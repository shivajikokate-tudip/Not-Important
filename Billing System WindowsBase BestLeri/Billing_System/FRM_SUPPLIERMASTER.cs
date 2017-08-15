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
    public partial class FRM_SUPPLIERMASTER : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        MODULE function = new MODULE();
        BL_SUPPLIERMASTER bl_obj = new BL_SUPPLIERMASTER();
        BL blobj = new BL();

        public FRM_SUPPLIERMASTER()
        {
            InitializeComponent();
        }

        private void FillLVW(DataSet ds)
        {
            try
            {
                lvw.Clear();
                List<ListViewColumnsInfo> list = new List<ListViewColumnsInfo>();
                list.Add(new ListViewColumnsInfo() { ColNumber = 2, ColumnSize = 150, Header = "Supplier No", Visible = true });
                list.Add(new ListViewColumnsInfo() { ColNumber = 1, ColumnSize = 150, Header = "Comp Name", Visible = true });
                list.Add(new ListViewColumnsInfo() { ColNumber = 3, ColumnSize = 150, Header = "Address", Visible = true });
                list.Add(new ListViewColumnsInfo() { ColNumber = 4, ColumnSize = 100, Header = "Mb.No.", Visible = true });
                list.Add(new ListViewColumnsInfo() { ColNumber = 5, ColumnSize = 100, Header = "VatNo", Visible = true });
                list.Add(new ListViewColumnsInfo() { ColNumber = 6, ColumnSize = 100, Header = "TinNo", Visible = true });
                list.Add(new ListViewColumnsInfo() { ColNumber = 0, ColumnSize = 0, Header = "Supplier Id", Visible = true });
                function.filllvw(lvw, ds, list, ColumnHeaderStyle.Nonclickable, 0, 0);
            }
            catch (Exception err) { err.GetBaseException(); }
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
                        txtSupplierId.Text = l.Tag.ToString();
                        txtSupplierNo.Text = l.SubItems[0].Text.ToString();
                        txtSuplFirmName.Text = l.SubItems[1].Text.ToString();
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
        public void ClearControls()
        {
            txtSuplFirmName.Text = "";
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
                if (txtSupplierId.Text.Trim().Length <= 0)
                {
                    v = false;
                    msg += "Something Went Wrong.";
                }
            if (flag == 'A' || flag == 'U')
                if (txtSuplFirmName.Text.Trim().Length <= 0)
                {
                    v = false;
                    msg += "Enter the Supplier or Firm Name.  ";
                }
            if (flag == 'A' || flag == 'U')
                if (txtAddress.Text.Trim().Length <= 0)
                {
                    v = false;
                    msg += "Enter the Address.  ";
                }

            if (flag == 'A' || flag == 'U')
            {                
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
                }
            if (flag == 'A' || flag == 'U')
                if (txtTinNo.Text.Trim().Length <= 0)
                {
                    v = false;
                    msg += "Enter the Tin Number.  ";
                }
            return v;
        }
        private void FRM_SUPPLIERMASTER_Load(object sender, EventArgs e)
        {
            function.settheme(this);
            try
            {
                customerno();
                optadd.Checked = true;
                FillLVW(bl_obj.SELECT(bl_obj));
            }
            catch (Exception err) { err.GetBaseException(); }
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;   // Do not resize the form.
        }
        private void customerno()
        {
            try
            {
                DataSet ds = bl_obj.blFill("SP_SupplierMaster");
                txtSupplierNo.Text = ds.Tables[1].Rows[0][0].ToString();
            }
            catch (Exception err) { err.GetBaseException(); }
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                module_Rpt.rpt_name = "FRM_SUPPLIERMASTER";
                Business_Report.Report_Viewer rpt = new Business_Report.Report_Viewer();
                rpt.Show();
            }
            catch (Exception err) { err.GetBaseException(); }
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
                        //       BL bl=new BL(); 
                        //bl.Parameter.Add("@flag",txtAddress.Text); 

                        //bl_obj.Customer_Id = Convert.ToInt32(txtCustomerId.Text);
                        bl_obj.Comp_Name = txtSuplFirmName.Text;
                        bl_obj.Address = txtAddress.Text;
                        //bl_obj.Customer_No = Convert.ToInt32(txtCustomerNo.Text);
                        bl_obj.Supplier_Mobileno = txtMobileNo.Text;
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
                        bl_obj.Supplier_Id = Convert.ToInt32(txtSupplierId.Text);
                        bl_obj.Comp_Name = txtSuplFirmName.Text;
                        bl_obj.Address = txtAddress.Text;
                        //bl_obj.Customer_No = Convert.ToInt32(txtCustomerNo.Text);
                        bl_obj.Supplier_Mobileno = txtMobileNo.Text;
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
                                bl_obj.Supplier_Id = Convert.ToInt32(l.Tag.ToString());
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

        private void optadd_CheckedChanged(object sender, EventArgs e)
        {
            if (optadd.Checked == true)
            {
                txtSuplFirmName.Focus();
                ClearControls();
                txtSupplierId.Text = "";
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
                txtSuplFirmName.Focus();
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
                txtSuplFirmName.Focus();
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

        private void txtMobileNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            blobj.validateNumberNotFloat(e);
        }
    }
}