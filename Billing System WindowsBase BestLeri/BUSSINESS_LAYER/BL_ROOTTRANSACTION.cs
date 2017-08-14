using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace BUSSINESS_LAYER
{
    public class BL_ROOTTRANSACTION : BL, ICOMMON_CLASS_MASTER
    {
        
        int _RootTranId;
        public int RootTranId
        {
            get { return _RootTranId;}
            set { _RootTranId = value;}
        }

        int _RootId;
        public int RootId
        {
            get { return _RootId; }
            set { _RootId = value;}
        }

        int _Customer_Id;
        public int Customer_Id
        {
            get { return _Customer_Id;}
            set { _Customer_Id = value;}
        
        }

        int _Position;
        public int Position
        {
            get { return _Position;}
            set { _Position = value;}
        
        }


        public DataSet SELECT(object classObject)
        {
            return blFill("SP_RootTransaction");
        }
        public DataSet SELECT1(object classObject)
        {
            Parameter.Clear();
            Parameter.Add("@RootId", ((BL_ROOTTRANSACTION)classObject).RootId.ToString().Trim());
            return blFill_Para_Name(Parameter, "SP_RootTransaction");
        }
        public DataSet INSERT(object classObject)
        {
            //@max,@RootId,@Customer_Id
            Parameter.Clear();
            Parameter.Add("@RootId", ((BL_ROOTTRANSACTION)classObject).RootId.ToString().Trim());
            Parameter.Add("@Customer_Id", ((BL_ROOTTRANSACTION)classObject).Customer_Id.ToString().Trim());
            Parameter.Add("@flag", "A");
            return blFill_Para_Name(Parameter, "SP_RootTransaction");
        }

        public DataSet UPDATE(object classObject)
        {

            Parameter.Clear();
            Parameter.Add("@RootTranId", ((BL_ROOTTRANSACTION)classObject).RootTranId.ToString().Trim());
            Parameter.Add("@Position", ((BL_ROOTTRANSACTION)classObject).Position.ToString().Trim());            
            Parameter.Add("@flag", "U");
            return blFill_Para_Name(Parameter, "SP_RootTransaction");
        }

        public DataSet DELETE(object classObject)
        {
            Parameter.Clear();
            Parameter.Add("@RootTranId", ((BL_ROOTTRANSACTION)classObject).RootTranId.ToString().Trim());
            Parameter.Add("@flag", "D");
            return blFill_Para_Name(Parameter, "SP_RootTransaction");
        }

        public void Fill_ListView(ListView Lvw, DataTable Dt)
        {
            throw new NotImplementedException();
        }

       
    }
}
