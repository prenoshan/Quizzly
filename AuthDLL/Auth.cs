using System;
using System.Data.SqlClient;
using System.Diagnostics;

namespace AuthDLL
{
    public class PilotAuth
    {

        //method to authenticate and login users
        public string login(SqlConnection conn, string username, string password)
        {

            //variable to hold the user role
            string userRole = "";


            //query to retrieve the user role of users based on their username and password
            //if userrole is null then user doesn't exist
            try
            {

                string q_Login = "select userroles from userinfo where usernames = @username and passwords = @password";

                SqlCommand cmd = new SqlCommand(q_Login, conn);

                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                userRole = Convert.ToString(cmd.ExecuteScalar());


            }
            catch (Exception e)
            {

                Debug.WriteLine(e);

            }

            return userRole;
        }

        //method to register users to the database
        public void register(SqlConnection conn, string username, string password, bool role)
        {


            //query to insert a new user into the database
            try
            {

                string q_Register = "insert into userinfo(usernames,passwords,userroles) values(@username,@password,@userrole)";

                SqlCommand cmd = new SqlCommand(q_Register, conn);

                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                if (role == false)
                {
                    cmd.Parameters.AddWithValue("@userrole", "Student");
                }

                else if (role == true)
                {

                    cmd.Parameters.AddWithValue("@userrole", "Lecturer");

                }

                cmd.ExecuteScalar();


            }

            catch (Exception e)
            {
                Debug.WriteLine(e);
            }

        }

        //method to get the user id
        public int getUserID(SqlConnection conn, string username)
        {

            int userID = 0;

            //query to get the user id of the user logged in so it can be used by the system
            try
            {

                string q_GetID = "select id from userinfo where usernames = @name";

                SqlCommand cmd = new SqlCommand(q_GetID, conn);

                cmd.Parameters.AddWithValue("@name", username);

                userID = Convert.ToInt32(cmd.ExecuteScalar());

            }
            catch (Exception e)
            {

                Debug.WriteLine(e);
            }

            return userID;

        }

        //method to insert user detail
        public void insertDetails(SqlConnection conn, int uid, string name, string surname, bool role)
        {


            //query to insert student and lecturer info into the db such as their name and surname
            try
            {
                string q_InsertStudDetails = "insert into student(userid,firstname,surname) values(@uid,@name,@surname)";

                string q_InsertLectDetails = "insert into lecturer(userid,firstname,surname) values(@uid,@name,@surname)";

                if (role == false)
                {

                    SqlCommand cmd = new SqlCommand(q_InsertStudDetails, conn);

                    cmd.Parameters.AddWithValue("@uid", uid);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@surname", surname);

                    cmd.ExecuteScalar();

                }

                else if (role == true)
                {


                    SqlCommand cmd = new SqlCommand(q_InsertLectDetails, conn);

                    cmd.Parameters.AddWithValue("@uid", uid);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@surname", surname);

                    cmd.ExecuteScalar();

                }
            }

            catch (Exception e)
            {

                Debug.WriteLine(e);
            }

        }

        //method to check if a username exists already
        public bool checkUsername(SqlConnection conn, string username, string userrole)
        {

            int count;

            bool userExists = false;

            //query to check if a username exists in the database
            //if a user exists the system will prompt them to enter a unique username
            try
            {
                string q_CheckUsername = "select count(*) from userinfo where usernames = @username and userroles = @userrole";

                SqlCommand cmd = new SqlCommand(q_CheckUsername, conn);

                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@userrole", userrole);

                count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count > 0)
                {
                    userExists = true;
                }

                else
                {

                    userExists = false;

                }
            }
            catch (Exception e)
            {

                Debug.WriteLine(e);
            }

            return userExists;
        }

        //mehtod to get the name of the user that logs in
        public string getName(SqlConnection conn, int id, bool role)
        {

            string name = "";

            string userrole;

            if(role == false)
            {
                userrole = "Student";
            }

            else
            {
                userrole = "Lecturer";
            }

            //query to get the name of the user that logs in so it can be used by the system
            try
            {
                string q_GetName = "select firstname from " + userrole + " where userid = @id";

                SqlCommand cmd = new SqlCommand(q_GetName, conn);

                cmd.Parameters.AddWithValue("@id", id);

                name = Convert.ToString(cmd.ExecuteScalar());

            }

            catch (Exception e)
            {

                Debug.WriteLine(e);
            }

            return name;

        }

    }
}
