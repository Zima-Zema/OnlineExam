using OnlineExam.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class TopicPerCourseWebUserControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                FillDDWithCourse();
            }

           
        }

        private void FillDDWithCourse()
        {
            ddl_TopicName.Items.Clear();
            ddl_TopicName.DataSource = TopicBL.GetAllTopic();
            ddl_TopicName.DataTextField = "Topic-Name";
            ddl_TopicName.DataValueField = "Topic-ID";
            ddl_TopicName.DataBind();
            ListItem m = new ListItem("none", "0");
            ddl_TopicName.Items.Insert(0, m);
        }


      
        
        
        

        protected void ddl_TopicName_SelectedIndexChanged1(object sender, EventArgs e)
        {

            gv_TopicsPerCrs.DataSource = TopicsPerCourse.Get_Course_By_Topic(int.Parse(ddl_TopicName.SelectedValue));
            gv_TopicsPerCrs.DataBind();


            if (gv_TopicsPerCrs.Rows.Count == 0)
            {

                lbl_status.Text = " Thise Topi Does not have Course";
                lbl_status.Visible = true;

            }
            else
            {

                lbl_status.Visible = false;

            }


        }
    }
}