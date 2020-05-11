using System;
using System.Collections.Generic;
using System.Text;

namespace HabitTrackerApp.Console_Methods
{
     public class ConsoleMethods
    {

        //Method to return Green Color if the check has passed Successfully
        public  static void GreenColor(string property,string anyKey)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"The {property} has been logged in Successfully");
            Console.ResetColor();
            Console.WriteLine(anyKey);
            Console.ReadLine();
            Console.Clear();
        }


        //Method make Console Red Color if the check has not passed
        public static void RedColor(string property,string anyKey)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(property);
            Console.ResetColor();
            Console.WriteLine(anyKey);
            Console.ReadLine();
            Console.Clear();
        }

    }
}
