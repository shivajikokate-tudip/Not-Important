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
    public partial class FRM_DayBook : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        BUSSINESS_LAYER.BL bl_obj = new BUSSINESS_LAYER.BL();
        module_Rpt function = new module_Rpt();

        public FRM_DayBook()
        {
            InitializeComponent();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
                module_Rpt function = new module_Rpt();
                BUSSINESS_LAYER.BL bl_obj = new BUSSINESS_LAYER.BL();
                List<string> para_name = new List<string>();
                para_name.Add("@flag");
                para_name.Add("@From_Date");
                List<string> para_value = new List<string>();
                para_value.Add("DB");
                para_value.Add(kryptonDateTimePicker1.Value.ToString("yyyy-MM-dd"));

                ds = bl_obj.blFill_Para_Name(para_name, para_value, "SP_Report");
                function.Show_Report("rptDayBook", ds, 0);
            }
            catch (Exception err)
            {
                err.GetBaseException();
            }
        }

        private void FRM_DayBook_Load(object sender, EventArgs e)
        {
            function.settheme(this);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;   // Do not resize the form.
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}