using System;
using System.Linq;

/* 
 * Exemplu citire:
 * 1 2 3
 * 4 5 6
 */

namespace _2022__ExMAP_TepesAlexandru_3_
{
    class Program
    {
        class Vector
        {
            public int x { get; set; }
            public int y { get; set; }
            public int z { get; set; }
        }

        static Vector ReadVector()
        {
            Vector v = new Vector();
            int[] coordinates = Console.ReadLine().Split(' ').Select(Int32.Parse).ToArray();
            v.x = coordinates[0];
            v.y = coordinates[1];
            v.z = coordinates[2];

            return v;
        }

        static double MarimeVector(Vector v)
        {
            return Math.Sqrt(v.x * v.x + v.y * v.y + v.z * v.z);
        }

        static void Main(string[] args)
        {
            Vector v1 = ReadVector();
            Vector v2 = ReadVector();

            // Cerinta a)
            int produsScalar = v1.x * v2.x + v1.y * v2.y + v1.z * v2.z;
            Console.WriteLine($"a) Produs scalar: {produsScalar}");

            // Cerinta b)
            bool perpendiculari = produsScalar == 0;
            if (perpendiculari)
            {
                Console.WriteLine($"b) Vectorii sunt perpendiculari");
            }
            else Console.WriteLine($"b) Vectorii nu sunt perpendiculari");

            // Cerinta c)
            double marimeVector1 = MarimeVector(v1);
            double marimeVector2 = MarimeVector(v2);

            Console.WriteLine($"Marime vector 1: {marimeVector1}");
            Console.WriteLine($"Marime vector 2: {marimeVector2}");
            
        }
    }
}
