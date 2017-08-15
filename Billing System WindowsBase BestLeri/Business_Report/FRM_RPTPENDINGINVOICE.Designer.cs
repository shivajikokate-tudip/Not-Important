namespace Business_Report
{
    partial class FRM_RPTPENDINGINVOICE
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
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.cmbCustomerName = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.txtAmount = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblAmount = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblCustomerName = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.dtpToDate = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.dtpFromDate = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.btnPreview = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lblFromDate = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btnClose = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lblToDate = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.optCustomerwise = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.optAmountwise = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.optDatewise = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
            this.kryptonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCustomerName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel
            // 
            this.kryptonPanel.Controls.Add(this.kryptonPanel2);
            this.kryptonPanel.Controls.Add(this.kryptonPanel1);
            this.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel.Name = "kryptonPanel";
            this.kryptonPanel.Size = new System.Drawing.Size(450, 202);
            this.kryptonPanel.TabIndex = 0;
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.cmbCustomerName);
            this.kryptonPanel2.Controls.Add(this.txtAmount);
            this.kryptonPanel2.Controls.Add(this.lblAmount);
            this.kryptonPanel2.Controls.Add(this.lblCustomerName);
            this.kryptonPanel2.Controls.Add(this.dtpToDate);
            this.kryptonPanel2.Controls.Add(this.dtpFromDate);
            this.kryptonPanel2.Controls.Add(this.btnPreview);
            this.kryptonPanel2.Controls.Add(this.lblFromDate);
            this.kryptonPanel2.Controls.Add(this.btnClose);
            this.kryptonPanel2.Controls.Add(this.lblToDate);
            this.kryptonPanel2.Location = new System.Drawing.Point(4, 44);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(442, 153);
            this.kryptonPanel2.TabIndex = 26;
            // 
            // cmbCustomerName
            // 
            this.cmbCustomerName.DropDownWidth = 171;
            this.cmbCustomerName.Location = new System.Drawing.Point(203, 14);
            this.cmbCustomerName.Name = "cmbCustomerName";
            this.cmbCustomerName.Size = new System.Drawing.Size(174, 21);
            this.cmbCustomerName.TabIndex = 25;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(203, 14);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(174, 20);
            this.txtAmount.TabIndex = 24;
            // 
            // lblAmount
            // 
            this.lblAmount.Location = new System.Drawing.Point(70, 14);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(55, 20);
            this.lblAmount.TabIndex = 23;
            this.lblAmount.Values.Text = "Amount";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.Location = new System.Drawing.Point(28, 14);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(99, 20);
            this.lblCustomerName.TabIndex = 22;
            this.lblCustomerName.Values.Text = "Customer Name";
            // 
            // dtpToDate
            // 
            this.dtpToDate.Checked = false;
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpToDate.Location = new System.Drawing.Point(203, 69);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(174, 21);
            this.dtpToDate.TabIndex = 13;
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Checked = false;
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFromDate.Location = new System.Drawing.Point(203, 40);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(174, 21);
            this.dtpFromDate.TabIndex = 12;
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(122, 107);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(90, 34);
            this.btnPreview.TabIndex = 14;
            this.btnPreview.Values.Text = "Preview";
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // lblFromDate
            // 
            this.lblFromDate.Location = new System.Drawing.Point(57, 42);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(68, 20);
            this.lblFromDate.TabIndex = 16;
            this.lblFromDate.Values.Text = "From Date";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(227, 107);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 34);
            this.btnClose.TabIndex = 15;
            this.btnClose.Values.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblToDate
            // 
            this.lblToDate.Location = new System.Drawing.Point(72, 70);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(53, 20);
            this.lblToDate.TabIndex = 17;
            this.lblToDate.Values.Text = "To Date";
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.optCustomerwise);
            this.kryptonPanel1.Controls.Add(this.optAmountwise);
            this.kryptonPanel1.Controls.Add(this.optDatewise);
            this.kryptonPanel1.Location = new System.Drawing.Point(4, 4);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(442, 37);
            this.kryptonPanel1.TabIndex = 25;
            // 
            // optCustomerwise
            // 
            this.optCustomerwise.Location = new System.Drawing.Point(163, 8);
            this.optCustomerwise.Name = "optCustomerwise";
            this.optCustomerwise.Size = new System.Drawing.Size(99, 20);
            this.optCustomerwise.TabIndex = 23;
            this.optCustomerwise.Values.Text = "Customerwise";
            this.optCustomerwise.CheckedChanged += new System.EventHandler(this.CmbCustomerwise_CheckedChanged);
            // 
            // optAmountwise
            // 
            this.optAmountwise.Location = new System.Drawing.Point(324, 8);
            this.optAmountwise.Name = "optAmountwise";
            this.optAmountwise.Size = new System.Drawing.Size(90, 20);
            this.optAmountwise.TabIndex = 24;
            this.optAmountwise.Values.Text = "Amountwise";
            this.optAmountwise.CheckedChanged += new System.EventHandler(this.cmbAmountwise_CheckedChanged);
            // 
            // optDatewise
            // 
            this.optDatewise.Location = new System.Drawing.Point(29, 8);
            this.optDatewise.Name = "optDatewise";
            this.optDatewise.Size = new System.Drawing.Size(72, 20);
            this.optDatewise.TabIndex = 22;
            this.optDatewise.Values.Text = "Datewise";
            this.optDatewise.CheckedChanged += new System.EventHandler(this.cmbDatewise_CheckedChanged);
            // 
            // FRM_RPTPENDINGINVOICE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 202);
            this.Controls.Add(this.kryptonPanel);
            this.Name = "FRM_RPTPENDINGINVOICE";
            this.Text = "PENDING INVOICE";
            this.Load += new System.EventHandler(this.FRM_RPTPENDINGINVOICE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).EndInit();
            this.kryptonPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCustomerName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblToDate;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnClose;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblFromDate;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnPreview;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtpToDate;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtpFromDate;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton optCustomerwise;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton optAmountwise;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton optDatewise;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cmbCustomerName;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtAmount;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblAmount;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblCustomerName;
    }
}

