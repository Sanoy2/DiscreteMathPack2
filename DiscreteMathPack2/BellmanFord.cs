using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiscreteMathPack1Console;
using Priority_Queue;

namespace DiscreteMathPack2
{
    public class BellmanFord
    {
        public Graph Graph { get; set; }

        public BellmanFord(Graph graph)
        {
            Graph = graph;
        }

        public int[] Work(bool print = true, int startIndex = 0)
        {
            return WorkOld(print, startIndex);
        }



        private int[] WorkOld (bool print = true, int startIndex = 0)
        {
            int NumberOfNodes = Graph.ListOfNodes.Count;

            int[] d = new int[NumberOfNodes];
            Node u;
            int du, dv, wuv;

            for (int i = 0; i < NumberOfNodes; i++)
            {
                d[i] = Int32.MaxValue / 10;
            }

            if (startIndex + 1 > NumberOfNodes)
            {
                startIndex = 0;
            }

            d[startIndex] = 0;
            for(int j = 0; j < NumberOfNodes; j++)
            {
                for (int i = 0; i < NumberOfNodes; i++)
                {
                    u = Graph.GetNode(i);
                    foreach (var v in u.ListOfEdges)
                    {
                        du = d[u.Id];
                        dv = d[v.Target.Id];
                        wuv = v.Weight;

                        if (du + wuv < dv)
                        {
                           d[v.Target.Id] = du + wuv;
                        }
                    }
                }
            }

            if (print)
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
