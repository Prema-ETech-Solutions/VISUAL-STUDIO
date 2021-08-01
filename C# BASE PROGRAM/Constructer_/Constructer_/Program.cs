using System;

namespace Constructer_
{
    class Program
    {
        public static int value; //field
        public Program()
        {
            value = 10;
        }

        static void Main(string[] args) //property
        {
            Program obj = new Program();
            Console.WriteLine(value);
            P1 obji = new P1();
            Console.WriteLine(obji.v1);
        }
    }
    class P1
    {
        public  int v1;
        public P1(int a =10)
        {
           
            v1 = a;
        }
    }
}
