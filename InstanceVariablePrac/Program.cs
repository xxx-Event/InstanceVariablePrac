﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstanceVariablePrac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            product product1 = new product();
            product1.name = "감자";
            product1.price = 2000;
        }
    }
}
