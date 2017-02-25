using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace OnlineExam.Code
{
    public class StudentsBL
    {
        public static DataTable GetStusent()
        {
            string stored = "Get_All_Student";
            return DBLayer.SelectData(stored);
        }

        public static DataTable GetStudentByID(int sid)
        {
            string stored = "Get_Student_By_ID";
            SqlParameter[] param = { new SqlParameter("@sid", sid) };
            return DBLayer.SelectData(stored, param);
        }
        public static int insert_Student(string Fname, string Lname, int deptid,string username,string pass)
        {
            string stored = "Add_Student";
            SqlParameter[] param = {
                new SqlParameter("@Fname",Fname),
                new SqlParameter("@Lname",Lname),
                new SqlParameter("@dept_id",deptid),
                new SqlParameter("@user",username),
                new SqlParameter("@pass",pass)
            };
            return DBLayer.DmlOperation(stored, param);
        }
        public static int Edit_Student(int id, string Fname, string Lname, int deptid, string username, string pass, string act)
        {
            string stored = "Edit_Student";
            SqlParameter[] param = {
                new SqlParameter("@id",id),
                new SqlParameter("@Fname",Fname),
                new SqlParameter("@Lname",Lname),
                new SqlParameter("@dept_id",deptid),
                new SqlParameter("@user",username),
                new SqlParameter("@pass",pass),
                new SqlParameter("@act",act)};
            return DBLayer.DmlOperation(stored, param);
        }
        public static int Remove_Student(int St_id)
        {
            string stored = "Remove_Student";
            SqlParameter[] param = { new SqlParameter("@id", St_id) };
            return DBLayer.DmlOperation(stored, param);
        }

        public static DataTable GetStudentByuserName(string user)
        {
            string stored = "Get_Student_Username";
            SqlParameter[] param = { new SqlParameter("@user", user) };
            return DBLayer.SelectData(stored, param);
        }




    }
}