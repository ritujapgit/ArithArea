using System;
using System.Collections.Generic;
using System.Text;

namespace ArithArea.nested
{
    class AgeifWeight
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the age :");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the weight");
            int wgh = int.Parse(Console.ReadLine());

            if (age > 18)
            {
                if (wgh > 50)
                {
                    Console.WriteLine("Person is eligible for blood donation.");
                }
                else
                {
                    Console.WriteLine("Wgh is nt correct.");
                }
            }
            else
            {
                Console.WriteLine("Person is not eligible for blood donation.");
            }
        } 

        }

    }

