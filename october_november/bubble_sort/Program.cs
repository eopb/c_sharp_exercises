using System;

namespace bubble_sort
{
    class SpecBubble
    {
        int[] a;
        public SpecBubble(int[] a)
        {
            this.a = a;
        }
        public static void ascending(int[] a) => Bubble.ascending(a);
    }
    static class Bubble
    {
        public static void ascending(int[] a) => sort(a, (i, j) => i > j);
        public static void descending(int[] a) => sort(a, (i, j) => i < j);
        public static void sort<T>(T[] a, Func<T, T, bool> sortedf)
        {
            bool sorted = false;
            while (!sorted)
            {
                sorted = true;
                for (int i = 0; i < a.Length - 1; i++)
                {
                    int j = i + 1;
                    if (sortedf(a[i], a[j]))
                    {
                        T t = a[j]; a[j] = a[i]; a[i] = t;
                        sorted = false;
                    }
                }
            }
        }
    }
    class Program
    {
        public static void print_array(int[] a)
        {
            Console.Write("\n");
            foreach (int i in a)
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
            int[] a = gen_random();
            Bubble.descending(a);
            print_array(a);
        }
    }
}
