using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace BUSSINESS_LAYER
{
    public class BL_PSMASTER : BL, ICOMMON_CLASS_MASTER
    {
        #region Local Variables
        int _Maxid;
        int _PlNo;
        int _AcNo;
        int _PsNo;
        string _PsSubno;
        string _PsName;
        string _PsEngName;
        string _PsUniName;
        string _PsLocation;
        string _PsEngLocation;
        string _PsUniLocation;
        int _EvmUsed;
        #endregion

        #region Variable Asseccible From Outside the Class
        public int Maxid { get { return _Maxid; } set { _Maxid = value; } }
        public int PlNo { get { return _PlNo; } set { _PlNo = value; } }
        public int AcNo { get { return _AcNo; } set { _AcNo = value; } }
        public int PsNo { get { return _PsNo; } set { _PsNo = value; } }
        public string PsSubno { get { return _PsSubno; } set { _PsSubno = value; } }
        public string PsName { get { return _PsName; } set { _PsName = value; } }
        public string PsEngName { get { return _PsEngName; } set { _PsEngName = value; } }
        public string PsUniName { get { return _PsUniName; } set { _PsUniName = value; } }

        public string PsLocation { get { return _PsLocation; } set { _PsLocation = value; } }
        public string PsEngLocation { get { return _PsEngLocation; } set { _PsEngLocation = value; } }
        public string PsUniLocation { get { return _PsUniLocation; } set { _PsUniLocation = value; } }
        public int EvmUsed { get { return _EvmUsed; } set { _EvmUsed = value; } }
        #endregion

        #region ICOMMON_CLASS_MASTER Members

        public DataSet SELECT(object classObject)
        {
            DataSet ds = new DataSet();
            DataTable dt = ExecuteQuery("Select plno,Plname,plengName,plUniName from Tbl_PLMaster;").Tables[0].Copy();
            dt.TableName = "PLMASTER";
            ds.Tables.Add(dt);
            dt = ExecuteQuery("Select Acno,Acname,plno,AcEngNAme,AcUniName from Tbl_ACMaster;").Tables[0].Copy();
            dt.TableName = "ACMASTER";
            ds.Tables.Add(dt);
            dt = ExecuteQuery("Select * from Tbl_PSMaster;").Tables[0].Copy();
            dt.TableName = "PSMASTER";
            ds.Tables.Add(dt);
            return ds;
        }

        public DataSet INSERT(object classObject)
        {
            try
            {
                int maxid = 0;
                Query = "select max(maxid) from Tbl_Psmaster where plno=@PLNo and acno=@Acno";
                Parameter.Clear();
                Parameter.Add("@PLNo", ((BL_PSMASTER)classObject).PlNo.ToString());
                Parameter.Add("@Acno", ((BL_PSMASTER)classObject).AcNo.ToString());
                string ds = ExecuteScaler(Parameter, Query);
                //if (ds.Tables.Count >= 1 && ds.Tables[0].Rows.Count >= 1)
                //maxid = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString());
                maxid = Convert.ToInt32(ds);
                maxid += 1;

                Query = "insert into Tbl_PsMaster values(" + maxid + ",@PLNo,	@Acno,	@PSNo,	@Subno,	@PSName,	@PSEngName,	@PSUNIName,	@PSLocation,	@PSEngLocation,	@PSUNILocation,	@EvmUsed)";
                Parameter.Clear();
                Parameter.Add("@PLNo", ((BL_PSMASTER)classObject).PlNo.ToString());
                Parameter.Add("@Acno", ((BL_PSMASTER)classObject).AcNo.ToString());
                Parameter.Add("@PSNo", ((BL_PSMASTER)classObject).PsNo.ToString());
                Parameter.Add("@Subno", ((BL_PSMASTER)classObject).PsSubno.ToString());
                Parameter.Add("@PSName", ((BL_PSMASTER)classObject).PsName.ToString());
                Parameter.Add("@PSEngName", ((BL_PSMASTER)classObject).PsEngName.ToString());
                Parameter.Add("@PSUNIName", ((BL_PSMASTER)classObject).PsUniName.ToString());
                Parameter.Add("@PSLocation", ((BL_PSMASTER)classObject).PsLocation.ToString());
                Parameter.Add("@PSEngLocation", ((BL_PSMASTER)classObject).PsEngLocation.ToString());
                Parameter.Add("@PSUNILocation", ((BL_PSMASTER)classObject).PsUniLocation.ToString());
                Parameter.Add("@EvmUsed", ((BL_PSMASTER)classObject).EvmUsed.ToString());
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

                Query = "update Tbl_PsMaster set psname=@PSName,psengname=@PSEngName,PSUNIName=@PSUNIName,PSLocation=@PSLocation,	PSEngLocation=@PSEngLocation,PSUNILocation=@PSUNILocation,EvmUsed=@EvmUsed where plno=@PLNo and acno=@Acno and psno=@PSNo and subno=@Subno";
                Parameter.Clear();
                Parameter.Add("@PSName", ((BL_PSMASTER)classObject).PsName.ToString());
                Parameter.Add("@PSEngName", ((BL_PSMASTER)classObject).PsEngName.ToString());
                Parameter.Add("@PSUNIName", ((BL_PSMASTER)classObject).PsUniName.ToString());
                Parameter.Add("@PSLocation", ((BL_PSMASTER)classObject).PsLocation.ToString());
                Parameter.Add("@PSEngLocation", ((BL_PSMASTER)classObject).PsEngLocation.ToString());
                Parameter.Add("@PSUNILocation", ((BL_PSMASTER)classObject).PsUniLocation.ToString());
                Parameter.Add("@EvmUsed", ((BL_PSMASTER)classObject).EvmUsed.ToString());
                Parameter.Add("@PLNo", ((BL_PSMASTER)classObject).PlNo.ToString());
                Parameter.Add("@Acno", ((BL_PSMASTER)classObject).AcNo.ToString());
                Parameter.Add("@PSNo", ((BL_PSMASTER)classObject).PsNo.ToString());
                Parameter.Add("@Subno", ((BL_PSMASTER)classObject).PsSubno.ToString());
 
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
                Query = "delete from Tbl_PsMaster where plno=@PLNo and acno=@Acno and psno=@PSNo and subno=@Subno;";
                Parameter.Clear();
                Parameter.Add("@PLNo", ((BL_PSMASTER)classObject).PlNo.ToString());
                Parameter.Add("@Acno", ((BL_PSMASTER)classObject).AcNo.ToString());
                Parameter.Add("@PSNo", ((BL_PSMASTER)classObject).PsNo.ToString());
                Parameter.Add("@Subno", ((BL_PSMASTER)classObject).PsSubno.ToString());
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
