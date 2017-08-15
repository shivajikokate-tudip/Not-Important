using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace BUSSINESS_LAYER
{
    public class BL : BL_LOCAL
    {
        
        public string Query;
        public Dictionary<string, string> Parameter;
        public SortedList<string, string> Parameters;
        public string Sp_Name;
        //public KeyValuePair<string,string> KeyValuePair;
        public BL()
        {
            Query = "";
            Sp_Name = "";
            Parameter = new Dictionary<string, string>();
            Parameter.Clear();
            Parameters = new SortedList<string, string>();
            Parameters.Clear();
        }

        public bool connectedYN()
        {
            return (DATA_LAYER.DB_SERVER.OpenConnection());
        }

        public bool checkConnection()
        {
            return (DATA_LAYER.DB_SERVER.checkConnection() == true ? true : false);
        }
        public bool checkConnection(string newconnectionstring)
        {
            return (DATA_LAYER.DB_SERVER.checkConnection(newconnectionstring) == true ? true : false);
        }
        public DataSet blFill_para_name(List<String> paraname, List<String> parameterList, String spname)
        {
            DataSet ds = new DataSet();
            try
            {
                ds = DATA_LAYER.DB_SERVER.dlFill1(paraname, parameterList, spname);
            }
            catch (Exception err)
            {
                err.GetBaseException();
            }
            return (ds);
        }
        public DataSet blFill(String spname)
        {
            DataSet ds = new DataSet();
            try
            {
                ds = DATA_LAYER.DB_SERVER.dlFill(spname);
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
                ds = DATA_LAYER.DB_SERVER.dlFill1(para, spname);
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
                ds = DATA_LAYER.DB_SERVER.dlFill_combo(para, spname);
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
                ds = DATA_LAYER.DB_SERVER.dlFill_combo_name(para_name, para_value, spname);
            }
            catch (Exception err)
            {
                err.GetBaseException();
            }
            return (ds);
        }
    }
}
