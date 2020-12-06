using AuthDLL;
using DBHelperDLL;
using System.Configuration;
using System.Windows;
using System.Windows.Input;

namespace Quizzly
{
    /// <summary>
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Window
    {

        //stores the connection string to the database
        string connString = ConfigurationManager.ConnectionStrings["QuizzlyDB"].ConnectionString;

        DBHelper helper = new DBHelper();

        public Register()
        {
            InitializeComponent();
        }

        private void BtnReg_Click(object sender, RoutedEventArgs e)
        {

            //checks if the username is empty
            if (tbUsername.Text.Equals(""))
            {

                validateUsername.IsOpen = true;

            }

            //checks if the first name is empty
            else if (tbFirstname.Text.Equals(""))
            {
                validateName.IsOpen = true;
            }

            //checks id the surname is empty
            else if (tbSurname.Text.Equals(""))
            {
                validateSurname.IsOpen = true;
            }

            //checks if the password is empty
            else if (tbPassword.Password.Equals(""))
            {

                validatePassword.IsOpen = true;

            }

            else
            {

                //gets a reference to the auth dll
                PilotAuth auth = new PilotAuth();

                //checks if the username exists already
                if (auth.checkUsername(helper.openConn(connString), tbUsername.Text, userType.Text))
                {

                    checkUsername.IsOpen = true;

                }

                else
                {
                    //registers user as a student
                    if (RegType.IsChecked == false)
                    {
                        auth.register(helper.openConn(connString), tbUsername.Text, tbPassword.Password, false);

                        auth.insertDetails(helper.openConn(connString),auth.getUserID(helper.openConn(connString), tbUsername.Text) ,tbFirstname.Text, tbSurname.Text, false);

                        clearControls();

                        regSuccess.IsOpen = true;

                    }

                    //registers user as a lecturer
                    else if (RegType.IsChecked == true)
                    {
                        auth.register(helper.openConn(connString), tbUsername.Text, tbPassword.Password, true);

                        auth.insertDetails(helper.openConn(connString), auth.getUserID(helper.openConn(connString), tbUsername.Text), tbFirstname.Text, tbSurname.Text, true);

                        clearControls();

                        regSuccess.IsOpen = true;
                    }

                    else
                    {

                        regError.IsOpen = true;

                    }
                }

                helper.closeConn();

            }

        }

        private void GoToLogin_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            Login login = new Login();

            login.Show();

            this.Close();
        }

        private void RegType_Click(object sender, RoutedEventArgs e)
        {

            //sets the user role for the user based on the toggle control
            if (RegType.IsChecked == true)
            {

                userType.Text = "Lecturer";

            }

            else if (RegType.IsChecked == false)
            {

                userType.Text = "Student";

            }

        }

        public void clearControls()
        {

            tbUsername.Text = "";
            tbFirstname.Text = "";
            tbSurname.Text = "";
            tbPassword.Password = null;
            RegType.IsChecked = false;
            userType.Text = "Student";

        }
    }
}
