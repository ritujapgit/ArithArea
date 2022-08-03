using System;
using System.Collections.Generic;
using System.Text;

namespace ArithArea.AreaOp
{
    class Swap
    {
      static void Main(string[] args)
        {
            int n1 = 2, n2 = 77, temp;
            Console.WriteLine(n1 +" "+ n2);
            temp = n1;
            n1 = n2;
            n2 = temp;
            Console.WriteLine(n1+"=n1" +"n2="+n2);
        }
    }
}
