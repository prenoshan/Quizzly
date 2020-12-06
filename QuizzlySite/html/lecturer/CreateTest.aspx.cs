using DBHelperDLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TestDLL;

namespace QuizzlySite.html.lecturer
{
    public partial class CreateTest : System.Web.UI.Page
    {

        //stores the connection string to the database
        string connString = ConfigurationManager.ConnectionStrings["QuizzlyDB"].ConnectionString;

        DBHelper helper = new DBHelper();

        Test test = new Test();

        protected void Page_Load(object sender, EventArgs e)
        {

            //hides the error panels
            errorOne.Visible = false;
            errorTwo.Visible = false;
            errorThree.Visible = false;
            errorFour.Visible = false;

            if (Session["invalidRequest"] != null)
            {
                if (Session["invalidRequest"].Equals("true"))
                {
                    errorFour.Visible = true;
                }
            }

            if(Session["User"] == null)
            {

                Session["LoggedIn"] = "false";

                Response.Redirect("~/html/LoginPage.aspx");

            }

            if (Session["UserType"].Equals("Student"))
            {

                Session["wrongUser"] = "true";

                Response.Redirect("~/html/student/StudHome.aspx");

            }

            //populates the category combo box
            foreach (DataRow row in test.getTestCategories(helper.openConn(connString)).Rows)
            {

                ddlTestCat.Items.Add(row[0].ToString());

            }

            helper.closeConn();

        }

        public void clearControls()
        {

            tbTestName.Text = "";
            tbQNumbers.Text = "0";

        }

        protected void btnTestCreate_Click(object sender, EventArgs e)
        {
            //checks if no test name is set
            if (tbTestName.Text.Equals(""))
            {

                errorTwo.Visible = false;
                errorThree.Visible = false;
                errorFour.Visible = false;
                errorOne.Visible = true;

            }

            //checks if no question number is set
            else if (tbQNumbers.Text.Equals(""))
            {

                errorTwo.Visible = false;
                errorThree.Visible = false;
                errorFour.Visible = false;
                errorOne.Visible = true;

            }


            //checks if the question number is an int
            else if (!int.TryParse(tbQNumbers.Text, out int num))
            {

                errorOne.Visible = false;
                errorThree.Visible = false;
                errorFour.Visible = false;
                errorTwo.Visible = true;

            }

            //checks if the test name already exists
            else if (test.testNameExists(helper.openConn(connString), tbTestName.Text) == true)
            {

                errorOne.Visible = false;
                errorTwo.Visible = false;
                errorFour.Visible = false;
                errorThree.Visible = true;

            }

            else
            {

                //calls method from dll to create the test
                test.createTest(helper.openConn(connString), tbTestName.Text, Convert.ToInt32(tbQNumbers.Text));

                test.getTestID(helper.openConn(connString), tbTestName.Text);

                test.getCatID(helper.openConn(connString), ddlTestCat.SelectedValue.ToString());

                //calls method from dll to store the category for the test
                test.insertCategoryforTest(helper.openConn(connString), tbTestName.Text, ddlTestCat.SelectedValue.ToString());

                helper.closeConn();

                Session["testName"] = tbTestName.Text;

                clearControls();

                Response.Redirect("~/html/lecturer/createTestArea.aspx");
            }
        }
    }
}