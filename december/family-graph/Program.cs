using System;
using System.IO;
using System.Linq;

namespace family_graph
{
    class Graph
    {
        string[] names;
        double[][] relationships;
        public Graph(string path)
        {
            var output = File.ReadAllLines(path);
            names = output[0].Split(',');
            relationships = output
                .Skip(1)
                .Select(i => i.Split(',').Select(j => Double.Parse(j)).ToArray()).ToArray();
        }
        public string print() =>
            $"{string.Join(",", names)}\n{string.Join("\n", relationships.Select(j => string.Join(",", j)))}";

    }
    class Program
    {
        static void Main(string[] args)
        {
            string path = "/home/efun/Documents/git/ethanboxx/github/csharp/c_sharp_exercises/december/family-graph/data.csv";
            Graph graph = new Graph(path);
            System.Console.WriteLine(graph.print());
            File.WriteAllText(
                "/home/efun/Documents/git/ethanboxx/github/csharp/c_sharp_exercises/december/family-graph/dataout.csv",
                graph.print()
            );
            // foreach (string line in output) System.Console.WriteLine(line);
        }
    }
}
