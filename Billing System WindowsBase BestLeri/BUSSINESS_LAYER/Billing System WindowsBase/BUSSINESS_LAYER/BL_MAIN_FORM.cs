using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
namespace BUSSINESS_LAYER
{
    public class BL_MAIN_FORM : BL, ICOMMON_CLASS_MASTER
    {

        #region Local Variables

        int _CARDHOLDER_ID;
        int _STATE_ID;
        int _DISTRICT_ID;
        int _TALUKA_ID;
        int _VILLAGE_ID;
        int _SHOP_ID;

        #endregion

        #region Variable Asseccible From Outside the Class

        public int CARDHOLDER_ID { get { return _CARDHOLDER_ID; } set { _CARDHOLDER_ID = value; } }
        public int STATE_ID { get { return _STATE_ID; } set { _STATE_ID = value; } }
        public int DISTRICT_ID { get { return _DISTRICT_ID; } set { _DISTRICT_ID = value; } }
        public int TALUKA_ID { get { return _TALUKA_ID; } set { _TALUKA_ID = value; } }
        public int VILLAGE_ID { get { return _VILLAGE_ID; } set { _VILLAGE_ID = value; } }
        public int SHOP_ID { get { return _SHOP_ID; } set { _SHOP_ID = value; } }

        #endregion

        #region ICOMMON_CLASS_MASTER Members

        public DataSet SELECT(object classObject)
        {

            DataSet ds = new DataSet();

            DataTable dt = ExecuteQuery("SELECT * FROM VW_CARD_COUNTS;").Tables[0].Copy();
            dt.TableName = "CARD_COUNTS";
            ds.Tables.Add(dt);

            dt = ExecuteQuery("SELECT * FROM TOTALS;").Tables[0].Copy();
            dt.TableName = "TOTAL_CARD_COUNTS";
            ds.Tables.Add(dt);

            Parameter.Clear();
            Parameter.Add("@State_id", ((BL_MAIN_FORM)classObject).STATE_ID.ToString());
            Parameter.Add("@District_id", ((BL_MAIN_FORM)classObject).DISTRICT_ID.ToString());
            Parameter.Add("@Taluka_id", ((BL_MAIN_FORM)classObject).TALUKA_ID.ToString());
            Parameter.Add("@Village_id", ((BL_MAIN_FORM)classObject).VILLAGE_ID.ToString());
            Parameter.Add("@Shop_id", ((BL_MAIN_FORM)classObject).SHOP_ID.ToString());
            Query = @"SELECT Cardholder_id, State_id, District_id, Taluka_id, Village_id, Shop_id, Card_Reference_Number, E_Salutation, E_Fname, E_Mname, E_Lname,M_Salutation, M_Fname, M_Mname, M_Lname
                      FROM Tbl_CardholderMaster
                      where State_id=@State_id and District_id=@District_id and Taluka_id=@Taluka_id and Village_id=@Village_id and  Shop_id=@Shop_id and ISVERIFY='1'
                      order by State_id, District_id, Taluka_id, Village_id, Shop_id,Cardholder_id
                      ";

            dt = ExecuteQuery(Parameter, Query).Tables[0].Copy();
            DataColumn dc = new DataColumn("M_SHOW", typeof(System.String));
            dt.Columns.Add(dc);
            dc.SetOrdinal(1);
            dc = new DataColumn("SHOW", typeof(System.String));
            dt.Columns.Add(dc);
            dc.SetOrdinal(2);

            //dt.Columns.Add(new DataColumn("SHOW", typeof(System.String)));
            foreach (DataRow dr in dt.Rows)
            {
                dr["M_SHOW"] = dr["M_Salutation"].ToString() + " " + dr["M_Fname"].ToString() + " " + dr["M_Mname"].ToString() + " " + dr["M_Lname"].ToString();
                dr["SHOW"] = dr["E_Salutation"].ToString() + " " + dr["E_Fname"].ToString() + " " + dr["E_Mname"].ToString() + " " + dr["E_Lname"].ToString();
            }
            dt.AcceptChanges();
            dt.TableName = "VERIFY Cards";
            ds.Tables.Add(dt);


            Parameter.Clear();
            Parameter.Add("@State_id", ((BL_MAIN_FORM)classObject).STATE_ID.ToString());
            Parameter.Add("@District_id", ((BL_MAIN_FORM)classObject).DISTRICT_ID.ToString());
            Parameter.Add("@Taluka_id", ((BL_MAIN_FORM)classObject).TALUKA_ID.ToString());
            Parameter.Add("@Village_id", ((BL_MAIN_FORM)classObject).VILLAGE_ID.ToString());
            Parameter.Add("@Shop_id", ((BL_MAIN_FORM)classObject).SHOP_ID.ToString());
            Query = @"SELECT Cardholder_id, State_id, District_id, Taluka_id, Village_id, Shop_id, Card_Reference_Number, E_Salutation, E_Fname, E_Mname, E_Lname,M_Salutation, M_Fname, M_Mname, M_Lname
                      FROM Tbl_CardholderMaster
                      where State_id=@State_id and District_id=@District_id and Taluka_id=@Taluka_id and Village_id=@Village_id and  Shop_id=@Shop_id and ISVERIFY='0'
                      order by State_id, District_id, Taluka_id, Village_id, Shop_id,Cardholder_id desc
                      ";

            dt = ExecuteQuery(Parameter, Query).Tables[0].Copy();
            dc = new DataColumn("M_SHOW", typeof(System.String));
            dt.Columns.Add(dc);
            dc.SetOrdinal(1);
            dc = new DataColumn("SHOW", typeof(System.String));
            dt.Columns.Add(dc);
            dc.SetOrdinal(2);

            //dt.Columns.Add(new DataColumn("SHOW", typeof(System.String)));
            foreach (DataRow dr in dt.Rows)
            {
                dr["M_SHOW"] = dr["M_Salutation"].ToString() + " " + dr["M_Fname"].ToString() + " " + dr["M_Mname"].ToString() + " " + dr["M_Lname"].ToString();
                dr["SHOW"] = dr["E_Salutation"].ToString() + " " + dr["E_Fname"].ToString() + " " + dr["E_Mname"].ToString() + " " + dr["E_Lname"].ToString();
            }
            dt.AcceptChanges();
            dt.TableName = "NOT VERIFY Cards";
            ds.Tables.Add(dt);

            return ds;
        }

        public DataSet INSERT(object classObject)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public DataSet UPDATE(object classObject)
        {
            throw new Exception("The method or operation is not implemented.");
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

        public bool CheckViewExists()
        {
            DataSet ds = new DataSet();
            bool ret=false;
            try
            {
                DataTable dt = ExecuteQuery("SELECT * FROM VW_CARD_COUNTS;").Tables[0].Copy();
                dt.TableName = "CARD_COUNTS";
                ds.Tables.Add(dt);
                ret = true;
            }
            catch (Exception ex)
            {
                ret = false;
                BL_Error_Log.WriteLog(ex);
            }
            return ret;

        }

    }
}
