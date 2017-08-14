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
    public partial class FRM_SUBEXPENCESMASTER : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        MODULE function = new MODULE();
        BL_SUBEXPENCESMASTER bl_obj = new BL_SUBEXPENCESMASTER();
        DataSet ds = new DataSet();
        public FRM_SUBEXPENCESMASTER()
        {
            InitializeComponent();
        }

        

        private void lvw_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                if (optupdate.Checked)
                {
                    ListViewItem l = lvw.HitTest(e.Location).Item;
                    if (l != null)
                    {
                        txtExpencesId.Text = l.Tag.ToString();
                        txtExpencesName.Text = l.SubItems[0].Text.ToString();
                        
                        if (l.SubItems[2].Text.ToString().Equals("Income"))
                        {
                            cmbMainAccount.SelectedIndex = 1;
                        }
                        if (l.SubItems[2].Text.ToString().Equals("Expences"))
                        {
                            cmbMainAccount.SelectedIndex = 2;
                        }
                        if (l.SubItems[2].Text.ToString().Equals("Assets"))
                        {
                            cmbMainAccount.SelectedIndex = 3;
                        }
                        if (l.SubItems[2].Text.ToString().Equals("Liability"))
                        {
                            cmbMainAccount.SelectedIndex = 4;
                        }
                        cmbExpences.SelectedValue = Convert.ToInt32(l.SubItems[3].Text.ToString());
                    }
                    else
                    {
                        ClearControls();
                    }
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
                list.Add(new ListViewColumnsInfo() { ColNumber = 1, ColumnSize = 200, Header = "Sub Account Name", Visible = true });
                list.Add(new ListViewColumnsInfo() { ColNumber = 2, ColumnSize = 200, Header = "Account Type", Visible = true });
                list.Add(new ListViewColumnsInfo() { ColNumber = 3, ColumnSize = 0, Header = "Option Type", Visible = true });
                list.Add(new ListViewColumnsInfo() { ColNumber = 4, ColumnSize = 0, Header = "Expence Id", Visible = true });
                list.Add(new ListViewColumnsInfo() { ColNumber = 0, ColumnSize = 0, Header = "Sub Expence Id", Visible = true });
                function.filllvw(lvw, ds, list, ColumnHeaderStyle.Nonclickable, 0, 0);
            }
            catch (Exception err) { err.GetBaseException(); }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string msg = "";
            try
            {
                if (optadd.Checked)
                {

                    if (Validate('A', out msg))
                    {
                        //if (optIncome.Checked == true) { bl_obj.OptionType = "I"; }
                        //if (optExpences.Checked == true) { bl_obj.OptionType = "E"; }
                        bl_obj.SubExpencesName = txtExpencesName.Text;
                        bl_obj.ExpencesId = Convert.ToInt32(cmbExpences.SelectedValue.ToString());
                        FillLVW(bl_obj.INSERT(bl_obj));
                        ClearControls();
                        KryptonMessageBox.Show("Record Save Successfully", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MyMessageBox.ShowBox(msg);
                }
                else if (optupdate.Checked)
                {
                    if (Validate('U', out msg))
                    {

                        bl_obj.SubExpencesId = Convert.ToInt32(txtExpencesId.Text.ToString());
                        //if (optIncome.Checked == true) { bl_obj.OptionType = "I"; }
                        //if (optExpences.Checked == true) { bl_obj.OptionType = "E"; }
                        bl_obj.SubExpencesName = txtExpencesName.Text;
                        bl_obj.ExpencesId = Convert.ToInt32(cmbExpences.SelectedValue.ToString());
                        FillLVW(bl_obj.UPDATE(bl_obj));
                        ClearControls();
                        KryptonMessageBox.Show("Record Update Successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MyMessageBox.ShowBox(msg);
                }
                else if (optdelete.Checked)
                {
                    if (Validate('D', out msg))
                    {
                        if (KryptonMessageBox.Show("Do You Want To delete These record(s)?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            foreach (ListViewItem l in lvw.CheckedItems)
                            {
                                bl_obj.SubExpencesId = Convert.ToInt32(l.Tag.ToString());
                                bl_obj.DELETE(bl_obj);
                            }
                            FillLVW(bl_obj.SELECT(bl_obj));
                            ClearControls();
                            KryptonMessageBox.Show("Record(s) deleted Successfully", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                        MyMessageBox.ShowBox(msg);
                }
            }
            catch (Exception err) { err.GetBaseException(); }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRM_SUBEXPENCESMASTER_Load(object sender, EventArgs e)
        {
            function.settheme(this); 
            optadd.Checked = true;
            FillLVW(bl_obj.SELECT(bl_obj));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;   // Do not resize the form.
        }
        public void ClearControls()
        {
            txtExpencesId.Text = "";
            txtExpencesName.Text = "";
            if (cmbExpences.Items.Count > 0)
                cmbExpences.SelectedIndex = 0;
            cmbMainAccount.SelectedIndex = 0;
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
                if (txtExpencesId.Text.Trim().Length <= 0)
                {
                    v = false;
                    msg += "Something Went Wrong";
                }
            if (flag == 'A' || flag == 'U')
                if (cmbExpences.SelectedIndex.ToString().Trim().Length <= 0)
                {
                    v = false;
                    msg += "Select Expences.  ";
                }
            if (flag == 'A' || flag == 'U')
                if (txtExpencesName.Text.Trim().Length <= 0)
                {
                    v = false;
                    msg += "Enter the Account Name.  ";
                }
            if (flag == 'A' || flag == 'U')
                if (cmbMainAccount.SelectedIndex < 0)
                {
                    v = false;
                    msg += "Enter the Type of Account.  ";
                }
            return v;
        }

        private void optadd_CheckedChanged(object sender, EventArgs e)
        {
            if (optadd.Checked == true)
            {
                txtExpencesName.Focus();
                ClearControls();
                btnsave.Text = "Add";
                btnsave.Enabled = true;
                lvw.CheckBoxes = false;
                optadd.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                btnsave.Enabled = false;
                optadd.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void optupdate_CheckedChanged(object sender, EventArgs e)
        {
            if (optupdate.Checked == true)
            {
                ClearControls();
                txtExpencesName.Focus();
                btnsave.Text = "Update";
                btnsave.Enabled = true;
                lvw.CheckBoxes = false;
                optupdate.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                btnsave.Enabled = false;
                optupdate.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void optdelete_CheckedChanged(object sender, EventArgs e)
        {
            if (optdelete.Checked == true)
            {
                ClearControls();
                txtExpencesName.Focus();
                btnsave.Text = "Delete";
                btnsave.Enabled = true;
                lvw.CheckBoxes = true;
                optdelete.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                btnsave.Enabled = false;
                optdelete.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            try
            {
                module_Rpt.rpt_name = "FRM_SUBEXPENCESMASTER";
                Business_Report.Report_Viewer rpt = new Business_Report.Report_Viewer();
                rpt.Show();
            }
            catch (Exception err) { err.GetBaseException(); }
        }

        private void cmbMainAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if ( cmbMainAccount.SelectedIndex == 1)
                {
                    SortedList<string, string> list = new SortedList<string, string>();
                    list.Add("@flag", "8");
                    list.Add("@Option_Type", "I");
                    ds = bl_obj.blFill_Para_Name(list, "SP_FILLDDL");
                    function.fillcombo(cmbExpences, ds.Tables[0]);
                }
                if (cmbMainAccount.SelectedIndex == 2)
                {
                    SortedList<string, string> list = new SortedList<string, string>();
                    list.Add("@flag", "8");
                    list.Add("@Option_Type", "E");
                    ds = bl_obj.blFill_Para_Name(list, "SP_FILLDDL");
                    function.fillcombo(cmbExpences, ds.Tables[0]);
                }
                if (cmbMainAccount.SelectedIndex == 3)
                {
                    SortedList<string, string> list = new SortedList<string, string>();
                    list.Add("@flag", "8");
                    list.Add("@Option_Type", "A");
                    ds = bl_obj.blFill_Para_Name(list, "SP_FILLDDL");
                    function.fillcombo(cmbExpences, ds.Tables[0]);
                }
                if (cmbMainAccount.SelectedIndex == 4)
                {
                    SortedList<string, string> list = new SortedList<string, string>();
                    list.Add("@flag", "8");
                    list.Add("@Option_Type", "L");
                    ds = bl_obj.blFill_Para_Name(list, "SP_FILLDDL");
                    function.fillcombo(cmbExpences, ds.Tables[0]);
                }
            }
            catch (Exception err) { err.GetBaseException(); }
        }
    }
}