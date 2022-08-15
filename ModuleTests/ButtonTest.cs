using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using KTANE_Solver;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace ModuleTests
{
    [TestClass]
    public class ButtonTest
    {

        StreamWriter io = new StreamWriter("dummy.txt");

        string holdAnswer = "Hold Button\nBlue: 4\nYellow: 5\nElse: 1";

        [TestMethod]
        public void BlueAbort()
        {
            Bomb bomb = new Bomb(Day.Sunday, "IIIII", 2, 2, 
            new Indicator("BOB", false, false), new Indicator("CAR", false, false), new Indicator("CLR", false, false),
            new Indicator("FRK", false, false), new Indicator("FRQ", false, false), new Indicator("IND", false, false), 
            new Indicator("MSA", false, false), new Indicator("NSA", false, false), new Indicator("SIG", false, false), 
            new Indicator("SND", false, false), new Indicator("TRN", false, false), false, 2, 
            new Port("DVID", 0), new Port("Parallel", 1), new Port("ps", 0), 
            new Port("rj", 0), new Port("serial", 0), new Port("setero", 0));

            KTANE_Solver.Button module = new KTANE_Solver.Button(bomb, io);

            Assert.AreEqual(holdAnswer, module.Solve(Color.Blue, "Abort"));

            io.Close();
        }

        [TestMethod]
        public void Detonate1Battery()
        {
            Bomb bomb = new Bomb(Day.Sunday, "IIIII", 2, 2,
            new Indicator("BOB", false, false), new Indicator("CAR", false, false), new Indicator("CLR", false, false),
            new Indicator("FRK", false, false), new Indicator("FRQ", false, false), new Indicator("IND", false, false),
            new Indicator("MSA", false, false), new Indicator("NSA", false, false), new Indicator("SIG", false, false),
            new Indicator("SND", false, false), new Indicator("TRN", false, false), false, 2,
            new Port("DVID", 0), new Port("Parallel", 1), new Port("ps", 0),
            new Port("rj", 0), new Port("serial", 0), new Port("setero", 0));

            KTANE_Solver.Button module = new KTANE_Solver.Button(bomb, io);

            Assert.AreEqual("Press", module.Solve(Color.Blue, "Detonate"));

            io.Close();
        }

        [TestMethod]
        public void WhiteLitCar()
        {
            Bomb bomb = new Bomb(Day.Sunday, "IIIII", 1, 1,
            new Indicator("BOB", false, false), new Indicator("CAR", true, true), new Indicator("CLR", false, false),
            new Indicator("FRK", false, false), new Indicator("FRQ", false, false), new Indicator("IND", false, false),
            new Indicator("MSA", false, false), new Indicator("NSA", false, false), new Indicator("SIG", false, false),
            new Indicator("SND", false, false), new Indicator("TRN", false, false), false, 2,
            new Port("DVID", 0), new Port("Parallel", 1), new Port("ps", 0),
            new Port("rj", 0), new Port("serial", 0), new Port("setero", 0));

            KTANE_Solver.Button module = new KTANE_Solver.Button(bomb, io);

            Assert.AreEqual(holdAnswer, module.Solve(Color.White, "Abort"));

            io.Close();
        }

        [TestMethod]
        public void LitFRK2Battery()
        {
            Bomb bomb = new Bomb(Day.Sunday, "IIIII", 3, 3,
            new Indicator("BOB", false, false), new Indicator("CAR", false, false), new Indicator("CLR", false, false),
            new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false),
            new Indicator("MSA", false, false), new Indicator("NSA", false, false), new Indicator("SIG", false, false),
            new Indicator("SND", false, false), new Indicator("TRN", false, false), false, 2,
            new Port("DVID", 0), new Port("Parallel", 1), new Port("ps", 0),
            new Port("rj", 0), new Port("serial", 0), new Port("setero", 0));

            KTANE_Solver.Button module = new KTANE_Solver.Button(bomb, io);

            Assert.AreEqual("Press", module.Solve(Color.White, "Abort"));

            io.Close();
        }

        [TestMethod]
        public void Yellow()
        {
            Bomb bomb = new Bomb(Day.Sunday, "IIIII", 1, 1,
            new Indicator("BOB", false, false), new Indicator("CAR", false, false), new Indicator("CLR", false, false),
            new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false),
            new Indicator("MSA", false, false), new Indicator("NSA", false, false), new Indicator("SIG", false, false),
            new Indicator("SND", false, false), new Indicator("TRN", false, false), false, 2,
            new Port("DVID", 0), new Port("Parallel", 1), new Port("ps", 0),
            new Port("rj", 0), new Port("serial", 0), new Port("setero", 0));

            KTANE_Solver.Button module = new KTANE_Solver.Button(bomb, io);

            Assert.AreEqual(holdAnswer, module.Solve(Color.Yellow, "Abort"));

            io.Close();
        }

        [TestMethod]
        public void RedHold()
        {
            Bomb bomb = new Bomb(Day.Sunday, "IIIII", 1, 1,
            new Indicator("BOB", false, false), new Indicator("CAR", false, false), new Indicator("CLR", false, false),
            new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false),
            new Indicator("MSA", false, false), new Indicator("NSA", false, false), new Indicator("SIG", false, false),
            new Indicator("SND", false, false), new Indicator("TRN", false, false), false, 2,
            new Port("DVID", 0), new Port("Parallel", 1), new Port("ps", 0),
            new Port("rj", 0), new Port("serial", 0), new Port("setero", 0));

            KTANE_Solver.Button module = new KTANE_Solver.Button(bomb, io);

            Assert.AreEqual("Press", module.Solve(Color.Red, "Hold"));

            io.Close();
        }

        [TestMethod]
        public void Other()
        {
            Bomb bomb = new Bomb(Day.Sunday, "IIIII", 1, 1,
            new Indicator("BOB", false, false), new Indicator("CAR", false, false), new Indicator("CLR", false, false),
            new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false),
            new Indicator("MSA", false, false), new Indicator("NSA", false, false), new Indicator("SIG", false, false),
            new Indicator("SND", false, false), new Indicator("TRN", false, false), false, 2,
            new Port("DVID", 0), new Port("Parallel", 1), new Port("ps", 0),
            new Port("rj", 0), new Port("serial", 0), new Port("setero", 0));

            KTANE_Solver.Button module = new KTANE_Solver.Button(bomb, io);

            Assert.AreEqual(holdAnswer, module.Solve(Color.Red, "Abort"));

            io.Close();
        }
    }
}
