using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;


namespace BUSSINESS_LAYER
{
    public class BL_ITEMMASTER : BL, ICOMMON_CLASS_MASTER
    {
        int _ItmeId;
        public int ItemId { get { return _ItmeId; } set { _ItmeId = value; } }
        public string ItemName { get; set; }

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
            Parameter.Add("@flag", "A");
            return blFill_Para_Name(Parameter, "SP_ItemMaster");
        }
                
        public DataSet UPDATE(object classObject)
        {
            Parameter.Clear();
            Parameter.Add("@ItemId", ((BL_ITEMMASTER)classObject).ItemId.ToString());
            Parameter.Add("@ItemName", ((BL_ITEMMASTER)classObject).ItemName);
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
