using OnlineExam;
using OnlineExam.Code;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.Admin.Admin_UC
{
    public partial class GenerateExam : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                fillDDlWithCrs();
                
            }
        }

        private void fillDDlWithStudents()
        {
            ddl_selectStn.Items.Clear();
            ddl_selectStn.DataSource = Student.GetStusent();
         
            ddl_selectStn.DataTextField = "St-Fname";
            ddl_selectStn.DataValueField = "St-ID";
            ddl_selectStn.DataBind();
            ListItem m = new ListItem("none", "0");
            ddl_selectStn.Items.Insert(0, m);
        }

        private void fillDDlWithCrs()
        {
            ddl_courseId.Items.Clear();
            ddl_courseId.DataSource = CourseBL.GetAllCourses();
            ddl_courseId.DataTextField = "Crs-Name";
            ddl_courseId.DataValueField = "Crs-ID";
            ddl_courseId.DataBind();
            ListItem m = new ListItem("none", "0");
            ddl_courseId.Items.Insert(0, m);

            ddl_mcq.DataSource = Enumerable.Range(1, 10);
            ddl_mcq.DataBind();
            ListItem li = new ListItem("none", "0");
            ddl_mcq.Items.Insert(0, li);

        }

        protected void btn_GenerateExam_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataReader dataReader = ExamBL.GenerateExam(int.Parse(ddl_courseId.SelectedValue.ToString()), int.Parse(ddl_mcq.SelectedValue.ToString()), 10 - int.Parse(ddl_mcq.SelectedValue.ToString()));

                lbl_status.Text = "Exam Generated";
                Session["generated_exID"] = dataReader["EX_ID"].ToString();
                Panel2.Visible = true;
                Panel1.Visible = false;
                fillDDlWithStudents();
            }
            catch (Exception ex)
            {

                lbl_status.Text = "Somthing Went Wrong :(";
                Admins.LogError(ex.Message.ToString(), DateTime.Now.ToLongDateString(), DateTime.Now.ToLongTimeString(), Path.GetFileName(Request.Url.AbsolutePath), "Delete_Click");

            }


        }

        protected void btn_assign_Click(object sender, EventArgs e)
        {
            lbl_assStatus.Text = "";
            DataTable dt = new DataTable();
            //dt = Stud_examBL.selectStudentsbyExam_Stud_ID(Session["generated_exID"].ToString(), DropDownList2.SelectedValue);

            if (dt.Rows.Count < 1)
            {
               // Stud_examBL.StudentExam(Session["generated_exID"].ToString(), DropDownList2.SelectedValue);
                lbl_assStatus.Text = "Assigned";
            }
            else
            {
                lbl_assStatus.Text = "Assigned before";
            }
        }

        protected void ddl_courseId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void ddl_selectStn_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}