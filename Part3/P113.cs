using System;

namespace P113
{
    class Program
    {
        delegate bool MemberTest(int a);

        static void Main(string[] args)
        {
            int[] arr = new int[] { 3, 5, 4, 2, 6, 4, 6, 8, 54, 23, 4, 6, 4 };

            Console.WriteLine("Odd");
            Console.WriteLine(Count(arr, IsOdd));
            Console.WriteLine("Even");
            Console.WriteLine(Count(arr, IsEven));
        }

        static int Count(int[] a, MemberTest testMethod)
        {
            int cnt = 0;
            foreach (var n in a)
            {
                if ( testMethod(n)) cnt++;
            }
            return cnt;
        }

        public static bool IsOdd(int n) { return n % 2 != 0; }
        public static bool IsEven(int n) { return n % 2 == 0; }
    }
}
