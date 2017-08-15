using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using BUSSINESS_LAYER;

namespace BUSSINESS_LAYER
{
    public class BL_BILLINGINVOICE : BL, ICOMMON_CLASS_MASTER
    {
        BL bl = new BL();
        BUSSINESS_LAYER.BL bl_obj = new BUSSINESS_LAYER.BL();
        int _itemid;
        public int itemid
        {
            get { return _itemid; }
            set { _itemid = value; }
        }
        string _flag;
        public string flag
        {
            get { return _flag; }
            set { _flag = value; }
        }
        int _Sales_Id;
        public int Sales_Id
        {
            get { return _Sales_Id; }
            set { _Sales_Id = value; }
        }

        int _Invoice_Number;
        public int Invoice_Number
        {
            get { return _Invoice_Number; }
            set { _Invoice_Number = value; }
        }
        int _Customer_Id;
        public int Customer_Id
        {
            get { return _Customer_Id; }
            set { _Customer_Id = value; }
        }

        int _PayModeId;
        public int PayModeId
        {
            get { return _PayModeId; }
            set { _PayModeId = value; }
        }
        string _Tras_Date;
        public string Tras_Date
        {
            get { return _Tras_Date; }
            set { _Tras_Date = value; }
        }

        double _Amount;
        public double Amount
        {
            get { return _Amount; }
            set { _Amount = value; }
        }
        double _Grand_Total;
        public double Grand_Total
        {
            get { return _Grand_Total; }
            set { _Grand_Total = value; }
        }

        double _Paid;
        public double Paid
        {
            get { return _Paid; }
            set { _Paid = value; }
        }
        double _On_Credit;
        public double On_Credit
        {
            get { return _On_Credit; }
            set { _On_Credit = value; }
        }
        double _Discount;
        public double Discount
        {
            get { return _Discount; }
            set { _Discount = value; }
        }
        double _Vat;
        public double Vat
        {
            get { return _Vat; }
            set { _Vat = value; }
        }
        int _Carton;
        public int Carton
        {
            get { return _Carton; }
            set { _Carton = value; }
        }
        int _Transportation;
        public int Transportation
        {
            get { return _Transportation; }
            set { _Transportation = value; }
        }

        int _Sales_Details_id;
        public int Sales_Details_id
        {
            get { return _Sales_Details_id; }
            set { _Sales_Details_id = value; }
        }

        int _SubItemId;
        public int SubItemId
        {
            get { return _SubItemId; }
            set { _SubItemId = value; }
        }

        double _Quantity;
        public double Quantity
        {
            get { return _Quantity; }
            set { _Quantity = value; }
        }
        double _Rate;
        public double Rate
        {
            get { return _Rate; }
            set { _Rate = value; }
        }
        double _Total;
        public double Total
        {
            get { return _Total; }
            set { _Total = value; }
        }
        string _form;
        public string form
        {
            get { return _form; }
            set { _form = value; }
        }
        string _TrasportEmp_Id, _TEmployee_Number;
        public string TrasportEmp_Id
        {
            get { return _TrasportEmp_Id; }
            set { _TrasportEmp_Id = value; }
        }

        public string TEmployee_Number
        {
            get { return _TEmployee_Number; }
            set { _TEmployee_Number = value; }
        }

        string _TEmployee_Name;
        public string TEmployee_Name
        {
            get { return _TEmployee_Name; }
            set { _TEmployee_Name = value; }
        }

        string _TVehicale_Number;
        public string TVehicale_Number
        {
            get { return _TVehicale_Number; }
            set { _TVehicale_Number = value; }
        }
        string _Number;
        public string Number
        {
            get { return _Number; }
            set { _Number = value; }
        }

        string _Details;
        public string Details
        {
            get { return _Details; }
            set { _Details = value; }
        }

        int _Pay_Mode_Id;
        public int Pay_Mode_Id
        {
            get { return _Pay_Mode_Id; }
            set { _Pay_Mode_Id = value; }
        }
        int _Account_Id;
        public int Account_Id
        {
            get { return _Account_Id; }
            set { _Account_Id = value; }
        }

        public DataSet SELECT(object classObject)
        {
            DataSet dsf = new DataSet();
            try
            {
                if (((BL_BILLINGINVOICE)classObject).form.ToString().Trim() == "S")
                {
                    dsf = blFill("Sp_SalesInvoice");
                }
                else if (((BL_BILLINGINVOICE)classObject).form.ToString().Trim() == "P")
                {
                    dsf = blFill("Sp_PurchaseInvoice");
                }
            }
            catch (Exception err)
            {
                err.GetBaseException();
            } return dsf;
        }

        public DataSet INSERT(object classObject)
        {
            DataSet ds = new DataSet();
            try
            {
                Parameter.Clear();
                if (((BL_BILLINGINVOICE)classObject).form.ToString().Trim() == "SI")
                {

                    Parameter.Add("@Tras_Date", ((BL_BILLINGINVOICE)classObject).Tras_Date.ToString().Trim());
                    Parameter.Add("@Customer_Id", ((BL_BILLINGINVOICE)classObject).Customer_Id.ToString().Trim());
                    Parameter.Add("@Amount", ((BL_BILLINGINVOICE)classObject).Total.ToString().Trim());
                    Parameter.Add("@Grand_Total", ((BL_BILLINGINVOICE)classObject).Grand_Total.ToString().Trim());
                    Parameter.Add("@Paid", ((BL_BILLINGINVOICE)classObject).Paid.ToString().Trim());
                    Parameter.Add("@On_Credit", ((BL_BILLINGINVOICE)classObject).On_Credit.ToString().Trim());
                    Parameter.Add("@Discount", ((BL_BILLINGINVOICE)classObject).Discount.ToString().Trim());
                    Parameter.Add("@Vat", ((BL_BILLINGINVOICE)classObject).Vat.ToString().Trim());
                    Parameter.Add("@Transportation_Id", "0");
                    Parameter.Add("@Carton", ((BL_BILLINGINVOICE)classObject).Carton.ToString().Trim());
                    Parameter.Add("@flag", "AI");
                    ds = blFill_Para_Name(Parameter, "Sp_SalesInvoice");
                }
                if (((BL_BILLINGINVOICE)classObject).form.ToString().Trim() == "SP")
                {
                    Parameter.Add("@Tras_Date", ((BL_BILLINGINVOICE)classObject).Tras_Date.ToString().Trim());
                    Parameter.Add("@Invoice_Number", ((BL_BILLINGINVOICE)classObject).Invoice_Number.ToString().Trim());
                    Parameter.Add("@Sales_Id", ((BL_BILLINGINVOICE)classObject).Sales_Id.ToString().Trim());
                    Parameter.Add("@SubItemId", ((BL_BILLINGINVOICE)classObject).SubItemId.ToString().Trim());
                    Parameter.Add("@Quantity", ((BL_BILLINGINVOICE)classObject).Quantity.ToString().Trim());
                    Parameter.Add("@Rate", ((BL_BILLINGINVOICE)classObject).Rate.ToString().Trim());
                    Parameter.Add("@Total", ((BL_BILLINGINVOICE)classObject).Amount.ToString().Trim());
                    Parameter.Add("@flag", "AP");
                    ds = blFill_Para_Name(Parameter, "Sp_SalesInvoice");
                }
                if (((BL_BILLINGINVOICE)classObject).form.ToString().Trim() == "PI")
                {
                    Parameter.Add("@Invoice_Number", ((BL_BILLINGINVOICE)classObject).Invoice_Number.ToString().Trim());
                    Parameter.Add("@Tran_Date", ((BL_BILLINGINVOICE)classObject).Tras_Date.ToString().Trim());
                    Parameter.Add("@Customer_Id", ((BL_BILLINGINVOICE)classObject).Customer_Id.ToString().Trim());
                    Parameter.Add("@Sub_Total", ((BL_BILLINGINVOICE)classObject).Total.ToString().Trim());
                    Parameter.Add("@Tax", ((BL_BILLINGINVOICE)classObject).Vat.ToString().Trim());
                    Parameter.Add("@Grand_Total", ((BL_BILLINGINVOICE)classObject).Grand_Total.ToString().Trim());
                    Parameter.Add("@ExciseDuety", ((BL_BILLINGINVOICE)classObject).Discount.ToString().Trim());
                    Parameter.Add("@Paid", ((BL_BILLINGINVOICE)classObject).Paid.ToString().Trim());
                    Parameter.Add("@On_Credit", ((BL_BILLINGINVOICE)classObject).On_Credit.ToString().Trim());
                    Parameter.Add("@flag", "AI");
                    ds = blFill_Para_Name(Parameter, "Sp_PurchaseInvoice");
                }
                if (((BL_BILLINGINVOICE)classObject).form.ToString().Trim() == "PP")
                {
                    Parameter.Add("@Purchase_Id", ((BL_BILLINGINVOICE)classObject).Sales_Id.ToString().Trim());
                    Parameter.Add("@Invoice_Number", ((BL_BILLINGINVOICE)classObject).Invoice_Number.ToString().Trim());
                    Parameter.Add("@SubItemId", ((BL_BILLINGINVOICE)classObject).SubItemId.ToString().Trim());
                    Parameter.Add("@Quantity", ((BL_BILLINGINVOICE)classObject).Quantity.ToString().Trim());
                    Parameter.Add("@Prise", ((BL_BILLINGINVOICE)classObject).Rate.ToString().Trim());
                    Parameter.Add("@Total", ((BL_BILLINGINVOICE)classObject).Amount.ToString().Trim());
                    Parameter.Add("@Tran_Date", ((BL_BILLINGINVOICE)classObject).Tras_Date.ToString().Trim());
                    Parameter.Add("@flag", "AP");
                    ds = blFill_Para_Name(Parameter, "Sp_PurchaseInvoice");
                }
                if (((BL_BILLINGINVOICE)classObject).form.ToString().Trim() == "PY")
                {
                    Parameter.Add("@PayModeId", ((BL_BILLINGINVOICE)classObject).PayModeId.ToString().Trim());
                    Parameter.Add("@Number", ((BL_BILLINGINVOICE)classObject).Number.ToString().Trim());
                    Parameter.Add("@Details", ((BL_BILLINGINVOICE)classObject).Details.ToString().Trim());
                    Parameter.Add("@Tras_Date", ((BL_BILLINGINVOICE)classObject).Tras_Date.ToString().Trim());
                    Parameter.Add("@Pay_Mode_Id", ((BL_BILLINGINVOICE)classObject).Pay_Mode_Id.ToString().Trim());
                    Parameter.Add("@Billing_ID", ((BL_BILLINGINVOICE)classObject).Sales_Id.ToString().Trim());
                    Parameter.Add("@Invoice_Type", ((BL_BILLINGINVOICE)classObject).flag.ToString().Trim());
                    Parameter.Add("@To_Acc", ((BL_BILLINGINVOICE)classObject).Account_Id.ToString().Trim());
                    Parameter.Add("@flag", "PY");
                    ds = blFill_Para_Name(Parameter, "Sp_SalesInvoice");
                } 
                if (((BL_BILLINGINVOICE)classObject).form.ToString().Trim() == "TP")
                {
                    Parameter.Add("@TrasportEmp_Id", ((BL_BILLINGINVOICE)classObject).TrasportEmp_Id.ToString().Trim());
                    Parameter.Add("@TEmployee_Name", ((BL_BILLINGINVOICE)classObject).TEmployee_Name.ToString().Trim());
                    Parameter.Add("@TVehicale_Number", ((BL_BILLINGINVOICE)classObject).TVehicale_Number.ToString().Trim());
                    Parameter.Add("@TEmployee_Number", ((BL_BILLINGINVOICE)classObject).TEmployee_Number.ToString().Trim());
                    Parameter.Add("@Transportation_Id", ((BL_BILLINGINVOICE)classObject).Transportation.ToString().Trim());
                    Parameter.Add("@Sales_Id", ((BL_BILLINGINVOICE)classObject).Sales_Id.ToString().Trim());
                    Parameter.Add("@flag", "TP");
                    ds = blFill_Para_Name(Parameter, "Sp_SalesInvoice");
                }
            }
            catch (Exception err)
            {
                err.GetBaseException();
            }
            return ds;
        }

        public DataSet UPDATE(object classObject)
        {
            DataSet ds = new DataSet();
            try
            {
                Parameter.Clear();
                if (((BL_BILLINGINVOICE)classObject).form.ToString().Trim() == "SI")
                {
                    Parameter.Add("@Sales_Id", ((BL_BILLINGINVOICE)classObject).Sales_Id.ToString().Trim());
                    Parameter.Add("@Invoice_Number", ((BL_BILLINGINVOICE)classObject).Invoice_Number.ToString().Trim());
                    Parameter.Add("@Tras_Date", ((BL_BILLINGINVOICE)classObject).Tras_Date.ToString().Trim());
                    Parameter.Add("@Customer_Id", ((BL_BILLINGINVOICE)classObject).Customer_Id.ToString().Trim());
                    Parameter.Add("@Amount", ((BL_BILLINGINVOICE)classObject).Total.ToString().Trim());
                    Parameter.Add("@Grand_Total", ((BL_BILLINGINVOICE)classObject).Grand_Total.ToString().Trim());
                    Parameter.Add("@Paid", ((BL_BILLINGINVOICE)classObject).Paid.ToString().Trim());
                    Parameter.Add("@On_Credit", ((BL_BILLINGINVOICE)classObject).On_Credit.ToString().Trim());
                    Parameter.Add("@Discount", ((BL_BILLINGINVOICE)classObject).Discount.ToString().Trim());
                    Parameter.Add("@Vat", ((BL_BILLINGINVOICE)classObject).Vat.ToString().Trim());
                    Parameter.Add("@Transportation_Id", "0");
                    //Parameter.Add("@Carton", ((BL_BILLINGINVOICE)classObject).Carton.ToString().Trim());
                    Parameter.Add("@flag", "UI");
                    ds = blFill_Para_Name(Parameter, "Sp_SalesInvoice");
                }
                if (((BL_BILLINGINVOICE)classObject).form.ToString().Trim() == "SP")
                {
                    Parameter.Add("@Tras_Date", ((BL_BILLINGINVOICE)classObject).Tras_Date.ToString().Trim());
                    Parameter.Add("@Sales_Details_id", ((BL_BILLINGINVOICE)classObject).Sales_Details_id.ToString().Trim());
                    Parameter.Add("@Invoice_Number", ((BL_BILLINGINVOICE)classObject).Invoice_Number.ToString().Trim());
                    Parameter.Add("@Sales_Id", ((BL_BILLINGINVOICE)classObject).Sales_Id.ToString().Trim());
                    Parameter.Add("@SubItemId", ((BL_BILLINGINVOICE)classObject).SubItemId.ToString().Trim());
                    Parameter.Add("@Quantity", ((BL_BILLINGINVOICE)classObject).Quantity.ToString().Trim());
                    Parameter.Add("@Rate", ((BL_BILLINGINVOICE)classObject).Rate.ToString().Trim());
                    Parameter.Add("@Total", ((BL_BILLINGINVOICE)classObject).Amount.ToString().Trim());
                    Parameter.Add("@flag", "UP");
                    ds = blFill_Para_Name(Parameter, "Sp_SalesInvoice");
                }
                if (((BL_BILLINGINVOICE)classObject).form.ToString().Trim() == "PI")
                {
                    Parameter.Add("@Purchase_Id", ((BL_BILLINGINVOICE)classObject).Sales_Id.ToString().Trim());
                    Parameter.Add("@Invoice_Number", ((BL_BILLINGINVOICE)classObject).Invoice_Number.ToString().Trim());
                    Parameter.Add("@Tran_Date", ((BL_BILLINGINVOICE)classObject).Tras_Date.ToString().Trim());
                    Parameter.Add("@Customer_Id", ((BL_BILLINGINVOICE)classObject).Customer_Id.ToString().Trim());
                    Parameter.Add("@Sub_Total", ((BL_BILLINGINVOICE)classObject).Total.ToString().Trim());
                    Parameter.Add("@Tax", ((BL_BILLINGINVOICE)classObject).Vat.ToString().Trim());
                    Parameter.Add("@Grand_Total", ((BL_BILLINGINVOICE)classObject).Grand_Total.ToString().Trim());
                    Parameter.Add("@ExciseDuety", ((BL_BILLINGINVOICE)classObject).Discount.ToString().Trim());
                    Parameter.Add("@Paid", ((BL_BILLINGINVOICE)classObject).Paid.ToString().Trim());
                    Parameter.Add("@On_Credit", ((BL_BILLINGINVOICE)classObject).On_Credit.ToString().Trim());
                    Parameter.Add("@flag", "UI");
                    ds = blFill_Para_Name(Parameter, "Sp_PurchaseInvoice");
                }
                if (((BL_BILLINGINVOICE)classObject).form.ToString().Trim() == "PP")
                {
                    Parameter.Add("@Purchase_Item_id", ((BL_BILLINGINVOICE)classObject).Sales_Details_id.ToString().Trim());
                    Parameter.Add("@Purchase_Id", ((BL_BILLINGINVOICE)classObject).Sales_Id.ToString().Trim());
                    Parameter.Add("@Invoice_Number", ((BL_BILLINGINVOICE)classObject).Invoice_Number.ToString().Trim());
                    Parameter.Add("@SubItemId", ((BL_BILLINGINVOICE)classObject).SubItemId.ToString().Trim());
                    Parameter.Add("@Quantity", ((BL_BILLINGINVOICE)classObject).Quantity.ToString().Trim());
                    Parameter.Add("@Prise", ((BL_BILLINGINVOICE)classObject).Rate.ToString().Trim());
                    Parameter.Add("@Total", ((BL_BILLINGINVOICE)classObject).Amount.ToString().Trim());
                    Parameter.Add("@Tran_Date", ((BL_BILLINGINVOICE)classObject).Tras_Date.ToString().Trim());
                    Parameter.Add("@flag", "UP");
                    ds = blFill_Para_Name(Parameter, "Sp_PurchaseInvoice");
                }
                if (((BL_BILLINGINVOICE)classObject).form.ToString().Trim() == "PY")
                {
                    Parameter.Add("@PayModeId", ((BL_BILLINGINVOICE)classObject).PayModeId.ToString().Trim());
                    Parameter.Add("@Number", ((BL_BILLINGINVOICE)classObject).Number.ToString().Trim());
                    Parameter.Add("@Details", ((BL_BILLINGINVOICE)classObject).Details.ToString().Trim());
                    Parameter.Add("@Tras_Date", ((BL_BILLINGINVOICE)classObject).Tras_Date.ToString().Trim());
                    Parameter.Add("@Pay_Mode_Id", ((BL_BILLINGINVOICE)classObject).Pay_Mode_Id.ToString().Trim());
                    Parameter.Add("@Billing_ID", ((BL_BILLINGINVOICE)classObject).Sales_Id.ToString().Trim());
                    Parameter.Add("@Invoice_Type", ((BL_BILLINGINVOICE)classObject).flag.ToString().Trim());
                    Parameter.Add("@flag", "PY");
                    ds = blFill_Para_Name(Parameter, "Sp_SalesInvoice");
                }
                if (((BL_BILLINGINVOICE)classObject).form.ToString().Trim() == "TP")
                {
                    Parameter.Add("@TrasportEmp_Id", ((BL_BILLINGINVOICE)classObject).TrasportEmp_Id.ToString().Trim());
                    Parameter.Add("@TEmployee_Name", ((BL_BILLINGINVOICE)classObject).TEmployee_Name.ToString().Trim());
                    Parameter.Add("@TVehicale_Number", ((BL_BILLINGINVOICE)classObject).TVehicale_Number.ToString().Trim());
                    Parameter.Add("@TEmployee_Number", ((BL_BILLINGINVOICE)classObject).TEmployee_Number.ToString().Trim());
                    Parameter.Add("@Transportation_Id", ((BL_BILLINGINVOICE)classObject).Transportation.ToString().Trim());
                    Parameter.Add("@Sales_Id", ((BL_BILLINGINVOICE)classObject).Sales_Id.ToString().Trim());
                    Parameter.Add("@flag", "TP");
                    ds = blFill_Para_Name(Parameter, "Sp_SalesInvoice");
                }
            }
            catch (Exception err)
            {
                err.GetBaseException();
            }
            return ds;
            //throw new NotImplementedException();
        }

        public DataSet DELETE(object classObject)
        {
            DataSet ds = new DataSet();
            try
            {
                Parameter.Clear();
                if (((BL_BILLINGINVOICE)classObject).form.ToString().Trim() == "SI")
                {

                    Parameter.Add("@Tras_Date", ((BL_BILLINGINVOICE)classObject).Tras_Date.ToString().Trim());
                    Parameter.Add("@Customer_Id", ((BL_BILLINGINVOICE)classObject).Customer_Id.ToString().Trim());
                    Parameter.Add("@Amount", ((BL_BILLINGINVOICE)classObject).Total.ToString().Trim());
                    Parameter.Add("@Grand_Total", ((BL_BILLINGINVOICE)classObject).Grand_Total.ToString().Trim());
                    Parameter.Add("@Paid", ((BL_BILLINGINVOICE)classObject).Paid.ToString().Trim());
                    Parameter.Add("@On_Credit", ((BL_BILLINGINVOICE)classObject).On_Credit.ToString().Trim());
                    Parameter.Add("@Discount", ((BL_BILLINGINVOICE)classObject).Discount.ToString().Trim());
                    Parameter.Add("@Vat", ((BL_BILLINGINVOICE)classObject).Vat.ToString().Trim());
                    Parameter.Add("@Transportation_Id", "0");
                    Parameter.Add("@Carton", ((BL_BILLINGINVOICE)classObject).Carton.ToString().Trim());
                    Parameter.Add("@flag", "UI");
                    ds = blFill_Para_Name(Parameter, "Sp_SalesInvoice");
                }
                if (((BL_BILLINGINVOICE)classObject).form.ToString().Trim() == "SP")
                {
                    Parameter.Add("@Tras_Date", ((BL_BILLINGINVOICE)classObject).Tras_Date.ToString().Trim());
                    Parameter.Add("@Sales_Details_id", ((BL_BILLINGINVOICE)classObject).Sales_Details_id.ToString().Trim());
                    Parameter.Add("@Invoice_Number", ((BL_BILLINGINVOICE)classObject).Invoice_Number.ToString().Trim());
                    Parameter.Add("@Sales_Id", ((BL_BILLINGINVOICE)classObject).Sales_Id.ToString().Trim());
                    Parameter.Add("@SubItemId", ((BL_BILLINGINVOICE)classObject).SubItemId.ToString().Trim());
                    Parameter.Add("@Quantity", ((BL_BILLINGINVOICE)classObject).Quantity.ToString().Trim());
                    Parameter.Add("@Rate", ((BL_BILLINGINVOICE)classObject).Rate.ToString().Trim());
                    Parameter.Add("@Total", ((BL_BILLINGINVOICE)classObject).Amount.ToString().Trim());
                    Parameter.Add("@flag", "DP");
                    ds = blFill_Para_Name(Parameter, "Sp_SalesInvoice");
                }
                if (((BL_BILLINGINVOICE)classObject).form.ToString().Trim() == "PI")
                {
                    Parameter.Add("@Invoice_Number", ((BL_BILLINGINVOICE)classObject).Invoice_Number.ToString().Trim());
                    Parameter.Add("@Tran_Date", ((BL_BILLINGINVOICE)classObject).Tras_Date.ToString().Trim());
                    Parameter.Add("@Customer_Id", ((BL_BILLINGINVOICE)classObject).Customer_Id.ToString().Trim());
                    Parameter.Add("@Sub_Total", ((BL_BILLINGINVOICE)classObject).Total.ToString().Trim());
                    Parameter.Add("@Tax", ((BL_BILLINGINVOICE)classObject).Vat.ToString().Trim());
                    Parameter.Add("@Grand_Total", ((BL_BILLINGINVOICE)classObject).Grand_Total.ToString().Trim());
                    Parameter.Add("@ExciseDuety", ((BL_BILLINGINVOICE)classObject).Discount.ToString().Trim());
                    Parameter.Add("@Paid", ((BL_BILLINGINVOICE)classObject).Paid.ToString().Trim());
                    Parameter.Add("@On_Credit", ((BL_BILLINGINVOICE)classObject).On_Credit.ToString().Trim());
                    Parameter.Add("@flag", "AI");
                    ds = blFill_Para_Name(Parameter, "Sp_PurchaseInvoice");
                }
                if (((BL_BILLINGINVOICE)classObject).form.ToString().Trim() == "PP")
                {
                    Parameter.Add("@Purchase_Item_id", ((BL_BILLINGINVOICE)classObject).Sales_Details_id.ToString().Trim());
                    Parameter.Add("@Purchase_Id", ((BL_BILLINGINVOICE)classObject).Sales_Id.ToString().Trim());
                    Parameter.Add("@Invoice_Number", ((BL_BILLINGINVOICE)classObject).Invoice_Number.ToString().Trim());
                    Parameter.Add("@SubItemId", ((BL_BILLINGINVOICE)classObject).SubItemId.ToString().Trim());
                    Parameter.Add("@Quantity", ((BL_BILLINGINVOICE)classObject).Quantity.ToString().Trim());
                    Parameter.Add("@Prise", ((BL_BILLINGINVOICE)classObject).Rate.ToString().Trim());
                    Parameter.Add("@Total", ((BL_BILLINGINVOICE)classObject).Amount.ToString().Trim());
                    Parameter.Add("@Tran_Date", ((BL_BILLINGINVOICE)classObject).Tras_Date.ToString().Trim());
                    Parameter.Add("@flag", "DP");
                    ds = blFill_Para_Name(Parameter, "Sp_PurchaseInvoice");
                }
                if (((BL_BILLINGINVOICE)classObject).form.ToString().Trim() == "PY")
                {
                    Parameter.Add("@PayModeId", ((BL_BILLINGINVOICE)classObject).PayModeId.ToString().Trim());
                    Parameter.Add("@Number", ((BL_BILLINGINVOICE)classObject).Number.ToString().Trim());
                    Parameter.Add("@Details", ((BL_BILLINGINVOICE)classObject).Details.ToString().Trim());
                    Parameter.Add("@Tras_Date", ((BL_BILLINGINVOICE)classObject).Tras_Date.ToString().Trim());
                    Parameter.Add("@Pay_Mode_Id", ((BL_BILLINGINVOICE)classObject).Pay_Mode_Id.ToString().Trim());
                    Parameter.Add("@Billing_ID", ((BL_BILLINGINVOICE)classObject).Sales_Id.ToString().Trim());
                    Parameter.Add("@Invoice_Type", ((BL_BILLINGINVOICE)classObject).flag.ToString().Trim());
                    Parameter.Add("@flag", "PY");
                    ds = blFill_Para_Name(Parameter, "Sp_SalesInvoice");
                }
                if (((BL_BILLINGINVOICE)classObject).form.ToString().Trim() == "TP")
                {
                    Parameter.Add("@TrasportEmp_Id", ((BL_BILLINGINVOICE)classObject).TrasportEmp_Id.ToString().Trim());
                    Parameter.Add("@TEmployee_Name", ((BL_BILLINGINVOICE)classObject).TEmployee_Name.ToString().Trim());
                    Parameter.Add("@TVehicale_Number", ((BL_BILLINGINVOICE)classObject).TVehicale_Number.ToString().Trim());
                    Parameter.Add("@TEmployee_Number", ((BL_BILLINGINVOICE)classObject).TEmployee_Number.ToString().Trim());
                    Parameter.Add("@Transportation_Id", ((BL_BILLINGINVOICE)classObject).Transportation.ToString().Trim());
                    Parameter.Add("@Sales_Id", ((BL_BILLINGINVOICE)classObject).Sales_Id.ToString().Trim());
                    Parameter.Add("@flag", "TP");
                    ds = blFill_Para_Name(Parameter, "Sp_SalesInvoice");
                }
            }
            catch (Exception err)
            {
                err.GetBaseException();
            }
            return ds;
            //throw new NotImplementedException();
        }

        public void Fill_ListView(ListView Lvw, DataTable Dt)
        {
            throw new NotImplementedException();
        }

        public System.Data.DataSet dropdown(object classobject)
        {
            Parameter.Clear();
            Parameter.Add("@itemid", ((BL_BILLINGINVOICE)classobject).itemid.ToString().Trim());
            Parameter.Add("@flag", ((BL_BILLINGINVOICE)classobject).flag.ToString().Trim());
            return blFill_Para_Name(Parameter, "SP_FILLDDL");
        }
        public DataSet REPORT(object classObject)
        {
            Parameter.Clear();
            Parameter.Add("@Data_Id", ((BL_BILLINGINVOICE)classObject).Invoice_Number.ToString().Trim());
            Parameter.Add("@flag", "SI");
            //DataSet dsr = new DataSet();
            return blFill_Para_Name(Parameter, "SP_Report");
        }
        public DataSet BALANCE(object classObject)
        {
            Parameter.Clear();
            Parameter.Add("@Customer_Id", ((BL_BILLINGINVOICE)classObject).Customer_Id.ToString().Trim());
            Parameter.Add("@Data_Id", ((BL_BILLINGINVOICE)classObject).itemid.ToString().Trim());
            Parameter.Add("@flag", "BA");
            //DataSet dsr = new DataSet();
            return blFill_Para_Name(Parameter, "SP_Report");
        }
        public DataSet unit(object classObject)
        {
            Parameter.Clear();
            List<string> para_name = new List<string>();
            List<string> para_value = new List<string>();
            para_name.Add("@itemid");
            para_name.Add("@flag");
            para_value.Add(itemid.ToString().Trim());
            para_value.Add(flag.ToString().Trim());
            return bl.blFill_para_name(para_name, para_value, "SP_FILLDDL");
        }
    }
}
