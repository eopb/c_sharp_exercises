using System;

namespace beans
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    class Beans : ICheckOut
    {
        public decimal GetPrice() => 2.99M;
    }
    public interface ICheckOut
    {
        decimal GetPrice();
    }
}
