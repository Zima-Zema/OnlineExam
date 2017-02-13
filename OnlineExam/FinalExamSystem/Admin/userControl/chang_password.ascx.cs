using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using OnlineExam.Code;

namespace WebApplication1.Admin.Admin_UC
{
    public partial class chang_password : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }


        protected void btn_changPass_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                DataTable dataTable = new DataTable();
                //dt = AdminBL.checkPassword(Session["username"].ToString(), TextBox1.Text);
                dataTable = Admins.GetAdmin(Session["username"].ToString(), txt_currentPass.Text);
                if (dataTable.Rows.Count > 0)
                {
                    if (txt_newPass.Text == txt_confirmPass.Text && txt_newPass.Text != "" && txt_confirmPass.Text != "")
                    {

                        Admins.ChangPass(int.Parse(Session["id"].ToString()), txt_newPass.Text);
                        lbl_status.Text = "Password Changed sucessfully";
                    }
                    else
                    {
                        lbl_status.Text = "Confirm Password Doesn't Match";
                    }
                }
                else
                {
                    lbl_status.Text = "Old Password Incorrect";
                }
            }
        }     
    }
}