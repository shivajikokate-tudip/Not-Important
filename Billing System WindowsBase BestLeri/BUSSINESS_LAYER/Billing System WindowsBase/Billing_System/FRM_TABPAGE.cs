using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace BILLING_SYSTEM
{
    public partial class FRM_TABPAGE : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        public FRM_TABPAGE()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text.ToString() + textBox2.Text.ToString();
            MessageBox.Show(name, "This Is Kamlesh Page  Thank You !!!!!!!!!!!");
        }
   
        private void tabPage2_Click(object sender, EventArgs e)
        {
            string name = textBox3.Text.ToString() + textBox4.Text.ToString();
            MessageBox.Show(name, "This Is Sagar Page Thank You !!!!!!!!!!!");
        }
         
    }
}