using System;
using System.Data.SqlClient;
using System.Diagnostics;

namespace QandADLL
{
    public class QandA
    {

        //method to create the questions
        public void createQuestion(SqlConnection conn,string question)
        {

            //query to insert questions into the database
            try
            {
                string q_CreateQues = "insert into question(question) values(@question)";

                SqlCommand cmd = new SqlCommand(q_CreateQues, conn);
                
                cmd.Parameters.AddWithValue("@question", question);

                cmd.ExecuteScalar();
            }
            catch (Exception e)
            {

                Debug.WriteLine(e);
            }

        }

        //method to create the questions for the test
        public void testQuestionInsert(SqlConnection conn, int qNum, int testid)
        {

            //query to insert questions for the test a lecturer sets
            try
            {

                string q_Insert = "insert into test_questions(testid,questionid) values(@testid,@questionid)";


                SqlCommand cmd = new SqlCommand(q_Insert, conn);

                cmd.Parameters.AddWithValue("@testid", testid);
                cmd.Parameters.AddWithValue("@questionid",qNum);

                cmd.ExecuteScalar();

            }
            catch (Exception e)
            {

                Debug.WriteLine(e);
            }

        }

        //method to get the question id
        public int getQuestionID(SqlConnection conn, string question)
        {

            int qID = 0;

            //query to get the question id so it can be used by the database 
            try
            {
                string q_GetQID = "select id from question where question = @question";

                SqlCommand cmd = new SqlCommand(q_GetQID, conn);

                cmd.Parameters.AddWithValue("@question", question);

                qID = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception e)
            {

                Debug.WriteLine(e);
            }

            return qID;

        }

        //method to insert answers into the database
        public void insertAnswers(SqlConnection conn, int testid, int qid, string answer, string iscorrect)
        {

            //query to insert answers for a question in the database
            try
            {
                string q_InsertAns = "insert into answers(testid,questionid,answers,iscorrect) values(@testid,@questionid,@answer,@iscorrect)";

                SqlCommand cmd = new SqlCommand(q_InsertAns, conn);

                cmd.Parameters.AddWithValue("@testid", testid);
                cmd.Parameters.AddWithValue("@questionid", qid);
                cmd.Parameters.AddWithValue("@answer", answer);
                cmd.Parameters.AddWithValue("@iscorrect", iscorrect);

                cmd.ExecuteScalar();
            }
            catch (Exception e)
            {

                Debug.WriteLine(e);
            }

        }

        //method to store the answers a student records for each test
        public void storeStudentAnswers(SqlConnection conn, int testid, int studid ,int qid, string answer)
        {

            try
            {

                string q_StoreStudAns = "insert into student_answers(testid,studid,questionid,answer) values(@testid,@studid,@questionid,@answer)";

                SqlCommand cmd = new SqlCommand(q_StoreStudAns, conn);

                cmd.Parameters.AddWithValue("@testid", testid);
                cmd.Parameters.AddWithValue("@studid", studid);
                cmd.Parameters.AddWithValue("@questionid", qid);
                cmd.Parameters.AddWithValue("@answer", answer);

                cmd.ExecuteScalar();

            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
            }

        }
    }
}
