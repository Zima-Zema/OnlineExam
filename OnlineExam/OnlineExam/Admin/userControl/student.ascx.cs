using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using OnlineExam.Code;
using System.IO;
using OnlineExam;

namespace WebApplication1 
{
    public partial class student : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                FillddlistwithSudent();
                DataTable dataTable = StdCrsIns.LastChanceForStudent();
                gv_lastchance.DataSource = dataTable;
                gv_lastchance.DataBind();
            }
        }
       private void FillddlistwithSudent()
        {
            try
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

                ddl_allstd.Items.Clear();
                ddl_allstd.DataSource = StudentsBL.GetStusent();
                ddl_allstd.DataTextField = "St-Fname";
                ddl_allstd.DataValueField = "St-ID";
                ddl_allstd.DataBind();
                ListItem D1 = new ListItem("none", "0");
                ddl_allstd.Items.Insert(0, D1);

                ddl_course.Items.Clear();
                ddl_course.DataSource = CourseBL.GetAllCourses();
                ddl_course.DataTextField = "Crs-Name";
                ddl_course.DataValueField = "Crs-ID";
                ddl_course.DataBind();
                ListItem D2 = new ListItem("none", "0");
                ddl_course.Items.Insert(0, D2);


            }
            catch (Exception ex)
            {
                Admins.LogError(ex.Message.ToString(), DateTime.Now.ToLongDateString(), DateTime.Now.ToLongTimeString(), Path.GetFileName(Request.Url.AbsolutePath), "FillddlistwithSudent");
                lbl.Text = "Something Went Wrong";
            }
            

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                Admins.LogError(ex.Message.ToString(), DateTime.Now.ToLongDateString(), DateTime.Now.ToLongTimeString(), Path.GetFileName(Request.Url.AbsolutePath), "DropDownList1_SelectedIndexChanged");
                lbl.Text = "Something Went Wrong";
            }
            
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
            if (Page.IsValid)
            {


                if (String.IsNullOrWhiteSpace(txt_stdID.Text))
                {
                    if (!String.IsNullOrWhiteSpace(txt_fname.Text) && ddl_dept.SelectedIndex != 0)
                    {
                        try
                        {
                            int rows = StudentsBL.insert_Student(txt_fname.Text, txt_lname.Text, int.Parse(ddl_dept.SelectedValue), txt_username.Text, txt_password.Text);
                            if (rows > 0)
                            {
                                lbl_status.Text = "Successfully Added :)";
                                FillddlistwithSudent();
                                Create_Click(sender, e);
                            }
                            else
                            {
                                lbl_status.Text = "Somthing Went Wrong :(";
                            }
                        }
                        catch (Exception ex)
                        {
                            Admins.LogError(ex.Message.ToString(), DateTime.Now.ToLongDateString(), DateTime.Now.ToLongTimeString(), Path.GetFileName(Request.Url.AbsolutePath), "Insert_Click");
                            lbl_status.Text = "Something Went Wrong";
                        }

                    }
                    else
                    {
                        lbl_status.Text = "You must Enter first name Or Invalid Department name";

                    }
                }
                else
                {
                    lbl_status.Text = "This Student is Already Add :(";
                }

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
                        lbl_status.Text = "Somthing Went Wrong :(";
                    }
                }
                else
                {
                    lbl_status.Text = "You must choose Student to Delete";

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
            if (Page.IsValid)
            {


                try
                {
                    if (ddl_dept.SelectedIndex!=0)
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
                    else
                    {
                        lbl.Text = "You Have To Assign Department ";
                    }
                    

                }
                catch (Exception ex)
                {

                    lbl.Text = "Somthing Went Wrong :(";
                    Admins.LogError(ex.Message.ToString(), DateTime.Now.ToLongDateString(), DateTime.Now.ToLongTimeString(), Path.GetFileName(Request.Url.AbsolutePath), "Update_Click");

                }

            }
        }

        protected void btn_assigntocourse_Click(object sender, EventArgs e)
        {
            if (ddl_allstd.SelectedIndex != 0 && ddl_course.SelectedIndex != 0)
            {
                int rows = StdCrsIns.CreateStdCourse(int.Parse(ddl_allstd.SelectedValue), int.Parse(ddl_course.SelectedValue));
                if (rows > 0)
                {
                    lbl_status.Text = "Assigned";
                }
                else
                {
                    lbl_status.Text = "اتغفلت";
                }
            }
            gv_lastchance.DataSource = StdCrsIns.LastChanceForStudent();
            gv_lastchance.DataBind();
        }

        protected void gv_lastchance_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gv_lastchance.EditIndex = -1;
            DataTable dataTable = StdCrsIns.LastChanceForStudent();
            gv_lastchance.DataSource = dataTable;
            gv_lastchance.DataBind();
        }

        protected void gv_lastchance_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            DataTable dataTable = StdCrsIns.LastChanceForStudent();

            //Remov_Stud_Course
            int sid = int.Parse(dataTable.Rows[e.RowIndex]["St-ID"].ToString());
            int crsid = int.Parse(dataTable.Rows[e.RowIndex]["Crs-ID"].ToString());
            int rows = StdCrsIns.Remov_Stud_Course(sid, crsid);
            if (rows > 0)
            {
                dataTable = StdCrsIns.LastChanceForStudent();
                gv_lastchance.DataSource = dataTable;
                gv_lastchance.DataBind();
            }
        }

        protected void gv_lastchance_RowEditing(object sender, GridViewEditEventArgs e)
        {
            DataTable dataTable = StdCrsIns.LastChanceForStudent();
            gv_lastchance.EditIndex = e.NewEditIndex;
            gv_lastchance.DataSource = dataTable;
            gv_lastchance.DataBind();
            DropDownList ddl_ins = (gv_lastchance.Rows[e.NewEditIndex].FindControl("ddl_lastchanceI") as DropDownList);
            ddl_ins.DataSource = StudentsBL.GetStusent();
            ddl_ins.DataTextField = "St-Fname";
            ddl_ins.DataValueField = "St-ID";
            ddl_ins.DataBind();
            ddl_ins.SelectedValue = dataTable.Rows[e.NewEditIndex]["St-ID"].ToString();


            DropDownList ddl_course = (gv_lastchance.Rows[e.NewEditIndex].FindControl("dd_lastchaneC") as DropDownList);
            ddl_course.DataSource = CourseBL.GetAllCourses();
            ddl_course.DataTextField = "Crs-Name";
            ddl_course.DataValueField = "Crs-ID";
            ddl_course.DataBind();
            ddl_course.SelectedValue = dataTable.Rows[e.NewEditIndex]["Crs-ID"].ToString();
        }

        protected void gv_lastchance_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int sid = int.Parse((gv_lastchance.Rows[e.RowIndex].FindControl("ddl_lastchanceI") as DropDownList).SelectedValue);
            int crsid = int.Parse((gv_lastchance.Rows[e.RowIndex].FindControl("dd_lastchaneC") as DropDownList).SelectedValue);

            int rows = StdCrsIns.EditStdCourseByStudent(sid, crsid);
            if (rows > 0)
            {
                gv_lastchance.EditIndex = -1;
                DataTable dataTable = StdCrsIns.LastChanceForStudent();
                gv_lastchance.DataSource = dataTable;
                gv_lastchance.DataBind();
            }
        }

     
    }
}