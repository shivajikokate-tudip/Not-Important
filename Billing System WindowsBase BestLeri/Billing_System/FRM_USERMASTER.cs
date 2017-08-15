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
    public partial class FRM_USERMASTER : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        BUSSINESS_LAYER.BL bl_obj = new BUSSINESS_LAYER.BL();
        MODULE function = new MODULE();
        DataSet form_ds = new DataSet();
        string msg = "";

        public FRM_USERMASTER()
        {
            InitializeComponent();
        }

        private void FRM_USERMASTER_Load(object sender, EventArgs e)
        {
            function.settheme(this);
            DataSet ds = bl_obj.blFill("SP_UserMaster");
            //bl_obj.blFill_para("SP_UserMaster");
            FillLVW(ds);
            function.fillcombo(cmbGroupType, ds.Tables[1]);            
            form_ds = ds;
            optAdd.Checked = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;   // Do not resize the form.
        }

        private void FillLVW(DataSet ds)
        {
            try
            {
                lvw.Clear();
                List<ListViewColumnsInfo> list = new List<ListViewColumnsInfo>();
                list.Add(new ListViewColumnsInfo() { ColNumber = 1, ColumnSize = 120, Header = "User Name", Visible = true });
                list.Add(new ListViewColumnsInfo() { ColNumber = 4, ColumnSize = 120, Header = "Group Type", Visible = true });
                list.Add(new ListViewColumnsInfo() { ColNumber = 0, ColumnSize = 0, Header = "User Id", Visible = true });
                list.Add(new ListViewColumnsInfo() { ColNumber = 2, ColumnSize = 120, Header = "Password", Visible = true });
                list.Add(new ListViewColumnsInfo() { ColNumber = 3, ColumnSize = 0, Header = "Group Id", Visible = true });
                function.filllvw(lvw, ds, list, ColumnHeaderStyle.Nonclickable, 0, 0);
            }
            catch (Exception err) { err.GetBaseException(); }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (validate(optDelete.Checked) == false)
                {
                    if (optAdd.Checked == true)
                    {
                        if (function.SearchTextInListView_on_column_bool(lvw, 0, txtUserName.Text, true) == true)
                        {
                           
                            msg = "- Record already exists\n\n";
                            MyMessageBox.ShowBox(msg);
                        }else 
                        if (txtUserName.Text.CompareTo("") != 0)
                        {
                            List<string> para_name = new List<string>();
                            para_name.Add("@UserName");
                            para_name.Add("@Password");
                            para_name.Add("@GroupID");
                            para_name.Add("@flag");

                            List<string> para_value = new List<string>();
                            para_value.Add(txtUserName.Text);
                            para_value.Add(function.Decrypt(txtPassword.Text));
                            para_value.Add(cmbGroupType.SelectedValue.ToString());
                            para_value.Add("A");
                            DataSet ds = bl_obj.blFill_para_name(para_name, para_value, "SP_UserMaster");
                            KryptonMessageBox.Show("Record Save Successfilly", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            FillLVW(ds);
                            cleartext();

                        }
                    }
                    
                     if (optEdit.Checked == true)
                    {
                        List<string> para_name = new List<string>();

                        para_name.Add("@UserID");
                        para_name.Add("@UserName");
                        para_name.Add("@Password");
                        para_name.Add("@GroupID");
                        para_name.Add("@flag");

                        List<string> para_value = new List<string>();
                        para_value.Add(txtUserId.Text);
                        para_value.Add(txtUserName.Text);
                        para_value.Add(function.Decrypt(txtPassword.Text));
                        para_value.Add(cmbGroupType.SelectedValue.ToString());
                        para_value.Add("U");
                        DataSet ds = bl_obj.blFill_para_name(para_name, para_value, "SP_UserMaster");
                        KryptonMessageBox.Show("Record Update Successfilly", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FillLVW(ds);
                        cleartext();
                    }

                     if (optDelete.Checked == true)
                    {
                        if (lvw.Items.Count != 0)
                        {
                            DialogResult str = MessageBox.Show(this, "Are U Sure To Delete A Record " + txtUserName.Text + "?", "Delete", MessageBoxButtons.YesNo);
                            for (int i = 0; i < lvw.Items.Count; i++)
                            {
                                if (lvw.Items[i].Checked == true)
                                {
                                    if (str.ToString().CompareTo("Yes") == 0)
                                    {
                                        List<string> para_name = new List<string>();

                                        para_name.Add("@UserID");
                                        para_name.Add("@GroupID");
                                        para_name.Add("@flag");

                                        List<string> para_value = new List<string>();
                                        para_value.Add(lvw.Items[i].SubItems[2].Text);
                                        para_value.Add(cmbGroupType.SelectedValue.ToString());
                                        para_value.Add("D");
                                        DataSet ds = bl_obj.blFill_para_name(para_name, para_value, "SP_UserMaster");
                                        KryptonMessageBox.Show("Record Delete Successfilly", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        FillLVW(ds);
                                        cleartext(); optAdd.Checked = true; 
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    //KryptonMessageBox.Show("Record Save Successfilly", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MyMessageBox.ShowBox(msg);
                    //function.Message_Show(this, msg, );
                    msg = "";
                }
            }
            catch (Exception err) { err.GetBaseException(); }
        }
        
        public bool validate(bool isdelete)
        {
            bool v = false;
            if (isdelete == false)
            {
                if (txtUserName.Text.CompareTo("") == 0)
                {
                    v = true;
                    msg = msg + "- Fill User Name  \n\n";
                    //break;
                }
                if (txtPassword.Text.CompareTo("") == 0)
                {
                    v = true;
                    msg = msg + "- Fill Password \n\n";
                    //break;
                }
                if (txtConformPassword.Text.CompareTo("") == 0)
                {
                    v = true;
                    msg = msg + "- Fill Confirm Password \n\n";
                    //break;
                }
                if (txtPassword.Text!=txtConformPassword.Text)
                {
                    v = true;
                    msg = msg + "- Password And Confirm Password Does Not Match \n\n";
                    //break;
                }
                
                else { }
            }
            else
            {
                bool c = false;
                foreach (ListViewItem l in lvw.Items)
                {
                    if (l.Checked == true)
                    {
                        c = true;

                    }
                    //else
                    //    c = false;


                }
                if (c == false)
                {
                    msg = msg + " Please Select The Item To Delete ! ";
                    v = true;
                }
            }
            return v;
        }

        protected void cleartext()
        {
            txtUserName.Text = "";
            txtPassword.Text = "";
            txtConformPassword.Text = "";
            cmbGroupType.SelectedIndex = 0;            
        }

        private void lvw_MouseUp(object sender, MouseEventArgs e)
        {
            ListViewItem l = lvw.HitTest(e.Location).Item;
            if (l != null)
            {
                txtUserId.Text = l.SubItems[2].Text;
                txtUserName.Text = l.SubItems[0].Text;
                txtPassword.Text = function.Encrypt(l.SubItems[3].Text);
                txtConformPassword.Text = function.Encrypt(l.SubItems[3].Text);
                cmbGroupType.SelectedValue = l.SubItems[4].Text;
            }
            else
            {
                cleartext();
            }
        }

        private void txtConformPassword_Leave(object sender, EventArgs e)
        {
            if (txtConformPassword.Text != txtPassword.Text)
                KryptonMessageBox.Show("Please Check Confirm Password");
        }

        private void optDelete_CheckedChanged(object sender, EventArgs e)
        {
            if (optDelete.Checked == true)
            {
                cleartext();
                btnSave.Enabled = true;
                btnSave.Text = "Delete";
                lvw.CheckBoxes = true;
                optDelete.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                btnSave.Enabled = false;
                optDelete.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void optEdit_CheckedChanged(object sender, EventArgs e)
        {
            if (optEdit.Checked == true)
            {
                cleartext();
                btnSave.Text = "Update";
                btnSave.Enabled = true;
                lvw.CheckBoxes = false;
                optEdit.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                btnSave.Enabled = false;
                optEdit.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void optAdd_CheckedChanged(object sender, EventArgs e)
        {
            if (optAdd.Checked == true)
            {
                cleartext();
                btnSave.Text = "Save";
                btnSave.Enabled = true;
                lvw.CheckBoxes = false;
                optAdd.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                btnSave.Enabled = false;
                optAdd.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}