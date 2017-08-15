using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace BUSSINESS_LAYER
{
    public class Bl_VILLAGEMASTER: BL ,ICOMMON_CLASS_MASTER 
    {
        private int _VillageID;

        public int VillageID
        {
            get { return _VillageID; }
            set { _VillageID = value; }
        }


        private string _VillageName;

        public string VillageName
        {
            get { return _VillageName; }
            set { _VillageName = value; }
        }

        private int _TalukaID;

        public int TalukaID
        {
            get { return _TalukaID; }
            set { _TalukaID = value; }
        }

        private int _DistrictID;

        public int DistrictID
        {
            get { return _DistrictID; }
            set { _DistrictID = value; }
        }

        private int _StateID;

        public int StateID
        {
            get { return _StateID; }
            set { _StateID = value; }
        }





        public DataSet SELECT(object classObject)
        {
            throw new NotImplementedException();
        }

        public DataSet INSERT(object classObject)
        {
            throw new NotImplementedException();
        }

        public DataSet UPDATE(object classObject)
        {
            throw new NotImplementedException();
        }

        public DataSet DELETE(object classObject)
        {
            throw new NotImplementedException();
        }

        public void Fill_ListView(ListView Lvw, DataTable Dt)
        {
            throw new NotImplementedException();
        }
    }
}
