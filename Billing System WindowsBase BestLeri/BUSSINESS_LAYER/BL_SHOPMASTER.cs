using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace BUSSINESS_LAYER
{
    public class BL_SHOPMASTER : BL, ICOMMON_CLASS_MASTER
    {
        int _Shop_Id;
        public int Shop_Id
        {
            get { return _Shop_Id; }
            set { _Shop_Id = value; }
        }

        string _Shop_Name;
        public string Shop_Name
        {
            get { return _Shop_Name; }
            set { _Shop_Name = value; }
        }

        string _Shop_Address;
        public string Shop_Address
        {
            get { return _Shop_Address; }
            set { _Shop_Address = value; }
        }

        string _Shop_ContactNo;
        public string Shop_ContactNo
        {
            get { return _Shop_ContactNo; }
            set { _Shop_ContactNo = value; }
        }

        string _Shop_CGSTno;
        public string Shop_CGSTno
        {
            get { return _Shop_CGSTno; }
            set { _Shop_CGSTno = value; }
        }

        string _Shop_SGSTno;
        public string Shop_SGSTno
        {
            get { return _Shop_SGSTno; }
            set { _Shop_SGSTno = value; }
        }

        string _Bank_Name;
        public string Bank_Name
        {
            get { return _Bank_Name; }
            set { _Bank_Name = value; }
        }

        string _Bank_Accountno;
        public string Bank_Accountno
        {
            get { return _Bank_Accountno; }
            set { _Bank_Accountno = value; }
        }

        string _IFSCCode;
        public string IFSCCode
        {
            get { return _IFSCCode; }
            set { _IFSCCode = value; }
        }

        string _PanNo;
        public string PanNo
        {
            get { return _PanNo; }
            set { _PanNo = value; }
        }

        public DataSet SELECT(object classObject)
        {
            return blFill("SP_ShopMaster");
        }

        public DataSet INSERT(object classObject)
        {
            Parameter.Clear();
            Parameter.Add("@Shop_Name", ((BL_SHOPMASTER)classObject).Shop_Name.ToString().Trim());
            Parameter.Add("@Shop_Address", ((BL_SHOPMASTER)classObject).Shop_Address.ToString().Trim());
            Parameter.Add("@Shop_ContactNo", ((BL_SHOPMASTER)classObject).Shop_ContactNo.ToString().Trim());
            Parameter.Add("@Shop_CGSTno", ((BL_SHOPMASTER)classObject).Shop_CGSTno.ToString().Trim());
            Parameter.Add("@Shop_SGSTno", ((BL_SHOPMASTER)classObject).Shop_SGSTno.ToString().Trim());
            Parameter.Add("@Bank_Name", ((BL_SHOPMASTER)classObject).Bank_Name.ToString().Trim());
            Parameter.Add("@Bank_Accountno", ((BL_SHOPMASTER)classObject).Bank_Accountno.ToString().Trim());
            Parameter.Add("@IFSCCode", ((BL_SHOPMASTER)classObject).IFSCCode.ToString().Trim());
            Parameter.Add("@PanNo", ((BL_SHOPMASTER)classObject).PanNo.ToString().Trim());
            Parameter.Add("@flag", "A");
            return blFill_Para_Name(Parameter, "SP_ShopMaster");
        }

        public DataSet UPDATE(object classObject)
        {
            Parameter.Clear();
            Parameter.Add("@Shop_Id", ((BL_SHOPMASTER)classObject).Shop_Id.ToString().Trim());
            Parameter.Add("@Shop_Name", ((BL_SHOPMASTER)classObject).Shop_Name.ToString().Trim());
            Parameter.Add("@Shop_Address", ((BL_SHOPMASTER)classObject).Shop_Address.ToString().Trim());
            Parameter.Add("@Shop_ContactNo", ((BL_SHOPMASTER)classObject).Shop_ContactNo.ToString().Trim());
            Parameter.Add("@Shop_CGSTno", ((BL_SHOPMASTER)classObject).Shop_CGSTno.ToString().Trim());
            Parameter.Add("@Shop_SGSTno", ((BL_SHOPMASTER)classObject).Shop_SGSTno.ToString().Trim());
            Parameter.Add("@Bank_Name", ((BL_SHOPMASTER)classObject).Bank_Name.ToString().Trim());
            Parameter.Add("@Bank_Accountno", ((BL_SHOPMASTER)classObject).Bank_Accountno.ToString().Trim());
            Parameter.Add("@IFSCCode", ((BL_SHOPMASTER)classObject).IFSCCode.ToString().Trim());
            Parameter.Add("@PanNo", ((BL_SHOPMASTER)classObject).PanNo.ToString().Trim());
            Parameter.Add("@flag", "U");
            return blFill_Para_Name(Parameter, "SP_ShopMaster");
        }

        public DataSet DELETE(object classObject)
        {
            Parameter.Clear();
            Parameter.Add("@Shop_Id", ((BL_SHOPMASTER)classObject).Shop_Id.ToString().Trim());
            Parameter.Add("@flag", "D");
            return blFill_Para_Name(Parameter, "SP_ShopMaster");
        }

        public void Fill_ListView(ListView Lvw, DataTable Dt)
        {
            throw new NotImplementedException();
        }
    }
}
