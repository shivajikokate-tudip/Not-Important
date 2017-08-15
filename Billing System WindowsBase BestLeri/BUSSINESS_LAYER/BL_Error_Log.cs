using System;
using System.Collections.Generic;
using System.Text;

namespace BUSSINESS_LAYER
{
    public static class BL_Error_Log
    {
        public static void WriteLog(Exception ex)
        {
            Console.Write(ex.Message.ToString()); 
        }
        //private static Exception MyException { get; set; }

        //BL_Error_Log(Exception ex)
        //{
            
        //    MyException = ex;
        ////Write To Log error
        //}
        

    }
}
