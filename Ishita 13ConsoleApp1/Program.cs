﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ishita_13ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, i, t = 9;
            int sum = 0;

            Console.Write("\n\n");
            Console.Write("Display the sum of the series [ 9 + 99 + 999 + 9999 ...]:\n");
            Console.Write("-----------------------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Input the number or terms :");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                sum += t;
                Console.Write("{0}   ", t);
                t = t * 10 + 9;
            }
            Console.Write("\nThe sum of the saries = {0} \n", sum);
        
    
        }
    }
}
