using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace BUSSINESS_LAYER
{
    public class BL_EMPLOYEEMASTER : BL, ICOMMON_CLASS_MASTER
    {
        int _Emp_Id;
        public int Emp_Id
        {
            get { return _Emp_Id; }
            set { _Emp_Id = value; }
        }
        
        string _Emp_Name;
        public string Emp_Name
        {
            get { return _Emp_Name; }
            set { _Emp_Name = value; }
        }

        string _Emp_Add;
        public string Emp_Add
        {
            get { return _Emp_Add; }
            set { _Emp_Add = value; }
        }

        string _Emp_Mob;
        public string Emp_Mob
        {
            get { return _Emp_Mob; }
            set { _Emp_Mob = value; }
        }

       string _Emp_BirthDate;
        public string Emp_BirthDate
        {
            get { return _Emp_BirthDate; }
            set { _Emp_BirthDate = value; }
        }

        string _Emp_JoinDate;
        public string Emp_JoinDate
        {
            get { return _Emp_JoinDate; }
            set { _Emp_JoinDate = value; }
        }


        decimal _Emp_Sal;
        public decimal Emp_Sal
        {
            get { return _Emp_Sal; }
            set { _Emp_Sal = value; }
        }


        public DataSet SELECT(object classObject)
        {
            return blFill("SP_EmployeeMaster");
        }

        public DataSet INSERT(object classObject)
        {
            Parameter.Clear();
            
            Parameter.Add("@Emp_Name", ((BL_EMPLOYEEMASTER)classObject).Emp_Name.ToString().Trim());
            Parameter.Add("@Emp_Add", ((BL_EMPLOYEEMASTER)classObject).Emp_Add.ToString().Trim());
            Parameter.Add("@Emp_Mob", ((BL_EMPLOYEEMASTER)classObject).Emp_Mob.ToString().Trim());
            Parameter.Add("@Emp_BirthDate", ((BL_EMPLOYEEMASTER)classObject).Emp_BirthDate.ToString().Trim());
            Parameter.Add("@Emp_JoinDate", ((BL_EMPLOYEEMASTER)classObject).Emp_JoinDate.ToString().Trim());
            Parameter.Add("@Emp_Sal", ((BL_EMPLOYEEMASTER)classObject).Emp_Sal.ToString().Trim());
            Parameter.Add("@flag", "A");
            return blFill_Para_Name(Parameter, "SP_EmployeeMaster");
        }

        public DataSet UPDATE(object classObject)
        {

            Parameter.Clear();
            Parameter.Add("@Emp_Id", ((BL_EMPLOYEEMASTER)classObject).Emp_Id.ToString().Trim());
            Parameter.Add("@Emp_Name", ((BL_EMPLOYEEMASTER)classObject).Emp_Name.ToString().Trim());
            Parameter.Add("@Emp_Add", ((BL_EMPLOYEEMASTER)classObject).Emp_Add.ToString().Trim());
            Parameter.Add("@Emp_Mob", ((BL_EMPLOYEEMASTER)classObject).Emp_Mob.ToString().Trim());
            Parameter.Add("@Emp_BirthDate", ((BL_EMPLOYEEMASTER)classObject).Emp_BirthDate.ToString().Trim());
            Parameter.Add("@Emp_JoinDate", ((BL_EMPLOYEEMASTER)classObject).Emp_JoinDate.ToString().Trim());
            Parameter.Add("@Emp_Sal", ((BL_EMPLOYEEMASTER)classObject).Emp_Sal.ToString().Trim());
            Parameter.Add("@flag", "U");
            return blFill_Para_Name(Parameter, "SP_EmployeeMaster");
        }

        public DataSet DELETE(object classObject)
        {
            Parameter.Clear();
            Parameter.Add("@Emp_Id", ((BL_EMPLOYEEMASTER)classObject).Emp_Id.ToString().Trim());
            Parameter.Add("@flag", "D");
            return blFill_Para_Name(Parameter, "SP_EmployeeMaster");
        }

        public void Fill_ListView(ListView Lvw, DataTable Dt)
        {
            throw new NotImplementedException();
        }

    }
}
