using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace BUSSINESS_LAYER
{
    public class BL_ROWMATERIALMASTER : BL, ICOMMON_CLASS_MASTER
    {
        int _RowMaterialId;
        public int RowMaterialId { get { return _RowMaterialId; } set { _RowMaterialId = value; } }

        string _RowMaterialName;
        public string RowMaterialName { get { return _RowMaterialName; } set { _RowMaterialName = value; } }

        char _RowMaterialFlag;
        public char RowMaterialFlag { get { return _RowMaterialFlag; } set { _RowMaterialFlag = value; } }

        int _MeasurmentId;
        public int MeasurmentId { get { return _MeasurmentId; } set { _MeasurmentId = value; } }

        int _RowHedarId;
        public int RowHedarId { get { return _RowHedarId; } set { _RowHedarId = value; } }


        #region ICOMMON_CLASS_MASTER Members

        public DataSet select(object classobject)
        {
            return blFill("SP_RowMaterialMaster");
        }
        public DataSet INSERT(object classObject)
        {
            Parameter.Clear();
            Parameter.Add("@RowMaterialId", ((BL_ROWMATERIALMASTER)classObject).RowMaterialId.ToString());
            Parameter.Add("@RowMaterialName", ((BL_ROWMATERIALMASTER)classObject).RowMaterialName.ToString());
            Parameter.Add("@RowMaterialFlag", ((BL_ROWMATERIALMASTER)classObject).RowMaterialFlag.ToString());
            Parameter.Add("@MeasurmentId", ((BL_ROWMATERIALMASTER)classObject).MeasurmentId.ToString());
            Parameter.Add("@RowHedarId", ((BL_ROWMATERIALMASTER)classObject).RowHedarId.ToString());
            Parameter.Add("@flag", "A");
            return blFill_Para_Name(Parameter, "SP_RowMaterialMaster");
        }

        public DataSet UPDATE(object classObject)
        {
            Parameter.Clear();
            Parameter.Add("@RowMaterialId", ((BL_ROWMATERIALMASTER)classObject).RowMaterialId.ToString());
            Parameter.Add("@RowMaterialName", ((BL_ROWMATERIALMASTER)classObject).RowMaterialName.ToString());
            Parameter.Add("@RowMaterialFlag", ((BL_ROWMATERIALMASTER)classObject).RowMaterialFlag.ToString());
            Parameter.Add("@MeasurmentId", ((BL_ROWMATERIALMASTER)classObject).MeasurmentId.ToString());
            Parameter.Add("@RowHedarId", ((BL_ROWMATERIALMASTER)classObject).RowHedarId.ToString());
            Parameter.Add("@flag", "U");
            return blFill_Para_Name(Parameter, "SP_RowMaterialMaster");
        }

        public DataSet DELETE(object classObject)
        {
            Parameter.Clear();
            Parameter.Add("@RowMaterialId", ((BL_ROWMATERIALMASTER)classObject).RowMaterialId.ToString());
            Parameter.Add("@flag", "D");
            return blFill_Para_Name(Parameter, "SP_RowMaterialMaster");
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
