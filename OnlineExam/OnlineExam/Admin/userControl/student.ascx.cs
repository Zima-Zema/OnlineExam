using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using OnlineExam.Code;
using System.IO;

namespace WebApplication1 
{
    public partial class student : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                FillddlistwithSudent();
            }
        }
       private void FillddlistwithSudent()
        {
            ddl_student.Items.Clear();
            
            ddl_student.DataSource = StudentsBL.GetStusent();
            ddl_student.DataTextField = "St-Fname";
            ddl_student.DataValueField = "St-ID";
            ddl_student.DataBind();
            ListItem m = new ListItem("none", "0");
            ddl_student.Items.Insert(0, m);

            ddl_dept.Items.Clear();
            ddl_dept.DataSource = DepartmentBL.GetAllDepartment();
            ddl_dept.DataTextField = "Dept_Name";
            ddl_dept.DataValueField = "Dept_Id";
            ddl_dept.DataBind();
            ListItem D = new ListItem("none", "0");
            ddl_dept.Items.Insert(0, D);

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            dataTable = StudentsBL.GetStudentByID(int.Parse(ddl_student.SelectedValue));
            txt_fname.Text = dataTable.Rows[0]["St-Fname"].ToString();
            txt_lname.Text = dataTable.Rows[0]["St-Lname"].ToString();
            txt_stdID.Text = dataTable.Rows[0]["St-ID"].ToString();
            txt_username.Text = dataTable.Rows[0]["username"].ToString();
            txt_password.Text = dataTable.Rows[0]["password"].ToString();
            ddl_dept.SelectedValue = dataTable.Rows[0]["Dept_Id"].ToString();
            cb_active.Checked = (bool)dataTable.Rows[0]["active"];
            lbl.Text = string.Empty;
        }
       protected void Create_Click(object sender, EventArgs e)
       {
            txt_fname.Text = txt_lname.Text = txt_stdID.Text = txt_username.Text = txt_password.Text = string.Empty;
            ddl_dept.SelectedIndex = 0;
            ddl_student.SelectedIndex = 0;
            lbl.Text = string.Empty;
            txt_stdID.Enabled = false;
       }

       protected void Insert_Click(object sender, EventArgs e)
       {
            if (String.IsNullOrWhiteSpace(txt_stdID.Text))
            {
                if (!String.IsNullOrWhiteSpace(txt_fname.Text)&&ddl_dept.SelectedIndex!=0)
                {
                    int rows = StudentsBL.insert_Student(txt_fname.Text, txt_lname.Text, int.Parse(ddl_dept.SelectedValue), txt_username.Text, txt_password.Text, cb_active.Checked.ToString());
                    if (rows > 0)
                    {
                        lbl.Text = "Successfully Added :)";
                        FillddlistwithSudent();
                        Create_Click(sender, e);
                    }
                    else
                    {
                        lbl.Text = "Somthing Went Wrong :(";
                    }
                }
                else
                {
                    lbl.Text = "You must Enter first name Or Invalid Department name";

                }
            }
            else
            {
                lbl.Text = "This Student is Already Add :(";
            }

            
            
       

       }

       protected void Delete_Click(object sender, EventArgs e)
       {
            try
            {
                if (ddl_student.SelectedIndex != 0)
                {
                    int rows = StudentsBL.Remove_Student(int.Parse(ddl_student.SelectedValue));
                    if (rows > 0)
                    {
                        lbl.Text = "Successfully Deleted :)";
                        FillddlistwithSudent();
                        Create_Click(sender, e);
                    }
                    else
                    {
                        lbl.Text = "Somthing Went Wrong :(";
                    }
                }
                else
                {
                    lbl.Text = "You must choose Student to Delete";

                }

            }
            catch (Exception ex)
            {
                lbl.Text = "Somthing Went Wrong :(";
                Admins.LogError(ex.Message.ToString(), DateTime.Now.ToLongDateString(), DateTime.Now.ToLongTimeString(), Path.GetFileName(Request.Url.AbsolutePath), "Delete_Click");

            }
            
        }

       protected void Update_Click(object sender, EventArgs e)
       {
            try
            {
                int rows = StudentsBL.Edit_Student(int.Parse(ddl_student.SelectedValue), txt_fname.Text, txt_lname.Text, int.Parse(ddl_dept.SelectedValue), txt_username.Text, txt_password.Text, cb_active.Checked.ToString());
                if (rows > 0)
                {
                    lbl.Text = "Successfully Updated :)";
                    FillddlistwithSudent();
                    Create_Click(sender, e);
                }
                else
                {
                    lbl.Text = "Somthing Went Wrong :(";
                }

            }
            catch (Exception ex)
            {

                lbl.Text = "Somthing Went Wrong :(";
                Admins.LogError(ex.Message.ToString(), DateTime.Now.ToLongDateString(), DateTime.Now.ToLongTimeString(), Path.GetFileName(Request.Url.AbsolutePath), "Delete_Click");

            }


        }

    }
}