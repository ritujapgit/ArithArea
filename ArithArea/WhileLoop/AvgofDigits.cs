using System;
using System.Collections.Generic;
using System.Text;

namespace ArithArea.WhileLoop
{
    class AvgofDigits
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Enter the number : ");
            int num = int.Parse(Console.ReadLine());
            int sum = 0, count = 0;
            float avg;
            while(num>0)
            {
                int r = num % 10;
                sum = sum + r;
                count++;
                num = num / 10;
            }
            Console.WriteLine(sum);
            avg = sum / count;
            Console.WriteLine(avg);

        }
    }
}
