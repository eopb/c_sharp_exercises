using System;
using System.Linq;
using System.Collections.Generic;

namespace binary_search
{
    static class binary
    {
        public static int search<T>(T[] l, T v) where T : IComparable => s(l, v, 0);
        static int s<T>(IEnumerable<T> l, T v, int o) where T : IComparable
        {
            int hl = l.Count() / 2, c = l.ElementAt(hl).CompareTo(v), of = o + hl;
            return c == 0 ? of : s(c < 0 ? l.Skip(hl) : l.Take(hl), v, c < 0 ? of : o);
        }
    }
    class Program
    {
        public static void Main(string[] args) =>
            Console.WriteLine(binary.search(new int[] { 1, 4, 7, 34, 89 }, 89));

    }
}
