namespace BILLING_SYSTEM
{
    partial class FRM_SALESRECOVERYCHECK
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
            this.btnExit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.dtpDate = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.kryptonPanel5 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.optSales = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.optPurchase = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.lblInvoiceNo = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmdName = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.txtInvoiceNo = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtAmount = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblVatNo = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblMobileNo = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblSupplierName = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonManager1 = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.btnPrint = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonManager2 = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.kryptonManager3 = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.kryptonPanel3 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.lvw = new AC.ExtendedRenderer.Toolkit.KryptonListView();
            this.btnSubmit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonPanel7 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonPanel6 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonPanel4 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.txtSalesRecoveryId = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonPanel8 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonManager4 = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel5)).BeginInit();
            this.kryptonPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmdName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).BeginInit();
            this.kryptonPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel7)).BeginInit();
            this.kryptonPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel6)).BeginInit();
            this.kryptonPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel4)).BeginInit();
            this.kryptonPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel8)).BeginInit();
            this.kryptonPanel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel
            // 
            this.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel.Name = "kryptonPanel";
            this.kryptonPanel.Size = new System.Drawing.Size(729, 232);
            this.kryptonPanel.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(255, 11);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 27);
            this.btnExit.TabIndex = 7;
            this.btnExit.Values.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(183, 111);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(166, 21);
            this.dtpDate.TabIndex = 3;
            this.dtpDate.ValueNullable = new System.DateTime(((long)(0)));
            // 
            // kryptonPanel5
            // 
            this.kryptonPanel5.Controls.Add(this.optSales);
            this.kryptonPanel5.Controls.Add(this.optPurchase);
            this.kryptonPanel5.Controls.Add(this.lblInvoiceNo);
            this.kryptonPanel5.Controls.Add(this.dtpDate);
            this.kryptonPanel5.Controls.Add(this.cmdName);
            this.kryptonPanel5.Controls.Add(this.txtInvoiceNo);
            this.kryptonPanel5.Controls.Add(this.txtAmount);
            this.kryptonPanel5.Controls.Add(this.lblVatNo);
            this.kryptonPanel5.Controls.Add(this.lblMobileNo);
            this.kryptonPanel5.Controls.Add(this.lblSupplierName);
            this.kryptonPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel5.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel5.Name = "kryptonPanel5";
            this.kryptonPanel5.Size = new System.Drawing.Size(380, 232);
            this.kryptonPanel5.TabIndex = 1;
            // 
            // optSales
            // 
            this.optSales.Location = new System.Drawing.Point(105, 13);
            this.optSales.Name = "optSales";
            this.optSales.Size = new System.Drawing.Size(56, 20);
            this.optSales.TabIndex = 19;
            this.optSales.Values.Text = "SALES";
            this.optSales.CheckedChanged += new System.EventHandler(this.optSales_CheckedChanged);
            // 
            // optPurchase
            // 
            this.optPurchase.Location = new System.Drawing.Point(200, 12);
            this.optPurchase.Name = "optPurchase";
            this.optPurchase.Size = new System.Drawing.Size(83, 20);
            this.optPurchase.TabIndex = 18;
            this.optPurchase.Values.Text = "PURCHASE";
            this.optPurchase.CheckedChanged += new System.EventHandler(this.optPurchase_CheckedChanged);
            // 
            // lblInvoiceNo
            // 
            this.lblInvoiceNo.Location = new System.Drawing.Point(71, 85);
            this.lblInvoiceNo.Name = "lblInvoiceNo";
            this.lblInvoiceNo.Size = new System.Drawing.Size(69, 20);
            this.lblInvoiceNo.TabIndex = 17;
            this.lblInvoiceNo.Values.Text = "Invoice No";
            // 
            // cmdName
            // 
            this.cmdName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmdName.DropDownWidth = 168;
            this.cmdName.Location = new System.Drawing.Point(183, 56);
            this.cmdName.Name = "cmdName";
            this.cmdName.Size = new System.Drawing.Size(166, 21);
            this.cmdName.TabIndex = 1;
            // 
            // txtInvoiceNo
            // 
            this.txtInvoiceNo.Location = new System.Drawing.Point(183, 85);
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.Size = new System.Drawing.Size(166, 20);
            this.txtInvoiceNo.TabIndex = 2;
            this.txtInvoiceNo.TextChanged += new System.EventHandler(this.txtInvoiceNo_TextChanged);
            this.txtInvoiceNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInvoiceNo_KeyPress);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(183, 138);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(166, 20);
            this.txtAmount.TabIndex = 4;
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            // 
            // lblVatNo
            // 
            this.lblVatNo.Location = new System.Drawing.Point(85, 138);
            this.lblVatNo.Name = "lblVatNo";
            this.lblVatNo.Size = new System.Drawing.Size(55, 20);
            this.lblVatNo.TabIndex = 7;
            this.lblVatNo.Values.Text = "Amount";
            // 
            // lblMobileNo
            // 
            this.lblMobileNo.Location = new System.Drawing.Point(38, 112);
            this.lblMobileNo.Name = "lblMobileNo";
            this.lblMobileNo.Size = new System.Drawing.Size(102, 20);
            this.lblMobileNo.TabIndex = 1;
            this.lblMobileNo.Values.Text = "Transaction Date";
            // 
            // lblSupplierName
            // 
            this.lblSupplierName.Location = new System.Drawing.Point(12, 57);
            this.lblSupplierName.Name = "lblSupplierName";
            this.lblSupplierName.Size = new System.Drawing.Size(128, 20);
            this.lblSupplierName.TabIndex = 0;
            this.lblSupplierName.Values.Text = "Customer/Firm Name";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(169, 11);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(80, 27);
            this.btnPrint.TabIndex = 6;
            this.btnPrint.Values.Text = "Clear";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // kryptonPanel3
            // 
            this.kryptonPanel3.Controls.Add(this.lvw);
            this.kryptonPanel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.kryptonPanel3.Location = new System.Drawing.Point(380, 0);
            this.kryptonPanel3.Name = "kryptonPanel3";
            this.kryptonPanel3.Size = new System.Drawing.Size(349, 232);
            this.kryptonPanel3.TabIndex = 12;
            // 
            // lvw
            // 
            this.lvw.AutoSizeLastColumn = true;
            this.lvw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvw.EnableHeaderGlow = false;
            this.lvw.EnableHeaderHotTrack = false;
            this.lvw.EnableHeaderRendering = false;
            this.lvw.EnableSorting = true;
            this.lvw.EnableVistaCheckBoxes = true;
            this.lvw.ForceLeftAlign = false;
            this.lvw.FullRowSelect = true;
            this.lvw.GradientEndColor = System.Drawing.Color.Gray;
            this.lvw.GradientMiddleColor = System.Drawing.Color.LightGray;
            this.lvw.GradientStartColor = System.Drawing.Color.White;
            this.lvw.IndendFirstItem = true;
            this.lvw.Location = new System.Drawing.Point(0, 0);
            this.lvw.Name = "lvw";
            this.lvw.OwnerDraw = true;
            this.lvw.PersistentColors = false;
            this.lvw.SelectEntireRowOnSubItem = true;
            this.lvw.Size = new System.Drawing.Size(349, 232);
            this.lvw.TabIndex = 7;
            this.lvw.UseCompatibleStateImageBehavior = false;
            this.lvw.UseStyledColors = false;
            this.lvw.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lvw_MouseUp);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(83, 11);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(80, 27);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Values.Text = "Check";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // kryptonPanel7
            // 
            this.kryptonPanel7.Controls.Add(this.kryptonPanel6);
            this.kryptonPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel7.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel7.Name = "kryptonPanel7";
            this.kryptonPanel7.Size = new System.Drawing.Size(729, 232);
            this.kryptonPanel7.TabIndex = 1;
            // 
            // kryptonPanel6
            // 
            this.kryptonPanel6.Controls.Add(this.kryptonPanel2);
            this.kryptonPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel6.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel6.Name = "kryptonPanel6";
            this.kryptonPanel6.Size = new System.Drawing.Size(729, 232);
            this.kryptonPanel6.TabIndex = 1;
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.kryptonPanel4);
            this.kryptonPanel2.Controls.Add(this.kryptonPanel5);
            this.kryptonPanel2.Controls.Add(this.kryptonPanel3);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(729, 232);
            this.kryptonPanel2.TabIndex = 1;
            // 
            // kryptonPanel4
            // 
            this.kryptonPanel4.Controls.Add(this.txtSalesRecoveryId);
            this.kryptonPanel4.Controls.Add(this.btnSubmit);
            this.kryptonPanel4.Controls.Add(this.btnPrint);
            this.kryptonPanel4.Controls.Add(this.btnExit);
            this.kryptonPanel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel4.Location = new System.Drawing.Point(0, 182);
            this.kryptonPanel4.Name = "kryptonPanel4";
            this.kryptonPanel4.Size = new System.Drawing.Size(380, 50);
            this.kryptonPanel4.TabIndex = 13;
            // 
            // txtSalesRecoveryId
            // 
            this.txtSalesRecoveryId.Enabled = false;
            this.txtSalesRecoveryId.Location = new System.Drawing.Point(12, 10);
            this.txtSalesRecoveryId.Name = "txtSalesRecoveryId";
            this.txtSalesRecoveryId.Size = new System.Drawing.Size(52, 20);
            this.txtSalesRecoveryId.TabIndex = 15;
            this.txtSalesRecoveryId.Visible = false;
            // 
            // kryptonPanel8
            // 
            this.kryptonPanel8.Controls.Add(this.kryptonPanel7);
            this.kryptonPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel8.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel8.Name = "kryptonPanel8";
            this.kryptonPanel8.Size = new System.Drawing.Size(729, 232);
            this.kryptonPanel8.TabIndex = 1;
            // 
            // FRM_SALESRECOVERYCHECK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 232);
            this.Controls.Add(this.kryptonPanel8);
            this.Controls.Add(this.kryptonPanel);
            this.Name = "FRM_SALESRECOVERYCHECK";
            this.Text = "RECOVERY CHECK";
            this.Load += new System.EventHandler(this.FRM_SALESRECOVERYCHECK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel5)).EndInit();
            this.kryptonPanel5.ResumeLayout(false);
            this.kryptonPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmdName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).EndInit();
            this.kryptonPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel7)).EndInit();
            this.kryptonPanel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel6)).EndInit();
            this.kryptonPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel4)).EndInit();
            this.kryptonPanel4.ResumeLayout(false);
            this.kryptonPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel8)).EndInit();
            this.kryptonPanel8.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnExit;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtpDate;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel5;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cmdName;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtInvoiceNo;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtAmount;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblVatNo;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblMobileNo;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblSupplierName;
        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnPrint;
        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager2;
        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager3;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel3;
        private AC.ExtendedRenderer.Toolkit.KryptonListView lvw;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSubmit;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel7;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel6;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel4;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtSalesRecoveryId;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel8;
        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager4;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblInvoiceNo;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton optSales;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton optPurchase;
    }
}

