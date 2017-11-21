﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cookbook
{
    class MainClass
    {
        internal Menu Menu
        {
            get => default(Cookbook.Menu);
            set
            {
            }
        }

        static public void Main(string[] args)
        {
            // Display the number of command line arguments:
            System.Console.WriteLine(args.Length);
        }
    }
}