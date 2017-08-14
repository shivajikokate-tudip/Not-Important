namespace BILLING_SYSTEM
{
    partial class FRM_ROWMATERIALMASTER
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
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonPanel6 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.lvw = new AC.ExtendedRenderer.Toolkit.KryptonListView();
            this.kryptonPanel3 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.txtRowMaterialId = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnPreview = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btncancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnSubmit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.cmbMeasurement = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.lblMeasurement = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmbRowHeaderName = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.lblRowMaterialName = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtRowMaterialName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblRowHeaderName = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonPanel4 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.optdelete = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.optupdate = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.optadd = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.kryptonPanel5 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
            this.kryptonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel6)).BeginInit();
            this.kryptonPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).BeginInit();
            this.kryptonPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMeasurement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbRowHeaderName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel4)).BeginInit();
            this.kryptonPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel5)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel
            // 
            this.kryptonPanel.Controls.Add(this.kryptonPanel1);
            this.kryptonPanel.Controls.Add(this.kryptonPanel5);
            this.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel.Name = "kryptonPanel";
            this.kryptonPanel.Size = new System.Drawing.Size(721, 264);
            this.kryptonPanel.TabIndex = 0;
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kryptonPanel6);
            this.kryptonPanel1.Controls.Add(this.kryptonPanel3);
            this.kryptonPanel1.Controls.Add(this.kryptonPanel2);
            this.kryptonPanel1.Controls.Add(this.kryptonPanel4);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(721, 264);
            this.kryptonPanel1.TabIndex = 3;
            // 
            // kryptonPanel6
            // 
            this.kryptonPanel6.Controls.Add(this.lvw);
            this.kryptonPanel6.Location = new System.Drawing.Point(382, 3);
            this.kryptonPanel6.Name = "kryptonPanel6";
            this.kryptonPanel6.Size = new System.Drawing.Size(336, 193);
            this.kryptonPanel6.TabIndex = 5;
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
            this.lvw.Size = new System.Drawing.Size(336, 193);
            this.lvw.TabIndex = 12;
            this.lvw.TabStop = false;
            this.lvw.UseCompatibleStateImageBehavior = false;
            this.lvw.UseStyledColors = false;
            this.lvw.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lvw_MouseUp);
            // 
            // kryptonPanel3
            // 
            this.kryptonPanel3.Controls.Add(this.txtRowMaterialId);
            this.kryptonPanel3.Controls.Add(this.btnPreview);
            this.kryptonPanel3.Controls.Add(this.btncancel);
            this.kryptonPanel3.Controls.Add(this.btnSubmit);
            this.kryptonPanel3.Location = new System.Drawing.Point(3, 201);
            this.kryptonPanel3.Name = "kryptonPanel3";
            this.kryptonPanel3.Size = new System.Drawing.Size(715, 57);
            this.kryptonPanel3.TabIndex = 4;
            // 
            // txtRowMaterialId
            // 
            this.txtRowMaterialId.Location = new System.Drawing.Point(9, 11);
            this.txtRowMaterialId.Name = "txtRowMaterialId";
            this.txtRowMaterialId.Size = new System.Drawing.Size(53, 20);
            this.txtRowMaterialId.TabIndex = 11;
            this.txtRowMaterialId.Visible = false;
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(311, 11);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(96, 31);
            this.btnPreview.TabIndex = 5;
            this.btnPreview.Values.Text = "Preview";
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(455, 11);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(96, 31);
            this.btncancel.TabIndex = 6;
            this.btncancel.Values.Text = "Cancel";
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(163, 11);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 31);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Values.Text = "Submit";
            this.btnSubmit.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.cmbMeasurement);
            this.kryptonPanel2.Controls.Add(this.lblMeasurement);
            this.kryptonPanel2.Controls.Add(this.cmbRowHeaderName);
            this.kryptonPanel2.Controls.Add(this.lblRowMaterialName);
            this.kryptonPanel2.Controls.Add(this.txtRowMaterialName);
            this.kryptonPanel2.Controls.Add(this.lblRowHeaderName);
            this.kryptonPanel2.Location = new System.Drawing.Point(3, 67);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(373, 129);
            this.kryptonPanel2.TabIndex = 3;
            // 
            // cmbMeasurement
            // 
            this.cmbMeasurement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMeasurement.DropDownWidth = 153;
            this.cmbMeasurement.Location = new System.Drawing.Point(188, 54);
            this.cmbMeasurement.Name = "cmbMeasurement";
            this.cmbMeasurement.Size = new System.Drawing.Size(153, 21);
            this.cmbMeasurement.TabIndex = 2;
            // 
            // lblMeasurement
            // 
            this.lblMeasurement.Location = new System.Drawing.Point(58, 54);
            this.lblMeasurement.Name = "lblMeasurement";
            this.lblMeasurement.Size = new System.Drawing.Size(86, 20);
            this.lblMeasurement.TabIndex = 9;
            this.lblMeasurement.Values.Text = "Measurement";
            // 
            // cmbRowHeaderName
            // 
            this.cmbRowHeaderName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRowHeaderName.DropDownWidth = 153;
            this.cmbRowHeaderName.Location = new System.Drawing.Point(188, 17);
            this.cmbRowHeaderName.Name = "cmbRowHeaderName";
            this.cmbRowHeaderName.Size = new System.Drawing.Size(153, 21);
            this.cmbRowHeaderName.TabIndex = 1;
            // 
            // lblRowMaterialName
            // 
            this.lblRowMaterialName.Location = new System.Drawing.Point(26, 89);
            this.lblRowMaterialName.Name = "lblRowMaterialName";
            this.lblRowMaterialName.Size = new System.Drawing.Size(118, 20);
            this.lblRowMaterialName.TabIndex = 6;
            this.lblRowMaterialName.Values.Text = "Row Material Name";
            // 
            // txtRowMaterialName
            // 
            this.txtRowMaterialName.Location = new System.Drawing.Point(188, 89);
            this.txtRowMaterialName.Name = "txtRowMaterialName";
            this.txtRowMaterialName.Size = new System.Drawing.Size(153, 20);
            this.txtRowMaterialName.TabIndex = 3;
            // 
            // lblRowHeaderName
            // 
            this.lblRowHeaderName.Location = new System.Drawing.Point(31, 17);
            this.lblRowHeaderName.Name = "lblRowHeaderName";
            this.lblRowHeaderName.Size = new System.Drawing.Size(113, 20);
            this.lblRowHeaderName.TabIndex = 4;
            this.lblRowHeaderName.Values.Text = "Row Header Name";
            // 
            // kryptonPanel4
            // 
            this.kryptonPanel4.Controls.Add(this.optdelete);
            this.kryptonPanel4.Controls.Add(this.optupdate);
            this.kryptonPanel4.Controls.Add(this.optadd);
            this.kryptonPanel4.Location = new System.Drawing.Point(3, 3);
            this.kryptonPanel4.Name = "kryptonPanel4";
            this.kryptonPanel4.Size = new System.Drawing.Size(373, 58);
            this.kryptonPanel4.TabIndex = 0;
            // 
            // optdelete
            // 
            this.optdelete.Location = new System.Drawing.Point(261, 19);
            this.optdelete.Name = "optdelete";
            this.optdelete.Size = new System.Drawing.Size(62, 20);
            this.optdelete.TabIndex = 8;
            this.optdelete.Values.Text = "DELETE";
            this.optdelete.CheckedChanged += new System.EventHandler(this.optdelete_CheckedChanged);
            // 
            // optupdate
            // 
            this.optupdate.Location = new System.Drawing.Point(146, 19);
            this.optupdate.Name = "optupdate";
            this.optupdate.Size = new System.Drawing.Size(67, 20);
            this.optupdate.TabIndex = 7;
            this.optupdate.Values.Text = "UPDATE";
            this.optupdate.CheckedChanged += new System.EventHandler(this.optupdate_CheckedChanged);
            // 
            // optadd
            // 
            this.optadd.Location = new System.Drawing.Point(50, 19);
            this.optadd.Name = "optadd";
            this.optadd.Size = new System.Drawing.Size(48, 20);
            this.optadd.TabIndex = 0;
            this.optadd.Values.Text = "ADD";
            this.optadd.CheckedChanged += new System.EventHandler(this.optadd_CheckedChanged);
            // 
            // kryptonPanel5
            // 
            this.kryptonPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel5.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel5.Name = "kryptonPanel5";
            this.kryptonPanel5.Size = new System.Drawing.Size(721, 264);
            this.kryptonPanel5.TabIndex = 2;
            // 
            // FRM_ROWMATERIALMASTER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 264);
            this.Controls.Add(this.kryptonPanel);
            this.Name = "FRM_ROWMATERIALMASTER";
            this.Text = "ROWMATERIAL MASTER";
            this.Load += new System.EventHandler(this.FRM_ROWMATERIALMASTER_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).EndInit();
            this.kryptonPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel6)).EndInit();
            this.kryptonPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).EndInit();
            this.kryptonPanel3.ResumeLayout(false);
            this.kryptonPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMeasurement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbRowHeaderName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel4)).EndInit();
            this.kryptonPanel4.ResumeLayout(false);
            this.kryptonPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private AC.ExtendedRenderer.Toolkit.KryptonListView lvw;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel3;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btncancel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSubmit;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtRowMaterialName;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblRowHeaderName;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel4;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton optdelete;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton optupdate;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton optadd;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel5;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblRowMaterialName;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel6;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cmbRowHeaderName;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cmbMeasurement;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblMeasurement;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnPreview;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtRowMaterialId;
    }
}

