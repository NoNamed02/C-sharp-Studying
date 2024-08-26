using System;
namespace P72
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int year = 2001; year <= 2100; year++)
            {
                if(YearCheck(year))
                {
                    Console.Write(year + " ");
                }
            }
        }

        static bool YearCheck(int year)
        {
            return year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);
        }
    }
}
