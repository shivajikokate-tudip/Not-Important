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
    public partial class FRM_PROD_PROCESS : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        BUSSINESS_LAYER.BL bl_obj = new BUSSINESS_LAYER.BL();
        DataSet ds = new DataSet();
        MODULE function = new MODULE();

        public FRM_PROD_PROCESS()
        {
            InitializeComponent();
        }

        private void rb_Boiling_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_Boiling.Checked == true)
            {
                bl_obj.Parameter.Clear();
                bl_obj.Parameter.Add("@Flag", "L");
                bl_obj.Parameter.Add("@ID", "0");
                bl_obj.Parameter.Add("@Code", "BLOING");
                ds = bl_obj.blFill_Para_Name(bl_obj.Parameter, "sp_GetData");

                function.fillcombo(cmb_Preform, ds.Tables[0]);
                function.fillcombo(cmbBloing, ds.Tables[1]);
                groupBox2.Visible = true;
                groupBox3.Visible = false;
                groupBox4.Visible = false;
                groupBox6.Visible = false;
                groupBox7.Visible = false;
                txtPreform.Text = "0";
                txtBloing.Text = "0";
                clear("Bloing");
            }
        }

        private void rb_Botteling_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_Botteling.Checked == true)
            {
                bl_obj.Parameter.Clear();
                bl_obj.Parameter.Add("@Flag", "L");
                bl_obj.Parameter.Add("@ID", "0");
                bl_obj.Parameter.Add("@Code", "BOTTELING");
                ds = bl_obj.blFill_Para_Name(bl_obj.Parameter, "sp_GetData");

                function.fillcombo(cmbBBloing, ds.Tables[0]);
                function.fillcombo(cmbBCapping, ds.Tables[1]);
                function.fillcombo(cmbBBottle, ds.Tables[2]);
                groupBox2.Visible = false;
                groupBox3.Visible = true;
                groupBox4.Visible = false;
                groupBox6.Visible = false;
                groupBox7.Visible = false;
                clear("Botteling");
            }
        }

        private void rb_Boxing_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_Boxing.Checked == true)
            {
                bl_obj.Parameter.Clear();
                bl_obj.Parameter.Add("@Flag", "L");
                bl_obj.Parameter.Add("@ID", "0");
                bl_obj.Parameter.Add("@Code", "BOXING");
                ds = bl_obj.blFill_Para_Name(bl_obj.Parameter, "sp_GetData");

                function.fillcombo(cmbBoxBottle, ds.Tables[0]);
                function.fillcombo(cmbBox, ds.Tables[1]);

                DataSet ds1 = bl_obj.blFill("sp_GetItem");
                function.fillcombo(kryptonComboBox1, ds1.Tables[0]);
                groupBox2.Visible = false;
                groupBox3.Visible = false;
                groupBox4.Visible = true;
                groupBox6.Visible = false;
                groupBox7.Visible = false;
                clear("Boxing");
            }
        }
        private void rbOtherMaterial_CheckedChanged(object sender, EventArgs e)
        {
            if (rbOtherMaterial.Checked == true)
            {
                bl_obj.Parameter.Clear();
                bl_obj.Parameter.Add("@Flag", "L");
                bl_obj.Parameter.Add("@ID", "0");
                bl_obj.Parameter.Add("@Code", "OTHER");
                ds = bl_obj.blFill_Para_Name(bl_obj.Parameter, "sp_GetData");

                function.fillcombo(cmbOtherMaterial, ds.Tables[0]);
                groupBox2.Visible = false;
                groupBox3.Visible = false;
                groupBox4.Visible = false;
                groupBox6.Visible = true;
                groupBox7.Visible = false;
                clear("Other");
            }
        }
        private void rbStock_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_Stock.Checked == true)
            {
                bl_obj.Parameter.Clear();
                bl_obj.Parameter.Add("@Flag", "L");
                bl_obj.Parameter.Add("@ID", "0");
                bl_obj.Parameter.Add("@Code", "Stock");
                ds = bl_obj.blFill_Para_Name(bl_obj.Parameter, "sp_GetData");

                function.fillcombo(cmb_Item, ds.Tables[0]);
                groupBox2.Visible = false;
                groupBox3.Visible = false;
                groupBox4.Visible = false;
                groupBox6.Visible = false;
                groupBox7.Visible = true;
                clear("Stock");
            }
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {

            if (Validate1())
            {
                if (rb_Boiling.Checked)
                {
                    if (Validate("Bloing"))
                    {
                        bl_obj.Parameter.Clear();
                        bl_obj.Parameter.Add("@Flag", "O");
                        bl_obj.Parameter.Add("@ID", cmb_Preform.SelectedValue.ToString());
                        bl_obj.Parameter.Add("@Emp_Id", cmbEmployee.SelectedValue.ToString());
                        bl_obj.Parameter.Add("@Shift", (rbShift1.Checked == true ? "1" : "2"));
                        bl_obj.Parameter.Add("@Code", "Out");
                        bl_obj.Parameter.Add("@Date", DateTime.Now.Date.ToString("yyyy-MM-dd"));
                        bl_obj.Parameter.Add("@Qty", txtPreform.Text.Trim());
                        bl_obj.Parameter.Add("@Consume", txtConsume.Text.Trim());
                        ds = bl_obj.blFill_Para_Name(bl_obj.Parameter, "sp_GetData");
                        bl_obj.Parameter.Clear();
                        bl_obj.Parameter.Add("@Flag", "O");
                        bl_obj.Parameter.Add("@ID", cmbBloing.SelectedValue.ToString());
                        bl_obj.Parameter.Add("@Emp_Id", cmbEmployee.SelectedValue.ToString());
                        bl_obj.Parameter.Add("@Shift", (rbShift1.Checked == true ? "1" : "2"));
                        bl_obj.Parameter.Add("@Code", "In");
                        bl_obj.Parameter.Add("@Date", DateTime.Now.Date.ToString("yyyy-MM-dd"));
                        bl_obj.Parameter.Add("@Qty", txtBloing.Text.Trim());
                        bl_obj.Parameter.Add("@Consume", "0");
                        ds = bl_obj.blFill_Para_Name(bl_obj.Parameter, "sp_GetData");

                        KryptonMessageBox.Show("Record Inserted Successfully");
                        clear("Bloing");
                    }
                }
                else if (rb_Botteling.Checked)
                {
                    if (Validate("Botteling"))
                    {
                        bl_obj.Parameter.Clear();
                        bl_obj.Parameter.Add("@Flag", "O");
                        bl_obj.Parameter.Add("@ID", cmbBBloing.SelectedValue.ToString());
                        bl_obj.Parameter.Add("@Emp_Id", cmbEmployee.SelectedValue.ToString());
                        bl_obj.Parameter.Add("@Shift", (rbShift1.Checked == true ? "1" : "2"));
                        bl_obj.Parameter.Add("@Code", "Out");
                        bl_obj.Parameter.Add("@Date", DateTime.Now.Date.ToString("yyyy-MM-dd"));
                        bl_obj.Parameter.Add("@Qty", txtBBloing.Text.Trim());
                        bl_obj.Parameter.Add("@Consume", txtBConsume.Text.Trim());
                        ds = bl_obj.blFill_Para_Name(bl_obj.Parameter, "sp_GetData");

                        bl_obj.Parameter.Clear();
                        bl_obj.Parameter.Add("@Flag", "O");
                        bl_obj.Parameter.Add("@ID", cmbBCapping.SelectedValue.ToString());
                        bl_obj.Parameter.Add("@Emp_Id", cmbEmployee.SelectedValue.ToString());
                        bl_obj.Parameter.Add("@Shift", (rbShift1.Checked == true ? "1" : "2"));
                        bl_obj.Parameter.Add("@Code", "Out");
                        bl_obj.Parameter.Add("@Date", DateTime.Now.Date.ToString("yyyy-MM-dd"));
                        bl_obj.Parameter.Add("@Qty", txtBCapping.Text.Trim());
                        bl_obj.Parameter.Add("@Consume", txtBCapConsume.Text.Trim());
                        ds = bl_obj.blFill_Para_Name(bl_obj.Parameter, "sp_GetData");

                        bl_obj.Parameter.Clear();
                        bl_obj.Parameter.Add("@Flag", "O");
                        bl_obj.Parameter.Add("@ID", cmbBBottle.SelectedValue.ToString());
                        bl_obj.Parameter.Add("@Emp_Id", cmbEmployee.SelectedValue.ToString());
                        bl_obj.Parameter.Add("@Shift", (rbShift1.Checked == true ? "1" : "2"));
                        bl_obj.Parameter.Add("@Code", "In");
                        bl_obj.Parameter.Add("@Date", DateTime.Now.Date.ToString("yyyy-MM-dd"));
                        bl_obj.Parameter.Add("@Qty", txtBBottle.Text.Trim());
                        bl_obj.Parameter.Add("@Consume", "0");
                        ds = bl_obj.blFill_Para_Name(bl_obj.Parameter, "sp_GetData");
                        KryptonMessageBox.Show("Record Inserted Successfully");
                        clear("Botteling");
                    }
                }
                else if (rb_Boxing.Checked)
                {

                    if (Validate("Boxing"))
                    {
                        bl_obj.Parameter.Clear();
                        bl_obj.Parameter.Add("@Flag", "O");
                        bl_obj.Parameter.Add("@ID", cmbBoxBottle.SelectedValue.ToString());
                        bl_obj.Parameter.Add("@Emp_Id", cmbEmployee.SelectedValue.ToString());
                        bl_obj.Parameter.Add("@Shift", (rbShift1.Checked == true ? "1" : "2"));
                        bl_obj.Parameter.Add("@Code", "Out");
                        bl_obj.Parameter.Add("@Date", DateTime.Now.Date.ToString("yyyy-MM-dd"));
                        bl_obj.Parameter.Add("@Qty", txtBoxBottle.Text.Trim());
                        bl_obj.Parameter.Add("@Consume", "0");
                        ds = bl_obj.blFill_Para_Name(bl_obj.Parameter, "sp_GetData");
                        bl_obj.Parameter.Clear();
                        bl_obj.Parameter.Add("@Flag", "O");
                        bl_obj.Parameter.Add("@ID", cmbBox.SelectedValue.ToString());
                        bl_obj.Parameter.Add("@Emp_Id", cmbEmployee.SelectedValue.ToString());
                        bl_obj.Parameter.Add("@Shift", (rbShift1.Checked == true ? "1" : "2"));
                        bl_obj.Parameter.Add("@Code", "Out");
                        bl_obj.Parameter.Add("@Date", DateTime.Now.Date.ToString("yyyy-MM-dd"));
                        bl_obj.Parameter.Add("@Qty", txtBox.Text.Trim());
                        bl_obj.Parameter.Add("@Consume", "0");
                        ds = bl_obj.blFill_Para_Name(bl_obj.Parameter, "sp_GetData");

                        /////////////////////////////////Start For Item Inword////////////////////////////

                        bl_obj.Parameter.Clear();
                        bl_obj.Parameter.Add("@Emp_Id", cmbEmployee.SelectedValue.ToString());
                        bl_obj.Parameter.Add("@Shift", (rbShift1.Checked == true ? "1" : "2"));
                        bl_obj.Parameter.Add("@Stock_Id", "0");
                        bl_obj.Parameter.Add("@SubItemId", kryptonComboBox1.SelectedValue.ToString());
                        bl_obj.Parameter.Add("@Sys_Date", DateTime.Now.Date.ToString("yyyy-MM-dd"));
                        bl_obj.Parameter.Add("@Tran_Date", DateTime.Now.Date.ToString("yyyy-MM-dd"));
                        bl_obj.Parameter.Add("@Opening_Stock", "0");
                        bl_obj.Parameter.Add("@Inword_Stock", txtBox.Text.Trim());
                        bl_obj.Parameter.Add("@Outword_Stock", "0");
                        bl_obj.Parameter.Add("@Closing_Stock", "0");

                        ds = bl_obj.blFill_Para_Name(bl_obj.Parameter, "SP_StockMaintainance");
                        KryptonMessageBox.Show("Record Inserted Successfully");
                        clear("Boxing");
                        /////////////////////////////////End For Item Inword////////////////////////////
                    }

                }
                else if (rbOtherMaterial.Checked)
                {
                    if (Validate("Other"))
                    {
                        bl_obj.Parameter.Clear();
                        bl_obj.Parameter.Add("@Flag", "O");
                        bl_obj.Parameter.Add("@ID", cmbOtherMaterial.SelectedValue.ToString());
                        bl_obj.Parameter.Add("@Emp_Id", cmbEmployee.SelectedValue.ToString());
                        bl_obj.Parameter.Add("@Shift", (rbShift1.Checked == true ? "1" : "2"));
                        bl_obj.Parameter.Add("@Code", "Out");
                        bl_obj.Parameter.Add("@Date", DateTime.Now.Date.ToString("yyyy-MM-dd"));
                        bl_obj.Parameter.Add("@Qty", txtConsumeOther.Text.Trim());
                        bl_obj.Parameter.Add("@Consume", "0");
                        ds = bl_obj.blFill_Para_Name(bl_obj.Parameter, "sp_GetData");
                        KryptonMessageBox.Show("Record Inserted Successfully");
                        clear("Other");
                    }
                }
                else if (rb_Stock.Checked)
                {
                    if (Validate("Stock"))
                    {
                        bl_obj.Parameter.Clear();
                        bl_obj.Parameter.Add("@Emp_Id", cmbEmployee.SelectedValue.ToString());
                        bl_obj.Parameter.Add("@Shift", (rbShift1.Checked == true ? "1" : "2"));
                        bl_obj.Parameter.Add("@Stock_Id", "0");
                        bl_obj.Parameter.Add("@SubItemId", cmb_Item.SelectedValue.ToString());
                        bl_obj.Parameter.Add("@Sys_Date", DateTime.Now.Date.ToString("yyyy-MM-dd"));
                        bl_obj.Parameter.Add("@Tran_Date", DateTime.Now.Date.ToString("yyyy-MM-dd"));
                        bl_obj.Parameter.Add("@Opening_Stock", "0");
                        bl_obj.Parameter.Add("@Inword_Stock", txt_Stock.Text.Trim());
                        bl_obj.Parameter.Add("@Outword_Stock", "0");
                        bl_obj.Parameter.Add("@Closing_Stock", "0");
                        ds = bl_obj.blFill_Para_Name(bl_obj.Parameter, "SP_StockMaintainance");
                        KryptonMessageBox.Show("Record Inserted Successfully");
                        clear("Stock");
                    }
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmb_Preform_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmb_Preform.SelectedIndex != 0)
                GetStock(cmb_Preform.SelectedValue.ToString(), kryptonLabel4);
        }

        private void cmbBloing_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbBloing.SelectedIndex != 0)
                GetStock(cmbBloing.SelectedValue.ToString(), kryptonLabel5);
        }
        private void cmb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmb_Item.SelectedIndex != 0)
                GetStock(cmb_Item.SelectedValue.ToString(), lbl_AvailableStock);
        }
        private void txtPreform_TextChanged(object sender, EventArgs e)
        {
            if (txtPreform.Text.Trim().CompareTo("") == 0)
            {
                txtPreform.Text = "0";
                txtPreform.SelectAll();
            }
            getDiff(txtPreform, txtBloing, txtConsume);
        }

        private void txtBloing_TextChanged(object sender, EventArgs e)
        {
            if (txtBloing.Text.Trim().CompareTo("") == 0)
            {
                txtBloing.Text = "0";
                txtBloing.SelectAll();
            }
            getDiff(txtPreform, txtBloing, txtConsume);
        }

        private void txtBloing_KeyPress(object sender, KeyPressEventArgs e)
        {
            bl_obj.validateNumber(e);
        }

        private void txtPreform_KeyPress(object sender, KeyPressEventArgs e)
        {
            bl_obj.validateNumber(e);
        }

        private void txtBBloing_TextChanged(object sender, EventArgs e)
        {
            if (txtBBloing.Text.Trim().CompareTo("") == 0)
            {
                txtBBloing.Text = "0";
                txtBBloing.SelectAll();
            }
            getDiff(txtBBloing, txtBBottle, txtBConsume);
        }

        private void txtBCapping_TextChanged(object sender, EventArgs e)
        {
            if (txtBCapping.Text.Trim().CompareTo("") == 0)
            {
                txtBCapping.Text = "0";
                txtBCapping.SelectAll();
            }
        }

        private void txtBBottle_TextChanged(object sender, EventArgs e)
        {
            if (txtBBottle.Text.Trim().CompareTo("") == 0)
            {
                txtBBottle.Text = "0";
                txtBBottle.SelectAll();
            }
            getDiff(txtBBloing, txtBBottle, txtBConsume);
            getDiff(txtBCapping, txtBBottle, txtBCapConsume);
        }

        private void cmbOtherMaterial_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbOtherMaterial.SelectedIndex != 0)
                GetStock(cmbOtherMaterial.SelectedValue.ToString(), kryptonLabel23);
        }

        private void txtBBloing_KeyPress(object sender, KeyPressEventArgs e)
        {
            bl_obj.validateNumber(e);
        }

        private void txtBCapping_KeyPress(object sender, KeyPressEventArgs e)
        {
            bl_obj.validateNumber(e);
        }

        private void txtBBottle_KeyPress(object sender, KeyPressEventArgs e)
        {
            bl_obj.validateNumber(e);
        }

        private void txtBConsume_KeyPress(object sender, KeyPressEventArgs e)
        {
            bl_obj.validateNumber(e);
        }

        private void txtConsume_KeyPress(object sender, KeyPressEventArgs e)
        {
            bl_obj.validateNumber(e);
        }
        private void txtConsumeOther_KeyPress(object sender, KeyPressEventArgs e)
        {
            bl_obj.validateNumber(e);
        }
        private void txtConsumeOther_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //if (txtConsumeOther.Text.Trim().CompareTo("") == 0)
                //{
                //    txtConsumeOther.Text = "0";
                //    txtConsumeOther.SelectAll();
                //}
                //if (cmbOtherMaterial.SelectedIndex != 0)
                //{
                //    if (cmbOtherMaterial.SelectedIndex != 0 && txtConsumeOther.Text.CompareTo("0") != 0)
                //    {

                //    }
                //}
            }
            catch (Exception Ex)
            { }
        }
        private void txtBoxBottle_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtBoxBottle.Text.Trim().CompareTo("") == 0)
                {
                    txtBoxBottle.Text = "0";
                    txtBoxBottle.SelectAll();
                }
                if (cmbBoxBottle.SelectedIndex != 0)
                {
                    if (cmbBox.SelectedIndex != 0 && txtBoxBottle.Text.CompareTo("0") != 0)
                    {
                        getPerBoxQty();
                    }
                }
            }
            catch (Exception Ex)
            { }
        }

        private void txtBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtBox.Text.Trim().CompareTo("") == 0)
                {
                    txtBox.Text = "0";
                    txtBox.SelectAll();
                }
                if (cmbBoxBottle.SelectedIndex != 0)
                {
                    if (cmbBox.SelectedIndex != 0 && txtBox.Text.CompareTo("0") != 0)
                    {
                        getPerBoxQty();
                    }
                }
            }
            catch (Exception Ex)
            { }
        }

        private void txtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            bl_obj.validateNumber(e);
        }

        private void txtBoxBottle_KeyPress(object sender, KeyPressEventArgs e)
        {
            bl_obj.validateNumber(e);
        }
        private void txt_Stock_KeyPress(object sender, KeyPressEventArgs e) 
        {
            bl_obj.validateNumber(e);
        }


        private void GetStock(string ID, KryptonLabel lbl)
        {
            try
            {
                bl_obj.Parameter.Clear();
                bl_obj.Parameter.Add("@Flag", "C"); if(rb_Stock.Checked)bl_obj.Parameter.Add("@Code", "Stock");
                bl_obj.Parameter.Add("@ID", ID);
                ds = bl_obj.blFill_Para_Name(bl_obj.Parameter, "sp_GetData");
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    lbl.Text = ds.Tables[0].Rows[0][0].ToString();
                }
                else
                {
                    lbl.Text = "0";
                }
            }
            catch (Exception Ex)
            { }
        }

        private void cmbBBloing_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbBBloing.SelectedIndex != 0)
                GetStock(cmbBBloing.SelectedValue.ToString(), kryptonLabel7);
        }

        private void cmbBCapping_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbBCapping.SelectedIndex != 0)
                GetStock(cmbBCapping.SelectedValue.ToString(), kryptonLabel6);
        }

        private void cmbBBottle_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbBBottle.SelectedIndex != 0)
                GetStock(cmbBBottle.SelectedValue.ToString(), kryptonLabel10);
        }

        private void cmbBoxBottle_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbBoxBottle.SelectedIndex != 0)
                GetStock(cmbBoxBottle.SelectedValue.ToString(), kryptonLabel13);
        }

        private void cmbBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbBox.SelectedIndex != 0)
                GetStock(cmbBox.SelectedValue.ToString(), kryptonLabel15);
        }
        private void cmb_Item_SelectionChangeCommitted(object sender, EventArgs e) 
        {
            if (cmb_Item.SelectedIndex != 0)
                GetStock(cmb_Item.SelectedValue.ToString(),lbl_AvailableStock);
        }
        private void FRM_PROD_PROCESS_Load(object sender, EventArgs e)
        {
            DataSet ds1 = new DataSet();
            bl_obj.Parameter.Clear();
            bl_obj.Parameter.Add("@Flag", "E");
            ds1 = bl_obj.blFill_Para_Name(bl_obj.Parameter, "sp_GetData");
            function.fillcombo(cmbEmployee, ds1.Tables[0]);
            rb_Botteling.Checked = false;
            rb_Boxing.Checked = false;
            rb_Boiling.Checked = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;   // Do not resize the form.
        }

        private void getDiff(KryptonTextBox txt1, KryptonTextBox txt2, KryptonTextBox txt3)
        {
            txt3.Text = (double.Parse(txt1.Text.Trim().CompareTo("") == 0 ? "0" : txt1.Text.Trim()) - double.Parse(txt2.Text.Trim().CompareTo("") == 0 ? "0" : txt2.Text.Trim())).ToString();
        }

        private bool Validate(string Flag)
        {
            bool Result = false;
           

            if (Flag == "Bloing")
            {
                if (cmb_Preform.SelectedIndex == 0)
                {
                    KryptonMessageBox.Show("Select Preform");
                    Result = false;
                }
                else if (cmbBloing.SelectedIndex == 0)
                {
                    KryptonMessageBox.Show("Select Bloing");
                    Result = false;
                }
                else if (txtPreform.Text.Trim().CompareTo("0") == 0)
                {
                    KryptonMessageBox.Show("Enter Preform Quantity");
                    Result = false;
                }
                else if (int.Parse(txtPreform.Text.Trim().CompareTo("") == 0 ? "0" : txtPreform.Text) > int.Parse(kryptonLabel4.Text.Trim().CompareTo("") == 0 ? "0" : kryptonLabel4.Text.Trim()))
                {
                    KryptonMessageBox.Show("Preform Quantity Must Not Be Greate Than Available");
                    Result = false;
                }
                else if (int.Parse(txtBloing.Text.Trim().CompareTo("") == 0 ? "0" : txtBloing.Text.Trim()) > int.Parse(txtPreform.Text.Trim().CompareTo("") == 0 ? "0" : txtPreform.Text.Trim()))
                {
                    KryptonMessageBox.Show("Bloing Quantity Must Not Be Greate Than Used Preform");
                    Result = false;
                }
                else
                {
                    Result = true;
                }

            }
            if (Flag == "Botteling")
            {
                if (cmbBBloing.SelectedIndex == 0)
                {
                    KryptonMessageBox.Show("Select Bloing");
                    Result = false;
                }
                else if (cmbBCapping.SelectedIndex == 0)
                {
                    KryptonMessageBox.Show("Select Capping");
                    Result = false;
                }
                else if (cmbBBottle.SelectedIndex == 0)
                {
                    KryptonMessageBox.Show("Select Bottle");
                    Result = false;
                }
                else if (txtBBloing.Text.Trim().CompareTo("0") == 0)
                {
                    KryptonMessageBox.Show("Enter Bloing Quantity");
                    Result = false;
                }
                else if (int.Parse(txtBBloing.Text.Trim().CompareTo("") == 0 ? "0" : txtBBloing.Text) > int.Parse(kryptonLabel7.Text.Trim().CompareTo("") == 0 ? "0" : kryptonLabel7.Text.Trim()))
                {
                    KryptonMessageBox.Show("Bloing Quantity Must Not Be Greate Than Available");
                    Result = false;
                }
                else if (int.Parse(txtBCapping.Text.Trim().CompareTo("") == 0 ? "0" : txtBCapping.Text) > int.Parse(kryptonLabel6.Text.Trim().CompareTo("") == 0 ? "0" : kryptonLabel6.Text.Trim()))
                {
                    KryptonMessageBox.Show("Capping Quantity Must Not Be Greate Than Available");
                    Result = false;
                }
                //else if (int.Parse(txtBCapping.Text.Trim().CompareTo("") == 0 ? "0" : txtBCapping.Text.Trim()) > int.Parse(txtBBloing.Text.Trim().CompareTo("") == 0 ? "0" : txtBBloing.Text.Trim()))
                //{
                //    KryptonMessageBox.Show("Capping Quantity Must Not Be Greate Than Used Bloing");
                //    Result = false;
                //}
                else if (int.Parse(txtBBottle.Text.Trim().CompareTo("") == 0 ? "0" : txtBBottle.Text.Trim()) > int.Parse(txtBBloing.Text.Trim().CompareTo("") == 0 ? "0" : txtBBloing.Text.Trim()))
                {
                    KryptonMessageBox.Show("Bottle Quantity Must Not Be Greate Than Used Bloing");
                    Result = false;
                }
                else
                {
                    Result = true;
                }

            }
            if (Flag == "Boxing")
            {
                if (cmbBoxBottle.SelectedIndex == 0)
                {
                    KryptonMessageBox.Show("Select Bottle");
                    Result = false;
                }
                else if (cmbBox.SelectedIndex == 0)
                {
                    KryptonMessageBox.Show("Select Box");
                    Result = false;
                }
                else if (txtBoxBottle.Text.Trim().CompareTo("0") == 0)
                {
                    KryptonMessageBox.Show("Enter Bottle Quantity");
                    Result = false;
                }
                else if (int.Parse(txtBoxBottle.Text.Trim().CompareTo("") == 0 ? "0" : txtBoxBottle.Text) > int.Parse(kryptonLabel13.Text.Trim().CompareTo("") == 0 ? "0" : kryptonLabel13.Text.Trim()))
                {
                    KryptonMessageBox.Show("Bottle Quantity Must Not Be Greate Than Available");
                    Result = false;
                }
                else if (int.Parse(txtBox.Text.Trim().CompareTo("") == 0 ? "0" : txtBox.Text.Trim()) > int.Parse(txtBoxBottle.Text.Trim().CompareTo("") == 0 ? "0" : txtBoxBottle.Text.Trim()))
                {
                    KryptonMessageBox.Show("Box Quantity Must Not Be Greate Than Used Bottle");
                    Result = false;
                }
                else if (kryptonComboBox1.SelectedIndex == 0)
                {
                    KryptonMessageBox.Show("Select Product");
                    Result = false;
                }
                else
                {
                    Result = true;
                }

            }
            if (Flag == "Other")
            {
                if (cmbOtherMaterial.SelectedIndex == 0)
                {
                    KryptonMessageBox.Show("Select Product");
                    Result = false;
                }
                else if (txtConsumeOther.Text.Trim().CompareTo("0") == 0)
                {
                    KryptonMessageBox.Show("Enter Product Quantity");
                    Result = false;
                }
                else if (txtConsumeOther.Text.Trim().CompareTo("") == 0)
                {
                    KryptonMessageBox.Show("Enter Product Quantity");
                    Result = false;
                }
                else if (double.Parse(txtConsumeOther.Text.Trim().CompareTo("") == 0 ? "0" : txtConsumeOther.Text) > double.Parse(kryptonLabel23.Text.Trim().CompareTo("") == 0 ? "0" : kryptonLabel23.Text.Trim()))
                {
                    KryptonMessageBox.Show("Quantity Must Not Be Greate Than Available");
                    Result = false;
                }
                else
                {
                    Result = true;
                }
            }
            if (Flag == "Stock")
            {
                if (cmb_Item.SelectedIndex == 0)
                {
                    KryptonMessageBox.Show("Select Product");
                    Result = false;
                }
                else if (txt_Stock.Text.Trim().CompareTo("0") == 0)
                {
                    KryptonMessageBox.Show("Enter Product Quantity");
                    Result = false;
                }
                else if (txt_Stock.Text.Trim().CompareTo("") == 0)
                {
                    KryptonMessageBox.Show("Enter Product Quantity");
                    Result = false;
                }
                //else if (double.Parse(txt_Stock.Text.Trim().CompareTo("") == 0 ? "0" : txt_Stock.Text) > double.Parse(lbl_AvailableStock.Text.Trim().CompareTo("") == 0 ? "0" : lbl_AvailableStock.Text.Trim()))
                //{
                //    KryptonMessageBox.Show("Quantity Must Not Be Greate Than Available");
                //    Result = false;
                //}
                else
                {
                    Result = true;
                }
            }
            
            return Result;
        }
        private bool Validate1()
        {
            bool Result = false;
            if (cmbEmployee.SelectedIndex == 0)
            {
                KryptonMessageBox.Show("Select Employee");
                Result = false;
            }

            else if (rbShift1.Checked == false && rbShift2.Checked == false)
            {
                KryptonMessageBox.Show("Select Shift");
                Result = false;
            }
            else
            {
                Result = true;
            }
            return Result;
        }
        private void clear(string a)
        {


            if (a.CompareTo("Bloing") == 0)
            {
                cmb_Preform.SelectedIndex = 0;
                txtPreform.Clear();
                cmbBloing.SelectedIndex = 0;
                txtBloing.Clear();
                txtConsume.Text = "0";
                kryptonLabel4.Text = "";
                kryptonLabel5.Text = "";

            }

            else if (a.CompareTo("Botteling") == 0)
            {
                cmbBBloing.SelectedIndex = 0;
                txtBBloing.Clear();
                cmbBCapping.SelectedIndex = 0;
                txtBCapping.Clear();
                cmbBBottle.SelectedIndex = 0;
                txtBBottle.Clear();
                txtBConsume.Text = "0";
                kryptonLabel7.Text = "";
                kryptonLabel6.Text = "";
                kryptonLabel10.Text = "";
            }

            else if (a.CompareTo("Boxing") == 0)
            {
                cmbBoxBottle.SelectedIndex = 0;
                txtBoxBottle.Clear();
                cmbBox.SelectedIndex = 0;
                txtBox.Clear();
                kryptonComboBox1.SelectedIndex = 0;
                kryptonLabel13.Text = "";
                kryptonLabel15.Text = "";
            }
            else if (a.CompareTo("Other") == 0)
            {
                cmbOtherMaterial.SelectedIndex = 0;
                txtConsumeOther.Clear();
                kryptonLabel23.Text = "";
            }
            else if (a.CompareTo("Stock") == 0)
            {
                cmb_Item.SelectedIndex = 0;
                txt_Stock.Clear();
                lbl_AvailableStock.Text = "";
            }

        }

        private void cmbBoxBottle_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbBoxBottle.SelectedIndex != 0)
                {
                    if (cmbBox.SelectedIndex != 0)
                    {
                        getPerBoxQty();
                    }
                }
            }
            catch (Exception Ex)
            { }
        }

        private void cmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbBoxBottle.SelectedIndex != 0)
                {
                    if (cmbBox.SelectedIndex != 0)
                    {
                        getPerBoxQty();
                    }
                }
            }
            catch (Exception Ex)
            { }
        }

        private void getPerBoxQty()
        {
            List<string> Para_Name = new List<string>();
            List<string> Para_Value = new List<string>();
            Para_Name.Clear();
            Para_Value.Clear();
            Para_Name.Add("@Bottle_ID");
            Para_Name.Add("@Box_ID");
            Para_Name.Add("@Flag");
            Para_Value.Add(cmbBoxBottle.SelectedValue.ToString());
            Para_Value.Add(cmbBox.SelectedValue.ToString());
            Para_Value.Add("G");


            DataSet dsdata = bl_obj.blFill_Para_Name(Para_Name, Para_Value, "sp_Tbl_BottleQty_Per_Box_Type");

            if (dsdata.Tables.Count > 0 && dsdata.Tables[0].Rows.Count > 0)
            {
                int PerBoxQty = 0;
                if (int.Parse(txtBoxBottle.Text.Trim()) < int.Parse(dsdata.Tables[0].Rows[0][0].ToString().Trim()))
                    txtBox.Text = "1";
                else if (int.Parse(txtBoxBottle.Text.Trim()) == int.Parse(dsdata.Tables[0].Rows[0][0].ToString().Trim()))
                    txtBox.Text = "1";
                else
                {
                    PerBoxQty = int.Parse(txtBoxBottle.Text.Trim()) / int.Parse(dsdata.Tables[0].Rows[0][0].ToString().Trim());
                    if (int.Parse(txtBoxBottle.Text.Trim()) % int.Parse(dsdata.Tables[0].Rows[0][0].ToString().Trim()) != 0)
                        txtBox.Text = (PerBoxQty + 1).ToString();
                    else
                        txtBox.Text = PerBoxQty.ToString();
                }
            }

        }

        
    }
}