using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using BUSSINESS_LAYER;

namespace BILLING_SYSTEM
{
    public partial class FRM_BILLINGINVOICE : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        MODULE function = new MODULE();
        BL_BILLINGINVOICE bl_obj = new BL_BILLINGINVOICE();
        DataSet ds = null;
        DataSet temp = new DataSet();//ds = (bl_obj.SELECT(bl_obj));


        public FRM_BILLINGINVOICE()
        {
            InitializeComponent(); 
           
        }

        private void FRM_BILLINGINVOICE_Load(object sender, EventArgs e)
        {
            function.settheme(this); datalist();
        }
        public DataSet datalist()
        {
            temp = ds = (bl_obj.SELECT(bl_obj));
            function.fillcombo(cmdfirmname, ds.Tables[0]);
            function.fillcombo(cmbSubItem, ds.Tables[2]);
            function.fillcombo(cmbSelectItem, ds.Tables[3]);
            function.fillcombo(cmbTransport, ds.Tables[5]);
            return ds;
        }
        private void cmdfirmname_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = cmdfirmname.SelectedIndex;
            //txtName.Text = ds.Tables[0].Rows[0][2].ToString();

            txtName.Text = ds.Tables[0].Rows[0][2].ToString();
            txtAddress.Text = ds.Tables[0].Rows[0][3].ToString();
        }
    }
}