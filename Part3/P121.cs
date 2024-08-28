using System;
using System.Collections.Generic;
using System.Linq;

namespace P121
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> data = new List<int>() { 123, 45, 12, 89, 456, 1, 4, 74, 46 };

            Print(data);

            var IstEven = from v in data where (v > 20 && v % 2 == 0) orderby v descending select v;

            Print(IstEven);

            var IstSorted = from v in data orderby v ascending select v;
            Print(IstSorted);
        }
        private static void Print(IEnumerable<int> data)
        {
            foreach (int item in data)
            {
                Console.Write($"[{item}] ");
            }
            Console.WriteLine();
        }
    }
}
