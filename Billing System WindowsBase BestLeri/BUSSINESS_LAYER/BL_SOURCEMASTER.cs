using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;


namespace BUSSINESS_LAYER
{
    public class BL_SOURCEMASTER : BL, ICOMMON_CLASS_MASTER
    {
        int _SourceId;
        public int SourceId { get { return _SourceId; } set { _SourceId = value; } }

        string _SourceName;
        public string SourceName { get { return _SourceName; } set { _SourceName = value; } }

        #region ICOMMON_CLASS_MASTER Members

        public DataSet select(object classobject)
        {
            return blFill("SP_SourceMaster");
        }


        public DataSet INSERT(object classObject)
        {
            Parameter.Clear();
            Parameter.Add("@SourceName", ((BL_SOURCEMASTER)classObject).SourceName.ToString());
            Parameter.Add("@flag", "A");
            return blFill_Para_Name(Parameter, "SP_SourceMaster");
        }


        public DataSet UPDATE(object classObject)
        {
            Parameter.Clear();
            Parameter.Add("@SourceId", ((BL_SOURCEMASTER)classObject).SourceId.ToString());
            Parameter.Add("@SourceName", ((BL_SOURCEMASTER)classObject).SourceName.ToString());
            Parameter.Add("@flag", "U");
            return blFill_Para_Name(Parameter, "SP_SourceMaster");
        }

        public DataSet DELETE(object classObject)
        {
            Parameter.Clear();
            Parameter.Add("@SourceId", ((BL_SOURCEMASTER)classObject).SourceId.ToString());
            Parameter.Add("@flag", "D");
            return blFill_Para_Name(Parameter, "SP_SourceMaster");
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
