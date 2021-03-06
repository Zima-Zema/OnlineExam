﻿using OnlineExam.Code;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
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
            try
            {
                ddl_topics.Items.Clear();
                ddl_topics.DataSource = TopicBL.GetAllTopic();
                ddl_topics.DataTextField = "Topic-Name";
                ddl_topics.DataValueField = "Topic-ID";
                ddl_topics.DataBind();
                ListItem m = new ListItem("none", "0");
                ddl_topics.Items.Insert(0, m);
            }
            catch (Exception)
            {

                throw;
            }
            
        }

    

        protected void ddl_topics_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dataTable = new DataTable();
                dataTable = TopicBL.GetTopicById(int.Parse(ddl_topics.SelectedValue));
                txt_TopicId.Text = dataTable.Rows[0]["Topic-ID"].ToString();
                txt_TopicName.Text = dataTable.Rows[0]["Topic-Name"].ToString();
            }
            catch (Exception ex)
            {
                Admins.LogError(ex.Message.ToString(), DateTime.Now.ToLongDateString(), DateTime.Now.ToLongTimeString(), Path.GetFileName(Request.Url.AbsolutePath), System.Reflection.MethodBase.GetCurrentMethod().Name.ToString());
                lbl_status.Text = "Something Went Wrong";
            }


        }

        protected void btn_NewTopic_Click(object sender, EventArgs e)
        {
            txt_TopicName.Text = txt_TopicId.Text = string.Empty;
        }

        protected void btn_InsertTopic_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {


                try
                {
                    DataTable valid = TopicBL.Get_Topic_By_Name(txt_TopicName.Text.ToString());
                    if (valid.Rows.Count<1)
                    {
                        int rows = TopicBL.Add_Topic(txt_TopicName.Text);
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
                    else
                    {
                        lbl_status.Text = "This Topic is Already Found";
                    }
                    
                }
                catch (Exception ex)
                {

                    lbl_status.Text = "Something Went Wrong";
                    Admins.LogError(ex.Message.ToString(), DateTime.Now.ToLongDateString(), DateTime.Now.ToLongTimeString(), Path.GetFileName(Request.Url.AbsolutePath), System.Reflection.MethodBase.GetCurrentMethod().Name.ToString());

                }

            }

        }

        protected void btn_update_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {


                try
                {

                    DataTable valid = TopicBL.Get_Topic_By_Name(txt_TopicName.Text.ToString());
                    if (valid.Rows.Count < 1)
                    {
                        int rows = TopicBL.Edit_Topic(txt_TopicName.Text, int.Parse(txt_TopicId.Text));
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
                    else
                    {
                        lbl_status.Text = "This Topic is Already Found";
                    }


                }
                catch (Exception ex)
                {
                    lbl_status.Text = "Something went wrong";
                    Admins.LogError(ex.Message.ToString(), DateTime.Now.ToLongDateString(), DateTime.Now.ToLongTimeString(), Path.GetFileName(Request.Url.AbsolutePath), System.Reflection.MethodBase.GetCurrentMethod().Name.ToString());

                }

            }

        }

        protected void btn_Delete_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                lbl_status.Text = "Something Went Wrong";
                Admins.LogError(ex.Message.ToString(), DateTime.Now.ToLongDateString(), DateTime.Now.ToLongTimeString(), Path.GetFileName(Request.Url.AbsolutePath), System.Reflection.MethodBase.GetCurrentMethod().Name.ToString());

            }


        }

        

       
    }
}