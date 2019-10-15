using System;

namespace routine
{
    class Program
    {
        static void Main(string[] args)
        {
            int input;
            while (true)
            {
                Console.Write("Please input an number: ");
                try { input = Int32.Parse(Console.ReadLine()); break; }
                catch { Console.WriteLine("Unable to parse input. Please try again."); continue; }
            }
            Console.WriteLine(
                "The number is equal to 5: {0}\nThe number is a multiple of 7 or 3: {1}",
                equal(input, 5),
                multiple_of_three_or_seven(input)
            );
        }
        static bool equal(int one, int two) =>
            one == two;
        static bool multiple_of_three_or_seven(int num) =>
            (num % 3 == 0) || (num % 7 == 0);
    }
}
