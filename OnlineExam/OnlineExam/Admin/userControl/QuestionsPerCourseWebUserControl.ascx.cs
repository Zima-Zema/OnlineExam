using OnlineExam.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class QuestionsPerCourseWebUserControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                FillDDWithCourse();
            }
        }

        private void FillDDWithCourse()
        {
            ddl_selectCrsName.Items.Clear();
            ddl_selectCrsName.DataSource = QuestionPerCourse.GetAllCourses();
            ddl_selectCrsName.DataTextField = "Crs-Name";
            ddl_selectCrsName.DataValueField = "Crs-ID";
            ddl_selectCrsName.DataBind();
            ListItem m = new ListItem("none", "0");
            ddl_selectCrsName.Items.Insert(0, m);
        }

        protected void ddl_selectCrsName_SelectedIndexChanged1(object sender, EventArgs e)
        {

            gv_QuestionPerCrs.DataSource = QuestionPerCourse.GetCourseById(int.Parse(ddl_selectCrsName.SelectedValue));
            gv_QuestionPerCrs.DataBind();


            if (gv_QuestionPerCrs.Rows.Count == 0)
            {

                lbl_status.Text = " Thise course not have Questions Yet";
                lbl_status.Visible = true;

            }
            else
            {

                lbl_status.Visible = false;

            }


        }

        protected void DetailsView1_PageIndexChanging1(object sender, DetailsViewPageEventArgs e)
        {
            //DetailsView1.DataSource = QuestionsPerCourseBL.GetCourseById(DropDownList1.SelectedValue);
            gv_QuestionPerCrs.PageIndex = e.NewPageIndex;
            gv_QuestionPerCrs.ChangeMode(DetailsViewMode.ReadOnly);
            gv_QuestionPerCrs.DataBind();
        }
    }
}