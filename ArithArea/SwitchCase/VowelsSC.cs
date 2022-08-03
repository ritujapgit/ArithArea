using System;
using System.Collections.Generic;
using System.Text;

namespace ArithArea.SwitchCase
{
    class VowelsSC
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Enter number");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your Choice :");
            int c = int.Parse(Console.ReadLine());
            
            switch(c)
            {
                case 1: Console.WriteLine("Monday");
                    break;
                case 2:Console.WriteLine("Tuesday");
                    break;
                case 3:Console.WriteLine("Wednesday");
                    break;
                case 4:Console.WriteLine("Thursday");
                    break;
                case 5:Console.WriteLine("Friday");
                    break;
                case 6:Console.WriteLine("Saturday");
                    break;
                case 7:Console.WriteLine("Sunday");
                    break;
                default:Console.WriteLine("enter the value between 1 to 7.");
                    break;
            }

        }
    }
}
