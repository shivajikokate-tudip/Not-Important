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
    public class DatasetToJet_org
    {
        public bool gETDATA(String strDirectory, DataSet dtt)
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
                    string strCreateTableQuery1 = @"CREATE TABLE Tbl_PLMaster(
	                                        PLNo integer NOT NULL ,
	                                        PLNAME memo NOT NULL,
	                                        PLENGNAME memo NOT NULL,
	                                        PLUNINAME memo NOT NULL,
                                            Primary Key(PLNo)
                                            );";

                    strCreateTableQuery1 = @"CREATE TABLE PlusMinus ( 
                                            PLNo          integer  NOT NULL,
                                            Acno          integer  NOT NULL,
                                            AverageVoting memo    NOT NULL
                                        );";
                    sceCreateTableCommand1 = new OleDbCommand(strCreateTableQuery1, sceConnection);
                    sceCreateTableCommand1.ExecuteNonQuery();

                    strCreateTableQuery1 = @"CREATE TABLE Plusminusdetails ( 
    PLNo    integer  NULL,
    AcNo    integer  NOT NULL,
    Psno    integer  NOT NULL,
    15per memo    NULL,
    id      INT               NULL 
);";
                    sceCreateTableCommand1 = new OleDbCommand(strCreateTableQuery1, sceConnection);
                    sceCreateTableCommand1.ExecuteNonQuery();



                    strCreateTableQuery1 = @"CREATE TABLE Table1 ( 
    ID INT IDENTITY( 1, 1 )  NOT NULL 
);";
                    sceCreateTableCommand1 = new OleDbCommand(strCreateTableQuery1, sceConnection);
                    sceCreateTableCommand1.ExecuteNonQuery();

                    strCreateTableQuery1 = @"CREATE TABLE Tbl_ACMaster ( 
PLNo integer NOT NULL , 
ACNo integer NOT NULL , 
ACName memo NOT NULL , 
ACENGName memo NOT NULL , 
ACUNIName memo NOT NULL , 
PRIMARY KEY 
( 
PLNo  , 
ACNo  
) ) ;";
                    sceCreateTableCommand1 = new OleDbCommand(strCreateTableQuery1, sceConnection);
                    sceCreateTableCommand1.ExecuteNonQuery();



                    strCreateTableQuery1 = @"CREATE TABLE Tbl_PLMaster ( 
PLNo integer NOT NULL , 
PLNAME memo NOT NULL , 
PLENGNAME memo NOT NULL , 
PLUNINAME memo NOT NULL , 
PRIMARY KEY  
( 
PLNo  
) 
);";
                    sceCreateTableCommand1 = new OleDbCommand(strCreateTableQuery1, sceConnection);
                    sceCreateTableCommand1.ExecuteNonQuery();







                    strCreateTableQuery1 = @"CREATE TABLE Tbl_PollingDetails ( 
Maxid integer NOT NULL , 
PLNo integer NOT NULL , 
ACNo integer NOT NULL , 
PSNo integer NOT NULL , 
SubNo Text(1) NOT NULL , 
TMVoting integer NOT NULL , 
TFVoting integer NOT NULL , 
TSHVoting integer NOT NULL , 
TVoting integer NOT NULL , 
EpicVoting integer NOT NULL , 
OtherVoting integer NOT NULL , 
PMVoting integer NOT NULL , 
F17a memo NOT NULL , 
MocPoll integer NOT NULL , 
CHVoting integer NOT NULL , 
Flag memo NOT NULL , 
ChallVoter integer NOT NULL , 
CpollProcess memo NULL , 
ActionPoll memo NULL , 
Evmrc memo NULL , 
ActionEvm memo NULL , 
Remarksaro memo NULL , 
remarks memo NULL , 
After5PM memo NOT NULL , 
After5PMCount integer NOT NULL ,
PRIMARY KEY  
( 
PLNo,ACNO,PSNO,SUBNO
) 
);";
                    sceCreateTableCommand1 = new OleDbCommand(strCreateTableQuery1, sceConnection);
                    sceCreateTableCommand1.ExecuteNonQuery();


                    strCreateTableQuery1 = @"CREATE TABLE Tbl_PollingOtherDetails ( 
Maxid float NOT NULL , 
PLNo integer NOT NULL , 
Acno integer NOT NULL , 
PSNo integer NOT NULL , 
SubNo Text(1) NOT NULL , 
WithoutanyDoc integer NOT NULL , 
Rampvoting integer NOT NULL , 
BellDempWith integer NOT NULL , 
BellDempWithOutAsst integer NOT NULL , 
RejectUnder49o integer NOT NULL , 
flag memo NOT NULL , 
TotalHandi integer NOT NULL ,
PRIMARY KEY  
( 
PLNo,ACNO,PSNO,SUBNO
) 
);";
                    sceCreateTableCommand1 = new OleDbCommand(strCreateTableQuery1, sceConnection);
                    sceCreateTableCommand1.ExecuteNonQuery();



                    strCreateTableQuery1 = @"CREATE TABLE Tbl_PSMaster ( 
Maxid float NOT NULL , 
PLNo integer NULL , 
Acno integer NOT NULL , 
PSNo integer NOT NULL , 
SubNo Text(1) NOT NULL , 
PSName memo NOT NULL , 
PSEngName memo NOT NULL , 
PSUNIName memo NULL , 
PSLocation memo NOT NULL , 
PSEngLocation memo NOT NULL , 
PSUNILocation memo NULL , 
EvmUsed memo NULL, 
PRIMARY KEY  
( 
PLNo,ACNO,PSNO,SUBNO
) 
);";
                    sceCreateTableCommand1 = new OleDbCommand(strCreateTableQuery1, sceConnection);
                    sceCreateTableCommand1.ExecuteNonQuery();





                    strCreateTableQuery1 = @"CREATE TABLE Tbl_VotersMaster ( 
Maxid float NOT NULL , 
PLNo integer NOT NULL , 
Acno integer NOT NULL , 
PSNo integer NOT NULL , 
SubNo Text(1) NOT NULL , 
TMVoters integer NOT NULL , 
TFVoters integer NOT NULL , 
TVoters integer NOT NULL , 
TSHVoters integer NULL ,
PRIMARY KEY  
( 
PLNo,ACNO,PSNO,SUBNO
) 
) ;";
                    sceCreateTableCommand1 = new OleDbCommand(strCreateTableQuery1, sceConnection);
                    sceCreateTableCommand1.ExecuteNonQuery();

                    strCreateTableQuery1 = @"CREATE TABLE Tbl_UserMaster (
PLNO integer NOT NULL,
ACNO integer NOT NULL,
userid integer NOT NULL,
User_Name memo NOT NULL,
Pass_word memo NOT NULL,
GroupId integer NOT NULL,
 PRIMARY KEY  
(PLNO,ACNO,userid )

);";
                    sceCreateTableCommand1 = new OleDbCommand(strCreateTableQuery1, sceConnection);
                    sceCreateTableCommand1.ExecuteNonQuery();

                    strCreateTableQuery1 = @"
CREATE TABLE Tbl_GroupMaster(
	GroupID integer NOT NULL,
	GroupName memo NOT NULL,
 PRIMARY KEY  
(Groupid));";
                    sceCreateTableCommand1 = new OleDbCommand(strCreateTableQuery1, sceConnection);
                    sceCreateTableCommand1.ExecuteNonQuery();




                    //strCreateTableQuery1 = "SELECT PLNo, Acno, PSno , Subno, PSName, PSno & ' ' & Subno& ' ' & PSName as PS_NAME,PSno & ' ' & Subno& ' ' & PSENGName as PS_ENGNAME,PSno & ' ' & Subno& ' ' & PSUNIName as PS_UNINAME FROM Tbl_PSMaster;";

                    //ADODB.Command cmd = new Command();
                    //cmd.CommandText = strCreateTableQuery1;
                    //cat.Views.Append("PSMASTER", cmd);
                    //cat = null;


                    //                    'Purpose:   Create a query using ADOX.
                    //Dim cat As New ADOX.Catalog
                    //Dim cmd As New ADODB.Command
                    //Dim strSql As String

                    //'Initialize.
                    //cat.ActiveConnection = CurrentProject.Connection

                    //'Assign the SQL statement to Command object's CommandText property.
                    //strSql = "SELECT BookingID, BookingDate FROM tblDaoBooking;"
                    //cmd.CommandText = strSql

                    //'Append the Command to the Views collectiion of the catalog.
                    //cat.Views.Append "qryAdoxBooking", cmd

                    //'Clean up.
                    //Set cmd = Nothing
                    //Set cat = Nothing
                    //Debug.Print "View created."




                    sceConnection.Close();
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
            //Table0= Table1
            //Table1=Tbl_PLMaster
            //Table2=Tbl_ACMaster
            //Table3=Tbl_PSMaster
            //Table4=Tbl_VotersMaster
            //Table5=Tbl_PollingDetails
            //Table6=Tbl_PollingOtherDetails
            //Table7=PlusMinus
            //Table8=Plusminusdetails
            try
            {
                Connection.Open();
                OleDbCommand cmd;
                string qry;
                foreach (DataTable dt in ds.Tables)
                {
                    switch (dt.DataSet.Tables.IndexOf(dt))
                    {
                        case 1:
                            #region
                            foreach (DataRow dr in dt.Rows)
                            {
                                qry = "insert into Tbl_PLMaster values(";
                                foreach (DataColumn dc in dt.Columns)
                                {
                                    qry += "'" + dr[dc].ToString() + "',";
                                }
                                qry = (qry.Trim().Remove(qry.Length - 1)) + ");";
                                new OleDbCommand(qry, Connection).ExecuteNonQuery();
                            }
                            #endregion
                            break;
                        case 2:
                            #region
                            foreach (DataRow dr in dt.Rows)
                            {
                                qry = "insert into Tbl_ACMaster values(";
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
                                qry = "insert into Tbl_PSMaster values(";
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
                        case 4:
                            #region
                            foreach (DataRow dr in dt.Rows)
                            {
                                qry = "insert into Tbl_VotersMaster values(";
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
                                qry = "insert into Tbl_PollingDetails values(";
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
                        case 6:
                            #region
                            foreach (DataRow dr in dt.Rows)
                            {
                                qry = "insert into Tbl_PollingOtherDetails values(";
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
                        case 7:
                            #region
                            foreach (DataRow dr in dt.Rows)
                            {
                                qry = "insert into PlusMinus values(";
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
                        case 8:
                            #region
                            foreach (DataRow dr in dt.Rows)
                            {
                                qry = "insert into Plusminusdetails values(";
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
                        case 9:
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
                                cmd.ExecuteNonQuery();
                            }
                            #endregion
                            break;
                        case 10:
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
                                cmd.ExecuteNonQuery();
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
            }

        }
    }
}