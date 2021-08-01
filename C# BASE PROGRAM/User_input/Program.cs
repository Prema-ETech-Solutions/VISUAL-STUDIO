using System;

namespace User_input
{
    class User
    {
        static void Main(string[] args)
        {
            // Now we will use Console.ReadLine() to get user input.
            // The Default 
             Console.Write("ENTER YOUR FULL NAME -");
            String name = Console.ReadLine();
            Console.WriteLine("NAME - "+name+ "\n\n\n");

            //COVERT THE INPUT IN INTERGER 
            Console.Write("ENTER YOUR PHONE NUMBER -");
            int number = Convert.ToInt32(Console.ReadLine());// It is converting the input in interger
            Console.WriteLine("NUMBER - " +number+ "\n\n\n");

            Console.Write("ENTER YOUR PERCENTAGE -");
            Double per = Convert.ToDouble(Console.ReadLine());// It is converting the input in double
            Console.WriteLine("NUMBER - " + per + "\n\n\n");

             


        }
    }
}
