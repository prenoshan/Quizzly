using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeTestDLL
{
    public class TestTaking
    {

        //method to get the tests set by lecturers
        public DataTable getTests(SqlConnection conn, string category)
        {

            DataTable dt = new DataTable();

            //executes a stored procedure that gets all tests set by a lecturer
            try
            {
                string q_GetTests = "exec sproc_getTests @category = @cat";

                SqlCommand cmd = new SqlCommand(q_GetTests, conn);

                cmd.Parameters.AddWithValue("@cat", category);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                sda.Fill(dt);

            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
            }

            return dt;
        }

        //method to get the questions for a test
        public DataTable getQuestions(SqlConnection conn, int testid)
        {
            DataTable dt = new DataTable();

            //executes a stored procedure that gets all the questions for a test
            try
            {

                string q_GetQs = "exec sproc_getQs @testid = @tid";

                SqlCommand cmd = new SqlCommand(q_GetQs, conn);

                cmd.Parameters.AddWithValue("@tid", testid);


                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                sda.Fill(dt);

            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
            }

            return dt;
        }

        //method to get all the answers for a test
        public DataTable getAnswers(SqlConnection conn, int questionID)
        {

            DataTable dt = new DataTable();

            //executes a stored procedure that gets all the answers for a question
            try
            {

                string q_GetAns = "exec sproc_getAnswers @questionid = @qid;";

                SqlCommand cmd = new SqlCommand(q_GetAns, conn);

                cmd.Parameters.AddWithValue("@qid", questionID);


                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                sda.Fill(dt);

            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
            }

            return dt;

        }

        //method to get the correct answer for each question
        public string getCorrectAnswer(SqlConnection conn, int qid)
        {

            string correctAns = "";

            //query to get the correct answer for each question on a test
            try
            {
                string q_GetCorrectAns = "select answers from answers where questionid = @qid and isCorrect = 'true'";

                SqlCommand cmd = new SqlCommand(q_GetCorrectAns, conn);

                cmd.Parameters.AddWithValue("@qid", qid);

                correctAns = Convert.ToString(cmd.ExecuteScalar());

            }
            catch (Exception e)
            {

                Debug.WriteLine(e);
            }

            return correctAns;
        }

        //method to store the results for a student
        public void storeResults(SqlConnection conn, int studid, int testid, int res)
        {

            //query that stores the result a student gets for each test
            try
            {
                string q_InsertRes = "insert into student_result values(@studid,@testid,@res)";

                SqlCommand cmd = new SqlCommand(q_InsertRes, conn);

                cmd.Parameters.AddWithValue("@studid", studid);
                cmd.Parameters.AddWithValue("@testid", testid);
                cmd.Parameters.AddWithValue("@res", res);

                cmd.ExecuteScalar();

            }
            catch (Exception e)
            {

                Debug.WriteLine(e);
            }

        }

        //method to get the student id
        public int getStudID(SqlConnection conn, string name)
        {

            int id = 0;

            //query to get the student id to be used by the system
            try
            {

                string q_GetStudID = "select id from student where firstname = @name";

                SqlCommand cmd = new SqlCommand(q_GetStudID, conn);

                cmd.Parameters.AddWithValue("@name", name);

                id = Convert.ToInt32(cmd.ExecuteScalar());

            }
            catch (Exception e)
            {

                Debug.WriteLine(e);
            }

            return id;

        }

        //method to check if student has taken a test
        public bool isTestTaken(SqlConnection conn, int testid, int studid)
        {

            int testTakenCount;

            bool isTestTaken = false;

            //sql query to check if a student has taken a test
            try
            {

                string q_GetStudTestsTaken = "select count(*) from student_result where student_result.testid = @testid and student_result.studid = @studid";

                SqlCommand cmd = new SqlCommand(q_GetStudTestsTaken, conn);

                cmd.Parameters.AddWithValue("@testid", testid);
                cmd.Parameters.AddWithValue("@studid", studid);

                testTakenCount = Convert.ToInt32(cmd.ExecuteScalar());

                //checks if the test was taken by the student
                if(testTakenCount > 0)
                {

                    isTestTaken = true;

                }

                else
                {
                    isTestTaken = false;
                }

            }

            catch (Exception e)
            {
                Debug.WriteLine(e);
            }

            return isTestTaken;


        }

    }
}
