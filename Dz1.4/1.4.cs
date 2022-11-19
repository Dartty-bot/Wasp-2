using System;

namespace Lesson_1
{
    class Program
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] b = new int[n];
            for (int i = 0; i < (n); i++)
            {
                int[] a = new int[n];
                int j = 0;
                while (j <= i)
                {
                    if (j == 0)
                    {
                        Console.Write(1);
                        a[j] = 1;

                    }
                    else if (j == i)
                    {
                        Console.Write(1);
                        a[j] = 1;

                    }
                    else
                    {
                        a[j] = b[j - 1] + b[j];
                        Console.Write(a[j]);

                    }

                    j++;
                }
                for (int k = 0; k < a.Length; k++)
                {
                    b[k] = a[k];
                }
                Console.WriteLine();
            }
        }
    }
}

