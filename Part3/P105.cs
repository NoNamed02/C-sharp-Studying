using System;
using System.Collections;

namespace P105
{
    class Program
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
        static void Main(string[] args)
        {
            string[] animals = { "A", "B", "C", "D" };
            string[] animals2 = { "가", "나", "다", "라" };

            Print(animals);
            Print(animals2);

            Array.Sort(animals);
            Array.Reverse(animals);

            Array.Sort(animals2);
            IComparer rev = new ReverseComparer();
            Array.Sort(animals2, rev);

            Print(animals);
            Print(animals2);
        }
        private static void Print<T>(T[] values)
        {
            foreach (var v in values)
                Console.Write($"{v} ");
            Console.WriteLine();
        }
    }
}
