using System;

namespace String
{
    class Program
    {
        public static string value = "Hello World !!",value2 = "Hello Public";

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! {0}", value);
            Console.WriteLine(value.Length);
            Console.WriteLine(value.ToUpper());
            Console.WriteLine(value.ToLower());
            Console.WriteLine(value+value2);
            Console.WriteLine(string.Concat(value,value2));
            Console.WriteLine("First {1} Second {0}",value2,value);
            Console.WriteLine(value[1]);



        }
    }
}
