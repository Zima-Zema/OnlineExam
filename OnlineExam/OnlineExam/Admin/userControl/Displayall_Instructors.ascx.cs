using OnlineExam.Code;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.Admin.Admin_UC
{
    public partial class Displayall_Instructors : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            fullGridViewWithInstructor();
        }

        private void fullGridViewWithInstructor()
        {
            try
            {
                gv_DisplayIns.DataSource = DisplayAllIns.GetAllIns();
                gv_DisplayIns.DataBind();
            }
            catch (Exception ex)
            {
                lbl_status.Text = "Somting went wrong";
                Admins.LogError(ex.Message.ToString(), DateTime.Now.ToLongDateString(), DateTime.Now.ToLongTimeString(), Path.GetFileName(Request.Url.AbsolutePath), "fullGridViewWithInstructor");

            }
            
        }
    }
}