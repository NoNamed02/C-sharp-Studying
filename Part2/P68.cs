using System;

namespace P68 // 생성자
{
    class Date
    {
        private int _year, _month, _day;

        public Date()
        {
            _year = 1;
            _month = 1;
            _day = 1;
        }

        public Date(int y, int m ,int d)
        {
            _year = y;
            _month = m;
            _day = d;
        }

        public void Print()
        {
            Console.WriteLine($"{_year} {_month} {_day}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Date test = new Date(2000, 11, 22);
            Date test2 = new Date();

            test.Print();
            test2.Print();
        }
    }
}
