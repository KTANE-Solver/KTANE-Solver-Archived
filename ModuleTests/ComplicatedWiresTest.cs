using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Drawing;
using KTANE_Solver;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;
namespace ModuleTests
{
    [TestClass]
    public class ComplicatedWiresTest
    {
        StreamWriter io = new StreamWriter("dummy.txt");

        Bomb bomb = new Bomb(Day.Sunday, "JF9TX4", 6, 4,
        new Indicator("BOB", false, false), new Indicator("CAR", false, false), new Indicator("CLR", true, false),
        new Indicator("FRK", false, false), new Indicator("FRQ", false, false), new Indicator("IND", false, false),
        new Indicator("MSA", false, false), new Indicator("NSA", false, false), new Indicator("SIG", false, false),
        new Indicator("SND", true, false), new Indicator("TRN", true, false), false, 2,
        new Port("DVID", 0), new Port("Parallel", 0), new Port("ps", 0),
        new Port("rj", 0), new Port("serial", 1), new Port("stero", 0));

        List<ComplicatedWire> wireList; 

        [TestMethod]
        public void TestMethod1()
        {
            wireList = new List<ComplicatedWire>()
            {
                new ComplicatedWire(Color.Purple, false, true),
                new ComplicatedWire(Color.Red, true, true),
                new ComplicatedWire(Color.Blue, false, false),
                new ComplicatedWire(Color.White, true, false),
                new ComplicatedWire(Color.Red, false, true),
                new ComplicatedWire(Color.White, false, false)
            };

            ComplicatedWires module = new ComplicatedWires(wireList, bomb, io);

            /*Cut, Cut, Cut, Cut, Cut, Cut*/
            Assert.AreEqual("1. Cut\n2. Cut\n3. Cut\n4.Cut\n5.Cut\n6.Cut", module.Solve());
        }

        [TestMethod]
        public void TestMethod2()
        {
            wireList = new List<ComplicatedWire>()
            {
                new ComplicatedWire(Color.Red, true, true),
                new ComplicatedWire(Color.Blue, true, false),
                new ComplicatedWire(Color.Purple, false, true),
                new ComplicatedWire(Color.White, true, false),
                new ComplicatedWire(Color.Red, false, false),
                new ComplicatedWire(Color.Blue, true, false)
            };

            ComplicatedWires module = new ComplicatedWires(wireList, bomb, io);

            /*Cut, Dont, Cut, Cut, Cut, Dont*/
            Assert.AreEqual("1. Cut\n2. Don't Cut\n3. Cut\n4.Cut\n5.Cut\n6.Don't Cut", module.Solve());

        }

        [TestMethod]
        public void TestMethod3()
        {
            wireList = new List<ComplicatedWire>()
            {
                new ComplicatedWire(Color.White, false, false),
                new ComplicatedWire(Color.White, false, true),
                new ComplicatedWire(Color.Blue, true, true),
                new ComplicatedWire(Color.Blue, false, false),
                new ComplicatedWire(Color.Blue, false, true),
            };

            ComplicatedWires module = new ComplicatedWires(wireList, bomb, io);

            /*Cut, D, D, Cut, D */
            Assert.AreEqual("1. Cut\n2. Don't Cut\n3. Don't Cut\n4.Cut\n5. Don't Cut", module.Solve());

        }

        [TestMethod]
        public void TestMethod4()
        {
            wireList = new List<ComplicatedWire>()
            {
                new ComplicatedWire(Color.Red, true, false),
                new ComplicatedWire(Color.Blue, false, true),
                new ComplicatedWire(Color.Blue, false, true),
                new ComplicatedWire(Color.Blue, false, false),
                new ComplicatedWire(Color.White, true, true),
                new ComplicatedWire(Color.Red, true, true)
            };

            ComplicatedWires module = new ComplicatedWires(wireList, bomb, io);

            /*Cut, D, D, Cut, Cut, Cut*/
            Assert.AreEqual("1. Cut\n2. Don't Cut\n3. Don't Cut\n4.Cut\n5.Cut\n6.Cut", module.Solve());

        }

        [TestMethod]
        public void TestMethod5()
        {
            wireList = new List<ComplicatedWire>()
            {
                new ComplicatedWire(Color.Red, false, true),
                new ComplicatedWire(Color.Red, true, true),
                new ComplicatedWire(Color.White, false, false),
                new ComplicatedWire(Color.Blue, false, false),
                new ComplicatedWire(Color.White, true, false),
                new ComplicatedWire(Color.Red, false, true)
            };

            ComplicatedWires module = new ComplicatedWires(wireList, bomb, io);

            /*Cut, Cut, Cut, Cut, Cut, Cut*/
            Assert.AreEqual("1. Cut\n2. Cut\n3. Cut\n4.Cut\n5.Cut\n6.Cut", module.Solve());

        }

        [TestMethod]
        public void TestMethod6()
        {
            wireList = new List<ComplicatedWire>()
            {
                new ComplicatedWire(Color.White, false, false),
                new ComplicatedWire(Color.White, false, true),
                new ComplicatedWire(Color.Red, false, false),
                new ComplicatedWire(Color.White, false, true),
                new ComplicatedWire(Color.Blue, false, true),
                new ComplicatedWire(Color.Red, false, true)
            };

            ComplicatedWires module = new ComplicatedWires(wireList, bomb, io);

            /*Cut, D, Cut, D, D, Cut*/
            Assert.AreEqual("1. Cut\n2. Don't Cut\n3. Cut\n4. Don't Cut\n5. Don't Cut\n6.Cut", module.Solve());

        }

        [TestMethod]
        public void TestMethod7()
        {
            wireList = new List<ComplicatedWire>()
            {
                new ComplicatedWire(Color.Red, false, false),
                new ComplicatedWire(Color.Blue, false, true),
                new ComplicatedWire(Color.Blue, false, false),
                new ComplicatedWire(Color.Blue, false, false),
                new ComplicatedWire(Color.White, true, false),
                new ComplicatedWire(Color.Red, false, false)
            };

            ComplicatedWires module = new ComplicatedWires(wireList, bomb, io);

            /*Cut, Cut, Cut, Cut, Cut, Cut*/
            Assert.AreEqual("1. Cut\n2. Cut\n3. Cut\n4.Cut\n5.Cut\n6.Cut", module.Solve());

        }

        [TestMethod]
        public void TestMethod8()
        {
            wireList = new List<ComplicatedWire>()
            {
                new ComplicatedWire(Color.Blue, false, true),
                new ComplicatedWire(Color.Red, false, true),
                new ComplicatedWire(Color.Blue, false, true),
                new ComplicatedWire(Color.Purple, false, false),
                new ComplicatedWire(Color.Red, true, false),
                new ComplicatedWire(Color.Red, false, false)
            };

            ComplicatedWires module = new ComplicatedWires(wireList, bomb, io);

            /*Cut, D, D, Cut, Cut, Cut*/
            Assert.AreEqual("1. Cut\n2. Don't Cut\n3. Don't Cut\n4.Cut\n5.Cut\n6.Cut", module.Solve());

        }

        [TestMethod]
        public void TestMethod9()
        {
            wireList = new List<ComplicatedWire>()
            {
                new ComplicatedWire(Color.Blue, false, true),
                new ComplicatedWire(Color.Blue, true, false),
                new ComplicatedWire(Color.White, true, true),
                new ComplicatedWire(Color.White, false, false),
                new ComplicatedWire(Color.White, true, false),
                new ComplicatedWire(Color.Red, true, false)
            };

            ComplicatedWires module = new ComplicatedWires(wireList, bomb, io);

            /*D, D, Cut, Cut, Cut, Cut*/
            Assert.AreEqual("1. Don't Cut\n2. Don't Cut\n3. Cut\n4.Cut\n5.Cut\n6.Cut", module.Solve());

        }

        [TestMethod]
        public void TestMethod10()
        {
            wireList = new List<ComplicatedWire>()
            {
                new ComplicatedWire(Color.White, true, true),
                new ComplicatedWire(Color.Red, false, true),
                new ComplicatedWire(Color.Red, true, true),
                new ComplicatedWire(Color.Purple, true, false),
                new ComplicatedWire(Color.Red, true, false),
                new ComplicatedWire(Color.White, false, false)
            };

            ComplicatedWires module = new ComplicatedWires(wireList, bomb, io);

            /*Cut, Cut, Cut, D, Cut, Cut*/
            Assert.AreEqual("1. Cut\n2. Cut\n3. Cut\n4. Don't Cut\n5.Cut\n6.Cut", module.Solve());

        }

        [TestMethod]
        public void TestMethod11()
        {
            wireList = new List<ComplicatedWire>()
            {
                new ComplicatedWire(Color.White, false, false),
                new ComplicatedWire(Color.Red, true, true),
                new ComplicatedWire(Color.Red, true, false),
                new ComplicatedWire(Color.Red, false, true),
                new ComplicatedWire(Color.White, false, false),
                new ComplicatedWire(Color.White, false, true)
            };

            ComplicatedWires module = new ComplicatedWires(wireList, bomb, io);

            /*Cut, Cut, Cut, Cut, Cut, D*/
            Assert.AreEqual("1. Cut\n2. Cut\n3. Cut\n4.Cut\n5.Cut\n6.Cut", module.Solve());

        }

        [TestMethod]
        public void TestMethod12()
        {
            wireList = new List<ComplicatedWire>()
            {
                new ComplicatedWire(Color.Purple, true, false),
                new ComplicatedWire(Color.White, false, false),
                new ComplicatedWire(Color.Red, false, false),
                new ComplicatedWire(Color.Red, false, true),
                new ComplicatedWire(Color.White, false, true),
                new ComplicatedWire(Color.Red, true, true)
            };

            ComplicatedWires module = new ComplicatedWires(wireList, bomb, io);

            /*D, Cut, Cut, Cut, D, Cut*/
            Assert.AreEqual("1. Don't Cut\n2. Cut\n3. Cut\n4.Cut\n5. Don't Cut\n6.Cut", module.Solve());

        }


        [TestMethod]
        public void TestMethod13()
        {
            wireList = new List<ComplicatedWire>()
            {
                new ComplicatedWire(Color.White, true, false),
                new ComplicatedWire(Color.Purple, false, false),
                new ComplicatedWire(Color.Red, true, false),
                new ComplicatedWire(Color.Blue, true, true),
                new ComplicatedWire(Color.Blue, true, false),
                new ComplicatedWire(Color.Red, true, true)
            };

            ComplicatedWires module = new ComplicatedWires(wireList, bomb, io);

            /*Cut, D, Cut, D, D, Cut*/
            Assert.AreEqual("1. Cut\n2. Don't Cut\n3. Cut\n4. Don't Cut\n5. Don't Cut\n6.Cut", module.Solve());

        }

        [TestMethod]
        public void TestMethod14()
        {
            wireList = new List<ComplicatedWire>()
            {
                new ComplicatedWire(Color.White, true, false),
                new ComplicatedWire(Color.Blue, false, true),
                new ComplicatedWire(Color.Red, false, false),
                new ComplicatedWire(Color.Blue, false, true),
                new ComplicatedWire(Color.White, false, false),
                new ComplicatedWire(Color.Purple, false, true)
            };

            ComplicatedWires module = new ComplicatedWires(wireList, bomb, io);

            /*Cut, D, Cut, D, Cut, Cut*/
            Assert.AreEqual("1. Cut\n2. Cut\n3. Cut\n4.Cut\n5.Cut\n6.Cut", module.Solve());

        }

        [TestMethod]
        public void TestMethod15()
        {
            wireList = new List<ComplicatedWire>()
            {
                new ComplicatedWire(Color.Blue, false, true),
                new ComplicatedWire(Color.Red, true, false),
                new ComplicatedWire(Color.White, true, true),
                new ComplicatedWire(Color.Blue, false, false),
                new ComplicatedWire(Color.Red, true, false)
            };

            ComplicatedWires module = new ComplicatedWires(wireList, bomb, io);

            /*D, Cut, Cut, Cut, Cut*/
            Assert.AreEqual("1. Don't Cut\n2. Cut\n3. Cut\n4.Cut\n5.Cut", module.Solve());

        }

        [TestMethod]
        public void TestMethod16()
        {
            wireList = new List<ComplicatedWire>()
            {
                new ComplicatedWire(Color.Red, true, false),
                new ComplicatedWire(Color.Red, false, false),
                new ComplicatedWire(Color.Blue, true, true),
                new ComplicatedWire(Color.Blue, true, true)
            };

            ComplicatedWires module = new ComplicatedWires(wireList, bomb, io);

            /*Cut, Cut, D, D*/
            Assert.AreEqual("1. Cut\n2. Cut\n3. Don't Cut\n4. Don't Cut", module.Solve());

        }
    }
}
