﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace OnlineExam
{
    public partial class Student_Student_courses : System.Web.UI.Page
    {
        DataTable dt = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlstudent.DataSource = Display.DisplayStudentByID();
                ddlstudent.DataValueField = "St-ID";
                ddlstudent.DataTextField = "St-Fname";
                ddlstudent.DataBind();

            }

        }

        protected void ddlstudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = Display.DisplayCoursesPerStudent(int.Parse(ddlstudent.SelectedValue));
                gvStudCourse.DataSource = dt;
                gvStudCourse.DataBind();
            }
            catch
            {
                lblresult.Text = "Error in Student";
            }
        }
    }
}