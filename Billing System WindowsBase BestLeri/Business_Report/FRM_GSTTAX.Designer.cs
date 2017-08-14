namespace Business_Report
{
    partial class FRM_GSTTAX
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
            this.kryptonManager = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.kryptonPanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btnClose = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnPreview = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.dtpToDate = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.lblFromDate = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.dtpFromDate = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.lblToDate = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.optGstr2 = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.optGstr3 = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.optGstr1 = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.kryptonPanel3 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
            this.kryptonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel
            // 
            this.kryptonPanel.Controls.Add(this.kryptonPanel1);
            this.kryptonPanel.Controls.Add(this.btnClose);
            this.kryptonPanel.Controls.Add(this.btnPreview);
            this.kryptonPanel.Controls.Add(this.dtpToDate);
            this.kryptonPanel.Controls.Add(this.lblFromDate);
            this.kryptonPanel.Controls.Add(this.dtpFromDate);
            this.kryptonPanel.Controls.Add(this.lblToDate);
            this.kryptonPanel.Controls.Add(this.kryptonPanel3);
            this.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel.Name = "kryptonPanel";
            this.kryptonPanel.Size = new System.Drawing.Size(341, 194);
            this.kryptonPanel.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(183, 148);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 27);
            this.btnClose.TabIndex = 33;
            this.btnClose.Values.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(68, 148);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(90, 27);
            this.btnPreview.TabIndex = 32;
            this.btnPreview.Values.Text = "Preview";
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // dtpToDate
            // 
            this.dtpToDate.Checked = false;
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpToDate.Location = new System.Drawing.Point(139, 102);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(162, 21);
            this.dtpToDate.TabIndex = 31;
            // 
            // lblFromDate
            // 
            this.lblFromDate.Location = new System.Drawing.Point(29, 65);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(68, 20);
            this.lblFromDate.TabIndex = 34;
            this.lblFromDate.Values.Text = "From Date";
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Checked = false;
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFromDate.Location = new System.Drawing.Point(139, 65);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(162, 21);
            this.dtpFromDate.TabIndex = 30;
            // 
            // lblToDate
            // 
            this.lblToDate.Location = new System.Drawing.Point(44, 101);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(53, 20);
            this.lblToDate.TabIndex = 35;
            this.lblToDate.Values.Text = "To Date";
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.optGstr2);
            this.kryptonPanel1.Controls.Add(this.optGstr3);
            this.kryptonPanel1.Controls.Add(this.optGstr1);
            this.kryptonPanel1.Location = new System.Drawing.Point(12, 12);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(310, 37);
            this.kryptonPanel1.TabIndex = 26;
            // 
            // optGstr2
            // 
            this.optGstr2.Location = new System.Drawing.Point(129, 8);
            this.optGstr2.Name = "optGstr2";
            this.optGstr2.Size = new System.Drawing.Size(58, 20);
            this.optGstr2.TabIndex = 23;
            this.optGstr2.Values.Text = "GSTR2";
            // 
            // optGstr3
            // 
            this.optGstr3.Location = new System.Drawing.Point(216, 8);
            this.optGstr3.Name = "optGstr3";
            this.optGstr3.Size = new System.Drawing.Size(58, 20);
            this.optGstr3.TabIndex = 24;
            this.optGstr3.Values.Text = "GSTR3";
            // 
            // optGstr1
            // 
            this.optGstr1.Location = new System.Drawing.Point(39, 8);
            this.optGstr1.Name = "optGstr1";
            this.optGstr1.Size = new System.Drawing.Size(58, 20);
            this.optGstr1.TabIndex = 22;
            this.optGstr1.Values.Text = "GSTR1";
            // 
            // kryptonPanel3
            // 
            this.kryptonPanel3.Location = new System.Drawing.Point(12, 55);
            this.kryptonPanel3.Name = "kryptonPanel3";
            this.kryptonPanel3.Size = new System.Drawing.Size(310, 127);
            this.kryptonPanel3.TabIndex = 27;
            // 
            // FRM_GSTTAX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 194);
            this.Controls.Add(this.kryptonPanel);
            this.Name = "FRM_GSTTAX";
            this.Text = "FRM_GSTTAX";
            this.Load += new System.EventHandler(this.FRM_GSTTAX_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).EndInit();
            this.kryptonPanel.ResumeLayout(false);
            this.kryptonPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnClose;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnPreview;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtpToDate;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblFromDate;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtpFromDate;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblToDate;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton optGstr2;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton optGstr3;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton optGstr1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel3;
    }
}

