using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Report4 : System.Web.UI.Page
{
    DataTable dt = new DataTable();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            ddlExam.DataSource = Reports.DisplayExamByID();
            ddlExam.DataValueField = "Exam-ID";
            ddlExam.DataTextField = "Exam-ID";
            ddlExam.DataBind();

        }

    }



    protected void ddlExam_SelectedIndexChanged(object sender, EventArgs e)
    {
        try {
            DataTable dt = Reports.R4(int.Parse(ddlExam.SelectedValue));
            gvR4.DataSource = dt;
            gvR4.DataBind();
        }
        catch
        {
            lblresult.Text = "Error in Exam No";
        }
       

    }
}