using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineExam
{
    public partial class Student_exam_answer_model_answer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlStudent.DataSource = Display.DisplayStudentByID();
                ddlStudent.DataValueField = "St-ID";
                ddlStudent.DataTextField = "St-ID";
                ddlStudent.DataBind();
                ddlExam.DataSource = Reports.DisplayExamByID();
                ddlExam.DataValueField = "Exam-ID";
                ddlExam.DataTextField = "Exam-ID";
                ddlExam.DataBind();

            }

        }

        protected void ddlStudent_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void gvViewQues_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void ddlExam_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnshow_Click(object sender, EventArgs e)
        {
            try
            {
                gvViewQues.DataSource = Display.Student_exam_answer_model_answer(int.Parse(ddlExam.SelectedValue), int.Parse(ddlStudent.SelectedValue));
                gvViewQues.DataBind();
            }
            catch
            {
                lblresult.Text = "Error In Exam Or Student";
            }
        }
    }
}