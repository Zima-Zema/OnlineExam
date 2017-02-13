using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for BusinessLayer
/// </summary>
public class BusinessLayer{    
    static DataTable dt = new DataTable();

    #region courses
    public static DataTable DisplayCourseByID(int ID)
    {
        SqlParameter[] SParameter = { new SqlParameter("ID", ID) };
        dt = DBLayer.SelectData("DisplayCourseByID", SParameter);
        return dt;
    }
    
    public static int Add_Course(int top_id, string crs_name, int crs_duration)
    {
        SqlParameter[] SParameter = { new SqlParameter("top_id", top_id), new SqlParameter("crs_name", crs_name), new SqlParameter("crs_duration", crs_duration) };
        int x = DBLayer.DmlOperation("Add_Course", SParameter);
        return x;
        
    }
    public static int Edit_Course(int crs_id, string crs_name, int crs_duration, int top_id)
    {
        SqlParameter[] SParameter = { new SqlParameter("crs_id", crs_id), new SqlParameter("crs_name", crs_name), new SqlParameter("crs_duration", crs_duration),new SqlParameter("top_id",top_id) };
        int x = DBLayer.DmlOperation("Edit_Course", SParameter);
        return x;
    }
    public static int Remove_Course(int crs_id)
    {
        SqlParameter[] SParameter = { new SqlParameter("crs_id", crs_id) };
        int x = DBLayer.DmlOperation("Remove_Course", SParameter);
        return x;
    }
    //
    public static int RemovecourseByName(string crs_name)
    {
        SqlParameter[] SParameter = { new SqlParameter("crs_name", crs_name) };
        int Rows = DBLayer.DmlOperation("RemovecourseByName", SParameter);
        return Rows;
    }
    public static DataTable Display_course_by_Idand_Name()
    {
        dt = DBLayer.SelectData("Display_course_by_Idand_Name");
        return dt;
    }


    #endregion
    #region Reports
    
    #endregion
    #region Dept
    public static DataTable Display_Department_by_Idand_Name()
    {
        dt = DBLayer.SelectData("Display_Department_by_Idand_Name");
        return dt;
    }
    #endregion


    public static DataTable GetInstructorByUsername(string username)
    {
        string stored = "Get_Ins_By_Username";
        SqlParameter[] param = { new SqlParameter("@user", username) };
        return DBLayer.SelectData(stored, param);
    }

    public static DataTable GetStudentByuserName(string user)
    {
        string stored = "Get_Student_By_userName";
        SqlParameter[] param = { new SqlParameter("@user", user) };
        return DBLayer.SelectData(stored, param);
    }
}
