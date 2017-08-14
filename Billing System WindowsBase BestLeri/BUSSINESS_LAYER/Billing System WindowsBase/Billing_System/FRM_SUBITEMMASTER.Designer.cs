namespace BILLING_SYSTEM
{
    partial class FRM_SUBITEMMASTER
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
            this.txtSubItemId = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnSubmit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnPrint = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnExit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.cmbMeasurment = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.lblUnitOfMeasurment = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtRate = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblRate = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtSubItem = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.cmbItem = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.lblSubItem = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblItem = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.optdelete = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.optedit = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.optadd = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.kryptonPanel3 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.lvw = new AC.ExtendedRenderer.Toolkit.KryptonListView();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
            this.kryptonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel4)).BeginInit();
            this.kryptonPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMeasurment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).BeginInit();
            this.kryptonPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel
            // 
            this.kryptonPanel.Controls.Add(this.kryptonPanel4);
            this.kryptonPanel.Controls.Add(this.kryptonPanel2);
            this.kryptonPanel.Controls.Add(this.kryptonPanel1);
            this.kryptonPanel.Controls.Add(this.kryptonPanel3);
            this.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel.Name = "kryptonPanel";
            this.kryptonPanel.Size = new System.Drawing.Size(678, 220);
            this.kryptonPanel.TabIndex = 0;
            // 
            // kryptonPanel4
            // 
            this.kryptonPanel4.Controls.Add(this.txtSubItemId);
            this.kryptonPanel4.Controls.Add(this.btnSubmit);
            this.kryptonPanel4.Controls.Add(this.btnPrint);
            this.kryptonPanel4.Controls.Add(this.btnExit);
            this.kryptonPanel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel4.Location = new System.Drawing.Point(0, 176);
            this.kryptonPanel4.Name = "kryptonPanel4";
            this.kryptonPanel4.Size = new System.Drawing.Size(356, 44);
            this.kryptonPanel4.TabIndex = 13;
            // 
            // txtSubItemId
            // 
            this.txtSubItemId.Location = new System.Drawing.Point(12, 8);
            this.txtSubItemId.Name = "txtSubItemId";
            this.txtSubItemId.Size = new System.Drawing.Size(61, 20);
            this.txtSubItemId.TabIndex = 11;
            this.txtSubItemId.Visible = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(91, 8);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(80, 27);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Values.Text = "Submit";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(177, 8);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(80, 27);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Values.Text = "Print";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(263, 8);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 27);
            this.btnExit.TabIndex = 6;
            this.btnExit.Values.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.cmbMeasurment);
            this.kryptonPanel2.Controls.Add(this.lblUnitOfMeasurment);
            this.kryptonPanel2.Controls.Add(this.txtRate);
            this.kryptonPanel2.Controls.Add(this.lblRate);
            this.kryptonPanel2.Controls.Add(this.txtSubItem);
            this.kryptonPanel2.Controls.Add(this.cmbItem);
            this.kryptonPanel2.Controls.Add(this.lblSubItem);
            this.kryptonPanel2.Controls.Add(this.lblItem);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 41);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(356, 179);
            this.kryptonPanel2.TabIndex = 1;
            // 
            // cmbMeasurment
            // 
            this.cmbMeasurment.DropDownWidth = 148;
            this.cmbMeasurment.Location = new System.Drawing.Point(129, 37);
            this.cmbMeasurment.Name = "cmbMeasurment";
            this.cmbMeasurment.Size = new System.Drawing.Size(168, 21);
            this.cmbMeasurment.TabIndex = 10;
            // 
            // lblUnitOfMeasurment
            // 
            this.lblUnitOfMeasurment.Location = new System.Drawing.Point(21, 38);
            this.lblUnitOfMeasurment.Name = "lblUnitOfMeasurment";
            this.lblUnitOfMeasurment.Size = new System.Drawing.Size(79, 20);
            this.lblUnitOfMeasurment.TabIndex = 9;
            this.lblUnitOfMeasurment.Values.Text = "Measurment";
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(129, 90);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(168, 20);
            this.txtRate.TabIndex = 8;
            // 
            // lblRate
            // 
            this.lblRate.Location = new System.Drawing.Point(65, 90);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(35, 20);
            this.lblRate.TabIndex = 7;
            this.lblRate.Values.Text = "Rate";
            // 
            // txtSubItem
            // 
            this.txtSubItem.Location = new System.Drawing.Point(129, 64);
            this.txtSubItem.Name = "txtSubItem";
            this.txtSubItem.Size = new System.Drawing.Size(168, 20);
            this.txtSubItem.TabIndex = 3;
            // 
            // cmbItem
            // 
            this.cmbItem.DropDownWidth = 148;
            this.cmbItem.Location = new System.Drawing.Point(129, 10);
            this.cmbItem.Name = "cmbItem";
            this.cmbItem.Size = new System.Drawing.Size(168, 21);
            this.cmbItem.TabIndex = 2;
            // 
            // lblSubItem
            // 
            this.lblSubItem.Location = new System.Drawing.Point(41, 64);
            this.lblSubItem.Name = "lblSubItem";
            this.lblSubItem.Size = new System.Drawing.Size(59, 20);
            this.lblSubItem.TabIndex = 1;
            this.lblSubItem.Values.Text = "Sub Item";
            // 
            // lblItem
            // 
            this.lblItem.Location = new System.Drawing.Point(67, 11);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(33, 20);
            this.lblItem.TabIndex = 0;
            this.lblItem.Values.Text = "Itrm";
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.optdelete);
            this.kryptonPanel1.Controls.Add(this.optedit);
            this.kryptonPanel1.Controls.Add(this.optadd);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(356, 41);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // optdelete
            // 
            this.optdelete.Location = new System.Drawing.Point(239, 8);
            this.optdelete.Name = "optdelete";
            this.optdelete.Size = new System.Drawing.Size(62, 20);
            this.optdelete.TabIndex = 2;
            this.optdelete.Values.Text = "DELETE";
            this.optdelete.CheckedChanged += new System.EventHandler(this.optdelete_CheckedChanged);
            // 
            // optedit
            // 
            this.optedit.Location = new System.Drawing.Point(141, 8);
            this.optedit.Name = "optedit";
            this.optedit.Size = new System.Drawing.Size(47, 20);
            this.optedit.TabIndex = 1;
            this.optedit.Values.Text = "EDIT";
            this.optedit.CheckedChanged += new System.EventHandler(this.optedit_CheckedChanged);
            // 
            // optadd
            // 
            this.optadd.Location = new System.Drawing.Point(38, 8);
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
            this.kryptonPanel3.Location = new System.Drawing.Point(356, 0);
            this.kryptonPanel3.Name = "kryptonPanel3";
            this.kryptonPanel3.Size = new System.Drawing.Size(322, 220);
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
            this.lvw.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvw.ForceLeftAlign = false;
            this.lvw.FullRowSelect = true;
            this.lvw.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(157)))), ((int)(((byte)(189)))));
            this.lvw.GradientMiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(196)))), ((int)(((byte)(216)))));
            this.lvw.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(232)))), ((int)(((byte)(246)))));
            this.lvw.IndendFirstItem = true;
            this.lvw.Location = new System.Drawing.Point(0, 0);
            this.lvw.Name = "lvw";
            this.lvw.OwnerDraw = true;
            this.lvw.PersistentColors = false;
            this.lvw.SelectEntireRowOnSubItem = true;
            this.lvw.Size = new System.Drawing.Size(322, 220);
            this.lvw.TabIndex = 11;
            this.lvw.UseCompatibleStateImageBehavior = false;
            this.lvw.UseStyledColors = false;
            this.lvw.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lvw_MouseUp);
            // 
            // FRM_SUBITEMMASTER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 220);
            this.Controls.Add(this.kryptonPanel);
            this.Name = "FRM_SUBITEMMASTER";
            this.Text = "FRM_SUBITEMMASTER";
            this.Load += new System.EventHandler(this.FRM_SUBITEMMASTER_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).EndInit();
            this.kryptonPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel4)).EndInit();
            this.kryptonPanel4.ResumeLayout(false);
            this.kryptonPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMeasurment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).EndInit();
            this.kryptonPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel3;
        private AC.ExtendedRenderer.Toolkit.KryptonListView lvw;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnExit;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnPrint;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSubmit;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtSubItem;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cmbItem;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblSubItem;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblItem;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton optdelete;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton optedit;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton optadd;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cmbMeasurment;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblUnitOfMeasurment;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtRate;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblRate;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel4;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtSubItemId;
    }
}

