﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ArithArea.Patterns
{
    class Pattern7
    {
        static void Main(string[]args)
        {
            for(int i=1;i<=5;i++)
            {
                for(int j=1;j<=5; j++)
                {
                    if (i == 3 || j == 3)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
