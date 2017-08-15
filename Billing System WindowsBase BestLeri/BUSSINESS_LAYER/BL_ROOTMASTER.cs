using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace BUSSINESS_LAYER
{
    public class BL_ROOTMASTER : BL, ICOMMON_CLASS_MASTER
    {
       
        int _RootId;
        public int RootId { get { return _RootId; } set { _RootId = value; } }


        int _Source;
        public int Source { get { return _Source; } set { _Source = value; } }


        int _Destination;
        public int Destination { get { return _Destination; } set { _Destination = value; } }

        //string _RootName;
        //public string RootName { get { return _RootName; } set { _RootName = value; } }

        int _SourceId;
        public int SourceId { get { return _SourceId; } set { _SourceId = value; } }

        #region ICOMMON_CLASS_MASTER Members

        public DataSet select(object classobject)
        {
            return blFill("SP_RootMaster");
        }

        public DataSet FindSource(object classObject)
        {
            Parameter.Clear();
            Parameter.Add("@SourceId", ((BL_ROOTMASTER)classObject).SourceId.ToString());
            Parameter.Add("@flag", "E");
            return blFill_Para_Name(Parameter, "SP_RootMaster");
        }

       
        public DataSet INSERT(object classObject)
        {
            Parameter.Clear();
            Parameter.Add("@Source", ((BL_ROOTMASTER)classObject).Source.ToString());
            Parameter.Add("@Destination", ((BL_ROOTMASTER)classObject).Destination.ToString());
            Parameter.Add("@flag", "A");
            return blFill_Para_Name(Parameter, "SP_RootMaster");
        }


        public DataSet UPDATE(object classObject)
        {
            Parameter.Clear();
            Parameter.Add("@RootId", ((BL_ROOTMASTER)classObject).RootId.ToString());
            Parameter.Add("@Source", ((BL_ROOTMASTER)classObject).Source.ToString());
            Parameter.Add("@Destination", ((BL_ROOTMASTER)classObject).Destination.ToString());
            Parameter.Add("@flag", "U");
            return blFill_Para_Name(Parameter, "SP_RootMaster");
        }

        public DataSet DELETE(object classObject)
        {
            Parameter.Clear();
            Parameter.Add("@RootId", ((BL_ROOTMASTER)classObject).RootId.ToString());
            Parameter.Add("@flag", "D");
            return blFill_Para_Name(Parameter, "SP_RootMaster");
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
