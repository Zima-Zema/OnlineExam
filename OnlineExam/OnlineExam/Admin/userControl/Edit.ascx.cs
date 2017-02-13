using OnlineExam.Code;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineExam.Admin.userControl
{
    public partial class Edit : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
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
            pl_true.Visible = false;
            pl_mcq.Visible = false;
        }
        private void FillQDDL()
        {
            ddl_qByCourse.Items.Clear();
            ddl_qByCourse.DataSource = Questions.GetQuestionByCrsID(int.Parse(ddl_course.SelectedValue));
            ddl_qByCourse.DataTextField = "Question-Head";
            ddl_qByCourse.DataValueField = "Question-ID";
            ddl_qByCourse.DataBind();
            ListItem c = new ListItem("none", "0");
            ddl_course.Items.Insert(0, c);
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
        private void FillType()
        {
            ddl_mcqType.Items.Clear();
            ListItem none = new ListItem("none", "NULL");
            ListItem mcq = new ListItem("MCQ", "MCQ");
            ListItem tf = new ListItem("TF", "TF");
            ddl_mcqType.Items.Insert(0, none);
            ddl_mcqType.Items.Insert(1, mcq);
            ddl_mcqType.Items.Insert(2, tf);

            ddl_tfType.Items.Insert(0, none);
            ddl_tfType.Items.Insert(1, mcq);
            ddl_tfType.Items.Insert(2, tf);

            ddl_tfType.DataBind();
        }

        protected void ddl_course_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            ddl_qByCourse.Enabled = true;
            FillQDDL();
        }



        protected void ddl_qByCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillType();

            DataTable dataTable = new DataTable();
            dataTable = Questions.GetMcqQuestionByID(int.Parse(ddl_qByCourse.SelectedValue));
            if (dataTable.Rows.Count>1)
            {
                pl_mcq.Visible = true;
                txt_mcqHead.Text = dataTable.Rows[0]["Question-Head"].ToString();
                ddl_mcqType.SelectedIndex = 1;
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
                dataTable = Questions.GetQuestionByID(int.Parse(ddl_qByCourse.SelectedValue));
                txt_tfHead.Text = dataTable.Rows[0]["Question-Head"].ToString();
                ddl_tfType.SelectedIndex = 2;
                txt_tfGrade.Text = dataTable.Rows[0]["Quesion-Grade"].ToString();
                ddl_tfModel.SelectedValue= dataTable.Rows[0]["QModelAnswer"].ToString();

            }
        }

        protected void btn_update_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            dataTable = Questions.GetMcqQuestionByID(int.Parse(ddl_qByCourse.SelectedValue));
            if (dataTable.Rows.Count > 1)
            {
                int rows = Questions.Edit_MCQ(int.Parse(ddl_qByCourse.SelectedValue),ddl_mcqType.SelectedValue, int.Parse(txt_mcqGrade.Text), ddl_mcqModel.SelectedValue, txt_mcqHead.Text, int.Parse(ddl_course.SelectedValue), "A", txt_ansA.Text, "B", txt_ansB.Text, "C", txt_ansC.Text, "D", txt_ansD.Text);
                if (rows > 0)
                {
                    lbl_status.Text = "Successfully Updated";
                    txt_mcqGrade.Text = txt_mcqHead.Text = txt_ansA.Text = txt_ansB.Text = txt_ansC.Text = txt_ansD.Text = string.Empty;
                    FillQDDL();

                }
                else
                {
                    lbl_status.Text = "Update Failed";
                }
            }
            else
            {
                int rows = Questions.Edit_Question(int.Parse(ddl_qByCourse.SelectedValue), ddl_tfType.SelectedValue, int.Parse(txt_tfGrade.Text), ddl_tfModel.SelectedValue, txt_tfHead.Text, int.Parse(ddl_course.SelectedValue));
                if (rows > 0)
                {
                    lbl_status.Text = "Successfully Updated";
                    txt_mcqGrade.Text = txt_mcqHead.Text = txt_ansA.Text = txt_ansB.Text = txt_ansC.Text = txt_ansD.Text = string.Empty;
                    FillQDDL();

                }
                else
                {
                    lbl_status.Text = "Update Failed";
                }
            }
        }

        protected void btn_delete_Click(object sender, EventArgs e)
        {
            int rows = Questions.Remove_Question(int.Parse(ddl_qByCourse.SelectedValue));
            if (rows > 0)
            {
                lbl_status.Text = "Successfully Deleted";
                txt_mcqGrade.Text = txt_mcqHead.Text = txt_ansA.Text = txt_ansB.Text = txt_ansC.Text = txt_ansD.Text = string.Empty;
                ddl_course.SelectedIndex = 0;
                ddl_qByCourse.SelectedIndex = 0;
                ddl_qByCourse.Enabled = false;
                pl_mcq.Visible = false;
                pl_true.Visible = false;

            }
            else
            {
                lbl_status.Text = "Delete Failed";
            }

        }

        protected void btn_cancel_Click(object sender, EventArgs e)
        {
            ddl_course.SelectedIndex = 0;
            ddl_qByCourse.SelectedIndex = 0;
            txt_mcqGrade.Text = txt_mcqHead.Text = txt_ansA.Text = txt_ansB.Text = txt_ansC.Text = txt_ansD.Text = string.Empty;
            txt_tfHead.Text = txt_tfGrade.Text = string.Empty;
            pl_mcq.Visible = false;
            pl_true.Visible = false;
        }
    }
}