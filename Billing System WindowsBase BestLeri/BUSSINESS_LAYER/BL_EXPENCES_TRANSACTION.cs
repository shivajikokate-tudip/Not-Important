using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace BUSSINESS_LAYER
{
    public class BL_EXPENCES_TRANSACTION : BL, ICOMMON_CLASS_MASTER
    {
        int _TranExpencesId;
        public int TranExpencesId { get { return _TranExpencesId; } set { _TranExpencesId = value; } }

        int _ExpencesId;
        public int ExpencesId { get { return _ExpencesId; } set { _ExpencesId = value; } }

        string _SysDate;
        public string SysDate { get { return _SysDate; } set { _SysDate = value; } }

        string _TransDate;
        public string TransDate { get { return _TransDate; } set { _TransDate = value; } }

        string _Desc;
        public string Desc { get { return _Desc; } set { _Desc = value; } }

        double _Amount;
        public double Amount { get { return _Amount; } set { _Amount = value; } }

        #region ICOMMON_CLASS_MASTER Members

        public DataSet select(object classobject)
        {
            return blFill("Sp_expencestransaction");
        }


        public DataSet INSERT(object classObject)
        {
            Parameter.Clear();
            Parameter.Add("@Tran_Expences_ID",((BL_EXPENCES_TRANSACTION)classObject).TranExpencesId.ToString());
            Parameter.Add("@Expences_ID", ((BL_EXPENCES_TRANSACTION)classObject).ExpencesId.ToString());
            Parameter.Add("@Sys_Date", ((BL_EXPENCES_TRANSACTION)classObject).SysDate.ToString());
            Parameter.Add("@Tran_Date", ((BL_EXPENCES_TRANSACTION)classObject).TransDate.ToString());
            Parameter.Add("@Discription",((BL_EXPENCES_TRANSACTION)classObject).Desc.ToString());
            Parameter.Add("@Amount", ((BL_EXPENCES_TRANSACTION)classObject).Amount.ToString());
            Parameter.Add("@flag", "A");
            return blFill_Para_Name(Parameter, "Sp_expencestransaction");
        }


        public DataSet UPDATE(object classObject)
        {
            Parameter.Clear();
            Parameter.Add("@Tran_Expences_ID", ((BL_EXPENCES_TRANSACTION)classObject).TranExpencesId.ToString());
            Parameter.Add("@Expences_ID", ((BL_EXPENCES_TRANSACTION)classObject).ExpencesId.ToString());
            Parameter.Add("@Sys_Date", ((BL_EXPENCES_TRANSACTION)classObject).SysDate.ToString());
            Parameter.Add("@Tran_Date", ((BL_EXPENCES_TRANSACTION)classObject).TransDate.ToString());
            Parameter.Add("@Discription", ((BL_EXPENCES_TRANSACTION)classObject).Desc.ToString());
            Parameter.Add("@Amount", ((BL_EXPENCES_TRANSACTION)classObject).Amount.ToString());
            Parameter.Add("@flag", "U");
            return blFill_Para_Name(Parameter, "Sp_expencestransaction");
        }

        public DataSet DELETE(object classObject)
        {
            Parameter.Clear();
            Parameter.Add("@Tran_Expences_ID", ((BL_EXPENCES_TRANSACTION)classObject).TranExpencesId.ToString());
            Parameter.Add("@flag", "D");
            return blFill_Para_Name(Parameter, "Sp_expencestransaction");
        }

        public void Fill_ListView(ListView Lvw, DataTable Dt)
        {

        }

        #endregion

        public DataSet SELECT(object classObject)
        {
            throw new NotImplementedException();
           
            
        }
    }
}
