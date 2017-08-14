namespace Business_Report
{
    partial class FRM_RPTSALES
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
            this.kryptonPanel3 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.cmbProductName = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.lblProductName = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmbCustomerName = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.lblCustomerName = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.dtpToDate = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.dtpFromDate = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.btnPreview = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lblFromDate = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btnClose = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lblToDate = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.optCustomerwise = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.optProductwise = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.optDatewise = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
            this.kryptonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).BeginInit();
            this.kryptonPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProductName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCustomerName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel
            // 
            this.kryptonPanel.Controls.Add(this.kryptonPanel2);
            this.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel.Name = "kryptonPanel";
            this.kryptonPanel.Size = new System.Drawing.Size(473, 196);
            this.kryptonPanel.TabIndex = 0;
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.kryptonPanel3);
            this.kryptonPanel2.Controls.Add(this.kryptonPanel1);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(473, 196);
            this.kryptonPanel2.TabIndex = 1;
            // 
            // kryptonPanel3
            // 
            this.kryptonPanel3.Controls.Add(this.cmbProductName);
            this.kryptonPanel3.Controls.Add(this.lblProductName);
            this.kryptonPanel3.Controls.Add(this.cmbCustomerName);
            this.kryptonPanel3.Controls.Add(this.lblCustomerName);
            this.kryptonPanel3.Controls.Add(this.dtpToDate);
            this.kryptonPanel3.Controls.Add(this.dtpFromDate);
            this.kryptonPanel3.Controls.Add(this.btnPreview);
            this.kryptonPanel3.Controls.Add(this.lblFromDate);
            this.kryptonPanel3.Controls.Add(this.btnClose);
            this.kryptonPanel3.Controls.Add(this.lblToDate);
            this.kryptonPanel3.Location = new System.Drawing.Point(4, 44);
            this.kryptonPanel3.Name = "kryptonPanel3";
            this.kryptonPanel3.Size = new System.Drawing.Size(463, 147);
            this.kryptonPanel3.TabIndex = 26;
            // 
            // cmbProductName
            // 
            this.cmbProductName.DropDownWidth = 171;
            this.cmbProductName.Location = new System.Drawing.Point(187, 10);
            this.cmbProductName.Name = "cmbProductName";
            this.cmbProductName.Size = new System.Drawing.Size(174, 21);
            this.cmbProductName.TabIndex = 27;
            // 
            // lblProductName
            // 
            this.lblProductName.Location = new System.Drawing.Point(37, 11);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(89, 20);
            this.lblProductName.TabIndex = 26;
            this.lblProductName.Values.Text = "Product Name";
            // 
            // cmbCustomerName
            // 
            this.cmbCustomerName.DropDownWidth = 171;
            this.cmbCustomerName.Location = new System.Drawing.Point(186, 10);
            this.cmbCustomerName.Name = "cmbCustomerName";
            this.cmbCustomerName.Size = new System.Drawing.Size(174, 21);
            this.cmbCustomerName.TabIndex = 25;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.Location = new System.Drawing.Point(32, 11);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(99, 20);
            this.lblCustomerName.TabIndex = 22;
            this.lblCustomerName.Values.Text = "Customer Name";
            // 
            // dtpToDate
            // 
            this.dtpToDate.Checked = false;
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpToDate.Location = new System.Drawing.Point(187, 67);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(174, 21);
            this.dtpToDate.TabIndex = 13;
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Checked = false;
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFromDate.Location = new System.Drawing.Point(187, 38);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(174, 21);
            this.dtpFromDate.TabIndex = 12;
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(134, 106);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(90, 34);
            this.btnPreview.TabIndex = 14;
            this.btnPreview.Values.Text = "Preview";
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // lblFromDate
            // 
            this.lblFromDate.Location = new System.Drawing.Point(58, 40);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(68, 20);
            this.lblFromDate.TabIndex = 16;
            this.lblFromDate.Values.Text = "From Date";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(239, 106);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 34);
            this.btnClose.TabIndex = 15;
            this.btnClose.Values.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblToDate
            // 
            this.lblToDate.Location = new System.Drawing.Point(73, 68);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(53, 20);
            this.lblToDate.TabIndex = 17;
            this.lblToDate.Values.Text = "To Date";
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.optCustomerwise);
            this.kryptonPanel1.Controls.Add(this.optProductwise);
            this.kryptonPanel1.Controls.Add(this.optDatewise);
            this.kryptonPanel1.Location = new System.Drawing.Point(4, 4);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(463, 37);
            this.kryptonPanel1.TabIndex = 25;
            // 
            // optCustomerwise
            // 
            this.optCustomerwise.Location = new System.Drawing.Point(173, 8);
            this.optCustomerwise.Name = "optCustomerwise";
            this.optCustomerwise.Size = new System.Drawing.Size(99, 20);
            this.optCustomerwise.TabIndex = 23;
            this.optCustomerwise.Values.Text = "Customerwise";
            this.optCustomerwise.CheckedChanged += new System.EventHandler(this.optCustomerwise_CheckedChanged);
            // 
            // optProductwise
            // 
            this.optProductwise.Location = new System.Drawing.Point(334, 8);
            this.optProductwise.Name = "optProductwise";
            this.optProductwise.Size = new System.Drawing.Size(89, 20);
            this.optProductwise.TabIndex = 24;
            this.optProductwise.Values.Text = "Productwise";
            this.optProductwise.CheckedChanged += new System.EventHandler(this.optProductwise_CheckedChanged);
            // 
            // optDatewise
            // 
            this.optDatewise.Location = new System.Drawing.Point(39, 8);
            this.optDatewise.Name = "optDatewise";
            this.optDatewise.Size = new System.Drawing.Size(72, 20);
            this.optDatewise.TabIndex = 22;
            this.optDatewise.Values.Text = "Datewise";
            this.optDatewise.CheckedChanged += new System.EventHandler(this.optDatewise_CheckedChanged);
            // 
            // FRM_RPTSALES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 196);
            this.Controls.Add(this.kryptonPanel);
            this.Name = "FRM_RPTSALES";
            this.Text = "SALES";
            this.Load += new System.EventHandler(this.FRM_RPTSALES_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).EndInit();
            this.kryptonPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).EndInit();
            this.kryptonPanel3.ResumeLayout(false);
            this.kryptonPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProductName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCustomerName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel3;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cmbCustomerName;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblCustomerName;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtpToDate;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtpFromDate;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnPreview;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblFromDate;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnClose;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblToDate;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton optCustomerwise;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton optProductwise;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton optDatewise;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cmbProductName;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblProductName;
    }
}

