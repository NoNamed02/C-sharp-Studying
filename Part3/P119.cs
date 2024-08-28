using System;

namespace P119
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myList = new List<string>() { "mouse", "cow", "tiger", "rabbit", "dragon", "snake" };

            bool n = myList.Exists(s => s.Contains("x"));
            Console.WriteLine(n);

            string name = myList.Find(s => s.Length == 3);
            Console.WriteLine(name);


            List<string>nameL = myList.FindAll(s => s.Length >= 3);
            foreach(var v in nameL)
                Console.WriteLine(v + " ");
        }
    }
}
