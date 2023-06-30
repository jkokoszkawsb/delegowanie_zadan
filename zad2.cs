using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    internal class zad2
    {
        public static double ObliczDlugoscOdcinka(double x1, double x2, double y1, double y2)
        {
            double dx = x2 - x1;
            double dy = y2 - y1;
            double dlugosc = Math.Sqrt(dx * dx + dy * dy);
            return dlugosc;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Podaj x1");
            double x1 = double.Parse(Console.ReadLine());
            Console.WriteLine("podaj x2");
            double x2 = double.Parse(Console.ReadLine());
            Console.WriteLine("podaj y1 ");
            double y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("podaj y2");
            double y2 = double.Parse(Console.ReadLine());
            double dlugosc = ObliczDlugoscOdcinka(x1, x2, y1, y2);
            Console.WriteLine("Długość twojego odcinka wynosi: " + dlugosc);
            Console.ReadLine();
        }
    }
}
