﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uygulama_40
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i<= 10; i++)
            {
                for(int j=1; j<=i; j++)
                {
                    Console.Write(j);

                }
                Console.WriteLine("");
            }
            Console.ReadLine();
        }
    }
}
