using System;
using System.Collections.Generic;
using System.Text;

namespace ArithArea.nested
{
    class EvenOdd
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Enter the value :");
            int n = int.Parse(Console.ReadLine());
            if (n >= 2 && n <= 6)
            {
                if (n % 2 == 0)
                {
                    Console.WriteLine("Hello Even.");
                }
                else
                {
                    Console.WriteLine("Hello odd.");
                }
            }

            else if (n >= 5 && n <= 10)
            {
                if (n % 2 == 0)
                {
                    Console.WriteLine("Even.");
                }
                else
                {
                    Console.WriteLine("Odd Number.");
                }
            }
            }
        }
    }
