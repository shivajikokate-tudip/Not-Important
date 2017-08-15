using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using BUSSINESS_LAYER;
using System.Text.RegularExpressions;

namespace BILLING_SYSTEM
{
    public partial class FRM_TRANSPORTATION_MASTER : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        MODULE function = new MODULE();
        BL_TRANSPORTATION_MASTER bl_obj = new BL_TRANSPORTATION_MASTER();
        BL blobj = new BL();

        public FRM_TRANSPORTATION_MASTER()
        {
            InitializeComponent();
        }

        private void FillLVW(DataSet ds)
        {          
            try
            {
                lvw.Clear();
                List<ListViewColumnsInfo> list = new List<ListViewColumnsInfo>();
                list.Add(new ListViewColumnsInfo() { ColNumber = 1, ColumnSize = 150, Header = "Transporatation Name", Visible = true });
                list.Add(new ListViewColumnsInfo() { ColNumber = 2, ColumnSize = 150, Header = "Address", Visible = true });
                list.Add(new ListViewColumnsInfo() { ColNumber = 3, ColumnSize = 150, Header = "Mb.No.", Visible = true });
                list.Add(new ListViewColumnsInfo() { ColNumber = 0, ColumnSize = 0, Header = "Transporation Id", Visible = true });
                function.filllvw(lvw, ds, list, ColumnHeaderStyle.Nonclickable, 0, 0);
            }
            catch (Exception err) { err.GetBaseException(); }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string msg = "";
            if (optadd.Checked)
            {

                if (Validate('A', out msg))
                {
                    bl_obj.TransportationName = txtTransportationName.Text;
                    bl_obj.Transportation_Address = txtAddress.Text;
                    bl_obj.Transportation_Number = txtMobileNo.Text;
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
                    bl_obj.TranspotationId = Convert.ToInt32(txtTranspotationId.Text.ToString());
                    bl_obj.TransportationName = txtTransportationName.Text;
                    bl_obj.Transportation_Address = txtAddress.Text;
                    bl_obj.Transportation_Number = txtMobileNo.Text;
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
                            bl_obj.TranspotationId = Convert.ToInt32(l.Tag.ToString());
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

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRM_TRANSPORTATION_MASTER_Load(object sender, EventArgs e)
        {
            function.settheme(this);
            FillLVW(bl_obj.select(bl_obj));
            optadd.Checked = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;   // Do not resize the form.
        }

        private void optadd_CheckedChanged(object sender, EventArgs e)
        {

            if (optadd.Checked == true)
            {
                txtTransportationName.Focus();
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

        private void optupdate_CheckedChanged(object sender, EventArgs e)
        {
            if (optupdate.Checked == true)
            {
                ClearControls();
                txtTransportationName.Focus();
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
                txtTransportationName.Focus();
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
                if (txtTranspotationId.Text.Trim().Length <= 0)
                {
                    v = false;
                    msg += "Something Went Wrong. ";
                }
            if (flag == 'A' || flag == 'U')
                if (txtTransportationName.Text.Trim().Length <= 0)
                {
                    v = false;
                    msg += "Enter the Transportation Name.  ";
                }


            if (flag == 'A' || flag == 'U')
                if (txtAddress.Text.Trim().Length <= 0)
                {
                    v = false;
                    msg += "Enter Transport Address.  ";
                }


            if (flag == 'A' || flag == 'U')
            {
                //Regex re = new Regex("[0-9]{9}");  //("^9[0-9]{9}") Starting from Mobile Number '9'

                //if (re.IsMatch(txtMobileNo.Text.Trim()) == false || txtMobileNo.Text.Length > 10)
                //{
                //    v = false;
                //    msg += "Invalid Mobile Number";
                //    txtMobileNo.Focus();
                //}
                if (txtMobileNo.Text.Trim().Length != 10)
                {
                    v = false;
                    msg += "Invalid Mobile Number.  ";
                    txtMobileNo.Focus();
                }
            }  
            return v;
        }

        public void ClearControls()
        {
            txtTranspotationId.Text = "";
            txtTransportationName.Text = "";
            txtAddress.Text = "";
            txtMobileNo.Text = "";
        }

        private void lvw_MouseUp(object sender, MouseEventArgs e)
        {
            if (optupdate.Checked)
            {
                ListViewItem l = lvw.HitTest(e.Location).Item;
                if (l != null)
                {
                    txtTranspotationId.Text = l.Tag.ToString();
                    txtTransportationName.Text = l.SubItems[0].Text.ToString();
                    txtAddress.Text = l.SubItems[1].Text.ToString();
                    txtMobileNo.Text = l.SubItems[2].Text.ToString();

                }
                else
                {
                    ClearControls();
                }
            }
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            try
            {
                module_Rpt.rpt_name = "FRM_TRANSPORTATION_MASTER";
                Business_Report.Report_Viewer rpt = new Business_Report.Report_Viewer();
                rpt.Show();
            }
            catch (Exception err) { err.GetBaseException(); }
        }

        private void txtMobileNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            blobj.validateNumberNotFloat(e);
        }
    }
}