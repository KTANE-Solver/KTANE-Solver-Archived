using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using KTANE_Solver;
using System.IO;
namespace ModuleTests
{
    [TestClass]
    public class MysticSquareTest
    {
        StreamWriter streamWriter = new StreamWriter("dummy.txt");

        [TestMethod]
        public void TestMethod1()
        {
            Bomb bomb = new Bomb(System.Windows.Forms.Day.Saturday, "MQ6EV4", 0, 0, new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), false, 0, null, null, null, null, null, null);

            string text = "231084675";

                int[,] grid = new int[3, 3];


            for (int i = 0; i < 9; i++)
            {
                int row = i / 3;
                int col = i % 3;

                grid[row, col] = int.Parse("" + text[i]);
            }

            MysticSquares module = new MysticSquares(bomb, streamWriter);

            Assert.AreEqual(5, module.FindSkullDebug(grid));

            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod2()
        {
            Bomb bomb = new Bomb(System.Windows.Forms.Day.Saturday, "TU7JE6", 0, 0, new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), false, 0, null, null, null, null, null, null);

            string text = "457831206";

            int[,] grid = new int[3, 3];


            for (int i = 0; i < 9; i++)
            {
                int row = i / 3;
                int col = i % 3;

                grid[row, col] = int.Parse("" + text[i]);
            }

            MysticSquares module = new MysticSquares(bomb, streamWriter);

            Assert.AreEqual(5, module.FindSkullDebug(grid));
        }
    }
}

