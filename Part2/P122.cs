using System;
using System.Collections.Generic;
using System.Linq;

namespace P122
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> data = new List<int>() { 123, 45, 12, 89, 456, 1, 4, 74, 46 };
            Print(data);

            List<int> Odd = new List<int>();
            Odd = SelectOddSort(data);
            Print(Odd);

            Int32[] arrOdd;
            arrOdd = SelectOddSort(data).ToArray();
            Print(arrOdd);
        }
        private static List<int> SelectOddSort(List<int> arr)
        {
            return (from v in arr where v % 2 == 1 orderby v select v).ToList<int>();
        }
        private static void Print(IEnumerable<int> data)
        {
            foreach (int item in data)
            {
                Console.Write($"[{item}] ");
            }
            Console.WriteLine("\n");
        }
    }

}
