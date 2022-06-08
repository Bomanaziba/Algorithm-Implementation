using System;
using System.Collections.Generic;

namespace Algorithm.Graph 
{

    public class Graph<T> 
    {
        public Dictionary<T, HashSet<T>> adjacencyList { get; } = new Dictionary<T, HashSet<T>>();
        
        public Graph() 
        {}

        public Graph(IEnumerable<T> vertices, IEnumerable<Tuple<T,T>> edges) 
        {
            foreach(var vertex in vertices)
                AddVertex(vertex);

            foreach(var edge in edges)
                AddEdge(edge);
        }

        public void AddVertex(T vertex) 
        {
            adjacencyList[vertex] = new HashSet<T>();
        }

        public void AddEdge(Tuple<T,T> edge) 
        {
            if (adjacencyList.ContainsKey(edge.Item1) && adjacencyList.ContainsKey(edge.Item2)) 
            {
                adjacencyList[edge.Item1].Add(edge.Item2);
                adjacencyList[edge.Item2].Add(edge.Item1);
            }
        }
    }
}