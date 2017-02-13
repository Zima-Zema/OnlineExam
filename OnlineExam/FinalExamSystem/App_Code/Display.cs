using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for Display
/// </summary>
public class Display
{
    static DataTable dt = new DataTable();
    //Student By ID
    public static DataTable DisplayStudentByID()

    {
        dt = DBLayer.SelectData("DisplayStudentByID");
        return dt;
    }
    //Display topics per Course 

    public static DataTable Get_Topics_By_Cource(int id)
    {
        SqlParameter[] SParameter = { new SqlParameter("id", id) };
        dt = DBLayer.SelectData("Get_Topics_By_Cource", SParameter);
        return dt;
    }
    //Instructors per course 
    public static DataTable Get_Instrucror_By_Cource(int id)
    {
        SqlParameter[] SParameter = { new SqlParameter("id", id) };
        dt = DBLayer.SelectData("Get_Instrucror_By_Cource", SParameter);
        return dt;
    }
    //Salary of all instructors
    public static DataTable DisplaySalaryOfInstructors()

    {
        dt = DBLayer.SelectData("DisplaySalaryOfInstructors");
        return dt;
    }
    //Student exams by student id 
    public static DataTable Get_Exam_By_StdID(int id)
    {
        SqlParameter[] SParameter = { new SqlParameter("id", id) };
        dt = DBLayer.SelectData("Get_Exam_By_StdID", SParameter);
        return dt;
    }
    //DisplayCorrectiveStudentsByCourse
    public static DataTable DisplayCorrectiveStudentsByCourse(int crsID)
    {
        SqlParameter[] SParameter = { new SqlParameter("crsID", crsID) };
        dt = DBLayer.SelectData("DisplayCorrectiveStudentsByCourse", SParameter);
        return dt;
    }
    //DisplayCorrectiveStudentsByDepartment
    public static DataTable DisplayCorrectiveStudentsByDepartment(int deptID)
    {
        SqlParameter[] SParameter = { new SqlParameter("deptID", deptID) };
        dt = DBLayer.SelectData("DisplayCorrectiveStudentsByDepartment", SParameter);
        return dt;
    }
    //Questions of courses without model answer 
    public static DataTable Questions_courses_without_model_answer(int id)
    {
        SqlParameter[] SParameter = { new SqlParameter("id", id) };
        dt = DBLayer.SelectData("Questions_courses_without_model_answer", SParameter);
        return dt;
    }
    //DisplayStudentsResults
    public static DataTable DisplayStudentsResults()
    {       
        dt = DBLayer.SelectData("DisplayStudentsResults");
        return dt;
    }
    //DisplayCoursesPerStudent
    public static DataTable DisplayCoursesPerStudent(int ID)
    {
        SqlParameter[] SParameter = { new SqlParameter("ID", ID) };
        dt = DBLayer.SelectData("DisplayCoursesPerStudent", SParameter);
        return dt;
    }
    //DisplayStudentInfo
    public static DataTable DisplayStudentInfo(int id)
    {
        SqlParameter[] SParameter = { new SqlParameter("id", id) };
        dt = DBLayer.SelectData("DisplayStudentInfo", SParameter);
        return dt;
    }
    //DisplayStudentAnswersAfterGeneration
    public static DataTable DisplayStudentAnswersAfterGeneration(int Eid,int Sid)
    {
        SqlParameter[] SParameter = { new SqlParameter("Eid", Eid), new SqlParameter("Sid", Sid) };
        dt = DBLayer.SelectData("DisplayStudentAnswersAfterGeneration", SParameter);
        return dt;
    }

    //Student_exam_answer_model_answer
    public static DataTable Student_exam_answer_model_answer(int Eid, int Sid)
    {
        SqlParameter[] SParameter = { new SqlParameter("Eid", Eid), new SqlParameter("Sid", Sid) };
        dt = DBLayer.SelectData("Student_exam_answer_model_answer", SParameter);
        return dt;
    }
    //Exam and students by date 
    public static DataTable Get_Exam_By_Date(string date)
    {
        SqlParameter[] SParameter = { new SqlParameter("date",date) };
        dt = DBLayer.SelectData("Get_Exam_By_Date", SParameter);
        return dt;
    }



}
