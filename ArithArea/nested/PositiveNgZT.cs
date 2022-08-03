using System;
using System.Collections.Generic;
using System.Text;

namespace ArithArea.nested
{
    class PositiveNgZT
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value :");
            int n = int.Parse(Console.ReadLine());
            string str = n > 0 ? "positive" : n < 0 ? "negative" : "Zero";
            Console.WriteLine(str);
        }
    }
}
