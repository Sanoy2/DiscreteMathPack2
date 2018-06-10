using System;

namespace DiscreteMathPack1Console
{
    public class Edge
    {
        public int Weight { get; private set; }
        public Node Target { get; set; }

        public Edge(Node target, int weight)
        {
            Target = target ?? throw new ArgumentNullException(nameof(target));
            SetWeight(weight);
        }

        private void SetWeight(int weight)
        {
            if (weight > 0)
            {
                Weight = weight;
            }
            else if (weight < 0)
            {
                Weight = -weight;
            }
            else if (weight == 0)
            {
                Weight = 1;
            }
        }

        public override string ToString()
        {
            return "Edge Target: " + Target.Id + ", weight: " + Weight;
        }
    }
}
