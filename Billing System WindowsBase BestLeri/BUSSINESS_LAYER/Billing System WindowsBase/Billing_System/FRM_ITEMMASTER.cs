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
            function.settheme(this);
            FillLVW(bl_obj.select(bl_obj));
        }

        private void FillLVW(DataSet ds)
        {            
            List<string> col = new List<string>();
            List<string> col_Name = new List<string>();
            List<string> col_Size = new List<string>();
            col.Add("1");
            col_Name.Add("ITEM NAME");
            col_Size.Add("100");
            function.filllvw(lvw, ds, col, col_Name, 0, 0, 0);            
        }

        private void optadd_CheckedChanged(object sender, EventArgs e)
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

        public void ClearControls()
        {
            txtItemid.Text = "";
            txtItemName.Text = "";
        }

        private void optupdate_CheckedChanged(object sender, EventArgs e)
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

        private void optdelete_CheckedChanged(object sender, EventArgs e)
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
                if (txtItemName.Text.Trim().Length <= 0)
                {
                    v = false;
                    msg += "Enter the Item Name";
                }
            return v;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string msg = "";
            if (optadd.Checked)
            {

                if (Validate('A', out msg))
                {
                    bl_obj.ItemName = txtItemName.Text;
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
            }
        }

        private void lvw_MouseUp(object sender, MouseEventArgs e)
        {
            if (optupdate.Checked)
            {
                ListViewItem l = lvw.HitTest(e.Location).Item;
                if (l != null)
                {
                    txtItemid.Text = l.Tag.ToString();
                    txtItemName.Text = l.SubItems[0].Text.ToString();

                }
                else
                {
                    ClearControls();
                }
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            module_Rpt.rpt_name = "FRM_ITEMMASTER";
            Business_Report.Report_Viewer rpt = new Business_Report.Report_Viewer();
            rpt.Show();
        }
    }
}