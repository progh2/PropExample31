﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestOver(3L);
        }

        // 오버로딩 
        //public static int TestOver(int input) { return 0;  }
        public static bool TestOver(float input) { return true; }
    }
}
