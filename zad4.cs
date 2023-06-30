using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad4
{
    internal class zad4
    {
        static void Main(string[] args)
        {
            int[,] tablica =
            {
                {1, 2, 3, 4, 5 },
                { 6, 7, 8, 9, 0 },
                {10, 11, 12, 13, 14 },
                { 1, 3, 3, 4, 5 } };
            znajdzNajbardziejPodobneWiersze(tablica, out int wiersz1, out int wiersz2);
            Console.WriteLine($"Najbardziej podobne wiersze: {wiersz1} i {wiersz2}");
            Console.ReadKey();
        }
        static void znajdzNajbardziejPodobneWiersze(int[,] tablica, out int wiersz1, out int wiersz2)
        {
            wiersz1 = 0;
            wiersz2 = 0;

            long najmniejszaRoznica = long.MaxValue;

            int iloscWierszy = tablica.GetLength(0);
            int iloscKolumn = tablica.GetLength(1);


            for (int i = 0; i < iloscWierszy; i++)
            {
                for (int j = i + 1; j < iloscWierszy; j++)
                {
                    long roznica = wyliczRoznice(tablica, i, j);
                    if (roznica < najmniejszaRoznica)
                    {
                        najmniejszaRoznica = roznica;
                        wiersz1 = i;
                        wiersz2 = j;
                    }
                }
            }
        }

        static long wyliczRoznice(int[,] tablica, int i, int j)
        {
            int iloscKolumn = tablica.GetLength(1);
            long roznica = 0;

            for (int kol = 0; kol < iloscKolumn; kol++)
            {
                roznica += (long)Math.Pow(tablica[i, kol] - tablica[j, kol], 2);
            }
            return roznica;
        }
    }
}
