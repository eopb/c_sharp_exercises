using System;
using System.Threading;

namespace divide_by_zero_exception
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int rndNumber = rnd.Next(0, 11);
            Console.Write($"100 / {rndNumber}");
            try
            {
                double ans = 100 / rndNumber;
                Console.WriteLine($" = {ans}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine(" Can't be done!");
            }
            Thread.Sleep(100);
            Main(args);
        }
    }
}
