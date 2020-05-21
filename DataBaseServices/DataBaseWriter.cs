using System;
using System.IO;

namespace DataBaseServices
{
    public  static class DataBaseWriter
    {
        public static void DataBaseWriting(string Username, string password, DateTime Birthday, string FirstName, string LastName)
        {

            StreamWriter sw = File.CreateText($"{Username}.txt");
            sw.WriteLine(Username);
            sw.WriteLine(password);
            sw.WriteLine(Birthday);
            sw.WriteLine(FirstName);
            sw.WriteLine(LastName);
            sw.Close();
        }
    }
}
