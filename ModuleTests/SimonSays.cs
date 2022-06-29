using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using KTANE_Solver;
using System.Windows.Forms;
using System.IO;
namespace ModuleTests
{
    [TestClass]
    public class SimonSays
    {
        StreamWriter streamWriter = new StreamWriter("C:\\delete later\\dummy.txt");
        [TestMethod]
        public void Test1()
        {
            Bomb bomb = new Bomb(Day.Sunday, "E", 0, 0, new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false),  false, 0, null, null, null, null, null, null);
            KTANE_Solver.SimonSays module = new KTANE_Solver.SimonSays(bomb, streamWriter);

            string answer = module.DebugSolve('R');
            streamWriter.Close();
            Assert.AreEqual(answer, "Blue");
        }

        [TestMethod]
        public void Test2()
        {
            Bomb bomb = new Bomb(Day.Sunday, "E", 0, 0, new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false),  false, 0, null, null, null, null, null, null);
            KTANE_Solver.SimonSays module = new KTANE_Solver.SimonSays(bomb, streamWriter);

            string answer = module.DebugSolve('Y');
            streamWriter.Close();
            Assert.AreEqual(answer, "Green");
        }

        [TestMethod]
        public void Test3()
        {
            Bomb bomb = new Bomb(Day.Sunday, "E", 0, 0, new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false),  false, 0, null, null, null, null, null, null);
            KTANE_Solver.SimonSays module = new KTANE_Solver.SimonSays(bomb, streamWriter);

            string answer = module.DebugSolve('B');
            streamWriter.Close();
            Assert.AreEqual(answer, "Red");
        }

        [TestMethod]
        public void Test4()
        {
            Bomb bomb = new Bomb(Day.Sunday, "E", 0, 0, new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false),  false, 0, null, null, null, null, null, null);
            KTANE_Solver.SimonSays module = new KTANE_Solver.SimonSays(bomb, streamWriter);

            string answer = module.DebugSolve('G');
            streamWriter.Close();
            Assert.AreEqual(answer, "Yellow");
        }

        [TestMethod]
        public void Test5()
        {
            Bomb bomb = new Bomb(Day.Sunday, "E", 0, 0, new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false),  false, 0, null, null, null, null, null, null);
            KTANE_Solver.SimonSays module = new KTANE_Solver.SimonSays(bomb, streamWriter);

            bomb.IncrementStrike();
            string answer = module.DebugSolve('R');
            streamWriter.Close();
            Assert.AreEqual(answer, "Yellow");
        }


        [TestMethod]
        public void Test6()
        {
            Bomb bomb = new Bomb(Day.Sunday, "E", 0, 0, new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false),  false, 0, null, null, null, null, null, null);
            KTANE_Solver.SimonSays module = new KTANE_Solver.SimonSays(bomb, streamWriter);

            bomb.IncrementStrike();
            string answer = module.DebugSolve('Y');
            streamWriter.Close();
            Assert.AreEqual(answer, "Red");
        }

        [TestMethod]
        public void Test7()
        {
            Bomb bomb = new Bomb(Day.Sunday, "E", 0, 0, new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false),  false, 0, null, null, null, null, null, null);
            KTANE_Solver.SimonSays module = new KTANE_Solver.SimonSays(bomb, streamWriter);

            bomb.IncrementStrike();
            string answer = module.DebugSolve('B');
            streamWriter.Close();
            Assert.AreEqual(answer, "Green");
        }

        [TestMethod]
        public void Test8()
        {
            Bomb bomb = new Bomb(Day.Sunday, "E", 0, 0, new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false),  false, 0, null, null, null, null, null, null);
            KTANE_Solver.SimonSays module = new KTANE_Solver.SimonSays(bomb, streamWriter);

            bomb.IncrementStrike();
            string answer = module.DebugSolve('G');
            streamWriter.Close();
            Assert.AreEqual(answer, "Blue");
        }

        [TestMethod]
        public void Test9()
        {
            Bomb bomb = new Bomb(Day.Sunday, "E", 0, 0, new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false),  false, 0, null, null, null, null, null, null);
            KTANE_Solver.SimonSays module = new KTANE_Solver.SimonSays(bomb, streamWriter);

            bomb.IncrementStrike();
            bomb.IncrementStrike();
            string answer = module.DebugSolve('R');
            streamWriter.Close();
            Assert.AreEqual(answer, "Green");
        }


        [TestMethod]
        public void Test10()
        {
            Bomb bomb = new Bomb(Day.Sunday, "E", 0, 0, new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false),  false, 0, null, null, null, null, null, null);
            KTANE_Solver.SimonSays module = new KTANE_Solver.SimonSays(bomb, streamWriter);

            bomb.IncrementStrike();
            bomb.IncrementStrike();

            string answer = module.DebugSolve('Y');
            streamWriter.Close();
            Assert.AreEqual(answer, "Blue");
        }

        [TestMethod]
        public void Test11()
        {
            Bomb bomb = new Bomb(Day.Sunday, "E", 0, 0, new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false),  false, 0, null, null, null, null, null, null);
            KTANE_Solver.SimonSays module = new KTANE_Solver.SimonSays(bomb, streamWriter);

            bomb.IncrementStrike();
            bomb.IncrementStrike();

            string answer = module.DebugSolve('B');
            streamWriter.Close();
            Assert.AreEqual(answer, "Red");
        }

        [TestMethod]
        public void Test12()
        {
            Bomb bomb = new Bomb(Day.Sunday, "E", 0, 0, new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false),  false, 0, null, null, null, null, null, null);
            KTANE_Solver.SimonSays module = new KTANE_Solver.SimonSays(bomb, streamWriter);

            bomb.IncrementStrike();
            bomb.IncrementStrike();

            string answer = module.DebugSolve('G');
            streamWriter.Close();
            Assert.AreEqual(answer, "Yellow");
        }

        [TestMethod]
        public void Test13()
        {
            Bomb bomb = new Bomb(Day.Sunday, "Q", 0, 0, new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), false, 0, null, null, null, null, null, null);
            KTANE_Solver.SimonSays module = new KTANE_Solver.SimonSays(bomb, streamWriter);

            string answer = module.DebugSolve('R');
            streamWriter.Close();
            Assert.AreEqual(answer, "Blue");
        }

        [TestMethod]
        public void Test14()
        {
            Bomb bomb = new Bomb(Day.Sunday, "Q", 0, 0, new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), false, 0, null, null, null, null, null, null);
            KTANE_Solver.SimonSays module = new KTANE_Solver.SimonSays(bomb, streamWriter);

            string answer = module.DebugSolve('Y');
            streamWriter.Close();
            Assert.AreEqual(answer, "Red");
        }

        [TestMethod]
        public void Test15()
        {
            Bomb bomb = new Bomb(Day.Sunday, "Q", 0, 0, new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), false, 0, null, null, null, null, null, null);
            KTANE_Solver.SimonSays module = new KTANE_Solver.SimonSays(bomb, streamWriter);

            string answer = module.DebugSolve('B');
            streamWriter.Close();
            Assert.AreEqual(answer, "Yellow");
        }

        [TestMethod]
        public void Test16()
        {
            Bomb bomb = new Bomb(Day.Sunday, "Q", 0, 0, new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), false, 0, null, null, null, null, null, null);
            KTANE_Solver.SimonSays module = new KTANE_Solver.SimonSays(bomb, streamWriter);

            string answer = module.DebugSolve('G');
            streamWriter.Close();
            Assert.AreEqual(answer, "Green");
        }

        [TestMethod]
        public void Test17()
        {
            Bomb bomb = new Bomb(Day.Sunday, "Q", 0, 0, new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), false, 0, null, null, null, null, null, null);
            KTANE_Solver.SimonSays module = new KTANE_Solver.SimonSays(bomb, streamWriter);
            bomb.IncrementStrike();
            string answer = module.DebugSolve('R');
            streamWriter.Close();
            Assert.AreEqual(answer, "Red");
        }

        [TestMethod]
        public void Test18()
        {
            Bomb bomb = new Bomb(Day.Sunday, "Q", 0, 0, new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), false, 0, null, null, null, null, null, null);
            KTANE_Solver.SimonSays module = new KTANE_Solver.SimonSays(bomb, streamWriter);
            bomb.IncrementStrike();

            string answer = module.DebugSolve('Y');
            streamWriter.Close();
            Assert.AreEqual(answer, "Green");
        }

        [TestMethod]
        public void Test19()
        {
            Bomb bomb = new Bomb(Day.Sunday, "Q", 0, 0, new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), false, 0, null, null, null, null, null, null);
            KTANE_Solver.SimonSays module = new KTANE_Solver.SimonSays(bomb, streamWriter);
            bomb.IncrementStrike();

            string answer = module.DebugSolve('B');
            streamWriter.Close();
            Assert.AreEqual(answer, "Blue");
        }

        [TestMethod]
        public void Test20()
        {
            Bomb bomb = new Bomb(Day.Sunday, "Q", 0, 0, new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), false, 0, null, null, null, null, null, null);
            KTANE_Solver.SimonSays module = new KTANE_Solver.SimonSays(bomb, streamWriter);
            bomb.IncrementStrike();

            string answer = module.DebugSolve('G');
            streamWriter.Close();
            Assert.AreEqual(answer, "Yellow");
        }

        [TestMethod]
        public void Test21()
        {
            Bomb bomb = new Bomb(Day.Sunday, "Q", 0, 0, new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), false, 0, null, null, null, null, null, null);
            KTANE_Solver.SimonSays module = new KTANE_Solver.SimonSays(bomb, streamWriter);
            bomb.IncrementStrike();
            string answer = module.DebugSolve('R');
            streamWriter.Close();
            Assert.AreEqual(answer, "Red");
        }

        [TestMethod]
        public void Test22()
        {
            Bomb bomb = new Bomb(Day.Sunday, "Q", 0, 0, new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), false, 0, null, null, null, null, null, null);
            KTANE_Solver.SimonSays module = new KTANE_Solver.SimonSays(bomb, streamWriter);
            bomb.IncrementStrike();

            string answer = module.DebugSolve('Y');
            streamWriter.Close();
            Assert.AreEqual(answer, "Green");
        }

        [TestMethod]
        public void Test23()
        {
            Bomb bomb = new Bomb(Day.Sunday, "Q", 0, 0, new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), false, 0, null, null, null, null, null, null);
            KTANE_Solver.SimonSays module = new KTANE_Solver.SimonSays(bomb, streamWriter);
            bomb.IncrementStrike();

            string answer = module.DebugSolve('B');
            streamWriter.Close();
            Assert.AreEqual(answer, "Blue");
        }

        [TestMethod]
        public void Test24()
        {
            Bomb bomb = new Bomb(Day.Sunday, "Q", 0, 0, new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), false, 0, null, null, null, null, null, null);
            KTANE_Solver.SimonSays module = new KTANE_Solver.SimonSays(bomb, streamWriter);
            bomb.IncrementStrike();

            string answer = module.DebugSolve('G');
            streamWriter.Close();
            Assert.AreEqual(answer, "Yellow");
        }
    }
}
