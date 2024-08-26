using System;

namespace P90
{
    class Program
    {
        public static void PrintInt(params int[] arr)
        {
            for (int i = 0; i < arr.Length; i++) Console.Write(arr[i] + " ");
            Console.WriteLine();
        }
        public static void PrintObj(params object[] arr)
        {
            for (int i = 0; i < arr.Length; i++) Console.Write(arr[i] + " ");
            Console.WriteLine();
        }

        public static void PrintText(object[] arr)
        {
            for (int i = 0; i < arr.Length; i++) Console.Write(arr[i] + " ");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            PrintInt(1, 2, 3, 4);
            PrintObj(1, 1.2, "a", 'b');
            PrintObj();

            int[] arr = { 5, 6, 7, 8 };
            PrintInt(arr);

            object[] arr2 = { 1, 1.5, "abc", 'd' };
            PrintObj(arr2);
            PrintText(arr2);

            PrintObj(arr);
        }
    }
}
