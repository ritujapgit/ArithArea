using System;
using System.Collections.Generic;
using System.Text;

namespace ArithArea.Weekly_Tests.Test30
{
    class KaprekarNo
    {
        public static void Main(string[]args)
        {
            Console.WriteLine("Enter the number :");
            int n = int.Parse(Console.ReadLine());
            int sq = n * n;
            int rem = n / 100;
            int n1 = rem;
            rem = n % 100;
            int n2 = rem;
            int sum = n1 + n2;
            Console.WriteLine("square of n is " + sq + " addition of two each digits in square is " + sum);
        }
    }
}
