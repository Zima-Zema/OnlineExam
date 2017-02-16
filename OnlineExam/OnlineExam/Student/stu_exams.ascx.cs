using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OnlineExam.Code;
using OnlineExam;
using System.IO;

namespace WebApplication1.Student.Stu_UC
{
    public partial class stu_exams : System.Web.UI.UserControl
    {
        Dictionary<int, string> ansDdictionary = new Dictionary<int, string>(10);

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                FullGVWithExams();
                FilltfAnswer();
                FillMcqModel();
                pl_mcqans.Visible = pl_tfans.Visible = false;
            }
        }

        private void FullGVWithExams()
        {
            try
            {
                DataTable dataTable = new DataTable();
                dataTable = OnlineExam.Code.StudentsBL.GetStudentByuserName(Session["username"].ToString());
                Session["id"] = dataTable.Rows[0]["St-ID"].ToString();

                gv_StudentExam.DataSource = ExamBL.GetAssignedExamByStdID(int.Parse(Session["id"].ToString()));
                gv_StudentExam.DataBind();

                if (gv_StudentExam.Rows.Count < 1)
                {
                    lbl_examstatus.Text = "There Is no Exams For You Right Now";
                    gv_StudentExam.DataSource = null;
                }
                else
                {
                    lbl_examstatus.Text = "";
                }
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        private void FilltfAnswer()
        {
            ddl_tfans.Items.Clear();
            ListItem t = new ListItem("True", "T");
            ListItem f = new ListItem("False", "F");
            ddl_tfans.Items.Insert(0, t);
            ddl_tfans.Items.Insert(1, f);
            ddl_tfans.DataBind();
        }
        private void FillMcqModel()
        {
            ddl_Mcqans.Items.Clear();
            ListItem a = new ListItem("A", "A");
            ListItem b = new ListItem("B", "B");
            ListItem c = new ListItem("C", "C");
            ListItem d = new ListItem("D", "D");
            ddl_Mcqans.Items.Insert(0, a);
            ddl_Mcqans.Items.Insert(1, b);
            ddl_Mcqans.Items.Insert(2, c);
            ddl_Mcqans.Items.Insert(3, d);
            ddl_Mcqans.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            gv_StudentExam.Visible = false;
            lbl_examstatus.Visible = false;
            pl_stud_Exam.Visible = true;
            btn_Submit.Visible = true;
            lbl_status.Visible = true;
            int x = int.Parse(gv_StudentExam.SelectedRow.Cells[1].Text.ToString());
            dv_exam.DataSource = ExamBL.Get_Question_By_Exam(int.Parse(gv_StudentExam.SelectedRow.Cells[1].Text.ToString()));
            dv_exam.DataBind();
            
            Session["ex_id"] = gv_StudentExam.SelectedRow.Cells[1].Text;
        }

        protected void DetailsView1_PageIndexChanging1(object sender, DetailsViewPageEventArgs e)
        {

           
            try
            {
                DataTable dataTable = new DataTable();
                dataTable = Questions.GetMcqQuestionByID(int.Parse((dv_exam.Rows[0].FindControl("Label2") as Label).Text));
                if (dataTable.Rows.Count > 1)
                {
                    pl_mcqans.Visible = true;
                    pl_tfans.Visible = false;
                    ansDdictionary[dv_exam.PageIndex] = ddl_Mcqans.SelectedValue;
                   
                }
                else
                {
                    pl_mcqans.Visible = true;
                    pl_tfans.Visible = false;
                    ansDdictionary[dv_exam.PageIndex] = ddl_tfans.SelectedValue;

                }
            }
            catch (Exception ex)
            {
                lbl_status.Text = "Somting went wrong";
                Admins.LogError(ex.Message.ToString(), DateTime.Now.ToLongDateString(), DateTime.Now.ToLongTimeString(), Path.GetFileName(Request.Url.AbsolutePath), "DetailsView1_PageIndexChanging1");

            }
            
            dv_exam.DataSource = ExamBL.Get_Question_By_Exam(int.Parse(gv_StudentExam.SelectedRow.Cells[1].Text.ToString()));
            dv_exam.PageIndex = e.NewPageIndex;
            dv_exam.ChangeMode(DetailsViewMode.ReadOnly);
            dv_exam.DataBind();
            
            string item;
            if (ansDdictionary.TryGetValue(e.NewPageIndex,out item))
            {
                try
                {
                    DataTable dataTable = new DataTable();
                    dataTable = Questions.GetMcqQuestionByID(int.Parse((dv_exam.Rows[0].FindControl("Label2") as Label).Text));
                    if (dataTable.Rows.Count > 1)
                    {
                        pl_mcqans.Visible = true;
                        pl_tfans.Visible = false;
                        
                        ddl_Mcqans.SelectedValue = ansDdictionary[e.NewPageIndex];

                    }
                    else
                    {
                        pl_mcqans.Visible = true;
                        pl_tfans.Visible = false;
                        ddl_tfans.SelectedValue = ansDdictionary[e.NewPageIndex];


                    }
                }
                catch (Exception ex)
                {
                    lbl_status.Text = "Somting went wrong";
                    Admins.LogError(ex.Message.ToString(), DateTime.Now.ToLongDateString(), DateTime.Now.ToLongTimeString(), Path.GetFileName(Request.Url.AbsolutePath), "DetailsView1_PageIndexChanging1");

                }
            }
          
            
        }

        

   

        protected void Button1_Click(object sender, EventArgs e)
        {
            lbl_status.Text = string.Empty;
            try
            {
                for (int i = 0; i < ansDdictionary.Count; i++)
                {
                    if (ansDdictionary[i] == null)
                    {
                        lbl_status.Text = "Answer All Questions";
                    }
                }
                if (lbl_status.Text == "")
                {
                    ExamBL.ExamAnswers(int.Parse(Session["id"].ToString()), int.Parse(Session["ex_id"].ToString()), ansDdictionary[0], ansDdictionary[1], ansDdictionary[2], ansDdictionary[3], ansDdictionary[4], ansDdictionary[5], ansDdictionary[6], ansDdictionary[7], ansDdictionary[8], ansDdictionary[9]);
                    ExamBL.CorrectExam(int.Parse(Session["id"].ToString()), int.Parse(Session["ex_id"].ToString()));
                    Response.Redirect("~/Student/Default.aspx");
                }
            }
            catch (Exception ex)
            {
                lbl_status.Text = "Somting went wrong";
                Admins.LogError(ex.Message.ToString(), DateTime.Now.ToLongDateString(), DateTime.Now.ToLongTimeString(), Path.GetFileName(Request.Url.AbsolutePath), "Button1_Click");

            }

        }

        protected void ddl_Mcqans_SelectedIndexChanged(object sender, EventArgs e)
        {
            ansDdictionary.Add(dv_exam.PageIndex, ddl_Mcqans.SelectedValue);
        }
    }
}