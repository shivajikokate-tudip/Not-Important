namespace BILLING_SYSTEM
{
    partial class FRM_MAIN
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
            this.kryptonPanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.Main_Panel = new ComponentFactory.Krypton.Toolkit.KryptonSplitContainer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.masterToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.productMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SubItemMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.talukaMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Thememenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cmpanddate = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.masterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parlimentoryMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assemblyMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pollingStationMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voterMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pollingDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pollingOtherDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uPLOADDATAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.kryptonContextMenu1 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenu();
            this.kryptonContextMenuItems1 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems();
            this.kryptonContextMenuItem1 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem();
            this.kryptonContextMenu2 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenu();
            this.kryptonContextMenuItems2 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems();
            this.kryptonContextMenuItem2 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
            this.kryptonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Main_Panel)).BeginInit();
            this.Main_Panel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel
            // 
            this.kryptonPanel.Controls.Add(this.Main_Panel);
            this.kryptonPanel.Controls.Add(this.menuStrip1);
            this.kryptonPanel.Controls.Add(this.cmpanddate);
            this.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel.Name = "kryptonPanel";
            this.kryptonPanel.Size = new System.Drawing.Size(758, 567);
            this.kryptonPanel.TabIndex = 0;
            // 
            // Main_Panel
            // 
            this.Main_Panel.Cursor = System.Windows.Forms.Cursors.Default;
            this.Main_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main_Panel.Location = new System.Drawing.Point(0, 24);
            this.Main_Panel.Name = "Main_Panel";
            // 
            // Main_Panel.Panel2
            // 
            this.Main_Panel.Panel2.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.Main_Panel.Panel2.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.Main_Panel_Panel2_ControlAdded);
            this.Main_Panel.Panel2.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.Main_Panel_Panel2_ControlRemoved);
            this.Main_Panel.Size = new System.Drawing.Size(758, 518);
            this.Main_Panel.SplitterDistance = 674;
            this.Main_Panel.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masterToolStripMenuItem1,
            this.transactionToolStripMenuItem1,
            this.reportToolStripMenuItem,
            this.toolsToolStripMenuItem1,
            this.exitToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(758, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // masterToolStripMenuItem1
            // 
            this.masterToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productMasterToolStripMenuItem,
            this.SubItemMasterToolStripMenuItem,
            this.talukaMasterToolStripMenuItem});
            this.masterToolStripMenuItem1.Name = "masterToolStripMenuItem1";
            this.masterToolStripMenuItem1.Size = new System.Drawing.Size(55, 20);
            this.masterToolStripMenuItem1.Text = "Master";
            // 
            // productMasterToolStripMenuItem
            // 
            this.productMasterToolStripMenuItem.Name = "productMasterToolStripMenuItem";
            this.productMasterToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.productMasterToolStripMenuItem.Tag = "FRM_ProductMaster";
            this.productMasterToolStripMenuItem.Text = "Product Master";
            // 
            // SubItemMasterToolStripMenuItem
            // 
            this.SubItemMasterToolStripMenuItem.Name = "SubItemMasterToolStripMenuItem";
            this.SubItemMasterToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.SubItemMasterToolStripMenuItem.Tag = "FRM_SUBITEMMASTER";
            this.SubItemMasterToolStripMenuItem.Text = "SubItem Master";
            // 
            // talukaMasterToolStripMenuItem
            // 
            this.talukaMasterToolStripMenuItem.Name = "talukaMasterToolStripMenuItem";
            this.talukaMasterToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.talukaMasterToolStripMenuItem.Tag = "FRM_TALUKAMASTER";
            this.talukaMasterToolStripMenuItem.Text = "Taluka Master";
            // 
            // transactionToolStripMenuItem1
            // 
            this.transactionToolStripMenuItem1.Name = "transactionToolStripMenuItem1";
            this.transactionToolStripMenuItem1.Size = new System.Drawing.Size(81, 20);
            this.transactionToolStripMenuItem1.Text = "Transaction";
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // toolsToolStripMenuItem1
            // 
            this.toolsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Thememenu});
            this.toolsToolStripMenuItem1.Name = "toolsToolStripMenuItem1";
            this.toolsToolStripMenuItem1.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem1.Text = "Tools";
            // 
            // Thememenu
            // 
            this.Thememenu.Name = "Thememenu";
            this.Thememenu.Size = new System.Drawing.Size(111, 22);
            this.Thememenu.Tag = "Frm_Colour_Theme";
            this.Thememenu.Text = "Theme";
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // cmpanddate
            // 
            this.cmpanddate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cmpanddate.Location = new System.Drawing.Point(0, 542);
            this.cmpanddate.Name = "cmpanddate";
            this.cmpanddate.Size = new System.Drawing.Size(758, 25);
            this.cmpanddate.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmpanddate.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmpanddate.TabIndex = 2;
            this.cmpanddate.Values.Heading = "Developed By :- HOTSPOT SOLUTION PVT.LTD.";
            this.cmpanddate.Values.Image = null;
            // 
            // masterToolStripMenuItem
            // 
            this.masterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formToolStripMenuItem,
            this.parlimentoryMasterToolStripMenuItem,
            this.assemblyMasterToolStripMenuItem,
            this.pollingStationMasterToolStripMenuItem,
            this.voterMasterToolStripMenuItem});
            this.masterToolStripMenuItem.Name = "masterToolStripMenuItem";
            this.masterToolStripMenuItem.Size = new System.Drawing.Size(74, 27);
            this.masterToolStripMenuItem.Text = "Master";
            // 
            // formToolStripMenuItem
            // 
            this.formToolStripMenuItem.Name = "formToolStripMenuItem";
            this.formToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.formToolStripMenuItem.Text = "form";
            this.formToolStripMenuItem.Visible = false;
            this.formToolStripMenuItem.Click += new System.EventHandler(this.formToolStripMenuItem_Click);
            // 
            // parlimentoryMasterToolStripMenuItem
            // 
            this.parlimentoryMasterToolStripMenuItem.Name = "parlimentoryMasterToolStripMenuItem";
            this.parlimentoryMasterToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.parlimentoryMasterToolStripMenuItem.Text = "Parlimentory Master";
            this.parlimentoryMasterToolStripMenuItem.Click += new System.EventHandler(this.parlimentoryMasterToolStripMenuItem_Click);
            // 
            // assemblyMasterToolStripMenuItem
            // 
            this.assemblyMasterToolStripMenuItem.Name = "assemblyMasterToolStripMenuItem";
            this.assemblyMasterToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.assemblyMasterToolStripMenuItem.Text = "Assembly Master";
            this.assemblyMasterToolStripMenuItem.Click += new System.EventHandler(this.assemblyMasterToolStripMenuItem_Click);
            // 
            // pollingStationMasterToolStripMenuItem
            // 
            this.pollingStationMasterToolStripMenuItem.Name = "pollingStationMasterToolStripMenuItem";
            this.pollingStationMasterToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.pollingStationMasterToolStripMenuItem.Text = "Polling Station Master";
            this.pollingStationMasterToolStripMenuItem.Click += new System.EventHandler(this.pollingStationMasterToolStripMenuItem_Click);
            // 
            // voterMasterToolStripMenuItem
            // 
            this.voterMasterToolStripMenuItem.Name = "voterMasterToolStripMenuItem";
            this.voterMasterToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.voterMasterToolStripMenuItem.Text = "Voter Master";
            this.voterMasterToolStripMenuItem.Click += new System.EventHandler(this.voterMasterToolStripMenuItem_Click);
            // 
            // transactionToolStripMenuItem
            // 
            this.transactionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pollingDetailsToolStripMenuItem,
            this.pollingOtherDetailsToolStripMenuItem,
            this.uPLOADDATAToolStripMenuItem});
            this.transactionToolStripMenuItem.Name = "transactionToolStripMenuItem";
            this.transactionToolStripMenuItem.Size = new System.Drawing.Size(110, 27);
            this.transactionToolStripMenuItem.Text = "Transaction";
            // 
            // pollingDetailsToolStripMenuItem
            // 
            this.pollingDetailsToolStripMenuItem.Name = "pollingDetailsToolStripMenuItem";
            this.pollingDetailsToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.pollingDetailsToolStripMenuItem.Text = "Polling Details";
            this.pollingDetailsToolStripMenuItem.Click += new System.EventHandler(this.pollingDetailsToolStripMenuItem_Click);
            // 
            // pollingOtherDetailsToolStripMenuItem
            // 
            this.pollingOtherDetailsToolStripMenuItem.Name = "pollingOtherDetailsToolStripMenuItem";
            this.pollingOtherDetailsToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.pollingOtherDetailsToolStripMenuItem.Text = "Polling Other Details";
            this.pollingOtherDetailsToolStripMenuItem.Visible = false;
            // 
            // uPLOADDATAToolStripMenuItem
            // 
            this.uPLOADDATAToolStripMenuItem.Name = "uPLOADDATAToolStripMenuItem";
            this.uPLOADDATAToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.uPLOADDATAToolStripMenuItem.Text = "UPLOADDATA";
            this.uPLOADDATAToolStripMenuItem.Click += new System.EventHandler(this.uPLOADDATAToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(80, 27);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.themeToolStripMenuItem1});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(62, 27);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // themeToolStripMenuItem1
            // 
            this.themeToolStripMenuItem1.Name = "themeToolStripMenuItem1";
            this.themeToolStripMenuItem1.Size = new System.Drawing.Size(111, 22);
            this.themeToolStripMenuItem1.Text = "Theme";
            this.themeToolStripMenuItem1.Click += new System.EventHandler(this.themeToolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(49, 27);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // kryptonContextMenu1
            // 
            this.kryptonContextMenu1.Items.AddRange(new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItemBase[] {
            this.kryptonContextMenuItems1});
            // 
            // kryptonContextMenuItems1
            // 
            this.kryptonContextMenuItems1.Items.AddRange(new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItemBase[] {
            this.kryptonContextMenuItem1});
            // 
            // kryptonContextMenuItem1
            // 
            this.kryptonContextMenuItem1.Text = "VIEW RECORD";
            this.kryptonContextMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // kryptonContextMenu2
            // 
            this.kryptonContextMenu2.Items.AddRange(new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItemBase[] {
            this.kryptonContextMenuItems2});
            // 
            // kryptonContextMenuItems2
            // 
            this.kryptonContextMenuItems2.Items.AddRange(new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItemBase[] {
            this.kryptonContextMenuItem2});
            // 
            // kryptonContextMenuItem2
            // 
            this.kryptonContextMenuItem2.Text = "VIEW RECORD";
            this.kryptonContextMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // FRM_MAIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 567);
            this.Controls.Add(this.kryptonPanel);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FRM_MAIN";
            this.Text = "Frm_Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Main_FormClosing);
            this.Load += new System.EventHandler(this.Frm_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).EndInit();
            this.kryptonPanel.ResumeLayout(false);
            this.kryptonPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Main_Panel)).EndInit();
            this.Main_Panel.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonSplitContainer Main_Panel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader cmpanddate;
        private System.Windows.Forms.ToolStripMenuItem masterToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem formToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem themeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem parlimentoryMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assemblyMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pollingStationMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voterMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pollingDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pollingOtherDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uPLOADDATAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masterToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem transactionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem1;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenu kryptonContextMenu1;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems kryptonContextMenuItems1;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem kryptonContextMenuItem1;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenu kryptonContextMenu2;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems kryptonContextMenuItems2;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem kryptonContextMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem productMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Thememenu;
        private System.Windows.Forms.ToolStripMenuItem SubItemMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem talukaMasterToolStripMenuItem;
    }
}

