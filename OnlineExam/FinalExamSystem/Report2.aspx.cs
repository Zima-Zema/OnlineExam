using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Report2 : System.Web.UI.Page
{
    DataTable dt = new DataTable();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            ddlstudent.DataSource = Reports.DisplayStudentByID();
            ddlstudent.DataValueField = "St-ID";
            ddlstudent.DataTextField = "St-ID";
            ddlstudent.DataBind();

        }
    }

    protected void ddldept_SelectedIndexChanged(object sender, EventArgs e)
    {
        try {
            DataTable dt = Reports.R2(int.Parse(ddlstudent.SelectedValue));
            gvR2.DataSource = dt;
            gvR2.DataBind();
        }
        catch
        {
            lblresult.Text = "Error In Student No";
        }
       
    }
}