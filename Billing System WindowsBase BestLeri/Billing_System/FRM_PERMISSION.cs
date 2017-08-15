using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using System.Data.SqlClient;
using System.Threading;
using BUSSINESS_LAYER;

namespace BILLING_SYSTEM
{
    public partial class FRM_PERMISSION : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        BUSSINESS_LAYER.BL bl_obj = new BUSSINESS_LAYER.BL();
        MODULE function = new MODULE();
        DataSet form_ds = new DataSet();
        DataSet ds_last = new DataSet();
        DataTable form_dt = new DataTable();
        DataSet Original = new DataSet();
        List<string> Para = new List<string>();
        BUSSINESS_LAYER.BL_Permission bl = new BUSSINESS_LAYER.BL_Permission();

        public FRM_PERMISSION()
        {
            InitializeComponent();
        }

        private void FRM_PERMISSION_Load(object sender, EventArgs e)
        {
            function.settheme(this);
            //Para.Clear();
            bl.Group_Id=Convert.ToInt32(MODULE.glb["GROUP_ID"].ToString());
            //Para.Add("F");

            DataSet ds = bl.fillddl(bl);
            function.fillcombo(cmbUserName,ds.Tables[0]); 
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;   // Do not resize the form.
        }
        private void FillLVW(DataSet ds,ListView lvw,int tbl_no)
        {
            lvw.Items.Clear();
            List<ListViewColumnsInfo> list = new List<ListViewColumnsInfo>();
            
            list.Add(new ListViewColumnsInfo() { ColNumber = 0, ColumnSize = 200, Header = "Menu Name", Visible = true });
            list.Add(new ListViewColumnsInfo() { ColNumber = 1, ColumnSize = 0, Header = "Menu_ID", Visible = false });
            list.Add(new ListViewColumnsInfo() { ColNumber = 2, ColumnSize = 200, Header = "Menu Url", Visible = true });


            function.filllvw(lvw, ds, list, ColumnHeaderStyle.Nonclickable, tbl_no, 0);
            lvw.CheckBoxes = true;
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            string[] arr = new string[7];
            foreach (ListViewItem lm in lvw_menu.CheckedItems)
            {   
                //arr[0] = lm.SubItems[0].Text;
                //arr[1] = lm.SubItems[1].Text;
                //arr[2] = lm.SubItems[2].Text;
                //arr[3] = lm.SubItems[3].Text;
                //arr[4] = lm.SubItems[4].Text;
                //arr[5] = lm.SubItems[5].Text;
                //arr[6] = lm.SubItems[6].Text;

               //ListViewItem litem = new ListViewItem(arr);
               lvw.Items.Add((ListViewItem)lm.Clone());
               lvw_menu.Items.Remove((ListViewItem)lm);
                
            }
            DataSet dsdata = Original;
            clear();
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
           
            foreach (ListViewItem lm in lvw.CheckedItems)
            {
                lvw_menu.Items.Add((ListViewItem)lm.Clone());
                lvw.Items.Remove((ListViewItem)lm);
            }
            clear();
        }

        private void clear()
        {
            foreach (ListViewItem lm in lvw_menu.CheckedItems)
            {
                lm.Checked = false;
            }
            foreach (ListViewItem lm in lvw.CheckedItems)
            {
                lm.Checked = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        public void group()
        {
            DataSet ds = new DataSet();
            bl.UserId = Convert.ToInt32(cmbUserName.SelectedValue.ToString());
            ds=bl.DELETE(bl);
            bl.Group_Id = Convert.ToInt32(ds.Tables[0].Rows[0][3].ToString());
        }
        private void btnSaveToDB_Click(object sender, EventArgs e)
        {
            group();   
            bl.INSERT(bl);
            foreach (ListViewItem lm in lvw.Items)
            {               
                bl.Menu_Id = Convert.ToInt32(lm.SubItems[1].Text);
                bl.UPDATE(bl);
            }
            MessageBox.Show("Permission Set Successfully.");
        }

        private void cmbUserName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbUserName.SelectedIndex != 0)
            {
                group(); 
                Para.Clear();
                Para.Add((bl.Group_Id).ToString());
                Para.Add((bl.Group_Id).ToString());
                Para.Add("S");
                
                DataSet ds1 = bl_obj.blFill_para(Para, "sp_menupermission");
                Original = ds1.Copy();
                FillLVW(ds1,lvw_menu,1);
                FillLVW(ds1, lvw, 0);
                lvw.View = View.Details;
                
            }
        }
    }
}