using OnlineExam.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class DepartmentManagerWebUserControl : System.Web.UI.UserControl
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
            ddl_Dept.Items.Clear();
            ddl_Dept.DataSource = DeptManger.GetAllDept();
            ddl_Dept.DataTextField = "Dept_Name";
            ddl_Dept.DataValueField = "Dept_Id";
            ddl_Dept.DataBind();
            ListItem m = new ListItem("none", "0");
            ddl_Dept.Items.Insert(0, m);
        }
        protected void ddl_Dept_SelectedIndexChanged(object sender, EventArgs e)
        {
            gv_DeptManger.DataSource = DeptManger.GetDeptMangerById(int.Parse(ddl_Dept.SelectedValue));
            gv_DeptManger.DataBind();


            if (gv_DeptManger.Rows.Count == 0)
            {

                lbl_status.Text = " This Department Not have Manager Yet";
                lbl_status.Visible = true;

            }
            else
            {

                lbl_status.Visible = false;

            }

        

        }
    }
}