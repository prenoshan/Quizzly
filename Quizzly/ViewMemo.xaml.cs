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
    /// Interaction logic for ViewMemo.xaml
    /// </summary>
    public partial class ViewMemo : UserControl
    {

        //stores the connection string to the database
        string connString = ConfigurationManager.ConnectionStrings["QuizzlyDB"].ConnectionString;

        //stores the references to the dlls
        DBHelper helper = new DBHelper();

        Test test = new Test();

        ResultAndMemo resultAndMemo = new ResultAndMemo();

        //list to store the test names for test that a student has completed
        List<string> testNames = new List<string>();

        public ViewMemo()
        {
            InitializeComponent();

            //populates the tests list with all the tests a student has completed
            foreach (DataRow row in resultAndMemo.getTestNames(helper.openConn(connString), resultAndMemo.getStudID(helper.openConn(connString), StudentScreen.username)).Rows)
            {

                testNames.Add(row[0].ToString());

            }

            allTests.ItemsSource = testNames;

            //checks if a student has not completed a test
            if (allTests.Items.Count == 0)
            {

                allTests.ItemsSource = null;

                allTests.Items.Add("You haven't taken a test yet");

            }


            helper.closeConn();

        }

        private void BtnViewMemo_Click(object sender, RoutedEventArgs e)
        {

            //sets the item source for the data grid to the memo for the test a student has chosen
            dgMemo.ItemsSource = resultAndMemo.getMemo(helper.openConn(connString), test.getTestID(helper.openConn(connString), allTests.SelectedValue.ToString()), resultAndMemo.getStudID(helper.openConn(connString), StudentScreen.username)).DefaultView;

            //sets the column names for each column
            dgMemo.Columns[0].Header = "Questions";
            dgMemo.Columns[1].Header = "Correct Answers";
            dgMemo.Columns[2].Header = "Your Answers";

            helper.closeConn();

        }
    }
}
