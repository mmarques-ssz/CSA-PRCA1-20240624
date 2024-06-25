using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projRepete2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            /* do/while
            a = 1;
            do
            {
                Console.WriteLine(a);
                a = a + 2;
            }
            while (a <= 100);
            */

            a = 1;
            while (a <= 100)
            {
                Console.WriteLine(a);
                a += 2;
            }
            



        }
    }
}
