using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using System.Runtime.InteropServices;
using System.IO;
using BUSSINESS_LAYER;

namespace BILLING_SYSTEM
{
    public partial class FRM_LOGIN : KryptonForm
    {
        MODULE function = new MODULE();
        BL_USERMASTER bl_obj = new BL_USERMASTER();
        BL_LOGIN bl_obj1 = new BL_LOGIN();
        string strcmpname = "";
        string str = "";
        int len = 0;
        int cnt = 0;
        int cnt1 = 0;

        private string[] folderFile = null;
        private int selected = 0;
        private int begin = 0;
        private int end = 0;

        [DllImport("shell32.dll", EntryPoint = "ShellExecute")]
        public static extern int ShellExecuteA(int hwnd, string
        lpOperation, string lpFile, string lpParameters, string lpDirectory,
        int nShowCmd);
        public FRM_LOGIN()
        {
            InitializeComponent();
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {
            try
            {
                textBox1.AutoCompleteCustomSource = function.set_user_name(true, "");
                function.settheme(this);

                //kryptonManager1.GlobalPalette = function.set_theme_name(true, "");
                strcmpname = loginheader.ValuesSecondary.Heading;

                len = strcmpname.Length;
                timer2.Enabled = true;
                kryptonManager1.GlobalPaletteMode = function.PalletMode(function.set_theme_name(true, ""));

                //this.StateCommon.Header.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 14);
                try
                {
                    string[] part1 = null, part2 = null, part3 = null;
                    part1 = Directory.GetFiles("img\\", "*.jpg");
                    part2 = Directory.GetFiles("img\\", "*.gif");
                    //part3 = Directory.GetFiles("img\\", "*.*");
                    part3 = Directory.GetFiles("img\\", "*.png");

                    folderFile = new string[part1.Length + part2.Length + part3.Length];

                    Array.Copy(part1, 0, folderFile, 0, part1.Length);
                    Array.Copy(part2, 0, folderFile, part1.Length, part2.Length);
                    Array.Copy(part3, 0, folderFile, part1.Length + part2.Length, part3.Length);

                    selected = 0;
                    begin = 0;
                    end = folderFile.Length;

                    showImage(folderFile[selected]);
                }
                catch (Exception ex)
                {
                    BL_Error_Log.WriteLog(ex);
                }

                try
                {
                    cnt = 0;
                    //function.get_prv_instance();

                    //Int64 midx;
                    //Int64 midy;
                    //midx = Screen.PrimaryScreen.WorkingArea.Width;
                    //midy = Screen.PrimaryScreen.WorkingArea.Height;
                    //loginheader.Left = Int32.Parse("" + ((midx / 2) - (loginheader.Width / 2)));
                    //loginheader.Top = Int32.Parse("" + ((midy / 2) - (loginheader.Width / 2)));
                    //panel1.Left = loginheader.Location.X;
                    //panel1.Top = loginheader.Location.Y;
                    //panel1.Location = new Point(loginheader.Location.X, panel1.Location.Y - panel1.Height);

                    if (bl_obj.connectedYN_Local() == false)
                    {
                        KryptonMessageBox.Show("\nConnection Is Not Available .\n", "Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                        Application.Exit();

                    }

                    //textBox1.Text = panel2.Left.ToString();
                    //maskedTextBox1.Text = panel2.Top.ToString();
                    //bl_obj.Load_Login = true;
                    //DataSet ds = bl_obj.SELECT(bl_obj);
                    //function.fillcombo(cboPlno, ds.Tables[0]);
                    //function.fillcombo(CboAcNo, ds.Tables[1]);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + " - " + ex.Source);
                }
            }
            catch (Exception ex)
            {
                BL_Error_Log.WriteLog(ex);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private bool Validate()
        {
            if (textBox1.Text.Trim().CompareTo("") == 0)
            {
                KryptonMessageBox.Show("User name should not blank");
                return false;
            }
            else if (maskedTextBox1.Text.Trim().CompareTo("") == 0)
            {
                KryptonMessageBox.Show("Password should not blank");
                return false;
            }
            else
            {
                return true;
            }

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            cnt++;
            if (cnt <= 3)
            {
                if (Validate())
                {
                    bl_obj.Load_Login = false;
                    bl_obj1.UserName = textBox1.Text;
                    bl_obj1.Password = (function.Decrypt(maskedTextBox1.Text));
                    DataSet ds = bl_obj1.select(bl_obj1);

                    if (function.CheckExistsDs(ds, 0))
                    {
                        MODULE.glb.Clear();
                        MODULE.glb.Add("USERNAME", ds.Tables[0].Rows[0]["UserName"].ToString());
                        MODULE.glb.Add("GROUP_ID", ds.Tables[0].Rows[0]["GroupId"].ToString());
                        MODULE.glb.Add("SHOP_ID", ds.Tables[0].Rows[0]["UserId"].ToString());
                        MODULE.glb.Add("SHOP_NAME", "WATER BILLING SOLUTION");
                        MODULE.glb.Add("GROUP_NAME", "Developer");
                        label4.Text = "Login Successfully".ToUpper();
                        SuccessLogin();
                        return;
                    }
                    else
                    {
                        ShowErrorMessage();
                    }
                    panel1.Left = loginheader.Location.X;
                    panel1.Top = 0;
                    panel1.Location = new Point(loginheader.Location.X, panel1.Location.Y - panel1.Height);
                    timer1.Enabled = true;
                    panel1.Visible = true;
                    button3.Focus();
                }
            }
            else
            {
                MessageBox.Show("Access Denied", "Acces Denied", MessageBoxButtons.OK);
                Application.Exit();
            }
        }

        private void ShowErrorMessage()
        {
            label4.Text = "User Name Or Password Is Incorrect";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!(loginheader.Location.Y + 50 <= panel1.Location.Y))
            {
                panel1.Location = new Point(panel1.Location.X, panel1.Location.Y + 20);
                listBox1.Items.Add(panel1.Location);
                listBox2.Items.Add(panel2.Location);
                panel1.Enabled = true;
                button3.Focus();
            }
            else
            {
                panel1.Enabled = true;
                timer1.Enabled = false;
                button3.Focus();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SuccessLogin();
        }

        private void SuccessLogin()
        {
            if (label4.Text.ToUpper().CompareTo("LOGIN SUCCESSFULLY".ToUpper()) == 0)
            {

                if (!textBox1.AutoCompleteCustomSource.Contains(textBox1.Text))
                    function.set_user_name(false, textBox1.Text);



                //this.ActiveForm.Hide();
                this.Dispose(false);
                //LAQ.Form1 f = new Form1();
                //LAQ.Main_Form f1 = new Main_Form();
                timer1.Enabled = false;
                timer2.Enabled = false;
                timer3.Enabled = false;
                FRM_MAIN f1 = new FRM_MAIN();
                f1.Show();
                //f.Show();
            }
            else
            {
                timer1.Enabled = false;
                panel2.Enabled = true;
                panel1.Visible = false;
            }
        }

        private void maskedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char[] ch = e.KeyChar.ToString().ToCharArray();
            if ((int)ch[0] == 13)
            {
                button1_Click_1(sender, e);
            }



        }
        private void buttonSpecHeaderGroup1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //kryptonLabel5.Text = DateTime.Now.ToString();
            kryptonHeader1.Values.Description = DateTime.Now.ToString() + "   ";
            if (cnt1 <= len)
            {
                loginheader.ValuesSecondary.Heading = strcmpname.Substring(cnt1) + " ***** " + strcmpname.Substring(0, cnt1);
                cnt1++;
            }
            else
                cnt1 = 0;

        }
        private void kryptonPanel1_Initialized(object sender, EventArgs e)
        {
            Int64 midx;
            Int64 midy;
            midx = Screen.PrimaryScreen.WorkingArea.Width;
            midy = Screen.PrimaryScreen.WorkingArea.Height;
            loginheader.Left = Int32.Parse("" + ((midx / 2) - (loginheader.Width / 2)));
            loginheader.Top = Int32.Parse("" + ((midy / 2) - (loginheader.Width / 2)));
            panel1.Left = loginheader.Location.X;
            panel1.Top = loginheader.Location.Y;
            panel1.Location = new Point(loginheader.Location.X, panel1.Location.Y - panel1.Height);

        }

        private void btn_font_problem_Click(object sender, EventArgs e)
        {
            string[] arr = Environment.GetCommandLineArgs();
            String FontPath = Application.StartupPath.ToString() + "\\Fonts\\*.ttf";
            ShellExecuteA(0, "open", FontPath, "", "", 0);
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = false;

            Form.ActiveForm.Hide();
            //LAQ.Form1 f = new Form1();
            //LAQ.Main_Form f1 = new Main_Form();

            FRM_MAIN f1 = new FRM_MAIN();
            f1.Show();
        }
        private void nextImage()
        {
            try
            {
                if (selected == folderFile.Length - 1)
                {
                    selected = 0;
                    showImage(folderFile[selected]);
                }
                else
                {
                    selected = selected + 1;
                    showImage(folderFile[selected]);
                }
            }
            catch (Exception ex)
            { BL_Error_Log.WriteLog(ex); }
        }
        private void showImage(string path)
        {
            Image imgtemp = Image.FromFile(path);
            pictureBox1.Width = imgtemp.Width / 2;
            pictureBox1.Height = imgtemp.Height / 2;
            pictureBox1.Image = imgtemp;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            nextImage();
        }

        private void textBox1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void FRM_LOGIN_FormClosing(object sender, FormClosingEventArgs e)
        {
            function.SetDeskTopResolution();
        }

    }
}