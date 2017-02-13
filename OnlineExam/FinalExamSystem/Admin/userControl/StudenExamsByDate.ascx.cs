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
            //GridView1.DataSource = Stud_examBL.selectStudentsExambyDate(Calendar1.SelectedDate.Date.ToString());
            gv_ExamDate.DataSource = ExamBL.GetExamByDate(cal_examDate.SelectedDate.Date.ToString());
            gv_ExamDate.DataBind();

        }
    }
}