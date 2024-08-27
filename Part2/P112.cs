using System;
namespace P112
{
    class MyCollection<T>
    {
        private T[] arr = new T[100];

        public T this[int i]
        {
            get { return arr[i]; }
            set { arr[i] = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var myString = new MyCollection<string>();

            myString[0] = "A";
            myString[1] = "B";
            myString[2] = "C";

            for (int i = 0; i < 3 ; i++)
                Console.WriteLine(myString[i]);
        }
    }
}
