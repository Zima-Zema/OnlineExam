using OnlineExam;
using OnlineExam.Code;
using System;
using System.Data;
using System.IO;
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
            try
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
                btn_ManageQuestion.Visible = false;
            }
            catch (Exception ex)
            {

                lbl_status.Text = "Somting went wrong";
                Admins.LogError(ex.Message.ToString(), DateTime.Now.ToLongDateString(), DateTime.Now.ToLongTimeString(), Path.GetFileName(Request.Url.AbsolutePath), "FullDDLWithCourses");

            }
            
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

        protected void ddl_EditQuestion_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (ddl_EditQuestion.SelectedIndex != 0)
                {
                    gv_EditQuestion.DataSource = Questions.GetQuestionByCourse(int.Parse(ddl_EditQuestion.SelectedValue));
                    gv_EditQuestion.DataBind();
                    btn_ManageQuestion.Visible = true;
                }
                else
                {
                    btn_ManageQuestion.Visible = false;
                }
            }
            catch (Exception ex)
            {

                lbl_status.Text = "Somting went wrong";
                Admins.LogError(ex.Message.ToString(), DateTime.Now.ToLongDateString(), DateTime.Now.ToLongTimeString(), Path.GetFileName(Request.Url.AbsolutePath), "ddl_EditQuestion_SelectedIndexChanged");

            }
            
           

        }
        protected void DetailsView1_PageIndexChanging1(object sender, DetailsViewPageEventArgs e)
        {
            try
            {
                gv_EditQuestion.DataSource = Questions.GetQuestionByCourse(int.Parse(ddl_EditQuestion.SelectedValue));
                gv_EditQuestion.PageIndex = e.NewPageIndex;
                gv_EditQuestion.ChangeMode(DetailsViewMode.ReadOnly);
                gv_EditQuestion.DataBind();
            }
            catch (Exception ex)
            {
                lbl_status.Text = "Somting went wrong";
                Admins.LogError(ex.Message.ToString(), DateTime.Now.ToLongDateString(), DateTime.Now.ToLongTimeString(), Path.GetFileName(Request.Url.AbsolutePath), "DetailsView1_PageIndexChanging1");

            }
            
        }

        protected void DetailsView1_ModeChanging(object sender, DetailsViewModeEventArgs e)
        {
            try
            {
                gv_EditQuestion.DataSource = Questions.GetQuestionByCourse(int.Parse(ddl_EditQuestion.SelectedValue));
                if (e.NewMode == DetailsViewMode.Edit)
                {
                    gv_EditQuestion.ChangeMode(DetailsViewMode.Edit);
                }
                else if (e.NewMode == DetailsViewMode.Insert)
                {
                    gv_EditQuestion.ChangeMode(DetailsViewMode.Insert);
                }
                else if (e.CancelingEdit)
                {
                    gv_EditQuestion.ChangeMode(DetailsViewMode.ReadOnly);
                }
                else if (e.Cancel)
                {
                    gv_EditQuestion.ChangeMode(DetailsViewMode.ReadOnly);
                }
                gv_EditQuestion.DataBind();
            }
            catch (Exception ex)
            {

                lbl_status.Text = "Somting went wrong";
                Admins.LogError(ex.Message.ToString(), DateTime.Now.ToLongDateString(), DateTime.Now.ToLongTimeString(), Path.GetFileName(Request.Url.AbsolutePath), "DetailsView1_ModeChanging");

            }

            
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
           
           
            FillType();
            FillMcqModel();
            FillTfModel();

            try
            {
                DataTable dataTable = new DataTable();
                dataTable = Questions.GetMcqQuestionByID(int.Parse((gv_EditQuestion.Rows[0].FindControl("Label2") as Label).Text));
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
                    
                    dataTable = Questions.GetQuestionByID(int.Parse((gv_EditQuestion.Rows[0].FindControl("Label2") as Label).Text));
                    txt_tfHead.Text = dataTable.Rows[0]["Question-Head"].ToString();
                    ddl_tfType.SelectedIndex = 1;
                    txt_tfGrade.Text = dataTable.Rows[0]["Quesion-Grade"].ToString();
                    ddl_tfModel.SelectedValue = dataTable.Rows[0]["QModelAnswer"].ToString();

                }
            }
            catch (Exception ex)
            {
                lbl_status.Text = "Somting went wrong";
                Admins.LogError(ex.Message.ToString(), DateTime.Now.ToLongDateString(), DateTime.Now.ToLongTimeString(), Path.GetFileName(Request.Url.AbsolutePath), "btn_ManageQuestion_Click");

            }


        }

        private void FillType()
        {
            ddl_mcqType.Items.Clear();
            ListItem none = new ListItem("none", "NULL");
            ListItem mcq = new ListItem("MCQ", "MCQ");
            ListItem tf = new ListItem("TF", "TF");
            ddl_mcqType.Items.Insert(0, mcq);
            ddl_mcqType.Items.Insert(1, tf);
            ddl_tfType.Items.Insert(0, mcq);
            ddl_tfType.Items.Insert(1, tf);
            ddl_tfType.DataBind();
        }

        protected void btn_cancel_Click(object sender, EventArgs e)
        {
            //pl_createQ.Visible = false;
            pl_manage.Visible = false;
            ddl_EditQuestion.Enabled = true;
        }
        
        protected void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dataTable = new DataTable();
                dataTable = Questions.GetMcqQuestionByID(int.Parse((gv_EditQuestion.Rows[0].FindControl("Label2") as Label).Text));
                if (dataTable.Rows.Count > 1)
                {
                    int rows = Questions.Edit_MCQ(int.Parse((gv_EditQuestion.Rows[0].FindControl("Label2") as Label).Text), ddl_mcqType.SelectedValue, int.Parse(txt_mcqGrade.Text), ddl_mcqModel.SelectedValue, txt_mcqHead.Text, int.Parse(ddl_EditQuestion.SelectedValue), "A", txt_ansA.Text, "B", txt_ansB.Text, "C", txt_ansC.Text, "D", txt_ansD.Text);
                    if (rows > 0)
                    {
                        lbl_status0.Text = "Successfully Updated";
                        txt_mcqGrade.Text = txt_mcqHead.Text = txt_ansA.Text = txt_ansB.Text = txt_ansC.Text = txt_ansD.Text = string.Empty;


                    }
                    else
                    {
                        lbl_status0.Text = "Update Failed";
                    }
                }
                else
                {
                    int rows = Questions.Edit_Question(int.Parse((gv_EditQuestion.Rows[0].FindControl("Label2") as Label).Text), ddl_tfType.SelectedValue, int.Parse(txt_tfGrade.Text), ddl_tfModel.SelectedValue, txt_tfHead.Text, int.Parse(ddl_EditQuestion.SelectedValue));
                    if (rows > 0)
                    {
                        lbl_status.Text = "Successfully Updated";
                        txt_mcqGrade.Text = txt_mcqHead.Text = txt_ansA.Text = txt_ansB.Text = txt_ansC.Text = txt_ansD.Text = string.Empty;


                    }
                    else
                    {
                        lbl_status0.Text = "Update Failed";
                    }
                }

            }
            catch (Exception ex)
            {

                lbl_status0.Text = "Somthing Went Wrong";
                Admins.LogError(ex.Message.ToString(), DateTime.Now.ToLongDateString(), DateTime.Now.ToLongTimeString(), Path.GetFileName(Request.Url.AbsolutePath), "btn_update_Click");


            }

        }

        protected void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                int rows = Questions.Remove_Question(int.Parse((gv_EditQuestion.Rows[0].FindControl("Label2") as Label).Text));
                if (rows > 0)
                {
                    lbl_status.Text = "Successfully Deleted";
                    txt_mcqGrade.Text = txt_mcqHead.Text = txt_ansA.Text = txt_ansB.Text = txt_ansC.Text = txt_ansD.Text = string.Empty;
                    pl_mcq.Visible = false;
                    pl_true.Visible = false;

                }
                else
                {
                    lbl_status.Text = "Delete Failed";
                }
            }
            catch (Exception ex)
            {
                lbl_status0.Text = "Somthing Went Wrong";
                Admins.LogError(ex.Message.ToString(), DateTime.Now.ToLongDateString(), DateTime.Now.ToLongTimeString(), Path.GetFileName(Request.Url.AbsolutePath), "btn_delete_Click");

            }


        }

        protected void btn_cancel0_Click(object sender, EventArgs e)
        {
            
            txt_mcqGrade.Text = txt_mcqHead.Text = txt_ansA.Text = txt_ansB.Text = txt_ansC.Text = txt_ansD.Text = string.Empty;
            txt_tfHead.Text = txt_tfGrade.Text = string.Empty;
            pl_mcq.Visible = false;
            pl_true.Visible = false;
            
        }

       
    }
}