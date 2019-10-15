using System;

namespace routine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input an number.");
            int input = Int32.Parse(Console.ReadLine());
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
