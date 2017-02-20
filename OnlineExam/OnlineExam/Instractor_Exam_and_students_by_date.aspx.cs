using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace OnlineExam
{
    public partial class Instractor_Exam_and_students_by_date : System.Web.UI.Page
    {
        DataTable dt = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void gvcalender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void CalenderExam_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = Display.Get_Exam_By_Date((CalenderExam.SelectedDate).ToString());
                gvcalender.DataSource = dt;
                gvcalender.DataBind();
            }
            catch
            {
                lblresult.Text = "Error in Date Of Exam";
            }

        }
    }
}