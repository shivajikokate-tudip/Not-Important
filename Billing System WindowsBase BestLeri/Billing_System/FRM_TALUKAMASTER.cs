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
    public partial class FRM_TALUKAMASTER : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        MODULE function = new MODULE();
        BL bl_obj = new BL();

        public FRM_TALUKAMASTER()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

        }

        private void FRM_TALUKAMASTER_Load(object sender, EventArgs e)
        {
            function.settheme(this);
            DataSet ds = bl_obj.blFill("SP_VillageMaster");
            FillLVW(ds, 0);
            function.fillcombo(cmbState, ds.Tables[1]);
            //function.fillcombo(cmbDistrict, ds.Tables[2]);
            //function.fillcombo(cmbTaluka, ds.Tables[3]);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;   // Do not resize the form.
        }

        public void FillLVW(DataSet ds, int tableno)
        {
            List<ListViewColumnsInfo> list = new List<ListViewColumnsInfo>();
            list.Add(new ListViewColumnsInfo() { ColNumber = 0, ColumnSize = 0, Header = "SID", Visible = false });
            list.Add(new ListViewColumnsInfo() { ColNumber = 1, ColumnSize = 150, Header = "State NAME", Visible = true });
            list.Add(new ListViewColumnsInfo() { ColNumber = 2, ColumnSize = 0, Header = "DID", Visible = true });
            list.Add(new ListViewColumnsInfo() { ColNumber = 3, ColumnSize = 150, Header = "District NAME", Visible = true });
            list.Add(new ListViewColumnsInfo() { ColNumber = 4, ColumnSize = 0, Header = "TID", Visible = true });
            list.Add(new ListViewColumnsInfo() { ColNumber = 5, ColumnSize = 150, Header = "Taluka NAME", Visible = true });
            list.Add(new ListViewColumnsInfo() { ColNumber = 6, ColumnSize = 0, Header = "VID", Visible = true });
            list.Add(new ListViewColumnsInfo() { ColNumber = 7, ColumnSize = 150, Header = "Village NAME", Visible = true });

            function.filllvw(lvw1: lvw, ds: ds, columns:list, headerstyle: ColumnHeaderStyle.Nonclickable, tableno: tableno, tag_col_no: 6);
        }

        private void cmbState_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbState.SelectedIndex > 0)
            {
                SortedList<string, string> list = new SortedList<string, string>();
                list.Add("@flag", "2");
                list.Add("@State_id", cmbState.SelectedValue.ToString());
                //list.Add ("@flag","3");
                //list.Add ("@flag","3");
                //list.Add ("@flag","3");

                DataSet ds = bl_obj.blFill_Para_Name(list, "SP_FILLDDL");
                function.fillcombo(cmbDistrict, ds.Tables[0]);
            }
        }

        private void cmbDistrict_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbState.SelectedIndex > 0 && cmbDistrict.SelectedIndex > 0)
            {
                SortedList<string, string> list = new SortedList<string, string>();
                list.Add("@flag", "3");
                list.Add("@State_id", cmbState.SelectedValue.ToString());
                list.Add("@District_id", cmbDistrict.SelectedValue.ToString());
                //list.Add ("@flag","3");
                //list.Add ("@flag","3");
                //list.Add ("@flag","3");

                DataSet ds = bl_obj.blFill_Para_Name(list, "SP_FILLDDL");
                function.fillcombo(cmbTaluka, ds.Tables[0]);
            }
        }

    }
        
    }
