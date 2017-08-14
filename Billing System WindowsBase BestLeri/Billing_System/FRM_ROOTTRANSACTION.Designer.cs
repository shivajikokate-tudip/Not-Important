namespace BILLING_SYSTEM
{
    partial class FRM_ROOTTRANSACTION
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
            this.btnSavePosition = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnDown = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnUp = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.lvw = new AC.ExtendedRenderer.Toolkit.KryptonListView();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonPanel3 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btnPreview = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btncancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnsave = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonPanel4 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.cmbCustomer = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.cmbRootName = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.lblCustomer = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblRootName = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonPanel7 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.optdelete = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.optupdate = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.optadd = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
            this.kryptonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).BeginInit();
            this.kryptonPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel4)).BeginInit();
            this.kryptonPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbRootName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel7)).BeginInit();
            this.kryptonPanel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel
            // 
            this.kryptonPanel.Controls.Add(this.btnSavePosition);
            this.kryptonPanel.Controls.Add(this.btnDown);
            this.kryptonPanel.Controls.Add(this.btnUp);
            this.kryptonPanel.Controls.Add(this.kryptonPanel2);
            this.kryptonPanel.Controls.Add(this.kryptonPanel1);
            this.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel.Name = "kryptonPanel";
            this.kryptonPanel.Size = new System.Drawing.Size(845, 191);
            this.kryptonPanel.TabIndex = 0;
            this.kryptonPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.kryptonPanel_Paint);
            // 
            // btnSavePosition
            // 
            this.btnSavePosition.Location = new System.Drawing.Point(759, 129);
            this.btnSavePosition.Name = "btnSavePosition";
            this.btnSavePosition.Size = new System.Drawing.Size(74, 25);
            this.btnSavePosition.TabIndex = 5;
            this.btnSavePosition.Values.Text = "Save";
            this.btnSavePosition.Click += new System.EventHandler(this.btnSavePosition_Click);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(759, 53);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(74, 25);
            this.btnDown.TabIndex = 4;
            this.btnDown.Values.Text = "Down";
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(759, 22);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(74, 25);
            this.btnUp.TabIndex = 2;
            this.btnUp.Values.Text = "Up";
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.lvw);
            this.kryptonPanel2.Location = new System.Drawing.Point(408, 3);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(345, 185);
            this.kryptonPanel2.TabIndex = 1;
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
            this.lvw.IndendFirstItem = false;
            this.lvw.Location = new System.Drawing.Point(0, 0);
            this.lvw.MultiSelect = false;
            this.lvw.Name = "lvw";
            this.lvw.OwnerDraw = true;
            this.lvw.PersistentColors = false;
            this.lvw.SelectEntireRowOnSubItem = true;
            this.lvw.Size = new System.Drawing.Size(345, 185);
            this.lvw.TabIndex = 7;
            this.lvw.TabStop = false;
            this.lvw.UseCompatibleStateImageBehavior = false;
            this.lvw.UseStyledColors = false;
            this.lvw.SelectedIndexChanged += new System.EventHandler(this.lvw_SelectedIndexChanged);
            this.lvw.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lvw_MouseUp);
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kryptonPanel3);
            this.kryptonPanel1.Controls.Add(this.kryptonPanel4);
            this.kryptonPanel1.Controls.Add(this.kryptonPanel7);
            this.kryptonPanel1.Location = new System.Drawing.Point(3, 3);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(399, 185);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // kryptonPanel3
            // 
            this.kryptonPanel3.Controls.Add(this.btnPreview);
            this.kryptonPanel3.Controls.Add(this.btncancel);
            this.kryptonPanel3.Controls.Add(this.btnsave);
            this.kryptonPanel3.Location = new System.Drawing.Point(3, 126);
            this.kryptonPanel3.Name = "kryptonPanel3";
            this.kryptonPanel3.Size = new System.Drawing.Size(393, 53);
            this.kryptonPanel3.TabIndex = 5;
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(154, 14);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(85, 25);
            this.btnPreview.TabIndex = 4;
            this.btnPreview.Values.Text = "Preview";
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(248, 14);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(85, 25);
            this.btncancel.TabIndex = 3;
            this.btncancel.Values.Text = "Cancel";
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(59, 14);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(85, 25);
            this.btnsave.TabIndex = 2;
            this.btnsave.Values.Text = "Submit";
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // kryptonPanel4
            // 
            this.kryptonPanel4.Controls.Add(this.cmbCustomer);
            this.kryptonPanel4.Controls.Add(this.cmbRootName);
            this.kryptonPanel4.Controls.Add(this.lblCustomer);
            this.kryptonPanel4.Controls.Add(this.lblRootName);
            this.kryptonPanel4.Location = new System.Drawing.Point(3, 50);
            this.kryptonPanel4.Name = "kryptonPanel4";
            this.kryptonPanel4.Size = new System.Drawing.Size(393, 70);
            this.kryptonPanel4.TabIndex = 4;
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCustomer.DropDownWidth = 127;
            this.cmbCustomer.Location = new System.Drawing.Point(158, 38);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(190, 21);
            this.cmbCustomer.TabIndex = 8;
            // 
            // cmbRootName
            // 
            this.cmbRootName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRootName.DropDownWidth = 127;
            this.cmbRootName.Location = new System.Drawing.Point(158, 11);
            this.cmbRootName.Name = "cmbRootName";
            this.cmbRootName.Size = new System.Drawing.Size(190, 21);
            this.cmbRootName.TabIndex = 7;
            this.cmbRootName.SelectionChangeCommitted += new System.EventHandler(this.cmbRootName_SelectionChangeCommitted);
            // 
            // lblCustomer
            // 
            this.lblCustomer.Location = new System.Drawing.Point(54, 39);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(63, 20);
            this.lblCustomer.TabIndex = 5;
            this.lblCustomer.Values.Text = "Customer";
            // 
            // lblRootName
            // 
            this.lblRootName.Location = new System.Drawing.Point(44, 11);
            this.lblRootName.Name = "lblRootName";
            this.lblRootName.Size = new System.Drawing.Size(73, 20);
            this.lblRootName.TabIndex = 4;
            this.lblRootName.Values.Text = "Root Name";
            // 
            // kryptonPanel7
            // 
            this.kryptonPanel7.Controls.Add(this.optdelete);
            this.kryptonPanel7.Controls.Add(this.optupdate);
            this.kryptonPanel7.Controls.Add(this.optadd);
            this.kryptonPanel7.Location = new System.Drawing.Point(3, 3);
            this.kryptonPanel7.Name = "kryptonPanel7";
            this.kryptonPanel7.Size = new System.Drawing.Size(393, 41);
            this.kryptonPanel7.TabIndex = 1;
            // 
            // optdelete
            // 
            this.optdelete.Location = new System.Drawing.Point(255, 10);
            this.optdelete.Name = "optdelete";
            this.optdelete.Size = new System.Drawing.Size(62, 20);
            this.optdelete.TabIndex = 5;
            this.optdelete.Values.Text = "DELETE";
            this.optdelete.Visible = false;
            this.optdelete.CheckedChanged += new System.EventHandler(this.optdelete_CheckedChanged);
            // 
            // optupdate
            // 
            this.optupdate.Location = new System.Drawing.Point(156, 10);
            this.optupdate.Name = "optupdate";
            this.optupdate.Size = new System.Drawing.Size(67, 20);
            this.optupdate.TabIndex = 4;
            this.optupdate.Values.Text = "UPDATE";
            this.optupdate.CheckedChanged += new System.EventHandler(this.optupdate_CheckedChanged);
            // 
            // optadd
            // 
            this.optadd.Location = new System.Drawing.Point(76, 10);
            this.optadd.Name = "optadd";
            this.optadd.Size = new System.Drawing.Size(48, 20);
            this.optadd.TabIndex = 0;
            this.optadd.Values.Text = "ADD";
            this.optadd.CheckedChanged += new System.EventHandler(this.optadd_CheckedChanged);
            // 
            // FRM_ROOTTRANSACTION
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 191);
            this.Controls.Add(this.kryptonPanel);
            this.Name = "FRM_ROOTTRANSACTION";
            this.Text = "FRM_ROOTTRANSACTION";
            this.Load += new System.EventHandler(this.FRM_ROOTTRANSACTION_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).EndInit();
            this.kryptonPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).EndInit();
            this.kryptonPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel4)).EndInit();
            this.kryptonPanel4.ResumeLayout(false);
            this.kryptonPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbRootName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel7)).EndInit();
            this.kryptonPanel7.ResumeLayout(false);
            this.kryptonPanel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel7;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton optdelete;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton optupdate;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton optadd;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel4;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cmbCustomer;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cmbRootName;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblCustomer;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblRootName;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel3;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnPreview;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btncancel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnsave;
        private AC.ExtendedRenderer.Toolkit.KryptonListView lvw;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnUp;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnDown;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSavePosition;
    }
}

