/*
 *  DATA TYPES & VARIABLES
 *   
 *   Data Types -- 
 *   1. int it hold 4 bytes and hold whole number
 *   2. long it hold 8 bytes and hold whole number
 *   3. float it hold 4 bytes and hold point number
 *   4. double it hold 8 bytes and hold point number
 *   5. bool it hold 1 bit and hold true/false 
 *   6. char it hold 1 byte and hold a letter
 *   7. string it hold 2 bytes per character and hold a sentence 
 *  
 *  VARIABLES -- 
 *  The general rules for constructing names for variables (unique identifiers) are:

    -Names can contain letters, digits and the underscore character (_)
    -Names must begin with a letter
    -Names should start with a lowercase letter and it cannot contain whitespace
    -Names are case sensitive ("myVar" and "myvar" are different variables)
    -Reserved words (like C# keywords, such as int or double) cannot be used as names
 *  
 *  Syntax -
     Datatype variableName = value ;
 */

using System;
 

namespace Second_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 10 , num1 = 20;
            float num_1 = 100.66f;
            double num_2 = 500.222D;
            long num_3 = 500000000L;
            string str = "C# ";
            string str2 = "HELLO ";
            char grade = 'A';

            Console.WriteLine("NUM 1"+num);
            Console.WriteLine(num_1);
            Console.WriteLine(num_2);
            Console.WriteLine(num_3);
            Console.WriteLine(str);
            Console.WriteLine(grade);
            Console.WriteLine(str + str2);
            //Console.WriteLine("Hello World!");
            Console.WriteLine(num + num1);
           
        }
    }
}
