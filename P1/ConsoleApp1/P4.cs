using System;

namespace Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("이름을 입력하세요 : ");
            string name = Console.ReadLine();
            Console.Write("나이를 입력하세요 : ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("안녕하세요, ");
            Console.Write(name + "님!");
            Console.WriteLine("나이는 " + age + "세 입니다.");
        }
    }
}
