using System;
using System.Collections.Generic;

namespace letter
{
    class Compresser
    {
        string s;
        public Compresser(string s) { this.s = s; }
        public Dictionary<char, int> letterCount()
        {
            var a = s.ToCharArray();
            var d = new Dictionary<char, int>();
            foreach (char c in a) try { d.Add(c, 1); } catch { d[c] += 1; };
            return d;
        }
    }
    class LowerCompresser
    {
        Compresser c;
        LowerCompresser(string s) { c = new Compresser(s.ToLower()); }
        public Dictionary<char, int> LetterCount() =>
            c.letterCount();
    }
    class Program
    {
        static void Main(string[] args)
        {
            foreach (KeyValuePair<char, int> i in (new Compresser("Hi my name is ethan")).letterCount())
                Console.WriteLine($"Letter {i.Key} is used {i.Value} times.");
        }

    }
}
