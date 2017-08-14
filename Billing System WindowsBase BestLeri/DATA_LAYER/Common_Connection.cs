using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.Odbc;
using System.Data.OleDb;
using System.Data.SQLite;
using System.IO;
using System.Reflection;

namespace DATA_LAYER
{
    public class Common_Connection
    {
        DbProviderFactory Factory = null;
        DBSettings Settings = new DBSettings();
        public DbProviderFactory GetFactory(int con_type)
        {
            //Sql Server
            if (con_type == 1)
            {
                Factory = DbProviderFactories.GetFactory("System.Data.SqlClient");
            }
            //ODBC Sql Server
            if (con_type == 2)
            {
                Factory = DbProviderFactories.GetFactory("System.Data.Odbc");
            }
            //Microsoft Access
            if (con_type == 3)
            {
                Factory = DbProviderFactories.GetFactory("System.Data.OleDb");
            }
            //Sql Lite
            if (con_type == 4)
            {
                Factory = DbProviderFactories.GetFactory("System.Data.SQLite");
            }
            return Factory;
        }

        public DbConnection GetConncetion(string connection_String, int Con_Type)
        {
            DbConnection con = GetFactory(Con_Type).CreateConnection();
            con.ConnectionString = connection_String;
            return con;
        }

        public DbDataAdapter CreateDataAdapter(int con_Type)
        {
            DbDataAdapter adp = GetFactory(con_Type).CreateDataAdapter();
            return adp;
        }
        public DbCommand CreateCommand(int con_Type)
        {
            DbCommand cmd = GetFactory(con_Type).CreateCommand();
            return cmd;
        }
        public DbParameter CreateParameter(int con_Type)
        {
            DbParameter param = GetFactory(con_Type).CreateParameter();
            return param;
        }


        public string WriteErrorLog(string Error)
        {
            string filename = "";
            string txtline = "";
            try
            {
                if (File.Exists(Assembly.GetExecutingAssembly().Location.Replace(@"\DATA_LAYER.dll","") + "\\ErrorLog.txt"))
                {
                    filename = Assembly.GetExecutingAssembly().Location.Replace(@"\DATA_LAYER.dll","") + "\\ErrorLog.txt";

                    System.IO.StreamWriter objWriter;
                    objWriter = new System.IO.StreamWriter(filename, true);
                    objWriter.Write(DateTime.Now.ToString("dd-MMM-yyyy"));
                    objWriter.Write("---------------------------------------------"+ System.Environment.NewLine);
                    objWriter.Write(Error.ToString());
                    objWriter.Write(System.Environment.NewLine +"~~~~~~~~~~~~~~~~~~~"+ DateTime.Now.ToString("dd-MMM-yyyy"));
                    objWriter.Write("---------------------------------------------" + System.Environment.NewLine);
                    objWriter.Close();
                }
                else
                {
                    StreamWriter sw = System.IO.File.CreateText(Assembly.GetExecutingAssembly().Location.Replace(@"\DATA_LAYER.dll","")  + "\\ErrorLog.txt");
                    sw.Write(DateTime.Now.ToString("dd-MMM-yyyy"));
                    sw.Write("---------------------------------------------" + System.Environment.NewLine);
                    sw.Write(Error.ToString());
                    sw.Write(System.Environment.NewLine + "~~~~~~~~~~~~~~~~~~~" + DateTime.Now.ToString("dd-MMM-yyyy"));
                    sw.Write("---------------------------------------------" + System.Environment.NewLine);

                    sw.Close();
                }


                return txtline;
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
                return string.IsNullOrEmpty(txtline) ? "Office2010Blue" : txtline;
            }
        }
    }
}
