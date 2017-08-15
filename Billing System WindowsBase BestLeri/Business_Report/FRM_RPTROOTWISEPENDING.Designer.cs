namespace Business_Report
{
    partial class FRM_RPTROOTWISEPENDING
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
            this.cmbRootName = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.lblRootName = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btnPreview = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnClose = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
            this.kryptonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbRootName)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel
            // 
            this.kryptonPanel.Controls.Add(this.btnPreview);
            this.kryptonPanel.Controls.Add(this.btnClose);
            this.kryptonPanel.Controls.Add(this.lblRootName);
            this.kryptonPanel.Controls.Add(this.cmbRootName);
            this.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel.Name = "kryptonPanel";
            this.kryptonPanel.Size = new System.Drawing.Size(359, 113);
            this.kryptonPanel.TabIndex = 0;
            // 
            // cmbRootName
            // 
            this.cmbRootName.DropDownWidth = 200;
            this.cmbRootName.Location = new System.Drawing.Point(130, 21);
            this.cmbRootName.Name = "cmbRootName";
            this.cmbRootName.Size = new System.Drawing.Size(200, 21);
            this.cmbRootName.TabIndex = 0;
            // 
            // lblRootName
            // 
            this.lblRootName.Location = new System.Drawing.Point(25, 22);
            this.lblRootName.Name = "lblRootName";
            this.lblRootName.Size = new System.Drawing.Size(73, 20);
            this.lblRootName.TabIndex = 1;
            this.lblRootName.Values.Text = "Root Name";
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(88, 67);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(90, 34);
            this.btnPreview.TabIndex = 16;
            this.btnPreview.Values.Text = "Preview";
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(193, 67);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 34);
            this.btnClose.TabIndex = 17;
            this.btnClose.Values.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FRM_RPTROOTWISEPENDING
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 113);
            this.Controls.Add(this.kryptonPanel);
            this.Name = "FRM_RPTROOTWISEPENDING";
            this.Text = "Rootwise Pending";
            this.Load += new System.EventHandler(this.FRM_RPTROOTWISEPENDING_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).EndInit();
            this.kryptonPanel.ResumeLayout(false);
            this.kryptonPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbRootName)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblRootName;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cmbRootName;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnPreview;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnClose;
    }
}

