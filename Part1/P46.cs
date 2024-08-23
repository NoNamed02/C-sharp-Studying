using System;
namespace A046
{
    class Program
    {
        static void Main(string[] args)
        {
            double max = double.MinValue;
            double min = double.MaxValue;
            double sum = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Write("키 입력 : ");
                double h= double.Parse(Console.ReadLine());

                if( h > max ) max = h;
                if( h < min ) min = h;
                sum += h;
            }
            Console.WriteLine("평균 {0} 최대 {1} 최소 {2}", sum / 5, max, min);
        }
    }
}
