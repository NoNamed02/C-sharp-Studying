using System;

namespace P83
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int[] v = new int[10];
            for (int i = 0; i < v.Length; i++)
            {
                v[i] = r.Next(1000);
            }
            Print(v);

            Array.Sort(v);
            Print(v);
            
            Console.Write("탐색 숫자 : ");
            int input = int.Parse(Console.ReadLine());

            int index = Search(v, 0, v.Length - 1, input);
            Console.WriteLine($"v [{index}]  = {input}");
        }

        private static int Search(int[] v, int low, int high, int key)
        {
            if (low <= high)
            {
                int mid = (low + high) / 2;
                if (key == v[mid])
                    return mid;
                else if (key > v[mid])
                    return Search(v, mid + 1, high, key);
                else
                    return Search(v, low, mid - 1, key);
            }
            return -1;
        }
        private static void Print<T>(T[] value)
        {
            foreach(T n in value)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine();
        }
    }
}
