using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using BUSSINESS_LAYER;

namespace BILLING_SYSTEM
{
    public partial class FRM_SUBITEMMASTER : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        BUSSINESS_LAYER.BL bl_obj = new BL();
        MODULE function = new MODULE();
        DataSet form_ds = new DataSet();
        string msg = "";
        public FRM_SUBITEMMASTER()
        {
            InitializeComponent();
        }

        private void FRM_SUBITEMMASTER_Load(object sender, EventArgs e)
        {
            function.settheme(this);
            optadd.Checked = true;
            DataSet ds = bl_obj.blFill("SP_SubItemMaster");
            FillLVW(ds);
            function.fillcombo(cmbItem, ds.Tables[1]);
            function.fillcombo(cmbMeasurment, ds.Tables[2]);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void optadd_CheckedChanged(object sender, EventArgs e)
        {
            if (optadd.Checked == true)
            {
                txtSubItem.Focus();
                cleartext();
                btnSubmit.Text = "Add";
                btnSubmit.Enabled = true;
                lvw.CheckBoxes = false;
                optadd.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                btnSubmit.Enabled = false;
                optadd.ForeColor = System.Drawing.Color.Black;
            }
        }

        protected void cleartext()
        {
            txtRate.Text = "";
            txtSubItem.Text = "";
            if (cmbItem.Items.Count > 0)
                cmbItem.SelectedIndex = 0;
            if (cmbMeasurment.Items.Count > 0)
                cmbMeasurment.SelectedIndex = 0;
        }

        private void optedit_CheckedChanged(object sender, EventArgs e)
        {
            if (optedit.Checked == true)
            {
                cleartext();
                txtSubItem.Focus();
                btnSubmit.Text = "Edit";
                btnSubmit.Enabled = true;
                lvw.CheckBoxes = false;
                optedit.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                btnSubmit.Enabled = false;
                optedit.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void optdelete_CheckedChanged(object sender, EventArgs e)
        {
            if (optdelete.Checked == true)
            {
                cleartext();
                txtSubItem.Focus();
                btnSubmit.Text = "Delete";
                btnSubmit.Enabled = true;
                lvw.CheckBoxes = true;
                optdelete.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                btnSubmit.Enabled = false;
                optdelete.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void FillLVW(DataSet ds)
        {
            List<String> col = new List<string>();
            col.Add("0");
            col.Add("1");
            col.Add("2");
            col.Add("3");
            col.Add("4");
            col.Add("5");
            col.Add("6");
            List<String> col_Name = new List<string>();
            col_Name.Add("SubItem Id");
            col_Name.Add("SubItem Name");
            col_Name.Add("Rate");
            col_Name.Add("Measurment ID");
            col_Name.Add("Measurment Name");
            col_Name.Add("Item Id");
            col_Name.Add("Item Name");
            List<string> col_Size = new List<string>();
            col_Size.Add("0");
            col_Size.Add("100");
            col_Size.Add("100");
            col_Size.Add("0");
            col_Size.Add("100");
            col_Size.Add("0");
            col_Size.Add("100");
            function.filllvw(lvw, ds, col, col_Name, 0, 0, 0);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
           
            if (Validate(optdelete.Checked) == true)
            {
                if (optadd.Checked == true)
                {
                    List<string> para_name = new List<string>();
                    //para_name.Add("@SubItemId");
                    para_name.Add("@SubItemName");
                    para_name.Add("@Rate");
                    para_name.Add("@ItemId");
                    para_name.Add("@MeasurmentId");
                    para_name.Add("@flag");
                    List<string> para_value = new List<string>(); 
                    para_value.Add(txtSubItem.Text.Trim().ToString());
                    para_value.Add(txtRate.Text.Trim().ToString());
                    para_value.Add(cmbItem.SelectedValue.ToString());                     
                    para_value.Add(cmbMeasurment.SelectedValue.ToString());
                    para_value.Add("A");
                    DataSet ds = bl_obj.blFill_para_name(para_name, para_value, "SP_SubItemMaster");
                    cleartext();                    
                    FillLVW(ds);
                }
                if (optedit.Checked == true)

                {
                    List<string> para_name = new List<string>();
                    para_name.Add("@SubItemId");
                    para_name.Add("@SubItemName");
                    para_name.Add("@Rate");
                    para_name.Add("@ItemId");
                    para_name.Add("@MeasurmentId");
                    para_name.Add("@flag");
                    List<string> para_value = new List<string>();
                    para_value.Add(txtSubItemId.Text.Trim().ToString());
                    para_value.Add(txtSubItem.Text.Trim().ToString());
                    para_value.Add(txtRate.Text.Trim().ToString());
                    para_value.Add(cmbItem.SelectedValue.ToString());
                    para_value.Add(cmbMeasurment.SelectedValue.ToString());
                    para_value.Add("U");
                    DataSet ds = bl_obj.blFill_para_name(para_name, para_value, "SP_SubItemMaster");
                    cleartext();                   
                    FillLVW(ds);
                }
                if (optdelete.Checked == true)
                {
                    if (lvw.Items.Count != 0)
                    {
                        DialogResult str = MessageBox.Show(this, "Are U Sure To Delete A Record "  + "?", "Delete", MessageBoxButtons.YesNo);
                        for (int i = 0; i < lvw.Items.Count; i++)
                        {
                            if (lvw.Items[i].Checked == true)
                            {
                                if (str.ToString().CompareTo("Yes") == 0)
                                {
                                    List<string> para_name = new List<string>();
                                    para_name.Add("@SubItemId");
                                    para_name.Add("@flag");
                                    List<string> para_value = new List<string>();
                                    para_value.Add(txtSubItemId.Text.ToString());
                                    para_value.Add("D");
                                    DataSet ds = bl_obj.blFill_para_name(para_name, para_value, "SP_SubItemMaster");
                                    cleartext();                                    
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                function.Message_Show(this, msg, "Error Information");
                msg = "";
            }
        }

        public bool Validate(char flag, out string msg)
        {
            msg = "";
            bool v = true;
            if (flag == 'D')
            {
                if (lvw.CheckedItems.Count <= 0)
                    v = false;
            }
            if (flag == 'U')
                if (txtSubItemId.Text.Trim().Length <= 0)
                {
                    v = false;
                    msg += "Something Went Wrong";
                }
            if (flag == 'A' || flag == 'U')
                if (cmbItem.SelectedIndex.ToString().Trim().Length <= 0)
                {
                    v = false;
                    msg += "Select Item";
                }
            if (flag == 'A' || flag == 'U')
                if (cmbMeasurment.SelectedIndex.ToString().Trim().Length <= 0)
                {
                    v = false;
                    msg += "Select Measurement";
                }
            if (flag == 'A' || flag == 'U')
                if (txtSubItem.Text.Trim().Length <= 0)
                {
                    v = false;
                    msg += "Enter the SubItem Name";
                }
            if (flag == 'A' || flag == 'U')
                if (txtRate.Text.Trim().Length <= 0)
                {
                    v = false;
                    msg += "Enter the Rate";
                }
            return v;
        }

        private void lvw_MouseUp(object sender, MouseEventArgs e)
        {
            if (optedit.Checked)
            {
                ListViewItem l = lvw.HitTest(e.Location).Item;
                if (l != null)
                {
                    txtSubItemId.Text = l.Tag.ToString();
                    txtSubItem.Text = l.SubItems[1].Text.ToString();
                    txtRate.Text = l.SubItems[2].Text.ToString();
                    cmbItem.SelectedIndex = cmbItem.FindString(l.SubItems[6].Text);
                    cmbMeasurment.SelectedIndex = cmbMeasurment.FindString(l.SubItems[4].Text);
                }
                else
                {
                    cleartext();
                }
            }
        }
    }
}