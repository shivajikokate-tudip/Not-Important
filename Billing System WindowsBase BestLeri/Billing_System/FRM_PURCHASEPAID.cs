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
    public partial class FRM_PURCHASEPAID : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        MODULE function = new MODULE();
        BL_PURCHASEPAID bl_obj = new BL_PURCHASEPAID();
        double NotApproved, paid, Total = 0;
        List<string> ParaName = new List<string>();
        List<string> Para = new List<string>();
        DataSet ds = new DataSet();
        string Voucher_ID = string.Empty;
        public FRM_PURCHASEPAID()
        {
            InitializeComponent();
        }

        private void GetVoucherNo(DataTable dt)
        {
            if (dt.Rows.Count > 0)
            {
                Voucher_ID = dt.Rows[0][0].ToString();
                txtInvoiceNo.Text = "PI" + Voucher_ID;
            }
            else
            {
                DataSet ds = (bl_obj.SELECT(bl_obj));
                Voucher_ID = ds.Tables[4].Rows[0][0].ToString();
                txtInvoiceNo.Text = "PI" + Voucher_ID;
            }
        }
        private void FRM_PURCHASEPAID_Load(object sender, EventArgs e)
        {
            function.settheme(this);
            filldata();
            rbadd.Checked = true;
        }

        private void filldata()
        {
            try
            {
                
                ds = (bl_obj.SELECT(bl_obj));
                function.fillcombo(cmdName, ds.Tables[1]);
                function.fillcombo(cmbPayMode, ds.Tables[2]);
                function.fillcombo(cmbAccount, ds.Tables[3]);
                FillLVW(ds);
                dtpDate.Value = Convert.ToDateTime(DateTime.Now.ToString());
                GetVoucherNo(ds.Tables[4]);  
            }
            catch (Exception err) { err.GetBaseException(); }
        }

        private void FillLVW(DataSet ds)
        {
            try
            {
                lvw.Clear();
                List<ListViewColumnsInfo> list = new List<ListViewColumnsInfo>();

                list.Add(new ListViewColumnsInfo() { ColNumber = 1, ColumnSize = 120, Header = "Company Name", Visible = true });
                list.Add(new ListViewColumnsInfo() { ColNumber = 3, ColumnSize = 120, Header = "Invoice No.", Visible = true });
                list.Add(new ListViewColumnsInfo() { ColNumber = 4, ColumnSize = 120, Header = "On Credit", Visible = true });
                list.Add(new ListViewColumnsInfo() { ColNumber = 0, ColumnSize = 0, Header = "Customer Id", Visible = true });
                list.Add(new ListViewColumnsInfo() { ColNumber = 2, ColumnSize = 0, Header = "Purchase Id", Visible = true });
                function.filllvw(lvw, ds, list, ColumnHeaderStyle.Nonclickable, 0, 0);
            }
            catch (Exception err) { err.GetBaseException(); }
            double TotalPending = 0;
            foreach (ListViewItem lm in lvw.Items)
            {
                TotalPending = TotalPending + Convert.ToDouble(lm.SubItems[2].Text.Trim());
            }
            txtPendingAmount.Text = TotalPending.ToString();
        }
        private void lvw_MouseUp(object sender, MouseEventArgs e)
        {
            //if (optedit.Checked)
            //{
            try
            {
                //ListViewItem l = lvw.HitTest(e.Location).Item;
                //if (l != null)
                //{
                //    //txtSalesRecoveryId.Text = l.Tag.ToString();
                //    txtAmount.Enabled = true; dtpDate.Enabled = true;
                //    cmdName.SelectedIndex = cmdName.FindString(l.SubItems[0].Text.ToString());
                //    txtInvoiceNo.Text = l.SubItems[1].Text.ToString();
                //    //txtAmount.Text = l.SubItems[2].Text.ToString();
                //    txtSalesRecoveryId.Text = l.SubItems[4].Text.ToString();
                //    Calculate();
                //}
                //else
                //{
                //    ClearControls();
                //}
                ////}    
            }
            catch (Exception err) { err.GetBaseException(); }
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string msg = "";
            //if (optadd.Checked)
            //{
            try
            {
                double EnteredAmount = Convert.ToDouble((txtAmount.Text.Trim().CompareTo("") != 0 ? txtAmount.Text.Trim() : "0"));
                double PaidAmount = 0;
                if (Validate('A', out msg))
                {
                    int i = 0;
                    if (lvw.Items.Count > 0)
                    {
                        foreach (ListViewItem lm in lvw.Items)
                        {
                            if (EnteredAmount > 0)
                            {
                                //bl_obj.SalesRecoveryId = Convert.ToInt32(txtSalesRecoveryId.Text);      
                                bl_obj.Purchase_Id = Convert.ToInt32(lm.SubItems[4].Text);
                                if (Convert.ToDouble(lm.SubItems[2].Text.Trim()) < EnteredAmount)
                                {
                                    bl_obj.Amount = Convert.ToDouble(lm.SubItems[2].Text.Trim());
                                    PaidAmount = Convert.ToDouble(lm.SubItems[2].Text.Trim());
                                }
                                else if (Convert.ToDouble(lm.SubItems[2].Text.Trim()) == EnteredAmount)
                                {
                                    bl_obj.Amount = Convert.ToDouble(lm.SubItems[2].Text.Trim());
                                    PaidAmount = Convert.ToDouble(lm.SubItems[2].Text.Trim());
                                }
                                else
                                {
                                    bl_obj.Amount = Convert.ToDouble(EnteredAmount);
                                    PaidAmount = Convert.ToDouble(EnteredAmount);
                                }
                                //bl_obj.Amount = Convert.ToDouble(lm.SubItems[2].Text);
                                bl_obj.Tran_Date = dtpDate.Value.ToString("yyyy-MM-dd");
                                //FillLVW(bl_obj.INSERT(bl_obj));
                                DataSet ds1 = bl_obj.INSERT(bl_obj);
                                
                                ParaName.Clear();
                                Para.Clear();
                                ParaName.Add("@Cust_ID");
                                ParaName.Add("@To_Acc");
                                ParaName.Add("@Day_Cash");
                                ParaName.Add("@Paid_Cash");
                                ParaName.Add("@Pay_Mode_Id");
                                ParaName.Add("@Description");
                                ParaName.Add("@Tran_Type");
                                ParaName.Add("@Cust_Type");
                                ParaName.Add("@User_ID");
                                ParaName.Add("@Flag");
                                ParaName.Add("@Tran_Number");
                                ParaName.Add("@Tran_Date");
                                ParaName.Add("@Voucher_No");

                                Para.Add(cmdName.SelectedValue.ToString());
                                Para.Add(cmbAccount.SelectedIndex == 0 ? "0" : cmbAccount.SelectedValue.ToString());
                                
                                Para.Add(i == 0 ? txtAmount.Text.Trim() : "0");
                                if (Convert.ToDouble(lm.SubItems[2].Text.Trim()) < EnteredAmount)
                                    Para.Add(lm.SubItems[2].Text.Trim());
                                else if (Convert.ToDouble(lm.SubItems[2].Text.Trim()) == EnteredAmount)
                                    Para.Add(lm.SubItems[2].Text.Trim());
                                else
                                    Para.Add(EnteredAmount.ToString());

                                
                                Para.Add(cmbPayMode.SelectedIndex==0 ? "0" : cmbPayMode.SelectedValue.ToString());
                                Para.Add(txtDescription.Text.Trim());
                                Para.Add("VP");
                                Para.Add("S");
                                Para.Add(MODULE.glb["SHOP_ID"].ToString());
                                Para.Add("A");
                                Para.Add(lm.SubItems[4].Text);
                                Para.Add(dtpDate.Value.ToString("yyyy-MM-dd"));
                                Para.Add(Voucher_ID);//For Voucher Number
                                bl_obj.blFill_para_name(ParaName, Para, "sp_Payment_Transaction_Details");
                                EnteredAmount = EnteredAmount - PaidAmount;
                                i++;
                            }
                        }
                    }
                    //else
                    //{
                        if (EnteredAmount != 0)
                        {
                            ParaName.Clear();
                            Para.Clear();
                            ParaName.Add("@Cust_ID");
                            ParaName.Add("@To_Acc");
                            ParaName.Add("@Day_Cash");
                            ParaName.Add("@Paid_Cash");
                            ParaName.Add("@Pay_Mode_Id");
                            ParaName.Add("@Description");
                            ParaName.Add("@Tran_Type");
                            ParaName.Add("@Cust_Type");
                            ParaName.Add("@User_ID");
                            ParaName.Add("@Flag");
                            ParaName.Add("@Tran_Number");
                            ParaName.Add("@Tran_Date");
                            ParaName.Add("@Voucher_No");

                            Para.Add(cmdName.SelectedValue.ToString());
                            Para.Add(cmbAccount.SelectedIndex == 0 ? "0" : cmbAccount.SelectedValue.ToString());
                            
                            
                            Para.Add("0");
                            Para.Add(EnteredAmount.ToString());
                            Para.Add(cmbPayMode.SelectedIndex == 0 ? "0" : cmbPayMode.SelectedValue.ToString());
                            Para.Add(txtDescription.Text.Trim());
                            Para.Add("VP");
                            Para.Add("S");
                            Para.Add(MODULE.glb["SHOP_ID"].ToString());
                            Para.Add("A");
                            Para.Add("0");
                            Para.Add(dtpDate.Value.ToString("yyyy-MM-dd"));
                            Para.Add(Voucher_ID);//For Voucher Number
                            bl_obj.blFill_para_name(ParaName, Para, "sp_Payment_Transaction_Details");
                        }
                    //}
                    KryptonMessageBox.Show("Record Save Successfilly", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearControls();
                    DataTable dt1 = new DataTable();
                    GetVoucherNo(dt1);
                    rbadd.Checked = true;
                    cmdName.Focus();
                }
                else
                    MyMessageBox.ShowBox(msg);
            }
            catch (Exception err) { err.GetBaseException(); }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public void ClearControls()
        {
            //filldata();
            //if (cmdName.Items.Count > 0)
                cmdName.SelectedIndex = 0;
                cmbAccount.SelectedIndex = 0;
                cmbPayMode.SelectedIndex = 0;
            txtInvoiceNo.Text = "";

            dtpDate.Text = "";
            txtSalesRecoveryId.Clear();
            txtAmount.Text = "0"; //txtAmount.Enabled = false; 
            txtNotApprove.Text = "0";
            txtPendingAmount.Text = "0";
            txtDescription.Text = "0";
            lvw.Items.Clear();
            dtpDate.Enabled = true;
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
                if (txtSalesRecoveryId.Text.Trim().Length <= 0)
                {
                    v = false;
                    msg += "Something Went Wrong. ";
                }

            if (flag == 'A' || flag == 'U')
                if (cmdName.SelectedIndex.Equals(0))
                {
                    v = false;
                    msg += "Select Customer/Firm name.  ";
                }
            //if (flag == 'A' || flag == 'U')
            //    if (cmbPayMode.SelectedIndex.Equals(0))
            //    {
            //        v = false;
            //        msg += "Select Pay Mode.  ";
            //    }
            if (flag == 'A' || flag == 'U')
                if (dtpDate.Text.Trim().Length <= 0)
                {
                    v = false;
                    msg += "Select Date. ";
                }
            if (flag == 'A' || flag == 'U')
                if (txtAmount.Text.Trim().Length <= 0)
                {
                    v = false;
                    msg += "Enter the Amount. ";
                }
            if (flag == 'A' || flag == 'U')
                if (cmbPayMode.SelectedIndex!=0 && cmbAccount.SelectedIndex==0)
                {
                    v = false;
                    msg += "Select Account. ";
                }
            
            return v;
        }

        private void txtInvoiceNo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtInvoiceNo == null || txtInvoiceNo.Text.Length > 0)
                {
                    bl_obj.PurchasePaidId = Convert.ToInt32(txtInvoiceNo.Text);
                    DataSet dsdata = new DataSet();
                    dsdata = bl_obj.FillInvoice(bl_obj);
                    FillLVW(dsdata);
                    if (dsdata.Tables.Count > 1)
                    {
                        paid = double.Parse(dsdata.Tables[1].Rows[0][0].ToString());
                        NotApproved = double.Parse(dsdata.Tables[1].Rows[0][1].ToString());
                        Total = double.Parse(dsdata.Tables[1].Rows[0][2].ToString());
                        txtNotApprove.Text = NotApproved.ToString();
                    }
                    else
                    {
                        txtNotApprove.Text = "0";
                    }
                }
                else filldata();
            }
            catch (Exception err) { err.GetBaseException(); }
        }

        private void cmdName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(cmdName.SelectedValue) > 0)
                {
                    bl_obj.CustomerId = Convert.ToInt32(cmdName.SelectedValue);
                    FillLVW(bl_obj.Fillcustomer(bl_obj)); //txtInvoiceNo.Clear(); 
                    txtAmount.Clear(); //txtAmount.Enabled = false; 
                    dtpDate.Enabled = true;
                    //ParaName.Clear();
                    //Para.Clear();
                    //ParaName.Add("@Cust_ID");
                    //ParaName.Add("@Cust_Type");
                    //ParaName.Add("@Tran_Date");
                    //ParaName.Add("@Flag");
                    //Para.Add(cmdName.SelectedValue.ToString());
                    //Para.Add("S");
                    //Para.Add(dtpDate.Value.Date.ToString("yyyy-MM-dd"));
                    //Para.Add("F");
                    //DataSet ds1 = bl_obj.blFill_para_name(ParaName, Para, "sp_Payment_Transaction_Details");
                    //txtNotApprove.Text = ds1.Tables[0].Rows[0][0].ToString();
                    txtAmount.Clear(); //txtAmount.Enabled = false; 
                    dtpDate.Enabled = true;
                    ParaName.Clear();
                    Para.Clear();
                    ParaName.Add("@Purchase_Id");
                    ParaName.Add("@flag");
                    Para.Add(cmdName.SelectedValue.ToString());
                    Para.Add("B");

                    DataSet ds1 = bl_obj.blFill_para_name(ParaName, Para, "SP_PurchasePaid");
                    txtPendingAmount.Text = ds1.Tables[0].Rows[0][0].ToString();
                }
                else { ClearControls(); ds = (bl_obj.SELECT(bl_obj)); FillLVW(ds); }
            }
            catch (Exception err) { err.GetBaseException(); }
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtAmount.Text.Trim().CompareTo("") == 0)
                {
                    txtAmount.Text = "0";
                    txtAmount.SelectAll();
                }
                //else if (double.Parse(txtAmount.Text.Trim()) > (Total - (paid + NotApproved)))
                //{
                //    KryptonMessageBox.Show("Please Enter Amount Less Than Pending Amount");
                //    txtAmount.Text = "0";
                //    txtAmount.SelectAll();
                //}
                else
                {
                    //Calculate();
                }

            }
            catch (Exception Ex)
            { }
        }

        private void Calculate()
        {
            txtAmount.Text = (Total - (paid + NotApproved)).ToString();
        }

        private void txtInvoiceNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //bl_obj.validateNumberNotFloat(e);
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            bl_obj.validateNumberNotFloat(e);
        }

        private void cmbPayMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPayMode.SelectedIndex != 0)
                cmbAccount.Enabled = true;
            else
                cmbAccount.Enabled = false;
        }

        private void rbadd_CheckedChanged(object sender, EventArgs e)
        {
            if (rbadd.Checked == true)
            {
                txtInvoiceNo.ReadOnly = true;
            }
            filldata();
        }

        private void rbedit_CheckedChanged(object sender, EventArgs e)
        {
            if (rbedit.Checked == true)
            {
                txtInvoiceNo.ReadOnly = false;
            }
        }
    }
}