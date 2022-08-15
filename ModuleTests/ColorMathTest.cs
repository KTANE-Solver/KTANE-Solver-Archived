using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using KTANE_Solver;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;
namespace ModuleTests
{

    //https://ktane.timwi.de/More/Logfile%20Analyzer.html#file=016282f09842e838b18a41e9f2a3c65f3dd775bd;bomb=7I1VK3


    [TestClass]
    public class ColorMathTest
    {
        StreamWriter io = new StreamWriter("dummy.txt");
        Bomb bomb = new Bomb(Day.Sunday, "7I1VK3", 3, 3,
            new Indicator("BOB", false, false), new Indicator("CAR", true, true), new Indicator("CLR", true, true),
            new Indicator("FRK", false, false), new Indicator("FRQ", true, true), new Indicator("IND", false, false),
            new Indicator("MSA", false, false), new Indicator("NSA", false, false), new Indicator("SIG", false, false),
            new Indicator("SND", false, false), new Indicator("TRN", false, false), false, 2,
            new Port("DVID", 1), new Port("Parallel", 1), new Port("ps", 1),
            new Port("rj", 0), new Port("serial", 1), new Port("setero", 1));


        List<ColorMath> modules = new List<ColorMath>()
        {
            new ColorMath(new Color[] { Color.Yellow, Color.Green, Color.Magenta, Color.Magenta },
                          new Color[] { Color.Black, Color.Magenta, Color.Red, Color.Blue },
                          'M', null, null),

            new ColorMath(new Color[] { Color.Purple, Color.Purple, Color.Yellow, Color.White } , 
                          new Color [] { Color.White, Color.Red, Color.Gray, Color.White } ,
                          'D', null, null),

            new ColorMath(new Color[] { Color.Purple,
                          Color.Purple,
                          Color.Yellow,
                          Color.White,
                          Color.Empty,
                          Color.Empty,
                          Color.Empty,
                          Color.Empty,
                          'S',
                          bomb,
                          io);

    };


        [TestMethod]
        public void TestMethod1()
        {
            SetBombFile(1);
            Assert.AreEqual("Yellow, White, Black, Magenta", modules[0].Solve(false));
            io.Close();
        }

        [TestMethod]
        public void TestMethod10()
        {
            SetBombFile(2);
            Assert.AreEqual("Gray, Blue, Magenta, Gray", modules[1].Solve(false));
            io.Close();

        }

        [TestMethod]
        public void TestMethod100()
        {


            Assert.AreEqual("Gray, Blue, Magenta, Gray", module.Solve(true));
            io.Close();
        }

        public void TestMethod11()
        {
            ColorMath module = new ColorMath(Color.Magenta,
                                             Color.Red,
                                             Color.Green,
                                             Color.Gray,
                                             Color.Empty,
                                             Color.Empty,
                                             Color.Empty,
                                             Color.Empty,
                                             'A',
                                             bomb,
                                             io);

            Assert.AreEqual("Gray, Green, Red, Red", module.Solve(true));
            io.Close();
        }

        public void TestMethod12()
        {
            ColorMath module = new ColorMath(Color.Red,
                                             Color.White,
                                             Color.Gray,
                                             Color.Purple,
                                             Color.Empty,
                                             Color.Empty,
                                             Color.Empty,
                                             Color.Empty,
                                             'A',
                                             bomb,
                                             io);

            Assert.AreEqual("Yellow, Red, Blue, Gray", module.Solve(true));
            io.Close();
        }

        public void TestMethod13()
        {
            ColorMath module = new ColorMath(Color.Blue,
                                             Color.Green,
                                             Color.Gray,
                                             Color.Orange,
                                             Color.Empty,
                                             Color.Empty,
                                             Color.Empty,
                                             Color.Empty,
                                             'S',
                                             bomb,
                                             io);

            Assert.AreEqual("Magenta, Gray, Magenta, Magenta", module.Solve(true));
            io.Close();
        }

        public void TestMethod14()
        {
            ColorMath module = new ColorMath(Color.Blue,
                                             Color.White,
                                             Color.Purple,
                                             Color.Gray,
                                             Color.Orange,
                                             Color.Green,
                                             Color.Red,
                                             Color.Purple,
                                             'M',
                                             bomb,
                                             io);

            Assert.AreEqual("Yellow, Orange, Orange, Gray", module.Solve(false));
            io.Close();
        }

        public void TestMethod15()
        {
            ColorMath module = new ColorMath(Color.Purple,
                                             Color.Black,
                                             Color.White,
                                             Color.Orange,
                                             Color.Empty,
                                             Color.Empty,
                                             Color.Empty,
                                             Color.Empty,
                                             'm',
                                             bomb,
                                             io);

            Assert.AreEqual("Orange, White, White, White", module.Solve(true));
            io.Close();
        }

        public void TestMethod16()
        {
            ColorMath module = new ColorMath(Color.Purple,
                                             Color.Red,
                                             Color.Gray,
                                             Color.White,
                                             Color.Empty,
                                             Color.Empty,
                                             Color.Empty,
                                             Color.Empty,
                                             'S',
                                             bomb,
                                             io);

            Assert.AreEqual("Green, White, Black, Blue", module.Solve(true));
            io.Close();
        }

        public void TestMethod17()
        {
            ColorMath module = new ColorMath(Color.Magenta,
                                             Color.Red,
                                             Color.Black,
                                             Color.Black,
                                             Color.Orange,
                                             Color.Yellow,
                                             Color.Green,
                                             Color.White,
                                             'D',
                                             bomb,
                                             io);

            Assert.AreEqual("Gray, Blue, Magenta, Gray", module.Solve(false));
            io.Close();
        }

        public void TestMethod18()
        {
            ColorMath module = new ColorMath(Color.Green,
                                             Color.Green,
                                             Color.Magenta,
                                             Color.Black,
                                             Color.Empty,
                                             Color.Empty,
                                             Color.Empty,
                                             Color.Empty,
                                             'S',
                                             bomb,
                                             io);

            Assert.AreEqual("Gray, White, Orange, White", module.Solve(true));
            io.Close();
        }

        public void TestMethod19()
        {
            ColorMath module = new ColorMath(Color.Magenta,
                                             Color.Blue,
                                             Color.Red,
                                             Color.Gray,
                                             Color.Blue,
                                             Color.Red,
                                             Color.Orange,
                                             Color.Blue,
                                             'S',
                                             bomb,
                                             io);

            Assert.AreEqual("Gray, Magenta, Yellow, Magenta", module.Solve(false));
        }

        public void TestMethod2()
        {
            ColorMath module = new ColorMath(Color.Orange,
                                             Color.Gray,
                                             Color.Red,
                                             Color.Black,
                                             Color.Green,
                                             Color.Black,
                                             Color.Orange,
                                             Color.Blue,
                                             'M',
                                             bomb,
                                             io);

            Assert.AreEqual("Purple, Red, Blue, Gray", module.Solve(false));
        }

        public void TestMethod20()
        {
            ColorMath module = new ColorMath(Color.Black,
                                             Color.Green,
                                             Color.Red,
                                             Color.Magenta,
                                             Color.Empty,
                                             Color.Empty,
                                             Color.Empty,
                                             Color.Empty,
                                             'D',
                                             bomb,
                                             io);

            Assert.AreEqual("Gray, Blue, Black, Red", module.Solve(true));
            io.Close();
        }

        public void TestMethod21()
        {
            ColorMath module = new ColorMath(Color.Yellow,
                                             Color.Blue,
                                             Color.Orange,
                                             Color.Green,
                                             Color.Magenta,
                                             Color.Gray,
                                             Color.Purple,
                                             Color.Yellow,
                                             'S',
                                             bomb,
                                             io);

            Assert.AreEqual("Orange, Purple, Gray, Blue", module.Solve(false));
        }

        public void TestMethod22()
        {
            ColorMath module = new ColorMath(Color.White,
                                             Color.Green,
                                             Color.Orange,
                                             Color.Yellow,
                                             Color.Empty,
                                             Color.Empty,
                                             Color.Empty,
                                             Color.Empty,
                                             'S',
                                             bomb,
                                             io);

            Assert.AreEqual("", module.Solve(true));
        }

        public void TestMethod23()
        {
            ColorMath module = new ColorMath(Color.Black,
                                             Color.Yellow,
                                             Color.Blue,
                                             Color.Orange,
                                             Color.Empty,
                                             Color.Empty,
                                             Color.Empty,
                                             Color.Empty,
                                             'M',
                                             bomb,
                                             io);

            Assert.AreEqual("Red, White, Yellow, White", module.Solve(true));
        }

        public void TestMethod24()
        {
            ColorMath module = new ColorMath(Color.Green,
                                             Color.Black,
                                             Color.Orange,
                                             Color.Blue,
                                             Color.Gray,
                                             Color.Red,
                                             Color.Yellow,
                                             Color.Yellow,
                                             'A',
                                             bomb,
                                             io);

            Assert.AreEqual("Orange, Gray, Orange, Magenta", module.Solve(false));
            io.Close();
        }

        public void TestMethod25()
        {
            ColorMath module = new ColorMath(Color.Blue,
                                             Color.Purple,
                                             Color.Gray,
                                             Color.Green,
                                             Color.Magenta,
                                             Color.Green,
                                             Color.Red,
                                             Color.Magenta,
                                             'D',
                                             bomb,
                                             io);

            Assert.AreEqual("Green, Blue, Magenta, Green", module.Solve(false));
            io.Close();
        }

        public void TestMethod26()
        {
            ColorMath module = new ColorMath(Color.Black,
                                             Color.Green,
                                             Color.Orange,
                                             Color.Green,
                                             Color.Yellow,
                                             Color.Orange,
                                             Color.Purple,
                                             Color.Magenta,
                                             'A',
                                             bomb,
                                             io);

            Assert.AreEqual("Green, White, Magenta, Yellow", module.Solve(false));
        }

        public void TestMethod27()
        {
            ColorMath module = new ColorMath(Color.Yellow,
                                             Color.Black,
                                             Color.Purple,
                                             Color.Purple,
                                             Color.Red,
                                             Color.White,
                                             Color.Red,
                                             Color.Red,
                                             'D',
                                             bomb,
                                             io);

            Assert.AreEqual("Gray, Blue, Magenta, Gray", module.Solve(false));
        }

        public void TestMethod28()
        {
            ColorMath module = new ColorMath(Color.Blue,
                                             Color.Blue,
                                             Color.Gray,
                                             Color.White,
                                             Color.Empty,
                                             Color.Empty,
                                             Color.Empty,
                                             Color.Empty,
                                             'D',
                                             bomb,
                                             io);

            Assert.AreEqual("Gray, Blue, Black, Blue", module.Solve(true));
        }

        public void TestMethod29()
        {
            ColorMath module = new ColorMath(Color.Magenta,
                                             Color.Orange,
                                             Color.Green,
                                             Color.White,
                                             Color.Empty,
                                             Color.Empty,
                                             Color.Empty,
                                             Color.Empty,
                                             'D',
                                             bomb,
                                             io);

            Assert.AreEqual("Gray, Blue, Magenta, Red", module.Solve(true));
        }

        public void TestMethod3()
        {
            ColorMath module = new ColorMath(Color.Gray,
                                             Color.White,
                                             Color.Gray,
                                             Color.Magenta,
                                             Color.Green,
                                             Color.Orange,
                                             Color.Orange,
                                             Color.Yellow,
                                             'D',
                                             bomb,
                                             io);

            Assert.AreEqual("Gray, Blue, Magenta, Gray", module.Solve(false));
        }

        public void TestMethod30()
        {
            ColorMath module = new ColorMath(Color.Blue,
                                             Color.Yellow,
                                             Color.Blue,
                                             Color.Red,
                                             Color.Gray,
                                             Color.Magenta,
                                             Color.Magenta,
                                             Color.Gray,
                                             'M',
                                             bomb,
                                             io);

            Assert.AreEqual("White, Magenta, White, Red", module.Solve(false));
        }

        public void TestMethod31()
        {
            ColorMath module = new ColorMath(Color.Red,
                                             Color.Red,
                                             Color.Red,
                                             Color.Red,
                                             Color.Black,
                                             Color.Orange,
                                             Color.White,
                                             Color.Black,
                                             'M',
                                             bomb,
                                             io);

            Assert.AreEqual("Yellow, Yellow, Blue, Gray", module.Solve(false));
        }

        public void TestMethod32()
        {
            ColorMath module = new ColorMath(Color.Black,
                                             Color.Magenta,
                                             Color.Gray,
                                             Color.Green,
                                             Color.Empty,
                                             Color.Empty,
                                             Color.Empty,
                                             Color.Empty,
                                             'S',
                                             bomb,
                                             io);

            Assert.AreEqual("", module.Solve(true));
        }

        public void TestMethod33()
        {
            ColorMath module = new ColorMath(Color.Yellow,
                                             Color.Green,
                                             Color.White,
                                             Color.Magenta,
                                             Color.Empty,
                                             Color.Empty,
                                             Color.Empty,
                                             Color.Empty,
                                             'D',
                                             bomb,
                                             io);

            Assert.AreEqual("Gray, Blue, Gray, Gray", module.Solve(true));
        }

        public void TestMethod34()
        {
            ColorMath module = new ColorMath(Color.Green,
                                             Color.Green,
                                             Color.Blue,
                                             Color.Red,
                                             Color.Empty,
                                             Color.Empty,
                                             Color.Empty,
                                             Color.Empty,
                                             'A',
                                             bomb,
                                             io);

            Assert.AreEqual("Green, Black, Purple, Yellow", module.Solve(true));
        }

        public void TestMethod35()
        {
            ColorMath module = new ColorMath(Color.Purple,
                                             Color.Gray,
                                             Color.Blue,
                                             Color.Red,
                                             Color.Empty,
                                             Color.Empty,
                                             Color.Empty,
                                             Color.Empty,
                                             'D',
                                             bomb,
                                             io);

            Assert.AreEqual("Purple, Red, Black, Red", module.Solve(true));
        }

        public void TestMethod36()
        {
            ColorMath module = new ColorMath(Color.Magenta,
                                             Color.Purple,
                                             Color.Blue,
                                             Color.Gray,
                                             Color.Yellow,
                                             Color.Orange,
                                             Color.Orange,
                                             Color.Purple,
                                             'D',
                                             bomb,
                                             io);

            Assert.AreEqual("White, Yellow, White, Purple", module.Solve(false));
        }

        public void TestMethod37()
        {
            ColorMath module = new ColorMath(Color.Black,
                                             Color.Green,
                                             Color.Green,
                                             Color.Orange,
                                             Color.Yellow,
                                             Color.Yellow,
                                             Color.Orange,
                                             Color.Orange,
                                             'D',
                                             bomb,
                                             io);

            Assert.AreEqual("Gray, Blue, Magenta, Blue", module.Solve(false));
        }

        public void TestMethod38()
        {
            ColorMath module = new ColorMath(Color.Yellow,
                                             Color.White,
                                             Color.Gray,
                                             Color.Purple,
                                             Color.Black,
                                             Color.Magenta,
                                             Color.Yellow,
                                             Color.Magenta,
                                             'D',
                                             bomb,
                                             io);

            Assert.AreEqual("Green, White, Magenta, Purple", module.Solve(false));
        }

        public void TestMethod39()
        {
            ColorMath module = new ColorMath(
                                             Color.Green,
                                             Color.Red,
                                             Color.Black,
                                             Color.Black,
                                             Color.Orange,
                                             Color.Green,
                                             Color.Yellow,
                                             Color.Blue,
                                             'D',
                                             bomb,
                                             io);

            Assert.AreEqual("Gray, Blue, Magenta, Orange", module.Solve(false));
        }

        public void TestMethod4()
        {
            ColorMath module = new ColorMath(Color.Green,
                                             Color.Blue,
                                             Color.Green, 
                                             Color.Gray,
                                             Color.Black,
                                             Color.Green,
                                             Color.Black,
                                             Color.Purple,
                                             'D',
                                             bomb,
                                             io);

            Assert.AreEqual("Gray, Blue, Magenta, Gray", module.Solve(false));
        }

        public void TestMethod40()
        {
            ColorMath module = new ColorMath(Color.Orange,
                                             Color.Magenta,
                                             Color.Purple,
                                             Color.Green,
                                             Color.Empty,
                                             Color.Empty,
                                             Color.Empty,
                                             Color.Empty,
                                             'D',
                                             bomb,
                                             io);

            Assert.AreEqual("Black, Orange, Gray, Yellow", module.Solve(true));
        }

        public void TestMethod41()
        {
            ColorMath module = new ColorMath(Color.Blue,
                                             Color.White,
                                             Color.Black,
                                             Color.Blue,
                                             Color.Empty,
                                             Color.Empty,
                                             Color.Empty,
                                             Color.Empty,
                                             'D',
                                             bomb,
                                             io); ;

            Assert.AreEqual("Magenta, Black, Gray, Red", module.Solve(true));
        }

        public void TestMethod42()
        {
            ColorMath module = new ColorMath(Color.Green,
                                             Color.Green,
                                             Color.Purple,
                                             Color.Yellow,
                                             Color.Black,
                                             Color.Gray,
                                             Color.Black,
                                             Color.Green,
                                             'D',
                                             bomb,
                                             io);

            Assert.AreEqual("Gray, Blue, Magenta, Gray", module.Solve(false));
        }

        public void TestMethod43()
        {
            ColorMath module = new ColorMath(Color.Green,
                                             Color.White,
                                             Color.Blue,
                                             Color.Black,
                                             Color.Empty,
                                             Color.Empty,
                                             Color.Empty,
                                             Color.Empty,
                                             'D',
                                             bomb,
                                             io);

            Assert.AreEqual("Green, Black, Magenta, White", module.Solve(true));
        }

        public void TestMethod44()
        {
            ColorMath module = new ColorMath(Color.Black,
                                             Color.Green,
                                             Color.Red,
                                             Color.Magenta,
                                             Color.Empty,
                                             Color.Empty,
                                             Color.Empty,
                                             Color.Empty,
                                             'D',
                                             bomb,
                                             io);

            Assert.AreEqual("Black, Blue, Blue, Black", module.Solve(true));
        }

        public void TestMethod45()
        {
            ColorMath module = new ColorMath(Color.White,
                                             Color.Gray,
                                             Color.Purple,
                                             Color.Blue,
                                             Color.Yellow,
                                             Color.Blue,
                                             Color.Black,
                                             Color.Red,
                                             'D',
                                             bomb,
                                             io);

            Assert.AreEqual("Blue, Red, Purple, White", module.Solve(false));
        }

        public void TestMethod46()
        {
            ColorMath module = new ColorMath(Color.Gray,
                                             Color.Green,
                                             Color.Purple,
                                             Color.Blue,
                                             Color.Empty,
                                             Color.Empty,
                                             Color.Empty,
                                             Color.Empty,
                                             'D',
                                             bomb,
                                             io);

            Assert.AreEqual("Gray, Blue, Blue, Yellow", module.Solve(true));
        }

        public void TestMethod47()
        {
            ColorMath module = new ColorMath(Color.Purple,
                                             Color.Magenta,
                                             Color.Yellow,
                                             Color.Green,
                                             Color.Orange,
                                             Color.Green,
                                             Color.Yellow,
                                             Color.Green,
                                             'D',
                                             bomb,
                                             io);

            Assert.AreEqual("Orange, Blue, Gray, Purple", module.Solve(false));
        }

        public void TestMethod48()
        {
            ColorMath module = new ColorMath(Color.Black,
                                             Color.Purple,
                                             Color.Orange,
                                             Color.Blue,
                                             Color.Gray,
                                             Color.Red,
                                             Color.Orange,
                                             Color.Yellow,
                                             'D',
                                             bomb,
                                             io);

            Assert.AreEqual("Red, Purple, Purple, Magenta", module.Solve(false));
        }

        public void TestMethod49()
        {
            ColorMath module = new ColorMath(Color.Gray,
                                             Color.Yellow,
                                             Color.White,
                                             Color.Blue,
                                             Color.Empty,
                                             Color.Empty,
                                             Color.Empty,
                                             Color.Empty,
                                             'D',
                                             bomb,
                                             io);

            Assert.AreEqual("White, Black, Purple, Red", module.Solve(true));
        }

        public void TestMethod5()
        {
            ColorMath module = new ColorMath(Color.Green,
                                             Color.Yellow,
                                             Color.Green,
                                             Color.Yellow,
                                             Color.Empty,
                                             Color.Empty,
                                             Color.Empty,
                                             Color.Empty,
                                             'D',
                                             bomb,
                                             io);

            Assert.AreEqual("Green, Red, Red, Green", module.Solve(true));
        }

        public void TestMethod50()
        {
            ColorMath module = new ColorMath(Color.Green,
                                             Color.Red,
                                             Color.Yellow,
                                             Color.Magenta,
                                             Color.Red,
                                             Color.Magenta,
                                             Color.Black,
                                             Color.Gray,
                                             'D',
                                             bomb,
                                             io);

            Assert.AreEqual("Yellow, Black, Gray, Yellow", module.Solve(false));
        }

        public void TestMethod51()
        {
            ColorMath module = new ColorMath(Color.Blue,
                                             Color.Blue,
                                             Color.Magenta,
                                             Color.Orange,
                                             Color.Purple,
                                             Color.Black,
                                             Color.Blue,
                                             Color.Black,
                                             'D',
                                             bomb,
                                             io);

            Assert.AreEqual("Orange, Magenta, Purple, Red", module.Solve(false));
        }

        public void TestMethod52()
        {
            ColorMath module = new ColorMath(Color.Yellow,
                                             Color.Orange,
                                             Color.Blue,
                                             Color.Gray,
                                             Color.Magenta,
                                             Color.Yellow,
                                             Color.Red,
                                             Color.Black,
                                             'D',
                                             bomb,
                                             io);

            Assert.AreEqual("Orange, Red, Black, Gray", module.Solve(false));
        }

        public void TestMethod53()
        {
            ColorMath module = new ColorMath(Color.Blue,
                                             Color.Green,
                                             Color.White,
                                             Color.Yellow,
                                             Color.Green,
                                             Color.Yellow,
                                             Color.Black,
                                             Color.Yellow,
                                             'D',
                                             bomb,
                                             io);

            Assert.AreEqual("Gray, Blue, Orange, Black", module.Solve(false));
        }

        public void TestMethod54()
        {
            ColorMath module = new ColorMath(Color.Gray,
                                             Color.Purple,
                                             Color.Orange,
                                             Color.Blue,
                                             Color.Empty,
                                             Color.Empty,
                                             Color.Empty,
                                             Color.Empty,
                                             'D',
                                             bomb,
                                             io);

            Assert.AreEqual("Gray, Blue, Blue, White", module.Solve(true));
        }

        public void TestMethod55()
        {
            ColorMath module = new ColorMath(Color.Blue,
                                             Color.White,
                                             Color.Green,
                                             Color.Purple,
                                             Color.Empty,
                                             Color.Empty,
                                             Color.Empty,
                                             Color.Empty,
                                             'D',
                                             bomb,
                                             io);

            Assert.AreEqual("Gray, Blue, Red, Orange", module.Solve(true));
        }

        public void TestMethod56()
        {
            ColorMath module = new ColorMath(Color.Black,
                                             Color.Orange,
                                             Color.White,
                                             Color.Gray,
                                             Color.White,
                                             Color.Black,
                                             Color.Black,
                                             Color.Blue,
                                             'D',
                                             bomb,
                                             io);

            Assert.AreEqual("White, Orange, Orange, Magenta", module.Solve(true));
        }

        public void TestMethod57()
        {
            ColorMath module = new ColorMath(Color.Red,
                                             Color.Yellow,
                                             Color.Magenta,
                                             Color.Red,
                                             Color.Empty,
                                             Color.Empty,
                                             Color.Empty,
                                             Color.Empty,
                                             'D',
                                             bomb,
                                             io);

            Assert.AreEqual("Gray, Blue, Green, Red", module.Solve(true));
        }

        public void TestMethod58()
        {
            ColorMath module = new ColorMath(Color.Red,
                                             Color.Purple,
                                             Color.Orange,
                                             Color.White,
                                             Color.Empty,
                                             Color.Empty,
                                             Color.Empty,
                                             Color.Empty,
                                             'D',
                                             bomb,
                                             io);

            Assert.AreEqual("Yellow, Orange, Magenta, Blue", module.Solve(true));
        }

        public void TestMethod59()
        {
            ColorMath module = new ColorMath(Color.White,
                                             Color.Orange,
                                             Color.Magenta,
                                             Color.Magenta,
                                             Color.Empty,
                                             Color.Empty,
                                             Color.Empty,
                                             Color.Empty,
                                             'D',
                                             bomb,
                                             io);

            Assert.AreEqual("Red, Purple, White, Black", module.Solve(true));
        }

        public void TestMethod6()
        {
            ColorMath module = new ColorMath(Color.Red,
                                             Color.White,
                                             Color.Black,
                                             Color.Red,
                                             Color.Empty,
                                             Color.Empty,
                                             Color.Empty,
                                             Color.Empty,
                                             'D',
                                             bomb,
                                             io);

            Assert.AreEqual("Yellow, Magenta, White, Yellow", module.Solve(true));
        }

        public void TestMethod60()
        {
            ColorMath module = new ColorMath(Color.Orange,
                                             Color.Purple,
                                             Color.Orange,
                                             Color.Purple,
                                             Color.Empty,
                                             Color.Empty,
                                             Color.Empty,
                                             Color.Empty,
                                             'D',
                                             bomb,
                                             io);

            Assert.AreEqual("Red, Gray, Blue, Blue", module.Solve(false));
        }

        public void TestMethod61()
        {
            ColorMath module = new ColorMath(Color.Green,
                                             Color.Gray,
                                             Color.Gray,
                                             Color.White,
                                             Color.Magenta,
                                             Color.Red,
                                             Color.Blue,
                                             Color.Orange,
                                             'D',
                                             bomb,
                                             io);

            Assert.AreEqual("Gray, Blue, Magenta, Gray", module.Solve(false));
        }

        public void TestMethod62()
        {
            ColorMath module = new ColorMath(Color.Yellow,
                                             Color.Yellow,
                                             Color.Magenta,
                                             Color.Yellow,
                                             Color.Yellow,
                                             Color.Yellow,
                                             Color.Black,
                                             Color.Purple,
                                             'D',
                                             bomb,
                                             io);

            Assert.AreEqual("Yellow, Magenta, Gray, Orange", module.Solve(false));
        }

        public void TestMethod63()
        {
            ColorMath module = new ColorMath(Color.White,
                                             Color.White,
                                             Color.White,
                                             Color.Purple,
                                             Color.Green,
                                             Color.Red,
                                             Color.Purple,
                                             Color.Blue,
                                             'D',
                                             bomb,
                                             io);

            Assert.AreEqual("Blue, Yellow, Purple, Purple", module.Solve(false));
        }

        public void TestMethod64()
        {
            ColorMath module = new ColorMath(Color.Blue,
                                             Color.White,
                                             Color.Green,
                                             Color.Yellow,
                                             Color.Empty,
                                             Color.Empty,
                                             Color.Empty,
                                             Color.Empty,
                                             'D',
                                             bomb,
                                             io);

            Assert.AreEqual("Red ,Orange, White, Magenta", module.Solve(true));
        }

        public void TestMethod65()
        {
            ColorMath module = new ColorMath(Color.Purple,
                                             Color.Purple,
                                             Color.Orange,
                                             Color.White,
                                             Color.Empty,
                                             Color.Empty,
                                             Color.Empty,
                                             Color.Empty,
                                             'D',
                                             bomb,
                                             io);

            Assert.AreEqual("Orange, Orange, Magenta, Blue", module.Solve());
        }

        public void TestMethod66()
        {
            ColorMath module = new ColorMath(Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             'D',
                                             bomb,
                                             io);

            Assert.AreEqual("", module.Solve());
        }

        public void TestMethod67()
        {
            ColorMath module = new ColorMath(Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             'D',
                                             bomb,
                                             io);

            Assert.AreEqual("", module.Solve());
        }

        public void TestMethod68()
        {
            ColorMath module = new ColorMath(Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             'D',
                                             bomb,
                                             io);

            Assert.AreEqual("", module.Solve());
        }

        public void TestMethod69()
        {
            ColorMath module = new ColorMath(Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             'D',
                                             bomb,
                                             io);

            Assert.AreEqual("", module.Solve());
        }

        public void TestMethod7()
        {
            ColorMath module = new ColorMath(Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             'D',
                                             bomb,
                                             io);

            Assert.AreEqual("", module.Solve());
        }

        public void TestMethod70()
        {
            ColorMath module = new ColorMath(Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             'D',
                                             bomb,
                                             io);

            Assert.AreEqual("", module.Solve());
        }

        public void TestMethod71()
        {
            ColorMath module = new ColorMath(Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             'D',
                                             bomb,
                                             io);

            Assert.AreEqual("", module.Solve());
        }

        public void TestMethod72()
        {
            ColorMath module = new ColorMath(Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             'D',
                                             bomb,
                                             io);

            Assert.AreEqual("", module.Solve());
        }

        public void TestMethod73()
        {
            ColorMath module = new ColorMath(Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             'D',
                                             bomb,
                                             io);

            Assert.AreEqual("", module.Solve());
        }

        public void TestMethod74()
        {
            ColorMath module = new ColorMath(Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             'D',
                                             bomb,
                                             io);

            Assert.AreEqual("", module.Solve());
        }

        public void TestMethod75()
        {
            ColorMath module = new ColorMath(Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             'D',
                                             bomb,
                                             io);

            Assert.AreEqual("", module.Solve());
        }

        public void TestMethod76()
        {
            ColorMath module = new ColorMath(Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             'D',
                                             bomb,
                                             io);

            Assert.AreEqual("", module.Solve());
        }

        public void TestMethod77()
        {
            ColorMath module = new ColorMath(Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             'D',
                                             bomb,
                                             io);

            Assert.AreEqual("", module.Solve());
        }

        public void TestMethod78()
        {
            ColorMath module = new ColorMath(Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             'D',
                                             bomb,
                                             io);

            Assert.AreEqual("", module.Solve());
        }

        public void TestMethod79()
        {
            ColorMath module = new ColorMath(Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             'D',
                                             bomb,
                                             io);

            Assert.AreEqual("", module.Solve());
        }

        public void TestMethod8()
        {
            ColorMath module = new ColorMath(Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             'D',
                                             bomb,
                                             io);

            Assert.AreEqual("", module.Solve());
        }

        public void TestMethod80()
        {
            ColorMath module = new ColorMath(Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             'D',
                                             bomb,
                                             io);

            Assert.AreEqual("", module.Solve());
        }

        public void TestMethod81()
        {
            ColorMath module = new ColorMath(Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             'D',
                                             bomb,
                                             io);

            Assert.AreEqual("", module.Solve());
        }

        public void TestMethod82()
        {
            ColorMath module = new ColorMath(Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             'D',
                                             bomb,
                                             io);

            Assert.AreEqual("", module.Solve());
        }

        public void TestMethod83()
        {
            ColorMath module = new ColorMath(Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             'D',
                                             bomb,
                                             io);

            Assert.AreEqual("", module.Solve());
        }

        public void TestMethod84()
        {
            ColorMath module = new ColorMath(Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             'D',
                                             bomb,
                                             io);

            Assert.AreEqual("", module.Solve());
        }

        public void TestMethod85()
        {
            ColorMath module = new ColorMath(Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             'D',
                                             bomb,
                                             io);

            Assert.AreEqual("", module.Solve());
        }

        public void TestMethod86()
        {
            ColorMath module = new ColorMath(Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             'D',
                                             bomb,
                                             io);

            Assert.AreEqual("", module.Solve());
        }

        public void TestMethod87()
        {
            ColorMath module = new ColorMath(Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             'D',
                                             bomb,
                                             io);

            Assert.AreEqual("", module.Solve());
        }

        public void TestMethod88()
        {
            ColorMath module = new ColorMath(Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             'D',
                                             bomb,
                                             io);

            Assert.AreEqual("", module.Solve());
        }

        public void TestMethod89()
        {
            ColorMath module = new ColorMath(Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             'D',
                                             bomb,
                                             io);

            Assert.AreEqual("", module.Solve());
        }

        public void TestMethod9()
        {
            ColorMath module = new ColorMath(Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             'D',
                                             bomb,
                                             io);

            Assert.AreEqual("", module.Solve());
        }

        public void TestMethod90()
        {
            ColorMath module = new ColorMath(Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             'D',
                                             bomb,
                                             io);

            Assert.AreEqual("", module.Solve());
        }

        public void TestMethod91()
        {
            ColorMath module = new ColorMath(Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             'D',
                                             bomb,
                                             io);

            Assert.AreEqual("", module.Solve());
        }

        public void TestMethod92()
        {
            ColorMath module = new ColorMath(Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             'D',
                                             bomb,
                                             io);

            Assert.AreEqual("", module.Solve());
        }

        public void TestMethod93()
        {
            ColorMath module = new ColorMath(Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             'D',
                                             bomb,
                                             io);

            Assert.AreEqual("", module.Solve());
        }

        public void TestMethod94()
        {
            ColorMath module = new ColorMath(Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             'D',
                                             bomb,
                                             io);

            Assert.AreEqual("", module.Solve());
        }

        public void TestMethod95()
        {
            ColorMath module = new ColorMath(Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             'D',
                                             bomb,
                                             io);

            Assert.AreEqual("", module.Solve());
        }

        public void TestMethod96()
        {
            ColorMath module = new ColorMath(Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             'D',
                                             bomb,
                                             io);

            Assert.AreEqual("", module.Solve());
        }

        public void TestMethod97()
        {
            ColorMath module = new ColorMath(Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             'D',
                                             bomb,
                                             io);

            Assert.AreEqual("", module.Solve());
        }

        public void TestMethod98()
        {
            ColorMath module = new ColorMath(Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             'D',
                                             bomb,
                                             io);

            Assert.AreEqual("", module.Solve());
        }

        public void TestMethod99()
        {
            ColorMath module = new ColorMath(Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             Color.,
                                             'D',
                                             bomb,
                                             io);

            Assert.AreEqual("", module.Solve());
        }

        protected void SetBombFile(int index)
        {
            modules[index - 1].LogFileWriter = io;
            modules[index - 1].Bomb = bomb;

        }

    }
}
