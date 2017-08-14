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
    public partial class FRM_BLOWING_MAKING1 : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        public FRM_BLOWING_MAKING1()
        {
            InitializeComponent();
        }

        private void kryptonPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            kryptonPanel7.Visible = true;
            lbl1.Text = "Blowing";
            lbl2.Text = "Enter Blowing";
            lbl3.Text = "Filling Water";
            lbl4.Text = "Enter Filling Water";
            lbl5.Text = "Cap";
            lbl6.Text = "Enter Cap";
        }

        private void optBlowing_CheckedChanged(object sender, EventArgs e)
        {
            kryptonPanel2.Visible = true;
            kryptonPanel7.Visible = false;
            lbl3.Text = "Preform";
            lbl4.Text = "Enter Preform";
            lbl5.Text = "Blowing";
            lbl6.Text = "Enter Blowing";
        }

        private void kryptonPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FRM_BLOWING_MAKING1_Load(object sender, EventArgs e)
        {
            kryptonPanel2.Visible = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;   // Do not resize the form.
        }

        private void optLabel_CheckedChanged(object sender, EventArgs e)
        {
            kryptonPanel2.Visible = true;
            kryptonPanel7.Visible = false;
            lbl3.Text = "Cap";
            lbl4.Text = "Enter Cap";
            lbl5.Text = "Label";
            lbl6.Text = "Enter Label";
        }

        private void optBox_CheckedChanged(object sender, EventArgs e)
        {
            kryptonPanel2.Visible = true;
            kryptonPanel7.Visible = false;
            lbl3.Text = "Label";
            lbl4.Text = "Enter Label";
            lbl5.Text = "Box";
            lbl6.Text = "Enter Box";
        }
    }
}