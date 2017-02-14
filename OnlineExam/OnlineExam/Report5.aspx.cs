using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineExam
{
    public partial class Report5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlStudent.DataSource = Reports.DisplayStudentByID();
                ddlStudent.DataValueField = "St-ID";
                ddlStudent.DataTextField = "St-ID";
                ddlStudent.DataBind();
                ddlExam.DataSource = Reports.DisplayExamByID();
                ddlExam.DataValueField = "Exam-ID";
                ddlExam.DataTextField = "Exam-ID";
                ddlExam.DataBind();

            }

        }



        protected void btnshow_Click(object sender, EventArgs e)
        {
            try
            {
                gvR5.DataSource = Reports.R5(int.Parse(ddlExam.SelectedValue), int.Parse(ddlStudent.SelectedValue));
                gvR5.DataBind();
            }
            catch
            {
                lblresult.Text = "Error In Exam No";
            }

        }

        protected void ddlStudent_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}