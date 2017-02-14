using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace OnlineExam
{
    public partial class Report1 : System.Web.UI.Page
    {
        DataTable dt = new DataTable();
        ObjectDataSource obds = new ObjectDataSource();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {

                ddldept.DataSource = BusinessLayer.Display_course_by_Idand_Name();
                ddldept.DataTextField = "Dept_Name";
                ddldept.DataValueField = "Dept_Id";
                ListItem li = new ListItem("none", "0");
                ddldept.Items.Insert(0, li);
                ddldept.DataBind();
                //obds.TypeName = "BusinessLayer";
                //obds.SelectMethod = "Display_Department_by_Idand_Name";
                //obds.Select();
                //ddldept.DataSource = obds;
                //ddldept.DataTextField = "Dept_Name";
                //ddldept.DataValueField = "Dept_Id";
                //ddldept.DataBind();
                /*
                 if (!IsPostBack) { 
                ddl_R2.DataSource = Reports.ROne();
                ddl_R2.DataValueField = "Dept_Id";
                ddl_R2.DataTextField = "Dept_Name";
                ddl_R2.DataBind();
                */



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
