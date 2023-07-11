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
    }
}
