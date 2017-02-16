using System;
using System.Web.UI.WebControls;
using System.Data;
using OnlineExam.Code;
using OnlineExam;
using System.IO;

namespace WebApplication1
{
    public partial class WebUserControl1 : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                FullDD();
            }
        }

        private void FullDD()
        {
            try
            {
                txt_Deptid.Enabled = false;
                ddl_selectDept.Items.Clear();
                ddl_selectDept.DataSource = DepartmentBL.GetAllDepartment();
                ddl_selectDept.DataTextField = "Dept_Name";
                ddl_selectDept.DataValueField = "Dept_Id";
                ddl_selectDept.DataBind();
                ListItem i = new ListItem("none", "0");
                ddl_selectDept.Items.Insert(0, i);

                ddl_manager.Items.Clear();
                ddl_manager.DataSource = InstractorBL.GetAllIns();
                ddl_manager.DataTextField = "Ins-Name";
                ddl_manager.DataValueField = "Ins-ID";
                ddl_manager.DataBind();
                ListItem m = new ListItem("none", "0");
                ddl_manager.Items.Insert(0, m);
            }
            catch (Exception ex)
            {
                lbl_status.Text = "Somting went wrong";
                Admins.LogError(ex.Message.ToString(), DateTime.Now.ToLongDateString(), DateTime.Now.ToLongTimeString(), Path.GetFileName(Request.Url.AbsolutePath), "btn_insert_Click");

            }
            
        }


        protected void btn_insert_Click(object sender, EventArgs e)
        {
            try
            {
                int rows = DepartmentBL.CreateDepartment(txt_Deptname.Text, txt_DeptDecs.Text, txt_Deptloc.Text, int.Parse(ddl_manager.SelectedValue.ToString()), cl_hireDate.SelectedDate);
                if (rows > 0)
                {
                    lbl_status.Text = "Successfully Added";
                }
                FullDD();
                btn_NewDept_Click(sender, e);
                txt_Deptid.Enabled = false;
            }
            catch (Exception ex)
            {
                lbl_status.Text = "Somting went wrong";
                Admins.LogError(ex.Message.ToString(), DateTime.Now.ToLongDateString(), DateTime.Now.ToLongTimeString(), Path.GetFileName(Request.Url.AbsolutePath), "btn_insert_Click");

            }

        }

        protected void ddl_selectDept_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txt_Deptid.Enabled = false;
                DataTable dataTable = new DataTable();

                dataTable = DepartmentBL.GetDepartmentById(int.Parse(ddl_selectDept.SelectedValue));
                txt_Deptid.Text = dataTable.Rows[0]["Dept_Id"].ToString();
                txt_Deptname.Text = dataTable.Rows[0]["Dept_Name"].ToString();
                txt_DeptDecs.Text = dataTable.Rows[0]["Dept_Desc"].ToString();
                txt_Deptloc.Text = dataTable.Rows[0]["Dept_Location"].ToString();
                ddl_manager.SelectedValue = dataTable.Rows[0]["Dept_Manager"].ToString();
                cl_hireDate.SelectedDate = (DateTime)dataTable.Rows[0]["Manager_hiredate"];
                txt_hireDate.Text = dataTable.Rows[0]["Manager_hiredate"].ToString();
            }
            catch (Exception ex)
            {
                lbl_status.Text = "Somting went wrong";
                Admins.LogError(ex.Message.ToString(), DateTime.Now.ToLongDateString(), DateTime.Now.ToLongTimeString(), Path.GetFileName(Request.Url.AbsolutePath), "ddl_selectDept_SelectedIndexChanged");

            }
            
           
        }

        protected void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                int rows = DepartmentBL.EditDepartment(int.Parse(txt_Deptid.Text), txt_Deptname.Text, txt_DeptDecs.Text, txt_Deptloc.Text, int.Parse(ddl_manager.SelectedValue), cl_hireDate.SelectedDate);
                if (rows > 0)
                {
                    lbl_status.Text = "Successfully Updated";
                }
                FullDD();
                btn_NewDept_Click(sender, e);
                txt_Deptid.Enabled = false;
            }
            catch (Exception ex)
            {
                lbl_status.Text = "Somting went wrong";
                Admins.LogError(ex.Message.ToString(), DateTime.Now.ToLongDateString(), DateTime.Now.ToLongTimeString(), Path.GetFileName(Request.Url.AbsolutePath), "ddl_Dept_SelectedIndexChanged");

            }

        }

        protected void btn_NewDept_Click(object sender, EventArgs e)
        {
            txt_Deptid.Text = txt_Deptname.Text = txt_DeptDecs.Text = txt_Deptloc.Text = txt_hireDate.Text = string.Empty;
            ddl_manager.SelectedIndex = 0;
            ddl_selectDept.SelectedIndex = 0;
            txt_Deptid.Enabled= false;
        }

        protected void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                int rows = DepartmentBL.RemoveDepartment(int.Parse(txt_Deptid.Text));
                if (rows > 0)
                {
                    lbl_status.Text = "Successfully Deleted";
                }

                FullDD();
                btn_NewDept_Click(sender, e);
                txt_Deptid.Enabled = false;
            }
            catch (Exception ex)
            {
                lbl_status.Text = "Somting went wrong";
                Admins.LogError(ex.Message.ToString(), DateTime.Now.ToLongDateString(), DateTime.Now.ToLongTimeString(), Path.GetFileName(Request.Url.AbsolutePath), "ddl_Dept_SelectedIndexChanged");

            }

        }
    }
}