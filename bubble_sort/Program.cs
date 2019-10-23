using System;

namespace bubble_sort
{
    class Program
    {
        public static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] a = gen_random();
            System.Console.WriteLine($"length {a.Length}");

            for (bool sorted = false; !sorted; sorted = true)
            {

                for (int i = 0; i < a.Length - 1; i++)
                {
                    int j = i + 1;
                    if (a[i] < a[i + 1])
                    {
                        Console.WriteLine($"{a[i]} {a[j]}");
                        int temp = a[j];
                        a[j] = a[i];
                        a[i] = temp;
                        sorted = false;
                    }
                    print_array(a);
                }
            }


        }
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
            int[] a = new int[8];
            for (int i = 0; i < a.Length - 1; i++)
            {
                a[i] = rnd.Next(1, 101);
            }
            return a;
        }

    }
}
