using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Priority_Queue;

namespace DiscreteMathPack1Console
{
    public class Node : FastPriorityQueueNode
    {
        public int Id { get; set; }
        public List<Edge> ListOfEdges { get; private set; }

        public Node(int id)
        {
            Id = id;
            ListOfEdges = new List<Edge>();
        }

        public void AddEdgeOneWay(Node target, int weight)
        {
            NewEdgeOneWay(target, weight);
        }

        public void AddEdgeTwoWay(Node target, int weightToTarget, int weightBack)
        {
            NewEdgeBothWay(target, weightToTarget, weightBack);
        }

        public void AddEdgeTwoWay(Node target, int weight)
        {
            NewEdgeBothWay(target, weight, weight);
        }

        private void NewEdgeBothWay(Node target, int weightToTarget, int weightBack)
        {
            NewEdgeOneWay(target, weightToTarget);
            target.NewEdgeOneWay(this, weightBack);
        }

        private void NewEdgeOneWay(Node target, int weight)
        {
            
            if (CheckIfConnectionExists(target))
            {
                //return;
            }
            
            var newEdge = new Edge(target, weight);
            ListOfEdges.Add(newEdge);
        }

        private bool CheckIfConnectionExists(Node target)
        {
            return ListOfEdges.Exists(n => n.Target.Equals(target));
        }

        protected bool Equals(Node other)
        {
            return Id == other.Id && Equals(ListOfEdges, other.ListOfEdges);
        }


        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendLine("====================");
            builder.AppendLine("Node ID: " + Id);
            foreach (var edge in ListOfEdges)
            {
                builder.AppendLine(edge.ToString());
            }
            builder.AppendLine("====================");
            return builder.ToString();
        }
    }
}
