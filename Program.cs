using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
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
            int s = 0;
            for(int i = 0; i < x.Length; i++ )
            {
                s = x[i];                
            }
            Console.WriteLine(s);

        }
    }
}
