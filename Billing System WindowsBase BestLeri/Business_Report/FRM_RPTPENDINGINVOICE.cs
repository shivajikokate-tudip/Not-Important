using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace Business_Report
{
    public partial class FRM_RPTPENDINGINVOICE : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        BUSSINESS_LAYER.BL bl_obj = new BUSSINESS_LAYER.BL();
        module_Rpt function = new module_Rpt();

        public FRM_RPTPENDINGINVOICE()
        {
            InitializeComponent();
        }

        private void FRM_RPTPENDINGINVOICE_Load(object sender, EventArgs e)
        {
            function.settheme(this);
            DataSet ds = bl_obj.blFill("SP_CustomerMaster");
            function.fillcombo(cmbCustomerName, ds.Tables[0]);

            lblCustomerName.Visible = false;
            lblAmount.Visible = false;
            txtAmount.Visible = false;
            cmbCustomerName.Visible = false;
            optDatewise.Checked = true;
            dtpFromDate.Value = Convert.ToDateTime("01/04/2017");
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;   // Do not resize the form.
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtAmount.Text == "" && cmbCustomerName.SelectedIndex == 0)
                {
                    if (optDatewise.Checked == true)
                    {
                        List<string> para_name = new List<string>();
                        para_name.Add("@From_Date");
                        para_name.Add("@To_Date");
                        para_name.Add("@flag");
                        List<string> para_value = new List<string>();
                        para_value.Add(function.date_save_to_db(dtpFromDate.Value));
                        para_value.Add(function.date_save_to_db(dtpToDate.Value));
                        //para_value.Add(dtpFromDate.Value.ToString("MM/dd/yyyy"));
                        //para_value.Add(dtpToDate.Value.ToString("MM/dd/yyyy"));
                        para_value.Add("SR");

                        DataSet ds = bl_obj.blFill_para_name(para_name, para_value, "SP_Report");

                        function.Show_Report("RptPendingInvoice", ds, 0, dtpFromDate.Value, dtpToDate.Value);
                    }
                }

                else if (cmbCustomerName.SelectedIndex == 0)
                {
                    if (optAmountwise.Checked == true)
                    {
                        List<string> para_name = new List<string>();
                        para_name.Add("@From_Date");
                        para_name.Add("@To_Date");
                        para_name.Add("@Data_Id");
                        para_name.Add("@flag");
                        List<string> para_value = new List<string>();
                        para_value.Add(function.date_save_to_db(dtpFromDate.Value));
                        para_value.Add(function.date_save_to_db(dtpToDate.Value));
                        para_value.Add(txtAmount.Text);
                        //para_value.Add(dtpFromDate.Value.ToString("MM/dd/yyyy"));
                        //para_value.Add(dtpToDate.Value.ToString("MM/dd/yyyy"));
                        para_value.Add("AA");

                        DataSet ds = bl_obj.blFill_para_name(para_name, para_value, "SP_Report");

                        function.Show_Report("RptPendingInvoice", ds, 0, dtpFromDate.Value, dtpToDate.Value);
                    }
                }

                else if (txtAmount.Text == "")
                {
                    if (optCustomerwise.Checked == true)
                    {
                        List<string> para_name = new List<string>();
                        para_name.Add("@From_Date");
                        para_name.Add("@To_Date");
                        para_name.Add("@Customer_Id");
                        para_name.Add("@flag");
                        List<string> para_value = new List<string>();
                        para_value.Add(function.date_save_to_db(dtpFromDate.Value));
                        para_value.Add(function.date_save_to_db(dtpToDate.Value));
                        para_value.Add(cmbCustomerName.SelectedValue.ToString());
                        //para_value.Add(dtpFromDate.Value.ToString("MM/dd/yyyy"));
                        //para_value.Add(dtpToDate.Value.ToString("MM/dd/yyyy"));
                        para_value.Add("PC");   // PC - Pending Invoice Customerwise

                        DataSet ds = bl_obj.blFill_para_name(para_name, para_value, "SP_Report");

                        function.Show_Report("RptPendingInvoiceCustomerwise", ds, 0, dtpFromDate.Value, dtpToDate.Value);
                    }
                }

                else
                {
                    List<string> para_name = new List<string>();
                    para_name.Add("@From_Date");
                    para_name.Add("@To_Date");
                    para_name.Add("@Customer_Id");
                    para_name.Add("@Data_Id");
                    para_name.Add("@flag");
                    List<string> para_value = new List<string>();
                    para_value.Add(function.date_save_to_db(dtpFromDate.Value));
                    para_value.Add(function.date_save_to_db(dtpToDate.Value));
                    para_value.Add(cmbCustomerName.SelectedValue.ToString());
                    para_value.Add(txtAmount.Text);
                    //para_value.Add(dtpFromDate.Value.ToString("MM/dd/yyyy"));
                    //para_value.Add(dtpToDate.Value.ToString("MM/dd/yyyy"));
                    para_value.Add("CA");

                    DataSet ds = bl_obj.blFill_para_name(para_name, para_value, "SP_Report");

                    function.Show_Report("RptPendingInvoice", ds, 1, dtpFromDate.Value, dtpToDate.Value);
                }
            }
            catch (Exception err)
            {
                err.GetBaseException();
            }
            clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }        

        private void cmbDatewise_CheckedChanged(object sender, EventArgs e)
        {
            if (optDatewise.Checked)
            {
                lblCustomerName.Visible = false;
                lblAmount.Visible = false;
                txtAmount.Visible = false;
                cmbCustomerName.Visible = false;
                dtpFromDate.Visible = true;
                dtpToDate.Visible = true;
                lblFromDate.Visible = true;
                lblToDate.Visible = true;
            }
        }

        private void CmbCustomerwise_CheckedChanged(object sender, EventArgs e)
        {
            if (optCustomerwise.Checked)
            {
                lblCustomerName.Visible = true;
                lblAmount.Visible = false;
                txtAmount.Visible = false;
                cmbCustomerName.Visible = true;
                dtpFromDate.Visible = true;
                dtpToDate.Visible = true;
                lblFromDate.Visible = true;
                lblToDate.Visible = true;
            }
        }

        private void cmbAmountwise_CheckedChanged(object sender, EventArgs e)
        {
            if (optAmountwise.Checked)
            {
                lblCustomerName.Visible = false;
                lblAmount.Visible = true;
                txtAmount.Visible = true;
                cmbCustomerName.Visible = false;
                dtpFromDate.Visible = true;
                dtpToDate.Visible = true;
                lblFromDate.Visible = true;
                lblToDate.Visible = true;
            }
        }

        private void clear()
        {
            if (optAmountwise.Checked)
            {
                txtAmount.Text = "";
            }
            else if (optCustomerwise.Checked)
            {
                cmbCustomerName.SelectedIndex = 0;
            }
            else
            { }
            dtpFromDate.Value = Convert.ToDateTime("01/04/2017");
            dtpToDate.Value = DateTime.Now.Date;

        }
    }
}