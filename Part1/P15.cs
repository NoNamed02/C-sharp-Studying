using System;

namespace A015
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;

            Console.Write("첫 번째 숫자를 입력하세요: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.Write("두 번째 숫자를 입력하세요: ");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{x} + {y} = {x + y}");

            short value = short.MaxValue;
            Console.WriteLine("\n2진수, 8진수, 10진수, 16진수로 출력하기");


            /*
            int baseNum = 2;
            string s = Convert.ToString(value, baseNum);
            int i = Convert.ToInt32(s, baseNum);
            //Console.WriteLine("i = {0}, {1,2}진수 = {2,16}", i, baseNum, s);
            
            Console.WriteLine($"i = {i}, {baseNum,2}진수 = {s,16}");

            baseNum = 8;
            s = Convert.ToString(value, baseNum);
            i = Convert.ToInt32(s, baseNum);
            Console.WriteLine($"i = {i}, {baseNum,2}진수 = {s,16}");

            baseNum = 10;
            s = Convert.ToString(value, baseNum);
            i = Convert.ToInt32(s, baseNum);
            Console.WriteLine($"i = {i}, {baseNum,2}진수 = {s,16}");

            baseNum = 16;
            s = Convert.ToString(value, baseNum);
            i = Convert.ToInt32(s, baseNum);
            Console.WriteLine($"i = {i}, {baseNum,2}진수 = {s,16}");
            */

            Calculator(2);
            Calculator(8);
            Calculator(10);
            Calculator(16);
        }

        static void Calculator(int baseNum)
        {
            string s = Convert.ToString(short.MaxValue, baseNum);
            int i = Convert.ToInt32(s, baseNum);
            Console.WriteLine($"i = {i}, {baseNum,2}진수 = {s,16}");
        }
    }
}
