namespace BILLING_SYSTEM
{
    partial class frm_Check_Invoice
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
            this.chkSelectAll = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.btnPass = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.rbExpence = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.rbPurchase = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.rbSales = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.lvw = new AC.ExtendedRenderer.Toolkit.KryptonListView();
            this.dtpDate = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
            this.kryptonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel
            // 
            this.kryptonPanel.Controls.Add(this.chkSelectAll);
            this.kryptonPanel.Controls.Add(this.btnPass);
            this.kryptonPanel.Controls.Add(this.kryptonPanel1);
            this.kryptonPanel.Controls.Add(this.lvw);
            this.kryptonPanel.Controls.Add(this.dtpDate);
            this.kryptonPanel.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel.Name = "kryptonPanel";
            this.kryptonPanel.Size = new System.Drawing.Size(482, 367);
            this.kryptonPanel.TabIndex = 0;
            // 
            // chkSelectAll
            // 
            this.chkSelectAll.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl;
            this.chkSelectAll.Location = new System.Drawing.Point(12, 99);
            this.chkSelectAll.Name = "chkSelectAll";
            this.chkSelectAll.Size = new System.Drawing.Size(73, 20);
            this.chkSelectAll.TabIndex = 14;
            this.chkSelectAll.Text = "Select All";
            this.chkSelectAll.Values.Text = "Select All";
            this.chkSelectAll.CheckedChanged += new System.EventHandler(this.chkSelectAll_CheckedChanged);
            // 
            // btnPass
            // 
            this.btnPass.Location = new System.Drawing.Point(296, 71);
            this.btnPass.Name = "btnPass";
            this.btnPass.Size = new System.Drawing.Size(90, 25);
            this.btnPass.TabIndex = 13;
            this.btnPass.Values.Text = "PASS";
            this.btnPass.Click += new System.EventHandler(this.btnPass_Click);
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.rbExpence);
            this.kryptonPanel1.Controls.Add(this.rbPurchase);
            this.kryptonPanel1.Controls.Add(this.rbSales);
            this.kryptonPanel1.Location = new System.Drawing.Point(3, 12);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(476, 54);
            this.kryptonPanel1.TabIndex = 12;
            // 
            // rbExpence
            // 
            this.rbExpence.Location = new System.Drawing.Point(321, 17);
            this.rbExpence.Name = "rbExpence";
            this.rbExpence.Size = new System.Drawing.Size(72, 20);
            this.rbExpence.TabIndex = 14;
            this.rbExpence.Values.Text = "EXPENCE";
            this.rbExpence.CheckedChanged += new System.EventHandler(this.rbExpence_CheckedChanged);
            // 
            // rbPurchase
            // 
            this.rbPurchase.Location = new System.Drawing.Point(201, 17);
            this.rbPurchase.Name = "rbPurchase";
            this.rbPurchase.Size = new System.Drawing.Size(83, 20);
            this.rbPurchase.TabIndex = 13;
            this.rbPurchase.Values.Text = "PURCHASE";
            this.rbPurchase.CheckedChanged += new System.EventHandler(this.rbPurchase_CheckedChanged);
            // 
            // rbSales
            // 
            this.rbSales.Location = new System.Drawing.Point(84, 17);
            this.rbSales.Name = "rbSales";
            this.rbSales.Size = new System.Drawing.Size(56, 20);
            this.rbSales.TabIndex = 12;
            this.rbSales.Values.Text = "SALES";
            this.rbSales.CheckedChanged += new System.EventHandler(this.rbSales_CheckedChanged);
            // 
            // lvw
            // 
            this.lvw.AutoSizeLastColumn = true;
            this.lvw.CheckBoxes = true;
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
            this.lvw.Location = new System.Drawing.Point(12, 125);
            this.lvw.Name = "lvw";
            this.lvw.OwnerDraw = true;
            this.lvw.PersistentColors = false;
            this.lvw.SelectEntireRowOnSubItem = true;
            this.lvw.Size = new System.Drawing.Size(458, 230);
            this.lvw.TabIndex = 9;
            this.lvw.TabStop = false;
            this.lvw.UseCompatibleStateImageBehavior = false;
            this.lvw.UseStyledColors = false;
            this.lvw.SelectedIndexChanged += new System.EventHandler(this.lvw_SelectedIndexChanged);
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "dd-MM-yyyy";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(158, 72);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(122, 21);
            this.dtpDate.TabIndex = 1;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(96, 73);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(46, 20);
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "DATE :";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 48);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem1.Text = "Show";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // frm_Check_Invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 367);
            this.Controls.Add(this.kryptonPanel);
            this.Name = "frm_Check_Invoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "APPROVE INVOICE";
            this.Load += new System.EventHandler(this.frm_Check_Invoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).EndInit();
            this.kryptonPanel.ResumeLayout(false);
            this.kryptonPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtpDate;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private AC.ExtendedRenderer.Toolkit.KryptonListView lvw;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox chkSelectAll;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnPass;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton rbPurchase;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton rbSales;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton rbExpence;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}

