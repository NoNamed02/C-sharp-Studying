using System;
using System.Collections.Generic;

namespace P111
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<int, string> s1 = new SortedList<int, string>();
            s1.Add(3, "C");
            s1.Add(4, "D");
            s1.Add(1, "A");
            s1.Add(2, "B");

            for (int i = 0; i < s1.Count; i++) Console.WriteLine(s1.Keys[i] + " " + s1.Values[i]);

            Console.WriteLine();

            foreach (var v in s1 ) Console.WriteLine(v);

            SortedList<string, int> s2 = new SortedList<string, int>();
            s2.Add("A", 1);
            s2.Add("B", 2);
            s2.Add("C", 3);
            s2.Add("D", 4);

            Console.WriteLine(s2["C"]);

            int val;
            if (s2.TryGetValue("A", out val)) Console.WriteLine("A : "+val);
            Console.WriteLine(s2.ContainsKey("C"));
            Console.WriteLine(s2.ContainsValue(2));

            s2.Remove("A");
            s2.RemoveAt(2);

            foreach (var v in s2) Console.WriteLine($"{v, -10}");
        }
    }
}
