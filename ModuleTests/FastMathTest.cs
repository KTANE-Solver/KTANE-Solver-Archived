using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using KTANE_Solver;
using System.Windows.Forms;
using System.IO;
namespace ModuleTests
{
    [TestClass]
    public class FastMathTest
    {
        StreamWriter streamWriter = new StreamWriter("C:\\delete later\\dummy.txt");
        [TestMethod]
        public void LettersGiveCorrectAnswers()
        {
            Bomb bomb = new Bomb(Day.Sunday, "IIIII", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
                    new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
                    new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
                    new Port("ps", 0), new Port("rj", 0), new Port("serial", 0), new Port("setero", 0));

            FastMath module = new FastMath(bomb, streamWriter);

            Assert.AreEqual(25, module.SolveDebug('A', 'A'));
            Assert.AreEqual(11, module.SolveDebug('A', 'B'));
            Assert.AreEqual(53, module.SolveDebug('A', 'C'));
            Assert.AreEqual(97, module.SolveDebug('A', 'D'));
            Assert.AreEqual(2, module.SolveDebug('A', 'E'));
            Assert.AreEqual(42, module.SolveDebug('A', 'G'));
            Assert.AreEqual(51, module.SolveDebug('A', 'K'));
            Assert.AreEqual(97, module.SolveDebug('A', 'N'));
            Assert.AreEqual(12, module.SolveDebug('A', 'P'));
            Assert.AreEqual(86, module.SolveDebug('A', 'S'));
            Assert.AreEqual(55, module.SolveDebug('A', 'T'));
            Assert.AreEqual(73, module.SolveDebug('A', 'X'));
            Assert.AreEqual(33, module.SolveDebug('A', 'Z'));
            Assert.AreEqual(54, module.SolveDebug('B', 'A'));
            Assert.AreEqual(7, module.SolveDebug('B', 'B'));
            Assert.AreEqual(32, module.SolveDebug('B', 'C'));
            Assert.AreEqual(19, module.SolveDebug('B', 'D'));
            Assert.AreEqual(84, module.SolveDebug('B', 'E'));
            Assert.AreEqual(33, module.SolveDebug('B', 'G'));
            Assert.AreEqual(27, module.SolveDebug('B', 'K'));
            Assert.AreEqual(78, module.SolveDebug('B', 'N'));
            Assert.AreEqual(26, module.SolveDebug('B', 'P'));
            Assert.AreEqual(46, module.SolveDebug('B', 'S'));
            Assert.AreEqual(9, module.SolveDebug('B', 'T'));
            Assert.AreEqual(13, module.SolveDebug('B', 'X'));
            Assert.AreEqual(58, module.SolveDebug('B', 'Z'));
            Assert.AreEqual(86, module.SolveDebug('C', 'A'));
            Assert.AreEqual(37, module.SolveDebug('C', 'B'));
            Assert.AreEqual(44, module.SolveDebug('C', 'C'));
            Assert.AreEqual(1, module.SolveDebug('C', 'D'));
            Assert.AreEqual(5, module.SolveDebug('C', 'E'));
            Assert.AreEqual(26, module.SolveDebug('C', 'G'));
            Assert.AreEqual(93, module.SolveDebug('C', 'K'));
            Assert.AreEqual(49, module.SolveDebug('C', 'N'));
            Assert.AreEqual(18, module.SolveDebug('C', 'P'));
            Assert.AreEqual(69, module.SolveDebug('C', 'S'));
            Assert.AreEqual(23, module.SolveDebug('C', 'T'));
            Assert.AreEqual(40, module.SolveDebug('C', 'X'));
            Assert.AreEqual(22, module.SolveDebug('C', 'Z'));
            Assert.AreEqual(54, module.SolveDebug('D', 'A'));
            Assert.AreEqual(28, module.SolveDebug('D', 'B'));
            Assert.AreEqual(77, module.SolveDebug('D', 'C'));
            Assert.AreEqual(93, module.SolveDebug('D', 'D'));
            Assert.AreEqual(11, module.SolveDebug('D', 'E'));
            Assert.AreEqual(0, module.SolveDebug('D', 'G'));
            Assert.AreEqual(35, module.SolveDebug('D', 'K'));
            Assert.AreEqual(61, module.SolveDebug('D', 'N'));
            Assert.AreEqual(27, module.SolveDebug('D', 'P'));
            Assert.AreEqual(48, module.SolveDebug('D', 'S'));
            Assert.AreEqual(13, module.SolveDebug('D', 'T'));
            Assert.AreEqual(72, module.SolveDebug('D', 'X'));
            Assert.AreEqual(80, module.SolveDebug('D', 'Z'));
            Assert.AreEqual(99, module.SolveDebug('E', 'A'));
            Assert.AreEqual(36, module.SolveDebug('E', 'B'));
            Assert.AreEqual(23, module.SolveDebug('E', 'C'));
            Assert.AreEqual(95, module.SolveDebug('E', 'D'));
            Assert.AreEqual(67, module.SolveDebug('E', 'E'));
            Assert.AreEqual(5, module.SolveDebug('E', 'G'));
            Assert.AreEqual(26, module.SolveDebug('E', 'K'));
            Assert.AreEqual(17, module.SolveDebug('E', 'N'));
            Assert.AreEqual(44, module.SolveDebug('E', 'P'));
            Assert.AreEqual(60, module.SolveDebug('E', 'S'));
            Assert.AreEqual(26, module.SolveDebug('E', 'T'));
            Assert.AreEqual(41, module.SolveDebug('E', 'X'));
            Assert.AreEqual(67, module.SolveDebug('E', 'Z'));
            Assert.AreEqual(74, module.SolveDebug('G', 'A'));
            Assert.AreEqual(95, module.SolveDebug('G', 'B'));
            Assert.AreEqual(3, module.SolveDebug('G', 'C'));
            Assert.AreEqual(4, module.SolveDebug('G', 'D'));
            Assert.AreEqual(56, module.SolveDebug('G', 'E'));
            Assert.AreEqual(23, module.SolveDebug('G', 'G'));
            Assert.AreEqual(54, module.SolveDebug('G', 'K'));
            Assert.AreEqual(29, module.SolveDebug('G', 'N'));
            Assert.AreEqual(52, module.SolveDebug('G', 'P'));
            Assert.AreEqual(38, module.SolveDebug('G', 'S'));
            Assert.AreEqual(10, module.SolveDebug('G', 'T'));
            Assert.AreEqual(76, module.SolveDebug('G', 'X'));
            Assert.AreEqual(98, module.SolveDebug('G', 'Z'));
            Assert.AreEqual(88, module.SolveDebug('K', 'A'));
            Assert.AreEqual(46, module.SolveDebug('K', 'B'));
            Assert.AreEqual(37, module.SolveDebug('K', 'C'));
            Assert.AreEqual(96, module.SolveDebug('K', 'D'));
            Assert.AreEqual(2, module.SolveDebug('K', 'E'));
            Assert.AreEqual(52, module.SolveDebug('K', 'G'));
            Assert.AreEqual(81, module.SolveDebug('K', 'K'));
            Assert.AreEqual(37, module.SolveDebug('K', 'N'));
            Assert.AreEqual(12, module.SolveDebug('K', 'P'));
            Assert.AreEqual(70, module.SolveDebug('K', 'S'));
            Assert.AreEqual(14, module.SolveDebug('K', 'T'));
            Assert.AreEqual(36, module.SolveDebug('K', 'X'));
            Assert.AreEqual(78, module.SolveDebug('K', 'Z'));
            Assert.AreEqual(54, module.SolveDebug('N', 'A'));
            Assert.AreEqual(43, module.SolveDebug('N', 'B'));
            Assert.AreEqual(12, module.SolveDebug('N', 'C'));
            Assert.AreEqual(65, module.SolveDebug('N', 'D'));
            Assert.AreEqual(94, module.SolveDebug('N', 'E'));
            Assert.AreEqual(3, module.SolveDebug('N', 'G'));
            Assert.AreEqual(47, module.SolveDebug('N', 'K'));
            Assert.AreEqual(23, module.SolveDebug('N', 'N'));
            Assert.AreEqual(16, module.SolveDebug('N', 'P'));
            Assert.AreEqual(62, module.SolveDebug('N', 'S'));
            Assert.AreEqual(73, module.SolveDebug('N', 'T'));
            Assert.AreEqual(46, module.SolveDebug('N', 'X'));
            Assert.AreEqual(21, module.SolveDebug('N', 'Z'));
            Assert.AreEqual(7, module.SolveDebug('P', 'A'));
            Assert.AreEqual(33, module.SolveDebug('P', 'B'));
            Assert.AreEqual(26, module.SolveDebug('P', 'C'));
            Assert.AreEqual(1, module.SolveDebug('P', 'D'));
            Assert.AreEqual(67, module.SolveDebug('P', 'E'));
            Assert.AreEqual(26, module.SolveDebug('P', 'G'));
            Assert.AreEqual(27, module.SolveDebug('P', 'K'));
            Assert.AreEqual(77, module.SolveDebug('P', 'N'));
            Assert.AreEqual(83, module.SolveDebug('P', 'P'));
            Assert.AreEqual(14, module.SolveDebug('P', 'S'));
            Assert.AreEqual(27, module.SolveDebug('P', 'T'));
            Assert.AreEqual(93, module.SolveDebug('P', 'X'));
            Assert.AreEqual(9, module.SolveDebug('P', 'Z'));
            Assert.AreEqual(63, module.SolveDebug('S', 'A'));
            Assert.AreEqual(64, module.SolveDebug('S', 'B'));
            Assert.AreEqual(94, module.SolveDebug('S', 'C'));
            Assert.AreEqual(27, module.SolveDebug('S', 'D'));
            Assert.AreEqual(48, module.SolveDebug('S', 'E'));
            Assert.AreEqual(84, module.SolveDebug('S', 'G'));
            Assert.AreEqual(33, module.SolveDebug('S', 'K'));
            Assert.AreEqual(10, module.SolveDebug('S', 'N'));
            Assert.AreEqual(16, module.SolveDebug('S', 'P'));
            Assert.AreEqual(74, module.SolveDebug('S', 'S'));
            Assert.AreEqual(43, module.SolveDebug('S', 'T'));
            Assert.AreEqual(99, module.SolveDebug('S', 'X'));
            Assert.AreEqual(4, module.SolveDebug('S', 'Z'));
            Assert.AreEqual(35, module.SolveDebug('T', 'A'));
            Assert.AreEqual(39, module.SolveDebug('T', 'B'));
            Assert.AreEqual(3, module.SolveDebug('T', 'C'));
            Assert.AreEqual(25, module.SolveDebug('T', 'D'));
            Assert.AreEqual(47, module.SolveDebug('T', 'E'));
            Assert.AreEqual(62, module.SolveDebug('T', 'G'));
            Assert.AreEqual(38, module.SolveDebug('T', 'K'));
            Assert.AreEqual(45, module.SolveDebug('T', 'N'));
            Assert.AreEqual(88, module.SolveDebug('T', 'P'));
            Assert.AreEqual(48, module.SolveDebug('T', 'S'));
            Assert.AreEqual(34, module.SolveDebug('T', 'T'));
            Assert.AreEqual(31, module.SolveDebug('T', 'X'));
            Assert.AreEqual(27, module.SolveDebug('T', 'Z'));
            Assert.AreEqual(67, module.SolveDebug('X', 'A'));
            Assert.AreEqual(30, module.SolveDebug('X', 'B'));
            Assert.AreEqual(27, module.SolveDebug('X', 'C'));
            Assert.AreEqual(71, module.SolveDebug('X', 'D'));
            Assert.AreEqual(9, module.SolveDebug('X', 'E'));
            Assert.AreEqual(11, module.SolveDebug('X', 'G'));
            Assert.AreEqual(44, module.SolveDebug('X', 'K'));
            Assert.AreEqual(37, module.SolveDebug('X', 'N'));
            Assert.AreEqual(18, module.SolveDebug('X', 'P'));
            Assert.AreEqual(40, module.SolveDebug('X', 'S'));
            Assert.AreEqual(32, module.SolveDebug('X', 'T'));
            Assert.AreEqual(15, module.SolveDebug('X', 'X'));
            Assert.AreEqual(78, module.SolveDebug('X', 'Z'));
            Assert.AreEqual(13, module.SolveDebug('Z', 'A'));
            Assert.AreEqual(23, module.SolveDebug('Z', 'B'));
            Assert.AreEqual(26, module.SolveDebug('Z', 'C'));
            Assert.AreEqual(85, module.SolveDebug('Z', 'D'));
            Assert.AreEqual(92, module.SolveDebug('Z', 'E'));
            Assert.AreEqual(12, module.SolveDebug('Z', 'G'));
            Assert.AreEqual(73, module.SolveDebug('Z', 'K'));
            Assert.AreEqual(56, module.SolveDebug('Z', 'N'));
            Assert.AreEqual(81, module.SolveDebug('Z', 'P'));
            Assert.AreEqual(7, module.SolveDebug('Z', 'S'));
            Assert.AreEqual(75, module.SolveDebug('Z', 'T'));
            Assert.AreEqual(47, module.SolveDebug('Z', 'X'));
            Assert.AreEqual(99, module.SolveDebug('Z', 'Z'));



            streamWriter.Close();
        }

        [TestMethod]
        public void Overrides()
        {
            Bomb bomb = new Bomb(Day.Sunday, "IIIII", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
        new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", true, true), new Indicator("NSA", false, false),
        new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
        new Port("ps", 0), new Port("rj", 0), new Port("serial", 0), new Port("setero", 0));

            FastMath module = new FastMath(bomb, streamWriter);

            Assert.AreEqual(25 + 20, module.SolveDebug('A', 'A'));

            bomb = new Bomb(Day.Sunday, "IIIII", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
        new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
        new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
        new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

            module = new FastMath(bomb, streamWriter);

            Assert.AreEqual(25 + 14, module.SolveDebug('A', 'A'));

            bomb = new Bomb(Day.Sunday, "F", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
        new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
        new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
        new Port("ps", 0), new Port("rj", 0), new Port("serial", 0), new Port("setero", 0));

            module = new FastMath(bomb, streamWriter);
            
            Assert.AreEqual(25 - 5, module.SolveDebug('A', 'A'));


            bomb = new Bomb(Day.Sunday, "IIIII", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
        new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
        new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
        new Port("ps", 0), new Port("rj", 1), new Port("serial", 0), new Port("setero", 0));

            module = new FastMath(bomb, streamWriter);

            Assert.AreEqual(25 + 27, module.SolveDebug('A', 'A'));

            bomb = new Bomb(Day.Sunday, "IIIII", 4, 4, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
        new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
        new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
        new Port("ps", 0), new Port("rj", 0), new Port("serial", 0), new Port("setero", 0));

            module = new FastMath(bomb, streamWriter);

            Assert.AreEqual(25 - 15, module.SolveDebug('A', 'A'));
        }
    }
}
