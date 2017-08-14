using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using DATA_LAYER;

namespace BUSSINESS_LAYER
{
    public class BL_MAIN_SERVER
    {
        public bool connectedYN()
        {
            return (DB_SERVER.OpenConnection());
        }
        public bool checkConnection()
        {
            return (DB_SERVER.checkConnection() == true ? true : false);
        }
        public bool checkConnection(string newconnectionstring)
        {
            return (DB_SERVER.checkConnection(newconnectionstring) == true ? true : false);
        }

        public DataSet blFill(String spname)
        {
            DataSet ds = new DataSet();
            try
            {
                ds = DB_SERVER.dlFill(spname);
            }
            catch (Exception err)
            {
                err.GetBaseException();
            }
            return (ds);
        }
        public DataSet blFill_With_Schema(String spname)
        {
            DataSet ds = new DataSet();
            try
            {
                ds = DB_SERVER.dlFill_Schema(spname);
            }
            catch (Exception err)
            {
                err.GetBaseException();
            }
            return (ds);
        }
        public DataSet blFill_With_Schema(SortedList<String, String> Parameters, String spname)
        {
            DataSet ds = new DataSet();
            try
            {
                ds = DB_SERVER.dlFill_Schema(Parameters, spname);
            }
            catch (Exception err)
            {
                err.GetBaseException();
            }
            return (ds);
        }
        public DataSet blFill_para(List<string> para, String spname)
        {
            DataSet ds = new DataSet();
            try
            {
                ds = DB_SERVER.dlFill1(para, spname);
            }
            catch (Exception err)
            {
                err.GetBaseException();
            }
            return (ds);
        }
        public DataSet blFill_Para_Name(List<String> paraname, List<String> parameterList, String spname)
        {
            DataSet ds = new DataSet();
            try
            {
                ds = DB_SERVER.dlFill1(paraname, parameterList, spname);
            }
            catch (Exception err)
            {
                err.GetBaseException();
            }
            return (ds);
        }
        public DataSet blFill_Para_Name(SortedList<String, String> para, String spname)
        {
            DataSet ds = new DataSet();
            try
            {
                ds = DB_SERVER.ExecuteStoredProcedureWithParametersWithName(para, spname);
            }
            catch (Exception err)
            {
                err.GetBaseException();
            }
            return (ds);
        }
        public DataSet blFill_Para_Name(Dictionary<String, String> para, String spname)
        {
            DataSet ds = new DataSet();
            try
            {
                ds = DB_SERVER.ExecuteStoredProcedureWithParametersWithName(para, spname);
            }
            catch (Exception err)
            {
                err.GetBaseException();
            }
            return (ds);
        }
        public DataSet blFill_Combo(List<string> para, String spname)
        {
            DataSet ds = new DataSet();
            try
            {
                ds = DB_SERVER.dlFill_combo(para, spname);
            }
            catch (Exception err)
            {
                err.GetBaseException();
            }
            return (ds);
        }
        public DataSet blFill_Combo_name(List<string> para_name, List<string> para_value, String spname)
        {
            DataSet ds = new DataSet();
            try
            {
                ds = DB_SERVER.dlFill_combo_name(para_name, para_value, spname);
            }
            catch (Exception err)
            {
                err.GetBaseException();
            }
            return (ds);
        }


        public DataSet ExecuteQuery(Dictionary<string, string> Parameter, string Query)
        {
            return DB_SERVER.ExecuteQuery(Parameter, Query);
        }
        public int ExecuteNonQuery(Dictionary<string, string> Parameter, string Query)
        {
            return DB_SERVER.ExecuteNonQuery(Parameter, Query);
        }

        public DataSet ExecuteQuery(string Query)
        {
            return DB_SERVER.ExecuteQuery(Query);
        }
        public int ExecuteNonQuery(string Query)
        {
            return DB_SERVER.ExecuteNonQuery(Query);
        }
    }
}
