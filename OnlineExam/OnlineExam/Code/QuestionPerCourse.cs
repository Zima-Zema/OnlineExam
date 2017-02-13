using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace OnlineExam.Code
{
    public class QuestionPerCourse
    {
        public static DataTable GetAllCourses()
        {

            string stored = "Get_All_Courses";
            return DBLayer.SelectData(stored);
        }
        public static DataTable GetCourseById(int id)
        {
            string stored = "Get_Question_By_Course";
            SqlParameter[] param = { new SqlParameter("@cid", id) };

            return DBLayer.SelectData(stored, param);
        }
    }
}