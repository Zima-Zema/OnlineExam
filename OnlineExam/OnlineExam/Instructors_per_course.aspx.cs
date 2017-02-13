using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace OnlineExam
{
    public partial class Instructors_per_course : System.Web.UI.Page
    {
        DataTable dt = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlcourse.DataSource = BusinessLayer.Display_course_by_Idand_Name();
                ddlcourse.DataValueField = "Crs-ID";
                ddlcourse.DataTextField = "Crs-ID";
                ddlcourse.DataBind();


            }

        }

        protected void ddlcourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = Display.Get_Instrucror_By_Cource(int.Parse(ddlcourse.SelectedValue));
                gvDisplayInstructor.DataSource = dt;
                gvDisplayInstructor.DataBind();
            }
            catch
            {
                lblresult.Text = "Error In Course No";
            }

        }

        protected void gvDisplayTopic_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}