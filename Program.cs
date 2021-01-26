using System;

namespace InterviewTask17
{
    class Program
    {
        private static int[] N = new int[] { 1, 2, 3, 0, 5, 6, 7, 8, 9 };
        private static int M = 5;
        private static int rez = 1;
        private static string[] Answers = new String[] { "No", "Yes" };
        static Action<int>[] methods = new Action<int>[] { IsZero, Non };

        static void Main(string[] args)
        {
            IsZero(0);
            int a = b2i(i2b(rez));
            Console.WriteLine("Array contains zeros - " + Answers[a]);
        }

        static void IsZero(int n)
        {
            rez *= N[n];
            int t = (M - 1 - n) * rez;
            t = b2i(i2b(t));
            methods[t].Invoke(n + 1);
        }

        static void Non(int n)
        {

        }

        static bool i2b(int i)
        {
            bool b;
            unsafe
            {
                b = !*(bool*)&i;
            }
            return b;
        }

        static int b2i(bool b)
        {
            int i;
            unsafe
            {
                i = *(int*)&b;
            }
            return i;
        }
    }
}
