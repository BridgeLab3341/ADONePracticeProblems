using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADONetPracticeProblems
{
    public class CustomerDetails
    {
        public static void CreateDataBase()
        {
            SqlConnection connection = new SqlConnection("data source=(localdb)\\MSSQLLocalDB; initial catalog=master; integrated security=true");
            try
            {
                string query = "Create Database ADONetPracticeProblems";
                SqlCommand command = new SqlCommand(query,connection);
                connection.Open();
                command.ExecuteNonQuery();
                Console.WriteLine("DataBase Created Successfully");
                Console.WriteLine("------------------------------");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something Went Wrong"+ex);
            }
            finally
            {
                connection.Close();
            }
        }
        public static SqlConnection connection = new SqlConnection("data source=(localdb)\\MSSQLLocalDB; initial catalog=ADONetPracticeProblems; integrated security=true");
        public static void CreateTable()
        {
            try
            {
                string query = "Create Table CustomerInformation(Id Int Identity(1,1)primary Key, Name varchar(25), City varchar(25),PhoneNumber varchar(10), Salary BigInt)";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                command.ExecuteNonQuery();
                Console.WriteLine("Table Created Successfully");
                Console.WriteLine("---------------------------");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something Went Wrong" + ex);
            }
            finally
            {
                connection.Close();
            }
        }
        public static void InsertData()
        {
            try
            {
                string query = "Insert into CustomerInformation values ('Somu','Banglore','8778567856',120000)";
                string query1 = "Insert into CustomerInformation values ('Anil','Banglore','6775445645',130000)";
                string query2 = "Insert into CustomerInformation values ('Kumar','Banglore','7867745655',110000)";

                SqlCommand command = new SqlCommand(query, connection);
                SqlCommand command1 = new SqlCommand(query1, connection);
                SqlCommand command2 = new SqlCommand(query2, connection);
                connection.Open();
                command.ExecuteNonQuery();
                command1.ExecuteNonQuery();
                command2.ExecuteNonQuery();

                Console.WriteLine("Inserted Data Successfully");
                Console.WriteLine("--------------------------");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something Went Wrong" + ex);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
