using System;
using System.Collections.Generic;

namespace stack
{
    class Program
    {
        static void Main(string[] args)
        {

            var s = new Stack<Char>();

            s.push('h'); s.push('e'); s.push('l'); s.push('l'); s.push('o');


            foreach (int i in s.a)
                Console.Write(i.ToString());

            Console.WriteLine("\nbackspacing"); s.pop();

            foreach (int i in s.a)
                Console.Write(i.ToString());
        }
    }
    class Stack<T>
    {
        public List<T> a;


        public Stack() { a = new List<T>(); }
        public T pop() { T i = a[a.Count - 1]; a.RemoveAt(a.Count - 1); return i; }
        public void push(T t) => a.Add(t);

        public bool isEmpty() => a.Count == 0;
    }

    class Queue<T>
    {
        public List<T> a;


        public Queue() { a = new List<T>(); }
        public T pop() { T i = a[0]; a.RemoveAt(0); return i; }
        public void push(T t) => a.Add(t);

        public bool isEmpty() => a.Count == 0;
    }
    class CirclularQueue<T>
    {
        public List<T> a;
        public int l;

        public CirclularQueue(int l) { a = new List<T>(); this.l = l; }
        public T pop() { T i = a[0]; a.RemoveAt(0); return i; }
        public void push(T t) { a.Add(t); if (a.Count > l) pop(); }

        public bool isEmpty() => a.Count == 0;
    }
}
