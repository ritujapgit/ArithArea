using System;
using System.Collections.Generic;
using System.Text;

namespace ArithArea.Patterns
{
    class Pattern5
    {
        static void Main(string[]args)
        {
            for(int i=1;i<=4;i++)
            {
                for(int j=4;j>=i;j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
