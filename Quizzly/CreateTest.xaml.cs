using TestDLL;
using System.Windows;
using System.Windows.Controls;
using System.Configuration;
using DBHelperDLL;
using System.Data;
using MaterialDesignThemes.Wpf;
using System;

namespace Quizzly
{
    /// <summary>
    /// Interaction logic for CreateTest.xaml
    /// </summary>
    public partial class CreateTest : UserControl
    {

        //stores the connection string to the database
        string connString = ConfigurationManager.ConnectionStrings["QuizzlyDB"].ConnectionString;

        DBHelper helper = new DBHelper();

        Test test = new Test();

        public static string testName;

        public CreateTest()
        {
            InitializeComponent();

            //populates the category combo box
            foreach (DataRow row in test.getTestCategories(helper.openConn(connString)).Rows)
            {

                testCategories.Items.Add(row[0].ToString());

            }

            helper.closeConn();
        }

        private void BtnCreateTest_Click(object sender, RoutedEventArgs e)
        {

            LecturerScreen lecturerScreen = (LecturerScreen)Window.GetWindow(this);

            //checks if no test name is set
            if (tbTestName.Text.Equals(""))
            {

                validateName.IsOpen = true;

            }

            //checks if no question number is set
            else if (tbTestQs.Text.Equals(""))
            {

                validateQuestionNumber.IsOpen = true;

            }


            //checks if the question number is an int
            else if(!int.TryParse(tbTestQs.Text, out int num))
            {

                validateQnumber.IsOpen = true;

            }

            //checks if the test name already exists
            else if(test.testNameExists(helper.openConn(connString),tbTestName.Text) == true)
            {

                nameExists.IsOpen = true;

            }

            else
            {

                //calls method from dll to create the test
                test.createTest(helper.openConn(connString), tbTestName.Text, Convert.ToInt32(tbTestQs.Text));

                test.getTestID(helper.openConn(connString), tbTestName.Text);

                test.getCatID(helper.openConn(connString), testCategories.SelectedValue.ToString());

                //calls method from dll to store the category for the test
                test.insertCategoryforTest(helper.openConn(connString), tbTestName.Text, testCategories.SelectedValue.ToString());

                helper.closeConn();

                testCreated.IsOpen = true;

                lecturerScreen.btnCreateTest.IsEnabled = false;
                lecturerScreen.btnLogOut.IsEnabled = false;
                lecturerScreen.btnWebsite.IsEnabled = false;

            }

        }

        private void BtnCreateSuccess_Click(object sender, RoutedEventArgs e)
        {

            //gets reference to the main lecturer screen
            LecturerScreen lecturerScreen = (LecturerScreen)Window.GetWindow(this);

            lecturerScreen.clearContent();

            testName = tbTestName.Text;

            NewTest newTest = new NewTest();

            //adds the new test user control to the lecturer screen
            lecturerScreen.addContent(newTest);

        }
    }
}
