using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Priority_Queue;
using DiscreteMathPack1Console;

namespace DiscreteMathPack2
{
    public class Dijkstra
    {
        public Graph Graph { get; set; }

        public Dijkstra(Graph graph)
        {
            Graph = graph;
        }

        public int[] Work(bool print = true, int startIndex = 0)
        {
            int NumberOfNodes = Graph.ListOfNodes.Count;
            var queue = new FastPriorityQueue<Node>(100 * 1000);
            Node u;
            int du;
            int dv;
            int wuv;
            int[] d = new int[NumberOfNodes];
            
            for (int i = 0; i < NumberOfNodes; i++)
            {
                d[i] = Int32.MaxValue / 10;
            }

            if (startIndex + 1> NumberOfNodes)
            {
                startIndex = 0;
            }

            d[startIndex] = 0; 

            for (int i = 0; i < NumberOfNodes; i++)
            {
                queue.Enqueue(Graph.GetNode(i), 0);
            }

            while (queue.Any()) // while queue is not empty
            {
                u = queue.Dequeue();

                foreach (var v in u.ListOfEdges)
                {
                    du = d[u.Id];
                    dv = d[v.Target.Id];
                    wuv = v.Weight;

                    if (du + wuv < dv)
                    {
                        d[v.Target.Id] = du + wuv;
                        if (queue.Contains(v.Target))
                        {
                            queue.UpdatePriority(v.Target, d[v.Target.Id]);
                        }
                        else
                        {
                            queue.Enqueue(v.Target, d[v.Target.Id]);
                        }
                    }
                }
            }

            if(print)
            {
                for (int i = 0; i < NumberOfNodes; i++)
                {
                    Console.WriteLine("Id: {0}, distance: {1}", i, d[i]);
                }
            }

            return d;
        }
    }
}
