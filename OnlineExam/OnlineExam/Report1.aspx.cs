﻿using System;
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
    public partial class Report1 : System.Web.UI.Page
    {
        DataTable dt = new DataTable();
       

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                try
                {
                    ddldept.DataSource = BusinessLayer.Display_Department_by_Idand_Name();
                    ddldept.DataTextField = "Dept_Name";
                    ddldept.DataValueField = "Dept_Id";
                    ListItem li = new ListItem("none", "0");
                    ddldept.Items.Insert(0, li);
                    ddldept.DataBind();
                }
                catch (Exception ex)
                {
                    lblresult.Text = "Something Went Wrong";
                    Admins.LogError(ex.Message.ToString(), DateTime.Now.ToLongDateString(), DateTime.Now.ToLongTimeString(), Path.GetFileName(Request.Url.AbsolutePath), "Page_Load");

                }




            }
        }

        protected void ddldept_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = Reports.ROne(int.Parse(ddldept.SelectedValue));
                gvR1.DataSource = dt;
                gvR1.DataBind();
            }
            catch
            {
                lblresult.Text = "Error In Deparment";
            }

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
