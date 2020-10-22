using System;

namespace Inclass5_Assignment_N01458247
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int Num1, Num2;
            int Result;
            Console.WriteLine("please enter the Num 1"); 
            Num1 = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("please enter the Num 2"); 
            Num2 = Convert.ToInt32(Console.ReadLine()); 
            Result = Num1 + Num2; 
            Console.WriteLine("Sum of two Numbers:" + Num1 + " + " + Num2 +  " = " + Result.ToString()); 
            Console.ReadLine();
        }
    }
}
