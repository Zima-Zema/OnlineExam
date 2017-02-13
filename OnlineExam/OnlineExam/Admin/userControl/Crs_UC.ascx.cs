using OnlineExam.Code;
using System;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.Admin
{
    public partial class Crs_UC : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                FullDDL();
            }
        }

        private void FullDDL()
        {
            txt_Cid.Enabled = false;
            ddl_selectCourse.Items.Clear();
            ddl_selectCourse.DataSource = CourseBL.GetAllCourses();
            ddl_selectCourse.DataTextField = "Crs-Name";
            ddl_selectCourse.DataValueField = "Crs-ID";
            ddl_selectCourse.DataBind();
            ListItem c = new ListItem("none", "0");
            ddl_selectCourse.Items.Insert(0, c);


            ddl_topic.Items.Clear();
            ddl_topic.DataSource = TopicBL.GetAllTopic();
            ddl_topic.DataTextField = "Topic-Name";
            ddl_topic.DataValueField = "Topic-ID";
            ddl_topic.DataBind();
            ListItem t = new ListItem("none", "0");
            ddl_topic.Items.Insert(0, t);

        }
        protected void btn_insert_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {

                int rows = CourseBL.CreateCourse(txt_Cname.Text, int.Parse(txt_Cduration.Text), int.Parse(ddl_topic.SelectedValue));
                if (rows > 0)
                {
                    lbl_status.Text = "Successfully Added";
                }
                FullDDL();
                btn_Newcourse_Click(sender, e);
                txt_Cid.Enabled = false;
            }
           
        }

        protected void ddl_selectCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_Cid.Enabled = false;
            DataTable dataTable = new DataTable();
            dataTable = CourseBL.GetCourseByID(int.Parse(ddl_selectCourse.SelectedValue));
            txt_Cid.Text = dataTable.Rows[0]["Crs-ID"].ToString();
            txt_Cname.Text = dataTable.Rows[0]["Crs-Name"].ToString();
            txt_Cduration.Text = dataTable.Rows[0]["Crs-Duration"].ToString();
            ddl_topic.SelectedValue = dataTable.Rows[0]["Topic-ID"].ToString();
        }

        protected void btn_Update_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                int rows = CourseBL.EditCourse(int.Parse(txt_Cid.Text), txt_Cname.Text, int.Parse(txt_Cduration.Text), int.Parse(ddl_topic.SelectedValue));
                if (rows>0)
                {
                    lbl_status.Text = "Successfully Updated";
                }
                FullDDL();
                btn_Newcourse_Click(sender, e);
                txt_Cid.Enabled = false;
            }
         
        }

        protected void btn_Newcourse_Click(object sender, EventArgs e)
        {
            txt_Cid.Text = txt_Cname.Text = txt_Cduration.Text = string.Empty;
            txt_Cid.Enabled = false;
        }

        protected void btn_delete_Click(object sender, EventArgs e)
        {
            int rows = CourseBL.RemoveCourse(int.Parse(txt_Cid.Text));
            if (rows>0)
            {
                lbl_status.Text = "Successfully Deleted";
            }
            FullDDL();
            btn_Newcourse_Click(sender, e);
            txt_Cid.Enabled = false;
        }
    }
}