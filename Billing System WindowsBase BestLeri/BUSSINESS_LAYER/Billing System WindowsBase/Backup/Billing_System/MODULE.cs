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
    public static string strfont = "Tahoma";
    public static string strfont_Unicode = "Arial Unicode MS";
    public static string strheaderfont = "Castellar";
    //static string strfont = "MG Shree";
    public static string glb_font = strfont;
    public static string rpt_name = "";
    public static bool is_rpt = false;
    public static string Groupid = "";
    public static string SlaoName = "";
    public static string SlaoNo = "";
    public static string UserName = "";
    public static SortedList<string, string> glb = new SortedList<string, string>();
    public KryptonForm ownerform_msg;
    public FRM_MAIN mdi;
    System.Windows.Forms.Timer t = null;// new System.Windows.Forms.Timer();
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
        if (ds.Tables.Count > 0)
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
        if (ds.Tables.Count > 0)
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
        if (ds.Tables.Count > 0)
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
        if (ds.Tables.Count > 0)
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
        if (ds.Tables.Count > 0)
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
        if (ds.Tables.Count > 0)
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
        else
        {
            cmb.DataBindings.Clear();
            cmb.DataSource = null;
            cmb.Items.Add("--Select--");
            cmb.SelectedIndex = 0;
        }
    }
    public void fillcombo(KryptonComboBox cmb, DataTable dt)
    {
        if (dt.Rows.Count > 0)
        {
            cmb.DataSource = dt;
            cmb.DisplayMember = dt.Columns[1].ColumnName.ToString();
            cmb.ValueMember = dt.Columns[0].ColumnName.ToString();
            DataRow dr = dt.NewRow();
            dr[dt.Columns[0].ColumnName.ToString()] = "0";
            dr[dt.Columns[1].ColumnName.ToString()] = "--Select--";
            dt.Rows.InsertAt(dr, 0);
            cmb.SelectedIndex = 0;
        }
        else
        {
            cmb.DataBindings.Clear();
            cmb.DataSource = null;
            cmb.Items.Add("--Select--");
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
            cmb.DataBindings.Clear();
            cmb.DataSource = null;
            cmb.Items.Add("--Select--");
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
            cmb.DataBindings.Clear();
            cmb.DataSource = null;
            cmb.Items.Add("--Select--");
            cmb.SelectedIndex = 0;
        }
    }

    public void fillcombo(DataGridViewComboBoxCell cmb, DataTable dt)
    {
        if (dt.Rows.Count > 0)
        {
            cmb.DataSource = dt;
            cmb.DisplayMember = dt.Columns[1].ColumnName.ToString();
            cmb.ValueMember = dt.Columns[0].ColumnName.ToString();
            DataRow dr = dt.NewRow();
            dr[dt.Columns[0].ColumnName.ToString()] = "0";
            dr[dt.Columns[1].ColumnName.ToString()] = "--Select--";
            dt.Rows.InsertAt(dr, 0);
            //cmb. SelectedIndex = 0;
        }
        else
        {
            cmb.Items.Clear();
            cmb.DataSource = null;
            cmb.Items.Add("--Select--");
            //cmb.SelectedIndex = 0;
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
        DateTime tDate = (!string.IsNullOrEmpty(date) || date != "") ? Convert.ToDateTime(date) : DateTime.MinValue.AddDays(1);// Convert.ToDateTime(SysDate());
        //String tempDate = tDate.ToString("dd/MM/yyyy");
        //tDate = DateTime.Parse(tempDate);
        return (tDate);
    }
    public void convertdate_string_date(string date, DateTimePicker dtp)
    {
        if (!string.IsNullOrEmpty(date) || date != "")
        { dtp.Value = Convert.ToDateTime(date); dtp.Checked = true; }
        else dtp.Checked = false;
    }
    public void convertdate_string_date(string date, KryptonDateTimePicker dtp)
    {
        if (!string.IsNullOrEmpty(date) || date != "")
        { dtp.Value = Convert.ToDateTime(date); dtp.Checked = true; }
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
            a -= 4;
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
        return (convertdate(DateTime.Parse(MODULE.glb["SYSDATE"].ToString())));
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
            switch (Ctrl.GetType().ToString())
            {
                case "System.Windows.Forms.CheckBox":
                    ((CheckBox)Ctrl).Checked = false;
                    break;
                case "System.Windows.Forms.TextBox":
                    ((TextBox)Ctrl).Text = "";
                    break;
                case "System.Windows.Forms.RichTextBox":
                    ((RichTextBox)Ctrl).Text = "";
                    break;
                case "System.Windows.Forms.ComboBox":
                    ((ComboBox)Ctrl).SelectedIndex = -1;
                    ((ComboBox)Ctrl).SelectedIndex = -1;
                    break;
                case "System.Windows.Forms.MaskedTextBox":
                    ((MaskedTextBox)Ctrl).Text = "";
                    break;
                case "System.Windows.Forms.DateTimePicker":
                    ((DateTimePicker)Ctrl).Value = DateTime.Parse(SysDate());
                    break;

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
            Debug.Print(Ctrl.GetType().ToString());
            switch (Ctrl.GetType().ToString())
            {
                case "ComponentFactory.Krypton.Toolkit.KryptonLabel":
                    ((ComponentFactory.Krypton.Toolkit.KryptonLabel)Ctrl).StateCommon.ShortText.Font = new System.Drawing.Font(strfont, 10, FontStyle.Bold);
                    ((ComponentFactory.Krypton.Toolkit.KryptonLabel)Ctrl).StateDisabled.ShortText.Font = new System.Drawing.Font(strfont, 10, FontStyle.Bold);
                    ((ComponentFactory.Krypton.Toolkit.KryptonLabel)Ctrl).LabelStyle = LabelStyle.TitlePanel; //    = new System.Drawing.Font("DVB-TTSurekh", 12);
                    break;
                case "System.Windows.Forms.LinkLabel":
                    ((System.Windows.Forms.LinkLabel)Ctrl).Font = new System.Drawing.Font(strfont, 10, FontStyle.Bold);
                    //((System.Windows.Forms.LinkLabel)Ctrl).LabelStyle = LabelStyle.TitlePanel; //    = new System.Drawing.Font("DVB-TTSurekh", 12);
                    break;
                case "ComponentFactory.Krypton.Toolkit.KryptonWrapLabel":
                    ((ComponentFactory.Krypton.Toolkit.KryptonWrapLabel)Ctrl).StateNormal.Font = new System.Drawing.Font(strfont, 12, FontStyle.Bold);
                    ((ComponentFactory.Krypton.Toolkit.KryptonWrapLabel)Ctrl).StateDisabled.Font = new System.Drawing.Font(strfont, 12, FontStyle.Bold);
                    ((ComponentFactory.Krypton.Toolkit.KryptonWrapLabel)Ctrl).LabelStyle = LabelStyle.TitlePanel;
                    //((System.Windows.Forms.LinkLabel)Ctrl).LabelStyle = LabelStyle.TitlePanel; //    = new System.Drawing.Font("DVB-TTSurekh", 12);
                    break;
                case "ComponentFactory.Krypton.Toolkit.KryptonLinkLabel":
                    ((ComponentFactory.Krypton.Toolkit.KryptonLinkLabel)Ctrl).StateNormal.ShortText.Font = new System.Drawing.Font(strfont, 10, FontStyle.Bold);
                    //((System.Windows.Forms.LinkLabel)Ctrl).LabelStyle = LabelStyle.TitlePanel; //    = new System.Drawing.Font("DVB-TTSurekh", 12);
                    break;
                case "ComponentFactory.Krypton.Toolkit.KryptonTextBox":
                    //    ((ComponentFactory.Krypton.Toolkit.KryptonTextBox)Ctrl).StateCommon.Content.Font = new  System.Drawing.Font("DVB-TTSurekh", 12);
                    ((ComponentFactory.Krypton.Toolkit.KryptonTextBox)Ctrl).StateCommon.Content.Font = new System.Drawing.Font(strfont, 10);
                    break;
                case "ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox":
                    //    ((ComponentFactory.Krypton.Toolkit.KryptonTextBox)Ctrl).StateCommon.Content.Font = new  System.Drawing.Font("DVB-TTSurekh", 12);
                    ((ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox)Ctrl).StateCommon.Content.Font = new System.Drawing.Font(strfont, 10);
                    break;

                case "BILLING_SYSTEM.KRYPTONNUMERICTEXTBOX":
                    //    ((ComponentFactory.Krypton.Toolkit.KryptonTextBox)Ctrl).StateCommon.Content.Font = new  System.Drawing.Font("DVB-TTSurekh", 12);
                    ((KRYPTONNUMERICTEXTBOX)Ctrl).StateCommon.Content.Font = new System.Drawing.Font(strfont, 10);
                    break;
                case "BILLING_SYSTEM.KRYPTONSELECTALLTEXTTEXTBOX":
                    //    ((ComponentFactory.Krypton.Toolkit.KryptonTextBox)Ctrl).StateCommon.Content.Font = new  System.Drawing.Font("DVB-TTSurekh", 12);
                    object o = ((KRYPTONSELECTALLTEXTTEXTBOX)Ctrl).Tag;
                    if (o != null)
                    {
                        if (((string)o).Trim() == "Unicode".Trim())
                            ((KRYPTONSELECTALLTEXTTEXTBOX)Ctrl).StateCommon.Content.Font = new System.Drawing.Font(strfont_Unicode, 12);
                    }
                    else
                        ((KRYPTONSELECTALLTEXTTEXTBOX)Ctrl).StateCommon.Content.Font = new System.Drawing.Font(strfont, 12);
                    break;
                case "ComponentFactory.Krypton.Toolkit.KryptonButton":
                    ((ComponentFactory.Krypton.Toolkit.KryptonButton)Ctrl).StateCommon.Content.ShortText.Font = new System.Drawing.Font(strfont, 10, FontStyle.Bold);
                    if (((ComponentFactory.Krypton.Toolkit.KryptonButton)Ctrl).Values.Text != ".....")
                        ((ComponentFactory.Krypton.Toolkit.KryptonButton)Ctrl).Size = new Size(((ComponentFactory.Krypton.Toolkit.KryptonButton)Ctrl).Size.Width, 33);
                    break;
                case "ComponentFactory.Krypton.Toolkit.KryptonComboBox":
                    ((ComponentFactory.Krypton.Toolkit.KryptonComboBox)Ctrl).StateActive.ComboBox.Content.Font = new System.Drawing.Font(strfont, 10);
                    ((ComponentFactory.Krypton.Toolkit.KryptonComboBox)Ctrl).StateNormal.ComboBox.Content.Font = new System.Drawing.Font(strfont, 10);
                    ((ComponentFactory.Krypton.Toolkit.KryptonComboBox)Ctrl).StateNormal.Item.Content.ShortText.Font = new System.Drawing.Font(strfont, 10);
                    ((ComponentFactory.Krypton.Toolkit.KryptonComboBox)Ctrl).StateTracking.Item.Content.ShortText.Font = new System.Drawing.Font(strfont, 10);
                    break;
                case "ComponentFactory.Krypton.Toolkit.KryptonCheckBox":
                    ((ComponentFactory.Krypton.Toolkit.KryptonCheckBox)Ctrl).StateCommon.ShortText.Font = new System.Drawing.Font(strfont, 10, FontStyle.Bold);
                    ((ComponentFactory.Krypton.Toolkit.KryptonCheckBox)Ctrl).LabelStyle = LabelStyle.TitlePanel; //    = new System.Drawing.Font("DVB-TTSurekh", 12);
                    break;
                case "ComponentFactory.Krypton.Toolkit.KryptonRadioButton":
                    ((ComponentFactory.Krypton.Toolkit.KryptonRadioButton)Ctrl).StateCommon.ShortText.Font = new System.Drawing.Font(strfont, 10);
                    ((ComponentFactory.Krypton.Toolkit.KryptonRadioButton)Ctrl).LabelStyle = LabelStyle.TitlePanel; //    = new System.Drawing.Font("DVB-TTSurekh", 12);
                    //((ComponentFactory.Krypton.Toolkit.KryptonRadioButton)Ctrl).StateNormal.ShortText.

                    break;
                case "ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker":
                    ((ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker)Ctrl).StateCommon.Content.Font = new System.Drawing.Font(strfont, 10);
                    break;
                case "ComponentFactory.Krypton.Toolkit.KryptonMessageBox":
                    ((ComponentFactory.Krypton.Toolkit.KryptonMessageBox)Ctrl).Font = new System.Drawing.Font(strfont, 10);
                    break;
                case "AC.ExtendedRenderer.Toolkit.KryptonListView":
                    ((AC.ExtendedRenderer.Toolkit.KryptonListView)Ctrl).Font = new System.Drawing.Font(strfont, 10, FontStyle.Bold);
                    ((AC.ExtendedRenderer.Toolkit.KryptonListView)Ctrl).AutoSizeLastColumn = false;
                    ((AC.ExtendedRenderer.Toolkit.KryptonListView)Ctrl).EnableHeaderGlow = true;
                    break;
                case "System.Windows.Forms.TreeView":
                    ((System.Windows.Forms.TreeView)Ctrl).Font = new System.Drawing.Font(strfont, 16, FontStyle.Bold);
                    break;
                //case "Tapal.MixedCheckBoxesTreeView" :
                //    ((Scrutiny_17_A.MixedCheckBoxesTreeView)Ctrl).Font = new System.Drawing.Font(strfont, 16, FontStyle.Bold );
                //    break;
                case "ComponentFactory.Krypton.Toolkit.KryptonForm":
                    ((ComponentFactory.Krypton.Toolkit.KryptonForm)Ctrl).StateCommon.Header.Content.ShortText.Font = new System.Drawing.Font(strfont, 10);
                    break;
                case "ComponentFactory.Krypton.Toolkit.KryptonHeader":
                    ((ComponentFactory.Krypton.Toolkit.KryptonHeader)Ctrl).StateCommon.Content.ShortText.Font = new System.Drawing.Font(strfont, 10, FontStyle.Bold);
                    ((ComponentFactory.Krypton.Toolkit.KryptonHeader)Ctrl).StateCommon.Content.LongText.Font = new System.Drawing.Font(strfont, 10, FontStyle.Bold);
                    break;
                default:
                    if (Ctrl.GetType().ToString() == "ComponentFactory.Krypton.Toolkit.KryptonPanel")
                    {
                        ((ComponentFactory.Krypton.Toolkit.KryptonPanel)Ctrl).StateCommon.ColorStyle = PaletteColorStyle.ExpertSquareHighlight;
                        //((ComponentFactory.Krypton.Toolkit.KryptonPanel)Ctrl).Palette=f.kryptonManager.GlobalPalette;
                    }
                    if (Ctrl.GetType().ToString() == "ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup")
                    {
                        ((ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup)Ctrl).StateCommon.HeaderPrimary.Content.ShortText.Font = new System.Drawing.Font(strfont, 10, FontStyle.Bold);
                        ((ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup)Ctrl).StateCommon.HeaderSecondary.Content.ShortText.Font = new System.Drawing.Font(strfont, 10, FontStyle.Bold);
                    }
                    if (Ctrl.GetType().ToString() == "ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup")
                    {
                        ((ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup)Ctrl).StateCommon.HeaderPrimary.Content.ShortText.Font = new System.Drawing.Font(strfont, 10, FontStyle.Bold);
                        ((ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup)Ctrl).StateCommon.HeaderSecondary.Content.ShortText.Font = new System.Drawing.Font(strfont, 10, FontStyle.Bold);
                    }
                    if (Ctrl.Controls.Count > 0)
                        settheme(Ctrl);
                    break;
            }
        }
    }

    public void insert_name(Control c)
    {


        //function.Setdtpdate(this);
        //((ComponentFactory.Krypton.Toolkit.KryptonForm)c).StateCommon.Header.Content.ShortText.Font = new System.Drawing.Font(strfont, 12);
        //try { settheme((KryptonForm)c, 1); }
        //catch (Exception ex) { ex.Message.ToString(); }

        foreach (Control Ctrl in c.Controls)
        {
            switch (Ctrl.GetType().ToString())
            {
                case "ComponentFactory.Krypton.Toolkit.KryptonLabel":
                    //((ComponentFactory.Krypton.Toolkit.KryptonLabel)Ctrl).StateCommon.ShortText.Font = new System.Drawing.Font(strfont, 10, FontStyle.Bold);
                    //((ComponentFactory.Krypton.Toolkit.KryptonLabel)Ctrl).LabelStyle = LabelStyle.TitlePanel; //    = new System.Drawing.Font("DVB-TTSurekh", 12);
                    MODULE.glb["ctl_temp_name"] += ((ComponentFactory.Krypton.Toolkit.KryptonLabel)Ctrl).Name.ToString() + "_" + ((ComponentFactory.Krypton.Toolkit.KryptonLabel)Ctrl).Text.ToString() + ",";
                    break;
                case "System.Windows.Forms.LinkLabel":
                    //((System.Windows.Forms.LinkLabel)Ctrl).Font = new System.Drawing.Font(strfont, 10, FontStyle.Bold);
                    MODULE.glb["ctl_temp_name"] += ((System.Windows.Forms.LinkLabel)Ctrl).Name.ToString() + "_" + ((System.Windows.Forms.LinkLabel)Ctrl).Text.ToString() + ",";
                    //((System.Windows.Forms.LinkLabel)Ctrl).LabelStyle = LabelStyle.TitlePanel; //    = new System.Drawing.Font("DVB-TTSurekh", 12);
                    break;
                case "ComponentFactory.Krypton.Toolkit.KryptonWrapLabel":
                    //((ComponentFactory.Krypton.Toolkit.KryptonWrapLabel)Ctrl).StateNormal.Font = new System.Drawing.Font(strfont, 10, FontStyle.Bold);
                    //((ComponentFactory.Krypton.Toolkit.KryptonWrapLabel)Ctrl).LabelStyle = LabelStyle.TitlePanel;
                    //((System.Windows.Forms.LinkLabel)Ctrl).LabelStyle = LabelStyle.TitlePanel; //    = new System.Drawing.Font("DVB-TTSurekh", 12);
                    MODULE.glb["ctl_temp_name"] += ((ComponentFactory.Krypton.Toolkit.KryptonWrapLabel)Ctrl).Name.ToString() + "_" + ((ComponentFactory.Krypton.Toolkit.KryptonWrapLabel)Ctrl).Text.ToString() + ",";

                    break;
                case "ComponentFactory.Krypton.Toolkit.KryptonLinkLabel":
                    //((ComponentFactory.Krypton.Toolkit.KryptonLinkLabel)Ctrl).StateNormal.ShortText.Font = new System.Drawing.Font(strfont, 10, FontStyle.Bold);
                    MODULE.glb["ctl_temp_name"] += ((ComponentFactory.Krypton.Toolkit.KryptonLinkLabel)Ctrl).Name.ToString() + "_" + ((ComponentFactory.Krypton.Toolkit.KryptonLinkLabel)Ctrl).Text.ToString() + ",";

                    //((System.Windows.Forms.LinkLabel)Ctrl).LabelStyle = LabelStyle.TitlePanel; //    = new System.Drawing.Font("DVB-TTSurekh", 12);
                    break;
                case "ComponentFactory.Krypton.Toolkit.KryptonTextBox":
                    //    ((ComponentFactory.Krypton.Toolkit.KryptonTextBox)Ctrl).StateCommon.Content.Font = new  System.Drawing.Font("DVB-TTSurekh", 12);
                    //((ComponentFactory.Krypton.Toolkit.KryptonTextBox)Ctrl).StateCommon.Content.Font = new System.Drawing.Font(strfont, 12);
                    break;
                case "ComponentFactory.Krypton.Toolkit.KryptonButton":
                    //((ComponentFactory.Krypton.Toolkit.KryptonButton)Ctrl).StateCommon.Content.ShortText.Font = new System.Drawing.Font(strfont, 15);
                    MODULE.glb["ctl_temp_name"] += ((ComponentFactory.Krypton.Toolkit.KryptonButton)Ctrl).Name.ToString() + "_" + ((ComponentFactory.Krypton.Toolkit.KryptonButton)Ctrl).Text.ToString() + ",";

                    //if (((ComponentFactory.Krypton.Toolkit.KryptonButton)Ctrl).Values.Text != ".....")
                    //    ((ComponentFactory.Krypton.Toolkit.KryptonButton)Ctrl).Size = new Size(((ComponentFactory.Krypton.Toolkit.KryptonButton)Ctrl).Size.Width, 33);
                    break;
                case "ComponentFactory.Krypton.Toolkit.KryptonComboBox":
                    //((ComponentFactory.Krypton.Toolkit.KryptonComboBox)Ctrl).StateActive.ComboBox.Content.Font = new System.Drawing.Font(strfont, 12);
                    //((ComponentFactory.Krypton.Toolkit.KryptonComboBox)Ctrl).StateNormal.ComboBox.Content.Font = new System.Drawing.Font(strfont, 12);
                    //((ComponentFactory.Krypton.Toolkit.KryptonComboBox)Ctrl).StateNormal.Item.Content.ShortText.Font = new System.Drawing.Font(strfont, 12);
                    //((ComponentFactory.Krypton.Toolkit.KryptonComboBox)Ctrl).StateTracking.Item.Content.ShortText.Font = new System.Drawing.Font(strfont, 12);
                    break;
                case "ComponentFactory.Krypton.Toolkit.KryptonCheckBox":
                    //((ComponentFactory.Krypton.Toolkit.KryptonCheckBox)Ctrl).StateCommon.ShortText.Font = new System.Drawing.Font(strfont, 10, FontStyle.Bold);
                    //((ComponentFactory.Krypton.Toolkit.KryptonCheckBox)Ctrl).LabelStyle = LabelStyle.TitlePanel; //    = new System.Drawing.Font("DVB-TTSurekh", 12);
                    MODULE.glb["ctl_temp_name"] += ((ComponentFactory.Krypton.Toolkit.KryptonCheckBox)Ctrl).Name.ToString() + "_" + ((ComponentFactory.Krypton.Toolkit.KryptonCheckBox)Ctrl).Text.ToString() + ",";

                    break;
                case "ComponentFactory.Krypton.Toolkit.KryptonRadioButton":
                    //((ComponentFactory.Krypton.Toolkit.KryptonRadioButton)Ctrl).StateCommon.ShortText.Font = new System.Drawing.Font(strfont, 12);
                    //((ComponentFactory.Krypton.Toolkit.KryptonRadioButton)Ctrl).LabelStyle = LabelStyle.TitlePanel; //    = new System.Drawing.Font("DVB-TTSurekh", 12);
                    ////((ComponentFactory.Krypton.Toolkit.KryptonRadioButton)Ctrl).StateNormal.ShortText.
                    MODULE.glb["ctl_temp_name"] += ((ComponentFactory.Krypton.Toolkit.KryptonRadioButton)Ctrl).Name.ToString() + "_" + ((ComponentFactory.Krypton.Toolkit.KryptonRadioButton)Ctrl).Text.ToString() + ",";

                    break;
                case "ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker":
                    //((ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker)Ctrl).StateCommon.Content.Font = new System.Drawing.Font(strfont, 12);
                    break;
                case "AC.ExtendedRenderer.Toolkit.KryptonListView":
                    //((AC.ExtendedRenderer.Toolkit.KryptonListView)Ctrl).Font = new System.Drawing.Font(strfont, 18);
                    //((AC.ExtendedRenderer.Toolkit.KryptonListView)Ctrl).AutoSizeLastColumn = false;
                    break;
                case "System.Windows.Forms.TreeView":
                    //((System.Windows.Forms.TreeView)Ctrl).Font = new System.Drawing.Font(strfont, 18, FontStyle.Bold);
                    break;
                case "Tapal.MixedCheckBoxesTreeView":
                    //((Tapal.MixedCheckBoxesTreeView)Ctrl).Font = new System.Drawing.Font(strfont, 18, FontStyle.Bold);
                    break;
                case "ComponentFactory.Krypton.Toolkit.KryptonForm":
                    //((ComponentFactory.Krypton.Toolkit.KryptonForm)Ctrl).StateCommon.Header.Content.ShortText.Font = new System.Drawing.Font(strfont, 12);
                    break;
                case "ComponentFactory.Krypton.Toolkit.KryptonHeader":
                    //((ComponentFactory.Krypton.Toolkit.KryptonHeader)Ctrl).StateCommon.Content.ShortText.Font = new System.Drawing.Font(strfont, 10, FontStyle.Bold);
                    //((ComponentFactory.Krypton.Toolkit.KryptonHeader)Ctrl).StateCommon.Content.LongText.Font = new System.Drawing.Font(strfont, 16, FontStyle.Bold);
                    MODULE.glb["ctl_temp_name"] += ((ComponentFactory.Krypton.Toolkit.KryptonHeader)Ctrl).Name.ToString() + "_" + ((ComponentFactory.Krypton.Toolkit.KryptonHeader)Ctrl).Text.ToString() + ",";

                    break;
                default:
                    if (Ctrl.GetType().ToString() == "ComponentFactory.Krypton.Toolkit.KryptonPanel")
                    {
                        ((ComponentFactory.Krypton.Toolkit.KryptonPanel)Ctrl).StateCommon.ColorStyle = PaletteColorStyle.ExpertSquareHighlight;
                        //((ComponentFactory.Krypton.Toolkit.KryptonPanel)Ctrl).Palette=f.kryptonManager.GlobalPalette;
                    }
                    if (Ctrl.GetType().ToString() == "ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup")
                    {
                        //((ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup)Ctrl).StateCommon.HeaderPrimary.Content.ShortText.Font = new System.Drawing.Font(strfont, 18, FontStyle.Bold);
                        //((ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup)Ctrl).StateCommon.HeaderSecondary.Content.ShortText.Font = new System.Drawing.Font(strfont, 16, FontStyle.Bold);
                        MODULE.glb["ctl_temp_name"] += ((ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup)Ctrl).Name.ToString() + "_" + ((ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup)Ctrl).Text.ToString() + ",";

                    }
                    if (Ctrl.GetType().ToString() == "ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup")
                    {
                        //((ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup)Ctrl).StateCommon.HeaderPrimary.Content.ShortText.Font = new System.Drawing.Font(strfont, 18, FontStyle.Bold);
                        //((ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup)Ctrl).StateCommon.HeaderSecondary.Content.ShortText.Font = new System.Drawing.Font(strfont, 16, FontStyle.Bold);

                    }
                    if (Ctrl.Controls.Count > 0)
                        insert_name(Ctrl);
                    break;
            }
        }
    }

    public void settheme(KryptonForm ownform, int? a)
    {
        ownform.StateCommon.Header.Content.ShortText.Font = new System.Drawing.Font(strheaderfont, 11, FontStyle.Bold);
    }

    public void open_form(Form ownform, bool closeYN, string new_form)
    {
        FRM_MAIN m = new FRM_MAIN();

        MODULE.glb["FORMNAME"] = new_form;

        if (closeYN == true)
        {
            ownform.Close();
        }
        m.Main_Panel_Panel2_ControlRemoved(ownform, new ControlEventArgs(ownform));
    }

    public string set_theme_name(bool RW, string name)
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
                    return ("Office2010Blue");
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
            return string.IsNullOrEmpty(txtline) ? "Office2010Blue" : txtline;
        }
    }
    public AutoCompleteStringCollection set_user_name(bool RW, string name)
    {
        string filename = "";
        AutoCompleteStringCollection txtline = new AutoCompleteStringCollection();
        AutoCompleteStringCollection return_a;
        try
        {
            if (File.Exists(Application.StartupPath.ToString() + "\\UserName"))
            {
                filename = Application.StartupPath.ToString() + "\\UserName";
                if (RW == true)
                {
                    System.IO.StreamReader objReader;
                    objReader = new System.IO.StreamReader(filename);
                    do
                    {
                        txtline.Add(Encrypt(Encrypt(Encrypt(objReader.ReadLine()))));

                    } while (objReader.Peek() != -1);
                    objReader.Close();
                }
                else
                {

                    System.IO.StreamWriter objWriter;
                    objWriter = new System.IO.StreamWriter(filename, true);
                    objWriter.WriteLine("\n" + Decrypt(Decrypt(Decrypt(name.ToString()))));
                    objWriter.Close();
                    System.IO.StreamReader objReader = new System.IO.StreamReader(filename);
                    do
                    {
                        txtline.Add(Encrypt(Encrypt(Encrypt(objReader.ReadLine()))));

                    } while (objReader.Peek() != -1);
                    objReader.Close();
                }
            }
            else
            {
                if (RW == true)
                {
                    return_a = new AutoCompleteStringCollection();
                }
                else
                {
                    StreamWriter sw = System.IO.File.CreateText(Application.StartupPath.ToString() + "\\UserName");
                    sw.Write(Decrypt(Decrypt(Decrypt(name.ToString()))));
                    sw.Close();
                }



            }
            //AutoCompleteStringCollection a = new AutoCompleteStringCollection();
            //a.AddRange(txtline);
            return_a = txtline;
        }
        catch (Exception ex)
        {
            ex.Message.ToString();
            return_a = new AutoCompleteStringCollection();
        }
        return return_a;
    }
    public PaletteModeManager PalletMode(string name)
    {

        if (name == "Office2010Blue")
            return (PaletteModeManager.Office2010Blue);

        else if (name == "Office2010Silver")
            return (PaletteModeManager.Office2010Silver);

        else if (name == "Office2010Black")
            return (PaletteModeManager.Office2010Black);

        else if (name == "Office2007Blue")
            return (PaletteModeManager.Office2007Blue);

        else if (name == "Office2007Silver")
            return (PaletteModeManager.Office2007Silver);

        else if (name == "Office2007Black")
            return (PaletteModeManager.Office2007Black);

        else if (name == "SparkleBlue")
            return (PaletteModeManager.SparkleBlue);

        else if (name == "SparkleOrange")
            return (PaletteModeManager.SparkleOrange);

        else if (name == "SparklePurple")
            return (PaletteModeManager.SparklePurple);

        else if (name == "ProfessionalOffice2003")
            return (PaletteModeManager.ProfessionalOffice2003);

        else if (name == "ProfessionalSystem")
            return (PaletteModeManager.ProfessionalSystem);
        else
            return (PaletteModeManager.SparkleOrange);


    }
    public void add_form_on_panel(KryptonForm newform, KryptonForm ownerform)
    {
        newform.TopLevel = false;
        newform.StateCommon.Header.Content.ShortText.Font = new System.Drawing.Font("DVB-TTSurekh", 25, FontStyle.Bold);
        add_form_panel a = new add_form_panel();
        ownerform.Controls.Add(a);
        a.kryptonPanel1.Controls.Add(newform);
    }
    public void Message_Show(KryptonForm ownerform, String msg)
    {
        KryptonLabel l_cap = new KryptonLabel();
        l_cap.Text = "एरर ईनफ़ॅमेशन";
        l_cap.Dock = DockStyle.Top;
        l_cap.SendToBack();
        l_cap.AutoSize = true;

        KryptonLabel l = new KryptonLabel();
        l.Text = "- " + msg + ".";
        l.Dock = DockStyle.Fill;
        l.BringToFront();
        l.AutoSize = true;
        KryptonButton b = new KryptonButton();
        b.Dock = DockStyle.Bottom;
        b.Text = "OK";
        b.Click += new EventHandler(b_click);
        b.SendToBack();
        b.Visible = true;
        ownerform_msg = ownerform;
        add_form_panel a = new add_form_panel(false);
        a.Parent = ownerform;
        //a.kryptonPanel1.Controls.Add(l_cap);
        a.kryptonPanel1.Controls.Add(l);
        a.kryptonPanel1.Controls.Add(b);
        ownerform.Controls.Add(a);
        a.Parent = ownerform;
        a.BringToFront();
        a.Enabled = true;
        settheme(a);
        a.Show();
    }
    public void Message_Show(KryptonForm ownerform, String msg, string caption)
    {
        //KryptonMessageBox.Show(ownerform, msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        //MessageBox.Show(ownerform, msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);


        MyMessageBox.ShowBox(msg, caption);


    }
    public void Message_Show(KryptonForm ownerform, String msg, int timer_millisec)
    {
        //KryptonLabel l_cap = new KryptonLabel();
        //l_cap.Text = "एरर ईनफ़ॅमेशन";
        //l_cap.Dock = DockStyle.Top;
        //l_cap.SendToBack();
        //l_cap.AutoSize = true;

        //KryptonLabel l = new KryptonLabel();
        //l.Text = "- " + msg + ".";
        //l.Dock = DockStyle.Fill;
        //l.BringToFront();
        //l.AutoSize = true;
        //KryptonButton b = new KryptonButton();
        //b.Dock = DockStyle.Bottom;
        //b.Text = "OK";
        //b.Click += new EventHandler(b_click);
        //b.SendToBack();
        //b.Visible = true;
        //ownerform_msg = ownerform;
        //add_form_panel a = new add_form_panel(false);
        //a.Parent = ownerform;
        ////a.kryptonPanel1.Controls.Add(l_cap);
        //a.kryptonPanel1.Controls.Add(l);
        //a.kryptonPanel1.Controls.Add(b);
        //ownerform.Controls.Add(a);
        //a.Parent = ownerform;
        //a.BringToFront();
        //a.Enabled = true;
        //settheme(a);
        //a.Show();

        //t = new System.Windows.Forms.Timer();

        //t.Tick += new System.EventHandler(t_Tick);
        //t.Enabled = true;
        //t.Start();
        //t.Interval = timer_millisec;

        MyMessageBox.ShowBox(msg, "", timer_millisec);
    }
    public void Message_Show(KryptonForm ownerform, String msg, string caption, int timer_millisec)
    {
        MyMessageBox.ShowBox(msg, caption, timer_millisec);
    }
    private void t_Tick(object sender, EventArgs e)
    {
        b_click(sender, e);
        t.Stop();
        t.Enabled = false;
    }
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

    public bool SearchTextInListView_bool(ListView lst, string Search)
    {
        bool vr = false;
        try
        {
            foreach (ListViewItem item in lst.Items)
            {
                item.Selected = false;
            }
            string iSearch = Search.ToLower();
            for (int colAll = 0; colAll <= lst.Columns.Count - 1; colAll++)
                foreach (ListViewItem item in lst.Items)
                {
                    if (item.SubItems[colAll].Text.IndexOf(iSearch.Trim()) > -1 |
                        item.SubItems[colAll].Text.ToUpper().IndexOf(iSearch.ToUpper().Trim()) > -1)
                    {
                        vr = true;
                        break;
                    }
                }
        }
        catch (Exception ex)
        { ex.Message.ToString(); }
        return vr;
    }
    public delegate void SearchTextInListViewDelegate(ListView lst, string Search);
    public void SearchTextInListView(ListView lst, string Search)
    {
        try
        {
            if (lst.InvokeRequired)
            {
                lst.Invoke(new SearchTextInListViewDelegate(SearchTextInListView), new object[] { lst, Search });
            }
            else
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
        }
        catch (Exception ex)
        { ex.Message.ToString(); }
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
    public void SearchTextInListView_on_column(ListView lst, int column, string Search, bool exact)
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
                if (exact == true)
                    if (item.SubItems[column].Text == (iSearch.Trim()) |
                        item.SubItems[column].Text.ToUpper() == iSearch.ToUpper().Trim())
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

    //public void Show_Report(BUSSINESS_LAYER.REPORT_LIST RptName)
    //{
    //    CopyAllKeys();
    //    REPORT_LAYER.MODULE_RPT rpt_obj = new REPORT_LAYER.MODULE_RPT();
    //    rpt_obj.Show_Report(RptName);
    //}
    //public void Show_Report(BUSSINESS_LAYER.REPORT_LIST RptName, string Value)
    //{
    //    CopyAllKeys();
    //    REPORT_LAYER.MODULE_RPT rpt_obj = new REPORT_LAYER.MODULE_RPT();
    //    rpt_obj.Show_Report(RptName, Value);
    //}
    //public void Show_Report(BUSSINESS_LAYER.REPORT_LIST RptName, DataSet ds, int tableno)
    //{
    //    CopyAllKeys();
    //    REPORT_LAYER.MODULE_RPT rpt_obj = new REPORT_LAYER.MODULE_RPT();
    //    rpt_obj.Show_Report(RptName, ds, tableno);
    //}

    //public void Show_Report(BUSSINESS_LAYER.REPORT_LIST RptName, DataSet ds, int tableno, String OfficeId, DateTime fromdate, DateTime todate)
    //{
    //    CopyAllKeys();
    //    REPORT_LAYER.MODULE_RPT rpt_obj = new REPORT_LAYER.MODULE_RPT();
    //    rpt_obj.Show_Report(RptName, ds, tableno);
    //}
    //private void CopyAllKeys()
    //{
    //    for (int i = 0; i < MODULE.glb.Keys.Count; i++)
    //    {
    //        string str = MODULE.glb.Keys[i].ToString();
    //        MODULE_RPT.glb_Rpt[(MODULE.glb.Keys[i].ToString())] = MODULE.glb[str].ToString();
    //        //module_Rpt.glb_Rpt[i]=module.glb.Keys[i].ToString()

    //    }
    //}
    public DataTable EnumToDataTable(Type enumType)
    {
        DataTable table = new DataTable();
        //Get the type of ENUM for DataColumn
        table.Columns.Add("Id", Enum.GetUnderlyingType(enumType));
        //Column that contains the Captions/Keys of Enum        
        table.Columns.Add("Desc", typeof(string));

        //Add the items from the enum:
        foreach (string name in Enum.GetNames(enumType))
        {
            //Replace underscores with space from caption/key and add item to collection:
            table.Rows.Add(Enum.Parse(enumType, name), name.Replace('_', ' '));
        }

        return table;
    }

}
