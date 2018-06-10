using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using MoreLinq;

namespace DiscreteMathPack1Console
{
    public class Graph
    {
        public int NumberOfNodes { get; private set; }
        public int MinNumberOfEdges { get; private set; }
        public List<Node> ListOfNodes { get; private set; }
        private int minWeight = 4;
        private int maxWeight = 100;
        private Random random;
        private int NumberOfEdgeMultiplier = 100;

        public Graph(int numberOfNodes)
        {
            var minNumberOfEdges = numberOfNodes * NumberOfEdgeMultiplier;

            init(numberOfNodes, minNumberOfEdges);
        }

        public Graph(int numberOfNodes, int minNumberOfEdges)
        {
            init(numberOfNodes, minNumberOfEdges);
        }

        private void init(int numberOfNodes, int minNumberOfEdges)
        {
            NumberOfNodes = MakeNonNegative(numberOfNodes);
            InitList();
            random = new Random();
            random.Next();
            MinNumberOfEdges = minNumberOfEdges;
        }

        public int GetNumberOfEdges()
        {
            int edges = 0;

            foreach (var node in ListOfNodes)
            {
                edges += node.ListOfEdges.Count;
            }

            return edges;
        }

        public Node GetNode(int Id)
        {
            return ListOfNodes.Find(n => n.Id == Id);
        }

        public void AddSpecificNode(Node node)
        {
            if (CheckIfNodeExists(node.Id))
            {
                node.Id = GetNextId();
            }
            
            ListOfNodes.Add(node);
        }

        public void AddNode()
        {
            ListOfNodes.Add(new Node(GetNextId()));
        }


        /// <summary>
        /// Clear all nodes, creates new nodes basing on NumberOfNodes
        /// </summary>
        public void GenerateGraph(bool print = false)
        {
            ListOfNodes.Clear();
            for (int i = 0; i < NumberOfNodes; i++)
            {
                AddNode();
            }

            //GenerateGraphEdgesBothWay();
            NewGenerateGraphEdgesBothWay();

            if (print)
            {
                Console.WriteLine(this.ToString());
            }
        }


        private void GenerateGraphEdgesBothWay()
        {
            if (ListOfNodes.Count < 4)
                throw new Exception("Should be at least 5 nodes!");

            ListOfNodes[0].AddEdgeTwoWay(GetRandomNode(), GetRandomWeight());

            foreach (var node in ListOfNodes)
            {
                node.AddEdgeTwoWay(GetRandomNodeWithExistingConnection(), GetRandomWeight());
            }

            while (GetNumberOfEdges() <= MinNumberOfEdges)
            {
                GetRandomNode().AddEdgeTwoWay(GetRandomNodeWithExistingConnection(), GetRandomWeight());
            }
        }

        private void NewGenerateGraphEdgesBothWay()
        {
            if (ListOfNodes.Count < 4)
                throw new Exception("Should be at least 5 nodes!");

            ListOfNodes[0].AddEdgeTwoWay(GetRandomNode(), GetRandomWeight());

            foreach (var node in ListOfNodes)
            {
                node.AddEdgeTwoWay(GetRandomNodeWithExistingConnection(), GetRandomWeight());
            }

            Node tmp;

            while (GetNumberOfEdges() < MinNumberOfEdges)
            {
                tmp = ListOfNodes.MinBy(p => p.ListOfEdges.Count);
                tmp.AddEdgeTwoWay(GetRandomNodeWithExistingConnection(), GetRandomWeight());
            }
        }

        private Node GetRandomNode()
        {
            return ListOfNodes[GetRandomNodeId()];
        }

        private Node GetRandomNodeWithExistingConnection()
        {
            int id = 1;

            do
            {
                id = GetRandomNodeId();
            } while (!ListOfNodes[id].ListOfEdges.Any());

            var node = ListOfNodes[id];

            return node;
        }

        private int GetRandomNodeId()
        {
            return random.Next(1, ListOfNodes.Count);
        }

        private int GetRandomWeight()
        {
            return random.Next(minWeight, maxWeight);
        }

        private void ClearAllEdges()
        {
            foreach (var node in ListOfNodes)
            {
                node.ListOfEdges.Clear();
            }
        }

        private int GetNextId()
        {
            int Id = 0;

            if (ListOfNodes.Any())
            {
                Id = ListOfNodes.Max(n => n.Id);
                Id++;
            }
            else
            {
                Id = 0;
            }
            
            return Id;
        }

        private bool CheckIfNodeExists(int Id)
        {
            return ListOfNodes.Exists(n => n.Id == Id);
        }

        private void InitList()
        {
            ListOfNodes = new List<Node>();
        }

        private int MakeNonNegative(int number)
        {
            if (number >= 0)
            {
                return number;
            }

            return -number;

        }

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendLine("====================");
            builder.AppendLine("GRAPH BEGINS HERE");
            builder.AppendLine("====================");
            builder.AppendLine("Number of nodes: " + NumberOfNodes);
            builder.AppendLine("Real number of nodes: " + ListOfNodes.Count);
            builder.AppendLine("Minimum number of edges: " + MinNumberOfEdges/2);
            builder.AppendLine("Real number of edges: " + GetNumberOfEdges()/2);
            builder.AppendLine("NODES:");

            foreach (var node in ListOfNodes)
            {
                builder.AppendLine(node.ToString());
            }

            builder.AppendLine("====================");
            builder.AppendLine("Number of nodes: " + NumberOfNodes);
            builder.AppendLine("Real number of nodes: " + ListOfNodes.Count);
            builder.AppendLine("Minimum number of edges: " + MinNumberOfEdges/2);
            builder.AppendLine("Real number of edges: " + GetNumberOfEdges()/2);
            builder.AppendLine("====================");
            builder.AppendLine("GRAPH ENDS HERE");
            builder.AppendLine("====================");

            return builder.ToString();
        }
    }
}

