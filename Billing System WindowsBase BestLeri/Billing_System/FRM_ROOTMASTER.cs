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
    public partial class FRM_ROOTMASTER : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        MODULE function = new MODULE();
        BL_ROOTMASTER bl_obj = new BL_ROOTMASTER();

        public FRM_ROOTMASTER()
        {
            InitializeComponent();
        }


        private void FillLVW(DataSet ds)
        {
            try
            {
                lvw.Clear();
                List<ListViewColumnsInfo> list = new List<ListViewColumnsInfo>();
                list.Add(new ListViewColumnsInfo() { ColNumber = 2, ColumnSize = 200, Header = "SourceName", Visible = true });
                list.Add(new ListViewColumnsInfo() { ColNumber = 1, ColumnSize = 0, Header = "Source", Visible = true });
                list.Add(new ListViewColumnsInfo() { ColNumber = 4, ColumnSize = 200, Header = "Destination", Visible = true });
                list.Add(new ListViewColumnsInfo() { ColNumber = 3, ColumnSize = 0, Header = "Destination", Visible = true });
                list.Add(new ListViewColumnsInfo() { ColNumber = 0, ColumnSize = 0, Header = "Root Id", Visible = true });
                function.filllvw(lvw, ds, list, ColumnHeaderStyle.Nonclickable, 0, 0);
            }
            catch (Exception err) { err.GetBaseException(); }
        }

        private void FRM_ROOTMASTER_Load(object sender, EventArgs e)
        {
            function.settheme(this); try
            {
                optadd.Checked = true;
                FillLVW(bl_obj.select(bl_obj));
                DataSet ds = new DataSet();
                ds = bl_obj.select(bl_obj);
                function.fillcombo(cmbSource, ds.Tables[1]);

                //DataSet ds1 = new DataSet();
                //ds1 = bl_obj.select(bl_obj);
                //function.fillcombo(cmbDestination, ds1.Tables[1]);
            }
            catch (Exception err) { err.GetBaseException(); }
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;   // Do not resize the form.
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string msg = ""; try
            {
                if (optadd.Checked)
                {
                    if (Validate('A', out msg))
                    {
                        bl_obj.Source = Convert.ToInt32(cmbSource.SelectedValue.ToString());
                        bl_obj.Destination = Convert.ToInt32(cmbDestination.SelectedValue.ToString());
                        FillLVW(bl_obj.INSERT(bl_obj));
                        FillLVW(bl_obj.select(bl_obj));
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
                        bl_obj.Source = Convert.ToInt32(cmbSource.SelectedValue.ToString());
                        bl_obj.Destination = Convert.ToInt32(cmbDestination.SelectedValue.ToString());
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
                                bl_obj.RootId = Convert.ToInt32(l.Tag.ToString());
                                bl_obj.DELETE(bl_obj);
                            }
                            FillLVW(bl_obj.select(bl_obj));
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

        private void optadd_CheckedChanged(object sender, EventArgs e)
        {
            if (optadd.Checked == true)
            {
                cmbSource.Focus();
                ClearControls();
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

        public void ClearControls()
        {
            txtRoot.Text = "";
            if (cmbSource.Items.Count > 0)
                cmbSource.SelectedIndex = 0;
            if (cmbDestination.Items.Count > 0)
                cmbDestination.SelectedIndex = 0;

        }

        private void optupdate_CheckedChanged(object sender, EventArgs e)
        {

            if (optupdate.Checked == true)
            {
                ClearControls();
                cmbSource.Focus();
                btnsave.Text = "Update";
                btnsave.Enabled = true;
                lvw.CheckBoxes = false;
                optupdate.ForeColor = System.Drawing.Color.Red;
                //fillcombo();
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
                cmbSource.Focus();
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
                if (cmbSource.SelectedIndex.Equals(0))
                {
                    v = false;
                    msg += "Select Source Name.  ";
                }

            if (flag == 'A' || flag == 'U')
                if (cmbDestination.SelectedIndex.Equals(0))
                {
                    v = false;
                    msg += "Select Destination Name.  ";
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
                        bl_obj.RootId = Convert.ToInt32(l.Tag.ToString());
                       // txtRoot.Text = l.SubItems[3].Text.ToString();
                        cmbSource.SelectedValue= (Convert.ToInt32(l.SubItems[1].Text));
                        Fillcombobox();
                        cmbDestination.SelectedValue = (Convert.ToInt32(l.SubItems[3].Text));
                        txtRoot.Text = cmbSource.Text+" To "+ cmbDestination.Text;
                       // cmbDestination.SelectedIndex = (Convert.ToInt32(l.SubItems[3].Text));

                    }
                    else
                    {
                        ClearControls();
                    }
                }
            }
            catch (Exception err) { err.GetBaseException(); }
        }

        private void cmbDestination_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if((cmbSource.SelectedIndex>0)&&(cmbDestination.SelectedIndex>0))
                if (txtRoot.Text == lvw.Items.ToString())
                {
                    MessageBox.Show("All Ready exist");
                }
                else
                {
             txtRoot.Text = cmbSource.Text + " To " + cmbDestination.Text;
                }
        }

        private void btnSource_Click(object sender, EventArgs e)
        {
            FRM_SOURCEMASTER fs = new FRM_SOURCEMASTER();
            fs.Show();
        }

        private void cmbSource_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Fillcombobox();
        }

        private void Fillcombobox()
        {

            DataSet ds1 = new DataSet();
            bl_obj.SourceId = Convert.ToInt32(cmbSource.SelectedValue.ToString());
            ds1 = bl_obj.FindSource(bl_obj);

            function.fillcombo(cmbDestination, ds1.Tables[0]);
        }






        //private void fillcombo()
        //{
        //    DataSet ds = new DataSet();
        //    ds = bl_obj.select(bl_obj);
        //    function.fillcombo(cmbSource, ds.Tables[1]);

        //    DataSet ds1 = new DataSet();
        //    ds1 = bl_obj.select(bl_obj);
        //    function.fillcombo(cmbDestination, ds1.Tables[1]);

           
        //}

    }
}
