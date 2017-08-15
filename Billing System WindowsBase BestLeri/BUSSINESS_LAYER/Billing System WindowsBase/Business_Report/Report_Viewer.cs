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
    public partial class Report_Viewer : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        BUSSINESS_LAYER.BL bl_obj = new BUSSINESS_LAYER.BL();
        module_Rpt function = new module_Rpt();
        int Tableno;
        DataTable common_dt = new DataTable();
        bool f = false;
        List<string> paraname = new List<string>();
        List<string> paravalue = new List<string>();
        DataSet ds = new DataSet();
        CrystalDecisions.CrystalReports.Engine.ReportClass doc;

        public Report_Viewer()
        {
            InitializeComponent();
        }
        public Report_Viewer(DataSet ds, int tableno)
        {
            InitializeComponent();
            dataSet1 = ds;
            Tableno = tableno;

        }

        public Report_Viewer(int tableno, DataSet ds)
        {
            InitializeComponent();
            dataSet1 = ds;
            Tableno = tableno;
            f = true;
        }


        private void Report_Viewer_Load(object sender, EventArgs e)
        {
            function.settheme(this);
            if (module_Rpt.rpt_name.CompareTo("FRM_ITEMMASTER") == 0)
            {
                DataSet ds = bl_obj.blFill("SP_ItemMaster");
                doc = new RptItemMaster();
                doc.Database.Tables["Tbl_ItemMaster"].SetDataSource(ds.Tables[0]);
                crystalReportViewer1.ReportSource = doc;
            }
            else
            { }
        }

        private void Report_Viewer_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                //function.clean();
                crystalReportViewer1.Dispose();
                crystalReportViewer1 = null;
                doc.Dispose();
                GC.Collect();
                Dispose(true);
            }
            catch (Exception ex)
            { }
        }
    }
}


