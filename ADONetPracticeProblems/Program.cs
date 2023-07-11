namespace ADONetPracticeProblems
{
    class Program
    {
        public static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Choose Option to Perform Operation\n1.Create DataBase\n2.Exit");
                int option=Convert.ToInt32(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        CustomerDetails.CreateDataBase();
                        break;
                        case 2:
                        flag = false;
                        break;
                }
            }
        }
    }
}