using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiscreteMathPack2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DiscreteMathPack2Tests
{
    [TestClass]
    public class BellmanFordTest
    {
        [TestMethod]
        public void Graph1_BellmanFord()
        {
            var graph = GraphGenerator.Graph1();
            var bellmanFord = new BellmanFord(graph);
            var result = bellmanFord.Work(false);
            int[] excected = { 0, 1 };
            Assert.AreEqual(true, ArrayComparer.Compare(excected, result));
        }

        [TestMethod]
        public void Graph2_BellmanFord()
        {
            var graph = GraphGenerator.Graph2();
            var bellmanFord = new BellmanFord(graph);
            var result = bellmanFord.Work(false);
            int[] excected = { 0, 1 };
            Assert.AreEqual(true, ArrayComparer.Compare(excected, result));
        }

        [TestMethod]
        public void Graph3_BellmanFord()
        {
            var graph = GraphGenerator.Graph3();
            var bellmanFord = new BellmanFord(graph);
            var result = bellmanFord.Work(false);
            int[] excected = { 0, 2 };
            Assert.AreEqual(true, ArrayComparer.Compare(excected, result));
        }

        [TestMethod]
        public void Graph4_BellmanFord()
        {
            var graph = GraphGenerator.Graph4();
            var bellmanFord = new BellmanFord(graph);
            var result = bellmanFord.Work(false);
            int[] excected = { 0, 1, 1 };
            Assert.AreEqual(true, ArrayComparer.Compare(excected, result));
        }

        [TestMethod]
        public void Graph5_BellmanFord()
        {
            var graph = GraphGenerator.Graph5();
            var bellmanFord = new BellmanFord(graph);
            var result = bellmanFord.Work(false);
            int[] excected = { 0, 1, 2};
            Assert.AreEqual(true, ArrayComparer.Compare(excected, result));
        }

        [TestMethod]
        public void Graph6_BellmanFord()
        {
            var graph = GraphGenerator.Graph6();
            var bellmanFord = new BellmanFord(graph);
            var result = bellmanFord.Work(false);
            int[] excected = { 0, 1, 1 };
            Assert.AreEqual(true, ArrayComparer.Compare(excected, result));
        }

        [TestMethod]
        public void Graph7_BellmanFord()
        {
            var graph = GraphGenerator.Graph7();
            var bellmanFord = new BellmanFord(graph);
            var result = bellmanFord.Work(false);
            int[] excected = { 0, 1, 3, 7 };
            Assert.AreEqual(true, ArrayComparer.Compare(excected, result));
        }

        [TestMethod]
        public void Graph8_BellmanFord()
        {
            var graph = GraphGenerator.Graph8();
            var bellmanFord = new BellmanFord(graph);
            var result = bellmanFord.Work(false);
            int[] excected = { 0, 1, 3, 7 };
            Assert.AreEqual(true, ArrayComparer.Compare(excected, result));
        }

        [TestMethod]
        public void Graph9_BellmanFord()
        {
            var graph = GraphGenerator.Graph9();
            var bellmanFord = new BellmanFord(graph);
            var result = bellmanFord.Work(false);
            int[] excected = { 0, 1, 3, 1 };
            Assert.AreEqual(true, ArrayComparer.Compare(excected, result));
        }

        [TestMethod]
        public void Graph10_BellmanFord()
        {
            var graph = GraphGenerator.Graph10();
            var bellmanFord = new BellmanFord(graph);
            var result = bellmanFord.Work(false);
            int[] excected = { 0, 1, 10, 3, 4, 30, 40 };
            Assert.AreEqual(true, ArrayComparer.Compare(excected, result));
        }
    }
}
