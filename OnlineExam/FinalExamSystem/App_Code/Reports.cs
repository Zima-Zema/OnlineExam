using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
/// <summary>
/// Summary description for Reports
/// </summary>
public class Reports
{
    static DataTable dt = new DataTable();
    public static DataTable ROne(int DeptID)
    {
        SqlParameter[] SParameter = { new SqlParameter("@DeptID", DeptID) };
        dt = DBLayer.SelectData("ROne", SParameter);
        return dt;
    }
    
    public static DataTable DisplayStudentByID()

    {
        dt = DBLayer.SelectData("DisplayStudentByID");
        return dt;
    }

    public static DataTable R2(int sid)

    {
        SqlParameter[] SParameter = { new SqlParameter("sid", sid) };
        dt = DBLayer.SelectData("R2", SParameter);
        return dt;
    }
    
    public static DataTable DisplayInstructorByID()

    {
        dt = DBLayer.SelectData("DisplayInstructorByID");
        return dt;
    }
    public static DataTable report3(int ins)
    {
        SqlParameter[] SParameter = { new SqlParameter("ins", ins) };
        dt = DBLayer.SelectData("report3", SParameter);
        return dt;
    }
    //report3 query
    public static DataTable Report33(int ins_id)
    {
        string query = "select [Ins-Name],[Crs-Name],COUNT([St-ID]) as [No Of students per course] from Course c inner join [Ins-Course] ic on c.[Crs-ID] =ic.[Crs-ID] inner join Instructor i on ic.[Ins-ID] = i.[Ins-ID]inner join [Stud-Course] sc on c.[Crs-ID] =sc.[Crs-ID] where i.[Ins-ID] = "+ins_id+" group by i.[Ins-Name],c.[Crs-Name]";
        return DBLayer.seldata(query);
    }


    public static DataTable DisplayExamByID()

    {
        dt = DBLayer.SelectData("DisplayExamByID");
        return dt;
    }

    
    public static DataTable R4(int eid)
    {
        SqlParameter[] SParameter = { new SqlParameter("eid", eid) };
        dt = DBLayer.SelectData("R4", SParameter);
        return dt;
    }
    public static DataTable R5(int eid, int sid)
    {
        SqlParameter[] SParameter = { new SqlParameter("eid", eid), new SqlParameter("sid", sid) };
        dt = DBLayer.SelectData("R5", SParameter);
        return dt;
    }
    public static DataTable R6(int CourseID)
    {
        SqlParameter[] SParameter = { new SqlParameter("CourseID", CourseID) };
        dt = DBLayer.SelectData("R6", SParameter);
        return dt;
    }
}
