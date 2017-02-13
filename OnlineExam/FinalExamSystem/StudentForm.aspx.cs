using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class StudentForm : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if ((string)Session["type"] != "Student" || Session["type"] == null)
        {
            Session["username"] = null;
            Session["type"] = null;
            Response.Redirect("http://localhost:23156/Account/Login.aspx");
        }
        else
        {

            DataTable dt = new DataTable();
            dt = BusinessLayer.GetStudentByuserName(Session["username"].ToString());
            Session["id"] = dt.Rows[0]["St-ID"].ToString();

        }
    }
}