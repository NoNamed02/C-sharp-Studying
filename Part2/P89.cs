using System;

namespace P89
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            Sqr(a);
            Console.WriteLine(a);

            int b = 3;
            Sqr(ref b);
            Console.WriteLine(b);

            string name;
            int id;
            GetName(out name, out id);
            Console.WriteLine(name + id);
        }

        static void Sqr(int x)
        {
            x = x * x;
        }

        static void Sqr(ref int x)
        {
            x = x * x;
        }

        static void GetName(out string name, out int id)
        {
            Console.Write("이름 : ");
            name = Console.ReadLine();
            Console.Write("아이디 : ");
            id = int.Parse(Console.ReadLine());
        }
    }
}
