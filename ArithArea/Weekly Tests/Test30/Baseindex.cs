using System;
using System.Collections.Generic;
using System.Text;

namespace ArithArea.Weekly_Tests.Test30
{
    class Baseindex
    {
        public static void Main(string[]args)
        {
            Console.WriteLine("enter the base number");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the index value :");
            int y= int.Parse(Console.ReadLine());
            int res=0;
            int s = 0;
            //s = x;
            for(int i=1;i<=y;i++)
            {
                res = x * i;
                 s= s + res;
            }
            Console.WriteLine(s);         

        }
    }
}
