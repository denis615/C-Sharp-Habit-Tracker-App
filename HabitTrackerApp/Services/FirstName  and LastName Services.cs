using System;
using System.Collections.Generic;
using System.Text;

namespace HabitTrackerApp.Services
{
    class FirstName_Services
    {
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
