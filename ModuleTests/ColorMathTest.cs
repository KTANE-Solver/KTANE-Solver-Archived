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

            //3
            new ColorMath(new Color []  { Color.Gray,
                                             Color.White,
                                             Color.Gray,
                                             Color.Magenta },
                                             new Color [] { Color.Green,
                                             Color.Orange,
                                             Color.Orange,
                                             Color.Yellow } ,
                                             'D',
                                             null,
                                             null),

            //4
            new ColorMath(new Color[] { Color.Green,
                                             Color.Blue,
                                             Color.Green,
                                             Color.Gray },
                                             new Color [] { Color.Black,
                                             Color.Green,
                                             Color.Black,
                                             Color.Purple },
                                             'D',
                                             null,
                                             null),
            //5
            new ColorMath(new Color [] { Color.Green,
                                             Color.Yellow,
                                             Color.Green,
                                             Color.Yellow },
                                             null,
                                             'A',
                                             null,
                                             null),

            //6
            new ColorMath(new Color [] { Color.Red,
                                             Color.White,
                                             Color.Black,
                                             Color.Red },
                                             null,
                                             'A',
                                             null,
                                             null),

            //7
                        new ColorMath(new Color [] { Color.Green,
                                             Color.Magenta,
                                             Color.Magenta,
                                             Color.Green },
                                             null,
                                             'S',
                                             null,
                                             null),
                        //8
                        new ColorMath(new Color [] { Color.Magenta,
                                             Color.Blue,
                                             Color.Purple,
                                             Color.Gray },
                                             null,
                                             'D',
                                             null,
                                             null),
                        //9
                         new ColorMath(new Color [] { Color.Gray,
                                             Color.Magenta,
                                             Color.Red,
                                             Color.Red },
                                             null,
                                             'D',
                                             null,
                                             null),

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
            new ColorMath(new Color[] { Color.Blue, Color.Gray, Color.Orange, Color.Green },
                          null,
                          'S',
                          null,
                          null),
            //14
            new ColorMath(new Color[] { Color.Blue, Color.White, Color.Purple, Color.Gray } ,
                          new Color[] { Color.Orange, Color.Green, Color.Red, Color.Purple } ,
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
                          'S', null, null),

            //26
            new ColorMath(new Color[] { Color.Black, Color.Green, Color.Orange, Color.Green },
                          new Color [] { Color.Yellow, Color.Orange, Color.Purple, Color.Magenta } ,
                                             'A', null, null),
            //27
            new ColorMath(new Color [] { Color.Yellow,
                                             Color.Black,
                                             Color.Purple,
                                             Color.Purple },
                                           new Color [] {  Color.Red,
                                             Color.White,
                                             Color.Red,
                                             Color.Red } ,
                                             'D',
                                             null,
                                             null),
            //28
            new ColorMath(new Color [] { Color.Blue,
                                             Color.Blue,
                                             Color.Gray,
                                             Color.White } ,
                                             null,
                                             'D',
                                             null,
                                             null),

            //29
            new ColorMath(new Color [] { Color.Magenta,
                                             Color.Orange,
                                             Color.Green,
                                             Color.White } ,
                                             null,
                                             'D',
                                             null,
                                             null),

            //30
            new ColorMath(new Color [] { Color.Blue,
                                             Color.Yellow,
                                             Color.Blue,
                                             Color.Red } ,
                                             new Color [] { Color.Gray,
                                             Color.Magenta,
                                             Color.Magenta,
                                             Color.Gray } ,
                                             'M',
                                             null,
                                             null),
            //31
            new ColorMath(new Color [] { Color.Red,
                                             Color.Red,
                                             Color.Red,
                                             Color.Red } ,
                                         new Color [] {   Color.Black,
                                             Color.Orange,
                                             Color.White,
                                             Color.Black } ,
                                             'M',
                                             null,
                                             null),

            //32
            new ColorMath(new Color [] { Color.Black,
                                             Color.Magenta,
                                             Color.Gray,
                                             Color.Green } ,
                                             null,
                                             'S',
                                             null,
                                             null),

            //33
            new ColorMath(new Color [] { Color.Yellow,
                                             Color.Green,
                                             Color.White,
                                             Color.Magenta },
                                            null,
                                             'D',
                                             null,
                                             null),
            //34
            new ColorMath(new Color [] { Color.Green,
                                             Color.Green,
                                             Color.Blue,
                                             Color.Red },
                                             null,
                                             'A',
                                             null,
                                             null),
            //35
            new ColorMath(new Color [] { Color.Purple,
                                             Color.Gray,
                                             Color.Blue,
                                             Color.Red } ,
                                             null,
                                             'M',
                                             null,
                                             null),
            //36
            new ColorMath(new Color [] { Color.Magenta,
                                             Color.Purple,
                                             Color.Blue,
                                             Color.Gray } ,
                                             new Color [] { Color.Yellow,
                                             Color.Orange,
                                             Color.Orange,
                                             Color.Purple } ,
                                             'S',
                                             null,
                                             null),

            //37
            new ColorMath(new Color [] { Color.Black,
                                             Color.Green,
                                             Color.Green,
                                             Color.Orange },
                                             new Color [] { Color.Yellow,
                                             Color.Yellow,
                                             Color.Orange,
                                             Color.Orange },
                                             'D',
                                             null,
                                             null),

            //38
            new ColorMath(new Color [] { Color.Yellow,
                                             Color.White,
                                             Color.Gray,
                                             Color.Purple },
                new Color [] {
                                             Color.Black,
                                             Color.Magenta,
                                             Color.Yellow,
                                             Color.Magenta },
                                             'M',
                                             null,
                                             null),

            //39
                         new ColorMath(
                        new Color[] { Color.Green,
                        Color.Red,
                        Color.Black,
                        Color.Black },
                    new Color [] { Color.Orange,
                        Color.Green,
                        Color.Yellow,
                        Color.Blue },
                        'A',
                        null,
                        null),

            //40
            new ColorMath(new Color [] { Color.Orange,
                                             Color.Magenta,
                                             Color.Purple,
                                             Color.Green },
                                             null,
                                             'M',
                                             null,
                                             null),

            //41
            new ColorMath(new Color [] { Color.Blue,
                                             Color.White,
                                             Color.Black,
                                             Color.Blue },
                                            null,
                                             'S',
                                             null,
                                             null),

            //42
            new ColorMath(new Color [] { Color.Green,
                                             Color.Green,
                                             Color.Purple,
                                             Color.Yellow },
                                             new Color [] {Color.Black,
                                             Color.Gray,
                                             Color.Black,
                                             Color.Green },
                                             'D',
                                             null,
                                             null),

            //43
            new ColorMath(new Color [] { Color.Green,
                                             Color.White,
                                             Color.Blue,
                                             Color.Black },
                                             null,
                                             'S',
                                             null,
                                             null),

            //44
            new ColorMath(new Color [] { Color.Black,
                                             Color.Green,
                                             Color.Red,
                                             Color.Magenta },
                                             null,
                                             'S',
                                             null,
                                             null),

            //45
            new ColorMath(new Color [] { Color.White,
                                             Color.Gray,
                                             Color.Purple,
                                             Color.Blue },
                                            new Color [] { Color.Yellow,
                                             Color.Blue,
                                             Color.Black,
                                             Color.Red },
                                             'S',
                                             null,
                                             null),

            //46
            new ColorMath(new Color [] { Color.Gray,
                                             Color.Green,
                                             Color.Purple,
                                             Color.Blue },
                null,
                                             'D',
                                             null,
                                             null),
            //47
            new ColorMath(new Color [] { Color.Purple,
                                             Color.Magenta,
                                             Color.Yellow,
                                             Color.Green },
                                            new Color [] { Color.Orange,
                                             Color.Green,
                                             Color.Yellow,
                                             Color.Green },
                                             'M',
                                             null,
                                             null),

            //48
            new ColorMath(new Color [] { Color.Black,
                                             Color.Purple,
                                             Color.Orange,
                                             Color.Blue } ,
                                             new Color [] { Color.Gray,
                                             Color.Red,
                                             Color.Orange,
                                             Color.Yellow },
                                             'A',
                                             null,
                                             null),
            //49
            new ColorMath(new Color [] { Color.Gray,
                                             Color.Yellow,
                                             Color.White,
                                             Color.Blue },
                                             null,
                                             'S',
                                             null,
                                             null),

            //50
            new ColorMath(new Color [] { Color.Green,
                                             Color.Red,
                                             Color.Yellow,
                                             Color.Magenta },
                                             new Color [] { Color.Red,
                                             Color.Magenta,
                                             Color.Black,
                                             Color.Gray },
                                             'S',
                                             null,
                                             null),

            //51
            new ColorMath(new Color [] { Color.Blue,
                                             Color.Blue,
                                             Color.Magenta,
                                             Color.Orange },
                                             new Color [] { Color.Purple,
                                             Color.Black,
                                             Color.Blue,
                                             Color.Black },
                                             'A',
                                             null,
                                             null),

            //52
            new ColorMath(new Color [] { Color.Yellow,
                                             Color.Orange,
                                             Color.Blue,
                                             Color.Gray },
                                             new Color [] { Color.Magenta,
                                             Color.Yellow,
                                             Color.Red,
                                             Color.Black },
                                             'S',
                                             null,
                                             null),

            //53
            new ColorMath(new Color [] { Color.Blue,
                                             Color.Green,
                                             Color.White,
                                             Color.Yellow },
                                             new Color [] { Color.Green,
                                             Color.Yellow,
                                             Color.Black,
                                             Color.Yellow },
                                             'S',
                                             null,
                                             null),

            //54
            new ColorMath(new Color [] {Color.Gray,
                                             Color.Purple,
                                             Color.Orange,
                                             Color.Blue } ,
                                             null,
                                             'D',
                                             null,
                                             null),

            //55
            new ColorMath(new Color [] { Color.Blue,
                                             Color.White,
                                             Color.Green,
                                             Color.Purple },
                                             null,
                                             'D',
                                             null,
                                             null),

            //56
            new ColorMath(new Color [] { Color.Black,
                                             Color.Orange,
                                             Color.White,
                                             Color.Gray },
                                             new Color [] { Color.White,
                                             Color.Black,
                                             Color.Black,
                                             Color.Blue },
                                             'S',
                                             null,
                                             null),

            //57
            new ColorMath(new Color [] { Color.Red,
                                             Color.Yellow,
                                             Color.Magenta,
                                             Color.Red },
                                             null,
                                             'D',
                                             null,
                                             null),

            //58
            new ColorMath(new Color [] { Color.Red,
                                             Color.Purple,
                                             Color.Orange,
                                             Color.White },
                                             null,
                                             'S',
                                             null,
                                             null),

            //59
            new ColorMath(new Color [] { Color.White,
                                             Color.Orange,
                                             Color.Magenta,
                                             Color.Magenta },
                                             null,
                                             'S',
                                             null,
                                             null),

            //60
            new ColorMath(new Color []{ Color.Orange,
                                             Color.Purple,
                                             Color.Orange,
                                             Color.Purple },
                                             null,
                                             'M',
                                             null,
                                             null),

            //61
            new ColorMath(new Color [] { Color.Green,
                                             Color.Gray,
                                             Color.Gray,
                                             Color.White },
                                             new Color[] { Color.Magenta,
                                             Color.Red,
                                             Color.Blue,
                                             Color.Orange },
                                             'D',
                                             null,
                                             null),

            //62
            new ColorMath(new Color [] { Color.Yellow,
                                             Color.Yellow,
                                             Color.Magenta,
                                             Color.Yellow },
                                             new Color [] { Color.Yellow,
                                             Color.Yellow,
                                             Color.Black,
                                             Color.Purple },
                                             'A',
                                             null,
                                             null),

            //63
            new ColorMath(new Color [] { Color.White,
                                             Color.White,
                                             Color.White,
                                             Color.Purple },
                                             new Color [] { Color.Green,
                                             Color.Red,
                                             Color.Purple,
                                             Color.Blue },
                                             'A',
                                             null,
                                             null),

            //64
            new ColorMath(new Color[] { Color.Blue,
                                             Color.White,
                                             Color.Green,
                                             Color.Yellow },
                                             null,
                                             'M',
                                             null,
                                             null),

            //65
            new ColorMath(new Color [] { Color.Purple,
                        Color.Purple,
                        Color.Orange,
                        Color.White },
                        null,
                        'S',
                        null,
                                             null),
            //66
            new ColorMath(new Color [] { Color.Purple,
                                             Color.Blue,
                                             Color.White,
                                             Color.Yellow},
                                             new Color [] { Color.White,
                                             Color.Blue,
                                             Color.Red,
                                             Color.Purple },
                                             'A',
                                             null,
                                             null),


            //67
            new ColorMath(new Color [] { Color.Purple,
                                             Color.Purple,
                                             Color.White,
                                             Color.Black},
                                             new Color [] { Color.Blue,
                                             Color.Red,
                                             Color.Red,
                                             Color.Purple },
                                             'S',
                                             null,
                                             null),

            //68
            new ColorMath(new Color [] { Color.Yellow,
                                             Color.Orange,
                                             Color.Blue,
                                             Color.Magenta},
                                             new Color [] { Color.Gray,
                                             Color.Orange,
                                             Color.Orange,
                                             Color.White },
                                             'A',
                                             null,
                                             null),

            //69
            new ColorMath(new Color [] { Color.Purple,
                                             Color.Black,
                                             Color.Purple,
                                             Color.Magenta},
                                             new Color [] { Color.Red,
                                             Color.Orange,
                                             Color.Magenta,
                                             Color.White },
                                             'A',
                                             null,
                                             null),

            //70
            new ColorMath(new Color [] { Color.Green,
                                             Color.Magenta,
                                             Color.Yellow,
                                             Color.Black},
                                             new Color [] { Color.Orange,
                                             Color.Orange,
                                             Color.Gray,
                                             Color.Yellow },
                                             'A',
                                             null,
                                             null),
            //71
                        new ColorMath(new Color [] { Color.White,
                                             Color.Orange,
                                             Color.Purple,
                                             Color.Green},
                                             new Color [] { Color.Orange,
                                             Color.Green,
                                             Color.Gray,
                                             Color.Green },
                                             'A',
                                             null,
                                             null),

                    //72
                    new ColorMath(new Color [] { Color.Yellow,
                        Color.Purple,
                        Color.Black,
                        Color.Gray},
                        null,
                        'A',
                        null,
                        null),

                    //73
                    new ColorMath(new Color [] { Color.Magenta,
                                             Color.Gray,
                                             Color.Yellow,
                                             Color.Green},
                                             new Color [] { Color.Purple,
                                             Color.Yellow,
                                             Color.Yellow,
                                             Color.Yellow },
                                             'D',
                                             null,
                                             null),

                    //74
                    new ColorMath(new Color [] { Color.Gray,
                            Color.Purple,
                            Color.Black,
                            Color.Purple},
                            null,
                            'M',
                            null,
                            null),

                    //75
                    new ColorMath(new Color [] { Color.Blue,
                                             Color.Red,
                                             Color.Gray,
                                             Color.Gray},
                                             new Color [] { Color.Yellow,
                                             Color.Orange,
                                             Color.Yellow,
                                             Color.Red },
                                             'A',
                                             null,
                                             null),

                    //76
                     new ColorMath(new Color [] { Color.Blue,
                            Color.White,
                            Color.Magenta,
                            Color.Purple},
                            null,
                            'A',
                            null,
                            null),

                     //77
                    new ColorMath(new Color [] { Color.Blue,
                        Color.Green,
                        Color.Blue,
                        Color.Red},
                        new Color [] { Color.Red,
                        Color.Yellow,
                        Color.Magenta,
                        Color.Yellow },
                        'S',
                        null,
                        null),

                    //78
                    new ColorMath(new Color [] { Color.Magenta,
                            Color.Orange,
                            Color.Red,
                            Color.Blue},
                            null,
                            'A',
                            null,
                            null),

                    //79
        new ColorMath(new Color [] { Color.Magenta,
                            Color.Gray,
                            Color.Magenta,
                            Color.Red},
                            null,
                            'S',
                            null,
                            null),

        //80
        new ColorMath(new Color [] { Color.Green,
    Color.Green,
    Color.Orange,
    Color.Black},
    new Color [] { Color.Green,
    Color.Orange,
    Color.Green,
    Color.Blue },
    'A',
    null,
    null),

        //81
        new ColorMath(new Color [] { Color.Green,
                            Color.Purple,
                            Color.Black,
                            Color.Orange},
                            null,
                            'S',
                            null,
                            null),

        //82
        new ColorMath(new Color [] { Color.Red,
                            Color.Blue,
                            Color.Black,
                            Color.Magenta},
                            null,
                            'M',
                            null,
                            null),

                //83
                new ColorMath(new Color [] { Color.Orange ,
            Color.White,
            Color.Green,
            Color.Black},
            new Color [] { Color.Red,
            Color.Red,
            Color.Magenta,
            Color.Black },
            'S',
            null,
            null),

            //84
                new ColorMath(new Color [] { Color.White ,
            Color.Blue,
            Color.Orange,
            Color.Green},
            new Color [] { Color.Blue,
            Color.White,
            Color.Green,
            Color.Black },
            'D',
            null,
            null),

                
            //85
                new ColorMath(new Color [] { Color.Blue ,
            Color.Black,
            Color.Purple,
            Color.Black},
            new Color [] { Color.Magenta,
            Color.Yellow,
            Color.Green,
            Color.Orange },
            'A',
            null,
            null),

            //86
            new ColorMath(new Color [] { Color.White ,
            Color.Black,
            Color.Yellow,
            Color.Orange},
            new Color [] { Color.Magenta,
            Color.Orange,
            Color.White,
            Color.Magenta },
            'M',
            null,
            null),

            //87
            new ColorMath(new Color [] { Color.Black,
                    Color.White,
                    Color.Purple,
                    Color.Gray},
                    null,
                    'M',
                    null,
                    null),

            //88
            new ColorMath(new Color [] { Color.Green ,
            Color.Purple,
            Color.Green,
            Color.Black},
            new Color [] { Color.Magenta,
            Color.Blue,
            Color.Red,
            Color.Red },
            'A',
            null,
            null),

            //89
            new ColorMath(new Color [] { Color.Gray ,
            Color.Magenta,
            Color.Red,
            Color.Orange},
            new Color [] { Color.White,
            Color.Magenta,
            Color.Purple,
            Color.Purple },
            'A',
            null,
            null),

            //90
            new ColorMath(new Color [] { Color.Blue ,
            Color.Blue,
            Color.Yellow,
            Color.Orange},
            new Color [] { Color.Gray,
            Color.White,
            Color.Black,
            Color.Magenta },
            'M',
            null,
            null),

            //91
            new ColorMath(new Color [] { Color.Blue,
                    Color.Orange,
                    Color.Black,
                    Color.Magenta},
                    null,
                    'A',
                    null,
                    null),

            //92
            new ColorMath(new Color [] { Color.White ,
            Color.Gray,
            Color.Gray,
            Color.Magenta},
            new Color [] { Color.Blue,
            Color.Magenta,
            Color.Orange,
            Color.Purple },
            'D',
            null,
            null),

            //93
            new ColorMath(new Color [] { Color.Gray ,
            Color.Magenta,
            Color.Yellow,
            Color.Magenta},
            new Color [] { Color.Orange,
            Color.White,
            Color.Gray,
            Color.Red },
            'A',
            null,
            null),

            //94
            new ColorMath(new Color [] { Color.Red,
                    Color.Blue,
                    Color.White,
                    Color.Red},
                    null,
                    'D',
                    null,
                    null),

            //95
            new ColorMath(new Color [] { Color.Green,
                    Color.White,
                    Color.Red,
                    Color.Green},
                    null,
                    'D',
                    null,
                    null),

            //96
            new ColorMath(new Color [] { Color.Green ,
            Color.Purple,
            Color.Blue,
            Color.Black},
            new Color [] { Color.Blue,
            Color.Green,
            Color.Red,
            Color.Black },
            'M',
            null,
            null),

            //97
            new ColorMath(new Color [] { Color.Yellow ,
            Color.Purple,
            Color.Yellow,
            Color.White},
            new Color [] { Color.Purple,
            Color.Orange,
            Color.Purple,
            Color.Gray },
            'D',
            null,
            null),

            //98
            new ColorMath(new Color [] { Color.Blue,
                    Color.Green,
                    Color.White,
                    Color.Gray},
                    null,
                    'S',
                    null,
                    null),

            //99
            new ColorMath(new Color [] { Color.Red ,
            Color.Yellow,
            Color.Magenta,
            Color.Yellow},
            new Color [] { Color.Green,
            Color.Green,
            Color.White,
            Color.Green },
            'D',
            null,
            null),

        //100
        new ColorMath(new Color[] { Color.Black, Color.Purple, Color.Magenta, Color.Green },
                                  null,
                                  'S',
                                  null,
                                  null),




    };


        [TestMethod]
        public void TestMethod1()
        {
            module = SetBombFile(1);
            Assert.AreEqual("Yellow, White, Black, Magenta", module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void TestMethod10()
        {
            module = SetBombFile(10);
            Assert.AreEqual("Gray, Blue, Magenta, Gray", module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void TestMethod100()
        {
            module = SetBombFile(100);
            Assert.AreEqual("Black, Yellow, White, Magenta", module.Solve(true));
            io.Close();
        }
        
        [TestMethod]
        public void TestMethod11()
        {
            module = SetBombFile(11);
            Assert.AreEqual("Gray, Green, Red, Red", module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void TestMethod12()
        {
            module = SetBombFile(12);
            Assert.AreEqual("Yellow, Red, Blue, Gray", module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void TestMethod13()
        {
            module = SetBombFile(13);

            Assert.AreEqual("Magenta, Gray, Magenta, Magenta", module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void TestMethod14()
        {
            module = SetBombFile(14);

            Assert.AreEqual("Yellow, Orange, Orange, Gray", module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void TestMethod15()
        {
            module = SetBombFile(15);

            Assert.AreEqual("Orange, White, White, White", module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void TestMethod16()
        {
            module = SetBombFile(16);

            Assert.AreEqual("Green, White, Black, Blue", module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void TestMethod17()
        {
            module = SetBombFile(17);

            Assert.AreEqual("Gray, Blue, Magenta, Gray", module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void TestMethod18()
        {
            module = SetBombFile(18);

            Assert.AreEqual("Gray, White, Orange, White", module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void TestMethod19()
        {
            module = SetBombFile(19); 

            Assert.AreEqual("Gray, Magenta, Yellow, Magenta", module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void TestMethod2()
        {
            module = SetBombFile(2);

            Assert.AreEqual("Purple, Red, Blue, Gray", module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void TestMethod20()
        {
            module = SetBombFile(20);

            Assert.AreEqual("Gray, Blue, Black, Red", module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void TestMethod21()
        {
            module = SetBombFile(21);

            Assert.AreEqual("Orange, Purple, Gray, Blue", module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void TestMethod22()
        {
            module = SetBombFile(22);

            Assert.AreEqual("Red, Blue, Magenta, Purple", module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void TestMethod23()
        {
            module = SetBombFile(23);

            Assert.AreEqual("Red, White, Yellow, White", module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void TestMethod24()
        {
            module = SetBombFile(24);

            Assert.AreEqual("Orange, Gray, Orange, Magenta", module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void TestMethod25()
        {
            module = SetBombFile(25);

            Assert.AreEqual("Green, Blue, Magenta, Green", module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void TestMethod26()
        {
            module = SetBombFile(26);

            Assert.AreEqual("Green, White, Magenta, Yellow", module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void TestMethod27()
        {
            module = SetBombFile(27);

            Assert.AreEqual("Gray, Blue, Magenta, Gray", module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void TestMethod28()
        {
            module = SetBombFile(28);

            Assert.AreEqual("Gray, Blue, Black, Blue", module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void TestMethod29()
        {
            module = SetBombFile(29);

            Assert.AreEqual("Gray, Blue, Magenta, Red", module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void TestMethod3()
        {
            module = SetBombFile(3);

            Assert.AreEqual("Gray, Blue, Magenta, Gray", module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void TestMethod30()
        {
            module = SetBombFile(30);

            Assert.AreEqual("White, Magenta, White, Red", module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void TestMethod31()
        {
            module = SetBombFile(31);

            Assert.AreEqual("Yellow, Yellow, Blue, Gray", module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void TestMethod32()
        {
            module = SetBombFile(32);

            Assert.AreEqual("Black, Red, Black, Magenta", module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void TestMethod33()
        {
            module = SetBombFile(33);

            Assert.AreEqual("Gray, Blue, Gray, Gray", module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void TestMethod34()
        {
            module = SetBombFile(34);


            Assert.AreEqual("Green, Black, Purple, Yellow", module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void TestMethod35()
        {
            module = SetBombFile(35);

            Assert.AreEqual("Purple, Red, Black, Red", module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void TestMethod36()
        {
            module = SetBombFile(36);

            Assert.AreEqual("White, Yellow, White, Purple", module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void TestMethod37()
        {
            module = SetBombFile(37);

            Assert.AreEqual("Gray, Blue, Magenta, Blue", module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void TestMethod38()
        {
            module = SetBombFile(38);

            Assert.AreEqual("Green, White, Magenta, Purple", module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void TestMethod39()
        {
            module = SetBombFile(39);

            Assert.AreEqual("Gray, Blue, Magenta, Orange", module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void TestMethod4()
        {
            module = SetBombFile(4);

            Assert.AreEqual("Gray, Blue, Magenta, Gray", module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void TestMethod40()
        {
            module = SetBombFile(40);

            Assert.AreEqual("Black, Orange, Gray, Yellow", module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void TestMethod41()
        {
            module = SetBombFile(41);

            Assert.AreEqual("Magenta, Black, Gray, Red", module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void TestMethod42()
        {
            module = SetBombFile(42);

            Assert.AreEqual("Gray, Blue, Magenta, Gray", module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void TestMethod43()
        {
            module = SetBombFile(43);

            Assert.AreEqual("Green, Black, Magenta, White", module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void TestMethod44()
        {
            module = SetBombFile(44);

            Assert.AreEqual("Black, Blue, Blue, Black", module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void TestMethod45()
        {
            module = SetBombFile(45);

            Assert.AreEqual("Blue, Red, Purple, White", module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void TestMethod46()
        {
            module = SetBombFile(46);

            Assert.AreEqual("Gray, Blue, Blue, Yellow", module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void TestMethod47()
        {
            module = SetBombFile(47);

            Assert.AreEqual("Orange, Blue, Gray, Purple", module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void TestMethod48()
        {
            module = SetBombFile(48);

            Assert.AreEqual("Red, Purple, Purple, Magenta", module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void TestMethod49()
        {
            module = SetBombFile(49);

            Assert.AreEqual("White, Black, Purple, Red", module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void TestMethod5()
        {
            module = SetBombFile(5);


            Assert.AreEqual("Green, Red, Red, Green", module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void TestMethod50()
        {
            module = SetBombFile(50);

            Assert.AreEqual("Yellow, Black, Gray, Yellow", module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void TestMethod51()
        {
            module = SetBombFile(51);

            Assert.AreEqual("Orange, Magenta, Purple, Red", module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void TestMethod52()
        {
            module = SetBombFile(52);

            Assert.AreEqual("Orange, Red, Black, Gray", module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void TestMethod53()
        {
            module = SetBombFile(53);


            Assert.AreEqual("Gray, Blue, Orange, Black", module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void TestMethod54()
        {
            module = SetBombFile(54);

            Assert.AreEqual("Gray, Blue, Blue, White", module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void TestMethod55()
        {
            module = SetBombFile(55);

            Assert.AreEqual("Gray, Blue, Red, Orange", module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void TestMethod56()
        {
            module = SetBombFile(56);

            Assert.AreEqual("White, Orange, Orange, Magenta", module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void TestMethod57()
        {
            module = SetBombFile(57);


            Assert.AreEqual("Gray, Blue, Green, Red", module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void TestMethod58()
        {
            module = SetBombFile(58);

            Assert.AreEqual("Yellow, Orange, Magenta, Blue", module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void TestMethod59()
        {
            module = SetBombFile(59);

            Assert.AreEqual("Red, Purple, White, Black", module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void TestMethod6()
        {
            module = SetBombFile(6);

            Assert.AreEqual("Yellow, Magenta, White, Yellow", module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void TestMethod60()
        {
            module = SetBombFile(60);

            Assert.AreEqual("Red, Gray, Blue, Blue", module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void TestMethod61()
        {
            module = SetBombFile(61);

            Assert.AreEqual("Gray, Blue, Magenta, Gray", module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void TestMethod62()
        {
            module = SetBombFile(62);

            Assert.AreEqual("Yellow, Magenta, Gray, Orange", module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void TestMethod63()
        {
            module = SetBombFile(63);

            Assert.AreEqual("Blue, Yellow, Purple, Purple", module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void TestMethod64()
        {
            module = SetBombFile(64);

            Assert.AreEqual("Red, Orange, White, Magenta", module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void TestMethod65()
        {
            module = SetBombFile(65);

            Assert.AreEqual("Orange, Orange, Magenta, Blue", module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void TestMethod66()
        {
            module = SetBombFile(66);

            Assert.AreEqual("Magenta, Blue, White, Orange", module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void TestMethod67()
        {
            module = SetBombFile(67);

            Assert.AreEqual("Orange, Magenta, Yellow, Gray", module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void TestMethod68()
        {
            module = SetBombFile(68);

            Assert.AreEqual("Magenta, Black, Orange, Orange", module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void TestMethod69()
        {
            module = SetBombFile(69);

            Assert.AreEqual("Orange, Blue, Purple, Orange", module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void TestMethod7()
        {
            module = SetBombFile(7);

            Assert.AreEqual("Green, Magenta, White, Magenta", module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void TestMethod70()
        {
            module = SetBombFile(70);

            Assert.AreEqual("Gray, Magenta, Green, Blue", module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void TestMethod71()
        {
            module = SetBombFile(71);

            Assert.AreEqual("Yellow, Red, Orange, Purple", module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void TestMethod72()
        {
            module = SetBombFile(72);

            Assert.AreEqual("Blue, Blue, White, Red", module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void TestMethod73()
        {
            module = SetBombFile(73);

            Assert.AreEqual("Gray, Blue, Magenta, Gray", module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void TestMethod74()
        {
            module = SetBombFile(74);

            Assert.AreEqual("Black, Gray, Yellow, Blue", module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void TestMethod75()
        {
            module = SetBombFile(75);

            Assert.AreEqual("Gray, Orange, Blue, Orange", module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void TestMethod76()
        {
            module = SetBombFile(76);

            Assert.AreEqual("Magenta, Magenta, Green, Gray", module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void TestMethod77()
        {
            module = SetBombFile(77);

            Assert.AreEqual("Orange, White, Gray, Green", module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void TestMethod78()
        {
            module = SetBombFile(78);

            Assert.AreEqual("Gray, Gray, Orange, White", module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void TestMethod79()
        {
            module = SetBombFile(79);

            Assert.AreEqual("Gray, Red, Orange, Green", module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void TestMethod8()
        {
            module = SetBombFile(8);

            Assert.AreEqual("Gray, Blue, Magenta, Black", module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void TestMethod80()
        {
            module = SetBombFile(80);

            Assert.AreEqual("Black, Orange, Gray, Orange", module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void TestMethod81()
        {
            module = SetBombFile(81);

            Assert.AreEqual("Green, Orange, Gray, Gray", module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void TestMethod82()
        {
            module = SetBombFile(82);

            Assert.AreEqual("Red, Red, Purple, Orange", module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void TestMethod83()
        {
            module = SetBombFile(83);

            Assert.AreEqual("Purple, Green, Black, Green", module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void TestMethod84()
        {

            module = SetBombFile(84);
            Assert.AreEqual("Gray, Blue, Yellow, White", module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void TestMethod85()
        {

            module = SetBombFile(85);
            Assert.AreEqual("White, Black, White, Red", module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void TestMethod86()
        {

            module = SetBombFile(86);
            Assert.AreEqual("White, Green, White, Green", module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void TestMethod87()
        {

            module = SetBombFile(87);
            Assert.AreEqual("Orange, Orange, Purple, Gray", module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void TestMethod88()
        {

            module = SetBombFile(88);
            Assert.AreEqual("Red, Black, Magenta, White", module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void TestMethod89()
        {

            module = SetBombFile(89);
            Assert.AreEqual("Black, Blue, Yellow, Magenta", module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void TestMethod9()
        {

            module = SetBombFile(9);
            Assert.AreEqual("Gray, Blue, Blue, Orange", module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void TestMethod90()
        {

            module = SetBombFile(90);
            Assert.AreEqual("Red, Magenta, Green, Green", module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void TestMethod91()
        {

            module = SetBombFile(91);
            Assert.AreEqual("Magenta, Yellow, Magenta, Purple", module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void TestMethod92()
        {

            module = SetBombFile(92);
            Assert.AreEqual("Gray, Blue, Blue, White", module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void TestMethod93()
        {

            module = SetBombFile(93);
            Assert.AreEqual("Orange, Black, Green, Black", module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void TestMethod94()
        {

            module = SetBombFile(94);
            Assert.AreEqual("Gray, Blue, Green, Black", module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void TestMethod95()
        {

            module = SetBombFile(95);
            Assert.AreEqual("Gray, Blue, Yellow, Gray", module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void TestMethod96()
        {

            module = SetBombFile(96);
            Assert.AreEqual("Orange, Red, Orange, Gray", module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void TestMethod97()
        {

            module = SetBombFile(97);
            Assert.AreEqual("Gray, Blue, Magenta, Gray", module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void TestMethod98()
        {

            module = SetBombFile(98);
            Assert.AreEqual("Blue, White, Green, Orange", module.Solve(true));
            io.Close();
        }

        [TestMethod]
        public void TestMethod99()
        {
            module = SetBombFile(99);
            Assert.AreEqual("Gray, Blue, Magenta, Blue", module.Solve(true));
            io.Close();
        }

        protected ColorMath SetBombFile(int index)
        {
            modules[index - 1].LogFileWriter = io;
            modules[index - 1].Bomb = bomb;

            return modules[index - 1];

        }

    }
}
