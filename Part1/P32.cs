using System;
using System.Drawing;

//열거형

namespace Part1
{
    class Program
    {
        enum Size
        {
            Short, Tall, Grande, Venti
        };
        static int[] price = { 3300, 3800, 4300, 4800 };
        enum Colors
        {
            Red = 1, Greem = 2, Blue = 4, yellow = 8
        };
        enum Coffee
        {
            Short = 3300, Tall = 3800, Grande = 4300, Venti =4800
        };
        static void Main(string[] args)
        {
            Console.WriteLine("커피 가격표");
            for(int i = 0; i<4; i++)
            {
                if(i == (int)Size.Short)
                    Console.WriteLine($"{Size.Short, 10} : {price[i]:C}");
                else if (i == (int)Size.Tall)
                    Console.WriteLine($"{Size.Tall,10} : {price[i]:C}");
                else if (i == (int)Size.Grande)
                    Console.WriteLine($"{Size.Grande,10} : {price[i]:C}");
                else if (i == (int)Size.Venti)
                    Console.WriteLine($"{Size.Venti,10} : {price[i]:C}");
            }

            Console.WriteLine("\n커피 가격표(enum)");
            foreach(var size in Enum.GetValues(typeof(Size)))
            {
                Console.WriteLine($"{size,10} : {price[(int)size]:C}");
            }
            Console.WriteLine("\nColors Enum iteration");
            foreach (var color in Enum.GetValues(typeof(Colors)))
            {
                Console.WriteLine($"{color, 10} : {Convert.ToInt32(color)}");
            }

            Console.WriteLine("\n커피 가격표 Enum");
            foreach(var coffee in Enum.GetValues(typeof(Coffee)))
            {
                Console.WriteLine($"{coffee,10} : {Convert.ToInt32(coffee):C}");
            }
        }
    }
}
