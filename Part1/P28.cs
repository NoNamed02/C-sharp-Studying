using System;

namespace A028
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "mouse, cow, tiger, rabbit, dragom";
            string s2 = "cow";
            bool b = s1.Contains(s2);
            Console.WriteLine(b);

            if(b)
            {
                int index = s1.IndexOf(s2);
                if(index >= 0)
                {
                    Console.WriteLine($"{s2} begins at index{index}");
                }
            }
            if(s1.IndexOf(s2, StringComparison.CurrentCultureIgnoreCase) >= 0)
            {
                Console.WriteLine($"{s2} is in the string {s1}");
            }
        }
    }
}
