using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace OnlineExam
{
    public partial class Display_topics_per_Course : System.Web.UI.Page
    {
        DataTable dt = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlcourse.DataSource = BusinessLayer.Display_course_by_Idand_Name();
                ddlcourse.DataValueField = "Crs-ID";
                ddlcourse.DataTextField = "Crs-Name";
                ddlcourse.DataBind();


            }


        }

        protected void ddlcourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = Display.Get_Topics_By_Cource(int.Parse(ddlcourse.SelectedValue));
                gvDisplayTopic.DataSource = dt;
                gvDisplayTopic.DataBind();
            }
            catch
            {
                lblresult.Text = "error in Course";
            }
        }

        protected void gvDisplayTopic_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}