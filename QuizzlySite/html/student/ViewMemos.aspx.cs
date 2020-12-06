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
    public partial class ViewMemos : System.Web.UI.Page
    {

        //stores the connection string to the database
        string connString = ConfigurationManager.ConnectionStrings["QuizzlyDB"].ConnectionString;

        //stores the references to the dlls
        DBHelper helper = new DBHelper();

        Test test = new Test();

        ResultAndMemo resultAndMemo = new ResultAndMemo();

        //list to store the test names for test that a student has completed
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

            gvMemos.Visible = false;

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

            gvMemos.Visible = true;

            //sets the item source for the data grid to the memo for the test a student has chosen
            gvMemos.DataSource = resultAndMemo.getMemo(helper.openConn(connString), test.getTestID(helper.openConn(connString), ddlTestsTaken.SelectedValue.ToString()), resultAndMemo.getStudID(helper.openConn(connString), Session["Name"].ToString()));

            gvMemos.DataBind();

            //sets the column names for each column
            gvMemos.HeaderRow.Cells[0].Text = "Questions";
            gvMemos.HeaderRow.Cells[1].Text = "Correct Answers";
            gvMemos.HeaderRow.Cells[2].Text = "Your Answers";

            helper.closeConn();

        }
    }
}