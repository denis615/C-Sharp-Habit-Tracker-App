using System;
using System.Collections.Generic;
using System.Text;
using HabitTrackerApp;
using DataBaseServices;
namespace HabitTrackerApp.Domains
{
    public  class User
    {
        //User Class so that we can create users from here
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }



    }

}
