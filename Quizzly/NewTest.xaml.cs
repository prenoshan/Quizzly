using DBHelperDLL;
using QandADLL;
using System.Configuration;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using TestDLL;

namespace Quizzly
{
    /// <summary>
    /// Interaction logic for NewTest.xaml
    /// </summary>
    public partial class NewTest : UserControl
    {

        //stores the connection string to the database
        string connString = ConfigurationManager.ConnectionStrings["QuizzlyDB"].ConnectionString;

        //gets the references to the dlls
        DBHelper helper = new DBHelper();

        QandA qandA = new QandA();

        Test test = new Test();

        //keeps the question count
        int q_Count, currentqCount = 1;

        public NewTest()
        {
            InitializeComponent();

            q_Count = test.getQcount(helper.openConn(connString), test.getTestID(helper.openConn(connString), CreateTest.testName), CreateTest.testName);

            //renders the question number to set for
            qNum.Text = "Question " + currentqCount + " of " + q_Count;

            helper.closeConn();
        }

        private void BtnSaveQuestion_Click(object sender, RoutedEventArgs e)
        {

            string question = new TextRange(rbQuestion.Document.ContentStart, rbQuestion.Document.ContentEnd).Text;

            //checks if the question is not empty
            if (string.IsNullOrWhiteSpace(question))
            {

                validateQuestion.IsOpen = true;

            }

            //checks if the answers are not empty
            else if(tbAnswerOne.Text.Equals("") || tbAnswerTwo.Text.Equals("") || tbAnswerThree.Text.Equals("") || tbAnswerFour.Text.Equals(""))
            {

                validateAnswers.IsOpen = true;

            }

            //checks if a correct answer is selected
            else if(checkAnswerOne.IsChecked == false && checkAnswerTwo.IsChecked == false && checkAnswerThree.IsChecked == false && checkAnswerFour.IsChecked == false)
            {

                validateCorrect.IsOpen = true;

            }

            else
            {

                //calls the method to create a question for the test
                qandA.createQuestion(helper.openConn(connString), question);

                //calls the method to store the questions for the test
                qandA.testQuestionInsert(helper.openConn(connString), qandA.getQuestionID(helper.openConn(connString), question), test.getTestID(helper.openConn(connString), CreateTest.testName));

                insertAnswer(question);

                helper.closeConn();

                currentqCount++;

                clearControls();

                qNum.Text = "Question " + currentqCount + " of " + q_Count;


                //checks if the current question count is greater than the question count that has been set
                if(currentqCount > q_Count)
                {

                    LecturerScreen lecturerScreen = (LecturerScreen)Window.GetWindow(this);

                    lecturerScreen.clearContent();

                    TestSet testSet = new TestSet();

                    //displays the user control for a test being set
                    lecturerScreen.addContent(testSet);

                    lecturerScreen.btnCreateTest.IsEnabled = true;
                    lecturerScreen.btnLogOut.IsEnabled = true;
                    lecturerScreen.btnWebsite.IsEnabled = true;

                }


            }

        }

        public void insertAnswer(string question)
        {

            string answer;
            string correct = "true", incorrect = "false";

            //checks if first answer is correct and inserts it else inserts answer as incorrect

            if (checkAnswerOne.IsChecked == true)
            {

                answer = tbAnswerOne.Text;

                qandA.insertAnswers(helper.openConn(connString), test.getTestID(helper.openConn(connString), CreateTest.testName), qandA.getQuestionID(helper.openConn(connString), question),answer,correct);

            }

            if(checkAnswerOne.IsChecked == false)
            {
                answer = tbAnswerOne.Text;

                qandA.insertAnswers(helper.openConn(connString), test.getTestID(helper.openConn(connString), CreateTest.testName), qandA.getQuestionID(helper.openConn(connString), question), answer, incorrect);
            }

            //checks if second answer is correct and inserts it else inserts answer as incorrect

            if (checkAnswerTwo.IsChecked == true)
            {

                answer = tbAnswerTwo.Text;

                qandA.insertAnswers(helper.openConn(connString), test.getTestID(helper.openConn(connString), CreateTest.testName), qandA.getQuestionID(helper.openConn(connString), question), answer, correct);

            }

            if (checkAnswerTwo.IsChecked == false)
            {
                answer = tbAnswerTwo.Text;

                qandA.insertAnswers(helper.openConn(connString), test.getTestID(helper.openConn(connString), CreateTest.testName), qandA.getQuestionID(helper.openConn(connString), question), answer, incorrect);
            }

            //checks if third answer is correct and inserts it else inserts answer as incorrect

            if (checkAnswerThree.IsChecked == true)
            {

                answer = tbAnswerThree.Text;

                qandA.insertAnswers(helper.openConn(connString), test.getTestID(helper.openConn(connString), CreateTest.testName), qandA.getQuestionID(helper.openConn(connString), question), answer, correct);

            }

            if (checkAnswerThree.IsChecked == false)
            {
                answer = tbAnswerThree.Text;

                qandA.insertAnswers(helper.openConn(connString), test.getTestID(helper.openConn(connString), CreateTest.testName), qandA.getQuestionID(helper.openConn(connString), question), answer, incorrect);
            }

            //checks if fourth answer is correct and inserts it else inserts answer as incorrect

            if (checkAnswerFour.IsChecked == true)
            {

                answer = tbAnswerFour.Text;

                qandA.insertAnswers(helper.openConn(connString), test.getTestID(helper.openConn(connString), CreateTest.testName), qandA.getQuestionID(helper.openConn(connString), question), answer, correct);

            }

            if (checkAnswerFour.IsChecked == false)
            {
                answer = tbAnswerFour.Text;

                qandA.insertAnswers(helper.openConn(connString), test.getTestID(helper.openConn(connString), CreateTest.testName), qandA.getQuestionID(helper.openConn(connString), question), answer, incorrect);
            }

            helper.closeConn();
        }

        public void clearControls()
        {

            rbQuestion.Document.Blocks.Clear();

            tbAnswerOne.Text = "";
            tbAnswerTwo.Text = "";
            tbAnswerThree.Text = "";
            tbAnswerFour.Text = "";

            checkAnswerOne.IsChecked = false;
            checkAnswerTwo.IsChecked = false;
            checkAnswerThree.IsChecked = false;
            checkAnswerFour.IsChecked = false;

        }
    }
}
