using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using BUSSINESS_LAYER;

namespace BUSSINESS_LAYER
{
    public class BL_EXPENCESTRANSACTION : BL, ICOMMON_CLASS_MASTER
    {
        BL bl = new BL(); BUSSINESS_LAYER.BL bl_obj = new BUSSINESS_LAYER.BL();
        int _Tran_Expences_ID; DataSet ds = new DataSet();
        public int Tran_Expences_ID
        {
            get { return _Tran_Expences_ID; }
            set { _Tran_Expences_ID = value; }
        }

        public int InvoiceNo
        {
            get { return _InvoiceNo; }
            set { _InvoiceNo = value; }
        }
        string _flag, _id;
        public string flag
        {
            get { return _flag; }
            set { _flag = value; }
        }
        public string id 
        {
            get { return _id; }
            set { _id = value; }
        }
        int _Expences_ID, _InvoiceNo;
        public int Expences_ID
        {
            get { return _Expences_ID; }
            set { _Expences_ID = value; }
        }

        int _SubExpences_ID;
        public int SubExpences_ID
        {
            get { return _SubExpences_ID; }
            set { _SubExpences_ID = value; }
        }

        int _TransactionModeId;
        public int TransactionModeId
        {
            get { return _TransactionModeId; }
            set { _TransactionModeId = value; }
        }
        string _Tras_Date;
        public string Tras_Date
        {
            get { return _Tras_Date; }
            set { _Tras_Date = value; }
        }
        string _Type;
        public string Type
        {
            get { return _Type; }
            set { _Type = value; }
        }
        double _Amount;
        public double Amount
        {
            get { return _Amount; }
            set { _Amount = value; }
        }

        string _Discription;
        public string Discription
        {
            get { return _Discription; }
            set { _Discription = value; }
        }

        string _TransationNo;
        public string TransationNo
        {
            get { return _TransationNo; }
            set { _TransationNo = value; }
        }
        public DataSet SELECT(object classObject)
        {
            return blFill("SP_Expences_Transaction");
        }

        public DataSet INSERT(object classObject)
        {
            ds.Clear();
            Parameter.Clear();
            try
            {
                Parameter.Add("@SubExpences_ID", ((BL_EXPENCESTRANSACTION)classObject).SubExpences_ID.ToString().Trim());
                Parameter.Add("@TransactionModeId", ((BL_EXPENCESTRANSACTION)classObject).TransactionModeId.ToString().Trim());
                Parameter.Add("@Transaction_No", ((BL_EXPENCESTRANSACTION)classObject).TransationNo.ToString().Trim());
                Parameter.Add("@Tran_Date", (((BL_EXPENCESTRANSACTION)classObject).Tras_Date.ToString().Trim()));
                Parameter.Add("@Discription", ((BL_EXPENCESTRANSACTION)classObject).Discription.ToString().Trim());
                Parameter.Add("@Amount", ((BL_EXPENCESTRANSACTION)classObject).Amount.ToString().Trim());
                Parameter.Add("@Type", ((BL_EXPENCESTRANSACTION)classObject).Type.ToString().Trim());
                Parameter.Add("@InvoiceNo", ((BL_EXPENCESTRANSACTION)classObject).InvoiceNo.ToString().Trim());
                Parameter.Add("@flag", "A");
                ds = blFill_Para_Name(Parameter, "SP_Expences_Transaction");
            }
            catch (Exception err)
            {
                err.GetBaseException();
            } return ds;
        }

        public DataSet UPDATE(object classObject)
        {
            ds.Clear();
            Parameter.Clear();
            try
            {
                Parameter.Add("@Tran_Expences_ID", ((BL_EXPENCESTRANSACTION)classObject).Tran_Expences_ID.ToString().Trim());
                Parameter.Add("@Expences_ID", ((BL_EXPENCESTRANSACTION)classObject).Expences_ID.ToString().Trim());
                Parameter.Add("@SubExpences_ID", ((BL_EXPENCESTRANSACTION)classObject).SubExpences_ID.ToString().Trim());
                Parameter.Add("@TransactionModeId", ((BL_EXPENCESTRANSACTION)classObject).TransactionModeId.ToString().Trim());
                Parameter.Add("@Tran_Date", (((BL_EXPENCESTRANSACTION)classObject).Tras_Date.ToString().Trim()));
                Parameter.Add("@Discription", ((BL_EXPENCESTRANSACTION)classObject).Discription.ToString().Trim());
                Parameter.Add("@Amount", ((BL_EXPENCESTRANSACTION)classObject).Amount.ToString().Trim());
                Parameter.Add("@Type", ((BL_EXPENCESTRANSACTION)classObject).Type.ToString().Trim());
                Parameter.Add("@InvoiceNo", ((BL_EXPENCESTRANSACTION)classObject).InvoiceNo.ToString().Trim());
                Parameter.Add("@flag", "U");
                return blFill_Para_Name(Parameter, "SP_Expences_Transaction");
            }
            catch (Exception err)
            {
                err.GetBaseException();
            } return ds;
        }

        public DataSet DELETE(object classObject)
        {
            Parameter.Clear();
            Parameter.Add("@Tran_Expences_ID", ((BL_EXPENCESTRANSACTION)classObject).Tran_Expences_ID.ToString().Trim());
            Parameter.Add("@flag", "D");
            return blFill_Para_Name(Parameter, "SP_Expences_Transaction");
        }

        public void Fill_ListView(ListView Lvw, DataTable Dt)
        {
            throw new NotImplementedException();
        }
        public System.Data.DataSet Tokenno(object classobject)
        {
            Parameter.Clear();
            Parameter.Add("@Transaction_No", ((BL_EXPENCESTRANSACTION)classobject).TransationNo.ToString().Trim());
            Parameter.Add("@flag", "F");
            return blFill_Para_Name(Parameter, "SP_Expences_Transaction");
        }
        public System.Data.DataSet dropdown(object classobject)
        {
            Parameter.Clear();
            Parameter.Add("@itemid", ((BL_EXPENCESTRANSACTION)classobject).Expences_ID.ToString().Trim());
            Parameter.Add("@flag", "9");
            return blFill_Para_Name(Parameter, "SP_FILLDDL");
        }
        public System.Data.DataSet dc(object classobject)
        {
            Parameter.Clear();
            Parameter.Add("@Option_Type", ((BL_EXPENCESTRANSACTION)classobject).id.ToString().Trim());
            Parameter.Add("@flag", "8");
            return blFill_Para_Name(Parameter, "SP_FILLDDL");
        }
    }
}
