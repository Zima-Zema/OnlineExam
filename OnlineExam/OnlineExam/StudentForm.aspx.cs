using OnlineExam.Code;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineExam
{
    public partial class StudentForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if ((string)Session["type"] != "Student" || Session["type"] == null)
                {
                    Session["username"] = null;
                    Session["type"] = null;
                    Response.Redirect("~/Account/Login.aspx");
                }
                else
                {

                    DataTable dt = new DataTable();
                    dt = Student.GetStudentByuserName(Session["username"].ToString());
                    Session["id"] = dt.Rows[0]["id"].ToString();

                }
            }
        }
    }
}