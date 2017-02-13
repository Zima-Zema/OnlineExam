using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Sql;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace OnlineExam.Code
{
    public class DeptManger
    {
        public static DataTable GetAllDept()
        {
            string stored = "Get_All_Dept";
            return DBLayer.SelectData(stored);
        }
        public static DataTable GetDeptMangerById(int id)
        {
            string stored = "Get_Dept_Manager";
            SqlParameter[] param = { new SqlParameter("@id", id) };
            return DBLayer.SelectData(stored,param);
        }
    }
}