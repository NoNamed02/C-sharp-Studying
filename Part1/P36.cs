using System;

namespace A036
{
    class Program
    {
        static void Main(string[] args)
        {
            string animal = null;

            Console.WriteLine("4글자 이상 동물 이름 출력");
            do
            {
                LongNameAnimal(animal);
            } while ((animal = Console.ReadLine()) != "");
        }
        private static void LongNameAnimal(string animal)
        {
            if (animal?.Length >= 4)
            {
                Console.WriteLine($"{animal} : {animal.Length}");
            }
        }
    }
}
