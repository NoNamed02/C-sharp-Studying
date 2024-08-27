using System;

namespace P94
{
    class MyClass<T>
    {
        private T[] arr;
        private int count = 0;

        public MyClass(int length)
        {
            arr = new T[length];
            count = length;
        }

        public void Insert(params T[] arr)
        {
            for (int i = 0; i < this.arr.Length; i++)
            {
                this.arr[i] = arr[i];
            }
        }
        public void Print()
        {
            foreach(T n in arr)
                Console.Write(n + " ");
            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass<int> a = new MyClass<int>(10);
            MyClass<string> s = new MyClass<string>(5);

            a.Insert(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
            s.Insert("AB", "BC", "CD", "DE", "EF");

            a.Print();
            s.Print();
        }
    }
}
