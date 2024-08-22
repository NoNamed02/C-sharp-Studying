using System;

namespace A030
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("표시 숫자: ");
                string s = Console.ReadLine();
                double v = double.Parse(s);

                if(v == -1)
                    break;
                Console.WriteLine(Number(s));
            }
        }

        private static string Number(string s)
        {
            int pos = 0;
            double v = Double.Parse(s);

            if (s.Contains("."))
            {
                pos = s.Length - s.IndexOf('.');
                string formatStr = "{0:N" + (pos - 1) + "}";
                s = string.Format(formatStr, v);
            }
            else
                s = string.Format("{0:N0}", v);
            return s;
        }
    }
}
