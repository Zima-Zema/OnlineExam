using OnlineExam;
using OnlineExam.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
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
            FillDDL();
            FillQtype();
        }

        protected void btn_ManageQuestion_Click(object sender, EventArgs e)
        {
            pl_manage.Visible = true;
            pl_createQ.Visible = false;
            btn_cancel.Visible = true;
            ddl_EditQuestion.Enabled = false;
            ddl_EditQuestion.SelectedIndex = 0;
        }

        protected void btn_cancel_Click(object sender, EventArgs e)
        {
            pl_createQ.Visible = false;
            pl_manage.Visible = false;
            ddl_EditQuestion.Enabled = true;
        }


        private void FillDDL()
        {

            ddl_course.Items.Clear();
            ddl_course.DataSource = CourseBL.GetAllCourses();
            ddl_course.DataTextField = "Crs-Name";
            ddl_course.DataValueField = "Crs-ID";
            ddl_course.DataBind();
            ListItem c = new ListItem("none", "0");
            ddl_course.Items.Insert(0, c);
            
        }
        private void FillQtype()
        {
            ddl_Qtype.Items.Clear();
            //ListItem none = new ListItem("none", "NULL");
            ListItem mcq = new ListItem("MCQ", "MCQ");
            ListItem tf = new ListItem("True|False", "TF");
            //ddl_Qtype.Items.Insert(0, none);
            ddl_Qtype.Items.Insert(0, mcq);
            ddl_Qtype.Items.Insert(1, tf);
            ddl_Qtype.DataBind();
            pl_mcq.Visible = false;
            pl_true.Visible = false;
        }

        private void FillMcqModel()
        {
            ddl_mcqModel.Items.Clear();
            ListItem a = new ListItem("A", "A");
            ListItem b = new ListItem("B", "B");
            ListItem c = new ListItem("C", "C");
            ListItem d = new ListItem("D", "D");
            ddl_mcqModel.Items.Insert(0, a);
            ddl_mcqModel.Items.Insert(1, b);
            ddl_mcqModel.Items.Insert(2, c);
            ddl_mcqModel.Items.Insert(3, d);
            ddl_mcqModel.DataBind();
        }
        private void FillTfModel()
        {
            ddl_tfModel.Items.Clear();
            ListItem t = new ListItem("True", "T");
            ListItem f = new ListItem("False", "F");
            ddl_tfModel.Items.Insert(0, t);
            ddl_tfModel.Items.Insert(1, f);
            ddl_tfModel.DataBind();
        }

        protected void ddl_Qtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_status0.Text = ddl_Qtype.SelectedValue;

            //if (ddl_Qtype.SelectedIndex==0)
            //{
            //    pl_mcq.Visible = true;
            //    pl_true.Visible = false;
            //    FillMcqModel();

            //}
            //if (ddl_Qtype.SelectedIndex==1)
            //{
            //    pl_true.Visible = true;
            //    pl_mcq.Visible = false;
            //    FillTfModel();

            //}
            //else
            //{
            //    pl_mcq.Visible = false;
            //    pl_true.Visible = false;
            //}
            //switch (ddl_Qtype.SelectedIndex)
            //{
            //    case 0:
            //        pl_mcq.Visible = true;
            //        pl_true.Visible = false;
            //        FillMcqModel();
            //        break;
            //    case 1:
            //        pl_true.Visible = true;
            //        pl_mcq.Visible = false;
            //        FillTfModel();
            //        break;
            //    default:
            //        pl_mcq.Visible = false;
            //        pl_true.Visible = false;
            //        break;
            //}
        }

        protected void ddl_course_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillQtype();
         
        }

        protected void btn_insert_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                if (ddl_Qtype.SelectedValue == "MCQ")
                {
                    int rows = Questions.Create_MCQ(ddl_Qtype.SelectedValue, int.Parse(txt_mcqGrade.Text), ddl_mcqModel.SelectedValue, txt_mcqHead.Text, int.Parse(ddl_course.SelectedValue), "A", txt_ansA.Text, "B", txt_ansB.Text, "C", txt_ansC.Text, "D", txt_ansD.Text);
                    if (rows > 0)
                    {
                        lbl_status0.Text = "Successfully Added";
                        txt_mcqGrade.Text = txt_mcqHead.Text = txt_ansA.Text = txt_ansB.Text = txt_ansC.Text = txt_ansD.Text = string.Empty;

                    }

                }
                else if (ddl_Qtype.SelectedValue == "TF")
                {
                    int rows = Questions.Create_Question(ddl_Qtype.SelectedValue, int.Parse(txt_tfGrade.Text), ddl_tfModel.SelectedValue, txt_tfHead.Text, int.Parse(ddl_course.SelectedValue));
                    if (rows > 0)
                    {
                        lbl_status0.Text = "Successfully Added";
                        txt_tfHead.Text = txt_tfGrade.Text = string.Empty;
                    }
                }
                else
                {
                    lbl_status0.Text = "Please Select Question Type";
                    pl_mcq.Visible = false;
                    pl_true.Visible = false;
                }
            }
        }

        protected void btn_cancelCreate_Click(object sender, EventArgs e)
        {
            ddl_course.SelectedIndex = 0;
            ddl_Qtype.SelectedIndex = 0;
            txt_mcqGrade.Text = txt_mcqHead.Text = txt_ansA.Text = txt_ansB.Text = txt_ansC.Text = txt_ansD.Text = string.Empty;
            txt_tfHead.Text = txt_tfGrade.Text = string.Empty;
            pl_mcq.Visible = false;
            pl_true.Visible = false;
        }
    }
}