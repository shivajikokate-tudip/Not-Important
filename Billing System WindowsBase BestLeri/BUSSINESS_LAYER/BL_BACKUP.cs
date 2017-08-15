using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace BUSSINESS_LAYER
{
    public class BL_BACKUP : BL, ICOMMON_CLASS_MASTER
    {
        #region ICOMMON_CLASS_MASTER Members
        public DataSet select(object classobject)
        {
            return blFill("SP_TestBackUpSQL");
        }


        public DataSet INSERT(object classObject)
        {
            return blFill("SP_TestBackUpSQL");
        }


        public DataSet UPDATE(object classObject)
        {
         return blFill("SP_TestBackUpSQL");
        }

        public DataSet DELETE(object classObject)
        {
        return blFill("SP_TestBackUpSQL");
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
