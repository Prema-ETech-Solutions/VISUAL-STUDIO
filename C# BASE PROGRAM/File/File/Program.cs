using System.IO;
using System;

namespace File_1
{ 
    
    class Program
    {
       
        static void Main(string[] args)
        {
            //FileStream F = new FileStream("test.dat", FileMode.OpenOrCreate,
             //FileAccess.ReadWrite);

            // Console.WriteLine("Hello World!");
            try
            {
                string writeText = "H";  // Create a text string
                File.WriteAllText("filename.txt", writeText);  // Create a file and write the contents of writeText to it

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

              

        }
    }
}
