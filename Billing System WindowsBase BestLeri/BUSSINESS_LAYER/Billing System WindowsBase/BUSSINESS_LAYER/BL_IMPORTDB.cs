using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace BUSSINESS_LAYER
{
    public class BL_IMPORTDB : BL, ICOMMON_CLASS_MASTER
    {
        public _Server_ID Server_ID;
        public _Local_ID LOCAL_ID;
        public BL_IMPORTDB()
        {
            Server_ID = new _Server_ID();
            LOCAL_ID = new _Local_ID();
        }
        // int _CardMemeber_id, _Cardholder_id, _State_id, _District_id, _Taluka_id, _Village_id, _Shop_id, _CardType_id,
        // _Total_Unit, _Total_person, _Bank_id, _Card_Unique_Number, _Gas_Qty,
        // _Machine_Unique_Number, _Age;
        // string _E_Salutation, _E_M_Fname, _E_M_Mname, _E_M_Lname, _M_Salutation, _M_M_Fname, _M_M_Mname, _M_M_Lname
        //, _Finger, _Member_Flag, _Isregiser, _Card_Reference_Number, _Adhar_Number, _Ration_Card_Number,
        // _Bank_Account_Number, _Pretxt,Createdon,Createdby,Updatedon,Updatedby,IsActive;
        // char _Isgas, _Gender;


        // public int CardMemeber_id { get { return _CardMemeber_id; } set { _CardMemeber_id = value; } }
        // public int Cardholder_id { get { return _Cardholder_id; } set { _Cardholder_id = value; } }
        // public int State_id { get { return _State_id; } set { _State_id = value; } }
        // public int District_id { get { return _District_id; } set { _District_id = value; } }
        // public int Taluka_id { get { return _Taluka_id; } set { _Taluka_id = value; } }
        // public int Village_id { get { return _Village_id; } set { _Village_id = value; } }
        // public int Shop_id { get { return _Shop_id; } set { _Shop_id = value; } }
        // public int CardType_id { get { return _CardType_id; } set { _CardType_id = value; } }
        // public string Card_Reference_Number { get { return _Card_Reference_Number; } set { _Card_Reference_Number = value; } }
        // public int Total_Unit { get { return _Total_Unit; } set { _Total_Unit = value; } }
        // public int Total_person { get { return _Total_person; } set { _Total_person = value; } }
        // public string Ration_Card_Number { get { return _Ration_Card_Number; } set { _Ration_Card_Number = value; } }
        // public int Bank_id { get { return _Bank_id; } set { _Bank_id = value; } }
        // public string Bank_Account_Number { get { return _Bank_Account_Number; } set { _Bank_Account_Number = value; } }
        // public int Card_Unique_Number { get { return _Card_Unique_Number; } set { _Card_Unique_Number = value; } }
        // public int Machine_Unique_Number { get { return _Machine_Unique_Number; } set { _Machine_Unique_Number = value; } }
        // public string Adhar_Number { get { return _Adhar_Number; } set { _Adhar_Number = value; } }
        // public int Age { get { return _Age; } set { _Age = value; } }
        // public int Gas_Qty { get { return _Gas_Qty; } set { _Gas_Qty = value; } }



        // public string E_Salutation { get { return _E_Salutation; } set { _E_Salutation = value; } }
        // public string E_M_Lname { get { return _E_M_Lname; } set { _E_M_Lname = value; } }
        // public string E_M_Fname { get { return _E_M_Fname; } set { _E_M_Fname = value; } }
        // public string E_M_Mname { get { return _E_M_Mname; } set { _E_M_Mname = value; } }

        // public string M_Salutation { get { return _M_Salutation; } set { _M_Salutation = value; } }
        // public string M_M_Lname { get { return _M_M_Lname; } set { _M_M_Lname = value; } }
        // public string M_M_Mname { get { return _M_M_Mname; } set { _M_M_Mname = value; } }
        // public string M_M_Fname { get { return _M_M_Fname; } set { _M_M_Fname = value; } }

        // public string Finger { get { return _Finger; } set { _Finger = value; } }
        // public string Member_Flag { get { return _Member_Flag; } set { _Member_Flag = value; } }
        // public string Isregiser { get { return _Isregiser; } set { _Isregiser = value; } }

        // public char Isgas { get { return _Isgas; } set { _Isgas = value; } }
        // public char Gender { get { return _Gender; } set { _Gender = value; } }

        // public string Pretxt { get { return _Pretxt; } set { _Pretxt = value; } }

        // public string  Createdon { get { return _Createdon; } set { _Createdon = value; } }
        // public string  Createdby { get { return _Createdby; } set { _Createdby = value; } }
        // public string  Updatedon { get { return _Updatedon; } set { _Updatedon = value; } }
        // public string  Updatedby { get { return _Updatedby; } set { _Updatedby = value; } }
        // public string  IsActive { get { return _IsActive; } set { _IsActive = value; } }

        DataTable _CardHolderMaster;
        DataTable _CardHolderWiseMember;
        string _path;
        public DataTable CardHolderMaster { get { return _CardHolderMaster; } set { _CardHolderMaster = value; } }
        public DataTable CardHolderWiseMember { get { return _CardHolderWiseMember; } set { _CardHolderWiseMember = value; } }
        public string Path { get { return _path; } set { _path = value; } }

        public class _Server_ID
        {
            int _district_id;
            int _taluka_id;
            int _village_id;
            int _shop_id;

            int _district_name;
            int _taluka_name;
            int _village_name;
            int _shop_name;

            public int District_id { get { return _district_id; } set { _district_id = value; } }
            public int Taluka_id { get { return _taluka_id; } set { _taluka_id = value; } }
            public int Village_id { get { return _village_id; } set { _village_id = value; } }
            public int Shop_id { get { return _shop_id; } set { _shop_id = value; } }

            public int District_Name { get { return _district_name; } set { _district_name = value; } }
            public int Taluka_Name { get { return _taluka_name; } set { _taluka_name = value; } }
            public int Village_Name { get { return _village_name; } set { _village_name = value; } }
            public int Shop_Name { get { return _shop_name; } set { _shop_name = value; } }

        }

        public class _Local_ID
        {
            int _district_id;
            int _taluka_id;
            int _village_id;
            int _shop_id;

            int _district_name;
            int _taluka_name;
            int _village_name;
            int _shop_name;

            public int District_id { get { return _district_id; } set { _district_id = value; } }
            public int Taluka_id { get { return _taluka_id; } set { _taluka_id = value; } }
            public int Village_id { get { return _village_id; } set { _village_id = value; } }
            public int Shop_id { get { return _shop_id; } set { _shop_id = value; } }

            public int District_Name { get { return _district_name; } set { _district_name = value; } }
            public int Taluka_Name { get { return _taluka_name; } set { _taluka_name = value; } }
            public int Village_Name { get { return _village_name; } set { _village_name = value; } }
            public int Shop_Name { get { return _shop_name; } set { _shop_name = value; } }

        }


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
            DataSet r_ds = new DataSet();
            try
            {
                #region
                ////    blFill_Para_Name(
                //    //Card holder table 
                //    Query = "insert into Tbl_CardholderMaster values(@Cardholder_id, @State_id,@District_id,  @Taluka_id, @Village_id, @Shop_id, @CardType_id, @Card_Reference_Number, @Gender, @E_Salutation,@E_Fname, @E_Mname, @E_Lname, @M_Salutation, @M_Fname, @M_Mname, @M_Lname, @Total_Unit, @Total_Person, @Ration_Card_Number, @Bank_id, @Bank_Account_Number, @Card_Unique_Number, @Isgas, @Gas_Qty, @Createdon, @Createdby, @Updatedon, @Updatedby, @IsActive)";
                //    Parameter.Clear();
                //    Parameter.Add("@Cardholder_id", ((BL_ACMASTER)classObject).Cardholder_id.ToString());
                //    Parameter.Add("@State_id", ((BL_ACMASTER)classObject).State_id.ToString());
                //    Parameter.Add("@District_id", ((BL_ACMASTER)classObject).District_id.ToString());
                //    Parameter.Add("@Taluka_id", ((BL_ACMASTER)classObject).Taluka_id.ToString());
                //    Parameter.Add("@Village_id", ((BL_ACMASTER)classObject).Village_id.ToString());

                //    Parameter.Add("@Shop_id", ((BL_ACMASTER)classObject).Shop_id.ToString());
                //    Parameter.Add("@CardType_id", ((BL_ACMASTER)classObject).CardType_id.ToString());
                //    Parameter.Add("@Card_Reference_Number", ((BL_ACMASTER)classObject).Card_Reference_Number.ToString());
                //    Parameter.Add("@Gender", ((BL_ACMASTER)classObject).Gender.ToString());

                //    Parameter.Add("@E_Salutation", ((BL_ACMASTER)classObject).E_Salutation.ToString());
                //    Parameter.Add("@E_Fname", ((BL_ACMASTER)classObject).E_Fname.ToString());
                //    Parameter.Add("@E_Mname", ((BL_ACMASTER)classObject).E_Mname.ToString());
                //    Parameter.Add("@E_Lname", ((BL_ACMASTER)classObject).E_Lname.ToString());

                //    Parameter.Add("@M_Salutation", ((BL_ACMASTER)classObject).M_Salutation.ToString());
                //    Parameter.Add("@M_Fname", ((BL_ACMASTER)classObject).M_Fname.ToString());
                //    Parameter.Add("@M_Mname", ((BL_ACMASTER)classObject).M_Mname.ToString());
                //    Parameter.Add("@M_Lname", ((BL_ACMASTER)classObject).M_Lname.ToString());

                //    Parameter.Add("@Total_Unit", ((BL_ACMASTER)classObject).Total_Unit.ToString());
                //    Parameter.Add("@Total_Person", ((BL_ACMASTER)classObject).Total_Person.ToString());
                //    Parameter.Add("@Ration_Card_Number", ((BL_ACMASTER)classObject).Ration_Card_Number.ToString());
                //    Parameter.Add("@Bank_id", ((BL_ACMASTER)classObject).Bank_id.ToString());

                //    Parameter.Add("@Bank_Account_Number", ((BL_ACMASTER)classObject).Bank_Account_Number.ToString());
                //    Parameter.Add("@Card_Unique_Number", ((BL_ACMASTER)classObject).Card_Unique_Number.ToString());
                //    Parameter.Add("@Isgas", ((BL_ACMASTER)classObject).Isgas.ToString());
                //    Parameter.Add("@Gas_Qty", ((BL_ACMASTER)classObject).Gas_Qty.ToString());

                //    Parameter.Add("@Createdon", ((BL_ACMASTER)classObject).Createdon.ToString());
                //    Parameter.Add("@Createdby", ((BL_ACMASTER)classObject).Createdby.ToString());
                //    Parameter.Add("@Updatedon", ((BL_ACMASTER)classObject).Updatedon.ToString());
                //    Parameter.Add("@Updatedby", ((BL_ACMASTER)classObject).Updatedby.ToString());
                //    Parameter.Add("@IsActive", ((BL_ACMASTER)classObject).IsActive.ToString());

                //    StringBuilder x = new StringBuilder("");
                //    x.Append(Fill_CardHolder.Instance.Cardholder_Details.DataSet.GetXml());


                //    ParaNameValue.Add("@Menudata", x.ToString());
                //    //ParaNameValue.Add("@Group_Menu_id", ("");  
                //    //ParaNameValue.Add("@Menu_id", ((MENU_MASTER)classObject).Menu_Url.ToString());
                //    ParaNameValue.Add("@flag", "A");
                //    DataSet ds = EXECUTE_PROCEDURE(ParaNameValue, "Sp_Menu_Permission");
                //    Fill_Menu_Grid.Instance.Menu_Details.Clear();
                //    ds.Tables.Clear();

                //    return ds;



                //    ExecuteNonQuery(Parameter, Query);

                //    Query = "insert into Tbl_CardholderwiseMember values(@Cardmember_id, @Cardholder_id, @State_id, @District_id, @Taluka_id, @2Village_id, @Shop_id, @Machine_Unique_Number, @Gender, @E_Salutation, @E_M_Fname, @2E_M_Mname, @E_M_Lname, @M_Salutation, @M_M_Fname,@M_M_Mname, @M_M_Lname, @Finger, @Member_Flag, @Isregister, @Card_Unique_Number, @Adhar_Number, @Age, @LImage, @RImage, @Createdon, @Createdby, @Updatedon, @2Updatedby, @IsActive)";
                //    Parameter.Clear();
                //    Parameter.Add("@Cardmember_id", ((BL_ACMASTER)classObject).Cardmember_id.ToString());
                //    Parameter.Add("@Cardholder_id", ((BL_ACMASTER)classObject).Cardholder_id.ToString());
                //    Parameter.Add("@State_id", ((BL_ACMASTER)classObject).State_id.ToString());
                //    Parameter.Add("@District_id", ((BL_ACMASTER)classObject).District_id.ToString());
                //    Parameter.Add("@Taluka_id", ((BL_ACMASTER)classObject).Taluka_id.ToString());
                //    Parameter.Add("@Village_id", ((BL_ACMASTER)classObject).Village_id.ToString());

                //    Parameter.Add("@Shop_id", ((BL_ACMASTER)classObject).Shop_id.ToString());

                //    Parameter.Add("@Machine_Unique_Number", ((BL_ACMASTER)classObject).Machine_Unique_Number.ToString());
                //    Parameter.Add("@Gender", ((BL_ACMASTER)classObject).Gender.ToString());

                //    Parameter.Add("@E_Salutation", ((BL_ACMASTER)classObject).E_Salutation.ToString());
                //    Parameter.Add("@E_M_Fname", ((BL_ACMASTER)classObject).E_M_Fname.ToString());
                //    Parameter.Add("@E_M_Mname", ((BL_ACMASTER)classObject).E_M_Mname.ToString());
                //    Parameter.Add("@E_M_Lname", ((BL_ACMASTER)classObject).E_M_Lname.ToString());

                //    Parameter.Add("@M_Salutation", ((BL_ACMASTER)classObject).M_Salutation.ToString());
                //    Parameter.Add("@M_M_Fname", ((BL_ACMASTER)classObject).M_M_Fname.ToString());
                //    Parameter.Add("@M_M_Mname", ((BL_ACMASTER)classObject).M_M_Mname.ToString());
                //    Parameter.Add("@M_M_Lname", ((BL_ACMASTER)classObject).M_M_Lname.ToString());

                //    Parameter.Add("@Finger", ((BL_ACMASTER)classObject).Finger.ToString());
                //    Parameter.Add("@Member_Flag", ((BL_ACMASTER)classObject).Member_Flag.ToString());
                //    Parameter.Add("@Isregister", ((BL_ACMASTER)classObject).Isregister.ToString());
                //    Parameter.Add("@Card_Unique_Number", ((BL_ACMASTER)classObject).Card_Unique_Number.ToString());

                //    Parameter.Add("@Adhar_Number", ((BL_ACMASTER)classObject).Bank_Account_Number.ToString());
                //    Parameter.Add("@Age", ((BL_ACMASTER)classObject).Age.ToString());
                //    Parameter.Add("@LImage", ((BL_ACMASTER)classObject).LImage.ToString());
                //    Parameter.Add("@RImage", ((BL_ACMASTER)classObject).RImage.ToString());

                //    Parameter.Add("@Createdon", ((BL_ACMASTER)classObject).Createdon.ToString());
                //    Parameter.Add("@Createdby", ((BL_ACMASTER)classObject).Createdby.ToString());
                //    Parameter.Add("@Updatedon", ((BL_ACMASTER)classObject).Updatedon.ToString());
                //    Parameter.Add("@Updatedby", ((BL_ACMASTER)classObject).Updatedby.ToString());
                //    Parameter.Add("@IsActive", ((BL_ACMASTER)classObject).IsActive.ToString());
                #endregion

                //DataSet ds = new DataSet("CARDDETAILS");
                //DataTable dt = ((BL_IMPORTDB)classObject).CardHolderMaster;
                //DataTable dt1 = ((BL_IMPORTDB)classObject).CardHolderWiseMember;
                //ds.Tables.Add(dt.Copy());


                //StringBuilder x = new StringBuilder("");
                //Parameter.Clear();
                //Parameter.Add("@CardHolderMAster", x.Append(ds.Tables[0].DataSet.GetXml()).ToString());

                //ds = new DataSet("CARDDETAILS");
                //ds.Tables.Add(dt1.Copy());
                //StringBuilder x1 = new StringBuilder("");
                //x1.Append(ds.GetXml());
                //Parameter.Add("@CardHolderWiseMember", x1.Append(ds.Tables[0].DataSet.GetXml()).ToString());

                Parameter.Clear();
                Parameter.Add("@Path", ((BL_IMPORTDB)classObject).Path);
                r_ds = blFill_Para_Name(Parameter, "SP_FORDATAENTRY_Fill_MASTER_MEMBER");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return r_ds;
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

        public DataSet OpenDB(string Path)
        {
            OleDbConnection Con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Path);
            try
            {
                Con.Open();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            try
            {
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                OleDbCommand cmd = new OleDbCommand("Select * from Tbl_CardholderMaster;", Con);
                OleDbDataAdapter adp = new OleDbDataAdapter(cmd);
                adp.Fill(dt);
                dt.TableName = "MASTER";
                ds.Tables.Add(dt);
                dt = new DataTable();
                cmd = new OleDbCommand("Select * from Tbl_CardholderwiseMember;", Con);
                adp = new OleDbDataAdapter(cmd);
                adp.Fill(dt);
                dt.TableName = "MEMBER";
                ds.Tables.Add(dt);

                dt = new DataTable();
                cmd = new OleDbCommand(@"SELECT Tbl_StateMaster.State_id, Tbl_StateMaster.State_Name, Tbl_DistrictMaster.District_id, Tbl_DistrictMaster.District_Name, Tbl_TalukaMaster.Taluka_id, Tbl_TalukaMaster.Taluka_Name, Tbl_VillageMaster.Village_id, Tbl_VillageMaster.Village_Name, Tbl_ShopMaster.Shop_id, Tbl_ShopMaster.Shop_Name
                                         FROM (((Tbl_StateMaster INNER JOIN Tbl_DistrictMaster ON Tbl_StateMaster.State_id = Tbl_DistrictMaster.State_id) INNER JOIN Tbl_TalukaMaster ON (Tbl_DistrictMaster.District_id = Tbl_TalukaMaster.District_id) AND (Tbl_DistrictMaster.State_id = Tbl_TalukaMaster.State_id) AND (Tbl_StateMaster.State_id = Tbl_TalukaMaster.State_id) AND (Tbl_DistrictMaster.District_id = Tbl_TalukaMaster.District_id)) INNER JOIN Tbl_VillageMaster ON (Tbl_DistrictMaster.District_id = Tbl_VillageMaster.District_id) AND (Tbl_TalukaMaster.State_id = Tbl_VillageMaster.State_id) AND (Tbl_TalukaMaster.District_id = Tbl_VillageMaster.District_id) AND (Tbl_StateMaster.State_id = Tbl_VillageMaster.State_id) AND (Tbl_TalukaMaster.Taluka_id = Tbl_VillageMaster.Taluka_id)) INNER JOIN Tbl_ShopMaster ON (Tbl_VillageMaster.State_id = Tbl_ShopMaster.State_id) AND (Tbl_VillageMaster.District_id = Tbl_ShopMaster.District_id) AND (Tbl_VillageMaster.Taluka_id = Tbl_ShopMaster.Taluka_id) AND (Tbl_TalukaMaster.Taluka_id = Tbl_ShopMaster.Taluka_id) AND (Tbl_DistrictMaster.District_id = Tbl_ShopMaster.District_id) AND (Tbl_StateMaster.State_id = Tbl_ShopMaster.State_id) AND (Tbl_VillageMaster.Village_id = Tbl_ShopMaster.Village_id);", Con);
                adp = new OleDbDataAdapter(cmd);
                adp.Fill(dt);
                dt.TableName = "MASTERS";
                ds.Tables.Add(dt);

                dt = new DataTable();
                cmd = new OleDbCommand(@"SELECT Tbl_StateMaster.State_id, Tbl_StateMaster.State_Name, Tbl_DistrictMaster.District_id, Tbl_DistrictMaster.District_Name, Tbl_TalukaMaster.Taluka_id, Tbl_TalukaMaster.Taluka_Name, Tbl_VillageMaster.Village_id, Tbl_VillageMaster.Village_Name, Tbl_ShopMaster.Shop_id, Tbl_ShopMaster.Shop_Name
                                         FROM (((((Tbl_StateMaster INNER JOIN Tbl_DistrictMaster ON Tbl_StateMaster.State_id = Tbl_DistrictMaster.State_id) INNER JOIN Tbl_TalukaMaster ON (Tbl_DistrictMaster.District_id = Tbl_TalukaMaster.District_id) AND (Tbl_DistrictMaster.State_id = Tbl_TalukaMaster.State_id) AND (Tbl_StateMaster.State_id = Tbl_TalukaMaster.State_id) 
                                        AND (Tbl_DistrictMaster.District_id = Tbl_TalukaMaster.District_id)) INNER JOIN Tbl_VillageMaster ON (Tbl_DistrictMaster.District_id = Tbl_VillageMaster.District_id) AND (Tbl_TalukaMaster.State_id = Tbl_VillageMaster.State_id) AND (Tbl_TalukaMaster.District_id = Tbl_VillageMaster.District_id) AND (Tbl_StateMaster.State_id = Tbl_VillageMaster.State_id) AND 
                                        (Tbl_TalukaMaster.Taluka_id = Tbl_VillageMaster.Taluka_id)) INNER JOIN Tbl_ShopMaster ON (Tbl_VillageMaster.State_id = Tbl_ShopMaster.State_id) AND (Tbl_VillageMaster.District_id = Tbl_ShopMaster.District_id) AND (Tbl_VillageMaster.Taluka_id = Tbl_ShopMaster.Taluka_id) AND (Tbl_TalukaMaster.Taluka_id = Tbl_ShopMaster.Taluka_id) AND (Tbl_DistrictMaster.District_id = Tbl_ShopMaster.District_id) AND
                                        (Tbl_StateMaster.State_id = Tbl_ShopMaster.State_id) AND (Tbl_VillageMaster.Village_id = Tbl_ShopMaster.Village_id)) INNER JOIN Tbl_CardholderMaster ON (Tbl_ShopMaster.State_id = Tbl_CardholderMaster.State_id) AND (Tbl_ShopMaster.District_id = Tbl_CardholderMaster.District_id) AND (Tbl_ShopMaster.Taluka_id = Tbl_CardholderMaster.Taluka_id) AND (Tbl_ShopMaster.Village_id = Tbl_CardholderMaster.Village_id) AND 
                                        (Tbl_ShopMaster.Shop_id = Tbl_CardholderMaster.Shop_id) AND (Tbl_VillageMaster.Village_id = Tbl_CardholderMaster.Village_id) AND (Tbl_TalukaMaster.Taluka_id = Tbl_CardholderMaster.Taluka_id) AND (Tbl_DistrictMaster.District_id = Tbl_CardholderMaster.District_id) AND (Tbl_StateMaster.State_id = Tbl_CardholderMaster.State_id)) INNER JOIN Tbl_CardholderwiseMember ON (Tbl_CardholderMaster.Shop_id = Tbl_CardholderwiseMember.Shop_id) AND 
                                        (Tbl_CardholderMaster.Village_id = Tbl_CardholderwiseMember.Village_id) AND (Tbl_CardholderMaster.Taluka_id = Tbl_CardholderwiseMember.Taluka_id) AND (Tbl_CardholderMaster.District_id = Tbl_CardholderwiseMember.District_id) AND (Tbl_CardholderMaster.State_id = Tbl_CardholderwiseMember.State_id) AND (Tbl_ShopMaster.Shop_id = Tbl_CardholderwiseMember.Shop_id) AND (Tbl_VillageMaster.Village_id = Tbl_CardholderwiseMember.Village_id) AND 
                                        (Tbl_TalukaMaster.Taluka_id = Tbl_CardholderwiseMember.Taluka_id) AND (Tbl_DistrictMaster.District_id = Tbl_CardholderwiseMember.District_id) AND (Tbl_CardholderMaster.Cardholder_id = Tbl_CardholderwiseMember.Cardholder_id) AND (Tbl_StateMaster.State_id = Tbl_CardholderwiseMember.State_id);", Con);
                adp = new OleDbDataAdapter(cmd);
                adp.Fill(dt);
                dt.TableName = "AllROWS";
                ds.Tables.Add(dt);


                //dt = new DataTable();
                //cmd = new OleDbCommand("Select * from Tbl_StateMaster;", Con);
                //adp = new OleDbDataAdapter(cmd);
                //adp.Fill(dt);
                //dt.TableName = "State";
                //ds.Tables.Add(dt);
                dt = new DataTable();
                cmd = new OleDbCommand("Select district_id,district_name from Tbl_DistrictMaster;", Con);
                adp = new OleDbDataAdapter(cmd);
                adp.Fill(dt);
                dt.TableName = "District";
                ds.Tables.Add(dt);

                dt = new DataTable();
                cmd = new OleDbCommand("Select Taluka_id,Taluka_name from Tbl_TalukaMaster;", Con);
                adp = new OleDbDataAdapter(cmd);
                adp.Fill(dt);
                dt.TableName = "Taluka";
                ds.Tables.Add(dt);

                dt = new DataTable();
                cmd = new OleDbCommand("Select Village_id,Village_name from Tbl_VillageMaster;", Con);
                adp = new OleDbDataAdapter(cmd);
                adp.Fill(dt);
                dt.TableName = "Village";
                ds.Tables.Add(dt);

                dt = new DataTable();
                cmd = new OleDbCommand("Select Shop_id,Shop_name from Tbl_ShopMaster;", Con);
                adp = new OleDbDataAdapter(cmd);
                adp.Fill(dt);
                dt.TableName = "Shop";
                ds.Tables.Add(dt);

                dt = new DataTable();
                cmd = new OleDbCommand("SELECT count(*) as cnt FROM Tbl_CardholderMaster;", Con);
                adp = new OleDbDataAdapter(cmd);
                adp.Fill(dt);
                dt.TableName = "CARD HOLDER MASTER COUNT";
                ds.Tables.Add(dt);

                dt = new DataTable();
                cmd = new OleDbCommand("SELECT count(*) as cnt FROM tbl_CardHolderWiseMember;", Con);
                adp = new OleDbDataAdapter(cmd);
                adp.Fill(dt);
                dt.TableName = "CARD MEMBER WISE COUNT";
                ds.Tables.Add(dt);

                return ds;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                Con.Close();
                Con.Dispose();
            }
        }

        public DataSet Check_Machine_Unique_Number_To_Card_Unique_Number_CardHolderWiseMwmber(string path, string flag)
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            if (flag.ToUpper() == "CHECK")
            {

                OleDbConnection Con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path);
                try
                {
                    Con.Open();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                try
                {

                    OleDbCommand cmd = new OleDbCommand(@"select * from Tbl_CardholderwiseMember  
                                                      where left(machine_unique_number,18)<>card_unique_number;", Con);
                    OleDbDataAdapter adp = new OleDbDataAdapter(cmd);
                    adp.Fill(dt);
                    dt.TableName = "Match";
                    ds.Tables.Add(dt);
                    //return ds;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {

                    Con.Close();
                    Con.Dispose();
                }
            }
            if (flag.ToUpper() == "UPDATE")
            {

                OleDbConnection Con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path);
                try
                {
                    Con.Open();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                try
                {
                    OleDbCommand cmd = new OleDbCommand(@"update Tbl_CardholderwiseMember set card_unique_number=left(machine_unique_number,18) where card_unique_number<>left(machine_unique_number,18);", Con);
                    int a = cmd.ExecuteNonQuery();
                    dt.Columns.Add(new DataColumn("Count", typeof(string)));
                    dt.AcceptChanges();
                    DataRow dr = dt.NewRow();
                    dr[0] = a;
                    dt.Rows.Add(dr);
                    dt.AcceptChanges();
                    dt.TableName = "Match";
                    ds.Tables.Add(dt);

                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    Con.Close();
                    Con.Dispose();
                }
            }
            return ds;
        }


    }
}


