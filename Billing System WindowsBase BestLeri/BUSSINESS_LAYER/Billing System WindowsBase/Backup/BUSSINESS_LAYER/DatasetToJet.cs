using ADOX;
using ADODB;
using System;
using System.Data;
using System.Data.OleDb;
using System.Text;
using System.Windows.Forms;
using System.IO;
using ComponentFactory.Krypton.Toolkit;
namespace BUSSINESS_LAYER
{
    /// <summary>
    /// Summary description for DatasetToJet.
    /// </summary>
    public class DatasetToJet
    {
        public bool GetData(String strDirectory, DataSet dtt)
        {
            OleDbConnection sceConnection = null;
            Catalog cat = new Catalog();
            bool ret = false;
            try
            {
                if (!File.Exists(strDirectory))
                {

                    // UpdateProgress("");
                    string str = "provider=Microsoft.Jet.OleDb.4.0;Data Source=" + strDirectory;
                    cat.Create(str);
                    cat = null;
                    sceConnection = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + strDirectory);
                    sceConnection.Open();
                    OleDbCommand sceCreateTableCommand1;

                    string strCreateTableQuery1 = @"
CREATE TABLE Tbl_GroupMaster(
	Group_id Integer NOT NULL,
	Group_Name text(50) NOT NULL,
 PRIMARY KEY  
(
	Group_id 
));
";
                    sceCreateTableCommand1 = new OleDbCommand(strCreateTableQuery1, sceConnection);
                    sceCreateTableCommand1.ExecuteNonQuery();
                    strCreateTableQuery1 = @"
CREATE TABLE Tbl_AreaMaster(
	Area_id Integer NOT NULL,
	Area_Specification text(100) NOT NULL,
 PRIMARY KEY  
(
	Area_id 
));

";
                    sceCreateTableCommand1 = new OleDbCommand(strCreateTableQuery1, sceConnection);
                    sceCreateTableCommand1.ExecuteNonQuery();
                    strCreateTableQuery1 = @"
CREATE TABLE Tbl_BankMaster(
	Bank_id Integer NOT NULL,
	Bank_Code text(4) NOT NULL,
	Bank_Name text(50) NOT NULL,
PRIMARY KEY  
(
	Bank_id 
));

";
                    sceCreateTableCommand1 = new OleDbCommand(strCreateTableQuery1, sceConnection);
                    sceCreateTableCommand1.ExecuteNonQuery();
                    strCreateTableQuery1 = @"

CREATE TABLE Tbl_StateMaster(
	State_id Integer NOT NULL,
	State_Code text(4) NOT NULL,
	State_Name text(50) NOT NULL,
 PRIMARY KEY  
(
	State_id 
));

";
                    sceCreateTableCommand1 = new OleDbCommand(strCreateTableQuery1, sceConnection);
                    sceCreateTableCommand1.ExecuteNonQuery();
                    strCreateTableQuery1 = @"

CREATE TABLE Tbl_DistrictMaster(
	District_id Integer NOT NULL,
	District_Code text(4) NOT NULL,
	District_Name text(50) NOT NULL,
	State_id Integer NOT NULL,
 PRIMARY KEY  
(
	District_id ,
	District_Code ,
	State_id 
));
";
                    sceCreateTableCommand1 = new OleDbCommand(strCreateTableQuery1, sceConnection);
                    sceCreateTableCommand1.ExecuteNonQuery();
                    strCreateTableQuery1 = @"

CREATE TABLE Tbl_TalukaMaster(
	Taluka_id Integer NOT NULL,
	Taluka_Code text(4) NOT NULL,
	Taluka_Name text(50) NOT NULL,
	District_id Integer NOT NULL,
	State_id Integer NOT NULL,
 PRIMARY KEY  
(
	Taluka_id ,
	District_id ,
	State_id 
));

";
                    sceCreateTableCommand1 = new OleDbCommand(strCreateTableQuery1, sceConnection);
                    sceCreateTableCommand1.ExecuteNonQuery();
                    strCreateTableQuery1 = @"
CREATE TABLE Tbl_VillageMaster(
	Village_id Integer NOT NULL,
	Village_Code text(4) NOT NULL,
	Village_Name text(50) NOT NULL,
	Taluka_id Integer NOT NULL,
	District_id Integer NOT NULL,
	State_id Integer NOT NULL,
	Area_id Integer NOT NULL,
 PRIMARY KEY  
(
	Village_id ,
	Taluka_id ,
	District_id ,
	State_id 
));
";
                    sceCreateTableCommand1 = new OleDbCommand(strCreateTableQuery1, sceConnection);
                    sceCreateTableCommand1.ExecuteNonQuery();
                    strCreateTableQuery1 = @"

CREATE TABLE Tbl_ShopMaster(
	Shop_id Integer NOT NULL,
	Shop_Code text(50) NOT NULL,
	Shop_Name text(50) NOT NULL,
	Village_id Integer NOT NULL,
	Taluka_id Integer NOT NULL,
	District_id Integer NOT NULL,
	State_id Integer NOT NULL,
	Address memo NOT NULL,
	Contact_Number text(20) NULL,
	E_Salutation nchar(10) NOT NULL,
	E_Shop_Owner_Fname text(50) NOT NULL,
	E_Shop_Owner_Mname text(50) NOT NULL,
	E_Shop_Owner_Lname text(50) NOT NULL,
	M_Salutation nchar(10) NOT NULL,
	M_Shop_Owner_Fname text(50) NOT NULL,
	M_Shop_Owner_Mname text(50) NOT NULL,
	M_Shop_Owner_Lname text(50) NOT NULL,
	Licence_Number text(50) NOT NULL,
	Shop_cat_id Integer NOT NULL,
	Mobile_Number text(10) NULL,
	Email text(50) NULL,
	Device_Code text(50) NOT NULL,
	LImage memo NULL,
	RImage memo NULL,
 PRIMARY KEY  
(
	Shop_id ,
	Village_id ,
	Taluka_id ,
	District_id ,
	State_id 
));
";
                    sceCreateTableCommand1 = new OleDbCommand(strCreateTableQuery1, sceConnection);
                    sceCreateTableCommand1.ExecuteNonQuery();
                    strCreateTableQuery1 = @"

CREATE TABLE Tbl_ShopCategoryMaster(
	Shop_Cat_id Integer NOT NULL,
	Shop_Cat_Code text(50) NOT NULL,
	Shop_Cat_Name text(50) NOT NULL,
	
 PRIMARY KEY  
(
	Shop_Cat_id 
));

";
                    sceCreateTableCommand1 = new OleDbCommand(strCreateTableQuery1, sceConnection);
                    sceCreateTableCommand1.ExecuteNonQuery();
                    strCreateTableQuery1 = @"

CREATE TABLE Tbl_CardTypeMaster(
	CardType_id Integer NOT NULL,
	E_CardType_Name text(50) NOT NULL,
	M_CardType_Name text(50) NULL,
	
	
	
	
	
 PRIMARY KEY  
(
	CardType_id 
));

";
                    sceCreateTableCommand1 = new OleDbCommand(strCreateTableQuery1, sceConnection);
                    sceCreateTableCommand1.ExecuteNonQuery();
                    strCreateTableQuery1 = @"



CREATE TABLE Tbl_CardholderMaster(
	Cardholder_id Integer NOT NULL,
	State_id Integer NOT NULL,
	District_id Integer NOT NULL,
	Taluka_id Integer NOT NULL,
	Village_id Integer NOT NULL,
	Shop_id Integer NOT NULL,
	CardType_id Integer NOT NULL,
	Card_Reference_Number text(50) NOT NULL,
	Gender char(10) NOT NULL,
	E_Salutation text(10) NOT NULL,
	E_Fname text(50) NOT NULL,
	E_Mname text(50) NOT NULL,
	E_Lname text(50) NOT NULL,
	M_Salutation text(10) NOT NULL,
	M_Fname text(50) NOT NULL,
	M_Mname text(50) NOT NULL,
	M_Lname text(50) NOT NULL,
	Total_Unit Integer NOT NULL,
	Total_Person Integer NOT NULL,
	Ration_Card_Number text(50) NOT NULL,
	Bank_id Integer NOT NULL,
	Bank_Account_Number text(50) NOT NULL,
	Card_Unique_Number text(21) NOT NULL,
	Isgas char(3) NULL,
	Gas_Qty Integer NULL,
	IsVerify Text,
	
	
	
	
 PRIMARY KEY  
(
	Cardholder_id ,
	State_id ,
	District_id ,
	Taluka_id ,
	Village_id ,
	Shop_id 
));
";
                    sceCreateTableCommand1 = new OleDbCommand(strCreateTableQuery1, sceConnection);
                    sceCreateTableCommand1.ExecuteNonQuery();
                    strCreateTableQuery1 = @"

CREATE TABLE Tbl_CardholderwiseMember(
	Cardmember_id Integer NOT NULL,
	Cardholder_id Integer NOT NULL,
	State_id Integer NOT NULL,
	District_id Integer NOT NULL,
	Taluka_id Integer NOT NULL,
	Village_id Integer NOT NULL,
	Shop_id Integer NOT NULL,
	Machine_Unique_Number text(25) NOT NULL,
	Gender char(10) NOT NULL,
	E_Salutation text(10) NOT NULL,
	E_M_Fname text(50) NOT NULL,
	E_M_Mname text(50) NOT NULL,
	E_M_Lname text(50) NOT NULL,
	M_Salutation text(10) NOT NULL,
	M_M_Fname text(50) NOT NULL,
	M_M_Mname text(50) NOT NULL,
	M_M_Lname text(50) NOT NULL,
	Finger text(50) NOT NULL,
	Member_Flag text(50) NOT NULL,
	Isregister TEXT(50) NOT NULL,
	Card_Unique_Number text(50) NOT NULL,
	Adhar_Number text(25) NOT NULL,
	Age Integer NOT NULL,
	LImage Memo NULL,
	RImage Memo NULL,
	IsVerify Text,
	
	
	
	
 PRIMARY KEY  
(
	Cardmember_id ,
	Cardholder_id ,
	State_id ,
	District_id ,
	Taluka_id ,
	Village_id ,
	Shop_id 
));
 
";
                    sceCreateTableCommand1 = new OleDbCommand(strCreateTableQuery1, sceConnection);
                    sceCreateTableCommand1.ExecuteNonQuery();
                    strCreateTableQuery1 = @"

CREATE TABLE Tbl_UserMaster(
	Userid Integer NOT NULL,
	State_id Integer NOT NULL,
	District_id Integer NOT NULL,
	Taluka_id Integer NOT NULL,
	Village_id Integer NOT NULL,
	Shop_id Integer NOT NULL,
	Group_id Integer NOT NULL,
	Emp_id Integer NOT NULL,
	User_name text(15) NOT NULL,
	Pass_word text(15) NOT NULL,
 PRIMARY KEY  
(
	Userid 
));


";
                    sceCreateTableCommand1 = new OleDbCommand(strCreateTableQuery1, sceConnection);
                    sceCreateTableCommand1.ExecuteNonQuery();
                    strCreateTableQuery1 = @"

CREATE TABLE Tbl_EmployeeMaster(
	Emp_Id Integer NOT NULL,
	State_Id Integer NOT NULL,
	District_Id Integer NOT NULL,
	Taluka_Id Integer NOT NULL,
	Village_Id Integer NOT NULL,
	Gender nchar(1) NOT NULL,
	E_Salutation text(10) NOT NULL,
	E_Fname text(50) NOT NULL,
	E_Mname text(50) NOT NULL,
	E_Lname text(50) NOT NULL,
	M_Salutation text(10) NOT NULL,
	M_Fname text(50) NOT NULL,
	M_Mname text(50) NOT NULL,
	M_Lname text(50) NOT NULL,
	Mobile_Number text(10) NULL,
	Email text(50) NULL,
	Contact_Number text(20) NULL,
	
	
	
	
	
 PRIMARY KEY  
(
	Emp_Id 
));
";
                    sceCreateTableCommand1 = new OleDbCommand(strCreateTableQuery1, sceConnection);
                    sceCreateTableCommand1.ExecuteNonQuery();

                    strCreateTableQuery1 = @"

CREATE TABLE ID_TO_DELETE(
	MACHINE_UNIQUE_NUMBER text(25) NOT NULL
);";
                    sceCreateTableCommand1 = new OleDbCommand(strCreateTableQuery1, sceConnection);
                    sceCreateTableCommand1.ExecuteNonQuery();



                    sceConnection.Close();
                    CREATEVIEW(strDirectory);
                    if (Insert_data(sceConnection, dtt))
                        ret = true;
                    else
                        ret = false;
                }
                else
                {
                    KryptonMessageBox.Show("Database Is Alrady Exists");
                }
                #region
                //foreach (System.Data.DataTable dttemp in dtt.Tables)
                //{
                //    string tableName = dttemp.TableName;

                //    StringBuilder stbSqlGetHeaders = new StringBuilder();
                //    stbSqlGetHeaders.Append("create table " + tableName + " (");
                //    int z = 0;
                //    StringBuilder stbSqlQuery = new StringBuilder();
                //    StringBuilder stbFields = new StringBuilder();
                //    StringBuilder stbParameters = new StringBuilder();


                //    foreach (DataColumn col in dttemp.Columns)
                //    {
                //        string datatyp = col.DataType.Name.ToString().Trim().ToLower();
                //        if (z != 0) stbSqlGetHeaders.Append(", "); ;
                //        String strName = col.ColumnName;
                //        String strType = col.DataType.Name.ToString().Trim().ToLower();
                //        if (strType.Equals("")) throw new ArgumentException("DataType Empty");
                //        if (strType.Equals("int32")) strType = "Number";
                //        if (strType.Equals("int64")) strType = "Number";
                //        if (strType.Equals("int16")) strType = "Number";
                //        if (strType.Equals("float")) strType = "float";
                //        if (strType.Equals("double")) strType = "Double";
                //        if (strType.Equals("decimal")) strType = "Double";
                //        if (strType.Equals("string")) strType = "memo";
                //        if (strType.Equals("boolean")) strType = "Bit";
                //        if (strType.Equals("datetime")) strType = "datetime";
                //        if (strType.Equals("byte[]")) strType = "Image";

                //        stbSqlGetHeaders.Append("[" + strName + "] " + strType);
                //        z++;

                //        stbFields.Append("[" + col.ColumnName + "]");

                //        stbParameters.Append("@" + col.ColumnName.ToLower());

                //        if (col.ColumnName != dttemp.Columns[dttemp.Columns.Count - 1].ColumnName)
                //        {
                //            stbFields.Append(", ");
                //            stbParameters.Append(", ");
                //        }

                //    }
                //    stbSqlGetHeaders.Append(")");
                //    OleDbCommand sceCreateTableCommand;
                //    string strCreateTableQuery = stbSqlGetHeaders.ToString();
                //    sceCreateTableCommand = new OleDbCommand(strCreateTableQuery, sceConnection);

                //    sceCreateTableCommand.ExecuteNonQuery();

                //    stbSqlQuery.Append("insert into " + tableName + " (");
                //    OleDbCommand comm = new OleDbCommand();

                //    stbSqlQuery.Append(stbFields.ToString() + ") ");
                //    stbSqlQuery.Append("values (");
                //    stbSqlQuery.Append(stbParameters.ToString() + ") ");

                //    string strTotalRows = dttemp.Rows.Count.ToString();

                //    foreach (DataRow row in dttemp.Rows)
                //    {
                //        OleDbCommand sceInsertCommand = new OleDbCommand(stbSqlQuery.ToString(), sceConnection);
                //        foreach (DataColumn col in dttemp.Columns)
                //        {
                //            string colnameparam = col.ColumnName;
                //            string colparam = col.ColumnName.ToLower();
                //            string datatyp1 = col.DataType.Name.ToString().Trim().ToLower();
                //            if (datatyp1.Substring(0, 3) == "str")
                //            {
                //                if (row[colnameparam].ToString() != "")
                //                {
                //                    sceInsertCommand.Parameters.Add("@" + colparam.Trim(), OleDbType.LongVarWChar).Value = row[colnameparam];
                //                }
                //                else
                //                {
                //                    sceInsertCommand.Parameters.Add("@" + colparam.Trim(), OleDbType.LongVarWChar).Value = DBNull.Value;
                //                }
                //            }
                //            else if (datatyp1.Substring(0, 3) == "dat")
                //            {
                //                if (row[colnameparam].ToString() != "")
                //                {
                //                    sceInsertCommand.Parameters.Add("@" + colparam.Trim(), OleDbType.Date).Value = row[colnameparam];
                //                }
                //                else
                //                {
                //                    sceInsertCommand.Parameters.Add("@" + colparam.Trim(), OleDbType.Date).Value = DBNull.Value;
                //                }
                //            }
                //            else if (datatyp1.Substring(0, 3) == "byt")
                //            {
                //                if (row[colnameparam].ToString() != "")
                //                {
                //                    sceInsertCommand.Parameters.Add("@" + colparam.Trim(), OleDbType.LongVarBinary).Value = row[colnameparam];
                //                }
                //                else
                //                {
                //                    sceInsertCommand.Parameters.Add("@" + colparam.Trim(), OleDbType.LongVarBinary).Value = DBNull.Value;
                //                }
                //            }
                //            else if (datatyp1.Substring(0, 3) == "int")
                //            {
                //                if (row[colnameparam].ToString() != "")
                //                {
                //                    sceInsertCommand.Parameters.Add("@" + colparam.Trim(), OleDbType.BigInt).Value = row[colnameparam];
                //                }
                //                else
                //                {
                //                    sceInsertCommand.Parameters.Add("@" + colparam.Trim(), OleDbType.BigInt).Value = DBNull.Value;
                //                }
                //            }
                //            else if (datatyp1.Substring(0, 3) == "boo")
                //            {
                //                if (row[colnameparam].ToString() != "")
                //                {
                //                    sceInsertCommand.Parameters.Add("@" + colparam.Trim(), OleDbType.Boolean).Value = row[colnameparam];
                //                }
                //                else
                //                {
                //                    sceInsertCommand.Parameters.Add("@" + colparam.Trim(), OleDbType.Boolean).Value = DBNull.Value;
                //                }
                //            }
                //            else if (datatyp1.Substring(0, 3) == "flo")
                //            {
                //                if (row[colnameparam].ToString() != "")
                //                {
                //                    sceInsertCommand.Parameters.Add("@" + colparam.Trim(), OleDbType.Double).Value = row[colnameparam];
                //                }
                //                else
                //                {
                //                    sceInsertCommand.Parameters.Add("@" + colparam.Trim(), OleDbType.Double).Value = DBNull.Value;
                //                }
                //            }
                //            else if (datatyp1.Substring(0, 3) == "dou")
                //            {
                //                if (row[colnameparam].ToString() != "")
                //                {
                //                    sceInsertCommand.Parameters.Add("@" + colparam.Trim(), OleDbType.Double).Value = row[colnameparam];
                //                }
                //                else
                //                {
                //                    sceInsertCommand.Parameters.Add("@" + colparam.Trim(), OleDbType.Double).Value = DBNull.Value;
                //                }
                //            }
                //            else if (datatyp1.Substring(0, 3) == "dec")
                //            {
                //                if (row[colnameparam].ToString() != "")
                //                {
                //                    sceInsertCommand.Parameters.Add("@" + colparam.Trim(), OleDbType.Decimal).Value = row[colnameparam];
                //                }
                //                else
                //                {
                //                    sceInsertCommand.Parameters.Add("@" + colparam.Trim(), OleDbType.Decimal).Value = DBNull.Value;
                //                }
                //            }
                //        }
                //        sceInsertCommand.ExecuteNonQuery();
                //    }
                //}
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Export Data", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return false;
            }
            finally
            {
                if (sceConnection != null)
                {
                    sceConnection.Close();
                    sceConnection.Dispose();
                    cat = null;
                }
            }
            return ret;
        }

        public bool Insert_data(OleDbConnection Connection, DataSet ds)
        {
            //Ds Tables Mapping 
            //0	Tbl_AreaMaster
            //1	Tbl_BankMaster
            //2	Tbl_CardholderMaster
            //3	Tbl_CardholderwiseMember
            //4	Tbl_CardTypeMaster
            //5	Tbl_DistrictMaster
            //6	Tbl_EmployeeMaster
            //7	Tbl_GroupMaster
            //8	Tbl_ShopCategoryMaster
            //9	Tbl_ShopMaster
            //10 Tbl_StateMaster
            //11 Tbl_TalukaMaster
            //12 Tbl_UserMaster
            //13 Tbl_VillageMaster
            OleDbCommand cmd = new OleDbCommand();
            try
            {
                Connection.Open();

                string qry;
                foreach (DataTable dt in ds.Tables)
                {
                    switch (dt.DataSet.Tables.IndexOf(dt))
                    {
                        case 0:
                            #region
                            foreach (DataRow dr in dt.Rows)
                            {
                                qry = "insert into Tbl_AreaMaster values(";
                                foreach (DataColumn dc in dt.Columns)
                                {
                                    qry += "@" + dc.ColumnName.ToString() + ",";
                                }
                                qry = (qry.Trim().Remove(qry.Length - 1)) + ");";
                                cmd = new OleDbCommand(qry, Connection);
                                foreach (DataColumn dc in dt.Columns)
                                {
                                    cmd.Parameters.AddWithValue("@" + dc.ColumnName.ToString(), dr[dc].ToString());
                                }
                                cmd.ExecuteNonQuery();
                            }
                            #endregion
                            break;
                        case 1:
                            #region
                            foreach (DataRow dr in dt.Rows)
                            {
                                qry = "insert into Tbl_BankMaster values(";
                                foreach (DataColumn dc in dt.Columns)
                                {
                                    qry += "@" + dc.ColumnName.ToString() + ",";
                                }
                                qry = (qry.Trim().Remove(qry.Length - 1)) + ");";
                                cmd = new OleDbCommand(qry, Connection);
                                foreach (DataColumn dc in dt.Columns)
                                {
                                    cmd.Parameters.AddWithValue("@" + dc.ColumnName.ToString(), dr[dc].ToString());
                                }
                                cmd.ExecuteNonQuery();
                            }
                            #endregion
                            break;
                        case 2:
                            #region
                            foreach (DataRow dr in dt.Rows)
                            {
                                qry = "insert into Tbl_CardholderMaster values(";
                                foreach (DataColumn dc in dt.Columns)
                                {
                                    qry += "@" + dc.ColumnName.ToString() + ",";
                                }
                                qry = (qry.Trim().Remove(qry.Length - 1)) + ");";
                                cmd = new OleDbCommand(qry, Connection);
                                foreach (DataColumn dc in dt.Columns)
                                {
                                    cmd.Parameters.AddWithValue("@" + dc.ColumnName.ToString(), dr[dc].ToString());
                                }
                                try
                                {
                                    cmd.ExecuteNonQuery();
                                }
                                catch (Exception ex) { BL_Error_Log.WriteLog(ex); }
                            }
                            #endregion
                            break;
                        case 3:
                            #region
                            foreach (DataRow dr in dt.Rows)
                            {
                                qry = "insert into Tbl_CardholderwiseMember values(";
                                foreach (DataColumn dc in dt.Columns)
                                {
                                    qry += "@" + dc.ColumnName.ToString() + ",";
                                }
                                qry = (qry.Trim().Remove(qry.Length - 1)) + ");";
                                cmd = new OleDbCommand(qry, Connection);
                                foreach (DataColumn dc in dt.Columns)
                                {
                                    cmd.Parameters.AddWithValue("@" + dc.ColumnName.ToString(), dr[dc].ToString());
                                }
                                try
                                {
                                    cmd.ExecuteNonQuery();
                                }
                                catch (Exception ex) { BL_Error_Log.WriteLog(ex); }
                            }
                            #endregion
                            break;
                        case 4:
                            #region
                            foreach (DataRow dr in dt.Rows)
                            {
                                qry = "insert into Tbl_CardTypeMaster values(";
                                foreach (DataColumn dc in dt.Columns)
                                {
                                    qry += "@" + dc.ColumnName.ToString() + ",";
                                }
                                qry = (qry.Trim().Remove(qry.Length - 1)) + ");";
                                cmd = new OleDbCommand(qry, Connection);
                                foreach (DataColumn dc in dt.Columns)
                                {
                                    cmd.Parameters.AddWithValue("@" + dc.ColumnName.ToString(), dr[dc].ToString().Trim().Length <= 0 ? "0" : dr[dc].ToString());
                                }
                                try { cmd.ExecuteNonQuery(); }
                                catch (Exception ex) { BL_Error_Log.WriteLog(ex); }
                            }
                            #endregion
                            break;
                        case 5:
                            #region
                            foreach (DataRow dr in dt.Rows)
                            {
                                qry = "insert into Tbl_DistrictMaster values(";
                                foreach (DataColumn dc in dt.Columns)
                                {
                                    qry += "@" + dc.ColumnName.ToString() + ",";
                                }
                                qry = (qry.Trim().Remove(qry.Length - 1)) + ");";
                                cmd = new OleDbCommand(qry, Connection);
                                foreach (DataColumn dc in dt.Columns)
                                {
                                    cmd.Parameters.AddWithValue("@" + dc.ColumnName.ToString(), dr[dc].ToString());
                                }
                                try
                                {
                                    cmd.ExecuteNonQuery();
                                }
                                catch (Exception ex) { BL_Error_Log.WriteLog(ex); }
                            }
                            #endregion
                            break;
                        case 6:
                            #region
                            foreach (DataRow dr in dt.Rows)
                            {
                                qry = "insert into Tbl_EmployeeMaster values(";
                                foreach (DataColumn dc in dt.Columns)
                                {
                                    qry += "@" + dc.ColumnName.ToString() + ",";
                                }
                                qry = (qry.Trim().Remove(qry.Length - 1)) + ");";
                                cmd = new OleDbCommand(qry, Connection);
                                foreach (DataColumn dc in dt.Columns)
                                {
                                    cmd.Parameters.AddWithValue("@" + dc.ColumnName.ToString(), dr[dc].ToString());
                                }
                                try
                                {
                                    cmd.ExecuteNonQuery();
                                }
                                catch (Exception ex) { BL_Error_Log.WriteLog(ex); }
                            }
                            #endregion
                            break;
                        case 7:
                            #region
                            foreach (DataRow dr in dt.Rows)
                            {
                                qry = "insert into Tbl_GroupMaster values(";
                                foreach (DataColumn dc in dt.Columns)
                                {
                                    qry += "@" + dc.ColumnName.ToString() + ",";
                                }
                                qry = (qry.Trim().Remove(qry.Length - 1)) + ");";
                                cmd = new OleDbCommand(qry, Connection);
                                foreach (DataColumn dc in dt.Columns)
                                {
                                    cmd.Parameters.AddWithValue("@" + dc.ColumnName.ToString(), dr[dc].ToString());
                                }
                                try
                                {
                                    cmd.ExecuteNonQuery();
                                }
                                catch (Exception ex) { BL_Error_Log.WriteLog(ex); }
                            }
                            #endregion
                            break;
                        case 8:
                            #region
                            foreach (DataRow dr in dt.Rows)
                            {
                                qry = "insert into Tbl_ShopCategoryMaster values(";
                                foreach (DataColumn dc in dt.Columns)
                                {
                                    qry += "@" + dc.ColumnName.ToString() + ",";
                                }
                                qry = (qry.Trim().Remove(qry.Length - 1)) + ");";
                                cmd = new OleDbCommand(qry, Connection);
                                foreach (DataColumn dc in dt.Columns)
                                {
                                    cmd.Parameters.AddWithValue("@" + dc.ColumnName.ToString(), dr[dc].ToString());
                                }
                                try
                                {
                                    cmd.ExecuteNonQuery();
                                }
                                catch (Exception ex) { BL_Error_Log.WriteLog(ex); }
                            }
                            #endregion
                            break;
                        case 9:
                            #region
                            foreach (DataRow dr in dt.Rows)
                            {
                                qry = "insert into Tbl_ShopMaster values(";
                                foreach (DataColumn dc in dt.Columns)
                                {
                                    qry += "@" + dc.ColumnName.ToString() + ",";
                                }
                                qry = (qry.Trim().Remove(qry.Length - 1)) + ");";
                                cmd = new OleDbCommand(qry, Connection);
                                foreach (DataColumn dc in dt.Columns)
                                {
                                    cmd.Parameters.AddWithValue("@" + dc.ColumnName.ToString(), dr[dc].ToString());
                                }
                                try
                                {
                                    cmd.ExecuteNonQuery();
                                }
                                catch (Exception ex) { BL_Error_Log.WriteLog(ex); }
                            }
                            #endregion
                            break;
                        case 10:
                            #region
                            foreach (DataRow dr in dt.Rows)
                            {
                                qry = "insert into Tbl_StateMaster values(";
                                foreach (DataColumn dc in dt.Columns)
                                {
                                    qry += "@" + dc.ColumnName.ToString() + ",";
                                }
                                qry = (qry.Trim().Remove(qry.Length - 1)) + ");";
                                cmd = new OleDbCommand(qry, Connection);
                                foreach (DataColumn dc in dt.Columns)
                                {
                                    cmd.Parameters.AddWithValue("@" + dc.ColumnName.ToString(), dr[dc].ToString());
                                }
                                try
                                {
                                    cmd.ExecuteNonQuery();
                                }
                                catch (Exception ex) { BL_Error_Log.WriteLog(ex); }
                            }
                            #endregion
                            break;
                        case 11:
                            #region
                            foreach (DataRow dr in dt.Rows)
                            {
                                qry = "insert into Tbl_TalukaMaster values(";
                                foreach (DataColumn dc in dt.Columns)
                                {
                                    qry += "@" + dc.ColumnName.ToString() + ",";
                                }
                                qry = (qry.Trim().Remove(qry.Length - 1)) + ");";
                                cmd = new OleDbCommand(qry, Connection);
                                foreach (DataColumn dc in dt.Columns)
                                {
                                    cmd.Parameters.AddWithValue("@" + dc.ColumnName.ToString(), dr[dc].ToString());
                                }
                                try
                                {
                                    cmd.ExecuteNonQuery();
                                }
                                catch (Exception ex) { BL_Error_Log.WriteLog(ex); }
                            }
                            #endregion
                            break;
                        case 12:
                            #region
                            foreach (DataRow dr in dt.Rows)
                            {
                                qry = "insert into Tbl_UserMaster values(";
                                foreach (DataColumn dc in dt.Columns)
                                {
                                    qry += "@" + dc.ColumnName.ToString() + ",";
                                }
                                qry = (qry.Trim().Remove(qry.Length - 1)) + ");";
                                cmd = new OleDbCommand(qry, Connection);
                                foreach (DataColumn dc in dt.Columns)
                                {
                                    cmd.Parameters.AddWithValue("@" + dc.ColumnName.ToString(), dr[dc].ToString());
                                }
                                try
                                {
                                    cmd.ExecuteNonQuery();
                                }
                                catch (Exception ex) { BL_Error_Log.WriteLog(ex); }
                            }
                            #endregion
                            break;
                        case 13:
                            #region
                            foreach (DataRow dr in dt.Rows)
                            {
                                qry = "insert into Tbl_VillageMaster values(";
                                foreach (DataColumn dc in dt.Columns)
                                {
                                    qry += "@" + dc.ColumnName.ToString() + ",";
                                }
                                qry = (qry.Trim().Remove(qry.Length - 1)) + ");";
                                cmd = new OleDbCommand(qry, Connection);
                                foreach (DataColumn dc in dt.Columns)
                                {
                                    cmd.Parameters.AddWithValue("@" + dc.ColumnName.ToString(), dr[dc].ToString());
                                }
                                try
                                {
                                    cmd.ExecuteNonQuery();
                                }
                                catch (Exception ex) { BL_Error_Log.WriteLog(ex); }
                            }
                            #endregion
                            break;
                    }
                }
                Connection.Close();
                return true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Export Data", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return false;
            }
            finally
            {
                Connection.Close();
                Connection.Dispose();
                cmd.Dispose();
            }

        }

        public bool CREATEVIEW(String strDirectory)
        {
            OleDbConnection sceConnection = null;
            Catalog cat = new Catalog();
            bool ret = false;
            try
            {


                // UpdateProgress("");
                //string str = "provider=Microsoft.Jet.OleDb.4.0;Data Source=" + strDirectory;
                //cat.Create(str);
                //cat = null;
                sceConnection = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + strDirectory);
                sceConnection.Open();
                OleDbCommand sceCreateTableCommand1;

                string strCreateTableQuery1 = @"
Create View TCARDS AS
SELECT CARDTYPE_ID, COUNT(*) AS TCARDS
FROM Tbl_CardholderMaster
GROUP BY CARDTYPE_ID;
";
                sceCreateTableCommand1 = new OleDbCommand(strCreateTableQuery1, sceConnection);
                sceCreateTableCommand1.ExecuteNonQuery();
                strCreateTableQuery1 = @"
Create View VCARDS AS
SELECT CARDTYPE_ID, COUNT(*) AS VCARDS
FROM Tbl_CardholderMaster
WHERE ISVERIFY='1'
GROUP BY CARDTYPE_ID;
";
                sceCreateTableCommand1 = new OleDbCommand(strCreateTableQuery1, sceConnection);
                sceCreateTableCommand1.ExecuteNonQuery();
                strCreateTableQuery1 = @"
Create View NVCARDS AS
SELECT CARDTYPE_ID, COUNT(*) AS NVCARDS
FROM Tbl_CardholderMaster
WHERE ISVERIFY='0'
GROUP BY CARDTYPE_ID;
";
                sceCreateTableCommand1 = new OleDbCommand(strCreateTableQuery1, sceConnection);
                sceCreateTableCommand1.ExecuteNonQuery();
                strCreateTableQuery1 = @"


Create View TOTALS AS
SELECT 'Total' AS CardType_id, sum(IIf(TCARDS Is Null,0,TCARDS)) AS T_CARDS, sum(IIf(VCARDS Is Null,0,VCARDS)) AS V_CARDS, sum(IIf(NVCARDS Is Null,0,NVCARDS)) AS NV_CARDS
FROM ((Tbl_CardTypeMaster LEFT JOIN TCARDS ON Tbl_CardTypeMaster.CardType_id=TCARDS.CARDTYPE_ID) LEFT JOIN VCARDS ON Tbl_CardTypeMaster.CardType_id=VCARDS.CARDTYPE_ID) LEFT JOIN NVCARDS ON Tbl_CardTypeMaster.CardType_id=NVCARDS.CARDTYPE_ID;

";
                sceCreateTableCommand1 = new OleDbCommand(strCreateTableQuery1, sceConnection);
                sceCreateTableCommand1.ExecuteNonQuery();
                strCreateTableQuery1 = @"
Create View VW_CARD_COUNTS AS
SELECT Tbl_CardTypeMaster.CardType_id, IIF(TCARDS IS NULL ,0,TCARDS) AS T_CARDS, IIF(VCARDS IS NULL ,0,VCARDS) AS V_CARDS, IIF(NVCARDS IS NULL ,0,NVCARDS) AS NV_CARDS
FROM ((Tbl_CardTypeMaster LEFT JOIN TCARDS ON Tbl_CardTypeMaster.CardType_id=TCARDS.CARDTYPE_ID) LEFT JOIN VCARDS ON Tbl_CardTypeMaster.CardType_id=VCARDS.CARDTYPE_ID) LEFT JOIN NVCARDS ON Tbl_CardTypeMaster.CardType_id=NVCARDS.CARDTYPE_ID;
";
                sceCreateTableCommand1 = new OleDbCommand(strCreateTableQuery1, sceConnection);
                sceCreateTableCommand1.ExecuteNonQuery();

                sceConnection.Close();
                ret = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Export Data", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return false;
            }
            finally
            {
                if (sceConnection != null)
                {
                    sceConnection.Close();
                    sceConnection.Dispose();
                    cat = null;
                }
            }
            return ret;
        }

    }
}