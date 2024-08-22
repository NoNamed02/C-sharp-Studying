using System;

namespace A023
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = Convert.ToInt32(Console.ReadLine());

            string result = (input > 0) ? "양수" : "음수";
            Console.WriteLine(result);
        }
    }
}
