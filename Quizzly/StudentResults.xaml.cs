using DBHelperDLL;
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
using TestDLL;

namespace Quizzly
{
    /// <summary>
    /// Interaction logic for StudentResults.xaml
    /// </summary>
    public partial class StudentResults : UserControl
    {

        //gets the connection string to the database
        string connString = ConfigurationManager.ConnectionStrings["QuizzlyDB"].ConnectionString;

        //gets the reference to the dlls
        DBHelper helper = new DBHelper();

        Test test = new Test();

        ResultAndMemo resultAndMemo = new ResultAndMemo();

        //list to store the test names for each student
        List<string> testNames = new List<string>();

        public StudentResults()
        {
            InitializeComponent();

           //populates the combo box with tests that students have completed
           foreach(DataRow row in resultAndMemo.getTestNames(helper.openConn(connString), resultAndMemo.getStudID(helper.openConn(connString), StudentScreen.username)).Rows)
            {

                testNames.Add(row[0].ToString());

            }

            testsTaken.ItemsSource = testNames;

            if(testsTaken.Items.Count == 0)
            {

                testsTaken.ItemsSource = null;

                testsTaken.Items.Add("You haven't taken a test yet");

            }

            helper.closeConn();

        }

        private void BtnViewResults_Click(object sender, RoutedEventArgs e)
        {

            //stores the result for the student's test
            int result = resultAndMemo.getResult(helper.openConn(connString), resultAndMemo.getStudID(helper.openConn(connString), StudentScreen.username), test.getTestID(helper.openConn(connString), testsTaken.SelectedValue.ToString()));

            //stores the question count of the test 
            int testQCount = test.getQcount(helper.openConn(connString), test.getTestID(helper.openConn(connString), testsTaken.SelectedValue.ToString()), testsTaken.SelectedValue.ToString());

            //stores the percentage that the student got for the test
            double percentage = ((double)result / testQCount) * 100;

            //displays the result and percentage to the user
            tbResult.Text = "Your mark for " + testsTaken.SelectedValue.ToString() + " is " + result + " / " + test.getQcount(helper.openConn(connString), test.getTestID(helper.openConn(connString), testsTaken.SelectedValue.ToString()), testsTaken.SelectedValue.ToString());
            tbPercentage.Text = "Your percentage for " + testsTaken.SelectedValue.ToString() + " is " + Math.Round(percentage, 2) + "%";

            helper.closeConn();

        }
    }
}
