using System;

namespace P61
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            Console.WriteLine("{0, -16}", "Random Bytes");
            Byte[] b = new byte[5];
            r.NextBytes(b);

            foreach(var x in b) Console.Write($"{x, 12}");
            Console.WriteLine();

            Console.Write("{0, -16}", "Random Double");
            double[] d = new double[5];
            
            for (int i = 0; i < 5; i++) d[i] = r.NextDouble();

            foreach (var x in d) Console.Write("{0, 12:F8}", x);
            Console.WriteLine();


            Console.Write("{0, -16}", "Random Int");
            int[] a = new int[5];
            for (int i = 0; i < 5; i++) a[i] = r.Next();
            Print(a);


            Console.Write("{0, -16}", "Random 0 - 99");
            int[] v = new int[5];
            for(int i = 0; i<5; i++) v[i] = r.Next(100);
            Print(v);
        }

        private static void Print(int[] value)
        {
            foreach(var x in value) Console.Write(x + " ");
            Console.WriteLine();
        }
    }
}
