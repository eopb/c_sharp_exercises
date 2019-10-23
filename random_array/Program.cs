using System;

namespace random_array
{
    public class Program
    {

        public static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] rndNumbers = new int[] {
                rnd.Next(1, 101), rnd.Next(1, 101), rnd.Next(1, 101), rnd.Next(1, 101) };
            foreach (int i in rndNumbers)
                Console.WriteLine($"Random number {i}");
        }
    }
}
