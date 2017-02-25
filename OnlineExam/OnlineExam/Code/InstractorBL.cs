using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace OnlineExam
{
    public class InstractorBL
    {
        public static DataTable GetAllIns()
        {
            string stored = "Get_All_Ins";
            return DBLayer.SelectData(stored);
        }



        public static int ChangeInsPass(string newpass, int ins_id)
        {
            int affected = 0;
            string stored = "Change_Ins_Pass";
            SqlParameter [] param = { new SqlParameter("@newpass",newpass), new SqlParameter("@ins_id",ins_id) };

            affected = DBLayer.DmlOperation(stored, param);
            return affected;
        }

        public static DataTable Instructors_Courses(int id)
        {
            DataTable dt = new DataTable();
            string stored = "R3";
            SqlParameter[] param = { new SqlParameter("@InsID", id)};

            return DBLayer.SelectData(stored, param);
            
        }

        public static DataTable GetInstructorByID(int id)
        {
            string stored = "Get_Ins_By_ID";
            SqlParameter[] param = { new SqlParameter("@id", id) };

            return DBLayer.SelectData(stored, param);
        }

        public static DataTable GetInstructorByUsername(string username)
        {
            string stored = "Get_Ins_By_Username";
            SqlParameter[] param = { new SqlParameter("@user", username) };
            return DBLayer.SelectData(stored, param);
        }

        public static int EditInstructor(int id, string name, int dept, string degree, string salary, string username,string password)
        {
            string stored = "Edit_Instructor";
            SqlParameter[] param = {
                new SqlParameter ("@insId",id),
                new SqlParameter("@insName",name),
                new SqlParameter("@deptId",dept),
                new SqlParameter("@degree",degree),
                new SqlParameter("@salary",salary),
                new SqlParameter("@user",username),
                new SqlParameter("@pass",password)
            };
            return DBLayer.DmlOperation(stored, param);
        }

        public static int EditInstructorSelf(int id, string name, int dept, string degree, string salary)
        {
            string stored = "Edit_Instructor_By_self";
            SqlParameter[] param = {
                new SqlParameter ("@insId",id),
                new SqlParameter("@insName",name),
                new SqlParameter("@deptId",dept),
                new SqlParameter("@degree",degree),
                new SqlParameter("@salary",salary)
            };
            return DBLayer.DmlOperation(stored, param);
        }

        public static int CreateInstructor(string name, int dept, string degree, string salary, string username, string password)
        {
            string stored = "Add_Instructor";
            SqlParameter[] param = {
                new SqlParameter("@insName",name),
                new SqlParameter("@deptId",dept),
                new SqlParameter("@degree",degree),
                new SqlParameter("@salary",salary),
                new SqlParameter("@user",username),
                new SqlParameter("@pass",password)
            };
            return DBLayer.DmlOperation(stored, param);
        }

        public static int RemoveInstructor(int id)
        {
            
            string stored = "Add_Instructor";
            SqlParameter[] param = {
                new SqlParameter ("@insId",id),
            };
            return DBLayer.DmlOperation(stored, param);

        }

      





    }
}