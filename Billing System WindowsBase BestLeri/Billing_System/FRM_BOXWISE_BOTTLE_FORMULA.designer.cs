namespace BILLING_SYSTEM
{
    partial class FRM_BOXWISE_BOTTLE_FORMULA
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
            this.lblCustomerNumber = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonManager1 = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.optdelete = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.optedit = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.optadd = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.txtQty = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonPanel3 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.lvw = new AC.ExtendedRenderer.Toolkit.KryptonListView();
            this.kryptonPanel5 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonComboBox2 = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonComboBox1 = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.lblAddress = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblCustomerName = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonPanel4 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.txtId = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnSubmit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnPreview = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnExit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonPanel6 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonManager2 = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).BeginInit();
            this.kryptonPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel5)).BeginInit();
            this.kryptonPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel4)).BeginInit();
            this.kryptonPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel6)).BeginInit();
            this.kryptonPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel
            // 
            this.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel.Name = "kryptonPanel";
            this.kryptonPanel.Size = new System.Drawing.Size(761, 216);
            this.kryptonPanel.TabIndex = 0;
            // 
            // lblCustomerNumber
            // 
            this.lblCustomerNumber.Location = new System.Drawing.Point(38, 17);
            this.lblCustomerNumber.Name = "lblCustomerNumber";
            this.lblCustomerNumber.Size = new System.Drawing.Size(72, 20);
            this.lblCustomerNumber.TabIndex = 15;
            this.lblCustomerNumber.Values.Text = "Bottle Type";
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.optdelete);
            this.kryptonPanel1.Controls.Add(this.optedit);
            this.kryptonPanel1.Controls.Add(this.optadd);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(439, 41);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // optdelete
            // 
            this.optdelete.Location = new System.Drawing.Point(278, 9);
            this.optdelete.Name = "optdelete";
            this.optdelete.Size = new System.Drawing.Size(62, 20);
            this.optdelete.TabIndex = 11;
            this.optdelete.Values.Text = "DELETE";
            this.optdelete.CheckedChanged += new System.EventHandler(this.optdelete_CheckedChanged);
            // 
            // optedit
            // 
            this.optedit.Location = new System.Drawing.Point(180, 9);
            this.optedit.Name = "optedit";
            this.optedit.Size = new System.Drawing.Size(47, 20);
            this.optedit.TabIndex = 10;
            this.optedit.Values.Text = "EDIT";
            this.optedit.CheckedChanged += new System.EventHandler(this.optedit_CheckedChanged);
            // 
            // optadd
            // 
            this.optadd.Location = new System.Drawing.Point(77, 9);
            this.optadd.Name = "optadd";
            this.optadd.Size = new System.Drawing.Size(48, 20);
            this.optadd.TabIndex = 0;
            this.optadd.Values.Text = "ADD";
            this.optadd.CheckedChanged += new System.EventHandler(this.optadd_CheckedChanged);
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(160, 91);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(203, 20);
            this.txtQty.TabIndex = 3;
            // 
            // kryptonPanel3
            // 
            this.kryptonPanel3.Controls.Add(this.lvw);
            this.kryptonPanel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.kryptonPanel3.Location = new System.Drawing.Point(439, 0);
            this.kryptonPanel3.Name = "kryptonPanel3";
            this.kryptonPanel3.Size = new System.Drawing.Size(322, 216);
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
            this.lvw.Size = new System.Drawing.Size(322, 216);
            this.lvw.TabIndex = 12;
            this.lvw.UseCompatibleStateImageBehavior = false;
            this.lvw.UseStyledColors = false;
            this.lvw.SelectedIndexChanged += new System.EventHandler(this.lvw_SelectedIndexChanged);
            // 
            // kryptonPanel5
            // 
            this.kryptonPanel5.Controls.Add(this.kryptonComboBox2);
            this.kryptonPanel5.Controls.Add(this.kryptonComboBox1);
            this.kryptonPanel5.Controls.Add(this.lblCustomerNumber);
            this.kryptonPanel5.Controls.Add(this.txtQty);
            this.kryptonPanel5.Controls.Add(this.lblAddress);
            this.kryptonPanel5.Controls.Add(this.lblCustomerName);
            this.kryptonPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel5.Location = new System.Drawing.Point(0, 41);
            this.kryptonPanel5.Name = "kryptonPanel5";
            this.kryptonPanel5.Size = new System.Drawing.Size(439, 175);
            this.kryptonPanel5.TabIndex = 1;
            // 
            // kryptonComboBox2
            // 
            this.kryptonComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kryptonComboBox2.DropDownWidth = 219;
            this.kryptonComboBox2.Location = new System.Drawing.Point(160, 54);
            this.kryptonComboBox2.Name = "kryptonComboBox2";
            this.kryptonComboBox2.Size = new System.Drawing.Size(203, 21);
            this.kryptonComboBox2.TabIndex = 17;
            this.kryptonComboBox2.SelectionChangeCommitted += new System.EventHandler(this.kryptonComboBox2_SelectionChangeCommitted);
            // 
            // kryptonComboBox1
            // 
            this.kryptonComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kryptonComboBox1.DropDownWidth = 219;
            this.kryptonComboBox1.Location = new System.Drawing.Point(160, 17);
            this.kryptonComboBox1.Name = "kryptonComboBox1";
            this.kryptonComboBox1.Size = new System.Drawing.Size(203, 21);
            this.kryptonComboBox1.TabIndex = 16;
            this.kryptonComboBox1.SelectionChangeCommitted += new System.EventHandler(this.kryptonComboBox1_SelectionChangeCommitted);
            // 
            // lblAddress
            // 
            this.lblAddress.Location = new System.Drawing.Point(13, 91);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(97, 20);
            this.lblAddress.TabIndex = 9;
            this.lblAddress.Values.Text = "Bottle Qty / Box";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.Location = new System.Drawing.Point(50, 54);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(60, 20);
            this.lblCustomerName.TabIndex = 0;
            this.lblCustomerName.Values.Text = "Box Type";
            // 
            // kryptonPanel4
            // 
            this.kryptonPanel4.Controls.Add(this.txtId);
            this.kryptonPanel4.Controls.Add(this.btnSubmit);
            this.kryptonPanel4.Controls.Add(this.btnPreview);
            this.kryptonPanel4.Controls.Add(this.btnExit);
            this.kryptonPanel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel4.Location = new System.Drawing.Point(0, 172);
            this.kryptonPanel4.Name = "kryptonPanel4";
            this.kryptonPanel4.Size = new System.Drawing.Size(439, 44);
            this.kryptonPanel4.TabIndex = 13;
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(12, 10);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(52, 20);
            this.txtId.TabIndex = 15;
            this.txtId.Visible = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(83, 8);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(80, 27);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Values.Text = "Submit";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(181, 8);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(80, 27);
            this.btnPreview.TabIndex = 8;
            this.btnPreview.Values.Text = "Preview";
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(279, 8);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 27);
            this.btnExit.TabIndex = 9;
            this.btnExit.Values.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.kryptonPanel4);
            this.kryptonPanel2.Controls.Add(this.kryptonPanel5);
            this.kryptonPanel2.Controls.Add(this.kryptonPanel1);
            this.kryptonPanel2.Controls.Add(this.kryptonPanel3);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(761, 216);
            this.kryptonPanel2.TabIndex = 1;
            // 
            // kryptonPanel6
            // 
            this.kryptonPanel6.Controls.Add(this.kryptonPanel2);
            this.kryptonPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel6.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel6.Name = "kryptonPanel6";
            this.kryptonPanel6.Size = new System.Drawing.Size(761, 216);
            this.kryptonPanel6.TabIndex = 1;
            // 
            // FRM_BOXWISE_BOTTLE_FORMULA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 216);
            this.Controls.Add(this.kryptonPanel6);
            this.Controls.Add(this.kryptonPanel);
            this.Name = "FRM_BOXWISE_BOTTLE_FORMULA";
            this.Text = "BOXWISE BOTTLE FORMULA";
            this.Load += new System.EventHandler(this.FRM_BOXWISE_BOTTLE_FORMULA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).EndInit();
            this.kryptonPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel5)).EndInit();
            this.kryptonPanel5.ResumeLayout(false);
            this.kryptonPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel4)).EndInit();
            this.kryptonPanel4.ResumeLayout(false);
            this.kryptonPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel6)).EndInit();
            this.kryptonPanel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblCustomerNumber;
        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton optdelete;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton optedit;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton optadd;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtQty;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel3;
        private AC.ExtendedRenderer.Toolkit.KryptonListView lvw;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel5;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox kryptonComboBox2;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox kryptonComboBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblAddress;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblCustomerName;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel4;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtId;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSubmit;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnPreview;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnExit;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel6;
        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager2;
    }
}

