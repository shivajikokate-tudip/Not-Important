using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace BUSSINESS_LAYER
{
   public  class BL_LOGIN : BL
    {
       string _UserName;
       public string UserName { get { return _UserName; } set { _UserName = value; } }

       string _Password;
       public string Password { get { return _Password; } set { _Password = value; } }
        
       public DataSet select(object classobject)
        {
            Parameter.Clear();
           Parameter.Add("@UserName",((BL_LOGIN)classobject).UserName.ToString());
           Parameter.Add("@Password", ((BL_LOGIN)classobject).Password.ToString());
           return blFill_Para_Name(Parameter, "sp_Login");
        }
    }
}
