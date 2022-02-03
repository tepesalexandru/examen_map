using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _2022__ExMAP_TepesAlexandru_12_
{
    class Program
    {
        class Muchie
        {
            public int x { get; set; }
            public int y { get; set; }
        }

        static List<Muchie> ReadFromFile(string fileName)
        {
            List<Muchie> muchii = new List<Muchie>();

            TextReader dataLoad = new StreamReader(fileName);
            string buffer;
            while ((buffer = dataLoad.ReadLine()) != null)
            {
                int[] valoriMuchii = buffer.Split(' ').Select(Int32.Parse).ToArray();
                muchii.Add(new Muchie { x = valoriMuchii[0], y = valoriMuchii[1] });
            }

            return muchii;
        }

        static void FillMatrix(bool[,] matrix, List<Muchie> muchii)
        {
            foreach(var muchie in muchii)
            {
                matrix[muchie.x, muchie.y] = true;
            }
        }

        static void DFS(int k, int n, bool[,] adiacenta, bool[] vizitate)
        {
            vizitate[k] = true;
            for (int i = 1; i <= n; i++)
            {
                if (adiacenta[k, i])
                {
                    DFS(i, n, adiacenta, vizitate);
                }
            }
        }

        static void Main(string[] args)
        {
            List<Muchie> muchii = ReadFromFile(@"..\..\..\muchii.in");

            // Numar noduri in graf
            int n = muchii.Max(muchie => Math.Max(muchie.x, muchie.y));

            // Construire matrice adiacenta
            bool[,] matriceAdiacenta = new bool[n + 1, n + 1];
            FillMatrix(matriceAdiacenta, muchii);

            bool[] noduriVizitate = new bool[n + 1];

            // Calculam cate componente conexe sunt in graf
            int componenteConexe = 0;
            for (int i = 1; i <= n; i++)
            {
                if (!noduriVizitate[i])
                {
                    componenteConexe++;
                    DFS(i, n, matriceAdiacenta, noduriVizitate);
                }
            }

            Console.WriteLine($"Muchii necesare: {componenteConexe - 1}");

        }
    }
}
