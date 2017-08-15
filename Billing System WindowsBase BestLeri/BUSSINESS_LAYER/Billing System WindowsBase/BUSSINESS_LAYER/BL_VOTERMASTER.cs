using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace BUSSINESS_LAYER
{
    public class BL_VOTERMASTER:BL,ICOMMON_CLASS_MASTER
    {
        #region Local Variables
        int _Maxid;
        int _PlNo;
        int _AcNo;
        int _PsNo;
        string _PsSubno;
        int _TMVoters;
        int _TFVoters;
        int _TVoters;
        int _TSHVoters;
        
        #endregion

        #region Variable Asseccible From Outside the Class
        public int Maxid { get { return _Maxid; } set { _Maxid = value; } }
        public int PlNo { get { return _PlNo; } set { _PlNo = value; } }
        public int AcNo { get { return _AcNo; } set { _AcNo = value; } }
        public int PsNo { get { return _PsNo; } set { _PsNo = value; } }
        public string PsSubno { get { return _PsSubno; } set { _PsSubno = value; } }
        public int TMVoters { get { return _TMVoters; } set { _TMVoters = value; } }
        public int TFVoters { get { return _TFVoters; } set { _TFVoters = value; } }
        public int TVoters { get { return _TVoters; } set { _TVoters = value; } }
        public int TSHVoters { get { return _TSHVoters; } set { _TSHVoters = value; } }

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
            dt = ExecuteQuery("Select PsNo & ':' & subno ,PsNo & ':' & subno & ':' & PsEngName from TBL_PSMASTER;").Tables[0].Copy();
            dt.TableName = "PSMASTER";
            ds.Tables.Add(dt);
            dt = ExecuteQuery("Select * from Tbl_VotersMaster;").Tables[0].Copy();
            dt.TableName = "VoterMASTER";
            ds.Tables.Add(dt);
            return ds;
        }

        public DataSet INSERT(object classObject)
        {
            try
            {
                int maxid = 0;
                Query = "select max(maxid) from Tbl_VotersMAster where plno=@PLNo and acno=@Acno and psno=@psno and SubNo='@subno'";
                Parameter.Clear();
                Parameter.Add("@PLNo", ((BL_VOTERMASTER)classObject).PlNo.ToString());
                Parameter.Add("@Acno", ((BL_VOTERMASTER)classObject).AcNo.ToString());
                Parameter.Add("@PsNo", ((BL_VOTERMASTER)classObject).PsNo.ToString());
                Parameter.Add("@SubNo", ((BL_VOTERMASTER)classObject).PsSubno.ToString());  
                string ds = ExecuteScaler(Parameter, Query);
                //if (ds.Tables.Count >= 1 && ds.Tables[0].Rows.Count >= 1)
                //maxid = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString());
                try
                {
                    maxid = Convert.ToInt32(ds);
                }
                catch (Exception ex)
                {}
                
                maxid += 1;

                Query = "insert into Tbl_VotersMaster values(" + maxid + ",@PLNo,	@Acno,	@PSNo,	@Subno,	@TMvoters,	@TFvoters,	@TVoters,	@TshVoters)";
                Parameter.Clear();
                Parameter.Add("@PLNo", ((BL_VOTERMASTER)classObject).PlNo.ToString());
                Parameter.Add("@Acno", ((BL_VOTERMASTER)classObject).AcNo.ToString());
                Parameter.Add("@PSNo", ((BL_VOTERMASTER)classObject).PsNo.ToString());
                Parameter.Add("@Subno", ((BL_VOTERMASTER)classObject).PsSubno.ToString());
                Parameter.Add("@TMvoters", ((BL_VOTERMASTER)classObject).TMVoters.ToString());
                Parameter.Add("@TFvoters", ((BL_VOTERMASTER)classObject).TFVoters.ToString());
                Parameter.Add("@Tvoters", ((BL_VOTERMASTER)classObject).TVoters.ToString());
                Parameter.Add("@TSHvoters", ((BL_VOTERMASTER)classObject).TSHVoters.ToString());
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

                Query = "update Tbl_VotersMaster set TMvoters=@TMvoters,TFvoters=@TFvoters,Tvoters=@Tvoters,TSHvoters=@TSHvoters where plno=@PLNo and acno=@Acno and psno=@PSNo and subno=@Subno";
                Parameter.Clear();
                Parameter.Add("@TMvoters", ((BL_VOTERMASTER)classObject).TMVoters.ToString());
                Parameter.Add("@TFvoters", ((BL_VOTERMASTER)classObject).TFVoters.ToString());
                Parameter.Add("@Tvoters", ((BL_VOTERMASTER)classObject).TVoters.ToString());
                Parameter.Add("@TSHvoters", ((BL_VOTERMASTER)classObject).TSHVoters.ToString());
                Parameter.Add("@PLNo", ((BL_VOTERMASTER)classObject).PlNo.ToString());
                Parameter.Add("@Acno", ((BL_VOTERMASTER)classObject).AcNo.ToString());
                Parameter.Add("@PSNo", ((BL_VOTERMASTER)classObject).PsNo.ToString());
                Parameter.Add("@Subno", ((BL_VOTERMASTER)classObject).PsSubno.ToString());

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
                Query = "delete from TBL_VOTERSMASTER where plno=@PLNo and acno=@Acno and psno=@PSNo and subno=@Subno;";
                Parameter.Clear();
                Parameter.Add("@PLNo", ((BL_VOTERMASTER)classObject).PlNo.ToString());
                Parameter.Add("@Acno", ((BL_VOTERMASTER)classObject).AcNo.ToString());
                Parameter.Add("@PSNo", ((BL_VOTERMASTER)classObject).PsNo.ToString());
                Parameter.Add("@Subno", ((BL_VOTERMASTER)classObject).PsSubno.ToString());
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

        public int Findmaxidofpsno(string plno, string acno, string psno, string subno)
        {
            Query = "Select maxid from tbl_psmaster where plno=@PLNo and acno=@Acno and psno=@PSNo and  subno=@Subno";
            Parameter.Clear();
            Parameter.Add("@PLNo", plno);
            Parameter.Add("@Acno", acno);
            Parameter.Add("@PSNo", psno);
            Parameter.Add("@Subno", subno);
            return Convert.ToInt32(ExecuteScaler(Parameter, Query));
        }


    }
}
