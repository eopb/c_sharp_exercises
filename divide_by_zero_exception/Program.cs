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
            try
            {
                double ans = 100 / rndNumber;
                Console.WriteLine($"100 / {rndNumber} = {ans}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine($"100 / {rndNumber} Can't be done!");
            }
            Thread.Sleep(100);
            Main(args);
        }
    }
}
