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
    public partial class FRM_MEASUREMENTMASTER : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        MODULE function = new MODULE();
        BL_MEASUREMENTMASTER bl_obj = new BL_MEASUREMENTMASTER();

        public FRM_MEASUREMENTMASTER()
        {
            InitializeComponent();
        }

        private void FillLVW(DataSet ds)
        {            
            try
            {
                lvw.Clear();
                List<ListViewColumnsInfo> list = new List<ListViewColumnsInfo>();
                list.Add(new ListViewColumnsInfo() { ColNumber = 1, ColumnSize = 150, Header = "Measurement Name", Visible = true });
                list.Add(new ListViewColumnsInfo() { ColNumber = 0, ColumnSize = 0, Header = "Measurement Id", Visible = true });
                function.filllvw(lvw, ds, list, ColumnHeaderStyle.Nonclickable, 0, 0);
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
                        bl_obj.MeasurementName = txtMeasurementName.Text;
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
                        bl_obj.MeasurementId = Convert.ToInt32(txtMeasurementId.Text.ToString());
                        bl_obj.MeasurementName = txtMeasurementName.Text;
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
                                bl_obj.MeasurementId = Convert.ToInt32(l.Tag.ToString());
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

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRM_MEASUREMENTMASTER_Load(object sender, EventArgs e)
        {
            function.settheme(this); try
            {
                optadd.Checked = true;
                FillLVW(bl_obj.select(bl_obj));
            }
            catch (Exception err) { err.GetBaseException(); }
        }

        private void optadd_CheckedChanged(object sender, EventArgs e)
        {

            if (optadd.Checked == true)
            {
                txtMeasurementName.Focus();
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
            txtMeasurementId.Text = "";
            txtMeasurementName.Text = "";
        }

        private void optupdate_CheckedChanged(object sender, EventArgs e)
        {
            if (optupdate.Checked == true)
            {
                ClearControls();
                txtMeasurementName.Focus();
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
                txtMeasurementName.Focus();
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
            if (flag == 'U')
                if (txtMeasurementId.Text.Trim().Length <= 0)
                {
                    v = false;
                    msg += "Something Went Wrong";
                }
            if (flag == 'A' || flag == 'U')
                if (txtMeasurementName.Text.Trim().Length <= 0)
                {
                    v = false;
                    msg += "Enter the Measurement Name";
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
                        txtMeasurementId.Text = l.Tag.ToString();
                        txtMeasurementName.Text = l.SubItems[0].Text.ToString();

                    }
                    else
                    {
                        ClearControls();
                    }
                }
            }
            catch (Exception err) { err.GetBaseException(); }
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            try
            {
                module_Rpt.rpt_name = "FRM_MEASUREMENTMASTER";
                Business_Report.Report_Viewer rpt = new Business_Report.Report_Viewer();
                rpt.Show();
            }
            catch (Exception err) { err.GetBaseException(); }
        }
    }
}