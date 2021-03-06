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
    public partial class FRM_MAIN : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        BL_MAIN_FORM bl_Obj = new BL_MAIN_FORM();
        int len = 0;
        int cnt = 0;
        int cnt1 = 0;
        string strcmpname = "";

        MODULE function = new MODULE();
        public FRM_MAIN()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            cmpanddate.Values.Description = DateTime.Now.ToString();
            if (cnt1 <= len)
            {
                cmpanddate.Values.Heading = strcmpname.Substring(cnt1) + " ***** " + strcmpname.Substring(0, cnt1);
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
            //kryptonManager.GlobalPaletteMode = function.PalletMode(function.set_theme_name(true, ""));
            SetFontToMenu(menuStrip1);

            //Bind Event To Menu Control
            foreach (ToolStripMenuItem t in menuStrip1.Items)
                SetMenuClicks(t);

            this.Text = MODULE.glb["SHOP_NAME"].ToString();
            RefreshWindow();
        }

        public void SetMenuClicks(ToolStripMenuItem t)
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

        private void menuclick_Click(object sender, EventArgs e)
        {
            open_form(this, false, ((ToolStripMenuItem)sender).Tag.ToString());
        }

        private bool CheckViewsAre_Exists()
        {
            bool ret = false;
            if (!bl_Obj.CheckViewExists())
            {
                Tapal_Settings setting = new Tapal_Settings();
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
            function.filllvw(lvw_Verify, ds, col, col_Name, col_Size, 0, 2, 0);

            function.filllvw(lvw_NotVerify, ds, col, col_Name, col_Size, 0, 3, 0);
        }

        private void FillCounts(DataSet ds)
        {
            ann.Values.Description = ds.Tables[0].Rows[0][1].ToString();
            ann_v.Values.Heading = ds.Tables[0].Rows[0][2].ToString();
            ann_nv.Values.Heading = ds.Tables[0].Rows[0][3].ToString();
            ant.Values.Description = ds.Tables[0].Rows[1][1].ToString();
            ant_v.Values.Heading = ds.Tables[0].Rows[1][2].ToString();
            ant_nv.Values.Heading = ds.Tables[0].Rows[1][3].ToString();
            bpl.Values.Description = ds.Tables[0].Rows[2][1].ToString();
            bpl_v.Values.Heading = ds.Tables[0].Rows[2][2].ToString();
            bpl_nv.Values.Heading = ds.Tables[0].Rows[2][3].ToString();
            apl.Values.Description = ds.Tables[0].Rows[3][1].ToString();
            apl_v.Values.Heading = ds.Tables[0].Rows[3][2].ToString();
            apl_nv.Values.Heading = ds.Tables[0].Rows[3][3].ToString();
            wh.Values.Description = ds.Tables[0].Rows[4][1].ToString();
            wh_v.Values.Heading = ds.Tables[0].Rows[4][2].ToString();
            wh_nv.Values.Heading = ds.Tables[0].Rows[4][3].ToString();
            nfs.Values.Description = ds.Tables[0].Rows[5][1].ToString();
            nfs_v.Values.Heading = ds.Tables[0].Rows[5][2].ToString();
            nfs_nv.Values.Heading = ds.Tables[0].Rows[5][3].ToString();
            total.Values.Description = ds.Tables[1].Rows[0][1].ToString();
            total_v.Values.Heading = ds.Tables[1].Rows[0][2].ToString();
            total_nv.Values.Heading = ds.Tables[1].Rows[0][3].ToString();

        }

        private void SetPositions()
        {
            Main_Panel.Panel2Collapsed = true;
            kryptonSplitContainer1.SplitterDistance = (int)Main_Panel.Panel1.Width * 30 / 100;
            kryptonSplitContainer2.SplitterDistance = (int)Main_Panel.Panel1.Height * 70 / 100;
            kryptonSplitContainer1.Panel1MinSize = (int)Main_Panel.Panel1.Width * 30 / 100;
            kryptonSplitContainer2.Panel1MinSize = (int)Main_Panel.Panel1.Height * 70 / 100;
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
            foreach (ToolStripMenuItem m in Menuitem.DropDownItems)
            {
                m.Font = new System.Drawing.Font("Tahoma", 8, FontStyle.Bold);
                if (m.HasDropDownItems)
                    SetFontToMenu(m);
            }

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
                    case "FRM_ProductMaster":

                        form = new FRM_ProductMaster();
                        ShowForm(form);

                        break;
                    default:
                        break;
                }
                //if (MODULE.glb["FORMNAME"] == "RATION_CARD_ENTRY")
                //{
                //    FRM_RATION_DATA_ENTRY frm = new FRM_RATION_DATA_ENTRY();
                //    ShowForm(frm);
                //    frm.WindowState = FormWindowState.Maximized;
                //    frm.FormBorderStyle = FormBorderStyle.None;
                //}
                //if (MODULE.glb["FORMNAME"] == "FRM_VERIFY")
                //{
                //    FRM_VERIFY frm = new FRM_VERIFY();
                //    ShowForm(frm);
                //    frm.WindowState = FormWindowState.Maximized;
                //    frm.FormBorderStyle = FormBorderStyle.None;
                //}
                //if (MODULE.glb["FORMNAME"] == "FRM_DATAENTRY_OTHER")
                //{
                //    FRM_DATAENTRY_OTHER frm = new FRM_DATAENTRY_OTHER();
                //    ShowForm(frm);
                //    frm.WindowState = FormWindowState.Maximized;
                //    frm.FormBorderStyle = FormBorderStyle.None;
                //}
                //if (MODULE.glb["FORMNAME"] == "FRM_SCRIPT_KEY")
                //{
                //    FRM_SCRIPT_KEY frm = new FRM_SCRIPT_KEY();
                //    ShowForm(frm);
                //}
                //if (MODULE.glb["FORMNAME"] == "FRM_ACMASTER")
                //{
                //    FRM_ACMASTER frm = new FRM_ACMASTER();
                //    ShowForm(frm);
                //}
                //if (MODULE.glb["FORMNAME"] == "FRM_PSMASTER")
                //{
                //    FRM_PSMASTER frm = new FRM_PSMASTER();
                //    ShowForm(frm);
                //}
                //if (MODULE.glb["FORMNAME"] == "FRM_VOTERMASTER")
                //{
                //    FRM_VOTERMASTER frm = new FRM_VOTERMASTER();
                //    ShowForm(frm);
                //}
                //if (MODULE.glb["FORMNAME"] == "FRM_POLLINGDETAILS")
                //{
                //    FRM_POLLINGDETAILS frm = new FRM_POLLINGDETAILS();
                //    ShowForm(frm);
                //    frm.WindowState = FormWindowState.Maximized;
                //}
                //if (MODULE.glb["FORMNAME"] == "FRM_UPLOADDATA")
                //{
                //    FRM_UPLOADDATA frm = new FRM_UPLOADDATA();
                //    ShowForm(frm);
                //}
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
            if (e.Button == MouseButtons.Right)
            {
                ListViewItem l = lvw_Verify.HitTest(e.Location).Item;
                if (l != null)
                    kryptonContextMenu1.Show(this);
            }
        }
        private void lvw_Verify_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewItem l = lvw_Verify.HitTest(e.Location).Item;
            if (l != null)
            {
                kryptonContextMenu1.Show(this);// c.RectangleToScreen(c.ClientRectangle),
                //show_track(lvw.SelectedItems[0].SubItems[0].Text, lvw.SelectedItems[0].SubItems[1].Text);
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //module.glb["TAPAL_ID_YEAR"] = lvw_Verify.SelectedItems[0].SubItems[0].Text;
            try
            {
                string id = lvw_Verify.SelectedItems[0].SubItems[3].Text;
                //FRM_VIEW_CARD view = new FRM_VIEW_CARD(id,true);
                //view.FormBorderStyle = FormBorderStyle.None;
                //view.StartPosition = FormStartPosition.CenterScreen; 
                //view.ShowDialog();
            }
            catch (Exception ex) { BL_Error_Log.WriteLog(ex); }
        }
        private void lvw_NotVerify_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ListViewItem l = lvw_NotVerify.HitTest(e.Location).Item;
                if (l != null)
                    kryptonContextMenu2.Show(this);
            }
        }
        private void lvw_NotVerify_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewItem l = lvw_NotVerify.HitTest(e.Location).Item;
            if (l != null)
            {
                kryptonContextMenu2.Show(this);// c.RectangleToScreen(c.ClientRectangle),
                //show_track(lvw.SelectedItems[0].SubItems[0].Text, lvw.SelectedItems[0].SubItems[1].Text);
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //module.glb["TAPAL_ID_YEAR"] = lvw_NotVerify.SelectedItems[0].SubItems[0].Text;
            try
            {
                string id = lvw_NotVerify.SelectedItems[0].SubItems[3].Text;
                //FRM_VIEW_CARD view = new FRM_VIEW_CARD(id, false);
                //view.FormBorderStyle = FormBorderStyle.None;
                //view.ShowDialog();
            }
            catch (Exception ex) { BL_Error_Log.WriteLog(ex); }
        }

        //private void productMasterToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    open_form(this, false, "FRM_ProductMaster");
        //}

        //private void Thememenu_Click(object sender, EventArgs e)
        //{
        //    open_form(this, false, "Frm_Colour_Theme");
        //}

        private void abcToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //private void Percentage_of_Votes_PolltoolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    function.Show_Report(REPORT_LIST.Percentage_of_Votes_Poll);
        //}

        //private void Voting_Percentage_of_Male_and_Female_VoterstoolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    function.Show_Report(REPORT_LIST.Voting_Percentage_of_Male_and_Female_Voters);
        //}

        //private void Percentage_of_Voters_Who_voted_With_Epic_CardtoolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    function.Show_Report(REPORT_LIST.Percentage_of_Voters_Who_voted_With_Epic_Card);
        //}

        //private void Percentage_of_Voters_Who_voted_With_Alternate_DocumenttoolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    function.Show_Report(REPORT_LIST.Percentage_of_Voters_Who_voted_With_Alternate_Document);
        //}

        //private void Shifted_Voters_Voting_PercentagetoolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    function.Show_Report(REPORT_LIST.Shifted_Voters_Voting_Percentage);
        //}

        //private void Last_Column_17_A_Not_Filled_At_AlltoolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    function.Show_Report(REPORT_LIST.Last_Column_17_A_Not_Filled_At_All);
        //}

        //private void Mock_Poll_present_Polling_AgentstoolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    function.Show_Report(REPORT_LIST.Mock_Poll_present_Polling_Agents);
        //}

        //private void Tender_Votes_DetailstoolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    function.Show_Report(REPORT_LIST.Tender_Votes_Details);
        //}

        //private void More_than_25_Voting_using_document_other_than_Epic_CardtoolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    function.Show_Report(REPORT_LIST.More_than_25_Voting_using_document_other_than_Epic_Card);
        //}

        //private void where_Polling_Percentage_is_plus_15_per_or_minus_15_per_of_the_Average_of_ACtoolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    function.Show_Report(REPORT_LIST.where_Polling_Percentage_is_plus_15_per_or_minus_15_per_of_the_Average_of_AC);
        //}

        //private void More_than_10_per_Shifted_Voters_Voting_PercentagetoolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    function.Show_Report(REPORT_LIST.More_than_10_per_Shifted_Voters_Voting_Percentage);
        //}

        //private void Challenged_Votes_DetailstoolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    function.Show_Report(REPORT_LIST.Challenged_Votes_Details);
        //}

        //private void Voting_after_5_PMtoolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    function.Show_Report(REPORT_LIST.Voting_after_5_PM, "Y");
        //}

        //private void Complaint_of_Polling_Station_and_Action_of_Preceding_officertoolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    function.Show_Report(REPORT_LIST.Complaint_of_Polling_Station_and_Action_of_Preceding_officer);
        //}

        //private void EVM_related_Complaints_and_ActiontoolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    function.Show_Report(REPORT_LIST.EVM_related_Complaints_and_Action);
        //}

        //private void AbstracttoolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    function.Show_Report(REPORT_LIST.Abstract);
        //}

        //private void A_03toolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    function.Show_Report(REPORT_LIST.A_03);
        //}

        //private void A_05toolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    function.Show_Report(REPORT_LIST.A_05);
        //}

        //private void Handicap_VotingtoolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    function.Show_Report(REPORT_LIST.Handicap_Voting);
        //}

        //private void Blind_Voters_DetailstoolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    function.Show_Report(REPORT_LIST.Blind_Voters_Details);
        //}

        //private void Reject_Under49_OtoolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    function.Show_Report(REPORT_LIST.Reject_Under49_O);
        //}

        //private void toolStripMenuItem22_Click(object sender, EventArgs e)
        //{
        //    function.Show_Report(REPORT_LIST.Last_Column_17_A_Not_Filled_At_All,"Y");
        //}

        //private void notFilledToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    function.Show_Report(REPORT_LIST.Last_Column_17_A_Not_Filled_At_All, "N");
        //}

        //private void allToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    function.Show_Report(REPORT_LIST.Last_Column_17_A_Not_Filled_At_All);
        //}

        //private void toolStripMenuItem24_Click(object sender, EventArgs e)
        //{
        //    function.Show_Report(REPORT_LIST.Mock_Poll_present_Polling_Agents, "2");
        //}

        //private void allToolStripMenuItem1_Click(object sender, EventArgs e)
        //{
        //    function.Show_Report(REPORT_LIST.Mock_Poll_present_Polling_Agents);
        //}

        //private void allToolStripMenuItem2_Click(object sender, EventArgs e)
        //{
        //    function.Show_Report(REPORT_LIST.Abstract);
        //}

        //private void moreThan5ToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    function.Show_Report(REPORT_LIST.Abstract, "5");
        //}

        //private void Reject_Under49_OtoolStripMenuItem_Click_1(object sender, EventArgs e)
        //{
        //    function.Show_Report(REPORT_LIST.Reject_Under49_O);
        //}


    }
}