namespace ADONetPracticeProblems
{
    class Program
    {
        public static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Choose Option to Perform Operation\n1.Create DataBase\n2.Create Customer Table\n3.Insert Data to Table\n4.Delete Customer\n5.Update Salary\n6.Exit");
                int option=Convert.ToInt32(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        CustomerDetails.CreateDataBase();
                        break;
                        case 2:
                            CustomerDetails.CreateTable();
                        break;
                        case 3:
                            CustomerDetails.InsertData();
                        break;
                        case 4:
                        CustomerDetails.DeleteCustomer();
                        break;
                        case 5:
                            CustomerDetails.UpdateCustomer();
                        break;
                        case 6:
                        flag = false;
                        break;
                }
            }
        }
    }
}