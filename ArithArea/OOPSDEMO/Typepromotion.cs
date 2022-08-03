using System;
using System.Collections.Generic;
using System.Text;

namespace ArithArea.OOPSDEMO
{
    class Typepromotion
    {
        void Addition(int x,float t)
        {
            Console.WriteLine(x + t);
        }
        static void Main(string[]args)
        {
            Typepromotion p = new Typepromotion();
            // p.Addition(4, 6.7);
            p.Addition(7, 5l);
        }
    }
}
