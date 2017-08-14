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
            try
            {
                function.settheme(this);
                optadd.Checked = true;
                DataSet ds = bl_obj.blFill("SP_SubItemMaster");
                FillLVW(ds);
                function.fillcombo(cmbItem, ds.Tables[1]);
                function.fillcombo(cmbMeasurment, ds.Tables[2]);
            }
            catch (Exception err) { err.GetBaseException(); }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void optadd_CheckedChanged(object sender, EventArgs e)
        {
            try
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
            catch (Exception err) { err.GetBaseException(); }
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
            try
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
            catch (Exception err) { err.GetBaseException(); }
        }

        private void optdelete_CheckedChanged(object sender, EventArgs e)
        {
            try
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
            catch (Exception err) { err.GetBaseException(); }
        }

        private void FillLVW(DataSet ds)
        {

            try
            {
                lvw.Clear();
                List<ListViewColumnsInfo> list = new List<ListViewColumnsInfo>();
                list.Add(new ListViewColumnsInfo() { ColNumber = 1, ColumnSize = 150, Header = "SubItem Name", Visible = true });
                list.Add(new ListViewColumnsInfo() { ColNumber = 2, ColumnSize = 100, Header = "Rate", Visible = true });
                list.Add(new ListViewColumnsInfo() { ColNumber = 3, ColumnSize = 0, Header = "Measurment ID", Visible = true });
                list.Add(new ListViewColumnsInfo() { ColNumber = 4, ColumnSize = 150, Header = "Measurment Name", Visible = true });
                list.Add(new ListViewColumnsInfo() { ColNumber = 5, ColumnSize = 0, Header = "Item Id", Visible = true });
                list.Add(new ListViewColumnsInfo() { ColNumber = 6, ColumnSize = 150, Header = "Item Name", Visible = true });
                list.Add(new ListViewColumnsInfo() { ColNumber = 0, ColumnSize = 0, Header = "SubItem Id", Visible = true });
                function.filllvw(lvw, ds, list, ColumnHeaderStyle.Nonclickable, 0, 0);
            }
            catch (Exception err) { err.GetBaseException(); }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (optadd.Checked == true)
                {
                    if (Validate('A', out msg))
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
                }
                if (optedit.Checked == true)
                {
                    if (Validate('A', out msg))
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
                }
                if (optdelete.Checked == true)
                {
                    DataSet ds=new DataSet();
                    if (lvw.Items.Count != 0)
                    {
                        
                        DialogResult str = MessageBox.Show(this, "Are U Sure To Delete A Record " + "?", "Delete", MessageBoxButtons.YesNo);
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
                                    para_value.Add(lvw.Items[i].SubItems[6].Text);
                                    para_value.Add("D");
                                     ds = bl_obj.blFill_para_name(para_name, para_value, "SP_SubItemMaster");
                                    
                                }
                            }
                        } cleartext();
                        FillLVW(ds);
                    }
                }
            }
            catch (Exception err) { err.GetBaseException(); }
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
            try
            {
                ListViewItem l = lvw.HitTest(e.Location).Item;
                if (optedit.Checked)
                {
                    if (l != null)
                    {
                        txtSubItemId.Text = l.Tag.ToString();
                        txtSubItem.Text = l.SubItems[0].Text.ToString();
                        txtRate.Text = l.SubItems[1].Text.ToString();
                        cmbItem.SelectedIndex = cmbItem.FindString(l.SubItems[5].Text);
                        cmbMeasurment.SelectedIndex = cmbMeasurment.FindString(l.SubItems[3].Text);
                    }
                    else
                    {
                        cleartext();
                    }
                }
              
            }
            catch (Exception err) { err.GetBaseException(); }
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            try
            {
                module_Rpt.rpt_name = "FRM_SUBITEMMASTER";
                Business_Report.Report_Viewer rpt = new Business_Report.Report_Viewer();
                rpt.Show();
            }
            catch (Exception err) { err.GetBaseException(); }
        }
    }
}