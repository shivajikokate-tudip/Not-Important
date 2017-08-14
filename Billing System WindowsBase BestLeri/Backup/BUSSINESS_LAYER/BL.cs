using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DATA_LAYER;


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

    }
}
