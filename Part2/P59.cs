using System;

/*
    자료형 [ , ] 배열명 = new 자료형 [ , ]
    자료형 [] [] 배열명 = new 자료형 [] []  - 가변형 
 */

namespace P59 // 다차원 배열
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2차원 배열 : arrA[2, 3]");
            int[,] arrA = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };

            for (int i = 0; i < arrA.GetLength(0); i++)
            {
                for (int j = 0; j < arrA.GetLength(1); j++)
                    Console.Write(arrA[i, j] + " ");
                Console.WriteLine();
            }

            Console.WriteLine("가변 배열 arrB");
            int[][] arrB = new int[2][];
            arrB[0] = new int[] { 1, 2};
            arrB[1] = new int[] { 3, 4, 5 };
            for (int i = 0;i < 2;i++)
            {
                for (int j = 0;j < arrB[i].Length;j++)
                    Console.Write(arrB[i][j] + " ");
                Console.WriteLine();
            }
        }
    }
}
