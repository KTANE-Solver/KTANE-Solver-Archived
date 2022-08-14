using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using KTANE_Solver;
using System.IO;
namespace ModuleTests
{
    [TestClass]
    public class ColoredSquaresTest
    {
        StreamWriter streamWriter = new StreamWriter("dummy.txt");

        ColoredSquares.Color[,] grid;
        ColoredSquares module;

        [TestMethod]
        public void Red()
        {
            #region 1
            grid = new ColoredSquares.Color [,] { {ColoredSquares.Color.White, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red}};

            module = new ColoredSquares(grid, null, streamWriter);

            Assert.AreEqual(ColoredSquares.Color.Blue, module.DebugSolve(ColoredSquares.Color.Red));

            #endregion

            #region 2
            grid = new ColoredSquares.Color[,] { {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red}};

            module = new ColoredSquares(grid, null, streamWriter);

            Assert.AreEqual(ColoredSquares.Color.Row, module.DebugSolve(ColoredSquares.Color.Red));

            #endregion

            #region 3
            grid = new ColoredSquares.Color[,] { {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red}};

            module = new ColoredSquares(grid, null, streamWriter);

            Assert.AreEqual(ColoredSquares.Color.Yellow, module.DebugSolve(ColoredSquares.Color.Red));

            #endregion

            #region 4
            grid = new ColoredSquares.Color[,] { {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red}};

            module = new ColoredSquares(grid, null, streamWriter);

            Assert.AreEqual(ColoredSquares.Color.Blue, module.DebugSolve(ColoredSquares.Color.Red));

            #endregion

            #region 5
            grid = new ColoredSquares.Color[,] { {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red}};

            module = new ColoredSquares(grid, null, streamWriter);

            Assert.AreEqual(ColoredSquares.Color.Yellow, module.DebugSolve(ColoredSquares.Color.Red));

            #endregion

            #region 6
            grid = new ColoredSquares.Color[,] { {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red}};

            module = new ColoredSquares(grid, null, streamWriter);

            Assert.AreEqual(ColoredSquares.Color.Magenta, module.DebugSolve(ColoredSquares.Color.Red));

            #endregion

            #region 7
            grid = new ColoredSquares.Color[,] { {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red}};

            module = new ColoredSquares(grid, null, streamWriter);

            Assert.AreEqual(ColoredSquares.Color.Green, module.DebugSolve(ColoredSquares.Color.Red));

            #endregion

            #region 8
            grid = new ColoredSquares.Color[,] { {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red}};

            module = new ColoredSquares(grid, null, streamWriter);

            Assert.AreEqual(ColoredSquares.Color.Magenta, module.DebugSolve(ColoredSquares.Color.Red));

            #endregion

            #region 9
            grid = new ColoredSquares.Color[,] { {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red}};

            module = new ColoredSquares(grid, null, streamWriter);

            Assert.AreEqual(ColoredSquares.Color.Column, module.DebugSolve(ColoredSquares.Color.Red));

            #endregion

            #region 10
            grid = new ColoredSquares.Color[,] { {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red}};

            module = new ColoredSquares(grid, null, streamWriter);

            Assert.AreEqual(ColoredSquares.Color.Green, module.DebugSolve(ColoredSquares.Color.Red));

            #endregion

            #region 11
            grid = new ColoredSquares.Color[,] { {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red}};

            module = new ColoredSquares(grid, null, streamWriter);

            Assert.AreEqual(ColoredSquares.Color.Red, module.DebugSolve(ColoredSquares.Color.Red));

            #endregion

            #region 12
            grid = new ColoredSquares.Color[,] { {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red}};

            module = new ColoredSquares(grid, null, streamWriter);

            Assert.AreEqual(ColoredSquares.Color.Column, module.DebugSolve(ColoredSquares.Color.Red));

            #endregion

            #region 13
            grid = new ColoredSquares.Color[,] { {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red}};

            module = new ColoredSquares(grid, null, streamWriter);

            Assert.AreEqual(ColoredSquares.Color.Row, module.DebugSolve(ColoredSquares.Color.Red));

            #endregion

            #region 14
            grid = new ColoredSquares.Color[,] { {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.Red, ColoredSquares.Color.Red}};

            module = new ColoredSquares(grid, null, streamWriter);

            Assert.AreEqual(ColoredSquares.Color.Red, module.DebugSolve(ColoredSquares.Color.Red));

            #endregion

            #region 15
            grid = new ColoredSquares.Color[,] { {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.Red}};

            module = new ColoredSquares(grid, null, streamWriter);

            Assert.AreEqual(ColoredSquares.Color.Column, module.DebugSolve(ColoredSquares.Color.Red));

            #endregion

            streamWriter.Close();
        }

        [TestMethod]
        public void Blue()
        {
            #region 1
            grid = new ColoredSquares.Color[,] { {ColoredSquares.Color.White, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red}};

            module = new ColoredSquares(grid, null, streamWriter);

            Assert.AreEqual(ColoredSquares.Color.Column, module.DebugSolve(ColoredSquares.Color.Blue));

            #endregion

            #region 2
            grid = new ColoredSquares.Color[,] { {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red}};

            module = new ColoredSquares(grid, null, streamWriter);

            Assert.AreEqual(ColoredSquares.Color.Green, module.DebugSolve(ColoredSquares.Color.Blue));

            #endregion

            #region 3
            grid = new ColoredSquares.Color[,] { {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red}};

            module = new ColoredSquares(grid, null, streamWriter);

            Assert.AreEqual(ColoredSquares.Color.Magenta, module.DebugSolve(ColoredSquares.Color.Blue));

            #endregion

            #region 4
            grid = new ColoredSquares.Color[,] { {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red}};

            module = new ColoredSquares(grid, null, streamWriter);

            Assert.AreEqual(ColoredSquares.Color.Green, module.DebugSolve(ColoredSquares.Color.Blue));

            #endregion

            #region 5
            grid = new ColoredSquares.Color[,] { {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red}};

            module = new ColoredSquares(grid, null, streamWriter);

            Assert.AreEqual(ColoredSquares.Color.Row, module.DebugSolve(ColoredSquares.Color.Blue));

            #endregion

            #region 6
            grid = new ColoredSquares.Color[,] { {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red}};

            module = new ColoredSquares(grid, null, streamWriter);

            Assert.AreEqual(ColoredSquares.Color.Red, module.DebugSolve(ColoredSquares.Color.Blue));

            #endregion

            #region 7
            grid = new ColoredSquares.Color[,] { {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red}};

            module = new ColoredSquares(grid, null, streamWriter);

            Assert.AreEqual(ColoredSquares.Color.Row, module.DebugSolve(ColoredSquares.Color.Blue));

            #endregion

            #region 8
            grid = new ColoredSquares.Color[,] { {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red}};

            module = new ColoredSquares(grid, null, streamWriter);

            Assert.AreEqual(ColoredSquares.Color.Red, module.DebugSolve(ColoredSquares.Color.Blue));

            #endregion

            #region 9
            grid = new ColoredSquares.Color[,] { {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red}};

            module = new ColoredSquares(grid, null, streamWriter);

            Assert.AreEqual(ColoredSquares.Color.Yellow, module.DebugSolve(ColoredSquares.Color.Blue));

            #endregion

            #region 10
            grid = new ColoredSquares.Color[,] { {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red}};

            module = new ColoredSquares(grid, null, streamWriter);

            Assert.AreEqual(ColoredSquares.Color.Column, module.DebugSolve(ColoredSquares.Color.Blue));

            #endregion

            #region 11
            grid = new ColoredSquares.Color[,] { {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red}};

            module = new ColoredSquares(grid, null, streamWriter);

            Assert.AreEqual(ColoredSquares.Color.Yellow, module.DebugSolve(ColoredSquares.Color.Blue));

            #endregion

            #region 12
            grid = new ColoredSquares.Color[,] { {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red}};

            module = new ColoredSquares(grid, null, streamWriter);

            Assert.AreEqual(ColoredSquares.Color.Blue, module.DebugSolve(ColoredSquares.Color.Blue));

            #endregion

            #region 13
            grid = new ColoredSquares.Color[,] { {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red}};

            module = new ColoredSquares(grid, null, streamWriter);

            Assert.AreEqual(ColoredSquares.Color.Magenta, module.DebugSolve(ColoredSquares.Color.Blue));

            #endregion

            #region 14
            grid = new ColoredSquares.Color[,] { {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.Red, ColoredSquares.Color.Red}};

            module = new ColoredSquares(grid, null, streamWriter);

            Assert.AreEqual(ColoredSquares.Color.Blue, module.DebugSolve(ColoredSquares.Color.Blue));

            #endregion

            #region 15
            grid = new ColoredSquares.Color[,] { {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.Red}};

            module = new ColoredSquares(grid, null, streamWriter);

            Assert.AreEqual(ColoredSquares.Color.Row, module.DebugSolve(ColoredSquares.Color.Blue));

            #endregion

            streamWriter.Close();
        }

        [TestMethod]
        public void Green()
        {
            #region 1
            grid = new ColoredSquares.Color[,] { {ColoredSquares.Color.White, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red}};

            module = new ColoredSquares(grid, null, streamWriter);

            Assert.AreEqual(ColoredSquares.Color.Red, module.DebugSolve(ColoredSquares.Color.Green));

            #endregion

            #region 2
            grid = new ColoredSquares.Color[,] { {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red}};

            module = new ColoredSquares(grid, null, streamWriter);

            Assert.AreEqual(ColoredSquares.Color.Blue, module.DebugSolve(ColoredSquares.Color.Green));

            #endregion

            #region 3
            grid = new ColoredSquares.Color[,] { {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red}};

            module = new ColoredSquares(grid, null, streamWriter);

            Assert.AreEqual(ColoredSquares.Color.Green, module.DebugSolve(ColoredSquares.Color.Green));

            #endregion

            #region 4
            grid = new ColoredSquares.Color[,] { {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red}};

            module = new ColoredSquares(grid, null, streamWriter);

            Assert.AreEqual(ColoredSquares.Color.Yellow, module.DebugSolve(ColoredSquares.Color.Green));

            #endregion

            #region 5
            grid = new ColoredSquares.Color[,] { {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red}};

            module = new ColoredSquares(grid, null, streamWriter);

            Assert.AreEqual(ColoredSquares.Color.Blue, module.DebugSolve(ColoredSquares.Color.Green));

            #endregion

            #region 6
            grid = new ColoredSquares.Color[,] { {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red}};

            module = new ColoredSquares(grid, null, streamWriter);

            Assert.AreEqual(ColoredSquares.Color.Yellow, module.DebugSolve(ColoredSquares.Color.Green));

            #endregion

            #region 7
            grid = new ColoredSquares.Color[,] { {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red}};

            module = new ColoredSquares(grid, null, streamWriter);

            Assert.AreEqual(ColoredSquares.Color.Column, module.DebugSolve(ColoredSquares.Color.Green));

            #endregion

            #region 8
            grid = new ColoredSquares.Color[,] { {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red}};

            module = new ColoredSquares(grid, null, streamWriter);

            Assert.AreEqual(ColoredSquares.Color.Green, module.DebugSolve(ColoredSquares.Color.Green));

            #endregion

            #region 9
            grid = new ColoredSquares.Color[,] { {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red}};

            module = new ColoredSquares(grid, null, streamWriter);

            Assert.AreEqual(ColoredSquares.Color.Red, module.DebugSolve(ColoredSquares.Color.Green));

            #endregion

            #region 10
            grid = new ColoredSquares.Color[,] { {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red}};

            module = new ColoredSquares(grid, null, streamWriter);

            Assert.AreEqual(ColoredSquares.Color.Row, module.DebugSolve(ColoredSquares.Color.Green));

            #endregion

            #region 11
            grid = new ColoredSquares.Color[,] { {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red}};

            module = new ColoredSquares(grid, null, streamWriter);

            Assert.AreEqual(ColoredSquares.Color.Row, module.DebugSolve(ColoredSquares.Color.Green));

            #endregion

            #region 12
            grid = new ColoredSquares.Color[,] { {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red}};

            module = new ColoredSquares(grid, null, streamWriter);

            Assert.AreEqual(ColoredSquares.Color.Magenta, module.DebugSolve(ColoredSquares.Color.Green));

            #endregion

            #region 13
            grid = new ColoredSquares.Color[,] { {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red}};

            module = new ColoredSquares(grid, null, streamWriter);

            Assert.AreEqual(ColoredSquares.Color.Column, module.DebugSolve(ColoredSquares.Color.Green));

            #endregion

            #region 14
            grid = new ColoredSquares.Color[,] { {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.Red, ColoredSquares.Color.Red}};

            module = new ColoredSquares(grid, null, streamWriter);

            Assert.AreEqual(ColoredSquares.Color.Magenta, module.DebugSolve(ColoredSquares.Color.Green));

            #endregion

            #region 15
            grid = new ColoredSquares.Color[,] { {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.Red}};

            module = new ColoredSquares(grid, null, streamWriter);

            Assert.AreEqual(ColoredSquares.Color.Column, module.DebugSolve(ColoredSquares.Color.Green));

            #endregion

            streamWriter.Close();
        }

        [TestMethod]
        public void Yellow()
        {
            #region 1
            grid = new ColoredSquares.Color[,] { {ColoredSquares.Color.White, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red}};

            module = new ColoredSquares(grid, null, streamWriter);

            Assert.AreEqual(ColoredSquares.Color.Yellow, module.DebugSolve(ColoredSquares.Color.Yellow));

            #endregion

            #region 2
            grid = new ColoredSquares.Color[,] { {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red}};

            module = new ColoredSquares(grid, null, streamWriter);

            Assert.AreEqual(ColoredSquares.Color.Magenta, module.DebugSolve(ColoredSquares.Color.Yellow));

            #endregion

            #region 3
            grid = new ColoredSquares.Color[,] { {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red}};

            module = new ColoredSquares(grid, null, streamWriter);

            Assert.AreEqual(ColoredSquares.Color.Row, module.DebugSolve(ColoredSquares.Color.Yellow));

            #endregion

            #region 4
            grid = new ColoredSquares.Color[,] { {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red}};

            module = new ColoredSquares(grid, null, streamWriter);

            Assert.AreEqual(ColoredSquares.Color.Column, module.DebugSolve(ColoredSquares.Color.Yellow));

            #endregion

            #region 5
            grid = new ColoredSquares.Color[,] { {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red}};

            module = new ColoredSquares(grid, null, streamWriter);

            Assert.AreEqual(ColoredSquares.Color.Magenta, module.DebugSolve(ColoredSquares.Color.Yellow));

            #endregion

            #region 6
            grid = new ColoredSquares.Color[,] { {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red}};

            module = new ColoredSquares(grid, null, streamWriter);

            Assert.AreEqual(ColoredSquares.Color.Green, module.DebugSolve(ColoredSquares.Color.Yellow));

            #endregion

            #region 7
            grid = new ColoredSquares.Color[,] { {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red}};

            module = new ColoredSquares(grid, null, streamWriter);

            Assert.AreEqual(ColoredSquares.Color.Blue, module.DebugSolve(ColoredSquares.Color.Yellow));

            #endregion

            #region 8
            grid = new ColoredSquares.Color[,] { {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red}};

            module = new ColoredSquares(grid, null, streamWriter);

            Assert.AreEqual(ColoredSquares.Color.Blue, module.DebugSolve(ColoredSquares.Color.Yellow));

            #endregion

            #region 9
            grid = new ColoredSquares.Color[,] { {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red}};

            module = new ColoredSquares(grid, null, streamWriter);

            Assert.AreEqual(ColoredSquares.Color.Green, module.DebugSolve(ColoredSquares.Color.Yellow));

            #endregion

            #region 10
            grid = new ColoredSquares.Color[,] { {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red}};

            module = new ColoredSquares(grid, null, streamWriter);

            Assert.AreEqual(ColoredSquares.Color.Red, module.DebugSolve(ColoredSquares.Color.Yellow));

            #endregion

            #region 11
            grid = new ColoredSquares.Color[,] { {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red}};

            module = new ColoredSquares(grid, null, streamWriter);

            Assert.AreEqual(ColoredSquares.Color.Column, module.DebugSolve(ColoredSquares.Color.Yellow));

            #endregion

            #region 12
            grid = new ColoredSquares.Color[,] { {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red}};

            module = new ColoredSquares(grid, null, streamWriter);

            Assert.AreEqual(ColoredSquares.Color.Red, module.DebugSolve(ColoredSquares.Color.Yellow));

            #endregion

            #region 13
            grid = new ColoredSquares.Color[,] { {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red}};

            module = new ColoredSquares(grid, null, streamWriter);

            Assert.AreEqual(ColoredSquares.Color.Yellow, module.DebugSolve(ColoredSquares.Color.Yellow));

            #endregion

            #region 14
            grid = new ColoredSquares.Color[,] { {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.Red, ColoredSquares.Color.Red}};

            module = new ColoredSquares(grid, null, streamWriter);

            Assert.AreEqual(ColoredSquares.Color.Row, module.DebugSolve(ColoredSquares.Color.Yellow));

            #endregion

            #region 15
            grid = new ColoredSquares.Color[,] { {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.Red}};

            module = new ColoredSquares(grid, null, streamWriter);

            Assert.AreEqual(ColoredSquares.Color.Row, module.DebugSolve(ColoredSquares.Color.Yellow));

            #endregion

            streamWriter.Close();
        }

        [TestMethod]
        public void Magenta()
        {
            #region 1
            grid = new ColoredSquares.Color[,] { {ColoredSquares.Color.White, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red}};

            module = new ColoredSquares(grid, null, streamWriter);

            Assert.AreEqual(ColoredSquares.Color.Row, module.DebugSolve(ColoredSquares.Color.Magenta));

            #endregion

            #region 2
            grid = new ColoredSquares.Color[,] { {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red}};

            module = new ColoredSquares(grid, null, streamWriter);

            Assert.AreEqual(ColoredSquares.Color.Red, module.DebugSolve(ColoredSquares.Color.Magenta));

            #endregion

            #region 3
            grid = new ColoredSquares.Color[,] { {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red}};

            module = new ColoredSquares(grid, null, streamWriter);

            Assert.AreEqual(ColoredSquares.Color.Blue, module.DebugSolve(ColoredSquares.Color.Magenta));

            #endregion

            #region 4
            grid = new ColoredSquares.Color[,] { {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red}};

            module = new ColoredSquares(grid, null, streamWriter);

            Assert.AreEqual(ColoredSquares.Color.Red, module.DebugSolve(ColoredSquares.Color.Magenta));

            #endregion

            #region 5
            grid = new ColoredSquares.Color[,] { {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red}};

            module = new ColoredSquares(grid, null, streamWriter);

            Assert.AreEqual(ColoredSquares.Color.Column, module.DebugSolve(ColoredSquares.Color.Magenta));

            #endregion

            #region 6
            grid = new ColoredSquares.Color[,] { {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red}};

            module = new ColoredSquares(grid, null, streamWriter);

            Assert.AreEqual(ColoredSquares.Color.Column, module.DebugSolve(ColoredSquares.Color.Magenta));

            #endregion

            #region 7
            grid = new ColoredSquares.Color[,] { {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red}};

            module = new ColoredSquares(grid, null, streamWriter);

            Assert.AreEqual(ColoredSquares.Color.Magenta, module.DebugSolve(ColoredSquares.Color.Magenta));

            #endregion

            #region 8
            grid = new ColoredSquares.Color[,] { {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red}};

            module = new ColoredSquares(grid, null, streamWriter);

            Assert.AreEqual(ColoredSquares.Color.Yellow, module.DebugSolve(ColoredSquares.Color.Magenta));

            #endregion

            #region 9
            grid = new ColoredSquares.Color[,] { {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red}};

            module = new ColoredSquares(grid, null, streamWriter);

            Assert.AreEqual(ColoredSquares.Color.Row, module.DebugSolve(ColoredSquares.Color.Magenta));

            #endregion

            #region 10
            grid = new ColoredSquares.Color[,] { {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red}};

            module = new ColoredSquares(grid, null, streamWriter);

            Assert.AreEqual(ColoredSquares.Color.Magenta, module.DebugSolve(ColoredSquares.Color.Magenta));

            #endregion

            #region 11
            grid = new ColoredSquares.Color[,] { {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red}};

            module = new ColoredSquares(grid, null, streamWriter);

            Assert.AreEqual(ColoredSquares.Color.Green, module.DebugSolve(ColoredSquares.Color.Magenta));

            #endregion

            #region 12
            grid = new ColoredSquares.Color[,] { {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red}};

            module = new ColoredSquares(grid, null, streamWriter);

            Assert.AreEqual(ColoredSquares.Color.Yellow, module.DebugSolve(ColoredSquares.Color.Magenta));

            #endregion

            #region 13
            grid = new ColoredSquares.Color[,] { {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red}};

            module = new ColoredSquares(grid, null, streamWriter);

            Assert.AreEqual(ColoredSquares.Color.Blue, module.DebugSolve(ColoredSquares.Color.Magenta));

            #endregion

            #region 14
            grid = new ColoredSquares.Color[,] { {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.Red, ColoredSquares.Color.Red}};

            module = new ColoredSquares(grid, null, streamWriter);

            Assert.AreEqual(ColoredSquares.Color.Green, module.DebugSolve(ColoredSquares.Color.Magenta));

            #endregion

            #region 15
            grid = new ColoredSquares.Color[,] { {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.Red}};

            module = new ColoredSquares(grid, null, streamWriter);

            Assert.AreEqual(ColoredSquares.Color.Column, module.DebugSolve(ColoredSquares.Color.Magenta));

            #endregion

            streamWriter.Close();
        }

        [TestMethod]
        public void Row()
        {
            #region 1
            grid = new ColoredSquares.Color[,] { {ColoredSquares.Color.White, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red}};

            module = new ColoredSquares(grid, null, streamWriter);

            Assert.AreEqual(ColoredSquares.Color.Green, module.DebugSolve(ColoredSquares.Color.Row));

            #endregion

            #region 2
            grid = new ColoredSquares.Color[,] { {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red}};

            module = new ColoredSquares(grid, null, streamWriter);

            Assert.AreEqual(ColoredSquares.Color.Column, module.DebugSolve(ColoredSquares.Color.Row));

            #endregion

            #region 3
            grid = new ColoredSquares.Color[,] { {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red}};

            module = new ColoredSquares(grid, null, streamWriter);

            Assert.AreEqual(ColoredSquares.Color.Red, module.DebugSolve(ColoredSquares.Color.Row));

            #endregion

            #region 4
            grid = new ColoredSquares.Color[,] { {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red}};

            module = new ColoredSquares(grid, null, streamWriter);

            Assert.AreEqual(ColoredSquares.Color.Row, module.DebugSolve(ColoredSquares.Color.Row));

            #endregion

            #region 5
            grid = new ColoredSquares.Color[,] { {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red}};

            module = new ColoredSquares(grid, null, streamWriter);

            Assert.AreEqual(ColoredSquares.Color.Red, module.DebugSolve(ColoredSquares.Color.Row));

            #endregion

            #region 6
            grid = new ColoredSquares.Color[,] { {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red}};

            module = new ColoredSquares(grid, null, streamWriter);

            Assert.AreEqual(ColoredSquares.Color.Blue, module.DebugSolve(ColoredSquares.Color.Row));

            #endregion

            #region 7
            grid = new ColoredSquares.Color[,] { {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red}};

            module = new ColoredSquares(grid, null, streamWriter);

            Assert.AreEqual(ColoredSquares.Color.Yellow, module.DebugSolve(ColoredSquares.Color.Row));

            #endregion

            #region 8
            grid = new ColoredSquares.Color[,] { {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red}};

            module = new ColoredSquares(grid, null, streamWriter);

            Assert.AreEqual(ColoredSquares.Color.Column, module.DebugSolve(ColoredSquares.Color.Row));

            #endregion

            #region 9
            grid = new ColoredSquares.Color[,] { {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red}};

            module = new ColoredSquares(grid, null, streamWriter);

            Assert.AreEqual(ColoredSquares.Color.Magenta, module.DebugSolve(ColoredSquares.Color.Row));

            #endregion

            #region 10
            grid = new ColoredSquares.Color[,] { {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red}};

            module = new ColoredSquares(grid, null, streamWriter);

            Assert.AreEqual(ColoredSquares.Color.Blue, module.DebugSolve(ColoredSquares.Color.Row));

            #endregion

            #region 11
            grid = new ColoredSquares.Color[,] { {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red}};

            module = new ColoredSquares(grid, null, streamWriter);

            Assert.AreEqual(ColoredSquares.Color.Magenta, module.DebugSolve(ColoredSquares.Color.Row));

            #endregion

            #region 12
            grid = new ColoredSquares.Color[,] { {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red}};

            module = new ColoredSquares(grid, null, streamWriter);

            Assert.AreEqual(ColoredSquares.Color.Row, module.DebugSolve(ColoredSquares.Color.Row));

            #endregion

            #region 13
            grid = new ColoredSquares.Color[,] { {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red}};

            module = new ColoredSquares(grid, null, streamWriter);

            Assert.AreEqual(ColoredSquares.Color.Green, module.DebugSolve(ColoredSquares.Color.Row));

            #endregion

            #region 14
            grid = new ColoredSquares.Color[,] { {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.Red, ColoredSquares.Color.Red}};

            module = new ColoredSquares(grid, null, streamWriter);

            Assert.AreEqual(ColoredSquares.Color.Yellow, module.DebugSolve(ColoredSquares.Color.Row));

            #endregion

            #region 15
            grid = new ColoredSquares.Color[,] { {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.Red}};

            module = new ColoredSquares(grid, null, streamWriter);

            Assert.AreEqual(ColoredSquares.Color.Row, module.DebugSolve(ColoredSquares.Color.Row));

            #endregion

            streamWriter.Close();
        }

        [TestMethod]
        public void Column()
        {
            #region 1
            grid = new ColoredSquares.Color[,] { {ColoredSquares.Color.White, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red}};

            module = new ColoredSquares(grid, null, streamWriter);

            Assert.AreEqual(ColoredSquares.Color.Magenta, module.DebugSolve(ColoredSquares.Color.Column));

            #endregion

            #region 2
            grid = new ColoredSquares.Color[,] { {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red}};

            module = new ColoredSquares(grid, null, streamWriter);

            Assert.AreEqual(ColoredSquares.Color.Yellow, module.DebugSolve(ColoredSquares.Color.Column));

            #endregion

            #region 3
            grid = new ColoredSquares.Color[,] { {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red}};

            module = new ColoredSquares(grid, null, streamWriter);

            Assert.AreEqual(ColoredSquares.Color.Column, module.DebugSolve(ColoredSquares.Color.Column));

            #endregion

            #region 4
            grid = new ColoredSquares.Color[,] { {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red}};

            module = new ColoredSquares(grid, null, streamWriter);

            Assert.AreEqual(ColoredSquares.Color.Magenta, module.DebugSolve(ColoredSquares.Color.Column));

            #endregion

            #region 5
            grid = new ColoredSquares.Color[,] { {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red}};

            module = new ColoredSquares(grid, null, streamWriter);

            Assert.AreEqual(ColoredSquares.Color.Green, module.DebugSolve(ColoredSquares.Color.Column));

            #endregion

            #region 6
            grid = new ColoredSquares.Color[,] { {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red}};

            module = new ColoredSquares(grid, null, streamWriter);

            Assert.AreEqual(ColoredSquares.Color.Row, module.DebugSolve(ColoredSquares.Color.Column));

            #endregion

            #region 7
            grid = new ColoredSquares.Color[,] { {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red}};

            module = new ColoredSquares(grid, null, streamWriter);

            Assert.AreEqual(ColoredSquares.Color.Red, module.DebugSolve(ColoredSquares.Color.Column));

            #endregion

            #region 8
            grid = new ColoredSquares.Color[,] { {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red}};

            module = new ColoredSquares(grid, null, streamWriter);

            Assert.AreEqual(ColoredSquares.Color.Row, module.DebugSolve(ColoredSquares.Color.Column));

            #endregion

            #region 9
            grid = new ColoredSquares.Color[,] { {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red}};

            module = new ColoredSquares(grid, null, streamWriter);

            Assert.AreEqual(ColoredSquares.Color.Blue, module.DebugSolve(ColoredSquares.Color.Column));

            #endregion

            #region 10
            grid = new ColoredSquares.Color[,] { {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.Red, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red}};

            module = new ColoredSquares(grid, null, streamWriter);

            Assert.AreEqual(ColoredSquares.Color.Yellow, module.DebugSolve(ColoredSquares.Color.Column));

            #endregion

            #region 11
            grid = new ColoredSquares.Color[,] { {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.Red},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red}};

            module = new ColoredSquares(grid, null, streamWriter);

            Assert.AreEqual(ColoredSquares.Color.Blue, module.DebugSolve(ColoredSquares.Color.Column));

            #endregion

            #region 12
            grid = new ColoredSquares.Color[,] { {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red}};

            module = new ColoredSquares(grid, null, streamWriter);

            Assert.AreEqual(ColoredSquares.Color.Green, module.DebugSolve(ColoredSquares.Color.Column));

            #endregion

            #region 13
            grid = new ColoredSquares.Color[,] { {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.Red, ColoredSquares.Color.Red, ColoredSquares.Color.Red}};

            module = new ColoredSquares(grid, null, streamWriter);

            Assert.AreEqual(ColoredSquares.Color.Red, module.DebugSolve(ColoredSquares.Color.Column));

            #endregion

            #region 14
            grid = new ColoredSquares.Color[,] { {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.Red, ColoredSquares.Color.Red}};

            module = new ColoredSquares(grid, null, streamWriter);

            Assert.AreEqual(ColoredSquares.Color.Column, module.DebugSolve(ColoredSquares.Color.Column));

            #endregion

            #region 15
            grid = new ColoredSquares.Color[,] { {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White},
                                                  {ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.White, ColoredSquares.Color.Red}};

            module = new ColoredSquares(grid, null, streamWriter);

            Assert.AreEqual(ColoredSquares.Color.Column, module.DebugSolve(ColoredSquares.Color.Column));

            #endregion

            streamWriter.Close();
        }
    }
}
