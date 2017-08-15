using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace BUSSINESS_LAYER
{
    public class BL_Product : BL,ICOMMON_CLASS_MASTER
    {

        int _ProductId;
        public int Product_Id { get { return _ProductId; } set { _ProductId = value; } }

        public string ProductName { get; set; }




        #region ICOMMON_CLASS_MASTER Members

        public DataSet SELECT(object classObject)
        {
            return blFill("SP_ProductMaster");
        }

        public DataSet INSERT(object classObject)
        {
            Parameter.Clear();
            Parameter.Add("@product_id", ((BL_Product)classObject).Product_Id.ToString());
            Parameter.Add("@product_name", ((BL_Product)classObject).ProductName);
            Parameter.Add("@flag", "A");
            return blFill_Para_Name(Parameter, "SP_ProductMaster");
        }

        public DataSet UPDATE(object classObject)
        {
            Parameter.Clear();
            Parameter.Add("@product_id", ((BL_Product)classObject).Product_Id.ToString());
            Parameter.Add("@product_name", ((BL_Product)classObject).ProductName);
            Parameter.Add("@flag", "U");
            return blFill_Para_Name(Parameter, "SP_ProductMaster");
        }

        public DataSet DELETE(object classObject)
        {
            Parameter.Clear();
            Parameter.Add("@product_id", ((BL_Product)classObject).Product_Id.ToString());
            Parameter.Add("@flag", "D");
            return blFill_Para_Name(Parameter, "SP_ProductMaster");
        }

        public void Fill_ListView(ListView Lvw, DataTable Dt)
        {

        }

        #endregion
    }
}
