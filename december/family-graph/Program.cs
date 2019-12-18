using System;
using System.IO;
using System.Linq;

namespace family_graph
{
    class Graph
    {
        string[] names;
        bool[][] relationships;
        public Graph(string path)
        {
            var output = File.ReadAllLines(path);
            names = output[0].Split(',');
            relationships = output
                .Skip(1)
                .Select(i => i.Split(',').Select(j => Int32.Parse(j) != 0).ToArray()).ToArray();
        }
        public void print()
        {
            foreach (string name in names) System.Console.Write($"{name},");
            System.Console.WriteLine();
            foreach (bool[] i in relationships)
            {
                foreach (bool j in i) System.Console.Write($"{j}, ");
                System.Console.WriteLine();
            };
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            string path = "/home/efun/Documents/git/ethanboxx/github/csharp/c_sharp_exercises/december/family-graph/data.csv";
            Graph graph = new Graph(path);
            graph.print();
            // foreach (string line in output) System.Console.WriteLine(line);
        }
    }
}
