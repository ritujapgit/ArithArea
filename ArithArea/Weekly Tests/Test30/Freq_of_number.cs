using System;
using System.Collections.Generic;
using System.Text;

namespace ArithArea.Weekly_Tests.Test30
{
    class Freq_of_number
    {
        public static void Main(string[]args)
        {
            int count = 0;
            Console.WriteLine("Enter the number :");
            int n=int.Parse(Console.ReadLine());
            while(n>0)
            {
                n = n / 10;
                count++;
            }
            Console.WriteLine("Frequency of digit is :" + count);
        }

    }
}
