using System;
using System.Collections.Generic;
using System.Text;

namespace ArithArea.WhileLoop
{
    class PrimeNumber
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Enter the number :");
            int num = int.Parse(Console.ReadLine());
            bool isprime = true;
            int i = 2;
            while(i<num)
            {
                if(num%1==0)
                {
                    isprime = false;
                    break;
                }
                i++;
            }
            if(isprime==true)
            {
                if(num!=1)
                {
                    Console.WriteLine(num);
                }
            }
        }
    }
}
