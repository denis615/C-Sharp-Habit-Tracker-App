using System;
using System.IO;
using HabitTrackerApp.Services;
using HabitTrackerApp.Domains;
namespace HabitTrackerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string anyKey = "Press any Key to continue";

            Console.WriteLine("Welcome to the Habit Tracker App");



            Console.WriteLine("Press 1 to create a new Account");
            Console.WriteLine("Pres 2 to Log in to the already existing account");
            string firstChoosing = Console.ReadLine();

            while (true) { 

            if (UsernameServices.firstChoosingCheck(firstChoosing) == 1)
            {
                    User User1 = new User();
                    Console.WriteLine("Please Choose Your UserName");
                    string UserName = Console.ReadLine();
                   
                    if (UsernameServices.CheckUserNameLength(UserName) == false && UsernameServices.firstNumCheck(UserName)==false)
                    {
                        while (true)
                        {
                            User1.UserName = UserName;
                            Console.WriteLine("Please Enter your Name?");
                            string firstName = Console.ReadLine();
                            if (FirstName_Services.firstNameLengthCheck(firstName) == false)
                            {
                                if (FirstName_Services.IsDigit(firstName) == false)
                                { Console.Clear();
                                    User1.FirstName = firstName;
                                    Console.WriteLine("The name logged in successfully");
                                    Console.WriteLine(anyKey);
                                    Console.ReadLine();
                                    break;
                                }
                            }
                            if (FirstName_Services.firstNameLengthCheck(firstName) == true)
                            {
                                Console.Clear();
                                Console.WriteLine("The Name must be longer than two characters");
                                Console.WriteLine(anyKey);
                                Console.ReadLine();
                                continue;
                            }
                            if (FirstName_Services.IsDigit(firstName) == true)
                            {
                                Console.Clear();
                                Console.WriteLine("The name shouldn't include a number");
                                Console.WriteLine(anyKey);
                                Console.ReadLine();
                                continue;
                            }
                        }
                        while (true)
                        {
                            
                            Console.WriteLine("Please Enter your Last Name?");
                            string lastName = Console.ReadLine();
                            if (FirstName_Services.firstNameLengthCheck(lastName) == false)
                            {
                                if (FirstName_Services.IsDigit(lastName) == false)
                                {
                                    Console.Clear();
                                    User1.LastName = lastName;
                                    Console.WriteLine("The  Last name logged in successfully");
                                    Console.WriteLine(anyKey);
                                    Console.ReadLine();
                                    break;
                                }
                            }
                            if (FirstName_Services.firstNameLengthCheck(lastName) == true)
                            {
                                Console.Clear();
                                Console.WriteLine("The Name must be longer than two characters");
                                Console.WriteLine(anyKey);
                                Console.ReadLine();
                                continue;
                            }
                            if (FirstName_Services.IsDigit(lastName) == true)
                            {
                                Console.Clear();
                                Console.WriteLine("The name shouldn't include a number");
                                Console.WriteLine(anyKey);
                                Console.ReadLine();
                                continue;
                            }
                        }
                        while (true) { 
                        Console.WriteLine("Please Enter your Password");
                        string userPassword = Console.ReadLine();
                            if (Password_Services.PasswordLength(userPassword) == true && Password_Services.PasswordDigit(userPassword) == true)
                            {
                                Console.Clear();
                                User1.Password = userPassword;
                                Console.WriteLine("Password Logged Successfully");
                                Console.WriteLine(anyKey);
                                Console.ReadLine();
                                break;
                            }
                            if (Password_Services.PasswordLength(userPassword) == false || Password_Services.PasswordDigit(userPassword) == false)
                            {
                                Console.Clear();
                                Console.WriteLine("Password Should be at least 6 characters long, and include one number");
                                Console.WriteLine(anyKey);
                                Console.ReadLine();
                                continue;
                            }


                        }

                        while (true)
                        {
                            Console.WriteLine("Please enter your Birthday in MM/DD/YYYY format");
                            string birthday = Console.ReadLine();


                            if (BirthdayServices.CalculAgeFormat(birthday) == false)
                            {
                                Console.Clear();
                                Console.WriteLine("Please Follow the MM/DD/YYYY Format");
                                Console.WriteLine(anyKey);
                                Console.ReadLine();
                                continue;
                            }
                            else
                            {
                                 
                                if(BirthdayServices.RealAge(birthday)<5|| BirthdayServices.RealAge(birthday) > 120)
                                    { 
                                        Console.WriteLine($"Your Age is {BirthdayServices.RealAge(birthday)} and you are not allowed to use this app");
                                    Environment.Exit(0);
                                    }

                                else
                                {
                                    Console.Clear();
                                    DateTime userBirthday = DateTime.Parse(birthday);
                                    User1.DateOfBirth = userBirthday;
                                    Console.WriteLine("Your Birthday Has been logged Successfully");
                                }


                                
                                break;
                            }
                          
                          
                        }
                        Console.Clear();
                        Console.WriteLine("The Username with these information has been created:");
                        Console.WriteLine($"Name: {User1.FirstName}");
                        Console.WriteLine($"Last Name: {User1.LastName}");
                        Console.WriteLine($"UserName:  {User1.UserName}");
                        Console.WriteLine($"Date of Birth:  {User1.DateOfBirth}");
                        Console.WriteLine(anyKey);
                        Console.ReadLine();
                        break;
                    }

                    
                    if (UsernameServices.CheckUserNameLength(UserName)==true||UsernameServices.firstNumCheck(UserName)==true)
                    {
                        Console.WriteLine("The Username must be at least 6 characters Long and the First Character Shouldn't include a number.");
                        Console.WriteLine("Press Any Key To Continue");
                        Console.ReadLine();
                        continue;
                    }

                Console.WriteLine("Hello World");
                    break;
            }
            if (UsernameServices.firstChoosingCheck(firstChoosing) == 2)
            {
                Console.WriteLine("Hello ANd Log in");
                    break;
            }
            if (UsernameServices.firstChoosingCheck(firstChoosing) == -1)
            {
                    Console.WriteLine("Please choose Either 1 or 2 ");
                    Console.WriteLine("Press 1 to create a new Account");
                    Console.WriteLine("Pres 2 to Log in to the already existing account");
                    firstChoosing = Console.ReadLine();
                    continue;
                    
            }

            }

            
           

        }
           
           
           

        }
    }


