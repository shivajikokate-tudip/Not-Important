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
    public partial class FRM_ProductMaster : KryptonForm
    {
        MODULE function = new MODULE();
        BL_Product bl_obj = new BL_Product();

        public FRM_ProductMaster()
        {
            InitializeComponent();
        }

        private void FRM_ProductMaster_Load(object sender, EventArgs e)
        {
            function.settheme(this);
            FillLVW(bl_obj.SELECT(bl_obj));


        }

        private void FillLVW(DataSet ds)
        {
            List<string> col = new List<string>();
            List<string> col_Name = new List<string>();
            List<string> col_Size = new List<string>();
            col.Add("1");
            col_Name.Add("Name");
            col_Size.Add("100");
            function.filllvw(lvw, ds, col, col_Name,ColumnHeaderStyle.Clickable , 0, 0);
        }
        private void opt_CheckedChanged(object sender, EventArgs e)
        {
            if (optadd.Checked)
            {
                btnsave.Text = "Save";
                lvw.CheckBoxes = false;
                ClearControls();
            }
            else if (optupdate.Checked)
            {
                btnsave.Text = "Update";

                lvw.CheckBoxes = false;
                ClearControls();
            }
            else if (optdelete.Checked)
            {
                btnsave.Text = "Delete";
                lvw.CheckBoxes = true;
                ClearControls();
            }

        }

        private void optupdate_CheckedChanged(object sender, EventArgs e)
        {
            optadd.Checked = false;
            optdelete.Checked = false;

        }


        private void optdelete_CheckedChanged(object sender, EventArgs e)
        {
            optupdate.Checked = false;
            optadd.Checked = false;

        }

        public void ClearControls()
        {
            txtproductid.Text = "";
            txtproductname.Text = "";
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
                if (txtproductid.Text.Trim().Length <= 0)
                {
                    v = false;
                    msg += "Something Went Wrong";
                }
            if (flag == 'A' || flag == 'U')
                if (txtproductname.Text.Trim().Length <= 0)
                {
                    v = false;
                    msg += "Enter the Product Name";
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
                    bl_obj.ProductName = txtproductname.Text;
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
                    bl_obj.Product_Id = Convert.ToInt32(txtproductid.Text.ToString());
                    bl_obj.ProductName = txtproductname.Text;
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
                            bl_obj.Product_Id = Convert.ToInt32(l.Tag.ToString());
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

        private void lvw_MouseUp(object sender, MouseEventArgs e)
        {
            if (optupdate.Checked)
            {
                ListViewItem l = lvw.HitTest(e.Location).Item;
                if (l != null)
                {
                    txtproductid.Text = l.Tag.ToString();
                    txtproductname.Text = l.SubItems[0].Text.ToString();

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

    }
}