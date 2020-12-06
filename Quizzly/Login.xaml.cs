using AuthDLL;
using DBHelperDLL;
using System.Configuration;
using System.Windows;
using System.Windows.Input;

namespace Quizzly
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Login : Window
    {

        //stores the connection to the database
        string connString = ConfigurationManager.ConnectionStrings["QuizzlyDB"].ConnectionString;

        //stores the connection to the master database
        string connStringSqlServer = ConfigurationManager.ConnectionStrings["sqlServer"].ConnectionString;

        DBHelper helper = new DBHelper();

        public static string name;

        public Login()
        {
            InitializeComponent();

            //connects to the master database
            helper.openConn(connStringSqlServer);

            //creates the quiz database
            helper.createDB();

            //creates the schema for the database
            helper.createSchema(helper.openConn(connString));

            //creates the stored procedures for the database
            helper.createSprocs(helper.openConn(connString));

            helper.closeConn();

        }

        private void LoginType_Click(object sender, RoutedEventArgs e)
        {

            //method that sets the user type of the person logging in
            if (LoginType.IsChecked == true)
            {

                userType.Text = "Lecturer";

            }

            else if (LoginType.IsChecked == false)
            {

                userType.Text = "Student";

            }

        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {

            //checks if username is empty
            if (tbUsername.Text.Equals(""))
            {

                validateUsername.IsOpen = true;

            }

            //checks if password is empty
            else if (tbPassword.Password.Equals(""))
            {

                validatePassword.IsOpen = true;

            }

            else
            {

                //gets reference to the auth dll
                PilotAuth auth = new PilotAuth();

                //checks if there is no user that exists for the username and password
                if (auth.login(helper.openConn(connString), tbUsername.Text, tbPassword.Password).Equals(null))
                {

                    validateLogin.IsOpen = true;

                }

                //redirects to lecturer screen if the user is a lecturer
                else if (LoginType.IsChecked == true && auth.login(helper.openConn(connString), tbUsername.Text, tbPassword.Password).Equals("Lecturer"))
                {

                    name = auth.getName(helper.openConn(connString), auth.getUserID(helper.openConn(connString), tbUsername.Text), true);

                    LecturerScreen lecturerScreen = new LecturerScreen();

                    lecturerScreen.Show();

                    this.Close();

                }

                //redirects to the student screen if the user is a student
                else if (LoginType.IsChecked == false && auth.login(helper.openConn(connString), tbUsername.Text, tbPassword.Password).Equals("Student"))
                {

                    name = auth.getName(helper.openConn(connString), auth.getUserID(helper.openConn(connString), tbUsername.Text), false);

                    StudentScreen studentScreen = new StudentScreen();

                    studentScreen.Show();

                    this.Close();

                }

                else
                {

                    validateLogin.IsOpen = true;

                }

                helper.closeConn();

            }
        }

        private void GoToReg_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            Register register = new Register();

            register.Show();

            this.Close();
        }
    }
}
