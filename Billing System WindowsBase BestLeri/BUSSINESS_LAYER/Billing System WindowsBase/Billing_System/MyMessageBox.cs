using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace BILLING_SYSTEM
{
    public partial class MyMessageBox : KryptonForm
    {

        static MyMessageBox newMessageBox;
        public Timer msgTimer;
        static string Button_id;
        int disposeFormTimer;
        static int _time_millisec = 1000;
        MODULE function = new MODULE();

        public MyMessageBox()
        {
            InitializeComponent();
            function.settheme(this);
        }
        public MyMessageBox(int TimeInterval)
        {
            InitializeComponent();
            function.settheme(this);
            _time_millisec = TimeInterval;
        }

        public static string ShowBox(string txtMessage)
        {

            newMessageBox = new MyMessageBox();
            newMessageBox.lblMessage.Text = txtMessage;
            newMessageBox.Height = newMessageBox.pictureBox1.Height + (newMessageBox.panel1.Height + 50) + (newMessageBox.kryptonPanel1.Height + 50);
            //newMessageBox.Width = newMessageBox.lblMessage.Width + 25; 
            newMessageBox.ShowDialog();
            return Button_id;
        }

        public static string ShowBox(string txtMessage, string txtTitle)
        {

            newMessageBox = new MyMessageBox();
            newMessageBox.lblTitle.Text = txtTitle;
            newMessageBox.lblMessage.Text = txtMessage;
            newMessageBox.Height = newMessageBox.pictureBox1.Height + (newMessageBox.panel1.Height + 50) + (newMessageBox.kryptonPanel1.Height + 50);
            //newMessageBox.Width = newMessageBox.lblMessage.Width + 25; 
            newMessageBox.ShowDialog();
            return Button_id;
        }

        public static string ShowBox(string txtMessage, string txtTitle, int time_millisec)
        {

            newMessageBox = new MyMessageBox(time_millisec);
            newMessageBox.lblTitle.Text = txtTitle;
            newMessageBox.lblMessage.Text = txtMessage;
            newMessageBox.Height = newMessageBox.pictureBox1.Height + (newMessageBox.panel1.Height + 50) + (newMessageBox.kryptonPanel1.Height + 50);
            //newMessageBox.Width = newMessageBox.lblMessage.Width + 25; 
            newMessageBox.ShowDialog();
            _time_millisec = time_millisec;

            return Button_id;
        }

        private void MyMessageBox_Load(object sender, EventArgs e)
        {
            function.settheme(this);
            newMessageBox.Height = newMessageBox.pictureBox1.Height + (newMessageBox.panel1.Height + 50) + (newMessageBox.kryptonPanel1.Height + 50);
            //newMessageBox.Width = newMessageBox.lblMessage.Width + 25; 
            disposeFormTimer = 30;
            newMessageBox.lblTimer.Text = disposeFormTimer.ToString();
            msgTimer = new Timer();

            if (_time_millisec >= 1)
            {
                msgTimer.Interval = _time_millisec;
                msgTimer.Enabled = true;
                msgTimer.Start();
                msgTimer.Tick += new System.EventHandler(this.timer_tick);

            }
            else
            { lblTimer.Visible = false; }
        }

        private void MyMessageBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics mGraphics = e.Graphics;
            Pen pen1 = new Pen(Color.FromArgb(96, 155, 173), 1);

            newMessageBox.Height = newMessageBox.pictureBox1.Height + (newMessageBox.panel1.Height + 50) + (newMessageBox.kryptonPanel1.Height + 50);
            // newMessageBox.Width =  newMessageBox.lblMessage.Width + 25;  


            Rectangle Area1 = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            LinearGradientBrush LGB = new LinearGradientBrush(Area1, Color.FromArgb(96, 155, 173), Color.FromArgb(245, 251, 251), LinearGradientMode.Vertical);
            mGraphics.FillRectangle(LGB, Area1);
            mGraphics.DrawRectangle(pen1, Area1);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            newMessageBox.msgTimer.Stop();
            newMessageBox.msgTimer.Dispose();
            Button_id = "1";
            newMessageBox.Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            newMessageBox.msgTimer.Stop();
            newMessageBox.msgTimer.Dispose();
            Button_id = "2";
            newMessageBox.Dispose();
        }

        private void timer_tick(object sender, EventArgs e)
        {
            disposeFormTimer--;

            if (disposeFormTimer >= 0)
            {
                newMessageBox.lblTimer.Text = disposeFormTimer.ToString();
            }
            else
            {
                newMessageBox.msgTimer.Stop();
                newMessageBox.msgTimer.Dispose();
                newMessageBox.Dispose();
            }
        }

        private void lblMessage_SizeChanged(object sender, EventArgs e)
        {
            newMessageBox.Height = newMessageBox.pictureBox1.Height + (newMessageBox.panel1.Height + 50) + (newMessageBox.kryptonPanel1.Height + 50);

            //newMessageBox.Width = newMessageBox.lblMessage.Width + 25;  

        }
    }
}