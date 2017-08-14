using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace BUSSINESS_LAYER
{
    public class BL_POLLINGDETAILS : BL, ICOMMON_CLASS_MASTER
    {
        #region Local Variables
        int _Maxid;
        int _PlNo;
        int _AcNo;
        int _PsNo;
        string _PsSubno;
        int _MaleVoting;
        int _FemaleVoting;
        int _TotalVoting;
        int _EpicVoting;
        int _OtherDocVoting;
        int _PhotoVoting;
        int _TSHVoting;
        string _Column17a;
        int _MockPollAgents;
        int _TenderVoting;
        int _ChallangedVoting;

        string _ComplaintPoll;
        string _ActionPoll;
        string _ComplaintEvm;
        string _ActionEvm;
        string _RemarkARO;
        string _Remark;
        string _After5PMYN;
        int _After5PMVoting;

        int _WithoutAnyIndentityVoting;
        int _THadicapVoting;
        int _HandicapRampVoting;
        int _BrailWOVoting;
        int _BRAILWVoting;
        int _BlindVoting;
        int _RejectUnder49o;
        #endregion

        #region Variable Asseccible From Outside the Class

        public int Maxid { get { return _Maxid; } set { _Maxid = value; } }
        public int PlNo { get { return _PlNo; } set { _PlNo = value; } }
        public int AcNo { get { return _AcNo; } set { _AcNo = value; } }
        public int PsNo { get { return _PsNo; } set { _PsNo = value; } }
        public string PsSubno { get { return _PsSubno; } set { _PsSubno = value; } }
        public int MaleVoting { get { return _MaleVoting; } set { _MaleVoting = value; } }
        public int FemaleVoting { get { return _FemaleVoting; } set { _FemaleVoting = value; } }
        public int TotalVoting { get { return _TotalVoting; } set { _TotalVoting = value; } }
        public int EpicVoting { get { return _EpicVoting; } set { _EpicVoting = value; } }
        public int OtherDocVoting { get { return _OtherDocVoting; } set { _OtherDocVoting = value; } }
        public int PhotoVoting { get { return _PhotoVoting; } set { _PhotoVoting = value; } }
        public int TSHVoting { get { return _TSHVoting; } set { _TSHVoting = value; } }
        public string Column17a { get { return _Column17a; } set { _Column17a = value; } }
        public int MockPollAgents { get { return _MockPollAgents; } set { _MockPollAgents = value; } }
        public int TenderVoting { get { return _TenderVoting; } set { _TenderVoting = value; } }
        public int ChallangedVoting { get { return _ChallangedVoting; } set { _ChallangedVoting = value; } }

        public string ComplaintPoll { get { return _ComplaintPoll; } set { _ComplaintPoll = value; } }
        public string ActionPoll { get { return _ActionPoll; } set { _ActionPoll = value; } }
        public string ComplaintEvm { get { return _ComplaintEvm; } set { _ComplaintEvm = value; } }
        public string ActionEvm { get { return _ActionEvm; } set { _ActionEvm = value; } }
        public string RemarkARO { get { return _RemarkARO; } set { _RemarkARO = value; } }
        public string Remark { get { return _Remark; } set { _Remark = value; } }
        public string After5PMYN { get { return _After5PMYN; } set { _After5PMYN = value; } }
        public int After5PMVoting { get { return _After5PMVoting; } set { _After5PMVoting = value; } }

        public int WithoutAnyIndentityVoting { get { return _WithoutAnyIndentityVoting; } set { _WithoutAnyIndentityVoting = value; } }
        public int THadicapVoting { get { return _THadicapVoting; } set { _THadicapVoting = value; } }
        public int HandicapRampVoting { get { return _HandicapRampVoting; } set { _HandicapRampVoting = value; } }
        public int BrailWOVoting { get { return _BrailWOVoting; } set { _BrailWOVoting = value; } }
        public int BRAILWVoting { get { return _BRAILWVoting; } set { _BRAILWVoting = value; } }
        public int BlindVoting { get { return _BlindVoting; } set { _BlindVoting = value; } }
        public int RejectUnder49o { get { return _RejectUnder49o; } set { _RejectUnder49o = value; } }

        

        #endregion

        #region ICOMMON_CLASS_MASTER Members

        public DataSet SELECT(object classObject)
        {
            DataSet ds = new DataSet();
            Parameter.Clear();
            Parameter.Add("@PLNO", ((BL_POLLINGDETAILS)classObject).PlNo.ToString());
            Parameter.Add("@ACNO", ((BL_POLLINGDETAILS)classObject).AcNo.ToString());
            Query = @"select tbl_psmaster.plno,tbl_psmaster.acno,tbl_psmaster.psno,tbl_psmaster.subno,tbl_psmaster.psengname,tbl_psmaster.psenglocation from tbl_psmaster left Join tbl_pollingdetails
                        on tbl_pollingdetails.plno=tbl_psmaster.plno and tbl_pollingdetails.acno=tbl_psmaster.acno
                        and tbl_pollingdetails.psno=tbl_psmaster.psno and tbl_pollingdetails.subno=tbl_psmaster.subno 
                        where tbl_psmaster.plno=@PLNO and tbl_psmaster.acno=@ACNO and tbl_pollingdetails.plno is null
                        order by tbl_psmaster.plno,tbl_psmaster.acno,tbl_psmaster.psno,tbl_psmaster.subno";

            DataTable dt = ExecuteQuery(Parameter, Query).Tables[0].Copy();
            dt.Columns.Add(new DataColumn("SHOW", typeof(System.String)));
            foreach (DataRow dr in dt.Rows)
                dr["SHOW"] = string.Format(dr["psno"].ToString().PadLeft(4,' ')) + ":" + string.Format(dr["SubNo"].ToString().PadLeft(2,' ').PadRight(3,' ')) + ":" + dr["PSEngNAME"].ToString();
            dt.AcceptChanges();
            dt.TableName = "Not Filled";
            ds.Tables.Add(dt);
            dt = new DataTable();
            Query = @"select tbl_psmaster.plno,tbl_psmaster.acno,tbl_psmaster.psno,tbl_psmaster.subno,tbl_psmaster.psengname,tbl_psmaster.psenglocation from tbl_psmaster inner join tbl_pollingdetails
                        on tbl_pollingdetails.plno=tbl_psmaster.plno and tbl_pollingdetails.acno=tbl_psmaster.acno
                        and tbl_pollingdetails.psno=tbl_psmaster.psno and tbl_pollingdetails.subno=tbl_psmaster.subno 
                        where tbl_psmaster.plno=@PLNO and tbl_psmaster.acno=@ACNO 
                        order by tbl_psmaster.plno,tbl_psmaster.acno,tbl_psmaster.psno,tbl_psmaster.subno";
            dt = ExecuteQuery(Parameter, Query).Tables[0].Copy();
            dt.Columns.Add(new DataColumn("SHOW", typeof(System.String)));
            foreach (DataRow dr in dt.Rows)
                dr["SHOW"] = string.Format(dr["psno"].ToString().PadLeft(4, ' ')) + ":" + string.Format(dr["SubNo"].ToString().PadLeft(2, ' ').PadRight(3, ' ')) + ":" + dr["PSEngNAME"].ToString();
            dt.AcceptChanges();
            dt.TableName = "Filled";
            ds.Tables.Add(dt);


            return ds;
        }

        public DataSet INSERT(object classObject)
        {
            try
            {
                #region  maxid for pollingdetails
                int maxid = 0;
                Query = "select max(maxid) from Tbl_Pollingdetails where plno=@PlNo and acno=@Acno and psno=@PsNo and subno=@subno";
                Parameter.Clear();
                Parameter.Add("@PLNo", ((BL_POLLINGDETAILS)classObject).PlNo.ToString());
                Parameter.Add("@Acno", ((BL_POLLINGDETAILS)classObject).AcNo.ToString());
                Parameter.Add("@PsNo", ((BL_POLLINGDETAILS)classObject).PsNo.ToString());
                Parameter.Add("@SubNo", ((BL_POLLINGDETAILS)classObject).PsSubno.ToString());

                string ds = ExecuteScaler(Parameter, Query);
                //if (ds.Tables.Count >= 1 && ds.Tables[0].Rows.Count >= 1)
                //maxid = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString());
                maxid = Convert.ToInt32(ds.Trim() == "" ? "0" : ds);
                maxid += 1;
                #endregion

                #region insert in polling details
                Query = @"insert into Tbl_PollingDetails values(" + maxid.ToString() + ",@PlNo,@AcNo,@PsNo,@PsSubno,@MaleVoting,@FemaleVoting,@TSHVoting,@TotalVoting,@EpicVoting,@OtherDocVoting,@PhotoVoting,@Column17a,@MockPollAgents,@TenderVoting,'Y',@ChallangedVoting,@ComplaintPoll,@ActionPoll,@ComplaintEvm,@ActionEvm,@RemarkARO,@Remark,@After5PMYN,@After5PMVoting)";
                Parameter.Clear();
                Parameter.Add("@PlNo ", ((BL_POLLINGDETAILS)classObject).PlNo.ToString());
                Parameter.Add("@AcNo ", ((BL_POLLINGDETAILS)classObject).AcNo.ToString());
                Parameter.Add("@PsNo ", ((BL_POLLINGDETAILS)classObject).PsNo.ToString());
                Parameter.Add("@PsSubno ", ((BL_POLLINGDETAILS)classObject).PsSubno.ToString());
                Parameter.Add("@MaleVoting ", ((BL_POLLINGDETAILS)classObject).MaleVoting.ToString());
                Parameter.Add("@FemaleVoting ", ((BL_POLLINGDETAILS)classObject).FemaleVoting.ToString());
                Parameter.Add("@TSHVoting ", ((BL_POLLINGDETAILS)classObject).TSHVoting.ToString());
                Parameter.Add("@TotalVoting ", ((BL_POLLINGDETAILS)classObject).TotalVoting.ToString());
                Parameter.Add("@EpicVoting ", ((BL_POLLINGDETAILS)classObject).EpicVoting.ToString());
                Parameter.Add("@OtherDocVoting ", ((BL_POLLINGDETAILS)classObject).OtherDocVoting.ToString());
                Parameter.Add("@PhotoVoting ", ((BL_POLLINGDETAILS)classObject).PhotoVoting.ToString());

                Parameter.Add("@Column17a ", ((BL_POLLINGDETAILS)classObject).Column17a.ToString());
                Parameter.Add("@MockPollAgents ", ((BL_POLLINGDETAILS)classObject).MockPollAgents.ToString());
                Parameter.Add("@TenderVoting ", ((BL_POLLINGDETAILS)classObject).TenderVoting.ToString());
                Parameter.Add("@ChallangedVoting ", ((BL_POLLINGDETAILS)classObject).ChallangedVoting.ToString());
                Parameter.Add("@ComplaintPoll ", ((BL_POLLINGDETAILS)classObject).ComplaintPoll.ToString());
                Parameter.Add("@ActionPoll ", ((BL_POLLINGDETAILS)classObject).ActionPoll.ToString());
                Parameter.Add("@ComplaintEvm ", ((BL_POLLINGDETAILS)classObject).ComplaintEvm.ToString());
                Parameter.Add("@ActionEvm ", ((BL_POLLINGDETAILS)classObject).ActionEvm.ToString());
                Parameter.Add("@RemarkARO ", ((BL_POLLINGDETAILS)classObject).RemarkARO.ToString());
                Parameter.Add("@Remark ", ((BL_POLLINGDETAILS)classObject).Remark.ToString());
                Parameter.Add("@After5PMYN ", ((BL_POLLINGDETAILS)classObject).After5PMYN.ToString());
                Parameter.Add("@After5PMVoting ", ((BL_POLLINGDETAILS)classObject).After5PMVoting.ToString());

                ExecuteNonQuery(Parameter, Query);
                #endregion

                #region maxid for pollingotherdeatils
                maxid = 0;
                Query = "select max(maxid) from Tbl_PollingOtherdetails where plno=@PlNo and acno=@Acno and psno=@PsNo and subno=@subno";
                Parameter.Clear();
                Parameter.Add("@PLNo", ((BL_POLLINGDETAILS)classObject).PlNo.ToString());
                Parameter.Add("@Acno", ((BL_POLLINGDETAILS)classObject).AcNo.ToString());
                Parameter.Add("@PsNo", ((BL_POLLINGDETAILS)classObject).PsNo.ToString());
                Parameter.Add("@SubNo", ((BL_POLLINGDETAILS)classObject).PsSubno.ToString());

                ds = ExecuteScaler(Parameter, Query);
                //if (ds.Tables.Count >= 1 && ds.Tables[0].Rows.Count >= 1)
                //maxid = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString());
                maxid = Convert.ToInt32(ds.Trim() == "" ? "0" : ds);
                maxid += 1;

                #endregion

                #region inset in polling other details
                Query = @"insert into tbl_pollingOtherdetails values(" + maxid.ToString() + ",@PlNo,@AcNo,@PsNo,@PsSubno,@WithoutAnyIndentityVoting,@HandicapRampVoting,@BRAILWVoting,@BrailWOVoting,@RejectUnder49o,'Y',@THadicapVoting)";
                Parameter.Clear();

                Parameter.Add("@PlNo ", ((BL_POLLINGDETAILS)classObject).PlNo.ToString());
                Parameter.Add("@AcNo ", ((BL_POLLINGDETAILS)classObject).AcNo.ToString());
                Parameter.Add("@PsNo ", ((BL_POLLINGDETAILS)classObject).PsNo.ToString());
                Parameter.Add("@PsSubno ", ((BL_POLLINGDETAILS)classObject).PsSubno.ToString());


                Parameter.Add("@WithoutAnyIndentityVoting ", ((BL_POLLINGDETAILS)classObject).WithoutAnyIndentityVoting.ToString());
                Parameter.Add("@HandicapRampVoting ", ((BL_POLLINGDETAILS)classObject).HandicapRampVoting.ToString());
                Parameter.Add("@BRAILWVoting ", ((BL_POLLINGDETAILS)classObject).BRAILWVoting.ToString());
                Parameter.Add("@BrailWOVoting ", ((BL_POLLINGDETAILS)classObject).BrailWOVoting.ToString());
                Parameter.Add("@RejectUnder49o", ((BL_POLLINGDETAILS)classObject).RejectUnder49o.ToString());
                Parameter.Add("@THadicapVoting ", ((BL_POLLINGDETAILS)classObject).THadicapVoting.ToString());
                
                ExecuteNonQuery(Parameter, Query);
                #endregion

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {

            }
            return SELECT(classObject);
        }
        public DataSet UPDATE(object classObject)
        {
            try
            {
                # region Update Polling Detils
                Query = @"update Tbl_PollingDetails set TMVoting=@MaleVoting,TFVoting=@FemaleVoting,TSHVoting=@TSHVoting,TVoting=@TotalVoting,EpicVoting=@EpicVoting,OtherVoting=@OtherDocVoting,PMVoting=@PhotoVoting,F17a=@Column17a,MocPoll=@MockPollAgents,CHVoting=@TenderVoting,Flag='Y',ChallVoter=@ChallangedVoting,CpollProcess=@ComplaintPoll,ActionPoll=@ActionPoll,Evmrc=@ComplaintEvm,ActionEvm=@ActionEvm,Remarksaro=@RemarkARO,remarks=@Remark,After5PM=@After5PMYN,After5PMCount=@After5PMVoting where plno=@PlNo and acno=@AcNo and psno=@PsNo and subno=@PsSubno";
                Parameter.Clear();
                Parameter.Add("@MaleVoting ", ((BL_POLLINGDETAILS)classObject).MaleVoting.ToString());
                Parameter.Add("@FemaleVoting ", ((BL_POLLINGDETAILS)classObject).FemaleVoting.ToString());
                Parameter.Add("@TSHVoting ", ((BL_POLLINGDETAILS)classObject).TSHVoting.ToString());
                Parameter.Add("@TotalVoting ", ((BL_POLLINGDETAILS)classObject).TotalVoting.ToString());
                Parameter.Add("@EpicVoting ", ((BL_POLLINGDETAILS)classObject).EpicVoting.ToString());
                Parameter.Add("@OtherDocVoting ", ((BL_POLLINGDETAILS)classObject).OtherDocVoting.ToString());
                Parameter.Add("@PhotoVoting ", ((BL_POLLINGDETAILS)classObject).PhotoVoting.ToString());

                Parameter.Add("@Column17a ", ((BL_POLLINGDETAILS)classObject).Column17a.ToString());
                Parameter.Add("@MockPollAgents ", ((BL_POLLINGDETAILS)classObject).MockPollAgents.ToString());
                Parameter.Add("@TenderVoting ", ((BL_POLLINGDETAILS)classObject).TenderVoting.ToString());
                Parameter.Add("@ChallangedVoting ", ((BL_POLLINGDETAILS)classObject).ChallangedVoting.ToString());
                Parameter.Add("@ComplaintPoll ", ((BL_POLLINGDETAILS)classObject).ComplaintPoll.ToString());
                Parameter.Add("@ActionPoll ", ((BL_POLLINGDETAILS)classObject).ActionPoll.ToString());
                Parameter.Add("@ComplaintEvm ", ((BL_POLLINGDETAILS)classObject).ComplaintEvm.ToString());
                Parameter.Add("@ActionEvm ", ((BL_POLLINGDETAILS)classObject).ActionEvm.ToString());
                Parameter.Add("@RemarkARO ", ((BL_POLLINGDETAILS)classObject).RemarkARO.ToString());
                Parameter.Add("@Remark ", ((BL_POLLINGDETAILS)classObject).Remark.ToString());
                Parameter.Add("@After5PMYN ", ((BL_POLLINGDETAILS)classObject).After5PMYN.ToString());
                Parameter.Add("@After5PMVoting ", ((BL_POLLINGDETAILS)classObject).After5PMVoting.ToString());

                Parameter.Add("@PlNo ", ((BL_POLLINGDETAILS)classObject).PlNo.ToString());
                Parameter.Add("@AcNo ", ((BL_POLLINGDETAILS)classObject).AcNo.ToString());
                Parameter.Add("@PsNo ", ((BL_POLLINGDETAILS)classObject).PsNo.ToString());
                Parameter.Add("@PsSubno ", ((BL_POLLINGDETAILS)classObject).PsSubno.ToString());


                ExecuteNonQuery(Parameter, Query);

                # endregion

                # region Update Polling Other Details
                Query = @"update tbl_pollingOtherdetails set WithoutanyDoc=@WithoutAnyIndentityVoting,Rampvoting=@HandicapRampVoting,BellDempWith=@BRAILWVoting,BellDempWithOutAsst=@BrailWOVoting,RejectUnder49o=@RejectUnder49o,flag='Y',TotalHandi=@THadicapVoting where plno=@PlNo and acno=@AcNo and psno=@PsNo and subno=@PsSubno";


                Parameter.Clear();
                Parameter.Add("@WithoutAnyIndentityVoting ", ((BL_POLLINGDETAILS)classObject).WithoutAnyIndentityVoting.ToString());
                Parameter.Add("@HandicapRampVoting ", ((BL_POLLINGDETAILS)classObject).HandicapRampVoting.ToString());
                Parameter.Add("@BRAILWVoting ", ((BL_POLLINGDETAILS)classObject).BRAILWVoting.ToString());
                Parameter.Add("@BrailWOVoting ", ((BL_POLLINGDETAILS)classObject).BrailWOVoting.ToString());
                Parameter.Add("@RejectUnder49o", ((BL_POLLINGDETAILS)classObject).RejectUnder49o.ToString());
                Parameter.Add("@THadicapVoting ", ((BL_POLLINGDETAILS)classObject).THadicapVoting.ToString());

                Parameter.Add("@PlNo ", ((BL_POLLINGDETAILS)classObject).PlNo.ToString());
                Parameter.Add("@AcNo ", ((BL_POLLINGDETAILS)classObject).AcNo.ToString());
                Parameter.Add("@PsNo ", ((BL_POLLINGDETAILS)classObject).PsNo.ToString());
                Parameter.Add("@PsSubno ", ((BL_POLLINGDETAILS)classObject).PsSubno.ToString());


                ExecuteNonQuery(Parameter, Query);

                # endregion

            }
            catch (Exception ex) { throw ex; }
            finally
            {

            }
            return SELECT(classObject);
        }

        public DataSet DELETE(object classObject)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public void Fill_ListView(ListView Lvw, DataTable Dt)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        #endregion


        public DataSet SelectVoterDetails(object classObject, ref bool HasValue)
        {
            DataSet ds = new DataSet();
            Query = "Select * from Tbl_VotersMaster where plno=@PLNO and acno=@ACNO and psno=@PSNO and Subno=@SUBNO";
            Parameter.Clear();
            Parameter.Add("@PLNO", ((BL_POLLINGDETAILS)classObject).PlNo.ToString());
            Parameter.Add("@ACNO", ((BL_POLLINGDETAILS)classObject).AcNo.ToString());
            Parameter.Add("@PSNO", ((BL_POLLINGDETAILS)classObject).PsNo.ToString());
            Parameter.Add("@SUBNO", ((BL_POLLINGDETAILS)classObject).PsSubno.ToString());
            ds = ExecuteQuery(Parameter, Query);
            if (ds.Tables.Count > 0)
                if (ds.Tables[0].Rows.Count > 0)
                {
                    HasValue = true;
                    return ds;
                }
                else
                {
                    HasValue = false;
                    return ds;
                }
            else
            {
                HasValue = false;
                return ds;
            }
        }

        public BL_POLLINGDETAILS FILLRECORD(object classObject)
        {
            BL_POLLINGDETAILS bl_Obj = new BL_POLLINGDETAILS();
            DataSet ds = new DataSet();
            Parameter.Clear();
            Parameter.Add("@PLNO", ((BL_POLLINGDETAILS)classObject).PlNo.ToString());
            Parameter.Add("@ACNO", ((BL_POLLINGDETAILS)classObject).AcNo.ToString());
            Parameter.Add("@PSNO", ((BL_POLLINGDETAILS)classObject).PsNo.ToString());
            Parameter.Add("@SUBNO", ((BL_POLLINGDETAILS)classObject).PsSubno.ToString());
            Query = @"Select * from Tbl_PollingDetails where plno=@PLNO and acno=@ACNO and psno=@PSNO and subno=@SUBNO";

            DataTable dt = ExecuteQuery(Parameter, Query).Tables[0].Copy();

            dt.TableName = "PollingDetails";
            ds.Tables.Add(dt);

            bl_Obj.MaleVoting = Convert.ToInt32(dt.Rows[0]["TMVoting"].ToString());
            bl_Obj.FemaleVoting = Convert.ToInt32(dt.Rows[0]["TFVoting"].ToString());
            bl_Obj.TotalVoting = Convert.ToInt32(dt.Rows[0]["TVoting"].ToString());
            bl_Obj.EpicVoting = Convert.ToInt32(dt.Rows[0]["EpicVoting"].ToString());
            bl_Obj.OtherDocVoting = Convert.ToInt32(dt.Rows[0]["OtherVoting"].ToString());
            bl_Obj.PhotoVoting = Convert.ToInt32(dt.Rows[0]["PMVoting"].ToString());
            bl_Obj.TSHVoting = Convert.ToInt32(dt.Rows[0]["TSHVoting"].ToString());
            bl_Obj.Column17a = dt.Rows[0]["F17a"].ToString();
            bl_Obj.MockPollAgents = Convert.ToInt32(dt.Rows[0]["MocPoll"].ToString());
            bl_Obj.TenderVoting = Convert.ToInt32(dt.Rows[0]["CHVoting"].ToString());
            bl_Obj.ChallangedVoting = Convert.ToInt32(dt.Rows[0]["ChallVoter"].ToString());
            bl_Obj.ComplaintPoll = dt.Rows[0]["CpollProcess"].ToString();
            bl_Obj.ActionPoll = dt.Rows[0]["ActionPoll"].ToString();
            bl_Obj.ComplaintEvm = dt.Rows[0]["Evmrc"].ToString();
            bl_Obj.ActionEvm = dt.Rows[0]["ActionEvm"].ToString();
            bl_Obj.RemarkARO = dt.Rows[0]["Remarksaro"].ToString();
            bl_Obj.Remark = dt.Rows[0]["remarks"].ToString();
            bl_Obj.After5PMYN = dt.Rows[0]["After5PM"].ToString();
            bl_Obj.After5PMVoting = Convert.ToInt32(dt.Rows[0]["After5PMCount"].ToString());

            dt = new DataTable();
            Parameter.Clear();
            Parameter.Add("@PLNO", ((BL_POLLINGDETAILS)classObject).PlNo.ToString());
            Parameter.Add("@ACNO", ((BL_POLLINGDETAILS)classObject).AcNo.ToString());
            Parameter.Add("@PSNO", ((BL_POLLINGDETAILS)classObject).PsNo.ToString());
            Parameter.Add("@SUBNO", ((BL_POLLINGDETAILS)classObject).PsSubno.ToString());
            Query = @"Select * from Tbl_PollingOtherDetails where plno=@PLNO and acno=@ACNO and psno=@PSNO and subno=@SUBNO";

            dt = ExecuteQuery(Parameter, Query).Tables[0].Copy();

            dt.TableName = "PollingOtherDetails";
            ds.Tables.Add(dt);

            if (dt.Rows.Count > 0)
            {
                bl_Obj.WithoutAnyIndentityVoting = Convert.ToInt32(dt.Rows[0]["WithoutanyDoc"].ToString());
                bl_Obj.THadicapVoting = Convert.ToInt32(dt.Rows[0]["TotalHandi"].ToString());
                bl_Obj.HandicapRampVoting = Convert.ToInt32(dt.Rows[0]["Rampvoting"].ToString());
                bl_Obj.BrailWOVoting = Convert.ToInt32(dt.Rows[0]["BellDempWithOutAsst"].ToString());
                bl_Obj.BRAILWVoting = Convert.ToInt32(dt.Rows[0]["BellDempWith"].ToString());
                bl_Obj.RejectUnder49o = Convert.ToInt32(dt.Rows[0]["RejectUnder49o"].ToString());
            }
            else
            {
                bl_Obj.WithoutAnyIndentityVoting = 0;
                bl_Obj.THadicapVoting = 0;
                bl_Obj.HandicapRampVoting = 0;
                bl_Obj.BrailWOVoting = 0;
                bl_Obj.BRAILWVoting = 0;
                bl_Obj.RejectUnder49o = 0;
            }

            return bl_Obj;
        }
    }
}
