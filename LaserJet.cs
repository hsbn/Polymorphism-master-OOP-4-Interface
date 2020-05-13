﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class LaserJet : IPrinterWindows
    {
        public void Show()
        {
            Console.WriteLine("LaserJer display dimension : 12*12");
        }

        public void Print()
        {
            Console.WriteLine("LaserJet printer printing....");
        }
    }
}
