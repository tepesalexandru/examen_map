using System;
using System.IO;

namespace _2022__ExMAP_TepesAlexandru_4_
{
    class Program
    {
        static int n;
        static int[] solution;
        static int ReadFromFile(string fileName)
        {
            TextReader dataLoad = new StreamReader(fileName);
            string buffer = dataLoad.ReadLine();

            return Int32.Parse(buffer);
        }

        static bool IsCorrectInsertion(int position)
        {
            for (int i = 0; i < position; i++)
            {
                if (solution[i] == solution[position])
                {
                    return false;
                }
            }

            return true;
        }

        static void Backtrack(int k)
        {
            for (int i = 1; i <= n; i++)
            {
                solution[k] = i;
                if(IsCorrectInsertion(k))
                {
                    if (k == n - 1)
                    {
                        using (StreamWriter outputFile = new StreamWriter(@"..\..\..\permutari1.out", true))
                        {
                            for (int j = 0; j < n; j++)
                            {
                                
                                outputFile.Write($"{solution[j]} ");
                            }
                            outputFile.WriteLine();
                        }
                    } else
                    {
                        Backtrack(k + 1);
                    }
                }
            }
        }

        static void CleanOutputFile(string fileName)
        {
            using (StreamWriter outputFile = new StreamWriter(fileName, false))
            {
                outputFile.Write("");
            }
        }

        static void Main(string[] args)
        {
            n = ReadFromFile(@"..\..\..\permutari1.in");
            solution = new int[n];

            CleanOutputFile(@"..\..\..\permutari1.out");
            Backtrack(0);
        }
    }
}
