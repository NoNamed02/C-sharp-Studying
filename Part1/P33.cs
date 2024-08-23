using System;

namespace A033
{
    class ConstEx { public const int Number = 3; }
    class ReadonlyEx
    {
        public readonly int Number = 10;
        public ReadonlyEx()
        {
            Number = 20;
        }
        public ReadonlyEx(int n)
        {
            Number = n;
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine(ConstEx.Number);
            ReadonlyEx inst1 = new ReadonlyEx();
            Console.WriteLine(inst1.Number);

            ReadonlyEx inst2 = new ReadonlyEx(200);
            Console.WriteLine(inst2.Number);

        }
    }
}
