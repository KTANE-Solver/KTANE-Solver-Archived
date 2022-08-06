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
        [TestMethod]
        public void Tests()
        {
            StreamWriter streamWriter = new StreamWriter("dummy.txt");

            Bomb bomb = new Bomb(Day.Friday, "D91UJ0", 0, 0, new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), false, 0, new Port("", 0), new Port("", 0), new Port("", 0), new Port("", 0), new Port("", 0), new Port("", 0));

            SkewedSlots module = new SkewedSlots(bomb, streamWriter, 550);
            
            Assert.AreEqual("535", module.DebugSolve());

            module = new SkewedSlots(bomb, streamWriter, 200);

            Assert.AreEqual("224", module.DebugSolve());

            module = new SkewedSlots(bomb, streamWriter, 757);

            Assert.AreEqual("434", module.DebugSolve());

            module = new SkewedSlots(bomb, streamWriter, 839);

            Assert.AreEqual("812", module.DebugSolve());

            module = new SkewedSlots(bomb, streamWriter, 474);

            Assert.AreEqual("472", module.DebugSolve());

            module = new SkewedSlots(bomb, streamWriter, 114);

            Assert.AreEqual("125", module.DebugSolve());

            module = new SkewedSlots(bomb, streamWriter, 693);

            Assert.AreEqual("542", module.DebugSolve());

            module = new SkewedSlots(bomb, streamWriter, 663);

            Assert.AreEqual("542", module.DebugSolve());

            module = new SkewedSlots(bomb, streamWriter, 057);

            Assert.AreEqual("435", module.DebugSolve());

            module = new SkewedSlots(bomb, streamWriter, 651);

            Assert.AreEqual("532", module.DebugSolve());

            module = new SkewedSlots(bomb, streamWriter, 669);

            Assert.AreEqual("543", module.DebugSolve());

            module = new SkewedSlots(bomb, streamWriter, 016);

            Assert.AreEqual("422", module.DebugSolve());

            module = new SkewedSlots(bomb, streamWriter, 620);

            Assert.AreEqual("555", module.DebugSolve());

            module = new SkewedSlots(bomb, streamWriter, 473);

            Assert.AreEqual("422", module.DebugSolve());

            module = new SkewedSlots(bomb, streamWriter, 327);

            Assert.AreEqual("755", module.DebugSolve());

            module = new SkewedSlots(bomb, streamWriter, 131);

            Assert.AreEqual("111", module.DebugSolve());

            module = new SkewedSlots(bomb, streamWriter, 842);

            Assert.AreEqual("823", module.DebugSolve());

            module = new SkewedSlots(bomb, streamWriter, 749);

            Assert.AreEqual("222", module.DebugSolve());

            module = new SkewedSlots(bomb, streamWriter, 861);

            Assert.AreEqual("842", module.DebugSolve());

            module = new SkewedSlots(bomb, streamWriter, 663);

            Assert.AreEqual("542", module.DebugSolve());

            module = new SkewedSlots(bomb, streamWriter, 986);

            Assert.AreEqual("302", module.DebugSolve());

            module = new SkewedSlots(bomb, streamWriter, 587);

            Assert.AreEqual("505", module.DebugSolve());

            module = new SkewedSlots(bomb, streamWriter, 829);

            Assert.AreEqual("852", module.DebugSolve());

            module = new SkewedSlots(bomb, streamWriter, 498);

            Assert.AreEqual("441", module.DebugSolve());

            module = new SkewedSlots(bomb, streamWriter, 346);

            Assert.AreEqual("722", module.DebugSolve());

            module = new SkewedSlots(bomb, streamWriter, 792);

            Assert.AreEqual("443", module.DebugSolve());

            module = new SkewedSlots(bomb, streamWriter, 250);

            Assert.AreEqual("235", module.DebugSolve());

            module = new SkewedSlots(bomb, streamWriter, 294);

            Assert.AreEqual("245", module.DebugSolve());

            module = new SkewedSlots(bomb, streamWriter, 799);

            Assert.AreEqual("443", module.DebugSolve());

            module = new SkewedSlots(bomb, streamWriter, 153);

            Assert.AreEqual("132", module.DebugSolve());

            module = new SkewedSlots(bomb, streamWriter, 700);

            Assert.AreEqual("224", module.DebugSolve());

            module = new SkewedSlots(bomb, streamWriter, 529);

            Assert.AreEqual("552", module.DebugSolve());

            module = new SkewedSlots(bomb, streamWriter, 782);

            Assert.AreEqual("203", module.DebugSolve());

            module = new SkewedSlots(bomb, streamWriter, 160);

            Assert.AreEqual("945", module.DebugSolve());

            module = new SkewedSlots(bomb, streamWriter, 368);

            Assert.AreEqual("741", module.DebugSolve());

            module = new SkewedSlots(bomb, streamWriter, 396);

            Assert.AreEqual("742", module.DebugSolve());

            module = new SkewedSlots(bomb, streamWriter, 282);

            Assert.AreEqual("202", module.DebugSolve());

            module = new SkewedSlots(bomb, streamWriter, 093);

            Assert.AreEqual("442", module.DebugSolve());

            module = new SkewedSlots(bomb, streamWriter, 801);

            Assert.AreEqual("822", module.DebugSolve());

            module = new SkewedSlots(bomb, streamWriter, 771);

            Assert.AreEqual("422", module.DebugSolve());

            module = new SkewedSlots(bomb, streamWriter, 671);

            Assert.AreEqual("522", module.DebugSolve());

            module = new SkewedSlots(bomb, streamWriter, 202);

            Assert.AreEqual("222", module.DebugSolve());

            module = new SkewedSlots(bomb, streamWriter, 233);

            Assert.AreEqual("217", module.DebugSolve());

            module = new SkewedSlots(bomb, streamWriter, 033);

            Assert.AreEqual("417", module.DebugSolve());

            module = new SkewedSlots(bomb, streamWriter, 349);

            Assert.AreEqual("722", module.DebugSolve());

            module = new SkewedSlots(bomb, streamWriter, 187);

            Assert.AreEqual("905", module.DebugSolve());

            module = new SkewedSlots(bomb, streamWriter, 298);

            Assert.AreEqual("241", module.DebugSolve());

            module = new SkewedSlots(bomb, streamWriter, 992);

            Assert.AreEqual("343", module.DebugSolve());

            module = new SkewedSlots(bomb, streamWriter, 321);

            Assert.AreEqual("752", module.DebugSolve());

            module = new SkewedSlots(bomb, streamWriter, 249);

            Assert.AreEqual("222", module.DebugSolve());

            module = new SkewedSlots(bomb, streamWriter, 131);

            Assert.AreEqual("111", module.DebugSolve());

            module = new SkewedSlots(bomb, streamWriter, 778);

            Assert.AreEqual("421", module.DebugSolve());

            module = new SkewedSlots(bomb, streamWriter, 426);

            Assert.AreEqual("252", module.DebugSolve());

            module = new SkewedSlots(bomb, streamWriter, 136);

            Assert.AreEqual("112", module.DebugSolve());

            module = new SkewedSlots(bomb, streamWriter, 943);

            Assert.AreEqual("322", module.DebugSolve());

            module = new SkewedSlots(bomb, streamWriter, 510);

            Assert.AreEqual("525", module.DebugSolve());

            module = new SkewedSlots(bomb, streamWriter, 881);

            Assert.AreEqual("802", module.DebugSolve());

            module = new SkewedSlots(bomb, streamWriter, 611);

            Assert.AreEqual("521", module.DebugSolve());

            module = new SkewedSlots(bomb, streamWriter, 703);

            Assert.AreEqual("222", module.DebugSolve());

            module = new SkewedSlots(bomb, streamWriter, 272);

            Assert.AreEqual("222", module.DebugSolve());

            module = new SkewedSlots(bomb, streamWriter, 771);

            Assert.AreEqual("422", module.DebugSolve());

            module = new SkewedSlots(bomb, streamWriter, 151);

            Assert.AreEqual("131", module.DebugSolve());

            module = new SkewedSlots(bomb, streamWriter, 106);

            Assert.AreEqual("922", module.DebugSolve());

            module = new SkewedSlots(bomb, streamWriter, 151);

            Assert.AreEqual("131", module.DebugSolve());

            module = new SkewedSlots(bomb, streamWriter, 953);

            Assert.AreEqual("332", module.DebugSolve());

            module = new SkewedSlots(bomb, streamWriter, 805);

            Assert.AreEqual("822", module.DebugSolve());

            module = new SkewedSlots(bomb, streamWriter, 041);

            Assert.AreEqual("222", module.DebugSolve());

            module = new SkewedSlots(bomb, streamWriter, 139);

            Assert.AreEqual("112", module.DebugSolve());

            module = new SkewedSlots(bomb, streamWriter, 356);

            Assert.AreEqual("732", module.DebugSolve());

            module = new SkewedSlots(bomb, streamWriter, 767);

            Assert.AreEqual("244", module.DebugSolve());

            module = new SkewedSlots(bomb, streamWriter, 829);

            Assert.AreEqual("852", module.DebugSolve());

            module = new SkewedSlots(bomb, streamWriter, 838);

            Assert.AreEqual("816", module.DebugSolve());

            module = new SkewedSlots(bomb, streamWriter, 042);

            Assert.AreEqual("223", module.DebugSolve());

            module = new SkewedSlots(bomb, streamWriter, 040);

            Assert.AreEqual("224", module.DebugSolve());

            module = new SkewedSlots(bomb, streamWriter, 736);

            Assert.AreEqual("412", module.DebugSolve());

            module = new SkewedSlots(bomb, streamWriter, 586);

            Assert.AreEqual("502", module.DebugSolve());

            module = new SkewedSlots(bomb, streamWriter, 181);

            Assert.AreEqual("901", module.DebugSolve());

            module = new SkewedSlots(bomb, streamWriter, 557);

            Assert.AreEqual("535", module.DebugSolve());

            module = new SkewedSlots(bomb, streamWriter, 108);

            Assert.AreEqual("921", module.DebugSolve());

            module = new SkewedSlots(bomb, streamWriter, 740);

            Assert.AreEqual("225", module.DebugSolve());

            module = new SkewedSlots(bomb, streamWriter, 276);

            Assert.AreEqual("222", module.DebugSolve());

            module = new SkewedSlots(bomb, streamWriter, 500);

            Assert.AreEqual("524", module.DebugSolve());

            module = new SkewedSlots(bomb, streamWriter, 096);

            Assert.AreEqual("442", module.DebugSolve());

            module = new SkewedSlots(bomb, streamWriter, 673);

            Assert.AreEqual("522", module.DebugSolve());

            module = new SkewedSlots(bomb, streamWriter, 851);

            Assert.AreEqual("832", module.DebugSolve());

            module = new SkewedSlots(bomb, streamWriter, 284);

            Assert.AreEqual("205", module.DebugSolve());

            module = new SkewedSlots(bomb, streamWriter, 866);

            Assert.AreEqual("840", module.DebugSolve());

            module = new SkewedSlots(bomb, streamWriter, 299);

            Assert.AreEqual("243", module.DebugSolve());

            module = new SkewedSlots(bomb, streamWriter, 348);

            Assert.AreEqual("721", module.DebugSolve());

            module = new SkewedSlots(bomb, streamWriter, 625);

            Assert.AreEqual("552", module.DebugSolve());

            module = new SkewedSlots(bomb, streamWriter, 181);

            Assert.AreEqual("901", module.DebugSolve());

            module = new SkewedSlots(bomb, streamWriter, 455);

            Assert.AreEqual("435", module.DebugSolve());

            module = new SkewedSlots(bomb, streamWriter, 950);

            Assert.AreEqual("335", module.DebugSolve());

            module = new SkewedSlots(bomb, streamWriter, 577);

            Assert.AreEqual("524", module.DebugSolve());

            module = new SkewedSlots(bomb, streamWriter, 638);

            Assert.AreEqual("511", module.DebugSolve());

            module = new SkewedSlots(bomb, streamWriter, 570);

            Assert.AreEqual("525", module.DebugSolve());

            module = new SkewedSlots(bomb, streamWriter, 534);

            Assert.AreEqual("515", module.DebugSolve());

            module = new SkewedSlots(bomb, streamWriter, 372);

            Assert.AreEqual("723", module.DebugSolve());

            module = new SkewedSlots(bomb, streamWriter, 069);

            Assert.AreEqual("242", module.DebugSolve());

            module = new SkewedSlots(bomb, streamWriter, 546);

            Assert.AreEqual("522", module.DebugSolve());
        }
    }
}
