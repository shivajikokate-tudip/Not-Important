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
        DateTime _fromdate = DateTime.Now;
        DateTime _todate = DateTime.Now;
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

        public Report_Viewer(DateTime fromdate, DateTime todate, DataSet ds, int tableno)
        {
            InitializeComponent();
            dataSet1 = ds;
            Tableno = tableno;
            _fromdate = fromdate;
            _todate = todate;
        }

        private void Report_Viewer_Load(object sender, EventArgs e)
        {
            function.settheme(this);

            //--------*********>>>>>>>>>>>>>>>>>   Binding a Report Master Form  <<<<<<<<<<<<<<<*********--------

            if (module_Rpt.rpt_name.CompareTo("FRM_EMPLOYEEMASTER") == 0)
            {
                DataSet ds = bl_obj.blFill("SP_EmployeeMaster");
                doc = new RptEmployeeMaster();
                doc.Database.Tables["Tbl_EmployeeMaster"].SetDataSource(ds.Tables[0]);
                crystalReportViewer1.ReportSource = doc;
            }

            if (module_Rpt.rpt_name.CompareTo("FRM_ITEMMASTER") == 0)
            {
                DataSet ds = bl_obj.blFill("SP_ItemMaster");
                doc = new RptItemMaster();
                doc.Database.Tables["Tbl_ItemMaster"].SetDataSource(ds.Tables[0]);
                crystalReportViewer1.ReportSource = doc;
            }

            if (module_Rpt.rpt_name.CompareTo("FRM_CUSTOMERMASTER") == 0)
            {
                DataSet ds = bl_obj.blFill("SP_CustomerMaster");
                doc = new RptCustomerMaster();
                doc.Database.Tables["Tbl_CustomerMaster"].SetDataSource(ds.Tables[0]);
                crystalReportViewer1.ReportSource = doc;
            }

            if (module_Rpt.rpt_name.CompareTo("FRM_TRANSPORTATION_MASTER") == 0)
            {
                DataSet ds = bl_obj.blFill("SP_TransportationMaster");
                doc = new RptTransportationMaster();
                doc.Database.Tables["Tbl_TransportationMaster"].SetDataSource(ds.Tables[0]);
                crystalReportViewer1.ReportSource = doc;
            }
            
            if (module_Rpt.rpt_name.CompareTo("FRM_EXPENCESMASTER") == 0)
            {
                  DataSet ds = bl_obj.blFill("SP_ExpencesMaster");
                  doc = new RptExpencesMaster();
                  doc.Database.Tables["Tbl_ExpencesMaster"].SetDataSource(ds.Tables[0]);
                  crystalReportViewer1.ReportSource = doc;
            }

            if (module_Rpt.rpt_name.CompareTo("FRM_ROWMATERIAL") == 0)
            {
                DataSet ds = bl_obj.blFill("SP_RowHedar");
                doc = new RptRowMaterial();
                doc.Database.Tables["Tbl_RowHedar"].SetDataSource(ds.Tables[0]);
                crystalReportViewer1.ReportSource = doc;
            }

            if (module_Rpt.rpt_name.CompareTo("FRM_SUPPLIERMASTER") == 0)
            {
                DataSet ds = bl_obj.blFill("SP_SupplierMaster");
                doc = new RptSupplierMaster();
                doc.Database.Tables["Tbl_SupplierMaster"].SetDataSource(ds.Tables[0]);
                crystalReportViewer1.ReportSource = doc;
            }

            if (module_Rpt.rpt_name.CompareTo("FRM_TRANSPORTATION_MASTER") == 0)
            {
                DataSet ds = bl_obj.blFill("SP_TransportationMaster");
                doc = new RptTransportationMaster();
                doc.Database.Tables["Tbl_TransportationMaster"].SetDataSource(ds.Tables[0]);
                crystalReportViewer1.ReportSource = doc;
            }


            if (module_Rpt.rpt_name.CompareTo("FRM_SUBEXPENCESMASTER") == 0)
            {
                DataSet ds = bl_obj.blFill("SP_SubExpencesMaster");
                doc = new RptSubExpencesMaster();
                doc.Database.Tables["Tbl_SubExpencesMaster"].SetDataSource(ds.Tables[0]);
                //doc.Database.Tables["Tbl_ExpencesMaster"].SetDataSource(ds.Tables[0]);
                crystalReportViewer1.ReportSource = doc;
            }


            if (module_Rpt.rpt_name.CompareTo("FRM_MEASUREMENTMASTER") == 0)
            {
                DataSet ds = bl_obj.blFill("SP_MeasurementMaster");
                doc = new RptMeasurmentMaster();
                doc.Database.Tables["Tbl_Measurment"].SetDataSource(ds.Tables[0]);
                crystalReportViewer1.ReportSource = doc;
            }

            //--------*********>>>>>>>>>>>>>>>>>   Binding a Report Transaction   <<<<<<<<<<<<<<<*********--------

            if (module_Rpt.rpt_name.CompareTo("RptSalesInvoice") == 0)
            {
                doc = new RptSalesInvoice();
                doc.Database.Tables["Tbl_Sales_Invoice"].SetDataSource(dataSet1.Tables[0]);
                crystalReportViewer1.ReportSource = doc;
            }

            if (module_Rpt.rpt_name.CompareTo("RptPendingInvoice") == 0)
            {
                doc = new RptPendingInvoice();
                doc.Database.Tables["Tbl_PendingInvoice"].SetDataSource(dataSet1.Tables[0]);
                crystalReportViewer1.ReportSource = doc;
            }

            if (module_Rpt.rpt_name.CompareTo("RptPendingInvoiceCustomerwise") == 0)
            {
                doc = new RptPendingInvoiceCustomerwise();
                doc.Database.Tables["Tbl_PendingInvoiceCustomerwise"].SetDataSource(dataSet1.Tables[0]);
                crystalReportViewer1.ReportSource = doc;
            }
            if (module_Rpt.rpt_name.CompareTo("RptScrapwise") == 0)
            {
                doc = new RptScrapwise();
                doc.Database.Tables["Tbl_Scrapwise"].SetDataSource(dataSet1.Tables[0]);
                crystalReportViewer1.ReportSource = doc;
            }

            if (module_Rpt.rpt_name.CompareTo("rptDayBook") == 0)
            {
                doc = new rptDayBookNew();
                doc.Database.Tables["DayBookNew"].SetDataSource(dataSet1.Tables[0]);
                //doc.Database.Tables["Tbl_OpeningBalance"].SetDataSource(dataSet1.Tables[1]);
                //doc.ParameterFields.Add("OpeningBal");
                //doc.SetParameterValue("OpeningBal",dataSet1.Tables[1].Rows[0][0].ToString());
                //doc.SetParameterValue("Date", dataSet1.Tables[1].Rows[0][1].ToString());
                crystalReportViewer1.ReportSource = doc;
            }

            if (module_Rpt.rpt_name.CompareTo("rptCashBook") == 0)
            {
                DataSet ds = new DataSet();
                paraname.Clear();
                paravalue.Clear();
                paraname.Add("@From_Date");

                paraname.Add("@flag");
                paravalue.Add(_fromdate.ToString("yyyy-MM-dd"));

                paravalue.Add("OP");
                ds = bl_obj.blFill_para_name(paraname, paravalue, "SP_Report");

                doc = new rptCashBook();
                doc.Database.Tables["CashBookNew"].SetDataSource(dataSet1.Tables[0]);
                //doc.Database.Tables["Tbl_OpeningBalance"].SetDataSource(dataSet1.Tables[1]);
                //doc.ParameterFields.Add("OpeningBal");
                doc.SetParameterValue("OpeningBal", ds.Tables[0].Rows[0][0].ToString());
                doc.SetParameterValue("Date", _fromdate);
                crystalReportViewer1.ReportSource = doc;
            }

            if (module_Rpt.rpt_name.CompareTo("RptSales") == 0)
            {
                doc = new RptSales();
                doc.Database.Tables["Tbl_Sales"].SetDataSource(dataSet1.Tables[0]);
                crystalReportViewer1.ReportSource = doc;
            }

            if (module_Rpt.rpt_name.CompareTo("RptPurchase") == 0)
            {
                doc = new RptPurchase();
                doc.Database.Tables["Tbl_Purchase"].SetDataSource(dataSet1.Tables[0]);
                crystalReportViewer1.ReportSource = doc;
            }

            if (module_Rpt.rpt_name.CompareTo("RptGeneralLedger") == 0)
            {
                doc = new RptGeneralLedger();
                doc.Database.Tables["Tbl_GeneralLedger"].SetDataSource(dataSet1.Tables[0]);
                doc.SetParameterValue("OpeningBal", dataSet1.Tables[1].Rows[0][0].ToString());
                crystalReportViewer1.ReportSource = doc;
            }
            if (module_Rpt.rpt_name.CompareTo("RptTrialBalance") == 0)
            {
                doc = new RptTrialBalance();
                doc.Database.Tables["Tbl_TrialBalance"].SetDataSource(dataSet1.Tables[0]);
                //doc.Database.Tables["Tbl_OpeningBalance"].SetDataSource(dataSet1.Tables[1]);
                //doc.ParameterFields.Add("OpeningBal");
                doc.SetParameterValue("OpeningBal", dataSet1.Tables[1].Rows[0][0].ToString());
                doc.SetParameterValue("Date", dataSet1.Tables[1].Rows[0][1].ToString());
                doc.SetParameterValue("ToDate", dataSet1.Tables[1].Rows[0][2].ToString());
                crystalReportViewer1.ReportSource = doc;
            }

            if (module_Rpt.rpt_name.CompareTo("RptRoot") == 0)
            {
                doc = new RptRoot();
                doc.Database.Tables["Tbl_Root"].SetDataSource(dataSet1.Tables[0]);
                crystalReportViewer1.ReportSource = doc;
            }

            if (module_Rpt.rpt_name.CompareTo("rptFinishedGoods") == 0)
            {
                doc = new rptFinishedGoods();
                doc.Database.Tables["Tbl_FinishedGoods"].SetDataSource(dataSet1.Tables[0]);
                crystalReportViewer1.ReportSource = doc;
            }

            if (module_Rpt.rpt_name.CompareTo("rptRowMaterialStock") == 0)
            {
                doc = new rptRowMaterialStock();
                doc.Database.Tables["Tbl_RowMaterialStock"].SetDataSource(dataSet1.Tables[0]);
                crystalReportViewer1.ReportSource = doc;
            }

            if (module_Rpt.rpt_name.CompareTo("rptProductionReport") == 0)
            {
                doc = new rptProductionReport();
                doc.Database.Tables["Tbl_ProductionReport"].SetDataSource(dataSet1.Tables[0]);
                crystalReportViewer1.ReportSource = doc;
            }

            //if (module_Rpt.rpt_name.CompareTo("RptTax") == 0)
            //{
            //    doc = new RptTax();
            //    doc.Database.Tables["Tbl_Tax"].SetDataSource(dataSet1.Tables[0]);
            //    crystalReportViewer1.ReportSource = doc;
            //}

            if (module_Rpt.rpt_name.CompareTo("rptCustomerLedgerNew") == 0)
            {
                doc = new rptCustomerLedgerNew();
                doc.Database.Tables["Tbl_Customer_Ledger_New"].SetDataSource(dataSet1.Tables[0]);
                crystalReportViewer1.ReportSource = doc;
            }

            if (module_Rpt.rpt_name.CompareTo("rptDateWiseAllCustTotal") == 0)
            {
                doc = new rptDateWiseAllCustTotal();
                doc.Database.Tables["AllCustDateWiseTotal"].SetDataSource(dataSet1.Tables[0]);
                crystalReportViewer1.ReportSource = doc;
            }

            //if (module_Rpt.rpt_name.CompareTo("RptDateWiseAllCustomer") == 0)
            //{
            //    doc = new RptDateWiseAllCustomer();
            //    doc.Database.Tables["AllCustDateWiseTotal"].SetDataSource(dataSet1.Tables[0]);
            //    crystalReportViewer1.ReportSource = doc;
            //}

            if (module_Rpt.rpt_name.CompareTo("rptDebitCreditTransaction") == 0)
            {
                doc = new rptDebitCreditTransaction();
                doc.Database.Tables["Tbl_DebitCreditTransaction"].SetDataSource(dataSet1.Tables[0]);
                crystalReportViewer1.ReportSource = doc;
            }

            if (module_Rpt.rpt_name.CompareTo("RptGSTTax") == 0)
            {
                doc = new RptGSTTax();
                doc.Database.Tables["Tbl_Tax"].SetDataSource(dataSet1.Tables[0]);
                crystalReportViewer1.ReportSource = doc;
            }
            if (module_Rpt.rpt_name.CompareTo("RPTGSTR") == 0)
            {
                doc = new RPTGSTR();
                doc.Database.Tables["Tbl_GSTR"].SetDataSource(dataSet1.Tables[0]);
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


