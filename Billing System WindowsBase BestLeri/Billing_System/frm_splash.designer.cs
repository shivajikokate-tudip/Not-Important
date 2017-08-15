namespace BILLING_SYSTEM
{
    partial class frm_splash
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.kryptonPanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonCheckButton3 = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.kryptonCheckButton2 = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.frm_name = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.kryptonManager1 = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
            this.kryptonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel
            // 
            this.kryptonPanel.Controls.Add(this.kryptonCheckButton3);
            this.kryptonPanel.Controls.Add(this.kryptonCheckButton2);
            this.kryptonPanel.Controls.Add(this.kryptonLabel2);
            this.kryptonPanel.Controls.Add(this.frm_name);
            this.kryptonPanel.Controls.Add(this.progressBar1);
            this.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel.Name = "kryptonPanel";
            this.kryptonPanel.Padding = new System.Windows.Forms.Padding(10);
            this.kryptonPanel.Size = new System.Drawing.Size(466, 295);
            this.kryptonPanel.TabIndex = 0;
            // 
            // kryptonCheckButton3
            // 
            this.kryptonCheckButton3.Location = new System.Drawing.Point(31, 26);
            this.kryptonCheckButton3.Name = "kryptonCheckButton3";
            this.kryptonCheckButton3.Size = new System.Drawing.Size(410, 73);
            this.kryptonCheckButton3.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonCheckButton3.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonCheckButton3.TabIndex = 8;
            this.kryptonCheckButton3.Values.Text = "BILLING";
            // 
            // kryptonCheckButton2
            // 
            this.kryptonCheckButton2.Location = new System.Drawing.Point(31, 105);
            this.kryptonCheckButton2.Name = "kryptonCheckButton2";
            this.kryptonCheckButton2.Size = new System.Drawing.Size(410, 63);
            this.kryptonCheckButton2.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonCheckButton2.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonCheckButton2.TabIndex = 7;
            this.kryptonCheckButton2.Values.Text = "SYSTEM";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.AutoSize = false;
            this.kryptonLabel2.Location = new System.Drawing.Point(13, 250);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(428, 32);
            this.kryptonLabel2.StateCommon.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonLabel2.StateCommon.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonLabel2.TabIndex = 3;
            this.kryptonLabel2.Values.Text = "SK Soft, AHMEDNAGAR";
            // 
            // frm_name
            // 
            this.frm_name.Location = new System.Drawing.Point(13, 187);
            this.frm_name.Name = "frm_name";
            this.frm_name.Size = new System.Drawing.Size(70, 20);
            this.frm_name.TabIndex = 1;
            this.frm_name.Values.Text = "Loading......";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(21, 223);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(414, 15);
            this.progressBar1.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // kryptonManager1
            // 
            this.kryptonManager1.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.SparkleBlue;
            // 
            // frm_splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 295);
            this.Controls.Add(this.kryptonPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_splash";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_splash";
            this.Load += new System.EventHandler(this.frm_splash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).EndInit();
            this.kryptonPanel.ResumeLayout(false);
            this.kryptonPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel frm_name;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckButton kryptonCheckButton3;
        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager1;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckButton kryptonCheckButton2;
    }
}

