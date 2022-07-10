using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using KTANE_Solver;
using System.Windows.Forms;
using System.Collections.Generic;

namespace ModuleTests
{
    [TestClass]
    public class ConnectionCheckTest
    {
        StreamWriter streamWriter = new StreamWriter("C:\\delete later\\dummy.txt");
        #region Neighbor Check

        [TestMethod]
        public void OneSLIMNeighborCheck()
        {
            Bomb bomb = new Bomb(Day.Sunday, "IIIII", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
                    new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
                    new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
                    new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

            int[] arr = new int[] {1, 1};
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);
            
            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsTrue(nodes[0].neighbors.Contains(nodes[1]));
            Assert.IsTrue(nodes[0].neighbors.Contains(nodes[2]));
            Assert.IsFalse(nodes[0].neighbors.Contains(nodes[3]));
            Assert.IsFalse(nodes[0].neighbors.Contains(nodes[4]));
            Assert.IsTrue(nodes[0].neighbors.Contains(nodes[5]));
            Assert.IsFalse(nodes[0].neighbors.Contains(nodes[6]));
            Assert.IsFalse(nodes[0].neighbors.Contains(nodes[7]));

            streamWriter.Close();
        }

        [TestMethod]
        public void TwoSLIMNeighborCheck()
        {
            Bomb bomb = new Bomb(Day.Sunday, "IIIII", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
                    new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
                    new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
                    new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsTrue(nodes[1].neighbors.Contains(nodes[0]));
            Assert.IsFalse(nodes[1].neighbors.Contains(nodes[2]));
            Assert.IsFalse(nodes[1].neighbors.Contains(nodes[3]));
            Assert.IsFalse(nodes[1].neighbors.Contains(nodes[4]));
            Assert.IsTrue(nodes[1].neighbors.Contains(nodes[5]));
            Assert.IsFalse(nodes[1].neighbors.Contains(nodes[6]));
            Assert.IsFalse(nodes[1].neighbors.Contains(nodes[7]));

            streamWriter.Close();
        }

        [TestMethod]
        public void ThreeSLIMNeighborCheck()
        {
            Bomb bomb = new Bomb(Day.Sunday, "IIIII", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
                    new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
                    new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
                    new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsTrue(nodes[2].neighbors.Contains(nodes[0]));
            Assert.IsFalse(nodes[2].neighbors.Contains(nodes[1]));
            Assert.IsTrue(nodes[2].neighbors.Contains(nodes[3]));
            Assert.IsFalse(nodes[2].neighbors.Contains(nodes[4]));
            Assert.IsTrue(nodes[2].neighbors.Contains(nodes[5]));
            Assert.IsFalse(nodes[2].neighbors.Contains(nodes[6]));
            Assert.IsFalse(nodes[2].neighbors.Contains(nodes[7]));
            streamWriter.Close();
        }

        [TestMethod]
        public void FourSLIMNeighborCheck()
        {
            Bomb bomb = new Bomb(Day.Sunday, "IIIII", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
                    new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
                    new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
                    new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsFalse(nodes[3].neighbors.Contains(nodes[0]));
            Assert.IsFalse(nodes[3].neighbors.Contains(nodes[1]));
            Assert.IsTrue(nodes[3].neighbors.Contains(nodes[2]));
            Assert.IsTrue(nodes[3].neighbors.Contains(nodes[4]));
            Assert.IsTrue(nodes[3].neighbors.Contains(nodes[5]));
            Assert.IsTrue(nodes[3].neighbors.Contains(nodes[6]));
            Assert.IsTrue(nodes[3].neighbors.Contains(nodes[7]));
            streamWriter.Close();
        }

        [TestMethod]
        public void FiveSLIMNeighborCheck()
        {
            Bomb bomb = new Bomb(Day.Sunday, "IIIII", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
                    new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
                    new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
                    new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsFalse(nodes[4].neighbors.Contains(nodes[0]));
            Assert.IsFalse(nodes[4].neighbors.Contains(nodes[1]));
            Assert.IsFalse(nodes[4].neighbors.Contains(nodes[2]));
            Assert.IsTrue(nodes[4].neighbors.Contains(nodes[3]));
            Assert.IsTrue(nodes[4].neighbors.Contains(nodes[5]));
            Assert.IsTrue(nodes[4].neighbors.Contains(nodes[6]));
            Assert.IsFalse(nodes[4].neighbors.Contains(nodes[7]));
            streamWriter.Close();
        }

        [TestMethod]
        public void SixSLIMNeighborCheck()
        {
            Bomb bomb = new Bomb(Day.Sunday, "IIIII", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
                    new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
                    new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
                    new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsTrue(nodes[5].neighbors.Contains(nodes[0]));
            Assert.IsTrue(nodes[5].neighbors.Contains(nodes[1]));
            Assert.IsTrue(nodes[5].neighbors.Contains(nodes[2]));
            Assert.IsTrue(nodes[5].neighbors.Contains(nodes[3]));
            Assert.IsTrue(nodes[5].neighbors.Contains(nodes[4]));
            Assert.IsFalse(nodes[5].neighbors.Contains(nodes[6]));
            Assert.IsFalse(nodes[5].neighbors.Contains(nodes[7]));
            streamWriter.Close();
        }

        [TestMethod]
        public void SevenSLIMNeighborCheck()
        {
            Bomb bomb = new Bomb(Day.Sunday, "IIIII", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
                    new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
                    new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
                    new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsFalse(nodes[6].neighbors.Contains(nodes[0]));
            Assert.IsFalse(nodes[6].neighbors.Contains(nodes[1]));
            Assert.IsFalse(nodes[6].neighbors.Contains(nodes[2]));
            Assert.IsTrue(nodes[6].neighbors.Contains(nodes[3]));
            Assert.IsTrue(nodes[6].neighbors.Contains(nodes[4]));
            Assert.IsFalse(nodes[6].neighbors.Contains(nodes[5]));
            Assert.IsTrue(nodes[6].neighbors.Contains(nodes[7]));
            streamWriter.Close();
        }

        [TestMethod]
        public void EightSLIMNeighborCheck()
        {
            Bomb bomb = new Bomb(Day.Sunday, "IIIII", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
                    new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
                    new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
                    new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsFalse(nodes[7].neighbors.Contains(nodes[0]));
            Assert.IsFalse(nodes[7].neighbors.Contains(nodes[1]));
            Assert.IsFalse(nodes[7].neighbors.Contains(nodes[2]));
            Assert.IsTrue(nodes[7].neighbors.Contains(nodes[3]));
            Assert.IsFalse(nodes[7].neighbors.Contains(nodes[4]));
            Assert.IsFalse(nodes[7].neighbors.Contains(nodes[5]));
            Assert.IsTrue(nodes[7].neighbors.Contains(nodes[6]));
            streamWriter.Close();
        }

        [TestMethod]
        public void One20DGTNeighborCheck()
        {
            Bomb bomb = new Bomb(Day.Sunday, "00000", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
                    new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
                    new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
                    new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsTrue(nodes[0].neighbors.Contains(nodes[1]));
            Assert.IsTrue(nodes[0].neighbors.Contains(nodes[2]));
            Assert.IsFalse(nodes[0].neighbors.Contains(nodes[3]));
            Assert.IsFalse(nodes[0].neighbors.Contains(nodes[4]));
            Assert.IsFalse(nodes[0].neighbors.Contains(nodes[5]));
            Assert.IsFalse(nodes[0].neighbors.Contains(nodes[6]));
            Assert.IsFalse(nodes[0].neighbors.Contains(nodes[7]));
            streamWriter.Close();
        }

        [TestMethod]
        public void Two20DGTNeighborCheck()
        {
            Bomb bomb = new Bomb(Day.Sunday, "00000", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
                    new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
                    new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
                    new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsTrue(nodes[1].neighbors.Contains(nodes[0]));
            Assert.IsFalse(nodes[1].neighbors.Contains(nodes[2]));
            Assert.IsTrue(nodes[1].neighbors.Contains(nodes[3]));
            Assert.IsFalse(nodes[1].neighbors.Contains(nodes[4]));
            Assert.IsFalse(nodes[1].neighbors.Contains(nodes[5]));
            Assert.IsTrue(nodes[1].neighbors.Contains(nodes[6]));
            Assert.IsFalse(nodes[1].neighbors.Contains(nodes[7]));
            streamWriter.Close();
        }

        [TestMethod]
        public void Three20DGTNeighborCheck()
        {
            Bomb bomb = new Bomb(Day.Sunday, "00000", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
                    new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
                    new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
                    new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsTrue(nodes[2].neighbors.Contains(nodes[0]));
            Assert.IsFalse(nodes[2].neighbors.Contains(nodes[1]));
            Assert.IsFalse(nodes[2].neighbors.Contains(nodes[3]));
            Assert.IsTrue(nodes[2].neighbors.Contains(nodes[4]));
            Assert.IsFalse(nodes[2].neighbors.Contains(nodes[5]));
            Assert.IsTrue(nodes[2].neighbors.Contains(nodes[6]));
            Assert.IsFalse(nodes[2].neighbors.Contains(nodes[7]));
            streamWriter.Close();
        }

        [TestMethod]
        public void Four20DGTNeighborCheck()
        {
            Bomb bomb = new Bomb(Day.Sunday, "00000", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
                    new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
                    new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
                    new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsFalse(nodes[3].neighbors.Contains(nodes[0]));
            Assert.IsTrue(nodes[3].neighbors.Contains(nodes[1]));
            Assert.IsFalse(nodes[3].neighbors.Contains(nodes[2]));
            Assert.IsFalse(nodes[3].neighbors.Contains(nodes[4]));
            Assert.IsTrue(nodes[3].neighbors.Contains(nodes[5]));
            Assert.IsTrue(nodes[3].neighbors.Contains(nodes[6]));
            Assert.IsTrue(nodes[3].neighbors.Contains(nodes[7]));
            streamWriter.Close();
        }

        [TestMethod]
        public void Five20DGTNeighborCheck()
        {
            Bomb bomb = new Bomb(Day.Sunday, "00000", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
                    new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
                    new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
                    new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsFalse(nodes[4].neighbors.Contains(nodes[0]));
            Assert.IsFalse(nodes[4].neighbors.Contains(nodes[1]));
            Assert.IsTrue(nodes[4].neighbors.Contains(nodes[2]));
            Assert.IsFalse(nodes[4].neighbors.Contains(nodes[3]));
            Assert.IsTrue(nodes[4].neighbors.Contains(nodes[5]));
            Assert.IsTrue(nodes[4].neighbors.Contains(nodes[6]));
            Assert.IsFalse(nodes[4].neighbors.Contains(nodes[7]));
            streamWriter.Close();
        }

        [TestMethod]
        public void Six20DGTNeighborCheck()
        {
            Bomb bomb = new Bomb(Day.Sunday, "00000", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
                    new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
                    new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
                    new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsFalse(nodes[5].neighbors.Contains(nodes[0]));
            Assert.IsFalse(nodes[5].neighbors.Contains(nodes[1]));
            Assert.IsFalse(nodes[5].neighbors.Contains(nodes[2]));
            Assert.IsTrue(nodes[5].neighbors.Contains(nodes[3]));
            Assert.IsTrue(nodes[5].neighbors.Contains(nodes[4]));
            Assert.IsFalse(nodes[5].neighbors.Contains(nodes[6]));
            Assert.IsTrue(nodes[5].neighbors.Contains(nodes[7]));
            streamWriter.Close();
        }

        [TestMethod]
        public void Seven20DGTNeighborCheck()
        {
            Bomb bomb = new Bomb(Day.Sunday, "00000", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
                    new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
                    new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
                    new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsFalse(nodes[6].neighbors.Contains(nodes[0]));
            Assert.IsTrue(nodes[6].neighbors.Contains(nodes[1]));
            Assert.IsTrue(nodes[6].neighbors.Contains(nodes[2]));
            Assert.IsTrue(nodes[6].neighbors.Contains(nodes[3]));
            Assert.IsTrue(nodes[6].neighbors.Contains(nodes[4]));
            Assert.IsFalse(nodes[6].neighbors.Contains(nodes[5]));
            Assert.IsFalse(nodes[6].neighbors.Contains(nodes[7]));
            streamWriter.Close();
        }

        [TestMethod]
        public void Eight20DGTNeighborCheck()
        {
            Bomb bomb = new Bomb(Day.Sunday, "00000", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
                    new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
                    new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
                    new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsFalse(nodes[7].neighbors.Contains(nodes[0]));
            Assert.IsFalse(nodes[7].neighbors.Contains(nodes[1]));
            Assert.IsFalse(nodes[7].neighbors.Contains(nodes[2]));
            Assert.IsTrue(nodes[7].neighbors.Contains(nodes[3]));
            Assert.IsFalse(nodes[7].neighbors.Contains(nodes[4]));
            Assert.IsTrue(nodes[7].neighbors.Contains(nodes[5]));
            Assert.IsFalse(nodes[7].neighbors.Contains(nodes[6]));
            streamWriter.Close();
        }

        [TestMethod]
        public void One7HPJNeighborCheck()
        {
            Bomb bomb = new Bomb(Day.Sunday, "77777", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
                    new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
                    new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
                    new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsTrue(nodes[0].neighbors.Contains(nodes[1]));
            Assert.IsTrue(nodes[0].neighbors.Contains(nodes[2]));
            Assert.IsFalse(nodes[0].neighbors.Contains(nodes[3]));
            Assert.IsFalse(nodes[0].neighbors.Contains(nodes[4]));
            Assert.IsFalse(nodes[0].neighbors.Contains(nodes[5]));
            Assert.IsFalse(nodes[0].neighbors.Contains(nodes[6]));
            Assert.IsFalse(nodes[0].neighbors.Contains(nodes[7]));
            streamWriter.Close();
        }

        [TestMethod]
        public void Two7HPJNeighborCheck()
        {
            Bomb bomb = new Bomb(Day.Sunday, "77777", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
                    new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
                    new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
                    new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsTrue(nodes[1].neighbors.Contains(nodes[0]));
            Assert.IsTrue(nodes[1].neighbors.Contains(nodes[2]));
            Assert.IsFalse(nodes[1].neighbors.Contains(nodes[3]));
            Assert.IsFalse(nodes[1].neighbors.Contains(nodes[4]));
            Assert.IsFalse(nodes[1].neighbors.Contains(nodes[5]));
            Assert.IsFalse(nodes[1].neighbors.Contains(nodes[6]));
            Assert.IsFalse(nodes[1].neighbors.Contains(nodes[7]));
            streamWriter.Close();
        }

        [TestMethod]
        public void Three7HPJNeighborCheck()
        {
            Bomb bomb = new Bomb(Day.Sunday, "77777", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
                    new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
                    new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
                    new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsTrue(nodes[2].neighbors.Contains(nodes[0]));
            Assert.IsTrue(nodes[2].neighbors.Contains(nodes[1]));
            Assert.IsFalse(nodes[2].neighbors.Contains(nodes[3]));
            Assert.IsFalse(nodes[2].neighbors.Contains(nodes[4]));
            Assert.IsFalse(nodes[2].neighbors.Contains(nodes[5]));
            Assert.IsFalse(nodes[2].neighbors.Contains(nodes[6]));
            Assert.IsFalse(nodes[2].neighbors.Contains(nodes[7]));
            streamWriter.Close();
        }

        [TestMethod]
        public void Four7HPJNeighborCheck()
        {
            Bomb bomb = new Bomb(Day.Sunday, "77777", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
                    new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
                    new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
                    new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsFalse(nodes[3].neighbors.Contains(nodes[0]));
            Assert.IsFalse(nodes[3].neighbors.Contains(nodes[1]));
            Assert.IsFalse(nodes[3].neighbors.Contains(nodes[2]));
            Assert.IsFalse(nodes[3].neighbors.Contains(nodes[4]));
            Assert.IsTrue(nodes[3].neighbors.Contains(nodes[5]));
            Assert.IsTrue(nodes[3].neighbors.Contains(nodes[6]));
            Assert.IsFalse(nodes[3].neighbors.Contains(nodes[7]));
            streamWriter.Close();
        }

        [TestMethod]
        public void Five7HPJNeighborCheck()
        {
            Bomb bomb = new Bomb(Day.Sunday, "77777", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
                    new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
                    new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
                    new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsFalse(nodes[4].neighbors.Contains(nodes[0]));
            Assert.IsFalse(nodes[4].neighbors.Contains(nodes[1]));
            Assert.IsFalse(nodes[4].neighbors.Contains(nodes[2]));
            Assert.IsFalse(nodes[4].neighbors.Contains(nodes[3]));
            Assert.IsTrue(nodes[4].neighbors.Contains(nodes[5]));
            Assert.IsTrue(nodes[4].neighbors.Contains(nodes[6]));
            Assert.IsFalse(nodes[4].neighbors.Contains(nodes[7]));
            streamWriter.Close();
        }

        [TestMethod]
        public void Six7HPJNeighborCheck()
        {
            Bomb bomb = new Bomb(Day.Sunday, "77777", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
                    new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
                    new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
                    new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsFalse(nodes[5].neighbors.Contains(nodes[0]));
            Assert.IsFalse(nodes[5].neighbors.Contains(nodes[1]));
            Assert.IsFalse(nodes[5].neighbors.Contains(nodes[2]));
            Assert.IsTrue(nodes[5].neighbors.Contains(nodes[3]));
            Assert.IsTrue(nodes[5].neighbors.Contains(nodes[4]));
            Assert.IsFalse(nodes[5].neighbors.Contains(nodes[6]));
            Assert.IsFalse(nodes[5].neighbors.Contains(nodes[7]));
            streamWriter.Close();
        }

        [TestMethod]
        public void Seven7HPJNeighborCheck()
        {
            Bomb bomb = new Bomb(Day.Sunday, "77777", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
                    new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
                    new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
                    new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsFalse(nodes[6].neighbors.Contains(nodes[0]));
            Assert.IsFalse(nodes[6].neighbors.Contains(nodes[1]));
            Assert.IsFalse(nodes[6].neighbors.Contains(nodes[2]));
            Assert.IsTrue(nodes[6].neighbors.Contains(nodes[3]));
            Assert.IsTrue(nodes[6].neighbors.Contains(nodes[4]));
            Assert.IsFalse(nodes[6].neighbors.Contains(nodes[5]));
            Assert.IsFalse(nodes[6].neighbors.Contains(nodes[7]));
            streamWriter.Close();
        }

        [TestMethod]
        public void Eight7HPJNeighborCheck()
        {
            Bomb bomb = new Bomb(Day.Sunday, "77777", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
                    new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
                    new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
                    new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsFalse(nodes[7].neighbors.Contains(nodes[0]));
            Assert.IsFalse(nodes[7].neighbors.Contains(nodes[1]));
            Assert.IsFalse(nodes[7].neighbors.Contains(nodes[2]));
            Assert.IsFalse(nodes[7].neighbors.Contains(nodes[3]));
            Assert.IsFalse(nodes[7].neighbors.Contains(nodes[4]));
            Assert.IsFalse(nodes[7].neighbors.Contains(nodes[5]));
            Assert.IsFalse(nodes[7].neighbors.Contains(nodes[6]));
            streamWriter.Close();
        }

        [TestMethod]
        public void One8CAKENeighborCheck()
        {
            Bomb bomb = new Bomb(Day.Sunday, "88888", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
                    new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
                    new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
                    new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsTrue(nodes[0].neighbors.Contains(nodes[1]));
            Assert.IsTrue(nodes[0].neighbors.Contains(nodes[2]));
            Assert.IsFalse(nodes[0].neighbors.Contains(nodes[3]));
            Assert.IsFalse(nodes[0].neighbors.Contains(nodes[4]));
            Assert.IsTrue(nodes[0].neighbors.Contains(nodes[5]));
            Assert.IsFalse(nodes[0].neighbors.Contains(nodes[6]));
            Assert.IsTrue(nodes[0].neighbors.Contains(nodes[7]));
            streamWriter.Close();
        }

        [TestMethod]
        public void Two8CAKENeighborCheck()
        {
            Bomb bomb = new Bomb(Day.Sunday, "88888", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
                    new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
                    new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
                    new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsTrue(nodes[1].neighbors.Contains(nodes[0]));
            Assert.IsFalse(nodes[1].neighbors.Contains(nodes[2]));
            Assert.IsTrue(nodes[1].neighbors.Contains(nodes[3]));
            Assert.IsFalse(nodes[1].neighbors.Contains(nodes[4]));
            Assert.IsTrue(nodes[1].neighbors.Contains(nodes[5]));
            Assert.IsFalse(nodes[1].neighbors.Contains(nodes[6]));
            Assert.IsFalse(nodes[1].neighbors.Contains(nodes[7]));
            streamWriter.Close();
        }

        [TestMethod]
        public void Three8CAKENeighborCheck()
        {
            Bomb bomb = new Bomb(Day.Sunday, "88888", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
                    new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
                    new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
                    new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsTrue(nodes[2].neighbors.Contains(nodes[0]));
            Assert.IsFalse(nodes[2].neighbors.Contains(nodes[1]));
            Assert.IsTrue(nodes[2].neighbors.Contains(nodes[3]));
            Assert.IsFalse(nodes[2].neighbors.Contains(nodes[4]));
            Assert.IsTrue(nodes[2].neighbors.Contains(nodes[5]));
            Assert.IsTrue(nodes[2].neighbors.Contains(nodes[6]));
            Assert.IsTrue(nodes[2].neighbors.Contains(nodes[7]));
            streamWriter.Close();
        }

        [TestMethod]
        public void Four8CAKENeighborCheck()
        {
            Bomb bomb = new Bomb(Day.Sunday, "88888", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
                    new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
                    new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
                    new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsFalse(nodes[3].neighbors.Contains(nodes[0]));
            Assert.IsTrue(nodes[3].neighbors.Contains(nodes[1]));
            Assert.IsTrue(nodes[3].neighbors.Contains(nodes[2]));
            Assert.IsTrue(nodes[3].neighbors.Contains(nodes[4]));
            Assert.IsTrue(nodes[3].neighbors.Contains(nodes[5]));
            Assert.IsTrue(nodes[3].neighbors.Contains(nodes[6]));
            Assert.IsFalse(nodes[3].neighbors.Contains(nodes[7]));
            streamWriter.Close();
        }

        [TestMethod]
        public void Five8CAKENeighborCheck()
        {
            Bomb bomb = new Bomb(Day.Sunday, "88888", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
                    new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
                    new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
                    new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsFalse(nodes[4].neighbors.Contains(nodes[0]));
            Assert.IsFalse(nodes[4].neighbors.Contains(nodes[1]));
            Assert.IsFalse(nodes[4].neighbors.Contains(nodes[2]));
            Assert.IsTrue(nodes[4].neighbors.Contains(nodes[3]));
            Assert.IsFalse(nodes[4].neighbors.Contains(nodes[5]));
            Assert.IsTrue(nodes[4].neighbors.Contains(nodes[6]));
            Assert.IsTrue(nodes[4].neighbors.Contains(nodes[7]));
            streamWriter.Close();
        }

        [TestMethod]
        public void Six8CAKENeighborCheck()
        {
            Bomb bomb = new Bomb(Day.Sunday, "88888", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
                    new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
                    new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
                    new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsTrue(nodes[5].neighbors.Contains(nodes[0]));
            Assert.IsTrue(nodes[5].neighbors.Contains(nodes[1]));
            Assert.IsTrue(nodes[5].neighbors.Contains(nodes[2]));
            Assert.IsTrue(nodes[5].neighbors.Contains(nodes[3]));
            Assert.IsFalse(nodes[5].neighbors.Contains(nodes[4]));
            Assert.IsFalse(nodes[5].neighbors.Contains(nodes[6]));
            Assert.IsFalse(nodes[5].neighbors.Contains(nodes[7]));
            streamWriter.Close();
        }

        [TestMethod]
        public void Seven8CAKENeighborCheck()
        {
            Bomb bomb = new Bomb(Day.Sunday, "88888", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
                    new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
                    new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
                    new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsFalse(nodes[6].neighbors.Contains(nodes[0]));
            Assert.IsFalse(nodes[6].neighbors.Contains(nodes[1]));
            Assert.IsTrue(nodes[6].neighbors.Contains(nodes[2]));
            Assert.IsTrue(nodes[6].neighbors.Contains(nodes[3]));
            Assert.IsTrue(nodes[6].neighbors.Contains(nodes[4]));
            Assert.IsFalse(nodes[6].neighbors.Contains(nodes[5]));
            Assert.IsTrue(nodes[6].neighbors.Contains(nodes[7]));
            streamWriter.Close();
        }

        [TestMethod]
        public void Eight8CAKENeighborCheck()
        {
            Bomb bomb = new Bomb(Day.Sunday, "88888", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
                    new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
                    new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
                    new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsTrue(nodes[7].neighbors.Contains(nodes[0]));
            Assert.IsFalse(nodes[7].neighbors.Contains(nodes[1]));
            Assert.IsTrue(nodes[7].neighbors.Contains(nodes[2]));
            Assert.IsFalse(nodes[7].neighbors.Contains(nodes[3]));
            Assert.IsTrue(nodes[7].neighbors.Contains(nodes[4]));
            Assert.IsFalse(nodes[7].neighbors.Contains(nodes[5]));
            Assert.IsTrue(nodes[7].neighbors.Contains(nodes[6]));
            streamWriter.Close();
        }

        [TestMethod]
        public void One15BRONeighborCheck()
        {
            Bomb bomb = new Bomb(Day.Sunday, "11111", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
                    new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
                    new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
                    new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsTrue(nodes[0].neighbors.Contains(nodes[1]));
            Assert.IsFalse(nodes[0].neighbors.Contains(nodes[2]));
            Assert.IsFalse(nodes[0].neighbors.Contains(nodes[3]));
            Assert.IsFalse(nodes[0].neighbors.Contains(nodes[4]));
            Assert.IsFalse(nodes[0].neighbors.Contains(nodes[5]));
            Assert.IsTrue(nodes[0].neighbors.Contains(nodes[6]));
            Assert.IsFalse(nodes[0].neighbors.Contains(nodes[7]));
            streamWriter.Close();
        }

        [TestMethod]
        public void Two15BRONeighborCheck()
        {
            Bomb bomb = new Bomb(Day.Sunday, "11111", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
        new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
        new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
        new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsTrue(nodes[1].neighbors.Contains(nodes[0]));
            Assert.IsFalse(nodes[1].neighbors.Contains(nodes[2]));
            Assert.IsFalse(nodes[1].neighbors.Contains(nodes[3]));
            Assert.IsFalse(nodes[1].neighbors.Contains(nodes[4]));
            Assert.IsFalse(nodes[1].neighbors.Contains(nodes[5]));
            Assert.IsTrue(nodes[1].neighbors.Contains(nodes[6]));
            Assert.IsFalse(nodes[1].neighbors.Contains(nodes[7]));
            streamWriter.Close();
        }

        [TestMethod]
        public void Three15BRONeighborCheck()
        {
            Bomb bomb = new Bomb(Day.Sunday, "11111", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
        new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
        new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
        new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsFalse(nodes[2].neighbors.Contains(nodes[0]));
            Assert.IsFalse(nodes[2].neighbors.Contains(nodes[1]));
            Assert.IsTrue(nodes[2].neighbors.Contains(nodes[3]));
            Assert.IsFalse(nodes[2].neighbors.Contains(nodes[4]));
            Assert.IsFalse(nodes[2].neighbors.Contains(nodes[5]));
            Assert.IsFalse(nodes[2].neighbors.Contains(nodes[6]));
            Assert.IsTrue(nodes[2].neighbors.Contains(nodes[7]));
            streamWriter.Close();
        }

        [TestMethod]
        public void Four15BRONeighborCheck()
        {
            Bomb bomb = new Bomb(Day.Sunday, "11111", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
        new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
        new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
        new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsFalse(nodes[3].neighbors.Contains(nodes[0]));
            Assert.IsFalse(nodes[3].neighbors.Contains(nodes[1]));
            Assert.IsTrue(nodes[3].neighbors.Contains(nodes[2]));
            Assert.IsFalse(nodes[3].neighbors.Contains(nodes[4]));
            Assert.IsFalse(nodes[3].neighbors.Contains(nodes[5]));
            Assert.IsFalse(nodes[3].neighbors.Contains(nodes[6]));
            Assert.IsTrue(nodes[3].neighbors.Contains(nodes[7]));
            streamWriter.Close();
        }

        [TestMethod]
        public void Five15BRONeighborCheck()
        {
            Bomb bomb = new Bomb(Day.Sunday, "11111", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
        new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
        new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
        new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsFalse(nodes[4].neighbors.Contains(nodes[0]));
            Assert.IsFalse(nodes[4].neighbors.Contains(nodes[1]));
            Assert.IsFalse(nodes[4].neighbors.Contains(nodes[2]));
            Assert.IsFalse(nodes[4].neighbors.Contains(nodes[3]));
            Assert.IsTrue(nodes[4].neighbors.Contains(nodes[5]));
            Assert.IsTrue(nodes[4].neighbors.Contains(nodes[6]));
            Assert.IsFalse(nodes[4].neighbors.Contains(nodes[7]));
            streamWriter.Close();
        }

        [TestMethod]
        public void Six15BRONeighborCheck()
        {
            Bomb bomb = new Bomb(Day.Sunday, "11111", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
        new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
        new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
        new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsFalse(nodes[5].neighbors.Contains(nodes[0]));
            Assert.IsFalse(nodes[5].neighbors.Contains(nodes[1]));
            Assert.IsFalse(nodes[5].neighbors.Contains(nodes[2]));
            Assert.IsFalse(nodes[5].neighbors.Contains(nodes[3]));
            Assert.IsTrue(nodes[5].neighbors.Contains(nodes[4]));
            Assert.IsTrue(nodes[5].neighbors.Contains(nodes[6]));
            Assert.IsFalse(nodes[5].neighbors.Contains(nodes[7]));
            streamWriter.Close();
        }

        [TestMethod]
        public void Seven15BRONeighborCheck()
        {
            Bomb bomb = new Bomb(Day.Sunday, "11111", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
        new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
        new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
        new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsTrue(nodes[6].neighbors.Contains(nodes[0]));
            Assert.IsTrue(nodes[6].neighbors.Contains(nodes[1]));
            Assert.IsFalse(nodes[6].neighbors.Contains(nodes[2]));
            Assert.IsFalse(nodes[6].neighbors.Contains(nodes[3]));
            Assert.IsTrue(nodes[6].neighbors.Contains(nodes[4]));
            Assert.IsTrue(nodes[6].neighbors.Contains(nodes[5]));
            Assert.IsFalse(nodes[6].neighbors.Contains(nodes[7]));
            streamWriter.Close();
        }

        [TestMethod]
        public void Eight15BRONeighborCheck()
        {
            Bomb bomb = new Bomb(Day.Sunday, "11111", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
        new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
        new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
        new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsFalse(nodes[7].neighbors.Contains(nodes[0]));
            Assert.IsFalse(nodes[7].neighbors.Contains(nodes[1]));
            Assert.IsTrue(nodes[7].neighbors.Contains(nodes[2]));
            Assert.IsTrue(nodes[7].neighbors.Contains(nodes[3]));
            Assert.IsFalse(nodes[7].neighbors.Contains(nodes[4]));
            Assert.IsFalse(nodes[7].neighbors.Contains(nodes[5]));
            Assert.IsFalse(nodes[7].neighbors.Contains(nodes[6]));
            streamWriter.Close();
        }

        [TestMethod]
        public void One34XYZNeighborCheck()
        {
            Bomb bomb = new Bomb(Day.Sunday, "33333", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
        new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
        new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
        new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsTrue(nodes[0].neighbors.Contains(nodes[1]));
            Assert.IsFalse(nodes[0].neighbors.Contains(nodes[2]));
            Assert.IsTrue(nodes[0].neighbors.Contains(nodes[3]));
            Assert.IsFalse(nodes[0].neighbors.Contains(nodes[4]));
            Assert.IsTrue(nodes[0].neighbors.Contains(nodes[5]));
            Assert.IsFalse(nodes[0].neighbors.Contains(nodes[6]));
            Assert.IsFalse(nodes[0].neighbors.Contains(nodes[7]));
            streamWriter.Close();
        }

        [TestMethod]
        public void Two34XYZNeighborCheck()
        {
            Bomb bomb = new Bomb(Day.Sunday, "33333", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsTrue(nodes[1].neighbors.Contains(nodes[0]));
            Assert.IsTrue(nodes[1].neighbors.Contains(nodes[2]));
            Assert.IsTrue(nodes[1].neighbors.Contains(nodes[3]));
            Assert.IsFalse(nodes[1].neighbors.Contains(nodes[4]));
            Assert.IsFalse(nodes[1].neighbors.Contains(nodes[5]));
            Assert.IsFalse(nodes[1].neighbors.Contains(nodes[6]));
            Assert.IsFalse(nodes[1].neighbors.Contains(nodes[7]));
            streamWriter.Close();
        }

        [TestMethod]
        public void Three34XYZNeighborCheck()
        {
            Bomb bomb = new Bomb(Day.Sunday, "33333", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsFalse(nodes[2].neighbors.Contains(nodes[0]));
            Assert.IsTrue(nodes[2].neighbors.Contains(nodes[1]));
            Assert.IsFalse(nodes[2].neighbors.Contains(nodes[3]));
            Assert.IsFalse(nodes[2].neighbors.Contains(nodes[4]));
            Assert.IsFalse(nodes[2].neighbors.Contains(nodes[5]));
            Assert.IsFalse(nodes[2].neighbors.Contains(nodes[6]));
            Assert.IsFalse(nodes[2].neighbors.Contains(nodes[7]));
            streamWriter.Close();
        }

        [TestMethod]
        public void Four34XYZNeighborCheck()
        {
            Bomb bomb = new Bomb(Day.Sunday, "33333", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsTrue(nodes[3].neighbors.Contains(nodes[0]));
            Assert.IsTrue(nodes[3].neighbors.Contains(nodes[1]));
            Assert.IsFalse(nodes[3].neighbors.Contains(nodes[2]));
            Assert.IsFalse(nodes[3].neighbors.Contains(nodes[4]));
            Assert.IsFalse(nodes[3].neighbors.Contains(nodes[5]));
            Assert.IsTrue(nodes[3].neighbors.Contains(nodes[6]));
            Assert.IsFalse(nodes[3].neighbors.Contains(nodes[7]));
            streamWriter.Close();
        }

        [TestMethod]
        public void Five34XYZNeighborCheck()
        {
            Bomb bomb = new Bomb(Day.Sunday, "33333", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsFalse(nodes[4].neighbors.Contains(nodes[0]));
            Assert.IsFalse(nodes[4].neighbors.Contains(nodes[1]));
            Assert.IsFalse(nodes[4].neighbors.Contains(nodes[2]));
            Assert.IsFalse(nodes[4].neighbors.Contains(nodes[3]));
            Assert.IsTrue(nodes[4].neighbors.Contains(nodes[5]));
            Assert.IsFalse(nodes[4].neighbors.Contains(nodes[6]));
            Assert.IsFalse(nodes[4].neighbors.Contains(nodes[7]));
            streamWriter.Close();
        }

        [TestMethod]
        public void Six34XYZNeighborCheck()
        {
            Bomb bomb = new Bomb(Day.Sunday, "33333", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsTrue(nodes[5].neighbors.Contains(nodes[0]));
            Assert.IsFalse(nodes[5].neighbors.Contains(nodes[1]));
            Assert.IsFalse(nodes[5].neighbors.Contains(nodes[2]));
            Assert.IsFalse(nodes[5].neighbors.Contains(nodes[3]));
            Assert.IsTrue(nodes[5].neighbors.Contains(nodes[4]));
            Assert.IsTrue(nodes[5].neighbors.Contains(nodes[6]));
            Assert.IsTrue(nodes[5].neighbors.Contains(nodes[7]));
            streamWriter.Close();
        }

        [TestMethod]
        public void Seven34XYZNeighborCheck()
        {
            Bomb bomb = new Bomb(Day.Sunday, "33333", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsFalse(nodes[6].neighbors.Contains(nodes[0]));
            Assert.IsFalse(nodes[6].neighbors.Contains(nodes[1]));
            Assert.IsFalse(nodes[6].neighbors.Contains(nodes[2]));
            Assert.IsTrue(nodes[6].neighbors.Contains(nodes[3]));
            Assert.IsFalse(nodes[6].neighbors.Contains(nodes[4]));
            Assert.IsTrue(nodes[6].neighbors.Contains(nodes[5]));
            Assert.IsTrue(nodes[6].neighbors.Contains(nodes[7]));
            streamWriter.Close();
        }

        [TestMethod]
        public void Eight34XYZNeighborCheck()
        {
            Bomb bomb = new Bomb(Day.Sunday, "33333", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsFalse(nodes[7].neighbors.Contains(nodes[0]));
            Assert.IsFalse(nodes[7].neighbors.Contains(nodes[1]));
            Assert.IsFalse(nodes[7].neighbors.Contains(nodes[2]));
            Assert.IsFalse(nodes[7].neighbors.Contains(nodes[3]));
            Assert.IsFalse(nodes[7].neighbors.Contains(nodes[4]));
            Assert.IsTrue(nodes[7].neighbors.Contains(nodes[5]));
            Assert.IsTrue(nodes[7].neighbors.Contains(nodes[6]));
            streamWriter.Close();
        }


        [TestMethod]
        public void One6WUFNeighborCheck()
        {
            Bomb bomb = new Bomb(Day.Sunday, "66666", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsTrue(nodes[0].neighbors.Contains(nodes[1]));
            Assert.IsFalse(nodes[0].neighbors.Contains(nodes[2]));
            Assert.IsFalse(nodes[0].neighbors.Contains(nodes[3]));
            Assert.IsFalse(nodes[0].neighbors.Contains(nodes[4]));
            Assert.IsTrue(nodes[0].neighbors.Contains(nodes[5]));
            Assert.IsTrue(nodes[0].neighbors.Contains(nodes[6]));
            Assert.IsFalse(nodes[0].neighbors.Contains(nodes[7]));
            streamWriter.Close();
        }

        [TestMethod]
        public void Two6WUFNeighborCheck()
        {
            Bomb bomb = new Bomb(Day.Sunday, "66666", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsTrue(nodes[1].neighbors.Contains(nodes[0]));
            Assert.IsTrue(nodes[1].neighbors.Contains(nodes[2]));
            Assert.IsFalse(nodes[1].neighbors.Contains(nodes[3]));
            Assert.IsFalse(nodes[1].neighbors.Contains(nodes[4]));
            Assert.IsFalse(nodes[1].neighbors.Contains(nodes[5]));
            Assert.IsTrue(nodes[1].neighbors.Contains(nodes[6]));
            Assert.IsTrue(nodes[1].neighbors.Contains(nodes[7]));
            streamWriter.Close();
        }

        [TestMethod]
        public void Three6WUFNeighborCheck()
        {
            Bomb bomb = new Bomb(Day.Sunday, "66666", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsFalse(nodes[2].neighbors.Contains(nodes[0]));
            Assert.IsTrue(nodes[2].neighbors.Contains(nodes[1]));
            Assert.IsFalse(nodes[2].neighbors.Contains(nodes[3]));
            Assert.IsTrue(nodes[2].neighbors.Contains(nodes[4]));
            Assert.IsTrue(nodes[2].neighbors.Contains(nodes[5]));
            Assert.IsFalse(nodes[2].neighbors.Contains(nodes[6]));
            Assert.IsTrue(nodes[2].neighbors.Contains(nodes[7]));
            streamWriter.Close();
        }

        [TestMethod]
        public void Four6WUFNeighborCheck()
        {
            Bomb bomb = new Bomb(Day.Sunday, "66666", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsFalse(nodes[3].neighbors.Contains(nodes[0]));
            Assert.IsFalse(nodes[3].neighbors.Contains(nodes[1]));
            Assert.IsFalse(nodes[3].neighbors.Contains(nodes[2]));
            Assert.IsTrue(nodes[3].neighbors.Contains(nodes[4]));
            Assert.IsFalse(nodes[3].neighbors.Contains(nodes[5]));
            Assert.IsTrue(nodes[3].neighbors.Contains(nodes[6]));
            Assert.IsTrue(nodes[3].neighbors.Contains(nodes[7]));
            streamWriter.Close();
        }

        [TestMethod]
        public void Five6WUFNeighborCheck()
        {
            Bomb bomb = new Bomb(Day.Sunday, "66666", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsFalse(nodes[4].neighbors.Contains(nodes[0]));
            Assert.IsFalse(nodes[4].neighbors.Contains(nodes[1]));
            Assert.IsTrue(nodes[4].neighbors.Contains(nodes[2]));
            Assert.IsTrue(nodes[4].neighbors.Contains(nodes[3]));
            Assert.IsTrue(nodes[4].neighbors.Contains(nodes[5]));
            Assert.IsTrue(nodes[4].neighbors.Contains(nodes[6]));
            Assert.IsFalse(nodes[4].neighbors.Contains(nodes[7]));
            streamWriter.Close();
        }

        [TestMethod]
        public void Six6WUFNeighborCheck()
        {
            Bomb bomb = new Bomb(Day.Sunday, "66666", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsTrue(nodes[5].neighbors.Contains(nodes[0]));
            Assert.IsFalse(nodes[5].neighbors.Contains(nodes[1]));
            Assert.IsTrue(nodes[5].neighbors.Contains(nodes[2]));
            Assert.IsFalse(nodes[5].neighbors.Contains(nodes[3]));
            Assert.IsTrue(nodes[5].neighbors.Contains(nodes[4]));
            Assert.IsTrue(nodes[5].neighbors.Contains(nodes[6]));
            Assert.IsFalse(nodes[5].neighbors.Contains(nodes[7]));
            streamWriter.Close();
        }

        [TestMethod]
        public void Seven6WUFNeighborCheck()
        {
            Bomb bomb = new Bomb(Day.Sunday, "66666", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsTrue(nodes[6].neighbors.Contains(nodes[0]));
            Assert.IsTrue(nodes[6].neighbors.Contains(nodes[1]));
            Assert.IsFalse(nodes[6].neighbors.Contains(nodes[2]));
            Assert.IsTrue(nodes[6].neighbors.Contains(nodes[3]));
            Assert.IsTrue(nodes[6].neighbors.Contains(nodes[4]));
            Assert.IsTrue(nodes[6].neighbors.Contains(nodes[5]));
            Assert.IsTrue(nodes[6].neighbors.Contains(nodes[7]));
            streamWriter.Close();
        }

        [TestMethod]
        public void Eight6WUFNeighborCheck()
        {
            Bomb bomb = new Bomb(Day.Sunday, "66666", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsFalse(nodes[7].neighbors.Contains(nodes[0]));
            Assert.IsTrue(nodes[7].neighbors.Contains(nodes[1]));
            Assert.IsTrue(nodes[7].neighbors.Contains(nodes[2]));
            Assert.IsTrue(nodes[7].neighbors.Contains(nodes[3]));
            Assert.IsFalse(nodes[7].neighbors.Contains(nodes[4]));
            Assert.IsFalse(nodes[7].neighbors.Contains(nodes[5]));
            Assert.IsTrue(nodes[7].neighbors.Contains(nodes[6]));
            streamWriter.Close();
        }

        [TestMethod]
        public void One9QVNNeighborCheck()
        {
            Bomb bomb = new Bomb(Day.Sunday, "99999", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsTrue(nodes[0].neighbors.Contains(nodes[1]));
            Assert.IsFalse(nodes[0].neighbors.Contains(nodes[2]));
            Assert.IsTrue(nodes[0].neighbors.Contains(nodes[3]));
            Assert.IsFalse(nodes[0].neighbors.Contains(nodes[4]));
            Assert.IsFalse(nodes[0].neighbors.Contains(nodes[5]));
            Assert.IsFalse(nodes[0].neighbors.Contains(nodes[6]));
            Assert.IsTrue(nodes[0].neighbors.Contains(nodes[7]));
            streamWriter.Close();
        }

        [TestMethod]
        public void Two9QVNNeighborCheck()
        {
            Bomb bomb = new Bomb(Day.Sunday, "99999", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsTrue(nodes[1].neighbors.Contains(nodes[0]));
            Assert.IsTrue(nodes[1].neighbors.Contains(nodes[2]));
            Assert.IsFalse(nodes[1].neighbors.Contains(nodes[3]));
            Assert.IsFalse(nodes[1].neighbors.Contains(nodes[4]));
            Assert.IsTrue(nodes[1].neighbors.Contains(nodes[5]));
            Assert.IsTrue(nodes[1].neighbors.Contains(nodes[6]));
            Assert.IsFalse(nodes[1].neighbors.Contains(nodes[7]));
            streamWriter.Close();
        }

        [TestMethod]
        public void Three9QVNNeighborCheck()
        {
            Bomb bomb = new Bomb(Day.Sunday, "99999", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsFalse(nodes[2].neighbors.Contains(nodes[0]));
            Assert.IsTrue(nodes[2].neighbors.Contains(nodes[1]));
            Assert.IsTrue(nodes[2].neighbors.Contains(nodes[3]));
            Assert.IsFalse(nodes[2].neighbors.Contains(nodes[4]));
            Assert.IsTrue(nodes[2].neighbors.Contains(nodes[5]));
            Assert.IsTrue(nodes[2].neighbors.Contains(nodes[6]));
            Assert.IsFalse(nodes[2].neighbors.Contains(nodes[7]));
            streamWriter.Close();
        }

        [TestMethod]
        public void Four9QVNNeighborCheck()
        {
            Bomb bomb = new Bomb(Day.Sunday, "99999", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsTrue(nodes[3].neighbors.Contains(nodes[0]));
            Assert.IsFalse(nodes[3].neighbors.Contains(nodes[1]));
            Assert.IsTrue(nodes[3].neighbors.Contains(nodes[2]));
            Assert.IsTrue(nodes[3].neighbors.Contains(nodes[4]));
            Assert.IsFalse(nodes[3].neighbors.Contains(nodes[5]));
            Assert.IsFalse(nodes[3].neighbors.Contains(nodes[6]));
            Assert.IsFalse(nodes[3].neighbors.Contains(nodes[7]));
            streamWriter.Close();
        }

        [TestMethod]
        public void Five9QVNNeighborCheck()
        {
            Bomb bomb = new Bomb(Day.Sunday, "99999", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsFalse(nodes[4].neighbors.Contains(nodes[0]));
            Assert.IsFalse(nodes[4].neighbors.Contains(nodes[1]));
            Assert.IsFalse(nodes[4].neighbors.Contains(nodes[2]));
            Assert.IsTrue(nodes[4].neighbors.Contains(nodes[3]));
            Assert.IsTrue(nodes[4].neighbors.Contains(nodes[5]));
            Assert.IsFalse(nodes[4].neighbors.Contains(nodes[6]));
            Assert.IsTrue(nodes[4].neighbors.Contains(nodes[7]));
            streamWriter.Close();
        }

        [TestMethod]
        public void Six9QVNNeighborCheck()
        {
            Bomb bomb = new Bomb(Day.Sunday, "99999", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsFalse(nodes[5].neighbors.Contains(nodes[0]));
            Assert.IsTrue(nodes[5].neighbors.Contains(nodes[1]));
            Assert.IsTrue(nodes[5].neighbors.Contains(nodes[2]));
            Assert.IsFalse(nodes[5].neighbors.Contains(nodes[3]));
            Assert.IsTrue(nodes[5].neighbors.Contains(nodes[4]));
            Assert.IsTrue(nodes[5].neighbors.Contains(nodes[6]));
            Assert.IsFalse(nodes[5].neighbors.Contains(nodes[7]));
            streamWriter.Close();
        }

        [TestMethod]
        public void Seven9QVNNeighborCheck()
        {
            Bomb bomb = new Bomb(Day.Sunday, "99999", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsFalse(nodes[6].neighbors.Contains(nodes[0]));
            Assert.IsTrue(nodes[6].neighbors.Contains(nodes[1]));
            Assert.IsTrue(nodes[6].neighbors.Contains(nodes[2]));
            Assert.IsFalse(nodes[6].neighbors.Contains(nodes[3]));
            Assert.IsFalse(nodes[6].neighbors.Contains(nodes[4]));
            Assert.IsTrue(nodes[6].neighbors.Contains(nodes[5]));
            Assert.IsTrue(nodes[6].neighbors.Contains(nodes[7]));
            streamWriter.Close();
        }

        [TestMethod]
        public void Eight9QVNNeighborCheck()
        {
            Bomb bomb = new Bomb(Day.Sunday, "99999", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(arr, arr, arr, arr, bomb, streamWriter);

            module.CreateGraph();
            List<ConnectionCheck.Node> nodes = module.nodes;

            Assert.IsTrue(nodes[7].neighbors.Contains(nodes[0]));
            Assert.IsFalse(nodes[7].neighbors.Contains(nodes[1]));
            Assert.IsFalse(nodes[7].neighbors.Contains(nodes[2]));
            Assert.IsFalse(nodes[7].neighbors.Contains(nodes[3]));
            Assert.IsTrue(nodes[7].neighbors.Contains(nodes[4]));
            Assert.IsFalse(nodes[7].neighbors.Contains(nodes[5]));
            Assert.IsTrue(nodes[7].neighbors.Contains(nodes[6]));
            streamWriter.Close();
        }

        #endregion

        #region Target Index
        [TestMethod]
        public void NumbersAllDifferent()
        {
            Bomb bomb = new Bomb(Day.Sunday, "IIIII", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
                    new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
                    new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
                    new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

            ConnectionCheck module = new ConnectionCheck(new int[] { 1, 2 }, new int[] { 3, 4 }, new int[] { 5, 6 }, new int[] { 7, 8 }, bomb, streamWriter);

            module.FindTargetIndex();

            Assert.AreEqual(4, module.targetIndex);

            
            streamWriter.Close();
        }

        [TestMethod]
        public void MoreThanOne1()
        {
            Bomb bomb = new Bomb(Day.Sunday, "IIIII", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
                    new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
                    new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
                    new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

            ConnectionCheck module = new ConnectionCheck(new int[] { 1, 1 }, new int[] { 3, 4 }, new int[] { 5, 6 }, new int[] { 7, 8 }, bomb, streamWriter);

            module.FindTargetIndex();

            Assert.AreEqual(0, module.targetIndex);
            streamWriter.Close();
        }

        [TestMethod]
        public void MoreThanOne7()
        {
            Bomb bomb = new Bomb(Day.Sunday, "IIIII", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
                    new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
                    new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
                    new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

            ConnectionCheck module = new ConnectionCheck(new int[] { 7, 2 }, new int[] { 3, 4 }, new int[] { 5, 6 }, new int[] { 7, 8 }, bomb, streamWriter);

            module.FindTargetIndex();

            Assert.AreEqual(4, module.targetIndex);
            streamWriter.Close();
        }

        [TestMethod]
        public void MoreThanTwo2()
        {
            Bomb bomb = new Bomb(Day.Sunday, "IIIII", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
                    new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
                    new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
                    new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

            ConnectionCheck module = new ConnectionCheck(new int[] { 2, 2 }, new int[] { 2, 4 }, new int[] { 5, 6 }, new int[] { 7, 8 }, bomb, streamWriter);

            module.FindTargetIndex();

            Assert.AreEqual(1, module.targetIndex);
            streamWriter.Close();
        }

        [TestMethod]
        public void NoFive()
        {
            Bomb bomb = new Bomb(Day.Sunday, "IIIII", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
                    new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
                    new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
                    new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

            int[] arr = new int[] { 1, 1 };
            ConnectionCheck module = new ConnectionCheck(new int[] { 1, 2 }, new int[] { 3, 4 }, new int[] { 2, 6 }, new int[] { 7, 8 }, bomb, streamWriter);

            module.FindTargetIndex();

            Assert.AreEqual(4, module.targetIndex);
            streamWriter.Close();
        }

        [TestMethod]
        public void Two8()
        {
            Bomb bomb = new Bomb(Day.Sunday, "IIIII", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
                    new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
                    new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
                    new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

            ConnectionCheck module = new ConnectionCheck(new int[] { 8, 2 }, new int[] { 3, 4 }, new int[] { 5, 6 }, new int[] { 7, 8 }, bomb, streamWriter);

            module.FindTargetIndex();

            Assert.AreEqual(2, module.targetIndex);
            streamWriter.Close();
        }

        [TestMethod]
        public void MoreThan6Batteries()
        {
            Bomb bomb = new Bomb(Day.Sunday, "IIIII", 0, 0, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
                    new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
                    new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
                    new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

            ConnectionCheck module = new ConnectionCheck(new int[] { 2, 2 }, new int[] { 3, 4 }, new int[] { 5, 6 }, new int[] { 7, 8 }, bomb, streamWriter);

            module.FindTargetIndex();

            Assert.AreEqual(4, module.targetIndex);
            streamWriter.Close();
        }

        [TestMethod]
        public void BatteryCount()
        {
            Bomb bomb = new Bomb(Day.Sunday, "IIIII", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
                    new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
                    new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
                    new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

            ConnectionCheck module = new ConnectionCheck(new int[] { 2, 2 }, new int[] { 3, 4 }, new int[] { 5, 6 }, new int[] { 7, 8 }, bomb, streamWriter);

            module.FindTargetIndex();

            Assert.AreEqual(bomb.Battery - 1, module.targetIndex);
            streamWriter.Close();
        }

        #endregion

        #region Target Gives Right Graph
        [TestMethod]
        public void Target0()
        {
            Bomb bomb = new Bomb(Day.Sunday, "20DGT", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
                    new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
                    new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
                    new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

            ConnectionCheck module = new ConnectionCheck(new int[] { 2, 2 }, new int[] { 3, 4 }, new int[] { 5, 6 }, new int[] { 7, 8 }, bomb, streamWriter);

            module.targetIndex = 1;

            

            Assert.AreEqual("20DGT", module.CreateGraph());
            streamWriter.Close();
        }

        [TestMethod]
        public void Target1()
        {
            Bomb bomb = new Bomb(Day.Sunday, "15BRO", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

            ConnectionCheck module = new ConnectionCheck(new int[] { 2, 2 }, new int[] { 3, 4 }, new int[] { 5, 6 }, new int[] { 7, 8 }, bomb, streamWriter);

            module.targetIndex = 0;



            Assert.AreEqual("15BRO", module.CreateGraph());
            streamWriter.Close();
        }

        [TestMethod]
        public void Target2()
        {
            Bomb bomb = new Bomb(Day.Sunday, "20DGT", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
                    new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
                    new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
                    new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

            ConnectionCheck module = new ConnectionCheck(new int[] { 2, 2 }, new int[] { 3, 4 }, new int[] { 5, 6 }, new int[] { 7, 8 }, bomb, streamWriter);

            module.targetIndex = 0;

            Assert.AreEqual("20DGT", module.CreateGraph());
            streamWriter.Close();
        }

        [TestMethod]
        public void Target3()
        {
            Bomb bomb = new Bomb(Day.Sunday, "34XYZ", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

            ConnectionCheck module = new ConnectionCheck(new int[] { 2, 2 }, new int[] { 3, 4 }, new int[] { 5, 6 }, new int[] { 7, 8 }, bomb, streamWriter);

            module.targetIndex = 0;



            Assert.AreEqual("34XYZ", module.CreateGraph());
            streamWriter.Close();
        }

        [TestMethod]
        public void Target4()
        {
            Bomb bomb = new Bomb(Day.Sunday, "34XYZ", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

            ConnectionCheck module = new ConnectionCheck(new int[] { 2, 2 }, new int[] { 3, 4 }, new int[] { 5, 6 }, new int[] { 7, 8 }, bomb, streamWriter);

            module.targetIndex = 1;



            Assert.AreEqual("34XYZ", module.CreateGraph());
            streamWriter.Close();
        }

        [TestMethod]
        public void Target5()
        {
            Bomb bomb = new Bomb(Day.Sunday, "15BRO", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

            ConnectionCheck module = new ConnectionCheck(new int[] { 2, 2 }, new int[] { 3, 4 }, new int[] { 5, 6 }, new int[] { 7, 8 }, bomb, streamWriter);

            module.targetIndex = 1;



            Assert.AreEqual("15BRO", module.CreateGraph());
            streamWriter.Close();
        }

        [TestMethod]
        public void Target6()
        {
            Bomb bomb = new Bomb(Day.Sunday, "6WUFF", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

            ConnectionCheck module = new ConnectionCheck(new int[] { 2, 2 }, new int[] { 3, 4 }, new int[] { 5, 6 }, new int[] { 7, 8 }, bomb, streamWriter);

            module.targetIndex = 0;



            Assert.AreEqual("6WUF", module.CreateGraph());
            streamWriter.Close();
        }

        [TestMethod]
        public void Target7()
        {
            Bomb bomb = new Bomb(Day.Sunday, "7HPJJ", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
        new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
        new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
        new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

            ConnectionCheck module = new ConnectionCheck(new int[] { 2, 2 }, new int[] { 3, 4 }, new int[] { 5, 6 }, new int[] { 7, 8 }, bomb, streamWriter);

            module.targetIndex = 0;



            Assert.AreEqual("7HPJ", module.CreateGraph());
            streamWriter.Close();
        }

        [TestMethod]
        public void Target8()
        {
            Bomb bomb = new Bomb(Day.Sunday, "8CAKE", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
        new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
        new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
        new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

            ConnectionCheck module = new ConnectionCheck(new int[] { 2, 2 }, new int[] { 3, 4 }, new int[] { 5, 6 }, new int[] { 7, 8 }, bomb, streamWriter);

            module.targetIndex = 0;



            Assert.AreEqual("8CAKE", module.CreateGraph());
            streamWriter.Close();
        }

        [TestMethod]
        public void Target9()
        {
            Bomb bomb = new Bomb(Day.Sunday, "9QVNN", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

            ConnectionCheck module = new ConnectionCheck(new int[] { 2, 2 }, new int[] { 3, 4 }, new int[] { 5, 6 }, new int[] { 7, 8 }, bomb, streamWriter);

            module.targetIndex = 0;
            
            Assert.AreEqual("9QVN", module.CreateGraph());
            streamWriter.Close();

        }

        [TestMethod]
        public void TargetA()
        {
            Bomb bomb = new Bomb(Day.Sunday, "8CAKE", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

            ConnectionCheck module = new ConnectionCheck(new int[] { 2, 2 }, new int[] { 3, 4 }, new int[] { 5, 6 }, new int[] { 7, 8 }, bomb, streamWriter);

            module.targetIndex = 2;



            Assert.AreEqual("8CAKE", module.CreateGraph());
            streamWriter.Close();
        }

        [TestMethod]
        public void TargetB()
        {
            Bomb bomb = new Bomb(Day.Sunday, "15BRO", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

            ConnectionCheck module = new ConnectionCheck(new int[] { 2, 2 }, new int[] { 3, 4 }, new int[] { 5, 6 }, new int[] { 7, 8 }, bomb, streamWriter);

            module.targetIndex = 2;



            Assert.AreEqual("15BRO", module.CreateGraph());
            streamWriter.Close();
        }

        [TestMethod]
        public void TargetC()
        {
            Bomb bomb = new Bomb(Day.Sunday, "8CAKE", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

            ConnectionCheck module = new ConnectionCheck(new int[] { 2, 2 }, new int[] { 3, 4 }, new int[] { 5, 6 }, new int[] { 7, 8 }, bomb, streamWriter);

            module.targetIndex = 1;



            Assert.AreEqual("8CAKE", module.CreateGraph());
            streamWriter.Close();
        }

        [TestMethod]
        public void TargetD()
        {
            Bomb bomb = new Bomb(Day.Sunday, "20DGT", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
        new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
        new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
        new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

            ConnectionCheck module = new ConnectionCheck(new int[] { 2, 2 }, new int[] { 3, 4 }, new int[] { 5, 6 }, new int[] { 7, 8 }, bomb, streamWriter);

            module.targetIndex = 2;

            Assert.AreEqual("20DGT", module.CreateGraph());
            streamWriter.Close();
        }

        [TestMethod]
        public void TargetE()
        {
            Bomb bomb = new Bomb(Day.Sunday, "8CAKE", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

            ConnectionCheck module = new ConnectionCheck(new int[] { 2, 2 }, new int[] { 3, 4 }, new int[] { 5, 6 }, new int[] { 7, 8 }, bomb, streamWriter);

            module.targetIndex = 4;



            Assert.AreEqual("8CAKE", module.CreateGraph());
            streamWriter.Close();
        }

        [TestMethod]
        public void TargetF()
        {
            Bomb bomb = new Bomb(Day.Sunday, "6WUFF", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

            ConnectionCheck module = new ConnectionCheck(new int[] { 2, 2 }, new int[] { 3, 4 }, new int[] { 5, 6 }, new int[] { 7, 8 }, bomb, streamWriter);

            module.targetIndex = 3;



            Assert.AreEqual("6WUF", module.CreateGraph());
            streamWriter.Close();
        }

        [TestMethod]
        public void TargetG()
        {
            Bomb bomb = new Bomb(Day.Sunday, "20DGT", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
        new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
        new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
        new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

            ConnectionCheck module = new ConnectionCheck(new int[] { 2, 2 }, new int[] { 3, 4 }, new int[] { 5, 6 }, new int[] { 7, 8 }, bomb, streamWriter);

            module.targetIndex = 4;

            Assert.AreEqual("20DGT", module.CreateGraph());
            streamWriter.Close();
        }

        [TestMethod]
        public void TargetH()
        {
            Bomb bomb = new Bomb(Day.Sunday, "7HPJJ", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
        new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
        new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
        new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

            ConnectionCheck module = new ConnectionCheck(new int[] { 2, 2 }, new int[] { 3, 4 }, new int[] { 5, 6 }, new int[] { 7, 8 }, bomb, streamWriter);

            module.targetIndex = 1;



            Assert.AreEqual("7HPJ", module.CreateGraph());
            streamWriter.Close();
        }

        [TestMethod]
        public void TargetI()
        {
            Bomb bomb = new Bomb(Day.Sunday, "SLIMM", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
        new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
        new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
        new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

            ConnectionCheck module = new ConnectionCheck(new int[] { 2, 2 }, new int[] { 3, 4 }, new int[] { 5, 6 }, new int[] { 7, 8 }, bomb, streamWriter);

            module.targetIndex = 2;



            Assert.AreEqual("SLIM", module.CreateGraph());
            streamWriter.Close();
        }

        [TestMethod]
        public void TargetJ()
        {
            Bomb bomb = new Bomb(Day.Sunday, "7HPJJ", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
        new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
        new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
        new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

            ConnectionCheck module = new ConnectionCheck(new int[] { 2, 2 }, new int[] { 3, 4 }, new int[] { 5, 6 }, new int[] { 7, 8 }, bomb, streamWriter);

            module.targetIndex = 4;



            Assert.AreEqual("7HPJ", module.CreateGraph());
            streamWriter.Close();
        }

        [TestMethod]
        public void TargetK()
        {
            Bomb bomb = new Bomb(Day.Sunday, "8CAKE", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

            ConnectionCheck module = new ConnectionCheck(new int[] { 2, 2 }, new int[] { 3, 4 }, new int[] { 5, 6 }, new int[] { 7, 8 }, bomb, streamWriter);

            module.targetIndex = 3;



            Assert.AreEqual("8CAKE", module.CreateGraph());
            streamWriter.Close();
        }

        [TestMethod]
        public void TargetL()
        {
            Bomb bomb = new Bomb(Day.Sunday, "SLIMM", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
        new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
        new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
        new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

            ConnectionCheck module = new ConnectionCheck(new int[] { 2, 2 }, new int[] { 3, 4 }, new int[] { 5, 6 }, new int[] { 7, 8 }, bomb, streamWriter);

            module.targetIndex = 1;



            Assert.AreEqual("SLIM", module.CreateGraph());
            streamWriter.Close();
        }

        [TestMethod]
        public void TargetM()
        {
            Bomb bomb = new Bomb(Day.Sunday, "SLIMM", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
        new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
        new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
        new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

            ConnectionCheck module = new ConnectionCheck(new int[] { 2, 2 }, new int[] { 3, 4 }, new int[] { 5, 6 }, new int[] { 7, 8 }, bomb, streamWriter);

            module.targetIndex = 3;



            Assert.AreEqual("SLIM", module.CreateGraph());
            streamWriter.Close();
        }

        [TestMethod]
        public void TargetN()
        {
            Bomb bomb = new Bomb(Day.Sunday, "9QVNN", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

            ConnectionCheck module = new ConnectionCheck(new int[] { 2, 2 }, new int[] { 3, 4 }, new int[] { 5, 6 }, new int[] { 7, 8 }, bomb, streamWriter);

            module.targetIndex = 3;

            Assert.AreEqual("9QVN", module.CreateGraph());
            streamWriter.Close();
        }

        [TestMethod]
        public void TargetO()
        {
            Bomb bomb = new Bomb(Day.Sunday, "15BRO", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

            ConnectionCheck module = new ConnectionCheck(new int[] { 2, 2 }, new int[] { 3, 4 }, new int[] { 5, 6 }, new int[] { 7, 8 }, bomb, streamWriter);

            module.targetIndex = 4;



            Assert.AreEqual("15BRO", module.CreateGraph());
            streamWriter.Close();
        }

        [TestMethod]
        public void TargetP()
        {
            Bomb bomb = new Bomb(Day.Sunday, "7HPJJ", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
        new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
        new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
        new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

            ConnectionCheck module = new ConnectionCheck(new int[] { 2, 2 }, new int[] { 3, 4 }, new int[] { 5, 6 }, new int[] { 7, 8 }, bomb, streamWriter);

            module.targetIndex = 2;



            Assert.AreEqual("7HPJ", module.CreateGraph());
            streamWriter.Close();
        }

        [TestMethod]
        public void TargetQ()
        {
            Bomb bomb = new Bomb(Day.Sunday, "9QVNN", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

            ConnectionCheck module = new ConnectionCheck(new int[] { 2, 2 }, new int[] { 3, 4 }, new int[] { 5, 6 }, new int[] { 7, 8 }, bomb, streamWriter);

            module.targetIndex = 1;

            Assert.AreEqual("9QVN", module.CreateGraph());
            streamWriter.Close();
        }

        [TestMethod]
        public void TargetR()
        {
            Bomb bomb = new Bomb(Day.Sunday, "15BRO", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

            ConnectionCheck module = new ConnectionCheck(new int[] { 2, 2 }, new int[] { 3, 4 }, new int[] { 5, 6 }, new int[] { 7, 8 }, bomb, streamWriter);

            module.targetIndex = 3;



            Assert.AreEqual("15BRO", module.CreateGraph());
            streamWriter.Close();
        }

        [TestMethod]
        public void TargetS()
        {
            Bomb bomb = new Bomb(Day.Sunday, "SLIMM", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
                    new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
                    new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
                    new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

            ConnectionCheck module = new ConnectionCheck(new int[] { 2, 2 }, new int[] { 3, 4 }, new int[] { 5, 6 }, new int[] { 7, 8 }, bomb, streamWriter);

            module.targetIndex = 0;



            Assert.AreEqual("SLIM", module.CreateGraph());
            streamWriter.Close();
        }

        [TestMethod]
        public void TargetT()
        {
            Bomb bomb = new Bomb(Day.Sunday, "20DGT", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
        new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
        new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
        new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

            ConnectionCheck module = new ConnectionCheck(new int[] { 2, 2 }, new int[] { 3, 4 }, new int[] { 5, 6 }, new int[] { 7, 8 }, bomb, streamWriter);

            module.targetIndex = 4;

            Assert.AreEqual("20DGT", module.CreateGraph());
            streamWriter.Close();
        }

        [TestMethod]
        public void TargetU()
        {
            Bomb bomb = new Bomb(Day.Sunday, "6WUFF", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

            ConnectionCheck module = new ConnectionCheck(new int[] { 2, 2 }, new int[] { 3, 4 }, new int[] { 5, 6 }, new int[] { 7, 8 }, bomb, streamWriter);

            module.targetIndex = 2;



            Assert.AreEqual("6WUF", module.CreateGraph());
            streamWriter.Close();
        }

        [TestMethod]
        public void TargetV()
        {
            Bomb bomb = new Bomb(Day.Sunday, "9QVNN", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

            ConnectionCheck module = new ConnectionCheck(new int[] { 2, 2 }, new int[] { 3, 4 }, new int[] { 5, 6 }, new int[] { 7, 8 }, bomb, streamWriter);

            module.targetIndex = 2;

            Assert.AreEqual("9QVN", module.CreateGraph());
            streamWriter.Close();
        }

        [TestMethod]
        public void TargetW()
        {
            Bomb bomb = new Bomb(Day.Sunday, "6WUFF", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

            ConnectionCheck module = new ConnectionCheck(new int[] { 2, 2 }, new int[] { 3, 4 }, new int[] { 5, 6 }, new int[] { 7, 8 }, bomb, streamWriter);

            module.targetIndex = 1;



            Assert.AreEqual("6WUF", module.CreateGraph());
            streamWriter.Close();
        }

        [TestMethod]
        public void TargetX()
        {
            Bomb bomb = new Bomb(Day.Sunday, "34XYZ", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

            ConnectionCheck module = new ConnectionCheck(new int[] { 2, 2 }, new int[] { 3, 4 }, new int[] { 5, 6 }, new int[] { 7, 8 }, bomb, streamWriter);

            module.targetIndex = 2;



            Assert.AreEqual("34XYZ", module.CreateGraph());
            streamWriter.Close();
        }

        [TestMethod]
        public void TargetY()
        {
            Bomb bomb = new Bomb(Day.Sunday, "34XYZ", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

            ConnectionCheck module = new ConnectionCheck(new int[] { 2, 2 }, new int[] { 3, 4 }, new int[] { 5, 6 }, new int[] { 7, 8 }, bomb, streamWriter);

            module.targetIndex = 3;



            Assert.AreEqual("34XYZ", module.CreateGraph());
            streamWriter.Close();
        }

        [TestMethod]
        public void TargetZ()
        {
            Bomb bomb = new Bomb(Day.Sunday, "34XYZ", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

            ConnectionCheck module = new ConnectionCheck(new int[] { 2, 2 }, new int[] { 3, 4 }, new int[] { 5, 6 }, new int[] { 7, 8 }, bomb, streamWriter);

            module.targetIndex = 4;



            Assert.AreEqual("34XYZ", module.CreateGraph());
            streamWriter.Close();
        }
        #endregion








    }
}
