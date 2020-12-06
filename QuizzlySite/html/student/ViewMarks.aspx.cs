using DBHelperDLL;
using ResultAndMemoDLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TestDLL;

namespace QuizzlySite.html.student
{
    public partial class ViewMarks : System.Web.UI.Page
    {

        //gets the connection string to the database
        string connString = ConfigurationManager.ConnectionStrings["QuizzlyDB"].ConnectionString;

        //gets the reference to the dlls
        DBHelper helper = new DBHelper();

        Test test = new Test();

        ResultAndMemo resultAndMemo = new ResultAndMemo();

        //list to store the test names for each student
        List<string> testNames = new List<string>();

        protected void Page_Load(object sender, EventArgs e)
        {
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

            if (!IsPostBack)
            {
                //populates the tests list with all the tests a student has completed
                foreach (DataRow row in resultAndMemo.getTestNames(helper.openConn(connString), resultAndMemo.getStudID(helper.openConn(connString), Session["Name"].ToString())).Rows)
                {

                    testNames.Add(row[0].ToString());

                }

                ddlTestsTaken.DataSource = testNames;
                ddlTestsTaken.DataBind();

                //checks if a student has not completed a test
                if (ddlTestsTaken.Items.Count == 0)
                {

                    ddlTestsTaken.DataSource = null;

                    ddlTestsTaken.Items.Add("You haven't taken a test yet");

                }
            }

            helper.closeConn();
        }

        protected void btnViewMemo_Click(object sender, EventArgs e)
        {

            //stores the result for the student's test
            int result = resultAndMemo.getResult(helper.openConn(connString), resultAndMemo.getStudID(helper.openConn(connString), Session["Name"].ToString()), test.getTestID(helper.openConn(connString), ddlTestsTaken.SelectedValue.ToString()));

            //stores the question count of the test 
            int testQCount = test.getQcount(helper.openConn(connString), test.getTestID(helper.openConn(connString), ddlTestsTaken.SelectedValue.ToString()), ddlTestsTaken.SelectedValue.ToString());

            //stores the percentage that the student got for the test
            double percentage = ((double)result / testQCount) * 100;

            //displays the result and percentage to the user
            lbMark.Text = "Your mark for " + ddlTestsTaken.SelectedValue.ToString() + " is " + result + " / " + test.getQcount(helper.openConn(connString), test.getTestID(helper.openConn(connString), ddlTestsTaken.SelectedValue.ToString()), ddlTestsTaken.SelectedValue.ToString());
            lbPercentage.Text = "Your percentage for " + ddlTestsTaken.SelectedValue.ToString() + " is " + Math.Round(percentage, 2) + "%";

            helper.closeConn();

        }
    }
}