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
            int a = 0;
            for(int i = 0; i < x.Length; i++ )
            {
                a = x[i];                
            }
            Console.WriteLine(s);
            
            int[] z = new int[5];
            Console.WriteLine("Enter the first number");
            z[0] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            z[1] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the third number");
            z[2] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the fourth number");
            z[3] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the fifth number");
            z[4] = Convert.ToInt32(Console.ReadLine());
            int s = 0;

            for(int d = 0; d < z.Length; d++)
            {
                s += z[d];
            }
            Console.WriteLine("Adding up all the numbers you wrote exatly - " + s);

        }
    }
}
