using OnlineExam.Code;
using System;
using System.Data;
using System.IO;

namespace OnlineExam
{
    public partial class StudentForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
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
                        Session["id"] = dt.Rows[0]["St-ID"].ToString();

                    }
                }
                catch (Exception ex)
                {

                    Admins.LogError(ex.Message.ToString(), DateTime.Now.ToLongDateString(), DateTime.Now.ToLongTimeString(), Path.GetFileName(Request.Url.AbsolutePath), "Page_Load");

                }
                
            }
        }
    }
}