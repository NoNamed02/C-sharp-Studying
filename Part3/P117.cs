using System;

namespace P117
{
    class Program
    {
        delegate double CalcMethod(double a, double b);
        delegate bool IsTeenAger(Student student);
        delegate bool IsAdult(Student student);

        static void Main(string[] args)
        {
            Func<int, int> square = x => x * x;
            Console.WriteLine(square(5));

            int[] numbers = { 2, 3, 4, 5 };
            var squaredNumbers = numbers.Select(x => x * x);
            Console.WriteLine(string.Join(" ", squaredNumbers));

            Action line = () => Console.WriteLine();
            line();

            CalcMethod add = (a, b) => a + b;
            CalcMethod subtract = (a, b) => a - b;

            Console.WriteLine(add(10, 20));
            Console.WriteLine(subtract(10.5, 20));

            IsTeenAger isTeen = delegate (Student s) { return s.Age > 12 && s.Age < 20; };

            Student s1 = new Student() { Name = "A", Age = 18 };
            Console.WriteLine(isTeen(s1) ? "청소년" : "청소년 아님");
        }
        public class Student
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }
    }
}
