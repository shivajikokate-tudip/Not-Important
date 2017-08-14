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
    public partial class FRM_BILLINGINVOICE : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        BL bl = new BL();
        MODULE function = new MODULE();
        module_Rpt function1 = new module_Rpt();
        BL_BILLINGINVOICE bl_obj = new BL_BILLINGINVOICE();
        BUSSINESS_LAYER.BL blobj = new BL();
        DataSet ds = null;
        DataSet dsg = new DataSet();
        DataSet dsdata = new DataSet();
        DataSet MainDs = new DataSet();
        List<string> ParaName = new List<string>();
        List<string> Para = new List<string>();

        int i, b, p = 0, t = 0;
        string msg = "";
        double TotalAmount = 0,Availablestock=0;
        string sname;
        double Total, GrandTotal, Vat = 0;
        public FRM_BILLINGINVOICE()
        {
            InitializeComponent();
        }

        private void FRM_BILLINGINVOICE_Load(object sender, EventArgs e)
        {
            function.settheme(this); b = 1;
            kryptonPanel6.Visible = false;
            kryptonPanel7.Visible = false;
            BL bl_obj1 = new BL();
            DataSet dsdata = bl_obj1.blFill("sp_GetPreDetailsInvoice");

            if (dsdata.Tables.Count > 0)
            {
                function.fillcombo(cmbPayMode, dsdata.Tables[0]);
                function.fillcombo(cmbTrans, dsdata.Tables[1]);
                function.fillcombo(cmbAccount, dsdata.Tables[2]);
            }
            btnPay.Visible = false;
            btnTransport.Visible = false;
            cmbAccount.Enabled = false;
            lblCarton.Visible = false;
            txtExciseDuety.Visible = false;
            txtExciseAmount.Visible = false;
        }

        public void clear()
        {
            bl_obj.Pay_Mode_Id = 0;
            bl_obj.Number = "";
            bl_obj.Details = "";
            bl_obj.Account_Id = 0;
            cmbAccount.Enabled = false;
            if (cmdfirmname.Items.Count > 0)
                cmdfirmname.SelectedIndex = 0;
            if (cmbSelectItem.Items.Count > 0)
                cmbSelectItem.SelectedIndex = 0;
            if (cmbTransport.Items.Count > 0)
                cmbTransport.SelectedIndex = 0; lblSubItem.Visible = false;
            b = 0;
            txtName.Clear();
            txtContact.Clear();
            txtAddress.Clear();
            txtExciseDuety.Text = "0";
            txtTotal.Clear();
            txtVatAmt.Clear();
            if (optSales.Checked == true)
            {
                txtVatPercent.ReadOnly = true;
                txtVatPercent.Text = "18";
            }
            else if (optPurchase.Checked == true)
            {
                txtVatPercent.ReadOnly = false;
                txtVatPercent.Text = "0";
            }
            else
            {
                txtVatPercent.Clear();
            }
            txtDisPercent.Text = "0";
            txtGrandTotal.Clear();
            txtPayAmount.Text = "0";
            txtCreditAmount.Clear();
            txtInvoiceNo.Clear();
            dataGridView1.Rows.Clear();
            p = 0; t = 0;
            clearproduct();
            txtDriverName.Clear();
           //cmb
            txtContactNo.Clear();
            if (cmbTrans.Items.Count > 0)
                cmbTrans.SelectedIndex = 0;
            if (cmbPayMode.Items.Count > 0)
                cmbPayMode.SelectedIndex = 0;
            txtDetails.Clear();
            txtDescription.Clear();

        }
        public void clearproduct()
        {
            if (cmbSubItem.Items.Count > 0)
                cmbSubItem.SelectedIndex = 0;
            txtQuantity.Clear();
            txtRate.Clear();
            txtUnit.Clear();
            txtAmount.Clear();
        }

        public DataSet datalist()
        {
            dtpDate.Value = Convert.ToDateTime(DateTime.Now.ToString());
            if (optSales.Checked) { bl_obj.form = "S"; }
            if (optPurchase.Checked) { bl_obj.form = "P"; }
            ds = (bl_obj.SELECT(bl_obj));
            MainDs = ds.Copy();
            function.fillcombo(cmdfirmname, ds.Tables[0]);
            //function.fillcombo(cmbSubItem, ds.Tables[2]);

            //function.fillcombo(cmbTransport, ds.Tables[5]);
            if (optSales.Checked)
            {
                function.fillcombo(cmbSelectItem, ds.Tables[3]);
                txtInvoiceNo.Text = ds.Tables[6].Rows[0][0].ToString();
            }
            else if (optPurchase.Checked) { function.fillcombo(cmbSelectItem, ds.Tables[2]); }
            return ds;
        }

        private void cmbSelectItem_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //try
            //{

            //    //if (cmbSelectItem.SelectedIndex > 0)
            //    //{
            //    //    bl_obj.itemid = Convert.ToInt32(cmbSelectItem.SelectedValue);
            //    //    bl_obj.flag = "6";
            //    //    function.fillcombo(cmbSubItem, (bl_obj.dropdown(bl_obj)));
            //    //}
            //    //txtUnit.Text = "";
            //    int r = Convert.ToInt32(cmbSelectItem.SelectedValue.ToString());
            //    if (optSales.Checked)
            //    {
            //        bl_obj.Parameter.Clear();
            //        bl_obj.Parameter.Add("@Sub_Item_ID", cmbSelectItem.SelectedValue.ToString());
            //        bl_obj.Parameter.Add("@Tran_Date", dtpDate.Value.ToString("yyyy-MM-dd"));
            //        bl_obj.Parameter.Add("@Flag", "S");
            //        DataSet dsdata = bl_obj.blFill_Para_Name(bl_obj.Parameter, "sp_Get_Stock_Itemwise");
            //        if (dsdata.Tables.Count > 0)
            //        {
            //            if (dsdata.Tables[0].Rows.Count > 0)
            //            {
            //                lblQtyBalance.Text = dsdata.Tables[0].Rows[0][0].ToString().CompareTo("") == 0 ? "0" : dsdata.Tables[0].Rows[0][0].ToString() + "  " + ds.Tables[3].Rows[r][3].ToString();
            //            }
            //            else
            //            {
            //                lblQtyBalance.Text = "0" + "  " + ds.Tables[3].Rows[r][3].ToString();
            //            }
            //        }
            //        else
            //        {
            //            lblQtyBalance.Text = "0" + "  " + ds.Tables[3].Rows[r][3].ToString();
            //        }
            //    }
            //    txtRate.Text = "";
            //    txtQuantity.Text = "";
            //    txtAmount.Text = "";

            //    if (optSales.Checked)
            //    {

            //        txtUnit.Text = ds.Tables[3].Rows[r][3].ToString();
            //    }
            //    if (optPurchase.Checked)
            //    {

            //        lblQtyBalance.Text = ds.Tables[2].Rows[r][5].ToString();
            //    }
            //    else txtUnit.Text = ds.Tables[2].Rows[r][5].ToString();
            //}
            //catch (Exception err)
            //{
            //    err.GetBaseException(); txtUnit.Clear();
            //}
        }

        //private void cmbSubItem_SelectionChangeCommitted(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        cmbSubItem.SelectionStart = 0;
        //        cmbSubItem.SelectionLength = cmbSubItem.Text.Length;
        //        sname = cmbSubItem.Text;

        //        if (cmbSubItem.SelectedIndex > 0)
        //        {

        //            bl_obj.itemid = Convert.ToInt32(cmbSubItem.SelectedValue);
        //            bl_obj.flag = "7";
        //            dsg = bl_obj.unit(bl_obj);
        //            if (dsg.Tables[0].Rows.Count > 0)
        //            {
        //                i = Convert.ToInt32(dsg.Tables[0].Rows[0][0].ToString());
        //                txtUnit.Text = dsg.Tables[0].Rows[0][1].ToString();
        //                txtRate.Text = dsg.Tables[0].Rows[0][2].ToString();
        //            }
        //            else { txtRate.Text = ""; txtUnit.Text = ""; txtQuantity.Text = ""; txtAmount.Text = ""; }
        //        }
        //        if (txtQuantity.Text == "") { txtAmount.Text = ""; }
        //        else
        //        {
        //            txtAmount.Text = (Math.Round(Convert.ToDouble(txtQuantity.Text) * Convert.ToDouble(dsg.Tables[0].Rows[0][2].ToString()))).ToString();
        //        }
        //    }
        //    catch (Exception err)
        //    {
        //        err.GetBaseException();
        //    }
        //}

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            try
            {
               if (txtQuantity.Text.Trim().CompareTo("") == 0)
                {
                    txtQuantity.Text = "0";
                    txtQuantity.SelectAll();
                }
                else
                {
                    //string vijay = Math.Round(Convert.ToDouble(txtAmount.Text), 2).ToString();
                    //CheckQty();
                }

                if (txtRate.Text == "") { txtAmount.Text = ""; }
                else //if (dsg.Tables.Count > 0)
                {
                    if (optSales.Checked == true)
                    {
                        
                        //txtAmount.Text = (
                        //                            (Convert.ToDouble(txtQuantity.Text) * Convert.ToDouble(txtRate.Text))
                        //                            -
                        //                            (((Convert.ToDouble(txtQuantity.Text) * Convert.ToDouble(txtRate.Text)) * 13.5) / 100)
                        //                            ).ToString();
                        txtAmount.Text = (Convert.ToDouble(txtQuantity.Text) * (Convert.ToDouble(txtRate.Text.Trim()) * 100 / 118)).ToString();
                    }
                    else if (optPurchase.Checked == true)
                    {
                        txtAmount.Text = (Convert.ToDouble(txtQuantity.Text) * Convert.ToDouble(txtRate.Text)).ToString();

                    }
                }
                //else if (b == 1) MyMessageBox.ShowBox("Select Product");
            }
            catch (Exception err)
            {
                err.GetBaseException();
            }
        }
        private void CheckQty()
        {
            if (optSales.Checked)
            {
                //if (double.Parse(txtQuantity.Text.Trim()) > Availablestock)
                //{
                //    KryptonMessageBox.Show("Quantity Must Not be Greater Than Available Stock");
                //    txtQuantity.Text = "0";
                //    txtQuantity.SelectAll();
                //}
            }
            else if (optPurchase.Checked)
            {
                if (float.Parse(txtPayAmount.Text.Trim()) > float.Parse(lblAvailableCash.Text.Trim()))
                {
                    //KryptonMessageBox.Show("Paid Cash Must Not be Greater Than Available Cash");
                    //txtPayAmount.Text = "0";
                    //txtPayAmount.SelectAll();
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            cmbSelectItem.SelectionStart = 0;
            cmbSelectItem.SelectionLength = cmbSelectItem.Text.Length;
            sname = cmbSelectItem.Text;
            try
            {
                if (Validate1('A', out msg))
                {
                    int cnt = dataGridView1.Rows.Count - 1;
                    if (cnt == 0)
                    {
                        cnt = 1;
                    }
                    else
                    {
                        cnt = cnt + 1;
                    }
                    bool Found = false;
                    if (dataGridView1.Rows.Count > 0)
                    {
                        //Check if the product Id exists with the same Price
                        //foreach (DataGridViewRow row in dataGridView1.Rows)
                        //{
                        //    if (Convert.ToString(row.Cells[1].Value) == cmbSelectItem.SelectedValue.ToString())
                        //    {
                        //        //Update the Quantity of the found row
                        //        if (row.Cells[4].Value.ToString() == txtRate.Text.ToString())
                        //        {
                        //            row.Cells[3].Value = Convert.ToString(Convert.ToDouble(txtQuantity.Text) + Convert.ToDouble(row.Cells[3].Value));
                        //            row.Cells[5].Value = Convert.ToString(Convert.ToDouble(txtAmount.Text) + Convert.ToDouble(row.Cells[5].Value));

                        //        }
                        //        else
                        //            MyMessageBox.ShowBox(" Rate Not Match "); Found = true;
                        //    }
                        //}
                        if (!Found)
                        {
                            //Add the row to grid view
                            if (optSales.Checked == true)
                                dataGridView1.Rows.Insert(0, cnt, cmbSelectItem.SelectedValue, sname, txtQuantity.Text.ToString(), (Convert.ToDouble(txtRate.Text.Trim()) * 100 / 118).ToString(), txtAmount.Text.ToString());
                            else if (optPurchase.Checked == true)
                                dataGridView1.Rows.Insert(0, cnt, cmbSelectItem.SelectedValue, sname, txtQuantity.Text.ToString(), txtRate.Text.ToString(), txtAmount.Text.ToString());
                        }
                    }
                    else
                    {
                        //Add the row to grid view for the first time
                        //dataGridView1.Rows.Insert(0, cnt, cmbSelectItem.SelectedValue, sname, txtQuantity.Text.ToString(), txtRate.Text.ToString(), txtAmount.Text.ToString());
                        if (optSales.Checked == true)
                            dataGridView1.Rows.Insert(0, cnt, cmbSelectItem.SelectedValue, sname, txtQuantity.Text.ToString(), (Convert.ToDouble(txtRate.Text.Trim()) * 100 / 118).ToString(), txtAmount.Text.ToString());
                        else if (optPurchase.Checked == true)
                            dataGridView1.Rows.Insert(0, cnt, cmbSelectItem.SelectedValue, sname, txtQuantity.Text.ToString(), txtRate.Text.ToString(), txtAmount.Text.ToString());
                    }

                    gridamountcount();
                    exciseDuety(); vatcalculate(); this.dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);
                    clearproduct();
                    //txtVatAmt.Clear();
                    //txtVatPercent.Clear();
                    //txtDisPercent.Clear();
                    txtCreditAmount.Text = txtGrandTotal.Text;
                    txtPayAmount.Text="0"; //txtCarton.Text = "0";
                }
                else
                    MyMessageBox.ShowBox(msg);
            }
            catch (Exception err)
            {
                err.GetBaseException();
            }
        }



        private void gridamountcount()
        {
            if (optSales.Checked == true)
            {
                if (dataGridView1.RowCount > 1)
                {
                    TotalAmount = 0;
                    Total = 0; GrandTotal = 0; Vat = 0;
                    for (int j = 2; j <= dataGridView1.RowCount; j++)
                    {
                        Total = Convert.ToDouble((TotalAmount = TotalAmount + Convert.ToDouble(dataGridView1.Rows[j - 2].Cells[5].Value)).ToString());
                        //GrandTotal = Convert.ToDouble((GrandTotal + (Convert.ToDouble(dataGridView1.Rows[j - 2].Cells[3].Value) * Convert.ToDouble(dataGridView1.Rows[j - 2].Cells[4].Value))).ToString());
                        //Vat = GrandTotal - Total;
                        dataGridView1.Rows[j - 2].Cells[0].Value = j - 1;
                        txtTotal.Text = Total.ToString();
                        Vat = (((Convert.ToDouble(txtTotal.Text.Trim()) * 18) / 100));
                        txtVatAmt.Text = Vat.ToString();
                        GrandTotal = Math.Round((Convert.ToDouble(txtTotal.Text.Trim()) + Vat),2);//GrandTotal.ToString();
                        txtGrandTotal.Text =  GrandTotal.ToString();
                    }
                }
            }
            else if (optPurchase.Checked == true)
            {
                if (dataGridView1.RowCount > 1)
                {
                    TotalAmount = 0;
                    Total = 0; GrandTotal = 0; Vat = 0;
                    for (int j = 2; j <= dataGridView1.RowCount; j++)
                    {
                        Total = GrandTotal = Convert.ToDouble(Math.Round(TotalAmount = TotalAmount + Convert.ToDouble(dataGridView1.Rows[j - 2].Cells[5].Value),2).ToString());
                        //GrandTotal = Convert.ToDouble((GrandTotal + (Convert.ToDouble(dataGridView1.Rows[j - 2].Cells[3].Value) * Convert.ToDouble(dataGridView1.Rows[j - 2].Cells[4].Value))).ToString());
                        Vat = GrandTotal - Total;
                        dataGridView1.Rows[j - 2].Cells[0].Value = j - 1;
                        txtGrandTotal.Text = GrandTotal.ToString();
                        txtTotal.Text = Total.ToString();
                        txtVatAmt.Text = Vat.ToString();
                    }
                }
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dataGridView1.SelectedRows.Count > 0)
                {
                    dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);
                }
                gridamountcount();
            }
            catch (Exception err)
            {
                err.GetBaseException();
            }
        }
        public void vatcalculate()
        {
            try
            {
                if (txtTotal.Text != "")
                {
                    if (txtVatPercent.Text != "")
                    {
                        if (optSales.Checked==true)
                        {
                            //txtVatAmt.Text = (Math.Round(Convert.ToInt32(txtTotal.Text) * Convert.ToDouble(txtVatPercent.Text) / 100)).ToString();
                        }
                        else if (optPurchase.Checked==true)
                        {
                            txtVatAmt.Text = (
                                ((Convert.ToDouble(txtTotal.Text) + (Convert.ToDouble(txtTotal.Text) * Convert.ToDouble(txtExciseDuety.Text.CompareTo("") == 0 ? "0" : txtExciseDuety.Text) / 100)) *
                            Convert.ToDouble(txtVatPercent.Text.CompareTo("")==0?"0":txtVatPercent.Text) / 100)
                            ).ToString(); 
                            txtGrandTotal.Text = Math.Round(Convert.ToDouble(txtVatAmt.Text) + Convert.ToDouble(txtExciseAmount.Text) + Convert.ToDouble(txtTotal.Text),2).ToString();
                        }
                    }
                    else
                    {
                        txtVatAmt.Text = "0";
                    }
                }
                else
                {
                    if (b == 1)
                        MyMessageBox.ShowBox("Select Product");
                    //txtVatPercent.Text = "";
                }
                txtCreditAmount.Text = txtGrandTotal.Text;
            }
            catch (Exception err)
            {
                err.GetBaseException();
            }
        }
        private void txtVatPercent_TextChanged(object sender, EventArgs e)
        {
            vatcalculate();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrintInvoice_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds1 = new DataSet();
                if (!(optSales.Checked || optPurchase.Checked))
                {
                    msg += "Do you want Sales or Purchase";
                    MyMessageBox.ShowBox(msg);
                }
                else
                {
                    if (optSales.Checked)
                    {
                        if (Validate('A', out msg))
                        {
                            if (Validation2('A', out msg))
                            {
                                bl_obj.form = "SI";
                                bl_obj.Customer_Id =Convert.ToInt32(cmdfirmname.SelectedValue.ToString());
                                //bl_obj.Tras_Date =Convert .ToDateTime( function.convertdate_string_date(function.SysDate(), dtpDate));
                                bl_obj.Tras_Date = dtpDate.Value.ToString("yyyy-MM-dd");
                                bl_obj.Carton = Convert.ToInt32("0");
                                //bl_obj.Transportation_Id = Convert.ToInt32("0"); //cmbTransport.SelectedIndex;
                                bl_obj.Total = Convert.ToDouble(txtTotal.Text);
                                bl_obj.Vat = Convert.ToDouble(txtVatPercent.Text);
                                bl_obj.Discount = Convert.ToDouble(txtDisPercent.Text);
                                bl_obj.Grand_Total = Convert.ToDouble(txtGrandTotal.Text);
                                bl_obj.Paid = Convert.ToDouble(txtPayAmount.Text);
                                bl_obj.On_Credit = Convert.ToDouble(txtCreditAmount.Text);
                                ds1 = bl_obj.INSERT(bl_obj);
                                bl_obj.Sales_Id = Convert.ToInt32(ds1.Tables[0].Rows[0][0].ToString());
                                bl_obj.Invoice_Number = Convert.ToInt32(ds1.Tables[0].Rows[0][1].ToString());

                                if (dataGridView1.RowCount > 1)
                                {
                                    for (int j = 2; j <= dataGridView1.RowCount; j++)
                                    {
                                        bl_obj.form = "SP";
                                        bl_obj.SubItemId = Convert.ToInt32(dataGridView1.Rows[j - 2].Cells[1].Value);
                                        bl_obj.Quantity = Convert.ToDouble(dataGridView1.Rows[j - 2].Cells[3].Value);
                                        bl_obj.Rate = Convert.ToDouble(dataGridView1.Rows[j - 2].Cells[4].Value);
                                        bl_obj.Amount = Convert.ToDouble(dataGridView1.Rows[j - 2].Cells[5].Value);
                                        bl_obj.INSERT(bl_obj);
                                    }
                                }
                                if (t == 1)
                                {
                                    bl_obj.form = "TP";
                                    bl_obj.INSERT(bl_obj);
                                }
                                if (p == 1)
                                {
                                    bl_obj.form = "PY"; bl_obj.flag = "S";
                                    bl_obj.INSERT(bl_obj);
                                }
                                else
                                {
                                    bl_obj.Pay_Mode_Id =0;
                                    bl_obj.Number = "";
                                    bl_obj.Details = "";
                                    bl_obj.Account_Id = 0;
                                    bl_obj.form = "PY"; bl_obj.flag = "S";
                                    bl_obj.INSERT(bl_obj);
                                }

                                /////////////////////////////////Start of Payment_Transaction_Details/////////////////////////////////////////////

                                //ParaName.Clear();
                                //Para.Clear();
                                //ParaName.Add("@Cust_ID");
                                //ParaName.Add("@To_Acc");
                                //ParaName.Add("@Day_Cash");
                                //ParaName.Add("@Paid_Cash");
                                //ParaName.Add("@Pay_Mode_Id");
                                //ParaName.Add("@Description");
                                //ParaName.Add("@Tran_Type");
                                //ParaName.Add("@Cust_Type");
                                //ParaName.Add("@User_ID");
                                //ParaName.Add("@Flag");
                                //ParaName.Add("@Tran_Number");
                                //ParaName.Add("@Tran_Date");
                                //Para.Add(cmdfirmname.SelectedValue.ToString());
                                //Para.Add(bl_obj.Account_Id.ToString());
                                
                                //    Para.Add(txtPayAmount.Text.Trim());
                                //    Para.Add("0");                                    
                                                                
                                //Para.Add(bl_obj.Pay_Mode_Id.ToString());
                                //Para.Add(bl_obj.Number+ " "+bl_obj.Details);
                                //Para.Add("C");
                                //Para.Add("C");
                                //Para.Add(MODULE.glb["SHOP_ID"].ToString());
                                //Para.Add("A");
                                //Para.Add(txtInvoiceNo.Text);
                                //Para.Add(dtpDate.Value.ToString("yyyy-MM-dd"));
                                //bl_obj.blFill_para_name(ParaName, Para, "sp_Payment_Transaction_Details");

                                /////////////////////////////End of Payment_Transaction_Details//////////////////////////////////////////////
                                KryptonMessageBox.Show("Record Save Successfilly", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                //KryptonMessageBox.Show("Do you want generate bill", "Yes", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                                DialogResult Result = KryptonMessageBox.Show("Do you want generate bill", "Invoice Save Successfilly", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                                if (Result == DialogResult.Yes)
                                {
                                    DataSet dsr = new DataSet();
                                    dsr = bl_obj.REPORT(bl_obj);
                                    function1.Show_Report("RptSalesInvoice", dsr, 0); clear(); b++; datalist();
                                }
                                else { clear(); b++; datalist(); }
                            }
                            else
                                MyMessageBox.ShowBox(msg);
                        }
                        else
                            MyMessageBox.ShowBox(msg);
                    }
                    if (optPurchase.Checked)
                    {
                        if (Validate('A', out msg))
                        {
                            bl_obj.form = "PI";
                            bl_obj.Invoice_Number = Convert.ToInt32(txtInvoiceNo.Text);
                            bl_obj.Customer_Id = Convert.ToInt32(cmdfirmname.SelectedValue.ToString());
                            bl_obj.Tras_Date = dtpDate.Value.ToString("yyyy-MM-dd");
                            bl_obj.Total = Convert.ToDouble(txtTotal.Text);
                            bl_obj.Vat = Convert.ToDouble(txtVatPercent.Text);
                            bl_obj.Grand_Total = Convert.ToDouble(txtGrandTotal.Text);
                            bl_obj.Discount = Convert.ToDouble(txtExciseDuety.Text);
                            bl_obj.Paid = Convert.ToDouble(txtPayAmount.Text);
                            bl_obj.On_Credit = Convert.ToDouble(txtCreditAmount.Text);
                            ds1 = bl_obj.INSERT(bl_obj);
                            bl_obj.Sales_Id = Convert.ToInt32(ds1.Tables[0].Rows[0][0].ToString());
                            bl_obj.Invoice_Number = Convert.ToInt32(txtInvoiceNo.Text);
                            //Convert.ToInt32(ds1.Tables[0].Rows[0][1].ToString());
                            //ClearControls();
                            if (dataGridView1.RowCount > 1)
                            {
                                for (int j = 2; j <= dataGridView1.RowCount; j++)
                                {
                                    bl_obj.form = "PP";
                                    bl_obj.SubItemId = Convert.ToInt32(dataGridView1.Rows[j - 2].Cells[1].Value);
                                    bl_obj.Quantity = Convert.ToDouble(dataGridView1.Rows[j - 2].Cells[3].Value);
                                    bl_obj.Rate = Convert.ToDouble(dataGridView1.Rows[j - 2].Cells[4].Value);
                                    bl_obj.Amount = Convert.ToDouble(dataGridView1.Rows[j - 2].Cells[5].Value);
                                    bl_obj.Tras_Date = dtpDate.Value.ToString("yyyy-MM-dd");
                                    bl_obj.INSERT(bl_obj);
                                }
                            }
                            if (p == 1)
                            {
                                bl_obj.form = "PY"; bl_obj.flag = "P";
                                bl_obj.INSERT(bl_obj);
                            }
                            else
                            {
                                bl_obj.Pay_Mode_Id = 0;
                                bl_obj.Number = "";
                                bl_obj.Details = "";
                                bl_obj.Account_Id = 0;
                                bl_obj.form = "PY"; bl_obj.flag = "P";
                                bl_obj.INSERT(bl_obj);
                            }

                            /////////////////////////////////Start of Payment_Transaction_Details/////////////////////////////////////////////

                            //ParaName.Clear();
                            //Para.Clear();
                            //ParaName.Add("@Cust_ID");
                            //ParaName.Add("@To_Acc");
                            //ParaName.Add("@Day_Cash");
                            //ParaName.Add("@Paid_Cash");
                            //ParaName.Add("@Pay_Mode_Id");
                            //ParaName.Add("@Description");
                            //ParaName.Add("@Tran_Type");
                            //ParaName.Add("@Cust_Type");
                            //ParaName.Add("@User_ID");
                            //ParaName.Add("@Flag");
                            //ParaName.Add("@Tran_Number");
                            //ParaName.Add("@Tran_Date");
                            //Para.Add(cmdfirmname.SelectedValue.ToString());
                            //Para.Add(bl_obj.Account_Id.ToString());
                            //Para.Add("0");
                            //Para.Add(txtPayAmount.Text.Trim());
                            //Para.Add(bl_obj.Pay_Mode_Id.ToString());
                            //Para.Add(bl_obj.Number + " " + bl_obj.Details);
                            //Para.Add("V");
                            //Para.Add("S");
                            //Para.Add(MODULE.glb["SHOP_ID"].ToString());
                            //Para.Add("A");
                            //Para.Add(bl_obj.Sales_Id.ToString());
                            //Para.Add(dtpDate.Value.ToString("yyyy-MM-dd"));
                            //bl_obj.blFill_para_name(ParaName, Para, "sp_Payment_Transaction_Details");

                            /////////////////////////////End of Payment_Transaction_Details//////////////////////////////////////////////
                            
                            b++; clear(); datalist();
                            KryptonMessageBox.Show("Transaction No : GRN" + bl_obj.Sales_Id + " .", "Record Save Successfilly", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            MyMessageBox.ShowBox(msg);
                    }
                }
                b++;

            }
            catch (Exception err)
            {
                err.GetBaseException();
            }
        }
        public bool Validate(char flag, out string msg)
        {

            msg = "";
            bool v = true;
            if (!(optSales.Checked || optPurchase.Checked))
            {
                v = false;
                msg += "Do you want Sales or Purchase. " + System.Environment.NewLine;
            }
            if (flag == 'A' || flag == 'U')
                if (dataGridView1.RowCount <= 1)
                {
                    v = false;
                    msg += "Select Product. " + System.Environment.NewLine;
                }
            if (flag == 'A' || flag == 'U')
                if (cmdfirmname.SelectedIndex.Equals(0))
                {
                    v = false;
                    msg += "Enter the Firm Name or Customer Name. " + System.Environment.NewLine;
                }


            if (flag == 'A' || flag == 'U')
                if (txtVatPercent.Text.Trim().Length <= 0)
                {
                    v = false;
                    msg += "Enter Vat Percentage. " + System.Environment.NewLine;
                }

            if (flag == 'A' || flag == 'U')
                if (txtInvoiceNo.Text.Trim().Length <= 0)
                {
                    v = false;
                    msg += "Enter Invoice No. " + System.Environment.NewLine;
                }

            if (flag == 'A' || flag == 'U')
                if (dtpDate.Value.ToString().Trim().Length <= 0)
                {
                    v = false;
                    msg += "Select Date. " + System.Environment.NewLine;
                }
            if (flag == 'A' || flag == 'U')
                if (txtPayAmount.Text.Trim().Length <= 0)
                {
                    v = false;
                    msg += "Enter Pay Amount. " + System.Environment.NewLine;
                }
            return v;
        }
        public bool Validate1(char flag, out string msg)
        {
            msg = "";
            bool v = true;

            if (flag == 'A' || flag == 'U')
                if (cmbSelectItem.SelectedIndex.Equals(0))
                {
                    v = false;
                    msg += "Select Item Name. " + System.Environment.NewLine;
                }
            if (flag == 'A' || flag == 'U')
                if (txtQuantity.Text.Trim().Length <= 0)
                {
                    v = false;
                    msg += "Enter Quantity. " + System.Environment.NewLine;
                }
            if (flag == 'A' || flag == 'U')
                if (txtRate.Text.Trim().Length <= 0)
                {
                    v = false;
                    msg += "Enter Rate. " + System.Environment.NewLine;
                }
            return v;
        }

        public bool Validation2(char flag, out string msg)
        {
            msg = "";
            bool v = true;

            //if (flag == 'A' || flag == 'U')
            //    if (txtCarton.Text.Trim().Length <= 0)
            //    {
            //        v = false;
            //        msg += "Enter Cartoon";
            //    }
            //if (flag == 'A' || flag == 'U')
            //    if (cmbTransport.SelectedIndex.Equals(0))
            //    {
            //        v = false;
            //        msg += "Select Transport";
            //    }
            if (flag == 'A' || flag == 'U')
                if (txtDisPercent.Text.Trim().Length <= 0)
                {
                    v = false;
                    msg += "Enter Discount. " + System.Environment.NewLine;
                }

            if (flag == 'A' || flag == 'U')
                if (txtPayAmount.Text.Trim().Length <= 0)
                {
                    v = false;
                    msg += "Enter Pay Amount. "+System.Environment.NewLine;
                }
            return v;
        }

        public void optSales_CheckedChanged(object sender, EventArgs e)
        {
            clear();
            lblVat.Text = "GST";
            lblFirmName.Text = "Customer Name";
            lblCarton.Visible = false;
            lblTransport.Visible = false;
            lblDiscount.Visible = true;
            txtInvoiceNo.Enabled = false;
            txtExciseDuety.Visible = false;
            cmbTransport.Visible = false;
            txtDisPercent.Visible = true;
            txtExciseAmount.Visible = false;
            //lblQtyBalance.Visible = true; 
            lblAvailableCash.Visible = false;
            datalist();
            btnPay.Visible = true;
            btnTransport.Visible = true;
            kryptonPanel6.Visible = false;
            kryptonPanel7.Visible = false;
            if (optSales.Checked == true)
            {
                txtVatPercent.Text = "18";
                txtVatPercent.ReadOnly = true;
            }
            cmbAccount.Visible = true;
            

            kryptonLabel8.Visible = true;
        }

        public void optPurchase_CheckedChanged(object sender, EventArgs e)
        {
            clear();
            txtExciseAmount.Visible = false;
            lblFirmName.Text = "Firm Name";
            lblCarton.Visible = false; ;
            lblTransport.Visible = false;
            lblDiscount.Visible = true;
            txtExciseDuety.Visible = false;
            cmbTransport.Visible = false;
            txtDisPercent.Visible = true;
            txtInvoiceNo.Enabled = true;
            //lblQtyBalance.Visible = false;
            lblAvailableCash.Visible = true;
            datalist();
            btnPay.Visible = true;
            btnTransport.Visible = false;
            kryptonPanel6.Visible = false;
            kryptonPanel7.Visible = false;
            if (optPurchase.Checked)
            {
                bl_obj.Parameter.Clear();

                bl_obj.Parameter.Add("@Tran_Date", dtpDate.Value.ToString("yyyy-MM-dd"));
                bl_obj.Parameter.Add("@Flag", "P");
                DataSet dsdata = bl_obj.blFill_Para_Name(bl_obj.Parameter, "sp_Get_Stock_Itemwise");
                if (dsdata.Tables.Count > 0)
                {
                    if (dsdata.Tables[0].Rows.Count > 0)
                    {
                        lblAvailableCash.Text = dsdata.Tables[0].Rows[0][0].ToString().CompareTo("") == 0 ? "0" : dsdata.Tables[0].Rows[0][0].ToString();
                    }
                    else
                    {
                        lblAvailableCash.Text = "0";
                    }
                }
                else
                {
                    lblAvailableCash.Text = "0";
                }
                txtVatPercent.Text = "0";
                txtVatPercent.ReadOnly = false;
            }
            cmbAccount.Visible = true;
            kryptonLabel8.Visible = true;
        }
        public void amountset()
        {
            try
            {
                if (optSales.Checked)
                {
                    //////////////////////////////////Start Old Code////////////////////////////////////////////
                    ////txtPayAmount.Text = "";
                    ////if (txtTotal.Text != "")
                    ////{
                    ////    if (txtDisPercent.Text != "" && txtVatPercent.Text == "")
                    ////    {
                    ////        txtGrandTotal.Text = (Math.Round(Convert.ToDouble(txtTotal.Text) - Convert.ToDouble(txtDisPercent.Text))).ToString();
                    ////    }
                    ////    else if (txtDisPercent.Text == "" && txtVatPercent.Text != "")
                    ////    {
                    ////        txtGrandTotal.Text = (Math.Round(Convert.ToInt32(txtTotal.Text) - (Convert.ToInt32(txtTotal.Text) * Convert.ToDouble(txtVatPercent.Text) / 100))).ToString();
                    ////    }
                    ////    else if (txtDisPercent.Text != "" && txtVatPercent.Text != "")
                    ////    {
                    ////        txtGrandTotal.Text = (Math.Round(Convert.ToInt32(txtTotal.Text) - (Convert.ToInt32(txtTotal.Text) * Convert.ToDouble(txtVatPercent.Text) / 100) - Convert.ToDouble(txtDisPercent.Text))).ToString();
                    ////    }
                    ////    if (txtDisPercent.Text == "" && txtVatPercent.Text == "")
                    ////    { txtGrandTotal.Text = txtTotal.Text; }
                    ////}

                    ////else
                    ////{
                    ////    if (b == 1)
                    ////        MyMessageBox.ShowBox("Select Product");
                    ////}
                    //////////////////////////////////End Old Code////////////////////////////////////////////
                    //txtPayAmount.Text = "";
                    //if (txtTotal.Text != "")
                    //{
                    //    if (txtDisPercent.Text != "" && txtVatPercent.Text == "")
                    //    {
                    //        txtGrandTotal.Text = (Math.Round(Total - Convert.ToDouble(txtDisPercent.Text))).ToString();
                    //    }
                    //    else if (txtDisPercent.Text == "" && txtVatPercent.Text != "")
                    //    {
                    //        //txtGrandTotal.Text = (Math.Round(Total + (Total * Convert.ToDouble(txtVatPercent.Text) / 100))).ToString();
                    //        txtTotal.Text = (Total - Convert.ToDouble(txtVatAmt.Text.Trim())).ToString();
                    //    }
                    //    else if (txtDisPercent.Text != "" && txtVatPercent.Text != "")
                    //    {
                    //        txtGrandTotal.Text = (Math.Round(Total - Convert.ToDouble(txtDisPercent.Text.Trim().CompareTo("") == 0 ? "0" : txtDisPercent.Text.Trim()))).ToString();
                    //        //txtGrandTotal.Text = (Math.Round(Total + (Total * Convert.ToDouble(txtVatPercent.Text) / 100) - Convert.ToDouble(txtDisPercent.Text))).ToString();
                    //        txtTotal.Text = (Total - Convert.ToDouble(txtVatAmt.Text.Trim())).ToString();
                    //    }
                    //    if (txtDisPercent.Text == "" && txtVatPercent.Text == "")
                    //    { txtGrandTotal.Text = txtTotal.Text; }
                    //}

                    //else
                    //{
                    //    if (b == 1)
                    //        MyMessageBox.ShowBox("Select Product");
                    //}
                    txtPayAmount.Text = "0";
                    if (txtTotal.Text != "")
                    {
                        if (optSales.Checked == true)
                        {
                            if (txtDisPercent.Text != "")
                            {
                                //Vat = ((Convert.ToDouble(txtTotal.Text.Trim()) * Convert.ToDouble(txtVatPercent.Text.Trim())) / 100);
                                //txtVatAmt.Text = Vat.ToString();
                                txtGrandTotal.Text =  ( Math.Round(GrandTotal - Convert.ToDouble(txtDisPercent.Text),2)).ToString();
                            }
                        }
                        else if (optPurchase.Checked == true)
                        {
                            if (txtDisPercent.Text != "")
                            {
                                txtGrandTotal.Text = (Math.Round(Total - Convert.ToDouble(txtDisPercent.Text),2)).ToString();
                            }
                            else if (txtDisPercent.Text == "" && txtVatPercent.Text != "")
                            {
                                //txtGrandTotal.Text = (Math.Round(Total + (Total * Convert.ToDouble(txtVatPercent.Text) / 100))).ToString();
                                txtTotal.Text = (Total - Convert.ToDouble(txtVatAmt.Text.Trim())).ToString();
                            }
                            else if (txtDisPercent.Text != "" && txtVatPercent.Text != "")
                            {
                                txtGrandTotal.Text = (Math.Round(Total - Convert.ToDouble(txtDisPercent.Text.Trim().CompareTo("") == 0 ? "0" : txtDisPercent.Text.Trim()),2)).ToString();
                                //txtGrandTotal.Text = (Math.Round(Total + (Total * Convert.ToDouble(txtVatPercent.Text) / 100) - Convert.ToDouble(txtDisPercent.Text))).ToString();
                                txtTotal.Text = (Total - Convert.ToDouble(txtVatAmt.Text.Trim())).ToString();
                            }
                            if (txtDisPercent.Text == "" && txtVatPercent.Text == "")
                            { txtGrandTotal.Text =Math.Round(Convert.ToDouble(txtTotal.Text.Trim()),2).ToString(); }
                        }
                    }

                    else
                    {
                        if (b == 1)
                            MyMessageBox.ShowBox("Select Product");
                    }
                }
                else if (optPurchase.Checked)
                {
                    txtPayAmount.Text = "0";
                    if (txtTotal.Text != "")
                    {
                        if (txtExciseDuety.Text != "" && txtVatPercent.Text == "")
                        {
                            txtGrandTotal.Text =
                               Math.Round(Convert.ToDouble(txtTotal.Text) + (
                                (Convert.ToDouble(txtTotal.Text) * Convert.ToDouble(txtExciseDuety.Text) / 100)),2).ToString();
                        }
                        else if (txtExciseDuety.Text == "" && txtVatPercent.Text != "")
                        {
                            txtGrandTotal.Text = (Math.Round(Convert.ToDouble(txtTotal.Text) + (Convert.ToDouble(txtTotal.Text) * Convert.ToDouble(txtVatPercent.Text) / 100),2)).ToString();
                        }
                        else if (txtExciseDuety.Text != "" && txtVatPercent.Text != "")
                        {
                            txtGrandTotal.Text = (Math.Round((Convert.ToDouble(txtTotal.Text) +
                                (Convert.ToDouble(txtTotal.Text) * Convert.ToDouble(txtExciseDuety.Text) / 100)) +
                                ((Convert.ToDouble(txtTotal.Text) + (Convert.ToDouble(txtTotal.Text) * Convert.ToDouble(txtExciseDuety.Text) / 100)) *
                            Convert.ToDouble(txtVatPercent.Text) / 100) - Convert.ToDouble(txtDisPercent.Text)
                                ,2)).ToString();
                        }
                        if (txtExciseDuety.Text == "" && txtVatPercent.Text == "")
                        { txtGrandTotal.Text = Math.Round(Convert.ToDouble(txtTotal.Text.Trim()),2).ToString(); }
                    }

                    else
                    {
                        if (b == 1)
                            MyMessageBox.ShowBox("Select Product");
                    }
                }
            }
            catch (Exception err)
            {
                err.GetBaseException();
            }
        }
        private void txtVatPercent_Leave(object sender, EventArgs e)
        {
            amountset();
        }

        private void txtDisPercent_Leave(object sender, EventArgs e)
        {
            if (txtDisPercent.Text.Trim().CompareTo("") == 0)
            {
                txtDisPercent.Text = "0";
                txtDisPercent.SelectAll();
            }
            amountset();
            //txtGrandTotal.Text = GrandTotal.ToString();
            txtCreditAmount.Text = (Convert.ToDouble(txtGrandTotal.Text.Trim().CompareTo("") == 0 ? "0" : txtGrandTotal.Text.Trim()) - Convert.ToDouble(txtPayAmount.Text.Trim().CompareTo("") == 0 ? "0" : txtPayAmount.Text.Trim())).ToString();
        }
        private void txtExciseDuety_Leave(object sender, EventArgs e)
        {
            amountset();
        }
        public void exciseDuety()
        {
            try
            {
                if (txtTotal.Text != "")
                {
                    if (txtExciseDuety.Text != "")
                    {

                        txtExciseAmount.Text = (Convert.ToDouble(txtTotal.Text) * Convert.ToDouble(txtExciseDuety.Text) / 100).ToString();
                    }

                    else
                    {
                        txtExciseAmount.Text = "0";
                    }
                }
                else
                {
                    if (b == 1)
                        MyMessageBox.ShowBox("Select Product");
                    txtVatPercent.Text = "0";
                } txtCreditAmount.Text = txtGrandTotal.Text;
            }
            catch (Exception err)
            {
                err.GetBaseException();
            }
        }
        private void txtExciseDuety_TextChanged(object sender, EventArgs e)
        {
            exciseDuety();
            vatcalculate();
        }

        private void txtPayAmount_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtPayAmount.Text.Trim().CompareTo("") == 0)
                {
                    txtPayAmount.Text = "0";
                    txtPayAmount.SelectAll();
                }
                else
                {
                    CheckQty();
                    vatcalculate();
                }

                if (txtGrandTotal.Text != "" && txtPayAmount.Text != "")
                {
                    txtCreditAmount.Text = ((Convert.ToDouble(txtGrandTotal.Text) - Convert.ToDouble(txtPayAmount.Text) - Convert.ToDouble(txtDisPercent.Text)).ToString());
                }
                else if (txtGrandTotal.Text == "")
                {
                    if (b == 1)
                        MyMessageBox.ShowBox("Select Product");
                    txtPayAmount.Text = "0";
                }
                else { txtPayAmount.Text = "0"; txtCreditAmount.Text = ""; }
            }
            catch (Exception err)
            {
                err.GetBaseException();
            }
        }

        private void cmdfirmname_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                txtUnit.Text = "";
                txtRate.Text = "";
                if (cmdfirmname.SelectedIndex == 0)
                {
                    txtName.Text = "";
                    txtAddress.Text = "";
                    txtContact.Text = "";
                }
                else
                {
                    DataSet ds10 = new DataSet();
                    int i = cmdfirmname.SelectedIndex - 1;
                    //txtName.Text = ds.Tables[0].Rows[0][2].ToString();
                    bl_obj.Customer_Id = Convert.ToInt32(cmdfirmname.SelectedValue.ToString());
                    if (optSales.Checked == true)
                    {
                        bl_obj.itemid = 1;
                    }
                    if (optPurchase.Checked == true)
                    {
                        bl_obj.itemid = 2;
                    }
                    ds10 = (bl_obj.BALANCE(bl_obj));
                    ds = (bl_obj.SELECT(bl_obj));
                    //cmdfirmname.SelectedIndex = Convert.ToInt32(ds.Tables[0].Rows[i][0].ToString());
                    txtName.Text = ds.Tables[0].Rows[i][2].ToString();
                    txtAddress.Text = ds.Tables[0].Rows[i][3].ToString();
                    txtContact.Text = ds.Tables[0].Rows[i][4].ToString();
                    if (ds10.Tables.Count >= 0)
                    {
                        string bal = ds10.Tables[0].Rows[0][0].ToString();
                        if (bal.Length > 0)
                        {
                            lblSubItem.Visible = true;
                            lblSubItem.Text = "Pending Amount " + ds10.Tables[0].Rows[0][0].ToString();
                        }
                        else
                            lblSubItem.Text = "Pending Amount 0 ";
                    }

                }
            }
            catch (Exception err)
            {
                err.GetBaseException(); lblSubItem.Visible = false;
            }
        }

        private void cmdfirmname_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtUnit.Text = "";
                txtRate.Text = "";
                if (cmdfirmname.SelectedIndex == 0)
                {
                    txtName.Text = "";
                    txtAddress.Text = "";
                    txtContact.Text = "";
                }
                else
                {
                    DataSet ds10 = new DataSet();
                    int i = cmdfirmname.SelectedIndex - 1;
                    //txtName.Text = ds.Tables[0].Rows[0][2].ToString();
                    bl_obj.Customer_Id = Convert.ToInt32(cmdfirmname.SelectedValue.ToString());
                    if (optSales.Checked == true)
                    {
                        bl_obj.itemid = 1;
                    }
                    if (optPurchase.Checked == true)
                    {
                        bl_obj.itemid = 2;
                    }
                    ds10 = (bl_obj.BALANCE(bl_obj));
                    ds = (bl_obj.SELECT(bl_obj));
                    //cmdfirmname.SelectedIndex = Convert.ToInt32(ds.Tables[0].Rows[i][0].ToString());
                    txtName.Text = ds.Tables[0].Rows[i][2].ToString();
                    txtAddress.Text = ds.Tables[0].Rows[i][3].ToString();
                    txtContact.Text = ds.Tables[0].Rows[i][4].ToString();
                    if (ds10.Tables.Count >= 0)
                    {
                        string bal = ds10.Tables[0].Rows[0][0].ToString();
                        if (bal.Length > 0)
                        {
                            lblSubItem.Visible = true;
                            lblSubItem.Text = "Pending Amount " + ds10.Tables[0].Rows[0][0].ToString();
                        }
                        else
                            lblSubItem.Text = "Pending Amount 0 ";
                    }

                }
            }
            catch (Exception err)
            {
                err.GetBaseException();
            }
        }

        private void txtRate_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtQuantity.Text == "") { txtAmount.Text = ""; }
                else
                {
                    if (optSales.Checked == true)
                    {
                        //txtAmount.Text = (
                        //                            (Convert.ToDouble(txtQuantity.Text) * Convert.ToDouble(txtRate.Text))
                        //                            -
                        //                            (((Convert.ToDouble(txtQuantity.Text) * Convert.ToDouble(txtRate.Text)) * 13.5) / 100)
                        //                            ).ToString();
                        txtAmount.Text = (Convert.ToDouble(txtQuantity.Text) * (Convert.ToDouble(txtRate.Text.Trim()) * 100 / 118)).ToString();
                    }
                    else if (optPurchase.Checked == true)
                    {
                        txtAmount.Text = (Convert.ToDouble(txtQuantity.Text) * Convert.ToDouble(txtRate.Text)).ToString();

                    }
                }
            }
            catch (Exception err)
            {
                err.GetBaseException();
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            kryptonPanel6.Visible = true;
            kryptonPanel6.BringToFront();
            kryptonPanel7.Visible = false;
        }

        private void btnPClose_Click(object sender, EventArgs e)
        {
            kryptonPanel6.Visible = false;
            kryptonPanel6.SendToBack();
        }
        public bool Validate3(char flag, out string msg)
        {
            msg = "";
            bool v = true;

            if (flag == 'A' || flag == 'U')
                if (cmbTrans.SelectedIndex.Equals(0))
                {
                    v = false;
                    msg += "Select Transportation Name. " + System.Environment.NewLine;
                }
            if (flag == 'A' || flag == 'U')
                if (cmbVehical_No.SelectedIndex.Equals(0))
                {
                    v = false;
                    msg += "Select Vahicle Number. " + System.Environment.NewLine;
                }
            if (flag == 'A' || flag == 'U')
                if (txtDriverName.Text.Trim().Length <= 0)
                {
                    v = false;
                    msg += "Enter Driver Name. " + System.Environment.NewLine;
                }
            if (flag == 'A' || flag == 'U')
                if (txtContactNo.Text.Trim().Length <= 0)
                {
                    v = false;
                    msg += "Enter Contact Number. "+System.Environment.NewLine;
                } 
            
            return v;
        }
        private void btnTSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validate3('A', out msg))
                {
                    t = 1;
                    //bl_obj.TrasportEmp_Id= ;
                    bl_obj.TEmployee_Name = txtDriverName.Text;
                    bl_obj.TVehicale_Number = cmbVehical_No.Text;
                    bl_obj.TEmployee_Number = Convert.ToInt32(txtContactNo.Text);
                    bl_obj.Transportation = Convert.ToInt32(cmbTrans.SelectedValue);
                    kryptonPanel7.Visible = false;
                }
                else 
                    MyMessageBox.ShowBox(msg);
            }
            catch (Exception err)
            { err.GetBaseException(); }
        }

        private void btnTClose_Click(object sender, EventArgs e)
        {
            kryptonPanel7.Visible = false;
            kryptonPanel7.SendToBack();
        }

        private void btnTransport_Click(object sender, EventArgs e)
        {
            kryptonPanel6.Visible = false;
            kryptonPanel7.Visible = true;
            kryptonPanel7.BringToFront();
        }
        public bool Validate4(char flag, out string msg)
        {
            msg = "";
            bool v = true;

            if (flag == 'A' || flag == 'U')
                if (cmbPayMode.SelectedIndex.Equals(0))
                {
                    v = false;
                    msg += "Select PayMode Type. " + System.Environment.NewLine;
                }
            if (flag == 'A' || flag == 'U')
                if (cmbPayMode.SelectedIndex != 0 && cmbAccount.SelectedIndex == 0)
                {
                    v = false;
                    msg += "Select Account Type. " + System.Environment.NewLine;
                }
           
            if (flag == 'A' || flag == 'U')
                if (txtDetails.Text.Trim().Length <= 0)
                {
                    v = false;
                    msg += "Enter PayMode Number. " + System.Environment.NewLine;
                }
            if (flag == 'A' || flag == 'U')
                if (txtDescription.Text.Trim().Length <= 0)
                {
                    v = false;
                    msg += "Enter Discription. " + System.Environment.NewLine;
                }
            return v;
        }
        private void btnPSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validate4('A', out msg))
                {
                    p = 1;
                    bl_obj.Pay_Mode_Id = Convert.ToInt32(cmbPayMode.SelectedValue);
                    bl_obj.Number = txtDetails.Text;
                    bl_obj.Details = txtDescription.Text;
                    //if(optPurchase.Checked==true)
                    if(cmbPayMode.SelectedIndex!=0)
                        bl_obj.Account_Id = Convert.ToInt32(cmbAccount.SelectedValue.ToString()) ; 
                    else
                        bl_obj.Account_Id = 0; 
                    //else
                    //    bl_obj.Account_Id = 0; 
                    kryptonPanel6.Visible = false;
                    cmbPayMode.SelectedIndex = 0;
                    cmbAccount.SelectedIndex = 0;
                    txtDetails.Clear();
                    txtDescription.Clear();
                   
                }
                else
                    MyMessageBox.ShowBox(msg);
            }
            catch (Exception err) { err.GetBaseException(); }
        }

        private void txtInvoiceNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            bl.validateNumberNotFloat(e);
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            bl.validateNumber(e);
        }

        private void txtRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            bl.validateNumber(e);
        }

        //private void txtDisPercent_KeyPress(object sender, KeyPressEventArgs e)  // Put Minus amount condition is not allow
        //{
        //    bl.validateNumber(e);
        //}

        private void txtPayAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            bl.validateNumber(e);
        }

        private void txtVatPercent_KeyPress(object sender, KeyPressEventArgs e)
        {
            bl.validateNumber(e);
        }

        private void txtExciseDuety_KeyPress(object sender, KeyPressEventArgs e)
        {
            bl.validateNumber(e);
        }
        private void txtDriverName_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        private void txtContactNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            bl.validateNumber(e);
        }
        private void cmbSelectItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                //if (cmbSelectItem.SelectedIndex > 0)
                //{
                //    bl_obj.itemid = Convert.ToInt32(cmbSelectItem.SelectedValue);
                //    bl_obj.flag = "6";
                //    function.fillcombo(cmbSubItem, (bl_obj.dropdown(bl_obj)));
                //}
                //txtUnit.Text = "";
                int r = Convert.ToInt32(cmbSelectItem.SelectedIndex.ToString());
                if (optSales.Checked)
                {
                    bl_obj.Parameter.Clear();
                    bl_obj.Parameter.Add("@Sub_Item_ID", cmbSelectItem.SelectedValue.ToString());
                    bl_obj.Parameter.Add("@Tran_Date", dtpDate.Value.ToString("yyyy-MM-dd"));
                    bl_obj.Parameter.Add("@Flag", "S");
                    DataSet dsdata = bl_obj.blFill_Para_Name(bl_obj.Parameter, "sp_Get_Stock_Itemwise");
                    if (dsdata.Tables.Count > 0)
                    {
                        if (dsdata.Tables[0].Rows.Count > 0)
                        {
                            lblQtyBalance.Text = dsdata.Tables[0].Rows[0][0].ToString().CompareTo("") == 0 ? "0" : dsdata.Tables[0].Rows[0][0].ToString() + "  "
                                +(r.ToString().CompareTo("0") == 0  ? "" : MainDs.Tables[3].Rows[r - 1][3].ToString());
                            Availablestock=Convert.ToDouble( dsdata.Tables[0].Rows[0][0].ToString().CompareTo("") == 0 ? "0" : dsdata.Tables[0].Rows[0][0].ToString());
                        }
                        else
                        {
                            lblQtyBalance.Text = "0" + "  " + (r.ToString().CompareTo("0") == 0 ? "" : MainDs.Tables[3].Rows[r - 1][3].ToString()); ;
                        }
                    }
                    else
                    {
                        lblQtyBalance.Text = "0" + "  " + (r.ToString().CompareTo("0") == 0 ? "" : MainDs.Tables[3].Rows[r - 1][3].ToString()); ;
                    }
                }
                txtRate.Text = "";
                txtQuantity.Text = "";
                txtAmount.Text = "";

                if (optSales.Checked)
                {
                    if (r != 0)
                        txtUnit.Text = MainDs.Tables[3].Rows[r - 1][3].ToString();
                    else
                        lblQtyBalance.Text = "";
                }
                if (optPurchase.Checked)
                {
                    if (r != 0)
                        lblQtyBalance.Text = MainDs.Tables[2].Rows[r - 1][5].ToString();
                    else
                        lblQtyBalance.Text = "";
                }
                else txtUnit.Text = MainDs.Tables[2].Rows[r-1][5].ToString();
            }
            catch (Exception err)
            {
                err.GetBaseException(); txtUnit.Clear();
            }
        }

        private void cmbAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ParaName.Clear();
                Para.Clear();

                ParaName.Add("@Customer_Id");
                ParaName.Add("@flag");
                if (cmbAccount.SelectedIndex == 0)
                {
                    Para.Add("0");
                }
                else
                {
                    Para.Add(cmbAccount.SelectedValue.ToString());
                }
                Para.Add("OB");
                DataSet dsnew = new DataSet();
                dsnew = bl_obj.blFill_para_name(ParaName, Para, "SP_Report");
                txtAvailBalance.Text = dsnew.Tables[0].Rows[0][0].ToString();
            }catch(Exception err)
            {
                err.GetBaseException();
            }
        }

        private void cmbPayMode_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbPayMode.SelectedIndex != 0)
                cmbAccount.Enabled = true;
            else
                cmbAccount.Enabled = false;
        }

        private void txtDisPercent_KeyPress(object sender, KeyPressEventArgs e)
        {
            bl_obj.validateNumber(e);
        }

        private void cmbTrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbTrans.SelectedIndex != 0)
                {
                    

                    ParaName.Clear();
                    Para.Clear();
                    ParaName.Add("@Transportation_ID");
                    ParaName.Add("@Flag");
                    Para.Add(cmbTrans.SelectedIndex == 0 ? "0" : cmbTrans.SelectedValue.ToString());
                    Para.Add("S");
                    function.fillcombo(cmbVehical_No, blobj.blFill_Para_Name(ParaName, Para, "sp_Vehical_Details"));
                }
            }
            catch (Exception Ex)
            { }
        }

        private void cmbVehical_No_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbVehical_No.SelectedIndex != 0)
                {
                    DataSet ds = new DataSet();
                    ParaName.Clear();
                    Para.Clear();
                    ParaName.Add("@ID");
                    ParaName.Add("@Flag");
                    Para.Add(cmbVehical_No.SelectedValue.ToString());
                    Para.Add("V");
                    ds = blobj.blFill_Para_Name(ParaName, Para, "sp_Vehical_Details");
                    txtContactNo.Text = ds.Tables[0].Rows[0][4].ToString();
                    txtDriverName.Text = ds.Tables[0].Rows[0][2].ToString();
                }
                else
                {
                    txtContactNo.Text = "";
                    txtDriverName.Text = "";
                }
            }
            catch (Exception Ex)
            { }
        }
    }
}