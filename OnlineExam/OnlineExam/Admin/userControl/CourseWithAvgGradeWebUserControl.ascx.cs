using OnlineExam.Code;
using System;
using System.Linq;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class CourseWithAvgGradeWebUserControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                FillDDWithCourse();
            }

        }

        private void FillDDWithCourse()
        {
            ddl_avgGrade.Items.Clear();
            ddl_avgGrade.DataSource = CourseWithAvrgGradeBL.GetAllCourses();
            ddl_avgGrade.DataTextField = "Crs-Name";
            ddl_avgGrade.DataValueField = "Crs-ID";
            ddl_avgGrade.DataBind();
            ListItem m = new ListItem("none", "0");
            ddl_avgGrade.Items.Insert(0, m);

        }

        protected void ddl_avgGrade_SelectedIndexChanged(object sender, EventArgs e)
        {
            gv_avgGrade.DataSource =CourseWithAvrgGradeBL.GetCourseById(int.Parse(ddl_avgGrade.SelectedValue));
            gv_avgGrade.DataBind();
            if (gv_avgGrade.Rows.Count == 0)
            {

                lbl_status.Text = " Thise course not have Grade Yet";
                lbl_status.Visible = true;

            }
            else
            {

                lbl_status.Visible = false;

            }
        }

    }
}