using System;
using System.Web;
using System.Web.UI;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Owin;
using OnlineExam.Models;

namespace OnlineExam.Account
{
    public partial class Login : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                Session["username"] = null;
                Session["type"] = null;
            }
            RegisterHyperLink.NavigateUrl = "Register";
            // Enable this once you have account confirmation enabled for password reset functionality
            //ForgotPasswordHyperLink.NavigateUrl = "Forgot";
            
            var returnUrl = HttpUtility.UrlEncode(Request.QueryString["ReturnUrl"]);
            if (!String.IsNullOrEmpty(returnUrl))
            {
                RegisterHyperLink.NavigateUrl += "?ReturnUrl=" + returnUrl;
            }
        }

        protected void LogIn(object sender, EventArgs e)
        {
            if (IsValid)
            {
                if (txt_username.Text != "" && txt_password.Text != "")
                {
                    string login = LoginBL.CheckLogin(txt_username.Text, txt_password.Text);

                    switch (login)
                    {
                        case "Instructor":
                            Session["username"] = txt_username.Text;
                            Session["type"] = "Instructor";
                            Response.Redirect("http://localhost:23156/InstructorForm.aspx");
                            break;
                        case "Student":
                            Session["username"] = txt_username.Text;
                            Session["type"] = "Student";
                            Response.Redirect("http://localhost:23156/StudentForm.aspx");
                            break;
                        case "Admin":
                            Session["username"] = txt_username.Text;
                            Session["type"] = "Admin";
                            Response.Redirect("~/Admin/Index.aspx");
                            break;
                        case "Not member":
                            lbl_status.Text = "Login Failed, Try Again";
                            Session["username"] = null;
                            Session["type"] = null;
                            break;
                        default:
                            lbl_status.Text = "Login Failed, Try Again";
                            break;
                    }
                }
                else
                {
                    lbl_status.Text = "Please Fill All DATA";
                }
            }
        }
    }
}