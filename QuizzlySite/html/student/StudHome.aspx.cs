using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuizzlySite.html.student
{
    public partial class StudHome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            errorOne.Visible = false;

            if (Session["User"] == null)
            {

                Session["LoggedIn"] = "false";

                Response.Redirect("~/html/LoginPage.aspx");

            }

            if (Session["UserType"].Equals("Lecturer"))
            {

                Session["wrongUser"] = "true";

                Response.Redirect("~/html/lecturer/LectHome.aspx");

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

        protected void btnViewMemos_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/html/student/ViewMemos.aspx");
        }

        protected void btnViewMarks_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/html/student/ViewMarks.aspx");
        }
    }
}