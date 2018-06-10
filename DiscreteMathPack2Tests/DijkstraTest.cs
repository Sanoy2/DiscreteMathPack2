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
    public class DijkstraTest
    {
        [TestMethod]
        public void Graph1_Dijkstra()
        {
            var graph = GraphGenerator.Graph1();
            var dijkstra = new Dijkstra(graph);
            var result = dijkstra.Work(false);
            int[] excected = {0, 1};
            Assert.AreEqual(true, ArrayComparer.Compare(excected, result));
        }

        [TestMethod]
        public void Graph2_Dijkstra()
        {
            var graph = GraphGenerator.Graph2();
            var dijkstra = new Dijkstra(graph);
            var result = dijkstra.Work(false);
            int[] excected = { 0, 1 };
            Assert.AreEqual(true, ArrayComparer.Compare(excected, result));
        }

        [TestMethod]
        public void Graph3_Dijkstra()
        {
            var graph = GraphGenerator.Graph3();
            var dijkstra = new Dijkstra(graph);
            var result = dijkstra.Work(false);
            int[] excected = { 0, 2 };
            Assert.AreEqual(true, ArrayComparer.Compare(excected, result));
        }

        [TestMethod]
        public void Graph4_Dijkstra()
        {
            var graph = GraphGenerator.Graph4();
            var dijkstra = new Dijkstra(graph);
            var result = dijkstra.Work(false);
            int[] excected = { 0, 1, 1 };
            Assert.AreEqual(true, ArrayComparer.Compare(excected, result));
        }

        [TestMethod]
        public void Graph5_Dijkstra()
        {
            var graph = GraphGenerator.Graph5();
            var dijkstra = new Dijkstra(graph);
            var result = dijkstra.Work(false);
            int[] excected = { 0, 1, 2 };
            Assert.AreEqual(true, ArrayComparer.Compare(excected, result));
        }

        [TestMethod]
        public void Graph6_Dijkstra()
        {
            var graph = GraphGenerator.Graph6();
            var dijkstra = new Dijkstra(graph);
            var result = dijkstra.Work(false);
            int[] excected = { 0, 1, 1 };
            Assert.AreEqual(true, ArrayComparer.Compare(excected, result));
        }

        [TestMethod]
        public void Graph7_Dijkstra()
        {
            var graph = GraphGenerator.Graph7();
            var dijkstra = new Dijkstra(graph);
            var result = dijkstra.Work(false);
            int[] excected = { 0, 1, 3, 7 };
            Assert.AreEqual(true, ArrayComparer.Compare(excected, result));
        }

        [TestMethod]
        public void Graph8_Dijkstra()
        {
            var graph = GraphGenerator.Graph8();
            var dijkstra = new Dijkstra(graph);
            var result = dijkstra.Work(false);
            int[] excected = { 0, 1, 3, 7 };
            Assert.AreEqual(true, ArrayComparer.Compare(excected, result));
        }

        [TestMethod]
        public void Graph9_Dijkstra()
        {
            var graph = GraphGenerator.Graph9();
            var dijkstra = new Dijkstra(graph);
            var result = dijkstra.Work(false);
            int[] excected = { 0, 1, 3, 1 };
            Assert.AreEqual(true, ArrayComparer.Compare(excected, result));
        }

        [TestMethod]
        public void Graph10_Dijkstra()
        {
            var graph = GraphGenerator.Graph10();
            var dijkstra = new Dijkstra(graph);
            var result = dijkstra.Work(false);
            int[] excected = { 0, 1, 10, 3, 4, 30, 40 };
            Assert.AreEqual(true, ArrayComparer.Compare(excected, result));
        }

        [TestMethod]
        public void Graph11_Dijkstra()
        {
            var graph = GraphGenerator.Graph11();
            var dijkstra = new Dijkstra(graph);
            var result = dijkstra.Work(false);
            int[] excected = { 0, 1, 2, 4, 5 };
            Assert.AreEqual(true, ArrayComparer.Compare(excected, result));
        }

        [TestMethod]
        public void Graph12_Dijkstra()
        {
            var graph = GraphGenerator.Graph12();
            var dijkstra = new Dijkstra(graph);
            var result = dijkstra.Work(false);
            int[] excected = { 0, 4, 4, 2, 2 };
            Assert.AreEqual(true, ArrayComparer.Compare(excected, result));
        }

        [TestMethod]
        public void Graph13_Dijkstra()
        {
            var graph = GraphGenerator.Graph13();
            var dijkstra = new Dijkstra(graph);
            var result = dijkstra.Work(false);
            int[] excected = { 0, 1, 2, 3, 4, 5 };
            Assert.AreEqual(true, ArrayComparer.Compare(excected, result));
        }
    }
}
