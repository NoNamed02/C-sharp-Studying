using System;

namespace A041
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("입력 : ");
            int value = int.Parse(Console.ReadLine());
            string grade = default(string);

            switch (value / 10)
            {
                case 10:
                case 9:
                    grade = "A";
                    break;
                case 8:
                    grade = "B";
                    break;
                case 7:
                    grade = "C";
                    break;
                case 6:
                    grade = "D";
                    break;
                default :
                    grade = "0";
                    break;
            }
            Console.WriteLine(grade);
        }
    }
}
