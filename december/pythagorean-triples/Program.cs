using System;
using System.Collections.Generic;
using System.Linq;

namespace pythagorean_triples
{
    class Program
    {
        static IEnumerable<string> allTriples()
        {
            for (int a = 1; ; a++) for (int b = 1; b <= a; b++)
                {
                    var c = Math.Sqrt(a * a + b * b);
                    if (Math.Floor(c) == c) yield return $"{a},{b},{c}";
                }
        }
        static void Main()
        {
            foreach (var s in allTriples()) Console.WriteLine(s);
        }
    }
}