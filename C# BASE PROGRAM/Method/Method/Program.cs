using System;

namespace Method
{
    class Program
    {
       static  void M1()
       {
            Console.WriteLine("HELLO");
       }

        static void M2(string name = "PREM")
        {
            Console.WriteLine(name);
        }
        static void M2(int name)
        {
            Console.WriteLine(name);
        }
        static void Main(string[] args)
        {
            M1();
            M1();
            M1();
            M2("NAME");
            M2();
            M2(10);


        }
    }
}
