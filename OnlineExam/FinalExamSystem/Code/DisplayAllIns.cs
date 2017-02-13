using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace OnlineExam.Code
{
    public class DisplayAllIns
    {
        public static DataTable GetAllIns()
        {
            string stored = "Get_All_Ins";
            return DBLayer.SelectData(stored);
        }
    }
}