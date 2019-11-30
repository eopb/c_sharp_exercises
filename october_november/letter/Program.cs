using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace letter
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (KeyValuePair<char, int> i in letterCount("Hi my name is ethan"))
                Console.WriteLine($"Letter {i.Key} is used {i.Value} times.");
        }
        static Dictionary<char, int> letterCount(string s)
        {
            var a = s.ToCharArray();
            var d = new Dictionary<char, int>();
            foreach (char c in a) try { d.Add(c, 1); } catch { d[c] += 1; };
            return d;
        }
        static ImmutableDictionary<char, int> functionalLetterCount(string s) =>
            s.ToCharArray().Aggregate<char, ImmutableDictionary<char, int>>(
                ImmutableDictionary.CreateBuilder<char, int>,
                (d, c) =>
                {

                    try { return d.Add(c, 1); }
                    catch { return d.SetItem(c, d[c] + 1); }
                }
            );


    }
}
