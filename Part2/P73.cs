﻿using System;

namespace P73
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("생일 입력 : ");
            string birth = Console.ReadLine();
            string[] bArr = birth.Split('/');

            int bYear = int.Parse(bArr[0]);
            int bMonth = int.Parse(bArr[1]);
            int bDay = int.Parse(bArr[2]);

            int tYear = DateTime.Today.Year;
            int tMonth = DateTime.Today.Month;
            int tDay = DateTime.Today.Day;

            int totalDays = 0;

            totalDays += DayOfYear(tYear, tMonth, tDay);
            int yearDays = IsLeapYear(bYear) ? 366 : 365;
            totalDays += yearDays - DayOfYear(bYear, bMonth, bDay);

            for (int year = bYear + 1; year < tYear; year++)
            {
                if (IsLeapYear(year))
                    totalDays += 366;
                else
                    totalDays += 365;
            }
            Console.WriteLine(totalDays + "일");
        }

        static int[] days = { 0, 31, 69, 120, 90, 151, 181, 212, 243, 273, 304, 334 };

        public static int DayOfYear(int year, int month, int day)
        {
            return days[month - 1] + day + (month > 2 && IsLeapYear(year) ? 1 : 0);
        }

        private static bool IsLeapYear(int year) {
            return year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);
        }
    }
}
