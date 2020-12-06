using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResultAndMemoDLL
{
    public class ResultAndMemo
    {

        //method to get the test names for the tests students have taken
        public DataTable getTestNames(SqlConnection conn, int id)
        {

            DataTable dt = new DataTable();

            //executes a stored procedure to get all test names of tests a student has taken
            try
            {

                string q_SelectTestsTaken = "exec sproc_GetTestNames @studid = @sid";

                SqlCommand cmd = new SqlCommand(q_SelectTestsTaken, conn);

                cmd.Parameters.AddWithValue("@sid", id);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                sda.Fill(dt);

            }
            catch (Exception e)
            {

                Debug.WriteLine(e);
            }

            return dt;

        }

        //method to get the result for the test a student requests
        public int getResult(SqlConnection conn, int studid, int testid)
        {

            int res = 0;

            //query to get the result for the tests students have done
            try
            {
                string q_GetRes = "select result from student_result where studid = @studid and testid = @testid";

                SqlCommand cmd = new SqlCommand(q_GetRes, conn);

                cmd.Parameters.AddWithValue("@studid", studid);
                cmd.Parameters.AddWithValue("@testid", testid);

                res = Convert.ToInt32(cmd.ExecuteScalar());

            }
            catch (Exception e)
            {

                Debug.WriteLine(e);
            }

            return res;
        }

        //method to get the student id
        public int getStudID(SqlConnection conn, string name)
        {

            int id = 0;

            //query to get the students id so it can be used by the system
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

        //method to get the memo of the test a student requests
        public DataTable getMemo(SqlConnection conn, int testid, int studid)
        {

            DataTable dt = new DataTable();

            //query to return a datatable of the memo for a test that a student chooses
            try
            {
                string q_GetMemo = "exec sproc_Memo @testid = @tid, @studid = @sid";

                SqlCommand cmd = new SqlCommand(q_GetMemo, conn);

                cmd.Parameters.AddWithValue("@tid", testid);
                cmd.Parameters.AddWithValue("@sid", studid);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                sda.Fill(dt);

            }
            catch (Exception e)
            {

                Debug.WriteLine(e);
                
            }

            return dt;

        }

    }
}
