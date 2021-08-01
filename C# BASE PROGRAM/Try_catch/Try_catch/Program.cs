using System;

namespace Try_catch
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Console.WriteLine("Hello World!");
            try
            {
                string[] a = {"1", "2", "3", "4", "5", "6", "7", "8", "9","10"};
                Console.WriteLine(a[9]);
                Console.WriteLine(a[10]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
