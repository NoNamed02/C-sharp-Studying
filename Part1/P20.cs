using System;

namespace A020
{
    class Program
    {
        static void Main(string[] args)
        {
            bool result;
            int first = 10, second = 20;

            result = (first == second);
            Console.WriteLine($"{first} == {second} : {result}");

            result = (first > second);
            Console.WriteLine($"{first} > {second} : {result}");

            result = (first < second);
            Console.WriteLine($"{first} < {second} : {result}");

            result = (first >= second);
            Console.WriteLine($"{first} >= {second} : {result}");

            result = (first <= second);
            Console.WriteLine($"{first} <= {second} : {result}");

            result = (first != second);
            Console.WriteLine($"{first} != {second} : {result}");
        }
    }
}
