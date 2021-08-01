using System;

namespace Math_
{
    class Program
    {
        public static int a = 10,b = 200;
        public static float f = -1000.5255f;

        

        static void Main(string[] args)
        {
            Console.WriteLine(Math.Max(b,a));
            Console.ReadLine();
            Console.WriteLine(Math.Min(b,a));
            Console.ReadLine();
            Console.WriteLine(Math.Abs(f));
            Console.ReadLine();
            Console.WriteLine(Math.Sqrt(b));
            Console.ReadLine();
            Console.WriteLine(Math.Round(f));
            


        }
    }
   
}
