using System;

namespace LogInServices
{
    public class FindUser
    {
        public static void FindUserinDatabase()
        {


            while (true)
            {
                Console.Clear();
                Console.WriteLine("Please Enter your Username");

                string getUser = Console.ReadLine();



                try
                {
                    StreamReader sr = new StreamReader($"{getUser}.txt");
                    string line = sr.ReadToEnd();

                    Console.WriteLine(line);
                    break;
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("The User Has not been found in our DataBase");
                    Console.WriteLine(e.Message);
                    Console.ResetColor();
                    Console.WriteLine("Press Enter to Try Again");
                    Console.ReadLine();
                    continue;
                }





            }

        }
    }
}