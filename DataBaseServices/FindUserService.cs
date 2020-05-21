using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;



namespace DataBaseServices
{
     public class  FindUserService
    {
        public static bool FindUserinDatabaseCheckPassword(string getUser, string password)
        {
           
            try
            {

                StreamReader databaseReader = new StreamReader($"{getUser}.txt");

                string UserInfo = databaseReader.ReadToEnd();

                

                if (UserInfo.Contains(getUser)==true && UserInfo.Contains(password)==true)
                {
                    Console.WriteLine("The User has been logged in Successfully");
                    
                }
                
                if (UserInfo.Contains(getUser)==true && UserInfo.Contains(password)==false)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wrong Username, or Password");
                    Console.ResetColor();
                    Console.WriteLine("Press Any Key to Continue");
                    Console.ReadKey();
                    return false;
                }

                return true;
                }


            catch (Exception ex)
            {
                
                    Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("That User Has not been found in Database");
                Console.WriteLine("Press Any Key to Continue");
                Console.ResetColor();
                Console.ReadLine();
                Console.Clear();
                   
                
                return false;
                
            }


        }


        }

       
        }
    
