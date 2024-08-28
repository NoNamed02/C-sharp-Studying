using System;
using System.Collections.Generic;
using System.Linq;

namespace P124
{
    class Student
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public List<int> Scores { get; set; }
    }
    class Program
    {
        static List<Student> students;
        static void Main(string[] args)
        {
            students = new List<Student>()
            {
                new Student { Name = "A", Id = 1 , Scores = new List<int>() { 80, 80 } },
                new Student { Name = "B", Id = 2 , Scores = new List<int>() {90, 80} },
                new Student { Name = "C", Id = 3 , Scores = new List<int>() {5, 80} },
                new Student { Name = "D", Id = 4 , Scores = new List<int>() {5, 90} }
            };

            var result = from v in students
                         group v by v.Scores.Average() >= 80 into g
                         select new
                         {
                             key = g.Key? "over 80" : "low 80",
                             count  = g.Count(),
                             avr = g.Average(v => v.Scores.Average()),
                             max = g.Max(v => v.Scores.Max())
                         };
            foreach ( var v in result )
            {
                Console.WriteLine( $"{v.key} 학생수 {v.count}" );
                Console.WriteLine($"{v.key} 평균 {v.avr:F2}");
                Console.WriteLine($"{v.key} 최고 {v.max:F2}");
                Console.WriteLine();
            }
        }
    }
}
