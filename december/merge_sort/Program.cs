using System;
using System.Linq;
using System.Collections.Generic;

namespace merge_sort
{
    static class Bubble
    {
        public static List<int> ascending(List<int> a) => s(a, (i, j) => i > j);
        public static List<int> descending(List<int> a) => s(a, (i, j) => i < j);
        public static List<T> s<T>(List<T> l, Func<T, T, bool> f) {
            Func<List<T>, List<T>, List<T>> m = (m1, m2) => {
                var mo = new List<T>();
                while (m1.Count > 0 && m2.Count > 0)
                    if (f(m1[0], m2[0])) { mo.Add(m2[0]); m2.RemoveAt(0); }
                    else                 { mo.Add(m1[0]); m1.RemoveAt(0); }
                return mo.Concat(m1).Concat(m2).ToList();
            };
            int n = l.Count;
            return (n <= 1) ? l : m(s(l.Take(n / 2).ToList(), f), s(l.Skip(n / 2).ToList(), f));
        }
    }
    class Program
    {
        public static void print_array(int[] l)
        {
            Console.Write("\n");
            foreach (int i in l)
                Console.Write($"{i},");
            Console.Write("\n");
        }
        public static int[] gen_random()
        {
            Random rnd = new Random();
            int[] a = new int[200];
            for (int i = 0; i < a.Length - 1; i++)
            {
                a[i] = rnd.Next(1, 101);
            }
            return a;
        }
        public static void Main(string[] args)
        {
            Random rnd = new Random();
            List<int> a = Bubble.descending(gen_random().ToList());
            print_array(a.ToArray());
        }
    }
}
