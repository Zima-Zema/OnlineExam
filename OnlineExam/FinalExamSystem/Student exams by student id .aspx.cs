using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Student_exams_by_student_id_ : System.Web.UI.Page
{
    DataTable dt = new DataTable();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            ddlstudent.DataSource = Display.DisplayStudentByID();
            ddlstudent.DataValueField = "St-ID";
            ddlstudent.DataTextField = "St-ID";
            ddlstudent.DataBind();

        }

    }

    protected void ddlExam_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            DataTable dt = Display.Get_Exam_By_StdID(int.Parse(ddlstudent.SelectedValue));
            gvStudExam.DataSource = dt;
            gvStudExam.DataBind();
        }
        catch
        {
            lblresult.Text = "Error in Student";
        }

    }
}