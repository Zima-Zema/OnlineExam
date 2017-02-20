using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace OnlineExam.Code
{
    public class Admins
    {
        public static DataTable GetAdmin(string user, string pass)
        {
            string stored = "Get_Admins";
            SqlParameter[] param = { new SqlParameter("@username", user),
            new SqlParameter("@password",pass)};

            return DBLayer.SelectData(stored, param);
        }
        public static DataTable GetAdminByID(string user)
        {
            string stored = "Get_Admin_Username";
            SqlParameter[] param = { new SqlParameter("@username", user)};

            return DBLayer.SelectData(stored, param);
        }
        public static int ChangPass(int id, string newpass)
        {
            string stored = "Edit_Admin_Pass";
            SqlParameter[] param = { new SqlParameter("@admin_id", id),
            new SqlParameter("@newpass",newpass)};

            return DBLayer.DmlOperation(stored, param);
        }
        public static DataTable GetAdminByUsername(string user)
        {
            string stored = "Get_Admin_Username";
            SqlParameter[] param = { new SqlParameter("@user", user) };
            return DBLayer.SelectData(stored, param);
        }

        internal static void LogError(string v1, string v2, string v3, object p, string v4)
        {
            throw new NotImplementedException();
        }

        public static int LogError(string message,string date,string time,string page,string func)
        { 
            string stored = "Log_Error";
            SqlParameter[] param ={
                new SqlParameter("@message",message),
                new SqlParameter("@date",date),
                new SqlParameter("@time",time),
                new SqlParameter("@page",page),
                new SqlParameter("@func",func)
            };
            return DBLayer.DmlOperation(stored, param);
        }



    }
}