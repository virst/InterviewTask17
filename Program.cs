using System;

namespace InterviewTask17
{
    class Program
    {
        private static int[] N = new int[] { 1, -2, 3, 0, 5, 6, 7, 8, 9 };
        private static int M = 5;
        private static int rez = 1;
        private static string[] Answers = new String[] { "Yes", "No" };
        static Action<int>[] methods = new Action<int>[] { Non, IsZero };

        static void Main(string[] args)
        {                  
            IsZero(0);
            int a = Sing(rez);
            Console.WriteLine("Array contains zeros - " + Answers[a]);
        }

        static void IsZero(int n)
        {
            rez *= N[n];
            n++;
            int t = M / n;
            t = Sing(t) * Sing(rez);
            methods[t].Invoke(n);
        }

        static void Non(int n)
        {

        }

        static int Sing(int i)
        {
            i *= i;
            return (int)(uint)(i / (i - 0.1));
        }


    }
}
