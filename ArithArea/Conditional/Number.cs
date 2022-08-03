using System;
using System.Collections.Generic;
using System.Text;

namespace ArithArea.Conditional
{
    class Number
    {
        static void Main(string[]args)
        {
            Console.WriteLine("enter the number");
            int num = int.Parse(Console.ReadLine());
            if(num>0)
            {
                Console.WriteLine(num + "number is positive.");
            }
            else
            {
                Console.WriteLine(num + "number is negative.");
            }

        }
    }
}
