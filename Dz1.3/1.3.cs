using System;

namespace Lesson_1
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] a = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] b = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] c = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int k = 1;

            while ((a[0] != c[0]) & (a[1] != c[0]))
            {
                for (int i = 0; i < k; i++)
                {
                    Console.Write('*');
                }
                a[0]++;
                a[1]++;
                k++;
                Console.WriteLine();
            }

        }
    }
}
