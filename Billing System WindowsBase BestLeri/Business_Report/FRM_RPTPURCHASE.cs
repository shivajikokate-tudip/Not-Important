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
    public partial class FRM_RPTPURCHASE : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        BUSSINESS_LAYER.BL bl_obj = new BUSSINESS_LAYER.BL();
        module_Rpt function = new module_Rpt();

        public FRM_RPTPURCHASE()
        {
            InitializeComponent();
        }

        private void FRM_RPTPURCHASE_Load(object sender, EventArgs e)
        {
            function.settheme(this);
            DataSet ds = bl_obj.blFill("SP_SupplierMaster");
            function.fillcombo(cmbSupplierName, ds.Tables[0]);
            DataSet ds1 = bl_obj.blFill("SP_RowMaterialMaster");
            function.fillcombo(cmbProductName, ds1.Tables[0]);

            lblSupplierName.Visible = false;
            cmbSupplierName.Visible = false;
            lblProductName.Visible = false;
            cmbProductName.Visible = false;

            optDatewise.Checked = true;
            dtpFromDate.Value = Convert.ToDateTime("01/04/2017");
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;   // Do not resize the form.
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            try
            {
                if (optDatewise.Checked==true)
                {
                    List<string> para_name = new List<string>();
                    para_name.Add("@From_Date");
                    para_name.Add("@To_Date");
                    para_name.Add("@flag");
                    List<string> para_value = new List<string>();
                    para_value.Add(function.date_save_to_db(dtpFromDate.Value));
                    para_value.Add(function.date_save_to_db(dtpToDate.Value));
                    para_value.Add("PD");
                    DataSet ds = bl_obj.blFill_para_name(para_name, para_value, "SP_Report");
                    function.Show_Report("RptPurchase", ds, 0, dtpFromDate.Value, dtpToDate.Value);
                }

                else if (optProductwise.Checked==true)
                {
                    List<string> para_name = new List<string>();
                    para_name.Add("@From_Date");
                    para_name.Add("@To_Date");
                    para_name.Add("@Data_Id");
                    para_name.Add("@flag");
                    List<string> para_value = new List<string>();
                    para_value.Add(function.date_save_to_db(dtpFromDate.Value));
                    para_value.Add(function.date_save_to_db(dtpToDate.Value));
                    para_value.Add(cmbProductName.SelectedIndex ==0?"0": cmbProductName.SelectedValue.ToString());
                    para_value.Add("PP");
                    DataSet ds = bl_obj.blFill_para_name(para_name, para_value, "SP_Report");
                    function.Show_Report("RptPurchase", ds, 0, dtpFromDate.Value, dtpToDate.Value);
                }

                else if (optSupplierwise.Checked==true)
                {
                    List<string> para_name = new List<string>();
                    para_name.Add("@From_Date");
                    para_name.Add("@To_Date");
                    para_name.Add("@Customer_Id");
                    para_name.Add("@flag");
                    List<string> para_value = new List<string>();
                    para_value.Add(function.date_save_to_db(dtpFromDate.Value));
                    para_value.Add(function.date_save_to_db(dtpToDate.Value));
                    para_value.Add(cmbSupplierName.SelectedIndex==0?"0": cmbSupplierName.SelectedValue.ToString());
                    para_value.Add("PS");
                    DataSet ds = bl_obj.blFill_para_name(para_name, para_value, "SP_Report");
                    function.Show_Report("RptPurchase", ds, 0, dtpFromDate.Value, dtpToDate.Value);
                }
                else
                { }
            }
            catch (Exception err)
            {
                err.GetBaseException();
            }
            clear();
        }

        private void clear()
        {
            if (optSupplierwise.Checked)
            {
                cmbSupplierName.SelectedIndex = 0;
            }
            else if (optProductwise.Checked)
            {
                cmbProductName.SelectedIndex = 0;
            }
            else { }
            dtpFromDate.Value = DateTime.Now.Date;
            dtpToDate.Value = DateTime.Now.Date;
        }

        private void optDatewise_CheckedChanged(object sender, EventArgs e)
        {
            if (optDatewise.Checked)
            {
                lblSupplierName.Visible = false;
                cmbSupplierName.Visible = false;
                lblProductName.Visible = false;
                cmbProductName.Visible = false;

                dtpFromDate.Visible = true;
                dtpToDate.Visible = true;
                lblFromDate.Visible = true;
                lblToDate.Visible = true;
            }
        }

        private void optSupplierwise_CheckedChanged(object sender, EventArgs e)
        {
            if (optSupplierwise.Checked)
            {
                lblSupplierName.Visible = true;
                cmbSupplierName.Visible = true;

                lblProductName.Visible = false;
                cmbProductName.Visible = false;
                dtpFromDate.Visible = true;
                dtpToDate.Visible = true;
                lblFromDate.Visible = true;
                lblToDate.Visible = true;
            }
        }

        private void optProductwise_CheckedChanged(object sender, EventArgs e)
        {
            lblProductName.Visible = true;
            cmbProductName.Visible = true;

            lblSupplierName.Visible = false;
            cmbSupplierName.Visible = false;
            dtpFromDate.Visible = true;
            dtpToDate.Visible = true;
            lblFromDate.Visible = true;
            lblToDate.Visible = true;
        }
        
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kryptonPanel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}