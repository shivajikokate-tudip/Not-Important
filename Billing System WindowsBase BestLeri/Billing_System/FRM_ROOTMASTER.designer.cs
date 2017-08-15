namespace BILLING_SYSTEM
{
    partial class FRM_ROOTMASTER
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
            this.kryptonPanel5 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.lvw = new AC.ExtendedRenderer.Toolkit.KryptonListView();
            this.btncancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnsave = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.optdelete = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.optupdate = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.btnPreview = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.optadd = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.kryptonPanel3 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.lblSource = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonPanel4 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btnSource = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txtRoot = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.cmbDestination = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.cmbSource = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.lblRoot = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblDestination = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonPanel7 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel5)).BeginInit();
            this.kryptonPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).BeginInit();
            this.kryptonPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel4)).BeginInit();
            this.kryptonPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDestination)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel7)).BeginInit();
            this.kryptonPanel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel
            // 
            this.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel.Name = "kryptonPanel";
            this.kryptonPanel.Size = new System.Drawing.Size(777, 216);
            this.kryptonPanel.TabIndex = 0;
            // 
            // kryptonPanel5
            // 
            this.kryptonPanel5.Controls.Add(this.lvw);
            this.kryptonPanel5.Location = new System.Drawing.Point(389, 3);
            this.kryptonPanel5.Name = "kryptonPanel5";
            this.kryptonPanel5.Size = new System.Drawing.Size(384, 206);
            this.kryptonPanel5.TabIndex = 6;
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
            this.lvw.Size = new System.Drawing.Size(384, 206);
            this.lvw.TabIndex = 6;
            this.lvw.TabStop = false;
            this.lvw.UseCompatibleStateImageBehavior = false;
            this.lvw.UseStyledColors = false;
            this.lvw.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lvw_MouseUp);
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(250, 14);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(85, 25);
            this.btncancel.TabIndex = 3;
            this.btncancel.Values.Text = "Cancel";
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(45, 14);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(85, 25);
            this.btnsave.TabIndex = 2;
            this.btnsave.Values.Text = "Submit";
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // optdelete
            // 
            this.optdelete.Location = new System.Drawing.Point(241, 10);
            this.optdelete.Name = "optdelete";
            this.optdelete.Size = new System.Drawing.Size(62, 20);
            this.optdelete.TabIndex = 5;
            this.optdelete.Values.Text = "DELETE";
            this.optdelete.CheckedChanged += new System.EventHandler(this.optdelete_CheckedChanged);
            // 
            // optupdate
            // 
            this.optupdate.Location = new System.Drawing.Point(150, 10);
            this.optupdate.Name = "optupdate";
            this.optupdate.Size = new System.Drawing.Size(67, 20);
            this.optupdate.TabIndex = 4;
            this.optupdate.Values.Text = "UPDATE";
            this.optupdate.CheckedChanged += new System.EventHandler(this.optupdate_CheckedChanged);
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(148, 14);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(85, 25);
            this.btnPreview.TabIndex = 4;
            this.btnPreview.Values.Text = "Preview";
            // 
            // optadd
            // 
            this.optadd.Location = new System.Drawing.Point(78, 10);
            this.optadd.Name = "optadd";
            this.optadd.Size = new System.Drawing.Size(48, 20);
            this.optadd.TabIndex = 0;
            this.optadd.Values.Text = "ADD";
            this.optadd.CheckedChanged += new System.EventHandler(this.optadd_CheckedChanged);
            // 
            // kryptonPanel3
            // 
            this.kryptonPanel3.Controls.Add(this.btnPreview);
            this.kryptonPanel3.Controls.Add(this.btncancel);
            this.kryptonPanel3.Controls.Add(this.btnsave);
            this.kryptonPanel3.Location = new System.Drawing.Point(5, 157);
            this.kryptonPanel3.Name = "kryptonPanel3";
            this.kryptonPanel3.Size = new System.Drawing.Size(381, 53);
            this.kryptonPanel3.TabIndex = 4;
            // 
            // lblSource
            // 
            this.lblSource.Location = new System.Drawing.Point(48, 16);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(48, 20);
            this.lblSource.TabIndex = 4;
            this.lblSource.Values.Text = "Source";
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.kryptonPanel5);
            this.kryptonPanel2.Controls.Add(this.kryptonPanel3);
            this.kryptonPanel2.Controls.Add(this.kryptonPanel4);
            this.kryptonPanel2.Controls.Add(this.kryptonPanel7);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(777, 216);
            this.kryptonPanel2.TabIndex = 6;
            // 
            // kryptonPanel4
            // 
            this.kryptonPanel4.Controls.Add(this.btnSource);
            this.kryptonPanel4.Controls.Add(this.txtRoot);
            this.kryptonPanel4.Controls.Add(this.cmbDestination);
            this.kryptonPanel4.Controls.Add(this.cmbSource);
            this.kryptonPanel4.Controls.Add(this.lblRoot);
            this.kryptonPanel4.Controls.Add(this.lblDestination);
            this.kryptonPanel4.Controls.Add(this.lblSource);
            this.kryptonPanel4.Location = new System.Drawing.Point(5, 47);
            this.kryptonPanel4.Name = "kryptonPanel4";
            this.kryptonPanel4.Size = new System.Drawing.Size(381, 104);
            this.kryptonPanel4.TabIndex = 3;
            // 
            // btnSource
            // 
            this.btnSource.Location = new System.Drawing.Point(294, 15);
            this.btnSource.Name = "btnSource";
            this.btnSource.Size = new System.Drawing.Size(75, 25);
            this.btnSource.TabIndex = 10;
            this.btnSource.Values.Text = "Add";
            this.btnSource.Click += new System.EventHandler(this.btnSource_Click);
            // 
            // txtRoot
            // 
            this.txtRoot.Enabled = false;
            this.txtRoot.Location = new System.Drawing.Point(141, 69);
            this.txtRoot.Name = "txtRoot";
            this.txtRoot.Size = new System.Drawing.Size(137, 20);
            this.txtRoot.TabIndex = 9;
            // 
            // cmbDestination
            // 
            this.cmbDestination.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDestination.DropDownWidth = 127;
            this.cmbDestination.Location = new System.Drawing.Point(141, 42);
            this.cmbDestination.Name = "cmbDestination";
            this.cmbDestination.Size = new System.Drawing.Size(137, 21);
            this.cmbDestination.TabIndex = 8;
            this.cmbDestination.SelectionChangeCommitted += new System.EventHandler(this.cmbDestination_SelectionChangeCommitted);
            // 
            // cmbSource
            // 
            this.cmbSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSource.DropDownWidth = 127;
            this.cmbSource.Location = new System.Drawing.Point(141, 15);
            this.cmbSource.Name = "cmbSource";
            this.cmbSource.Size = new System.Drawing.Size(137, 21);
            this.cmbSource.TabIndex = 7;
            this.cmbSource.SelectionChangeCommitted += new System.EventHandler(this.cmbSource_SelectionChangeCommitted);
            // 
            // lblRoot
            // 
            this.lblRoot.Location = new System.Drawing.Point(59, 69);
            this.lblRoot.Name = "lblRoot";
            this.lblRoot.Size = new System.Drawing.Size(37, 20);
            this.lblRoot.TabIndex = 6;
            this.lblRoot.Values.Text = "Root";
            // 
            // lblDestination
            // 
            this.lblDestination.Location = new System.Drawing.Point(24, 43);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(73, 20);
            this.lblDestination.TabIndex = 5;
            this.lblDestination.Values.Text = "Destination";
            // 
            // kryptonPanel7
            // 
            this.kryptonPanel7.Controls.Add(this.optdelete);
            this.kryptonPanel7.Controls.Add(this.optupdate);
            this.kryptonPanel7.Controls.Add(this.optadd);
            this.kryptonPanel7.Location = new System.Drawing.Point(5, 3);
            this.kryptonPanel7.Name = "kryptonPanel7";
            this.kryptonPanel7.Size = new System.Drawing.Size(381, 41);
            this.kryptonPanel7.TabIndex = 0;
            // 
            // FRM_ROOTMASTER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 216);
            this.Controls.Add(this.kryptonPanel2);
            this.Controls.Add(this.kryptonPanel);
            this.Name = "FRM_ROOTMASTER";
            this.Text = "FRM_ROOTMASTER";
            this.Load += new System.EventHandler(this.FRM_ROOTMASTER_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel5)).EndInit();
            this.kryptonPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).EndInit();
            this.kryptonPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel4)).EndInit();
            this.kryptonPanel4.ResumeLayout(false);
            this.kryptonPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDestination)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel7)).EndInit();
            this.kryptonPanel7.ResumeLayout(false);
            this.kryptonPanel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel5;
        private AC.ExtendedRenderer.Toolkit.KryptonListView lvw;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btncancel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnsave;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton optdelete;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton optupdate;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnPreview;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton optadd;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel3;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblSource;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel4;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel7;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblRoot;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblDestination;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtRoot;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cmbDestination;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cmbSource;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSource;
    }
}

