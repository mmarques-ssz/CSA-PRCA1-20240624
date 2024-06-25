using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projIncDec
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            a = 1;
            b = a-- * 2;
            Console.WriteLine(a);
            Console.WriteLine(b);

            b += 2;
            Console.WriteLine(b);

            b -= 5;
            Console.WriteLine(b);

            b *= 8;
            Console.WriteLine(b);

            b /= 2;
            Console.WriteLine(b);

            b %= 2;
            Console.WriteLine(b);



            

            



            Console.WriteLine("----FIM----");
            Console.ReadKey();
        }
    }
}
