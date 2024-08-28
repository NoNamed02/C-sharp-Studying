using System;
using System.Collections;

namespace P106
{
    public class ReverseComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            string s1 = (string)x;
            string s2 = (string)y;
            return string.Compare(s2, s1);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] EN = { "A", "B", "C", "D" };
            string[] KR = { "가", "나", "다", "라" };

            Print(KR, EN);

            Array.Sort(EN, KR);
            Print(KR, EN);

            IComparer comparer = new ReverseComparer();
            Array.Sort(KR, EN, comparer);
            Print(KR, EN);


            string[] T1 = { "a", "b", "c", "d" };
            string[] T2 = { "t2", "t4", "t1", "t3" };

            Print(T1, T2);
            Array.Sort(T2, T1);
            Print(T1, T2);
        }
        private static void Print<T>(T[] values1, T[] values2)
        {
            foreach (var v in values1)
                Console.Write($"{v} ");
            Console.WriteLine();
            foreach (var v in values2)
                Console.Write($"{v} ");
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
