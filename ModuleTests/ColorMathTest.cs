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

        ColorMath module;

        List<ColorMath> modules = new List<ColorMath>()
        {
            //1
            new ColorMath(new Color[] { Color.Yellow, Color.Green, Color.Magenta, Color.Magenta },
                          new Color[] { Color.Black, Color.Magenta, Color.Red, Color.Blue },
                          'M', null, null),
            //2
            new ColorMath(new Color [] { Color.Orange, Color.Gray, Color.Red, Color.Black },
                          new Color[] { Color.Green, Color.Black, Color.Orange, Color.Blue },
                          'M', null, null),

            //10
            new ColorMath(new Color[] { Color.Purple, Color.Purple, Color.Yellow, Color.White } ,
                          new Color [] { Color.White, Color.Red, Color.Gray, Color.White } ,
                          'D', null, null),

            //11
            new ColorMath(new Color [] {Color.Magenta, Color.Red, Color.Green, Color.Gray },
                                             null,
                                             'A',
                                             null,
                                             null),

            //12
            new ColorMath(new Color[] { Color.Red, Color.White, Color.Gray, Color.Purple },
                                        null,
                                        'A',
                                        null,
                                        null),

            //13
            new ColorMath(new Color[] { Color.Blue, Color.Green, Color.Gray, Color.Orange },
                          null,
                          'S',
                          null,
                          null),
            //14
            new ColorMath(new Color[] { Color.Blue, Color.White, Color.Purple, Color.Gray } ,
                          null,
                          'M',
                          null,
                          null),

            //15
            new ColorMath(new Color [] { Color.Purple, Color.Black, Color.White, Color.Orange } ,
                          null,
                          'M',
                          null,
                          null),
            //16
            new ColorMath(new Color [] { Color.Purple, Color.Red, Color.Gray, Color.White },
                        null,
                        'S',
                        null,
                        null),

            //17
            new ColorMath(new Color [] { Color.Magenta, Color.Red, Color.Black, Color.Black },
                          new Color[] { Color.Orange, Color.Yellow, Color.Green, Color.White } ,
                          'D',
                          null,
                          null),

            //18
            new ColorMath(new Color [] { Color.Green, Color.Green, Color.Magenta, Color.Black },
                          null,
                          'S',
                          null,
                          null),

            //19
            new ColorMath(new Color [] { Color.Magenta, Color.Blue, Color.Red, Color.Gray },
                          new Color [] { Color.Blue, Color.Red, Color.Orange, Color.Blue },
                          'S',
                          null,
                          null),

            //20
            new ColorMath(new Color [] { Color.Black, Color.Green, Color.Red, Color.Magenta } ,
                                         null, 'D', null, null),
            //21
            new ColorMath(new Color [] {Color.Yellow, Color.Blue, Color.Orange, Color.Green },
                          new Color [] { Color.Magenta, Color.Gray, Color.Purple, Color.Yellow },
                                        'S', null, null),
            //22
            new ColorMath(new Color[] { Color.White, Color.Green, Color.Orange, Color.Yellow } ,
                          null, 'S', null, null),
            //23
            new ColorMath(new Color [] { Color.Black, Color.Yellow, Color.Blue, Color.Orange } ,
                          null, 'M', null, null),

            //24
            new ColorMath(new Color [] { Color.Green, Color.Black, Color.Orange, Color.Blue },
                           new Color[] { Color.Gray, Color.Red, Color.Yellow, Color.Yellow },
                           'A', null, null),

            //25
            new ColorMath(new Color [] { Color.Blue, Color.Purple, Color.Gray, Color.Green },
                          new Color [] {Color.Magenta, Color.Green, Color.Red, Color.Magenta },
                          'D', null, null),

        //100
        new ColorMath(new Color[] { Color.Purple, Color.Purple, Color.Yellow, Color.White },
                              null,
                              'S',
                              null,
                              null),




    };


        [TestMethod]
        public void TestMethod1()
        {
            module = SetBombFile(1);
            Assert.AreEqual("Yellow, White, Black, Magenta", module.Solve(module.rightColors == null));
            io.Close();
        }

        [TestMethod]
        public void TestMethod10()
        {
            module = SetBombFile(10);
            Assert.AreEqual("Gray, Blue, Magenta, Gray", module.Solve(module.rightColors == null));
            io.Close();

        }

        [TestMethod]
        public void TestMethod100()
        {
            module = SetBombFile(100);
            Assert.AreEqual("Gray, Blue, Magenta, Gray", module.Solve(module.rightColors == null));
            io.Close();
        }

        public void TestMethod11()
        {
            module = SetBombFile(11);
            Assert.AreEqual("Gray, Green, Red, Red", module.Solve(module.rightColors == null));
            io.Close();
        }

        public void TestMethod12()
        {
            module = SetBombFile(12);
            Assert.AreEqual("Yellow, Red, Blue, Gray", module.Solve(module.rightColors == null));
            io.Close();
        }

        public void TestMethod13()
        {
            module = SetBombFile(13);

            Assert.AreEqual("Magenta, Gray, Magenta, Magenta", module.Solve(module.rightColors == null));
            io.Close();
        }

        public void TestMethod14()
        {
            module = SetBombFile(14);

            Assert.AreEqual("Yellow, Orange, Orange, Gray", module.Solve(module.rightColors == null));
            io.Close();
        }

        public void TestMethod15()
        {
            module = SetBombFile(15);

            Assert.AreEqual("Orange, White, White, White", module.Solve(module.rightColors == null));
            io.Close();
        }

        public void TestMethod16()
        {
            module = SetBombFile(16);

            Assert.AreEqual("Green, White, Black, Blue", module.Solve(module.rightColors == null));
            io.Close();
        }

        public void TestMethod17()
        {
            module = SetBombFile(17);

            Assert.AreEqual("Gray, Blue, Magenta, Gray", module.Solve(module.rightColors == null));
            io.Close();
        }

        public void TestMethod18()
        {
            module = SetBombFile(18);

            Assert.AreEqual("Gray, White, Orange, White", module.Solve(module.rightColors == null));
            io.Close();
        }

        public void TestMethod19()
        {
            module = SetBombFile(19); 

            Assert.AreEqual("Gray, Magenta, Yellow, Magenta", module.Solve(module.rightColors == null));
        }

        public void TestMethod2()
        {
            module = SetBombFile(2);

            Assert.AreEqual("Purple, Red, Blue, Gray", module.Solve(module.rightColors == null));
        }

        public void TestMethod20()
        {
            module = SetBombFile(20);

            Assert.AreEqual("Gray, Blue, Black, Red", module.Solve(module.rightColors == null));
            io.Close();
        }

        public void TestMethod21()
        {
            module = SetBombFile(21);

            Assert.AreEqual("Orange, Purple, Gray, Blue", module.Solve(module.rightColors == null));
        }

        public void TestMethod22()
        {
            module = SetBombFile(22);

            Assert.AreEqual("", module.Solve(module.rightColors == null));
        }

        public void TestMethod23()
        {
            module = SetBombFile(23);

            Assert.AreEqual("Red, White, Yellow, White", module.Solve(module.rightColors == null));
        }

        public void TestMethod24()
        {
            module = SetBombFile(24);

            Assert.AreEqual("Orange, Gray, Orange, Magenta", module.Solve(module.rightColors == null));
            io.Close();
        }

        public void TestMethod25()
        {
            module = SetBombFile(25);

            Assert.AreEqual("Green, Blue, Magenta, Green", module.Solve(module.rightColors == null));
            io.Close();
        }

        public void TestMethod26()
        {
            ColorMath modules[] = new ColorMath(Color.Black,
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

            Assert.AreEqual("Green, White, Magenta, Yellow", modules[].Solve(false));
        }

        public void TestMethod27()
        {
            ColorMath modules[] = new ColorMath(Color.Yellow,
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

            Assert.AreEqual("Gray, Blue, Magenta, Gray", modules[].Solve(false));
        }

        public void TestMethod28()
        {
            ColorMath modules[] = new ColorMath(Color.Blue,
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

            Assert.AreEqual("Gray, Blue, Black, Blue", modules[].Solve(true));
        }

        public void TestMethod29()
        {
            ColorMath modules[] = new ColorMath(Color.Magenta,
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

            Assert.AreEqual("Gray, Blue, Magenta, Red", modules[].Solve(true));
        }

        public void TestMethod3()
        {
            ColorMath modules[] = new ColorMath(Color.Gray,
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

            Assert.AreEqual("Gray, Blue, Magenta, Gray", modules[].Solve(false));
        }

        public void TestMethod30()
        {
            ColorMath modules[] = new ColorMath(Color.Blue,
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

            Assert.AreEqual("White, Magenta, White, Red", modules[].Solve(false));
        }

        public void TestMethod31()
        {
            ColorMath modules[] = new ColorMath(Color.Red,
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

            Assert.AreEqual("Yellow, Yellow, Blue, Gray", modules[].Solve(false));
        }

        public void TestMethod32()
        {
            ColorMath modules[] = new ColorMath(Color.Black,
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

            Assert.AreEqual("", modules[].Solve(true));
        }

        public void TestMethod33()
        {
            ColorMath modules[] = new ColorMath(Color.Yellow,
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

            Assert.AreEqual("Gray, Blue, Gray, Gray", modules[].Solve(true));
        }

        public void TestMethod34()
        {
            ColorMath modules[] = new ColorMath(Color.Green,
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

            Assert.AreEqual("Green, Black, Purple, Yellow", modules[].Solve(true));
        }

        public void TestMethod35()
        {
            ColorMath modules[] = new ColorMath(Color.Purple,
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

            Assert.AreEqual("Purple, Red, Black, Red", modules[].Solve(true));
        }

        public void TestMethod36()
        {
            ColorMath modules[] = new ColorMath(Color.Magenta,
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

            Assert.AreEqual("White, Yellow, White, Purple", modules[].Solve(false));
        }

        public void TestMethod37()
        {
            ColorMath modules[] = new ColorMath(Color.Black,
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

            Assert.AreEqual("Gray, Blue, Magenta, Blue", modules[].Solve(false));
        }

        public void TestMethod38()
        {
            ColorMath modules[] = new ColorMath(Color.Yellow,
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

            Assert.AreEqual("Green, White, Magenta, Purple", modules[].Solve(false));
        }

        public void TestMethod39()
        {
            ColorMath modules[] = new ColorMath(
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

            Assert.AreEqual("Gray, Blue, Magenta, Orange", modules[].Solve(false));
        }

        public void TestMethod4()
        {
            ColorMath modules[] = new ColorMath(Color.Green,
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

            Assert.AreEqual("Gray, Blue, Magenta, Gray", modules[].Solve(false));
        }

        public void TestMethod40()
        {
            ColorMath modules[] = new ColorMath(Color.Orange,
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

            Assert.AreEqual("Black, Orange, Gray, Yellow", modules[].Solve(true));
        }

        public void TestMethod41()
        {
            ColorMath modules[] = new ColorMath(Color.Blue,
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

            Assert.AreEqual("Magenta, Black, Gray, Red", modules[].Solve(true));
        }

        public void TestMethod42()
        {
            ColorMath modules[] = new ColorMath(Color.Green,
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

            Assert.AreEqual("Gray, Blue, Magenta, Gray", modules[].Solve(false));
        }

        public void TestMethod43()
        {
            ColorMath modules[] = new ColorMath(Color.Green,
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

            Assert.AreEqual("Green, Black, Magenta, White", modules[].Solve(true));
        }

        public void TestMethod44()
        {
            ColorMath modules[] = new ColorMath(Color.Black,
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

            Assert.AreEqual("Black, Blue, Blue, Black", modules[].Solve(true));
        }

        public void TestMethod45()
        {
            ColorMath modules[] = new ColorMath(Color.White,
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

            Assert.AreEqual("Blue, Red, Purple, White", modules[].Solve(false));
        }

        public void TestMethod46()
        {
            ColorMath modules[] = new ColorMath(Color.Gray,
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

            Assert.AreEqual("Gray, Blue, Blue, Yellow", modules[].Solve(true));
        }

        public void TestMethod47()
        {
            ColorMath modules[] = new ColorMath(Color.Purple,
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

            Assert.AreEqual("Orange, Blue, Gray, Purple", modules[].Solve(false));
        }

        public void TestMethod48()
        {
            ColorMath modules[] = new ColorMath(Color.Black,
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

            Assert.AreEqual("Red, Purple, Purple, Magenta", modules[].Solve(false));
        }

        public void TestMethod49()
        {
            ColorMath modules[] = new ColorMath(Color.Gray,
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

            Assert.AreEqual("White, Black, Purple, Red", modules[].Solve(true));
        }

        public void TestMethod5()
        {
            ColorMath modules[] = new ColorMath(Color.Green,
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

            Assert.AreEqual("Green, Red, Red, Green", modules[].Solve(true));
        }

        public void TestMethod50()
        {
            ColorMath modules[] = new ColorMath(Color.Green,
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

            Assert.AreEqual("Yellow, Black, Gray, Yellow", modules[].Solve(false));
        }

        public void TestMethod51()
        {
            ColorMath modules[] = new ColorMath(Color.Blue,
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

            Assert.AreEqual("Orange, Magenta, Purple, Red", modules[].Solve(false));
        }

        public void TestMethod52()
        {
            ColorMath modules[] = new ColorMath(Color.Yellow,
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

            Assert.AreEqual("Orange, Red, Black, Gray", modules[].Solve(false));
        }

        public void TestMethod53()
        {
            ColorMath modules[] = new ColorMath(Color.Blue,
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

            Assert.AreEqual("Gray, Blue, Orange, Black", modules[].Solve(false));
        }

        public void TestMethod54()
        {
            ColorMath modules[] = new ColorMath(Color.Gray,
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

            Assert.AreEqual("Gray, Blue, Blue, White", modules[].Solve(true));
        }

        public void TestMethod55()
        {
            ColorMath modules[] = new ColorMath(Color.Blue,
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

            Assert.AreEqual("Gray, Blue, Red, Orange", modules[].Solve(true));
        }

        public void TestMethod56()
        {
            ColorMath modules[] = new ColorMath(Color.Black,
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

            Assert.AreEqual("White, Orange, Orange, Magenta", modules[].Solve(true));
        }

        public void TestMethod57()
        {
            ColorMath modules[] = new ColorMath(Color.Red,
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

            Assert.AreEqual("Gray, Blue, Green, Red", modules[].Solve(true));
        }

        public void TestMethod58()
        {
            ColorMath modules[] = new ColorMath(Color.Red,
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

            Assert.AreEqual("Yellow, Orange, Magenta, Blue", modules[].Solve(true));
        }

        public void TestMethod59()
        {
            ColorMath modules[] = new ColorMath(Color.White,
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

            Assert.AreEqual("Red, Purple, White, Black", modules[].Solve(true));
        }

        public void TestMethod6()
        {
            ColorMath modules[] = new ColorMath(Color.Red,
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

            Assert.AreEqual("Yellow, Magenta, White, Yellow", modules[].Solve(true));
        }

        public void TestMethod60()
        {
            ColorMath modules[] = new ColorMath(Color.Orange,
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

            Assert.AreEqual("Red, Gray, Blue, Blue", modules[].Solve(false));
        }

        public void TestMethod61()
        {
            ColorMath modules[] = new ColorMath(Color.Green,
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

            Assert.AreEqual("Gray, Blue, Magenta, Gray", modules[].Solve(false));
        }

        public void TestMethod62()
        {
            ColorMath modules[] = new ColorMath(Color.Yellow,
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

            Assert.AreEqual("Yellow, Magenta, Gray, Orange", modules[].Solve(false));
        }

        public void TestMethod63()
        {
            ColorMath modules[] = new ColorMath(Color.White,
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

            Assert.AreEqual("Blue, Yellow, Purple, Purple", modules[].Solve(false));
        }

        public void TestMethod64()
        {
            ColorMath modules[] = new ColorMath(Color.Blue,
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

            Assert.AreEqual("Red ,Orange, White, Magenta", modules[].Solve(true));
        }

        public void TestMethod65()
        {
            ColorMath modules[] = new ColorMath(Color.Purple,
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

            Assert.AreEqual("Orange, Orange, Magenta, Blue", modules[].Solve());
        }

        public void TestMethod66()
        {
            ColorMath modules[] = new ColorMath(Color.,
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

            Assert.AreEqual("", modules[].Solve());
        }

        public void TestMethod67()
        {
            ColorMath modules[] = new ColorMath(Color.,
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

            Assert.AreEqual("", modules[].Solve());
        }

        public void TestMethod68()
        {
            ColorMath modules[] = new ColorMath(Color.,
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

            Assert.AreEqual("", modules[].Solve());
        }

        public void TestMethod69()
        {
            ColorMath modules[] = new ColorMath(Color.,
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

            Assert.AreEqual("", modules[].Solve());
        }

        public void TestMethod7()
        {
            ColorMath modules[] = new ColorMath(Color.,
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

            Assert.AreEqual("", modules[].Solve());
        }

        public void TestMethod70()
        {
            ColorMath modules[] = new ColorMath(Color.,
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

            Assert.AreEqual("", modules[].Solve());
        }

        public void TestMethod71()
        {
            ColorMath modules[] = new ColorMath(Color.,
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

            Assert.AreEqual("", modules[].Solve());
        }

        public void TestMethod72()
        {
            ColorMath modules[] = new ColorMath(Color.,
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

            Assert.AreEqual("", modules[].Solve());
        }

        public void TestMethod73()
        {
            ColorMath modules[] = new ColorMath(Color.,
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

            Assert.AreEqual("", modules[].Solve());
        }

        public void TestMethod74()
        {
            ColorMath modules[] = new ColorMath(Color.,
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

            Assert.AreEqual("", modules[].Solve());
        }

        public void TestMethod75()
        {
            ColorMath modules[] = new ColorMath(Color.,
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

            Assert.AreEqual("", modules[].Solve());
        }

        public void TestMethod76()
        {
            ColorMath modules[] = new ColorMath(Color.,
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

            Assert.AreEqual("", modules[].Solve());
        }

        public void TestMethod77()
        {
            ColorMath modules[] = new ColorMath(Color.,
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

            Assert.AreEqual("", modules[].Solve());
        }

        public void TestMethod78()
        {
            ColorMath modules[] = new ColorMath(Color.,
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

            Assert.AreEqual("", modules[].Solve());
        }

        public void TestMethod79()
        {
            ColorMath modules[] = new ColorMath(Color.,
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

            Assert.AreEqual("", modules[].Solve());
        }

        public void TestMethod8()
        {
            ColorMath modules[] = new ColorMath(Color.,
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

            Assert.AreEqual("", modules[].Solve());
        }

        public void TestMethod80()
        {
            ColorMath modules[] = new ColorMath(Color.,
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

            Assert.AreEqual("", modules[].Solve());
        }

        public void TestMethod81()
        {
            ColorMath modules[] = new ColorMath(Color.,
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

            Assert.AreEqual("", modules[].Solve());
        }

        public void TestMethod82()
        {
            ColorMath modules[] = new ColorMath(Color.,
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

            Assert.AreEqual("", modules[].Solve());
        }

        public void TestMethod83()
        {
            ColorMath modules[] = new ColorMath(Color.,
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

            Assert.AreEqual("", modules[].Solve());
        }

        public void TestMethod84()
        {
            ColorMath modules[] = new ColorMath(Color.,
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

            Assert.AreEqual("", modules[].Solve());
        }

        public void TestMethod85()
        {
            ColorMath modules[] = new ColorMath(Color.,
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

            Assert.AreEqual("", modules[].Solve());
        }

        public void TestMethod86()
        {
            ColorMath modules[] = new ColorMath(Color.,
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

            Assert.AreEqual("", modules[].Solve());
        }

        public void TestMethod87()
        {
            ColorMath modules[] = new ColorMath(Color.,
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

            Assert.AreEqual("", modules[].Solve());
        }

        public void TestMethod88()
        {
            ColorMath modules[] = new ColorMath(Color.,
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

            Assert.AreEqual("", modules[].Solve());
        }

        public void TestMethod89()
        {
            ColorMath modules[] = new ColorMath(Color.,
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

            Assert.AreEqual("", modules[].Solve());
        }

        public void TestMethod9()
        {
            ColorMath modules[] = new ColorMath(Color.,
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

            Assert.AreEqual("", modules[].Solve());
        }

        public void TestMethod90()
        {
            ColorMath modules[] = new ColorMath(Color.,
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

            Assert.AreEqual("", modules[].Solve());
        }

        public void TestMethod91()
        {
            ColorMath modules[] = new ColorMath(Color.,
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

            Assert.AreEqual("", modules[].Solve());
        }

        public void TestMethod92()
        {
            ColorMath modules[] = new ColorMath(Color.,
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

            Assert.AreEqual("", modules[].Solve());
        }

        public void TestMethod93()
        {
            ColorMath modules[] = new ColorMath(Color.,
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

            Assert.AreEqual("", modules[].Solve());
        }

        public void TestMethod94()
        {
            ColorMath modules[] = new ColorMath(Color.,
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

            Assert.AreEqual("", modules[].Solve());
        }

        public void TestMethod95()
        {
            ColorMath modules[] = new ColorMath(Color.,
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

            Assert.AreEqual("", modules[].Solve());
        }

        public void TestMethod96()
        {
            ColorMath modules[] = new ColorMath(Color.,
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

            Assert.AreEqual("", modules[].Solve());
        }

        public void TestMethod97()
        {
            ColorMath modules[] = new ColorMath(Color.,
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

            Assert.AreEqual("", modules[].Solve());
        }

        public void TestMethod98()
        {
            ColorMath modules[] = new ColorMath(Color.,
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

            Assert.AreEqual("", modules[].Solve());
        }

        public void TestMethod99()
        {
            ColorMath modules[] = new ColorMath(Color.,
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

            Assert.AreEqual("", modules[].Solve());
        }

        protected ColorMath SetBombFile(int index)
        {
            modules[index - 1].LogFileWriter = io;
            modules[index - 1].Bomb = bomb;

            return modules[index - 1];

        }

    }
}
