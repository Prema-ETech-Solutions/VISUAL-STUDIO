using System;

namespace Switch__
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER A NUMBER (1-5) \n:");
            int v1 = (int)Convert.ToInt64(Console.ReadLine());
            switch (v1)
            {
                case 1:
                    {
                        Console.WriteLine("CASE 1{0} :",v1);
                        break; 
                    }
                case 2:
                    {
                        Console.WriteLine("CASE 2{0} :", v1);
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("CASE 3{0} :", v1);
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("CASE 4{0} :", v1);
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("CASE 5{0} :", v1);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("CASE Default {0} :", v1);
                        break;
                    }


            }
            Console.ReadLine();
        }
    }
}
