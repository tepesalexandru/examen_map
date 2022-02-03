using System;
using System.Linq;

namespace _2022__ExMAP_TepesAlexandru_10_
{
    class Program
    {
        static int MuchiiGrafComplet(int nrNoduri)
        {
            return nrNoduri * (nrNoduri - 1) / 2;
        }
        static void Main(string[] args)
        {
            int[] firstLine = Console.ReadLine().Split(' ').Select(Int32.Parse).ToArray();
            int n = firstLine[0];
            int m = firstLine[1];

            int minimNoduriIzolare, maximNoduriIzolate;

            // Numar minim de noduri izolate
            int maxNoduriAcoperite = m * 2;
            if (maxNoduriAcoperite >= n)
            {
                minimNoduriIzolare = 0;
            } else
            {
                minimNoduriIzolare = n - maxNoduriAcoperite;
            }

            // Numar maxim de noduri izolate
            int noduriGrafComplet = 0;
            while (MuchiiGrafComplet(noduriGrafComplet + 1) <= m)
            {
                noduriGrafComplet++;
            }

            maximNoduriIzolate = n - noduriGrafComplet;

            int muchiiGrafComplet = MuchiiGrafComplet(noduriGrafComplet);
            int muchiiRamase = m - muchiiGrafComplet;
            if (muchiiRamase > 0)
            {
                maximNoduriIzolate--;
            }

            Console.WriteLine($"Minim noduri izolate: {minimNoduriIzolare}");
            Console.WriteLine($"Maxim noduri izolate: {maximNoduriIzolate}");

        }
    }
}
