namespace BILLING_SYSTEM
{
    partial class FRM_Vehical_Details
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
            this.kryptonManager1 = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.optdelete = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.optedit = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.optadd = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.kryptonPanel3 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.lvw = new AC.ExtendedRenderer.Toolkit.KryptonListView();
            this.kryptonPanel5 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.txtEmployeeName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtAddress = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblAddress = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtMobileNumber = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblMobileNo = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblEmployeeName = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btnExit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonPanel4 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.txtEmpId = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnSubmit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnPreview = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonPanel6 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonPanel7 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonPanel8 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.txtDescription = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmbTransport = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.txtVehical_No = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).BeginInit();
            this.kryptonPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel5)).BeginInit();
            this.kryptonPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel4)).BeginInit();
            this.kryptonPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel6)).BeginInit();
            this.kryptonPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel7)).BeginInit();
            this.kryptonPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel8)).BeginInit();
            this.kryptonPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTransport)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel
            // 
            this.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel.Name = "kryptonPanel";
            this.kryptonPanel.Size = new System.Drawing.Size(854, 285);
            this.kryptonPanel.TabIndex = 0;
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.optdelete);
            this.kryptonPanel1.Controls.Add(this.optedit);
            this.kryptonPanel1.Controls.Add(this.optadd);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(400, 35);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // optdelete
            // 
            this.optdelete.Location = new System.Drawing.Point(277, 7);
            this.optdelete.Name = "optdelete";
            this.optdelete.Size = new System.Drawing.Size(62, 20);
            this.optdelete.TabIndex = 11;
            this.optdelete.Values.Text = "DELETE";
            this.optdelete.CheckedChanged += new System.EventHandler(this.optdelete_CheckedChanged);
            // 
            // optedit
            // 
            this.optedit.Location = new System.Drawing.Point(167, 7);
            this.optedit.Name = "optedit";
            this.optedit.Size = new System.Drawing.Size(62, 20);
            this.optedit.TabIndex = 10;
            this.optedit.Values.Text = "Update";
            this.optedit.CheckedChanged += new System.EventHandler(this.optedit_CheckedChanged);
            // 
            // optadd
            // 
            this.optadd.Location = new System.Drawing.Point(71, 7);
            this.optadd.Name = "optadd";
            this.optadd.Size = new System.Drawing.Size(48, 20);
            this.optadd.TabIndex = 0;
            this.optadd.Values.Text = "ADD";
            this.optadd.CheckedChanged += new System.EventHandler(this.optadd_CheckedChanged);
            // 
            // kryptonPanel3
            // 
            this.kryptonPanel3.Controls.Add(this.lvw);
            this.kryptonPanel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.kryptonPanel3.Location = new System.Drawing.Point(400, 0);
            this.kryptonPanel3.Name = "kryptonPanel3";
            this.kryptonPanel3.Size = new System.Drawing.Size(454, 285);
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
            this.lvw.Size = new System.Drawing.Size(454, 285);
            this.lvw.TabIndex = 12;
            this.lvw.TabStop = false;
            this.lvw.UseCompatibleStateImageBehavior = false;
            this.lvw.UseStyledColors = false;
            this.lvw.SelectedIndexChanged += new System.EventHandler(this.lvw_SelectedIndexChanged);
            // 
            // kryptonPanel5
            // 
            this.kryptonPanel5.Controls.Add(this.txtVehical_No);
            this.kryptonPanel5.Controls.Add(this.kryptonLabel3);
            this.kryptonPanel5.Controls.Add(this.cmbTransport);
            this.kryptonPanel5.Controls.Add(this.kryptonLabel2);
            this.kryptonPanel5.Controls.Add(this.txtDescription);
            this.kryptonPanel5.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel5.Controls.Add(this.txtEmployeeName);
            this.kryptonPanel5.Controls.Add(this.txtAddress);
            this.kryptonPanel5.Controls.Add(this.lblAddress);
            this.kryptonPanel5.Controls.Add(this.txtMobileNumber);
            this.kryptonPanel5.Controls.Add(this.lblMobileNo);
            this.kryptonPanel5.Controls.Add(this.lblEmployeeName);
            this.kryptonPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel5.Location = new System.Drawing.Point(0, 35);
            this.kryptonPanel5.Name = "kryptonPanel5";
            this.kryptonPanel5.Size = new System.Drawing.Size(400, 250);
            this.kryptonPanel5.TabIndex = 1;
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Location = new System.Drawing.Point(195, 55);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(168, 20);
            this.txtEmployeeName.TabIndex = 1;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(195, 80);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(168, 46);
            this.txtAddress.TabIndex = 2;
            // 
            // lblAddress
            // 
            this.lblAddress.Location = new System.Drawing.Point(97, 91);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(54, 20);
            this.lblAddress.TabIndex = 9;
            this.lblAddress.Values.Text = "Address";
            // 
            // txtMobileNumber
            // 
            this.txtMobileNumber.Location = new System.Drawing.Point(195, 132);
            this.txtMobileNumber.MaxLength = 10;
            this.txtMobileNumber.Name = "txtMobileNumber";
            this.txtMobileNumber.Size = new System.Drawing.Size(168, 20);
            this.txtMobileNumber.TabIndex = 3;
            // 
            // lblMobileNo
            // 
            this.lblMobileNo.Location = new System.Drawing.Point(54, 132);
            this.lblMobileNo.Name = "lblMobileNo";
            this.lblMobileNo.Size = new System.Drawing.Size(97, 20);
            this.lblMobileNo.TabIndex = 1;
            this.lblMobileNo.Values.Text = "Mobile Number";
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.Location = new System.Drawing.Point(51, 55);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(100, 20);
            this.lblEmployeeName.TabIndex = 0;
            this.lblEmployeeName.Values.Text = "Employee Name";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(267, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 27);
            this.btnExit.TabIndex = 9;
            this.btnExit.Values.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.kryptonPanel4);
            this.kryptonPanel2.Controls.Add(this.kryptonPanel5);
            this.kryptonPanel2.Controls.Add(this.kryptonPanel1);
            this.kryptonPanel2.Controls.Add(this.kryptonPanel3);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(854, 285);
            this.kryptonPanel2.TabIndex = 1;
            // 
            // kryptonPanel4
            // 
            this.kryptonPanel4.Controls.Add(this.txtEmpId);
            this.kryptonPanel4.Controls.Add(this.btnSubmit);
            this.kryptonPanel4.Controls.Add(this.btnPreview);
            this.kryptonPanel4.Controls.Add(this.btnExit);
            this.kryptonPanel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel4.Location = new System.Drawing.Point(0, 248);
            this.kryptonPanel4.Name = "kryptonPanel4";
            this.kryptonPanel4.Size = new System.Drawing.Size(400, 37);
            this.kryptonPanel4.TabIndex = 13;
            // 
            // txtEmpId
            // 
            this.txtEmpId.Enabled = false;
            this.txtEmpId.Location = new System.Drawing.Point(12, 10);
            this.txtEmpId.Name = "txtEmpId";
            this.txtEmpId.Size = new System.Drawing.Size(33, 20);
            this.txtEmpId.TabIndex = 15;
            this.txtEmpId.Visible = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(63, 5);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(80, 27);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Values.Text = "Submit";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(165, 5);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(80, 27);
            this.btnPreview.TabIndex = 8;
            this.btnPreview.Values.Text = "Preview";
            // 
            // kryptonPanel6
            // 
            this.kryptonPanel6.Controls.Add(this.kryptonPanel2);
            this.kryptonPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel6.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel6.Name = "kryptonPanel6";
            this.kryptonPanel6.Size = new System.Drawing.Size(854, 285);
            this.kryptonPanel6.TabIndex = 1;
            // 
            // kryptonPanel7
            // 
            this.kryptonPanel7.Controls.Add(this.kryptonPanel6);
            this.kryptonPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel7.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel7.Name = "kryptonPanel7";
            this.kryptonPanel7.Size = new System.Drawing.Size(854, 285);
            this.kryptonPanel7.TabIndex = 1;
            // 
            // kryptonPanel8
            // 
            this.kryptonPanel8.Controls.Add(this.kryptonPanel7);
            this.kryptonPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel8.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel8.Name = "kryptonPanel8";
            this.kryptonPanel8.Size = new System.Drawing.Size(854, 285);
            this.kryptonPanel8.TabIndex = 1;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(195, 158);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(168, 46);
            this.txtDescription.TabIndex = 10;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(78, 168);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(73, 20);
            this.kryptonLabel1.TabIndex = 11;
            this.kryptonLabel1.Values.Text = "Description";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(61, 5);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(90, 20);
            this.kryptonLabel2.TabIndex = 12;
            this.kryptonLabel2.Values.Text = "Transportation";
            // 
            // cmbTransport
            // 
            this.cmbTransport.DropDownWidth = 168;
            this.cmbTransport.Location = new System.Drawing.Point(195, 4);
            this.cmbTransport.Name = "cmbTransport";
            this.cmbTransport.Size = new System.Drawing.Size(168, 21);
            this.cmbTransport.TabIndex = 13;
            this.cmbTransport.Text = "kryptonComboBox1";
            this.cmbTransport.SelectedIndexChanged += new System.EventHandler(this.cmbTransport_SelectedIndexChanged);
            // 
            // txtVehical_No
            // 
            this.txtVehical_No.Location = new System.Drawing.Point(195, 31);
            this.txtVehical_No.Name = "txtVehical_No";
            this.txtVehical_No.Size = new System.Drawing.Size(168, 20);
            this.txtVehical_No.TabIndex = 15;
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(79, 31);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(72, 20);
            this.kryptonLabel3.TabIndex = 14;
            this.kryptonLabel3.Values.Text = "Vehical No.";
            // 
            // FRM_Vehical_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 285);
            this.Controls.Add(this.kryptonPanel8);
            this.Controls.Add(this.kryptonPanel);
            this.Name = "FRM_Vehical_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_Vehical_Details";
            this.Load += new System.EventHandler(this.FRM_Vehical_Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).EndInit();
            this.kryptonPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel5)).EndInit();
            this.kryptonPanel5.ResumeLayout(false);
            this.kryptonPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel4)).EndInit();
            this.kryptonPanel4.ResumeLayout(false);
            this.kryptonPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel6)).EndInit();
            this.kryptonPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel7)).EndInit();
            this.kryptonPanel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel8)).EndInit();
            this.kryptonPanel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmbTransport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton optdelete;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton optedit;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton optadd;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel3;
        private AC.ExtendedRenderer.Toolkit.KryptonListView lvw;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel5;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cmbTransport;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtDescription;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtEmployeeName;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtAddress;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblAddress;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtMobileNumber;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblMobileNo;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblEmployeeName;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnExit;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel4;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtEmpId;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSubmit;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnPreview;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel6;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel7;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel8;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtVehical_No;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
    }
}

