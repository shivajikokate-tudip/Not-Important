namespace BILLING_SYSTEM
{
    partial class add_form_panel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(146, 186);
            this.kryptonPanel1.TabIndex = 0;
            this.kryptonPanel1.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.kryptonPanel1_ControlRemoved);
            this.kryptonPanel1.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.kryptonPanel1_ControlAdded);
            this.kryptonPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.kryptonPanel1_Paint);
            // 
            // add_form_panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "add_form_panel";
            this.Size = new System.Drawing.Size(146, 186);
            this.Load += new System.EventHandler(this.add_form_panel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
    }
}
