using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using KTANE_Solver;
using System.IO;
using System.Windows.Forms;
namespace ModuleTests
{
    [TestClass]
    public class BlindAlley
    {
        StreamWriter streamWriter = new StreamWriter("C:\\delete later\\dummy.txt");
        [TestMethod]
        public void Test1()
        {
            Bomb bomb = new Bomb(Day.Sunday, "GS5BP5", 2, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false), new Indicator("CLR", false, false), new Indicator("FRK", false, false), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false), new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 3, new Port("", 1), new Port("", 0), new Port("", 2), new Port("", 3), new Port("", 0), new Port("", 3));
            KTANE_Solver.BlindAlley module = new KTANE_Solver.BlindAlley(bomb, streamWriter);

            string answer = module.Solve();

            streamWriter.Close();

            Assert.AreEqual("Top Middle\nMiddle Left\nMiddle\nMiddle Right\nBottom Left\nBottom Right", answer);
        }

        [TestMethod]
        public void Test2()
        {
            Bomb bomb = new Bomb(Day.Sunday, "KS2DM8", 2, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false), new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", true, true), new Indicator("IND", true, true), new Indicator("MSA", false, false), new Indicator("NSA", false, false), new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", false, false), true, 1, new Port("", 0), new Port("", 0), new Port("", 1), new Port("", 1), new Port("", 0), new Port("", 0));
            KTANE_Solver.BlindAlley module = new KTANE_Solver.BlindAlley(bomb, streamWriter);

            string answer = module.Solve();

            streamWriter.Close();

            Assert.AreEqual("Top Middle\nBottom Left", answer);
        }

        [TestMethod]
        public void Test3()
        {
            Bomb bomb = new Bomb(Day.Sunday, "FH9RN8", 2, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false), new Indicator("CLR", false, false), new Indicator("FRK", false, false), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", true, true), new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", false, false), true, 3, new Port("", 1), new Port("", 0), new Port("", 1), new Port("", 1), new Port("", 0), new Port("", 1));
            KTANE_Solver.BlindAlley module = new KTANE_Solver.BlindAlley(bomb, streamWriter);

            string answer = module.Solve();


            streamWriter.Close();

            Assert.AreEqual("Middle", answer);
        }

        [TestMethod]
        public void Test4()
        {
            Bomb bomb = new Bomb(Day.Sunday, "CE6KK5", 2, 1, new Indicator("BOB", true, true), new Indicator("CAR", false, false), new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", true, true), new Indicator("NSA", false, false), new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", false, false), false, 3, new Port("", 0), new Port("", 1), new Port("", 0), new Port("", 0), new Port("", 0), new Port("", 0));
            KTANE_Solver.BlindAlley module = new KTANE_Solver.BlindAlley(bomb, streamWriter);

            string answer = module.Solve();


            streamWriter.Close();

            Assert.AreEqual("Bottom Middle", answer);
        }

        [TestMethod]
        public void Test5()
        {
            Bomb bomb = new Bomb(Day.Sunday, "Q49KZ6", 3, 2, new Indicator("BOB", false, false), 
            new Indicator("CAR", false, false), new Indicator("CLR", false, false), 
            new Indicator("FRK", false, false), new Indicator("FRQ", false, false), 
            new Indicator("IND", false, false), new Indicator("MSA", false, false), 
            new Indicator("NSA", false, false), new Indicator("SIG", true, true), 
            new Indicator("SND", false, false), new Indicator("TRN", false, false), false, 2, 
            new Port("", 1), new Port("", 1), new Port("", 0), new Port("", 3), new Port("", 1), 
            new Port("", 3));
            KTANE_Solver.BlindAlley module = new KTANE_Solver.BlindAlley(bomb, streamWriter);
            string answer = module.Solve();


            streamWriter.Close();

            Assert.AreEqual("Bottom Left", answer);
        }

        [TestMethod]
        public void Test6()
        {
            Bomb bomb = new Bomb(Day.Sunday, "IA2AQ1", 1, 1, new Indicator("BOB", false, false),
            new Indicator("CAR", true, true), new Indicator("CLR", true, false),
            new Indicator("FRK", false, false), new Indicator("FRQ", false, false),
            new Indicator("IND", false, false), new Indicator("MSA", false, false),
            new Indicator("NSA", false, false), new Indicator("SIG", false, false),
            new Indicator("SND", false, false), new Indicator("TRN", false, false), true, 2,
            new Port("", 1), new Port("", 0), new Port("", 1), new Port("", 1), new Port("", 0),
            new Port("", 1));
            KTANE_Solver.BlindAlley module = new KTANE_Solver.BlindAlley(bomb, streamWriter);

            string answer = module.Solve();


            streamWriter.Close();

            Assert.AreEqual("Bottom Right", answer);
        }

        [TestMethod]
        public void Test7()
        {
            Bomb bomb = new Bomb(Day.Sunday, "2A9WB7", 1, 1, new Indicator("BOB", true, true),
            new Indicator("CAR", false, true), new Indicator("CLR", false, false),
            new Indicator("FRK", false, false), new Indicator("FRQ", false, false),
            new Indicator("IND", true, false), new Indicator("MSA", false, false),
            new Indicator("NSA", false, false), new Indicator("SIG", false, false),
            new Indicator("SND", false, false), new Indicator("TRN", false, false), false, 2,
            new Port("dvid", 1), new Port("parallel", 0), new Port("ps", 0), new Port("rj", 2), new Port("serial", 0),
            new Port("stereo", 2));
            KTANE_Solver.BlindAlley module = new KTANE_Solver.BlindAlley(bomb, streamWriter);
            string answer = module.Solve();

            streamWriter.Close();

            Assert.AreEqual("Middle Left", answer);
        }

        [TestMethod]
        public void Test8()
        {
            Bomb bomb = new Bomb(Day.Sunday, "0L2UV0", 5, 3, new Indicator("BOB", false, false),
            new Indicator("CAR", false, false), new Indicator("CLR", false, false),
            new Indicator("FRK", false, false), new Indicator("FRQ", false, false),
            new Indicator("IND", false, false), new Indicator("MSA", false, false),
            new Indicator("NSA", false, false), new Indicator("SIG", false, false),
            new Indicator("SND", false, false), new Indicator("TRN", false, false), true, 2,
            new Port("dvid", 0), new Port("parallel", 0), new Port("ps", 0), new Port("rj", 1), new Port("serial", 0),
            new Port("stereo", 1));
            KTANE_Solver.BlindAlley module = new KTANE_Solver.BlindAlley(bomb, streamWriter);

            string answer = module.Solve();

            streamWriter.Close();

            Assert.AreEqual("Top Middle\nBottom Left\nBottom Middle\nBottom Right", answer);
        }

        [TestMethod]
        public void Test9()
        {
            Bomb bomb = new Bomb(Day.Sunday, "9P5UF5", 3, 2, new Indicator("BOB", false, false),
            new Indicator("CAR", false, false), new Indicator("CLR", false, false),
            new Indicator("FRK", true, true), new Indicator("FRQ", false, false),
            new Indicator("IND", false, false), new Indicator("MSA", false, false),
            new Indicator("NSA", false, false), new Indicator("SIG", false, false),
            new Indicator("SND", false, false), new Indicator("TRN", true, true), true, 2,
            new Port("dvid", 1), new Port("parallel", 0), new Port("ps", 0), new Port("rj", 1), new Port("serial", 0),
            new Port("stereo", 1));
            KTANE_Solver.BlindAlley module = new KTANE_Solver.BlindAlley(bomb, streamWriter);
            string answer = module.Solve();

            streamWriter.Close();

            Assert.AreEqual("Top Middle", answer);
        }

        [TestMethod]
        public void Test10()
        {
            Bomb bomb = new Bomb(Day.Sunday, "JC0EG8", 1, 1, new Indicator("BOB", false, false),
            new Indicator("CAR", false, false), new Indicator("CLR", false, false),
            new Indicator("FRK", false, false), new Indicator("FRQ", false, false),
            new Indicator("IND", false, false), new Indicator("MSA", true, true),
            new Indicator("NSA", true, false), new Indicator("SIG", false, false),
            new Indicator("SND", false, false), new Indicator("TRN", true, true), true, 1,
            new Port("dvid", 0), new Port("parallel", 0), new Port("ps", 0), new Port("rj", 0), new Port("serial", 0),
            new Port("stereo", 0));
            KTANE_Solver.BlindAlley module = new KTANE_Solver.BlindAlley(bomb, streamWriter);
            string answer = module.Solve();

            streamWriter.Close();

            Assert.AreEqual("Bottom Left\nBottom Middle", answer);
        }

        [TestMethod]
        public void Test11()
        {
            Bomb bomb = new Bomb(Day.Sunday, "G55XE6", 1, 1, new Indicator("BOB", false, false),
            new Indicator("CAR", false, false), new Indicator("CLR", true, true),
            new Indicator("FRK", false, false), new Indicator("FRQ", false, false),
            new Indicator("IND", false, false), new Indicator("MSA", false, false),
            new Indicator("NSA", false, false), new Indicator("SIG", false, false),
            new Indicator("SND", false, false), new Indicator("TRN", true, true), true, 2,
            new Port("dvid", 0), new Port("parallel", 2), new Port("ps", 0), new Port("rj", 1), new Port("serial", 2),
            new Port("stereo", 1));
            KTANE_Solver.BlindAlley module = new KTANE_Solver.BlindAlley(bomb, streamWriter);
            string answer = module.Solve();

            streamWriter.Close();

            Assert.AreEqual("Middle Right\nBottom Left\nBottom Middle", answer);
        }

        [TestMethod]
        public void Test12()
        {
            Bomb bomb = new Bomb(Day.Sunday, "1V8BH0", 5, 4, new Indicator("BOB", true, false),
            new Indicator("CAR", false, false), new Indicator("CLR", false, false),
            new Indicator("FRK", false, false), new Indicator("FRQ", false, false),
            new Indicator("IND", false, false), new Indicator("MSA", false, false),
            new Indicator("NSA", false, false), new Indicator("SIG", false, false),
            new Indicator("SND", false, false), new Indicator("TRN", false, false), false, 0,
            new Port("dvid", 0), new Port("parallel", 0), new Port("ps", 0), new Port("rj", 0), new Port("serial", 0),
            new Port("stereo", 0));
            KTANE_Solver.BlindAlley module = new KTANE_Solver.BlindAlley(bomb, streamWriter);
            string answer = module.Solve();

            streamWriter.Close();

            Assert.AreEqual("Top Left", answer);
        }

        [TestMethod]
        public void Test13()
        {
            Bomb bomb = new Bomb(Day.Sunday, "WG0JE7", 0, 0, new Indicator("BOB", false, false),
            new Indicator("CAR", true, false), new Indicator("CLR", false, false),
            new Indicator("FRK", false, false), new Indicator("FRQ", true, false),
            new Indicator("IND", false, false), new Indicator("MSA", false, false),
            new Indicator("NSA", false, false), new Indicator("SIG", false, false),
            new Indicator("SND", true, false), new Indicator("TRN", false, false), false, 2,
            new Port("dvid", 1), new Port("parallel", 1), new Port("ps", 0), new Port("rj", 1), new Port("serial", 0),
            new Port("stereo", 0));
            KTANE_Solver.BlindAlley module = new KTANE_Solver.BlindAlley(bomb, streamWriter);
            string answer = module.Solve();

            streamWriter.Close();

            Assert.AreEqual("Top Middle\nMiddle Left\nMiddle\nBottom Middle", answer);
        }

        [TestMethod]
        public void Test14()
        {
            Bomb bomb = new Bomb(Day.Sunday, "HU9XG6", 4, 2, new Indicator("BOB", false, false),
            new Indicator("CAR", false, false), new Indicator("CLR", false, false),
            new Indicator("FRK", true, false), new Indicator("FRQ", false, false),
            new Indicator("IND", false, false), new Indicator("MSA", false, false),
            new Indicator("NSA", false, false), new Indicator("SIG", false, false),
            new Indicator("SND", false, false), new Indicator("TRN", true, false), false, 2,
            new Port("dvid", 0), new Port("parallel", 0), new Port("ps", 0), new Port("rj", 0), new Port("serial", 0),
            new Port("stereo", 0));
            KTANE_Solver.BlindAlley module = new KTANE_Solver.BlindAlley(bomb, streamWriter);
            string answer = module.Solve();

            streamWriter.Close();

            Assert.AreEqual("Bottom Middle", answer);
        }

        [TestMethod]
        public void Test15()
        {
            Bomb bomb = new Bomb(Day.Sunday, "E24FT3", 0, 0, new Indicator("BOB", false, false),
            new Indicator("CAR", false, false), new Indicator("CLR", false, false),
            new Indicator("FRK", false, false), new Indicator("FRQ", false, false),
            new Indicator("IND", false, false), new Indicator("MSA", false, false),
            new Indicator("NSA", true, true), new Indicator("SIG", false, false),
            new Indicator("SND", false, false), new Indicator("TRN", true, false), false, 3,
            new Port("dvid", 2), new Port("parallel", 0), new Port("ps", 1), new Port("rj", 1), new Port("serial", 0),
            new Port("stereo", 3));
            KTANE_Solver.BlindAlley module = new KTANE_Solver.BlindAlley(bomb, streamWriter);
            string answer = module.Solve();

            streamWriter.Close();

            Assert.AreEqual("Middle Left\nMiddle", answer);
        }

        [TestMethod]
        public void Test16()
        {
            Bomb bomb = new Bomb(Day.Sunday, "RI0JU7", 2, 2, new Indicator("BOB", false, false),
            new Indicator("CAR", false, false), new Indicator("CLR", false, false),
            new Indicator("FRK", false, false), new Indicator("FRQ", false, false),
            new Indicator("IND", false, false), new Indicator("MSA", false, false),
            new Indicator("NSA", false, false), new Indicator("SIG", false, false),
            new Indicator("SND", false, false), new Indicator("TRN", false, false), false, 3,
            new Port("dvid", 1), new Port("parallel", 1), new Port("ps", 0), new Port("rj", 0), new Port("serial", 1),
            new Port("stereo", 0));
            KTANE_Solver.BlindAlley module = new KTANE_Solver.BlindAlley(bomb, streamWriter);
            string answer = module.Solve();

            streamWriter.Close();

            Assert.AreEqual("Bottom Middle", answer);
        }

        [TestMethod]
        public void Test17()
        {
            Bomb bomb = new Bomb(Day.Sunday, "WQ4SL0", 1, 1, new Indicator("BOB", false, false),
            new Indicator("CAR", false, false), new Indicator("CLR", false, false),
            new Indicator("FRK", true, true), new Indicator("FRQ", false, false),
            new Indicator("IND", false, false), new Indicator("MSA", false, false),
            new Indicator("NSA", false, false), new Indicator("SIG", true, true),
            new Indicator("SND", false, false), new Indicator("TRN", false, false), false, 3,
            new Port("dvid", 0), new Port("parallel", 1), new Port("ps", 1), new Port("rj", 0), new Port("serial", 1),
            new Port("stereo", 1));
            KTANE_Solver.BlindAlley module = new KTANE_Solver.BlindAlley(bomb, streamWriter);
            string answer = module.Solve();

            streamWriter.Close();

            Assert.AreEqual("Middle Right\nBottom Left", answer);
        }

        [TestMethod]
        public void Test18()
        {
            Bomb bomb = new Bomb(Day.Sunday, "WR7BW6", 0, 0, new Indicator("BOB", false, false),
            new Indicator("CAR", true, true), new Indicator("CLR", false, false),
            new Indicator("FRK", false, false), new Indicator("FRQ", false, false),
            new Indicator("IND", false, false), new Indicator("MSA", false, false),
            new Indicator("NSA", false, false), new Indicator("SIG", true, true),
            new Indicator("SND", false, false), new Indicator("TRN", true, true), true, 2,
            new Port("dvid", 1), new Port("parallel", 0), new Port("ps", 0), new Port("rj", 1), new Port("serial", 0),
            new Port("stereo", 1));
            KTANE_Solver.BlindAlley module = new KTANE_Solver.BlindAlley(bomb, streamWriter);
            string answer = module.Solve();

            streamWriter.Close();

            Assert.AreEqual("Bottom Left", answer);
        }

        [TestMethod]
        public void Test19()
        {
            Bomb bomb = new Bomb(Day.Sunday, "IK2BJ9", 3, 2, new Indicator("BOB", false, false),
            new Indicator("CAR", false, false), new Indicator("CLR", false, false),
            new Indicator("FRK", true, true), new Indicator("FRQ", true, true),
            new Indicator("IND", false, false), new Indicator("MSA", true, true),
            new Indicator("NSA", false, false), new Indicator("SIG", false, false),
            new Indicator("SND", false, false), new Indicator("TRN", false, false), false, 0,
            new Port("dvid", 0), new Port("parallel", 0), new Port("ps", 0), new Port("rj", 0), new Port("serial", 0),
            new Port("stereo", 0));
            KTANE_Solver.BlindAlley module = new KTANE_Solver.BlindAlley(bomb, streamWriter);
            string answer = module.Solve();

            streamWriter.Close();

            Assert.AreEqual("Bottom Left\nBottom Middle", answer);
        }

        [TestMethod]
        public void Test20()
        {
            Bomb bomb = new Bomb(Day.Sunday, "C60RG4", 2, 1, new Indicator("BOB", false, false),
            new Indicator("CAR", false, false), new Indicator("CLR", false, false),
            new Indicator("FRK", false, false), new Indicator("FRQ", true, false),
            new Indicator("IND", false, false), new Indicator("MSA", true, true),
            new Indicator("NSA", false, false), new Indicator("SIG", false, false),
            new Indicator("SND", true, false), new Indicator("TRN", false, false), true, 1,
            new Port("dvid", 0), new Port("parallel", 0), new Port("ps", 0), new Port("rj", 0), new Port("serial", 0),
            new Port("stereo", 0));
            KTANE_Solver.BlindAlley module = new KTANE_Solver.BlindAlley(bomb, streamWriter);
            string answer = module.Solve();

            streamWriter.Close();

            Assert.AreEqual("Middle", answer);
        }

        [TestMethod]
        public void Test21()
        {
            Bomb bomb = new Bomb(Day.Sunday, "IM5UU7", 0, 0, new Indicator("BOB", true, true),
            new Indicator("CAR", false, false), new Indicator("CLR", true, true),
            new Indicator("FRK", false, false), new Indicator("FRQ", true, false),
            new Indicator("IND", false, false), new Indicator("MSA", true, true),
            new Indicator("NSA", false, false), new Indicator("SIG", false, false),
            new Indicator("SND", true, false), new Indicator("TRN", true, false), false, 2,
            new Port("dvid", 0), new Port("parallel", 0), new Port("ps", 1), new Port("rj", 0), new Port("serial", 1),
            new Port("stereo", 0));
            KTANE_Solver.BlindAlley module = new KTANE_Solver.BlindAlley(bomb, streamWriter);
            string answer = module.Solve();

            streamWriter.Close();

            Assert.AreEqual("Middle Right", answer);
        }

        [TestMethod]
        public void Test22()
        {
            Bomb bomb = new Bomb(Day.Sunday, "035BE0", 2, 1, new Indicator("BOB", false, false),
            new Indicator("CAR", true, false), new Indicator("CLR", false, false),
            new Indicator("FRK", false, false), new Indicator("FRQ", false, false),
            new Indicator("IND", true, true), new Indicator("MSA", false, false),
            new Indicator("NSA", false, false), new Indicator("SIG", false, false),
            new Indicator("SND", true, false), new Indicator("TRN", false, false), false, 1,
            new Port("dvid", 0), new Port("parallel", 0), new Port("ps", 0), new Port("rj", 0), new Port("serial", 1),
            new Port("stereo", 0));
            KTANE_Solver.BlindAlley module = new KTANE_Solver.BlindAlley(bomb, streamWriter);
            string answer = module.Solve();

            streamWriter.Close();

            Assert.AreEqual("Middle", answer);
        }

        [TestMethod]
        public void Test23()
        {
            Bomb bomb = new Bomb(Day.Sunday, "427IG0", 2, 1, new Indicator("BOB", false, false),
            new Indicator("CAR", false, false), new Indicator("CLR", false, false),
            new Indicator("FRK", true, true), new Indicator("FRQ", false, false),
            new Indicator("IND", false, false), new Indicator("MSA", true, true),
            new Indicator("NSA", false, false), new Indicator("SIG", false, false),
            new Indicator("SND", false, false), new Indicator("TRN", false, false), true, 2,
            new Port("dvid", 0), new Port("parallel", 0), new Port("ps", 0), new Port("rj", 0), new Port("serial", 0),
            new Port("stereo", 0));
            KTANE_Solver.BlindAlley module = new KTANE_Solver.BlindAlley(bomb, streamWriter);
            string answer = module.Solve();

            streamWriter.Close();

            Assert.AreEqual("Bottom Middle", answer);
        }

        [TestMethod]
        public void Test24()
        {
            Bomb bomb = new Bomb(Day.Sunday, "2J1SC4", 4, 2, new Indicator("BOB", false, false),
            new Indicator("CAR", false, false), new Indicator("CLR", false, false),
            new Indicator("FRK", false, false), new Indicator("FRQ", false, false),
            new Indicator("IND", false, false), new Indicator("MSA", false, false),
            new Indicator("NSA", false, false), new Indicator("SIG", false, false),
            new Indicator("SND", true, false), new Indicator("TRN", false, false), false, 2,
            new Port("dvid", 0), new Port("parallel", 1), new Port("ps", 0), new Port("rj", 0), new Port("serial", 2),
            new Port("stereo", 0));
            KTANE_Solver.BlindAlley module = new KTANE_Solver.BlindAlley(bomb, streamWriter);
            string answer = module.Solve();

            streamWriter.Close();

            Assert.AreEqual("Middle", answer);
        }

        [TestMethod]
        public void Test25()
        {
            Bomb bomb = new Bomb(Day.Sunday, "JB7ME1", 3, 2, new Indicator("BOB", false, false),
            new Indicator("CAR", false, false), new Indicator("CLR", false, false),
            new Indicator("FRK", false, false), new Indicator("FRQ", false, false),
            new Indicator("IND", false, false), new Indicator("MSA", false, false),
            new Indicator("NSA", false, false), new Indicator("SIG", false, false),
            new Indicator("SND", false, false), new Indicator("TRN", false, false), true, 1,
            new Port("dvid", 1), new Port("parallel", 0), new Port("ps", 2), new Port("rj", 1), new Port("serial", 0),
            new Port("stereo", 2));
            KTANE_Solver.BlindAlley module = new KTANE_Solver.BlindAlley(bomb, streamWriter);
            string answer = module.Solve();

            streamWriter.Close();

            Assert.AreEqual("Top Left\nTop Middle\nMiddle Left\nMiddle Right\nBottom Middle\nBottom Right", answer);
        }

        [TestMethod]
        public void Test26()
        {
            Bomb bomb = new Bomb(Day.Sunday, "G09JS3", 2, 1, new Indicator("BOB", false, false),
            new Indicator("CAR", true, false), new Indicator("CLR", true, false),
            new Indicator("FRK", false, false), new Indicator("FRQ", false, false),
            new Indicator("IND", false, false), new Indicator("MSA", false, false),
            new Indicator("NSA", false, false), new Indicator("SIG", true, false),
            new Indicator("SND", false, false), new Indicator("TRN", true, false), true, 0,
            new Port("dvid", 0), new Port("parallel", 0), new Port("ps", 0), new Port("rj", 0), new Port("serial", 0),
            new Port("stereo", 0));
            KTANE_Solver.BlindAlley module = new KTANE_Solver.BlindAlley(bomb, streamWriter);
            string answer = module.Solve();

            streamWriter.Close();

            Assert.AreEqual("Middle", answer);
        }

        [TestMethod]
        public void Test27()
        {
            Bomb bomb = new Bomb(Day.Sunday, "7N3KI5", 2, 1, new Indicator("BOB", false, false),
            new Indicator("CAR", false, false), new Indicator("CLR", false, false),
            new Indicator("FRK", false, false), new Indicator("FRQ", false, false),
            new Indicator("IND", false, false), new Indicator("MSA", false, false),
            new Indicator("NSA", false, false), new Indicator("SIG", true, false),
            new Indicator("SND", false, false), new Indicator("TRN", false, false), false, 3,
            new Port("dvid", 1), new Port("parallel", 1), new Port("ps", 0), new Port("rj", 2), new Port("serial", 0),
            new Port("stereo", 1));
            KTANE_Solver.BlindAlley module = new KTANE_Solver.BlindAlley(bomb, streamWriter);
            string answer = module.Solve();

            streamWriter.Close();

            Assert.AreEqual("Middle\nBottom Middle", answer);
        }

        [TestMethod]
        public void Test28()
        {
            Bomb bomb = new Bomb(Day.Sunday, "UU9UL3", 3, 2, new Indicator("BOB", false, false),
            new Indicator("CAR", false, false), new Indicator("CLR", true, true),
            new Indicator("FRK", false, false), new Indicator("FRQ", false, false),
            new Indicator("IND", false, false), new Indicator("MSA", false, false),
            new Indicator("NSA", false, false), new Indicator("SIG", false, false),
            new Indicator("SND", false, false), new Indicator("TRN", false, false), false, 2,
            new Port("dvid", 1), new Port("parallel", 0), new Port("ps", 1), new Port("rj", 2), new Port("serial", 0),
            new Port("stereo", 0));
            KTANE_Solver.BlindAlley module = new KTANE_Solver.BlindAlley(bomb, streamWriter);
            string answer = module.Solve();

            streamWriter.Close();

            Assert.AreEqual("Middle Right", answer);
        }

        [TestMethod]
        public void Test29()
        {
            Bomb bomb = new Bomb(Day.Sunday, "VS7AW4", 3, 2, new Indicator("BOB", false, false),
            new Indicator("CAR", false, false), new Indicator("CLR", true, false),
            new Indicator("FRK", false, false), new Indicator("FRQ", false, false),
            new Indicator("IND", false, false), new Indicator("MSA", false, false),
            new Indicator("NSA", false, false), new Indicator("SIG", false, false),
            new Indicator("SND", false, false), new Indicator("TRN", false, false), false, 2,
            new Port("dvid", 0), new Port("parallel", 1), new Port("ps", 0), new Port("rj", 2), new Port("serial", 0),
            new Port("stereo", 0));
            KTANE_Solver.BlindAlley module = new KTANE_Solver.BlindAlley(bomb, streamWriter);
            string answer = module.Solve();

            streamWriter.Close();

            Assert.AreEqual("Bottom Middle", answer);
        }

        [TestMethod]
        public void Test30()
        {
            Bomb bomb = new Bomb(Day.Sunday, "9S6CE0", 3, 2, new Indicator("BOB", false, false),
            new Indicator("CAR", false, false), new Indicator("CLR", true, true),
            new Indicator("FRK", false, false), new Indicator("FRQ", false, false),
            new Indicator("IND", true, true), new Indicator("MSA", false, false),
            new Indicator("NSA", false, false), new Indicator("SIG", true, true),
            new Indicator("SND", false, false), new Indicator("TRN", false, false), false, 0,
            new Port("dvid", 0), new Port("parallel", 0), new Port("ps", 0), new Port("rj", 0), new Port("serial", 0),
            new Port("stereo", 0));
            KTANE_Solver.BlindAlley module = new KTANE_Solver.BlindAlley(bomb, streamWriter);
            string answer = module.Solve();

            streamWriter.Close();

            Assert.AreEqual("Top Left\nBottom Left", answer);
        }


        [TestMethod]
        public void Test31()
        {
            Bomb bomb = new Bomb(Day.Sunday, "5T3NF5", 2, 2, new Indicator("BOB", false, false),
            new Indicator("CAR", false, false), new Indicator("CLR", false, false),
            new Indicator("FRK", false, false), new Indicator("FRQ", true, true),
            new Indicator("IND", true, false), new Indicator("MSA", false, false),
            new Indicator("NSA", false, false), new Indicator("SIG", false, false),
            new Indicator("SND", false, false), new Indicator("TRN", false, false), false, 1,
            new Port("dvid", 1), new Port("parallel", 0), new Port("ps", 1), new Port("rj", 0), new Port("serial", 0),
            new Port("stereo", 1));
            KTANE_Solver.BlindAlley module = new KTANE_Solver.BlindAlley(bomb, streamWriter);
            string answer = module.Solve();

            streamWriter.Close();

            Assert.AreEqual("Middle Left", answer);
        }

        [TestMethod]
        public void Test32()
        {
            Bomb bomb = new Bomb(Day.Sunday, "F69RN2", 2, 2, new Indicator("BOB", false, false),
            new Indicator("CAR", false, false), new Indicator("CLR", false, false),
            new Indicator("FRK", false, false), new Indicator("FRQ", false, false),
            new Indicator("IND", false, false), new Indicator("MSA", false, false),
            new Indicator("NSA", false, false), new Indicator("SIG", false, false),
            new Indicator("SND", false, false), new Indicator("TRN", false, false), false, 3,
            new Port("dvid", 0), new Port("parallel", 2), new Port("ps", 0), new Port("rj", 0), new Port("serial", 2),
            new Port("stereo", 0));
            KTANE_Solver.BlindAlley module = new KTANE_Solver.BlindAlley(bomb, streamWriter);
            string answer = module.Solve();

            streamWriter.Close();

            Assert.AreEqual("Top Left\nMiddle\nMiddle Right\nBottom Left\nBottom Middle", answer);
        }

    }
}
