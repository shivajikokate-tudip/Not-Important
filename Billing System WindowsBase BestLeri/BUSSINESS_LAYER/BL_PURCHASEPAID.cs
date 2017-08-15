using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace BUSSINESS_LAYER
{
    public class BL_PURCHASEPAID : BL, ICOMMON_CLASS_MASTER
    {
        int _PurchasePaidId;
        public int PurchasePaidId
        {
            get { return _PurchasePaidId; }
            set { _PurchasePaidId = value; }
        }
        int _CustomerId;
        public int CustomerId
        {
            get { return _CustomerId; }
            set { _CustomerId = value; }
        }
        int _Purchase_Id;
        public int Purchase_Id
        {
            get { return _Purchase_Id; }
            set { _Purchase_Id = value; }
        }

        string _Tran_Date;
        public string Tran_Date
        {
            get { return _Tran_Date; }
            set { _Tran_Date = value; }
        }

        double _Amount;
        public double Amount
        {
            get { return _Amount; }
            set { _Amount = value; }
        }

        public System.Data.DataSet SELECT(object classObject)
        {
            return blFill("SP_PurchasePaid");
        }

        public System.Data.DataSet INSERT(object classObject)
        {
            Parameter.Clear();
            Parameter.Add("@SalesId", ((BL_PURCHASEPAID)classObject).Purchase_Id.ToString().Trim());
            Parameter.Add("@Amount", ((BL_PURCHASEPAID)classObject).Amount.ToString().Trim());
            Parameter.Add("@Tran_Date", ((BL_PURCHASEPAID)classObject).Tran_Date.ToString().Trim());
            Parameter.Add("@flag", "U");
            return blFill_Para_Name(Parameter, "SP_PurchaseRecoveryCheck");
        }

        public System.Data.DataSet UPDATE(object classObject)
        {
            Parameter.Clear();
            Parameter.Add("@PurchasePaidId", ((BL_PURCHASEPAID)classObject).PurchasePaidId.ToString().Trim());
            Parameter.Add("@Purchase_Id", ((BL_PURCHASEPAID)classObject).Purchase_Id.ToString().Trim());
            Parameter.Add("@Amount", ((BL_PURCHASEPAID)classObject).Amount.ToString().Trim());
            Parameter.Add("@Tran_Date", ((BL_PURCHASEPAID)classObject).Tran_Date.ToString().Trim());
            Parameter.Add("@flag", "U");
            return blFill_Para_Name(Parameter, "SP_PurchasePaid");
        }

        public DataSet DELETE(object classObject)
        {
            Parameter.Clear();
            Parameter.Add("@PurchasePaidId", ((BL_PURCHASEPAID)classObject).PurchasePaidId.ToString().Trim());
            Parameter.Add("@flag", "D");
            return blFill_Para_Name(Parameter, "SP_PurchasePaid");
        }
        public System.Data.DataSet FillInvoice(object classobject)
        {
            Parameter.Clear();
            Parameter.Add("@PurchasePaidId", ((BL_PURCHASEPAID)classobject).PurchasePaidId.ToString().Trim());
            Parameter.Add("@flag", "F");
            return blFill_Para_Name(Parameter, "SP_PurchasePaid");
        }
        public System.Data.DataSet Fillcustomer(object classobject)
        {
            Parameter.Clear();
            Parameter.Add("@PurchasePaidId", ((BL_PURCHASEPAID)classobject).CustomerId.ToString().Trim());
            Parameter.Add("@flag", "M");
            return blFill_Para_Name(Parameter, "SP_PurchasePaid");
        }
        public void Fill_ListView(ListView Lvw, DataTable Dt)
        {
            throw new NotImplementedException();
        }
    }
}
