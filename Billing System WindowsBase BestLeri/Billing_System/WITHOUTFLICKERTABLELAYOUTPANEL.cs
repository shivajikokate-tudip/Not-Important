using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;

namespace BILLING_SYSTEM
{
    public partial class SagarLayoutPanel : TableLayoutPanel
    {
        public SagarLayoutPanel()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint |
              ControlStyles.OptimizedDoubleBuffer |
              ControlStyles.UserPaint, true);
        }

        public SagarLayoutPanel(IContainer container)
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint |
              ControlStyles.OptimizedDoubleBuffer |
              ControlStyles.UserPaint, true);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // SagarLayoutPanel
            // 
            this.BackColor = System.Drawing.Color.Transparent;
            this.ResumeLayout(false);

        }
    }
}
