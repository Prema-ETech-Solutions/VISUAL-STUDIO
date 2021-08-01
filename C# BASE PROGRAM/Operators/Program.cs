//Operators are used to perform operations on variables and values.
using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int ans, v1, v2;
            Console.Write("ENTER A VALUE - ");
             v1 = Convert.ToInt32(Console.ReadLine());//  Taking input in interger
            Console.Write("ENTER A VALUE - ");
             v2 = Convert.ToInt32(Console.ReadLine());//  Taking input in interger
            
            Console.WriteLine("Arithmetic Operators\n\n");
            
            Console.WriteLine("'+' is use to add the values");
            Console.WriteLine("V1 + V2 = ?");
            Console.WriteLine(v1+"+"+v2+"="+(v1+v2));
            ans = v1 + v2;
            Console.WriteLine(v1 + "+" + v2 + "=" +ans+"\n\n");

            Console.WriteLine("'-' is use to subtracts the values");
            Console.WriteLine("V1 - V2 = ?");
            Console.WriteLine(v1 + "-" + v2 + "=" + (v1 - v2));
            ans = v1 - v2;
            Console.WriteLine(v1 + "-" + v2 + "=" + ans+"\n\n");

            Console.WriteLine("'*' is use to multiplies the values");
            Console.WriteLine("V1 * V2 = ?");
            Console.WriteLine(v1 + "*" + v2 + "=" + (v1 * v2));
            ans = v1 * v2;
            Console.WriteLine(v1 + "*" + v2 + "=" + ans + "\n\n");

            Console.WriteLine("'/' is use to divides the values");
            Console.WriteLine("V1 / V2 = ?");
            Console.WriteLine(v1 + "/" + v2 + "=" + (v1 / v2));
            ans = v1 / v2;
            Console.WriteLine(v1 + "/" + v2 + "=" + ans + "\n\n");

            Console.WriteLine("'%' is use to returns the values division remainder");
            Console.WriteLine("V1 % V2 = ?");
            Console.WriteLine(v1 + "%" + v2 + "=" + (v1 % v2));
            ans = v1 % v2;
            Console.WriteLine(v1 + "%" + v2 + "=" + ans + "\n\n");

            Console.WriteLine("'++' is use to increases the value of a variable by 1 ");
            Console.WriteLine("v1++ = " + v1++ + "\n\n");

            Console.WriteLine("'--' is use to decreases the value of a variable by 1 ");
            Console.WriteLine("v1-- = " + v1-- + "\n\n");


            
            Console.WriteLine("Assignment Operators / Shorthand Operators \n\n");
            //Assignment operators are used to assign values to variables.
            


            Console.WriteLine("'=' is use to assign the value to a variables");
            Console.WriteLine("v1 = 10");
            v1 = 10; v2 = 20;
            Console.WriteLine(" Value of v1 and v2 is  "+ v1 + v2 + " \n\n");


            Console.WriteLine("'+=' is use to add the two value and assign the value to a variables");
            Console.WriteLine("v1+=v2 / v1 = v1 + v2");
            v1 += v2;
            Console.WriteLine("Now the value of v1 and v2 is added and the answer is assign to v1 = "+v1+" \n\n");
            v1 = 20; v2 = 20;


            Console.WriteLine("'-=' is use to subtraction the two value and assign the value to a variables");
            Console.WriteLine("v1-=v2 / v1 = v1 - v2");
            v1 -= v2;
            Console.WriteLine("Now the value of v1 and v2 is subtraction and the answer is assign to v1 = " + v1 + " \n\n");
            v1 = 20; v2 = 20;

            Console.WriteLine("'*=' is use to multiplication the two value and assign the value to a variables");
            Console.WriteLine("v1*=v2 / v1 = v1 * v2");
            v1 *= v2;
            Console.WriteLine("Now the value of v1 and v2 is multiplication	and the answer is assign to v1 = " + v1 + " \n\n");
            v1 = 20; v2 = 20;


            Console.WriteLine("'/=' is use to division the two value and assign the value to a variables");
            Console.WriteLine("v1/=v2 / v1 = v1 / v2");
            v1 /= v2;
            Console.WriteLine("Now the value of v1 and v2 is division and the answer is assign to v1 = " + v1 + " \n\n");
            v1 = 20; v2 = 20;

            Console.WriteLine("'%=' is use to modulus the two value and assign the value to a variables");
            Console.WriteLine("v1%=v2 / v1 = v1 % v2");
            v1 %= v2;
            Console.WriteLine("Now the value of v1 and v2 is Modulus and the answer is assign to v1 = " + v1 + " \n\n");
            v1 = 20; v2 = 20;



        }
    }
}
 // x = 5&3
 // x = 5>>3
 

 

