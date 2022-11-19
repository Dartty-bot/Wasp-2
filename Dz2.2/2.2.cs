using System;

namespace Lesson_1
{
    class Program
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int n1 = Convert.ToInt32(Console.ReadLine());
            int answer = n1 + n;
            string ans2 = "";
            string ans1 = "";
            string ans = "";
            int q = 0;
            while (answer > 0)
            {
                int k2 = answer % 2;
                string t2 = k2.ToString();
                ans2 = t2 + ans2;
                answer = answer / 2;
            }
            if (n < n1)
            {
                q = n;
                n = n1;
                n1 = q;
            }
            while (n > 0)
            {
                int k = n % 2;
                string t = k.ToString();
                ans = t + ans;
                n = n / 2;
            }
            while (n1 > 0)
            {
                int k1 = n1 % 2;
                string t1 = k1.ToString();
                ans1 = t1 + ans1;
                n1 = n1 / 2;
            }
            while ((ans.Length - ans1.Length) > 0)
            {
                ans1 = '0' + ans1;
            }
            while (ans.Length < ans2.Length)
            {
                ans = '0' + ans;
                ans1 = '0' + ans1;
            }
            Console.WriteLine(ans);
            Console.WriteLine(ans1);
            for (int i = 0; i < ans.Length; i++)
            {
                Console.Write('.');
            }
            Console.WriteLine();
            Console.WriteLine(ans2);


        }
    }
}


