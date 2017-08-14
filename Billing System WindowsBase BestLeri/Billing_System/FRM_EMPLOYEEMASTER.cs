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
    public partial class FRM_EMPLOYEEMASTER : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        MODULE function = new MODULE();
        BL_EMPLOYEEMASTER bl_obj = new BL_EMPLOYEEMASTER();
        public FRM_EMPLOYEEMASTER()
        {
            InitializeComponent();
        }


        private void FillLVW(DataSet ds)
        {
            try
            {
                lvw.Clear();
                List<ListViewColumnsInfo> list = new List<ListViewColumnsInfo>();
                //list.Add(new ListViewColumnsInfo() { ColNumber = 0, ColumnSize = 100, Header = "EmpID", Visible = true });
                list.Add(new ListViewColumnsInfo() { ColNumber = 1, ColumnSize = 200, Header = "Name", Visible = true });
                list.Add(new ListViewColumnsInfo() { ColNumber = 2, ColumnSize = 200, Header = "Address", Visible = true });
                list.Add(new ListViewColumnsInfo() { ColNumber = 3, ColumnSize = 100, Header = "Mb.No.", Visible = true });
                list.Add(new ListViewColumnsInfo() { ColNumber = 4, ColumnSize = 100, Header = "BirthDate", Visible = true });
                list.Add(new ListViewColumnsInfo() { ColNumber = 5, ColumnSize = 100, Header = "JoiningDate", Visible = true });
                list.Add(new ListViewColumnsInfo() { ColNumber = 6, ColumnSize = 0, Header = "Salary", Visible = true });
                function.filllvw(lvw, ds, list, ColumnHeaderStyle.Nonclickable, 0, 0);
            }
            catch (Exception err) { err.GetBaseException(); }
        }

        private void lvw_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                if (optedit.Checked)
                {
                    ListViewItem l = lvw.HitTest(e.Location).Item;
                    if (l != null)
                    {
                        txtEmpId.Text = l.Tag.ToString();
                        txtEmployeeName.Text = l.SubItems[0].Text.ToString();
                        txtAddress.Text = l.SubItems[1].Text.ToString();
                        txtMobileNumber.Text = l.SubItems[2].Text.ToString();
                        dtpBirthDate.Value = Convert.ToDateTime(l.SubItems[3].Text.ToString());
                        dtpJoiningDate.Value = Convert.ToDateTime(l.SubItems[4].Text.ToString());
                        txtSalalry.Text = l.SubItems[5].Text.ToString();
                    }
                    else
                    {
                        ClearControls();
                    }
                }
            }
            catch (Exception err) { err.GetBaseException(); }
        }

        public void ClearControls()
        {
            txtEmpId.Text = "";
            txtEmployeeName.Text = "";
            txtAddress.Text = "";
            txtMobileNumber.Text = "";
            dtpBirthDate.Value = DateTime.Now.Date;
            dtpJoiningDate.Value = DateTime.Now.Date;
            txtSalalry.Text = "";
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
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
                if (txtEmpId.Text.Trim().Length <= 0)
                {
                    v = false;
                    msg += "Something Went Wrong";
                }
            if (flag == 'A' || flag == 'U')
                if (txtEmployeeName.Text.Trim().Length <= 0)
                {
                    v = false;
                    msg += "Enter the Employee Name";
                }
            if (flag == 'A' || flag == 'U')
                if (txtAddress.Text.Trim().Length <= 0)
                {
                    v = false;
                    msg += "Enter the Address";
                }
            if (flag == 'A' || flag == 'U')
                if (txtMobileNumber.Text.Trim().Length <= 0)
                {
                    v = false;
                    msg += "Enter the Mobile Number";
                }
            if (flag == 'A' || flag == 'U')
                if (txtSalalry.Text.Trim().Length <= 0)
                {
                    v = false;
                    msg += "Enter Salary";
                }
            return v;
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string msg = "";
                if (optadd.Checked)
                {

                    if (Validate('A', out msg))
                    {
                        bl_obj.Emp_Name = txtEmployeeName.Text;
                        bl_obj.Emp_Add = txtAddress.Text;
                        bl_obj.Emp_Mob = txtMobileNumber.Text;
                        bl_obj.Emp_BirthDate = dtpBirthDate.Value.ToString("yyyy-MM-dd");
                        bl_obj.Emp_JoinDate = dtpJoiningDate.Value.ToString("yyyy-MM-dd");

                        bl_obj.Emp_Sal = decimal.Parse(txtSalalry.Text);
                        FillLVW(bl_obj.INSERT(bl_obj));
                        ClearControls();
                        KryptonMessageBox.Show("Record Save Successfilly", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MyMessageBox.ShowBox(msg);
                }
                else if (optedit.Checked)
                {
                    if (Validate('U', out msg))
                    {
                        bl_obj.Emp_Id = int.Parse(txtEmpId.Text);
                        bl_obj.Emp_Name = txtEmployeeName.Text;
                        bl_obj.Emp_Add = txtAddress.Text;
                        bl_obj.Emp_Mob = txtMobileNumber.Text;
                        bl_obj.Emp_BirthDate = dtpBirthDate.Value.ToString("yyyy-MM-dd");
                        bl_obj.Emp_JoinDate = dtpJoiningDate.Value.ToString("yyyy-MM-dd");
                        bl_obj.Emp_Sal = decimal.Parse(txtSalalry.Text);
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
                                //txtCustomerId.Text = l.Tag.ToString();
                                //l.Tag = txtCustomerId.Text;
                                bl_obj.Emp_Id = Convert.ToInt32(l.Tag.ToString());
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


        private void FRM_EMPLOYEEMASTER_Load(object sender, EventArgs e)
        {
            function.settheme(this);
            optadd.Checked = true;
            FillLVW(bl_obj.SELECT(bl_obj));
            //dtpBirthDate.Value = DateTime.Parse( "21 / 01 / 2000");
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;   // Do not resize the form.
        }

        private void optadd_CheckedChanged(object sender, EventArgs e)
        {
            if (optadd.Checked == true)
            {
                ClearControls();
                txtEmployeeName.Focus();
                txtEmpId.Text = "";
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

        private void optedit_CheckedChanged(object sender, EventArgs e)
        {
            if (optedit.Checked == true)
            {
                ClearControls();
                txtEmployeeName.Focus();
                btnSubmit.Text = "Update";
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
                ClearControls();
                txtEmployeeName.Focus();
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

        private void btnPreview_Click(object sender, EventArgs e)
        {
            try
            {
                module_Rpt.rpt_name = "FRM_EMPLOYEEMASTER";
                Business_Report.Report_Viewer rpt = new Business_Report.Report_Viewer();
                rpt.Show();
            }
            catch (Exception err)
            {
                err.GetBaseException();
            }
        }

        private void txtSalalry_KeyPress(object sender, KeyPressEventArgs e)
        {
            bl_obj.validateNumberNotFloat(e);
        }

        private void txtMobileNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            bl_obj.validateNumberNotFloat(e);
        }
    }
}