using OnlineExam.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace WebApplication1
{
    public partial class StudentCorrectiveByDeptWebUserControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {

                FullDDLWithDepartments();
            }

        }

        private void FullDDLWithDepartments()
        {
            ddl_department.Items.Clear();
            ddl_department.DataSource = DepartmentBL.GetAllDepartment();
            ddl_department.DataTextField = "Dept_Name";
            ddl_department.DataValueField = "Dept_Id";
            ddl_department.DataBind();
            ListItem m = new ListItem("none", "0");
            ddl_department.Items.Insert(0, m);
        }
        protected void ddl_department_SelectedIndexChanged(object sender, EventArgs e)
        {
            gv_corrective.DataSource = ExamBL.GetCorrectiveByDept(int.Parse(ddl_department.SelectedValue));
            gv_corrective.DataBind();


            if (gv_corrective.Rows.Count == 0)
            {

                lbl_status.Text = " This Department Not have Corrective";
                lbl_status.Visible = true;

            }
            else
            {

                lbl_status.Visible = false;

            }

        }
    }
}