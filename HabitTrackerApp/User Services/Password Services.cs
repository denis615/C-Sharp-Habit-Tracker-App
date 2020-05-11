using System;
using System.Collections.Generic;
using System.Text;

namespace HabitTrackerApp.Services
{
    class Password_Services
    {

        //Method to check the length of the Password
        public static bool PasswordLength(string password)
        {
            if (password.Length < 6)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        //Method to check if there is  number in the password
        public static bool PasswordDigit(string password)
        {
            int j;
            char[] firstChar = password.ToCharArray();
            bool isANumber;
            for (int i = 0; i < firstChar.Length; i++)
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
