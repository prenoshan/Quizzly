using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace TestDLL
{
    public class Test
    {

        //method to create a test
        public void createTest(SqlConnection conn, string name, int qCount)
        {

            //query to create a test in the database
            try
            {

                string q_CreateTest = "insert into test(name,qcount) values(@name,@qcount)";

                SqlCommand cmd = new SqlCommand(q_CreateTest,conn);

                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@qcount", qCount);

                cmd.ExecuteScalar();

            }

            catch(Exception e)
            {

                Debug.WriteLine(e);

            }

        }

        //method to get the question count for each test
        public int getQcount(SqlConnection conn, int testid, string name)
        {

            int qCount = 0;

            //query to get the question count for each test
            try
            {

                string q_GetCount = "select qcount from test where id = @testid";

                SqlCommand cmd = new SqlCommand(q_GetCount, conn);

                cmd.Parameters.AddWithValue("@testid", getTestID(conn,name));

                qCount = Convert.ToInt32(cmd.ExecuteScalar());

            }
            catch (Exception e)
            {

                Debug.WriteLine(e);
            }

            return qCount;

        }

        //method to insert the category that a lecturer sets for a test
        public void insertCategoryforTest(SqlConnection conn, string testName, string catName)
        {

            //query to insert a category for each test
            try
            {

                string q_InsertCat = "insert into test_category(testid, catid) values(@testid,@catid)";

                SqlCommand cmd = new SqlCommand(q_InsertCat, conn);

                cmd.Parameters.AddWithValue("@testid", getTestID(conn, testName));
                cmd.Parameters.AddWithValue("@catid", getCatID(conn, catName));

                cmd.ExecuteScalar();
            }

            catch (Exception e)
            {

                Debug.WriteLine(e);
            }

        }

        //method to get all the test categories
        public DataTable getTestCategories(SqlConnection conn)
        {

            DataTable dt = new DataTable();

            //query to get all categories available from the database
            try
            {
                string q_allTestCats = "select name from category";

                SqlCommand cmd = new SqlCommand(q_allTestCats, conn);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);


                sda.Fill(dt);

            }
            catch (Exception e)
            {

                Debug.WriteLine(e);
            }

            return dt;
        }

        //method to get the category id
        public int getCatID(SqlConnection conn, string name)
        {

            int categoryID = 0;

            //query to get the id of a category to be used in the system
            try
            {

                string q_GetCatID = "select id from category where name = @name";

                SqlCommand cmd = new SqlCommand(q_GetCatID, conn);

                cmd.Parameters.AddWithValue("@name", name);

                categoryID = Convert.ToInt32(cmd.ExecuteScalar());

            }

            catch (Exception e)
            {

                Debug.WriteLine(e);
            }

            return categoryID;
        }

        //method to get the test id
        public int getTestID(SqlConnection conn, string name)
        {

            int testID = 0;

            //query to select the id for a test to be used in the system
            try
            {

                string q_GetID = "select id from test where name = @name";

                SqlCommand cmd = new SqlCommand(q_GetID, conn);

                cmd.Parameters.AddWithValue("@name", name);

                testID = Convert.ToInt32(cmd.ExecuteScalar());


            }
            catch (Exception e)
            {

                Debug.WriteLine(e);
            }

            return testID;
        }

        //method to keep the test name unique
        public bool testNameExists(SqlConnection conn, string name)
        {

            bool nameExists = false;

            //query that checks if the test name entered already exists in the database
            try
            {

                int count;

                string q_CheckName = "select count(*) from test where name = @name";

                SqlCommand cmd = new SqlCommand(q_CheckName, conn);

                cmd.Parameters.AddWithValue("@name", name);

                count = Convert.ToInt32(cmd.ExecuteScalar());

                if(count > 0)
                {

                    nameExists = true;

                }

                else
                {
                    nameExists = false;
                }

            }

            catch (Exception e)
            {

                Debug.WriteLine(e);
            }


            return nameExists;
        }

    }
}
