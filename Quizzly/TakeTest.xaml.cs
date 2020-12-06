using DBHelperDLL;
using ResultAndMemoDLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics;
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
    /// Interaction logic for TakeTest.xaml
    /// </summary>
    public partial class TakeTest : UserControl
    {

        //stores the connection string to the database
        string connString = ConfigurationManager.ConnectionStrings["QuizzlyDB"].ConnectionString;

        //stores the dll references 
        DBHelper helper = new DBHelper();

        Test test = new Test();

        ResultAndMemo resultAndMemo = new ResultAndMemo();

        TestTaking testTaking = new TestTaking();

        public static string testName; 

        public TakeTest()
        {
            InitializeComponent();

            //populates the test categories available
            foreach (DataRow row in test.getTestCategories(helper.openConn(connString)).Rows)
            {

                availableCategories.Items.Add(row[0].ToString());

            }

            helper.closeConn();
        }

        private void AvailableCategories_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            //gets the test category that is selected
            string selectedItem = (sender as ComboBox).SelectedValue.ToString();

            TestTaking testTaking = new TestTaking();

            List<string> tests = new List<string>();

            //populates the tests list with all tests available for each category
            foreach (DataRow row in testTaking.getTests(helper.openConn(connString), selectedItem).Rows)
            {

                tests.Add((row[0].ToString()));

            }

            if (availableTests.ItemsSource == null)
            {
                availableTests.Items.Clear();
            }

            availableTests.ItemsSource = tests;

            availableTests.SelectedIndex = 0;

            //checks if there is no tests available for each category
            if (availableTests.Items.Count == 0)
            {

                availableTests.ItemsSource = null;

                availableTests.Items.Add("No test available for selected category");

                btnTakeTest.IsEnabled = false;

            }

            else
            {
                btnTakeTest.IsEnabled = true;
            }

            helper.closeConn();

        }

        private void BtnTakeTest_Click(object sender, RoutedEventArgs e)
        {

            testName = availableTests.SelectedValue.ToString();

            //stores a reference to the student screen window
            StudentScreen studentScreen = (StudentScreen)Window.GetWindow(this);

            if(testTaking.isTestTaken(helper.openConn(connString), test.getTestID(helper.openConn(connString), testName), resultAndMemo.getStudID(helper.openConn(connString), StudentScreen.username)) == true)
            {

                validateTestTaken.IsOpen = true;

            }

            else
            {

                studentScreen.clearContent();

                TestArea testArea = new TestArea();

                studentScreen.btnTakeTest.IsEnabled = false;
                studentScreen.btnViewMarks.IsEnabled = false;
                studentScreen.btnViewMemos.IsEnabled = false;
                studentScreen.btnLogOut.IsEnabled = false;
                studentScreen.btnWebsite.IsEnabled = false;

                //adds the test area user control to the student screen
                studentScreen.addContent(testArea);
            }

        }
    }
}
