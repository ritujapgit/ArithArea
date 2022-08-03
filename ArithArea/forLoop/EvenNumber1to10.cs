using System;
using System.Collections.Generic;
using System.Text;

namespace ArithArea.forLoop
{
    class EvenNumber1to10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Even Numbers between 1 to 10.");
            int i;
            for (i = 1; i <= 20; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }

            }

        }
    }
}
