using System;

namespace P65
{
    struct DateStruct
    {
        public int year, month, day;
    }

    class DateClass
    {
        public int year, month, day;
    }
    class Program
    {
        static void Main(string[] args)
        {
            //int computer_price = 71968 + 23005 + 42001 + 2662 + 86497 + 51908;
            //Console.WriteLine(computer_price);

            DateStruct sDay;
            sDay.year = 2018;
            sDay.month = 11;
            sDay.day = 22;
            Console.WriteLine($"{sDay.year} {sDay.month} {sDay.day}");

            DateClass cDay = new DateClass();
            cDay.year = 2018;
            cDay.month = 11;
            cDay.day = 22;
            Console.WriteLine($"{cDay.year} {cDay.month} {cDay.day}");

            DateStruct sDay2 = new DateStruct();
            Console.WriteLine($"{sDay2.year} {sDay2.month} {sDay2.day}");

            DateClass cDay2 = new DateClass();
            Console.WriteLine($"{cDay2.year} {cDay2.month} {cDay2.day}");

            DateStruct s = sDay;
            DateClass c = cDay;

            s.year = 2000;
            c.year = 2000;

            Console.WriteLine($"s {s.year} {s.month} {s.day}");
            Console.WriteLine($"c {c.year} {c.month} {c.day}");
            Console.WriteLine($"{sDay.year} {sDay.month} {sDay.day}");
            Console.WriteLine($"{cDay.year} {cDay.month} {cDay.day}");
        }
    }
}
