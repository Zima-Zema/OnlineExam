﻿using OnlineExam;
using OnlineExam.Code;
using System;
using System.Data;
using System.Web.UI.WebControls;

namespace WebApplication1.Admin
{
    public partial class QuestionsUC : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                FullDDLWithCourses();
                btn_cancel.Visible = false;
            }
        }

        private void FullDDLWithCourses()
        {
            ddl_EditQuestion.Items.Clear();
            ddl_EditQuestion.DataSource = CourseBL.GetAllCourses();
            ddl_EditQuestion.DataTextField = "Crs-Name";
            ddl_EditQuestion.DataValueField = "Crs-Id";
            ddl_EditQuestion.DataBind();
            ListItem m = new ListItem("none", "0");
            ddl_EditQuestion.Items.Insert(0, m);
            pl_createQ.Visible = false;
            pl_manage.Visible = false;
        }

        protected void ddl_EditQuestion_SelectedIndexChanged(object sender, EventArgs e)
        {
            gv_EditQuestion.DataSource = Questions.GetQuestionByCourse(int.Parse(ddl_EditQuestion.SelectedValue));
            
            gv_EditQuestion.DataBind();
            
        }
        protected void DetailsView1_PageIndexChanging1(object sender, DetailsViewPageEventArgs e)
        {
            gv_EditQuestion.DataSource = Questions.GetQuestionByCourse(int.Parse(ddl_EditQuestion.SelectedValue));
            gv_EditQuestion.PageIndex = e.NewPageIndex;
            gv_EditQuestion.ChangeMode(DetailsViewMode.ReadOnly);
            gv_EditQuestion.DataBind();
        }

        protected void DetailsView1_ModeChanging(object sender, DetailsViewModeEventArgs e)
        {
          
            gv_EditQuestion.DataSource = Questions.GetQuestionByCourse(int.Parse(ddl_EditQuestion.SelectedValue));
            if (e.NewMode == DetailsViewMode.Edit)
            {
                gv_EditQuestion.ChangeMode(DetailsViewMode.Edit);
            }
            else if(e.NewMode == DetailsViewMode.Insert)
            {
                gv_EditQuestion.ChangeMode(DetailsViewMode.Insert);
            }
            else if(e.CancelingEdit)
            {
               gv_EditQuestion.ChangeMode( DetailsViewMode.ReadOnly);
            }
            else if(e.Cancel)
            {
                gv_EditQuestion.ChangeMode(DetailsViewMode.ReadOnly);
            }
            gv_EditQuestion.DataBind();
        }

        protected void btn_CreateQuestion_Click(object sender, EventArgs e)
        {
            pl_createQ.Visible = true;
            pl_manage.Visible = false;
            btn_cancel.Visible = true;
            ddl_EditQuestion.Enabled = false;
            ddl_EditQuestion.SelectedIndex = 0;
            
        }

        protected void btn_ManageQuestion_Click(object sender, EventArgs e)
        {
            pl_manage.Visible = true;
            pl_createQ.Visible = false;
            btn_cancel.Visible = true;
            ddl_EditQuestion.Enabled = false;
            //ddl_EditQuestion.SelectedIndex = 0;
           
            FillType();

            DataTable dataTable = new DataTable();
            dataTable = Questions.GetMcqQuestionByID(int.Parse(gv_EditQuestion.Rows[0].Cells[1].Controls[0].ToString()));
            if (dataTable.Rows.Count > 1)
            {
                pl_mcq.Visible = true;
                pl_true.Visible = false;
                txt_mcqHead.Text = dataTable.Rows[0]["Question-Head"].ToString();
                ddl_mcqType.SelectedIndex = 0;
                txt_mcqGrade.Text = dataTable.Rows[0]["Quesion-Grade"].ToString();
                txt_ansA.Text = dataTable.Rows[0]["Choice-Text"].ToString();
                txt_ansB.Text = dataTable.Rows[1]["Choice-Text"].ToString();
                txt_ansC.Text = dataTable.Rows[2]["Choice-Text"].ToString();
                txt_ansD.Text = dataTable.Rows[3]["Choice-Text"].ToString();
                ddl_mcqModel.SelectedValue = dataTable.Rows[0]["QModelAnswer"].ToString();
            }
            else
            {
                pl_true.Visible = true;
                pl_mcq.Visible = false;
                dataTable = Questions.GetQuestionByID(int.Parse(gv_EditQuestion.Rows[0].Cells[1].Controls[0].ToString()));
                txt_tfHead.Text = dataTable.Rows[0]["Question-Head"].ToString();
                ddl_tfType.SelectedIndex = 1;
                txt_tfGrade.Text = dataTable.Rows[0]["Quesion-Grade"].ToString();
                ddl_tfModel.SelectedValue = dataTable.Rows[0]["QModelAnswer"].ToString();

            }

        }

        private void FillType()
        {
            ddl_mcqType.Items.Clear();
            ListItem none = new ListItem("none", "NULL");
            ListItem mcq = new ListItem("MCQ", "MCQ");
            ListItem tf = new ListItem("TF", "TF");
            //ddl_mcqType.Items.Insert(0, none);
            ddl_mcqType.Items.Insert(0, mcq);
            ddl_mcqType.Items.Insert(1, tf);

            //ddl_tfType.Items.Insert(0, none);
            ddl_tfType.Items.Insert(0, mcq);
            ddl_tfType.Items.Insert(1, tf);

            ddl_tfType.DataBind();
        }

        protected void btn_cancel_Click(object sender, EventArgs e)
        {
            pl_createQ.Visible = false;
            pl_manage.Visible = false;
            ddl_EditQuestion.Enabled = true;
        }

        protected void ddl_course_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btn_update_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            dataTable = Questions.GetMcqQuestionByID(int.Parse(gv_EditQuestion.Rows[0].Cells[1].Controls[0].ToString()));
            if (dataTable.Rows.Count > 1)
            {
                int rows = Questions.Edit_MCQ(int.Parse(gv_EditQuestion.Rows[0].Cells[1].Controls[0].ToString()), ddl_mcqType.SelectedValue, int.Parse(txt_mcqGrade.Text), ddl_mcqModel.SelectedValue, txt_mcqHead.Text, int.Parse(ddl_EditQuestion.SelectedValue), "A", txt_ansA.Text, "B", txt_ansB.Text, "C", txt_ansC.Text, "D", txt_ansD.Text);
                if (rows > 0)
                {
                    lbl_status.Text = "Successfully Updated";
                    txt_mcqGrade.Text = txt_mcqHead.Text = txt_ansA.Text = txt_ansB.Text = txt_ansC.Text = txt_ansD.Text = string.Empty;
                    

                }
                else
                {
                    lbl_status.Text = "Update Failed";
                }
            }
            else
            {
                int rows = Questions.Edit_Question(int.Parse(ddl_EditQuestion.SelectedValue), ddl_tfType.SelectedValue, int.Parse(txt_tfGrade.Text), ddl_tfModel.SelectedValue, txt_tfHead.Text, int.Parse(ddl_EditQuestion.SelectedValue));
                if (rows > 0)
                {
                    lbl_status.Text = "Successfully Updated";
                    txt_mcqGrade.Text = txt_mcqHead.Text = txt_ansA.Text = txt_ansB.Text = txt_ansC.Text = txt_ansD.Text = string.Empty;
                    

                }
                else
                {
                    lbl_status.Text = "Update Failed";
                }
            }
        }

        protected void btn_delete_Click(object sender, EventArgs e)
        {
            int rows = Questions.Remove_Question(int.Parse(gv_EditQuestion.Rows[0].Cells[1].Controls[0].ToString()));
            if (rows > 0)
            {
                lbl_status.Text = "Successfully Deleted";
                txt_mcqGrade.Text = txt_mcqHead.Text = txt_ansA.Text = txt_ansB.Text = txt_ansC.Text = txt_ansD.Text = string.Empty;
                //ddl_course.SelectedIndex = 0;
                //ddl_qByCourse.SelectedIndex = 0;
                //ddl_qByCourse.Enabled = false;
                pl_mcq.Visible = false;
                pl_true.Visible = false;

            }
            else
            {
                lbl_status.Text = "Delete Failed";
            }

        }

        protected void btn_cancel0_Click(object sender, EventArgs e)
        {
            //ddl_course.SelectedIndex = 0;
            //ddl_qByCourse.SelectedIndex = 0;
            txt_mcqGrade.Text = txt_mcqHead.Text = txt_ansA.Text = txt_ansB.Text = txt_ansC.Text = txt_ansD.Text = string.Empty;
            txt_tfHead.Text = txt_tfGrade.Text = string.Empty;
            pl_mcq.Visible = false;
            pl_true.Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label13.Text = gv_EditQuestion.Rows[0].Cells[1].Text.ToString();
            //Label13.Text = txt.Text;
        }
    }
}