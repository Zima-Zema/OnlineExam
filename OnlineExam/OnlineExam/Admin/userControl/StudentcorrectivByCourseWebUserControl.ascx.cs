using OnlineExam.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class StudentcorrectivByCourseWebUserControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                FullDDLWithCourses();
            }

        }

        private void FullDDLWithCourses()
        {
            ddl_course.Items.Clear();
            ddl_course.DataSource = CourseBL.GetAllCourses();
            ddl_course.DataTextField = "Crs-Name";
            ddl_course.DataValueField = "Crs-Id";
            ddl_course.DataBind();
            ListItem m = new ListItem("none", "0");
            ddl_course.Items.Insert(0, m);
        }
        protected void ddl_course_SelectedIndexChanged(object sender, EventArgs e)
        {
            gv_corrective.DataSource = ExamBL.GetCorrectiveByCourse(int.Parse(ddl_course.SelectedValue));
            gv_corrective.DataBind();

            if(gv_corrective.Rows.Count==0)
             {
               
                 lbl_status.Text = " This Sudent Not have Corrective";
                 lbl_status.Visible = true;

             }
            else
            {

                lbl_status.Visible = false;
                
            }

             

        }
    }
}