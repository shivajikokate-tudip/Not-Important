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
using Business_Report;
using System.Threading;
public class module_Rpt
{
     static string strfont = "DVBW-TTSurekh";
    //static string strfont_unicode = "DVBW-TTSurekh";
    public static string strfont_header = "DVBW-TTSurekh";
    //string strfont = "Mangal";

    public static string glb_font = strfont;
    public static string rpt_name = "";
    public static bool is_rpt = false;
    public static string Groupid = "";
    public static string SlaoName = "";
    public static string SlaoNo = "";
    public static string UserName = "";
    public static SortedList<string, string> glb_Rpt = new SortedList<string, string>();
    public KryptonForm ownerform_msg;

    public void filllvw(ListView lvw1, DataSet ds, List<String> col, List<String> col_name, int? headerstyle, int? tableno)
    {
        
        ListViewItem lstitem = new ListViewItem();
        lvw1.Columns.Clear();
        lvw1.Items.Clear();
        lvw1.View = View.Details;
        lvw1.FullRowSelect = true;
        lvw1.GridLines = true;
        if (headerstyle == 0)
            lvw1.HeaderStyle = ColumnHeaderStyle.Clickable;
        if (headerstyle == 1)
            lvw1.HeaderStyle = ColumnHeaderStyle.Nonclickable;
        if (headerstyle == 2)
            lvw1.HeaderStyle = ColumnHeaderStyle.None;
        if (ds.Tables[0].Rows.Count > 0)
        {
            for (int i = 0; i <= col.Count - 1; i++)
            {
                if (ds.Tables[Int32.Parse(tableno.ToString())].Columns[Int32.Parse(col[i])].DataType.ToString().CompareTo("System.Decimal") == 0)
                    lvw1.Columns.Add(col_name[i], 100);

                if (ds.Tables[Int32.Parse(tableno.ToString())].Columns[Int32.Parse(col[i])].DataType.ToString().CompareTo("System.String") == 0)
                    lvw1.Columns.Add(col_name[i], 500);
            }
            for (int i = 0; i <= ds.Tables[Int32.Parse(tableno.ToString())].Rows.Count - 1; i++)
            {
                lstitem = lvw1.Items.Add(ds.Tables[Int32.Parse(tableno.ToString())].Rows[i][Int32.Parse(col[0])].ToString());
                for (int j = 1; j < col.Count; j++)
                    lstitem.SubItems.Add(ds.Tables[Int32.Parse(tableno.ToString())].Rows[i][Int32.Parse(col[j])].ToString());
            }
        }
        else
        {
            for (int i = 0; i <= col.Count - 1; i++)
            {
                
                    lvw1.Columns.Add(col_name[i], 100);

            }
        }

        //lvw1.Columns[0].Width = lvw1.Width;
    }
    public void filllvw(ListView lvw1, DataSet ds, List<String> col, List<String> col_name, int? headerstyle, int? tableno, int? tag_col_no)
    {
        ListViewItem lstitem = new ListViewItem();
        lvw1.Columns.Clear();
        lvw1.Items.Clear();
        lvw1.View = View.Details;
        lvw1.FullRowSelect = true;
        lvw1.GridLines = true;
        if (headerstyle == 0)
            lvw1.HeaderStyle = ColumnHeaderStyle.Clickable;
        if (headerstyle == 1)
            lvw1.HeaderStyle = ColumnHeaderStyle.Nonclickable;
        if (headerstyle == 2)
            lvw1.HeaderStyle = ColumnHeaderStyle.None;
        if (ds.Tables[0].Rows.Count > 0)
        {
        for (int i = 0; i <= col.Count - 1; i++)
        {
            if (ds.Tables[Int32.Parse(tableno.ToString())].Columns[Int32.Parse(col[i])].DataType.ToString().CompareTo("System.Decimal") == 0)
                lvw1.Columns.Add(col_name[i], 100);

            if (ds.Tables[Int32.Parse(tableno.ToString())].Columns[Int32.Parse(col[i])].DataType.ToString().CompareTo("System.String") == 0)
                lvw1.Columns.Add(col_name[i], 500);
        }
        for (int i = 0; i <= ds.Tables[Int32.Parse(tableno.ToString())].Rows.Count - 1; i++)
        {
            lstitem = lvw1.Items.Add(ds.Tables[Int32.Parse(tableno.ToString())].Rows[i][Int32.Parse(col[0])].ToString());
            if (tag_col_no.HasValue)
                lstitem.Tag = ds.Tables[Int32.Parse(tableno.ToString())].Rows[i][Int32.Parse("" + tag_col_no)].ToString();

            for (int j = 1; j < col.Count; j++)
                lstitem.SubItems.Add(ds.Tables[Int32.Parse(tableno.ToString())].Rows[i][Int32.Parse(col[j])].ToString());
        }
    }
    else
    {
        for (int i = 0; i <= col.Count - 1; i++)
        {

            lvw1.Columns.Add(col_name[i], 100);

        }
    }
        //lvw1.Columns[0].Width = lvw1.Width;
    }
    public void filllvw(ListView lvw1, DataSet ds, List<String> col, List<String> col_name, int? headerstyle, int? tableno, int? tag_col_no, bool? items_clearYN)
    {
        ListViewItem lstitem = new ListViewItem();
        if (items_clearYN == true)
        {
            lvw1.Columns.Clear();
            lvw1.Items.Clear();
        }
        lvw1.View = View.Details;
        lvw1.FullRowSelect = true;
        lvw1.GridLines = true;
        if (headerstyle == 0)
            lvw1.HeaderStyle = ColumnHeaderStyle.Clickable;
        if (headerstyle == 1)
            lvw1.HeaderStyle = ColumnHeaderStyle.Nonclickable;
        if (headerstyle == 2)
            lvw1.HeaderStyle = ColumnHeaderStyle.None;
        if (ds.Tables[0].Rows.Count > 0)
        {
            for (int i = 0; i <= col.Count - 1; i++)
            {
                if (ds.Tables[Int32.Parse(tableno.ToString())].Columns[Int32.Parse(col[i])].DataType.ToString().CompareTo("System.Decimal") == 0)
                    lvw1.Columns.Add(col_name[i], 100);

                if (ds.Tables[Int32.Parse(tableno.ToString())].Columns[Int32.Parse(col[i])].DataType.ToString().CompareTo("System.String") == 0)
                    lvw1.Columns.Add(col_name[i], 500);
            }
            for (int i = 0; i <= ds.Tables[Int32.Parse(tableno.ToString())].Rows.Count - 1; i++)
            {
                lstitem = lvw1.Items.Add(ds.Tables[Int32.Parse(tableno.ToString())].Rows[i][Int32.Parse(col[0])].ToString());
                if (tag_col_no.HasValue)
                    lstitem.Tag = ds.Tables[Int32.Parse(tableno.ToString())].Rows[i][Int32.Parse("" + tag_col_no)].ToString();

                for (int j = 1; j < col.Count; j++)
                    lstitem.SubItems.Add(ds.Tables[Int32.Parse(tableno.ToString())].Rows[i][Int32.Parse(col[j])].ToString());
            }
        }
        else
        {
            for (int i = 0; i <= col.Count - 1; i++)
            {
               lvw1.Columns.Add(col_name[i], 100);
            }
        }
        //lvw1.Columns[0].Width = lvw1.Width;
    }

    public void filllvw(ListView lvw1, DataSet ds, List<String> col, List<String> col_name, List<String> col_size, int? headerstyle, int? tableno)
    {
        ListViewItem lstitem = new ListViewItem();
        lvw1.Columns.Clear();
        lvw1.Items.Clear();
        lvw1.View = View.Details;
        lvw1.FullRowSelect = true;
        lvw1.GridLines = true;
        if (headerstyle == 0)
            lvw1.HeaderStyle = ColumnHeaderStyle.Clickable;
        if (headerstyle == 1)
            lvw1.HeaderStyle = ColumnHeaderStyle.Nonclickable;
        if (headerstyle == 2)
            lvw1.HeaderStyle = ColumnHeaderStyle.None;
        if (ds.Tables[0].Rows.Count > 0)
        {
            for (int i = 0; i <= col.Count - 1; i++)
            {
                //            if (ds.Tables[Int32.Parse(tableno.ToString())].Columns[Int32.Parse(col[i])].DataType.ToString().CompareTo("System.Decimal") == 0)
                lvw1.Columns.Add(col_name[i], Int32.Parse(col_size[i].ToString()));
            }

            for (int i = 0; i <= ds.Tables[Int32.Parse(tableno.ToString())].Rows.Count - 1; i++)
            {
                lstitem = lvw1.Items.Add(ds.Tables[Int32.Parse(tableno.ToString())].Rows[i][Int32.Parse(col[0])].ToString());
                for (int j = 1; j < col.Count; j++)
                    lstitem.SubItems.Add(ds.Tables[Int32.Parse(tableno.ToString())].Rows[i][Int32.Parse(col[j])].ToString());
            }
        }
        else
        {
            for (int i = 0; i <= col.Count - 1; i++)
            {
                lvw1.Columns.Add(col_name[i], Int32.Parse(col_size[i].ToString()));
                //lvw1.Columns.Add(col_name[i], 100);

            }
        }
    }
    public void filllvw(ListView lvw1, DataSet ds, List<String> col, List<String> col_name, List<String> col_size, int? headerstyle, int? tableno, int? tag_col_no)
    {
        ListViewItem lstitem = new ListViewItem();
        lvw1.Columns.Clear();
        lvw1.Items.Clear();
        lvw1.View = View.Details;
        lvw1.FullRowSelect = true;
        lvw1.GridLines = true;
        if (headerstyle == 0)
            lvw1.HeaderStyle = ColumnHeaderStyle.Clickable;
        if (headerstyle == 1)
            lvw1.HeaderStyle = ColumnHeaderStyle.Nonclickable;
        if (headerstyle == 2)
            lvw1.HeaderStyle = ColumnHeaderStyle.None;
        if (ds.Tables[(int)tableno].Rows.Count > 0)
        {
            for (int i = 0; i <= col.Count - 1; i++)
            {
                //            if (ds.Tables[Int32.Parse(tableno.ToString())].Columns[Int32.Parse(col[i])].DataType.ToString().CompareTo("System.Decimal") == 0)
                lvw1.Columns.Add(col_name[i], Int32.Parse(col_size[i].ToString()));
            }

            for (int i = 0; i <= ds.Tables[Int32.Parse(tableno.ToString())].Rows.Count - 1; i++)
            {
                lstitem = lvw1.Items.Add(ds.Tables[Int32.Parse(tableno.ToString())].Rows[i][Int32.Parse(col[0])].ToString());
                if (tag_col_no.HasValue)
                    lstitem.Tag = ds.Tables[Int32.Parse(tableno.ToString())].Rows[i][Int32.Parse("" + tag_col_no)].ToString();
                for (int j = 1; j < col.Count; j++)
                    lstitem.SubItems.Add(ds.Tables[Int32.Parse(tableno.ToString())].Rows[i][Int32.Parse(col[j])].ToString());
            }
        }
        else
        {
            for (int i = 0; i <= col.Count - 1; i++)
            {
                lvw1.Columns.Add(col_name[i], Int32.Parse(col_size[i].ToString()));
                //lvw1.Columns.Add(col_name[i], 100);

            }
        }
    }
    public void filllvw(ListView lvw1, DataSet ds, List<String> col, List<String> col_name, List<String> col_size, int? headerstyle, int? tableno, int? tag_col_no, bool? items_clearYN)
    {
        ListViewItem lstitem = new ListViewItem();
        if (items_clearYN == true)
        {
            lvw1.Columns.Clear();
            lvw1.Items.Clear();
        }
        lvw1.View = View.Details;
        lvw1.FullRowSelect = true;
        lvw1.GridLines = true;
        if (headerstyle == 0)
            lvw1.HeaderStyle = ColumnHeaderStyle.Clickable;
        if (headerstyle == 1)
            lvw1.HeaderStyle = ColumnHeaderStyle.Nonclickable;
        if (headerstyle == 2)
            lvw1.HeaderStyle = ColumnHeaderStyle.None;
        if (ds.Tables[0].Rows.Count > 0)
        {
            for (int i = 0; i <= col.Count - 1; i++)
            {
                //            if (ds.Tables[Int32.Parse(tableno.ToString())].Columns[Int32.Parse(col[i])].DataType.ToString().CompareTo("System.Decimal") == 0)
                lvw1.Columns.Add(col_name[i], Int32.Parse(col_size[i].ToString()));
            }

            for (int i = 0; i <= ds.Tables[Int32.Parse(tableno.ToString())].Rows.Count - 1; i++)
            {
                lstitem = lvw1.Items.Add(ds.Tables[Int32.Parse(tableno.ToString())].Rows[i][Int32.Parse(col[0])].ToString());
                if (tag_col_no.HasValue)
                    lstitem.Tag = ds.Tables[Int32.Parse(tableno.ToString())].Rows[i][Int32.Parse("" + tag_col_no)].ToString();
                for (int j = 1; j < col.Count; j++)
                    lstitem.SubItems.Add(ds.Tables[Int32.Parse(tableno.ToString())].Rows[i][Int32.Parse(col[j])].ToString());
            }
        }
        else
        {
            for (int i = 0; i <= col.Count - 1; i++)
            {
                lvw1.Columns.Add(col_name[i], Int32.Parse(col_size[i].ToString()));
                //lvw1.Columns.Add(col_name[i], 100);

            }
        }
    }

    public void fillcombo(KryptonComboBox cmb, DataSet ds)
    {
        if (ds.Tables.Count > 0)
        {
            cmb.DataSource = ds.Tables[0];
            cmb.DisplayMember = ds.Tables[0].Columns[1].ColumnName.ToString();
            cmb.ValueMember = ds.Tables[0].Columns[0].ColumnName.ToString();
            DataRow dr = ds.Tables[0].NewRow();
            dr[ds.Tables[0].Columns[1].ColumnName.ToString()] = "--Select--";
            ds.Tables[0].Rows.InsertAt(dr, 0);
            cmb.SelectedIndex = 0;
        }

    }
    public void fillcombo(KryptonComboBox cmb, DataTable dt)
    {

        if (dt.Rows.Count >0)
        {
            DataView dv = new DataView();
            dv = dt.DefaultView;
            DataTable _l_dt = new DataTable();
            _l_dt = dv.ToTable();
            cmb.DataSource = _l_dt;
            cmb.DisplayMember = _l_dt.Columns[1].ColumnName.ToString();
            cmb.ValueMember = _l_dt.Columns[0].ColumnName.ToString();
            DataRow dr = _l_dt.NewRow();

            dr[_l_dt.Columns[1].ColumnName.ToString()] = "--Select--";

            _l_dt.Rows.InsertAt(dr, 0);
            cmb.SelectedIndex = 0;
        }

    }
    public void fillcombo_withall(KryptonComboBox cmb, DataSet ds)
    {
        if (ds.Tables.Count > 0)
        {
            cmb.DataSource = ds.Tables[0];
            cmb.DisplayMember = ds.Tables[0].Columns[1].ColumnName.ToString();
            cmb.ValueMember = ds.Tables[0].Columns[0].ColumnName.ToString();
            DataRow dr = ds.Tables[0].NewRow();
            dr[ds.Tables[0].Columns[1].ColumnName.ToString()] = "--Select--";
            ds.Tables[0].Rows.InsertAt(dr, 0);
            DataRow dr1 = ds.Tables[0].NewRow();
            dr1[ds.Tables[0].Columns[0].ColumnName.ToString()] = "0";
            dr1[ds.Tables[0].Columns[1].ColumnName.ToString()] = "ALL";
            ds.Tables[0].Rows.InsertAt(dr1, 1);
            cmb.SelectedIndex = 0;
        }
        else
        {
            //cmb.DataBindings.Clear();
            //cmb.DataSource = null;
            //cmb.Items.Add("--Select--");
            //cmb.SelectedIndex = 0;
            //cmb.Items.Add("ALL");

            DataTable dt1 = ds.Tables[0];
            cmb.DataSource = dt1;
            cmb.DisplayMember = dt1.Columns[1].ColumnName.ToString();
            cmb.ValueMember = dt1.Columns[0].ColumnName.ToString();
            DataRow dr = dt1.NewRow();
            dr[dt1.Columns[1].ColumnName.ToString()] = "--Select--";
            ds.Tables[0].Rows.InsertAt(dr, 0);
            DataRow dr1 = ds.Tables[0].NewRow();
            dr1[dt1.Columns[0].ColumnName.ToString()] = "0";
            dr1[dt1.Columns[1].ColumnName.ToString()] = "ALL";
            dt1.Rows.InsertAt(dr1, 1);
            cmb.SelectedIndex = 0;
        }
    }
    public void fillcombo_withall(KryptonComboBox cmb, DataTable dt)
    {
        if (dt.Rows.Count > 0)
        {
            cmb.DataSource = dt;
            cmb.DisplayMember = dt.Columns[1].ColumnName.ToString();
            cmb.ValueMember = dt.Columns[0].ColumnName.ToString();
            DataRow dr = dt.NewRow();
            dr[dt.Columns[1].ColumnName.ToString()] = "--Select--";
            dt.Rows.InsertAt(dr, 0);
            DataRow dr1 = dt.NewRow();
            dr1[dt.Columns[0].ColumnName.ToString()] = "0";
            dr1[dt.Columns[1].ColumnName.ToString()] = "ALL";
            dt.Rows.InsertAt(dr1, 1);
            cmb.SelectedIndex = 0;
        }
        else
        {
            //cmb.DataBindings.Clear();
            //cmb.DataSource = null;
            //cmb.Items.Add("--Select--");
            //cmb.SelectedIndex = 0;
            //cmb.Items.Add(new Object("ALL",0));

            DataTable dt1 = dt;
            cmb.DataSource = dt1;
            cmb.DisplayMember = dt1.Columns[1].ColumnName.ToString();
            cmb.ValueMember = dt1.Columns[0].ColumnName.ToString();
            DataRow dr = dt1.NewRow();
            dr[dt1.Columns[1].ColumnName.ToString()] = "--Select--";
            dt.Rows.InsertAt(dr, 0);
            DataRow dr1 = dt.NewRow();
            dr1[dt1.Columns[0].ColumnName.ToString()] = "0";
            dr1[dt1.Columns[1].ColumnName.ToString()] = "ALL";
            dt1.Rows.InsertAt(dr1, 1);
            cmb.SelectedIndex = 0;
        }
    }

    public String convertdate(DateTime date)
    {
        DateTime tDate = date;
        String tempDate = tDate.ToString("dd/MM/yyyy");
        //tDate = DateTime.Parse(tempDate);
        return (tempDate);
    }

    public DateTime convertdate_string_date(string date)
    {
        DateTime tDate = (!string.IsNullOrEmpty(date) || date != "") ? Convert.ToDateTime(date) :DateTime.MinValue.AddDays(1);// Convert.ToDateTime(SysDate());
        //String tempDate = tDate.ToString("dd/MM/yyyy");
        //tDate = DateTime.Parse(tempDate);
        return (tDate);
    }
    public void convertdate_string_date(string date,DateTimePicker dtp)
    {
        if (!string.IsNullOrEmpty(date) || date != "")
        { dtp.Value = Convert.ToDateTime(date); } 
        else dtp.Checked = false;
    }
    public void convertdate_string_date(string date, KryptonDateTimePicker dtp)
    {
        if (!string.IsNullOrEmpty(date) || date != "")
        { dtp.Value = Convert.ToDateTime(date); }
        else dtp.Checked = false;
    }

    public string Decrypt(string str)
    {
        Char[] ch = str.ToCharArray();
        Char[] ch1 = new char[str.Length];
        string newstr = "";
        for (int i = 0; i <= str.Length - 1; i++)
        {
            int a = (int)ch[i];
            a += 4;
            ch1[i] = (char)a;
            newstr += ch1[i].ToString();
        }
        return (newstr);
    }
    public string Encrypt(string str)
    {
        Char[] ch = str.ToCharArray();
        Char[] ch1 = new char[str.Length];
        string newstr = "";
        for (int i = 0; i <= str.Length - 1; i++)
        {
            int a = (int)ch[i];
            a += 4;
            ch1[i] = (char)a;
            newstr += ch1[i].ToString();
        }
        return (newstr);
    }

    public bool get_prv_instance()
    {
        string curr = Process.GetCurrentProcess().ProcessName;
        Process[] prv = Process.GetProcessesByName(curr);
        if (prv.Length > 1)
        {
            DialogResult res = MessageBox.Show("Already Running Close Prevous Instance!", "SSTS", MessageBoxButtons.YesNo);
            if (res.ToString().CompareTo("Yes") == 0)
            {
                prv[0].Kill();
                KryptonMessageBox.Show(prv[1].StartTime.ToString());
            }
            else
            {
                prv[1].Kill();
                KryptonMessageBox.Show(prv[0].StartTime.ToString());
            }
            return false;
        }
        else
            return true;
    }

    public String SysDate()
    {
        return (convertdate(DateTime.Parse(module_Rpt.glb_Rpt["SYSDATE"].ToString())));
    }

    public void Setdtpdate(Control c)
    {
        foreach (Control Ctrl in c.Controls)
        {
            switch (Ctrl.GetType().ToString())
            {
                case "System.Windows.Forms.DateTimePicker":
                    ((DateTimePicker)Ctrl).CustomFormat = "dd/MM/yyyy";
                    ((DateTimePicker)Ctrl).Format = DateTimePickerFormat.Custom;
                    ((DateTimePicker)Ctrl).Checked = false;
                    //((DateTimePicker)Ctrl).Value = DateTime.ParseExact(SysDate(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    break;
                case "ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker":
                    ((KryptonDateTimePicker)Ctrl).CustomFormat = "dd/MM/yyyy";
                    ((KryptonDateTimePicker)Ctrl).Format = DateTimePickerFormat.Custom;
                    ((KryptonDateTimePicker)Ctrl).Checked = false;
                    //((DateTimePicker)Ctrl).Value = DateTime.ParseExact(SysDate(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    break;

                default:
                    if (Ctrl.Controls.Count > 0)
                        Setdtpdate(Ctrl);
                    break;
            }
        }
    }


    public void ClearControls(Control c)
    {
        foreach (Control Ctrl in c.Controls)
        {
            //Console.WriteLine(Ctrl.GetType().ToString());          
            //MessageBox.Show ( (Ctrl.GetType().ToString())) ;          
            switch (Ctrl.GetType().ToString())
            {
                case "ComponentFactory.Krypton.Toolkit.KryptonCheckBox":
                    ((CheckBox)Ctrl).Checked = false;
                    break;
                case "ComponentFactory.Krypton.Toolkit.KryptonTextBox":
                    ((TextBox)Ctrl).Text = "";
                    break;
                case "System.Windows.Forms.RichTextBox":
                    ((RichTextBox)Ctrl).Text = "";
                    break;
                case "ComponentFactory.Krypton.Toolkit.KryptonComboBox":
                    ((ComboBox)Ctrl).SelectedIndex = -1;
                    ((ComboBox)Ctrl).SelectedIndex = -1;
                    break;
                case "System.Windows.Forms.MaskedTextBox":
                    ((MaskedTextBox)Ctrl).Text = "";
                    break;
                case "System.Windows.Forms.DateTimePicker":
                    ((DateTimePicker)Ctrl).Value = DateTime.Parse(SysDate());
                    break;
                //case "Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit":
                //    ((UltraMaskedEdit)Ctrl).Text = "";
                //    break;
                //case "Infragistics.Win.UltraWinEditors.UltraDateTimeEditor":
                //    DateTime dt = DateTime.Now;
                //    string shortDate = dt.ToShortDateString();
                //    ((UltraDateTimeEditor)Ctrl).Text = shortDate;
                //    break;
                //case "System.Windows.Forms.RichTextBox":
                //    ((RichTextBox)Ctrl).Text = "";
                //    break;
                //case " Infragistics.Win.UltraWinGrid.UltraCombo":
                //    ((UltraCombo)Ctrl).Text = "";
                //    break;
                //case "Infragistics.Win.UltraWinEditors.UltraCurrencyEditor":
                //    ((UltraCurrencyEditor)Ctrl).Value = 0.0m;
                //    break;
                default:
                    if (Ctrl.Controls.Count > 0)
                        ClearControls(Ctrl);
                    break;
            }
        }
    }



    public void settheme(Control c)
    {

        Setdtpdate(c);

        //function.Setdtpdate(this);
        //((ComponentFactory.Krypton.Toolkit.KryptonForm)c).StateCommon.Header.Content.ShortText.Font = new System.Drawing.Font(strfont, 12);
        try { settheme((KryptonForm)c, 1); }
        catch (Exception ex) { ex.Message.ToString(); }

        foreach (Control Ctrl in c.Controls)
        {
            switch (Ctrl.GetType().ToString())
            {
                case "ComponentFactory.Krypton.Toolkit.KryptonLabel":
                    ((ComponentFactory.Krypton.Toolkit.KryptonLabel)Ctrl).StateCommon.ShortText.Font = new System.Drawing.Font(strfont, 14, FontStyle.Bold);
                    ((ComponentFactory.Krypton.Toolkit.KryptonLabel)Ctrl).LabelStyle = LabelStyle.TitlePanel; //    = new System.Drawing.Font("DVB-TTSurekh", 12);
                    break;
                case "System.Windows.Forms.LinkLabel":
                    ((System.Windows.Forms.LinkLabel)Ctrl).Font = new System.Drawing.Font(strfont, 14, FontStyle.Bold);
                    //((System.Windows.Forms.LinkLabel)Ctrl).LabelStyle = LabelStyle.TitlePanel; //    = new System.Drawing.Font("DVB-TTSurekh", 12);
                    break;
                case "ComponentFactory.Krypton.Toolkit.KryptonWrapLabel":
                    ((ComponentFactory.Krypton.Toolkit.KryptonWrapLabel)Ctrl).StateNormal.Font = new System.Drawing.Font(strfont, 14, FontStyle.Bold);
                    ((ComponentFactory.Krypton.Toolkit.KryptonWrapLabel)Ctrl).LabelStyle = LabelStyle.TitlePanel;
                    //((System.Windows.Forms.LinkLabel)Ctrl).LabelStyle = LabelStyle.TitlePanel; //    = new System.Drawing.Font("DVB-TTSurekh", 12);
                    break;
                case "ComponentFactory.Krypton.Toolkit.KryptonLinkLabel":
                    ((ComponentFactory.Krypton.Toolkit.KryptonLinkLabel)Ctrl).StateNormal.ShortText.Font = new System.Drawing.Font(strfont, 14, FontStyle.Bold);
                    //((System.Windows.Forms.LinkLabel)Ctrl).LabelStyle = LabelStyle.TitlePanel; //    = new System.Drawing.Font("DVB-TTSurekh", 12);
                    break;
                case "ComponentFactory.Krypton.Toolkit.KryptonTextBox":
                    //    ((ComponentFactory.Krypton.Toolkit.KryptonTextBox)Ctrl).StateCommon.Content.Font = new  System.Drawing.Font("DVB-TTSurekh", 12);
                    ((ComponentFactory.Krypton.Toolkit.KryptonTextBox)Ctrl).StateCommon.Content.Font = new System.Drawing.Font(strfont, 14);
                    break;
                case "ComponentFactory.Krypton.Toolkit.KryptonButton":
                    ((ComponentFactory.Krypton.Toolkit.KryptonButton)Ctrl).StateCommon.Content.ShortText.Font = new System.Drawing.Font(strfont, 14);
                    if (((ComponentFactory.Krypton.Toolkit.KryptonButton)Ctrl).Values.Text != ".....")
                        ((ComponentFactory.Krypton.Toolkit.KryptonButton)Ctrl).Size = new Size(((ComponentFactory.Krypton.Toolkit.KryptonButton)Ctrl).Size.Width, 33);
                    break;
                case "ComponentFactory.Krypton.Toolkit.KryptonComboBox":
                    ((ComponentFactory.Krypton.Toolkit.KryptonComboBox)Ctrl).StateActive.ComboBox.Content.Font = new System.Drawing.Font(strfont, 14);
                    ((ComponentFactory.Krypton.Toolkit.KryptonComboBox)Ctrl).StateNormal.ComboBox.Content.Font = new System.Drawing.Font(strfont, 14);
                    ((ComponentFactory.Krypton.Toolkit.KryptonComboBox)Ctrl).StateNormal.Item.Content.ShortText.Font = new System.Drawing.Font(strfont, 14);
                    ((ComponentFactory.Krypton.Toolkit.KryptonComboBox)Ctrl).StateTracking.Item.Content.ShortText.Font = new System.Drawing.Font(strfont, 14);
                    
                    ((ComponentFactory.Krypton.Toolkit.KryptonComboBox)Ctrl).StateDisabled.ComboBox.Content.Font = new System.Drawing.Font(strfont, 14);
                    ((ComponentFactory.Krypton.Toolkit.KryptonComboBox)Ctrl).StateDisabled.Item.Content.ShortText.Font = new System.Drawing.Font(strfont, 14);
                    

                    break;
                case "ComponentFactory.Krypton.Toolkit.KryptonCheckBox":
                    ((ComponentFactory.Krypton.Toolkit.KryptonCheckBox)Ctrl).StateCommon.ShortText.Font = new System.Drawing.Font(strfont, 14, FontStyle.Bold);
                    ((ComponentFactory.Krypton.Toolkit.KryptonCheckBox)Ctrl).LabelStyle = LabelStyle.TitlePanel; //    = new System.Drawing.Font("DVB-TTSurekh", 12);
                    break;
                case "ComponentFactory.Krypton.Toolkit.KryptonRadioButton":
                    ((ComponentFactory.Krypton.Toolkit.KryptonRadioButton)Ctrl).StateCommon.ShortText.Font = new System.Drawing.Font(strfont, 14);
                    ((ComponentFactory.Krypton.Toolkit.KryptonRadioButton)Ctrl).LabelStyle = LabelStyle.TitlePanel; //    = new System.Drawing.Font("DVB-TTSurekh", 12);
                    //((ComponentFactory.Krypton.Toolkit.KryptonRadioButton)Ctrl).StateNormal.ShortText.

                    break;
                case "ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker":
                    ((ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker)Ctrl).StateCommon.Content.Font = new System.Drawing.Font(strfont, 14);
                    break;
                case "ComponentFactory.Krypton.Toolkit.KryptonMessageBox":
                    ((ComponentFactory.Krypton.Toolkit.KryptonMessageBox)Ctrl).Font = new System.Drawing.Font(strfont, 14);
                    break;
                case "System.Windows.Forms.TreeView":
                    ((System.Windows.Forms.TreeView)Ctrl).Font = new System.Drawing.Font(strfont, 18, FontStyle.Bold);
                    break;
                case "ComponentFactory.Krypton.Toolkit.KryptonForm":
                    ((ComponentFactory.Krypton.Toolkit.KryptonForm)Ctrl).StateCommon.Header.Content.ShortText.Font = new System.Drawing.Font("DVB-TTChhaya", 14, FontStyle.Bold);
                    break;
                case "ComponentFactory.Krypton.Toolkit.KryptonHeader":
                    ((ComponentFactory.Krypton.Toolkit.KryptonHeader)Ctrl).StateCommon.Content.ShortText.Font = new System.Drawing.Font(strfont, 14, FontStyle.Bold);
                    ((ComponentFactory.Krypton.Toolkit.KryptonHeader)Ctrl).StateCommon.Content.LongText.Font = new System.Drawing.Font(strfont, 15, FontStyle.Bold);
                    break;
                default:
                    if (Ctrl.GetType().ToString() == "ComponentFactory.Krypton.Toolkit.KryptonPanel")
                    {
                        ((ComponentFactory.Krypton.Toolkit.KryptonPanel)Ctrl).StateCommon.ColorStyle = PaletteColorStyle.ExpertSquareHighlight;
                        //((ComponentFactory.Krypton.Toolkit.KryptonPanel)Ctrl).Palette=f.kryptonManager.GlobalPalette;
                    }
                    if (Ctrl.GetType().ToString() == "ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup")
                    {
                        ((ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup)Ctrl).StateCommon.HeaderPrimary.Content.ShortText.Font = new System.Drawing.Font(strfont, 14, FontStyle.Bold);
                        ((ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup)Ctrl).StateCommon.HeaderSecondary.Content.ShortText.Font = new System.Drawing.Font(strfont, 13, FontStyle.Bold);
                    }
                    if (Ctrl.GetType().ToString() == "ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup")
                    {
                        ((ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup)Ctrl).StateCommon.HeaderPrimary.Content.ShortText.Font = new System.Drawing.Font(strfont, 14, FontStyle.Bold);
                        ((ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup)Ctrl).StateCommon.HeaderSecondary.Content.ShortText.Font = new System.Drawing.Font(strfont, 13, FontStyle.Bold);
                    }
                    if (Ctrl.Controls.Count > 0)
                        settheme(Ctrl);
                    break;
            }
        }
    }


    public void settheme(KryptonForm ownform, int? a)
    {
        ownform.Icon = new Icon(Application.StartupPath.ToString() + "\\SUN.ICO");
        ownform.StateCommon.Header.Content.ShortText.Font = new System.Drawing.Font(strfont_header, 22, FontStyle.Bold);

    }

    //public void open_form(Form ownform, bool closeYN, string new_form)
    //{
    //    Tapal_MDIParent m = new Tapal_MDIParent();

    //    module_Rpt.glb["FORMNAME"] = new_form;
     
    //    if (closeYN == true)
    //    {
    //        ownform.Close();
    //    }
    //    m.kryptonSplitContainer1_Panel2_ControlRemoved(ownform, new ControlEventArgs(ownform));
    //}

    public string set_theme_name(bool RW,string name)
    {
        string filename = "";
        string txtline = "";
        try
        {
            if (File.Exists(Application.StartupPath.ToString() + "\\ThemeName.txt"))
            {
                filename = Application.StartupPath.ToString() + "\\ThemeName.txt";
                if (RW == true)
                {
                    System.IO.StreamReader objReader;
                    objReader = new System.IO.StreamReader(filename);
                    do
                    {
                        txtline = objReader.ReadLine() + "";

                    } while (objReader.Peek() != -1);

                }
                else
                {
                    System.IO.StreamWriter objWriter;
                    objWriter = new System.IO.StreamWriter(filename);
                    objWriter.Write(name.ToString());
                    objWriter.Close();
                }
            }
            else
            {
                if (RW == true)
                {
                    return ("SparkleBlue");
                }
                else
                {
                    StreamWriter sw = System.IO.File.CreateText(Application.StartupPath.ToString() + "\\ThemeName.txt");
                    sw.Write(name.ToString());
                    sw.Close();
                }



            }

            return txtline;
        }
        catch (Exception ex)
        {
            ex.Message.ToString();
            return  string.IsNullOrEmpty(txtline) ? "SparkleBlue" : txtline;
        }
    }


    public PaletteModeManager PalletMode(string name)
    {

            if (name== "Office2010Blue")
                return (PaletteModeManager.Office2010Blue);
                
            else if (name== "Office2010Silver")
                return (PaletteModeManager.Office2010Silver);
                
            else if (name== "Office2010Black")
                return (PaletteModeManager.Office2010Black);
                
            else if (name== "Office2007Blue")
                return (PaletteModeManager.Office2007Blue);
                
            else if (name== "Office2007Silver")
                return (PaletteModeManager.Office2007Silver);
                
            else if (name== "Office2007Black")
                return (PaletteModeManager.Office2007Black);
                
            else if (name== "SparkleBlue")
                return (PaletteModeManager.SparkleBlue);
                
            else if (name== "SparkleOrange")
                return (PaletteModeManager.SparkleOrange);
                
            else if (name== "SparklePurple")
                return (PaletteModeManager.SparklePurple);
                
            else if (name== "ProfessionalOffice2003")
                return (PaletteModeManager.ProfessionalOffice2003);
                
            else if (name== "ProfessionalSystem")
                return (PaletteModeManager.ProfessionalSystem);
            else
                return (PaletteModeManager.SparkleOrange);


    }

    //public void add_form_on_panel(KryptonForm newform, KryptonForm ownerform)
    //{
    //    newform.TopLevel = false;
    //    newform.StateCommon.Header.Content.ShortText.Font = new System.Drawing.Font("DVB-TTSurekh", 25, FontStyle.Bold);
    //    add_form_panel a = new add_form_panel();
    //    ownerform.Controls.Add(a);
    //    a.kryptonPanel1.Controls.Add(newform);
    //}
    //public void Message_Show(KryptonForm ownerform,String msg)
    //{
    //    KryptonLabel l = new KryptonLabel();
    //    l.Text = "\n - "+msg+".\n";
    //    l.Dock = DockStyle.Fill;
    //    l.AutoSize = true;
    //    KryptonButton b = new KryptonButton();
    //    b.Dock = DockStyle.Bottom;
    //    b.Text = "OK";
    //    b.Click += new EventHandler(b_click);
    //    b.Visible = true;
    //    ownerform_msg = ownerform;
    //    add_form_panel a = new add_form_panel(false);
    //    a.Parent = ownerform;
    //    a.kryptonPanel1.Controls.Add(l);
    //    a.kryptonPanel1.Controls.Add(b);
    //    ownerform.Controls.Add(a);
    //    a.BringToFront();
    //    a.Enabled = true;
    //    a.Show();
    //}
    private void b_click(object sender, EventArgs e)
    {
        findcontrol(ownerform_msg);
    }
    private void findcontrol(Control c)
    {
        foreach (Control Ctrl in c.Controls)
        {
            switch (Ctrl.GetType().ToString())
            {
                case "Tapal.add_form_panel":
                    Ctrl.Dispose();
                    break;
                default:
                    if (Ctrl.Controls.Count > 0)
                        findcontrol(Ctrl);
                    break;
            }
        }
    }

    public void SearchTextInListView(ListView lst, string Search)
    {
        try
        {
            foreach (ListViewItem item in lst.Items)
            {
                item.Selected = false;
            }
            string iSearch = Search.ToLower();
            for (int colAll = 0; colAll < lst.Columns.Count - 1; colAll++)
                foreach (ListViewItem item in lst.Items)
                {
                    if (item.SubItems[colAll].Text.IndexOf(iSearch.Trim()) > -1 |
                        item.SubItems[colAll].Text.ToUpper().IndexOf(iSearch.ToUpper().Trim()) > -1)
                    {
                        item.Selected = true;
                    }
                }
            RemoveUnselected(lst);
        }
        catch (Exception ex)
        {
            ex.Message.ToString();
        }
    }
    public void SearchTextInListView_on_column(ListView lst, int column, string Search)
    {
        try
        {
            foreach (ListViewItem item in lst.Items)
            {
                item.Selected = false;
            }
            string iSearch = Search.ToLower();
                foreach (ListViewItem item in lst.Items)
                {
                    if (item.SubItems[column].Text.IndexOf(iSearch.Trim()) > -1 |
                        item.SubItems[column].Text.ToUpper().IndexOf(iSearch.ToUpper().Trim()) > -1)
                    {
                        item.Selected = true;
                    }
                }
            RemoveUnselected(lst);
        }
        catch (Exception ex)
        { ex.Message.ToString(); }
    }
    public void SearchTextInListView_on_column(ListView lst, int column, string Search,bool exact)
    {
        try
        {
            foreach (ListViewItem item in lst.Items)
            {
                item.Selected = false;
            }
            string iSearch = Search.ToLower();
                foreach (ListViewItem item in lst.Items)
                {
                    if (exact==true) 
                    if (item.SubItems[column].Text==(iSearch.Trim()) |
                        item.SubItems[column].Text.ToUpper() == iSearch.ToUpper().Trim() )
                    {
                        item.Selected = true;
                    }
                }
            RemoveUnselected(lst);
        }
        catch (Exception ex)
        { ex.Message.ToString(); }
    }
        // remove unselected items
    private void RemoveUnselected(ListView lst)
    {
        int i = 0;
        while (true)
        {
            if (i >= lst.Items.Count)
            {
                break;
            }
            if (lst.Items[i].Selected == false)
            {
                lst.Items[i].Remove();
                i--;
            }
            i++;
        }
    }
    public string whoselogin()
    {
        string str="";
        if (module_Rpt.glb_Rpt["GROUPID"] == "1")
        {
            str = "HOD";
        }
        if (module_Rpt.glb_Rpt["GROUPID"] == "2")
        {
            str = "TABLE";
        }

        if (module_Rpt.glb_Rpt["GROUPID"] == "3")
        {
            str = "HIGHERLEVELADMIN";
        }

        if (module_Rpt.glb_Rpt["GROUPID"] == "4")
        {
            str = "HIGHERLEVEL";
        }
        if (module_Rpt.glb_Rpt["GROUPID"] == "5")
        {
            str = "INWARDOPERATOR";
        }
        if (module_Rpt.glb_Rpt["GROUPID"] == "6")
        {
            str = "SOFTWAREADMIN";
        }
        if (module_Rpt.glb_Rpt["GROUPID"] == "7")
        {
            str = "DEVELOPER";
        }
        return str;
    }

    public string fill_combo_withauthority(KryptonComboBox cmb,DataTable dt)
    {
        string str = "";
        if (module_Rpt.glb_Rpt["GROUPID"] == "1")
        {
            str = "HOD";
            fillcombo(cmb,dt);
        }
        if (module_Rpt.glb_Rpt["GROUPID"] == "2")
        {
            str = "TABLE";
            fillcombo(cmb, dt);
        }

        if (module_Rpt.glb_Rpt["GROUPID"] == "3")
        {
            str = "HIGHERLEVELADMIN";
            fillcombo_withall(cmb, dt);
        }

         if (module_Rpt.glb_Rpt["GROUPID"] == "4")
        {
            str = "HIGHERLEVEL";
            fillcombo_withall(cmb, dt);
        }
        if (module_Rpt.glb_Rpt["GROUPID"] == "5")
        {
            str = "INWARDOPERATOR";
            fillcombo_withall(cmb, dt);
        }
        if (module_Rpt.glb_Rpt["GROUPID"] == "6")
        {
            str = "SOFTWAREADMIN";
            fillcombo_withall(cmb, dt);
        }
        if (module_Rpt.glb_Rpt["GROUPID"] == "7")
        {
            str = "DEVELOPER";
        }
        return str;
    }
    public string fill_combo_withauthority(string dept_or_table, KryptonComboBox cmb, DataTable dt)
    {
        string str = "";
        if (module_Rpt.glb_Rpt["GROUPID"] == "1")
        {
            str = "HOD";
            if (dept_or_table.ToUpper() == "DEPT")
            {
                fillcombo(cmb, dt);
                cmb.SelectedIndex = cmb.FindString(module_Rpt.glb_Rpt["DEPTNAME"].ToString());
                cmb.Enabled = false;
            }
            else if (dept_or_table.ToUpper() == "TABLE")
                fillcombo_withall(cmb, dt);
        }
        if (module_Rpt.glb_Rpt["GROUPID"] == "2")
        {
            str = "TABLE";
            if (dept_or_table.ToUpper() == "DEPT")
            {
                fillcombo(cmb, dt);
                cmb.SelectedIndex = cmb.FindString(module_Rpt.glb_Rpt["DEPTNAME"].ToString());
                cmb.Enabled = false;
            }
            else if (dept_or_table.ToUpper() == "TABLE")
            {
                fillcombo(cmb, dt);
                cmb.SelectedIndex = cmb.FindString(module_Rpt.glb_Rpt["TABLENAME"].ToString());
                cmb.Enabled = false;
            }

            
        }

        if (module_Rpt.glb_Rpt["GROUPID"] == "3")
        {
            str = "HIGHERLEVELADMIN";
            fillcombo_withall(cmb, dt);
        }

        if (module_Rpt.glb_Rpt["GROUPID"] == "4")
        {
            str = "HIGHERLEVEL";
            fillcombo_withall(cmb, dt);
        }
        if (module_Rpt.glb_Rpt["GROUPID"] == "5")
        {
            str = "INWARDOPERATOR";
            fillcombo_withall(cmb, dt);
        }
        if (module_Rpt.glb_Rpt["GROUPID"] == "6")
        {
            str = "SOFTWAREADMIN";
            fillcombo_withall(cmb, dt);
        }
        if (module_Rpt.glb_Rpt["GROUPID"] == "7")
        {
            str = "DEVELOPER";
        }
        return str;
    }
    public void Show_Report(string rpt_name, DataSet ds, int tableno)
    {
        module_Rpt.rpt_name = rpt_name;
        Report_Viewer rpt = new Report_Viewer(ds, tableno);
        rpt.Show();
    }
    //public void Show_Report(string rpt_name, int tableno, DataSet ds)
    //{
    //    module_Rpt.rpt_name = rpt_name;
    //    Report_Viewer rpt = new Report_Viewer( tableno,ds);
    //    rpt.Show();
    //}
       
    public void setauthority(KryptonComboBox cmbdept, bool dept_enable, int dept_index, KryptonComboBox cmbtable, bool table_enable, int table_index)
    {
        cmbdept.Enabled = dept_enable;
        cmbdept.SelectedIndex = dept_index;

        cmbtable.Enabled = table_enable ;
        cmbtable.SelectedIndex = table_index ;
        //for (int i=0;i<=ctl.Count-1;i++)
        //{ 
        //    ctl[i].Enabled= enable[i];
        //    if (index[i].Trim().ToString() != "")
        //        ctl[i].SelectedIndex = int.Parse(index[i].ToString());

        //}
    }

    public void Show_Report(string rpt_name, DataSet ds, int tableno, String OfficeId, DateTime fromdate, DateTime todate)
    {
        module_Rpt.rpt_name = rpt_name;
        Report_Viewer rpt = new Report_Viewer(fromdate, todate, ds, tableno);
        rpt.Show();
    }

    public void setauthority(KryptonComboBox cmb, bool enable, int index)
    {
        cmb.Enabled = enable;
        cmb.SelectedIndex = index;
    }
    public string date_save_to_db(DateTime dt)
    {
        return (dt.Year + "-" + dt.Month + "-" + dt.Day);
    } 
    
    public void Show_Report(string rpt_name, DataSet ds, int tableno, DateTime fromdate, DateTime todate)
    {
        module_Rpt.rpt_name = rpt_name;
        Report_Viewer rpt = new Report_Viewer(fromdate, todate, ds, tableno);
        rpt.Show();
    }
}
