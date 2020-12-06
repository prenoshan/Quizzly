using System;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;

namespace DBHelperDLL
{
    public class DBHelper
    {

        public SqlConnection conn;

        //method to open the connection to the database
        public SqlConnection openConn(string connString)
        {

            try
            {

                conn = new SqlConnection(connString);

                conn.Open();

            }

            catch (Exception e)
            {

                Debug.WriteLine(e);
            }

            return conn;

        }

        //method to close the connection to the database
        public void closeConn()
        {

            try
            {

                conn.Close();

            }

            catch (Exception e)
            {

                Debug.WriteLine(e);
            }

        }

        //method to create the database
        public void createDB()
        {

            //query to create the database on the host's computer's installation of sql server if the database does not exist
            try
            {
                string q_CreateDB = "if not exists (select * from master.sys.databases where name = 'Usr18005753ZengageDB') create database Usr18005753ZengageDB;";

                SqlCommand cmd = new SqlCommand(q_CreateDB, conn);

                cmd.ExecuteScalar();

            }
            catch (Exception e)
            {

                Debug.WriteLine(e);
            }

        }

        //method to create the schema for the database
        public void createSchema(SqlConnection conn)
        {

            //query to create the database schema after it has been created
            try
            {
                string schemaScript = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "/DBScripts/quizzlyScript.sql");

                SqlCommand cmd = new SqlCommand(schemaScript, conn);

                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {

                Debug.WriteLine(e);
            }

        }

        //method to create the stored procedures for the database
        public void createSprocs(SqlConnection conn)
        {

            //query that loops through all the stored procedure scripts and executes them into the database
            try
            {
                for (int i = 1; i < 6; i++)
                {

                    string sprocScript = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "/DBScripts/sproc" + i + ".sql");

                    SqlCommand cmd = new SqlCommand(sprocScript, conn);

                    cmd.ExecuteNonQuery();

                }
            }
            catch (Exception e)
            {

                Debug.WriteLine(e);
            }

        }

    }
}
