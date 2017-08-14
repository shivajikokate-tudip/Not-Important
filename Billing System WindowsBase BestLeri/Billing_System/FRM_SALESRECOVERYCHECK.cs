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
    public partial class FRM_SALESRECOVERYCHECK : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        MODULE function = new MODULE();
        BL_SALESRECOVERYCHECK bl_obj = new BL_SALESRECOVERYCHECK();
        public FRM_SALESRECOVERYCHECK()
        {
            InitializeComponent();
        }

        private void FRM_SALESRECOVERYCHECK_Load(object sender, EventArgs e)
        {
            function.settheme(this);
            // filldata();
        }
        private void FillLVW(DataSet ds)
        {
            try
            {
                lvw.Clear();
                List<ListViewColumnsInfo> list = new List<ListViewColumnsInfo>();
                list.Add(new ListViewColumnsInfo() { ColNumber = 1, ColumnSize = 120, Header = "Company Name", Visible = true });
                list.Add(new ListViewColumnsInfo() { ColNumber = 3, ColumnSize = 120, Header = "Invoice Number", Visible = true });
                list.Add(new ListViewColumnsInfo() { ColNumber = 4, ColumnSize = 120, Header = "On Credit", Visible = true });
                list.Add(new ListViewColumnsInfo() { ColNumber = 6, ColumnSize = 0, Header = "Date", Visible = true });
                list.Add(new ListViewColumnsInfo() { ColNumber = 0, ColumnSize = 0, Header = "Customer Id", Visible = true });
                list.Add(new ListViewColumnsInfo() { ColNumber = 2, ColumnSize = 0, Header = "Sales Id", Visible = true });
                list.Add(new ListViewColumnsInfo() { ColNumber = 5, ColumnSize = 0, Header = "SalesRecovery Id", Visible = true });
                function.filllvw(lvw, ds, list, ColumnHeaderStyle.Nonclickable, 0, 0);
            }
            catch (Exception err) { err.GetBaseException(); }
        }
        private void filldata()
        {
            try
            {
                DataSet ds = new DataSet();
                DataSet ds1 = new DataSet();
                ds = (bl_obj.SELECT(bl_obj));
                function.fillcombo(cmdName, ds.Tables[1]);
                //FillLVW(bl_obj.SELECT(bl_obj)); 
                FillLVW(ds);
                dtpDate.Value = Convert.ToDateTime(DateTime.Now.ToString());
            }
            catch (Exception err) { err.GetBaseException(); }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string msg = "";
            try
            {
                if (Validate('A', out msg))
                {
                    bl_obj.SalesRecoveryId = Convert.ToInt32(txtSalesRecoveryId.Text);
                    //bl_obj.SalesId =Convert.ToInt32(cmdName.SelectedValue.ToString());
                    bl_obj.Amount = Convert.ToDouble(txtAmount.Text);
                    bl_obj.Tran_Date = dtpDate.Value.ToString("yyyy-MM-dd");
                    FillLVW(bl_obj.UPDATE(bl_obj));
                    ClearControls();
                    KryptonMessageBox.Show("Record Save Successfilly", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MyMessageBox.ShowBox(msg);
            }
            catch (Exception err) { err.GetBaseException(); }
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
                    msg += "Something Went Wrong";
                }

            if (flag == 'A' || flag == 'U')
                if (optSales.Checked == false && optPurchase.Checked == false)
                {
                    v = false;
                    msg += "Select the Sales Or Purchase.  ";
                }
            if (flag == 'A' || flag == 'U')
                if (cmdName.SelectedIndex.Equals(0))
                {
                    v = false;
                    msg += "Select Customer/Firm name.  ";
                }
            if (flag == 'A' || flag == 'U')
                if (txtInvoiceNo.Text.Trim().Length <= 0)
                {
                    v = false;
                    msg += "Enter Invoice No.  ";
                }
            if (flag == 'A' || flag == 'U')
                if (dtpDate.Text.Trim().Length <= 0)
                {
                    v = false;
                    msg += "Select Date";
                }
            if (flag == 'A' || flag == 'U')
                if (txtAmount.Text.Trim().Length <= 0)
                {
                    v = false;
                    msg += "Enter the Amount.  ";
                }

            return v;
        }

        private void txtInvoiceNo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtInvoiceNo == null || txtInvoiceNo.Text.Length > 0)
                {
                    bl_obj.SalesRecoveryId = Convert.ToInt32(txtInvoiceNo.Text);
                    FillLVW(bl_obj.FillInvoice(bl_obj));
                }
                else ClearControls();
            }
            catch (Exception err) { err.GetBaseException(); }
        }
        public void ClearControls()
        {
            //filldata();
            //if (cmdName.Items.Count >= 0)
            //{
            //    cmdName.SelectedIndex = 0;

            //}
            lvw.Clear();
            cmdName.DataSource = null;
            txtInvoiceNo.Text = "";
            dtpDate.Text = "";
            // txtSalesRecoveryId.Text = "";

            txtAmount.Text = "";
        }

        public void clear()
        {
            optPurchase.Checked = false;
            optSales.Checked = false;
        }

        private void lvw_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                ListViewItem l = lvw.HitTest(e.Location).Item;
                if (l != null)
                {
                    txtSalesRecoveryId.Text = l.SubItems[6].Text.ToString();
                    cmdName.SelectedValue = l.SubItems[4].Text.ToString();
                    txtInvoiceNo.Text = l.SubItems[1].Text.ToString();
                    txtAmount.Text = l.SubItems[2].Text.ToString();
                    dtpDate.Value = Convert.ToDateTime(l.SubItems[3].Text.ToString());
                    bl_obj.SalesId = Convert.ToInt32( l.SubItems[5].Text.ToString());
                }
                else
                {
                    ClearControls();
                }
            }
            catch (Exception err) { err.GetBaseException(); }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            ClearControls();
            clear();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void optSales_CheckedChanged(object sender, EventArgs e)
        {
            ClearControls();
            bl_obj.form = "S";
            filldata();
        }

        private void optPurchase_CheckedChanged(object sender, EventArgs e)
        {
            ClearControls();
            bl_obj.form = "P";
            filldata();
        }

        private void txtInvoiceNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            bl_obj.validateNumberNotFloat(e);
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            bl_obj.validateNumberNotFloat(e);
        }
    }
}