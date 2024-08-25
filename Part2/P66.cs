using System;

namespace P66
{
    class Product
    {
        public string name;
        public int price;
    }
    class MyMath
    {
        public static double PI = 3.14;
    }
    class MyCalendar
    {
        public const int months = 12;
        public const int weeks = 52;
        public const int days = 365;

        public const double daysPerWeek = (double)days / (double)weeks;
        public const double daysPerMonth = (double)days / (double)months;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Product p = new Product();
            p.name = "Test";
            p.price = 100;

            Console.WriteLine($"{p.name} {p.price}");
            Console.WriteLine($"원주율 : {MyMath.PI}");
            Console.WriteLine($"한달은 평균 {MyCalendar.daysPerMonth :F3}");
        }
    }
}
