using System;
using System.Linq;

/*
 * Exemplu citire:
 * 3 3
 * 1 2 3
 * 4 5 6
 * 7 8 9
 */

namespace _2022__ExMAP_TepesAlexandru_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstLine = Console.ReadLine().Split(' ').Select(Int32.Parse).ToArray();
            int n = firstLine[0];
            int m = firstLine[1];
            int[,] mat = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                int[] row = Console.ReadLine().Split(' ').Select(Int32.Parse).ToArray();
                for (int j = 0; j < m; j++)
                {
                    mat[i, j] = row[j];
                }
            }

            int lastElement = mat[n - 1, m - 1];
            for (int i = 0; i < n; i++)
            {
                mat[i, 0] = lastElement;
                mat[i, m - 1] = lastElement;
            }

            for (int j = 0; j < m; j++)
            {
                mat[0, j] = lastElement;
                mat[n - 1, j] = lastElement;
            }


            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{mat[i, j]} ");
                }
                Console.WriteLine();
            }

        }
    }
}
