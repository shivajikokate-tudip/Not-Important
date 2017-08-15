namespace BILLING_SYSTEM
{
    partial class FRM_EXPENCESTRANSACTION
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
            this.kryptonPanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.txtTokanNo = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.txtT_ID = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblSubAccountCr = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmbSubAccountCr = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.lblInvoiceNo = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtInvoiceNo = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblTokenNo = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblFirmName = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblDiscription = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblSubAccountDr = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtAmount = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.cmdTransactionMode = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.btnDelete = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.cmbSubAccountDr = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.btnAdd = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txtDiscription = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblAmount = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblDate = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.dtpDate = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.kryptonPanel4 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btnClear = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnExit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnSubmit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonPanel5 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Credit_Account = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Credit_Acc_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tran_Mode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tran_Expences_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.rbDelete = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.rbUpdate = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.rbNew = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
            this.kryptonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSubAccountCr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdTransactionMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSubAccountDr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel4)).BeginInit();
            this.kryptonPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel5)).BeginInit();
            this.kryptonPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel
            // 
            this.kryptonPanel.Controls.Add(this.kryptonPanel1);
            this.kryptonPanel.Controls.Add(this.kryptonPanel2);
            this.kryptonPanel.Controls.Add(this.kryptonPanel5);
            this.kryptonPanel.Controls.Add(this.kryptonPanel4);
            this.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel.Name = "kryptonPanel";
            this.kryptonPanel.Size = new System.Drawing.Size(748, 473);
            this.kryptonPanel.TabIndex = 0;
            // 
            // txtTokanNo
            // 
            this.txtTokanNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTokanNo.Enabled = false;
            this.txtTokanNo.Location = new System.Drawing.Point(532, 21);
            this.txtTokanNo.Name = "txtTokanNo";
            this.txtTokanNo.Size = new System.Drawing.Size(162, 20);
            this.txtTokanNo.TabIndex = 38;
            this.txtTokanNo.TextChanged += new System.EventHandler(this.txtTokanNo_TextChanged);
            this.txtTokanNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTokanNo_KeyPress);
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.txtT_ID);
            this.kryptonPanel2.Controls.Add(this.lblSubAccountCr);
            this.kryptonPanel2.Controls.Add(this.cmbSubAccountCr);
            this.kryptonPanel2.Controls.Add(this.lblInvoiceNo);
            this.kryptonPanel2.Controls.Add(this.txtInvoiceNo);
            this.kryptonPanel2.Controls.Add(this.lblTokenNo);
            this.kryptonPanel2.Controls.Add(this.lblFirmName);
            this.kryptonPanel2.Controls.Add(this.lblDiscription);
            this.kryptonPanel2.Controls.Add(this.lblSubAccountDr);
            this.kryptonPanel2.Controls.Add(this.txtTokanNo);
            this.kryptonPanel2.Controls.Add(this.txtAmount);
            this.kryptonPanel2.Controls.Add(this.cmdTransactionMode);
            this.kryptonPanel2.Controls.Add(this.btnDelete);
            this.kryptonPanel2.Controls.Add(this.cmbSubAccountDr);
            this.kryptonPanel2.Controls.Add(this.btnAdd);
            this.kryptonPanel2.Controls.Add(this.txtDiscription);
            this.kryptonPanel2.Controls.Add(this.lblAmount);
            this.kryptonPanel2.Controls.Add(this.lblDate);
            this.kryptonPanel2.Controls.Add(this.dtpDate);
            this.kryptonPanel2.Location = new System.Drawing.Point(3, 44);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(739, 218);
            this.kryptonPanel2.TabIndex = 3;
            // 
            // txtT_ID
            // 
            this.txtT_ID.Location = new System.Drawing.Point(81, 171);
            this.txtT_ID.Name = "txtT_ID";
            this.txtT_ID.Size = new System.Drawing.Size(40, 20);
            this.txtT_ID.TabIndex = 49;
            this.txtT_ID.Visible = false;
            // 
            // lblSubAccountCr
            // 
            this.lblSubAccountCr.Location = new System.Drawing.Point(396, 110);
            this.lblSubAccountCr.Name = "lblSubAccountCr";
            this.lblSubAccountCr.Size = new System.Drawing.Size(94, 20);
            this.lblSubAccountCr.TabIndex = 48;
            this.lblSubAccountCr.Values.Text = "SubAccount Cr.";
            // 
            // cmbSubAccountCr
            // 
            this.cmbSubAccountCr.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbSubAccountCr.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSubAccountCr.DropDownWidth = 146;
            this.cmbSubAccountCr.Enabled = false;
            this.cmbSubAccountCr.Location = new System.Drawing.Point(532, 106);
            this.cmbSubAccountCr.Name = "cmbSubAccountCr";
            this.cmbSubAccountCr.Size = new System.Drawing.Size(162, 21);
            this.cmbSubAccountCr.TabIndex = 5;
            // 
            // lblInvoiceNo
            // 
            this.lblInvoiceNo.Location = new System.Drawing.Point(418, 53);
            this.lblInvoiceNo.Name = "lblInvoiceNo";
            this.lblInvoiceNo.Size = new System.Drawing.Size(72, 20);
            this.lblInvoiceNo.TabIndex = 43;
            this.lblInvoiceNo.Values.Text = "Invoice No.";
            this.lblInvoiceNo.Visible = false;
            // 
            // txtInvoiceNo
            // 
            this.txtInvoiceNo.Location = new System.Drawing.Point(532, 49);
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.Size = new System.Drawing.Size(162, 20);
            this.txtInvoiceNo.TabIndex = 6;
            this.txtInvoiceNo.Visible = false;
            this.txtInvoiceNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInvoiceNo_KeyPress);
            // 
            // lblTokenNo
            // 
            this.lblTokenNo.Location = new System.Drawing.Point(424, 21);
            this.lblTokenNo.Name = "lblTokenNo";
            this.lblTokenNo.Size = new System.Drawing.Size(66, 20);
            this.lblTokenNo.TabIndex = 42;
            this.lblTokenNo.Values.Text = "Token No.";
            // 
            // lblFirmName
            // 
            this.lblFirmName.Location = new System.Drawing.Point(27, 51);
            this.lblFirmName.Name = "lblFirmName";
            this.lblFirmName.Size = new System.Drawing.Size(109, 20);
            this.lblFirmName.TabIndex = 37;
            this.lblFirmName.Values.Text = "Transaction Mode";
            // 
            // lblDiscription
            // 
            this.lblDiscription.Location = new System.Drawing.Point(421, 137);
            this.lblDiscription.Name = "lblDiscription";
            this.lblDiscription.Size = new System.Drawing.Size(69, 20);
            this.lblDiscription.TabIndex = 40;
            this.lblDiscription.Values.Text = "Discription";
            // 
            // lblSubAccountDr
            // 
            this.lblSubAccountDr.Location = new System.Drawing.Point(41, 107);
            this.lblSubAccountDr.Name = "lblSubAccountDr";
            this.lblSubAccountDr.Size = new System.Drawing.Size(95, 20);
            this.lblSubAccountDr.TabIndex = 39;
            this.lblSubAccountDr.Values.Text = "SubAccount Dr.";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(172, 137);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(173, 20);
            this.txtAmount.TabIndex = 6;
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            // 
            // cmdTransactionMode
            // 
            this.cmdTransactionMode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmdTransactionMode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmdTransactionMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmdTransactionMode.DropDownWidth = 273;
            this.cmdTransactionMode.Items.AddRange(new object[] {
            "---Select---",
            "Payment",
            "Receipt",
            "Contra"});
            this.cmdTransactionMode.Location = new System.Drawing.Point(172, 50);
            this.cmdTransactionMode.Name = "cmdTransactionMode";
            this.cmdTransactionMode.Size = new System.Drawing.Size(173, 21);
            this.cmdTransactionMode.TabIndex = 2;
            this.cmdTransactionMode.SelectedIndexChanged += new System.EventHandler(this.cmdTransactionMode_SelectedIndexChanged);
            this.cmdTransactionMode.SelectionChangeCommitted += new System.EventHandler(this.cmdTransactionMode_SelectionChangeCommitted);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(384, 177);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(83, 25);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Values.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cmbSubAccountDr
            // 
            this.cmbSubAccountDr.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbSubAccountDr.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSubAccountDr.DropDownWidth = 146;
            this.cmbSubAccountDr.Location = new System.Drawing.Point(172, 108);
            this.cmbSubAccountDr.Name = "cmbSubAccountDr";
            this.cmbSubAccountDr.Size = new System.Drawing.Size(173, 21);
            this.cmbSubAccountDr.TabIndex = 3;
            this.cmbSubAccountDr.SelectedIndexChanged += new System.EventHandler(this.cmbSubAccountDr_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(288, 177);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(83, 25);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Values.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtDiscription
            // 
            this.txtDiscription.Location = new System.Drawing.Point(534, 135);
            this.txtDiscription.Multiline = true;
            this.txtDiscription.Name = "txtDiscription";
            this.txtDiscription.Size = new System.Drawing.Size(162, 56);
            this.txtDiscription.TabIndex = 7;
            // 
            // lblAmount
            // 
            this.lblAmount.Location = new System.Drawing.Point(81, 135);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(55, 20);
            this.lblAmount.TabIndex = 44;
            this.lblAmount.Values.Text = "Amount";
            // 
            // lblDate
            // 
            this.lblDate.Location = new System.Drawing.Point(100, 23);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(36, 20);
            this.lblDate.TabIndex = 41;
            this.lblDate.Values.Text = "Date";
            // 
            // dtpDate
            // 
            this.dtpDate.CalendarTodayDate = new System.DateTime(2017, 3, 20, 0, 0, 0, 0);
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(172, 21);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(173, 21);
            this.dtpDate.TabIndex = 1;
            this.dtpDate.ValueNullable = new System.DateTime(((long)(0)));
            // 
            // kryptonPanel4
            // 
            this.kryptonPanel4.Controls.Add(this.btnClear);
            this.kryptonPanel4.Controls.Add(this.btnExit);
            this.kryptonPanel4.Controls.Add(this.btnSubmit);
            this.kryptonPanel4.Location = new System.Drawing.Point(3, 419);
            this.kryptonPanel4.Name = "kryptonPanel4";
            this.kryptonPanel4.Size = new System.Drawing.Size(739, 49);
            this.kryptonPanel4.TabIndex = 19;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(317, 8);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(118, 25);
            this.btnClear.TabIndex = 11;
            this.btnClear.Values.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(454, 8);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(118, 25);
            this.btnExit.TabIndex = 12;
            this.btnExit.Values.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(182, 8);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(118, 25);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Values.Text = "Submit";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // kryptonPanel5
            // 
            this.kryptonPanel5.Controls.Add(this.dataGridView1);
            this.kryptonPanel5.Location = new System.Drawing.Point(3, 266);
            this.kryptonPanel5.Name = "kryptonPanel5";
            this.kryptonPanel5.Size = new System.Drawing.Size(739, 149);
            this.kryptonPanel5.TabIndex = 24;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column2,
            this.Credit_Account,
            this.Column1,
            this.Credit_Acc_ID,
            this.Column3,
            this.Column5,
            this.DC,
            this.Tran_Mode,
            this.Tran_Expences_ID});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(739, 149);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.TabStop = false;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Sr. No.";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Debit Account";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Credit_Account
            // 
            this.Credit_Account.HeaderText = "Credit Account";
            this.Credit_Account.Name = "Credit_Account";
            this.Credit_Account.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "DebitAccount ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Credit_Acc_ID
            // 
            this.Credit_Acc_ID.HeaderText = "Credit_Acc_ID";
            this.Credit_Acc_ID.Name = "Credit_Acc_ID";
            this.Credit_Acc_ID.ReadOnly = true;
            this.Credit_Acc_ID.Visible = false;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Description";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Amount";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // DC
            // 
            this.DC.HeaderText = "D/C";
            this.DC.Name = "DC";
            this.DC.ReadOnly = true;
            this.DC.Visible = false;
            // 
            // Tran_Mode
            // 
            this.Tran_Mode.HeaderText = "Tran_Mode";
            this.Tran_Mode.Name = "Tran_Mode";
            this.Tran_Mode.ReadOnly = true;
            this.Tran_Mode.Visible = false;
            // 
            // Tran_Expences_ID
            // 
            this.Tran_Expences_ID.HeaderText = "Tran_Expences_ID";
            this.Tran_Expences_ID.Name = "Tran_Expences_ID";
            this.Tran_Expences_ID.ReadOnly = true;
            this.Tran_Expences_ID.Visible = false;
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.rbDelete);
            this.kryptonPanel1.Controls.Add(this.rbUpdate);
            this.kryptonPanel1.Controls.Add(this.rbNew);
            this.kryptonPanel1.Location = new System.Drawing.Point(3, 3);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(739, 38);
            this.kryptonPanel1.TabIndex = 1;
            // 
            // rbDelete
            // 
            this.rbDelete.Location = new System.Drawing.Point(370, 8);
            this.rbDelete.Name = "rbDelete";
            this.rbDelete.Size = new System.Drawing.Size(62, 20);
            this.rbDelete.TabIndex = 14;
            this.rbDelete.Values.Text = "DELETE";
            this.rbDelete.CheckedChanged += new System.EventHandler(this.rbDelete_CheckedChanged);
            // 
            // rbUpdate
            // 
            this.rbUpdate.Location = new System.Drawing.Point(644, 9);
            this.rbUpdate.Name = "rbUpdate";
            this.rbUpdate.Size = new System.Drawing.Size(67, 20);
            this.rbUpdate.TabIndex = 13;
            this.rbUpdate.Values.Text = "UPDATE";
            this.rbUpdate.Visible = false;
            this.rbUpdate.CheckedChanged += new System.EventHandler(this.rbUpdate_CheckedChanged);
            // 
            // rbNew
            // 
            this.rbNew.Location = new System.Drawing.Point(258, 8);
            this.rbNew.Name = "rbNew";
            this.rbNew.Size = new System.Drawing.Size(48, 20);
            this.rbNew.TabIndex = 0;
            this.rbNew.Values.Text = "ADD";
            this.rbNew.CheckedChanged += new System.EventHandler(this.rbNew_CheckedChanged);
            // 
            // FRM_EXPENCESTRANSACTION
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 473);
            this.Controls.Add(this.kryptonPanel);
            this.Name = "FRM_EXPENCESTRANSACTION";
            this.Text = "DEBIT CREDIT TRANSACTION";
            this.Load += new System.EventHandler(this.FRM_EXPENCESTRANSACTION_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).EndInit();
            this.kryptonPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSubAccountCr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdTransactionMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSubAccountDr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel4)).EndInit();
            this.kryptonPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel5)).EndInit();
            this.kryptonPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtTokanNo;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtAmount;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnDelete;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAdd;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblAmount;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cmdTransactionMode;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtDiscription;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblDate;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblSubAccountDr;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cmbSubAccountDr;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblFirmName;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtpDate;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel4;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnExit;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSubmit;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblTokenNo;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblDiscription;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnClear;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton rbDelete;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton rbUpdate;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton rbNew;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtT_ID;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox kryptonComboBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblSubAccountCr;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cmbSubAccountCr;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblInvoiceNo;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtInvoiceNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Credit_Account;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Credit_Acc_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn DC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tran_Mode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tran_Expences_ID;
    }
}

