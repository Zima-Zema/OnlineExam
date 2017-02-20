using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using OnlineExam.Code;
using System.IO;

namespace OnlineExam
{
    public partial class Report3 : System.Web.UI.Page
    {
        DataTable dt = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlinstructor.DataSource = Reports.DisplayInstructorByID();
                ddlinstructor.DataValueField = "Ins-ID";
                ddlinstructor.DataTextField = "Ins-Name";
                ddlinstructor.DataBind();
                /*
                DataTable dt = Reports.Report33(int.Parse(ddlinstructor.SelectedValue));
                gvR3.DataSource = dt;
                gvR3.DataBind();*/

            }
        }



        protected void ddldept_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = Reports.report3(int.Parse(ddlinstructor.SelectedValue));
                GVR3.DataSource = dt;
                GVR3.DataBind();
            }
            catch(Exception ex)
            {
                lblresult.Text = "Error in Instructor Data";
                Admins.LogError(ex.Message.ToString(), DateTime.Now.ToLongDateString(), DateTime.Now.ToLongTimeString(), Path.GetFileName(Request.Url.AbsolutePath), "ddldept_SelectedIndexChanged");

            }


        }

        protected void GVR3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}