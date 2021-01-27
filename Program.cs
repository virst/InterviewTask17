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
            int a = (rez * rez).CompareTo(0);
            Console.WriteLine("Array contains zeros - " + Answers[a]);
        }

        static void IsZero(int n)
        {
            rez *= N[n];
            n++;
            int t = M / n;
            t = t.CompareTo(0) * (rez*rez).CompareTo(0);
            methods[t].Invoke(n);
        }

        static void Non(int n)
        {

        }       
    }
}
