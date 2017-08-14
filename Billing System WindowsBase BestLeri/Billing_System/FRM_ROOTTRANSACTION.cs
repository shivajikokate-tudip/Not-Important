using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using BUSSINESS_LAYER;

namespace BILLING_SYSTEM
{
    public partial class FRM_ROOTTRANSACTION : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        MODULE function = new MODULE();
        BL_ROOTTRANSACTION bl_obj = new BL_ROOTTRANSACTION();

        public FRM_ROOTTRANSACTION()
        {
            InitializeComponent();
        }

        private void FillLVW(DataSet ds)
        {
            try
            {
                lvw.Clear();
                List<ListViewColumnsInfo> list = new List<ListViewColumnsInfo>();
                list.Add(new ListViewColumnsInfo() { ColNumber = 2, ColumnSize = 150, Header = "CustomerName", Visible = true });
                list.Add(new ListViewColumnsInfo() { ColNumber = 3, ColumnSize = 0, Header = "CustomerId", Visible = true });
                list.Add(new ListViewColumnsInfo() { ColNumber = 1, ColumnSize = 0, Header = "RootId", Visible = true });
                list.Add(new ListViewColumnsInfo() { ColNumber = 4, ColumnSize = 150, Header = "Position", Visible = true });

                list.Add(new ListViewColumnsInfo() { ColNumber = 0, ColumnSize = 0, Header = "RootTranId", Visible = true });
                function.filllvw(lvw, ds, list, ColumnHeaderStyle.Nonclickable, 0, 0);
            }
            catch (Exception err) { err.GetBaseException(); }
        }


        public void ClearControls()
        {
            
            if (cmbRootName.Items.Count > 0)
                cmbRootName.SelectedIndex = 0;
            if (cmbCustomer.Items.Count > 0)
                cmbCustomer.SelectedIndex = 0;

        }
        private void FRM_ROOTTRANSACTION_Load(object sender, EventArgs e)
        {
            function.settheme(this); 
            try
            {
                optadd.Checked = true;
                //FillLVW(bl_obj.SELECT(bl_obj));
                DataSet ds = new DataSet();
                ds = bl_obj.SELECT(bl_obj);
                function.fillcombo(cmbRootName, ds.Tables[1]);

                DataSet ds1 = new DataSet();
                ds1 = bl_obj.SELECT(bl_obj);
                function.fillcombo(cmbCustomer, ds1.Tables[2]);
            }
            catch (Exception err) { err.GetBaseException(); }
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;   // Do not resize the form.
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void optadd_CheckedChanged(object sender, EventArgs e)
        {
            if (optadd.Checked == true)
            {
                ClearControls();
                cmbRootName.Focus();
                btnsave.Text = "Add";
                btnsave.Enabled = true;
                lvw.CheckBoxes = false;
                optadd.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                btnsave.Enabled = false;
                optadd.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void optupdate_CheckedChanged(object sender, EventArgs e)
        {
            if (optupdate.Checked == true)
            {
                ClearControls();
                cmbRootName.Focus();
                btnsave.Text = "Update";
                btnsave.Enabled = true;
                lvw.CheckBoxes = false;
                optupdate.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                btnsave.Enabled = false;
                optupdate.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void optdelete_CheckedChanged(object sender, EventArgs e)
        {
            if (optdelete.Checked == true)
            {
                ClearControls();
                cmbRootName.Focus();
                btnsave.Text = "Delete";
                btnsave.Enabled = true;
                lvw.CheckBoxes = true;
                optdelete.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                btnsave.Enabled = false;
                optdelete.ForeColor = System.Drawing.Color.Black;
            }
        }

        public bool Validate(char flag, out string msg)
        {
            msg = "";
            bool v = true;
            if (flag == 'D')
            {
                if (lvw.CheckedItems.Count <= 0)
                    v = false;
            }

            if (flag == 'A' || flag == 'U')
                if (cmbRootName.SelectedIndex.Equals(0))
                {
                    v = false;
                    msg += "Select Root Name.  ";
                }

            if (flag == 'A' || flag == 'U')
                if (cmbCustomer.SelectedIndex.Equals(0))
                {
                    v = false;
                    msg += "Select Customer Name.  ";
                }

            return v;
        }

        private void lvw_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                if (optupdate.Checked)
                {
                    ListViewItem l = lvw.HitTest(e.Location).Item;
                    if (l != null)
                    {
                        bl_obj.RootTranId = Convert.ToInt32(l.Tag.ToString());
                        cmbRootName.SelectedValue = (Convert.ToInt32(l.SubItems[2].Text));
                        cmbCustomer.SelectedValue = (Convert.ToInt32(l.SubItems[1].Text));
                    }
                    else
                    {
                        ClearControls();
                    }
                }
            }
            catch (Exception err) { err.GetBaseException(); }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {

            string msg = ""; try
            {
                if (optadd.Checked)
                {
                    if (Validate('A', out msg))
                    {
                        bl_obj.RootId = Convert.ToInt32(cmbRootName.SelectedValue.ToString());
                        bl_obj.Customer_Id = Convert.ToInt32(cmbCustomer.SelectedValue.ToString());
                        FillLVW(bl_obj.INSERT(bl_obj));
                        ClearControls();
                        KryptonMessageBox.Show("Record Save Successfully", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MyMessageBox.ShowBox(msg);
                }
                else if (optupdate.Checked)
                {
                    if (Validate('U', out msg))
                    {

                        bl_obj.RootId = Convert.ToInt32(cmbRootName.SelectedValue);
                        bl_obj.Customer_Id = Convert.ToInt32(cmbCustomer.SelectedValue);
                        FillLVW(bl_obj.UPDATE(bl_obj));
                        ClearControls();
                        KryptonMessageBox.Show("Record Update Successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MyMessageBox.ShowBox(msg);
                }
                else if (optdelete.Checked)
                {
                    if (Validate('D', out msg))
                    {
                        if (KryptonMessageBox.Show("Do You Want To delete These record(s)?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            foreach (ListViewItem l in lvw.CheckedItems)
                            {
                                bl_obj.RootTranId = Convert.ToInt32(l.Tag.ToString());
                                bl_obj.DELETE(bl_obj);
                            }
                            FillLVW(bl_obj.SELECT(bl_obj));
                            ClearControls();
                            KryptonMessageBox.Show("Record(s) deleted Successfully", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                        MyMessageBox.ShowBox(msg);
                }
            }
            catch (Exception err) { err.GetBaseException(); }
        }

        private void lvw_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnUp_Click(object sender, EventArgs e)
        {          
            try
            {
                ListViewItem selected = lvw.SelectedItems[0];
                int indx = selected.Index;               
                lvw.Items.Remove(selected);
                lvw.Items.Insert(indx - 1, selected);
            }
            catch (Exception ee2)
            {
                KryptonMessageBox.Show("This is first position", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
          
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            ListViewItem selected = lvw.SelectedItems[0];
            try
            {
                
                int indx = selected.Index;
                lvw.Items.Remove(selected);
                lvw.Items.Insert(indx + 1, selected);
            }
            catch (Exception ee1)
            {
                lvw.Items.Insert(0, selected);
            }
        }

        private void cmbRootName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            bl_obj.RootId = Convert.ToInt32(cmbRootName.SelectedValue);
            bl_obj.SELECT1(bl_obj);

            FillLVW(bl_obj.SELECT1(bl_obj));
            //DataSet ds = new DataSet();
            //ds = bl_obj.SELECT1(bl_obj);
            //FillLVW(ds);           
        }

        private void kryptonPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSavePosition_Click(object sender, EventArgs e)
        {
            int a = 0;
            foreach (ListViewItem lm in lvw.Items)
            {
                a++;
                //ListViewItem l = lvw.HitTest(e.Location).Item;
                //string a = lm.SubItems[4].Text;
                    //lvw.Columns[4].Text;//lvw.Columns[0].
                bl_obj.RootTranId = Convert.ToInt32(lm.SubItems[4].Text);
                bl_obj.Position = a;
                bl_obj.UPDATE(bl_obj);
            }
            ClearControls();
            KryptonMessageBox.Show("Record Update Successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
              
    }
}