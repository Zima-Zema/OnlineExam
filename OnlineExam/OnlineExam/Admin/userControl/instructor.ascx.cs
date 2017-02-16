using OnlineExam;
using OnlineExam.Code;
using System;
using System.Data;
using System.IO;
using System.Web.UI.WebControls;


namespace WebApplication1
{
    public partial class instructor : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                FullDDL();
            }
        }

        private void FullDDL()
        {
            try
            {
                ddl_selectInst.Items.Clear();
                ddl_selectInst.DataSource = InstractorBL.GetAllIns();
                ddl_selectInst.DataTextField = "Ins-Name";
                ddl_selectInst.DataValueField = "Ins-ID";
                ddl_selectInst.DataBind();
                ListItem I = new ListItem("none", "0");
                ddl_selectInst.Items.Insert(0, I);

                ddl_Dept.Items.Clear();
                ddl_Dept.DataSource = DepartmentBL.GetAllDepartment();
                ddl_Dept.DataTextField = "Dept_Name";
                ddl_Dept.DataValueField = "Dept_Id";
                ddl_Dept.DataBind();
                ListItem D = new ListItem("none", "0");
                ddl_Dept.Items.Insert(0, D);
            }
            catch (Exception ex)
            {
                lbl_status.Text = "Somting went wrong";
                Admins.LogError(ex.Message.ToString(), DateTime.Now.ToLongDateString(), DateTime.Now.ToLongTimeString(), Path.GetFileName(Request.Url.AbsolutePath), "FullDDL");

            }
            

        }

        protected void ddl_selectInst_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txt_instId.Enabled = false;
                DataTable dataTable = new DataTable();
                dataTable = InstractorBL.GetInstructorByID(int.Parse(ddl_selectInst.SelectedValue));
                txt_instId.Text = dataTable.Rows[0]["Ins-ID"].ToString();
                txt_InsName.Text = dataTable.Rows[0]["Ins-Name"].ToString();
                txt_InsDegree.Text = dataTable.Rows[0]["Ins_Degree"].ToString();
                txt_InsSalary.Text = dataTable.Rows[0]["Salary"].ToString();
                txt_userName.Text = dataTable.Rows[0]["username"].ToString();
                txt_password.Text = dataTable.Rows[0]["password"].ToString();
                ddl_Dept.SelectedValue = dataTable.Rows[0]["Depart-ID"].ToString();
                cb_active.Checked = (bool)dataTable.Rows[0]["active"];
            }
            catch (Exception ex)
            {
                lbl_status.Text = "Somting went wrong";
                Admins.LogError(ex.Message.ToString(), DateTime.Now.ToLongDateString(), DateTime.Now.ToLongTimeString(), Path.GetFileName(Request.Url.AbsolutePath), "ddl_selectInst_SelectedIndexChanged");

            }
            

        }

        protected void btn_NewINs_Click(object sender, EventArgs e)
        {
            txt_instId.Text = txt_InsName.Text = txt_InsDegree.Text = txt_InsSalary.Text = txt_userName.Text = txt_password.Text = String.Empty;
        }

        protected void btn_InsertIns_Click(object sender, EventArgs e)
        {
            try
            {
                int rows = InstractorBL.CreateInstructor(txt_InsName.Text, int.Parse(ddl_Dept.SelectedValue), txt_InsDegree.Text, txt_InsSalary.Text, txt_userName.Text, txt_password.Text, cb_active.Checked.ToString());
                if (rows > 0)
                {
                    lbl_status.Text = "Successfully Added :)";
                    FullDDL();
                    btn_NewINs_Click(sender, e);
                    txt_instId.Enabled = false;
                }
                else
                {
                    lbl_status.Text = "Somthing Went Wrong :(";
                }
            }
            catch (Exception ex)
            {
                lbl_status.Text = "Somting went wrong";
                Admins.LogError(ex.Message.ToString(), DateTime.Now.ToLongDateString(), DateTime.Now.ToLongTimeString(), Path.GetFileName(Request.Url.AbsolutePath), "btn_InsertIns_Click");

            }


        }

        protected void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                int rows = InstractorBL.EditInstructor(int.Parse(txt_instId.Text), txt_InsName.Text, int.Parse(ddl_Dept.SelectedValue), txt_InsDegree.Text, txt_InsDegree.Text, txt_userName.Text, txt_password.Text, cb_active.Checked.ToString());
                if (rows > 0)
                {
                    lbl_status.Text = "Successfully Updated";
                }
                FullDDL();
                btn_NewINs_Click(sender, e);
                txt_instId.Enabled = false;
            }
            catch (Exception ex)
            {
                lbl_status.Text = "Somting went wrong";
                Admins.LogError(ex.Message.ToString(), DateTime.Now.ToLongDateString(), DateTime.Now.ToLongTimeString(), Path.GetFileName(Request.Url.AbsolutePath), "btn_Update_Click");

            }


        }

        protected void btn_Delete_Click(object sender, EventArgs e)
        {

            try
            {
                int rows = InstractorBL.RemoveInstructor(int.Parse(ddl_selectInst.SelectedValue));
                if (rows > 0)
                {
                    lbl_status.Text = "Successfully Deleted";
                }
                FullDDL();
                btn_NewINs_Click(sender, e);
                txt_instId.Enabled = false;
            }
            catch (Exception ex)
            {
                lbl_status.Text = "Somting went wrong";
                Admins.LogError(ex.Message.ToString(), DateTime.Now.ToLongDateString(), DateTime.Now.ToLongTimeString(), Path.GetFileName(Request.Url.AbsolutePath), "btn_Delete_Click");

            }

        }
    }
}