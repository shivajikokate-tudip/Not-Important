using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using DATA_LAYER;
namespace BUSSINESS_LAYER
{
    public class BL_LOCAL : BL_MAIN_SERVER
    {
        //DB_LOCAL DB_LOCAL = new DB_LOCAL();
        public bool connectedYN_Local()
        {
            return (DB_LOCAL.OpenConnection());
        }
        public bool checkConnection_Local()
        {
            return (DB_LOCAL.checkConnection_Local() == true ? true : false);
        }
        public bool checkConnection_Local(string newconnectionstring,string Con_Type)
        {
            return DB_LOCAL.checkConnection_Local(newconnectionstring, Con_Type) == true ? true : false;
        }

        public DataSet ExecuteQuery(string Query)
        {
            return DB_LOCAL.ExecuteQuery(Query);
        }
        public DataSet ExecuteQuery(Dictionary<string, string> Parameter, string Query)
        {
            return DB_LOCAL.ExecuteQuery(Parameter, Query);
        }
        public string ExecuteScaler(string Query)
        {
            return DB_LOCAL.ExecuteScaler(Query);
        }
        public string ExecuteScaler(Dictionary<string, string> Parameter, string Query)
        {
            return DB_LOCAL.ExecuteScaler(Parameter, Query);
        }
        public int ExecuteNonQuery(string Query)
        {
            return DB_LOCAL.ExecuteNonQuery(Query);
        }
        public int ExecuteNonQuery(Dictionary<string, string> Parameter, string Query)
        {
            return DB_LOCAL.ExecuteNonQuery(Parameter, Query);
        }


    }
}
