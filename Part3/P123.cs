using System;
using System.Collections.Generic;
using System.Linq;

namespace P123
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
                new Student { Name = "A", Id = 1 , Scores = new List<int>() { 1, 50 } },
                new Student { Name = "B", Id = 2 , Scores = new List<int>() {3, 60} },
                new Student { Name = "C", Id = 3 , Scores = new List<int>() {5, 70} }
            };
            Print(students);

            High(0, 3);
            High(1, 60);
        }
        private static void High(int n ,int cut)
        {
            var high = from Student in students where Student.Scores[n] >= cut select new { Name = Student.Name, Scores = Student.Scores[n] };
            foreach (var v in high)
            {
                Console.Write($"[{v.Name}] : {v.Scores}");
            }
            Console.WriteLine();
        }

        private static void Print(List<Student> value)
        {
            foreach (var v in value)
            {
                Console.Write($"[{v.Name}] [{v.Id}] [{v.Scores[0]} {v.Scores[1]}]  " );
            }
            Console.WriteLine("\n");
        }
    }
}
