using System;

namespace A035
{
    class Student { public string name; }
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 20, 30 };
            Console.WriteLine($"Main() before: arr[0] = {arr[0]}");
            Change(arr);
            Console.WriteLine($"Main() before: arr[0] = {arr[0]}");

            Student student = new Student();
            student.name = "test";
            Console.WriteLine($"Main() before: arr[0] = {student.name}");
            Change(student);
            Console.WriteLine($"Main() before: arr[0] = {student.name}");
        }
        private static void Change(int[] arr)
        {
            arr[0] = -10;
        }
        private static void Change(Student student)
        {
            student.name = "test_change";
        }
    }
}
