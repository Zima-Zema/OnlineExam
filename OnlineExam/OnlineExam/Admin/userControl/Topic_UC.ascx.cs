using OnlineExam.Code;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.Admin
{
    public partial class Topic_UC : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                FullDDLWithTopics();

            }
        }

        private void FullDDLWithTopics()
        {
            ddl_topics.Items.Clear();
            ddl_topics.DataSource = TopicBL.GetAllTopic();
            ddl_topics.DataTextField = "Topic-Name";
            ddl_topics.DataValueField = "Topic-ID";
            ddl_topics.DataBind();
            ListItem m = new ListItem("none", "0");
            ddl_topics.Items.Insert(0, m);
        }

    

        protected void ddl_topics_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            DataTable dataTable = new DataTable();
            dataTable = TopicBL.GetTopicById(int.Parse(ddl_topics.SelectedValue));
            txt_TopicId.Text = dataTable.Rows[0]["Topic-ID"].ToString();
            txt_TopicName.Text = dataTable.Rows[0]["Topic-Name"].ToString();
         
        }

        protected void btn_NewTopic_Click(object sender, EventArgs e)
        {
            txt_TopicName.Text = txt_TopicId.Text = string.Empty;
        }

        protected void btn_InsertTopic_Click(object sender, EventArgs e)
        {
            // Label1.Text = topic.insertTopic(TextBox1.Text, DropDownList2.SelectedValue, TextBox3.Text) + "  Row Affected";
            int rows = TopicBL.Add_Topic(txt_TopicName.Text);
            if (rows>0)
            {
                lbl_status.Text = "Done";
                FullDDLWithTopics();
                ddl_topics.Items.Clear();
                btn_NewTopic_Click(sender, e);
            }
            else
            {
                lbl_status.Text = "Failed";
            }
          
           
        }

        protected void btn_update_Click(object sender, EventArgs e)
        {
            int rows = TopicBL.Edit_Topic(txt_TopicName.Text, int.Parse(txt_TopicId.Text));
            if (rows>0)
            {
                lbl_status.Text = "Done";
                FullDDLWithTopics();
                ddl_topics.Items.Clear();
                btn_NewTopic_Click(sender, e);
            }
            else
            {
                lbl_status.Text = "Failed";
            }



        }

        protected void btn_Delete_Click(object sender, EventArgs e)
        {
            int rows = TopicBL.Remove_Topic(int.Parse(txt_TopicId.Text));
            if (rows > 0)
            {
                lbl_status.Text = "Done";
                FullDDLWithTopics();
                ddl_topics.Items.Clear();
                btn_NewTopic_Click(sender, e);
            }
            else
            {
                lbl_status.Text = "Failed";
            }

        }

        

       
    }
}