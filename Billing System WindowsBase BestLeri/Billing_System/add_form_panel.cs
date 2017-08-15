using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace BILLING_SYSTEM
{
    public partial class add_form_panel : UserControl
    {
        bool dockStyleYN;
        public add_form_panel()
        {
            InitializeComponent();
        }
        public add_form_panel(bool dockYN)
        {
            InitializeComponent();
            if (dockYN == false)
                dockStyleYN = true;
        }

        private void kryptonPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonPanel1_ControlRemoved(object sender, ControlEventArgs e)
        {
            
            this.Dock = DockStyle.None;
            this.Parent.Dock = DockStyle.None;
            this.Dispose();
        }

        private void kryptonPanel1_ControlAdded(object sender, ControlEventArgs e)
        {
            new MODULE().settheme(this);
            this.Top = 0;
            this.Left = 0;
            if (dockStyleYN == false)
            {
                this.Parent.Dock = DockStyle.Fill;
                this.Dock = DockStyle.Fill;
            }
            if (dockStyleYN == true )
            {
                this.AutoSize = true;
                this.AutoSizeMode = AutoSizeMode.GrowOnly;
                this.kryptonPanel1.AutoSize = true;
                this.kryptonPanel1.AutoSizeMode = AutoSizeMode.GrowOnly;
                this.kryptonPanel1.AutoScroll = true;
                Int64 midx;
                Int64 midy;
                midx = this.Parent.Width / 2;
                midy = this.Parent.Height / 2;
                this.Location = new Point(Int32.Parse("" + midx) - (this.Width / 2), Int32.Parse("" + midy) - (this.Height  / 2));
            }
            
            this.BringToFront();
            e.Control.Location = new Point((this.Parent.Width - e.Control.Width) / 2, (this.Parent.Height - e.Control.Height) / 2);
            e.Control.BringToFront();
            e.Control.Show();

        }

        private void add_form_panel_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            
        }
    }
}
