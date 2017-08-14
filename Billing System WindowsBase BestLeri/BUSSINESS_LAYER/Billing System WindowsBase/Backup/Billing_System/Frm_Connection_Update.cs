using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using System.Data.SqlClient;
using BUSSINESS_LAYER;

namespace BILLING_SYSTEM
{
    public partial class Frm_Connection_Update : ComponentFactory.Krypton.Toolkit.KryptonForm
    {

        Tapal_Settings setting = new Tapal_Settings();
        BUSSINESS_LAYER.BL bl_obj = new BUSSINESS_LAYER.BL();
        MODULE function = new MODULE();
        public Frm_Connection_Update()
        {
            InitializeComponent();
        }

        private void Frm_Connection_Update_Load(object sender, EventArgs e)
        {
            function.settheme(this);
            SqlConnection connection = new SqlConnection(setting.ConnectionString_Web.ToString());
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Tbl_Officemaster", connection);
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            function.fillcombo(cmboffice, ds.Tables[0]);

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(setting.ConnectionString_Web.ToString());
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Tapal_Connection_String where officeid=" + cmboffice.SelectedValue.ToString(), connection);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            setting.Properties["ConnectionStringUpdate"].DefaultValue = true;
            setting.Properties["ConnectionString"].DefaultValue = ds.Tables[0].Rows[0][2].ToString();
            //Properties.Settings.Default.Save();
            setting.Save();
            setting.Reload();

            string new_connectionstring = setting.ConnectionString_Web.ToString(); 
            bool okyn = new BL().checkConnection(new_connectionstring);
            setting.ConnectionStringUpdate = true;
            setting.Save();
            setting.Reload();


            Application.Restart();
        }

        private void Frm_Connection_Update_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}