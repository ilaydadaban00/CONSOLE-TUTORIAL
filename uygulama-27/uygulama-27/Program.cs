﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uygulama_27
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            byte b = (byte)a;


            Console.WriteLine(b.GetType());
            Console.WriteLine(b);
            Console.ReadLine();
        }
    }
}
