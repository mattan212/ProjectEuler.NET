using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEulerNet.Models
{
    public class Graph<T>
    {
        public List<Vertex<T>> Vertices { get; set; }
        public List<Edge<T>> Edges { get; set; }

        public static Graph<T> Parse<T>(string pyramid, Func<string, T> TParser)
        {
            var graph = new Graph<T>
            {
                Edges = new List<Edge<T>>(),
                Vertices = new List<Vertex<T>>()
            };
            
            var lines = pyramid.Split(Environment.NewLine);
            var id = 0;

            List<Vertex<T>> nodes;
            foreach (var line in lines)
            {
                nodes = line.Split(' ').Select(x => new Vertex<T>
                {
                    Id = id++,
                    Edges = new List<Edge<T>>(),
                    Value = TParser(x)
                }).ToList();

                graph.Vertices.AddRange(nodes);
            }


            id = 0;
            for (var i = 1; i <= lines.Count(); i++)
            {
                for (var j = 0; j < i; j++)
                {
                    var nodeIndex = i + j * 1;
                    graph.Edges.Add(new Edge<T>
                    {
                        From = graph.Vertices[i],
                        To = graph.Vertices[nodeIndex],
                        Id = id++
                    });
                }
            }

            return graph;
        }
    }

    public class Vertex<T>
    {
        public int Id { get; set; }

        public T Value { get; set; }

        public List<Edge<T>> Edges { get; set; }
    }

    public class Edge<T>
    {
        public int Id { get; set; }

        public T Value { get; set; }

        public Vertex<T> From { get; set; }
        public Vertex<T> To { get; set; }
    }
}
