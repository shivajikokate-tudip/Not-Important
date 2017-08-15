using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using BUSSINESS_LAYER;
using Business_Report;

namespace BILLING_SYSTEM
{
    public partial class FRM_ITEMMASTER : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        MODULE function = new MODULE();
        BL_ITEMMASTER bl_obj = new BL_ITEMMASTER();

        public FRM_ITEMMASTER()
        {
            InitializeComponent();
        }

        private void FRM_ITEMMASTER_Load(object sender, EventArgs e)
        {
            try
            {
                function.settheme(this); optadd.Checked = true;
                DataSet ds = new DataSet();
                ds = bl_obj.select(bl_obj);
                FillLVW(ds);
                function.fillcombo(cmbMeasurment, ds.Tables[1]);
            }
            catch (Exception err) { err.GetBaseException(); }
            //this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;   // Do not resize the form.
        }

        private void FillLVW(DataSet ds)
        {
            try
            {
                lvw.Clear();
                List<ListViewColumnsInfo> list = new List<ListViewColumnsInfo>();
                list.Add(new ListViewColumnsInfo() { ColNumber = 1, ColumnSize = 150, Header = "Item Name", Visible = true });
                list.Add(new ListViewColumnsInfo() { ColNumber = 3, ColumnSize = 150, Header = "Measurment Name", Visible = true });
                list.Add(new ListViewColumnsInfo() { ColNumber = 0, ColumnSize = 0, Header = "Item Id", Visible = true });
                list.Add(new ListViewColumnsInfo() { ColNumber = 2, ColumnSize = 0, Header = "Measurment Id", Visible = true });
                list.Add(new ListViewColumnsInfo() { ColNumber = 4, ColumnSize = 0, Header = "PFLAG", Visible = true });
                function.filllvw(lvw, ds, list, ColumnHeaderStyle.Nonclickable, 0, 0);
            }
            catch (Exception err) { err.GetBaseException(); }
        }

        private void optadd_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (optadd.Checked == true)
                {
                    txtItemName.Focus();
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
            catch (Exception err) { err.GetBaseException(); }
        }

        public void ClearControls()
        {
            txtItemid.Text = "";
            txtItemName.Text = "";
            if (cmbMeasurment.Items.Count > 0)
                cmbMeasurment.SelectedIndex = 0;

        }

        private void optupdate_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (optupdate.Checked == true)
                {
                    ClearControls();
                    txtItemName.Focus();
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
            catch (Exception err) { err.GetBaseException(); }
        }

        private void optdelete_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (optdelete.Checked == true)
                {
                    ClearControls();
                    txtItemName.Focus();
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
            catch (Exception err) { err.GetBaseException(); }
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
            if (flag == 'U')
                if (txtItemid.Text.Trim().Length <= 0)
                {
                    v = false;
                    msg += "Something Went Wrong";
                }

            if (flag == 'A' || flag == 'U')
                if (cmbMeasurment.SelectedIndex.Equals(0))
                {
                    v = false;
                    msg += "Select Measurement.  ";
                }

            if (flag == 'A' || flag == 'U')
                if (txtItemName.Text.Trim().Length <= 0)
                {
                    v = false;
                    msg += "Enter the Item Name";
                }            
            return v;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (optWithProcess.Checked)
                {
                    bl_obj.PFlag = "P";
                }
                if (optWithoutProcess.Checked)
                {
                    bl_obj.PFlag = "D";
                }
                string msg = "";
                if (optadd.Checked)
                {                   
                    if (Validate('A', out msg))
                    {
                        bl_obj.ItemName = txtItemName.Text;
                        bl_obj.MeasurmentId = Convert.ToInt32(cmbMeasurment.SelectedValue);                        
                        FillLVW(bl_obj.INSERT(bl_obj));
                        ClearControls();
                        KryptonMessageBox.Show("Record Save Successfilly", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MyMessageBox.ShowBox(msg);
                }
                else if (optupdate.Checked)
                {
                    if (Validate('U', out msg))
                    {
                        bl_obj.ItemId = Convert.ToInt32(txtItemid.Text.ToString());
                        bl_obj.ItemName = txtItemName.Text;
                        bl_obj.MeasurmentId = Convert.ToInt32(cmbMeasurment.SelectedValue);
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
                                bl_obj.ItemId = Convert.ToInt32(l.Tag.ToString());
                                bl_obj.DELETE(bl_obj);
                            }
                            FillLVW(bl_obj.select(bl_obj));
                            ClearControls();
                            KryptonMessageBox.Show("Record(s) deleted Successfully", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                        MyMessageBox.ShowBox(msg);
                } optadd.Checked = true;
            }
            catch (Exception err) { err.GetBaseException(); }
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
                        txtItemid.Text = l.Tag.ToString();
                        txtItemName.Text = l.SubItems[0].Text.ToString();
                        cmbMeasurment.SelectedValue = (Convert.ToInt32(l.SubItems[3].Text));
                        if (l.SubItems[4].Text == "P") 
                        {
                            optWithProcess.Checked=true;
                        }
                        if (l.SubItems[4].Text == "D")
                        {
                            optWithoutProcess.Checked = true;
                        }
                    }
                    else
                    {
                        ClearControls();
                    }
                }
            }
            catch (Exception err) { err.GetBaseException(); }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            try
            {
                module_Rpt.rpt_name = "FRM_ITEMMASTER";
                Business_Report.Report_Viewer rpt = new Business_Report.Report_Viewer();
                rpt.Show();
            }
            catch (Exception err) { err.GetBaseException(); }
        }
    }
}