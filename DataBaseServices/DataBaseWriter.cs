using System;
using System.IO;

namespace DataBaseServices
{
    public  static class DataBaseWriter
    {
        public static void DataBaseWriting(StreamWriter sw, string password,DateTime Birthday, string FirstName,string LastName)
        {
           
            sw.WriteLine(password);
            sw.WriteLine(Birthday);
            sw.WriteLine(FirstName);
            sw.WriteLine(LastName);
            sw.Close();
        }
    }
}
