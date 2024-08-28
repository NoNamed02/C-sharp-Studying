using System;

namespace P114
{
    class Program
    {
        delegate bool MemberTest(int a);

        static void Main(string[] args)
        {
            var arr = new[] { 3, 5, 4, 2, 6, 4, 6, 8, 54, 23, 4, 6, 4 };

            Console.WriteLine("Odd");
            int n = Count(arr, delegate (int x) { return x % 2 == 0; });
            Console.WriteLine(n);
            Console.WriteLine("Even");
            n = Count(arr, delegate (int x) { return x % 2 != 0; });
            Console.WriteLine(n);
        }

        static int Count(int[] a, MemberTest testMethod)
        {
            int cnt = 0;
            foreach (var n in a)
            {
                if (testMethod(n)) cnt++;
            }
            return cnt;
        }
    }
}
