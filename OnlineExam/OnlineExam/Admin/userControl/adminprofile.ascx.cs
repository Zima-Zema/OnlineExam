using OnlineExam.Code;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.Admin.Admin_UC
{
    public partial class adminprofile : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if(!IsPostBack)
            {
                pl_change.Visible = false;
                pl_show.Visible = true;
                displayAdminDate();
            }
        }

        private void displayAdminDate()
        {
            try
            {
                DataTable dataTable = new DataTable();
                dataTable = Admins.GetAdminByUsername(Session["username"].ToString());
                lbl_username.Text = dataTable.Rows[0]["username"].ToString();
                lbl_fname.Text = dataTable.Rows[0]["fname"].ToString();
                lbl_lname.Text = dataTable.Rows[0]["lname"].ToString();
                lbl_salary.Text = dataTable.Rows[0]["salary"].ToString();
                lbl_enterdate.Text = dataTable.Rows[0]["enter_date"].ToString();
            }
            catch (Exception ex)
            {
                lbl_status.Text = "Somting went wrong";
                Admins.LogError(ex.Message.ToString(), DateTime.Now.ToLongDateString(), DateTime.Now.ToLongTimeString(), Path.GetFileName(Request.Url.AbsolutePath), "displayAdminDate");

            }


        }

        protected void btn_chPass_Click(object sender, EventArgs e)
        {
            pl_show.Visible = false;
            pl_change.Visible = true;
        }
    }
}