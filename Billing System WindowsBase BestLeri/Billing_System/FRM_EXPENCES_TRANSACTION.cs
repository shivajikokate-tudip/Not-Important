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
    public partial class FRM_EXPENCES_TRANSACTION : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        MODULE function = new MODULE();
        //BL_EXPENCES_TRANSACTION bl_obj = new BL_EXPENCES_TRANSACTION();
        BL_EXPENCES_TRANSACTION bl_obj = new BL_EXPENCES_TRANSACTION();

      
        public FRM_EXPENCES_TRANSACTION()
        {
            InitializeComponent();
        }

        
        private void FillLVW(DataSet ds)
        {
            List<string> col = new List<string>();
            List<string> col_Name = new List<string>();
            List<string> col_Size = new List<string>();

 
            col.Add("1");
            col_Name.Add("TranExpencesId");
            col_Size.Add("10");

            col.Add("2");
            col_Name.Add("ExpencesId");
            col_Size.Add("10");

            col.Add("3");
            col_Name.Add("Sys_date");
            col_Size.Add("10");

            col.Add("4");
            col_Name.Add("Tran_Date");
            col_Size.Add("10");

            col.Add("5");
            col_Name.Add("Description");
            col_Size.Add("10");


            col.Add("6");
            col_Name.Add("Amount");
            col_Size.Add("10");
            
            function.filllvw(lvw, ds, col, col_Name, 0,0, 0);
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
                if (txtTransactionId.Text.Trim().Length <= 0)
                {
                    v = false;
                    msg += "Something Went Wrong";
                }
            if (flag == 'A' || flag == 'U')
                if (comboExpenceName.Text.Trim().Length <= 0)
                {
                    v = false;
                    msg += "Enter the Item Name";
                }
            return v;
        }


        public void ClearControls()
        {
            comboExpenceName.Text = "Select";
            txtDescription.Clear();
            txtTransactionId.Text = "";
            txtAmount.Text = "";


        }

        private void FRM_EXPENCES_TRANSACTION_Load(object sender, EventArgs e)
        {
            function.settheme(this);
            optadd.Checked = true;
            FillLVW(bl_obj.select(bl_obj));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;   // Do not resize the form.
            //FillLVW(bl_obj.select(bl_obj));
            
            //function.settheme(this);
            //optadd.Checked = true;
            ////DataSet ds = bl_obj.blFill("Sp_expencestransaction");
            ////FillLVW(ds);
            ////bl_obj.SELECT(fillcombo(comboExpenceName, ds.Tables[1]));

            //DataSet ds = new DataSet();
            ////FillLVW(bl_obj.SELECT(bl_obj));
            //ds = bl_obj.SELECT(bl_obj);
            //function.fillcombo(comboExpenceName, ds.Tables[1]);
            //FillLVW (ds);
            try
            {

                function.settheme(this);
                //optadd.Checked = true;
                DataSet ds = bl_obj.blFill("Sp_expencestransaction");
                FillLVW(ds);
                function.fillcombo(comboExpenceName, ds.Tables[1]);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }

        }

        //protected void fill_lvw(DataSet ds)
        //{
        //    List<String> col = new List<string>();
        //    col.Add("0");
        //    col.Add("1");
        //    col.Add("2");
        //    col.Add("3");
        //    List<String> col_name = new List<string>();
        //    col_name.Add("ExpencesName");
        //    col_name.Add("Trans_Date");
        //    col_name.Add("Description");
        //    col_name.Add("Amount");
        //    //col_name.Add("IsActive");
        //    List<string> col_Size = new List<string>();
        //    col_Size.Add("10");
        //    col_Size.Add("10");
        //    col_Size.Add("10");
        //    col_Size.Add("10");
        //    function.filllvw(lvw, ds, col, col_name, 0, 0, 0);
        //}

        private void btnsave_Click(object sender, EventArgs e)
        {
            string msg = "";
            if (optadd.Checked)
            {

                if (Validate('A', out msg))
                {
                    bl_obj.ExpencesId = int.Parse(comboExpenceName.SelectedValue.ToString());
                    bl_obj.TransDate = tDate.Value.ToShortDateString();
                    bl_obj.SysDate = DateTime.Now.ToString();
                    bl_obj.Desc = txtDescription.Text;
                    bl_obj.Amount = double.Parse(txtAmount.Text);
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
                    bl_obj.TranExpencesId = Convert.ToInt32(txtTransactionId.Text);
                    bl_obj.ExpencesId = int.Parse(comboExpenceName.SelectedValue.ToString());
                    bl_obj.TransDate = tDate.Value.ToShortDateString();
                    bl_obj.SysDate = DateTime.Now.ToString();
                    bl_obj.Desc = txtDescription.Text;
                    bl_obj.Amount = double.Parse(txtAmount.Text);
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
                            //bl_obj.RowMaterialId = Convert.ToInt32(l.Tag.ToString());
                            bl_obj.TranExpencesId = Convert.ToInt32(l.Tag.ToString());
                            //bl_obj.TranExpencesId = Convert.ToInt32(txtTransactionId.Text);
                            bl_obj.DELETE(bl_obj);
                        }
                        FillLVW(bl_obj.select(bl_obj));
                        ClearControls();
                        KryptonMessageBox.Show("Record(s) deleted Successfully", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                    MyMessageBox.ShowBox(msg);
            }
        }

        private void optadd_CheckedChanged(object sender, EventArgs e)
        {

            if (optadd.Checked == true)
            {
                comboExpenceName.Focus();
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
                comboExpenceName.Focus();
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
                comboExpenceName.Focus();
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

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboExpenceName_SelectedIndexChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    string a = comboExpenceName.SelectedItem .ToString();
            //    int b =  int.Parse (comboExpenceName.SelectedValue .ToString());
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error");
            //                }
        }

        private void lvw_MouseUp(object sender, MouseEventArgs e)
        {
            if (optupdate.Checked)
            {
                ListViewItem l = lvw.HitTest(e.Location).Item;
                if (l != null)
                {
                    txtTransactionId.Text = l.Tag.ToString();
                    comboExpenceName.SelectedItem = l.SubItems[0].Text.ToString();
                    tDate.Value = DateTime.Parse( l.SubItems[1].Text.ToString());
                    txtDescription.Text = l.SubItems[2].Text.ToString();
                    txtAmount.Text = l.SubItems[3].Text.ToString();
                }
                else
                {
                    ClearControls();
                }
            }
        }

        private void lvw_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void kryptonPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}