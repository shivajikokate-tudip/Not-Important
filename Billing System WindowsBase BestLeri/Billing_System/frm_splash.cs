using System;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using System.Runtime.InteropServices;
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

        BILLING_SYSTEM.Settings setting = new BILLING_SYSTEM.Settings();
        BL bl_obj = new BL();
        MODULE function = new MODULE();
        public frm_splash()
        {
            InitializeComponent();
        }

        private void frm_splash_Load(object sender, EventArgs e)
        {
            kryptonManager1.GlobalPaletteMode = function.PalletMode(function.set_theme_name(true, ""));
            function.settheme(this);
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
                        if (IsConnectionValid() == false && setting.ConnectionStringUpdate == false)
                        {
                            timer1.Enabled = false;
                            Frm_Connection_Update f = new Frm_Connection_Update();
                            f.Show();
                        }
                        else if (IsConnectionValid() == false && setting.ConnectionStringUpdate == true)
                        {
                            timer1.Enabled = false;
                            KryptonMessageBox.Show(this, "Please check database connection!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Dispose(false);
                            Application.Exit();
                        }
                    }
                    catch (Exception ex)
                    {
                        new MODULE().WriteErrorLog(ex.StackTrace.ToString());
                    }

                }

                if (progressBar1.Value == 80)
                {
                    /* Default screen resolution */
                    //int tempHeight = 0, tempWidth = 0;
                    //Screen Srn = Screen.PrimaryScreen;
                    //tempHeight = Srn.Bounds.Width;
                    //tempWidth = Srn.Bounds.Height;
                    //setting.ExistingResolution = tempHeight.ToString() + " , " + tempWidth.ToString();
                    //setting.Save();
                    //setting.Reload();
                    ////if(tempHeight<1024)
                    ////{
                    //string str = setting.SetResolution.ToString();
                    //CResolution ChangeRes = new CResolution(Int32.Parse(str.Split(',')[0].Trim().ToString()), Int32.Parse(str.Split(',')[1].Trim().ToString()));
                    ////}
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
        private bool IsConnectionValid()
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