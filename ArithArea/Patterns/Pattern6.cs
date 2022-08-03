using System;
using System.Collections.Generic;
using System.Text;

namespace ArithArea.Patterns
{
    class Pattern6
    {
        static void Main(string[]args)
        {
           for(char i='A';i<='D';i++)
            {
                for(char j='A';j<='D';j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}
