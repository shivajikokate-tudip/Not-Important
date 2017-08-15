using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace BUSSINESS_LAYER
{
    public class BL_SALESRECOVERY:BL,ICOMMON_CLASS_MASTER
    {
        int _SalesRecoveryId;
        public int SalesRecoveryId
        {
            get { return _SalesRecoveryId; }
            set { _SalesRecoveryId = value; }
        }
        int _CustomerId;
        public int CustomerId
        {
            get { return _CustomerId;}
            set { _CustomerId= value; }
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

        public System.Data.DataSet SELECT(object classObject)
        {
            return blFill("SP_SalesRecovery");
        }

        public System.Data.DataSet INSERT(object classObject)
        {
            Parameter.Clear();
            Parameter.Add("@SalesId", ((BL_SALESRECOVERY)classObject).SalesId.ToString().Trim());
            Parameter.Add("@Amount", ((BL_SALESRECOVERY)classObject).Amount.ToString().Trim());
            Parameter.Add("@Tran_Date", ((BL_SALESRECOVERY)classObject).Tran_Date.ToString().Trim());
            Parameter.Add("@flag", "U");
            return blFill_Para_Name(Parameter, "SP_SalesRecoveryCheck");
        }

        public System.Data.DataSet UPDATE(object classObject)
        {
            Parameter.Clear();
            Parameter.Add("@SalesRecoveryId", ((BL_SALESRECOVERY)classObject).SalesRecoveryId.ToString().Trim());
            Parameter.Add("@SalesId", ((BL_SALESRECOVERY)classObject).SalesId.ToString().Trim());
            Parameter.Add("@Amount", ((BL_SALESRECOVERY)classObject).Amount.ToString().Trim());
            Parameter.Add("@Tran_Date", ((BL_SALESRECOVERY)classObject).Tran_Date.ToString().Trim());
            Parameter.Add("@flag", "U");
            return blFill_Para_Name(Parameter, "SP_SalesRecovery");
        }

        public System.Data.DataSet DELETE(object classObject)
        {
            Parameter.Clear();
            Parameter.Add("@SalesRecoveryId", ((BL_SALESRECOVERY)classObject).SalesRecoveryId.ToString().Trim());           
            Parameter.Add("@flag", "D");
            return blFill_Para_Name(Parameter, "SP_SalesRecovery");
        }

        public System.Data.DataSet FillInvoice(object classobject) 
        {
            Parameter.Clear();
            Parameter.Add("@SalesRecoveryId", ((BL_SALESRECOVERY)classobject).SalesRecoveryId.ToString().Trim());
            Parameter.Add("@flag", "F");
            return blFill_Para_Name(Parameter, "SP_SalesRecovery");
        }
        public System.Data.DataSet Fillcustomer(object classobject)
        {
            Parameter.Clear();
            Parameter.Add("@SalesRecoveryId", ((BL_SALESRECOVERY)classobject).CustomerId.ToString().Trim());
            Parameter.Add("@flag", "M");
            return blFill_Para_Name(Parameter, "SP_SalesRecovery");
        }

        public void Fill_ListView(System.Windows.Forms.ListView Lvw, System.Data.DataTable Dt)
        {
            throw new NotImplementedException();
        }
    }
}
