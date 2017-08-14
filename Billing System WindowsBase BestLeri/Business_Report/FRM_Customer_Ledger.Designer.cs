namespace Business_Report
{
    partial class FRM_Customer_Ledger
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
            this.cmbCustomerName = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.lblCustomerName = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btnPreview = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnClose = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.dtpToDate = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.dtpFromDate = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.lblFromDate = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.lblToDate = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCustomerName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel
            // 
            this.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel.Name = "kryptonPanel";
            this.kryptonPanel.Size = new System.Drawing.Size(365, 161);
            this.kryptonPanel.TabIndex = 0;
            // 
            // cmbCustomerName
            // 
            this.cmbCustomerName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCustomerName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCustomerName.DropDownWidth = 171;
            this.cmbCustomerName.Location = new System.Drawing.Point(160, 17);
            this.cmbCustomerName.Name = "cmbCustomerName";
            this.cmbCustomerName.Size = new System.Drawing.Size(174, 21);
            this.cmbCustomerName.TabIndex = 27;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.Location = new System.Drawing.Point(18, 19);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(99, 20);
            this.lblCustomerName.TabIndex = 26;
            this.lblCustomerName.Values.Text = "Customer Name";
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(79, 115);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(90, 34);
            this.btnPreview.TabIndex = 22;
            this.btnPreview.Values.Text = "Preview";
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(184, 115);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 34);
            this.btnClose.TabIndex = 23;
            this.btnClose.Values.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dtpToDate
            // 
            this.dtpToDate.Checked = false;
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpToDate.Location = new System.Drawing.Point(160, 75);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(174, 21);
            this.dtpToDate.TabIndex = 19;
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Checked = false;
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFromDate.Location = new System.Drawing.Point(160, 46);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(174, 21);
            this.dtpFromDate.TabIndex = 18;
            // 
            // lblFromDate
            // 
            this.lblFromDate.Location = new System.Drawing.Point(49, 47);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(68, 20);
            this.lblFromDate.TabIndex = 20;
            this.lblFromDate.Values.Text = "From Date";
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.cmbCustomerName);
            this.kryptonPanel1.Controls.Add(this.lblCustomerName);
            this.kryptonPanel1.Controls.Add(this.btnPreview);
            this.kryptonPanel1.Controls.Add(this.btnClose);
            this.kryptonPanel1.Controls.Add(this.dtpToDate);
            this.kryptonPanel1.Controls.Add(this.dtpFromDate);
            this.kryptonPanel1.Controls.Add(this.lblFromDate);
            this.kryptonPanel1.Controls.Add(this.lblToDate);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(365, 161);
            this.kryptonPanel1.TabIndex = 1;
            // 
            // lblToDate
            // 
            this.lblToDate.Location = new System.Drawing.Point(64, 75);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(53, 20);
            this.lblToDate.TabIndex = 21;
            this.lblToDate.Values.Text = "To Date";
            // 
            // FRM_Customer_Ledger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 161);
            this.Controls.Add(this.kryptonPanel1);
            this.Controls.Add(this.kryptonPanel);
            this.Name = "FRM_Customer_Ledger";
            this.Text = "FRM_Customer_Ledger";
            this.Load += new System.EventHandler(this.FRM_Customer_Ledger_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCustomerName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cmbCustomerName;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblCustomerName;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnPreview;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnClose;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtpToDate;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtpFromDate;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblFromDate;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblToDate;
    }
}

