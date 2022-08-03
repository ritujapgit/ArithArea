using System;
using System.Collections.Generic;
using System.Text;

namespace ArithArea.Topic1_CLR_DATATYPES_
{
    class Leapyear
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the year:");
            int yr = int.Parse(Console.ReadLine());
            if(yr%4==0)
            {
                Console.WriteLine(yr + " is Leap Year.");
            }
            else
            {
                Console.WriteLine(yr + " is not Leap year.");
            }
        }
    }
}
