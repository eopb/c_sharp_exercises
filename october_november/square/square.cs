using System;

namespace square
{

    class Square
    {
        private double side;


        public double Side
        {
            get { return side; }
            set { side = value; }
        }
        public void printSquare()
        {
            Console.WriteLine(side);
        }
    }
}