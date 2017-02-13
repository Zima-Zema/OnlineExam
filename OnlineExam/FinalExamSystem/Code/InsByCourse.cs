using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace OnlineExam.Code
{
    public class InsByCourse
    {
        public static DataTable GetAllCourses()
        {

            string stored = "Get_All_Courses";
            return DBLayer.SelectData(stored);
        }

        public static DataTable GetCourseById(int id)
        {
            string stored = "Get_Instrucror_By_Cource";
            SqlParameter[] param = { new SqlParameter("@id", id) };

            return DBLayer.SelectData(stored, param);
        }
    }
}