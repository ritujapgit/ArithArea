using System;
using System.Collections.Generic;
using System.Text;

namespace ArithArea.Patterns
{
    class Pattern_8
    {
        static void Main(string[]args)
        {
            for(int r = 4;r>=1;r--)
            {
                for(int c=1;c<=r;c++)
                {
                    Console.WriteLine("*");
                }
                Console.Write(" ");
            }
        }
    }
}
