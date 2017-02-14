using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace OnlineExam
{
    public partial class Specific_student_information : System.Web.UI.Page
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

        protected void ddlstudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = Display.DisplayStudentInfo(int.Parse(ddlstudent.SelectedValue));
                gvStudentInfo.DataSource = dt;
                gvStudentInfo.DataBind();
            }
            catch
            {
                lblresult.Text = "Error in student No";
            }

        }
    }
}