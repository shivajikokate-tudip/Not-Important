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
    public partial class FRM_RPTROWMATERIALSTOCK : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        public FRM_RPTROWMATERIALSTOCK()
        {
            InitializeComponent();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            module_Rpt function = new module_Rpt();
            BUSSINESS_LAYER.BL bl_obj = new BUSSINESS_LAYER.BL();
            List<string> para_name = new List<string>();
            para_name.Add("@flag");
            para_name.Add("@From_Date");
            List<string> para_value = new List<string>();
            para_value.Add("FR");
            para_value.Add(kryptonDateTimePicker1.Value.ToString("yyyy-MM-dd"));

            ds = bl_obj.blFill_Para_Name(para_name, para_value, "SP_Report");
            function.Show_Report("rptRowMaterialStock", ds, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}