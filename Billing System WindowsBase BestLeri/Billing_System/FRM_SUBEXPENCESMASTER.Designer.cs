namespace BILLING_SYSTEM
{
    partial class FRM_SUBEXPENCESMASTER
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
            this.kryptonManager1 = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.kryptonPanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonPanel3 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonPanel4 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.lvw = new AC.ExtendedRenderer.Toolkit.KryptonListView();
            this.kryptonPanel5 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btnPreview = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btncancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txtExpencesId = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnsave = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.lblMainAccount = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmbMainAccount = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.cmbExpences = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.lblExpences = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtExpencesName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblexpencesname = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.optdelete = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.optupdate = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.optadd = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
            this.kryptonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).BeginInit();
            this.kryptonPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel4)).BeginInit();
            this.kryptonPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel5)).BeginInit();
            this.kryptonPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMainAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbExpences)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel
            // 
            this.kryptonPanel.Controls.Add(this.kryptonPanel3);
            this.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel.Name = "kryptonPanel";
            this.kryptonPanel.Size = new System.Drawing.Size(671, 205);
            this.kryptonPanel.TabIndex = 0;
            // 
            // kryptonPanel3
            // 
            this.kryptonPanel3.Controls.Add(this.kryptonPanel4);
            this.kryptonPanel3.Controls.Add(this.kryptonPanel5);
            this.kryptonPanel3.Controls.Add(this.kryptonPanel2);
            this.kryptonPanel3.Controls.Add(this.kryptonPanel1);
            this.kryptonPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel3.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel3.Name = "kryptonPanel3";
            this.kryptonPanel3.Size = new System.Drawing.Size(671, 205);
            this.kryptonPanel3.TabIndex = 1;
            // 
            // kryptonPanel4
            // 
            this.kryptonPanel4.Controls.Add(this.lvw);
            this.kryptonPanel4.Location = new System.Drawing.Point(311, 3);
            this.kryptonPanel4.Name = "kryptonPanel4";
            this.kryptonPanel4.Size = new System.Drawing.Size(357, 196);
            this.kryptonPanel4.TabIndex = 6;
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
            this.lvw.Size = new System.Drawing.Size(357, 196);
            this.lvw.TabIndex = 9;
            this.lvw.TabStop = false;
            this.lvw.UseCompatibleStateImageBehavior = false;
            this.lvw.UseStyledColors = false;
            this.lvw.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lvw_MouseUp);
            // 
            // kryptonPanel5
            // 
            this.kryptonPanel5.Controls.Add(this.btnPreview);
            this.kryptonPanel5.Controls.Add(this.btncancel);
            this.kryptonPanel5.Controls.Add(this.txtExpencesId);
            this.kryptonPanel5.Controls.Add(this.btnsave);
            this.kryptonPanel5.Location = new System.Drawing.Point(3, 150);
            this.kryptonPanel5.Name = "kryptonPanel5";
            this.kryptonPanel5.Size = new System.Drawing.Size(301, 49);
            this.kryptonPanel5.TabIndex = 4;
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(112, 12);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(81, 25);
            this.btnPreview.TabIndex = 5;
            this.btnPreview.Values.Text = "Preview";
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(199, 12);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(81, 25);
            this.btncancel.TabIndex = 6;
            this.btncancel.Values.Text = "Cancel";
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // txtExpencesId
            // 
            this.txtExpencesId.Location = new System.Drawing.Point(3, 3);
            this.txtExpencesId.Name = "txtExpencesId";
            this.txtExpencesId.Size = new System.Drawing.Size(20, 20);
            this.txtExpencesId.TabIndex = 0;
            this.txtExpencesId.Visible = false;
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(21, 12);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(85, 25);
            this.btnsave.TabIndex = 4;
            this.btnsave.Values.Text = "Submit";
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.lblMainAccount);
            this.kryptonPanel2.Controls.Add(this.cmbMainAccount);
            this.kryptonPanel2.Controls.Add(this.cmbExpences);
            this.kryptonPanel2.Controls.Add(this.lblExpences);
            this.kryptonPanel2.Controls.Add(this.txtExpencesName);
            this.kryptonPanel2.Controls.Add(this.lblexpencesname);
            this.kryptonPanel2.Location = new System.Drawing.Point(4, 40);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(301, 104);
            this.kryptonPanel2.TabIndex = 3;
            // 
            // lblMainAccount
            // 
            this.lblMainAccount.Location = new System.Drawing.Point(36, 14);
            this.lblMainAccount.Name = "lblMainAccount";
            this.lblMainAccount.Size = new System.Drawing.Size(86, 20);
            this.lblMainAccount.TabIndex = 9;
            this.lblMainAccount.Values.Text = "Main Account";
            // 
            // cmbMainAccount
            // 
            this.cmbMainAccount.DropDownWidth = 130;
            this.cmbMainAccount.Items.AddRange(new object[] {
            "-Select-",
            "Income",
            "Expences",
            "Assets",
            "Liability"});
            this.cmbMainAccount.Location = new System.Drawing.Point(142, 13);
            this.cmbMainAccount.Name = "cmbMainAccount";
            this.cmbMainAccount.Size = new System.Drawing.Size(144, 21);
            this.cmbMainAccount.TabIndex = 1;
            this.cmbMainAccount.SelectedIndexChanged += new System.EventHandler(this.cmbMainAccount_SelectedIndexChanged);
            // 
            // cmbExpences
            // 
            this.cmbExpences.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbExpences.DropDownWidth = 148;
            this.cmbExpences.Location = new System.Drawing.Point(143, 42);
            this.cmbExpences.Name = "cmbExpences";
            this.cmbExpences.Size = new System.Drawing.Size(143, 21);
            this.cmbExpences.TabIndex = 2;
            // 
            // lblExpences
            // 
            this.lblExpences.Location = new System.Drawing.Point(37, 42);
            this.lblExpences.Name = "lblExpences";
            this.lblExpences.Size = new System.Drawing.Size(85, 20);
            this.lblExpences.TabIndex = 7;
            this.lblExpences.Values.Text = "Account Type";
            // 
            // txtExpencesName
            // 
            this.txtExpencesName.Location = new System.Drawing.Point(143, 71);
            this.txtExpencesName.Name = "txtExpencesName";
            this.txtExpencesName.Size = new System.Drawing.Size(143, 20);
            this.txtExpencesName.TabIndex = 3;
            // 
            // lblexpencesname
            // 
            this.lblexpencesname.Location = new System.Drawing.Point(13, 70);
            this.lblexpencesname.Name = "lblexpencesname";
            this.lblexpencesname.Size = new System.Drawing.Size(109, 20);
            this.lblexpencesname.TabIndex = 4;
            this.lblexpencesname.Values.Text = "Sub Account Type";
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.optdelete);
            this.kryptonPanel1.Controls.Add(this.optupdate);
            this.kryptonPanel1.Controls.Add(this.optadd);
            this.kryptonPanel1.Location = new System.Drawing.Point(4, 3);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(301, 36);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // optdelete
            // 
            this.optdelete.Location = new System.Drawing.Point(211, 8);
            this.optdelete.Name = "optdelete";
            this.optdelete.Size = new System.Drawing.Size(62, 20);
            this.optdelete.TabIndex = 8;
            this.optdelete.Values.Text = "DELETE";
            this.optdelete.CheckedChanged += new System.EventHandler(this.optdelete_CheckedChanged);
            // 
            // optupdate
            // 
            this.optupdate.Location = new System.Drawing.Point(115, 8);
            this.optupdate.Name = "optupdate";
            this.optupdate.Size = new System.Drawing.Size(67, 20);
            this.optupdate.TabIndex = 7;
            this.optupdate.Values.Text = "UPDATE";
            this.optupdate.CheckedChanged += new System.EventHandler(this.optupdate_CheckedChanged);
            // 
            // optadd
            // 
            this.optadd.Location = new System.Drawing.Point(28, 8);
            this.optadd.Name = "optadd";
            this.optadd.Size = new System.Drawing.Size(48, 20);
            this.optadd.TabIndex = 0;
            this.optadd.Values.Text = "ADD";
            this.optadd.CheckedChanged += new System.EventHandler(this.optadd_CheckedChanged);
            // 
            // FRM_SUBEXPENCESMASTER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 205);
            this.Controls.Add(this.kryptonPanel);
            this.Name = "FRM_SUBEXPENCESMASTER";
            this.Text = "SUBEXPENCES MASTER";
            this.Load += new System.EventHandler(this.FRM_SUBEXPENCESMASTER_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).EndInit();
            this.kryptonPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).EndInit();
            this.kryptonPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel4)).EndInit();
            this.kryptonPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel5)).EndInit();
            this.kryptonPanel5.ResumeLayout(false);
            this.kryptonPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMainAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbExpences)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel3;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel4;
        private AC.ExtendedRenderer.Toolkit.KryptonListView lvw;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel5;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnPreview;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btncancel;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtExpencesId;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnsave;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cmbExpences;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblExpences;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtExpencesName;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblexpencesname;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton optdelete;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton optupdate;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton optadd;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblMainAccount;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cmbMainAccount;
    }
}

