using System;

namespace Lesson_1
{
    class Program
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int j = 0; j < n; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    if (a[j] < a[i])
                    {
                        int z = a[j];
                        a[j] = a[i];
                        a[i] = z;
                    }
                }
            }
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a[x]);

        }
    }
}