using System;

namespace Dz1
{
    class Program
    { 
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int k = 0;
            for (int i = 0; i < n; i++)
            {
                int q = (4 - (n - k));
                int p = n - k;
                while (q > 0)
                {
                    Console.Write(4 - q);
                    q--;
                }
                while (p > 0)
                {
                    Console.Write((p + k));
                    p--;
                }
                Console.WriteLine();
                k++;
            }

        }
    }

}