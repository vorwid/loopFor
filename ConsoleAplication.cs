﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 20; i++)
            {
                if (i % 2 == 0) continue;
                Console.WriteLine(i);
            }
        }
    }
}
