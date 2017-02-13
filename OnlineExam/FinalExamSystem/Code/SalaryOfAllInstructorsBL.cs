using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace OnlineExam.Code
{
    public class SalaryOfAllInstructorsBL
    {
        public static DataTable GetAllInstructors()
        {
            string stored = "Get_All_Ins";
            return DBLayer.SelectData(stored);
        }
        public static DataTable GetInstructorByID(int id)
        {
            string stored = "Get_Ins_By_ID";
            SqlParameter[] param = { new SqlParameter("@id", id) };

            return DBLayer.SelectData(stored, param);
        }

    }
}
