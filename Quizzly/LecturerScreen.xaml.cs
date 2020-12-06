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

    public partial class LecturerScreen : Window
    {

        public LecturerScreen()
        {
            InitializeComponent();

            tbUsername.Text = "Welcome " + Login.name;

        }

        private void BtnCreateTest_Click(object sender, RoutedEventArgs e)
        {
            
            CreateTest createTest = new CreateTest();

            mainArea.Children.Add(createTest);

        }

        public void addContent(UserControl control)
        {

            mainArea.Children.Add(control);

        }

        public void clearContent()
        {

            mainArea.Children.Clear();

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
