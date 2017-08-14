using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;


namespace BUSSINESS_LAYER
{
    public class BL_ITEMMASTER : BL, ICOMMON_CLASS_MASTER
    {
        int _ItmeId, _MeasurmentId; string _ItemName,_PFlag;
        public int MeasurmentId { get { return _MeasurmentId; } set { _MeasurmentId = value; } }
        public int ItemId { get { return _ItmeId; } set { _ItmeId = value; } }
        public string ItemName { get { return _ItemName; } set { _ItemName = value; } }
        public string PFlag { get { return _PFlag; } set { _PFlag = value; } }

        #region ICOMMON_CLASS_MASTER Members

        public DataSet select(object classobject)
        {
            return blFill("SP_ItemMaster");
        }

        public DataSet INSERT(object classObject)
        {
            Parameter.Clear();
            Parameter.Add("@ItemId", ((BL_ITEMMASTER)classObject).ItemId.ToString());
            Parameter.Add("@ItemName", ((BL_ITEMMASTER)classObject).ItemName.ToString());
            Parameter.Add("@MeasurmentId", ((BL_ITEMMASTER)classObject).MeasurmentId.ToString());
            Parameter.Add("@PFlag", ((BL_ITEMMASTER)classObject).PFlag.ToString());
            Parameter.Add("@flag", "A");
            return blFill_Para_Name(Parameter, "SP_ItemMaster");
        }
                
        public DataSet UPDATE(object classObject)
        {
            Parameter.Clear();
            Parameter.Add("@ItemId", ((BL_ITEMMASTER)classObject).ItemId.ToString());
            Parameter.Add("@ItemName", ((BL_ITEMMASTER)classObject).ItemName.ToString());
            Parameter.Add("@MeasurmentId", ((BL_ITEMMASTER)classObject).MeasurmentId.ToString());
            Parameter.Add("@PFlag", ((BL_ITEMMASTER)classObject).PFlag.ToString());
            Parameter.Add("@flag", "U");
            return blFill_Para_Name(Parameter, "SP_ItemMaster");
        }

        public DataSet DELETE(object classObject)
        {
            Parameter.Clear();
            Parameter.Add("@ItemId", ((BL_ITEMMASTER)classObject).ItemId.ToString());
            Parameter.Add("@flag", "D");
            return blFill_Para_Name(Parameter, "SP_ItemMaster");
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
