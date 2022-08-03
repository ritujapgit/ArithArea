using System;
using System.Collections.Generic;
using System.Text;

namespace ArithArea.forLoop
{
    class Table
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Enter Number :");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("The table of" + n);
            int i;
            for(i=1;i<=10;i++)
            {
                Console.WriteLine(n * i);
            }
        }
    }
}
