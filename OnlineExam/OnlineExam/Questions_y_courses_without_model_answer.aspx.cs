using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace OnlineExam
{
    public partial class Questions_y_courses_without_model_answer : System.Web.UI.Page
    {
        DataTable dt = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlCourse.DataSource = BusinessLayer.Display_course_by_Idand_Name();
                ddlCourse.DataValueField = "Crs-ID";
                ddlCourse.DataTextField = "Crs-Name";
                ddlCourse.DataBind();
            }

        }

        protected void ddlCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = Display.Questions_courses_without_model_answer(int.Parse(ddlCourse.SelectedValue));
                gvcourseWithoutQques.DataSource = dt;
                gvcourseWithoutQques.DataBind();
            }
            catch
            {
                lblresult.Text = "Error in Course";
            }
        }
    }
}