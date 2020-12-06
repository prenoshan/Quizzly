using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuizzlySite.html.lecturer
{
    public partial class LectHome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            errorOne.Visible = false;

            if (Session["User"] == null)
            {

                Session["LoggedIn"] = "false";

                Response.Redirect("~/html/LoginPage.aspx");

            }

            if (Session["UserType"].Equals("Student"))
            {

                Session["wrongUser"] = "true";

                Response.Redirect("~/html/student/StudHome.aspx");

            }

            if (Session["wrongUser"] != null)
            {

                if (Session["wrongUser"].Equals("true"))
                {
                    errorOne.Visible = true;
                }

            }

            lbName.Text = Session["Name"].ToString();
        }

        protected void btnCreateTest_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/html/lecturer/CreateTest.aspx");
        }
    }
}