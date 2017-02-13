using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineExam
{
    public partial class Students_have_corrective_exam_by_dept : System.Web.UI.Page
    {
        DataTable dt = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlDept.DataSource = BusinessLayer.Display_Department_by_Idand_Name();
                ddlDept.DataValueField = "Dept_Id";
                ddlDept.DataTextField = "Dept_Id";
                ddlDept.DataBind();


            }

        }

        protected void ddlDept_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {


                DataTable dt = Display.DisplayCorrectiveStudentsByDepartment(int.Parse(ddlDept.SelectedValue));
                gvCorrrectiveByDept.DataSource = dt;
                gvCorrrectiveByDept.DataBind();
            }
            catch
            {
                lblresult.Text = "Error In Department No";
            }

        }
    }
}