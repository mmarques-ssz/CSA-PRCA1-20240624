﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projRepete
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            /* do/while
            do
            {
                Console.Write("Digite numero positivo: ");
                a = int.Parse(Console.ReadLine());
            }
            while (a <= 0);
            Console.WriteLine("O número digitado foi {0}", a);
             */

            a = 0;
            while (a <= 0)
            {
                Console.Write("Digite numero positivo: ");
                a = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("O número digitado foi {0}", a);


        }
    }
}
