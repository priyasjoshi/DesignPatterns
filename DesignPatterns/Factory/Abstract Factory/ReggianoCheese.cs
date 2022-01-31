﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    class ReggianoCheese : Cheese
    {
        public void CreateCheese()
        {
            Console.WriteLine("Using Reggiano Cheese");
        }
    }
}
