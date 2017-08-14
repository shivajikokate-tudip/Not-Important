using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace BUSSINESS_LAYER
{
    public class BL_LOGIN_SERVER : BL, ICOMMON_CLASS_MASTER
    {
        #region Variables
        int _PlNo;
        int _AcNo;
        string _UserName;
        string _Password;
        bool _Load_Login;
        public int PlNo { get { return _PlNo; } set { _PlNo = value; } }
        public int AcNo { get { return _AcNo; } set { _AcNo = value; } }
        public bool Load_Login { get { return _Load_Login; } set { _Load_Login = value; } }
        public string UserName { get { return _UserName; } set { _UserName = value; } }
        public string Password { get { return _Password; } set { _Password = value; } }
        #endregion

        #region ICOMMON_CLASS_MASTER Members

        public DataSet SELECT(object classObject)
        {
            DataSet ds = new DataSet();
            if (((BL_LOGIN_SERVER)classObject).Load_Login)
            {
                ds = blFill("Sp_User_Name");
            }
            if (!((BL_LOGIN_SERVER)classObject).Load_Login)
            {
                Parameters.Clear();
                Parameters.Add("@username", ((BL_LOGIN_SERVER)classObject).UserName.ToString());
                Parameters.Add("@password", ((BL_LOGIN_SERVER)classObject).Password.ToString());
                ds = blFill_Para_Name(Parameters, "Sp_Login");
            }
            return ds;
        }

        public DataSet INSERT(object classObject)
        {
            return new DataSet();
        }

        public DataSet UPDATE(object classObject)
        {
            return new DataSet();
        }

        public DataSet DELETE(object classObject)
        {
            return new DataSet();
        }

        public void Fill_ListView(ListView Lvw, DataTable Dt)
        {

        }

        #endregion

    }
}
