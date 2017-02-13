using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;

namespace OnlineExam.Code
{
    public class TopicsPerCourse
    {
        public static DataTable GetAllCourses()
        {

            string stored = "Get_All_Courses";
            return DBLayer.SelectData(stored);
        }
        public static DataTable GetCourseById(int id)
        {
            string stored = "Get_Course_By_StdID";
            SqlParameter[] param = { new SqlParameter("@id", id) };

            return DBLayer.SelectData(stored, param);
        }
        public static DataTable Get_Course_By_Topic(int id)
        {
            string stored = "Get_Course_By_Topic";
            SqlParameter[] param = { new SqlParameter("@topid", id) };

            return DBLayer.SelectData(stored, param);
        }

    }
}