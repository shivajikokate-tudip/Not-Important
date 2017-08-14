using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace BUSSINESS_LAYER
{
    public class BL_Permission : BL, ICOMMON_CLASS_MASTER
    {
        int _Group_Id;
        public int Group_Id
        {
            get { return _Group_Id; }
            set { _Group_Id = value; }
        }
        int _UserId;
        public int UserId
        {
            get { return _UserId; }
            set { _UserId = value; }
        }

        int _Menu_Id;
        public int Menu_Id
        {
            get { return _Menu_Id; }
            set { _Menu_Id = value; }
        }
        
        public DataSet SELECT(object classObject)
        {
            return blFill("sp_menupermission");
        }
         

        public DataSet INSERT(object classObject)
        {
            Parameter.Clear();
            Parameter.Add("@GroupID", ((BL_Permission)classObject).Group_Id.ToString().Trim());
            Parameter.Add("@flag", "A");
            return blFill_Para_Name(Parameter, "sp_menupermission");
        }

        public DataSet UPDATE(object classObject)
        {
            Parameter.Clear();
            Parameter.Add("@GroupID", ((BL_Permission)classObject).Group_Id.ToString().Trim());
            Parameter.Add("@Menu_Id", ((BL_Permission)classObject).Menu_Id.ToString().Trim());            
            Parameter.Add("@flag", "U");
            return blFill_Para_Name(Parameter, "sp_menupermission");
        }

        public DataSet DELETE(object classObject)
        {
            Parameter.Clear();
            Parameter.Add("@itemid", ((BL_Permission)classObject).UserId.ToString().Trim());
            Parameter.Add("@flag", "13");
            return blFill_Para_Name(Parameter, "SP_FILLDDL");
        }

        public void Fill_ListView(ListView Lvw, DataTable Dt)
        {
            throw new NotImplementedException();
        }
        public DataSet fillddl(object classObject) 
        {
            Parameter.Clear();
            Parameter.Add("@GroupID", ((BL_Permission)classObject).Group_Id.ToString().Trim());
            Parameter.Add("@flag", "F");
            return blFill_Para_Name(Parameter, "SP_UserMaster");
        }
    }
}
