using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace BUSSINESS_LAYER
{
    public class BL_ACMASTER : BL, ICOMMON_CLASS_MASTER
    {
        int _PlNo;
        int _AcNo;
        string _AcName;
        string _AcEngName;
        string _AcUniName;

        public int PlNo { get { return _PlNo; } set { _PlNo = value; } }
        public int AcNo { get { return _AcNo; } set { _AcNo = value; } }
        public string AcName { get { return _AcName; } set { _AcName = value; } }
        public string AcEngName { get { return _AcEngName; } set { _AcEngName  = value; } }
        public string AcUniName { get { return _AcUniName; } set { _AcUniName = value; } }

        #region ICOMMON_CLASS_MASTER Members

        public DataSet SELECT(object classObject)
        {
            DataSet ds = new DataSet();
            DataTable dt = ExecuteQuery("Select plno,Plname from Tbl_PLMaster;").Tables[0].Copy();
            dt.TableName = "PLMASTER";
            ds.Tables.Add(dt);
            dt = ExecuteQuery("Select * from Tbl_ACMaster;").Tables[0].Copy();
            dt.TableName = "ACMASTER";
            ds.Tables.Add(dt);
            return ds;
        }

        public DataSet INSERT(object classObject)
        {
            try
            {

                Query = "insert into Tbl_ACMaster values(@PLNO,@ACNO,@ACNAME,@ACENGNAME,@ACUNINAME)";
                Parameter.Clear();
                Parameter.Add("@PLNO", ((BL_ACMASTER)classObject).PlNo.ToString());
                Parameter.Add("@ACNO", ((BL_ACMASTER)classObject).AcNo.ToString());
                Parameter.Add("@ACNAME", ((BL_ACMASTER)classObject).AcName.ToString());
                Parameter.Add("@ACENGNAME", ((BL_ACMASTER)classObject).AcEngName.ToString());
                Parameter.Add("@ACUNINAME", ((BL_ACMASTER)classObject).AcUniName.ToString());
                ExecuteNonQuery(Parameter, Query);

            }
            catch (Exception ex)
            {
            }
            return SELECT(classObject);
        }

        public DataSet UPDATE(object classObject)
        {
            try
            {

                Query = "update Tbl_ACMaster set AcName=@ACNAME,AcEngName=@ACENGNAME,AcUniName=@ACUNINAME where plno=@PLNO and Acno=@ACNO";
                Parameter.Clear();
                Parameter.Add("@ACNAME", ((BL_ACMASTER)classObject).AcName.ToString());
                Parameter.Add("@ACENGNAME", ((BL_ACMASTER)classObject).AcEngName.ToString());
                Parameter.Add("@ACUNINAME", ((BL_ACMASTER)classObject).AcUniName.ToString());
                Parameter.Add("@PLNO", ((BL_ACMASTER)classObject).PlNo.ToString());
                Parameter.Add("@ACNO", ((BL_ACMASTER)classObject).AcNo.ToString());
                ExecuteNonQuery(Parameter, Query);

            }
            catch (Exception ex)
            {
            }
            return SELECT(classObject);
        }

        public DataSet DELETE(object classObject)
        {
            try
            {
                Query = "delete from Tbl_ACMaster where plno=@PLNO and acno=@ACNO;";
                Parameter.Clear();
                Parameter.Add("@plno", ((BL_ACMASTER)classObject).PlNo.ToString());
                Parameter.Add("@ACNO", ((BL_ACMASTER)classObject).AcNo.ToString());
                ExecuteNonQuery(Parameter, Query);
            }
            catch (Exception)
            {

                throw;
            }

            return SELECT(classObject);
        }

        public void Fill_ListView(ListView LVW, DataTable Dt)
        {

        }

        #endregion



    }
}
