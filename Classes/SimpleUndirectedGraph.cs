﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace GraphLibrary
{
    public class SimpleUndirectedGraph <T,TK> : AbstractGraph<T,TK>
    {
        public override bool AddEdge(T v1, T v2, TK weigth)
        {
            if (v1 == null || v2 == null || weigth == null)
                throw new ArgumentNullException();
            if (!VertexSet.Contains(v1) || !VertexSet.Contains(v2))
                return false;
            IPairValue<T> pair = new PairValue<T>(v1, v2);
            IPairValue<T> returningPair = new PairValue<T>(v2, v1);
            if (EdgeSet.Contains(pair) || EdgeSet.Contains(returningPair))
                return false;
            EdgeSet.Add(pair);
            EdgeSet.Add(returningPair);
            Weigths[pair] = weigth;
            Weigths[returningPair] = weigth;
            return true;
        }

        public override TK GetWeigth(T v1, T v2)
        {
            if (v1 == null || v2 == null)
                throw new ArgumentNullException();
            IPairValue<T> pair = new PairValue<T>(v1, v2);
            if (!Weigths.ContainsKey(pair))
                throw new ArgumentException();
            return Weigths[pair];
        }

        public override bool DeleteEdge(T v1, T v2)
        {
            if (v1 == null || v2 == null)
                throw new ArgumentNullException();
            IPairValue<T> pair = new PairValue<T>(v1, v2);
            IPairValue<T> returningPair = new PairValue<T>(v2, v1);
            if (EdgeSet.Contains(pair) && EdgeSet.Contains(returningPair))
            {
                EdgeSet.Remove(pair);
                EdgeSet.Remove(returningPair);
                Weigths.Remove(pair);
                Weigths.Remove(returningPair);
                return true;
            }
            return false;
        }

        public override bool AreAdjacent(T v1, T v2)
        {
            if (v1 == null || v2 == null)
                throw new ArgumentNullException();
            if (!VertexSet.Contains(v1) || !VertexSet.Contains(v2))
                throw new ArgumentException();
            return EdgeSet.Contains(new PairValue<T>(v1, v2));
        }

        public override int Degree(T vertex)
        {
            if (vertex == null)
                throw new ArgumentNullException();
            if (!VertexSet.Contains(vertex))
                throw new ArgumentException();
            int counter = 0;
            foreach(IPairValue<T> pair in EdgeSet)
                if (pair.GetFirst().Equals(vertex))
                    counter++;
            return counter;
        }

        public override int OutDegree(T vertex)
        {
            if (vertex == null)
                throw new ArgumentNullException();
            if (!VertexSet.Contains(vertex))
                throw new ArgumentException();
            return Degree(vertex);
        }

        public override int InDegree(T vertex)
        {
            if (vertex == null)
                throw new ArgumentNullException();
            if (!VertexSet.Contains(vertex))
                throw new ArgumentException();
            return Degree(vertex);
        }
        public List<string> BFS(int s)
        {

            // Mark all the vertices as not 
            // visited(By default set as false)  
            bool[] visited = new bool[VertexSet.Count()];
            for (int i = 0; i < VertexSet.Count() - 1; i++)
                visited[i] = false;

            // Create a queue for BFS  
            List<int> queue = new List<int>();
            List<string> rofl = new List<string>();
            // Mark the current node as  
            // visited and enqueue it  
            visited[s] = true;
            queue.Add(s);

            while (queue.Any())
            {
                s = queue.First();
                rofl.Add(VertexSet[s].ToString());
                queue.RemoveAt(queue.IndexOf(queue.First()));
                List<T> list = AdjacentVertex(VertexSet[s]).ToList();
                foreach (var val in list)
                {
                    if (!visited[VertexSet.IndexOf(val)])
                    {
                        visited[VertexSet.IndexOf(val)] = true;
                        queue.Add(VertexSet.IndexOf(val));
                    }
                }
            }
            return rofl;
        }
        public void DeleteEdges()
        {
            EdgeSet.Clear();
            Weigths.Clear();
        }
        public override IEnumerable<T> AdjacentVertex(T vertex)
        {
            if (vertex == null)
                throw new ArgumentNullException();
            if (!VertexSet.Contains(vertex))
                throw new ArgumentException();
            foreach (IPairValue<T> p in EdgeSet)
                if (p.GetFirst().Equals(vertex))
                    yield return p.GetSecond();
        }
    }
}
