using System;

namespace square
{
    class Program
    {
        static void Main(string[] args)
        {
            Square mysquare = new Square(),
                mysquare2 = new Square();
            mysquare.Side = 1;
            mysquare2.Side = 5;
            Console.WriteLine("Hello World!" + mysquare.Side);
            mysquare.printSquare();
            mysquare2.printSquare();
        }
    }
}
