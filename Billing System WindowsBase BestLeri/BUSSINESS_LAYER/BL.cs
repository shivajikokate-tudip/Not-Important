using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

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
        public void validateNumber(KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != '.' & e.KeyChar != '-')
            {
                e.Handled = true;
            }
            //base.OnKeyPress(e);
        }
        public void validateNumberNotFloat(KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != '-')
            {
                e.Handled = true;
            }
            //base.OnKeyPress(e);
        }
        public DataSet DeleteRec(ListView lvw, List<string> s, int rno, string spname)
        {
            bool temp = false;
            DataSet ds = new DataSet();
            for (int i = 0; i < lvw.Items.Count; i++)
            {
                if (lvw.Items[i].Checked == true)
                {
                    DialogResult rs = MessageBox.Show("Are You Sure To Delete Records", "Exit", MessageBoxButtons.OKCancel);
                    temp = true;
                    //bool temp1 = false;
                    List<string> param = new List<string>();


                    if (rs.ToString().CompareTo("OK") == 0)
                    {
                        ds.Clear();
                        param.Clear();
                        param.Add("D");
                        param.Add(lvw.Items[i].SubItems[rno].Text.Trim());
                        ds = blFill_para_name(s, param, spname);

                    }
                }
            }
            if (temp == false)
            {
                MessageBox.Show("Please Select At Least One Record To Delete", "", MessageBoxButtons.OK);
                ds = blFill(spname);
            }
            return ds;
        }
    }
}
