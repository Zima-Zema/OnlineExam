using OnlineExam.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineExam.Admin.userControl
{
    public partial class AddQuestion : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                FillDDL();
            }
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


            ddl_Qtype.Items.Clear();
            ListItem none = new ListItem("none", "NULL");
            ListItem mcq = new ListItem("MCQ", "MCQ");
            ListItem tf = new ListItem("TF", "TF");
            ddl_Qtype.Items.Insert(0, none);
            ddl_Qtype.Items.Insert(1, mcq);
            ddl_Qtype.Items.Insert(2, tf);
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
            if (ddl_Qtype.SelectedValue== "MCQ")
            {
                pl_mcq.Visible = true;
                FillMcqModel();

            }
            else if(ddl_Qtype.SelectedValue == "TF")
            {
                pl_true.Visible = true;
                FillTfModel();
                
            }
            else
            {
                pl_mcq.Visible = false;
                pl_true.Visible = false;
            }
        }

        protected void btn_insert_Click(object sender, EventArgs e)
        {
            if (Page.IsValid) {
                if (ddl_Qtype.SelectedValue == "MCQ")
                {
                    int rows = Questions.Create_MCQ(ddl_Qtype.SelectedValue, int.Parse(txt_mcqGrade.Text), ddl_mcqModel.SelectedValue, txt_mcqHead.Text, int.Parse(ddl_course.SelectedValue), "A", txt_ansA.Text, "B", txt_ansB.Text, "C", txt_ansC.Text, "D", txt_ansD.Text);
                    if (rows > 0)
                    {
                        lbl_status.Text = "Successfully Added";
                        txt_mcqGrade.Text = txt_mcqHead.Text = txt_ansA.Text = txt_ansB.Text = txt_ansC.Text = txt_ansD.Text = string.Empty;
                        
                    }

                }
                else if (ddl_Qtype.SelectedValue == "TF")
                {
                    int rows = Questions.Create_Question(ddl_Qtype.SelectedValue, int.Parse(txt_tfGrade.Text), ddl_tfModel.SelectedValue, txt_tfHead.Text, int.Parse(ddl_course.SelectedValue));
                    if (rows > 0)
                    {
                        lbl_status.Text = "Successfully Added";
                        txt_tfHead.Text = txt_tfGrade.Text = string.Empty;
                    }
                }
                else
                {
                    lbl_status.Text = "Please Select Question Type";
                    pl_mcq.Visible = false;
                    pl_true.Visible = false;
                }
            }
        }

        protected void btn_cancel_Click(object sender, EventArgs e)
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