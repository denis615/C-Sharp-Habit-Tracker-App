using System;
using System.Collections.Generic;
using System.Text;
using HabitTrackerApp;
namespace HabitTrackerApp.Services
{
   public class UsernameServices


        //Method to check if the length of the Username
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

        //Method to check if the First Character of the Username has a number
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

        //Method to check the first Choosing of the User when it runs the app
        public static int   firstChoosingCheck( string firstChoosing)
        {
            if (firstChoosing == "1")
            {
                return 1;
            }
            if (firstChoosing == "2")
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
