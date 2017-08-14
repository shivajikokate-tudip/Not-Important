namespace BILLING_SYSTEM
{
    partial class FRM_PERMISSION
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
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btnLeft = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnRight = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnSaveToDB = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonPanel4 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.lvw = new AC.ExtendedRenderer.Toolkit.KryptonListView();
            this.kryptonPanel3 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.lvw_menu = new AC.ExtendedRenderer.Toolkit.KryptonListView();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.lblUserName = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmbUserName = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
            this.kryptonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel4)).BeginInit();
            this.kryptonPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).BeginInit();
            this.kryptonPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbUserName)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel
            // 
            this.kryptonPanel.Controls.Add(this.kryptonPanel1);
            this.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel.Name = "kryptonPanel";
            this.kryptonPanel.Size = new System.Drawing.Size(727, 410);
            this.kryptonPanel.TabIndex = 0;
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.btnLeft);
            this.kryptonPanel1.Controls.Add(this.btnRight);
            this.kryptonPanel1.Controls.Add(this.btnSaveToDB);
            this.kryptonPanel1.Controls.Add(this.btnCancel);
            this.kryptonPanel1.Controls.Add(this.kryptonPanel4);
            this.kryptonPanel1.Controls.Add(this.kryptonPanel3);
            this.kryptonPanel1.Controls.Add(this.kryptonPanel2);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.kryptonPanel1.Size = new System.Drawing.Size(727, 410);
            this.kryptonPanel1.TabIndex = 1;
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(385, 135);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(41, 25);
            this.btnLeft.TabIndex = 7;
            this.btnLeft.Values.Text = "<<";
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(385, 104);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(41, 25);
            this.btnRight.TabIndex = 6;
            this.btnRight.Values.Text = ">>";
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnSaveToDB
            // 
            this.btnSaveToDB.Location = new System.Drawing.Point(438, 324);
            this.btnSaveToDB.Name = "btnSaveToDB";
            this.btnSaveToDB.Size = new System.Drawing.Size(277, 36);
            this.btnSaveToDB.TabIndex = 4;
            this.btnSaveToDB.Values.Text = "Save To DB";
            this.btnSaveToDB.Click += new System.EventHandler(this.btnSaveToDB_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(438, 366);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(277, 36);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Values.Text = "&Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // kryptonPanel4
            // 
            this.kryptonPanel4.Controls.Add(this.lvw);
            this.kryptonPanel4.Location = new System.Drawing.Point(438, 67);
            this.kryptonPanel4.Name = "kryptonPanel4";
            this.kryptonPanel4.Padding = new System.Windows.Forms.Padding(5);
            this.kryptonPanel4.Size = new System.Drawing.Size(277, 251);
            this.kryptonPanel4.TabIndex = 5;
            // 
            // lvw
            // 
            this.lvw.AutoSizeLastColumn = true;
            this.lvw.CheckBoxes = true;
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
            this.lvw.Location = new System.Drawing.Point(5, 5);
            this.lvw.Name = "lvw";
            this.lvw.OwnerDraw = true;
            this.lvw.PersistentColors = false;
            this.lvw.SelectEntireRowOnSubItem = true;
            this.lvw.Size = new System.Drawing.Size(267, 241);
            this.lvw.TabIndex = 2;
            this.lvw.UseCompatibleStateImageBehavior = false;
            this.lvw.UseStyledColors = false;
            // 
            // kryptonPanel3
            // 
            this.kryptonPanel3.Controls.Add(this.lvw_menu);
            this.kryptonPanel3.Location = new System.Drawing.Point(11, 67);
            this.kryptonPanel3.Name = "kryptonPanel3";
            this.kryptonPanel3.Padding = new System.Windows.Forms.Padding(5);
            this.kryptonPanel3.Size = new System.Drawing.Size(360, 335);
            this.kryptonPanel3.TabIndex = 4;
            // 
            // lvw_menu
            // 
            this.lvw_menu.AutoSizeLastColumn = true;
            this.lvw_menu.CheckBoxes = true;
            this.lvw_menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvw_menu.EnableHeaderGlow = false;
            this.lvw_menu.EnableHeaderHotTrack = false;
            this.lvw_menu.EnableHeaderRendering = false;
            this.lvw_menu.EnableSorting = true;
            this.lvw_menu.EnableVistaCheckBoxes = true;
            this.lvw_menu.ForceLeftAlign = false;
            this.lvw_menu.FullRowSelect = true;
            this.lvw_menu.GradientEndColor = System.Drawing.Color.Gray;
            this.lvw_menu.GradientMiddleColor = System.Drawing.Color.LightGray;
            this.lvw_menu.GradientStartColor = System.Drawing.Color.White;
            this.lvw_menu.IndendFirstItem = true;
            this.lvw_menu.Location = new System.Drawing.Point(5, 5);
            this.lvw_menu.Name = "lvw_menu";
            this.lvw_menu.OwnerDraw = true;
            this.lvw_menu.PersistentColors = false;
            this.lvw_menu.SelectEntireRowOnSubItem = true;
            this.lvw_menu.Size = new System.Drawing.Size(350, 325);
            this.lvw_menu.TabIndex = 1;
            this.lvw_menu.UseCompatibleStateImageBehavior = false;
            this.lvw_menu.UseStyledColors = false;
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.lblUserName);
            this.kryptonPanel2.Controls.Add(this.cmbUserName);
            this.kryptonPanel2.Location = new System.Drawing.Point(12, 12);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Padding = new System.Windows.Forms.Padding(5);
            this.kryptonPanel2.Size = new System.Drawing.Size(703, 49);
            this.kryptonPanel2.TabIndex = 3;
            // 
            // lblUserName
            // 
            this.lblUserName.Location = new System.Drawing.Point(74, 14);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(71, 20);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Values.Text = "User Name";
            // 
            // cmbUserName
            // 
            this.cmbUserName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUserName.DropDownWidth = 121;
            this.cmbUserName.Location = new System.Drawing.Point(171, 14);
            this.cmbUserName.Name = "cmbUserName";
            this.cmbUserName.Size = new System.Drawing.Size(457, 21);
            this.cmbUserName.TabIndex = 0;
            this.cmbUserName.SelectionChangeCommitted += new System.EventHandler(this.cmbUserName_SelectionChangeCommitted);
            // 
            // FRM_PERMISSION
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 410);
            this.Controls.Add(this.kryptonPanel);
            this.Name = "FRM_PERMISSION";
            this.Text = "USER AND GROUP LEVEL PERMISSION";
            this.Load += new System.EventHandler(this.FRM_PERMISSION_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).EndInit();
            this.kryptonPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel4)).EndInit();
            this.kryptonPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).EndInit();
            this.kryptonPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbUserName)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSaveToDB;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCancel;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel4;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel3;
        private AC.ExtendedRenderer.Toolkit.KryptonListView lvw_menu;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cmbUserName;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblUserName;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnLeft;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnRight;
        private AC.ExtendedRenderer.Toolkit.KryptonListView lvw;
    }
}

