using System;
using System.Collections.Generic;
using System.Text;

namespace ArithArea.Conditional
{
    class Days
    {
        static void Main(string[]args)
        {
            Console.WriteLine("enter value of n :");
            int n = int.Parse(Console.ReadLine());
            if(n==1)
            {
                Console.WriteLine(n + " is Monday.");
            }
            else if(n==2)
            {
                Console.WriteLine(n + " is Tuesday.");
            }
            else if (n==3)
            {
                Console.WriteLine(n + " is Wednesday.");
            }
            else if (n==4)
            {
                Console.WriteLine(n + " is Thursday.");
            }
            else if (n==5)
            {
                Console.WriteLine(n + " is Friday.");
            }
            else if (n==6)
            {
                Console.WriteLine(n + " is Saturday.");
            }
            else if (n==7)
            {
                Console.WriteLine(n + " is Sunday.");
            }
            else
            {
                Console.WriteLine("Enter the valid number.");
            }




        }
    }
}
