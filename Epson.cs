using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Epson : IPrinterWindows
    {
        public void Show()
        {
            Console.WriteLine("Epsom display dimension : 10*11");
        }

        public void Print()
        {
            Console.WriteLine("Epson printer printing....");
        }
    }
}
