using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineExam
{
    public partial class DisplayStudentAnswersAfterGeneration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
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

        protected void btnview_Click(object sender, EventArgs e)
        {
            try
            {
                gvStudAfterExam.DataSource = Display.DisplayStudentAnswersAfterGeneration(int.Parse(ddlExam.SelectedValue), int.Parse(ddlStudent.SelectedValue));
                gvStudAfterExam.DataBind();

            }
            catch
            {
                lblresult.Text = "error in Results";
            }


        }

        protected void ddlExam_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void gvStudAfterExam_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }
}