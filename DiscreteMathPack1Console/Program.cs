using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiscreteMathPack2;


namespace DiscreteMathPack1Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==PROGRAM STARTED==");

            bool printComparerResult = true;
            bool printGraph = false;
            bool printAlgorithmsResults = false;

            int numberOfNodes = 5;
            int numberOfEdges = 4;

            int[] nodesSet = {10, 100, 200, 300, 400, 500, 1000, 1500, 2000, 2500, 3000, 5000};
            //int[] nodesSet = {100, 200, 300};
            int[] edgesSet = new int[nodesSet.Length];

            for (int i = 0; i < edgesSet.Length; i++)
            {
                edgesSet[i] = (int)(((0.13 * nodesSet[i] * nodesSet[i]) - (2.26 * nodesSet[i]) + 380));
                edgesSet[i] *= 2;
            }

            Comparer comparer;
            ComparerResult result;

            comparer = new Comparer();

            result = comparer.RunTest
            (
                numberOfNodes,
                numberOfEdges,
                false,
                false,
                false
            );

            string line = "Nodes, Edges, Bellman-Ford, Dijkstra";

            using (System.IO.StreamWriter file =
                new System.IO.StreamWriter(@"C:\Users\Krzysztof\Desktop\mathResults.txt"))
            {
                file.WriteLine(line);

                for (int i = 0; i < nodesSet.Length; i++)
                {
                    numberOfNodes = nodesSet[i];
                    numberOfEdges = edgesSet[i];
                    result = comparer.RunTest
                    (
                        numberOfNodes,
                        numberOfEdges,
                        printComparerResult,
                        printGraph,
                        printAlgorithmsResults
                    );

                    line = numberOfNodes + "," + numberOfEdges + "," + result.bellmanFordTimeInMS + "," +
                           result.dijkstraTimeInMS;

                    file.WriteLine(line);
                }
            }

            Console.WriteLine("==DONE==");
            Console.ReadKey();
        }
    }
}
