using System;

namespace bubble_sort
{
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
            bool sorted = false;
            while (!sorted)
            {
                sorted = true;
                for (int i = 0; i < a.Length - 1; i++)
                {
                    int j = i + 1;
                    if (a[i] < a[j])
                    {
                        int t = a[j]; a[j] = a[i]; a[i] = t;
                        sorted = false;
                    }
                    print_array(a);
                }
            }
        }
    }
}
