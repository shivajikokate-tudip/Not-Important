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
    public partial class FRM_ROWMATERIAL : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        MODULE function = new MODULE();
        BL_ROWMATERIAL bl_obj = new BL_ROWMATERIAL();

        public FRM_ROWMATERIAL()
        {
            InitializeComponent();
        }

        private void FRM_ROWMATERIAL_Load(object sender, EventArgs e)
        {
            try
            {
                function.settheme(this);
                optAdd.Checked = true;
                DataSet ds = new DataSet();
                ds = bl_obj.select(bl_obj);
                FillLVW(ds);
            }
            catch (Exception err) { err.GetBaseException(); }
        }

        private void FillLVW(DataSet ds)
        {
            try
            {
                lvw.Clear();
                List<ListViewColumnsInfo> list = new List<ListViewColumnsInfo>();
                list.Add(new ListViewColumnsInfo() { ColNumber = 1, ColumnSize = 200, Header = "RowHedar Name", Visible = true });
                list.Add(new ListViewColumnsInfo() { ColNumber = 0, ColumnSize = 0, Header = "RowHedar Id", Visible = true });
                function.filllvw(lvw, ds, list, ColumnHeaderStyle.Nonclickable, 0, 0);
            }
            catch (Exception err) { err.GetBaseException(); }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string msg = "";
                if (optAdd.Checked)
                {

                    if (Validate('A', out msg))
                    {
                        bl_obj.RowHedarName = txtRawMaterial.Text;
                        FillLVW(bl_obj.INSERT(bl_obj));
                        ClearControls();
                        KryptonMessageBox.Show("Record Save Successfilly", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MyMessageBox.ShowBox(msg);
                }
                else if (optEdit.Checked)
                {
                    if (Validate('U', out msg))
                    {
                        bl_obj.RowHedarId = Convert.ToInt32(txtRowMaterialId.Text.ToString());
                        bl_obj.RowHedarName = txtRawMaterial.Text;
                        FillLVW(bl_obj.UPDATE(bl_obj));
                        ClearControls();
                        KryptonMessageBox.Show("Record Update Successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MyMessageBox.ShowBox(msg);
                }
                else if (optDelete.Checked)
                {
                    if (Validate('D', out msg))
                    {
                        if (KryptonMessageBox.Show("Do You Want To delete These record(s)?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            foreach (ListViewItem l in lvw.CheckedItems)
                            {
                                bl_obj.RowHedarId = Convert.ToInt32(l.Tag.ToString());
                                bl_obj.DELETE(bl_obj);
                            }
                            FillLVW(bl_obj.select(bl_obj));
                            ClearControls();
                            KryptonMessageBox.Show("Record(s) deleted Successfully", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                        MyMessageBox.ShowBox(msg);
                } optAdd.Checked = true;
            }
            catch (Exception err) { err.GetBaseException(); }
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void optAdd_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (optAdd.Checked == true)
                {
                    txtRawMaterial.Focus();
                    ClearControls();
                    btnSubmit.Text = "Add";
                    btnSubmit.Enabled = true;
                    lvw.CheckBoxes = false;
                    optAdd.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    btnSubmit.Enabled = false;
                    optAdd.ForeColor = System.Drawing.Color.Black;
                }
            }
            catch (Exception err) { err.GetBaseException(); }
        }

        public void ClearControls()
        {
            txtRowMaterialId.Text = "";
            txtRawMaterial.Text = "";
        }

        private void optEdit_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (optEdit.Checked == true)
                {
                    ClearControls();
                    txtRawMaterial.Focus();
                    btnSubmit.Text = "Update";
                    btnSubmit.Enabled = true;
                    lvw.CheckBoxes = false;
                    optEdit.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    btnSubmit.Enabled = false;
                    optEdit.ForeColor = System.Drawing.Color.Black;
                }
            }
            catch (Exception err) { err.GetBaseException(); }
        }

        private void optDelete_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (optDelete.Checked == true)
                {
                    ClearControls();
                    txtRawMaterial.Focus();
                    btnSubmit.Text = "Delete";
                    btnSubmit.Enabled = true;
                    lvw.CheckBoxes = true;
                    optDelete.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    btnSubmit.Enabled = false;
                    optDelete.ForeColor = System.Drawing.Color.Black;
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
                if (txtRowMaterialId.Text.Trim().Length <= 0)
                {
                    v = false;
                    msg += "Something Went Wrong";
                }
            if (flag == 'A' || flag == 'U')
                if (txtRawMaterial.Text.Trim().Length <= 0)
                {
                    v = false;
                    msg += "Enter the Row Hedar Name";
                }
            return v;
        }

        private void lvw_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                if (optEdit.Checked)
                {
                    ListViewItem l = lvw.HitTest(e.Location).Item;
                    if (l != null)
                    {
                        txtRowMaterialId.Text = l.Tag.ToString();
                        txtRawMaterial.Text = l.SubItems[0].Text.ToString();
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
                module_Rpt.rpt_name = "FRM_ROWMATERIAL";
                Business_Report.Report_Viewer rpt = new Business_Report.Report_Viewer();
                rpt.Show();
            }
            catch (Exception err)
            {
                err.GetBaseException();
            }
        }
    }
}