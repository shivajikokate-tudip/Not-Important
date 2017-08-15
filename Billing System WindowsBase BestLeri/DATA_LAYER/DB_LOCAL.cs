using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using System.Data;
using System.Data.OleDb;

namespace DATA_LAYER
{

    public static class DB_LOCAL
    {
        static Common_Connection db_obj = new Common_Connection();
        static DBSettings settings = new DBSettings();
        static DbConnection con_Local = null;
        public static bool OpenConnection()
        {
            try
            {
                if (con_Local == null)
                {
                    con_Local = db_obj.GetConncetion(settings.Connection_String_Local, settings.Connection_Type);
                }

                if (con_Local.State == ConnectionState.Closed || con_Local.State == ConnectionState.Broken)
                {
                    con_Local.Open();
                }
                if (con_Local.State == ConnectionState.Open)
                {
                    return true;
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public static void CloseConnection()
        {
            if (con_Local != null)
            {
                if (con_Local.State == ConnectionState.Open)
                {
                    con_Local.Close();
                }
            }
        }
        public static DataSet ExecuteQuery(string Query)
        {
            DataSet dataset = new DataSet();
            try
            {
                if (OpenConnection())
                {
                    DbCommand Command = db_obj.CreateCommand(settings.Connection_Type);
                    Command.CommandText = Query;
                    Command.CommandType = CommandType.Text;
                    Command.Connection = con_Local;
                    DbDataAdapter dataAdapter = db_obj.CreateDataAdapter(settings.Connection_Type);
                    dataAdapter.SelectCommand = Command;
                    dataAdapter.Fill(dataset);

                }
            }
            catch (Exception ex)
            { }
            finally
            { CloseConnection(); }
            return dataset;
        }

        public static bool checkConnection_Local()
        {
            string connectionString = settings.Connection_String_Local.ToString();
            try
            {
                DbConnection conn = db_obj.GetConncetion(settings.Connection_String_Local, settings.Connection_Type);
                conn.ConnectionString = connectionString;
                conn.Open();
                return true;
            }
            catch (Exception) { return false; }
        }

        public static bool checkConnection_Local(string newconnectionstring, string Con_Type)
        {
            settings.Properties["Connection_String_Local"].DefaultValue = newconnectionstring.ToString();
            settings.Properties["Connection_Type"].DefaultValue = Con_Type.ToString();
            settings.Save();
            settings.Reload();
            string connectionString = settings.Connection_String_Local.ToString();
            try
            {
                DbConnection conn = db_obj.GetConncetion(connectionString, settings.Connection_Type);
                conn.ConnectionString = connectionString;
                conn.Open();
                return true;
            }
            catch (Exception) { return false; }
        }

        public static DataSet ExecuteQuery(Dictionary<string, string> Parameter, string Query)
        {
            DataSet dataset = new DataSet();
            try
            {
                if (OpenConnection())
                {
                    DbCommand Command = db_obj.CreateCommand(settings.Connection_Type);
                    if (settings.Connection_Type == 2)
                        foreach (KeyValuePair<string, string> k in Parameter)
                        {
                            Query = Query.Replace(k.Key, "?");
                        }
                    Command.CommandText = Query;
                    Command.CommandType = CommandType.Text;
                    Command.Connection = con_Local;
                    DbParameter param;
                    foreach (KeyValuePair<string, string> k in Parameter)
                    {
                        param = db_obj.CreateParameter(settings.Connection_Type);
                        param.ParameterName = k.Key.ToString();
                        param.Value = k.Value.ToString();
                        //param.DbType = DbType.String;
                        Command.Parameters.Add(param);
                    }
                    DbDataAdapter dataAdapter = db_obj.CreateDataAdapter(settings.Connection_Type);
                    dataAdapter.SelectCommand = Command;
                    dataAdapter.Fill(dataset);
                }

            }
            catch (Exception)
            {

            }
            finally
            {
                CloseConnection();
            }
            return dataset;
        }
        //public DataTable ExecuteQuery(string Query)
        //{
        //    DataTable datatable = new DataTable();
        //    try
        //    {
        //        if (OpenConnection())
        //        {
        //            DbCommand Command = db_obj.CreateCommand(settings.Connection_Type);
        //            Command.CommandType = CommandType.Text;
        //            DbDataAdapter DataAdapter = db_obj.CreateDataAdapter(settings.Connection_Type);
        //            DataAdapter.Fill(datatable);
        //        }
        //    }
        //    catch (Exception ex)
        //    { }
        //    finally
        //    { CloseConnection(); }
        //    return datatable;
        //}
        public static int ExecuteNonQuery(string Query)
        {
            int ret = 0;
            try
            {
                if (OpenConnection())
                {
                    DbCommand Command = db_obj.CreateCommand(settings.Connection_Type);
                    Command.CommandText = Query;
                    Command.CommandType = CommandType.Text;
                    Command.Connection = con_Local;
                    ret = Command.ExecuteNonQuery();
                }

            }
            catch (Exception)
            { }
            finally
            {
                CloseConnection();
            }
            return ret;
        }
        public static int ExecuteNonQuery(Dictionary<string, string> Parameter, string Query)
        {
            int ret = 0;
            try
            {
                if (OpenConnection())
                {
                    DbCommand Command = db_obj.CreateCommand(settings.Connection_Type);
                    if (settings.Connection_Type == 2)
                        foreach (KeyValuePair<string, string> k in Parameter)
                        {
                            Query = Query.Replace(k.Key, "?");
                        }
                    Command.CommandText = Query;
                    Command.CommandType = CommandType.Text;
                    Command.Connection = con_Local;
                    DbParameter param;
                    foreach (KeyValuePair<string, string> k in Parameter)
                    {
                        param = db_obj.CreateParameter(settings.Connection_Type);
                        param.ParameterName = k.Key.ToString();
                        param.Value = k.Value.ToString();
                        //param.DbType = DbType.String;
                        Command.Parameters.Add(param);
                    }
                    ret = Command.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                CloseConnection();
            }
            return ret;
        }
  

        public static string ExecuteScaler(string Query)
        {
            string ret = "";
            try
            {
                if (OpenConnection())
                {
                    DbCommand Command = db_obj.CreateCommand(settings.Connection_Type);
                    Command.CommandText = Query;
                    Command.CommandType = CommandType.Text;
                    Command.Connection = con_Local;
                    ret = Command.ExecuteNonQuery().ToString();
                }

            }
            catch (Exception)
            { }
            finally
            {
                CloseConnection();
            }
            return ret;
        }
        public static string ExecuteScaler(Dictionary<string, string> Parameter, string Query)
        {
            string ret = "";
            try
            {
                if (OpenConnection())
                {
                    DbCommand Command = db_obj.CreateCommand(settings.Connection_Type);
                    if (settings.Connection_Type == 2)
                        foreach (KeyValuePair<string, string> k in Parameter)
                        {
                            Query = Query.Replace(k.Key, "?");
                        }
                    Command.CommandText = Query;
                    Command.CommandType = CommandType.Text;
                    Command.Connection = con_Local;
                    DbParameter param;
                    foreach (KeyValuePair<string, string> k in Parameter)
                    {
                        param = db_obj.CreateParameter(settings.Connection_Type);
                        param.ParameterName = k.Key.ToString();
                        param.Value = k.Value.ToString();
                        //param.DbType = DbType.String;
                        Command.Parameters.Add(param);
                    }
                    ret = Command.ExecuteScalar().ToString();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                CloseConnection();
            }
            return ret;
        }
    }
}


