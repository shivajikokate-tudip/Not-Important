namespace BILLING_SYSTEM
{
    partial class FRM_MEASUREMENTMASTER
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
            this.optdelete = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.optupdate = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.lvw = new AC.ExtendedRenderer.Toolkit.KryptonListView();
            this.lblMeasurementName = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.optadd = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.kryptonPanel3 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btnPreview = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btncancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txtMeasurementId = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnsave = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txtMeasurementName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonPanel5 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonPanel4 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonManager1 = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).BeginInit();
            this.kryptonPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel5)).BeginInit();
            this.kryptonPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel4)).BeginInit();
            this.kryptonPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel
            // 
            this.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel.Name = "kryptonPanel";
            this.kryptonPanel.Size = new System.Drawing.Size(611, 152);
            this.kryptonPanel.TabIndex = 0;
            // 
            // optdelete
            // 
            this.optdelete.Location = new System.Drawing.Point(232, 10);
            this.optdelete.Name = "optdelete";
            this.optdelete.Size = new System.Drawing.Size(62, 20);
            this.optdelete.TabIndex = 5;
            this.optdelete.Values.Text = "DELETE";
            this.optdelete.CheckedChanged += new System.EventHandler(this.optdelete_CheckedChanged);
            // 
            // optupdate
            // 
            this.optupdate.Location = new System.Drawing.Point(129, 10);
            this.optupdate.Name = "optupdate";
            this.optupdate.Size = new System.Drawing.Size(67, 20);
            this.optupdate.TabIndex = 4;
            this.optupdate.Values.Text = "UPDATE";
            this.optupdate.CheckedChanged += new System.EventHandler(this.optupdate_CheckedChanged);
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
            this.lvw.Size = new System.Drawing.Size(272, 145);
            this.lvw.TabIndex = 6;
            this.lvw.TabStop = false;
            this.lvw.UseCompatibleStateImageBehavior = false;
            this.lvw.UseStyledColors = false;
            this.lvw.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lvw_MouseUp);
            // 
            // lblMeasurementName
            // 
            this.lblMeasurementName.Location = new System.Drawing.Point(17, 13);
            this.lblMeasurementName.Name = "lblMeasurementName";
            this.lblMeasurementName.Size = new System.Drawing.Size(122, 20);
            this.lblMeasurementName.TabIndex = 4;
            this.lblMeasurementName.Values.Text = "Measurement Name";
            // 
            // optadd
            // 
            this.optadd.Location = new System.Drawing.Point(31, 10);
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
            this.kryptonPanel3.Controls.Add(this.txtMeasurementId);
            this.kryptonPanel3.Controls.Add(this.btnsave);
            this.kryptonPanel3.Location = new System.Drawing.Point(5, 96);
            this.kryptonPanel3.Name = "kryptonPanel3";
            this.kryptonPanel3.Size = new System.Drawing.Size(325, 53);
            this.kryptonPanel3.TabIndex = 4;
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(122, 14);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(85, 25);
            this.btnPreview.TabIndex = 4;
            this.btnPreview.Values.Text = "Preview";
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(216, 14);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(81, 25);
            this.btncancel.TabIndex = 3;
            this.btncancel.Values.Text = "Cancel";
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // txtMeasurementId
            // 
            this.txtMeasurementId.Location = new System.Drawing.Point(3, 3);
            this.txtMeasurementId.Name = "txtMeasurementId";
            this.txtMeasurementId.Size = new System.Drawing.Size(18, 20);
            this.txtMeasurementId.TabIndex = 0;
            this.txtMeasurementId.Visible = false;
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(27, 14);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(85, 25);
            this.btnsave.TabIndex = 2;
            this.btnsave.Values.Text = "Submit";
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // txtMeasurementName
            // 
            this.txtMeasurementName.Location = new System.Drawing.Point(177, 13);
            this.txtMeasurementName.Name = "txtMeasurementName";
            this.txtMeasurementName.Size = new System.Drawing.Size(130, 20);
            this.txtMeasurementName.TabIndex = 1;
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.txtMeasurementName);
            this.kryptonPanel2.Controls.Add(this.lblMeasurementName);
            this.kryptonPanel2.Location = new System.Drawing.Point(5, 47);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(325, 46);
            this.kryptonPanel2.TabIndex = 3;
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kryptonPanel5);
            this.kryptonPanel1.Controls.Add(this.kryptonPanel3);
            this.kryptonPanel1.Controls.Add(this.kryptonPanel2);
            this.kryptonPanel1.Controls.Add(this.kryptonPanel4);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(611, 152);
            this.kryptonPanel1.TabIndex = 1;
            // 
            // kryptonPanel5
            // 
            this.kryptonPanel5.Controls.Add(this.lvw);
            this.kryptonPanel5.Location = new System.Drawing.Point(336, 4);
            this.kryptonPanel5.Name = "kryptonPanel5";
            this.kryptonPanel5.Size = new System.Drawing.Size(272, 145);
            this.kryptonPanel5.TabIndex = 6;
            // 
            // kryptonPanel4
            // 
            this.kryptonPanel4.Controls.Add(this.optdelete);
            this.kryptonPanel4.Controls.Add(this.optupdate);
            this.kryptonPanel4.Controls.Add(this.optadd);
            this.kryptonPanel4.Location = new System.Drawing.Point(5, 3);
            this.kryptonPanel4.Name = "kryptonPanel4";
            this.kryptonPanel4.Size = new System.Drawing.Size(325, 41);
            this.kryptonPanel4.TabIndex = 0;
            // 
            // FRM_MEASUREMENTMASTER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 152);
            this.Controls.Add(this.kryptonPanel1);
            this.Controls.Add(this.kryptonPanel);
            this.Name = "FRM_MEASUREMENTMASTER";
            this.Text = "MEASUREMENT MASTER";
            this.Load += new System.EventHandler(this.FRM_MEASUREMENTMASTER_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).EndInit();
            this.kryptonPanel3.ResumeLayout(false);
            this.kryptonPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel5)).EndInit();
            this.kryptonPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel4)).EndInit();
            this.kryptonPanel4.ResumeLayout(false);
            this.kryptonPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton optdelete;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton optupdate;
        private AC.ExtendedRenderer.Toolkit.KryptonListView lvw;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblMeasurementName;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton optadd;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel3;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btncancel;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtMeasurementId;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnsave;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtMeasurementName;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel4;
        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel5;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnPreview;
    }
}

