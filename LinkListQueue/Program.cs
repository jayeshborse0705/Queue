﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue qt = new Queue();
            qt.Enqueue(56);
            qt.Enqueue(30);
            qt.Enqueue(70);
            qt.Dequeue();
          

            foreach (Object obj in qt)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine(); 
            Console.ReadKey();
        }
    }
}