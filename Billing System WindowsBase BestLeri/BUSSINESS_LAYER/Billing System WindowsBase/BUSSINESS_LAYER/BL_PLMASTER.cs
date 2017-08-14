using System.Data;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Text;
using BUSSINESS_LAYER;

namespace BUSSINESS_LAYER
{
    public class BL_PLMASTER : BL, ICOMMON_CLASS_MASTER
    {
        int _PlNo;
        string _PlName;
        string _PlEngName;
        string _PlUniName;

        public int PlNo { get { return _PlNo; } set { _PlNo = value; } }
        public string PlName { get { return _PlName; } set { _PlName = value; } }
        public string PlEngName { get { return _PlEngName; } set { _PlEngName = value; } }
        public string PlUniName { get { return _PlUniName; } set { _PlUniName = value; } }

        #region ICOMMON_CLASS_MASTER Members

        public DataSet SELECT(object classObject)
        {
            return ExecuteQuery("Select * from Tbl_PlMaster;");
        }

        public DataSet INSERT(object classObject)
        {
            try
            {
               
                Query = "insert into Tbl_PlMaster values(@plno,@PlName,@PlEngName,@PlUniName)";
                Parameter.Clear();
                Parameter.Add("@plno", ((BL_PLMASTER)classObject).PlNo.ToString());
                Parameter.Add("@PlName", ((BL_PLMASTER)classObject).PlName.ToString());
                Parameter.Add("@PlEngName", ((BL_PLMASTER)classObject).PlEngName.ToString());
                Parameter.Add("@PlUniName", ((BL_PLMASTER)classObject).PlUniName.ToString());
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

                Query = "update Tbl_PlMaster set PlName=@PlName,PlEngName=@PlEngName,PlUniName=@PlUniName where plno=@plno";
                Parameter.Clear();
                Parameter.Add("@PlName", ((BL_PLMASTER)classObject).PlName.ToString());
                Parameter.Add("@PlEngName", ((BL_PLMASTER)classObject).PlEngName.ToString());
                Parameter.Add("@PlUniName", ((BL_PLMASTER)classObject).PlUniName.ToString());
                Parameter.Add("@plno", ((BL_PLMASTER)classObject).PlNo.ToString());
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
                Query = "delete from Tbl_PlMaster where plno=@plno;";
                Parameter.Clear();
                Parameter.Add("@plno", ((BL_PLMASTER)classObject).PlNo.ToString());
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
