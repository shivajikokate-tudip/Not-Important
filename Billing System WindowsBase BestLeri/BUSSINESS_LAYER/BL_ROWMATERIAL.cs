using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace BUSSINESS_LAYER
{
    public class BL_ROWMATERIAL : BL, ICOMMON_CLASS_MASTER
    {
        int _RowHedarId;
        public int RowHedarId { get { return _RowHedarId; } set { _RowHedarId = value; } }

        string _RowHedarName;
        public string RowHedarName { get { return _RowHedarName; } set { _RowHedarName = value; } }

        #region ICOMMON_CLASS_MASTER Members

        public DataSet select(object classobject)
        {
            return blFill("SP_RowHedar");
        }

        public DataSet INSERT(object classObject)
        {
            Parameter.Clear();
            Parameter.Add("@RowHedarId", ((BL_ROWMATERIAL)classObject).RowHedarId.ToString());
            Parameter.Add("@RowHedarName", ((BL_ROWMATERIAL)classObject).RowHedarName.ToString());
            Parameter.Add("@flag", "A");
            return blFill_Para_Name(Parameter, "SP_RowHedar");
        }

        public DataSet UPDATE(object classObject)
        {
            Parameter.Clear();
            Parameter.Add("@RowHedarId", ((BL_ROWMATERIAL)classObject).RowHedarId.ToString());
            Parameter.Add("@RowHedarName", ((BL_ROWMATERIAL)classObject).RowHedarName.ToString());
            Parameter.Add("@flag", "U");
            return blFill_Para_Name(Parameter, "SP_RowHedar");
        }

        public DataSet DELETE(object classObject)
        {
            Parameter.Clear();
            Parameter.Add("@RowHedarId", ((BL_ROWMATERIAL)classObject).RowHedarId.ToString());
            Parameter.Add("@flag", "D");
            return blFill_Para_Name(Parameter, "SP_RowHedar");
        }

        #endregion

        public DataSet SELECT(object classObject)
        {
            throw new NotImplementedException();
        }


        public void Fill_ListView(ListView Lvw, DataTable Dt)
        {
            throw new NotImplementedException();
        }
    }
}
