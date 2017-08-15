using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
namespace BUSSINESS_LAYER
{
    public class BL_SALESRECOVERYCHECK : BL, ICOMMON_CLASS_MASTER
    {
        int _SalesRecoveryId;
        public int SalesRecoveryId
        {
            get { return _SalesRecoveryId; }
            set { _SalesRecoveryId = value; }
        }
        int _SalesId;
        public int SalesId
        {
            get { return _SalesId; }
            set { _SalesId = value; }
        }
        double _Amount;
        public double Amount
        {
            get { return _Amount; }
            set { _Amount = value; }
        }

        string _Tran_Date;
        public string Tran_Date
        {
            get { return _Tran_Date; }
            set { _Tran_Date = value; }
        }
        string _form;
        public string form
        {
            get { return _form; }
            set { _form = value; }
        }
        public System.Data.DataSet SELECT(object classObject)
        {
            DataSet ds =new DataSet();
            if (form == "S")
            {
                ds=blFill("SP_SalesRecoveryCheck");
            }
            if (form == "P")
            {
                ds=blFill("SP_PurchaseRecoveryCheck");
            }
            return ds;
        }
        
        public DataSet INSERT(object classObject)
        {
            throw new NotImplementedException();
        }

        public DataSet UPDATE(object classObject)
        {
            DataSet ds1 = new DataSet();
            if (form == "S")
            {
                Parameter.Clear();
                Parameter.Add("@SalesRecoveryId", ((BL_SALESRECOVERYCHECK)classObject).SalesRecoveryId.ToString().Trim());
                Parameter.Add("@SalesId", ((BL_SALESRECOVERYCHECK)classObject).SalesId.ToString().Trim());
                Parameter.Add("@Amount", ((BL_SALESRECOVERYCHECK)classObject).Amount.ToString().Trim());
                Parameter.Add("@Tran_Date", ((BL_SALESRECOVERYCHECK)classObject).Tran_Date.ToString().Trim());
                Parameter.Add("@flag", "U");
                ds1= blFill_Para_Name(Parameter, "SP_SalesRecoveryCheck");
            }
            if (form == "P")
            {
                Parameter.Clear();
                Parameter.Add("@SalesRecoveryId", ((BL_SALESRECOVERYCHECK)classObject).SalesRecoveryId.ToString().Trim());
                Parameter.Add("@SalesId", ((BL_SALESRECOVERYCHECK)classObject).SalesId.ToString().Trim());
                Parameter.Add("@Amount", ((BL_SALESRECOVERYCHECK)classObject).Amount.ToString().Trim());
                Parameter.Add("@Tran_Date", ((BL_SALESRECOVERYCHECK)classObject).Tran_Date.ToString().Trim());
                Parameter.Add("@flag", "U");
                ds1 = blFill_Para_Name(Parameter, "SP_PurchaseRecoveryCheck");
            }

            return ds1;
        }

        public DataSet DELETE(object classObject)
        {
            throw new NotImplementedException();
        }

        public void Fill_ListView(ListView Lvw, DataTable Dt)
        {
            throw new NotImplementedException();
        }
        public System.Data.DataSet FillInvoice(object classobject)
        {
            DataSet ds2 = new DataSet();
            if (form == "S")
            {
                Parameter.Clear();
                Parameter.Add("@SalesRecoveryId", ((BL_SALESRECOVERYCHECK)classobject).SalesRecoveryId.ToString().Trim());
                Parameter.Add("@flag", "C");
                ds2=blFill_Para_Name(Parameter, "SP_SalesRecoveryCheck");
            }
            if (form == "P")
            {
                Parameter.Clear();
                Parameter.Add("@SalesRecoveryId", ((BL_SALESRECOVERYCHECK)classobject).SalesRecoveryId.ToString().Trim());
                Parameter.Add("@flag", "C");
                ds2 = blFill_Para_Name(Parameter, "SP_PurchaseRecoveryCheck");
            } 
            return ds2;
        }
    }
}
