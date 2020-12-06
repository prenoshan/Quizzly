using DBHelperDLL;
using QandADLL;
using ResultAndMemoDLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TakeTestDLL;
using TestDLL;

namespace Quizzly
{
    /// <summary>
    /// Interaction logic for TestArea.xaml
    /// </summary>
    public partial class TestArea : UserControl
    {

        //stores the connection string to the database
        string connString = ConfigurationManager.ConnectionStrings["QuizzlyDB"].ConnectionString;

        //stores the references to the dlls
        DBHelper helper = new DBHelper();

        Test test = new Test();

        QandA qandA = new QandA();

        TestTaking testTaking = new TestTaking();

        ResultAndMemo resultAndMemo = new ResultAndMemo();

        CurrentTest currentTest = new CurrentTest();

        //keeps track of the current question count and the question count of the test
        int qCounter = 1, qCountForTest;

        //variable to store correct answers
        int correctCount = 0;

        public TestArea()
        {
            InitializeComponent();

            qCountForTest = test.getQcount(helper.openConn(connString), test.getTestID(helper.openConn(connString), TakeTest.testName), TakeTest.testName);

            //renders the first question number for the test
            qNum.Text = "Question " + qCounter + " of " + qCountForTest;

            //method to display the question and its answers
            storeAndDisplayQsAndAns();

            helper.closeConn();

        }

        public void storeAndDisplayQsAndAns()
        {

            //populates a list with the questions for the current test
            foreach (DataRow row in testTaking.getQuestions(helper.openConn(connString), test.getTestID(helper.openConn(connString), TakeTest.testName)).Rows)
            {

                currentTest.Questions.Add(row[0].ToString());

            }

            questionText.Text = currentTest.Questions[0].ToString();

            //populates a list with possible answers for the current test
            foreach (DataRow row in testTaking.getAnswers(helper.openConn(connString), qandA.getQuestionID(helper.openConn(connString), questionText.Text)).Rows)
            {

                currentTest.Answers.Add(row[0].ToString());

            }

            ansOne.Text = currentTest.Answers[0];
            ansTwo.Text = currentTest.Answers[1];
            ansThree.Text = currentTest.Answers[2];
            ansFour.Text = currentTest.Answers[3];

            helper.closeConn();

        }

        private void BtnNextQuestion_Click(object sender, RoutedEventArgs e)
        {

            //checks if an answer is selected
            if (selectAnswerOne.IsChecked == false && selectAnswerTwo.IsChecked == false && selectAnswerThree.IsChecked == false && selectAnswerFour.IsChecked == false)
            {

                validateAnswer.IsOpen = true;

            }

            else
            {

                //counter to iterate through each new question
                qCounter++;

                //stores the student's answer
                string getSelectedAnswer = getAnswers();

                string correctAns = testTaking.getCorrectAnswer(helper.openConn(connString), qandA.getQuestionID(helper.openConn(connString), questionText.Text));

                //calls method to insert the student's answer for each question into the database
                qandA.storeStudentAnswers(helper.openConn(connString), test.getTestID(helper.openConn(connString), TakeTest.testName), resultAndMemo.getStudID(helper.openConn(connString), StudentScreen.username), qandA.getQuestionID(helper.openConn(connString), questionText.Text), getSelectedAnswer);

                clearSelectedAnswers();

                //checks if the answer a student selects is correct
                if (getSelectedAnswer.Equals(correctAns))
                {
                    correctCount++;
                }

                //check to see if the test has ended
                if (qCounter > qCountForTest)
                {

                    StudentScreen studentScreen = (StudentScreen)Window.GetWindow(this);

                    studentScreen.clearContent();

                    TestComplete testComplete = new TestComplete();

                    //stores the answers a student has submitted for a test
                    testTaking.storeResults(helper.openConn(connString), testTaking.getStudID(helper.openConn(connString), StudentScreen.username), test.getTestID(helper.openConn(connString), TakeTest.testName), correctCount);

                    //adds the user control to indicate a test has been completed
                    studentScreen.addContent(testComplete);

                    studentScreen.btnTakeTest.IsEnabled = true;
                    studentScreen.btnViewMarks.IsEnabled = true;
                    studentScreen.btnViewMemos.IsEnabled = true;
                    studentScreen.btnLogOut.IsEnabled = true;
                    studentScreen.btnWebsite.IsEnabled = true;

                }

                if(qCounter <= qCountForTest)
                {

                    //renders the question count for the test
                    qNum.Text = "Question " + qCounter + " of " + qCountForTest;

                    //clears the answers list
                    currentTest.Answers.Clear();

                    //renders the question for the test
                    questionText.Text = currentTest.Questions[qCounter - 1].ToString();

                    //populates the answer list with the possible answers for each question in the test
                    foreach (DataRow row in testTaking.getAnswers(helper.openConn(connString), qandA.getQuestionID(helper.openConn(connString), questionText.Text)).Rows)
                    {

                        currentTest.Answers.Add(row[0].ToString());

                    }

                    //renders the answers to the users
                    ansOne.Text = currentTest.Answers[0];
                    ansTwo.Text = currentTest.Answers[1];
                    ansThree.Text = currentTest.Answers[2];
                    ansFour.Text = currentTest.Answers[3];
                }

            }

            helper.closeConn();

        }

        public string getAnswers()
        {

            string studAns = "";

            //checks if the student has selected the first answer
            if (selectAnswerOne.IsChecked == true)
            {

                studAns = ansOne.Text;

            }

            //checks if the student has selected the second answer
            else if (selectAnswerTwo.IsChecked == true)
            {

                studAns = ansTwo.Text;

            }

            //checks if the student has selected the third answer
            else if (selectAnswerThree.IsChecked == true)
            {

                studAns = ansThree.Text;

            }

            //checks if the student has selected the fourth answer
            else if (selectAnswerFour.IsChecked == true)
            {

                studAns = ansFour.Text;

            }

            return studAns;

        }

        public void clearSelectedAnswers()
        {

            selectAnswerOne.IsChecked = false;
            selectAnswerTwo.IsChecked = false;
            selectAnswerThree.IsChecked = false;
            selectAnswerFour.IsChecked = false;

        }
    }
}
