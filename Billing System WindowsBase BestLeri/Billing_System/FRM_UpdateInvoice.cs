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
    public partial class FRM_UpdateInvoice : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        BL bl = new BL();
        MODULE function = new MODULE(); module_Rpt function1 = new module_Rpt();
        BL_BILLINGINVOICE bl_obj = new BL_BILLINGINVOICE();
        DataSet ds = null;
        DataSet dsg = new DataSet();
        DataSet MainDs = new DataSet();
        BL blobj = new BL();
        int i, b, p = 0, t = 0;
        string msg = "";
        double Total, GrandTotal, Vat = 0;
        double TotalAmount = 0;
        string sname;
        int index_Of_Row = 0;
        int sales_ID = 0;
        int Invoice_No = 0;
        string FormFlag=string.Empty;
        string PassedDate=string.Empty;
        public FRM_UpdateInvoice()
        {
            InitializeComponent();
            FormFlag = string.Empty;
            dtpDate.Enabled = true;
            dtpDate.Value = DateTime.Now.Date;
        }
        public FRM_UpdateInvoice(Form f, string No,char Flag,string dtp)
        {
            InitializeComponent();
            if (No.Trim().CompareTo("") != 0)
            {
                Invoice_No = Int32.Parse(No);
                FormFlag = Flag.ToString();
                PassedDate = dtp;
                function.settheme(this); b = 1;
                kryptonPanel6.Visible = false;
                kryptonPanel7.Visible = false;
                BL bl_obj1 = new BL();
                DataSet dsdata = bl_obj1.blFill("sp_GetPreDetailsInvoice");

                if (dsdata.Tables.Count > 0)
                {
                    function.fillcombo(cmbPayMode, dsdata.Tables[0]);
                    function.fillcombo(cmbTrans, dsdata.Tables[1]);
                }
                btnPay.Visible = false;
                btnTransport.Visible = false;
                FindData(Int32.Parse(No),Flag);
                dtpDate.Enabled = true;
            }
            else
            { }
            f.Close();

        }
        private void optSales_CheckedChanged(object sender, EventArgs e)
        {
            clear();
            lblVat.Text = "Vat";
            lblFirmName.Text = "Customer Name";
            lblCarton.Visible = false;
            lblTransport.Visible = false;
            lblDiscount.Visible = true;
            txtInvoiceNo.Enabled = true;
            txtExciseDuety.Visible = false;
            cmbTransport.Visible = false;
            txtDisPercent.Visible = true;
            txtExciseAmount.Visible = false;

            datalist(); lblAvailableBalance.Text = "-";
            lblAvailableStock.Text = "-";
            btnPay.Visible = false;
            btnTransport.Visible = false;
            kryptonPanel6.Visible = false;
            kryptonPanel7.Visible = false;
        }

        private void optPurchase_CheckedChanged(object sender, EventArgs e)
        {
            clear();
            txtExciseAmount.Visible = true;
            lblFirmName.Text = "Firm Name";
            lblAvailableStock.Text = "-";
            lblCarton.Visible = true;
            lblTransport.Visible = false;
            lblDiscount.Visible = true;
            txtExciseDuety.Visible = true;
            cmbTransport.Visible = false;
            txtDisPercent.Visible = true;
            txtInvoiceNo.Enabled = true;
            datalist();
            btnPay.Visible = false;
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
                        lblAvailableBalance.Text = dsdata.Tables[0].Rows[0][0].ToString().CompareTo("") == 0 ? "0" : dsdata.Tables[0].Rows[0][0].ToString();
                    }
                    else
                    {
                        lblAvailableBalance.Text = "0";
                    }
                }
                else
                {
                    lblAvailableBalance.Text = "0";
                }
            }
        }

        private void UpdateInvoice_Load(object sender, EventArgs e)
        {
            function.settheme(this); b = 1;
            kryptonPanel6.Visible = false;
            kryptonPanel7.Visible = false;
            BL bl_obj1 = new BL();
            DataSet dsdata = bl_obj1.blFill("sp_GetPreDetailsInvoice");
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;   // Do not resize the form.

            if (dsdata.Tables.Count > 0)
            {
                function.fillcombo(cmbPayMode, dsdata.Tables[0]);
                function.fillcombo(cmbTrans, dsdata.Tables[1]);
            }
            btnPay.Visible = false;
            btnTransport.Visible = false;
            btnFind.Enabled = true;
        }
        public void clear()
        {

            if (cmdfirmname.Items.Count > 0)
                cmdfirmname.SelectedIndex = 0;
            if (cmbSelectItem.Items.Count > 0)
                cmbSelectItem.SelectedIndex = 0;
            if (cmbTransport.Items.Count > 0)
                cmbTransport.SelectedIndex = 0;
            b = 0;
            txtName.Clear();
            txtContact.Clear();
            txtAddress.Clear();
            txtExciseDuety.Text = "0";
            txtTotal.Clear();
            txtVatAmt.Clear();
            txtVatPercent.Clear();
            txtDisPercent.Text="0";
            txtGrandTotal.Clear();
            txtPayAmount.Text="0";
            txtCreditAmount.Clear();
            txtInvoiceNo.Clear();
            lvw.Items.Clear();
            p = 0; t = 0;
            clearproduct();
            txtDriverName.Clear();
            txtVehicleNo.Clear();
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
                //txtInvoiceNo.Text = ds.Tables[6].Rows[0][0].ToString();
            }
            else if (optPurchase.Checked) { function.fillcombo(cmbSelectItem, ds.Tables[2]); }
            return ds;
        }

        private void cmbSelectItem_SelectionChangeCommitted(object sender, EventArgs e)
        {
        //    try
        //    {

        //        //if (cmbSelectItem.SelectedIndex > 0)
        //        //{
        //        //    bl_obj.itemid = Convert.ToDouble(cmbSelectItem.SelectedValue);
        //        //    bl_obj.flag = "6";
        //        //    function.fillcombo(cmbSubItem, (bl_obj.dropdown(bl_obj)));
        //        //}
        //        //txtUnit.Text = "";
        //        if (optSales.Checked)
        //        {
        //            bl_obj.Parameter.Clear();
        //            bl_obj.Parameter.Add("@Sub_Item_ID", cmbSelectItem.SelectedValue.ToString());
        //            bl_obj.Parameter.Add("@Tran_Date", dtpDate.Value.ToString("yyyy-MM-dd"));
        //            bl_obj.Parameter.Add("@Flag", "S");
        //            DataSet dsdata = bl_obj.blFill_Para_Name(bl_obj.Parameter, "sp_Get_Stock_Itemwise");
        //            if (dsdata.Tables.Count > 0)
        //            {
        //                if (dsdata.Tables[0].Rows.Count > 0)
        //                {
        //                    lblAvailableStock.Text = dsdata.Tables[0].Rows[0][0].ToString().CompareTo("") == 0 ? "0" : dsdata.Tables[0].Rows[0][0].ToString();
        //                }
        //                else
        //                {
        //                    lblAvailableStock.Text = "0";
        //                }
        //            }
        //            else
        //            {
        //                lblAvailableStock.Text = "-";
        //            }
        //        }
        //        txtRate.Text = "";
        //        txtQuantity.Text = "";
        //        txtAmount.Text = "";
        //        int r = cmbSelectItem.SelectedIndex; if (optSales.Checked)
        //        {
        //            txtUnit.Text = ds.Tables[3].Rows[r ][3].ToString();
        //        }
        //        else txtUnit.Text = ds.Tables[2].Rows[r][5].ToString();
        //    }
        //    catch (Exception err)
        //    {
        //        err.GetBaseException(); txtUnit.Clear();
        //    }
        }

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
                        txtAmount.Text = (Convert.ToDouble(txtQuantity.Text) * (Convert.ToDouble(txtRate.Text.Trim()) * 100 / 113.5)).ToString();
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

        private void CalculateAmount()
        {
            txtAmount.Text = ((Convert.ToDouble(txtQuantity.Text) * Convert.ToDouble(txtRate.Text))).ToString();
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
                //if (float.Parse(txtPayAmount.Text.Trim()) > float.Parse(lblAvailableCash.Text.Trim()))
                //{
                //    //KryptonMessageBox.Show("Paid Cash Must Not be Greater Than Available Cash");
                //    //txtPayAmount.Text = "0";
                //    //txtPayAmount.SelectAll();
                //}
            }
        }
        private void FillLVW(DataSet ds)
        {
            try
            {
                lvw.Clear();
                List<ListViewColumnsInfo> list = new List<ListViewColumnsInfo>();
                list.Add(new ListViewColumnsInfo() { ColNumber = 0, ColumnSize = 190, Header = "ItemName", Visible = true });
                list.Add(new ListViewColumnsInfo() { ColNumber = 1, ColumnSize = 0, Header = "SubItemId", Visible = true });
                list.Add(new ListViewColumnsInfo() { ColNumber = 2, ColumnSize = 185, Header = "Quantity", Visible = true });
                list.Add(new ListViewColumnsInfo() { ColNumber = 3, ColumnSize = 185, Header = "Rate", Visible = true });
                list.Add(new ListViewColumnsInfo() { ColNumber = 4, ColumnSize = 185, Header = "Total", Visible = true });
                list.Add(new ListViewColumnsInfo() { ColNumber = 5, ColumnSize = 0, Header = "Flag", Visible = true });

                list.Add(new ListViewColumnsInfo() { ColNumber = 6, ColumnSize = 0, Header = "OldItem", Visible = true });
                list.Add(new ListViewColumnsInfo() { ColNumber = 7, ColumnSize = 0, Header = "OldItemID", Visible = true });
                list.Add(new ListViewColumnsInfo() { ColNumber = 8, ColumnSize = 0, Header = "OldQty", Visible = true });
                list.Add(new ListViewColumnsInfo() { ColNumber = 9, ColumnSize = 0, Header = "OldRate", Visible = true });
                list.Add(new ListViewColumnsInfo() { ColNumber = 10, ColumnSize = 0, Header = "OldTotal", Visible = true });
                list.Add(new ListViewColumnsInfo() { ColNumber = 11, ColumnSize = 0, Header = "Sales_ID", Visible = true });
                list.Add(new ListViewColumnsInfo() { ColNumber = 12, ColumnSize = 0, Header = "Invoice_No", Visible = true });
                list.Add(new ListViewColumnsInfo() { ColNumber = 13, ColumnSize = 0, Header = "Tras_Date", Visible = true });
                list.Add(new ListViewColumnsInfo() { ColNumber = 14, ColumnSize = 0, Header = "Customer_ID", Visible = true });
                list.Add(new ListViewColumnsInfo() { ColNumber = 15, ColumnSize = 0, Header = "Amount", Visible = true });
                list.Add(new ListViewColumnsInfo() { ColNumber = 16, ColumnSize = 0, Header = "Grand_Total", Visible = true });
                list.Add(new ListViewColumnsInfo() { ColNumber = 17, ColumnSize = 0, Header = "Paid", Visible = true });
                list.Add(new ListViewColumnsInfo() { ColNumber = 18, ColumnSize = 0, Header = "On_Credit", Visible = true });
                list.Add(new ListViewColumnsInfo() { ColNumber = 19, ColumnSize = 0, Header = "Discount", Visible = true });
                list.Add(new ListViewColumnsInfo() { ColNumber = 20, ColumnSize = 0, Header = "Vat", Visible = true });
                list.Add(new ListViewColumnsInfo() { ColNumber = 21, ColumnSize = 0, Header = "Sales_Details_id", Visible = true });
                

                function.filllvw(lvw, ds, list, ColumnHeaderStyle.Nonclickable, 0, 0);
            }
            catch (Exception err) { err.GetBaseException(); }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            cmbSelectItem.SelectionStart = 0;
            cmbSelectItem.SelectionLength = cmbSelectItem.Text.Length;
            sname = cmbSelectItem.Text;
            //try
            //{
                ////if (Validate1('A', out msg))
                ////{
                ////    int cnt = lvw.Items.Count - 1;
                ////    if (cnt == 0)
                ////    {
                ////        cnt = 1;
                ////    }
                ////    else
                ////    {
                ////        cnt = cnt + 1;
                ////    }
                ////    bool Found = false;
                ////    if (lvw.Items.Count > 0)
                ////    {
                ////        //Check if the product Id exists with the same Price
                ////        //foreach (DataGridViewRow row in dataGridView1.Rows)
                ////        //{
                ////        //    if (Convert.ToString(row.Cells[1].Value) == cmbSelectItem.SelectedValue.ToString())
                ////        //    {
                ////        //        //Update the Quantity of the found row
                ////        //        if (row.Cells[4].Value.ToString() == txtRate.Text.ToString())
                ////        //        {
                ////        //            row.Cells[3].Value = Convert.ToString(Convert.ToDouble(txtQuantity.Text) + Convert.ToDouble(row.Cells[3].Value));
                ////        //            row.Cells[5].Value = Convert.ToString(Convert.ToDouble(txtAmount.Text) + Convert.ToDouble(row.Cells[5].Value));

                ////        //        }
                ////        //        else
                ////        //            MyMessageBox.ShowBox(" Rate Not Match "); Found = true;
                ////        //    }
                ////        //}
                ////        //if (!Found)
                ////        //{
                ////        //    //Add the row to grid view
                ////        //    dataGridView1.Rows.Insert(0, cnt, cmbSelectItem.SelectedValue, sname, txtQuantity.Text.ToString(), txtRate.Text.ToString(), txtAmount.Text.ToString());
                ////        //}
                ////    }
                ////    else
                ////    {
                ////        //Add the row to grid view for the first time
                ////        //dataGridView1.Rows.Insert(0, cnt, cmbSelectItem.SelectedValue, sname, txtQuantity.Text.ToString(), txtRate.Text.ToString(), txtAmount.Text.ToString());
                ////    }
                    ///////////////////////////////////////////////////////////////////////
                    try
                    {
                        if (rbAdd.Checked)
                        {
                            try
                            {
                                if (Validate1('A', out msg))
                                {
                                    lvw.View = View.Details;
                                    lvw.GridLines = true;
                                    lvw.FullRowSelect = true;
                                    string[] arr = new string[15];
                                    ListViewItem lm;

                                    arr[0] = cmbSelectItem.Text.Trim();
                                    arr[1] = cmbSelectItem.SelectedValue.ToString();
                                    arr[2] = txtQuantity.Text.Trim();
                                    arr[3] = (Convert.ToDouble(txtRate.Text.Trim()) * 100 / 113.5).ToString().ToString();
                                    arr[4] = txtAmount.Text.Trim(); 
                                    arr[5] = "N";
                                    lm = new ListViewItem(arr);
                                    lvw.Items.Add(lm);

                                    //calculateTotal();
                                    //clear();
                                    cmbSelectItem.Focus();
                                    
                                    SetColorToRow(lvw.Items.Count - 1, "N");
                                }
                                else
                                {
                                }
                                //clear();
                            }
                            catch (Exception exc)
                            {

                            }
                        }
                        else if (rbEdit.Checked)
                        {
                            if (Validate1('A', out msg))
                            {
                                int Record_ID = 0;

                                Record_ID = index_Of_Row;

                                
                                lvw.Items[Record_ID].SubItems[0].Text = cmbSelectItem.Text.Trim();
                                lvw.Items[Record_ID].SubItems[1].Text = cmbSelectItem.SelectedValue.ToString().Trim();
                                lvw.Items[Record_ID].SubItems[2].Text = txtQuantity.Text.Trim();
                                lvw.Items[Record_ID].SubItems[3].Text = (Convert.ToDouble(txtRate.Text.Trim()) * 100 / 113.5).ToString().ToString();
                                lvw.Items[Record_ID].SubItems[4].Text = txtAmount.Text.Trim();
                                if (lvw.Items[Record_ID].SubItems[5].Text.Trim() == "A")
                                {
                                    lvw.Items[Record_ID].SubItems[5].Text = "U";
                                }
                                else if (lvw.Items[Record_ID].SubItems[5].Text.Trim() == "N")
                                {
                                    lvw.Items[Record_ID].SubItems[5].Text = "N";
                                }
                                else if (lvw.Items[Record_ID].SubItems[5].Text.Trim() == "D")
                                {
                                    lvw.Items[Record_ID].SubItems[5].Text = "U";
                                }
                                else
                                {

                                }
                                if (lvw.Items[Record_ID].SubItems[5].Text.Trim() == "U")
                                {
                                    SetColorToRow(Record_ID, "U");
                                }
                                else if (lvw.Items[Record_ID].SubItems[5].Text.Trim() == "N")
                                {
                                    SetColorToRow(Record_ID, "N");
                                }
                                else
                                {
                                    
                                }
                            }
                            //calculateTotal();
                        }                        

                        else
                        {
                            //amountset(); exciseduety(); vatpercent(); payamount();
                            gridamountcount();
                            exciseDuety(); vatcalculate();
                        }
                        cmbSelectItem.SelectedIndex = 0;
                        txtQuantity.Text = "0";
                        txtRate.Text = "0";
                        txtAmount.Text = "0";

                    }
                    catch (Exception exc)
                    {

                    }
                    /////////////////////////////////////////////////////////////////////////////
                    //gridamountcount(); amountset(); exciseduety(); vatpercent(); payamount();
                    gridamountcount();
                    exciseDuety(); vatcalculate();
            //this.dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);
                //    clearproduct();
                //    txtVatAmt.Clear();
                //    txtVatPercent.Clear();
                //    txtDisPercent.Clear();
                //    txtCreditAmount.Clear();
                //    txtPayAmount.Clear(); //txtCarton.Text = "0";
                //}
                //else
                //    MyMessageBox.ShowBox(msg);
            //}
            //catch (Exception err)
            //{
            //    err.GetBaseException();
            //}
        }

        private void SetColorToRow(int position, string flag)
        {
            if (flag == "D")
            {
                lvw.Items[position].ForeColor = Color.White;
                lvw.Items[position].BackColor = Color.Red;
                lvw.Items[position].SubItems[5].Text = "D";
                lvw.Items[position].Selected = false;
            }
            else if (flag == "U")
            {
                lvw.Items[position].ForeColor = Color.White;
                lvw.Items[position].BackColor = Color.Black;
            }
            else if (flag == "N")
            {
                lvw.Items[position].ForeColor = Color.White;
                lvw.Items[position].BackColor = Color.Green;
            }
        }
        private void gridamountcount()
        {
            if (lvw.Items.Count > 0)
            {
                TotalAmount = 0;
                foreach (ListViewItem lm in lvw.Items)
                {
                    if(lm.SubItems[5].Text.Trim().CompareTo("D")!=0)
                        TotalAmount = TotalAmount + Convert.ToDouble(lm.SubItems[4].Text.Trim());                    
                }
                txtTotal.Text =  TotalAmount.ToString();
                txtGrandTotal.Text = Math.Round(TotalAmount,2).ToString();
                GrandTotal = Convert.ToDouble(txtGrandTotal.Text);
            }
        }
        public void vatpercent()
        {
            try
            {
                if (txtTotal.Text != "")
                {
                    if (txtVatPercent.Text != "")
                    {
                        if (optSales.Checked)
                        {
                            txtVatAmt.Text = ((Convert.ToDouble(txtTotal.Text) * Convert.ToDouble(txtVatPercent.Text) / 100)).ToString();
                        }
                        else if (optPurchase.Checked)
                        {
                            txtVatAmt.Text = (
                            ((Convert.ToDouble(txtTotal.Text) + (Convert.ToDouble(txtTotal.Text) * Convert.ToDouble(txtExciseDuety.Text) / 100)) *
                        Convert.ToDouble(txtVatPercent.Text) / 100)
                            ).ToString();
                        }
                    }
                    else
                    {
                        txtVatAmt.Text = "";
                    }
                    if (optPurchase.Checked == true)
                    {
                        txtCreditAmount.Text = ((
                       (Convert.ToDecimal(txtTotal.Text.Trim().CompareTo("") == 0 ? "0" : txtTotal.Text.Trim()))
                           + (Convert.ToDecimal(txtExciseAmount.Text.Trim().CompareTo("") == 0 ? "0" : txtExciseAmount.Text.Trim()))
                               + (Convert.ToDecimal(txtVatAmt.Text.Trim().CompareTo("") == 0 ? "0" : txtVatAmt.Text.Trim()))
                                   - (Convert.ToDecimal(txtDisPercent.Text.Trim().CompareTo("") == 0 ? "0" : txtDisPercent.Text.Trim()))
                                       - (Convert.ToDecimal(txtPayAmount.Text.Trim().CompareTo("") == 0 ? "0" : txtPayAmount.Text.Trim()))
                                       )).ToString();
                        amountset();
                    }
                }
                else
                {
                    if (b == 1)
                        MyMessageBox.ShowBox("Select Product");
                    txtVatPercent.Text = "";
                }

            }
            catch (Exception err)
            {
                err.GetBaseException();
            }
        }
        public void txtVatPercent_TextChanged(object sender, EventArgs e)
        {
            vatcalculate();
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
                                /////////////////////////// Start For Header Insertion/////////////////////////
                                bl_obj.form = "SI";
                                bl_obj.Sales_Id = sales_ID = Convert.ToInt32(lvw.Items[0].SubItems[11].Text.Trim());
                                bl_obj.Invoice_Number = Invoice_No = Convert.ToInt32(txtInvoiceNo.Text.Trim());
                                bl_obj.Customer_Id = Convert.ToInt32(cmdfirmname.SelectedValue.ToString());
                                //bl_obj.Tras_Date =Convert .ToDateTime( function.convertdate_string_date(function.SysDate(), dtpDate));
                                bl_obj.Tras_Date = dtpDate.Value.ToString("yyyy-MM-dd");
                                bl_obj.Carton = Convert.ToInt32("0");
                                //bl_obj.Transportation_Id = Convert.ToDouble("0"); //cmbTransport.SelectedIndex;
                                bl_obj.Total = Convert.ToDouble(txtTotal.Text);
                                bl_obj.Vat = Convert.ToDouble(txtVatPercent.Text);
                                bl_obj.Discount = Convert.ToDouble(txtDisPercent.Text);
                                bl_obj.Grand_Total = Convert.ToDouble(txtGrandTotal.Text);
                                bl_obj.Paid = Convert.ToDouble(txtPayAmount.Text);
                                bl_obj.On_Credit = Convert.ToDouble(txtCreditAmount.Text);
                                ds1 = bl_obj.UPDATE(bl_obj);
                                ///////////////////////////End For Header Insertion/////////////////////////
                                
                                ///////////////////////////Start For Details Insertion/////////////////////////
                                if (lvw.Items.Count > 0)
                                {
                                    foreach (ListViewItem lm in lvw.Items)
                                    {
                                        if (lm.SubItems[5].Text.Trim().CompareTo("N") != 0)
                                        {
                                            bl_obj.Sales_Id = sales_ID = Convert.ToInt32(lm.SubItems[11].Text.Trim());
                                            bl_obj.Invoice_Number = Invoice_No = Convert.ToInt32(lm.SubItems[12].Text.Trim());
                                        }
                                        if (lm.SubItems[5].Text.Trim().CompareTo("A") == 0)
                                        {
                                            bl_obj.form = "SP";
                                            bl_obj.Tras_Date = dtpDate.Value.ToString("yyyy-MM-dd");
                                            bl_obj.Sales_Details_id = Convert.ToInt32(lm.SubItems[21].Text.Trim());
                                            bl_obj.SubItemId = Convert.ToInt32(lm.SubItems[1].Text.Trim());
                                            bl_obj.Quantity = Convert.ToDouble(lm.SubItems[2].Text.Trim());
                                            bl_obj.Rate = Convert.ToDouble(lm.SubItems[3].Text.Trim());
                                            bl_obj.Amount = Convert.ToDouble(lm.SubItems[4].Text.Trim());
                                            bl_obj.UPDATE(bl_obj);
                                        }
                                        else if (lm.SubItems[5].Text.Trim().CompareTo("U") == 0)
                                        {
                                            bl_obj.form = "SP";
                                            bl_obj.Tras_Date = dtpDate.Value.ToString("yyyy-MM-dd");
                                            bl_obj.Sales_Details_id = Convert.ToInt32(lm.SubItems[21].Text.Trim());
                                            bl_obj.SubItemId = Convert.ToInt32(lm.SubItems[1].Text.Trim());
                                            bl_obj.Quantity = Convert.ToDouble(lm.SubItems[2].Text.Trim());
                                            bl_obj.Rate = Convert.ToDouble(lm.SubItems[3].Text.Trim());
                                            bl_obj.Amount = Convert.ToDouble(lm.SubItems[4].Text.Trim());
                                            bl_obj.UPDATE(bl_obj);
                                        }
                                        else if (lm.SubItems[5].Text.Trim().CompareTo("D") == 0)
                                        {
                                            bl_obj.form = "SP";
                                            bl_obj.Tras_Date = dtpDate.Value.ToString("yyyy-MM-dd");
                                            bl_obj.Sales_Details_id = Convert.ToInt32(lm.SubItems[21].Text.Trim());
                                            bl_obj.SubItemId = Convert.ToInt32(lm.SubItems[1].Text.Trim());
                                            bl_obj.Quantity = 0;
                                            bl_obj.Rate = Convert.ToDouble(lm.SubItems[3].Text.Trim());
                                            bl_obj.Amount = Convert.ToDouble(lm.SubItems[4].Text.Trim());
                                            bl_obj.DELETE(bl_obj);
                                        }
                                        else if (lm.SubItems[5].Text.Trim().CompareTo("N") == 0)
                                        {
                                            bl_obj.form = "SP";
                                            bl_obj.Tras_Date = dtpDate.Value.ToString("yyyy-MM-dd");
                                            bl_obj.SubItemId = Convert.ToInt32(lm.SubItems[1].Text.Trim());
                                            bl_obj.Quantity = Convert.ToInt32(lm.SubItems[2].Text.Trim());
                                            bl_obj.Rate = Convert.ToDouble(lm.SubItems[3].Text.Trim());
                                            bl_obj.Amount = Convert.ToDouble(lm.SubItems[4].Text.Trim());
                                            bl_obj.INSERT(bl_obj);
                                        }
                                        else
                                        { }
                                    }
                                }
                                ///////////////////////////End For Details Insertion/////////////////////////
                //                if (t == 1)
                //                {
                //                    bl_obj.form = "TP";
                //                    bl_obj.INSERT(bl_obj);
                //                }
                //                if (p == 1)
                //                {
                //                    bl_obj.form = "PY"; bl_obj.flag = "S";
                //                    bl_obj.INSERT(bl_obj);
                //                }
                //                KryptonMessageBox.Show("Record Save Successfilly", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //                //KryptonMessageBox.Show("Do you want generate bill", "Yes", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                //                DialogResult Result = KryptonMessageBox.Show("Do you want generate bill", "Invoice Save Successfilly", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                //                if (Result == DialogResult.Yes)
                //                {
                //                    DataSet dsr = new DataSet();
                //                    dsr = bl_obj.REPORT(bl_obj);
                //                    function1.Show_Report("RptSalesInvoice", dsr, 0); clear(); b++; datalist();
                                //}
                                //else { clear(); b++; datalist(); }
                                clear();
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
                            ///////////////////////////Start For Header Insertion/////////////////////////
                            bl_obj.form = "PI";
                            bl_obj.Sales_Id = sales_ID = Convert.ToInt32(lvw.Items[0].SubItems[11].Text.Trim());
                            bl_obj.Invoice_Number = Convert.ToInt32(txtInvoiceNo.Text);
                            bl_obj.Customer_Id = cmdfirmname.SelectedIndex;
                            bl_obj.Tras_Date = dtpDate.Value.ToString("yyyy-MM-dd");
                            bl_obj.Total = Convert.ToDouble(txtTotal.Text);
                            bl_obj.Vat = Convert.ToDouble(txtVatPercent.Text);
                            bl_obj.Grand_Total = Convert.ToDouble(txtGrandTotal.Text);
                            bl_obj.Discount = Convert.ToDouble(txtExciseDuety.Text);
                            bl_obj.Paid = Convert.ToDouble(txtPayAmount.Text);
                            bl_obj.On_Credit = Convert.ToDouble(txtCreditAmount.Text);
                            ds1 = bl_obj.UPDATE(bl_obj);
                            
                            ///////////////////////////End For Header Insertion/////////////////////////

                            ///////////////////////////Start For Details Insertion/////////////////////////
                            if (lvw.Items.Count > 0)
                            {
                                foreach (ListViewItem lm in lvw.Items)
                                {
                                    if (lm.SubItems[5].Text.Trim().CompareTo("N") != 0)
                                    {
                                        bl_obj.Sales_Id = sales_ID = Convert.ToInt32(lm.SubItems[11].Text.Trim());
                                        bl_obj.Invoice_Number = Invoice_No = Convert.ToInt32(lm.SubItems[12].Text.Trim());
                                    }
                                    if (lm.SubItems[5].Text.Trim().CompareTo("A") == 0)
                                    {
                                        bl_obj.form = "PP";
                                        bl_obj.Tras_Date = dtpDate.Value.ToString("yyyy-MM-dd");
                                        bl_obj.Sales_Details_id = Convert.ToInt32(lm.SubItems[21].Text.Trim());
                                        bl_obj.SubItemId = Convert.ToInt32(lm.SubItems[1].Text.Trim());
                                        bl_obj.Quantity = Convert.ToDouble(lm.SubItems[2].Text.Trim());
                                        bl_obj.Rate = Convert.ToDouble(lm.SubItems[3].Text.Trim());
                                        bl_obj.Amount = Convert.ToDouble(lm.SubItems[4].Text.Trim());
                                        bl_obj.UPDATE(bl_obj);
                                    }
                                    else if (lm.SubItems[5].Text.Trim().CompareTo("U") == 0)
                                    {
                                        bl_obj.form = "PP";
                                        bl_obj.Tras_Date = dtpDate.Value.ToString("yyyy-MM-dd");
                                        bl_obj.Sales_Details_id = Convert.ToInt32(lm.SubItems[21].Text.Trim());
                                        bl_obj.SubItemId = Convert.ToInt32(lm.SubItems[1].Text.Trim());
                                        bl_obj.Quantity = Convert.ToDouble(lm.SubItems[2].Text.Trim());
                                        bl_obj.Rate = Convert.ToDouble(lm.SubItems[3].Text.Trim());
                                        bl_obj.Amount = Convert.ToDouble(lm.SubItems[4].Text.Trim());
                                        bl_obj.UPDATE(bl_obj);
                                    }
                                    else if (lm.SubItems[5].Text.Trim().CompareTo("D") == 0)
                                    {
                                        bl_obj.form = "PP";
                                        bl_obj.Tras_Date = dtpDate.Value.ToString("yyyy-MM-dd");
                                        bl_obj.Sales_Details_id = Convert.ToInt32(lm.SubItems[21].Text.Trim());
                                        bl_obj.SubItemId = Convert.ToInt32(lm.SubItems[1].Text.Trim());
                                        bl_obj.Quantity = 0;
                                        bl_obj.Rate = Convert.ToDouble(lm.SubItems[3].Text.Trim());
                                        bl_obj.Amount = Convert.ToDouble(lm.SubItems[4].Text.Trim());
                                        bl_obj.DELETE(bl_obj);
                                    }
                                    else if (lm.SubItems[5].Text.Trim().CompareTo("N") == 0)
                                    {
                                        bl_obj.form = "PP";
                                        bl_obj.Tras_Date = dtpDate.Value.ToString("yyyy-MM-dd");
                                        bl_obj.SubItemId = Convert.ToInt32(lm.SubItems[1].Text.Trim());
                                        bl_obj.Quantity = Convert.ToDouble(lm.SubItems[2].Text.Trim());
                                        bl_obj.Rate = Convert.ToDouble(lm.SubItems[3].Text.Trim());
                                        bl_obj.Amount = Convert.ToDouble(lm.SubItems[4].Text.Trim());
                                        bl_obj.INSERT(bl_obj);
                                    }
                                    else
                                    { }
                                }
                            }
                            ///////////////////////////End For Details Insertion/////////////////////////
                            if (p == 1)
                            {
                                bl_obj.form = "PY"; bl_obj.flag = "P";
                                bl_obj.INSERT(bl_obj);
                            } b++; clear(); datalist();
                            KryptonMessageBox.Show("Transaction No " + bl_obj.Sales_Id + " .", "Record Save Successfilly", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            MyMessageBox.ShowBox(msg);
                    }
                    KryptonMessageBox.Show("Record Updated Successfully");
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
                msg += "Do you want Sales or Purchase";
            }
            //if (flag == 'A' || flag == 'U')
            //    if (dataGridView1.RowCount <= 1)
            //    {
            //        v = false;
            //        msg += "Select Product";
            //    }
            if (flag == 'A' || flag == 'U')
                if (cmdfirmname.SelectedIndex.Equals(0))
                {
                    v = false;
                    msg += "Enter the Firm Name or Customer Name";
                }


            if (flag == 'A' || flag == 'U')
                if (txtVatPercent.Text.Trim().Length <= 0)
                {
                    v = false;
                    msg += "Enter Vat Percentage";
                }

            if (flag == 'A' || flag == 'U')
                if (txtInvoiceNo.Text.Trim().Length <= 0)
                {
                    v = false;
                    msg += "Enter Invoice No.";
                }

            if (flag == 'A' || flag == 'U')
                if (dtpDate.Value.ToString().Trim().Length <= 0)
                {
                    v = false;
                    msg += "Select Date";
                }
            if (flag == 'A' || flag == 'U')
                if (txtDisPercent.Text.Trim().Length <= 0)
                {
                    v = false;
                    msg += "Enter Discount";
                }

            if (flag == 'A' || flag == 'U')
                if (txtPayAmount.Text.Trim().Length <= 0)
                {
                    v = false;
                    msg += "Enter Pay Amount";
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
                    msg += "Select Item Name ";
                }
            if (flag == 'A' || flag == 'U')
                if (txtQuantity.Text.Trim().Length <= 0)
                {
                    v = false;
                    msg += "Enter Quantity ";
                }
            if (flag == 'A' || flag == 'U')
                if (txtRate.Text.Trim().Length <= 0)
                {
                    v = false;
                    msg += "Enter Rate ";
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
                    msg += "Enter Discount";
                }

            if (flag == 'A' || flag == 'U')
                if (txtPayAmount.Text.Trim().Length <= 0)
                {
                    v = false;
                    msg += "Enter Pay Amount";
                }
            return v;
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
                                txtGrandTotal.Text = (Math.Round(GrandTotal - Convert.ToDouble(txtDisPercent.Text), 2)).ToString();
                            }
                        }
                        else if (optPurchase.Checked == true)
                        {
                            if (txtDisPercent.Text != "")
                            {
                                txtGrandTotal.Text = (Math.Round(Total - Convert.ToDouble(txtDisPercent.Text), 2)).ToString();
                            }
                            else if (txtDisPercent.Text == "" && txtVatPercent.Text != "")
                            {
                                //txtGrandTotal.Text = (Math.Round(Total + (Total * Convert.ToDouble(txtVatPercent.Text) / 100))).ToString();
                                txtTotal.Text = (Total - Convert.ToDouble(txtVatAmt.Text.Trim())).ToString();
                            }
                            else if (txtDisPercent.Text != "" && txtVatPercent.Text != "")
                            {
                                txtGrandTotal.Text = (Math.Round(Total - Convert.ToDouble(txtDisPercent.Text.Trim().CompareTo("") == 0 ? "0" : txtDisPercent.Text.Trim()), 2)).ToString();
                                //txtGrandTotal.Text = (Math.Round(Total + (Total * Convert.ToDouble(txtVatPercent.Text) / 100) - Convert.ToDouble(txtDisPercent.Text))).ToString();
                                txtTotal.Text = (Total - Convert.ToDouble(txtVatAmt.Text.Trim())).ToString();
                            }
                            if (txtDisPercent.Text == "" && txtVatPercent.Text == "")
                            { txtGrandTotal.Text = Math.Round(Convert.ToDouble(txtTotal.Text.Trim()), 2).ToString(); }
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
                                (Convert.ToDouble(txtTotal.Text) * Convert.ToDouble(txtExciseDuety.Text) / 100)), 2).ToString();
                        }
                        else if (txtExciseDuety.Text == "" && txtVatPercent.Text != "")
                        {
                            txtGrandTotal.Text = (Math.Round(Convert.ToDouble(txtTotal.Text) + (Convert.ToDouble(txtTotal.Text) * Convert.ToDouble(txtVatPercent.Text) / 100), 2)).ToString();
                        }
                        else if (txtExciseDuety.Text != "" && txtVatPercent.Text != "")
                        {
                            txtGrandTotal.Text = (Math.Round((Convert.ToDouble(txtTotal.Text) +
                                (Convert.ToDouble(txtTotal.Text) * Convert.ToDouble(txtExciseDuety.Text) / 100)) +
                                ((Convert.ToDouble(txtTotal.Text) + (Convert.ToDouble(txtTotal.Text) * Convert.ToDouble(txtExciseDuety.Text) / 100)) *
                            Convert.ToDouble(txtVatPercent.Text) / 100) - Convert.ToDouble(txtDisPercent.Text)
                                , 2)).ToString();
                        }
                        if (txtExciseDuety.Text == "" && txtVatPercent.Text == "")
                        { txtGrandTotal.Text = Math.Round(Convert.ToDouble(txtTotal.Text.Trim()), 2).ToString(); }
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
        public void exciseduety()
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
                        txtExciseAmount.Text = "";
                    }
                }
                else
                {
                    if (b == 1)
                        MyMessageBox.ShowBox("Select Product");
                    txtVatPercent.Text = "";
                }
                if (optPurchase.Checked == true)
                    txtCreditAmount.Text = ((
                       (Convert.ToDecimal(txtTotal.Text.Trim().CompareTo("") == 0 ? "0" : txtTotal.Text.Trim()))
                           + (Convert.ToDecimal(txtVatAmt.Text.Trim().CompareTo("") == 0 ? "0" : txtVatAmt.Text.Trim()))
                               + (Convert.ToDecimal(txtExciseAmount.Text.Trim().CompareTo("") == 0 ? "0" : txtExciseAmount.Text.Trim()))
                                   - (Convert.ToDecimal(txtDisPercent.Text.Trim().CompareTo("") == 0 ? "0" : txtDisPercent.Text.Trim()))
                                       - (Convert.ToDecimal(txtPayAmount.Text.Trim().CompareTo("") == 0 ? "0" : txtPayAmount.Text.Trim()))
                                       )).ToString();


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

        public void vatcalculate()
        {
            try
            {
                if (txtTotal.Text != "")
                {
                    if (txtVatPercent.Text != "")
                    {
                        if (optSales.Checked == true)
                        {
                            //txtVatAmt.Text = (Math.Round(Convert.ToInt32(txtTotal.Text) * Convert.ToDouble(txtVatPercent.Text) / 100)).ToString();
                        }
                        else if (optPurchase.Checked == true)
                        {
                            txtVatAmt.Text = (
                                ((Convert.ToDouble(txtTotal.Text) + (Convert.ToDouble(txtTotal.Text) * Convert.ToDouble(txtExciseDuety.Text.CompareTo("") == 0 ? "0" : txtExciseDuety.Text) / 100)) *
                            Convert.ToDouble(txtVatPercent.Text.CompareTo("") == 0 ? "0" : txtVatPercent.Text) / 100)
                            ).ToString();
                            txtGrandTotal.Text = Math.Round(Convert.ToDouble(txtVatAmt.Text) + Convert.ToDouble(txtExciseAmount.Text) + Convert.ToDouble(txtTotal.Text), 2).ToString();
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

        public void payamount()
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
                }

                if (txtGrandTotal.Text != "" && txtPayAmount.Text != "")
                {
                    txtCreditAmount.Text = ((Convert.ToDouble(txtGrandTotal.Text) - Convert.ToDouble(txtPayAmount.Text)).ToString());
                }
                else if (txtGrandTotal.Text == "")
                {
                    if (b == 1)
                        MyMessageBox.ShowBox("Select Product");
                    //txtPayAmount.Text = "";
                }
                else { txtPayAmount.Text = ""; txtCreditAmount.Text = ""; }
            }
            catch (Exception err)
            {
                err.GetBaseException();
            }
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
                    int i = cmdfirmname.SelectedIndex - 1;
                    //txtName.Text = ds.Tables[0].Rows[0][2].ToString();
                    ds = (bl_obj.SELECT(bl_obj));
                    //cmdfirmname.SelectedIndex = Convert.ToDouble(ds.Tables[0].Rows[i][0].ToString());
                    txtName.Text = ds.Tables[0].Rows[i][2].ToString();
                    txtAddress.Text = ds.Tables[0].Rows[i][3].ToString();
                    txtContact.Text = ds.Tables[0].Rows[i][4].ToString();
                }
            }
            catch (Exception err)
            {
                err.GetBaseException();
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
                    int i = cmdfirmname.SelectedIndex - 1;
                    //txtName.Text = ds.Tables[0].Rows[0][2].ToString();
                    ds = (bl_obj.SELECT(bl_obj));
                    //cmdfirmname.SelectedIndex = Convert.ToDouble(ds.Tables[0].Rows[i][0].ToString());
                    txtName.Text = ds.Tables[0].Rows[i][2].ToString();
                    txtAddress.Text = ds.Tables[0].Rows[i][3].ToString();
                    txtContact.Text = ds.Tables[0].Rows[i][4].ToString();
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
                        txtAmount.Text = (Convert.ToDouble(txtQuantity.Text) * (Convert.ToDouble(txtRate.Text.Trim()) * 100 / 113.5)).ToString();
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (FormFlag.Trim().CompareTo("S") == 0)
                new frm_Check_Invoice(this, FormFlag, PassedDate).Show();
            else if (FormFlag.Trim().CompareTo("P") == 0)
                new frm_Check_Invoice(this, FormFlag, PassedDate).Show();
            else
                this.Close();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (txtInvoiceNo.Text.Trim().Length <= 0)
            {
                msg += "Enter Invoice No.";
            }
            else
            {
                bool flag = false;
                bl_obj.Invoice_Number = Convert.ToInt32(txtInvoiceNo.Text.Trim());
                DataSet dsr = new DataSet();
                blobj.Parameter.Clear();
                blobj.Parameter.Add("@Invoice_No", txtInvoiceNo.Text.Trim());
                if (optSales.Checked == true)
                {
                    blobj.Parameter.Add("@Flag", "S");
                    flag = true;
                }
                else if (optPurchase.Checked == true)
                {
                    blobj.Parameter.Add("@Flag", "P");
                    flag = true;
                }
                else
                {
                    flag = false;
                }
                if (flag)
                {
                    dsr = blobj.blFill_Para_Name(blobj.Parameter, "sp_GetDataForUpdate");
                    if (dsr.Tables.Count > 0)
                    {
                        if (dsr.Tables[0].Rows.Count > 0)
                        {
                            DataSet dsdata = new DataSet();
                            dsdata = dsr.Copy();
                            FillLVW(dsdata);
                            kryptonPanel4.Enabled = false;
                            kryptonPanel5.Enabled = false;
                            setData(dsdata);
                        }
                        else
                        {
                            KryptonMessageBox.Show("Sorry!! No Invoice Found For Updatation");
                            clear();
                        }
                    }
                    else
                    {
                        KryptonMessageBox.Show("Sorry!! No Invoice Found For Updatation");
                        clear();
                    }

                }
                else
                {
                    KryptonMessageBox.Show("Select Sales/Purchase Option");
                    clear();
                }

            }
        }
        private void FindData( int no,char rbFlag)
        {
            if (rbFlag.ToString().CompareTo("S") == 0 ? optSales.Checked = true : optPurchase.Checked = true)
            {
                txtInvoiceNo.Text = no.ToString();
                btnFind.Enabled = false;
            }
            if (no.ToString().Trim().Length <= 0)
            {
                msg += "Enter Invoice No.";
            }
            else
            {
                bool flag = false;
                bl_obj.Invoice_Number = no;
                DataSet dsr = new DataSet();
                blobj.Parameter.Clear();
                blobj.Parameter.Add("@Invoice_No", no.ToString());
                if (optSales.Checked == true)
                {
                    blobj.Parameter.Add("@Flag", "S");
                    flag = true;
                }
                else if (optPurchase.Checked == true)
                {
                    blobj.Parameter.Add("@Flag", "P");
                    flag = true;
                }
                else
                {
                    flag = false;
                }
                if (flag)
                {
                    dsr = blobj.blFill_Para_Name(blobj.Parameter, "sp_GetDataForUpdate");
                    if (dsr.Tables.Count > 0)
                    {
                        if (dsr.Tables[0].Rows.Count > 0)
                        {
                            DataSet dsdata = new DataSet();
                            dsdata = dsr.Copy();
                            FillLVW(dsdata);
                            kryptonPanel4.Enabled = false;
                            kryptonPanel5.Enabled = false;
                            setData(dsdata);
                        }
                        else
                        {
                            KryptonMessageBox.Show("Sorry!! No Invoice Found For Updatation");
                            clear();
                        }
                    }
                    else
                    {
                        KryptonMessageBox.Show("Sorry!! No Invoice Found For Updatation");
                        clear();
                    }

                }
                else
                {
                    KryptonMessageBox.Show("Select Sales/Purchase Option");
                    clear();
                }

            }
        }
        private void setData(DataSet ds)
        {
            if (optSales.Checked == true)
            {
                dtpDate.Value = Convert.ToDateTime(ds.Tables[0].Rows[0][13].ToString());
                cmdfirmname.SelectedValue = ds.Tables[0].Rows[0][14].ToString();
                txtTotal.Text = ds.Tables[0].Rows[0][15].ToString();
                txtGrandTotal.Text = ds.Tables[0].Rows[0][16].ToString();
                txtPayAmount.Text = ds.Tables[0].Rows[0][17].ToString();
                txtCreditAmount.Text = ds.Tables[0].Rows[0][18].ToString();
                txtDisPercent.Text = ds.Tables[0].Rows[0][19].ToString();
                txtVatPercent.Text = ds.Tables[0].Rows[0][20].ToString();
            }
            else if (optPurchase.Checked == true)
            {
                dtpDate.Value = Convert.ToDateTime(ds.Tables[0].Rows[0][13].ToString());
                cmdfirmname.SelectedValue = ds.Tables[0].Rows[0][14].ToString();
                txtTotal.Text = ds.Tables[0].Rows[0][15].ToString();
                txtGrandTotal.Text = ds.Tables[0].Rows[0][16].ToString();
                txtPayAmount.Text = ds.Tables[0].Rows[0][17].ToString();
                txtCreditAmount.Text = ds.Tables[0].Rows[0][18].ToString();
                txtExciseDuety.Text = ds.Tables[0].Rows[0][19].ToString();
                txtVatPercent.Text = ds.Tables[0].Rows[0][20].ToString();
            }
            else
            { }
        }

        private void rbAdd_CheckedChanged(object sender, EventArgs e)
        {
            kryptonPanel4.Enabled = true;
            kryptonPanel5.Enabled = false;
            lvw.CheckBoxes = false;
            clearproduct();
        }

        private void rbEdit_CheckedChanged(object sender, EventArgs e)
        {
            kryptonPanel4.Enabled = true;
            kryptonPanel5.Enabled = true;
            lvw.CheckBoxes = false; clearproduct();
        }

        private void rbDelete_CheckedChanged(object sender, EventArgs e)
        {
            kryptonPanel4.Enabled = false;
            kryptonPanel5.Enabled = true;
            lvw.CheckBoxes = true; clearproduct();
        }

        private void lvw_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            try
            {
                ListViewItem item = e.Item as ListViewItem;
                if (item.Checked == true)
                {
                    DialogResult rs = MessageBox.Show("Are you Sure to Delete Row :" + (item.Index + 1), " ", MessageBoxButtons.YesNo);
                    if (rs == DialogResult.Yes)
                    {
                        string flag = "";
                        //e.Item.Selected = false;

                        if (lvw.Items[item.Index].SubItems[5].Text.Trim() == "N")
                        {
                            lvw.Items.RemoveAt(item.Index);
                        }
                        else if (item.SubItems[5].Text == "A")
                        {
                            item.SubItems[5].Text = "D";
                            SetColorToRow(item.Index, "D");
                        }
                        else if (item.SubItems[5].Text == "U")
                        {
                            item.SubItems[5].Text = "D";
                            SetColorToRow(item.Index, "D");
                        }
                        else
                        {
                            //SetColorToRow(item.Index, "D");
                        }
                    }
                    else
                    {
                        item.Checked = false;
                    }
                }
                else if (item.Checked == false)
                {
                    //DialogResult rs = MessageBox.Show("Are you Sure to UnDelete Row :" + (item.Index + 1), " ", MessageBoxButtons.YesNo);
                    //if (rs == DialogResult.Yes)
                    //{
                    string flag = "";
                    //e.Item.Selected = false;
                    if (lvw.Items[item.Index].SubItems[5].Text.Trim() == "D")
                    {
                        item.SubItems[5].Text = "U";
                        SetColorToRow(item.Index, "U");
                    }
                    else
                    {

                    }
                }
                else
                {
                    //item.Checked = false;
                }
            }
            catch (Exception eee)
            { }
            gridamountcount(); 
            amountset(); 
            exciseduety();
            vatpercent(); 
            //payamount();
            txtCreditAmount.Text = ((Convert.ToDouble(txtGrandTotal.Text) - Convert.ToDouble(txtPayAmount.Text)).ToString());
        }

        private void lvw_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                ListView.SelectedListViewItemCollection lv = this.lvw.SelectedItems;
                foreach (ListViewItem im in lv)
                {
                    if (rbEdit.Checked)
                    {
                        cmbSelectItem.SelectedValue = Int32.Parse(im.SubItems[1].Text.Trim());
                        txtQuantity.Text = im.SubItems[2].Text;
                        txtRate.Text =  ((Convert.ToDouble(im.SubItems[3].Text.Trim())*113.5)/100).ToString();
                        txtTotal.Text = im.SubItems[4].Text;
                        index_Of_Row = im.Index;
                        
                        if (lvw.Items[im.Index].SubItems[5].Text.ToString().Trim() == "D")
                        {
                            DialogResult rs = MessageBox.Show("Do You Want To Undelete This Item", "", MessageBoxButtons.YesNo);
                            if (rs.ToString().CompareTo("Yes") == 0)
                            {
                                im.SubItems[5].Text = "U";
                            }
                            else
                            {

                            }
                        }
                        else
                        {

                        }
                    }
                    else
                    {
                        MessageBox.Show("First Select EDIT Otpion");
                    }
                }



            }
            catch (Exception ex)
            {
                
            }
            cmbSelectItem.Focus();
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
                            lblAvailableStock.Text = dsdata.Tables[0].Rows[0][0].ToString().CompareTo("") == 0 ? "0" : dsdata.Tables[0].Rows[0][0].ToString() + "  " + MainDs.Tables[3].Rows[r][3].ToString();
                        }
                        else
                        {
                            lblAvailableStock.Text = "0" + "  " + MainDs.Tables[3].Rows[r][3].ToString();
                        }
                    }
                    else
                    {
                        lblAvailableStock.Text = "0" + "  " + MainDs.Tables[3].Rows[r][3].ToString();
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
                        lblAvailableStock.Text = "";
                }
                if (optPurchase.Checked)
                {
                    if (r != 0)
                        lblAvailableStock.Text = MainDs.Tables[2].Rows[r - 1][5].ToString();
                    else
                        lblAvailableStock.Text = "";
                }
                else txtUnit.Text = MainDs.Tables[2].Rows[r][5].ToString();
            }
            catch (Exception err)
            {
                err.GetBaseException(); txtUnit.Clear();
            }
        }

        private void txtGrandTotal_TextChanged(object sender, EventArgs e)
        {
            
        }
        public void total()
        {
            if (optSales.Checked == true)
                txtCreditAmount.Text = (((Convert.ToDecimal(txtTotal.Text.Trim().CompareTo("") == 0 ? "0" : txtTotal.Text.Trim())) + (Convert.ToDecimal(txtVatAmt.Text.Trim().CompareTo("") == 0 ? "0" : txtVatAmt.Text.Trim())) - (Convert.ToDecimal(txtDisPercent.Text.Trim().CompareTo("") == 0 ? "0" : txtDisPercent.Text.Trim())) - (Convert.ToDecimal(txtPayAmount.Text.Trim().CompareTo("") == 0 ? "0" : txtPayAmount.Text.Trim())))).ToString();
            else if (optPurchase.Checked == true)
                txtCreditAmount.Text = ((
                    (Convert.ToDecimal(txtTotal.Text.Trim().CompareTo("") == 0 ? "0" : txtTotal.Text.Trim()))
                        + (Convert.ToDecimal(txtVatAmt.Text.Trim().CompareTo("") == 0 ? "0" : txtVatAmt.Text.Trim()))
                            + (Convert.ToDecimal(txtExciseAmount.Text.Trim().CompareTo("") == 0 ? "0" : txtExciseAmount.Text.Trim()))
                                - (Convert.ToDecimal(txtDisPercent.Text.Trim().CompareTo("") == 0 ? "0" : txtDisPercent.Text.Trim()))
                                    - (Convert.ToDecimal(txtPayAmount.Text.Trim().CompareTo("") == 0 ? "0" : txtPayAmount.Text.Trim()))
                                    )).ToString();
            else
                txtCreditAmount.Text = "0";
        }
        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
            total();
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

        private void txtDisPercent_KeyPress(object sender, KeyPressEventArgs e)
        {
            bl.validateNumber(e);
        }

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
    }
}