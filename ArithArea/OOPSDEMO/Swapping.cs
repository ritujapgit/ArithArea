using System;
using System.Collections.Generic;
using System.Text;

namespace ArithArea.OOPSDEMO
{
    class Swapping
    {
        public void Swap(ref int n1,ref int n2)
        {
            int temp = n1;
            n1 = n2;
            n2 = temp;
        }
        static void Main(string[]args)
        {
            Swapping s = new Swapping();
            Console.WriteLine("enter the 1st number :");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the 2nd number :");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine(n1 + " "+n2);
            Console.WriteLine("....................");
            s.Swap(ref n1, ref n2);
            Console.WriteLine(n1 + " " + n2);

        }
    }
}
