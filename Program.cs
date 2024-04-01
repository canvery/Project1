namespace Proj1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int LoginAttempts = 0;

            for (int i = 0; i < 3; i++)
            {

                Console.WriteLine("Username:");
                String UserId1 = Console.ReadLine();
                Console.WriteLine("Password:");
                String Pass = Console.ReadLine();

                String UserIdCorrect = "Admin";
                String PassCorrect = "Admin1234!";


                Console.ReadKey();

                if (UserId1 != UserIdCorrect && Pass != PassCorrect)
                    LoginAttempts++;
                else
                    break;
            }

            if (LoginAttempts > 2)
                Console.WriteLine("Login Failure");
            else
                Console.WriteLine("Login Successful");

            Console.ReadKey();
        }
    }
}
