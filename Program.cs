using System;

namespace ConsoleApp4._2
{    
    class Program
    {
        public static void Main(string[] args)
        {

            int[] x = new int[10];
            x[0] = 24;
            x[1] = 15;
            x[2] = 2;
            x[3] = 4;
            x[4] = 85;
            x[5] = 29;
            x[6] = 61;
            x[7] = 46;
            x[8] = 77;
            x[9] = 12;
            int a = 0;
            for (int i = 0; i < x.Length; i++)
            {
                a += x[i];
            }
            Console.WriteLine("x = " + a);

            Console.WriteLine();

            int[] q = new int[10];
            q[0] = 24;
            q[1] = 15;
            q[2] = 2;
            q[3] = 4;
            q[4] = 85;
            q[5] = 29;
            q[6] = 61;
            q[7] = 46;
            q[8] = 77;
            q[9] = 12;
            int p = 0;
            int z = 0;
            while (z < q.Length)
            {              
                p += q[z];
                z++;
                Console.WriteLine("p = " + p);
            }

            Console.WriteLine();

            int[] d = new int[10];
            d[0] = 24;
            d[1] = 15;
            d[2] = 2;
            d[3] = 4;
            d[4] = 85;
            d[5] = 29;
            d[6] = 61;
            d[7] = 46;
            d[8] = 77;
            d[9] = 12;
            int j = 0;
            int h = 0;
            do
            {
                j += d[h];
                h++;
                Console.WriteLine("j = " + j);
            } while (h < d.Length) ;


        }
    }
}
