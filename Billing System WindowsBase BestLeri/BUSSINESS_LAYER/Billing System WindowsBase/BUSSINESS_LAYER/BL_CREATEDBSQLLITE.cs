using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace BUSSINESS_LAYER
{
    public class BL_CREATEDBSQLLITE : BL, ICOMMON_CLASS_MASTER
    {
        public _Server_ID Server_ID;
        public BL_CREATEDBSQLLITE() 
        {
            Server_ID = new _Server_ID();
        }
        string _path;
        public string Path { get { return _path; } set { _path = value; } }
        DataTable _CardHolderMaster;
        DataTable _CardHolderWiseMember;

        public DataTable CardHolderMaster { get { return _CardHolderMaster; } set { _CardHolderMaster = value; } }
        public DataTable CardHolderWiseMember { get { return _CardHolderWiseMember; } set { _CardHolderWiseMember = value; } }

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
            DataSet r_ds=new DataSet();
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
                DataSet ds = new DataSet("CARDDETAILS");
                DataTable dt = ((BL_IMPORTDB)classObject).CardHolderMaster;
                DataTable dt1 = ((BL_IMPORTDB)classObject).CardHolderWiseMember;
                ds.Tables.Add(dt.Copy());


                StringBuilder x = new StringBuilder("");
                Parameter.Clear();
                Parameter.Add("@CardHolderMAster", x.Append(ds.GetXml()).ToString());

                ds = new DataSet("CARDDETAILS");
                ds.Tables.Add(dt1.Copy());
                StringBuilder x1 = new StringBuilder("");
                x1.Append(ds.GetXml());
                Parameter.Add("@CardHolderWiseMember", x1.Append(ds.GetXml()).ToString());
                r_ds = blFill_Para_Name(Parameter, "SP_FORDATAENTRY_Fill_MASTER_MEMBER");
            }
            catch (Exception ex)
            {
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

                return ds;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }



    }
}


