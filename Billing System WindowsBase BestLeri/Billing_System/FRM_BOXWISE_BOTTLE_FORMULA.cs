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
    public partial class FRM_BOXWISE_BOTTLE_FORMULA : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        BUSSINESS_LAYER.BL bl_obj = new BUSSINESS_LAYER.BL();
        DataSet ds = new DataSet();
        MODULE function = new MODULE();
        public FRM_BOXWISE_BOTTLE_FORMULA()
        {
            InitializeComponent();
        }

        private void optadd_CheckedChanged(object sender, EventArgs e)
        {
            if (optadd.Checked)
            lvw.CheckBoxes = false;
        }

        private void optedit_CheckedChanged(object sender, EventArgs e)
        {
            if (optedit.Checked)
            lvw.CheckBoxes = false;
        }

        private void optdelete_CheckedChanged(object sender, EventArgs e)
        {
            if(optdelete.Checked)
            lvw.CheckBoxes = true;
        }

        private void kryptonComboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void kryptonComboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (optadd.Checked)
            {
                if (Validate())
                {
                    bl_obj.Parameter.Clear();
                    bl_obj.Parameter.Add("@ID", "0");
                    bl_obj.Parameter.Add("@Box_ID", kryptonComboBox2.SelectedValue.ToString());
                    bl_obj.Parameter.Add("@Bottle_ID", kryptonComboBox1.SelectedValue.ToString());
                    bl_obj.Parameter.Add("@Per_Box_Qty", txtQty.Text.Trim());
                    bl_obj.Parameter.Add("@Flag", "A"); 

                    ds = bl_obj.blFill_Para_Name(bl_obj.Parameter, "sp_Tbl_BottleQty_Per_Box_Type");
                    KryptonMessageBox.Show("Record Inserted Successfully");
                }
            }
            else if (optedit.Checked)
            {
                if (Validate())
                {
                    bl_obj.Parameter.Clear();
                    bl_obj.Parameter.Add("@ID", txtId.Text.Trim());
                    bl_obj.Parameter.Add("@Box_ID", kryptonComboBox2.SelectedValue.ToString());
                    bl_obj.Parameter.Add("@Bottle_ID", kryptonComboBox1.SelectedValue.ToString());
                    bl_obj.Parameter.Add("@Per_Box_Qty", txtQty.Text.Trim());
                    bl_obj.Parameter.Add("@Flag", "U"); 
                    bl_obj.Parameter.Add("@ID", txtId.Text.Trim());

                    ds = bl_obj.blFill_Para_Name(bl_obj.Parameter, "sp_Tbl_BottleQty_Per_Box_Type");
                    KryptonMessageBox.Show("Record Updated Successfully");
                }
            }
            else if (optdelete.Checked)
            {
                List<string> Para = new List<string>();
                Para.Clear();
                Para.Add("@Flag");
                Para.Add("@ID");
                ds = bl_obj.DeleteRec(lvw,Para,0, "sp_Tbl_BottleQty_Per_Box_Type");
                KryptonMessageBox.Show("Record Deleted Successfully");
            }
            FillLVW(bl_obj.blFill("sp_Tbl_BottleQty_Per_Box_Type"),0);
            optadd.Checked = true;
            kryptonComboBox1.SelectedIndex = 0;
            kryptonComboBox2.SelectedIndex = 0;
            txtQty.Clear();
        }
                

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRM_BOXWISE_BOTTLE_FORMULA_Load(object sender, EventArgs e)
        {
            function.settheme(this);
            bl_obj.Parameter.Clear();
            bl_obj.Parameter.Add("@Flag", "S");

            ds = bl_obj.blFill_Para_Name(bl_obj.Parameter, "sp_Tbl_BottleQty_Per_Box_Type");

            function.fillcombo(kryptonComboBox1, ds.Tables[0]);
            function.fillcombo(kryptonComboBox2, ds.Tables[1]);
            FillLVW(ds,2);
            optadd.Checked = true;

        }
        private void FillLVW(DataSet ds,int tblno)
        {
            try
            {
                lvw.Clear();
                List<ListViewColumnsInfo> list = new List<ListViewColumnsInfo>();
                list.Add(new ListViewColumnsInfo() { ColNumber = 0, ColumnSize =50, Header = "ID", Visible = true });
                list.Add(new ListViewColumnsInfo() { ColNumber = 1, ColumnSize = 50, Header = "Qty", Visible = true });
                list.Add(new ListViewColumnsInfo() { ColNumber = 2, ColumnSize = 150, Header = "Bottle Type", Visible = true });
                list.Add(new ListViewColumnsInfo() { ColNumber = 3, ColumnSize = 0, Header = "Bottle ID", Visible = true });
                list.Add(new ListViewColumnsInfo() { ColNumber = 4, ColumnSize = 150, Header = "Box Type", Visible = true });
                list.Add(new ListViewColumnsInfo() { ColNumber = 5, ColumnSize = 0, Header = "Box ID", Visible = true });
                
                function.filllvw(lvw, ds, list, ColumnHeaderStyle.Nonclickable, tblno, 0);
            }
            catch (Exception err) { err.GetBaseException(); }
        }
        private bool Validate()
        {
            if (kryptonComboBox1.SelectedIndex == 0)
            {
                KryptonMessageBox.Show("Select Bottle");
                return false;
            }
            else if (kryptonComboBox2.SelectedIndex == 0)
            {
                KryptonMessageBox.Show("Select Box");
                return false;
            }
            else if (txtQty.Text.Trim().CompareTo("") == 0)
            {
                KryptonMessageBox.Show("Enter Quantity");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void lvw_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (optedit.Checked == true)
                {
                    ListView.SelectedListViewItemCollection lv = this.lvw.SelectedItems;
                    foreach (ListViewItem im in lv)
                    {
                        kryptonComboBox1.SelectedValue = im.SubItems[3].ToString();
                        kryptonComboBox2.SelectedValue = im.SubItems[5].ToString();
                        txtQty.Text = im.SubItems[0].Text;
                        txtId.Text = im.SubItems[1].Text;
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {

        }
    }
}