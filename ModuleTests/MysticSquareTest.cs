using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using KTANE_Solver;
using System.IO;
namespace ModuleTests
{
    [TestClass]
    public class MysticSquareTest
    {
        StreamWriter writer = new StreamWriter("C:\\Users\\nyabe\\Downloads\\delete later\\dummy.txt");
        [TestMethod]
        public void TestMethod1()
        {
            int[,] grid = new int[,] { { 5, 1, 4 }, { 6, 0, 2 }, { 8, 3, 7 } };
            MysticSquares module = new MysticSquares(null, writer, grid);

            module.Solve();

            Assert.IsTrue(false);
        }
    }
}
