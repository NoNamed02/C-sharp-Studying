using System;
using System.Collections.Generic;

namespace P104
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> a = new List<string>();
            String[] b = new string[3];

            a.Add("C");
            a.Add("B");
            a.Add("A");

            b[0] = "A";
            b[1] = "C";
            b[2] = "B";

            a.Sort();
            Array.Sort(b);
            foreach (string value in a)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine();

            foreach (string value in b)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine();
        }
    }
}
