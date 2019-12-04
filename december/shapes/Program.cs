using System;
using System.Collections.Generic;

namespace shapes
{
    abstract class Shape
    {
        protected Dictionary<string, decimal> lines;
        public Shape(Dictionary<string, decimal> lines)
        {
            this.lines = lines;
        }
        public virtual decimal area() => 0m;
    }
    class Square : Shape
    {
        private const string keySide = "side";
        public Square(Dictionary<string, decimal> lines) : base(lines)
        {
        }
        public override decimal area() => lines[keySide] * lines[keySide];
    }
    class Circle : Shape
    {
        private const string keySide = "radius";
        public Circle(Dictionary<string, decimal> lines) : base(lines)
        {
        }
        public override decimal area() => (decimal)(Math.Pow((double)lines["radius"], 2) * Math.PI);
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, decimal> dic = new Dictionary<string, decimal>();
            dic.Add("side", 5m);
            dic.Add("radius", 5m);

            Console.WriteLine((new Square(dic)).area());
            Console.WriteLine((new Circle(dic)).area());
        }
    }
}
