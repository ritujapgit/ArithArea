using System;
using System.Collections.Generic;
using System.Text;

namespace ArithArea.Patterns
{
    class Pattern4
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Enter the number of row");
            int row = int.Parse(Console.ReadLine());
           
            for(int i=1;i<=row;i++)
            {
                Console.Write(i);
                for(int j=1;j<=i;j++)
                {
                   
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
    }
}
