using System;

namespace A040
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("입력 : ");
            string input = Console.ReadLine();

            while (input != "Q")
            {
                Console.WriteLine($"{input} : 입력함");
                Console.Write("입력 : ");
                input = Console.ReadLine();
            }
            Console.WriteLine("종료");
        }
    }
}
