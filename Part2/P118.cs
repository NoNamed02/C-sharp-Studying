using System;

namespace P118
{
    class Program 
    {
        static void Main(string[] args)
        {
            Predicate<int> isEven = n => n % 2 == 0;
            Console.WriteLine(isEven(6));

            Predicate<string> Lower = s => s.Equals(s.ToLower());
            Console.WriteLine(Lower("Test"));
        }
    }
}
