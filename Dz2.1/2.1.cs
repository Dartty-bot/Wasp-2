using System;

namespace Lesson_1
{
    class Program
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string ans = "";
            while (n > 0)
            {
                int k = n % 2;
                string t = k.ToString();
                ans = t + ans;
                n = n / 2;
            }
            Console.WriteLine(ans);
        }
    }
}

