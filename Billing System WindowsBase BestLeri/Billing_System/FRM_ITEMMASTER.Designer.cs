namespace BILLING_SYSTEM
{
    partial class FRM_ITEMMASTER
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
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.optWithoutProcess = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.optWithProcess = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.txtItemName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.cmbMeasurment = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.lblItemName = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblMeasurement = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonPanel4 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btnPreview = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txtItemid = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btncancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnsave = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.LayoutPanel1 = new BILLING_SYSTEM.SagarLayoutPanel(this.components);
            this.optupdate = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.optdelete = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.optadd = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.kryptonPanel5 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.lvw = new AC.ExtendedRenderer.Toolkit.KryptonListView();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
            this.kryptonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMeasurment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel4)).BeginInit();
            this.kryptonPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.LayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel5)).BeginInit();
            this.kryptonPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel
            // 
            this.kryptonPanel.Controls.Add(this.kryptonPanel2);
            this.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel.Name = "kryptonPanel";
            this.kryptonPanel.Size = new System.Drawing.Size(653, 208);
            this.kryptonPanel.TabIndex = 0;
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.optWithoutProcess);
            this.kryptonPanel2.Controls.Add(this.optWithProcess);
            this.kryptonPanel2.Controls.Add(this.txtItemName);
            this.kryptonPanel2.Controls.Add(this.cmbMeasurment);
            this.kryptonPanel2.Controls.Add(this.lblItemName);
            this.kryptonPanel2.Controls.Add(this.lblMeasurement);
            this.kryptonPanel2.Controls.Add(this.kryptonPanel4);
            this.kryptonPanel2.Controls.Add(this.kryptonPanel1);
            this.kryptonPanel2.Controls.Add(this.kryptonPanel5);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(653, 208);
            this.kryptonPanel2.TabIndex = 1;
            // 
            // optWithoutProcess
            // 
            this.optWithoutProcess.Location = new System.Drawing.Point(184, 55);
            this.optWithoutProcess.Name = "optWithoutProcess";
            this.optWithoutProcess.Size = new System.Drawing.Size(111, 20);
            this.optWithoutProcess.TabIndex = 7;
            this.optWithoutProcess.Values.Text = "Without Process";
            // 
            // optWithProcess
            // 
            this.optWithProcess.Location = new System.Drawing.Point(51, 55);
            this.optWithProcess.Name = "optWithProcess";
            this.optWithProcess.Size = new System.Drawing.Size(93, 20);
            this.optWithProcess.TabIndex = 6;
            this.optWithProcess.Values.Text = "With Process";
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(159, 124);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(137, 20);
            this.txtItemName.TabIndex = 2;
            // 
            // cmbMeasurment
            // 
            this.cmbMeasurment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMeasurment.DropDownWidth = 127;
            this.cmbMeasurment.Location = new System.Drawing.Point(159, 91);
            this.cmbMeasurment.Name = "cmbMeasurment";
            this.cmbMeasurment.Size = new System.Drawing.Size(136, 21);
            this.cmbMeasurment.TabIndex = 1;
            // 
            // lblItemName
            // 
            this.lblItemName.Location = new System.Drawing.Point(27, 123);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(71, 20);
            this.lblItemName.TabIndex = 5;
            this.lblItemName.Values.Text = "Item Name";
            // 
            // lblMeasurement
            // 
            this.lblMeasurement.Location = new System.Drawing.Point(12, 92);
            this.lblMeasurement.Name = "lblMeasurement";
            this.lblMeasurement.Size = new System.Drawing.Size(86, 20);
            this.lblMeasurement.TabIndex = 4;
            this.lblMeasurement.Values.Text = "Measurement";
            // 
            // kryptonPanel4
            // 
            this.kryptonPanel4.Controls.Add(this.btnPreview);
            this.kryptonPanel4.Controls.Add(this.txtItemid);
            this.kryptonPanel4.Controls.Add(this.btncancel);
            this.kryptonPanel4.Controls.Add(this.btnsave);
            this.kryptonPanel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel4.Location = new System.Drawing.Point(0, 155);
            this.kryptonPanel4.Name = "kryptonPanel4";
            this.kryptonPanel4.Size = new System.Drawing.Size(323, 53);
            this.kryptonPanel4.TabIndex = 2;
            // 
            // btnPreview
            // 
            this.btnPreview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPreview.Location = new System.Drawing.Point(117, 10);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(90, 33);
            this.btnPreview.TabIndex = 4;
            this.btnPreview.Values.Text = "Preview";
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // txtItemid
            // 
            this.txtItemid.Location = new System.Drawing.Point(3, 3);
            this.txtItemid.Name = "txtItemid";
            this.txtItemid.Size = new System.Drawing.Size(15, 20);
            this.txtItemid.TabIndex = 2;
            this.txtItemid.Visible = false;
            // 
            // btncancel
            // 
            this.btncancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btncancel.Location = new System.Drawing.Point(209, 10);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(90, 33);
            this.btncancel.TabIndex = 5;
            this.btncancel.Values.Text = "Cancel";
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnsave
            // 
            this.btnsave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnsave.Location = new System.Drawing.Point(24, 10);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(90, 33);
            this.btnsave.TabIndex = 3;
            this.btnsave.Values.Text = "Submit";
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.LayoutPanel1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(323, 45);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // LayoutPanel1
            // 
            this.LayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.LayoutPanel1.ColumnCount = 3;
            this.LayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.LayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.33027F));
            this.LayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.33641F));
            this.LayoutPanel1.Controls.Add(this.optupdate, 1, 0);
            this.LayoutPanel1.Controls.Add(this.optdelete, 2, 0);
            this.LayoutPanel1.Controls.Add(this.optadd, 0, 0);
            this.LayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.LayoutPanel1.Name = "LayoutPanel1";
            this.LayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.LayoutPanel1.RowCount = 1;
            this.LayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LayoutPanel1.Size = new System.Drawing.Size(323, 45);
            this.LayoutPanel1.TabIndex = 0;
            // 
            // optupdate
            // 
            this.optupdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.optupdate.Location = new System.Drawing.Point(112, 8);
            this.optupdate.Name = "optupdate";
            this.optupdate.Size = new System.Drawing.Size(104, 29);
            this.optupdate.TabIndex = 6;
            this.optupdate.Values.Text = "UPDATE";
            this.optupdate.CheckedChanged += new System.EventHandler(this.optupdate_CheckedChanged);
            // 
            // optdelete
            // 
            this.optdelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.optdelete.Location = new System.Drawing.Point(222, 8);
            this.optdelete.Name = "optdelete";
            this.optdelete.Size = new System.Drawing.Size(93, 29);
            this.optdelete.TabIndex = 7;
            this.optdelete.Values.Text = "DELETE";
            this.optdelete.CheckedChanged += new System.EventHandler(this.optdelete_CheckedChanged);
            // 
            // optadd
            // 
            this.optadd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.optadd.Location = new System.Drawing.Point(8, 8);
            this.optadd.Name = "optadd";
            this.optadd.Size = new System.Drawing.Size(98, 29);
            this.optadd.TabIndex = 0;
            this.optadd.Values.Text = "ADD";
            this.optadd.CheckedChanged += new System.EventHandler(this.optadd_CheckedChanged);
            // 
            // kryptonPanel5
            // 
            this.kryptonPanel5.Controls.Add(this.lvw);
            this.kryptonPanel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.kryptonPanel5.Location = new System.Drawing.Point(323, 0);
            this.kryptonPanel5.Name = "kryptonPanel5";
            this.kryptonPanel5.Padding = new System.Windows.Forms.Padding(5);
            this.kryptonPanel5.Size = new System.Drawing.Size(330, 208);
            this.kryptonPanel5.TabIndex = 3;
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
            this.lvw.Location = new System.Drawing.Point(5, 5);
            this.lvw.Name = "lvw";
            this.lvw.OwnerDraw = true;
            this.lvw.PersistentColors = false;
            this.lvw.SelectEntireRowOnSubItem = true;
            this.lvw.Size = new System.Drawing.Size(320, 198);
            this.lvw.TabIndex = 7;
            this.lvw.TabStop = false;
            this.lvw.UseCompatibleStateImageBehavior = false;
            this.lvw.UseStyledColors = false;
            this.lvw.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lvw_MouseUp);
            // 
            // FRM_ITEMMASTER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 208);
            this.Controls.Add(this.kryptonPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "FRM_ITEMMASTER";
            this.Text = "ITEM MASTER";
            this.Load += new System.EventHandler(this.FRM_ITEMMASTER_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).EndInit();
            this.kryptonPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMeasurment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel4)).EndInit();
            this.kryptonPanel4.ResumeLayout(false);
            this.kryptonPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.LayoutPanel1.ResumeLayout(false);
            this.LayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel5)).EndInit();
            this.kryptonPanel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel4;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtItemid;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btncancel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnsave;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private SagarLayoutPanel LayoutPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton optupdate;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton optdelete;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton optadd;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel5;
        private AC.ExtendedRenderer.Toolkit.KryptonListView lvw;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnPreview;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtItemName;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cmbMeasurment;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblItemName;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblMeasurement;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton optWithoutProcess;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton optWithProcess;
    }
}

