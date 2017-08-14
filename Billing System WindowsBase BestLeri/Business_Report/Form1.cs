using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace Business_Report
{
    public partial class Form1 : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        BUSSINESS_LAYER.BL bl_obj = new BUSSINESS_LAYER.BL();
        module_Rpt function = new module_Rpt();
        int Tableno;        
       
        public Form1()
        {
            InitializeComponent();
        }
        public Form1(DataSet ds, int tableno)
        {
            InitializeComponent();
            dataSet1 = ds;
            Tableno = tableno;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}