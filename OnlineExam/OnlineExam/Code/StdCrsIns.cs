using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace OnlineExam.Code
{
    public class StdCrsIns
    {
        public static DataTable GetCourseByStdID(int id)
        {
            string stored = "Get_Course_By_StdID";
            SqlParameter[] param = { new SqlParameter("@id", id) };
            return DBLayer.SelectData(stored, param);
        }
        public static int EditInsCourseByCourse (int ins,int crs)
        {
            string stored = "Edit_Ins_Course_By_Course";
            SqlParameter[] param = { new SqlParameter("@Iid", ins), new SqlParameter("@cid", crs) };
            return DBLayer.DmlOperation(stored, param);
        }
        public static int EditInsCourseByIns(int ins,int crs)
        {
            string stored = "Edit_Ins_Course_By_Ins";
            SqlParameter[] param = { new SqlParameter("@Iid", ins), new SqlParameter("@cid", crs) };
            return DBLayer.DmlOperation(stored, param);
        }
        public static int EditStdCourseByCourse(int sid,int cid)
        {
            string stored = "Edit_Std_Course_By_Course";
            SqlParameter[] param = { new SqlParameter("@stid", sid), new SqlParameter("@cid", cid) };
            return DBLayer.DmlOperation(stored, param);

        }
        public static int EditStdCourseByStudent(int sid, int cid)
        {
            string stored = "Edit_Std_Course_By_Student";
            SqlParameter[] param = { new SqlParameter("@stid", sid), new SqlParameter("@cid", cid) };
            return DBLayer.DmlOperation(stored, param);

        }
        public static DataTable Get_Student_By_Course(int crsid)
        {
            string stored = "Get_Student_By_Course";
            SqlParameter[] param = { new SqlParameter("@crsid", crsid)};
            return DBLayer.SelectData(stored, param);
        }
        public static int CreateInsCourse(int ins ,int crs)
        {
            string stored = "Add_Ins_Course";
            SqlParameter[] param = { new SqlParameter("@Iid", ins), new SqlParameter("@cid", crs) };
            return DBLayer.DmlOperation(stored, param);
            
        }
        public static int CreateStdCourse(int std,int crs)
        {
            string stored = "Add_Stud_Course";
            SqlParameter[] param = { new SqlParameter("@sid", std), new SqlParameter("@cid", crs) };
            return DBLayer.DmlOperation(stored, param);
        }
        public static DataTable GetInsByCourse(int ins)
        {
            string stored = "Get_Ins_By_Course";
            SqlParameter[] param = { new SqlParameter("@insid", ins) };
            return DBLayer.SelectData(stored, param);
        }



        //LastChanceForStudent
        public static DataTable LastChance()
        {
            return DBLayer.SelectData("LastChance");
        }
        public static DataTable LastChanceForStudent()
        {
            return DBLayer.SelectData("LastChanceForStudent");
        }
        public static int Remove_Ins_Course(int insid,int cid)
        {
            SqlParameter[] param = { new SqlParameter("@Iid", insid), new SqlParameter("@cid", cid) };

            return DBLayer.DmlOperation("Remove_Ins_Course", param);
        }
        //Remov_Stud_Course
        public static int Remov_Stud_Course(int sid, int cid)
        {
            SqlParameter[] param = { new SqlParameter("@sid", sid), new SqlParameter("@cid", cid) };

            return DBLayer.DmlOperation("Remov_Stud_Course", param);
        }

    }
}