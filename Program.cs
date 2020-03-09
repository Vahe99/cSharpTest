using System;

namespace ConsoleApp4._2
{    
    class Program
    {
        public static void Main(string[] args)
        {

            int[] x = new int[10] { 24, 15, 2, 4, 85, 29, 61, 46, 77, 12,};        
            int a = 0;
            for (int i = 0; i < x.Length; i++)
            {
                a += x[i];
            }
            Console.WriteLine("x = " + a);

            Console.WriteLine();

            int[] q = new int[10] { 24, 15, 2, 4, 85, 29, 61, 46, 77, 12, };
            int p = 0;
            int z = 0;
            while (z < q.Length)
            {
                p += q[z];
                z++;
                Console.WriteLine("p = " + p);
            }

            Console.WriteLine();

            int[] d = new int[10] { 24, 15, 2, 4, 85, 29, 61, 46, 77, 12, };

            int j = 0;
            int h = 0;
            do
            {
                j += d[h];
                h++;
                Console.WriteLine("j = " + j);
            } while (h < d.Length);


        }
    }
}
