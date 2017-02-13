using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace OnlineExam
{
    public class LoginBL
    {
        public static string CheckLogin(string user,string pass)
        {
            DataTable datatable = new DataTable();
            string stored = "Get_Ins_User_Pass";
            SqlParameter[] param = { new SqlParameter("@user", user), new SqlParameter("@pass", pass) };
            datatable= DBLayer.SelectData(stored, param);
            if (datatable.Rows.Count > 0)
            {
                return "Instructor";
            }
            else
            {
                stored = "Get_Std_User_Pass";
                SqlParameter[] param2 = { new SqlParameter("@user", user), new SqlParameter("@pass", pass) };
                datatable = DBLayer.SelectData(stored, param2);
                if (datatable.Rows.Count>0)
                {
                    return "Student";
                }
                else
                {
                    stored = "Get_Admin_User_Pass";
                    SqlParameter[] param3 = { new SqlParameter("@user", user), new SqlParameter("@pass", pass) };
                    datatable = DBLayer.SelectData(stored, param3);
                    if (datatable.Rows.Count > 0)
                    {
                        return "Admin";
                    }
                    else
                    {
                        return "Not member";
                    }
                }
            }
        }
    }
}