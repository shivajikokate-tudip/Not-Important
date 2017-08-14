using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace BUSSINESS_LAYER
{
    public class BL_CUSTOMERMASTER : BL, ICOMMON_CLASS_MASTER
    {
        int _Customer_Id;
        public int Customer_Id
        {
            get { return _Customer_Id; }
            set { _Customer_Id = value; }
        }
        int _Customer_No;
        public int Customer_No
        {
            get { return _Customer_No; }
            set { _Customer_No = value; }
        }
        string _Comp_Name;
        public string Comp_Name
        {
            get { return _Comp_Name; }
            set { _Comp_Name = value; }
        }
        string _Address;
        public string Address
        {
            get { return _Address; }
            set { _Address = value; }
        }
       
        string _Cust_Mobileno;
        public string Cust_Mobileno
        {
            get { return _Cust_Mobileno; }
            set { _Cust_Mobileno = value; }
        }
        string _Vat_No;
        public string Vat_No
        {
            get { return _Vat_No; }
            set { _Vat_No = value; }
        }
        string _Tin_No;
        public string Tin_No
        {
            get { return _Tin_No; }
            set { _Tin_No = value; }
        }

        public System.Data.DataSet SELECT(object classObject)
        {
            return blFill("SP_CustomerMaster");
        }

        public System.Data.DataSet INSERT(object classObject)
        {
            Parameter.Clear();
            Parameter.Add("@Customer_Id", ((BL_CUSTOMERMASTER)classObject).Customer_Id.ToString().Trim());
            Parameter.Add("@Customer_No", ((BL_CUSTOMERMASTER)classObject).Customer_No.ToString().Trim());
            Parameter.Add("@Comp_Name", ((BL_CUSTOMERMASTER)classObject).Comp_Name.ToString().Trim());
            Parameter.Add("@Address", ((BL_CUSTOMERMASTER)classObject).Address.ToString().Trim());
            Parameter.Add("@Cust_Mobileno",(((BL_CUSTOMERMASTER)classObject).Cust_Mobileno.ToString().Trim()));
            Parameter.Add("@Vat_No", ((BL_CUSTOMERMASTER)classObject).Vat_No.ToString().Trim());
            Parameter.Add("@Tin_No", ((BL_CUSTOMERMASTER)classObject).Tin_No.ToString().Trim());
            Parameter.Add("@flag", "A");
            return blFill_Para_Name(Parameter, "SP_CustomerMaster");
        }

        public System.Data.DataSet UPDATE(object classObject)
        {
            Parameter.Clear();
            Parameter.Add("@Customer_Id", ((BL_CUSTOMERMASTER)classObject).Customer_Id.ToString().Trim());
            Parameter.Add("@Customer_No", ((BL_CUSTOMERMASTER)classObject).Customer_No.ToString().Trim());
            Parameter.Add("@Comp_Name", ((BL_CUSTOMERMASTER)classObject).Comp_Name.ToString().Trim());
            Parameter.Add("@Address", ((BL_CUSTOMERMASTER)classObject).Address.ToString().Trim());
            Parameter.Add("@Cust_Mobileno", ((BL_CUSTOMERMASTER)classObject).Cust_Mobileno.ToString().Trim());
            Parameter.Add("@Vat_No", ((BL_CUSTOMERMASTER)classObject).Vat_No.ToString().Trim());
            Parameter.Add("@Tin_No", ((BL_CUSTOMERMASTER)classObject).Tin_No.ToString().Trim());
            Parameter.Add("@flag", "U");
            return blFill_Para_Name(Parameter, "SP_CustomerMaster");
        }

        public System.Data.DataSet DELETE(object classObject)
        {
            Parameter.Clear();
            Parameter.Add("@Customer_Id", ((BL_CUSTOMERMASTER)classObject).Customer_Id.ToString().Trim());
            Parameter.Add("@flag", "D");
            return blFill_Para_Name(Parameter, "SP_CustomerMaster");
        }

        public void Fill_ListView(System.Windows.Forms.ListView Lvw, System.Data.DataTable Dt)
        {
            throw new NotImplementedException();
        }
    }
}
