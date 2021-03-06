using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using BUSSINESS_LAYER;
using BILLING_SYSTEM;
using Business_Report;
using System.Reflection;

namespace BILLING_SYSTEM
{
    public partial class FRM_MAIN : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        BL_MAIN_FORM bl_Obj = new BL_MAIN_FORM();
        Report_Name rpt = new Report_Name();
        MODULE function = new MODULE();
        BL_BACKUP bl_back = new BL_BACKUP();
        List<string> Para = new List<string>();
        BL bl = new BL();
        int len = 0;
        int cnt = 0;
        int cnt1 = 0;
        string strcmpname = "";

        public FRM_MAIN()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            cmpanddate.Values.Description = DateTime.Now.ToString();
            if (cnt1 <= len)
            {
                cmpanddate.Values.Heading = strcmpname.Substring(cnt1) + " *** " + strcmpname.Substring(0, cnt1);
                cnt1++;
            }
            else
                cnt1 = 0;
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            function.settheme(this);
            SetPositions();
            cmpanddate.Values.Description = DateTime.Now.ToString();
            //open_form(this, false, "RATION_CARD_ENTRY");
            strcmpname = cmpanddate.Values.Heading.ToString();
            len = strcmpname.Length;
            //////kryptonManager.GlobalPaletteMode = function.PalletMode(function.set_theme_name(true, ""));
            ////SetFontToMenu(menuStrip1);

            //////Bind Event To Menu Control
            ////foreach (ToolStripMenuItem t in menuStrip1.Items)
            ////    SetMenuClicks(t);

            FillHeaderMenu();//For Filling Main Menus
            this.Text = MODULE.glb["SHOP_NAME"].ToString();
            RefreshWindow();
            SetFontToMenu(menuStrip1);//To Set Font For Each Menu
        }

        private void FillHeaderMenu() //For Filling Main Menus
        {

            Para.Clear();
            Para.Add(MODULE.glb["GROUP_ID"].ToString());
            Para.Add("1");
            Para.Add("F");
            DataSet ds = bl.blFill_para(Para, "sp_menupermission");
            menuStrip1.Items.Clear();
            if (ds.Tables.Count > 0)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        ToolStripMenuItem item = new ToolStripMenuItem();
                        item.Name = dr[0].ToString();
                        item.Text = dr[0].ToString();
                        item.Tag = dr[1].ToString();
                        menuStrip1.Items.Add(item);
                    }
                }
            }
            if (ds.Tables.Count > 1)
            {
                FillSubMenu(ds);
            }
            ToolStripMenuItem LogONOff = new ToolStripMenuItem();
            LogONOff.Name = "LogONOff";
            LogONOff.Text = "LOG OFF/ON";
            LogONOff.Click += new System.EventHandler(ChildMenu_Click);
            menuStrip1.Items.Add(LogONOff);
            ToolStripMenuItem Exit = new ToolStripMenuItem();
            Exit.Name = "Exit";
            Exit.Text = "Exit";
            Exit.Click += new System.EventHandler(ChildMenu_Click);
            menuStrip1.Items.Add(Exit);
        }

        private void FillSubMenu(DataSet ds) //For Filling SubMenus
        {
            //foreach (DataRow dr in ds.Tables[1].Rows)
            //{
            //    ToolStripMenuItem Header = new ToolStripMenuItem();
            //    Header.Tag = dr[3].ToString();
            foreach (ToolStripMenuItem im in menuStrip1.Items)
            {
                for (int i = 0; i < ds.Tables[1].Rows.Count; i++)
                {
                    if (im.Tag.ToString().Trim().CompareTo(ds.Tables[1].Rows[i][3].ToString().Trim()) == 0)
                    {
                        ToolStripMenuItem Child = new ToolStripMenuItem();
                        Child.Name = ds.Tables[1].Rows[i][2].ToString();
                        Child.Text = ds.Tables[1].Rows[i][0].ToString();
                        Child.Tag = ds.Tables[1].Rows[i][4].ToString();
                        Child.Click += new System.EventHandler(ChildMenu_Click);
                        im.DropDownItems.Add(Child);
                        if (Child.Tag.ToString().Trim().CompareTo("Y") != 0)
                        {
                            FillSubChild(ds, Child);
                        }


                    }

                }
            }



            //}
        }
        private void FillSubChild(DataSet ds, ToolStripMenuItem CHild)
        {
            //foreach (ToolStripMenuItem subChild in CHild.DropDownItems)
            //{
            //if (subChild.Tag.ToString().Trim().CompareTo("Y") != 0)
            //{
            for (int i = 0; i < ds.Tables[1].Rows.Count; i++)
            {
                if (CHild.Tag.ToString().Trim().CompareTo(ds.Tables[1].Rows[i][3].ToString().Trim()) == 0)
                {
                    ToolStripMenuItem SubChild = new ToolStripMenuItem();
                    SubChild.Name = ds.Tables[1].Rows[i][2].ToString();
                    SubChild.Text = ds.Tables[1].Rows[i][0].ToString();
                    SubChild.Tag = ds.Tables[1].Rows[i][4].ToString();
                    SubChild.Click += new System.EventHandler(ChildMenu_Click);
                    CHild.DropDownItems.Add(SubChild);
                }

            }
            //}
            //}
        }
        private void ChildMenu_Click(object sender, EventArgs e) //For Event Handeler Of Menu
        {
            try{
                if (((ToolStripMenuItem)sender).Text.Trim().CompareTo("Exit") == 0)
                    Application.Exit();
           
                else if (((ToolStripMenuItem)sender).Text.Trim().CompareTo("Backup") == 0)
                {
                    bl_back.select(bl_back);
                    MessageBox.Show("Backup Generated Successfully");
                }
                //else if (((ToolStripMenuItem)sender).Text.Trim().CompareTo("Tax Report") == 0)
                //{
                //    module_Rpt function = new module_Rpt();
                //    BUSSINESS_LAYER.BL bl_obj = new BUSSINESS_LAYER.BL();
                //    DataSet ds = new DataSet();
                //    List<string> para_name = new List<string>();
                //    para_name.Add("@flag");
                //    List<string> para_value = new List<string>();
                //    para_value.Add("TX");
                //    ds = bl_obj.blFill_para_name(para_name, para_value, "SP_Report");
                //    function.Show_Report("RptTax", ds, 0);
                //}
                //else if (((ToolStripMenuItem)sender).Text.Trim().CompareTo("Collection Report") == 0)
                //{
              
                //    module_Rpt function = new module_Rpt();
                //    BUSSINESS_LAYER.BL bl_obj = new BUSSINESS_LAYER.BL();
                //    List<string> para_name = new List<string>();
               
                //    para_name.Add("@flag");
                //    List<string> para_value = new List<string>();
               
                //    para_value.Add("ACTD");

                //    DataSet ds = bl_obj.blFill_para_name(para_name, para_value, "SP_Report");

                //    function.Show_Report("rptDateWiseAllCustTotal", ds,0);
           
                //}
                else if (((ToolStripMenuItem)sender).Name.ToString().Trim().CompareTo("LogONOff") == 0)
                {
                    Dispose(true);
                    //Form.ActiveForm.Hide();
                    BILLING_SYSTEM.FRM_LOGIN f1 = new FRM_LOGIN();
                    f1.Show();
                }
                else
                {
                    if (((ToolStripMenuItem)sender).Name.ToString().Trim().Length > 2)
                    {
                        if (((ToolStripMenuItem)sender).Name.ToString().Substring(2, 6).Trim().CompareTo("Report") == 0)
                        {
                            MODULE.is_rpt = true;
                            open_form(this, false, ((ToolStripMenuItem)sender).Name.ToString().Substring(9));
                        }
                        else
                        {
                            MODULE.is_rpt = false;
                            open_form(this, false, ((ToolStripMenuItem)sender).Name.ToString().Substring(2));
                        }
                    }
                }
            }
            catch (Exception Ex)
            {
                Application.Exit();
            }
        }

        public void SetMenuClicks(ToolStripMenuItem t)
        {
            try
            {
                foreach (ToolStripMenuItem submenu in t.DropDownItems)
                {
                    if (submenu.DropDownItems.Count <= 0)
                    {
                        if (submenu.Tag != null && submenu.Tag.ToString().Trim().Length > 0)

                            submenu.Click += new EventHandler(menuclick_Click);
                    }
                    else
                        SetMenuClicks(submenu);
                    //this.productMasterToolStripMenuItem.Click += new System.EventHandler(this.productMasterToolStripMenuItem_Click);
                }
            }
            catch (Exception Ex)
            { }
        }

        private void menuclick_Click(object sender, EventArgs e)
        {
            string formname = "";
            if (((ToolStripMenuItem)sender).Tag.ToString().Split('-').Length > 0)
                if (((ToolStripMenuItem)sender).Tag.ToString().Split('-')[0].ToString() == "Report")
                {
                    formname = ((ToolStripMenuItem)sender).Tag.ToString().Split('-')[1].ToString();
                    MODULE.is_rpt = true;
                }
                else
                    formname = ((ToolStripMenuItem)sender).Tag.ToString();
            open_form(this, false, formname);
        }

        private bool CheckViewsAre_Exists()
        {
            bool ret = false;
            if (!bl_Obj.CheckViewExists())
            {
                Settings setting = new Settings();
                string path = setting.ConnectionString_Local.ToString().Substring(setting.ConnectionString_Local.LastIndexOf("=") + 1).ToString();
                try
                {
                    bool v = new DatasetToJet().CREATEVIEW(path);
                    if (!v)
                    {
                        KryptonMessageBox.Show("Error In Createing Views ." + Environment.NewLine + "Hence Cannot UPdate Window" + Environment.NewLine);
                        ret = false;
                    }
                    else
                        ret = v;
                }
                catch (Exception ex)
                {
                    KryptonMessageBox.Show(ex.Message.ToString(), "Creating Views Problem");
                    return ret;
                }
            }
            else
            {
                ret = true;
            }
            return ret;
        }

        private void RefreshWindow()
        {
            //bl_Obj.STATE_ID = Convert.ToInt32(MODULE.glb["STATE_ID"].ToString());
            //bl_Obj.DISTRICT_ID = Convert.ToInt32(MODULE.glb["DISTRICT_ID"].ToString());
            //bl_Obj.TALUKA_ID = Convert.ToInt32(MODULE.glb["TALUKA_ID"].ToString());
            //bl_Obj.VILLAGE_ID = Convert.ToInt32(MODULE.glb["VILLAGE_ID"].ToString());
            //bl_Obj.SHOP_ID = Convert.ToInt32(MODULE.glb["SHOP_ID"].ToString());

            //DataSet ds = bl_Obj.SELECT(bl_Obj);
            //if (function.CheckExistsDs(ds, false))
            //{
            //    FillCounts(ds);
            //    FillLVW(ds);
            //}
        }

        private void FillLVW(DataSet ds)
        {
            List<string> col = new List<string>();
            List<string> col_Name = new List<string>();
            List<string> col_Size = new List<string>();
            col.Add("8"); col.Add("1");
            col.Add("2"); col.Add("0");
            col.Add("3"); col.Add("4");
            col.Add("5"); col.Add("6");
            col.Add("8"); col.Add("9");
            col.Add("10"); col.Add("11");
            col.Add("12");
            col_Name.Add("संदर्भ क्र."); col_Name.Add("मराठी नाव"); col_Name.Add("इंग्रजी नाव");
            col_Name.Add("0");
            col_Name.Add("3"); col_Name.Add("4");
            col_Name.Add("5"); col_Name.Add("6");
            col_Name.Add("8"); col_Name.Add("9");
            col_Name.Add("10"); col_Name.Add("11"); col_Name.Add("12");
            col_Size.Add("65"); col_Size.Add("250"); col_Size.Add("-2");
            col_Size.Add("0");
            col_Size.Add("0"); col_Size.Add("0");
            col_Size.Add("0"); col_Size.Add("0");
            col_Size.Add("0"); col_Size.Add("0");
            col_Size.Add("0"); col_Size.Add("0"); col_Size.Add("0");
            //function.filllvw(lvw_Verify, ds, col, col_Name, col_Size,ColumnHeaderStyle.Clickable , 2, 0);

            //function.filllvw(lvw_NotVerify, ds, col, col_Name, col_Size, 0, 3, 0);
        }

        private void FillCounts(DataSet ds)
        {
            //ann.Values.Description = ds.Tables[0].Rows[0][1].ToString();
            //ann_v.Values.Heading = ds.Tables[0].Rows[0][2].ToString();
            //ann_nv.Values.Heading = ds.Tables[0].Rows[0][3].ToString();
            //ant.Values.Description = ds.Tables[0].Rows[1][1].ToString();
            //ant_v.Values.Heading = ds.Tables[0].Rows[1][2].ToString();
            //ant_nv.Values.Heading = ds.Tables[0].Rows[1][3].ToString();
            //bpl.Values.Description = ds.Tables[0].Rows[2][1].ToString();
            //bpl_v.Values.Heading = ds.Tables[0].Rows[2][2].ToString();
            //bpl_nv.Values.Heading = ds.Tables[0].Rows[2][3].ToString();
            //apl.Values.Description = ds.Tables[0].Rows[3][1].ToString();
            //apl_v.Values.Heading = ds.Tables[0].Rows[3][2].ToString();
            //apl_nv.Values.Heading = ds.Tables[0].Rows[3][3].ToString();
            //wh.Values.Description = ds.Tables[0].Rows[4][1].ToString();
            //wh_v.Values.Heading = ds.Tables[0].Rows[4][2].ToString();
            //wh_nv.Values.Heading = ds.Tables[0].Rows[4][3].ToString();
            //nfs.Values.Description = ds.Tables[0].Rows[5][1].ToString();
            //nfs_v.Values.Heading = ds.Tables[0].Rows[5][2].ToString();
            //nfs_nv.Values.Heading = ds.Tables[0].Rows[5][3].ToString();
            //total.Values.Description = ds.Tables[1].Rows[0][1].ToString();
            //total_v.Values.Heading = ds.Tables[1].Rows[0][2].ToString();
            //total_nv.Values.Heading = ds.Tables[1].Rows[0][3].ToString();

        }

        private void SetPositions()
        {
            Main_Panel.Panel2Collapsed = true;
            //kryptonSplitContainer1.SplitterDistance = (int)Main_Panel.Panel1.Width * 30 / 100;
            //kryptonSplitContainer2.SplitterDistance = (int)Main_Panel.Panel1.Height * 70 / 100;
            //kryptonSplitContainer1.Panel1MinSize = (int)Main_Panel.Panel1.Width * 30 / 100;
            //kryptonSplitContainer2.Panel1MinSize = (int)Main_Panel.Panel1.Height * 70 / 100;
        }

        private void SetFontToMenu(MenuStrip menu)
        {

            foreach (ToolStripMenuItem m in menu.Items)
            {
                m.Font = new System.Drawing.Font("Tahoma", 8, FontStyle.Bold);
                SetFontToMenu(m);
            }
        }

        private void SetFontToMenu(ToolStripMenuItem Menuitem)
        {
            try
            {
                foreach (ToolStripMenuItem m in Menuitem.DropDownItems)
                {
                    m.Font = new System.Drawing.Font("Tahoma", 8, FontStyle.Bold);
                    if (m.HasDropDownItems)
                        SetFontToMenu(m);
                }
            }
            catch (Exception Ex)
            { }

        }

        private void formToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open_form(this, false, "Form1");
        }


        private void Main_Panel_Panel2_ControlAdded(object sender, ControlEventArgs e)
        {
            Main_Panel.Panel1Collapsed = true;
        }


        public void Main_Panel_Panel2_ControlRemoved(object sender, ControlEventArgs e)
        {
            if (MODULE.glb.ContainsKey("FORMNAME") == true)
            {
                if (MODULE.is_rpt == true)
                {

                    ShowForm(rpt.select_Report_Form(MODULE.glb["FORMNAME"]));

                    MODULE.is_rpt = false;
                }
                if (MODULE.glb["FORMNAME"] == "Form1")
                {
                    Form1 frm = new Form1();
                    ShowForm(frm);

                }
                KryptonForm form = new KryptonForm();
                switch (MODULE.glb["FORMNAME"].ToString())
                {

                    case "Frm_Colour_Theme":

                        form = new FRM_COLOR_THEME();
                        ShowForm(form);

                        break;
                    // *****__________ Master ToolScript Menu   __________*****

                    case "FRM_ITEMMASTER":
                        form = new FRM_ITEMMASTER();
                        ShowForm(form);
                        break;


                    case "FRM_SUBITEMMASTER":
                        form = new FRM_SUBITEMMASTER();
                        ShowForm(form);
                        break;

                    case "FRM_CUSTOMERMASTER":
                        form = new FRM_CUSTOMERMASTER();
                        ShowForm(form);
                        break;

                    case "FRM_SUPPLIERMASTER":
                        form = new FRM_SUPPLIERMASTER();
                        ShowForm(form);
                        break;

                    case "FRM_EMPLOYEEMASTER":
                        form = new FRM_EMPLOYEEMASTER();
                        ShowForm(form);
                        break;

                    case "FRM_MEASUREMENTMASTER":
                        form = new FRM_MEASUREMENTMASTER();
                        ShowForm(form);
                        break;

                    case "FRM_TRANSPORTATION_MASTER":
                        form = new FRM_TRANSPORTATION_MASTER();
                        ShowForm(form);
                        break;

                    case "FRM_ROWMATERIALMASTER":
                        form = new FRM_ROWMATERIALMASTER();
                        ShowForm(form);
                        break;

                    case "FRM_EXPENCESMASTER":
                        form = new FRM_ACCOUNTHEAD();
                        ShowForm(form);
                        break;

                    case "FRM_SUBEXPENCESMASTER":
                        form = new FRM_SUBEXPENCESMASTER();
                        ShowForm(form);
                        break;

                    case "FRM_ROWMATERIAL":
                        form = new FRM_ROWMATERIAL();
                        ShowForm(form);
                        break;

                    case "FRM_BOXWISE_BOTTLE_FORMULA":
                        form = new FRM_BOXWISE_BOTTLE_FORMULA();
                        ShowForm(form);
                        break;

                    case "FRM_USERMASTER":
                        form = new FRM_USERMASTER();
                        ShowForm(form);
                        break;

                    case "FRM_ROOTMASTER":
                        form = new FRM_ROOTMASTER();
                        ShowForm(form);
                        break;

                    // *****_____('^')_____ Transaction ToolScript Menu   _____('^')_____*****

                    case "FRM_BILLINGINVOICE":
                        form = new FRM_BILLINGINVOICE();
                        ShowForm(form);
                        break;

                    case "FRM_EXPENCESTRANSACTION":
                        form = new FRM_EXPENCESTRANSACTION();
                        ShowForm(form);
                        break;

                    case "FRM_SALESRECOVERY":
                        form = new FRM_SALESRECOVERY();
                        ShowForm(form);
                        break;

                    case "FRM_PURCHASEPAID":
                        form = new FRM_PURCHASEPAID();
                        ShowForm(form);
                        break;

                    case "FRM_PROD_PROCESS":
                        form = new FRM_PROD_PROCESS();
                        ShowForm(form);
                        break;

                    case "FRM_SALESRECOVERYCHECK":
                        form = new FRM_SALESRECOVERYCHECK();
                        ShowForm(form);
                        break;
                    case "frm_Check_Invoice":
                        form = new frm_Check_Invoice();
                        ShowForm(form);
                        break;
                    case "FRM_UpdateInvoice":
                        form = new FRM_UpdateInvoice();
                        ShowForm(form);
                        break;

                    case "FRM_PERMISSION":
                        form = new FRM_PERMISSION();
                        ShowForm(form);
                        break;

                    case "FRM_ROOTTRANSACTION":
                        form = new FRM_ROOTTRANSACTION();
                        ShowForm(form);
                        break;
                    case "FRM_Vehical_Details":
                        form = new FRM_Vehical_Details();
                        ShowForm(form);
                        break;
                    case "FRM_SHOPMASTER":
                        form = new FRM_SHOPMASTER();
                        ShowForm(form);
                        break;
                    default:
                        break;
                }

                MODULE.glb["FORMNAME"] = "";
            }
            if (Main_Panel.Panel2.Controls.Count <= 0)
            {
                Main_Panel.Panel2Collapsed = true;
            }

            RefreshWindow();
        }

        public void ShowForm(KryptonForm sender)
        {

            KryptonHeader kryptonHeader1 = new KryptonHeader();
            this.Main_Panel.Panel1.AutoScrollPosition = new Point(10, 10);
            //sender.ControlBox = false;
            //sender.StateCommon.Header.Content.ShortText.Font = new System.Drawing.Font("DVB-TTSurekh", 22, FontStyle.Bold);
            sender.FormBorderStyle = FormBorderStyle.Fixed3D;
            sender.ShowInTaskbar = false;
            sender.TopLevel = false;
            sender.Visible = true;
            sender.Parent = this.Main_Panel.Panel2;
            //kryptonHeader1.Values.Heading = sender.Text.ToString();
            //kryptonHeader1.Values.Description  = "";
            //kryptonHeader1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            //kryptonHeader1.Location = new Point((Main_Panel.Panel2.Width - sender.Width) / 2,kryptonHeader1.Height);
            this.Main_Panel.Panel2.Controls.Remove(FindForm()); //clear panel first
            this.Main_Panel.Panel2.Controls.Add(sender);
            sender.BringToFront();
            sender.Location = new Point((Main_Panel.Panel2.Width - sender.Width) / 2, (Main_Panel.Panel2.Height - sender.Height) / 2);
            kryptonHeader1.Dock = DockStyle.Top;
            sender.Show();
        }
        public object ShowForm(KryptonForm sender, int i)
        {

            KryptonHeader kryptonHeader1 = new KryptonHeader();
            this.Main_Panel.Panel1.AutoScrollPosition = new Point(10, 10);
            //sender.ControlBox = false;
            //sender.StateCommon.Header.Content.ShortText.Font = new System.Drawing.Font("DVB-TTSurekh", 22, FontStyle.Bold);
            sender.FormBorderStyle = FormBorderStyle.Fixed3D;
            sender.ShowInTaskbar = false;
            sender.TopLevel = false;
            sender.Visible = true;
            sender.Parent = this.Main_Panel.Panel2;
            //kryptonHeader1.Values.Heading = sender.Text.ToString();
            //kryptonHeader1.Values.Description  = "";
            //kryptonHeader1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            //kryptonHeader1.Location = new Point((Main_Panel.Panel2.Width - sender.Width) / 2,kryptonHeader1.Height);
            this.Main_Panel.Panel2.Controls.Remove(FindForm()); //clear panel first
            this.Main_Panel.Panel2.Controls.Add(sender);
            sender.BringToFront();
            sender.Location = new Point((Main_Panel.Panel2.Width - sender.Width) / 2, (Main_Panel.Panel2.Height - sender.Height) / 2);
            kryptonHeader1.Dock = DockStyle.Top;
            sender.Show();
            return (object)sender;
        }
        public void open_form(Form ownform, bool closeYN, string new_form)
        {
            MODULE.glb["FORMNAME"] = new_form;
            if (closeYN == true)
            {
                ownform.Close();
            }
            Main_Panel_Panel2_ControlRemoved(this, new ControlEventArgs(this));

        }



        private void themeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            open_form(this, false, "Frm_Colour_Theme");
        }

        private void Frm_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            function.SetDeskTopResolution();
            Application.Exit();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //function.SetDeskTopResolution();
            Application.Exit();
        }

        private void parlimentoryMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open_form(this, false, "FRM_PLMASTER");
        }

        private void assemblyMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open_form(this, false, "FRM_ACMASTER");
        }

        private void pollingStationMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open_form(this, false, "FRM_PSMASTER");
        }

        private void voterMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {

            open_form(this, false, "FRM_VOTERMASTER");
        }

        private void pollingDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open_form(this, false, "FRM_POLLINGDETAILS");

        }
        private void uPLOADDATAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open_form(this, false, "FRM_UPLOADDATA");
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open_form(this, false, "RATION_CARD_ENTRY");
        }

        private void verificationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open_form(this, false, "FRM_VERIFY");
        }

        private void form1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open_form(this, false, "Form1");
        }

        private void fillToatlPersonUnitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open_form(this, false, "FRM_DATAENTRY_OTHER");
        }

        private void scriptKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open_form(this, false, "FRM_SCRIPT_KEY");
        }



        private void lvw_Verify_MouseUp(object sender, MouseEventArgs e)
        {
            //if (e.Button == MouseButtons.Right)
            //{
            //    //ListViewItem l = lvw_Verify.HitTest(e.Location).Item;
            //    if (l != null)
            //        kryptonContextMenu1.Show(this);
            //}
        }
        private void lvw_Verify_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ////ListViewItem l = lvw_Verify.HitTest(e.Location).Item;
            //if (l != null)
            //{
            //    kryptonContextMenu1.Show(this);// c.RectangleToScreen(c.ClientRectangle),
            //    //show_track(lvw.SelectedItems[0].SubItems[0].Text, lvw.SelectedItems[0].SubItems[1].Text);
            //}
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //module.glb["TAPAL_ID_YEAR"] = lvw_Verify.SelectedItems[0].SubItems[0].Text;
            try
            {
                //string id = lvw_Verify.SelectedItems[0].SubItems[3].Text;
                //FRM_VIEW_CARD view = new FRM_VIEW_CARD(id,true);
                //view.FormBorderStyle = FormBorderStyle.None;
                //view.StartPosition = FormStartPosition.CenterScreen; 
                //view.ShowDialog();
            }
            catch (Exception ex) { BL_Error_Log.WriteLog(ex); }
        }
        private void lvw_NotVerify_MouseUp(object sender, MouseEventArgs e)
        {
            //if (e.Button == MouseButtons.Right)
            //{
            //    ListViewItem l = lvw_NotVerify.HitTest(e.Location).Item;
            //    if (l != null)
            //        kryptonContextMenu2.Show(this);
            //}
        }
        private void lvw_NotVerify_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //ListViewItem l = lvw_NotVerify.HitTest(e.Location).Item;
            //if (l != null)
            //{
            //    kryptonContextMenu2.Show(this);// c.RectangleToScreen(c.ClientRectangle),
            //    //show_track(lvw.SelectedItems[0].SubItems[0].Text, lvw.SelectedItems[0].SubItems[1].Text);
            //}
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //module.glb["TAPAL_ID_YEAR"] = lvw_NotVerify.SelectedItems[0].SubItems[0].Text;
            try
            {
                //string id = lvw_NotVerify.SelectedItems[0].SubItems[3].Text;
                //FRM_VIEW_CARD view = new FRM_VIEW_CARD(id, false);
                //view.FormBorderStyle = FormBorderStyle.None;
                //view.ShowDialog();
            }
            catch (Exception ex) { BL_Error_Log.WriteLog(ex); }
        }

        private void logONLogOFFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispose(true);
            //Form.ActiveForm.Hide();
            BILLING_SYSTEM.FRM_LOGIN f1 = new FRM_LOGIN();
            f1.Show();
        }

        private void ItemMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salesInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void InvoiceApprovetoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            open_form(this, false, "frm_Check_Invoice");
        }

        private void RowHeadertoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            open_form(this, false, "FRM_ROWMATERIAL");
        }

        private void RowMaterialMastertoolStripMenuItem2_Click(object sender, EventArgs e)
        {
            open_form(this, false, "FRM_ROWMATERIALMASTER");
        }

        private void BoxWisetoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            open_form(this, false, "FRM_BOXWISE_BOTTLE_FORMULA");
        }

        private void ProdManufacturetoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            open_form(this, false, "FRM_PROD_PROCESS");
        }

        private void CustomerMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open_form(this, false, "FRM_CUSTOMERMASTER");
        }

        private void backupDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bl_back.select(bl_back);
            MessageBox.Show("Backup Generated Successfully");
        }

        private void Thememenu_Click(object sender, EventArgs e)
        {

        }
    }
}