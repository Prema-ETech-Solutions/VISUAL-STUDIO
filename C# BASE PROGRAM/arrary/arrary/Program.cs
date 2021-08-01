using System;

namespace arrary
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] c1 = { "z", "g", "f" };
            Console.WriteLine(c1[2]);
            c1[2] = "cd";
            Array.Sort(c1);
            foreach (String i in c1 )
            {
                Console.WriteLine(i);
            }

        }
    }
}
