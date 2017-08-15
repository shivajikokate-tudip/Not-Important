namespace BILLING_SYSTEM
{
    partial class FRM_ROWMATERIAL
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
            this.txtRowMaterialId = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnPreview = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnSubmit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonPanel3 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.lvw = new AC.ExtendedRenderer.Toolkit.KryptonListView();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.lblRowMaterial = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtRawMaterial = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.optDelete = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.optEdit = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.optAdd = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
            this.kryptonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).BeginInit();
            this.kryptonPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel
            // 
            this.kryptonPanel.Controls.Add(this.txtRowMaterialId);
            this.kryptonPanel.Controls.Add(this.btnPreview);
            this.kryptonPanel.Controls.Add(this.btnCancel);
            this.kryptonPanel.Controls.Add(this.btnSubmit);
            this.kryptonPanel.Controls.Add(this.kryptonPanel3);
            this.kryptonPanel.Controls.Add(this.kryptonPanel2);
            this.kryptonPanel.Controls.Add(this.kryptonPanel1);
            this.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel.Name = "kryptonPanel";
            this.kryptonPanel.Size = new System.Drawing.Size(576, 147);
            this.kryptonPanel.TabIndex = 0;
            // 
            // txtRowMaterialId
            // 
            this.txtRowMaterialId.Location = new System.Drawing.Point(12, 104);
            this.txtRowMaterialId.Name = "txtRowMaterialId";
            this.txtRowMaterialId.Size = new System.Drawing.Size(58, 20);
            this.txtRowMaterialId.TabIndex = 2;
            this.txtRowMaterialId.Visible = false;
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(241, 110);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(90, 25);
            this.btnPreview.TabIndex = 3;
            this.btnPreview.Values.Text = "Preview";
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(353, 110);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 25);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Values.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(129, 110);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(90, 25);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Values.Text = "Submit";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // kryptonPanel3
            // 
            this.kryptonPanel3.Controls.Add(this.lvw);
            this.kryptonPanel3.Location = new System.Drawing.Point(314, 4);
            this.kryptonPanel3.Name = "kryptonPanel3";
            this.kryptonPanel3.Size = new System.Drawing.Size(258, 94);
            this.kryptonPanel3.TabIndex = 2;
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
            this.lvw.Size = new System.Drawing.Size(258, 94);
            this.lvw.TabIndex = 0;
            this.lvw.TabStop = false;
            this.lvw.UseCompatibleStateImageBehavior = false;
            this.lvw.UseStyledColors = false;
            this.lvw.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lvw_MouseUp);
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.lblRowMaterial);
            this.kryptonPanel2.Controls.Add(this.txtRawMaterial);
            this.kryptonPanel2.Location = new System.Drawing.Point(4, 44);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(306, 54);
            this.kryptonPanel2.TabIndex = 1;
            // 
            // lblRowMaterial
            // 
            this.lblRowMaterial.Location = new System.Drawing.Point(19, 17);
            this.lblRowMaterial.Name = "lblRowMaterial";
            this.lblRowMaterial.Size = new System.Drawing.Size(77, 20);
            this.lblRowMaterial.TabIndex = 1;
            this.lblRowMaterial.Values.Text = "Row Header";
            // 
            // txtRawMaterial
            // 
            this.txtRawMaterial.Location = new System.Drawing.Point(144, 18);
            this.txtRawMaterial.Name = "txtRawMaterial";
            this.txtRawMaterial.Size = new System.Drawing.Size(147, 20);
            this.txtRawMaterial.TabIndex = 1;
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.optDelete);
            this.kryptonPanel1.Controls.Add(this.optEdit);
            this.kryptonPanel1.Controls.Add(this.optAdd);
            this.kryptonPanel1.Location = new System.Drawing.Point(4, 4);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(306, 37);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // optDelete
            // 
            this.optDelete.Location = new System.Drawing.Point(220, 6);
            this.optDelete.Name = "optDelete";
            this.optDelete.Size = new System.Drawing.Size(58, 20);
            this.optDelete.TabIndex = 6;
            this.optDelete.Values.Text = "Delete";
            this.optDelete.CheckedChanged += new System.EventHandler(this.optDelete_CheckedChanged);
            // 
            // optEdit
            // 
            this.optEdit.Location = new System.Drawing.Point(127, 8);
            this.optEdit.Name = "optEdit";
            this.optEdit.Size = new System.Drawing.Size(43, 20);
            this.optEdit.TabIndex = 5;
            this.optEdit.Values.Text = "Edit";
            this.optEdit.CheckedChanged += new System.EventHandler(this.optEdit_CheckedChanged);
            // 
            // optAdd
            // 
            this.optAdd.Location = new System.Drawing.Point(29, 8);
            this.optAdd.Name = "optAdd";
            this.optAdd.Size = new System.Drawing.Size(45, 20);
            this.optAdd.TabIndex = 0;
            this.optAdd.Values.Text = "Add";
            this.optAdd.CheckedChanged += new System.EventHandler(this.optAdd_CheckedChanged);
            // 
            // FRM_ROWMATERIAL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 147);
            this.Controls.Add(this.kryptonPanel);
            this.Name = "FRM_ROWMATERIAL";
            this.Text = "ROWMATERIAL";
            this.Load += new System.EventHandler(this.FRM_ROWMATERIAL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).EndInit();
            this.kryptonPanel.ResumeLayout(false);
            this.kryptonPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).EndInit();
            this.kryptonPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCancel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSubmit;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel3;
        private AC.ExtendedRenderer.Toolkit.KryptonListView lvw;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblRowMaterial;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtRawMaterial;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton optDelete;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton optEdit;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton optAdd;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnPreview;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtRowMaterialId;
    }
}

