using System;

namespace A012
{
    class Program
    {
        static void Main(string[] args)
        {
            float flt = 1F / 3;
            double dbl = 1D / 3;
            decimal dcm = 1M / 3;

            Console.WriteLine("float : {0}\ndouble : {1}\ndecimal : {2}", flt, dbl, dcm);
            Console.WriteLine($"float : {sizeof(float)}\ndouble : {sizeof(double)}\ndecimal : {sizeof(decimal)}");
            Console.WriteLine($"float : {float.MinValue} ~ {float.MaxValue}\ndouble : {double.MinValue} ~ {double.MaxValue}\ndecimal : {decimal.MinValue} ~ {decimal.MaxValue}");
        }
    }
}
