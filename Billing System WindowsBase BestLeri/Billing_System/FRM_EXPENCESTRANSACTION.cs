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
    public partial class FRM_EXPENCESTRANSACTION : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        BL bl = new BL();
        MODULE function = new MODULE();
        BL_EXPENCESTRANSACTION bl_obj = new BL_EXPENCESTRANSACTION();
        DataSet ds = new DataSet();
        DataSet dsf = new DataSet();
        List<string> ParaName = new List<string>();
        List<string> Para = new List<string>();
        string msg = "";
        string type = "";
        public FRM_EXPENCESTRANSACTION()
        {
            InitializeComponent();
        }

        private void FRM_EXPENCESTRANSACTION_Load(object sender, EventArgs e)
        {
            try
            {
                dtpDate.Value = Convert.ToDateTime(DateTime.Now.ToString());
                accounttype();
                DataSet ds1 = ds.Copy();
                //function.fillcombo(cmbMainAccountDr, ds.Tables[2]);
                //function.fillcombo(cmbMainAccountCr, ds1.Tables[2]);
                function.fillcombo(cmdTransactionMode, ds.Tables[1]);
                rbNew.Checked = true;
            }
            catch (Exception err)
            {
                err.GetBaseException();
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
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
                if (rbNew.Checked == true)
                {
                    if (Validate1('A', out msg))
                    {
                        if (dataGridView1.Rows.Count > 0)
                        {
                            //Check if the product Id exists with the same Price
                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                if (Convert.ToString(row.Cells[1].Value) == cmbSubAccountDr.SelectedValue.ToString())
                                {
                                    //Update the Quantity of the found row
                                    Found = true;
                                    MyMessageBox.ShowBox("Please Select Different Account For Creadit Voucher");
                                }
                            }
                            if (!Found)
                            {
                                //Add the row to grid view
                                if (cmdTransactionMode.SelectedIndex.Equals(2) || cmdTransactionMode.SelectedIndex.Equals(4))
                                {
                                    dataGridView1.Rows.Insert(0, cnt, cmbSubAccountDr.Text, cmbSubAccountCr.Text, cmbSubAccountDr.SelectedValue, cmbSubAccountCr.SelectedValue, txtDiscription.Text.ToString(), txtAmount.Text.ToString(), type, cmdTransactionMode.SelectedIndex);
                                }
                                else if (cmdTransactionMode.SelectedIndex.Equals(1) || cmdTransactionMode.SelectedIndex.Equals(3) || cmdTransactionMode.SelectedIndex.Equals(5))
                                {
                                    dataGridView1.Rows.Insert(0, cnt, cmbSubAccountDr.Text, cmbSubAccountCr.Text, cmbSubAccountDr.SelectedValue, cmbSubAccountCr.SelectedValue, txtDiscription.Text.ToString(), txtAmount.Text.ToString(), type, cmdTransactionMode.SelectedIndex);
                                }
                            }
                        }
                        else
                        {
                            //Add the row to grid view for the first time
                            if (cmdTransactionMode.SelectedIndex.Equals(2) || cmdTransactionMode.SelectedIndex.Equals(4))
                            {
                                dataGridView1.Rows.Insert(0, cnt, cmbSubAccountDr.Text, cmbSubAccountCr.Text, cmbSubAccountDr.SelectedValue, cmbSubAccountCr.SelectedValue, txtDiscription.Text.ToString(), txtAmount.Text.ToString(), type, cmdTransactionMode.SelectedIndex);
                            }
                            else if (cmdTransactionMode.SelectedIndex.Equals(1) || cmdTransactionMode.SelectedIndex.Equals(3) || cmdTransactionMode.SelectedIndex.Equals(5))
                            {
                                dataGridView1.Rows.Insert(0, cnt, cmbSubAccountDr.Text, cmbSubAccountCr.Text, cmbSubAccountDr.SelectedValue, cmbSubAccountCr.SelectedValue, txtDiscription.Text.ToString(), txtAmount.Text.ToString(), type, cmdTransactionMode.SelectedIndex);
                            }
                        }
                    }
                    else
                        MyMessageBox.ShowBox(msg);

                }
                else if (rbUpdate.Checked == true)
                {
                    if (Validate1('U', out msg))
                    {

                        dataGridView1.Rows[0].Cells["Column2"].Value = cmbSubAccountDr.Text;
                        dataGridView1.Rows[0].Cells["Credit_Account"].Value = cmbSubAccountCr.Text;
                        dataGridView1.Rows[0].Cells["Column1"].Value = cmbSubAccountDr.SelectedValue;
                        dataGridView1.Rows[0].Cells["Credit_Acc_ID"].Value = cmbSubAccountCr.SelectedValue;
                        dataGridView1.Rows[0].Cells["Column3"].Value = txtDiscription.Text.ToString();
                        dataGridView1.Rows[0].Cells["Column5"].Value = txtAmount.Text.ToString();
                        dataGridView1.Rows[0].Cells["DC"].Value = type;
                    }
                    else
                        MyMessageBox.ShowBox(msg);
                }
                else if (rbDelete.Checked == true)
                {

                }
                //gridamountcount(); 
                this.dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);


                gridamountcount();

                //if (cmdTransactionMode.SelectedIndex > 0)
                //    if (cmdTransactionMode.SelectedIndex.Equals(3))
                //    {
                //        if (dataGridView1.RowCount < 3)
                //        {
                //            MyMessageBox.ShowBox("Please Enter Credit Vaucher");
                //            type = "C"; bl_obj.id = "A"; debitcredit();
                //            cmdTransactionMode.Enabled = false;
                //            txtAmount.Enabled = false;
                //        }
                //    }
            }
            catch (Exception err)
            {
                err.GetBaseException();
            }
            clear();

        }
        public void clear()
        {
            if (cmbSubAccountDr.Items.Count > 0)
                cmbSubAccountDr.SelectedIndex = 0;
            //if (cmbMainAccountDr.Items.Count > 0)
            //    cmbMainAccountDr.SelectedIndex = 0;
            //if (cmbSubAccountCr.Items.Count > 0)
            //    cmbSubAccountCr.SelectedIndex = 0;
            //if (cmbMainAccountCr.Items.Count > 0)
            //    cmbMainAccountCr.SelectedIndex = 0;
            txtDiscription.Clear();
            txtAmount.Clear();

        }
        public void clearall()
        {
            clear();
            txtTokanNo.Clear();
            txtAmount.Clear();
            if (cmdTransactionMode.Items.Count > 0)
                cmdTransactionMode.SelectedIndex = 0;
            //if (cmbMainAccountCr.Items.Count > 0)
            //    cmbMainAccountCr.SelectedIndex = 0;
            //if (cmbMainAccountDr.Items.Count > 0)
            //    cmbMainAccountDr.SelectedIndex = 0;
            dataGridView1.Rows.Clear();
            cmdTransactionMode.Enabled = true;
            txtAmount.Enabled = true;
            txtInvoiceNo.Clear();
        }
        private void gridamountcount()
        {
            if (dataGridView1.RowCount > 1)
            {
                for (int j = 2; j <= dataGridView1.RowCount; j++)
                {
                    dataGridView1.Rows[j - 2].Cells[0].Value = j - 1;
                }
            }
        }

        public bool Validate(char flag, out string msg)
        {
            msg = "";
            bool v = true;

            if (flag == 'A' || flag == 'U')
                if (dataGridView1.RowCount <= 1)
                {
                    v = false;
                    msg += "Enter Voucher";
                }
            //if (flag == 'A' || flag == 'U')
            //    if (cmdTransactionMode.SelectedIndex.Equals(0))
            //    {
            //        v = false;
            //        msg += "Select Transaction Mode";
            //    }
            if (flag == 'A' || flag == 'U')
                if (dtpDate.Value.ToString().Trim().Length <= 0)
                {
                    v = false;
                    msg += "Select Date";
                }
            return v;
        }

        public bool Validate1(char flag, out string msg)
        {
            msg = "";
            bool v = true;

            //if (flag == 'A' || flag == 'U')
            //    if (cmdTransactionMode.SelectedIndex.Equals(0))
            //    {
            //        v = false;
            //        msg += "Select Transaction Mode.  ";
            //    }
            //if (flag == 'A' || flag == 'U')
            //    if (cmbMainAccountDr.SelectedIndex.Equals(0))
            //    {
            //        v = false;
            //        msg += "Select Main Account Dr. Type.  ";
            //    }
            if (flag == 'A' || flag == 'U')
                if (cmbSubAccountDr.SelectedIndex.Equals(0))
                {
                    v = false;
                    msg += "Select SubAccount Dr. Type.  ";
                }
            //if (flag == 'A' || flag == 'U')
            //    if (cmbMainAccountCr.SelectedIndex.Equals(0))
            //    {
            //        v = false;
            //        msg += "Select Main Account Cr. Type.  ";
            //    }
            if (flag == 'A' || flag == 'U')
                if (cmbSubAccountCr.SelectedIndex.Equals(0))
                {
                    v = false;
                    msg += "Select SubAccount Cr. Type.  ";
                }
            if (flag == 'A' || flag == 'U')
                if (txtAmount.Text.Trim().Length <= 0)
                {
                    v = false;
                    msg += "Enter Amount.  ";
                }
            if (flag == 'A' || flag == 'U')
                if (txtDiscription.Text.Trim().Length <= 0)
                {
                    v = false;
                    msg += "Enter Discription.  ";
                }
            if (flag == 'A')
                if (dataGridView1.Rows.Count > 1)
                {
                    v = false;
                    msg += "Please Submit Previous Voucher Entry.  ";
                }
            return v;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);
            }
            gridamountcount();
        }

        private void txtTokanNo_TextChanged(object sender, EventArgs e)
        {
            if (rbUpdate.Checked == true || rbDelete.Checked == true)
            {
                bl_obj.TransationNo = txtTokanNo.Text;
                dsf = bl_obj.Tokenno(bl_obj);
                FillForUpdate(dsf);
            }
        }
        private void FillForUpdate(DataSet ds)
        {
            try
            {
                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        string TransactionFlag = string.Empty;
                        TransactionFlag = ds.Tables[0].Rows[0][12].ToString().Substring(0,2);

                        if (TransactionFlag.Trim().CompareTo("CD") == 0)
                        {
                            cmdTransactionMode.SelectedIndex = 1;
                        }
                        else if (TransactionFlag.Trim().CompareTo("CC") == 0)
                        {
                            cmdTransactionMode.SelectedIndex = 2;
                        }
                        else if (TransactionFlag.Trim().CompareTo("BD") == 0)
                        {
                            cmdTransactionMode.SelectedIndex = 3;
                        }
                        else if (TransactionFlag.Trim().CompareTo("BC") == 0)
                        {
                            cmdTransactionMode.SelectedIndex = 4;
                        }
                        else if (TransactionFlag.Trim().CompareTo("TR") == 0)
                        {
                            cmdTransactionMode.SelectedIndex = 5;
                        }
                        else
                        {
                            cmdTransactionMode.SelectedIndex = 0;
                        }

                        txtT_ID.Text = ds.Tables[0].Rows[0][0].ToString();
                        //cmbMainAccountDr.SelectedValue = ds.Tables[0].Rows[0][4].ToString();
                        cmbSubAccountDr.SelectedValue = ds.Tables[0].Rows[0][2].ToString();
                        //cmbMainAccountCr.SelectedValue = ds.Tables[0].Rows[0][5].ToString();
                        cmbSubAccountCr.SelectedValue = ds.Tables[0].Rows[0][3].ToString();
                        txtAmount.Text = ds.Tables[0].Rows[0][8].ToString();
                        txtDiscription.Text = ds.Tables[0].Rows[0][13].ToString();
                        dataGridView1.Rows.Clear();
                        dataGridView1.Rows.Insert(0, 1, cmbSubAccountDr.Text, cmbSubAccountCr.Text, cmbSubAccountDr.SelectedValue, cmbSubAccountCr.SelectedValue, txtDiscription.Text.ToString(), txtAmount.Text.ToString(), type);
                        //cmbMainAccountDr.Enabled = false;
                        //cmbMainAccountCr.Enabled = false;
                        //cmbSubAccountDr.Enabled = false;
                        //cmbSubAccountCr.Enabled = false;
                    }
                }
            }
            catch (Exception Ex)
            { }
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validate('A', out msg))
                {
                    if (dataGridView1.RowCount > 1)
                    {
                        //if (cmdTransactionMode.SelectedIndex.Equals(3))
                        //{
                        for (int j = 2; j <= dataGridView1.RowCount; j++)
                        {
                            //if (dataGridView1.RowCount == 3)
                            //{
                            //bl_obj.SubExpences_ID = Convert.ToInt32(dataGridView1.Rows[j - 2].Cells[3].Value);

                            //bl_obj.TransactionModeId = Convert.ToInt32((cmdTransactionMode.SelectedIndex));
                            //bl_obj.TransationNo = txtTokanNo.Text;
                            //bl_obj.InvoiceNo = Convert.ToInt32(txtInvoiceNo.Text);
                            //bl_obj.Tras_Date = dtpDate.Value.ToString("yyyy-MM-dd");
                            //bl_obj.Discription = (dataGridView1.Rows[j - 2].Cells[3].Value).ToString();
                            //bl_obj.Amount = Convert.ToDouble(dataGridView1.Rows[j - 2].Cells[4].Value);
                            //bl_obj.Type = dataGridView1.Rows[j - 2].Cells[5].Value.ToString();
                            //bl_obj.INSERT(bl_obj);
                            if (rbNew.Checked == true)
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
                                
                                Para.Add((dataGridView1.Rows[j - 2].Cells[3].Value).ToString());
                                Para.Add((dataGridView1.Rows[j - 2].Cells[4].Value).ToString());
                                Para.Add((dataGridView1.Rows[j - 2].Cells[6].Value).ToString());
                                Para.Add("0");

                                Para.Add(cmdTransactionMode.SelectedIndex.ToString());
                                Para.Add((dataGridView1.Rows[j - 2].Cells[5].Value).ToString());
                                Para.Add("E");
                                Para.Add("E");
                                Para.Add(MODULE.glb["SHOP_ID"].ToString());
                                Para.Add("A");
                                Para.Add(txtTokanNo.Text);
                                Para.Add(dtpDate.Value.ToString("yyyy-MM-dd"));
                                bl_obj.blFill_para_name(ParaName, Para, "sp_Payment_Transaction_Details");

                                KryptonMessageBox.Show("Record Save Successfilly", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else if (rbUpdate.Checked == true)
                            {
                                ParaName.Clear();
                                Para.Clear();
                                ParaName.Add("@T_ID");
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

                                Para.Add(txtT_ID.Text);
                                Para.Add((dataGridView1.Rows[j - 2].Cells[3].Value).ToString());
                                Para.Add((dataGridView1.Rows[j - 2].Cells[4].Value).ToString());

                                Para.Add((dataGridView1.Rows[j - 2].Cells[6].Value).ToString());
                                Para.Add("0");
                                Para.Add("0");
                                Para.Add((dataGridView1.Rows[j - 2].Cells[5].Value).ToString());
                                Para.Add("E");
                                Para.Add("E");
                                Para.Add(MODULE.glb["SHOP_ID"].ToString());
                                Para.Add("U");
                                Para.Add(txtTokanNo.Text);
                                Para.Add(dtpDate.Value.ToString("yyyy-MM-dd"));
                                bl_obj.blFill_para_name(ParaName, Para, "sp_Payment_Transaction_Details");

                                KryptonMessageBox.Show("Record Updated Successfilly", "UPDATE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                            else if (rbDelete.Checked == true)
                            {
                                ParaName.Clear();
                                Para.Clear();
                                ParaName.Add("@T_ID");
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

                                Para.Add(txtT_ID.Text);
                                Para.Add((dataGridView1.Rows[j - 2].Cells[3].Value).ToString());
                                Para.Add((dataGridView1.Rows[j - 2].Cells[4].Value).ToString());

                                Para.Add((dataGridView1.Rows[j - 2].Cells[6].Value).ToString());
                                Para.Add("0");
                                Para.Add("0");
                                Para.Add((dataGridView1.Rows[j - 2].Cells[5].Value).ToString());
                                Para.Add("E");
                                Para.Add("E");
                                Para.Add(MODULE.glb["SHOP_ID"].ToString());
                                Para.Add("D");
                                Para.Add(txtTokanNo.Text);
                                Para.Add(dtpDate.Value.ToString("yyyy-MM-dd"));
                                bl_obj.blFill_para_name(ParaName, Para, "sp_Payment_Transaction_Details");

                                KryptonMessageBox.Show("Record Updated Successfilly", "UPDATE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else { }
                            //}
                            //else
                            //{
                            //    MyMessageBox.ShowBox("Invalid Vhoucher"); clearall(); break;
                            //}
                        }
                        //}
                        //else
                        //{
                        //    for (int j = 2; j <= dataGridView1.RowCount; j++)
                        //    {
                        //        if (dataGridView1.RowCount == 2)
                        //        {
                        //            bl_obj.SubExpences_ID = Convert.ToInt32(dataGridView1.Rows[j - 2].Cells[1].Value);
                        //            bl_obj.TransactionModeId = Convert.ToInt32((cmdTransactionMode.SelectedIndex));
                        //            bl_obj.TransationNo = txtTokanNo.Text;
                        //            bl_obj.InvoiceNo = Convert.ToInt32(txtInvoiceNo.Text);
                        //            bl_obj.Tras_Date = dtpDate.Value.ToString("yyyy-MM-dd");
                        //            bl_obj.Discription = (dataGridView1.Rows[j - 2].Cells[3].Value).ToString();
                        //            bl_obj.Amount = Convert.ToDouble(dataGridView1.Rows[j - 2].Cells[4].Value);
                        //            bl_obj.Type = dataGridView1.Rows[j - 2].Cells[5].Value.ToString();
                        //            bl_obj.INSERT(bl_obj);
                        //            KryptonMessageBox.Show("Record Save Successfilly", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //        }
                        //        else
                        //        {
                        //            MyMessageBox.ShowBox("Invalid Vhoucher"); clearall(); break;
                        //        }
                        //    }
                        //}
                    }
                }
                else
                    MyMessageBox.ShowBox(msg);
                clearall(); accounttype();
            }
            catch (Exception err)
            {
                err.GetBaseException();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdTransactionMode_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                //if (cmdTransactionMode.SelectedIndex > 0)
                //    if (cmdTransactionMode.SelectedIndex.Equals(3))
                //    {
                //        txtTokanNo.Text = ("TR" + bl_obj.Tran_Expences_ID).ToString(); lblAmount.Text = "Amount";
                //        MyMessageBox.ShowBox("Please Enter Debit Vaucher");
                //        type = "D"; bl_obj.id = "L";
                //        debitcredit();
                //    }
                //if (cmdTransactionMode.SelectedIndex.Equals(2))
                //{
                //    txtTokanNo.Text = ("CCP" + bl_obj.Tran_Expences_ID).ToString(); type = "C"; bl_obj.id = "A"; debitcredit();
                //    ////lblAmount.Text = cmbSubItem.SelectedValue
                //    //string type = cmdTransactionMode.SelectedValue.ToString();
                //}
                //if (cmdTransactionMode.SelectedIndex.Equals(1))
                //{
                //    txtTokanNo.Text = ("DCP" + bl_obj.Tran_Expences_ID).ToString(); type = "D"; bl_obj.id = "L"; debitcredit();
                //}

            }
            catch (Exception err)
            {
                err.GetBaseException();
            }
        }
        public void debitcredit()
        {

            //function.fillcombo(cmbMainAccountDr, (bl_obj.dc(bl_obj)));
        }
        public void accounttype()
        {
            ds = (bl_obj.SELECT(bl_obj));
            ParaName.Clear();
            Para.Clear();
            ParaName.Add("@Flag");
            Para.Add("M");
            DataSet dsdata = bl_obj.blFill_Para_Name(ParaName, Para, "sp_Payment_Transaction_Details");
            if (dsdata.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < dsdata.Tables[0].Rows.Count; i++)
                {
                    //bl_obj.Tran_Expences_ID = Convert.ToInt32(ds.Tables[0].Rows[i][0].ToString()) + 1;
                    bl_obj.Tran_Expences_ID = Convert.ToInt32(dsdata.Tables[0].Rows[0][0].ToString());
                }
            }
            else bl_obj.Tran_Expences_ID = 1;
             type = "D"; bl_obj.id = "L"; debitcredit();
        }

        private void cmbItem_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //try
            //{
            //    if (cmbMainAccountDr.SelectedIndex > 0)
            //    {
            //        bl_obj.Expences_ID = Convert.ToInt32(cmbMainAccountDr.SelectedValue);
            //        function.fillcombo(cmbSubAccountDr, (bl_obj.dropdown(bl_obj)));


            //        //if (cmbMainAccountDr.SelectedIndex == 1)
            //        //{
            //        //    SortedList<string, string> list = new SortedList<string, string>();
            //        //    list.Add("@flag", "8");
            //        //    list.Add("@Option_Type", "I");
            //        //    ds = bl_obj.blFill_Para_Name(list, "SP_FILLDDL");
            //        //    function.fillcombo(cmbSubAccountDr, ds.Tables[0]);
            //        //}
            //        //if (cmbMainAccountDr.SelectedIndex == 2)
            //        //{
            //        //    SortedList<string, string> list = new SortedList<string, string>();
            //        //    list.Add("@flag", "8");
            //        //    list.Add("@Option_Type", "E");
            //        //    ds = bl_obj.blFill_Para_Name(list, "SP_FILLDDL");
            //        //    function.fillcombo(cmbSubAccountDr, ds.Tables[0]);
            //        //}
            //        //if (cmbMainAccountDr.SelectedIndex == 3)
            //        //{
            //        //    SortedList<string, string> list = new SortedList<string, string>();
            //        //    list.Add("@flag", "8");
            //        //    list.Add("@Option_Type", "A");
            //        //    ds = bl_obj.blFill_Para_Name(list, "SP_FILLDDL");
            //        //    function.fillcombo(cmbSubAccountDr, ds.Tables[0]);
            //        //}
            //        //if (cmbMainAccountDr.SelectedIndex == 4)
            //        //{
            //        //    SortedList<string, string> list = new SortedList<string, string>();
            //        //    list.Add("@flag", "8");
            //        //    list.Add("@Option_Type", "L");
            //        //    ds = bl_obj.blFill_Para_Name(list, "SP_FILLDDL");
            //        //    function.fillcombo(cmbSubAccountDr, ds.Tables[0]);
            //        //}
            //    }
            //}
            //catch (Exception err)
            //{
            //    err.GetBaseException();
            //}
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearall();
        }

        private void cmdTransactionMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmdTransactionMode.SelectedIndex == 1)
                {
                    FillDDL("1",1,0);
                    cmdTransactionMode.Enabled = true;
                    cmbSubAccountCr.Enabled=true;
                    cmbSubAccountDr.Enabled = false;
                    cmbSubAccountDr.SelectedIndex=1;
                    if(rbNew.Checked==true)
                    txtTokanNo.Text = ("CD" + bl_obj.Tran_Expences_ID).ToString();
                    lblSubAccountDr.Text = "Debit Account";
                    lblSubAccountCr.Text = "Credit Account";
                }
                else if (cmdTransactionMode.SelectedIndex == 2)
                {
                    FillDDL("2",0,1);
                    cmdTransactionMode.Enabled = true;
                    cmbSubAccountCr.Enabled=false;
                    cmbSubAccountDr.Enabled = true;
                    cmbSubAccountCr.SelectedIndex=1;
                    if (rbNew.Checked == true)
                    txtTokanNo.Text = ("CC" + bl_obj.Tran_Expences_ID).ToString();
                    lblSubAccountDr.Text = "Debit Account";
                    lblSubAccountCr.Text = "Credit Account";
                }
                else if (cmdTransactionMode.SelectedIndex == 3)
                {
                    FillDDL("3",1,0);
                    cmdTransactionMode.Enabled = true;
                    cmbSubAccountCr.Enabled=true;
                    cmbSubAccountDr.Enabled = true;
                    cmbSubAccountCr.SelectedIndex=0;
                    if (rbNew.Checked == true)
                    txtTokanNo.Text = ("BD" + bl_obj.Tran_Expences_ID).ToString();
                    lblSubAccountDr.Text = "Debit Account";
                    lblSubAccountCr.Text = "Credit Account";
                }
                else if (cmdTransactionMode.SelectedIndex == 4)
                {
                    FillDDL("4",0,1);
                    cmdTransactionMode.Enabled = true;
                    cmbSubAccountCr.Enabled=true;
                    cmbSubAccountDr.Enabled = true;
                    cmbSubAccountCr.SelectedIndex=0;
                    if (rbNew.Checked == true)
                    txtTokanNo.Text = ("BC" + bl_obj.Tran_Expences_ID).ToString();
                    lblSubAccountDr.Text = "Debit Account";
                    lblSubAccountCr.Text = "Credit Account";
                }
                else if (cmdTransactionMode.SelectedIndex == 5)
                {
                    FillDDL("5",0,0);
                    cmdTransactionMode.Enabled = true;
                    cmbSubAccountCr.Enabled = true;
                    cmbSubAccountDr.Enabled = true;
                    if (rbNew.Checked == true)
                    txtTokanNo.Text = ("TR" + bl_obj.Tran_Expences_ID).ToString();
                    lblSubAccountDr.Text = "Debit Account";
                    lblSubAccountCr.Text = "Credit Account";
                }
                else
                {
                    bl_obj.Expences_ID = 0;
                    function.fillcombo(cmbSubAccountDr, (bl_obj.dropdown(bl_obj)));
                    cmdTransactionMode.Enabled = true;
                    if (rbNew.Checked == true)
                    txtTokanNo.Text = "";//("TRN" + bl_obj.Tran_Expences_ID).ToString();
                    lblSubAccountDr.Text = "Debit Account";
                    lblSubAccountCr.Text = "Credit Account";
                }

                //else
                //{
                //    //KryptonMessageBox.Show("Select Transaction Mode.");
                //    //cmdTransactionMode.Enabled = false;
                //}
            }
            catch (Exception Ex)
            { }
            //if (cmdTransactionMode.SelectedIndex == 1)
            //{
                
            //}
            //else if (cmdTransactionMode.SelectedIndex == 2)
            //{

            //}
            //else if (cmdTransactionMode.SelectedIndex == 3)
            //{

            //}
            //else
            //{
            //    KryptonMessageBox.Show("Select Transaction Mode.");
            //}
        }

        private void FillDDL(string id, int debitTbl_No, int creditTbl_No)
        {
            
            Para.Clear();
            Para.Add(id);
            Para.Add("A");
            DataSet ds = new DataSet();
            ds = bl_obj.blFill_para(Para, "sp_Fill_DDL_Transaction");
            function.fillcombo(cmbSubAccountDr, ds.Tables[debitTbl_No]);
            if(id.CompareTo("5")!=0)
                function.fillcombo(cmbSubAccountCr, ds.Tables[creditTbl_No]);
            
        }
        private void txtInvoiceNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            bl.validateNumberNotFloat(e);
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            bl.validateNumberNotFloat(e);
        }

        private void cmbMainAccountCr_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void rbNew_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNew.Checked == true)
            {
                txtTokanNo.Enabled = false;
                txtTokanNo.Text = ("TRN" + bl_obj.Tran_Expences_ID).ToString(); type = "D"; bl_obj.id = "L"; debitcredit();
                btnAdd.Text = "ADD";
                //cmbMainAccountDr.Enabled = true;
                //cmbMainAccountCr.Enabled = true;
                cmbSubAccountDr.Enabled = true;
                cmbSubAccountCr.Enabled = true;
                btnAdd.Enabled = true;
                btnDelete.Enabled = true;
                //cmbMainAccountDr.SelectedIndex = 0;
                //cmbMainAccountCr.SelectedIndex = 0;
                cmbSubAccountDr.SelectedIndex = 0;
                cmbSubAccountCr.SelectedIndex = 0;
                txtAmount.Text = "0";
                txtDiscription.Clear();
            }
        }

        private void rbUpdate_CheckedChanged(object sender, EventArgs e)
        {
            if (rbUpdate.Checked == true)
            {
                txtTokanNo.Enabled = true;
                btnAdd.Text = "UPDATE";
                btnAdd.Enabled = true;
                btnDelete.Enabled = false;
            }
        }

        private void rbDelete_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDelete.Checked == true)
            {
                txtTokanNo.Enabled = true;
                btnAdd.Text = "ADD";
                //cmbMainAccountDr.Enabled = true;
                //cmbMainAccountCr.Enabled = true;
                cmbSubAccountDr.Enabled = true;
                cmbSubAccountCr.Enabled = true;
                btnAdd.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        private void txtTokanNo_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void cmbMainAccountDr_SelectedIndexChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    if (cmbMainAccountDr.SelectedIndex > 0)
            //    {
            //        bl_obj.Expences_ID = Convert.ToInt32(cmbMainAccountDr.SelectedValue);
            //        function.fillcombo(cmbSubAccountDr, (bl_obj.dropdown(bl_obj)));
            //    }
            //}
            //catch (Exception Ex)
            //{ }
        }

        private void cmbMainAccountCr_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //if (cmbMainAccountDr.SelectedIndex > 0)
                //{
                //    bl_obj.Expences_ID = Convert.ToInt32(cmbMainAccountDr.SelectedValue);
                //    ParaName.Clear();
                //    Para.Clear();
                //    ParaName.Add("@Taluka_id");
                //    ParaName.Add("@itemid");
                //    ParaName.Add("@flag");
                //    Para.Add(cmbSubAccountDr.SelectedValue.ToString());
                //    Para.Add(cmbMainAccountCr.SelectedValue.ToString());
                //    Para.Add("10");
                //    function.fillcombo(cmbSubAccountCr, (bl_obj.blFill_Para_Name(ParaName, Para, "SP_FILLDDL")));

                //    //try
                //    //{
                //    //    if (cmbMainAccountCr.SelectedIndex == 1)
                //    //    {
                //    //        SortedList<string, string> list = new SortedList<string, string>();
                //    //        list.Add("@flag", "8");
                //    //        list.Add("@Option_Type", "I");
                //    //        ds = bl_obj.blFill_Para_Name(list, "SP_FILLDDL");
                //    //        function.fillcombo(cmbSubAccountCr, ds.Tables[0]);
                //    //    }
                //    //    if (cmbMainAccountCr.SelectedIndex == 2)
                //    //    {
                //    //        SortedList<string, string> list = new SortedList<string, string>();
                //    //        list.Add("@flag", "8");
                //    //        list.Add("@Option_Type", "E");
                //    //        ds = bl_obj.blFill_Para_Name(list, "SP_FILLDDL");
                //    //        function.fillcombo(cmbSubAccountCr, ds.Tables[0]);
                //    //    }
                //    //    if (cmbMainAccountCr.SelectedIndex == 3)
                //    //    {
                //    //        SortedList<string, string> list = new SortedList<string, string>();
                //    //        list.Add("@flag", "8");
                //    //        list.Add("@Option_Type", "A");
                //    //        ds = bl_obj.blFill_Para_Name(list, "SP_FILLDDL");
                //    //        function.fillcombo(cmbSubAccountCr, ds.Tables[0]);
                //    //    }
                //    //    if (cmbMainAccountCr.SelectedIndex == 4)
                //    //    {
                //    //        SortedList<string, string> list = new SortedList<string, string>();
                //    //        list.Add("@flag", "8");
                //    //        list.Add("@Option_Type", "L");
                //    //        ds = bl_obj.blFill_Para_Name(list, "SP_FILLDDL");
                //    //        function.fillcombo(cmbSubAccountCr, ds.Tables[0]);
                //    //    }
                //    //}
                //    //catch (Exception err) { err.GetBaseException(); }
            }
            
            catch (Exception Ex)
            { }
        }

        private void cmbSubAccountDr_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbSubAccountDr.SelectedIndex == 0)
                {
                    //cmbMainAccountCr.Enabled = false;
                    cmbSubAccountCr.Enabled = false;
                }
                else if (cmdTransactionMode.SelectedIndex == 5 || cmdTransactionMode.SelectedIndex == 4 || cmdTransactionMode.SelectedIndex == 3)
                {
                    //cmbMainAccountCr.Enabled = true;
                    cmbSubAccountCr.Enabled = true;

                    Para.Clear();
                    Para.Add(cmbSubAccountDr.SelectedValue.ToString());
                    Para.Add("T");
                    Para.Add(cmdTransactionMode.SelectedValue.ToString());
                    DataSet ds = new DataSet();
                    ds = bl_obj.blFill_para(Para, "sp_Fill_DDL_Transaction");
                    function.fillcombo(cmbSubAccountCr, ds.Tables[0]);
                    //cmbMainAccountCr.SelectedIndex = 0;

                }
            }
            catch (Exception Ex)
            { }
        }
    }
}