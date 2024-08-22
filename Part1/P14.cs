using System;

namespace A014
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int value;

            Console.Write("1. int로 변환할 문자열을 입력하세요: ");
            input = Console.ReadLine();
            bool result = Int32.TryParse(input, out value);

            if (!result)
            {
                Console.WriteLine($"{input}은 int로 변환될 수 없습니다.\n");
            }
            else
            {
                Console.WriteLine($"int {value}로 변환되었습니다.");
            }

            Console.Write("2. double로 변환할 문자열을 입력하세요: ");
            input= Console.ReadLine();
            try
            {
                double m = Double.Parse(input);
                Console.WriteLine($"double {m}으로 변환되었습니다.\n");
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
