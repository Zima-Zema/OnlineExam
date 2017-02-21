using OnlineExam.Code;
using System;
using System.Collections.Generic;
using System.IO;
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
            try
            {
                ddl_TopicName.Items.Clear();
                ddl_TopicName.DataSource = TopicBL.GetAllTopic();
                ddl_TopicName.DataTextField = "Topic-Name";
                ddl_TopicName.DataValueField = "Topic-ID";
                ddl_TopicName.DataBind();
                ListItem m = new ListItem("none", "0");
                ddl_TopicName.Items.Insert(0, m);
            }
            catch (Exception ex)
            {

                lbl_status.Text = "Something Wrong happend";
                Admins.LogError(ex.Message.ToString(), DateTime.Now.ToLongDateString(), DateTime.Now.ToLongTimeString(), Path.GetFileName(Request.Url.AbsolutePath), System.Reflection.MethodBase.GetCurrentMethod().Name.ToString());

            }

        }


      
        
        
        

        protected void ddl_TopicName_SelectedIndexChanged1(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                Admins.LogError(ex.Message.ToString(), DateTime.Now.ToLongDateString(), DateTime.Now.ToLongTimeString(), Path.GetFileName(Request.Url.AbsolutePath), System.Reflection.MethodBase.GetCurrentMethod().Name.ToString());
                lbl_status.Text = "Something went worng";
            }



        }
    }
}