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
    public partial class FRM_PRODUCTIONREPORT : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        BUSSINESS_LAYER.BL bl_obj = new BUSSINESS_LAYER.BL();
        module_Rpt function = new module_Rpt();

        public FRM_PRODUCTIONREPORT()
        {
            InitializeComponent();
        }

        private void FRM_PRODUCTIONREPORT_Load(object sender, EventArgs e)
        {
            dtpFromDate.Value = Convert.ToDateTime("01/04/2017");
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> para_name = new List<string>();
                para_name.Add("@From_Date");
                para_name.Add("@To_Date");
                para_name.Add("@flag");
                List<string> para_value = new List<string>();
                para_value.Add(function.date_save_to_db(dtpFromDate.Value));
                para_value.Add(function.date_save_to_db(dtpToDate.Value));
                para_value.Add("RP");

                DataSet ds = bl_obj.blFill_para_name(para_name, para_value, "SP_Report");

                function.Show_Report("rptProductionReport", ds, 0, dtpFromDate.Value, dtpToDate.Value);
            }
            catch (Exception err)
            { err.GetBaseException(); }
            clear();
        }

        private void clear()
        {
            dtpFromDate.Value = Convert.ToDateTime("01/04/2017");
            dtpToDate.Value = DateTime.Now.Date;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}