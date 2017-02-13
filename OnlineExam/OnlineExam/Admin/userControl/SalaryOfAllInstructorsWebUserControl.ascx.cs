using OnlineExam.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class SalaryOfAllInstructorsWebUserControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                FillDDWithInstructor();
            }

        }

        private void FillDDWithInstructor()
        {
            ddl_GetSalary.Items.Clear();
            ddl_GetSalary.DataSource = SalaryOfAllInstructorsBL.GetAllInstructors();
            ddl_GetSalary.DataTextField = "Ins-Name";
            ddl_GetSalary.DataValueField = "Ins-ID";
            ddl_GetSalary.DataBind();
            ListItem m = new ListItem("none", "0");
            ddl_GetSalary.Items.Insert(0, m);

        }
        protected void ddl_GetSalary_SelectedIndexChanged(object sender, EventArgs e)
        {

            gv_Salary.DataSource = SalaryOfAllInstructorsBL.GetInstructorByID(int.Parse(ddl_GetSalary.SelectedValue));
            gv_Salary.DataBind();


            if (gv_Salary.Rows.Count == 0)
            {

                lbl_status.Text = " Salary not determind Yet";
                lbl_status.Visible = true;

            }
            else
            {

                lbl_status.Visible = false;

            }

        }
    }
}