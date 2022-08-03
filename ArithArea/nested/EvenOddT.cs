using System;
using System.Collections.Generic;
using System.Text;

namespace ArithArea.nested
{
    class EvenOddT
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Enter the value :");
            int n = int.Parse(Console.ReadLine());

            string result=n%2==0?"Evennumber":"Oddnumber";
        }
    }
}
