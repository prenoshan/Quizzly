using AuthDLL;
using DBHelperDLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuizzlySite.html
{
    public partial class LoginPage : System.Web.UI.Page
    {

        //stores the connection to the database
        string connString = ConfigurationManager.ConnectionStrings["QuizzlyDB"].ConnectionString;

        DBHelper helper = new DBHelper();

        public void clearControls()
        {

            txtUsername.Text = "";
            txtPassword.Text = "";
            toggle.Checked = false;

        }

        protected void Page_Load(object sender, EventArgs e)
        {

            errorOne.Visible = false;
            errorTwo.Visible = false;
            errorThree.Visible = false;

            if(Session["LoggedIn"] != null)
            {

                if (Session["LoggedIn"].Equals("false"))
                {
                    errorThree.Visible = true;
                }

            }

            if(Session["User"] != null)
            {

                if (Session["UserType"].Equals("Lecturer"))
                {

                    Response.Redirect("~/html/lecturer/LectHome.aspx");

                }

                else if (Session["UserType"].Equals("Student"))
                {

                    Response.Redirect("~/html/student/StudHome.aspx");

                }

            }

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            //checks if username is empty
            if (txtUsername.Text.Equals(""))
            {

                errorTwo.Visible = false;
                errorThree.Visible = false;
                errorOne.Visible = true;

            }

            //checks if password is empty
            else if (txtPassword.Text.Equals(""))
            {

                errorTwo.Visible = false;
                errorThree.Visible = false;
                errorOne.Visible = true;

            }

            else
            {

                //gets reference to the auth dll
                PilotAuth auth = new PilotAuth();

                //checks if there is no user that exists for the username and password
                if (auth.login(helper.openConn(connString), txtUsername.Text, txtPassword.Text).Equals(null))
                {

                    errorOne.Visible = false;
                    errorThree.Visible = false;
                    errorTwo.Visible = true;

                }

                //redirects to lecturer screen if the user is a lecturer
                else if (toggle.Checked == true && auth.login(helper.openConn(connString), txtUsername.Text, txtPassword.Text).Equals("Lecturer"))
                {

                    Session["User"] = Guid.NewGuid().ToString();

                    Session["UserType"] = "Lecturer";

                    Session["Name"] = auth.getName(helper.openConn(connString), auth.getUserID(helper.openConn(connString), txtUsername.Text), true);

                    clearControls();

                    Response.Redirect("~/html/lecturer/LectHome.aspx");

                }

                //redirects to the student screen if the user is a student
                else if (toggle.Checked == false && auth.login(helper.openConn(connString), txtUsername.Text, txtPassword.Text).Equals("Student"))
                {

                    Session["User"] = Guid.NewGuid().ToString();

                    Session["UserType"] = "Student";

                    Session["Name"] = auth.getName(helper.openConn(connString), auth.getUserID(helper.openConn(connString), txtUsername.Text), false);

                    clearControls();

                    Response.Redirect("~/html/student/StudHome.aspx");

                }

                else
                {

                    errorOne.Visible = false;
                    errorThree.Visible = false;
                    errorTwo.Visible = true;

                }

                helper.closeConn();

            }
        }
    }
}