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
    public partial class FRM_ROWMATERIALMASTER : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        MODULE function = new MODULE();
        BL_ROWMATERIALMASTER bl_obj = new BL_ROWMATERIALMASTER();

        public FRM_ROWMATERIALMASTER()
        {
            InitializeComponent();
        }

        private void FRM_ROWMATERIALMASTER_Load(object sender, EventArgs e)
        {
            try
            {
                function.settheme(this);
                optadd.Checked = true;
                DataSet ds = new DataSet();
                ds = bl_obj.select(bl_obj);
                FillLVW(ds);
                function.fillcombo(cmbMeasurement, ds.Tables[2]);
                function.fillcombo(cmbRowHeaderName, ds.Tables[1]);
            }
            catch (Exception err) { err.GetBaseException(); }
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;   // Do not resize the form.
        }

        private void FillLVW(DataSet ds)
        {
            try
            {
                lvw.Clear();
                List<ListViewColumnsInfo> list = new List<ListViewColumnsInfo>();
                list.Add(new ListViewColumnsInfo() { ColNumber = 6, ColumnSize = 120, Header = "Row Header", Visible = true });
                list.Add(new ListViewColumnsInfo() { ColNumber = 1, ColumnSize = 120, Header = "Material Name", Visible = true });
                list.Add(new ListViewColumnsInfo() { ColNumber = 5, ColumnSize = 120, Header = "Measurement", Visible = true });
                list.Add(new ListViewColumnsInfo() { ColNumber = 2, ColumnSize = 0, Header = "Material Type", Visible = true });                
                
                list.Add(new ListViewColumnsInfo() { ColNumber = 0, ColumnSize = 0, Header = "Row Material Id", Visible = true });
                list.Add(new ListViewColumnsInfo() { ColNumber = 3, ColumnSize = 0, Header = "Measurement Id", Visible = true });
                list.Add(new ListViewColumnsInfo() { ColNumber = 4, ColumnSize = 0, Header = "Row Header Id", Visible = true });
                function.filllvw(lvw, ds, list, ColumnHeaderStyle.Nonclickable, 0, 0);
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
                if (txtRowMaterialId.Text.Trim().Length <= 0)
                {
                    v = false;
                    msg += "Something Went Wrong";
                }

            if (flag == 'A' || flag == 'U')
                if (cmbRowHeaderName.SelectedIndex.Equals(0))
                {
                    v = false;
                    msg += "Select Row Header.  ";
                }
            if (flag == 'A' || flag == 'U')
                if (cmbMeasurement.SelectedIndex.Equals(0))
                {
                    v = false;
                    msg += "Select Measurement.  ";
                }
            if (flag == 'A' || flag == 'U')
                if (txtRowMaterialName.Text.Trim().Length <= 0)
                {
                    v = false;
                    msg += "Enter the Row Material Name.  ";
                }
            return v;
        }

        public void ClearControls()
        {
            txtRowMaterialName.Text = "";
            if (cmbMeasurement.Items.Count > 0)
                cmbMeasurement.SelectedIndex = 0;
            if (cmbRowHeaderName.Items.Count > 0)
                cmbRowHeaderName.SelectedIndex = 0;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string msg = "";
            try
            {
                if (optadd.Checked)
                {

                    if (Validate('A', out msg))
                    {
                        bl_obj.RowMaterialName = txtRowMaterialName.Text;
                        bl_obj.MeasurmentId = Convert.ToInt32(cmbMeasurement.SelectedValue);
                        bl_obj.RowHedarId = Convert.ToInt32(cmbRowHeaderName.SelectedValue);
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
                        bl_obj.RowMaterialId = Convert.ToInt32(txtRowMaterialId.Text.ToString());
                        bl_obj.RowMaterialName = txtRowMaterialName.Text;
                        bl_obj.MeasurmentId = Convert.ToInt32(cmbMeasurement.SelectedValue);
                        bl_obj.RowHedarId = Convert.ToInt32(cmbRowHeaderName.SelectedValue);
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
                                bl_obj.RowMaterialId = Convert.ToInt32(l.Tag.ToString());
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
            try
            {
                if (optadd.Checked == true)
                {
                    txtRowMaterialName.Focus();
                    ClearControls();
                    btnSubmit.Text = "Add";
                    btnSubmit.Enabled = true;
                    lvw.CheckBoxes = false;
                    optadd.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    btnSubmit.Enabled = false;
                    optadd.ForeColor = System.Drawing.Color.Black;
                }
            }
            catch (Exception err) { err.GetBaseException(); }
        }

        private void optupdate_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (optupdate.Checked == true)
                {
                    ClearControls();
                    txtRowMaterialName.Focus();
                    btnSubmit.Text = "Update";
                    btnSubmit.Enabled = true;
                    lvw.CheckBoxes = false;
                    optupdate.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    btnSubmit.Enabled = false;
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
                    txtRowMaterialName.Focus();
                    btnSubmit.Text = "Delete";
                    btnSubmit.Enabled = true;
                    lvw.CheckBoxes = true;
                    optdelete.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    btnSubmit.Enabled = false;
                    optdelete.ForeColor = System.Drawing.Color.Black;
                }
            }
            catch (Exception err) { err.GetBaseException(); }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
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
                        txtRowMaterialId.Text = l.Tag.ToString();
                        txtRowMaterialName.Text = l.SubItems[1].Text.ToString();
                        cmbMeasurement.SelectedValue = Convert.ToInt32(l.SubItems[5].Text);
                        cmbRowHeaderName.SelectedValue = Convert.ToInt32(l.SubItems[6].Text);
                    }
                    else
                    {
                        ClearControls();
                    }
                }
            }
            catch (Exception err)
            {
                err.GetBaseException();
            }
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            try
            {
                module_Rpt.rpt_name = "FRM_ROWMATERIALMASTER";
                Business_Report.Report_Viewer rpt = new Business_Report.Report_Viewer();
                rpt.Show();
            }
            catch (Exception err) { err.GetBaseException(); }
        }
    }
}