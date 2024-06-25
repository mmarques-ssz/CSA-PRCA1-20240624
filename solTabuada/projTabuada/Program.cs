using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projTabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int i;
            do
            {
                Console.Write("Digite número entre 1 e 10: ");
                n = int.Parse(Console.ReadLine());
            }
            while (n<1 || n>10);

            for (i = 1; i <= 10; ++i)
                Console.WriteLine("{0} x {1} = {2}",
                    n, i, n * i);
        }
    }
}
