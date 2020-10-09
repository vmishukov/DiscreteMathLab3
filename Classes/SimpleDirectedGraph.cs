using System;
using System.Collections.Generic;
using System.Linq;

namespace GraphLibrary
{
    public class SimpleDirectedGraph<TV, TK> : AbstractGraph<TV, TK>
    {
        public override bool AddEdge(TV v1, TV v2, TK weigth)
        {
            if (v1 == null || v2 == null || weigth == null)
                throw new ArgumentNullException();
            if (!VertexSet.Contains(v1) || !VertexSet.Contains(v2))
                return false;
            IPairValue<TV> pair = new PairValue<TV>(v1, v2);
            if (EdgeSet.Contains(pair))
                return false;
            EdgeSet.Add(pair);
            Weigths[pair] = weigth;
            return true;
        }

        public override TK GetWeigth(TV v1, TV v2)
        {
            if (v1 == null || v2 == null)
                throw new ArgumentNullException();
            IPairValue<TV> pair = new PairValue<TV>(v1, v2);
            if (!Weigths.ContainsKey(pair))
                throw new ArgumentException();
            return Weigths[pair];
        }

        public override bool DeleteEdge(TV v1, TV v2)
        {
            if (v1 == null || v2 == null)
                throw new ArgumentNullException();
            IPairValue<TV> pair = new PairValue<TV>(v1, v2);
            if (EdgeSet.Contains(pair))
            {
                EdgeSet.Remove(pair);
                Weigths.Remove(pair);
                return true;
            }
            return false;
        }

        public  void DeleteEdges()
        {

            EdgeSet.Clear();
            Weigths.Clear(); 
         
        }
        public List<string> BFS(int s)
        {

            // Mark all the vertices as not 
            // visited(By default set as false)  
            bool[] visited = new bool[VertexSet.Count()];
            for (int i = 0; i < VertexSet.Count()-1; i++)
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
                List<TV> list = AdjacentVertex(VertexSet[s]).ToList();
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
        public override bool AreAdjacent(TV v1, TV v2)
        {
            if (v1 == null || v2 == null)
                throw new ArgumentNullException();
            if (!VertexSet.Contains(v1) || !VertexSet.Contains(v2))
                throw new ArgumentException();
            return EdgeSet.Contains(new PairValue<TV>(v1, v2));
        }

        public override int Degree(TV vertex)
        {
            if (vertex == null)
                throw new ArgumentNullException();
            if (!VertexSet.Contains(vertex))
                throw new ArgumentException();
            return InDegree(vertex) + OutDegree(vertex);
        }

        public override int OutDegree(TV vertex)
        {
            if (vertex == null)
                throw new ArgumentNullException();
            if (!VertexSet.Contains(vertex))
                throw new ArgumentException();
            int counter = 0;
            foreach (var pair in EdgeSet)
                if (pair.GetFirst().Equals(vertex))
                    counter++;
            return counter;
        }

        public override int InDegree(TV vertex)
        {
            if (vertex == null)
                throw new ArgumentNullException();
            if (!VertexSet.Contains(vertex))
                throw new ArgumentException();
            int counter = 0;
            foreach (var pair in EdgeSet)
                if (pair.GetSecond().Equals(vertex))
                    counter++;
            return counter;
        }

        public override IEnumerable<TV> AdjacentVertex(TV vertex)
        {
            foreach (IPairValue<TV> p in EdgeSet)
                if (p.GetFirst().Equals(vertex))
                    yield return p.GetSecond();
        }
    }
}
