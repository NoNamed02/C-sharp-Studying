using System;
using System.Collections.Generic;
using System.Linq;

namespace P120
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> data = new List<int>() { 123, 45, 12, 89, 456, 1, 4, 74, 46 };
            List<int> lsSortedEven = new List<int>();

            foreach (var i in data) if(i % 2 == 0) lsSortedEven.Add(i);

            lsSortedEven.Sort();

            foreach (var i in lsSortedEven)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            var sortedEven = from i in data
                             where i % 2 == 0
                             orderby i
                             select i;

            foreach (var i in sortedEven)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}

