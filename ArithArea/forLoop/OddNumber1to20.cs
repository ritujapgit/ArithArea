using System;
using System.Collections.Generic;
using System.Text;

namespace ArithArea.forLoop
{
    class OddNumber1to20
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Odd Numbers between 1 to 20.");
            int i;
            for(i=1;i<=20;i++)
            {
                if(i%2!=0)
                    {
                    Console.WriteLine(i);
                    }
                
            }
                
        }
    }
}
