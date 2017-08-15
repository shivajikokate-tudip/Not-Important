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
    public partial class FRM_CUSTOMERMASTER : KryptonForm
    {
        MODULE function = new MODULE();
        BL_CUSTOMERMASTER bl_obj = new BL_CUSTOMERMASTER();
        BL blobj = new BL();
        
        public FRM_CUSTOMERMASTER()
        {
            InitializeComponent();
        }

        private void FillLVW(DataSet ds)
        {
            try
            {
                lvw.Clear();
                List<ListViewColumnsInfo> list = new List<ListViewColumnsInfo>();
                list.Add(new ListViewColumnsInfo() { ColNumber = 2, ColumnSize = 200, Header = "Customer No", Visible = true });
                list.Add(new ListViewColumnsInfo() { ColNumber = 1, ColumnSize = 200, Header = "Company Name", Visible = true });
                list.Add(new ListViewColumnsInfo() { ColNumber = 3, ColumnSize = 200, Header = "Address", Visible = true });
                list.Add(new ListViewColumnsInfo() { ColNumber = 4, ColumnSize = 200, Header = "Mb.No.", Visible = true });
                list.Add(new ListViewColumnsInfo() { ColNumber = 5, ColumnSize = 200, Header = "VatNo", Visible = true });
                list.Add(new ListViewColumnsInfo() { ColNumber = 6, ColumnSize = 200, Header = "TinNo", Visible = true });
                list.Add(new ListViewColumnsInfo() { ColNumber = 0, ColumnSize = 0, Header = "CustomerId", Visible = true });
                function.filllvw(lvw, ds, list, ColumnHeaderStyle.Nonclickable, 0, 0);
            }
            catch (Exception err) { err.GetBaseException(); }
        }

        public void ClearControls()
        {

            txtCustFirmName.Text = "";
            txtAddress.Text = "";
            txtMobileNo.Text = "";
            txtTinNo.Text = "";
            txtVatNo.Text = "";
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
                if (txtCustomerId.Text.Trim().Length <= 0)
                {
                    v = false;
                    msg += "Something Went Wrong.  ";
                }
            if (flag == 'A' || flag == 'U')
                if (txtCustFirmName.Text.Trim().Length <= 0)
                {
                    v = false;
                    msg += "Enter the Customer or Firm Name.  ";
                }
            if (flag == 'A' || flag == 'U')
                if (txtAddress.Text.Trim().Length <= 0)
                {
                    v = false;
                    msg += "Enter the Address.  ";
                }

            if (flag == 'A' || flag == 'U')
            {
                //Regex re = new Regex("[0-9]{9}");  //("^9[0-9]{9}") Starting from Mobile Number '9'

                //if (re.IsMatch(txtMobileNo.Text.Trim()) == false || txtMobileNo.Text.Length > 10)
                //{
                //    v = false;
                //    msg += "Invalid Mobile Number.  ";
                //    txtMobileNo.Focus();
                //}
                if (txtMobileNo.Text.Trim().Length != 10)
                {
                    v = false;
                    msg += "Invalid Mobile Number.  ";
                    txtMobileNo.Focus();
                }
            } 

            if (flag == 'A' || flag == 'U')
                if (txtVatNo.Text.Trim().Length <= 0)
                {
                    v = false;
                    msg += "Enter the Vat Number.  ";
                } if (flag == 'A' || flag == 'U')
                if (txtTinNo.Text.Trim().Length <= 0)
                {
                    v = false;
                    msg += "Enter the Tin Number.  ";
                }
            return v;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string msg = "";
                if (optadd.Checked)
                {

                    if (Validate('A', out msg))
                    {
                        //bl_obj.Customer_Id = Convert.ToInt32(txtCustomerId.Text);
                        bl_obj.Comp_Name = txtCustFirmName.Text;
                        bl_obj.Address = txtAddress.Text;
                        //bl_obj.Customer_No = Convert.ToInt32(txtCustomerNo.Text);
                        bl_obj.Cust_Mobileno = txtMobileNo.Text;
                        bl_obj.Tin_No = txtTinNo.Text;
                        bl_obj.Vat_No = txtVatNo.Text;

                        FillLVW(bl_obj.INSERT(bl_obj));
                        ClearControls();
                        KryptonMessageBox.Show("Record Save Successfilly", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MyMessageBox.ShowBox(msg);
                }
                else if (optedit.Checked)
                {
                    if (Validate('U', out msg))
                    {
                        bl_obj.Customer_Id = Convert.ToInt32(txtCustomerId.Text);
                        bl_obj.Comp_Name = txtCustFirmName.Text;
                        bl_obj.Address = txtAddress.Text;
                        //bl_obj.Customer_No = Convert.ToInt32(txtCustomerNo.Text);
                        bl_obj.Cust_Mobileno = txtMobileNo.Text;
                        bl_obj.Tin_No = txtTinNo.Text;
                        bl_obj.Vat_No = txtVatNo.Text;
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
                                //txtCustomerId.Text = l.Tag.ToString();
                                //l.Tag = txtCustomerId.Text;
                                bl_obj.Customer_Id = Convert.ToInt32(l.Tag.ToString());
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
                customerno();
            }
            catch (Exception err) { err.GetBaseException(); }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                module_Rpt.rpt_name = "FRM_CUSTOMERMASTER";
                Business_Report.Report_Viewer rpt = new Business_Report.Report_Viewer();
                rpt.Show();
            }
            catch (Exception err) { err.GetBaseException(); }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lvw_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                if (optedit.Checked)
                {
                    ListViewItem l = lvw.HitTest(e.Location).Item;
                    if (l != null)
                    {
                        txtCustomerId.Text = l.Tag.ToString();
                        txtCustomerNo.Text = l.SubItems[0].Text.ToString();
                        txtCustFirmName.Text = l.SubItems[1].Text.ToString();
                        txtAddress.Text = l.SubItems[2].Text.ToString();
                        txtMobileNo.Text = l.SubItems[3].Text.ToString();
                        txtVatNo.Text = l.SubItems[4].Text.ToString();
                        txtTinNo.Text = l.SubItems[5].Text.ToString();
                    }
                    else
                    {
                        ClearControls();
                    }
                }
            }
            catch (Exception err) { err.GetBaseException(); }
        }
        private void customerno()
        {
            try
            {
                DataSet ds = bl_obj.blFill("SP_CustomerMaster");
                txtCustomerNo.Text = ds.Tables[1].Rows[0][0].ToString();
            }
            catch (Exception err) { err.GetBaseException(); }
        }
        private void FRM_CUSTOMERMASTER_Load_1(object sender, EventArgs e)
        {
            try
            {
                function.settheme(this);
                customerno();
                //DataSet ds = bl_obj.blFill("SP_CustomerMaster");
                FillLVW(bl_obj.SELECT(bl_obj)); optadd.Checked = true;
                //FillLVW(ds);
                //DataSet ds = bl_obj.blFill("SP_CustomerMaster");
                //FillLVW(ds, 0);
                //txtCustomerNo.Text = ds.Tables[1].Rows[0][0].ToString();
            }
            catch (Exception err) { err.GetBaseException(); }
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;   // Do not resize the form.
        }

        private void optadd_CheckedChanged(object sender, EventArgs e)
        {
            if (optadd.Checked == true)
            {
                txtCustFirmName.Focus();
                ClearControls();
                txtCustomerId.Text = "";
                customerno();
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

        private void optedit_CheckedChanged(object sender, EventArgs e)
        {
            if (optedit.Checked == true)
            {
                ClearControls();
                txtCustFirmName.Focus();
                btnSubmit.Text = "Update";
                btnSubmit.Enabled = true;
                lvw.CheckBoxes = false;
                optedit.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                btnSubmit.Enabled = false;
                optedit.ForeColor = System.Drawing.Color.Black;
            }

        }

        private void optdelete_CheckedChanged(object sender, EventArgs e)
        {
            if (optdelete.Checked == true)
            {
                ClearControls();
                txtCustFirmName.Focus();
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

        private void txtVatNo_TextChanged(object sender, EventArgs e)
        {
            txtTinNo.Text = txtVatNo.Text;
        }

        private void txtTinNo_TextChanged(object sender, EventArgs e)
        {
          
        }

       

        private void txtMobileNo_KeyPress_1(object sender, KeyPressEventArgs e)
        {
           blobj.validateNumberNotFloat(e);  
            
        }

       

       
    }
}