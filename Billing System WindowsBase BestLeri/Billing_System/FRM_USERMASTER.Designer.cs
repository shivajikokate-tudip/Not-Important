namespace BILLING_SYSTEM
{
    partial class FRM_USERMASTER
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
            this.kryptonPanel4 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.lvw = new AC.ExtendedRenderer.Toolkit.KryptonListView();
            this.kryptonPanel3 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.txtUserId = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnPreview = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnSave = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.txtConformPassword = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtPassword = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtUserName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblConfirmPassword = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblPassword = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblUserName = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblGroupType = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmbGroupType = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.optDelete = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.optEdit = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.optAdd = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
            this.kryptonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel4)).BeginInit();
            this.kryptonPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).BeginInit();
            this.kryptonPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbGroupType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel
            // 
            this.kryptonPanel.Controls.Add(this.kryptonPanel4);
            this.kryptonPanel.Controls.Add(this.kryptonPanel3);
            this.kryptonPanel.Controls.Add(this.kryptonPanel2);
            this.kryptonPanel.Controls.Add(this.kryptonPanel1);
            this.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel.Name = "kryptonPanel";
            this.kryptonPanel.Size = new System.Drawing.Size(689, 252);
            this.kryptonPanel.TabIndex = 0;
            // 
            // kryptonPanel4
            // 
            this.kryptonPanel4.Controls.Add(this.lvw);
            this.kryptonPanel4.Location = new System.Drawing.Point(364, 4);
            this.kryptonPanel4.Name = "kryptonPanel4";
            this.kryptonPanel4.Size = new System.Drawing.Size(322, 244);
            this.kryptonPanel4.TabIndex = 3;
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
            this.lvw.Size = new System.Drawing.Size(322, 244);
            this.lvw.TabIndex = 0;
            this.lvw.UseCompatibleStateImageBehavior = false;
            this.lvw.UseStyledColors = false;
            this.lvw.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lvw_MouseUp);
            // 
            // kryptonPanel3
            // 
            this.kryptonPanel3.Controls.Add(this.txtUserId);
            this.kryptonPanel3.Controls.Add(this.btnCancel);
            this.kryptonPanel3.Controls.Add(this.btnPreview);
            this.kryptonPanel3.Controls.Add(this.btnSave);
            this.kryptonPanel3.Location = new System.Drawing.Point(4, 192);
            this.kryptonPanel3.Name = "kryptonPanel3";
            this.kryptonPanel3.Size = new System.Drawing.Size(353, 56);
            this.kryptonPanel3.TabIndex = 2;
            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(3, 3);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(24, 20);
            this.txtUserId.TabIndex = 8;
            this.txtUserId.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(237, 16);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 25);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Values.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(131, 16);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(90, 25);
            this.btnPreview.TabIndex = 1;
            this.btnPreview.Values.Text = "Preview";
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(25, 16);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 25);
            this.btnSave.TabIndex = 0;
            this.btnSave.Values.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.txtConformPassword);
            this.kryptonPanel2.Controls.Add(this.txtPassword);
            this.kryptonPanel2.Controls.Add(this.txtUserName);
            this.kryptonPanel2.Controls.Add(this.lblConfirmPassword);
            this.kryptonPanel2.Controls.Add(this.lblPassword);
            this.kryptonPanel2.Controls.Add(this.lblUserName);
            this.kryptonPanel2.Controls.Add(this.lblGroupType);
            this.kryptonPanel2.Controls.Add(this.cmbGroupType);
            this.kryptonPanel2.Location = new System.Drawing.Point(4, 51);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(353, 135);
            this.kryptonPanel2.TabIndex = 1;
            // 
            // txtConformPassword
            // 
            this.txtConformPassword.Location = new System.Drawing.Point(171, 100);
            this.txtConformPassword.Name = "txtConformPassword";
            this.txtConformPassword.Size = new System.Drawing.Size(153, 20);
            this.txtConformPassword.TabIndex = 7;
            this.txtConformPassword.Leave += new System.EventHandler(this.txtConformPassword_Leave);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(171, 72);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(153, 20);
            this.txtPassword.TabIndex = 6;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(171, 44);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(153, 20);
            this.txtUserName.TabIndex = 5;
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.Location = new System.Drawing.Point(21, 100);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(109, 20);
            this.lblConfirmPassword.TabIndex = 4;
            this.lblConfirmPassword.Values.Text = "Confirm Password";
            // 
            // lblPassword
            // 
            this.lblPassword.Location = new System.Drawing.Point(68, 72);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(62, 20);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Values.Text = "Password";
            // 
            // lblUserName
            // 
            this.lblUserName.Location = new System.Drawing.Point(59, 44);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(71, 20);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Values.Text = "User Name";
            // 
            // lblGroupType
            // 
            this.lblGroupType.Location = new System.Drawing.Point(56, 16);
            this.lblGroupType.Name = "lblGroupType";
            this.lblGroupType.Size = new System.Drawing.Size(74, 20);
            this.lblGroupType.TabIndex = 1;
            this.lblGroupType.Values.Text = "Group Type";
            // 
            // cmbGroupType
            // 
            this.cmbGroupType.DropDownWidth = 153;
            this.cmbGroupType.Location = new System.Drawing.Point(171, 15);
            this.cmbGroupType.Name = "cmbGroupType";
            this.cmbGroupType.Size = new System.Drawing.Size(153, 21);
            this.cmbGroupType.TabIndex = 0;
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.optDelete);
            this.kryptonPanel1.Controls.Add(this.optEdit);
            this.kryptonPanel1.Controls.Add(this.optAdd);
            this.kryptonPanel1.Location = new System.Drawing.Point(4, 4);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(353, 41);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // optDelete
            // 
            this.optDelete.Location = new System.Drawing.Point(239, 10);
            this.optDelete.Name = "optDelete";
            this.optDelete.Size = new System.Drawing.Size(58, 20);
            this.optDelete.TabIndex = 2;
            this.optDelete.Values.Text = "Delete";
            this.optDelete.CheckedChanged += new System.EventHandler(this.optDelete_CheckedChanged);
            // 
            // optEdit
            // 
            this.optEdit.Location = new System.Drawing.Point(148, 10);
            this.optEdit.Name = "optEdit";
            this.optEdit.Size = new System.Drawing.Size(43, 20);
            this.optEdit.TabIndex = 1;
            this.optEdit.Values.Text = "Edit";
            this.optEdit.CheckedChanged += new System.EventHandler(this.optEdit_CheckedChanged);
            // 
            // optAdd
            // 
            this.optAdd.Location = new System.Drawing.Point(55, 10);
            this.optAdd.Name = "optAdd";
            this.optAdd.Size = new System.Drawing.Size(45, 20);
            this.optAdd.TabIndex = 0;
            this.optAdd.Values.Text = "Add";
            this.optAdd.CheckedChanged += new System.EventHandler(this.optAdd_CheckedChanged);
            // 
            // FRM_USERMASTER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 252);
            this.Controls.Add(this.kryptonPanel);
            this.Name = "FRM_USERMASTER";
            this.Text = "USER MASTER";
            this.Load += new System.EventHandler(this.FRM_USERMASTER_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).EndInit();
            this.kryptonPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel4)).EndInit();
            this.kryptonPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).EndInit();
            this.kryptonPanel3.ResumeLayout(false);
            this.kryptonPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbGroupType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel4;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel3;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton optDelete;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton optEdit;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton optAdd;
        private AC.ExtendedRenderer.Toolkit.KryptonListView lvw;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtUserId;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCancel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnPreview;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSave;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtConformPassword;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtPassword;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtUserName;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblConfirmPassword;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblPassword;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblUserName;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblGroupType;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cmbGroupType;
    }
}

