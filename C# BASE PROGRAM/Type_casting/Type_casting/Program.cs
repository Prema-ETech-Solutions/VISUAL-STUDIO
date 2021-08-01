/*
 Implicit Casting (automatically) - converting a smaller type to a larger type size
  char -> int -> long -> float -> double
 Explicit Casting (manually) - converting a larger type to a smaller size type
  double -> float -> long -> int -> char
 
 */
using System;

namespace Type_casting
{
    class Type_cast
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TYPE_CASTING");
            
            Console.WriteLine("IMPLICIT CASTING");//Implicit casting is done automatically when passing a smaller size type to a larger size type
            
            int I1 = 10;
            
            double D1 = I1;// Automatic casting: int to double
            
            Console.WriteLine("INTERGER  = "+I1);
            
            Console.WriteLine("DOUBLE    = "+D1+"\n\n");
            
            Console.WriteLine("EXPLICIT CASTING");
            
            Double D2 = 1000.56;
            
            int I2 = (int)D2;// Manual casting: double to int
         
            Console.WriteLine("DOUBLE   = "+D2);
            
            Console.WriteLine("INTERGER = "+I2+"\n\n");
            
            Console.WriteLine("TYPE CONVERSION METHODS");
           
            int I3 = 20;
            
            Double D3 = 5000.25;
            
            bool B1 = true;
            
            Console.WriteLine("INTERGER TO STRING   ="+Convert.ToString(I3));// convert int to string
            
            Console.WriteLine("INTERGER TO DOUBLE   ="+Convert.ToDouble(I3));// convert int to double
            
            Console.WriteLine("DOUBLE   TO INTERGER ="+Convert.ToInt32(D3));// convert double to int
            
            Console.WriteLine("BOOL     TO STRING   ="+Convert.ToString(B1));// convert bool to string
            
            // Link for all convert function https://drive.google.com/open?id=1bB4p3Mgh9LqxpS87cY1et8lbB5wkwOcf
        }
    }
}
