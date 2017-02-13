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
    }
}