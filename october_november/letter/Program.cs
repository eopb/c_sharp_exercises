using System;
using System.Collections.Generic;

namespace letter
{
    static class Compresser
    {
        public static Dictionary<char, int> letterCount(string s)
        {
            var a = s.ToCharArray();
            var d = new Dictionary<char, int>();
            foreach (char c in a) try { d.Add(c, 1); } catch { d[c] += 1; };
            return d;
        }
        public static Dictionary<char, int> lowerLetterCount(string s) =>
            letterCount(s.ToLower());
    }
    class Program
    {
        static void Main(string[] args)
        {
            foreach (KeyValuePair<char, int> i in Compresser.letterCount("Hi my name is ethan"))
                Console.WriteLine($"Letter {i.Key} is used {i.Value} times.");
        }

    }
}
