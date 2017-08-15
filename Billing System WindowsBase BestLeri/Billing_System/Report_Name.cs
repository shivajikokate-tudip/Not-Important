using System.Windows.Forms;
using System;
using System.Data;
using System.Diagnostics;
using System.Configuration;
using System.Collections.Generic;
using System.Data.Sql;
using System.Drawing;
using System.Data.SqlClient;
using System.Globalization;
using ComponentFactory.Krypton.Toolkit;
using System.IO;
using BILLING_SYSTEM;
using Business_Report;
using System.Threading;
using System.Collections;
namespace BILLING_SYSTEM
{
    class Report_Name
    {
        public KryptonForm select_Report_Form(string frm_name)
        {
            for (int i=0 ;i<MODULE.glb.Keys.Count;i++)
            {
                string str=MODULE.glb.Keys[i].ToString();
                module_Rpt.glb_Rpt[(MODULE.glb.Keys[i].ToString())]=MODULE.glb[str].ToString();
                //module_Rpt.glb_Rpt[i]=module.glb.Keys[i].ToString()
 
            }

            KryptonForm new_form = null;
            if (frm_name == "Form1")
            {
                Business_Report.Report_Viewer frm = new Business_Report.Report_Viewer();
                new_form = frm;
            }
            else if (frm_name == "FRM_RPTSALESINVOICE")
            {
                Business_Report.FRM_RPTSALESINVOICE frm = new Business_Report.FRM_RPTSALESINVOICE();
                new_form = frm;
            }
            else if (frm_name == "FRM_RPTPENDINGINVOICE")
            {
                Business_Report.FRM_RPTPENDINGINVOICE frm = new Business_Report.FRM_RPTPENDINGINVOICE();
                new_form = frm;
            }
            else if (frm_name == "FRM_RPTSCRAPWISE")
            {
                Business_Report.FRM_RPTSCRAPWISE frm = new Business_Report.FRM_RPTSCRAPWISE();
                new_form = frm;
            }
            else if (frm_name == "FRM_DayBook")
            {
                Business_Report.FRM_DayBook frm = new Business_Report.FRM_DayBook();
                new_form = frm;
            }
            else if (frm_name == "FRM_CashBook")
            {
                Business_Report.FRM_CashBook frm = new Business_Report.FRM_CashBook();
                new_form = frm;
            }
            else if (frm_name == "FRM_RPTSALES")
            {
                Business_Report.FRM_RPTSALES frm = new Business_Report.FRM_RPTSALES();
                new_form = frm;
            }
            else if (frm_name == "FRM_RPTPURCHASE")
            {
                Business_Report.FRM_RPTPURCHASE frm = new Business_Report.FRM_RPTPURCHASE();
                new_form = frm;
            }
            else if (frm_name == "FRM_RPTGENERALLEDGER")
            {
                Business_Report.FRM_RPTGENERALLEDGER frm = new Business_Report.FRM_RPTGENERALLEDGER();
                new_form = frm;
            }
            else if (frm_name == "Frm_RptTrialBalance")
            {
                Business_Report.Frm_RptTrialBalance frm = new Business_Report.Frm_RptTrialBalance();
                new_form = frm;
            }
            else if (frm_name == "FRM_RPTROOTWISEPENDING")
            {
                Business_Report.FRM_RPTROOTWISEPENDING frm = new Business_Report.FRM_RPTROOTWISEPENDING();
                new_form = frm;
            }
            else if (frm_name == "FRM_RPTFINISHEDGOODS")
            {
                Business_Report.FRM_RPTFINISHEDGOODS frm = new Business_Report.FRM_RPTFINISHEDGOODS();
                new_form = frm;
            }
            else if (frm_name == "FRM_RPTROWMATERIALSTOCK")
            {
                Business_Report.FRM_RPTROWMATERIALSTOCK frm = new Business_Report.FRM_RPTROWMATERIALSTOCK();
                new_form = frm;
            }
            else if (frm_name == "FRM_PRODUCTIONREPORT")
            {
                Business_Report.FRM_PRODUCTIONREPORT frm = new Business_Report.FRM_PRODUCTIONREPORT();
                new_form = frm;
            }
            else if (frm_name == "FRM_Customer_Ledger")
            {
                Business_Report.FRM_Customer_Ledger frm = new Business_Report.FRM_Customer_Ledger();
                new_form = frm;
            }
            else if (frm_name == "FRM_Customer_Ledger")
            {
                Business_Report.FRM_Customer_Ledger frm = new Business_Report.FRM_Customer_Ledger();
                new_form = frm;
            }
            else if (frm_name == "FRM_RPTCOLLECTIONREPORT")
            {
                Business_Report.FRM_RPTCOLLECTIONREPORT frm = new Business_Report.FRM_RPTCOLLECTIONREPORT();
                new_form = frm;
            }
            else if (frm_name == "FRM_RPTDEBTICREDITTRANSACTION")
            {
                Business_Report.FRM_RPTDEBTICREDITTRANSACTION frm = new Business_Report.FRM_RPTDEBTICREDITTRANSACTION();
                new_form = frm;
            }
            else if (frm_name == "FRM_GSTTAX")
            {
                Business_Report.FRM_GSTTAX frm = new Business_Report.FRM_GSTTAX();
                new_form = frm;
            }

            return new_form;
        }
    }
}
