using System;
using System.Collections;
using System.Collections.Generic;

namespace P109
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            foreach (var i  in input)
            {
                Console.Write(i + " ");
            }
            Console.Write(" = ");

            Stack<double> nStack = new Stack<double>();
            foreach (var s in input)
            {
                if (isoperator(s))
                {
                    switch (s)
                    {
                        case "+":
                            nStack.Push(nStack.Pop() + nStack.Pop()); break;
                    }
                }
                else
                {
                    nStack.Push(double.Parse(s));
                }
            }
            Console.WriteLine(nStack.Pop());
        }

        private static bool isoperator(string s)
        {
            if(s == "+" || s == "-")
                return true;
            else
                return false;
        }
    }
}
