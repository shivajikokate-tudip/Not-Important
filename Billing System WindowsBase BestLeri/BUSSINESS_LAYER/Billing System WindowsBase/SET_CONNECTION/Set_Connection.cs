using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using System.Xml;

namespace SET_CONNECTION
{
    public partial class Set_Connection : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        public Set_Connection()
        {
            InitializeComponent();
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            string str = txt_con_new.Text;
            openFileDialog1.ShowDialog();
            //txt_con_new.Text = openFileDialog1.FileName.Substring(openFileDialog1.FileName.LastIndexOf('\\')).ToString();

            //txt_con_new.Text = str.Replace((str.Substring(str.LastIndexOf("=")+1).ToString()), openFileDialog1.FileName.Substring(openFileDialog1.FileName.LastIndexOf(@"\")).Trim('\\').ToString());
            txt_con_new.Text = str.Replace((str.Substring(str.LastIndexOf("=") + 1).ToString()), openFileDialog1.FileName);
        }

        public void ReadConfigFile()
        {
            //updating config file
            XmlDocument XmlDoc = new XmlDocument();
            //Loading the Config file
            XmlDoc.Load("BILLING_SYSTEM.exe.Config");
            foreach (XmlElement xElement in XmlDoc.DocumentElement)
            {
                if (xElement.Name == "connectionStrings")
                {
                    //setting the coonection string
                    foreach (XmlNode x in xElement.ChildNodes)
                    {
                        if (x.Attributes["name"].Value == "BILLING_SYSTEM.Tapal_Settings.ConnectionString_Web")
                        {
                            txt_con_local.Text = x.Attributes["connectionString"].Value.ToString();
                            txt_con_new.Text = x.Attributes["connectionString"].Value.ToString();
                        }
                    }
                }
            }
            //writing the connection string in config file
            //XmlDoc.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
        }

        public void UpdateConfigFile(string Con)
        {
            //updating config file
            XmlDocument XmlDoc = new XmlDocument();
            //Loading the Config file
            XmlDoc.Load("BILLING_SYSTEM.exe.Config");
            foreach (XmlElement xElement in XmlDoc.DocumentElement)
            {
                if (xElement.Name == "connectionStrings")
                {
                    //setting the coonection string
                    foreach (XmlNode x in xElement.ChildNodes)
                    {
                        if (x.Attributes["name"].Value == "BILLING_SYSTEM.Tapal_Settings.ConnectionString_Web")
                        {
                            x.Attributes["connectionString"].Value = Con;
                        }
                    }
                }
            }
            //writing the connection string in config file
            XmlDoc.Save("BILLING_SYSTEM.exe.Config");
        }

        private void Set_Connection_Load(object sender, EventArgs e)
        {
            ReadConfigFile();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            UpdateConfigFile(txt_con_new.Text);
            ReadConfigFile();
        }

    }
}