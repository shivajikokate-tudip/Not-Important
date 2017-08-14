using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace BILLING_SYSTEM
{
    public partial class frm_Check_Invoice : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        BUSSINESS_LAYER.BL bl_obj = new BUSSINESS_LAYER.BL();
        DataSet ds = new DataSet();
        MODULE function = new MODULE();
        string Record_Number = string.Empty;
        string bill_no = string.Empty;
        string FormFlag = string.Empty;
        string PassedDate=string.Empty;
        public frm_Check_Invoice()
        {
            InitializeComponent();
        }

        public frm_Check_Invoice(Form f, string pflag,string pdtp)
        {
            InitializeComponent();
            
            FormFlag = pflag;
            PassedDate = pdtp;
            if (FormFlag.Trim().CompareTo("S") == 0)
                rbSales.Checked = true;
            else if (FormFlag.Trim().CompareTo("P") == 0)
                rbPurchase.Checked = true;
            else
            { }
            dtpDate.Value = Convert.ToDateTime(PassedDate);
            this.TopMost=true;
            f.Dispose();
            
        }

        private void chkSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSelectAll.Checked == true)
            {
                foreach (ListViewItem lm in lvw.Items)
                {
                    lm.Checked = true;
                }
            }

            else
            {
                foreach (ListViewItem lm in lvw.Items)
                {
                    lm.Checked = false;
                }
            }
        }

        private void btnPass_Click(object sender, EventArgs e)
        {
            bool Flag = false;
            foreach (ListViewItem lm in lvw.CheckedItems)
            {
                bl_obj.Parameter.Clear();
                
                bl_obj.Parameter.Add("@ID", lm.SubItems[1].Text);
                bl_obj.Parameter.Add("@Date",Convert.ToDateTime(lm.SubItems[2].Text).ToString("yyyy-MM-dd"));
                bl_obj.Parameter.Add("@Paid", lm.SubItems[6].Text);
                if(rbSales.Checked==true)
                    bl_obj.Parameter.Add("@Flag", "S");
                else if (rbPurchase.Checked == true)
                    bl_obj.Parameter.Add("@Flag", "P");
                else if (rbExpence.Checked == true)
                {
                    bl_obj.Parameter.Add("@Flag", "E"); //bl_obj.Parameter.Add("@ID", lm.SubItems[1].Text);
                    bl_obj.Parameter.Add("@Type",lm.SubItems[7].Text);
                    
                }
                bl_obj.Parameter.Add("@Transaction_No", lm.SubItems[0].Text);
                bl_obj.Parameter.Add("@User_ID", MODULE.glb["SHOP_ID"].ToString());
               
                DataSet ds1 = bl_obj.blFill_Para_Name(bl_obj.Parameter, "sp_Approve_Invoice");
                Flag = true;


            }

            if (Flag)
            {
                chkSelectAll.Checked = false;
                lvw.Items.Clear();
                Getdata();
                KryptonMessageBox.Show("Record/s Approved Successfully");
            }
            else
            {
                KryptonMessageBox.Show("Select Record To Approve");
            }
        }

        private void rbSales_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSales.Checked == true)
            {
                Getdata();
                //FillLVW(ds, 0);
            }
            else
            { }
        }

        private void rbPurchase_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPurchase.Checked == true)
            {
                Getdata();
                //FillLVW(ds, 1);
            }
            else
            { }
        }

        private void frm_Check_Invoice_Load(object sender, EventArgs e)
        {
            try
            {
                
                
            }
            catch (Exception Ex)
            {
 
            }
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;   // Do not resize the form.
        }
        private void FillLVW(DataSet ds,int tblNo)
        {
            try
            {
                lvw.Items.Clear();
                lvw.Columns.Clear();
                List<ListViewColumnsInfo> list = new List<ListViewColumnsInfo>();
                list.Add(new ListViewColumnsInfo() { ColNumber = 0, ColumnSize = 100, Header = "INV. NO", Visible = true });
                list.Add(new ListViewColumnsInfo() { ColNumber = 1, ColumnSize = 0, Header = "Sales_ID", Visible = true });
                list.Add(new ListViewColumnsInfo() { ColNumber = 2, ColumnSize = 80, Header = "Date", Visible = true });
                list.Add(new ListViewColumnsInfo() { ColNumber = 3, ColumnSize = 0, Header = "ID", Visible = true });
                list.Add(new ListViewColumnsInfo() { ColNumber = 4, ColumnSize = 100, Header = "Customer Name", Visible = true });
                list.Add(new ListViewColumnsInfo() { ColNumber = 5, ColumnSize = 100, Header = "Amount", Visible = true });
                list.Add(new ListViewColumnsInfo() { ColNumber = 6, ColumnSize = 100, Header = "Paid", Visible = true });
                list.Add(new ListViewColumnsInfo() { ColNumber = 7, ColumnSize = 0, Header = "Type", Visible = true });
                function.filllvw(lvw, ds, list, ColumnHeaderStyle.Nonclickable, tblNo, 0);
                if (lvw.Items.Count > 0)
                { }
                else
                {
                    KryptonMessageBox.Show("Sorry, No Invoice/s Pending For Approve On Date : "+dtpDate.Value.Date.ToString("dd-MM-yyyy"));
                }
            }
            catch (Exception err) { err.GetBaseException(); }
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            
            try
            {
                Getdata();
            }
            catch (Exception Ex)
            {

            }
        }

        private void Getdata()
        {
            bool flag = false;
            bl_obj.Parameter.Clear();
            bl_obj.Parameter.Add("@Date", dtpDate.Value.Date.ToString("yyyy-MM-dd"));
            if (rbSales.Checked == true)
            {   
                flag = true;
            }
            else if (rbPurchase.Checked == true)
            {
                flag = true;
            }
            else if (rbExpence.Checked == true)
            {
                flag = true;
            }
            else
            {
                flag = false;
            }
            if (flag)
            {
                ds = bl_obj.blFill_Para_Name(bl_obj.Parameter, "sp_Approve_Invoice");
                if (rbPurchase.Checked == true)
                {
                    FillLVW(ds, 1);                    
                }
                else if (rbSales.Checked == true)
                {
                    FillLVW(ds, 0);
                }
                else if (rbExpence.Checked == true)
                {
                    FillLVW(ds, 2);
                }
                else
                { }
            }
            else
            {
                KryptonMessageBox.Show("Select SALES , PURCHASE OR EXPENCE");
            }
        }

        private void rbExpence_CheckedChanged(object sender, EventArgs e)
        {
            if (rbExpence.Checked == true)
            {
                Getdata();
                //FillLVW(ds, 2);
            }
            else
            { }
        }

        private void lvw_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ListView.SelectedListViewItemCollection lv = this.lvw.SelectedItems;
                foreach (ListViewItem im in lv)
                {
                    contextMenuStrip1.Items[0].Text = "SHOW INVOICE NO. : " + im.SubItems[0].Text.Trim();
                    bill_no = im.SubItems[0].Text.Trim();
                    contextMenuStrip1.Show(Control.MousePosition);
                    Record_Number = im.SubItems[0].Text.Trim();
                    //txtQty.Text = im.SubItems[1].Text.Trim();
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (rbExpence.Checked == true)
            {
                KryptonMessageBox.Show("Not Available.");
            }
            else
            {
                new FRM_UpdateInvoice(this,bill_no, rbSales.Checked == true ? 'S' : 'P',dtpDate.Value.Date.ToString("yyyy-MM-dd")).ShowDialog();                
            }
        }

        
       

        

    }
}