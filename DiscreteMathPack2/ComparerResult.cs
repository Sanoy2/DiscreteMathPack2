using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscreteMathPack2
{
    public class ComparerResult
    {
        public int bellmanFordTimeInMS { get; set; }
        public int dijkstraTimeInMS { get; set; }
        public int numberOfNodes { get; set; }
        public int numberOfEdges { get; set; }
        public bool theSameResult { get; set; }

        public ComparerResult()
        {
            bellmanFordTimeInMS = -1;
            dijkstraTimeInMS = -1;
            numberOfNodes = -1;
            numberOfEdges = -1;
            theSameResult = false;
        }

        public override string ToString()
        {
            var builder = new StringBuilder();

            builder.AppendLine("Number of nodes: " + numberOfNodes);

            if(numberOfEdges > numberOfNodes)
                builder.AppendLine("Number of edges: " + numberOfEdges/2);

            builder.AppendLine("Bellman-Ford: " + bellmanFordTimeInMS + " ms");
            builder.AppendLine("Dijkstra: " + dijkstraTimeInMS + " ms");

            builder.AppendLine("The same result: " + theSameResult);

            return builder.ToString();
        }
    }
}
