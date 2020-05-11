using System;
using System.Collections.Generic;
using System.Text;

namespace HabitTrackerApp.Services
{
    class FirstName_Services
    {
        //Method to check the Length of the First Name and Last Name
        public static bool firstNameLengthCheck(string firstName)
        {
            
            if (firstName.Length < 2)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        //Method to check if there is a Digit inside the Name or Last Name
        public  static bool IsDigit(string firstName)
        {
            int j;
            char[] firstChar = firstName.ToCharArray();
            bool isANumber;
          for(int i = 0; i < firstChar.Length; i++)
            {
                string convertingToString = firstChar[i].ToString();

                isANumber = int.TryParse(convertingToString, out j);
                if (isANumber == true)
                {
                    return true;
                }
            }

            return false;

            
         
        }


    }
}
