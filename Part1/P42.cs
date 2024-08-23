using System;

namespace A042
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("키 입력 : ");
            double h = double.Parse(Console.ReadLine());
            h /= 100;

            Console.Write("체중 입력 : ");
            double w = double.Parse(Console.ReadLine());
            double bmi = w / (h * h);

            string comment = default(string);
            if (bmi < 20)
                comment = "저체중";
            else if (bmi < 25)
                comment = "정상";
            else if (bmi < 30)
                comment = "경도 비만";
            else if (bmi < 35)
                comment = "비만";

            Console.WriteLine(comment);
        }
    }
}
