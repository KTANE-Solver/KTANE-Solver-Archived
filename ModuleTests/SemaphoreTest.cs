using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using KTANE_Solver;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
namespace ModuleTests
{
    [TestClass]
    public class SemaphoreTest
    {
        StreamWriter streamWriter = new StreamWriter("C:\\Users\\Nya\\Downloads\\delete later\\dummy.txt");

        [TestMethod]
        public void TestMethod1()
        {
            Bomb bomb = new Bomb(Day.Sunday, "3W8DU1", 0, 0, new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), false, 0, null, null, null, null, null, null);

            Semaphore module = new Semaphore(bomb,streamWriter, new Semaphore.Flag(Semaphore.FlagState.North, Semaphore.FlagState.NorthEast));

            Assert.AreEqual("Valid", module.DebugSolve(new Semaphore.Flag(Semaphore.FlagState.West, Semaphore.FlagState.SouthWest)));
            Assert.AreEqual("Valid", module.DebugSolve(new Semaphore.Flag(Semaphore.FlagState.North, Semaphore.FlagState.East)));
            Assert.AreEqual("Invalid", module.DebugSolve(new Semaphore.Flag(Semaphore.FlagState.South, Semaphore.FlagState.NorthEast)));


            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod2()
        {
            Bomb bomb = new Bomb(Day.Sunday, "3W8DU1", 0, 0, new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), false, 0, null, null, null, null, null, null);

            Semaphore module = new Semaphore(bomb, streamWriter, new Semaphore.Flag(Semaphore.FlagState.North, Semaphore.FlagState.East));
            Assert.AreEqual("Valid", module.DebugSolve(new Semaphore.Flag(Semaphore.FlagState.North, Semaphore.FlagState.South)));
            Assert.AreEqual("Invalid", module.DebugSolve(new Semaphore.Flag(Semaphore.FlagState.SouthEast, Semaphore.FlagState.East)));


            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod3()
        {
            Bomb bomb = new Bomb(Day.Sunday, "3W8DU1", 0, 0, new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), false, 0, null, null, null, null, null, null);

            Semaphore module = new Semaphore(bomb, streamWriter, new Semaphore.Flag(Semaphore.FlagState.North, Semaphore.FlagState.NorthEast));
            Assert.AreEqual("Valid", module.DebugSolve(new Semaphore.Flag(Semaphore.FlagState.West, Semaphore.FlagState.SouthWest)));
            Assert.AreEqual("Valid", module.DebugSolve(new Semaphore.Flag(Semaphore.FlagState.North, Semaphore.FlagState.East)));
            Assert.AreEqual("Valid", module.DebugSolve(new Semaphore.Flag(Semaphore.FlagState.North, Semaphore.FlagState.South)));
            Assert.AreEqual("Invalid", module.DebugSolve(new Semaphore.Flag(Semaphore.FlagState.West, Semaphore.FlagState.North)));

            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod4()
        {
            Bomb bomb = new Bomb(Day.Sunday, "3W8DU1", 0, 0, new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), false, 0, null, null, null, null, null, null);

            Semaphore module = new Semaphore(bomb, streamWriter, new Semaphore.Flag(Semaphore.FlagState.North, Semaphore.FlagState.East));
            Assert.AreEqual("Valid", module.DebugSolve(new Semaphore.Flag(Semaphore.FlagState.North, Semaphore.FlagState.South)));
            Assert.AreEqual("Valid", module.DebugSolve(new Semaphore.Flag(Semaphore.FlagState.North, Semaphore.FlagState.NorthEast)));
            Assert.AreEqual("Valid", module.DebugSolve(new Semaphore.Flag(Semaphore.FlagState.NorthWest, Semaphore.FlagState.South)));
            Assert.AreEqual("Valid", module.DebugSolve(new Semaphore.Flag(Semaphore.FlagState.SouthWest, Semaphore.FlagState.South)));
            Assert.AreEqual("Valid", module.DebugSolve(new Semaphore.Flag(Semaphore.FlagState.West, Semaphore.FlagState.SouthWest)));
            Assert.AreEqual("Valid", module.DebugSolve(new Semaphore.Flag(Semaphore.FlagState.North, Semaphore.FlagState.East)));
            Assert.AreEqual("Invalid", module.DebugSolve(new Semaphore.Flag(Semaphore.FlagState.NorthWest, Semaphore.FlagState.North)));

            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod5()
        {
            Bomb bomb = new Bomb(Day.Sunday, "3W8DU1", 0, 0, new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), false, 0, null, null, null, null, null, null);

            Semaphore module = new Semaphore(bomb, streamWriter, new Semaphore.Flag(Semaphore.FlagState.North, Semaphore.FlagState.East));

            Assert.AreEqual("Invalid", module.DebugSolve(new Semaphore.Flag(Semaphore.FlagState.West, Semaphore.FlagState.NorthEast)));

            streamWriter.Close();
        }
    }
}
