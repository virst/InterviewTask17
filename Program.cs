using System;

namespace InterviewTask17
{
    class Program
    {
        private static int[] N = new int[] { 1, 2, 3, 0, 5, 6, 7, 8, 9 };
        private static int M = 5;
        private static int rez = 1;
        private static string[] Answers = new String[] { "No", "Yes" };

        static void Main(string[] args)
        {
            bool b = IsZero(0);
            int a = b2i(b);
            Console.WriteLine("Array contains zeros - " + Answers[a]);
        }

        static bool IsZero(int n)
        {
            return !i2b(M - n) && (i2b(rez *= N[n]) || IsZero(n + 1));
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
