namespace BILLING_SYSTEM
{
    partial class FRM_EXPENCES_TRANSACTION
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
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.lvw = new AC.ExtendedRenderer.Toolkit.KryptonListView();
            this.kryptonPanel3 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btncancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txtTransactionId = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnsave = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.txtAmount = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtDescription = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblDiscription = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.tDate = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.lblTransactionDate = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.comboExpenceName = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.lblSelectExpencesName = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonPanel4 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.optdelete = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.optupdate = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.optadd = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
            this.kryptonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).BeginInit();
            this.kryptonPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboExpenceName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel4)).BeginInit();
            this.kryptonPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel
            // 
            this.kryptonPanel.Controls.Add(this.kryptonPanel1);
            this.kryptonPanel.Controls.Add(this.kryptonPanel3);
            this.kryptonPanel.Controls.Add(this.kryptonPanel2);
            this.kryptonPanel.Controls.Add(this.kryptonPanel4);
            this.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel.Name = "kryptonPanel";
            this.kryptonPanel.Size = new System.Drawing.Size(632, 309);
            this.kryptonPanel.TabIndex = 0;
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.lvw);
            this.kryptonPanel1.Location = new System.Drawing.Point(322, 3);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(307, 298);
            this.kryptonPanel1.TabIndex = 6;
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
            this.lvw.Size = new System.Drawing.Size(307, 298);
            this.lvw.TabIndex = 6;
            this.lvw.TabStop = false;
            this.lvw.UseCompatibleStateImageBehavior = false;
            this.lvw.UseStyledColors = false;
            this.lvw.SelectedIndexChanged += new System.EventHandler(this.lvw_SelectedIndexChanged);
            this.lvw.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lvw_MouseUp);
            // 
            // kryptonPanel3
            // 
            this.kryptonPanel3.Controls.Add(this.btncancel);
            this.kryptonPanel3.Controls.Add(this.txtTransactionId);
            this.kryptonPanel3.Controls.Add(this.btnsave);
            this.kryptonPanel3.Location = new System.Drawing.Point(3, 251);
            this.kryptonPanel3.Name = "kryptonPanel3";
            this.kryptonPanel3.Size = new System.Drawing.Size(313, 50);
            this.kryptonPanel3.TabIndex = 5;
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(169, 13);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(81, 25);
            this.btncancel.TabIndex = 6;
            this.btncancel.Values.Text = "Cancel";
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // txtTransactionId
            // 
            this.txtTransactionId.Location = new System.Drawing.Point(3, 3);
            this.txtTransactionId.Name = "txtTransactionId";
            this.txtTransactionId.Size = new System.Drawing.Size(34, 20);
            this.txtTransactionId.TabIndex = 0;
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(62, 13);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(85, 25);
            this.btnsave.TabIndex = 5;
            this.btnsave.Values.Text = "Submit";
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.txtAmount);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel2.Controls.Add(this.txtDescription);
            this.kryptonPanel2.Controls.Add(this.lblDiscription);
            this.kryptonPanel2.Controls.Add(this.tDate);
            this.kryptonPanel2.Controls.Add(this.lblTransactionDate);
            this.kryptonPanel2.Controls.Add(this.comboExpenceName);
            this.kryptonPanel2.Controls.Add(this.lblSelectExpencesName);
            this.kryptonPanel2.Location = new System.Drawing.Point(3, 50);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(313, 195);
            this.kryptonPanel2.TabIndex = 4;
            this.kryptonPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.kryptonPanel2_Paint);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(179, 161);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(118, 20);
            this.txtAmount.TabIndex = 4;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(93, 161);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(55, 20);
            this.kryptonLabel1.TabIndex = 10;
            this.kryptonLabel1.Values.Text = "Amount";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(179, 80);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(118, 73);
            this.txtDescription.TabIndex = 3;
            // 
            // lblDiscription
            // 
            this.lblDiscription.Location = new System.Drawing.Point(79, 105);
            this.lblDiscription.Name = "lblDiscription";
            this.lblDiscription.Size = new System.Drawing.Size(69, 20);
            this.lblDiscription.TabIndex = 8;
            this.lblDiscription.Values.Text = "Discription";
            // 
            // tDate
            // 
            this.tDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tDate.Location = new System.Drawing.Point(179, 45);
            this.tDate.Name = "tDate";
            this.tDate.Size = new System.Drawing.Size(118, 21);
            this.tDate.TabIndex = 2;
            // 
            // lblTransactionDate
            // 
            this.lblTransactionDate.Location = new System.Drawing.Point(46, 46);
            this.lblTransactionDate.Name = "lblTransactionDate";
            this.lblTransactionDate.Size = new System.Drawing.Size(102, 20);
            this.lblTransactionDate.TabIndex = 6;
            this.lblTransactionDate.Values.Text = "Transaction Date";
            // 
            // comboExpenceName
            // 
            this.comboExpenceName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboExpenceName.DropDownWidth = 121;
            this.comboExpenceName.Location = new System.Drawing.Point(179, 15);
            this.comboExpenceName.Name = "comboExpenceName";
            this.comboExpenceName.Size = new System.Drawing.Size(118, 21);
            this.comboExpenceName.TabIndex = 1;
            this.comboExpenceName.SelectedIndexChanged += new System.EventHandler(this.comboExpenceName_SelectedIndexChanged);
            // 
            // lblSelectExpencesName
            // 
            this.lblSelectExpencesName.Location = new System.Drawing.Point(16, 16);
            this.lblSelectExpencesName.Name = "lblSelectExpencesName";
            this.lblSelectExpencesName.Size = new System.Drawing.Size(132, 20);
            this.lblSelectExpencesName.TabIndex = 4;
            this.lblSelectExpencesName.Values.Text = "Select Expences Name";
            // 
            // kryptonPanel4
            // 
            this.kryptonPanel4.Controls.Add(this.optdelete);
            this.kryptonPanel4.Controls.Add(this.optupdate);
            this.kryptonPanel4.Controls.Add(this.optadd);
            this.kryptonPanel4.Location = new System.Drawing.Point(3, 3);
            this.kryptonPanel4.Name = "kryptonPanel4";
            this.kryptonPanel4.Size = new System.Drawing.Size(313, 41);
            this.kryptonPanel4.TabIndex = 1;
            // 
            // optdelete
            // 
            this.optdelete.Location = new System.Drawing.Point(217, 10);
            this.optdelete.Name = "optdelete";
            this.optdelete.Size = new System.Drawing.Size(62, 20);
            this.optdelete.TabIndex = 8;
            this.optdelete.Values.Text = "DELETE";
            this.optdelete.CheckedChanged += new System.EventHandler(this.optdelete_CheckedChanged);
            // 
            // optupdate
            // 
            this.optupdate.Location = new System.Drawing.Point(121, 10);
            this.optupdate.Name = "optupdate";
            this.optupdate.Size = new System.Drawing.Size(67, 20);
            this.optupdate.TabIndex = 7;
            this.optupdate.Values.Text = "UPDATE";
            this.optupdate.CheckedChanged += new System.EventHandler(this.optupdate_CheckedChanged);
            // 
            // optadd
            // 
            this.optadd.Location = new System.Drawing.Point(34, 10);
            this.optadd.Name = "optadd";
            this.optadd.Size = new System.Drawing.Size(48, 20);
            this.optadd.TabIndex = 0;
            this.optadd.Values.Text = "ADD";
            this.optadd.CheckedChanged += new System.EventHandler(this.optadd_CheckedChanged);
            // 
            // FRM_EXPENCES_TRANSACTION
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 309);
            this.Controls.Add(this.kryptonPanel);
            this.Name = "FRM_EXPENCES_TRANSACTION";
            this.Text = "EXPENCES TRANSACTION";
            this.Load += new System.EventHandler(this.FRM_EXPENCES_TRANSACTION_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).EndInit();
            this.kryptonPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).EndInit();
            this.kryptonPanel3.ResumeLayout(false);
            this.kryptonPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboExpenceName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel4)).EndInit();
            this.kryptonPanel4.ResumeLayout(false);
            this.kryptonPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel4;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton optdelete;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton optupdate;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton optadd;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblSelectExpencesName;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel3;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btncancel;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtTransactionId;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnsave;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtAmount;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtDescription;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblDiscription;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker tDate;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblTransactionDate;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox comboExpenceName;
        private AC.ExtendedRenderer.Toolkit.KryptonListView lvw;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
    }
}

