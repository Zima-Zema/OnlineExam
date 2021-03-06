﻿using OnlineExam.Code;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class InstructorsPerCourseWebUserControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                FillDDWithCourse();
            }
        }

        private void FillDDWithCourse()
        {
            try
            {
                ddl_selectCrs.Items.Clear();
                ddl_selectCrs.DataSource = InsByCourse.GetAllCourses();
                ddl_selectCrs.DataTextField = "Crs-Name";
                ddl_selectCrs.DataValueField = "Crs-ID";
                ddl_selectCrs.DataBind();
                ListItem m = new ListItem("none", "0");
                ddl_selectCrs.Items.Insert(0, m);
            }
            catch (Exception ex)
            {
                Admins.LogError(ex.Message.ToString(), DateTime.Now.ToLongDateString(), DateTime.Now.ToLongTimeString(), Path.GetFileName(Request.Url.AbsolutePath), "FillDDWithCourse");
                lbl_status.Text = "Somthing Went Worng";
            }
            
        }

        protected void ddl_selectCrs_SelectedIndexChanged1(object sender, EventArgs e)
        {
            try
            {
                gv_CourseIns.DataSource = InsByCourse.GetCourseById(int.Parse(ddl_selectCrs.SelectedValue));
                gv_CourseIns.DataBind();


                if (gv_CourseIns.Rows.Count == 0)
                {

                    lbl_status.Text = " Thise course not have Instructor Yet";
                    lbl_status.Visible = true;

                }
                else
                {

                    lbl_status.Visible = false;

                }

            }
            catch (Exception ex)
            {
                Admins.LogError(ex.Message.ToString(), DateTime.Now.ToLongDateString(), DateTime.Now.ToLongTimeString(), Path.GetFileName(Request.Url.AbsolutePath), "ddl_selectCrs_SelectedIndexChanged1");
                lbl_status.Text = "Something Went Wrong";
            }




        }
    }
}