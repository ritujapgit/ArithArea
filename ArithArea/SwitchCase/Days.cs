using System;
using System.Collections.Generic;
using System.Text;

namespace ArithArea.SwitchCase
{
    class Days
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Enter the 1st number : ");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the 2nd number : ");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("\n1.Addition\n2.Substraction\n3.Multiplication\n4.Division");
            Console.WriteLine("enter your choice");
            int c = int.Parse(Console.ReadLine());

            switch(c)
            {
                case 1:Console.WriteLine("Addition=" + (n1 + n2));
                    break;
                case 2:
                    Console.WriteLine("Subtraction=" + (n1 - n2));
                    break;
                case 3:
                    Console.WriteLine("Multiplication=" + (n1 * n2));
                    break;
                case 4:
                    Console.WriteLine("Division=" + (n1/n2));
                    break;
                default:Console.WriteLine("Enter the choice between 1 and 4.");
                    break;
            }
        }
    }
}
