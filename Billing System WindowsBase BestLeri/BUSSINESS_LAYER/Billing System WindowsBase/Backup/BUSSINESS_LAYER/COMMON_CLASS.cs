using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using DATA_LAYER;
using System.Web;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
namespace BUSSINESS_LAYER
{
    public interface ICOMMON_CLASS_MASTER
    {
        DataSet SELECT(object classObject);
        DataSet INSERT(object classObject);
        DataSet UPDATE(object classObject);
        DataSet DELETE(object classObject);
        void Fill_ListView(ListView Lvw, DataTable Dt);
    }
    public interface ICOMMON_CLASS_MASTER_FILLDDL
    {
        void FILL_DDL(ComboBox ddl, DataTable dt);
        void FILL_DDL(ComboBox ddl, DataTable dt, bool insertAll);
    }
    public partial class COMMON_CLASS 
    {

        public List<string> ParaName = null;
        public List<string> ParaValue = null;
        public SortedList<string, string> ParaNameValue = null;
        //DB_LOCAL  DataLayer_Local_obj = new DB_LOCAL();
        //DB_SERVER DataLayer_Server_obj = new DB_SERVER();
     
          public String convertdate(DateTime date)
        {
            DateTime tDate = date;
            String tempDate = tDate.ToString("dd/MM/yyyy");
            //tDate = DateTime.Parse(tempDate);
            return (tempDate);
        }

        public DateTime convertdate_string_date(string date)
        {
            DateTime tDate = (!string.IsNullOrEmpty(date) || date != "") ? Convert.ToDateTime(date) : DateTime.MinValue.AddDays(1);// Convert.ToDateTime(SysDate());
            //String tempDate = tDate.ToString("dd/MM/yyyy");
            //tDate = DateTime.Parse(tempDate);
            return (tDate);
        }
        //public void convertdate_string_date(string date, DateTimePicker dtp)
        //{
        //    if (!string.IsNullOrEmpty(date) || date != "")
        //    { dtp.Value = Convert.ToDateTime(date); dtp.Checked = true; }
        //    else dtp.Checked = false;
        //}
        //public void convertdate_string_date(string date, KryptonDateTimePicker dtp)
        //{
        //    if (!string.IsNullOrEmpty(date) || date != "")
        //    { dtp.Value = Convert.ToDateTime(date); dtp.Checked = true; }
        //    else dtp.Checked = false;
        //}
        public string date_save_to_db(DateTime dt)
        {
            return (dt.Year + "-" + dt.Month + "-" + dt.Day);
        }

        public string Decrypt(string str)
        {
            Char[] ch = str.ToCharArray();
            Char[] ch1 = new char[str.Length];
            string newstr = "";
            for (int i = 0; i <= str.Length - 1; i++)
            {
                int a = (int)ch[i];
                a += 4;
                ch1[i] = (char)a;
                newstr += ch1[i].ToString();
            }
            return (newstr);
        }
        public string Encrypt(string str)
        {
            Char[] ch = str.ToCharArray();
            Char[] ch1 = new char[str.Length];
            string newstr = "";
            for (int i = 0; i <= str.Length - 1; i++)
            {
                int a = (int)ch[i];
                a -= 4;
                ch1[i] = (char)a;
                newstr += ch1[i].ToString();
            }
            return (newstr);
        }

    
    }


}
namespace BUSSINESS_LAYER
{
    public enum Salutation_Eng
    {
        Mr = 1,
        Mrs = 2,
        Kumar = 3,
        Kumari = 4,
        Sau = 5,
    }
    public enum Salutation_Mar
    {
        श्री = 1,
        श्रीमती = 2,
        कुमार = 3,
        कुमारी = 4,
        सौ = 5,
    }

    public enum MONTH_ENG
    {
        JAN = 1,
        FEB = 2,
        MAR = 3,
        APR = 4,
        MAY = 5,
        JUN = 6,
        JUL = 7,
        AUG = 8,
        SEP = 9,
        OCT = 10,
        NOV = 11,
        DEC = 12
    }
    public enum MONTH_MAR
    {
        जानेवारी = 1,
        फेब्रुवारी = 2,
        मार्च = 3,
        एप्रिल = 4,
        मे = 5,
        जून = 6,
        जुलै = 7,
        ऑगस्ट = 8,
        सेप्तेम्बेर = 9,
        ऑक्टोबर = 10,
        नोव्हेंबर = 11,
        डिसेंबर = 12,
    }

    public enum REPORT_LIST
    {
        Percentage_of_Votes_Poll                                                        = 1,
        Voting_Percentage_of_Male_and_Female_Voters                                     = 2,
        Percentage_of_Voters_Who_voted_With_Epic_Card                                   = 3,
        Percentage_of_Voters_Who_voted_With_Alternate_Document                          = 4,
        Shifted_Voters_Voting_Percentage                                                = 5,
        Last_Column_17_A_Not_Filled_At_All                                              = 6,
        Mock_Poll_present_Polling_Agents                                                = 7,
        Tender_Votes_Details                                                            = 8,
        More_than_25_Voting_using_document_other_than_Epic_Card                         = 9,
        where_Polling_Percentage_is_plus_15_per_or_minus_15_per_of_the_Average_of_AC    = 10,
        More_than_10_per_Shifted_Voters_Voting_Percentage                               = 11,
        Challenged_Votes_Details                                                        = 12,
        Voting_after_5_PM                                                               = 13,
        Complaint_of_Polling_Station_and_Action_of_Preceding_officer                    = 14,
        EVM_related_Complaints_and_Action                                               = 15,
        Abstract                                                                        = 16,
        A_03                                                                            = 17,
        A_05                                                                            = 18,
        Handicap_Voting                                                                 = 19,
        Blind_Voters_Details                                                            = 20,
        Reject_Under49_O                                                                = 21,
        PLMASTER                                                                        = 22,
        ACMASTER                                                                        = 23,
    }

}
