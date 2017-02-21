using OnlineExam.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.Admin.Admin_UC
{
    public partial class StudenExamsByDate : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void cal_examDate_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                gv_ExamDate.DataSource = ExamBL.GetExamByDate(cal_examDate.SelectedDate.Date.ToString());
                gv_ExamDate.DataBind();

            }
            catch (Exception ex)
            {
                Admins.LogError(ex.Message.ToString(), DateTime.Now.ToLongDateString(), DateTime.Now.ToLongTimeString(), Path.GetFileName(Request.Url.AbsolutePath), "FullDDL");
                lbl_status.Text = "انت اتغفلت";
            }

        }
    }
}