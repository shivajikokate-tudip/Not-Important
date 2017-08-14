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
    public partial class FRM_SHOPMASTER : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        MODULE function = new MODULE();
        BL_SHOPMASTER bl_obj = new BL_SHOPMASTER();
        DataSet ds = new DataSet();

        public FRM_SHOPMASTER()
        {
            InitializeComponent();
        }

        private void FRM_SHOPMASTER_Load(object sender, EventArgs e)
        {
            fill_data();          
        }

        public void fill_data()
        {
            ds = (bl_obj.SELECT(bl_obj));
            txtShopName.Text = ds.Tables[0].Rows[0][1].ToString();
            txtShopAddress.Text = ds.Tables[0].Rows[0][2].ToString();
            txtContactNo.Text = ds.Tables[0].Rows[0][3].ToString();
            txtCGSTNo.Text = ds.Tables[0].Rows[0][4].ToString();
            txtSGSTNo.Text = ds.Tables[0].Rows[0][5].ToString();
            txtBankName.Text = ds.Tables[0].Rows[0][6].ToString();
            txtBankACNo.Text = ds.Tables[0].Rows[0][7].ToString();
            txtIFSCCode.Text = ds.Tables[0].Rows[0][8].ToString();
            txtPanNo.Text = ds.Tables[0].Rows[0][9].ToString();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string msg = "";
            if(Validate('U',out msg))
            {
                bl_obj.Shop_Id = 1;
                bl_obj.Shop_Name = txtShopName.Text;
                bl_obj.Shop_Address = txtShopAddress.Text;
                bl_obj.Shop_ContactNo= txtContactNo.Text;
                bl_obj.Shop_CGSTno = txtCGSTNo.Text;
                bl_obj.Shop_SGSTno = txtSGSTNo.Text;
                bl_obj.Bank_Name = txtBankName.Text;
                bl_obj.Bank_Accountno = txtBankACNo.Text;
                bl_obj.IFSCCode = txtIFSCCode.Text;
                bl_obj.PanNo = txtPanNo.Text;
                
                bl_obj.UPDATE(bl_obj);
                fill_data();
                ClearControls();
                KryptonMessageBox.Show("Record Update Successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
                MyMessageBox.ShowBox(msg);
        }
        public void ClearControls()
        {
            txtShopName.Clear();
            txtShopAddress.Clear();
            txtContactNo.Clear();
            txtCGSTNo.Clear();
            txtSGSTNo.Clear();
            txtBankName.Clear();
            txtBankACNo.Clear();
            txtIFSCCode.Clear();
            txtPanNo.Clear();
        }
        public bool Validate(char flag, out string msg)
        {
            msg = "";
            bool v = true;
            
            if (flag == 'A' || flag == 'U')
                if (txtShopName.Text.Trim().Length <= 0)
                {
                    v = false;
                    msg += "Enter the Shop Name";
                }
            if (flag == 'A' || flag == 'U')
                if (txtShopAddress.Text.Trim().Length <= 0)
                {
                    v = false;
                    msg += "Enter the Address";
                }
            if (flag == 'A' || flag == 'U')
                if (txtContactNo.Text.Trim().Length <= 0)
                {
                    v = false;
                    msg += "Enter the Mobile Number";
                }
            if (flag == 'A' || flag == 'U')
                if (txtCGSTNo.Text.Trim().Length <= 0)
                {
                    v = false;
                    msg += "Enter CGST NO.";
                }
            if (flag == 'A' || flag == 'U')
                if (txtSGSTNo.Text.Trim().Length <= 0)
                {
                    v = false;
                    msg += "Enter the SGST NO.";
                }
            if (flag == 'A' || flag == 'U')
                if (txtBankName.Text.Trim().Length <= 0)
                {
                    v = false;
                    msg += "Enter the Bank Name.";
                }
            if (flag == 'A' || flag == 'U')
                if (txtBankACNo.Text.Trim().Length <= 0)
                {
                    v = false;
                    msg += "Enter Account NO.";
                }
            if (flag == 'A' || flag == 'U')
                if (txtIFSCCode.Text.Trim().Length <= 0)
                {
                    v = false;
                    msg += "Enter the IFSC Code.";
                }
            if (flag == 'A' || flag == 'U')
                if (txtPanNo.Text.Trim().Length <= 0)
                {
                    v = false;
                    msg += "Enter the Pan Number";
                }
            return v;
        }
    }
}