using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using System.Windows.Forms;

namespace BUSSINESS_LAYER
{
    public class BL_RATION_CARD_ENTRY : BL, ICOMMON_CLASS_MASTER
    {
        public Other o;
        public BL_RATION_CARD_ENTRY()
        {
            o = new Other();
            MACHINEUNIQUEID_FOR_DELETE = new List<string>();
        }
        #region Local Variables
        int _CARDHOLDER_ID;
        int _STATE_ID;
        int _DISTRICT_ID;
        int _TALUKA_ID;
        int _VILLAGE_ID;
        int _SHOP_ID;
        int _CARDTYPE_ID;
        string _CARD_REFERENCE_NUMBER;
        string _GENDER;
        string _E_SALUTATION;
        string _E_FNAME;
        string _E_MNAME;
        string _E_LNAME;
        string _M_SALUTATION;
        string _M_FNAME;
        string _M_MNAME;
        string _M_LNAME;
        int _AGE;
        int _TOTAL_UNIT;
        int _TOTAL_PERSON;
        string _AADHAR_NUMBER;
        string _RATION_CARD_NUMBER;
        int _BANK_ID;
        string _BANK_ACCOUNT_NUMBER;
        string _CARD_UNIQUE_NUMBER;
        string _ISGAS;
        int _GAS_QTY;
        List<string> _MACHINEUNIQUEID_FOR_DELETE = new List<string>();
        #region Other_Member
        /// <summary>
        /// Add Other Members In Th Class.
        /// </summary>
        /// <returns>
        /// A tuple containing the following information:
        /// <list type="bullet">
        /// <item><see cref="Tuple{T1,T2,T3}.Item1"/>: The Gender of the person.</item>
        /// <item><see cref="Tuple{T1,T2,T3}.Item2"/>: The Salutaion of the person.</item>
        /// <item><see cref="Tuple{T1,T2,T3}.Item3"/>: The First Name of the person</item>
        /// </list>
        /// </returns>
        /// 

        List<Other> _OtherMembers = new List<Other>();
        //list parameters in as below serial
        public struct Other
        {
            public int _CARDMEMEBER_ID;
            public string _GENDER;
            public string _E_SALUTATION;
            public string _E_FNAME;
            public string _E_MNAME;
            public string _E_LNAME;
            public string _M_SALUTATION;
            public string _M_FNAME;
            public string _M_MNAME;
            public string _M_LNAME;
            public string _AADHAR_NUMBER;
            public int _AGE;
            public string _IS_NEW_DB;
            public string _Member_Flag;
            public string _MAchineUniqueID;
            public string _IsRegister;
        }
        #endregion

        #endregion

        #region Variable Asseccible From Outside the Class
        public int CARDHOLDER_ID { get { return _CARDHOLDER_ID; } set { _CARDHOLDER_ID = value; } }
        public int STATE_ID { get { return _STATE_ID; } set { _STATE_ID = value; } }
        public int DISTRICT_ID { get { return _DISTRICT_ID; } set { _DISTRICT_ID = value; } }
        public int TALUKA_ID { get { return _TALUKA_ID; } set { _TALUKA_ID = value; } }
        public int VILLAGE_ID { get { return _VILLAGE_ID; } set { _VILLAGE_ID = value; } }
        public int SHOP_ID { get { return _SHOP_ID; } set { _SHOP_ID = value; } }
        public int CARDTYPE_ID { get { return _CARDTYPE_ID; } set { _CARDTYPE_ID = value; } }
        public string CARD_REFERENCE_NUMBER { get { return _CARD_REFERENCE_NUMBER; } set { _CARD_REFERENCE_NUMBER = value; } }
        public string GENDER { get { return _GENDER; } set { _GENDER = value; } }
        public string E_SALUTATION { get { return _E_SALUTATION; } set { _E_SALUTATION = value; } }
        public string E_FNAME { get { return _E_FNAME; } set { _E_FNAME = value; } }
        public string E_MNAME { get { return _E_MNAME; } set { _E_MNAME = value; } }
        public string E_LNAME { get { return _E_LNAME; } set { _E_LNAME = value; } }
        public string M_SALUTATION { get { return _M_SALUTATION; } set { _M_SALUTATION = value; } }
        public string M_FNAME { get { return _M_FNAME; } set { _M_FNAME = value; } }
        public string M_MNAME { get { return _M_MNAME; } set { _M_MNAME = value; } }
        public string M_LNAME { get { return _M_LNAME; } set { _M_LNAME = value; } }
        public int AGE { get { return _AGE; } set { _AGE = value; } }
        public int TOTAL_UNIT { get { return _TOTAL_UNIT; } set { _TOTAL_UNIT = value; } }
        public int TOTAL_PERSON { get { return _TOTAL_PERSON; } set { _TOTAL_PERSON = value; } }

        public string AADHAR_NUMBER { get { return _AADHAR_NUMBER; } set { _AADHAR_NUMBER = value; } }
        public string RATION_CARD_NUMBER { get { return _RATION_CARD_NUMBER; } set { _RATION_CARD_NUMBER = value; } }
        public int BANK_ID { get { return _BANK_ID; } set { _BANK_ID = value; } }
        public string BANK_ACCOUNT_NUMBER { get { return _BANK_ACCOUNT_NUMBER; } set { _BANK_ACCOUNT_NUMBER = value; } }
        public string CARD_UNIQUE_NUMBER { get { return _CARD_UNIQUE_NUMBER; } set { _CARD_UNIQUE_NUMBER = value; } }
        public string ISGAS { get { return _ISGAS; } set { _ISGAS = value; } }
        public int GAS_QTY { get { return _GAS_QTY; } set { _GAS_QTY = value; } }

        public List<string> MACHINEUNIQUEID_FOR_DELETE { get { return _MACHINEUNIQUEID_FOR_DELETE; } set { _MACHINEUNIQUEID_FOR_DELETE = value; } }
        #endregion
        public List<Other> OtherMembers { get { return _OtherMembers; } set { _OtherMembers = value; } }


        #region ICOMMON_CLASS_MASTER Members

        public DataSet SELECT(object classObject)
        {

            DataSet ds = new DataSet();

            DataTable dt = ExecuteQuery("SELECT District_id,District_Name FROM Tbl_DistrictMaster;").Tables[0].Copy();
            dt.TableName = "DISTRICTMASTER";
            ds.Tables.Add(dt);
            dt = ExecuteQuery("SELECT Taluka_id,Taluka_Name FROM Tbl_TalukaMaster;").Tables[0].Copy();
            dt.TableName = "TALUKAMASTER";
            ds.Tables.Add(dt);
            dt = ExecuteQuery("SELECT Village_id,Village_Name FROM Tbl_VillageMaster;").Tables[0].Copy();
            dt.TableName = "VILLAGEMASTER";
            ds.Tables.Add(dt);
            dt = ExecuteQuery("SELECT Shop_id,Shop_Name FROM Tbl_ShopMaster;").Tables[0].Copy();
            dt.TableName = "SHOPMASTER";
            ds.Tables.Add(dt);

            dt = ExecuteQuery("SELECT CardType_id, M_CardType_Name FROM Tbl_CardTypeMaster;").Tables[0].Copy();
            dt.TableName = "CARDTYPEMASTER";
            ds.Tables.Add(dt);

            //dt = ExecuteQuery("SELECT * FROM Tbl_CardholderMaster;").Tables[0].Copy();
            //dt.TableName = "CARDHOLDERMASTER";
            //ds.Tables.Add(dt);

            Parameter.Clear();
            Parameter.Add("@State_id", ((BL_RATION_CARD_ENTRY)classObject).STATE_ID.ToString());
            Parameter.Add("@District_id", ((BL_RATION_CARD_ENTRY)classObject).DISTRICT_ID.ToString());
            Parameter.Add("@Taluka_id", ((BL_RATION_CARD_ENTRY)classObject).TALUKA_ID.ToString());
            Parameter.Add("@Village_id", ((BL_RATION_CARD_ENTRY)classObject).VILLAGE_ID.ToString());
            Parameter.Add("@Shop_id", ((BL_RATION_CARD_ENTRY)classObject).SHOP_ID.ToString());
            Query = @"SELECT Cardholder_id, State_id, District_id, Taluka_id, Village_id, Shop_id, Card_Reference_Number, E_Salutation, E_Fname, E_Mname, E_Lname
                      FROM Tbl_CardholderMaster
                      where State_id=@State_id and District_id=@District_id and Taluka_id=@Taluka_id and Village_id=@Village_id and  Shop_id=@Shop_id and ISVERIFY='0'
                      order by State_id, District_id, Taluka_id, Village_id, Shop_id,Cardholder_id desc
                      ";

            dt = ExecuteQuery(Parameter, Query).Tables[0].Copy();
            DataColumn dc = new DataColumn("SHOW", typeof(System.String));
            dt.Columns.Add(dc);
            dc.SetOrdinal(1);

            //dt.Columns.Add(new DataColumn("SHOW", typeof(System.String)));
            foreach (DataRow dr in dt.Rows)
                dr["SHOW"] = dr["E_Salutation"].ToString() + " " + dr["E_Fname"].ToString() + " " + dr["E_Mname"].ToString() + " " + dr["E_Lname"].ToString();
            dt.AcceptChanges();
            dt.TableName = "NOT VERIFY Cards";
            ds.Tables.Add(dt);

            Parameter.Clear();
            Parameter.Add("@State_id", ((BL_RATION_CARD_ENTRY)classObject).STATE_ID.ToString());
            Parameter.Add("@District_id", ((BL_RATION_CARD_ENTRY)classObject).DISTRICT_ID.ToString());
            Parameter.Add("@Taluka_id", ((BL_RATION_CARD_ENTRY)classObject).TALUKA_ID.ToString());
            Parameter.Add("@Village_id", ((BL_RATION_CARD_ENTRY)classObject).VILLAGE_ID.ToString());
            Parameter.Add("@Shop_id", ((BL_RATION_CARD_ENTRY)classObject).SHOP_ID.ToString());
            Query = @"SELECT Cardholder_id, State_id, District_id, Taluka_id, Village_id, Shop_id, Card_Reference_Number, E_Salutation, E_Fname, E_Mname, E_Lname
                      FROM Tbl_CardholderMaster
                      where State_id=@State_id and District_id=@District_id and Taluka_id=@Taluka_id and Village_id=@Village_id and  Shop_id=@Shop_id and ISVERIFY='1'
                      order by State_id, District_id, Taluka_id, Village_id, Shop_id,Cardholder_id desc
                      ";

            dt = ExecuteQuery(Parameter, Query).Tables[0].Copy();
            dc = new DataColumn("SHOW", typeof(System.String));
            dt.Columns.Add(dc);
            dc.SetOrdinal(1);

            //dt.Columns.Add(new DataColumn("SHOW", typeof(System.String)));
            foreach (DataRow dr in dt.Rows)
                dr["SHOW"] = dr["E_Salutation"].ToString() + " " + dr["E_Fname"].ToString() + " " + dr["E_Mname"].ToString() + " " + dr["E_Lname"].ToString();
            dt.AcceptChanges();
            dt.TableName = "VERIFY Cards";
            ds.Tables.Add(dt);

            dt = ExecuteQuery(@"SELECT E_M_FNAME as NAME,E_M_LNAME as SURNAME,M_M_FNAME as MNAME,M_M_LNAME as MSURNAME
                                FROM Tbl_CardholderwiseMember where E_M_FNAME not like '*-*'
                                Union ALL
                                SELECT E_M_MNAME,'',M_M_MNAME,''
                                FROM Tbl_CardholderwiseMember where  E_M_MNAME not like '*-*'
                                ").Tables[0].Copy();
            dt.TableName = "NAMELIST";
            ds.Tables.Add(dt);
            return ds;
        }

        public DataSet INSERT(object classObject)
        {
            try
            {


                #region  maxid for Card
                int maxid = 0;
                Query = "select max(Cardholder_id) from Tbl_CardholderMaster where State_id=@State_id  and District_id=@District_id and Taluka_id=@Taluka_id and Village_id=@Village_id and Shop_id=@Shop_id";
                Parameter.Clear();

                Parameter.Add("@State_id ", ((BL_RATION_CARD_ENTRY)classObject).STATE_ID.ToString());
                Parameter.Add("@District_id", ((BL_RATION_CARD_ENTRY)classObject).DISTRICT_ID.ToString());
                Parameter.Add("@Taluka_id", ((BL_RATION_CARD_ENTRY)classObject).TALUKA_ID.ToString());
                Parameter.Add("@Village_id", ((BL_RATION_CARD_ENTRY)classObject).VILLAGE_ID.ToString());
                Parameter.Add("@Shop_id", ((BL_RATION_CARD_ENTRY)classObject).SHOP_ID.ToString());

                string ds = ExecuteScaler(Parameter, Query);
                //if (ds.Tables.Count >= 1 && ds.Tables[0].Rows.Count >= 1)
                //maxid = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString());
                maxid = Convert.ToInt32(ds.Trim() == "" ? "0" : ds);
                maxid += 1;
                #endregion

                #region insert in Tbl_CardholderMaster
                Query = @"insert into  Tbl_CardholderMaster values (@Cardholder_id, @State_id, @District_id, @Taluka_id, @Village_id, @Shop_id, @CardType_id, @Card_Reference_Number, @Gender, @E_Salutation, @E_Fname, @E_Mname, @E_Lname, @M_Salutation, @M_Fname, @M_Mname, @M_Lname, @Total_Unit, @Total_Person, @Ration_Card_Number, @Bank_id, @Bank_Account_Number, @Card_Unique_Number, @Isgas, @Gas_Qty,@isverify)";
                Parameter.Clear();
                Parameter.Add("@Cardholder_id", maxid.ToString());
                Parameter.Add("@State_id", ((BL_RATION_CARD_ENTRY)classObject).STATE_ID.ToString());
                Parameter.Add("@District_id", ((BL_RATION_CARD_ENTRY)classObject).DISTRICT_ID.ToString());
                Parameter.Add("@Taluka_id", ((BL_RATION_CARD_ENTRY)classObject).TALUKA_ID.ToString());
                Parameter.Add("@Village_id", ((BL_RATION_CARD_ENTRY)classObject).VILLAGE_ID.ToString());
                Parameter.Add("@Shop_id", ((BL_RATION_CARD_ENTRY)classObject).SHOP_ID.ToString());
                Parameter.Add("@CardType_id", ((BL_RATION_CARD_ENTRY)classObject).CARDTYPE_ID.ToString());
                Parameter.Add("@Card_Reference_Number", ((BL_RATION_CARD_ENTRY)classObject).CARD_REFERENCE_NUMBER.ToString());
                Parameter.Add("@Gender", ((BL_RATION_CARD_ENTRY)classObject).GENDER.ToString());
                Parameter.Add("@E_Salutation", ((BL_RATION_CARD_ENTRY)classObject).E_SALUTATION.ToString());
                Parameter.Add("@E_Fname", ((BL_RATION_CARD_ENTRY)classObject).E_FNAME.ToString());
                Parameter.Add("@E_Mname", ((BL_RATION_CARD_ENTRY)classObject).E_MNAME.ToString());
                Parameter.Add("@E_Lname", ((BL_RATION_CARD_ENTRY)classObject).E_LNAME.ToString());
                Parameter.Add("@M_Salutation", ((BL_RATION_CARD_ENTRY)classObject).M_SALUTATION.ToString());
                Parameter.Add("@M_Fname", ((BL_RATION_CARD_ENTRY)classObject).M_FNAME.ToString());
                Parameter.Add("@M_Mname", ((BL_RATION_CARD_ENTRY)classObject).M_MNAME.ToString());
                Parameter.Add("@M_Lname", ((BL_RATION_CARD_ENTRY)classObject).M_LNAME.ToString());
                Parameter.Add("@Total_Unit", ((BL_RATION_CARD_ENTRY)classObject).TOTAL_UNIT.ToString());
                Parameter.Add("@Total_Person", ((BL_RATION_CARD_ENTRY)classObject).TOTAL_PERSON.ToString());
                Parameter.Add("@Ration_Card_Number", ((BL_RATION_CARD_ENTRY)classObject).RATION_CARD_NUMBER.ToString());
                Parameter.Add("@Bank_id", ((BL_RATION_CARD_ENTRY)classObject).BANK_ID.ToString());
                Parameter.Add("@Bank_Account_Number", ((BL_RATION_CARD_ENTRY)classObject).BANK_ACCOUNT_NUMBER.ToString());
                Parameter.Add("@Card_Unique_Number", Card_Unique_Number(((BL_RATION_CARD_ENTRY)classObject).STATE_ID,
                        ((BL_RATION_CARD_ENTRY)classObject).DISTRICT_ID,
                        ((BL_RATION_CARD_ENTRY)classObject).TALUKA_ID,
                    ((BL_RATION_CARD_ENTRY)classObject).VILLAGE_ID,
                    ((BL_RATION_CARD_ENTRY)classObject).SHOP_ID,
                    maxid));
                Parameter.Add("@Isgas", ((BL_RATION_CARD_ENTRY)classObject).ISGAS.ToString());
                Parameter.Add("@Gas_Qty", ((BL_RATION_CARD_ENTRY)classObject).GAS_QTY.ToString());
                Parameter.Add("@Isverify", "0");




                ExecuteNonQuery(Parameter, Query);
                #endregion
                #region For Insert main member in other Table
                #region maxid for Tbl_CardHolderWiseMember
                int maxid1 = 0;
                Query = "select max(Cardmember_id) from Tbl_CardHolderWiseMember where State_id=@State_id and District_id=@District_id and Taluka_id=@Taluka_id and Village_id=@Village_id and Shop_id=@Shop_id and Cardholder_id=@Cardhold_id";
                Parameter.Clear();
                Parameter.Add("@State_id ", ((BL_RATION_CARD_ENTRY)classObject).STATE_ID.ToString());
                Parameter.Add("@District_id", ((BL_RATION_CARD_ENTRY)classObject).DISTRICT_ID.ToString());
                Parameter.Add("@Taluka_id", ((BL_RATION_CARD_ENTRY)classObject).TALUKA_ID.ToString());
                Parameter.Add("@Village_id", ((BL_RATION_CARD_ENTRY)classObject).VILLAGE_ID.ToString());
                Parameter.Add("@Shop_id", ((BL_RATION_CARD_ENTRY)classObject).SHOP_ID.ToString());
                Parameter.Add("@Cardhold_id", maxid.ToString());

                ds = ExecuteScaler(Parameter, Query);
                //if (ds.Tables.Count >= 1 && ds.Tables[0].Rows.Count >= 1)
                //maxid = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString());
                maxid1 = Convert.ToInt32(ds.Trim() == "" ? "0" : ds);
                maxid1 += 1;

                #endregion


                Query = @"insert into Tbl_CardholderwiseMember values(@Cardmember_id, @Cardholder_id, @State_id, @District_id, @Taluka_id, @Village_id, @Shop_id, @Machine_Unique_Number, @Gender, @E_Salutation, @E_M_Fname, @E_M_Mname, @E_M_Lname, @M_Salutation, @M_M_Fname, @M_M_Mname, @M_M_Lname, @Finger, @Member_Flag, @Isregister, @Card_Unique_Number, @Adhar_Number, @Age, @LImage, @RImage,@isverify);";
                Parameter.Clear();

                Parameter.Add("@Cardmember_id", maxid1.ToString());
                Parameter.Add("@Cardholder_id", maxid.ToString());
                Parameter.Add("@State_id", ((BL_RATION_CARD_ENTRY)classObject).STATE_ID.ToString());
                Parameter.Add("@District_id", ((BL_RATION_CARD_ENTRY)classObject).DISTRICT_ID.ToString());
                Parameter.Add("@Taluka_id", ((BL_RATION_CARD_ENTRY)classObject).TALUKA_ID.ToString());
                Parameter.Add("@Village_id", ((BL_RATION_CARD_ENTRY)classObject).VILLAGE_ID.ToString());
                Parameter.Add("@Shop_id", ((BL_RATION_CARD_ENTRY)classObject).SHOP_ID.ToString());
                Parameter.Add("@Machine_Unique_Number", Machine_Unique_Number(((BL_RATION_CARD_ENTRY)classObject).STATE_ID,
                    ((BL_RATION_CARD_ENTRY)classObject).DISTRICT_ID,
                    ((BL_RATION_CARD_ENTRY)classObject).TALUKA_ID,
                ((BL_RATION_CARD_ENTRY)classObject).VILLAGE_ID,
                ((BL_RATION_CARD_ENTRY)classObject).SHOP_ID,
                maxid, maxid1));
                Parameter.Add("@Gender", ((BL_RATION_CARD_ENTRY)classObject).GENDER.ToString());
                Parameter.Add("@E_Salutation", ((BL_RATION_CARD_ENTRY)classObject).E_SALUTATION.ToString());
                Parameter.Add("@E_M_Fname", ((BL_RATION_CARD_ENTRY)classObject).E_FNAME.ToString());
                Parameter.Add("@E_M_Mname", ((BL_RATION_CARD_ENTRY)classObject).E_MNAME.ToString());
                Parameter.Add("@E_M_Lname", ((BL_RATION_CARD_ENTRY)classObject).E_LNAME.ToString());
                Parameter.Add("@M_Salutation", ((BL_RATION_CARD_ENTRY)classObject).M_SALUTATION.ToString());
                Parameter.Add("@M_M_Fname", ((BL_RATION_CARD_ENTRY)classObject).M_FNAME.ToString());
                Parameter.Add("@M_M_Mname", ((BL_RATION_CARD_ENTRY)classObject).M_MNAME.ToString());
                Parameter.Add("@M_M_Lname", ((BL_RATION_CARD_ENTRY)classObject).M_LNAME.ToString());
                Parameter.Add("@Finger", "-");
                Parameter.Add("@Member_Flag", "M");
                Parameter.Add("@Isregister", "0");
                Parameter.Add("@Card_Unique_Number", Card_Unique_Number(((BL_RATION_CARD_ENTRY)classObject).STATE_ID,
                    ((BL_RATION_CARD_ENTRY)classObject).DISTRICT_ID,
                    ((BL_RATION_CARD_ENTRY)classObject).TALUKA_ID,
                ((BL_RATION_CARD_ENTRY)classObject).VILLAGE_ID,
                ((BL_RATION_CARD_ENTRY)classObject).SHOP_ID,
                maxid));
                Parameter.Add("@Adhar_Number", ((BL_RATION_CARD_ENTRY)classObject).AADHAR_NUMBER.ToString());
                Parameter.Add("@Age", ((BL_RATION_CARD_ENTRY)classObject).AGE.ToString());
                Parameter.Add("@LImage", DBNull.Value.ToString());
                Parameter.Add("@RImage", DBNull.Value.ToString());
                Parameter.Add("@Isverify", "0");
                ExecuteNonQuery(Parameter, Query);
                #endregion


                #region inset in Tbl_CardHolderWiseMember

                foreach (Other o in ((BL_RATION_CARD_ENTRY)classObject).OtherMembers)
                {
                    #region maxid for Tbl_CardHolderWiseMember
                    maxid1 = 0;
                    Query = "select max(Cardmember_id) from Tbl_CardHolderWiseMember where State_id=@State_id and District_id=@District_id and Taluka_id=@Taluka_id and Village_id=@Village_id and Shop_id=@Shop_id and Cardholder_id=@Cardhold_id";
                    Parameter.Clear();
                    Parameter.Add("@State_id ", ((BL_RATION_CARD_ENTRY)classObject).STATE_ID.ToString());
                    Parameter.Add("@District_id", ((BL_RATION_CARD_ENTRY)classObject).DISTRICT_ID.ToString());
                    Parameter.Add("@Taluka_id", ((BL_RATION_CARD_ENTRY)classObject).TALUKA_ID.ToString());
                    Parameter.Add("@Village_id", ((BL_RATION_CARD_ENTRY)classObject).VILLAGE_ID.ToString());
                    Parameter.Add("@Shop_id", ((BL_RATION_CARD_ENTRY)classObject).SHOP_ID.ToString());
                    Parameter.Add("@Cardhold_id", maxid.ToString());

                    ds = ExecuteScaler(Parameter, Query);
                    //if (ds.Tables.Count >= 1 && ds.Tables[0].Rows.Count >= 1)
                    //maxid = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString());
                    maxid1 = Convert.ToInt32(ds.Trim() == "" ? "0" : ds);
                    maxid1 += 1;

                    #endregion


                    Query = @"insert into Tbl_CardholderwiseMember values(@Cardmember_id, @Cardholder_id, @State_id, @District_id, @Taluka_id, @Village_id, @Shop_id, @Machine_Unique_Number, @Gender, @E_Salutation, @E_M_Fname, @E_M_Mname, @E_M_Lname, @M_Salutation, @M_M_Fname, @M_M_Mname, @M_M_Lname, @Finger, @Member_Flag, @Isregister, @Card_Unique_Number, @Adhar_Number, @Age, @LImage, @RImage,@isverify);";
                    Parameter.Clear();

                    Parameter.Add("@Cardmember_id", maxid1.ToString());
                    Parameter.Add("@Cardholder_id", maxid.ToString());
                    Parameter.Add("@State_id", ((BL_RATION_CARD_ENTRY)classObject).STATE_ID.ToString());
                    Parameter.Add("@District_id", ((BL_RATION_CARD_ENTRY)classObject).DISTRICT_ID.ToString());
                    Parameter.Add("@Taluka_id", ((BL_RATION_CARD_ENTRY)classObject).TALUKA_ID.ToString());
                    Parameter.Add("@Village_id", ((BL_RATION_CARD_ENTRY)classObject).VILLAGE_ID.ToString());
                    Parameter.Add("@Shop_id", ((BL_RATION_CARD_ENTRY)classObject).SHOP_ID.ToString());
                    Parameter.Add("@Machine_Unique_Number", Machine_Unique_Number(((BL_RATION_CARD_ENTRY)classObject).STATE_ID,
                        ((BL_RATION_CARD_ENTRY)classObject).DISTRICT_ID,
                        ((BL_RATION_CARD_ENTRY)classObject).TALUKA_ID,
                    ((BL_RATION_CARD_ENTRY)classObject).VILLAGE_ID,
                    ((BL_RATION_CARD_ENTRY)classObject).SHOP_ID,
                    maxid, maxid1));
                    Parameter.Add("@Gender", o._GENDER.ToString());
                    Parameter.Add("@E_Salutation", o._E_SALUTATION.ToString());
                    Parameter.Add("@E_M_Fname", o._E_FNAME.ToString());
                    Parameter.Add("@E_M_Mname", o._E_MNAME.ToString());
                    Parameter.Add("@E_M_Lname", o._E_LNAME.ToString());
                    Parameter.Add("@M_Salutation", o._M_SALUTATION.ToString());
                    Parameter.Add("@M_M_Fname", o._M_FNAME.ToString());
                    Parameter.Add("@M_M_Mname", o._M_MNAME.ToString());
                    Parameter.Add("@M_M_Lname", o._M_LNAME.ToString());
                    Parameter.Add("@Finger", "-");
                    Parameter.Add("@Member_Flag", "O");
                    Parameter.Add("@Isregister", "0");
                    Parameter.Add("@Card_Unique_Number", Card_Unique_Number(((BL_RATION_CARD_ENTRY)classObject).STATE_ID,
                        ((BL_RATION_CARD_ENTRY)classObject).DISTRICT_ID,
                        ((BL_RATION_CARD_ENTRY)classObject).TALUKA_ID,
                    ((BL_RATION_CARD_ENTRY)classObject).VILLAGE_ID,
                    ((BL_RATION_CARD_ENTRY)classObject).SHOP_ID,
                    maxid));
                    Parameter.Add("@Adhar_Number", o._AADHAR_NUMBER.ToString());
                    Parameter.Add("@Age", o._AGE.ToString());
                    Parameter.Add("@LImage", DBNull.Value.ToString());
                    Parameter.Add("@RImage", DBNull.Value.ToString());
                    Parameter.Add("@Isverify", "0");

                    ExecuteNonQuery(Parameter, Query);

                }
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
                #region Update in Tbl_CardholderMaster
                Query = @"Update Tbl_CardholderMaster set
                        CardType_id=@CardType_id, Card_Reference_Number=@Card_Reference_Number, Gender=@Gender, E_Salutation=@E_Salutation, 
                        E_Fname=@E_Fname, E_Mname=@E_Mname, E_Lname=@E_Lname, M_Salutation=@M_Salutation, M_Fname=@M_Fname, M_Mname=@M_Mname, M_Lname=@M_Lname, 
                        Total_Unit=@Total_Unit, Total_Person=@Total_Person, Ration_Card_Number=@Ration_Card_Number, Bank_id=@Bank_id, 
                        Bank_Account_Number=@Bank_Account_Number, Card_Unique_Number=@Card_Unique_Number, Isgas=@Isgas, Gas_Qty=@Gas_Qty,isverify=@isverify
                        where State_id=@State_id and District_id=@District_id and Taluka_id=@Taluka_id and Village_id=@Village_id and  Shop_id=@Shop_id and Cardholder_id=@Cardholder_id";
                Parameter.Clear();


                Parameter.Add("@CardType_id", ((BL_RATION_CARD_ENTRY)classObject).CARDTYPE_ID.ToString());
                Parameter.Add("@Card_Reference_Number", ((BL_RATION_CARD_ENTRY)classObject).CARD_REFERENCE_NUMBER.ToString());
                Parameter.Add("@Gender", ((BL_RATION_CARD_ENTRY)classObject).GENDER.ToString());
                Parameter.Add("@E_Salutation", ((BL_RATION_CARD_ENTRY)classObject).E_SALUTATION.ToString());
                Parameter.Add("@E_Fname", ((BL_RATION_CARD_ENTRY)classObject).E_FNAME.ToString());
                Parameter.Add("@E_Mname", ((BL_RATION_CARD_ENTRY)classObject).E_MNAME.ToString());
                Parameter.Add("@E_Lname", ((BL_RATION_CARD_ENTRY)classObject).E_LNAME.ToString());
                Parameter.Add("@M_Salutation", ((BL_RATION_CARD_ENTRY)classObject).M_SALUTATION.ToString());
                Parameter.Add("@M_Fname", ((BL_RATION_CARD_ENTRY)classObject).M_FNAME.ToString());
                Parameter.Add("@M_Mname", ((BL_RATION_CARD_ENTRY)classObject).M_MNAME.ToString());
                Parameter.Add("@M_Lname", ((BL_RATION_CARD_ENTRY)classObject).M_LNAME.ToString());
                Parameter.Add("@Total_Unit", ((BL_RATION_CARD_ENTRY)classObject).TOTAL_UNIT.ToString());
                Parameter.Add("@Total_Person", ((BL_RATION_CARD_ENTRY)classObject).TOTAL_PERSON.ToString());
                Parameter.Add("@Ration_Card_Number", ((BL_RATION_CARD_ENTRY)classObject).RATION_CARD_NUMBER.ToString());
                Parameter.Add("@Bank_id", ((BL_RATION_CARD_ENTRY)classObject).BANK_ID.ToString());
                Parameter.Add("@Bank_Account_Number", ((BL_RATION_CARD_ENTRY)classObject).BANK_ACCOUNT_NUMBER.ToString());
                Parameter.Add("@Card_Unique_Number", Card_Unique_Number(((BL_RATION_CARD_ENTRY)classObject).STATE_ID,
                        ((BL_RATION_CARD_ENTRY)classObject).DISTRICT_ID,
                        ((BL_RATION_CARD_ENTRY)classObject).TALUKA_ID,
                    ((BL_RATION_CARD_ENTRY)classObject).VILLAGE_ID,
                    ((BL_RATION_CARD_ENTRY)classObject).SHOP_ID,
                    ((BL_RATION_CARD_ENTRY)classObject).CARDHOLDER_ID));
                Parameter.Add("@Isgas", ((BL_RATION_CARD_ENTRY)classObject).ISGAS.ToString());
                Parameter.Add("@Gas_Qty", ((BL_RATION_CARD_ENTRY)classObject).GAS_QTY.ToString());
                Parameter.Add("@Isverify", "0");

                Parameter.Add("@State_id", ((BL_RATION_CARD_ENTRY)classObject).STATE_ID.ToString());
                Parameter.Add("@District_id", ((BL_RATION_CARD_ENTRY)classObject).DISTRICT_ID.ToString());
                Parameter.Add("@Taluka_id", ((BL_RATION_CARD_ENTRY)classObject).TALUKA_ID.ToString());
                Parameter.Add("@Village_id", ((BL_RATION_CARD_ENTRY)classObject).VILLAGE_ID.ToString());
                Parameter.Add("@Shop_id", ((BL_RATION_CARD_ENTRY)classObject).SHOP_ID.ToString());
                Parameter.Add("@Cardholder_id", ((BL_RATION_CARD_ENTRY)classObject).CARDHOLDER_ID.ToString());

                ExecuteNonQuery(Parameter, Query);
                #endregion
                #region Update Main Member in Tbl_CardholderwiseMember
                #region for existing entry
                Query = @"Update Tbl_CardholderwiseMember set 
                                Machine_Unique_Number=@Machine_Unique_Number, Gender=@Gender, E_Salutation=@E_Salutation, E_M_Fname=@E_M_Fname, E_M_Mname=@E_M_Mname, E_M_Lname=@E_M_Lname, M_Salutation=@M_Salutation, M_M_Fname=@M_M_Fname, M_M_Mname=@M_M_Mname, M_M_Lname=@M_M_Lname, 
                                Finger=@Finger, Member_Flag=@Member_Flag, Isregister=@Isregister, Card_Unique_Number=@Card_Unique_Number, Adhar_Number=@Adhar_Number, Age=@Age, LImage=@LImage, RImage=@RImage,isverify=@isverify
                                where State_id=@State_id and District_id=@District_id and Taluka_id=@Taluka_id and Village_id=@Village_id and  Shop_id=@Shop_id and Cardholder_id=@Cardholder_id and Cardmember_id=@Cardmember_id";
                Parameter.Clear();

                Parameter.Add("@Machine_Unique_Number", Machine_Unique_Number(((BL_RATION_CARD_ENTRY)classObject).STATE_ID,
                        ((BL_RATION_CARD_ENTRY)classObject).DISTRICT_ID,
                        ((BL_RATION_CARD_ENTRY)classObject).TALUKA_ID,
                    ((BL_RATION_CARD_ENTRY)classObject).VILLAGE_ID,
                    ((BL_RATION_CARD_ENTRY)classObject).SHOP_ID,
                    ((BL_RATION_CARD_ENTRY)classObject).CARDHOLDER_ID, 1));
                Parameter.Add("@Gender", ((BL_RATION_CARD_ENTRY)classObject).GENDER.ToString());
                Parameter.Add("@E_Salutation", ((BL_RATION_CARD_ENTRY)classObject).E_SALUTATION.ToString());
                Parameter.Add("@E_M_Fname", ((BL_RATION_CARD_ENTRY)classObject).E_FNAME.ToString());
                Parameter.Add("@E_M_Mname", ((BL_RATION_CARD_ENTRY)classObject).E_MNAME.ToString());
                Parameter.Add("@E_M_Lname", ((BL_RATION_CARD_ENTRY)classObject).E_LNAME.ToString());
                Parameter.Add("@M_Salutation", ((BL_RATION_CARD_ENTRY)classObject).M_SALUTATION.ToString());
                Parameter.Add("@M_M_Fname", ((BL_RATION_CARD_ENTRY)classObject).M_FNAME.ToString());
                Parameter.Add("@M_M_Mname", ((BL_RATION_CARD_ENTRY)classObject).M_MNAME.ToString());
                Parameter.Add("@M_M_Lname", ((BL_RATION_CARD_ENTRY)classObject).M_LNAME.ToString());
                Parameter.Add("@Finger", "-");
                Parameter.Add("@Member_Flag", "M");
                Parameter.Add("@Isregister", "0");
                Parameter.Add("@Card_Unique_Number", Card_Unique_Number(((BL_RATION_CARD_ENTRY)classObject).STATE_ID,
                    ((BL_RATION_CARD_ENTRY)classObject).DISTRICT_ID,
                    ((BL_RATION_CARD_ENTRY)classObject).TALUKA_ID,
                ((BL_RATION_CARD_ENTRY)classObject).VILLAGE_ID,
                ((BL_RATION_CARD_ENTRY)classObject).SHOP_ID,
                1));
                Parameter.Add("@Adhar_Number", "0");
                Parameter.Add("@Age", ((BL_RATION_CARD_ENTRY)classObject).AGE.ToString());
                Parameter.Add("@LImage", DBNull.Value.ToString());
                Parameter.Add("@RImage", DBNull.Value.ToString());
                Parameter.Add("@Isverify", "0");


                Parameter.Add("@State_id", ((BL_RATION_CARD_ENTRY)classObject).STATE_ID.ToString());
                Parameter.Add("@District_id", ((BL_RATION_CARD_ENTRY)classObject).DISTRICT_ID.ToString());
                Parameter.Add("@Taluka_id", ((BL_RATION_CARD_ENTRY)classObject).TALUKA_ID.ToString());
                Parameter.Add("@Village_id", ((BL_RATION_CARD_ENTRY)classObject).VILLAGE_ID.ToString());
                Parameter.Add("@Shop_id", ((BL_RATION_CARD_ENTRY)classObject).SHOP_ID.ToString());
                Parameter.Add("@Cardholder_id", ((BL_RATION_CARD_ENTRY)classObject).CARDHOLDER_ID.ToString());
                Parameter.Add("@Cardmember_id", "1");

                ExecuteNonQuery(Parameter, Query);
                #endregion
                #endregion
                #region delete Remaining Member
                foreach (String id in ((BL_RATION_CARD_ENTRY)classObject).MACHINEUNIQUEID_FOR_DELETE)
                {
                    Query = @"insert into ID_TO_DELETE values(@MACHINE_UNIQUE_NUMBER)";
                    Parameter.Clear();
                    Parameter.Add("@MACHINE_UNIQUE_NUMBER", id.ToString());
                    ExecuteNonQuery(Parameter, Query);

                    Query = @"delete from Tbl_CardholderwiseMember                                
                                where MACHINE_UNIQUE_NUMBER=@MACHINE_UNIQUE_NUMBER";
                    Parameter.Clear();
                    Parameter.Add("@MACHINE_UNIQUE_NUMBER", id.ToString());
                    ExecuteNonQuery(Parameter, Query);

                }
                #endregion

                #region Update in Tbl_CardholderwiseMember

                foreach (Other o1 in ((BL_RATION_CARD_ENTRY)classObject).OtherMembers)
                {
                    #region for existing entry
                    if (o1._IS_NEW_DB.ToUpper() == "DB")
                    {
                        Query = @"Update Tbl_CardholderwiseMember set 
                                Machine_Unique_Number=@Machine_Unique_Number, Gender=@Gender, E_Salutation=@E_Salutation, E_M_Fname=@E_M_Fname, E_M_Mname=@E_M_Mname, E_M_Lname=@E_M_Lname, M_Salutation=@M_Salutation, M_M_Fname=@M_M_Fname, M_M_Mname=@M_M_Mname, M_M_Lname=@M_M_Lname, 
                                Finger=@Finger, Member_Flag=@Member_Flag, Isregister=@Isregister, Card_Unique_Number=@Card_Unique_Number, Adhar_Number=@Adhar_Number, Age=@Age, LImage=@LImage, RImage=@RImage,isverify=@isverify
                                where State_id=@State_id and District_id=@District_id and Taluka_id=@Taluka_id and Village_id=@Village_id and  Shop_id=@Shop_id and Cardholder_id=@Cardholder_id and Cardmember_id=@Cardmember_id";
                        Parameter.Clear();

                        Parameter.Add("@Machine_Unique_Number", Machine_Unique_Number(((BL_RATION_CARD_ENTRY)classObject).STATE_ID,
                                ((BL_RATION_CARD_ENTRY)classObject).DISTRICT_ID,
                                ((BL_RATION_CARD_ENTRY)classObject).TALUKA_ID,
                            ((BL_RATION_CARD_ENTRY)classObject).VILLAGE_ID,
                            ((BL_RATION_CARD_ENTRY)classObject).SHOP_ID,
                            ((BL_RATION_CARD_ENTRY)classObject).CARDHOLDER_ID, o1._CARDMEMEBER_ID));
                        Parameter.Add("@Gender", o1._GENDER.ToString());
                        Parameter.Add("@E_Salutation", o1._E_SALUTATION.ToString());
                        Parameter.Add("@E_M_Fname", o1._E_FNAME.ToString());
                        Parameter.Add("@E_M_Mname", o1._E_MNAME.ToString());
                        Parameter.Add("@E_M_Lname", o1._E_LNAME.ToString());
                        Parameter.Add("@M_Salutation", o1._M_SALUTATION.ToString());
                        Parameter.Add("@M_M_Fname", o1._M_FNAME.ToString());
                        Parameter.Add("@M_M_Mname", o1._M_MNAME.ToString());
                        Parameter.Add("@M_M_Lname", o1._M_LNAME.ToString());
                        Parameter.Add("@Finger", "-");
                        Parameter.Add("@Member_Flag", "O");
                        Parameter.Add("@Isregister", "0");
                        Parameter.Add("@Card_Unique_Number", Card_Unique_Number(((BL_RATION_CARD_ENTRY)classObject).STATE_ID,
                            ((BL_RATION_CARD_ENTRY)classObject).DISTRICT_ID,
                            ((BL_RATION_CARD_ENTRY)classObject).TALUKA_ID,
                        ((BL_RATION_CARD_ENTRY)classObject).VILLAGE_ID,
                        ((BL_RATION_CARD_ENTRY)classObject).SHOP_ID,
                        o1._CARDMEMEBER_ID));
                        Parameter.Add("@Adhar_Number", o1._AADHAR_NUMBER.ToString());
                        Parameter.Add("@Age", o1._AGE.ToString());
                        Parameter.Add("@LImage", DBNull.Value.ToString());
                        Parameter.Add("@RImage", DBNull.Value.ToString());
                        Parameter.Add("@Isverify", "0");


                        Parameter.Add("@State_id", ((BL_RATION_CARD_ENTRY)classObject).STATE_ID.ToString());
                        Parameter.Add("@District_id", ((BL_RATION_CARD_ENTRY)classObject).DISTRICT_ID.ToString());
                        Parameter.Add("@Taluka_id", ((BL_RATION_CARD_ENTRY)classObject).TALUKA_ID.ToString());
                        Parameter.Add("@Village_id", ((BL_RATION_CARD_ENTRY)classObject).VILLAGE_ID.ToString());
                        Parameter.Add("@Shop_id", ((BL_RATION_CARD_ENTRY)classObject).SHOP_ID.ToString());
                        Parameter.Add("@Cardholder_id", ((BL_RATION_CARD_ENTRY)classObject).CARDHOLDER_ID.ToString());
                        Parameter.Add("@Cardmember_id", o1._CARDMEMEBER_ID.ToString());

                        ExecuteNonQuery(Parameter, Query);
                    }
                    #endregion
                    #region for New entry
                    if (o1._IS_NEW_DB.ToUpper() == "NEW")
                    {
                        #region maxid for Tbl_CardHolderWiseMember
                        int maxid1 = 0;
                        Query = "select max(Cardmember_id) from Tbl_CardHolderWiseMember where State_id=@State_id and District_id=@District_id and Taluka_id=@Taluka_id and Village_id=@Village_id and Shop_id=@Shop_id and Cardholder_id=@Cardhold_id";
                        Parameter.Clear();
                        Parameter.Add("@State_id ", ((BL_RATION_CARD_ENTRY)classObject).STATE_ID.ToString());
                        Parameter.Add("@District_id", ((BL_RATION_CARD_ENTRY)classObject).DISTRICT_ID.ToString());
                        Parameter.Add("@Taluka_id", ((BL_RATION_CARD_ENTRY)classObject).TALUKA_ID.ToString());
                        Parameter.Add("@Village_id", ((BL_RATION_CARD_ENTRY)classObject).VILLAGE_ID.ToString());
                        Parameter.Add("@Shop_id", ((BL_RATION_CARD_ENTRY)classObject).SHOP_ID.ToString());
                        Parameter.Add("@Cardhold_id", ((BL_RATION_CARD_ENTRY)classObject).CARDHOLDER_ID.ToString());

                        string ds = ExecuteScaler(Parameter, Query);
                        //if (ds.Tables.Count >= 1 && ds.Tables[0].Rows.Count >= 1)
                        //maxid = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString());
                        maxid1 = Convert.ToInt32(ds.Trim() == "" ? "0" : ds);
                        maxid1 += 1;

                        #endregion

                        #region
                        Query = @"insert into Tbl_CardholderwiseMember values(@Cardmember_id, @Cardholder_id, @State_id, @District_id, @Taluka_id, @Village_id, @Shop_id, @Machine_Unique_Number, @Gender, @E_Salutation, @E_M_Fname, @E_M_Mname, @E_M_Lname, @M_Salutation, @M_M_Fname, @M_M_Mname, @M_M_Lname, @Finger, @Member_Flag, @Isregister, @Card_Unique_Number, @Adhar_Number, @Age, @LImage, @RImage,@isverify);";
                        Parameter.Clear();

                        Parameter.Add("@Cardmember_id", maxid1.ToString());
                        Parameter.Add("@Cardholder_id", ((BL_RATION_CARD_ENTRY)classObject).CARDHOLDER_ID.ToString());
                        Parameter.Add("@State_id", ((BL_RATION_CARD_ENTRY)classObject).STATE_ID.ToString());
                        Parameter.Add("@District_id", ((BL_RATION_CARD_ENTRY)classObject).DISTRICT_ID.ToString());
                        Parameter.Add("@Taluka_id", ((BL_RATION_CARD_ENTRY)classObject).TALUKA_ID.ToString());
                        Parameter.Add("@Village_id", ((BL_RATION_CARD_ENTRY)classObject).VILLAGE_ID.ToString());
                        Parameter.Add("@Shop_id", ((BL_RATION_CARD_ENTRY)classObject).SHOP_ID.ToString());
                        Parameter.Add("@Machine_Unique_Number", Machine_Unique_Number(((BL_RATION_CARD_ENTRY)classObject).STATE_ID,
                            ((BL_RATION_CARD_ENTRY)classObject).DISTRICT_ID,
                            ((BL_RATION_CARD_ENTRY)classObject).TALUKA_ID,
                        ((BL_RATION_CARD_ENTRY)classObject).VILLAGE_ID,
                        ((BL_RATION_CARD_ENTRY)classObject).SHOP_ID,
                        ((BL_RATION_CARD_ENTRY)classObject).CARDHOLDER_ID, maxid1));
                        Parameter.Add("@Gender", o1._GENDER.ToString());
                        Parameter.Add("@E_Salutation", o1._E_SALUTATION.ToString());
                        Parameter.Add("@E_M_Fname", o1._E_FNAME.ToString());
                        Parameter.Add("@E_M_Mname", o1._E_MNAME.ToString());
                        Parameter.Add("@E_M_Lname", o1._E_LNAME.ToString());
                        Parameter.Add("@M_Salutation", o1._M_SALUTATION.ToString());
                        Parameter.Add("@M_M_Fname", o1._M_FNAME.ToString());
                        Parameter.Add("@M_M_Mname", o1._M_MNAME.ToString());
                        Parameter.Add("@M_M_Lname", o1._M_LNAME.ToString());
                        Parameter.Add("@Finger", "-");
                        Parameter.Add("@Member_Flag", "O");
                        Parameter.Add("@Isregister", "0");
                        Parameter.Add("@Card_Unique_Number", Card_Unique_Number(((BL_RATION_CARD_ENTRY)classObject).STATE_ID,
                            ((BL_RATION_CARD_ENTRY)classObject).DISTRICT_ID,
                            ((BL_RATION_CARD_ENTRY)classObject).TALUKA_ID,
                        ((BL_RATION_CARD_ENTRY)classObject).VILLAGE_ID,
                        ((BL_RATION_CARD_ENTRY)classObject).SHOP_ID,
                        ((BL_RATION_CARD_ENTRY)classObject).CARDHOLDER_ID));
                        Parameter.Add("@Adhar_Number", o1._AADHAR_NUMBER.ToString());
                        Parameter.Add("@Age", o1._AGE.ToString());
                        Parameter.Add("@LImage", DBNull.Value.ToString());
                        Parameter.Add("@RImage", DBNull.Value.ToString());
                        Parameter.Add("@Isverify", "0");

                        ExecuteNonQuery(Parameter, Query);
                        #endregion
                    }
                    #endregion

                }
                #endregion

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


        public DataSet VERIFY(object classObject)
        {
            try
            {
                #region Update in Tbl_CardholderMaster
                Query = @"Update Tbl_CardholderMaster set isverify='1' where State_id=@State_id and District_id=@District_id and Taluka_id=@Taluka_id and Village_id=@Village_id and  Shop_id=@Shop_id and Cardholder_id=@Cardholder_id";
                Parameter.Clear();

                Parameter.Add("@State_id", ((BL_RATION_CARD_ENTRY)classObject).STATE_ID.ToString());
                Parameter.Add("@District_id", ((BL_RATION_CARD_ENTRY)classObject).DISTRICT_ID.ToString());
                Parameter.Add("@Taluka_id", ((BL_RATION_CARD_ENTRY)classObject).TALUKA_ID.ToString());
                Parameter.Add("@Village_id", ((BL_RATION_CARD_ENTRY)classObject).VILLAGE_ID.ToString());
                Parameter.Add("@Shop_id", ((BL_RATION_CARD_ENTRY)classObject).SHOP_ID.ToString());
                Parameter.Add("@Cardholder_id", ((BL_RATION_CARD_ENTRY)classObject).CARDHOLDER_ID.ToString());

                ExecuteNonQuery(Parameter, Query);
                #endregion
                #region Update in Tbl_CardholderwiseMember
                Query = @"Update Tbl_CardholderwiseMember set isverify='1'  where State_id=@State_id and District_id=@District_id and Taluka_id=@Taluka_id and Village_id=@Village_id and  Shop_id=@Shop_id and Cardholder_id=@Cardholder_id";
                Parameter.Clear();

                Parameter.Add("@State_id", ((BL_RATION_CARD_ENTRY)classObject).STATE_ID.ToString());
                Parameter.Add("@District_id", ((BL_RATION_CARD_ENTRY)classObject).DISTRICT_ID.ToString());
                Parameter.Add("@Taluka_id", ((BL_RATION_CARD_ENTRY)classObject).TALUKA_ID.ToString());
                Parameter.Add("@Village_id", ((BL_RATION_CARD_ENTRY)classObject).VILLAGE_ID.ToString());
                Parameter.Add("@Shop_id", ((BL_RATION_CARD_ENTRY)classObject).SHOP_ID.ToString());
                Parameter.Add("@Cardholder_id", ((BL_RATION_CARD_ENTRY)classObject).CARDHOLDER_ID.ToString());

                ExecuteNonQuery(Parameter, Query);
                #endregion
                return SELECT(classObject);
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

        public DataSet UPDATE_PERSON_UNIT(object classObject)
        {
            try
            {
                #region Update in Tbl_CardholderMaster
                Query = @"Update Tbl_CardholderMaster set Total_Person=@Total_Person, Total_Unit=@Total_Unit where State_id=@State_id and District_id=@District_id and Taluka_id=@Taluka_id and Village_id=@Village_id and  Shop_id=@Shop_id and Cardholder_id=@Cardholder_id";
                Parameter.Clear();

                Parameter.Add("@Total_Person", ((BL_RATION_CARD_ENTRY)classObject).TOTAL_PERSON.ToString());
                Parameter.Add("@Total_Unit", ((BL_RATION_CARD_ENTRY)classObject).TOTAL_UNIT.ToString());
                Parameter.Add("@State_id", ((BL_RATION_CARD_ENTRY)classObject).STATE_ID.ToString());
                Parameter.Add("@District_id", ((BL_RATION_CARD_ENTRY)classObject).DISTRICT_ID.ToString());
                Parameter.Add("@Taluka_id", ((BL_RATION_CARD_ENTRY)classObject).TALUKA_ID.ToString());
                Parameter.Add("@Village_id", ((BL_RATION_CARD_ENTRY)classObject).VILLAGE_ID.ToString());
                Parameter.Add("@Shop_id", ((BL_RATION_CARD_ENTRY)classObject).SHOP_ID.ToString());
                Parameter.Add("@Cardholder_id", ((BL_RATION_CARD_ENTRY)classObject).CARDHOLDER_ID.ToString());

                ExecuteNonQuery(Parameter, Query);
                #endregion

                return SELECT_FOR_OTHER(classObject);
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

        public BL_RATION_CARD_ENTRY FILLRECORD(object classObject)
        {
            BL_RATION_CARD_ENTRY bl_Obj = new BL_RATION_CARD_ENTRY();
            DataSet ds = new DataSet();
            Parameter.Clear();
            Parameter.Add("@State_id", ((BL_RATION_CARD_ENTRY)classObject).STATE_ID.ToString());
            Parameter.Add("@District_id", ((BL_RATION_CARD_ENTRY)classObject).DISTRICT_ID.ToString());
            Parameter.Add("@Taluka_id", ((BL_RATION_CARD_ENTRY)classObject).TALUKA_ID.ToString());
            Parameter.Add("@Village_id", ((BL_RATION_CARD_ENTRY)classObject).VILLAGE_ID.ToString());
            Parameter.Add("@Shop_id", ((BL_RATION_CARD_ENTRY)classObject).SHOP_ID.ToString());
            Parameter.Add("@Cardholder_id", ((BL_RATION_CARD_ENTRY)classObject).CARDHOLDER_ID.ToString());

            Query = @"SELECT * FROM Tbl_CardholderMaster
                      where State_id=@State_id and District_id=@District_id and Taluka_id=@Taluka_id and Village_id=@Village_id and  Shop_id=@Shop_id and Cardholder_id=@Cardholder_id and IsVerify='0'
                      order by State_id, District_id, Taluka_id, Village_id, Shop_id,Cardholder_id";

            DataTable dt = ExecuteQuery(Parameter, Query).Tables[0].Copy();
            dt.TableName = "Master";
            bl_Obj.CARDHOLDER_ID = Convert.ToInt32(dt.Rows[0]["Cardholder_id"].ToString());
            bl_Obj.STATE_ID = Convert.ToInt32(dt.Rows[0]["State_id"].ToString());
            bl_Obj.DISTRICT_ID = Convert.ToInt32(dt.Rows[0]["District_id"].ToString());
            bl_Obj.TALUKA_ID = Convert.ToInt32(dt.Rows[0]["Taluka_id"].ToString());
            bl_Obj.VILLAGE_ID = Convert.ToInt32(dt.Rows[0]["Village_id"].ToString());
            bl_Obj.SHOP_ID = Convert.ToInt32(dt.Rows[0]["Shop_id"].ToString());
            bl_Obj.CARDTYPE_ID = Convert.ToInt32(dt.Rows[0]["CardType_id"].ToString());
            bl_Obj.CARD_REFERENCE_NUMBER = dt.Rows[0]["Card_Reference_Number"].ToString();
            bl_Obj.GENDER = dt.Rows[0]["Gender"].ToString();
            bl_Obj.E_SALUTATION = dt.Rows[0]["E_Salutation"].ToString();
            bl_Obj.E_FNAME = dt.Rows[0]["E_Fname"].ToString();
            bl_Obj.E_MNAME = dt.Rows[0]["E_Mname"].ToString();
            bl_Obj.E_LNAME = dt.Rows[0]["E_Lname"].ToString();
            bl_Obj.M_SALUTATION = dt.Rows[0]["M_Salutation"].ToString();
            bl_Obj.M_FNAME = dt.Rows[0]["M_Fname"].ToString();
            bl_Obj.M_MNAME = dt.Rows[0]["M_Mname"].ToString();
            bl_Obj.M_LNAME = dt.Rows[0]["M_Lname"].ToString();
            bl_Obj.TOTAL_UNIT = Convert.ToInt32(dt.Rows[0]["Total_Unit"].ToString());
            bl_Obj.TOTAL_PERSON = Convert.ToInt32(dt.Rows[0]["Total_Person"].ToString());
            bl_Obj.RATION_CARD_NUMBER = dt.Rows[0]["Ration_Card_Number"].ToString();
            bl_Obj.BANK_ID = Convert.ToInt32(dt.Rows[0]["Bank_id"].ToString());
            bl_Obj.BANK_ACCOUNT_NUMBER = dt.Rows[0]["Bank_Account_Number"].ToString();
            bl_Obj.CARD_UNIQUE_NUMBER = dt.Rows[0]["Card_Unique_Number"].ToString();
            bl_Obj.ISGAS = dt.Rows[0]["Isgas"].ToString();
            bl_Obj.GAS_QTY = Convert.ToInt32(dt.Rows[0]["Gas_Qty"].ToString());



            Query = @"SELECT * FROM Tbl_CardholderwiseMember
                      where State_id=@State_id and District_id=@District_id and Taluka_id=@Taluka_id and Village_id=@Village_id and  Shop_id=@Shop_id and Cardholder_id=@Cardholder_id 
                      order by State_id, District_id, Taluka_id, Village_id, Shop_id,Cardholder_id,Cardmember_id";
            dt = ExecuteQuery(Parameter, Query).Tables[0].Copy();
            dt.TableName = "Member";

            bl_Obj.OtherMembers.Clear();
            if (dt.Rows.Count >= 1)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr["Member_Flag"].ToString() == "O")
                    {//E_Salutation, E_M_Fname, E_M_Mname, E_M_Lname, M_Salutation, M_M_Fname, M_M_Mname, M_M_Lname, Finger, Member_Flag, Isregister, Card_Unique_Number, Adhar_Number, Age, LImage, RImage, IsVerify
                        bl_Obj.o._CARDMEMEBER_ID = Convert.ToInt32(dr["Cardmember_id"].ToString());
                        bl_Obj.o._E_SALUTATION = dr["E_Salutation"].ToString();
                        bl_Obj.o._E_FNAME = dr["E_M_Fname"].ToString();
                        bl_Obj.o._E_MNAME = dr["E_M_Mname"].ToString();
                        bl_Obj.o._E_LNAME = dr["E_M_Lname"].ToString();
                        bl_Obj.o._M_SALUTATION = dr["M_Salutation"].ToString();
                        bl_Obj.o._M_FNAME = dr["M_M_Fname"].ToString();
                        bl_Obj.o._M_MNAME = dr["M_M_Mname"].ToString();
                        bl_Obj.o._M_LNAME = dr["M_M_Lname"].ToString();
                        bl_Obj.o._AGE = Convert.ToInt32(dr["Age"].ToString());
                        bl_Obj.o._AADHAR_NUMBER = "0";
                        bl_Obj.o._Member_Flag = dr["Member_Flag"].ToString();
                        bl_Obj.o._MAchineUniqueID = dr["MACHINE_UNIQUE_NUMBER"].ToString();
                        bl_Obj.o._IsRegister = dr["ISREGISTER"].ToString();
                        bl_Obj.OtherMembers.Add(bl_Obj.o);
                    }
                    else
                    {
                        bl_Obj.AGE = Convert.ToInt32(dr["Age"].ToString());
                    }
                }
            }
            return bl_Obj;
        }
        private string Card_Unique_Number(int State_id, int District_id, int Taluka_id, int Village_id, int Shop_id, int Cardholder_id)
        {
            return State_id.ToString().PadLeft(2, '0') + "" +
            District_id.ToString().PadLeft(2, '0') + "" +
            Taluka_id.ToString().PadLeft(2, '0') + "" +
            Village_id.ToString().PadLeft(4, '0') + "" +
            Shop_id.ToString().PadLeft(4, '0') + "" +
            Cardholder_id.ToString().PadLeft(4, '0');
        }
        private string Machine_Unique_Number(int State_id, int District_id, int Taluka_id, int Village_id, int Shop_id, int Cardholder_id, int Cardmemeber_id)
        {
            return State_id.ToString().PadLeft(2, '0') + "" +
            District_id.ToString().PadLeft(2, '0') + "" +
            Taluka_id.ToString().PadLeft(2, '0') + "" +
            Village_id.ToString().PadLeft(4, '0') + "" +
            Shop_id.ToString().PadLeft(4, '0') + "" +
            Cardholder_id.ToString().PadLeft(4, '0') + "" +
            Cardmemeber_id.ToString().PadLeft(3, '0');
        }

        public DataSet FILLCOMBO(int? State_ID, int? District_ID, int? Taluka_ID, int? Village_ID)
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            if (State_ID == null)
                dt = ExecuteQuery("SELECT District_id,District_Name FROM Tbl_DistrictMaster;").Tables[0].Copy();
            else
                dt = ExecuteQuery("SELECT District_id,District_Name FROM Tbl_DistrictMaster where state_id=" + State_ID + ";").Tables[0].Copy();

            dt.TableName = "DISTRICTMASTER";
            ds.Tables.Add(dt);
            if (State_ID == null & DISTRICT_ID == null)
                dt = ExecuteQuery("SELECT Taluka_id,Taluka_Name FROM Tbl_TalukaMaster;").Tables[0].Copy();
            else
                dt = ExecuteQuery("SELECT Taluka_id,Taluka_Name FROM Tbl_TalukaMaster where state_id=" + State_ID + " and district_id=" + DISTRICT_ID + ";").Tables[0].Copy();
            dt.TableName = "TALUKAMASTER";
            ds.Tables.Add(dt);
            if (State_ID == null & DISTRICT_ID == null & TALUKA_ID == null)
                dt = ExecuteQuery("SELECT Village_id,Village_Name FROM Tbl_VillageMaster;").Tables[0].Copy();
            else
                dt = ExecuteQuery("SELECT Village_id,Village_Name FROM Tbl_VillageMaster where state_id=" + State_ID + " and district_id=" + DISTRICT_ID + " and taluka_id=" + TALUKA_ID + ";").Tables[0].Copy();
            dt.TableName = "VILLAGEMASTER";
            ds.Tables.Add(dt);
            if (State_ID == null & DISTRICT_ID == null & TALUKA_ID == null & Village_ID == null)
                dt = ExecuteQuery("SELECT Shop_id,Shop_Name FROM Tbl_ShopMaster;").Tables[0].Copy();
            else
                dt = ExecuteQuery("SELECT Shop_id,Shop_Name FROM Tbl_ShopMaster where state_id=" + State_ID + " and district_id=" + DISTRICT_ID + " and taluka_id=" + TALUKA_ID + " and village_id=" + Village_ID + ";").Tables[0].Copy();
            dt.TableName = "SHOPMASTER";
            ds.Tables.Add(dt);
            return ds;
        }
        public DataSet SELECT_FOR_OTHER(object classObject)
        {

            DataSet ds = new DataSet();

            DataTable dt = ExecuteQuery("SELECT District_id,District_Name FROM Tbl_DistrictMaster;").Tables[0].Copy();
            dt.TableName = "DISTRICTMASTER";
            ds.Tables.Add(dt);
            dt = ExecuteQuery("SELECT Taluka_id,Taluka_Name FROM Tbl_TalukaMaster;").Tables[0].Copy();
            dt.TableName = "TALUKAMASTER";
            ds.Tables.Add(dt);
            dt = ExecuteQuery("SELECT Village_id,Village_Name FROM Tbl_VillageMaster;").Tables[0].Copy();
            dt.TableName = "VILLAGEMASTER";
            ds.Tables.Add(dt);
            dt = ExecuteQuery("SELECT Shop_id,Shop_Name FROM Tbl_ShopMaster;").Tables[0].Copy();
            dt.TableName = "SHOPMASTER";
            ds.Tables.Add(dt);

            dt = ExecuteQuery("SELECT CardType_id, M_CardType_Name FROM Tbl_CardTypeMaster;").Tables[0].Copy();
            dt.TableName = "CARDTYPEMASTER";
            ds.Tables.Add(dt);

            //dt = ExecuteQuery("SELECT * FROM Tbl_CardholderMaster;").Tables[0].Copy();
            //dt.TableName = "CARDHOLDERMASTER";
            //ds.Tables.Add(dt);

            Parameter.Clear();
            Parameter.Add("@State_id", ((BL_RATION_CARD_ENTRY)classObject).STATE_ID.ToString());
            Parameter.Add("@District_id", ((BL_RATION_CARD_ENTRY)classObject).DISTRICT_ID.ToString());
            Parameter.Add("@Taluka_id", ((BL_RATION_CARD_ENTRY)classObject).TALUKA_ID.ToString());
            Parameter.Add("@Village_id", ((BL_RATION_CARD_ENTRY)classObject).VILLAGE_ID.ToString());
            Parameter.Add("@Shop_id", ((BL_RATION_CARD_ENTRY)classObject).SHOP_ID.ToString());
            Query = @"SELECT Cardholder_id, State_id, District_id, Taluka_id, Village_id, Shop_id, Card_Reference_Number, E_Salutation, E_Fname, E_Mname, E_Lname
                      FROM Tbl_CardholderMaster
                      where State_id=@State_id and District_id=@District_id and Taluka_id=@Taluka_id and Village_id=@Village_id and  Shop_id=@Shop_id and Total_Person=0
                      order by State_id, District_id, Taluka_id, Village_id, Shop_id,Cardholder_id desc
                      ";

            dt = ExecuteQuery(Parameter, Query).Tables[0].Copy();
            DataColumn dc = new DataColumn("SHOW", typeof(System.String));
            dt.Columns.Add(dc);
            dc.SetOrdinal(1);

            //dt.Columns.Add(new DataColumn("SHOW", typeof(System.String)));
            foreach (DataRow dr in dt.Rows)
                dr["SHOW"] = dr["E_Salutation"].ToString() + " " + dr["E_Fname"].ToString() + " " + dr["E_Mname"].ToString() + " " + dr["E_Lname"].ToString();
            dt.AcceptChanges();
            dt.TableName = "NOT VERIFY Cards";
            ds.Tables.Add(dt);

            Parameter.Clear();
            Parameter.Add("@State_id", ((BL_RATION_CARD_ENTRY)classObject).STATE_ID.ToString());
            Parameter.Add("@District_id", ((BL_RATION_CARD_ENTRY)classObject).DISTRICT_ID.ToString());
            Parameter.Add("@Taluka_id", ((BL_RATION_CARD_ENTRY)classObject).TALUKA_ID.ToString());
            Parameter.Add("@Village_id", ((BL_RATION_CARD_ENTRY)classObject).VILLAGE_ID.ToString());
            Parameter.Add("@Shop_id", ((BL_RATION_CARD_ENTRY)classObject).SHOP_ID.ToString());
            Query = @"SELECT Cardholder_id, State_id, District_id, Taluka_id, Village_id, Shop_id, Card_Reference_Number, E_Salutation, E_Fname, E_Mname, E_Lname
                      FROM Tbl_CardholderMaster
                      where State_id=@State_id and District_id=@District_id and Taluka_id=@Taluka_id and Village_id=@Village_id and  Shop_id=@Shop_id and Total_Person>0
                      order by State_id, District_id, Taluka_id, Village_id, Shop_id,Cardholder_id desc
                      ";

            dt = ExecuteQuery(Parameter, Query).Tables[0].Copy();
            dc = new DataColumn("SHOW", typeof(System.String));
            dt.Columns.Add(dc);
            dc.SetOrdinal(1);

            //dt.Columns.Add(new DataColumn("SHOW", typeof(System.String)));
            foreach (DataRow dr in dt.Rows)
                dr["SHOW"] = dr["E_Salutation"].ToString() + " " + dr["E_Fname"].ToString() + " " + dr["E_Mname"].ToString() + " " + dr["E_Lname"].ToString();
            dt.AcceptChanges();
            dt.TableName = "VERIFY Cards";
            ds.Tables.Add(dt);

            return ds;
        }
        public BL_RATION_CARD_ENTRY FILLRECORD(object classObject, bool For_1_or_2)
        {
            BL_RATION_CARD_ENTRY bl_Obj = new BL_RATION_CARD_ENTRY();
            DataSet ds = new DataSet();
            Parameter.Clear();
            Parameter.Add("@State_id", ((BL_RATION_CARD_ENTRY)classObject).STATE_ID.ToString());
            Parameter.Add("@District_id", ((BL_RATION_CARD_ENTRY)classObject).DISTRICT_ID.ToString());
            Parameter.Add("@Taluka_id", ((BL_RATION_CARD_ENTRY)classObject).TALUKA_ID.ToString());
            Parameter.Add("@Village_id", ((BL_RATION_CARD_ENTRY)classObject).VILLAGE_ID.ToString());
            Parameter.Add("@Shop_id", ((BL_RATION_CARD_ENTRY)classObject).SHOP_ID.ToString());
            Parameter.Add("@Cardholder_id", ((BL_RATION_CARD_ENTRY)classObject).CARDHOLDER_ID.ToString());

            if (!For_1_or_2)
                Query = @"SELECT * FROM Tbl_CardholderMaster
                      where State_id=@State_id and District_id=@District_id and Taluka_id=@Taluka_id and Village_id=@Village_id and  Shop_id=@Shop_id and Cardholder_id=@Cardholder_id and isverify='0'
                      order by State_id, District_id, Taluka_id, Village_id, Shop_id,Cardholder_id";
            if (For_1_or_2)
                Query = @"SELECT * FROM Tbl_CardholderMaster
                      where State_id=@State_id and District_id=@District_id and Taluka_id=@Taluka_id and Village_id=@Village_id and  Shop_id=@Shop_id and Cardholder_id=@Cardholder_id and isverify='1'
                      order by State_id, District_id, Taluka_id, Village_id, Shop_id,Cardholder_id";

            DataTable dt = ExecuteQuery(Parameter, Query).Tables[0].Copy();
            dt.TableName = "Master";
            bl_Obj.CARDHOLDER_ID = Convert.ToInt32(dt.Rows[0]["Cardholder_id"].ToString());
            bl_Obj.STATE_ID = Convert.ToInt32(dt.Rows[0]["State_id"].ToString());
            bl_Obj.DISTRICT_ID = Convert.ToInt32(dt.Rows[0]["District_id"].ToString());
            bl_Obj.TALUKA_ID = Convert.ToInt32(dt.Rows[0]["Taluka_id"].ToString());
            bl_Obj.VILLAGE_ID = Convert.ToInt32(dt.Rows[0]["Village_id"].ToString());
            bl_Obj.SHOP_ID = Convert.ToInt32(dt.Rows[0]["Shop_id"].ToString());
            bl_Obj.CARDTYPE_ID = Convert.ToInt32(dt.Rows[0]["CardType_id"].ToString());
            bl_Obj.CARD_REFERENCE_NUMBER = dt.Rows[0]["Card_Reference_Number"].ToString();
            bl_Obj.GENDER = dt.Rows[0]["Gender"].ToString();
            bl_Obj.E_SALUTATION = dt.Rows[0]["E_Salutation"].ToString();
            bl_Obj.E_FNAME = dt.Rows[0]["E_Fname"].ToString();
            bl_Obj.E_MNAME = dt.Rows[0]["E_Mname"].ToString();
            bl_Obj.E_LNAME = dt.Rows[0]["E_Lname"].ToString();
            bl_Obj.M_SALUTATION = dt.Rows[0]["M_Salutation"].ToString();
            bl_Obj.M_FNAME = dt.Rows[0]["M_Fname"].ToString();
            bl_Obj.M_MNAME = dt.Rows[0]["M_Mname"].ToString();
            bl_Obj.M_LNAME = dt.Rows[0]["M_Lname"].ToString();
            bl_Obj.TOTAL_UNIT = Convert.ToInt32(dt.Rows[0]["Total_Unit"].ToString());
            bl_Obj.TOTAL_PERSON = Convert.ToInt32(dt.Rows[0]["Total_Person"].ToString());
            bl_Obj.RATION_CARD_NUMBER = dt.Rows[0]["Ration_Card_Number"].ToString();
            bl_Obj.BANK_ID = Convert.ToInt32(dt.Rows[0]["Bank_id"].ToString());
            bl_Obj.BANK_ACCOUNT_NUMBER = dt.Rows[0]["Bank_Account_Number"].ToString();
            bl_Obj.CARD_UNIQUE_NUMBER = dt.Rows[0]["Card_Unique_Number"].ToString();
            bl_Obj.ISGAS = dt.Rows[0]["Isgas"].ToString();
            bl_Obj.GAS_QTY = Convert.ToInt32(dt.Rows[0]["Gas_Qty"].ToString());



            Query = @"SELECT * FROM Tbl_CardholderwiseMember
                      where State_id=@State_id and District_id=@District_id and Taluka_id=@Taluka_id and Village_id=@Village_id and  Shop_id=@Shop_id and Cardholder_id=@Cardholder_id 
                      order by State_id, District_id, Taluka_id, Village_id, Shop_id,Cardholder_id,Cardmember_id";
            dt = ExecuteQuery(Parameter, Query).Tables[0].Copy();
            dt.TableName = "Member";

            bl_Obj.OtherMembers.Clear();
            if (dt.Rows.Count >= 1)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr["Member_Flag"].ToString() == "O")
                    {//E_Salutation, E_M_Fname, E_M_Mname, E_M_Lname, M_Salutation, M_M_Fname, M_M_Mname, M_M_Lname, Finger, Member_Flag, Isregister, Card_Unique_Number, Adhar_Number, Age, LImage, RImage, IsVerify
                        bl_Obj.o._CARDMEMEBER_ID = Convert.ToInt32(dr["Cardmember_id"].ToString());
                        bl_Obj.o._E_SALUTATION = dr["E_Salutation"].ToString();
                        bl_Obj.o._E_FNAME = dr["E_M_Fname"].ToString();
                        bl_Obj.o._E_MNAME = dr["E_M_Mname"].ToString();
                        bl_Obj.o._E_LNAME = dr["E_M_Lname"].ToString();
                        bl_Obj.o._M_SALUTATION = dr["M_Salutation"].ToString();
                        bl_Obj.o._M_FNAME = dr["M_M_Fname"].ToString();
                        bl_Obj.o._M_MNAME = dr["M_M_Mname"].ToString();
                        bl_Obj.o._M_LNAME = dr["M_M_Lname"].ToString();
                        bl_Obj.o._AGE = Convert.ToInt32(dr["Age"].ToString());
                        bl_Obj.o._AADHAR_NUMBER = "0";
                        bl_Obj.o._Member_Flag = dr["Member_Flag"].ToString();
                        bl_Obj.OtherMembers.Add(bl_Obj.o);
                    }
                    else
                    {
                        bl_Obj.AGE = Convert.ToInt32(dr["Age"].ToString());
                    }
                }
            }


            return bl_Obj;
        }
    }


}
