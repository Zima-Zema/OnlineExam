using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Students_have_corrective_exam_by_course_ : System.Web.UI.Page
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
            DataTable dt = Display.DisplayCorrectiveStudentsByCourse(int.Parse(ddlcourse.SelectedValue));
            gvCorrectiveByCourse.DataSource = dt;
            gvCorrectiveByCourse.DataBind();
        }
        catch
        {
            lblresult.Text = "Error in Entering Course No";
        }
    }

    protected void gvCorrectiveByCourse_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}