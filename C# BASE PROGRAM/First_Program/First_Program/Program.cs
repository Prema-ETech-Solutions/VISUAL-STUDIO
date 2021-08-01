/* 
 --This is is a Block / Multi-line Comment
 */
// This is a single line Comment

using System; // This is predefined namespace in library 

namespace First_Program // This is a namespace we created
{
    class Program // class we created in our namespace  
    { 
        static void Main(string[] args) // main function
        {
           Console.WriteLine("Hello World! 1");// Use to print the output on console
           Console.WriteLine("Hello World!2");
            Console.Write("Hello World!3");
            Console.Write("Hello World!4");

        }
    }
}
/*
 * NOTE :-
 * The curly braces {} is use denote the block of the Function / Class / namespace /etc .
 * Statement ends with a semicolon ; .
 * In the case you omit the using System line, Then you have to write ["System.Console.Writeline()"] to print any thing on the console.
 * Console is a class of the [System namespace], which has a [WriteLine()] method that is used to output/print text.
 */
