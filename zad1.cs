using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1
{
    internal class zad1
    {

        static string sformatowanyczas(int sekundy)
        {
            int godziny = sekundy / 3600;
            int minuty = (sekundy % 3600) / 60;
            int pozostaleSekundy = sekundy % 60;

            string sformatowanaGodzina = godziny.ToString().PadLeft(2, '0');
            string sformatowaneMinuty = minuty.ToString().PadLeft(2, '0');
            string sformatowaneSekundy = pozostaleSekundy.ToString().PadLeft(2, '0');

            return $"{sformatowanaGodzina}:{sformatowaneMinuty}:{sformatowaneSekundy}";
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Podaj czas w sekundach");
            int sekundy = int.Parse(Console.ReadLine());
            Console.WriteLine(sformatowanyczas(sekundy));
            Console.ReadKey();
        }
    }
}
