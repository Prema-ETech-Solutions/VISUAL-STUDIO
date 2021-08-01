using System;

namespace Inherentance
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            P2 obj = new P2();
            P2.M2();
            P2.M1();

        }
    }

    class P1
    {

        public static void M1()
        {
            Console.WriteLine("P1 / M1");
        }


    }
    class P2:P1
    {
        public static void M2()
        {
            Console.WriteLine("P2 / M2");
        }
    }

}
