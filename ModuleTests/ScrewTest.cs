using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using KTANE_Solver;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;

namespace ModuleTests
{
    [TestClass]
    public class ScrewTest
    {
        StreamWriter streamWriter = new StreamWriter("C:\\Users\\Nya\\Downloads\\delete later\\dummy.txt");
        [TestMethod]
        public void TestMethod1()
        {
            Bomb bomb = new Bomb(Day.Sunday, "3I3NL7", 2, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
                    new Indicator("CLR", false, false), new Indicator("FRK", false, false), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", true, true), new Indicator("NSA", true, true),
                    new Indicator("SIG", true, true), new Indicator("SND", false, false), new Indicator("TRN", false, false), false, 1, new Port("DVID", 1), new Port("Parallel", 0),
                    new Port("ps", 0), new Port("rj", 1), new Port("serial", 0), new Port("setero", 1));

            Screw module = new Screw(bomb, streamWriter, new List<Screw.Color>() { Screw.Color.White, Screw.Color.Yellow, Screw.Color.Green, Screw.Color.Red, Screw.Color.Magenta, Screw.Color.Blue });

            module.FindScrewLocations();

            //BCAD
            Assert.AreEqual("Yellow and C", module.SolveDebug(1));

            Assert.AreEqual("Red and C", module.SolveDebug(2));

            Assert.AreEqual("Magenta and D", module.SolveDebug(3));

            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod2()
        {
            Bomb bomb = new Bomb(Day.Sunday, "0K0EM2", 2, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
                    new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
                    new Indicator("SIG", true, true), new Indicator("SND", true, false), new Indicator("TRN", false, false), false, 1, new Port("DVID", 1), new Port("Parallel", 0),
                    new Port("ps", 1), new Port("rj", 0), new Port("serial", 0), new Port("setero", 1));

            Screw module = new Screw(bomb, streamWriter, new List<Screw.Color>() { Screw.Color.Green, Screw.Color.Red, Screw.Color.White, Screw.Color.Magenta, Screw.Color.Blue, Screw.Color.Yellow });

            module.FindScrewLocations();

            Assert.AreEqual("White and D", module.SolveDebug(1));

            Assert.AreEqual("Magenta and 2nd position", module.SolveDebug(2));

            Assert.AreEqual("Blue and C", module.SolveDebug(3));

            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod3()
        {
            Bomb bomb = new Bomb(Day.Sunday, "CW7SG1", 4, 2, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
                    new Indicator("CLR", true, true), new Indicator("FRK", false, false), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", true, true),
                    new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", false, false), false, 1, new Port("DVID", 0), new Port("Parallel", 0),
                    new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

            Screw module = new Screw(bomb, streamWriter, new List<Screw.Color>() { Screw.Color.White, Screw.Color.Red, Screw.Color.Green, Screw.Color.Blue, Screw.Color.Yellow, Screw.Color.Magenta });

            module.FindScrewLocations();

            Assert.AreEqual("Blue and 2nd position", module.SolveDebug(1));

            //ADCB
            Assert.AreEqual("Green and C", module.SolveDebug(2));

            Assert.AreEqual("Blue and 2nd position", module.SolveDebug(3));

            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod4()
        {
            Bomb bomb = new Bomb(Day.Sunday, "CW7SG1", 4, 2, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
                    new Indicator("CLR", true, true), new Indicator("FRK", false, false), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", true, true),
                    new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", false, false), false, 1, new Port("DVID", 0), new Port("Parallel", 0),
                    new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

            Screw module = new Screw(bomb, streamWriter, new List<Screw.Color>() { Screw.Color.Blue, Screw.Color.Yellow, Screw.Color.White, Screw.Color.Magenta, Screw.Color.Green, Screw.Color.Red });

            module.FindScrewLocations();

            Assert.AreEqual("Magenta and 2nd position", module.SolveDebug(1));

            //BDCA
            Assert.AreEqual("White and A", module.SolveDebug(2));

            Assert.AreEqual("Magenta and 2nd position", module.SolveDebug(3));

            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod5()
        {
            Bomb bomb = new Bomb(Day.Sunday, "CW7SG1", 4, 2, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
                    new Indicator("CLR", true, true), new Indicator("FRK", false, false), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", true, true),
                    new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", false, false), false, 1, new Port("DVID", 0), new Port("Parallel", 0),
                    new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

            Screw module = new Screw(bomb, streamWriter, new List<Screw.Color>() { Screw.Color.Blue, Screw.Color.White, Screw.Color.Magenta, Screw.Color.Red, Screw.Color.Yellow, Screw.Color.Green });

            module.FindScrewLocations();

            Assert.AreEqual("Red and 2nd position", module.SolveDebug(1));

            //DBCA
            Assert.AreEqual("Magenta and A", module.SolveDebug(2));

            Assert.AreEqual("Red and 2nd position", module.SolveDebug(3));

            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod6()
        {
            Bomb bomb = new Bomb(Day.Sunday, "CW7SG1", 4, 2, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
                    new Indicator("CLR", true, true), new Indicator("FRK", false, false), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", true, true),
                    new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", false, false), false, 1, new Port("DVID", 0), new Port("Parallel", 0),
                    new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

            Screw module = new Screw(bomb, streamWriter, new List<Screw.Color>() { Screw.Color.Red, Screw.Color.Yellow, Screw.Color.Green, Screw.Color.Blue, Screw.Color.White, Screw.Color.Magenta });

            module.FindScrewLocations();

            Assert.AreEqual("Blue and 2nd position", module.SolveDebug(1));

            //BDAC
            Assert.AreEqual("Green and C", module.SolveDebug(2));

            Assert.AreEqual("Blue and 2nd position", module.SolveDebug(3));

            streamWriter.Close();
        }
    }
}
