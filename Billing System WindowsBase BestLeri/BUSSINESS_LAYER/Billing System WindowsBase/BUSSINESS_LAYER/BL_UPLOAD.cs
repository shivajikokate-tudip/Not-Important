using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace BUSSINESS_LAYER
{
   public class BL_UPLOAD : BL, ICOMMON_CLASS_MASTER
    {
        #region Local Variables
        int _PlNo;
        int _AcNo;
        int _PsNo;
        string _PsSubno;
        #endregion

        #region Variable Asseccible From Outside the Class
        public int PlNo { get { return _PlNo; } set { _PlNo = value; } }
        public int AcNo { get { return _AcNo; } set { _AcNo = value; } }
        public int PsNo { get { return _PsNo; } set { _PsNo = value; } }
        public string PsSubno { get { return _PsSubno; } set { _PsSubno = value; } }
        #endregion

        #region ICOMMON_CLASS_MASTER Members

        public DataSet SELECT(object classObject)
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            Parameter.Clear();
            Parameter.Add("@PLNO", ((BL_UPLOAD)classObject).PlNo.ToString());
            Parameter.Add("@ACNO", ((BL_UPLOAD)classObject).AcNo.ToString());
            Query = @"select plno,acno,psno,subno from tbl_pollingdetails where plno=@plno and acno=@acno";

            dt = ExecuteQuery(Parameter, Query).Tables[0].Copy();
            dt.TableName = "LocalDetails";
            ds.Tables.Add(dt);

            dt = new DataTable();
            Parameter.Clear();
            Parameter.Add("@PLNO", ((BL_UPLOAD)classObject).PlNo.ToString());
            Parameter.Add("@ACNO", ((BL_UPLOAD)classObject).AcNo.ToString());
            Query = @"Sp_UPLOAD";

            dt = blFill_Para_Name(Parameter, Query).Tables[0].Copy();
            dt.TableName = "SERVERDetails";
            ds.Tables.Add(dt);
            return ds;
        }

        public DataSet INSERT(object classObject)
        {
            return new DataSet();
        }

        public DataSet UPDATE(object classObject)
        {
            return new DataSet();
        }

        public DataSet DELETE(object classObject)
        {
            return new DataSet();
        }

        public void Fill_ListView(ListView Lvw, DataTable Dt)
        {
            
        }

        #endregion
    }
}
