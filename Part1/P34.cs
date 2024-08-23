using System;

namespace A034
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "before passing";
            Console.WriteLine(s);

            Test(s);
            Console.WriteLine(s);
            Test(ref s);
            Console.WriteLine(s);
        }

        public static void Test(string s)
        {
            s = "REF check";
        }

        public static void Test(ref string s)
        {
            s = "REF check";
        }

    }
}
