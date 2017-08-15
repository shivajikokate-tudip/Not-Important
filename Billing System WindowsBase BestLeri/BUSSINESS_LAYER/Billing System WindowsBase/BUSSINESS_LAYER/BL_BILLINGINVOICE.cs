using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace BUSSINESS_LAYER
{
    public class BL_BILLINGINVOICE:BL,ICOMMON_CLASS_MASTER
    {
        public DataSet SELECT(object classObject)
        {
            return blFill("Sp_PurchaseInvoice");
        }

        public DataSet INSERT(object classObject)
        {
            throw new NotImplementedException();
        }

        public DataSet UPDATE(object classObject)
        {
            throw new NotImplementedException();
        }

        public DataSet DELETE(object classObject)
        {
            throw new NotImplementedException();
        }

        public void Fill_ListView(ListView Lvw, DataTable Dt)
        {
            throw new NotImplementedException();
        }
    }
}
