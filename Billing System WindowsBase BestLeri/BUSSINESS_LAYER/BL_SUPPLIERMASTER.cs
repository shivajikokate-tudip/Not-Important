using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace BUSSINESS_LAYER
{
    public class BL_SUPPLIERMASTER:BL,ICOMMON_CLASS_MASTER
    {
        int _Supplier_Id;
        public int Supplier_Id
        {
            get { return _Supplier_Id; }
            set { _Supplier_Id = value; }
        }
        int _SupplierNo;
        public int SupplierNo
        {
            get { return _SupplierNo; }
            set { _SupplierNo = value; }
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
        string _Supplier_Mobileno;
        public string Supplier_Mobileno
        {
            get { return _Supplier_Mobileno; }
            set { _Supplier_Mobileno = value; }
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
        public DataSet SELECT(object classObject)
        {
            return blFill("SP_SupplierMaster");
        }

        public DataSet INSERT(object classObject)
        {
            Parameter.Clear();
            //Parameter.Add("@Supplier_Id", ((BL_SUPPLIERMASTER)classObject).Supplier_Id.ToString().Trim());
            Parameter.Add("@SupplierNo", ((BL_SUPPLIERMASTER)classObject).SupplierNo.ToString().Trim());
            Parameter.Add("@Comp_Name", ((BL_SUPPLIERMASTER)classObject).Comp_Name.ToString().Trim());
            Parameter.Add("@Address", ((BL_SUPPLIERMASTER)classObject).Address.ToString().Trim());
            Parameter.Add("@Supplier_Mobileno", (((BL_SUPPLIERMASTER)classObject).Supplier_Mobileno.ToString().Trim()));
            Parameter.Add("@Vat_No", ((BL_SUPPLIERMASTER)classObject).Vat_No.ToString().Trim());
            Parameter.Add("@Tin_No", ((BL_SUPPLIERMASTER)classObject).Tin_No.ToString().Trim());
            Parameter.Add("@flag", "A");
            return blFill_Para_Name(Parameter, "SP_SupplierMaster");
        }

        public DataSet UPDATE(object classObject)
        {
            Parameter.Clear();
            Parameter.Add("@Supplier_Id", ((BL_SUPPLIERMASTER)classObject).Supplier_Id.ToString().Trim());
            Parameter.Add("@SupplierNo", ((BL_SUPPLIERMASTER)classObject).SupplierNo.ToString().Trim());
            Parameter.Add("@Comp_Name", ((BL_SUPPLIERMASTER)classObject).Comp_Name.ToString().Trim());
            Parameter.Add("@Address", ((BL_SUPPLIERMASTER)classObject).Address.ToString().Trim());
            Parameter.Add("@Supplier_Mobileno", (((BL_SUPPLIERMASTER)classObject).Supplier_Mobileno.ToString().Trim()));
            Parameter.Add("@Vat_No", ((BL_SUPPLIERMASTER)classObject).Vat_No.ToString().Trim());
            Parameter.Add("@Tin_No", ((BL_SUPPLIERMASTER)classObject).Tin_No.ToString().Trim());
            Parameter.Add("@flag", "U");
            return blFill_Para_Name(Parameter, "SP_SupplierMaster");
        }

        public DataSet DELETE(object classObject)
        {
            Parameter.Clear();
            Parameter.Add("@Supplier_Id", ((BL_SUPPLIERMASTER)classObject).Supplier_Id.ToString().Trim());           
            Parameter.Add("@flag", "D");
            return blFill_Para_Name(Parameter, "SP_SupplierMaster");
        }

        public void Fill_ListView(ListView Lvw, DataTable Dt)
        {
            throw new NotImplementedException();
        }
    }
}
