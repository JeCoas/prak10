using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace polymorphism___interface
{
    public class Program
    {
        static void Main(string[] args)
        {
            Printer printer = new Printer();
            Console.WriteLine("Silahkan pilih printer : ");
            Console.WriteLine("1. Epson");
            Console.WriteLine("2. Canon");
            Console.WriteLine("3. LaserJet");

            Console.Write("Pilih nomor 1..3 : ");
            int pilihan = Convert.ToInt32(Console.ReadLine());
            printer.Jenis = pilihan;

            IPrinter cetak;

            if (printer.Jenis == 1)
                cetak = new Epson();
            else if (printer.Jenis == 2)
                cetak = new LaserJet();
            else
                cetak = new Canon();

            cetak.Cetak(printer);
            Console.ReadLine();
        }
    }
}
