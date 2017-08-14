namespace Business_Report
{
    partial class FRM_RPTDEBTICREDITTRANSACTION
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
            this.dtpToDate = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.dtpFromDate = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.btnPreview = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lblFromDate = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btnClose = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lblToDate = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
            this.kryptonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel
            // 
            this.kryptonPanel.Controls.Add(this.dtpToDate);
            this.kryptonPanel.Controls.Add(this.lblFromDate);
            this.kryptonPanel.Controls.Add(this.dtpFromDate);
            this.kryptonPanel.Controls.Add(this.lblToDate);
            this.kryptonPanel.Controls.Add(this.btnPreview);
            this.kryptonPanel.Controls.Add(this.btnClose);
            this.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel.Name = "kryptonPanel";
            this.kryptonPanel.Size = new System.Drawing.Size(352, 139);
            this.kryptonPanel.TabIndex = 0;
            // 
            // dtpToDate
            // 
            this.dtpToDate.Checked = false;
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpToDate.Location = new System.Drawing.Point(142, 45);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(174, 21);
            this.dtpToDate.TabIndex = 25;
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Checked = false;
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFromDate.Location = new System.Drawing.Point(142, 16);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(174, 21);
            this.dtpFromDate.TabIndex = 24;
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(77, 83);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(90, 34);
            this.btnPreview.TabIndex = 26;
            this.btnPreview.Values.Text = "Preview";
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // lblFromDate
            // 
            this.lblFromDate.Location = new System.Drawing.Point(36, 18);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(68, 20);
            this.lblFromDate.TabIndex = 28;
            this.lblFromDate.Values.Text = "From Date";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(182, 83);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 34);
            this.btnClose.TabIndex = 27;
            this.btnClose.Values.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblToDate
            // 
            this.lblToDate.Location = new System.Drawing.Point(51, 46);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(53, 20);
            this.lblToDate.TabIndex = 29;
            this.lblToDate.Values.Text = "To Date";
            // 
            // FRM_RPTDEBTICREDITTRANSACTION
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 139);
            this.Controls.Add(this.kryptonPanel);
            this.Name = "FRM_RPTDEBTICREDITTRANSACTION";
            this.Text = "FRM_RPTDEBTICREDITTRANSACTION";
            this.Load += new System.EventHandler(this.FRM_RPTDEBTICREDITTRANSACTION_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).EndInit();
            this.kryptonPanel.ResumeLayout(false);
            this.kryptonPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtpToDate;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblFromDate;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtpFromDate;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblToDate;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnPreview;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnClose;
    }
}

