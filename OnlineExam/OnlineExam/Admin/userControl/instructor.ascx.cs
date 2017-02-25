using OnlineExam;
using OnlineExam.Code;
using System;
using System.Data;
using System.IO;
using System.Web.UI.WebControls;


namespace WebApplication1
{
    public partial class instructor : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                FullDDL();
                gv_lastchance.DataSource = StdCrsIns.LastChance();
                gv_lastchance.DataBind();
            }
        }

        private void FullDDL()
        {
            try
            {
                ddl_selectInst.Items.Clear();
                ddl_selectInst.DataSource = InstractorBL.GetAllIns();
                ddl_selectInst.DataTextField = "Ins-Name";
                ddl_selectInst.DataValueField = "Ins-ID";
                ddl_selectInst.DataBind();
                ListItem I = new ListItem("none", "0");
                ddl_selectInst.Items.Insert(0, I);

                ddl_Dept.Items.Clear();
                ddl_Dept.DataSource = DepartmentBL.GetAllDepartment();
                ddl_Dept.DataTextField = "Dept_Name";
                ddl_Dept.DataValueField = "Dept_Id";
                ddl_Dept.DataBind();
                ListItem D = new ListItem("none", "0");
                ddl_Dept.Items.Insert(0, D);


                ddl_course.Items.Clear();
                ddl_course.DataSource = CourseBL.GetAllCourses();
                ddl_course.DataTextField = "Crs-Name";
                ddl_course.DataValueField = "Crs-ID";
                ddl_Dept.Items.Insert(0, D);
                ddl_course.DataBind();

                ddl_allIns.Items.Clear();
                ddl_allIns.DataSource = InstractorBL.GetAllIns();
                ddl_allIns.DataTextField = "Ins-Name";
                ddl_allIns.DataValueField = "Ins-ID";
                ddl_allIns.DataBind();
               
                ddl_selectInst.Items.Insert(0, I);


            }
            catch (Exception ex)
            {
                lbl_status.Text = "Somting went wrong";
                Admins.LogError(ex.Message.ToString(), DateTime.Now.ToLongDateString(), DateTime.Now.ToLongTimeString(), Path.GetFileName(Request.Url.AbsolutePath), "FullDDL");

            }
            

        }

        protected void ddl_selectInst_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txt_instId.Enabled = false;
                DataTable dataTable = new DataTable();
                dataTable = InstractorBL.GetInstructorByID(int.Parse(ddl_selectInst.SelectedValue));
                txt_instId.Text = dataTable.Rows[0]["Ins-ID"].ToString();
                txt_InsName.Text = dataTable.Rows[0]["Ins-Name"].ToString();
                txt_InsDegree.Text = dataTable.Rows[0]["Ins_Degree"].ToString();
                txt_InsSalary.Text = dataTable.Rows[0]["Salary"].ToString();
                txt_userName.Text = dataTable.Rows[0]["username"].ToString();
                txt_password.Text = dataTable.Rows[0]["password"].ToString();
                ddl_Dept.SelectedValue = dataTable.Rows[0]["Depart-ID"].ToString();
                
            }
            catch (Exception ex)
            {
                lbl_status.Text = "Somting went wrong";
                Admins.LogError(ex.Message.ToString(), DateTime.Now.ToLongDateString(), DateTime.Now.ToLongTimeString(), Path.GetFileName(Request.Url.AbsolutePath), "ddl_selectInst_SelectedIndexChanged");

            }
            

        }

        protected void btn_NewINs_Click(object sender, EventArgs e)
        {
            txt_instId.Text = txt_InsName.Text = txt_InsDegree.Text = txt_InsSalary.Text = txt_userName.Text = txt_password.Text = String.Empty;
        }

        protected void btn_InsertIns_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {


                try
                {
                    if (ddl_Dept.SelectedIndex != 0)
                    {
                        int rows = InstractorBL.CreateInstructor(txt_InsName.Text, int.Parse(ddl_Dept.SelectedValue), txt_InsDegree.Text, txt_InsSalary.Text, txt_userName.Text, txt_password.Text);
                       
                        if (rows > 0)
                        {
                            lbl_status.Text = "Successfully Added :)";
                            FullDDL();
                            btn_NewINs_Click(sender, e);
                            txt_instId.Enabled = false;
                        }
                        else
                        {
                            lbl_status.Text = "Connection Time Out :(";
                        }
                    }
                    else
                    {
                        lbl_status.Text = "You Have to Assign Department";
                    }

                }
                catch (Exception ex)
                {
                    lbl_status.Text = "Somting went wrong";
                    Admins.LogError(ex.Message.ToString(), DateTime.Now.ToLongDateString(), DateTime.Now.ToLongTimeString(), Path.GetFileName(Request.Url.AbsolutePath), "btn_InsertIns_Click");

                }

            }
        }

        protected void btn_Update_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {


                try
                {
                    if (ddl_Dept.SelectedIndex != 0)
                    {


                        int rows = InstractorBL.EditInstructor(int.Parse(txt_instId.Text), txt_InsName.Text, int.Parse(ddl_Dept.SelectedValue), txt_InsDegree.Text, txt_InsDegree.Text, txt_userName.Text, txt_password.Text);
                        if (rows > 0)
                        {
                            lbl_status.Text = "Successfully Updated";
                        }
                        FullDDL();
                        btn_NewINs_Click(sender, e);
                        txt_instId.Enabled = false;
                    }
                    else
                    {
                        lbl_status.Text = "You Have To Assign Department";
                    }
                }
                catch (Exception ex)
                {
                    lbl_status.Text = "Somting went wrong";
                    Admins.LogError(ex.Message.ToString(), DateTime.Now.ToLongDateString(), DateTime.Now.ToLongTimeString(), Path.GetFileName(Request.Url.AbsolutePath), "btn_Update_Click");

                }
            }

        }

        protected void btn_Delete_Click(object sender, EventArgs e)
        {

            try
            {
                int rows = InstractorBL.RemoveInstructor(int.Parse(ddl_selectInst.SelectedValue));
                if (rows > 0)
                {
                    lbl_status.Text = "Successfully Deleted";
                }
                FullDDL();
                btn_NewINs_Click(sender, e);
                txt_instId.Enabled = false;
            }
            catch (Exception ex)
            {
                lbl_status.Text = "Somting went wrong";
                Admins.LogError(ex.Message.ToString(), DateTime.Now.ToLongDateString(), DateTime.Now.ToLongTimeString(), Path.GetFileName(Request.Url.AbsolutePath), "btn_Delete_Click");

            }

        }

        protected void ddl_Dept_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btn_assigntocourse_Click(object sender, EventArgs e)
        {
            if (ddl_allIns.SelectedIndex!=0 && ddl_course.SelectedIndex!=0)
            {
                int rows = StdCrsIns.CreateInsCourse(int.Parse(ddl_allIns.SelectedValue), int.Parse(ddl_course.SelectedValue));
                if (rows>0)
                {
                    lbl_status.Text = "Assigned";
                }
                else
                {
                    lbl_status.Text = "اتغفلت";
                }
            }
        }

       
        //protected void gv_inscrs_RowEditing1(object sender, GridViewEditEventArgs e)
        //{
        //    //gv_inscrs.EditIndex = e.NewEditIndex;
        //}

        //protected void gv_inscrs_RowUpdating(object sender, GridViewUpdateEventArgs e)
        //{
        //    int insid = int.Parse((gv_inscrs.Rows[e.RowIndex].FindControl("ddl_insforcrs") as DropDownList).SelectedValue);
        //    int crsid = int.Parse((gv_inscrs.Rows[e.RowIndex].FindControl("ddl_course") as DropDownList).SelectedValue);
        //    int rows = StdCrsIns.EditInsCourseByIns(insid, crsid);
        //    if (rows>0)
        //    {
        //        gv_inscrs.EditIndex = -1;
        //        gv_inscrs.DataBind();
        //    }
        //}

        protected void gv_lastchance_RowEditing(object sender, GridViewEditEventArgs e)
        {
            DataTable dataTable= StdCrsIns.LastChance();
            gv_lastchance.EditIndex = e.NewEditIndex;
            gv_lastchance.DataSource = dataTable;
            gv_lastchance.DataBind();
            DropDownList ddl_ins = (gv_lastchance.Rows[e.NewEditIndex].FindControl("ddl_lastchanceI") as DropDownList);
            ddl_ins.DataSource = InstractorBL.GetAllIns();
            ddl_ins.DataTextField = "Ins-Name";
            ddl_ins.DataValueField = "Ins-ID";
            ddl_ins.DataBind();
            ddl_ins.SelectedValue = dataTable.Rows[e.NewEditIndex]["Ins-ID"].ToString();


            DropDownList ddl_course = (gv_lastchance.Rows[e.NewEditIndex].FindControl("dd_lastchaneC") as DropDownList);
            ddl_course.DataSource = CourseBL.GetAllCourses();
            ddl_course.DataTextField = "Crs-Name";
            ddl_course.DataValueField = "Crs-ID";
            ddl_course.DataBind();
            ddl_course.SelectedValue = dataTable.Rows[e.NewEditIndex]["Crs-ID"].ToString();


        }

        protected void gv_lastchance_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gv_lastchance.EditIndex = -1;
            DataTable dataTable = StdCrsIns.LastChance();
            gv_lastchance.DataSource = dataTable;
            gv_lastchance.DataBind();
        }

        protected void gv_lastchance_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            DataTable dataTable = StdCrsIns.LastChance();


            int insid = int.Parse(dataTable.Rows[e.RowIndex]["Ins-ID"].ToString());
            int crsid = int.Parse(dataTable.Rows[e.RowIndex]["Crs-ID"].ToString());
            int rows = StdCrsIns.Remove_Ins_Course(insid, crsid);
            if (rows > 0)
            {
                dataTable = StdCrsIns.LastChance();
                gv_lastchance.DataSource = dataTable;
                gv_lastchance.DataBind();
            }
        }

        protected void gv_lastchance_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int insid = int.Parse((gv_lastchance.Rows[e.RowIndex].FindControl("ddl_lastchanceI") as DropDownList).SelectedValue);
            int crsid = int.Parse((gv_lastchance.Rows[e.RowIndex].FindControl("dd_lastchaneC") as DropDownList).SelectedValue);
            
            int rows = StdCrsIns.EditInsCourseByIns(insid, crsid);
            if (rows > 0)
            {
                gv_lastchance.EditIndex = -1;
                DataTable dataTable = StdCrsIns.LastChance();
                gv_lastchance.DataSource = dataTable;
                gv_lastchance.DataBind();
            }

        }

        protected void gv_lastchance_RowCommand(object sender, GridViewCommandEventArgs e)
        {

        }

        protected void gv_lastchance_RowCreated(object sender, GridViewRowEventArgs e)
        {

        }
    }
}