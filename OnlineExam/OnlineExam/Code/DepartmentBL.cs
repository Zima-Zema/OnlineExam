using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace OnlineExam.Code
{
    public class DepartmentBL
    {
        public static DataTable GetAllDepartment()
        {
            string stored = "Get_All_Dept";
            return DBLayer.SelectData(stored);
        }
        public static DataTable GetDepartmentById(int id)
        {
            string stored = "Get_Department_by_Id";
            SqlParameter[] param = { new SqlParameter("@deptid", id) };
            return DBLayer.SelectData(stored, param);
        }
        public static int CreateDepartment(string name,string desc,string loc,int manager,DateTime hdate)
        {
            string stored = "Add_Department";
            SqlParameter[] param = {
                new SqlParameter("@deptName",name),
                new SqlParameter("@deptDesc",desc),
                new SqlParameter("@deptLoc",loc),
                new SqlParameter("@deptManager",manager),
                new SqlParameter("@deptHdate",hdate)
            };
            return DBLayer.DmlOperation(stored, param);
        }
        public static int EditDepartment(int id,string name, string desc, string loc, int manager, DateTime hdate)
        {
            string stored = "Edit_Department";
            SqlParameter[] param = {
                new SqlParameter("@deptID",id),
                new SqlParameter("@deptName",name),
                new SqlParameter("@deptDesc",desc),
                new SqlParameter("@deptLoc",loc),
                new SqlParameter("@deptManager",manager),
                new SqlParameter("@deptHdate",hdate)
            };
            return DBLayer.DmlOperation(stored, param);
        }
        public static int RemoveDepartment(int id)
        {
            string stored = "Remove_Department";
            SqlParameter[] param = { new SqlParameter("@deptId", id) };
            return DBLayer.DmlOperation(stored, param);
        }

        public static DataTable GetDepartmentByName(string name)
        {
            string stored = "Get_Department_By_Name";
            SqlParameter[] param =
            {
                new SqlParameter("@name",name)
            };
            return DBLayer.SelectData(stored, param);
        }
    }
}