using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism___interface
{
    public class Epson : IPrinter
    {
        public void Cetak(Printer print)
        {
            Console.WriteLine("Epson display dimension : 10 * 11");
            Console.WriteLine("Epson Printer Printing....");
        }
    }
}
