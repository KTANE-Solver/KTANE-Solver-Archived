using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using KTANE_Solver;
using System.Windows.Forms;
using System.IO;
namespace ModuleTests
{
    [TestClass]
    public class SkewedSlotsTest
    {
        StreamWriter streamWriter = new StreamWriter("dummy.txt");

        Bomb bomb = new Bomb(Day.Friday, "D91UJ0", 0, 0, new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), false, 0, new Port("", 0), new Port("", 0), new Port("", 0), new Port("", 0), new Port("", 0), new Port("", 0));

        [TestMethod]
        public void Test1()
        {
            SkewedSlots module = new SkewedSlots(bomb, streamWriter, 550);
            
            Assert.AreEqual("535", module.DebugSolve());

            streamWriter.Close();

        }

        [TestMethod]
        public void Test10()
        {
            SkewedSlots module = new SkewedSlots(bomb, streamWriter, 200);

            Assert.AreEqual("224", module.DebugSolve());
            streamWriter.Close();
        }

        [TestMethod]
        public void Test100()
        {
            SkewedSlots module = new SkewedSlots(bomb, streamWriter, 757);

            Assert.AreEqual("434", module.DebugSolve());
            streamWriter.Close();
        }

        [TestMethod]
        public void Test11()
        {
            SkewedSlots module = new SkewedSlots(bomb, streamWriter, 839);

            Assert.AreEqual("812", module.DebugSolve());
            streamWriter.Close();
        }

        [TestMethod]
        public void Test12()
        {
            SkewedSlots module = new SkewedSlots(bomb, streamWriter, 474);

            Assert.AreEqual("424", module.DebugSolve());
            streamWriter.Close();
        }

        [TestMethod]
        public void Test13()
        {
            SkewedSlots module = new SkewedSlots(bomb, streamWriter, 114);

            Assert.AreEqual("125", module.DebugSolve());           
            streamWriter.Close();
        }

        [TestMethod]
        public void Test14()
        {
            SkewedSlots module = new SkewedSlots(bomb, streamWriter, 693);

            Assert.AreEqual("542", module.DebugSolve());
            streamWriter.Close();
        }

        [TestMethod]
        public void Test15()
        {
            SkewedSlots module = new SkewedSlots(bomb, streamWriter, 663);

            Assert.AreEqual("542", module.DebugSolve());
            streamWriter.Close();
        }

        [TestMethod]
        public void Test16()
        {
            SkewedSlots module = new SkewedSlots(bomb, streamWriter, 057);

            Assert.AreEqual("435", module.DebugSolve());
            streamWriter.Close();
        }

        [TestMethod]
        public void Test17()
        {
            SkewedSlots module = new SkewedSlots(bomb, streamWriter, 651);

            Assert.AreEqual("532", module.DebugSolve());
            streamWriter.Close();
        }

        [TestMethod]
        public void Test18()
        {
            SkewedSlots module = new SkewedSlots(bomb, streamWriter, 699);

            Assert.AreEqual("543", module.DebugSolve());
            streamWriter.Close();
        }

        [TestMethod]
        public void Test19()
        {
            SkewedSlots module = new SkewedSlots(bomb, streamWriter, 016);

            Assert.AreEqual("422", module.DebugSolve());
            streamWriter.Close();
        }

        [TestMethod]
        public void Test2()
        {
            SkewedSlots module = new SkewedSlots(bomb, streamWriter, 620);

            Assert.AreEqual("555", module.DebugSolve());
            streamWriter.Close();
        }

        [TestMethod]
        public void Test20()
        {
            SkewedSlots module = new SkewedSlots(bomb, streamWriter, 473);

            Assert.AreEqual("422", module.DebugSolve());
            streamWriter.Close();
        }

        [TestMethod]
        public void Test21()
        {
            SkewedSlots module = new SkewedSlots(bomb, streamWriter, 327);

            Assert.AreEqual("755", module.DebugSolve());
            streamWriter.Close();
        }

        [TestMethod]
        public void Test22()
        {
            SkewedSlots module = new SkewedSlots(bomb, streamWriter, 131);

            Assert.AreEqual("111", module.DebugSolve());
            streamWriter.Close();
        }

        [TestMethod]
        public void Test23()
        {
            SkewedSlots module = new SkewedSlots(bomb, streamWriter, 842);

            Assert.AreEqual("823", module.DebugSolve());
            streamWriter.Close();
        }

        [TestMethod]
        public void Test24()
        {
            SkewedSlots module = new SkewedSlots(bomb, streamWriter, 749);

            Assert.AreEqual("222", module.DebugSolve());
            streamWriter.Close();
        }

        [TestMethod]
        public void Test25()
        {
            SkewedSlots module = new SkewedSlots(bomb, streamWriter, 861);

            Assert.AreEqual("842", module.DebugSolve());
            streamWriter.Close();
        }

        [TestMethod]
        public void Test26()
        {
            SkewedSlots module = new SkewedSlots(bomb, streamWriter, 663);

            Assert.AreEqual("542", module.DebugSolve());
            streamWriter.Close();

        }

        [TestMethod]
        public void Test27()
        {
            SkewedSlots module = new SkewedSlots(bomb, streamWriter, 986);

            Assert.AreEqual("302", module.DebugSolve());
            streamWriter.Close();
        }

        [TestMethod]
        public void Test28()
        {
            SkewedSlots module = new SkewedSlots(bomb, streamWriter, 587);

            Assert.AreEqual("505", module.DebugSolve());
            streamWriter.Close();
        }

        [TestMethod]
        public void Test29()
        {
            SkewedSlots module = new SkewedSlots(bomb, streamWriter, 829);

            Assert.AreEqual("852", module.DebugSolve());
            streamWriter.Close();

        }

        [TestMethod]
        public void Test3()
        {
            SkewedSlots module = new SkewedSlots(bomb, streamWriter, 498);

            Assert.AreEqual("441", module.DebugSolve());
            streamWriter.Close();
        }

        [TestMethod]
        public void Test30()
        {
            SkewedSlots module = new SkewedSlots(bomb, streamWriter, 346);

            Assert.AreEqual("722", module.DebugSolve());
            streamWriter.Close();
        }

        [TestMethod]
        public void Test31()
        {
            SkewedSlots module = new SkewedSlots(bomb, streamWriter, 792);

            Assert.AreEqual("443", module.DebugSolve());
            streamWriter.Close();

        }

        [TestMethod]
        public void Test32()
        {
            SkewedSlots module = new SkewedSlots(bomb, streamWriter, 250);

            Assert.AreEqual("235", module.DebugSolve());
            streamWriter.Close();
        }

        [TestMethod]
        public void Test33()
        {
            SkewedSlots module = new SkewedSlots(bomb, streamWriter, 294);

            Assert.AreEqual("245", module.DebugSolve());
            streamWriter.Close();

        }

        [TestMethod]
        public void Test34()
        {
            SkewedSlots module = new SkewedSlots(bomb, streamWriter, 799);

            Assert.AreEqual("443", module.DebugSolve());
            streamWriter.Close();
        }

        [TestMethod]
        public void Test35()
        {
            SkewedSlots module = new SkewedSlots(bomb, streamWriter, 153);

            Assert.AreEqual("132", module.DebugSolve());
            streamWriter.Close();

        }

        [TestMethod]
        public void Test36()
        {
            SkewedSlots module = new SkewedSlots(bomb, streamWriter, 700);

            Assert.AreEqual("224", module.DebugSolve());
            streamWriter.Close();

        }

        [TestMethod]
        public void Test37()
        {
            SkewedSlots module = new SkewedSlots(bomb, streamWriter, 529);

            Assert.AreEqual("552", module.DebugSolve());
            streamWriter.Close();

        }

        [TestMethod]
        public void Test38()
        {
            SkewedSlots module = new SkewedSlots(bomb, streamWriter, 782);

            Assert.AreEqual("203", module.DebugSolve());
            streamWriter.Close();

        }

        [TestMethod]
        public void Test39()
        {
            SkewedSlots module = new SkewedSlots(bomb, streamWriter, 160);

            Assert.AreEqual("945", module.DebugSolve());
            streamWriter.Close();

        }

        [TestMethod]
        public void Test4()
        {
            SkewedSlots module = new SkewedSlots(bomb, streamWriter, 368);

            Assert.AreEqual("741", module.DebugSolve());
            streamWriter.Close();

        }

        [TestMethod]
        public void Test40()
        {
            SkewedSlots module = new SkewedSlots(bomb, streamWriter, 396);

            Assert.AreEqual("742", module.DebugSolve());
            streamWriter.Close();

        }

        [TestMethod]
        public void Test41()
        {
            SkewedSlots module = new SkewedSlots(bomb, streamWriter, 282);

            Assert.AreEqual("202", module.DebugSolve());

            streamWriter.Close();
        }

        [TestMethod]
        public void Test42()
        {
            SkewedSlots module = new SkewedSlots(bomb, streamWriter, 093);

            Assert.AreEqual("442", module.DebugSolve());

            streamWriter.Close();

        }

        [TestMethod]
        public void Test43()
        {
            SkewedSlots module = new SkewedSlots(bomb, streamWriter, 801);

            Assert.AreEqual("822", module.DebugSolve());

            streamWriter.Close();

        }

        [TestMethod]
        public void Test44()
        {
            SkewedSlots module = new SkewedSlots(bomb, streamWriter, 771);

            Assert.AreEqual("422", module.DebugSolve());

            streamWriter.Close();
        }

        [TestMethod]
        public void Test45()
        {
            SkewedSlots module = new SkewedSlots(bomb, streamWriter, 671);

            Assert.AreEqual("522", module.DebugSolve());

            streamWriter.Close();
        }

        [TestMethod]
        public void Test46()
        {
            SkewedSlots module = new SkewedSlots(bomb, streamWriter, 202);

            Assert.AreEqual("222", module.DebugSolve());

            streamWriter.Close();
        }

        [TestMethod]
        public void Test47()
        {
            SkewedSlots module = new SkewedSlots(bomb, streamWriter, 233);

            Assert.AreEqual("217", module.DebugSolve());

            streamWriter.Close();
        }

        [TestMethod]
        public void Test48()
        {
            SkewedSlots module = new SkewedSlots(bomb, streamWriter, 033);

            Assert.AreEqual("417", module.DebugSolve());

            streamWriter.Close();
        }

        [TestMethod]
        public void Test49()
        {
            SkewedSlots module = new SkewedSlots(bomb, streamWriter, 349);

            Assert.AreEqual("722", module.DebugSolve());

            streamWriter.Close();
        }

        [TestMethod]
        public void Test5()
        {
            SkewedSlots module = new SkewedSlots(bomb, streamWriter, 187);

            Assert.AreEqual("905", module.DebugSolve());

            streamWriter.Close();
        }

        [TestMethod]
        public void Test50()
        {
            SkewedSlots module = new SkewedSlots(bomb, streamWriter, 298);

            Assert.AreEqual("241", module.DebugSolve());

            streamWriter.Close();
        }

        [TestMethod]
        public void Test51()
        {
            SkewedSlots module = new SkewedSlots(bomb, streamWriter, 992);

            Assert.AreEqual("343", module.DebugSolve());

            streamWriter.Close();
        }

        [TestMethod]
        public void Test52()
        {
            SkewedSlots module = new SkewedSlots(bomb, streamWriter, 321);

            Assert.AreEqual("752", module.DebugSolve());

            streamWriter.Close();
        }

        [TestMethod]
        public void Test53()
        {
            SkewedSlots module = new SkewedSlots(bomb, streamWriter, 249);

            Assert.AreEqual("222", module.DebugSolve());

            streamWriter.Close();
        }

        [TestMethod]
        public void Test54()
        {
            SkewedSlots module = new SkewedSlots(bomb, streamWriter, 131);

            Assert.AreEqual("111", module.DebugSolve());

            streamWriter.Close();
        }

        [TestMethod]
        public void Test55()
        {
            SkewedSlots module = new SkewedSlots(bomb, streamWriter, 778);

            Assert.AreEqual("421", module.DebugSolve());

            streamWriter.Close();
        }

        [TestMethod]
        public void Test56()
        {
            SkewedSlots module = new SkewedSlots(bomb, streamWriter, 426);

            Assert.AreEqual("252", module.DebugSolve());

            streamWriter.Close();
        }

        [TestMethod]
        public void Test57()
        {
            SkewedSlots module = new SkewedSlots(bomb, streamWriter, 136);

            Assert.AreEqual("112", module.DebugSolve());

            streamWriter.Close();
        }

        [TestMethod]
        public void Test58()
        {
            SkewedSlots module = new SkewedSlots(bomb, streamWriter, 943);

            Assert.AreEqual("322", module.DebugSolve());

            streamWriter.Close();
        }

        [TestMethod]
        public void Test59()
        {
            SkewedSlots module = new SkewedSlots(bomb, streamWriter, 510);

            Assert.AreEqual("525", module.DebugSolve());

            streamWriter.Close();

        }

        [TestMethod]
        public void Test6()
        {
            SkewedSlots module = new SkewedSlots(bomb, streamWriter, 881);

            Assert.AreEqual("802", module.DebugSolve());

            streamWriter.Close();

        }

        [TestMethod]
        public void Test60()
        {
            SkewedSlots module = new SkewedSlots(bomb, streamWriter, 611);

            Assert.AreEqual("521", module.DebugSolve());

            streamWriter.Close();

        }

        [TestMethod]
        public void Test61()
        {
            SkewedSlots module = new SkewedSlots(bomb, streamWriter, 703);

            Assert.AreEqual("222", module.DebugSolve());

            streamWriter.Close();

        }

        [TestMethod]
        public void Test62()
        {
            SkewedSlots module = new SkewedSlots(bomb, streamWriter, 272);

            Assert.AreEqual("222", module.DebugSolve());

            streamWriter.Close();

        }

        [TestMethod]
        public void Test63()
        {
            SkewedSlots module = new SkewedSlots(bomb, streamWriter, 771);

            Assert.AreEqual("422", module.DebugSolve());

            streamWriter.Close();

        }

        [TestMethod]
        public void Test64()
        {
            SkewedSlots module = new SkewedSlots(bomb, streamWriter, 151);

            Assert.AreEqual("131", module.DebugSolve());

            streamWriter.Close();

        }

        [TestMethod]
        public void Test65()
        {
            SkewedSlots module = new SkewedSlots(bomb, streamWriter, 106);

            Assert.AreEqual("922", module.DebugSolve());

            streamWriter.Close();

        }

        [TestMethod]
        public void Test66()
        {
            SkewedSlots module = new SkewedSlots(bomb, streamWriter, 151);

            Assert.AreEqual("131", module.DebugSolve());

            streamWriter.Close();

        }

        [TestMethod]
        public void Test67()
        {
            SkewedSlots module = new SkewedSlots(bomb, streamWriter, 953);

            Assert.AreEqual("332", module.DebugSolve());

            streamWriter.Close();

        }

        [TestMethod]
        public void Test68()
        {
            SkewedSlots module = new SkewedSlots(bomb, streamWriter, 805);

            Assert.AreEqual("822", module.DebugSolve());

            streamWriter.Close();

        }

        [TestMethod]
        public void Test69()
        {
            SkewedSlots module = new SkewedSlots(bomb, streamWriter, 041);

            Assert.AreEqual("222", module.DebugSolve());

            streamWriter.Close();

        }

        [TestMethod]
        public void Test7()
        {
            SkewedSlots module = new SkewedSlots(bomb, streamWriter, 139);

            Assert.AreEqual("112", module.DebugSolve());

            streamWriter.Close();

        }

        [TestMethod]
        public void Test70()
        {
            SkewedSlots module = new SkewedSlots(bomb, streamWriter, 356);

            Assert.AreEqual("732", module.DebugSolve());

            streamWriter.Close();

        }

        [TestMethod]
        public void Test71()
        {
            SkewedSlots module = new SkewedSlots(bomb, streamWriter, 767);

            Assert.AreEqual("244", module.DebugSolve());

            streamWriter.Close();

        }

        [TestMethod]
        public void Test72()
        {
            SkewedSlots module = new SkewedSlots(bomb, streamWriter, 829);

            Assert.AreEqual("852", module.DebugSolve());

            streamWriter.Close();

        }

        [TestMethod]
        public void Test73()
        {
            SkewedSlots module = new SkewedSlots(bomb, streamWriter, 838);

            Assert.AreEqual("816", module.DebugSolve());

            streamWriter.Close();

        }

        [TestMethod]
        public void Test74()
        {
            SkewedSlots module = new SkewedSlots(bomb, streamWriter, 042);

            Assert.AreEqual("223", module.DebugSolve());
            streamWriter.Close();

        }

        [TestMethod]
        public void Test75()
        {
            SkewedSlots module = new SkewedSlots(bomb, streamWriter, 040);

            Assert.AreEqual("224", module.DebugSolve());

            streamWriter.Close();

        }

        [TestMethod]
        public void Test76()
        {
            SkewedSlots module = new SkewedSlots(bomb, streamWriter, 736);

            Assert.AreEqual("412", module.DebugSolve());
            streamWriter.Close();

        }

        [TestMethod]
        public void Test77()
        {
            SkewedSlots module = new SkewedSlots(bomb, streamWriter, 586);

            Assert.AreEqual("502", module.DebugSolve());

            streamWriter.Close();

        }

        [TestMethod]
        public void Test78()
        {
            SkewedSlots module = new SkewedSlots(bomb, streamWriter, 181);

            Assert.AreEqual("901", module.DebugSolve());

            streamWriter.Close();

        }

        [TestMethod]
        public void Test79()
        {
            SkewedSlots module = new SkewedSlots(bomb, streamWriter, 557);

            Assert.AreEqual("535", module.DebugSolve());

            streamWriter.Close();

        }

        [TestMethod]
        public void Test8()
        {
            SkewedSlots module = new SkewedSlots(bomb, streamWriter, 108);

            Assert.AreEqual("921", module.DebugSolve());

            streamWriter.Close();

        }

        [TestMethod]
        public void Test80()
        {
            SkewedSlots module = new SkewedSlots(bomb, streamWriter, 740);

            Assert.AreEqual("225", module.DebugSolve());

            streamWriter.Close();

        }

        [TestMethod]
        public void Test81()
        {
            SkewedSlots module = new SkewedSlots(bomb, streamWriter, 276);

            Assert.AreEqual("222", module.DebugSolve());

            streamWriter.Close();

        }

        [TestMethod]
        public void Test82()
        {
            SkewedSlots module = new SkewedSlots(bomb, streamWriter, 500);

            Assert.AreEqual("524", module.DebugSolve());

            streamWriter.Close();

        }

        [TestMethod]
        public void Test83()
        {
            SkewedSlots module = new SkewedSlots(bomb, streamWriter, 096);

            Assert.AreEqual("442", module.DebugSolve());

            streamWriter.Close();

        }

        [TestMethod]
        public void Test84()
        {
            SkewedSlots module = new SkewedSlots(bomb, streamWriter, 673);

            Assert.AreEqual("522", module.DebugSolve());

            streamWriter.Close();

        }

        [TestMethod]
        public void Test85()
        {
            SkewedSlots module = new SkewedSlots(bomb, streamWriter, 851);

            Assert.AreEqual("832", module.DebugSolve());

            streamWriter.Close();

        }

        [TestMethod]
        public void Test86()
        {
            SkewedSlots module = new SkewedSlots(bomb, streamWriter, 284);

            Assert.AreEqual("205", module.DebugSolve());

            streamWriter.Close();

        }

        [TestMethod]
        public void Test87()
        {
            SkewedSlots module = new SkewedSlots(bomb, streamWriter, 866);

            Assert.AreEqual("840", module.DebugSolve());

            streamWriter.Close();

        }

        [TestMethod]
        public void Test88()
        {
            SkewedSlots module = new SkewedSlots(bomb, streamWriter, 299);

            Assert.AreEqual("243", module.DebugSolve());

            streamWriter.Close();

        }

        [TestMethod]
        public void Test89()
        {
            SkewedSlots module = new SkewedSlots(bomb, streamWriter, 348);

            Assert.AreEqual("721", module.DebugSolve());

            streamWriter.Close();

        }

        [TestMethod]
        public void Test9()
        {
            SkewedSlots module = new SkewedSlots(bomb, streamWriter, 625);

            Assert.AreEqual("552", module.DebugSolve());
            
            streamWriter.Close();
        }

        [TestMethod]
        public void Test90()
        {
            SkewedSlots module = new SkewedSlots(bomb, streamWriter, 181);

            Assert.AreEqual("901", module.DebugSolve());

            streamWriter.Close();
        }

        [TestMethod]
        public void Test91()
        {
            SkewedSlots module = new SkewedSlots(bomb, streamWriter, 455);

            Assert.AreEqual("435", module.DebugSolve());

            streamWriter.Close();
        }

        [TestMethod]
        public void Test92()
        {
            SkewedSlots module = new SkewedSlots(bomb, streamWriter, 950);

            Assert.AreEqual("335", module.DebugSolve());

            streamWriter.Close();
        }

        [TestMethod]
        public void Test93()
        {
            SkewedSlots module = new SkewedSlots(bomb, streamWriter, 577);

            Assert.AreEqual("524", module.DebugSolve());
            
            streamWriter.Close();
        }

        [TestMethod]
        public void Test94()
        {
            SkewedSlots module = new SkewedSlots(bomb, streamWriter, 638);

            Assert.AreEqual("511", module.DebugSolve());

            streamWriter.Close();
        }

        [TestMethod]
        public void Test95()
        {
            SkewedSlots module = new SkewedSlots(bomb, streamWriter, 570);

            Assert.AreEqual("525", module.DebugSolve());

            streamWriter.Close();
        }

        [TestMethod]
        public void Test96()
        {
            SkewedSlots module = new SkewedSlots(bomb, streamWriter, 534);

            Assert.AreEqual("515", module.DebugSolve());

            streamWriter.Close();
        }

        [TestMethod]
        public void Test97()
        {
            SkewedSlots module = new SkewedSlots(bomb, streamWriter, 372);

            Assert.AreEqual("723", module.DebugSolve());

            streamWriter.Close();
        }

        [TestMethod]
        public void Test98()
        {
            SkewedSlots module = new SkewedSlots(bomb, streamWriter, 069);

            Assert.AreEqual("242", module.DebugSolve());

            streamWriter.Close();

        }

        [TestMethod]
        public void Test99()
        {
            SkewedSlots module = new SkewedSlots(bomb, streamWriter, 546);

            Assert.AreEqual("522", module.DebugSolve());

            streamWriter.Close();
        }
    }
}
