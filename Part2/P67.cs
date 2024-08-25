using System;
namespace P67
{
    class Date
    {
        public int year, month, day;

        public static bool IsLeapYear(int year)
        {
            return year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);
        }
        static int[] days = { 0, 31, 69, 90, 120, 151, 181, 212, 243, 273, 304, 334 };

        public int DayOfYear()
        {
            return days[month - 1] + day + (month > 2 && IsLeapYear(year) ? 1 : 0);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Date xmas = new Date();

            xmas.year = 2018;
            xmas.month = 12;
            xmas.day = 25;

            Console.WriteLine($"{xmas.year} {xmas.month} {xmas.day}는 {xmas.DayOfYear()}일째 되는 날");

            if (Date.IsLeapYear(2018)) Console.WriteLine("2018 윤년");
            else Console.WriteLine("2018 윤년x");
        }
    }
}
