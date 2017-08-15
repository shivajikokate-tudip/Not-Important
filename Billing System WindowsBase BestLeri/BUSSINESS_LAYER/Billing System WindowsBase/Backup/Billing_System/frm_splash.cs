using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Globalization;
using System.Reflection;
using BUSSINESS_LAYER;


namespace BILLING_SYSTEM
{
    public partial class frm_splash : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        [DllImport("kernel32.dll")]
        private static extern uint GetUserDefaultLCID();
        [DllImport("kernel32.dll")]
        static extern bool SetLocaleInfo(uint Locale, uint LCType,
        string lpLCData);
        public const int LOCALE_SSHORTDATE = 0x1F;
        public const int LOCALE_SDATE = 0x1D;

        Tapal_Settings setting = new Tapal_Settings();
        BL bl_obj = new BL();
        MODULE function = new MODULE();
        public frm_splash()
        {
            InitializeComponent();
        }

        private void frm_splash_Load(object sender, EventArgs e)
        {

            //string text = "";
            kryptonManager1.GlobalPaletteMode = function.PalletMode(function.set_theme_name(true, ""));
            function.settheme(this);
            //Assembly SampleAssembly = Assembly.GetExecutingAssembly();
            //Type[] ts = SampleAssembly.GetTypes(); ;

            //for (int i = 0; i < ts.Length; i++)
            //{
            //    if (ts[i].IsSubclassOf(typeof(Form)) || (ts[i]).GetType() == typeof(Form))
            //    {
            //        try
            //        {
            //            text += ts[i].Name + "\n";
            //            module.glb["f_temp_name"] = ts[i].Name;
            //            module.glb["ctl_temp_name"] = "";
            //            Form f = (Form)SampleAssembly.CreateInstance(ts[i].ToString());
            //            f.Show();
            //            function.insert_name(f);
            //            List<string> para = new List<string>();
            //            List<string> para_value = new List<string>();
            //            para.Add("@fname");
            //            para_value.Add(module.glb["f_temp_name"].ToString());
            //            para.Add("@ctlname_text");
            //            para_value.Add(module.glb["ctl_temp_name"].ToString());
            //            DataSet ds = bl_obj.blFill_para_name(para, para_value, "sp_insert_name");
            //            module.glb["ctl_temp_name"] = "";
            //        }
            //        catch (Exception ex)
            //        {

            //        }
            //    }
            //}
            //MessageBox.Show(text);
        }

        public static void SetShortDate(string strShortDate)
        {
            uint lngLCID;
            lngLCID = GetUserDefaultLCID();
            SetLocaleInfo(lngLCID, LOCALE_SSHORTDATE, strShortDate);
            SetLocaleInfo(lngLCID, LOCALE_SDATE, "/");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                frm_name.Text = progressBar1.Value >= 20 && progressBar1.Value < 40 ? "Checking Date Format.." : progressBar1.Value >= 40 && progressBar1.Value < 60 ? "Checking Connection.." : progressBar1.Value >= 60 && progressBar1.Value < 80 ? "Checking Date.." : progressBar1.Value >= 80 & progressBar1.Value < 90 ? "Setting Resolution" : progressBar1.Value >= 90 && progressBar1.Value < 95 ? "Checking Update.." : "Checking Forms..";
                if (progressBar1.Value == 30)
                {
                    DateTime dt = new DateTime(2011, 6, 15);
                    if (dt.ToString().Substring(0, 11).Trim() != "15/06/2011")
                    {
                        timer1.Enabled = false;
                        SetShortDate("dd/MM/yyyy");
                        KryptonMessageBox.Show(this, "DATE TIME Format is Not Proper. Restarting the application", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Application.Restart();
                    }
                }
                if (progressBar1.Value == 60)
                {
                    try
                    {
                        if (ok() == false && setting.ConnectionStringUpdate == false)
                        {
                            timer1.Enabled = false;
                            Frm_Connection_Update f = new Frm_Connection_Update();
                            f.Show();
                        }
                        else if (ok() == false && setting.ConnectionStringUpdate == true)
                        {
                            timer1.Enabled = false;
                            KryptonMessageBox.Show(this, "Not Conected To Database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Dispose(false);
                            Application.Exit();
                        }
                    }
                    catch (Exception ex)
                    {
                        new MODULE().WriteErrorLog(ex.StackTrace.ToString());
                    }

                }

                if (progressBar1.Value == 60)
                {
                    //BL bl_obj = new BL();
                    //DataSet ds= bl_obj.blFill("sp_get_date");

                    //DateTime dt = DateTime.Today; 
                    //if (dt.ToShortDateString() != ds.Tables[0].Rows[0][0].ToString())
                    //{
                    //    timer1.Enabled = false;
                    //    //SetShortDate("dd/MM/yyyy");
                    //    KryptonMessageBox.Show(this,"DATE is Not Proper . So set date to " + ds.Tables[0].Rows[0][0].ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //    this.Dispose(false);
                    //    Application.Exit();

                    //}
                }

                if (progressBar1.Value == 80)
                {
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
                progressBar1.Value = progressBar1.Value + 1;
            }
            if (progressBar1.Value >= 100)
            {
                timer1.Enabled = false;
                this.Dispose(false);
                new FRM_LOGIN().Show();
            }
        }
        private bool ok()
        {
            bool okyn = false;
            string new_connectionstring = setting.ConnectionString_Web.ToString();
            if (setting.ConnectionStringUpdate == true)
            {
                okyn = new BL().checkConnection(new_connectionstring);
                if (okyn)
                {
                    //new_connectionstring = setting.ConnectionString_Local.ToString();
                    string Con_Type = setting.Con_Type.ToString();
                    okyn = new BL().checkConnection_Local(new_connectionstring, Con_Type);
                }
            }
            else
            {
                okyn = new BL().checkConnection(new_connectionstring);
                setting.ConnectionStringUpdate = true;
                setting.Save();
                setting.Reload();
            }

            return okyn;
        }
    }
}