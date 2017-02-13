using OnlineExam.Code;
using System;
using System.Collections.Generic;
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

            gv_DisplayIns.DataSource = DisplayAllIns.GetAllIns();
            gv_DisplayIns.DataBind();
        }
    }
}