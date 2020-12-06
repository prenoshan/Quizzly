using DBHelperDLL;
using QandADLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TestDLL;

namespace QuizzlySite.html.lecturer
{
    public partial class CreateTestArea : System.Web.UI.Page
    {

        //stores the connection string to the database
        string connString = ConfigurationManager.ConnectionStrings["QuizzlyDB"].ConnectionString;

        //gets the references to the dlls
        DBHelper helper = new DBHelper();

        QandA qandA = new QandA();

        Test test = new Test();

        //keeps the question count
        int q_Count, currentqCount = 2;

        protected void Page_Load(object sender, EventArgs e)
        {

            if(Session["testName"] == null)
            {
                Session["invalidRequest"] = "true";
                Response.Redirect("~/html/lecturer/CreateTest.aspx");
            }


            contentTwo.Visible = false;
            contentOne.Visible = true;

            errorOne.Visible = false;
            errorTwo.Visible = false;

            q_Count = test.getQcount(helper.openConn(connString), test.getTestID(helper.openConn(connString), Session["testName"].ToString()), Session["testName"].ToString());

            helper.closeConn();

            if (!IsPostBack)
            {
                //renders the question number to set for
                tbQuestionNum.Text = "Question 1" + " of " + q_Count;

            }

        }

        public void insertAnswer(string question)
        {

            string answer;
            string correct = "true", incorrect = "false";

            //checks if first answer is correct and inserts it else inserts answer as incorrect

            if (rbAnsOne.Checked == true)
            {

                answer = tbAnsOne.Text;

                qandA.insertAnswers(helper.openConn(connString), test.getTestID(helper.openConn(connString), Session["testName"].ToString()), qandA.getQuestionID(helper.openConn(connString), question), answer, correct);

            }

            if (rbAnsOne.Checked == false)
            {
                answer = tbAnsOne.Text;

                qandA.insertAnswers(helper.openConn(connString), test.getTestID(helper.openConn(connString), Session["testName"].ToString()), qandA.getQuestionID(helper.openConn(connString), question), answer, incorrect);
            }

            //checks if second answer is correct and inserts it else inserts answer as incorrect

            if (rbAnsTwo.Checked == true)
            {

                answer = tbAnsTwo.Text;

                qandA.insertAnswers(helper.openConn(connString), test.getTestID(helper.openConn(connString), Session["testName"].ToString()), qandA.getQuestionID(helper.openConn(connString), question), answer, correct);

            }

            if (rbAnsTwo.Checked == false)
            {
                answer = tbAnsTwo.Text;

                qandA.insertAnswers(helper.openConn(connString), test.getTestID(helper.openConn(connString), Session["testName"].ToString()), qandA.getQuestionID(helper.openConn(connString), question), answer, incorrect);
            }

            //checks if third answer is correct and inserts it else inserts answer as incorrect

            if (rbAnsThree.Checked == true)
            {

                answer = tbAnsThree.Text;

                qandA.insertAnswers(helper.openConn(connString), test.getTestID(helper.openConn(connString), Session["testName"].ToString()), qandA.getQuestionID(helper.openConn(connString), question), answer, correct);

            }

            if (rbAnsThree.Checked == false)
            {
                answer = tbAnsThree.Text;

                qandA.insertAnswers(helper.openConn(connString), test.getTestID(helper.openConn(connString), Session["testName"].ToString()), qandA.getQuestionID(helper.openConn(connString), question), answer, incorrect);
            }

            //checks if fourth answer is correct and inserts it else inserts answer as incorrect

            if (rbAnsFour.Checked == true)
            {

                answer = tbAnsFour.Text;

                qandA.insertAnswers(helper.openConn(connString), test.getTestID(helper.openConn(connString), Session["testName"].ToString()), qandA.getQuestionID(helper.openConn(connString), question), answer, correct);

            }

            if (rbAnsFour.Checked == false)
            {
                answer = tbAnsFour.Text;

                qandA.insertAnswers(helper.openConn(connString), test.getTestID(helper.openConn(connString), Session["testName"].ToString()), qandA.getQuestionID(helper.openConn(connString), question), answer, incorrect);
            }

            helper.closeConn();
        }

        protected void btnAddQuestion_Click(object sender, EventArgs e)
        {

            //checks if the question is not empty
            if (string.IsNullOrWhiteSpace(tbQuestion.Text))
            {

                errorTwo.Visible = false;
                errorOne.Visible = true;

            }

            //checks if the answers are not empty
            else if (tbAnsOne.Text.Equals("") || tbAnsTwo.Text.Equals("") || tbAnsThree.Text.Equals("") || tbAnsFour.Text.Equals(""))
            {

                errorTwo.Visible = false;
                errorOne.Visible = true;

            }

            //checks if a correct answer is selected
            else if (rbAnsOne.Checked == false && rbAnsTwo.Checked == false && rbAnsThree.Checked == false && rbAnsFour.Checked == false)
            {

                errorOne.Visible = false;
                errorTwo.Visible = true;

            }

            else
            {

                //calls the method to create a question for the test
                qandA.createQuestion(helper.openConn(connString), tbQuestion.Text.Trim());

                //calls the method to store the questions for the test
                qandA.testQuestionInsert(helper.openConn(connString), qandA.getQuestionID(helper.openConn(connString), tbQuestion.Text.Trim()), test.getTestID(helper.openConn(connString), Session["testName"].ToString()));

                insertAnswer(tbQuestion.Text.Trim());

                helper.closeConn();

                if (ViewState["currentqCount"] != null)
                {

                    currentqCount = (int)ViewState["currentqCount"] + 1;

                }

                clearControls();

                tbQuestionNum.Text = "Question " + currentqCount + " of " + q_Count;

                ViewState["currentqCount"] = currentqCount;

                //checks if the current question count is greater than the question count that has been set
                if (currentqCount > q_Count)
                {

                    contentOne.Visible = false;
                    contentTwo.Visible = true;

                }


            }
        }

        protected void btnNewTest_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/html/lecturer/CreateTest.aspx");
        }

        public void clearControls()
        {

            tbQuestion.Text = "";

            tbAnsOne.Text = "";
            tbAnsTwo.Text = "";
            tbAnsThree.Text = "";
            tbAnsFour.Text = "";

            rbAnsOne.Checked = false;
            rbAnsTwo.Checked = false;
            rbAnsThree.Checked = false;
            rbAnsFour.Checked = false;

        }
    }
}