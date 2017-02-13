using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Students_results_ : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            gvStudentResult.DataSource = Display.DisplayStudentsResults();
            gvStudentResult.DataBind();
        }
        catch
        {
            lblresult.Text = "Error In Results";
        }
    }

    protected void gvStudentResult_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}