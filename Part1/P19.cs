using System;

namespace A019
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.MaxValue, y = 0;

            checked
            {
                try
                {
                    y = x + 10;
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            Console.WriteLine($"int.MaxValue + 10 = {y}");
        }
    }
}
