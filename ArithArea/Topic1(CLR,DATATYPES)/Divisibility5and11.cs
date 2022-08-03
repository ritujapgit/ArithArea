using System;
using System.Collections.Generic;
using System.Text;

namespace ArithArea.Topic1_CLR_DATATYPES_
{
    class Divisibility5and11
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Enter the Number :");
            int n = int.Parse(Console.ReadLine());
            if(n%5==0 && n%11==0)
            {
                Console.WriteLine(n + "is divisible by 5 and 11. ");
            }
            else if(n%5==0)
            {
                Console.WriteLine(n + " is only divisible by 5.");
            }
            else
            {
                Console.WriteLine(n + " is only divisible by 11.");
            }
        }
    }
}
