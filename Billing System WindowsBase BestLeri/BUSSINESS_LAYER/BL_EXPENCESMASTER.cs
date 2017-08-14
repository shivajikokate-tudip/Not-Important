using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace BUSSINESS_LAYER
{
        public class BL_EXPENCESMASTER : BL, ICOMMON_CLASS_MASTER
    {
        int _ExpencesId;
        public int ExpencesId { get { return _ExpencesId; } set { _ExpencesId = value; } }

        string _ExpencesName;
        public string ExpencesName { get { return _ExpencesName; } set { _ExpencesName = value; } }
        string _OptionType;
        public string OptionType  { get{return _OptionType;} set{_OptionType=value;} }
        #region ICOMMON_CLASS_MASTER Members

        public DataSet select(object classobject)
        {
            return blFill("SP_ExpencesMaster");
        }


        public DataSet INSERT(object classObject)
        {
            Parameter.Clear();
            //` Parameter.Add("@Expences_Id", ((BL_EXPENCESMASTER)classObject).ExpencesId.ToString()); 
            Parameter.Add("@Option_Type", ((BL_EXPENCESMASTER)classObject).OptionType.ToString());
            Parameter.Add("@Expences_Name", ((BL_EXPENCESMASTER)classObject).ExpencesName.ToString());
            Parameter.Add("@flag", "A");
            return blFill_Para_Name(Parameter, "SP_ExpencesMaster");
        }


        public DataSet UPDATE(object classObject)
        {
            Parameter.Clear();
            Parameter.Add("@Expences_Id", ((BL_EXPENCESMASTER)classObject).ExpencesId.ToString());
            Parameter.Add("@Option_Type", ((BL_EXPENCESMASTER)classObject).OptionType.ToString());
            Parameter.Add("@Expences_Name", ((BL_EXPENCESMASTER)classObject).ExpencesName.ToString());
            Parameter.Add("@flag", "U");
            return blFill_Para_Name(Parameter, "SP_ExpencesMaster");
        }

        public DataSet DELETE(object classObject)
        {
            Parameter.Clear();
            Parameter.Add("@Expences_Id", ((BL_EXPENCESMASTER)classObject).ExpencesId.ToString());
            Parameter.Add("@flag", "D");
            return blFill_Para_Name(Parameter, "SP_ExpencesMaster");
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
