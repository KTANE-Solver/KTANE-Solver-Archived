using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using KTANE_Solver;
using System.Windows.Forms;

namespace ModuleTests
{
    [TestClass]
    public class LetterKeysTest
    {
        StreamWriter streamWriter = new StreamWriter("dummy.txt");

        [TestMethod]
        public void TestMethod1()
        {
            LetterKeys module = new LetterKeys(null, streamWriter, 69);
            Assert.AreEqual(module.SolveDebug(), "D");
            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod2()
        {
            LetterKeys module = new LetterKeys(null, streamWriter, 6);
            Assert.AreEqual(module.SolveDebug(), "A");
            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod3()
        {
            Bomb bomb = new Bomb(Day.Sunday, "IIIII", 2, 2, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
                   new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
                   new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
                   new Port("ps", 0), new Port("rj", 0), new Port("serial", 0), new Port("setero", 0));

            LetterKeys module = new LetterKeys(bomb, streamWriter, 3);
            Assert.AreEqual(module.SolveDebug(), "B");
            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod4()
        {
            Bomb bomb = new Bomb(Day.Sunday, "C", 1, 2, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
                   new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
                   new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
                   new Port("ps", 0), new Port("rj", 0), new Port("serial", 0), new Port("setero", 0));

            LetterKeys module = new LetterKeys(bomb, streamWriter, 22);
            Assert.AreEqual(module.SolveDebug(), "B");
            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod5()
        {
            Bomb bomb = new Bomb(Day.Sunday, "C", 1, 2, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
                   new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
                   new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
                   new Port("ps", 0), new Port("rj", 0), new Port("serial", 0), new Port("setero", 0));

            LetterKeys module = new LetterKeys(bomb, streamWriter, 1);
            Assert.AreEqual(module.SolveDebug(), "C");
            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod6()
        {
            Bomb bomb = new Bomb(Day.Sunday, "A", 1, 2, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
                   new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
                   new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
                   new Port("ps", 0), new Port("rj", 0), new Port("serial", 0), new Port("setero", 0));

            LetterKeys module = new LetterKeys(bomb, streamWriter, 44);
            Assert.AreEqual(module.SolveDebug(), "D");
            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod7()
        {
            Bomb bomb = new Bomb(Day.Sunday, "A", 1, 2, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
                   new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
                   new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
                   new Port("ps", 0), new Port("rj", 0), new Port("serial", 0), new Port("setero", 0));

            LetterKeys module = new LetterKeys(bomb, streamWriter, 46);
            Assert.AreEqual(module.SolveDebug(), "A");
            streamWriter.Close();
        }
    }
}
