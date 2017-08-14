namespace BILLING_SYSTEM
{
    partial class FRM_ProductMaster
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
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.sagarLayoutPanel2 = new BILLING_SYSTEM.SagarLayoutPanel(this.components);
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtproductname = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonPanel3 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.txtproductid = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btncancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnsave = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.sagarLayoutPanel1 = new BILLING_SYSTEM.SagarLayoutPanel(this.components);
            this.optupdate = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.optdelete = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.optadd = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.kryptonPanel4 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.lvw = new AC.ExtendedRenderer.Toolkit.KryptonListView();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
            this.kryptonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            this.sagarLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).BeginInit();
            this.kryptonPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.sagarLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel4)).BeginInit();
            this.kryptonPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel
            // 
            this.kryptonPanel.Controls.Add(this.kryptonPanel2);
            this.kryptonPanel.Controls.Add(this.kryptonPanel3);
            this.kryptonPanel.Controls.Add(this.kryptonPanel1);
            this.kryptonPanel.Controls.Add(this.kryptonPanel4);
            this.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel.Name = "kryptonPanel";
            this.kryptonPanel.Size = new System.Drawing.Size(573, 145);
            this.kryptonPanel.TabIndex = 0;
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.sagarLayoutPanel2);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 45);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(300, 47);
            this.kryptonPanel2.TabIndex = 1;
            // 
            // sagarLayoutPanel2
            // 
            this.sagarLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.sagarLayoutPanel2.ColumnCount = 2;
            this.sagarLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.sagarLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.sagarLayoutPanel2.Controls.Add(this.kryptonLabel1, 0, 0);
            this.sagarLayoutPanel2.Controls.Add(this.txtproductname, 1, 0);
            this.sagarLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sagarLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.sagarLayoutPanel2.Margin = new System.Windows.Forms.Padding(5);
            this.sagarLayoutPanel2.Name = "sagarLayoutPanel2";
            this.sagarLayoutPanel2.Padding = new System.Windows.Forms.Padding(5);
            this.sagarLayoutPanel2.RowCount = 1;
            this.sagarLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.sagarLayoutPanel2.Size = new System.Drawing.Size(300, 47);
            this.sagarLayoutPanel2.TabIndex = 0;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonLabel1.Location = new System.Drawing.Point(10, 10);
            this.kryptonLabel1.Margin = new System.Windows.Forms.Padding(5);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(135, 27);
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "Product name";
            // 
            // txtproductname
            // 
            this.txtproductname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtproductname.Location = new System.Drawing.Point(155, 10);
            this.txtproductname.Margin = new System.Windows.Forms.Padding(5);
            this.txtproductname.Name = "txtproductname";
            this.txtproductname.Size = new System.Drawing.Size(135, 20);
            this.txtproductname.TabIndex = 1;
            // 
            // kryptonPanel3
            // 
            this.kryptonPanel3.Controls.Add(this.txtproductid);
            this.kryptonPanel3.Controls.Add(this.btncancel);
            this.kryptonPanel3.Controls.Add(this.btnsave);
            this.kryptonPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel3.Location = new System.Drawing.Point(0, 92);
            this.kryptonPanel3.Name = "kryptonPanel3";
            this.kryptonPanel3.Size = new System.Drawing.Size(300, 53);
            this.kryptonPanel3.TabIndex = 2;
            // 
            // txtproductid
            // 
            this.txtproductid.Location = new System.Drawing.Point(10, 8);
            this.txtproductid.Name = "txtproductid";
            this.txtproductid.Size = new System.Drawing.Size(60, 20);
            this.txtproductid.TabIndex = 2;
            this.txtproductid.Visible = false;
            // 
            // btncancel
            // 
            this.btncancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btncancel.Location = new System.Drawing.Point(205, 8);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(90, 33);
            this.btncancel.TabIndex = 1;
            this.btncancel.Values.Text = "Cancel";
            // 
            // btnsave
            // 
            this.btnsave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnsave.Location = new System.Drawing.Point(109, 8);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(90, 33);
            this.btnsave.TabIndex = 0;
            this.btnsave.Values.Text = "Save";
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.sagarLayoutPanel1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(300, 45);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // sagarLayoutPanel1
            // 
            this.sagarLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.sagarLayoutPanel1.ColumnCount = 3;
            this.sagarLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.sagarLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.sagarLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.sagarLayoutPanel1.Controls.Add(this.optupdate, 1, 0);
            this.sagarLayoutPanel1.Controls.Add(this.optdelete, 2, 0);
            this.sagarLayoutPanel1.Controls.Add(this.optadd, 0, 0);
            this.sagarLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sagarLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.sagarLayoutPanel1.Name = "sagarLayoutPanel1";
            this.sagarLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.sagarLayoutPanel1.RowCount = 1;
            this.sagarLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.sagarLayoutPanel1.Size = new System.Drawing.Size(300, 45);
            this.sagarLayoutPanel1.TabIndex = 0;
            // 
            // optupdate
            // 
            this.optupdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.optupdate.Location = new System.Drawing.Point(104, 8);
            this.optupdate.Name = "optupdate";
            this.optupdate.Size = new System.Drawing.Size(90, 29);
            this.optupdate.TabIndex = 1;
            this.optupdate.Values.Text = "UPDATE";
            this.optupdate.CheckedChanged += new System.EventHandler(this.opt_CheckedChanged);
            // 
            // optdelete
            // 
            this.optdelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.optdelete.Location = new System.Drawing.Point(200, 8);
            this.optdelete.Name = "optdelete";
            this.optdelete.Size = new System.Drawing.Size(92, 29);
            this.optdelete.TabIndex = 2;
            this.optdelete.Values.Text = "DELETE";
            this.optdelete.CheckedChanged += new System.EventHandler(this.opt_CheckedChanged);
            // 
            // optadd
            // 
            this.optadd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.optadd.Location = new System.Drawing.Point(8, 8);
            this.optadd.Name = "optadd";
            this.optadd.Size = new System.Drawing.Size(90, 29);
            this.optadd.TabIndex = 0;
            this.optadd.Values.Text = "ADD";
            this.optadd.CheckedChanged += new System.EventHandler(this.opt_CheckedChanged);
            // 
            // kryptonPanel4
            // 
            this.kryptonPanel4.Controls.Add(this.lvw);
            this.kryptonPanel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.kryptonPanel4.Location = new System.Drawing.Point(300, 0);
            this.kryptonPanel4.Name = "kryptonPanel4";
            this.kryptonPanel4.Padding = new System.Windows.Forms.Padding(5);
            this.kryptonPanel4.Size = new System.Drawing.Size(273, 145);
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
            this.lvw.Location = new System.Drawing.Point(5, 5);
            this.lvw.Name = "lvw";
            this.lvw.OwnerDraw = true;
            this.lvw.PersistentColors = false;
            this.lvw.SelectEntireRowOnSubItem = true;
            this.lvw.Size = new System.Drawing.Size(263, 135);
            this.lvw.TabIndex = 0;
            this.lvw.UseCompatibleStateImageBehavior = false;
            this.lvw.UseStyledColors = false;
            this.lvw.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lvw_MouseUp);
            // 
            // FRM_ProductMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 145);
            this.Controls.Add(this.kryptonPanel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_ProductMaster";
            this.Text = "Product Master";
            this.Load += new System.EventHandler(this.FRM_ProductMaster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).EndInit();
            this.kryptonPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.sagarLayoutPanel2.ResumeLayout(false);
            this.sagarLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).EndInit();
            this.kryptonPanel3.ResumeLayout(false);
            this.kryptonPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.sagarLayoutPanel1.ResumeLayout(false);
            this.sagarLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel4)).EndInit();
            this.kryptonPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel3;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel4;
        private SagarLayoutPanel sagarLayoutPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton optupdate;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton optdelete;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton optadd;
        private SagarLayoutPanel sagarLayoutPanel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtproductname;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btncancel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnsave;
        private AC.ExtendedRenderer.Toolkit.KryptonListView lvw;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtproductid;
    }
}

