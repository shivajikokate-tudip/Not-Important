using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace BILLING_SYSTEM
{
    public partial class FRM_Vehical_Details : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        BUSSINESS_LAYER.BL bl_obj = new BUSSINESS_LAYER.BL();
        MODULE function = new MODULE();
        List<string> ParaName = new List<string>();
        List<string> Para = new List<string>();
        DataSet ds = new DataSet();
        public FRM_Vehical_Details()
        {
            InitializeComponent();
        }

        private void FRM_Vehical_Details_Load(object sender, EventArgs e)
        {
            ds = bl_obj.blFill("SP_TransportationMaster");
            function.fillcombo(cmbTransport, ds);
        }

        private void optadd_CheckedChanged(object sender, EventArgs e)
        {
            if (optadd.Checked == true)
            {
                lvw.CheckBoxes = false;
            }
        }

        private void optedit_CheckedChanged(object sender, EventArgs e)
        {
            if (optedit.Checked == true)
            {
                lvw.CheckBoxes = false;
            }
        }

        private void optdelete_CheckedChanged(object sender, EventArgs e)
        {
            if (optdelete.Checked == true)
            {
                lvw.CheckBoxes = true;
            }
        }

        private void cmbTransport_SelectedIndexChanged(object sender, EventArgs e)
        {
                DataSet dsdata = new DataSet();
                Para.Clear();
                ParaName.Clear();
                ParaName.Add("@Transportation_ID");
                ParaName.Add("@Flag");
                Para.Add(cmbTransport.SelectedIndex==0?"0": cmbTransport.SelectedValue.ToString());
                Para.Add("S");
                if (cmbTransport.SelectedIndex == 0)
                {
                    dsdata = bl_obj.blFill("sp_Vehical_Details");
                }
                else
                {
                    dsdata = bl_obj.blFill_Para_Name(ParaName, Para, "sp_Vehical_Details");
                }
                FillLVW(dsdata);
            
        }
        private void FillLVW(DataSet ds)
        {
            try
            {
                lvw.Clear();
                List<ListViewColumnsInfo> list = new List<ListViewColumnsInfo>();                
                list.Add(new ListViewColumnsInfo() { ColNumber = 1, ColumnSize = 200, Header = "Vehical No", Visible = true });
                list.Add(new ListViewColumnsInfo() { ColNumber = 2, ColumnSize = 200, Header = "Name", Visible = true });
                list.Add(new ListViewColumnsInfo() { ColNumber = 3, ColumnSize = 100, Header = "Address", Visible = true });
                list.Add(new ListViewColumnsInfo() { ColNumber = 4, ColumnSize = 100, Header = "Contact", Visible = true });
                list.Add(new ListViewColumnsInfo() { ColNumber = 5, ColumnSize = 0, Header = "Is_Active", Visible = false });
                list.Add(new ListViewColumnsInfo() { ColNumber = 6, ColumnSize = 0, Header = "Transportation_ID", Visible = false });
                list.Add(new ListViewColumnsInfo() { ColNumber = 6, ColumnSize = 100, Header = "Description", Visible = true });
                list.Add(new ListViewColumnsInfo() { ColNumber = 0, ColumnSize = 0, Header = "ID", Visible = false });
                function.filllvw(lvw, ds, list, ColumnHeaderStyle.Nonclickable, 0, 0);
            }
            catch (Exception err) { err.GetBaseException(); }
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Para.Clear();
            ParaName.Clear();
            string msg = "";
            if (optadd.Checked == true)
            {
                if (Validate('A', out msg))
                {
                    ParaName.Add("@Vehical_No");
                    ParaName.Add("@Employee_Name");
                    ParaName.Add("@Employee_Address");
                    ParaName.Add("@Contact");
                    ParaName.Add("@Transportation_ID");
                    ParaName.Add("@Description");
                    ParaName.Add("@Flag");
                    Para.Add(txtVehical_No.Text.Trim());
                    Para.Add(txtEmployeeName.Text.Trim());
                    Para.Add(txtAddress.Text.Trim());
                    Para.Add(txtMobileNumber.Text.Trim());
                    Para.Add(cmbTransport.SelectedValue.ToString());
                    Para.Add(txtDescription.Text.Trim());
                    Para.Add("A");
                    bl_obj.blFill_Para_Name(ParaName, Para, "sp_Vehical_Details");
                    KryptonMessageBox.Show("Record Save Successfilly", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                    MyMessageBox.ShowBox(msg);
            }
            else if (optedit.Checked == true)
            {
                if (Validate('U', out msg))
                {
                    ParaName.Add("@ID");
                    ParaName.Add("@Vehical_No");
                    ParaName.Add("@Employee_Name");
                    ParaName.Add("@Employee_Address");
                    ParaName.Add("@Contact");
                    ParaName.Add("@Transportation_ID");
                    ParaName.Add("@Description");
                    ParaName.Add("@Flag");
                    Para.Add(txtEmpId.Text.Trim());
                    Para.Add(txtVehical_No.Text.Trim());
                    Para.Add(txtEmployeeName.Text.Trim());
                    Para.Add(txtAddress.Text.Trim());
                    Para.Add(txtMobileNumber.Text.Trim());
                    Para.Add(cmbTransport.SelectedValue.ToString());
                    Para.Add(txtDescription.Text.Trim());
                    Para.Add("U");
                    bl_obj.blFill_Para_Name(ParaName, Para, "sp_Vehical_Details");
                    KryptonMessageBox.Show("Record Update Successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                    MyMessageBox.ShowBox(msg);
            }
            else if (optdelete.Checked == true)
            {
                
               
                if (Validate('D', out msg))
                {
                    if (KryptonMessageBox.Show("Do You Want To delete These record(s)?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        foreach (ListViewItem l in lvw.CheckedItems)
                        {
                            ParaName.Clear();
                            Para.Clear();
                            ParaName.Add("@ID");
                            ParaName.Add("@Flag");

                            Para.Add(l.SubItems[0].Text.Trim());
                            Para.Add("D");
                            bl_obj.blFill_Para_Name(ParaName, Para, "sp_Vehical_Details");
                        }
                        
                        //ClearControls();
                        KryptonMessageBox.Show("Record(s) deleted Successfully", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                    MyMessageBox.ShowBox(msg);
            }
            ClearControls();
            
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
                if (cmbTransport.SelectedIndex== 0)
                {
                    v = false;
                    msg += "Select Transport";
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
                if (txtVehical_No.Text.Trim().Length <= 0)
                {
                    v = false;
                    msg += "Enter Vehicle Number";
                }
            return v;
        }
        public void ClearControls()
        {
            txtEmpId.Text = "";
            txtEmployeeName.Text = "";
            txtAddress.Text = "";
            txtMobileNumber.Text = "";
           
            txtVehical_No.Text = "";
            txtDescription.Clear();
            cmbTransport.SelectedIndex = 0;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lvw_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem lm in lvw.SelectedItems)
            {
                txtEmpId.Text = lm.SubItems[0].Text;
                txtVehical_No.Text = lm.SubItems[1].Text;
                txtEmployeeName.Text = lm.SubItems[2].Text;
                txtAddress.Text = lm.SubItems[3].Text;
                txtMobileNumber.Text = lm.SubItems[4].Text;
                cmbTransport.SelectedValue = lm.SubItems[6].Text;
                txtDescription.Text = lm.SubItems[7].Text;
            }
        }
    }
}