using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
namespace BUSSINESS_LAYER
{
    public class BL_SUBEXPENCESMASTER : BL, ICOMMON_CLASS_MASTER
   {
       int _ExpencesId;
       public int ExpencesId { get { return _ExpencesId; } set { _ExpencesId = value; } }
       int _SubExpencesId;
       public int SubExpencesId { get { return _SubExpencesId; } set { _SubExpencesId = value; } }
       string _SubExpencesName;
       public string SubExpencesName { get { return _SubExpencesName; } set { _SubExpencesName = value; } }

       public DataSet SELECT(object classObject)
       {
           return blFill("SP_SubExpencesMaster");
       }

       public DataSet INSERT(object classObject)
       {
           Parameter.Clear();
           Parameter.Add("@Expences_ID", ((BL_SUBEXPENCESMASTER)classObject).ExpencesId.ToString());
           Parameter.Add("@SubExpences_Name", ((BL_SUBEXPENCESMASTER)classObject).SubExpencesName.ToString());
           Parameter.Add("@flag", "A");
           return blFill_Para_Name(Parameter, "SP_SubExpencesMaster");
       }

       public DataSet UPDATE(object classObject)
       {
           Parameter.Clear();
           Parameter.Add("@SubExpences_ID", ((BL_SUBEXPENCESMASTER)classObject).SubExpencesId.ToString());
           Parameter.Add("@Expences_ID", ((BL_SUBEXPENCESMASTER)classObject).ExpencesId.ToString());
           Parameter.Add("@SubExpences_Name", ((BL_SUBEXPENCESMASTER)classObject).SubExpencesName.ToString());
           Parameter.Add("@flag", "U");
           return blFill_Para_Name(Parameter, "SP_SubExpencesMaster");
       }

       public DataSet DELETE(object classObject)
       {
           Parameter.Clear();
           Parameter.Add("@SubExpences_ID", ((BL_SUBEXPENCESMASTER)classObject).SubExpencesId.ToString());
           Parameter.Add("@flag", "D");
           return blFill_Para_Name(Parameter, "SP_SubExpencesMaster");
       }

       public void Fill_ListView(ListView Lvw, DataTable Dt)
       {
           throw new NotImplementedException();
       }
   }
}
