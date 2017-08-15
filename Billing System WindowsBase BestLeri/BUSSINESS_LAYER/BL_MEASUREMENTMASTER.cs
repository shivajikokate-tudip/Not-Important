using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace BUSSINESS_LAYER
{
    public class BL_MEASUREMENTMASTER : BL, ICOMMON_CLASS_MASTER
    {
        int _MeasurementId;
        public int MeasurementId { get { return _MeasurementId; } set { _MeasurementId = value; } }

        string _MeasurementName;
        public string MeasurementName { get { return _MeasurementName; } set { _MeasurementName = value; } }

        #region ICOMMON_CLASS_MASTER Members

        public DataSet select(object classobject)
        {
            return blFill("SP_MeasurementMaster");
        }


        public DataSet INSERT(object classObject)
        {
            Parameter.Clear();
            Parameter.Add("@MeasurmentId", ((BL_MEASUREMENTMASTER)classObject).MeasurementId.ToString());
            Parameter.Add("@Measurement_Name", ((BL_MEASUREMENTMASTER)classObject).MeasurementName.ToString());
            Parameter.Add("@flag", "A");
            return blFill_Para_Name(Parameter, "SP_MeasurementMaster");
        }


        public DataSet UPDATE(object classObject)
        {
            Parameter.Clear();
            Parameter.Add("@MeasurmentId", ((BL_MEASUREMENTMASTER)classObject).MeasurementId.ToString());
            Parameter.Add("@Measurement_Name", ((BL_MEASUREMENTMASTER)classObject).MeasurementName.ToString());
            Parameter.Add("@flag", "U");
            return blFill_Para_Name(Parameter, "SP_MeasurementMaster");
        }

        public DataSet DELETE(object classObject)
        {
            Parameter.Clear();
            Parameter.Add("@MeasurmentId", ((BL_MEASUREMENTMASTER)classObject).MeasurementId.ToString());
            Parameter.Add("@flag", "D");
            return blFill_Para_Name(Parameter, "SP_MeasurementMaster");
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
