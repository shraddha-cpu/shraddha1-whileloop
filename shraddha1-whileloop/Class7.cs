﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shraddha1_whileloop
{
    internal class Class7
    {
        static void Main(string[] args)
        {
            int i, j;
            for (i = 1; i <= 5; i++)
            {
                for (j = 5; j >= i; j--)
                {
                    Console.WriteLine("j");
                }
                Console.WriteLine("");
            }   
        }
    }
}
