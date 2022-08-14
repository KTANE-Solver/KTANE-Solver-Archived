using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using KTANE_Solver;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace ModuleTests
{
    [TestClass]
    public class LEDGridTest
    {
        StreamWriter streamWriter = new StreamWriter("dummy.txt");

        [TestMethod]
        public void ZeroIndicators()
        {
            Bomb bomb = new Bomb(Day.Sunday, "ABCDE6", 0, 0, 
                                 new Indicator("", true, false), new Indicator("", false, false), 
                                 new Indicator("", false, false), new Indicator("", false, false), 
                                 new Indicator("", false, false), new Indicator("", false, false), 
                                 new Indicator("", false, false), new Indicator("", false, false), 
                                 new Indicator("", false, false), new Indicator("", false, false), 
                                 new Indicator("", false, false), false, 0, 
                                 new Port("", 0), new Port("", 0), new Port("", 0), 
                                 new Port("", 0), new Port("", 0), new Port("", 0));

            Color[] grid = new Color[] { Color.Red, Color.Red, Color.Red, 
                                         Color.Red, Color.Red, Color.Red, 
                                         Color.Red, Color.Red, Color.Red };

            LEDGrid module = new LEDGrid(bomb, streamWriter, grid);

            Assert.AreEqual("C, D, A, B", module.FindAnswer());

            grid = new Color[] { Color.Red, Color.Red, Color.Red,
                                 Color.Red, Color.Red, Color.Red,
                                 Color.Red, Color.Red, Color.Orange };

            module = new LEDGrid(bomb, streamWriter, grid);

            Assert.AreEqual("D, A, C, B", module.FindAnswer());

            grid = new Color[] { Color.Blue, Color.Blue, Color.Blue,
                                 Color.Blue, Color.Blue, Color.Orange,
                                 Color.Blue, Color.Blue, Color.Orange };

            module = new LEDGrid(bomb, streamWriter, grid);

            Assert.AreEqual("B, A, C, D", module.FindAnswer());

            grid = new Color[] { Color.Orange, Color.Blue, Color.Blue,
                                 Color.Blue, Color.Blue, Color.Blue,
                                 Color.Blue, Color.Blue, Color.Blue };

            module = new LEDGrid(bomb, streamWriter, grid);

            Assert.AreEqual("A, C, D, B", module.FindAnswer());

            grid = new Color[] { Color.Orange, Color.Blue, Color.Blue,
                                 Color.Blue, Color.Blue, Color.Blue,
                                 Color.Blue, Color.Green, Color.Blue };

            module = new LEDGrid(bomb, streamWriter, grid);

            Assert.AreEqual("B, C, D, A", module.FindAnswer());
        }

        [TestMethod]
        public void OneIndicators()
        {

        }

        [TestMethod]
        public void TwoIndicators()
        {

        }

        [TestMethod]
        public void ThreeIndicators()
        {

        }

        [TestMethod]
        public void FourIndicators()
        {

        }
    }
}
