using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace BUSSINESS_LAYER
{
    public class BL_USERMASTER : BL_LOGIN_SERVER, ICOMMON_CLASS_MASTER
    {
        #region Variables
        int _DistId;
        int _TalukaId;
        int _VillageId;
        int _ShopId;
        string _UserName;
        string _Password;
        bool _Load_Login;
        public int DistId { get { return _DistId; } set { _DistId = value; } }
        public int TalukaId { get { return _TalukaId; } set { _TalukaId = value; } }
        public int VillageId { get { return _VillageId; } set { _VillageId = value; } }
        public int ShopId { get { return _ShopId; } set { _ShopId = value; } }
        public bool Load_Login { get { return _Load_Login; } set { _Load_Login = value; } }
        public string UserName { get { return _UserName; } set { _UserName = value; } }
        public string Password { get { return _Password; } set { _Password = value; } }
        #endregion



        #region ICOMMON_CLASS_MASTER Members

        public DataSet SELECT(object classObject)
        {
            DataSet ds = new DataSet();
            Parameter.Clear();
            Parameter.Add("@user_name", ((BL_USERMASTER)classObject).UserName.ToString());
            Parameter.Add("@pass_word", ((BL_USERMASTER)classObject).Password.ToString());
            Sp_Name = "Sp_User_Name";
            ds = blFill_Para_Name(Parameter, Sp_Name);
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
