using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism___interface
{
    public class LaserJet : IPrinter
    {
        public void Cetak(Printer print)
        {
            Console.WriteLine("LaserJett display dimension 12 * 12");
            Console.WriteLine("LaserJett Printer Printing....");
        }
    }
}
