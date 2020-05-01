using System;
using System.Collections.Generic;
using System.Text;
using HabitTrackerApp;
namespace HabitTrackerApp.Services
{
   public class UsernameServices
    {   public static bool CheckUserNameLength(string user)
        {

            if (user.Length < 6)
            {
                return true;
            }
            else
            {
                return false;
            }




        }

        public static bool firstNumCheck(string user)

           
        {
            int i;
            char[] characters = user.ToCharArray();
            string firstLetter = characters[0].ToString();
            bool isItNumber = int.TryParse(firstLetter, out i);

            if (isItNumber == true)
            {
                return true;
            }
            else
            {
                return false;
            }
           

        }

        public static int   firstChoosingCheck( string choose)
        {
            if (choose == "1")
            {
                return 1;
            }
            if (choose == "2")
            {
                return 2;
            }
            else
            {
                
                return -1;
                
            }
        }
        
    }
}
