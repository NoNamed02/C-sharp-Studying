using System;
using System.Collections.Generic;

namespace P110
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> colorTable = new Dictionary<string, string>();

            colorTable.Add("Red", "빨강");
            colorTable.Add("Green", "초록");

            foreach (var value in colorTable)
                Console.WriteLine($"colorTable [{value.Key}] = {value.Value}");

            try
            {
                colorTable.Add("Red", "빨강");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine(colorTable["Red"]);
            Console.WriteLine(colorTable["Green"]);
        }
    }
}
