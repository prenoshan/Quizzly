using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace Quizzly
{
    /// <summary>
    /// Interaction logic for StudentScreen.xaml
    /// </summary>
    public partial class StudentScreen : Window
    {

        public static string username;

        public StudentScreen()
        {
            InitializeComponent();

            username = Login.name;

            userName.Text = "Welcome " + username;

        }

        private void BtnTakeTest_Click(object sender, RoutedEventArgs e)
        {
            clearContent();

            TakeTest takeTest = new TakeTest();

            addContent(takeTest);

        }

        public void addContent(UserControl control)
        {

            mainArea.Children.Add(control);

        }

        public void clearContent()
        {

            mainArea.Children.Clear();

        }

        private void BtnViewMarks_Click(object sender, RoutedEventArgs e)
        {

            clearContent();

            StudentResults studentResults = new StudentResults();

            addContent(studentResults);

        }

        private void BtnViewMemos_Click(object sender, RoutedEventArgs e)
        {

            clearContent();

            ViewMemo viewMemo= new ViewMemo();

            addContent(viewMemo);

        }

        private void BtnLogOut_Click(object sender, RoutedEventArgs e)
        {

            Login login = new Login();

            login.Show();

            this.Close();

        }

        private void BtnWebsite_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("http://localhost:53150/html/LoginPage.aspx");
        }
    }
}
