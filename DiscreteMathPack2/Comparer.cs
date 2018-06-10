using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiscreteMathPack1Console;

namespace DiscreteMathPack2
{
    public class Comparer
    {
        public Stopwatch Stopwatch { get; set; }

        public Comparer()
        {
            Stopwatch = new Stopwatch();
        }

        public ComparerResult RunTest(int numberOfNodes, int numberOfEdges, bool printCompareResult = false, bool printGraph = false, bool printAlgorithmsResult = false)
        {
            var result = new ComparerResult();

            int[] bellmanFordResult;
            int[] dijkstraResult;

            var graph = new Graph(numberOfNodes, numberOfEdges);
            graph.GenerateGraph(printGraph);

            result.numberOfNodes = graph.ListOfNodes.Count;
            result.numberOfEdges = graph.GetNumberOfEdges();

            var BellmanFord = new BellmanFord(graph);
            var Dijkstra = new Dijkstra(graph);

            Stopwatch.Start();
            bellmanFordResult = BellmanFord.Work(printAlgorithmsResult);
            Stopwatch.Stop();

            result.bellmanFordTimeInMS = Stopwatch.GetResultInMs();

            Stopwatch.Start();
            dijkstraResult = Dijkstra.Work(printAlgorithmsResult);
            Stopwatch.Stop();

            result.dijkstraTimeInMS = Stopwatch.GetResultInMs();

            result.theSameResult = Enumerable.SequenceEqual(bellmanFordResult, dijkstraResult);

            if (printCompareResult)
            {
                Console.WriteLine(result.ToString());
            }

            return result;
        }

    }
}
