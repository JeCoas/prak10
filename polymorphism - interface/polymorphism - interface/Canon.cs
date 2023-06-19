using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism___interface
{
    public class Canon : IPrinter
    {
        public void Cetak(Printer print)
        {
            Console.WriteLine("Cannon display dimension : 9.5 * 12");
            Console.WriteLine("Cannon Printer Printing....");
        }
    }
}
