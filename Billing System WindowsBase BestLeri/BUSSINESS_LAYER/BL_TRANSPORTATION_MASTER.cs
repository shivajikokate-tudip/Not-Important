using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace BUSSINESS_LAYER
{
    public class BL_TRANSPORTATION_MASTER : BL, ICOMMON_CLASS_MASTER
    {

        int _TranspotationId;
        public int TranspotationId { get { return _TranspotationId; } set { _TranspotationId = value; } }

        string _TransportationName;
        public string TransportationName { get { return _TransportationName; } set { _TransportationName = value; } }

        string _Transportation_Address;
        public string Transportation_Address { get { return _Transportation_Address; } set { _Transportation_Address = value; } }

        string _Transportation_Number;
        public string Transportation_Number { get { return _Transportation_Number; } set { _Transportation_Number = value; } }


        #region ICOMMON_CLASS_MASTER Members

        public DataSet select(object classobject)
        {
            return blFill("Sp_TransportationMaster");
        }


        public DataSet INSERT(object classObject)
        {
            Parameter.Clear();
            Parameter.Add("@TranspotationId", ((BL_TRANSPORTATION_MASTER)classObject).TranspotationId.ToString());
            Parameter.Add("@TransportationName", ((BL_TRANSPORTATION_MASTER)classObject).TransportationName.ToString());
            Parameter.Add("@Transportation_Address", ((BL_TRANSPORTATION_MASTER)classObject).Transportation_Address.ToString());
            Parameter.Add("@Transportation_Number", ((BL_TRANSPORTATION_MASTER)classObject)._Transportation_Number.ToString());
            Parameter.Add("@flag", "A");
            return blFill_Para_Name(Parameter, "Sp_TransportationMaster");
        }


        public DataSet UPDATE(object classObject)
        {
            Parameter.Clear();
            Parameter.Add("@TranspotationId", ((BL_TRANSPORTATION_MASTER)classObject).TranspotationId.ToString());
            Parameter.Add("@TransportationName", ((BL_TRANSPORTATION_MASTER)classObject).TransportationName.ToString());
            Parameter.Add("@Transportation_Address", ((BL_TRANSPORTATION_MASTER)classObject).Transportation_Address.ToString());
            Parameter.Add("@Transportation_Number", ((BL_TRANSPORTATION_MASTER)classObject)._Transportation_Number.ToString()); 
            Parameter.Add("@flag", "U");
            return blFill_Para_Name(Parameter, "Sp_TransportationMaster");
        }

        public DataSet DELETE(object classObject)
        {
            Parameter.Clear();
            Parameter.Add("@TranspotationId", ((BL_TRANSPORTATION_MASTER)classObject).TranspotationId.ToString());
            Parameter.Add("@flag", "D");
            return blFill_Para_Name(Parameter, "Sp_TransportationMaster");
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
