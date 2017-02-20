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
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddl_course.DataSource = BusinessLayer.Display_course_by_Idand_Name();
                ddl_course.DataValueField = "Crs-ID";
                ddl_course.DataTextField = "Crs-Name";
                ddl_course.DataBind();


            }


        }

        protected void ddl_course_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = Display.Get_Topics_By_Cource(int.Parse(ddl_course.SelectedValue));
                gv_DisplayTopic.DataSource = dt;
                gv_DisplayTopic.DataBind();
            }
            catch
            {
                lbl_result.Text = "error in Course";
            }
        }

        protected void gvDisplayTopic_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}