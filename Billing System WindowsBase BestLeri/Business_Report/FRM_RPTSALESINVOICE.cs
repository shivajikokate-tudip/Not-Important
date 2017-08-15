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
    public partial class FRM_RPTSALESINVOICE : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        BUSSINESS_LAYER.BL bl_obj = new BUSSINESS_LAYER.BL();
        module_Rpt function = new module_Rpt();
        CrystalDecisions.CrystalReports.Engine.ReportClass doc;
         

        public FRM_RPTSALESINVOICE()
        {
            InitializeComponent();
        }

        private void FRM_RPTSALESINVOICE_Load(object sender, EventArgs e)
        {
            function.settheme(this);            
            //DataSet ds = bl_obj.blFill("Sp_SalesInvoice");
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;   // Do not resize the form.
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> para_name = new List<string>();
                para_name.Add("@Data_Id");
                para_name.Add("@flag");
                List<string> para_value = new List<string>();
                para_value.Add(txtInvoiceNo.Text);
                para_value.Add("SI");

                DataSet ds = bl_obj.blFill_para_name(para_name, para_value, "SP_Report");
                function.Show_Report("RptSalesInvoice", ds, 0);
            }
            catch (Exception err)
            {
                err.GetBaseException();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}