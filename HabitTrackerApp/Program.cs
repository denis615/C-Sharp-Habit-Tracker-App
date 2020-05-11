﻿using System;
using System.IO;
using HabitTrackerApp.Services;
using HabitTrackerApp.Domains;
using HabitTrackerApp.Console_Methods;
namespace HabitTrackerApp
{
    class Program
    {
        static void Main(string[] args)
        {   
            
            // A string which I needed to use a lot, so I declared it here in order to use it more down
            string anyKey = "Press any Key to continue";

        firstCheck:
            Console.Clear();
             Console.WriteLine("Welcome to the Habit Tracker App");


            
            Console.WriteLine("Press 1 to create a new Account");
            Console.WriteLine("Pres 2 to Log in to the already existing account");
            string firstChoosing = Console.ReadLine();
            #region CreateUser
            while (true) { 
                //If the User Decides to create a user
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
                            //Creating our Database
                            try
                            {
                                StreamWriter sw = File.CreateText($"{User1.UserName}.txt");
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e);
                                Console.WriteLine("That username already Exists please choose a different one");
                            }
                            ConsoleMethods.GreenColor("UserName", anyKey);
                            Console.WriteLine("Please Enter your Name?");
                            string firstName = Console.ReadLine();
                            if (FirstName_Services.firstNameLengthCheck(firstName) == false)
                            {
                                if (FirstName_Services.IsDigit(firstName) == false)
                                { Console.Clear();
                                    User1.FirstName = firstName;


                                    ConsoleMethods.GreenColor("Name", anyKey);
                                    break;
                                }
                            }
                            if (FirstName_Services.firstNameLengthCheck(firstName) == true)
                            {
                                string nameError = "The Name must be longer than two characters";
                                ConsoleMethods.RedColor(nameError, anyKey);
                                continue;
                            }
                            if (FirstName_Services.IsDigit(firstName) == true)
                            {
                                string isNumDigit = "The name shouldn't include a number";
                                ConsoleMethods.RedColor(isNumDigit, anyKey);
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
                                    ConsoleMethods.GreenColor("LastName", anyKey);
                                    break;
                                }
                            }
                            if (FirstName_Services.firstNameLengthCheck(lastName) == true)
                            {
                                string lastNameLenghtError = "The  Last Name must be longer than two characters";
                                ConsoleMethods.RedColor(lastNameLenghtError, anyKey);
                                continue;
                            }
                            if (FirstName_Services.IsDigit(lastName) == true)
                            {
                                string lastNameNumError = "The name shouldn't include a number";
                                ConsoleMethods.RedColor(lastNameNumError, anyKey);
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
                                ConsoleMethods.GreenColor("Password", anyKey);
                                break;
                            }
                            if (Password_Services.PasswordLength(userPassword) == false || Password_Services.PasswordDigit(userPassword) == false)
                            {
                                string passwordError = "Password Should be at least 6 characters long, and include one number";
                                ConsoleMethods.RedColor(passwordError, anyKey);
                                continue;
                            }


                        }

                        while (true)
                        {
                            Console.WriteLine("Please enter your Birthday in MM/DD/YYYY format");
                            string birthday = Console.ReadLine();


                            if (BirthdayServices.CalculAgeFormat(birthday) == false)
                            {
                                string birthDayError = "Please Follow the MM/DD/YYYY Format";
                                ConsoleMethods.RedColor(birthDayError, anyKey);
                                continue;
                            }
                            else
                            {
                                 
                                if(BirthdayServices.RealAge(birthday)<5|| BirthdayServices.RealAge(birthday) > 120)
                                    {
                                    Console.ForegroundColor = ConsoleColor.Red;    
                                        Console.WriteLine($"Your Age is {BirthdayServices.RealAge(birthday)} and you are not allowed to use this app");

                                    Console.ResetColor();
                                    Environment.Exit(0);
                                    }

                                else
                                {
                                    Console.Clear();
                                    DateTime userBirthday = DateTime.Parse(birthday);
                                    User1.DateOfBirth = userBirthday;
                                    ConsoleMethods.GreenColor("BirthDay", anyKey);
                                }


                                
                                break;
                            }
                          
                          
                        }
                        
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("The Username with these information has been created:");
                        Console.WriteLine($"Name: {User1.FirstName}");
                        Console.WriteLine($"Last Name: {User1.LastName}");
                        Console.WriteLine($"UserName:  {User1.UserName}");
                        Console.WriteLine($"Date of Birth:  {User1.DateOfBirth:MM/dd/yyyy}");
                        Console.WriteLine(anyKey);
                        Console.ResetColor();
                      
                       
                        Console.ReadLine();

                        
                        goto firstCheck;
                    }

                    
                    if (UsernameServices.CheckUserNameLength(UserName)==true||UsernameServices.firstNumCheck(UserName)==true)
                    {
                        string UsernameError = "The Username must be at least 6 characters Long and the First Character Shouldn't include a number.";
                        ConsoleMethods.RedColor(UsernameError, anyKey);
                        continue;
                    }

                
            }
            if (UsernameServices.firstChoosingCheck(firstChoosing) == 2)
            {
                Console.WriteLine("Hello ANd Log in");
                    break;
            }
            if (UsernameServices.firstChoosingCheck(firstChoosing) == -1)
            {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please choose Either 1 or 2 ");
                    Console.ResetColor();
                    Console.WriteLine("Press Any Key to Continue");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Press 1 to create a new Account");
                    Console.WriteLine("Pres 2 to Log in to the already existing account");
                    firstChoosing = Console.ReadLine();

                    continue;
                    
            }

            }

            #endregion


        }




    }
    }


