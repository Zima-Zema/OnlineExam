using System;
using System.Collections.Generic;
using System.Data;
using System.Web.UI.WebControls;
using OnlineExam.Code;
using OnlineExam;
using System.IO;

namespace WebApplication1.Student.Stu_UC
{
    public partial class stu_exams : System.Web.UI.UserControl
    {
       static Dictionary<int, string> ansDdictionary = new Dictionary<int, string>()
        {
            {0,"0" },{1,"0" },{2,"0" },
            {3,"0" },
            {4,"0" },
            {5,"0" },
            {6,"0" },
            {7,"0" },
            {8,"0" },
            {9,"0" },
           
        };

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
            ListItem n = new ListItem("none", "0");
            ListItem t = new ListItem("True", "T");
            ListItem f = new ListItem("False", "F");
            ddl_tfans.Items.Insert(0, n);
            ddl_tfans.Items.Insert(1, t);
            ddl_tfans.Items.Insert(2, f);
            ddl_tfans.DataBind();
        }
        private void FillMcqModel()
        {
            ddl_Mcqans.Items.Clear();
            ListItem n = new ListItem("none", "0");

            ListItem a = new ListItem("A", "A");
            ListItem b = new ListItem("B", "B");
            ListItem c = new ListItem("C", "C");
            ListItem d = new ListItem("D", "D");
            ddl_Mcqans.Items.Insert(0, n);

            ddl_Mcqans.Items.Insert(1, a);
            ddl_Mcqans.Items.Insert(2, b);
            ddl_Mcqans.Items.Insert(3, c);
            ddl_Mcqans.Items.Insert(4, d);
            ddl_Mcqans.DataBind();
        }

     

        protected void DetailsView1_PageIndexChanging1(object sender, DetailsViewPageEventArgs e)
        {
            dv_exam.DataSource = ExamBL.Get_Question_By_Exam(int.Parse(gv_StudentExam.SelectedRow.Cells[1].Text.ToString()));
            dv_exam.PageIndex = e.NewPageIndex;
            dv_exam.ChangeMode(DetailsViewMode.ReadOnly);
            dv_exam.DataBind();
            
            
            if (ansDdictionary[e.NewPageIndex]!="0")
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
                        pl_mcqans.Visible = false;
                        pl_tfans.Visible = true;
                        ddl_tfans.SelectedValue = ansDdictionary[e.NewPageIndex];


                    }
                }
                catch (Exception ex)
                {
                    lbl_status.Text = "Somting went wrong";
                    Admins.LogError(ex.Message.ToString(), DateTime.Now.ToLongDateString(), DateTime.Now.ToLongTimeString(), Path.GetFileName(Request.Url.AbsolutePath), "DetailsView1_PageIndexChanging1");

                }
            }
            else
            {
                ddl_Mcqans.SelectedValue = ddl_tfans.SelectedValue = ansDdictionary[e.NewPageIndex];
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
                    ExamBL.ExamAnswers(int.Parse(Session["id"].ToString()), int.Parse(Session["ex_id"].ToString()), ansDdictionary[0].ToString(), ansDdictionary[1].ToString(), ansDdictionary[2].ToString(), ansDdictionary[3].ToString(), ansDdictionary[4].ToString(), ansDdictionary[5].ToString(), ansDdictionary[6].ToString(), ansDdictionary[7].ToString(), ansDdictionary[8].ToString(), ansDdictionary[9].ToString());
                    ExamBL.CorrectExam(int.Parse(Session["id"].ToString()), int.Parse(Session["ex_id"].ToString()));
                    Response.Redirect("~/StudentForm.aspx");
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
            ansDdictionary[dv_exam.PageIndex] = ddl_Mcqans.SelectedValue;
        }

        protected void gv_StudentExam_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            gv_StudentExam.Visible = false;
            lbl_examstatus.Visible = false;

            dv_exam.Visible = true;
            pl_exam.Visible = true;
            btn_Submit.Visible = true;
            lbl_status.Visible = true;
            
            dv_exam.DataSource = ExamBL.Get_Question_By_Exam(int.Parse(gv_StudentExam.Rows[e.NewSelectedIndex].Cells[1].Text.ToString()));
            dv_exam.DataBind();
            Session["ex_id"] = gv_StudentExam.Rows[e.NewSelectedIndex].Cells[1].Text.ToString();

            try
            {
                DataTable dataTable = new DataTable();
                dataTable = Questions.GetMcqQuestionByID(int.Parse((dv_exam.Rows[0].FindControl("Label2") as Label).Text));
                if (dataTable.Rows.Count > 1)
                {
                    pl_mcqans.Visible = true;
                    pl_tfans.Visible = false;
                    //ansDdictionary[dv_exam.PageIndex] = ddl_Mcqans.SelectedValue;

                }
                else
                {
                    pl_mcqans.Visible = false;
                    pl_tfans.Visible = true;
                    //ansDdictionary[dv_exam.PageIndex] = ddl_tfans.SelectedValue;

                }
            }
            catch (Exception ex)
            {
                lbl_status.Text = "Somting went wrong";
                Admins.LogError(ex.Message.ToString(), DateTime.Now.ToLongDateString(), DateTime.Now.ToLongTimeString(), Path.GetFileName(Request.Url.AbsolutePath), "DetailsView1_PageIndexChanging1");

            }


        }

        protected void ddl_tfans_SelectedIndexChanged(object sender, EventArgs e)
        {
            ansDdictionary[dv_exam.PageIndex]= ddl_tfans.SelectedValue;
        }

        protected void dv_exam_PageIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dataTable = new DataTable();
                dataTable = Questions.GetMcqQuestionByID(int.Parse((dv_exam.Rows[0].FindControl("Label2") as Label).Text));
                if (dataTable.Rows.Count > 1)
                {
                    pl_mcqans.Visible = true;
                    pl_tfans.Visible = false;
                    //ansDdictionary[dv_exam.PageIndex] = ddl_Mcqans.SelectedValue;

                }
                else
                {
                    pl_mcqans.Visible = false;
                    pl_tfans.Visible = true;
                    //ansDdictionary[dv_exam.PageIndex] = ddl_tfans.SelectedValue;

                }
            }
            catch (Exception ex)
            {
                lbl_status.Text = "Somting went wrong";
                Admins.LogError(ex.Message.ToString(), DateTime.Now.ToLongDateString(), DateTime.Now.ToLongTimeString(), Path.GetFileName(Request.Url.AbsolutePath), "DetailsView1_PageIndexChanging1");

            }

        }
    }
}