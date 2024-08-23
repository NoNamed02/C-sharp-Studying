using System;
using System.Diagnostics;
using System.Text;

namespace A031
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("This is a StringBuilder Test");
            Console.WriteLine($"{sb.ToString()} ({sb.Length} C)");

            sb.Clear();
            Console.WriteLine($"{sb.ToString()} ({sb.Length} C)");

            sb.Append("new string");
            Console.WriteLine($"{sb.ToString()} ({sb.Length} C)");

            sb.Insert(5, "xyz", 2);
            Console.WriteLine($"{sb.ToString()} ({sb.Length} C)");

            sb.Remove(5, 4);
            Console.WriteLine($"{sb.ToString()} ({sb.Length} C)");

            sb.Replace("xyz", "abc");
            Console.WriteLine($"{sb.ToString()} ({sb.Length} C)");

            Stopwatch time = new Stopwatch();
            string test = string.Empty;
            time.Start();
            for (int i = 0; i < 100000; i++)
            {
                test += i;
            }
            time.Stop();
            Console.WriteLine("String : " + time.ElapsedMilliseconds + "ms");

            StringBuilder test1 = new StringBuilder();
            time.Reset();
            time.Start();
            for(int i = 0; i < 100000; i++)
            {
                test1.Append(i);
            }
            time.Stop();
            Console.WriteLine("StringB : " + time.ElapsedMilliseconds + "ms");
        }
    }
}
