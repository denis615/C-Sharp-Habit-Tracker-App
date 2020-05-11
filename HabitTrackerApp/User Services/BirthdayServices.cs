using System;
using System.Collections.Generic;
using System.Text;

namespace HabitTrackerApp.Services
{
    class BirthdayServices
    {

        //Method to Calculate if the Format of the MM//DD/YYYY Is correct
       public static bool CalculAgeFormat(string birthday)
        {
            DateTime dob;

            bool isITOK = DateTime.TryParse(birthday, out dob);
            DateTime now = DateTime.Now;
           
            int age = now.Year - dob.Year;
            

            if (isITOK == true)
            {
                return true;
            }
            else
            {
                return false;
            }


        }

        //Method to calculcate the age of the user
        public static int RealAge(string birthday)
        {
            DateTime now = DateTime.Now;
            DateTime userBirthday = DateTime.Parse(birthday);

            int years = now.Year - userBirthday.Year;

            

            if (now.Month>userBirthday.Month)
            {
                 years--;
            }
            if (now.Month == userBirthday.Month && userBirthday.Day>now.Day)
            {
                 years--;
            }

            return years;
        }


        

    }
}
