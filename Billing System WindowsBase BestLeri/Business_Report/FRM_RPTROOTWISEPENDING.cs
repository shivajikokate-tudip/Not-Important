using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace Business_Report
{
    public partial class FRM_RPTROOTWISEPENDING : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        BUSSINESS_LAYER.BL bl_obj = new BUSSINESS_LAYER.BL();
        module_Rpt function = new module_Rpt();

        public FRM_RPTROOTWISEPENDING()
        {
            InitializeComponent();
        }

        private void FRM_RPTROOTWISEPENDING_Load(object sender, EventArgs e)
        {
            function.settheme(this);
            DataSet ds = bl_obj.blFill("SP_RootTransaction");
            function.fillcombo(cmbRootName, ds.Tables[1]);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;   // Do not resize the form.
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> para_name = new List<string>();
                para_name.Add("@Data_Id");
                para_name.Add("@flag");
                List<string> para_value = new List<string>();                
                para_value.Add(cmbRootName.SelectedValue.ToString());
                para_value.Add("RT");
                DataSet ds = bl_obj.blFill_para_name(para_name, para_value, "SP_Report");
                function.Show_Report("RptRoot",ds,0);
            }
            catch (Exception err)
            {
                err.GetBaseException();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}