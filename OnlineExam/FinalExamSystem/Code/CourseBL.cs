using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace OnlineExam.Code
{
    public class CourseBL
    {
        public static DataTable GetAllCourses()
        {
            string stored = "Get_All_Courses";
            return DBLayer.SelectData(stored);
        }
        public static DataTable GetCourseByID(int id)
        {
            string stored = "Get_Crs_By_ID";
            SqlParameter[] param = { new SqlParameter("@id", id) };
            return DBLayer.SelectData(stored, param);
        }
        public static int CreateCourse(string name,int duration,int topid)
        {
            string stored = "Add_Course";
            SqlParameter[] param = {
                new SqlParameter("@crs_name",name),
                new SqlParameter("@crs_duration",duration),
                new SqlParameter("@top_id",topid)};
            return DBLayer.DmlOperation(stored, param);
        }
        public static int EditCourse(int id,string name,int duration,int topid)
        {
            string stored = "Edit_Course";
            SqlParameter[] param = {
                new SqlParameter ("@",id),
                new SqlParameter("@crs_name",name),
                new SqlParameter("@crs_duration",duration),
                new SqlParameter("@top_id",topid)
            };
            return DBLayer.DmlOperation(stored, param);
        }
        public static int RemoveCourse(int id)
        {
            string stored = "Remove_Course";
            SqlParameter[] param = { new SqlParameter("@crs_id", id) };
            return DBLayer.DmlOperation(stored, param);
        } 
    }
}