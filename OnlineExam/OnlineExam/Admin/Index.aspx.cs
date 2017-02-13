using OnlineExam.Code;
using System;
using System.Data;

namespace OnlineExam.Admin
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if ((string)Session["type"] != "Admin" || Session["type"] == null)
                {
                    Session["username"] = null;
                    Session["type"] = null;
                    Response.Redirect("~/Account/Login.aspx");
                }
                else
                {
                   
                    DataTable dt = new DataTable();
                    dt = Admins.GetAdminByUsername(Session["username"].ToString());
                    Session["id"] = dt.Rows[0]["id"].ToString();
                    hideAllPanels();
                }
            }
        }
        private void hideAllPanels()
        {
            stud_pnl.Visible = false;
            dateexam.Visible = avggrade.Visible = InsSalary.Visible = Profileee.Visible = GenerateExam.Visible = dispInstructor.Visible = course_pnl.Visible = pnl_ins.Visible = Que_pnl.Visible = stud_pnl.Visible = tpic_pnl.Visible = topicpercrs.Visible = dept_manag.Visible = dept_pnl.Visible = Instrpercourse.Visible = quepercourse.Visible = false;
            correctiveCrs.Visible = false;
            correctiveDept.Visible = false;

        }

        protected void username_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Admin/Profile.aspx");
        }

        protected void student_btn_Click(object sender, EventArgs e)
        {
            hideAllPanels();
            stud_pnl.Visible = true;
        }

        protected void ins_btn_Click(object sender, EventArgs e)
        {
            hideAllPanels();
            pnl_ins.Visible = true;
        }

        protected void que_btn_Click(object sender, EventArgs e)
        {
            hideAllPanels();
            Que_pnl.Visible = true;
        }

        protected void dept_btn_Click(object sender, EventArgs e)
        {
            hideAllPanels();
            dept_pnl.Visible = true;
        }

        protected void Crs_btn_Click(object sender, EventArgs e)
        {
            hideAllPanels();
            course_pnl.Visible = true;
        }

        protected void Topic_btn_Click(object sender, EventArgs e)
        {
            hideAllPanels();
            tpic_pnl.Visible = true;
        }

        protected void btn_deptManager_Click(object sender, EventArgs e)
        {
            hideAllPanels();
            dept_manag.Visible = true;
        }

        protected void btn_topicCrs_Click(object sender, EventArgs e)
        {
            hideAllPanels();
            topicpercrs.Visible = true;
        }

        protected void btn_ins_Click(object sender, EventArgs e)
        {
            hideAllPanels();
            Instrpercourse.Visible = true;
        }

        protected void btn_QuesCrs_Click(object sender, EventArgs e)
        {
            hideAllPanels();
            quepercourse.Visible = true;
        }

        protected void btn_allINS_Click(object sender, EventArgs e)
        {
            hideAllPanels();
            dispInstructor.Visible = true;
        }

        protected void btn_generate_Click(object sender, EventArgs e)
        {
            hideAllPanels();
            GenerateExam.Visible = true;
        }

        protected void btn_salaryINS_Click(object sender, EventArgs e)
        {
            hideAllPanels();
            InsSalary.Visible = true;
        }

        protected void btn_courseAVG_Click(object sender, EventArgs e)
        {
            hideAllPanels();
            avggrade.Visible = true;
        }

        protected void btn_stdExamdate_Click(object sender, EventArgs e)
        {
            hideAllPanels();
            dateexam.Visible = true;
        }

        protected void btn_correctiveCourse_Click(object sender, EventArgs e)
        {
            hideAllPanels();
            correctiveCrs.Visible = true;
        }

        protected void btn_correctiveDept_Click(object sender, EventArgs e)
        {
            hideAllPanels();
            correctiveDept.Visible = true;
        }
    }
}