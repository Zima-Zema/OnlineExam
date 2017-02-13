using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Report6 : System.Web.UI.Page
{
    DataTable dt = new DataTable();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            ddlcourse.DataSource = BusinessLayer.Display_course_by_Idand_Name();
            ddlcourse.DataValueField = "Crs-ID";
            ddlcourse.DataTextField = "Crs-ID";
            ddlcourse.DataBind();
            

        }

    }

    protected void ddlcourse_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            DataTable dt = Reports.R6(int.Parse(ddlcourse.SelectedValue));
            gvR6.DataSource = dt;
            gvR6.DataBind();
        }
        catch
        {
            lblresult.Text = "error in Selecting Course ";
        }
    }
}