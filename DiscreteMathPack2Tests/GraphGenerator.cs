using System;
using DiscreteMathPack1Console;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DiscreteMathPack2Tests
{
    public static class GraphGenerator
    {
        // node0 is always the source for the algorithms
        public static Graph Graph1()
        {
            //node0 connected to node1 once
            // correct: {0,1}

            var graph = new Graph(2);
            var node0 = new Node(0);
            var node1 = new Node(1);

            graph.AddSpecificNode(node0);
            graph.AddSpecificNode(node1);

            node0.AddEdgeTwoWay(node1, 1);
            
            return graph;
        }

        public static Graph Graph2()
        {
            // node0 connected to node1 three times with the same weight
            // correct: {0,1}

            var graph = new Graph(2);
            var node0 = new Node(0);
            var node1 = new Node(1);

            graph.AddSpecificNode(node0);
            graph.AddSpecificNode(node1);

            node0.AddEdgeTwoWay(node1, 1);
            node0.AddEdgeTwoWay(node1, 1);
            node0.AddEdgeTwoWay(node1, 1);
            
            return graph;
        }

        public static Graph Graph3()
        {
            // node0 connected to node1 three times with different weights
            // correct: {0,2}

            var graph = new Graph(2);
            var node0 = new Node(0);
            var node1 = new Node(1);

            graph.AddSpecificNode(node0);
            graph.AddSpecificNode(node1);

            node0.AddEdgeTwoWay(node1, 2);
            node0.AddEdgeTwoWay(node1, 3);
            node0.AddEdgeTwoWay(node1, 4);
            
            return graph;
        }

        public static Graph Graph4()
        {
            // node0 connected to node1 once
            // node0 connected to node2 once
            // correct: {0,1,1}

            var graph = new Graph(3);
            var node0 = new Node(0);
            var node1 = new Node(1);
            var node2 = new Node(2);

            graph.AddSpecificNode(node0);
            graph.AddSpecificNode(node1);
            graph.AddSpecificNode(node2);

            node0.AddEdgeTwoWay(node1, 1);
            node0.AddEdgeTwoWay(node2, 1);
            
            return graph;
        }

        public static Graph Graph5()
        {
            // node0 connected to node1 once
            // node1 connected to node2 once
            // correct: {0,1,2}

            var graph = new Graph(3);
            var node0 = new Node(0);
            var node1 = new Node(1);
            var node2 = new Node(2);

            graph.AddSpecificNode(node0);
            graph.AddSpecificNode(node1);
            graph.AddSpecificNode(node2);

            node0.AddEdgeTwoWay(node1, 1);
            node1.AddEdgeTwoWay(node2, 1);
            
            return graph;
        }

        public static Graph Graph6()
        {
            // node0 connected to node1 once
            // node0 connected to node2 once
            // node1 connected to node2 once
            // correct: {0,1,1}

            var graph = new Graph(3);
            var node0 = new Node(0);
            var node1 = new Node(1);
            var node2 = new Node(2);

            graph.AddSpecificNode(node0);
            graph.AddSpecificNode(node1);
            graph.AddSpecificNode(node2);

            node0.AddEdgeTwoWay(node1, 1);
            node0.AddEdgeTwoWay(node2, 1);
            node1.AddEdgeTwoWay(node2, 1);
            
            return graph;
        }

        public static Graph Graph7()
        {
            // node0 connected to node1 once w = 1
            // node1 connected to node2 once w = 2
            // node2 connected to node3 once w = 4
            // correct: {0,1,3,7}

            int i = 0;
            
            var node0 = new Node(i++);
            var node1 = new Node(i++);
            var node2 = new Node(i++);
            var node3 = new Node(i++);

            var graph = new Graph(i);
            graph.AddSpecificNode(node0);
            graph.AddSpecificNode(node1);
            graph.AddSpecificNode(node2);
            graph.AddSpecificNode(node3);

            node0.AddEdgeTwoWay(node1, 1);
            node1.AddEdgeTwoWay(node2, 2);
            node2.AddEdgeTwoWay(node3, 4);

            return graph;
        }

        public static Graph Graph8()
        {
            // node0 connected to node1 once w = 1
            // node1 connected to node2 once w = 2
            // node2 connected to node2 once w = 1
            // node2 connected to node3 once w = 4
            // correct: {0,1,3,7}

            int i = 0;

            var node0 = new Node(i++);
            var node1 = new Node(i++);
            var node2 = new Node(i++);
            var node3 = new Node(i++);

            var graph = new Graph(i);
            graph.AddSpecificNode(node0);
            graph.AddSpecificNode(node1);
            graph.AddSpecificNode(node2);
            graph.AddSpecificNode(node3);

            node0.AddEdgeTwoWay(node1, 1);
            node1.AddEdgeTwoWay(node2, 2);
            node2.AddEdgeTwoWay(node2, 1);
            node2.AddEdgeTwoWay(node3, 4);

            return graph;
        }

        public static Graph Graph9()
        {
            // node0 connected to node1 once w = 1
            // node1 connected to node2 once w = 2
            // node2 connected to node3 once w = 4
            // node3 connected to node0 once w = 1
            // correct: {0,1,3,1}

            int i = 0;

            var node0 = new Node(i++);
            var node1 = new Node(i++);
            var node2 = new Node(i++);
            var node3 = new Node(i++);

            var graph = new Graph(i);
            graph.AddSpecificNode(node0);
            graph.AddSpecificNode(node1);
            graph.AddSpecificNode(node2);
            graph.AddSpecificNode(node3);

            node0.AddEdgeTwoWay(node1, 1);
            node1.AddEdgeTwoWay(node2, 2);
            node2.AddEdgeTwoWay(node3, 4);
            node3.AddEdgeTwoWay(node0, 1);

            return graph;
        }

        public static Graph Graph10()
        {
            // this is a tree
           
            // node0 connected to node1 once w = 1
            // node0 connected to node2 ince w = 10

            // node1 connected to node3 once w = 2
            // node1 connected to node4 once w = 3

            // node2 connected to node5 once w = 20
            // node2 connected to node6 once w = 30

            // correct: {0,1,10,3,4,30,40}

            int i = 0;

            var node0 = new Node(i++);
            var node1 = new Node(i++);
            var node2 = new Node(i++);
            var node3 = new Node(i++);
            var node4 = new Node(i++);
            var node5 = new Node(i++);
            var node6 = new Node(i++);

            var graph = new Graph(i);
            graph.AddSpecificNode(node0);
            graph.AddSpecificNode(node1);
            graph.AddSpecificNode(node2);
            graph.AddSpecificNode(node3);
            graph.AddSpecificNode(node4);
            graph.AddSpecificNode(node5);
            graph.AddSpecificNode(node6);

            node0.AddEdgeTwoWay(node1, 1);
            node0.AddEdgeTwoWay(node2, 10);

            node1.AddEdgeTwoWay(node3, 2);
            node1.AddEdgeTwoWay(node4, 3);

            node2.AddEdgeTwoWay(node5, 20);
            node2.AddEdgeTwoWay(node6, 30);

            return graph;
        }

        public static Graph Graph11()
        {
            // pentagon
            // node0 connected to node1 w = 1
            // node0 connected to node2 w = 2
            // node1 connected to node3 w = 3
            // node2 connected to node4 w = 4
            // node3 connected to node4 w = 1
            // correct: {0,1,2,4,5}

            int i = 0;

            var node0 = new Node(0);
            var node1 = new Node(1);
            var node2 = new Node(2);
            var node3 = new Node(3);
            var node4 = new Node(4);

            var graph = new Graph(0);
            graph.AddSpecificNode(node0);
            graph.AddSpecificNode(node1);
            graph.AddSpecificNode(node2);
            graph.AddSpecificNode(node3);
            graph.AddSpecificNode(node4);

            node0.AddEdgeTwoWay(node1, 1);
            node0.AddEdgeTwoWay(node2, 2);
            node1.AddEdgeTwoWay(node3, 3);
            node2.AddEdgeTwoWay(node4, 4);
            node3.AddEdgeTwoWay(node4, 1);

            return graph;
        }

        public static Graph Graph12()
        {
            // pentagon with diagonals
            // sides w = 10
            // node0 connected to node1 w = 10
            // node0 connected to node2 w = 10
            // node1 connected to node3 w = 10
            // node2 connected to node4 w = 10
            // node3 connected to node4 w = 10

            // diagonals w = 2
            // node0 connected to node3 w = 2
            // node0 connected to node4 w = 2
            // node1 connected to node2 w = 2
            // node1 connected to node4 w = 2
            // node2 connected to node3 w = 2
            // correct: {0,4,4,2,2}

            int i = 0;

            var node0 = new Node(0);
            var node1 = new Node(1);
            var node2 = new Node(2);
            var node3 = new Node(3);
            var node4 = new Node(4);

            var graph = new Graph(0);
            graph.AddSpecificNode(node0);
            graph.AddSpecificNode(node1);
            graph.AddSpecificNode(node2);
            graph.AddSpecificNode(node3);
            graph.AddSpecificNode(node4);

            //sides
            node0.AddEdgeTwoWay(node1, 10);
            node0.AddEdgeTwoWay(node2, 10);
            node1.AddEdgeTwoWay(node3, 10);
            node2.AddEdgeTwoWay(node4, 10);
            node3.AddEdgeTwoWay(node4, 10);

            //diagonals
            node0.AddEdgeTwoWay(node3, 2);
            node0.AddEdgeTwoWay(node4, 2);
            node1.AddEdgeTwoWay(node2, 2);
            node1.AddEdgeTwoWay(node4, 2);
            node2.AddEdgeTwoWay(node3, 2);

            return graph;
        }

        public static Graph Graph13()
        {
            // node0 connected to node1 once w = 1
            // node0 connected to node5 once w = 10
            // node1 connected to node2 once w = 1
            // node2 connected to node3 once w = 1
            // node3 connected to node4 once w = 1
            // node4 connected to node5 once w = 1

            // correct: {0,1,2,3,4,5}

            int i = 0;

            var node0 = new Node(i++);
            var node1 = new Node(i++);
            var node2 = new Node(i++);
            var node3 = new Node(i++);
            var node4 = new Node(i++);
            var node5 = new Node(i++);

            var graph = new Graph(i);
            graph.AddSpecificNode(node0);
            graph.AddSpecificNode(node1);
            graph.AddSpecificNode(node2);
            graph.AddSpecificNode(node3);
            graph.AddSpecificNode(node4);
            graph.AddSpecificNode(node5);

            node0.AddEdgeTwoWay(node1, 1);
            node5.AddEdgeTwoWay(node5, 10);
            node1.AddEdgeTwoWay(node2, 1);
            node2.AddEdgeTwoWay(node3, 1);
            node3.AddEdgeTwoWay(node4, 1);
            node4.AddEdgeTwoWay(node5, 1);

            return graph;
        }
    }
}
