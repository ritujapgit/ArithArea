using System;
using System.Collections.Generic;
using System.Text;

namespace ArithArea.Conditional
{
    class Divisible5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            if(num%5==0)
            {
                Console.WriteLine(num+ "is divisible by 5");
            }
            else
            {
                Console.WriteLine(num + "is not divisible by 5");
            }
        }
    }
}
