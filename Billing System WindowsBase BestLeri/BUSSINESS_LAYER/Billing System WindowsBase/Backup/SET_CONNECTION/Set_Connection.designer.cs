namespace SET_CONNECTION
{
    partial class Set_Connection
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
            this.kryptonButton2 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txt_con_new = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txt_con_local = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
            this.kryptonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel
            // 
            this.kryptonPanel.Controls.Add(this.kryptonButton2);
            this.kryptonPanel.Controls.Add(this.kryptonButton1);
            this.kryptonPanel.Controls.Add(this.txt_con_new);
            this.kryptonPanel.Controls.Add(this.txt_con_local);
            this.kryptonPanel.Controls.Add(this.kryptonLabel2);
            this.kryptonPanel.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel.Name = "kryptonPanel";
            this.kryptonPanel.Size = new System.Drawing.Size(791, 346);
            this.kryptonPanel.TabIndex = 0;
            // 
            // kryptonButton2
            // 
            this.kryptonButton2.Location = new System.Drawing.Point(546, 85);
            this.kryptonButton2.Name = "kryptonButton2";
            this.kryptonButton2.Size = new System.Drawing.Size(25, 66);
            this.kryptonButton2.TabIndex = 5;
            this.kryptonButton2.Values.Text = "...";
            this.kryptonButton2.Click += new System.EventHandler(this.kryptonButton2_Click);
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(335, 157);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(204, 38);
            this.kryptonButton1.TabIndex = 4;
            this.kryptonButton1.Values.Text = "Update Connection";
            this.kryptonButton1.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // txt_con_new
            // 
            this.txt_con_new.Location = new System.Drawing.Point(182, 85);
            this.txt_con_new.Multiline = true;
            this.txt_con_new.Name = "txt_con_new";
            this.txt_con_new.Size = new System.Drawing.Size(357, 66);
            this.txt_con_new.TabIndex = 3;
            // 
            // txt_con_local
            // 
            this.txt_con_local.Location = new System.Drawing.Point(182, 13);
            this.txt_con_local.Multiline = true;
            this.txt_con_local.Name = "txt_con_local";
            this.txt_con_local.Size = new System.Drawing.Size(389, 66);
            this.txt_con_local.TabIndex = 2;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(13, 85);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(140, 27);
            this.kryptonLabel2.TabIndex = 1;
            this.kryptonLabel2.Values.Text = "New Connection ";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(13, 13);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(163, 27);
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "Current Connection";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "\"Access Database File(*.mdb)\"|*.mdb";
            this.openFileDialog1.RestoreDirectory = true;
            this.openFileDialog1.SupportMultiDottedExtensions = true;
            // 
            // Set_Connection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 346);
            this.Controls.Add(this.kryptonPanel);
            this.Name = "Set_Connection";
            this.Text = "Set_Connection";
            this.Load += new System.EventHandler(this.Set_Connection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).EndInit();
            this.kryptonPanel.ResumeLayout(false);
            this.kryptonPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_con_new;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_con_local;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

