using System.Windows.Forms;
using System;
using System.Data;
using System.Diagnostics;
using System.Configuration;
using System.Collections.Generic;
using System.Data.Sql;
using System.Drawing;
using System.Data.SqlClient;
using System.Globalization;
using ComponentFactory.Krypton.Toolkit;
using System.IO;
using BILLING_SYSTEM;
using System.Threading;


public partial class MODULE
{

    public List<string> para_name = new List<string>();
    public List<string> para_value = new List<string>();

    public string date_save_to_db(DateTime dt)
    {
        return (dt.Year + "-" + dt.Month + "-" + dt.Day);
    }
    public string whoselogin()
    {
        string str = "";
        if (MODULE.glb["GROUPID"] == "1")
        {
            str = "HOD";
        }
        if (MODULE.glb["GROUPID"] == "2")
        {

            str = "TABLE";
        }

        if (MODULE.glb["GROUPID"] == "3")
        {
            str = "HIGHERLEVELADMIN";
        }

        if (MODULE.glb["GROUPID"] == "4")
        {
            str = "HIGHERLEVEL";
        }
        if (MODULE.glb["GROUPID"] == "5")
        {
            str = "INWARDOPERATOR";
        }
        if (MODULE.glb["GROUPID"] == "6")
        {
            str = "SOFTWAREADMIN";
        }
        if (MODULE.glb["GROUPID"] == "7")
        {
            str = "DEVELOPER";
        }
        return str;
    }
    public string whoselogin_For_TapalInsert()
    {
        string str = "";
        if (MODULE.glb["GROUPID"] == "1")
        {
            str = "A";
        }
        if (MODULE.glb["GROUPID"] == "2")
        {

            str = "OP";
        }

        if (MODULE.glb["GROUPID"] == "3")
        {
            str = "HIGHERLEVELADMIN";
        }

        if (MODULE.glb["GROUPID"] == "4")
        {
            str = "HIGHERLEVEL";
        }
        if (MODULE.glb["GROUPID"] == "5")
        {
            str = "IO";
        }
        if (MODULE.glb["GROUPID"] == "6")
        {
            str = "SFT";
        }
        if (MODULE.glb["GROUPID"] == "7")
        {
            str = "DEV";
        }
        return str;
    }



    public string fill_combo_withauthority(KryptonComboBox cmb, DataTable dt)
    {
        string str = "";
        if (MODULE.glb["GROUPID"] == "1")
        {
            str = "HOD";
            fillcombo(cmb, dt);
        }
        if (MODULE.glb["GROUPID"] == "2")
        {
            str = "TABLE";
            fillcombo(cmb, dt);
        }

        if (MODULE.glb["GROUPID"] == "3")
        {
            str = "HIGHERLEVELADMIN";
            fillcombo_withall(cmb, dt);
        }

        if (MODULE.glb["GROUPID"] == "4")
        {
            str = "HIGHERLEVEL";
            fillcombo_withall(cmb, dt);
        }
        if (MODULE.glb["GROUPID"] == "5")
        {
            str = "INWARDOPERATOR";
            fillcombo_withall(cmb, dt);
        }
        if (MODULE.glb["GROUPID"] == "6")
        {
            str = "SOFTWAREADMIN";
            fillcombo_withall(cmb, dt);
        }
        if (MODULE.glb["GROUPID"] == "7")
        {
            str = "DEVELOPER";
        }
        return str;
    }
    public string fill_combo_withauthority(string dept_or_table, KryptonComboBox cmb, DataTable dt)
    {
        string str = "";
        if (MODULE.glb["GROUPID"] == "1")
        {
            str = "HOD";
            if (dept_or_table.ToUpper() == "DEPT")
            {
                fillcombo(cmb, dt);
                cmb.SelectedIndex = cmb.FindString(MODULE.glb["DEPTNAME"].ToString());
                cmb.Enabled = false;
            }
            else if (dept_or_table.ToUpper() == "TABLE")
                fillcombo_withall(cmb, dt);
        }
        if (MODULE.glb["GROUPID"] == "2")
        {
            str = "TABLE";
            if (dept_or_table.ToUpper() == "DEPT")
            {
                fillcombo(cmb, dt);
                cmb.SelectedIndex = cmb.FindString(MODULE.glb["DEPTNAME"].ToString());
                cmb.Enabled = false;
            }
            else if (dept_or_table.ToUpper() == "TABLE")
            {
                fillcombo(cmb, dt);
                cmb.SelectedIndex = cmb.FindString(MODULE.glb["TABLENAME"].ToString());
                cmb.Enabled = false;
            }


        }

        if (MODULE.glb["GROUPID"] == "3")
        {
            str = "HIGHERLEVELADMIN";
            fillcombo_withall(cmb, dt);
        }

        if (MODULE.glb["GROUPID"] == "4")
        {
            str = "HIGHERLEVEL";
            fillcombo_withall(cmb, dt);
        }
        if (MODULE.glb["GROUPID"] == "5")
        {
            str = "INWARDOPERATOR";
            fillcombo_withall(cmb, dt);
        }
        if (MODULE.glb["GROUPID"] == "6")
        {
            str = "SOFTWAREADMIN";
            fillcombo_withall(cmb, dt);
        }
        if (MODULE.glb["GROUPID"] == "7")
        {
            str = "DEVELOPER";
        }
        return str;
    }

    public void setauthority(KryptonComboBox cmbdept, bool dept_enable, int dept_index, KryptonComboBox cmbtable, bool table_enable, int table_index)
    {
        cmbdept.Enabled = dept_enable;
        cmbdept.SelectedIndex = dept_index;

        cmbtable.Enabled = table_enable;
        cmbtable.SelectedIndex = table_index;
        //for (int i=0;i<=ctl.Count-1;i++)
        //{ 
        //    ctl[i].Enabled= enable[i];
        //    if (index[i].Trim().ToString() != "")
        //        ctl[i].SelectedIndex = int.Parse(index[i].ToString());

        //}
    }

    public void setauthority(KryptonComboBox cmb, bool enable, int index)
    {
        cmb.Enabled = enable;
        cmb.SelectedIndex = index;
    }

    public bool CheckExistsDs(DataSet ds, bool ForAllTable)
    {
        if (ds.Tables.Count <= 0) return false;
        if (ForAllTable)
        {
            foreach (DataTable dt in ds.Tables)
            {
                if (dt.Rows.Count <= 0) return false;
            }
        }
        return true;
    }
    public bool CheckExistsDs(DataSet ds, int Tableno)
    {
        if (ds.Tables.Count <= 0) return false;
        if (ds.Tables[Tableno].Rows.Count <= 0) return false;
        return true;
    }

    public string WriteErrorLog(string Error)
    {
        string filename = "";
        string txtline = "";
        try
        {
            if (File.Exists(Application.StartupPath.ToString() + "\\ErrorLog.txt"))
            {
                filename = Application.StartupPath.ToString() + "\\ErrorLog.txt";

                System.IO.StreamWriter objWriter;
                objWriter = new System.IO.StreamWriter(filename, true);
                objWriter.Write("---------------------------------------------");
                objWriter.Write(DateTime.Now.ToString("dd-MMM-yyyy") + "\n");
                objWriter.Write(Error.ToString());
                objWriter.Write("---------------------------------------------");
                objWriter.Close();
            }
            else
            {
                StreamWriter sw = System.IO.File.CreateText(Application.StartupPath.ToString() + "\\ErrorLog.txt");
                sw.Write("---------------------------------------------");
                sw.Write(DateTime.Now.ToString("dd-MMM-yyyy") + "\n");
                sw.Write(Error.ToString());
                sw.Write("---------------------------------------------");
                sw.Close();
            }


            return txtline;
        }
        catch (Exception ex)
        {
            ex.Message.ToString();
            return string.IsNullOrEmpty(txtline) ? "Office2010Blue" : txtline;
        }
    }


    public void SetApplicationResolution()
    {
        Tapal_Settings setting = new Tapal_Settings();
        int tempHeight = 0, tempWidth = 0;

        Screen Srn = Screen.PrimaryScreen;
        tempHeight = Srn.Bounds.Width;
        tempWidth = Srn.Bounds.Height;
        setting.ExistingResolution = tempHeight.ToString() + " , " + tempWidth.ToString();
        setting.Save();
        setting.Reload();
        //if(tempHeight<1024)
        //{
        string str = setting.SetResolution.ToString();
        CResolution ChangeRes = new CResolution(Int32.Parse(str.Split(',')[0].Trim().ToString()), Int32.Parse(str.Split(',')[1].Trim().ToString()));
        //}
    }
    public void SetDeskTopResolution()
    {
        Tapal_Settings setting = new Tapal_Settings();
        int tempHeight = 0, tempWidth = 0;

        Screen Srn = Screen.PrimaryScreen;
        tempHeight = Srn.Bounds.Width;
        tempWidth = Srn.Bounds.Height;
        //setting.ExistingResolution = tempHeight.ToString() + " , " + tempWidth.ToString();
        //setting.Save();
        //setting.Reload();
        //if(tempHeight<1024)
        //{
        string str = setting.ExistingResolution.ToString();
        CResolution ChangeRes = new CResolution(Int32.Parse(str.Split(',')[0].Trim().ToString()), Int32.Parse(str.Split(',')[1].Trim().ToString()));
        //}
    }
}

