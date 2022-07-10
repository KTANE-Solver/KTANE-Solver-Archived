using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using KTANE_Solver;
using System.Windows.Forms;
using System.IO;
namespace ModuleTests
{
    [TestClass]
    public class TicTacToeTest
    {
        StreamWriter streamWriter = new StreamWriter("C:\\delete later\\dummy.txt");

        [TestMethod]
        public void CorrectTicTacToe()
        {
            //Horizontal Top row
            char[,] grid = new char[,] { { 'X', 'X', 'X' }, 
                                         { '1', '2', '3' }, 
                                         { '4', '5', '6'}
            };
            TicTacToe module = new TicTacToe(null, streamWriter, grid);

            Assert.IsTrue(module.MakesTicTacToe(0, 0));

            //Horizontal Middle row
            grid = new char[,] { { '1', '2', '3' },
                                 { 'X', 'X', 'X' },
                                 { '4', '5', '6'} 
            };

            module = new TicTacToe(null, streamWriter, grid);

            Assert.IsTrue(module.MakesTicTacToe(1, 0));

            //Horizontal Bottom row
            grid = new char[,] { { '1', '2', '3' },
                                 { '4', '5', '6'},
                                 { 'X', 'X', 'X' },
            };

            module = new TicTacToe(null, streamWriter, grid);

            Assert.IsTrue(module.MakesTicTacToe(2, 0));

            //Vertical first column
            grid = new char[,] { { 'X', '1', '4' },
                                 { 'X', '2', '5'},
                                 { 'X', '3', '6' },
            };

            module = new TicTacToe(null, streamWriter, grid);

            Assert.IsTrue(module.MakesTicTacToe(0, 0));

            //Vertical second column
            grid = new char[,] { { '1', 'X', '4' },
                                 { '2', 'X', '5'},
                                 { '3', 'X', '6' },
            };

            module = new TicTacToe(null, streamWriter, grid);

            Assert.IsTrue(module.MakesTicTacToe(0, 1));

            //Vertical third column
            grid = new char[,] { { '1', '4', 'X' },
                                 { '2', '5', 'X'},
                                 { '3', '6', 'X' },
            };

            module = new TicTacToe(null, streamWriter, grid);

            Assert.IsTrue(module.MakesTicTacToe(0, 2));

            //Diagnol top left
            grid = new char[,] { { 'X', '1', '2' },
                                 { '3', 'X', '6'},
                                 { '4', '5', 'X' },
            };

            module = new TicTacToe(null, streamWriter, grid);

            Assert.IsTrue(module.MakesTicTacToe(0, 0));

            //Diagnol bottom left
            grid = new char[,] { { '5', '1', 'X' },
                                 { '3', 'X', '6'},
                                 { 'X', '5', '4' },
            };

            module = new TicTacToe(null, streamWriter, grid);

            Assert.IsTrue(module.MakesTicTacToe(2, 0));

            //test 1
            grid = new char[,] { { 'O', 'O', 'X' },
                                 { 'X', '6', 'O'},
                                 { '7', '8', 'X' },
            };

            module = new TicTacToe(null, streamWriter, grid);
            Assert.IsFalse(module.MakesTicTacToe(0, 1));


            streamWriter.Close();
        }

        [TestMethod]
        public void InitialStartingRow()
        {

            //1
            Bomb bomb = new Bomb(Day.Sunday, "1", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
                   new Indicator("CLR", false, false), new Indicator("FRK", true, false), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
                   new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", false, false), false, 2, new Port("DVID", 0), new Port("Parallel", 0),
                   new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

            TicTacToe module = new TicTacToe(bomb, streamWriter, null);
            module.FindStartingRow();

            Assert.AreEqual(1, module.currentRow);

            //2
            bomb = new Bomb(Day.Sunday, "1", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
            new Indicator("CLR", false, false), new Indicator("FRK", true, false), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
            new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", false, false), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
            new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

            module = new TicTacToe(bomb, streamWriter, null);
            module.FindStartingRow();

            Assert.AreEqual(2, module.currentRow);

            //3
            bomb = new Bomb(Day.Sunday, "1", 1, 1, new Indicator("BOB", true, false), new Indicator("CAR", true, true),
            new Indicator("CLR", false, false), new Indicator("FRK", false, false), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
            new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", false, false), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
            new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

            module = new TicTacToe(bomb, streamWriter, null);
            module.FindStartingRow();

            Assert.AreEqual(3, module.currentRow);

            //4
            bomb = new Bomb(Day.Sunday, "1", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", true, true),
            new Indicator("CLR", false, false), new Indicator("FRK", false, false), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
            new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", false, false), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
            new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

            module = new TicTacToe(bomb, streamWriter, null);
            module.FindStartingRow();

            Assert.AreEqual(4, module.currentRow);

            //5
            bomb = new Bomb(Day.Sunday, "0", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
                   new Indicator("CLR", false, false), new Indicator("FRK", true, false), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
                   new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", false, false), false, 2, new Port("DVID", 0), new Port("Parallel", 0),
                   new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

            module = new TicTacToe(bomb, streamWriter, null);
            module.FindStartingRow();

            Assert.AreEqual(5, module.currentRow);

            //6
            bomb = new Bomb(Day.Sunday, "0", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
            new Indicator("CLR", false, false), new Indicator("FRK", true, false), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
            new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", false, false), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
            new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

            module = new TicTacToe(bomb, streamWriter, null);
            module.FindStartingRow();

            Assert.AreEqual(6, module.currentRow);

            //7
            bomb = new Bomb(Day.Sunday, "0", 1, 1, new Indicator("BOB", true, false), new Indicator("CAR", true, true),
            new Indicator("CLR", false, false), new Indicator("FRK", false, false), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
            new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", false, false), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
            new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

            module = new TicTacToe(bomb, streamWriter, null);
            module.FindStartingRow();

            Assert.AreEqual(7, module.currentRow);

            //8
            bomb = new Bomb(Day.Sunday, "0", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", true, true),
            new Indicator("CLR", false, false), new Indicator("FRK", false, false), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
            new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", false, false), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
            new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

            module = new TicTacToe(bomb, streamWriter, null);
            module.FindStartingRow();

            Assert.AreEqual(8, module.currentRow);

            streamWriter.Close();
        }

        [TestMethod]
        public void Table()
        {
            #region More X
            char[,] grid = new char[,] { { 'X', '1', '1' }, { '1', '1', '1' }, { '1', '1', '1' } };


            TicTacToe module = new TicTacToe(null, streamWriter, grid);


            module.currentRow = 1;

            Assert.AreEqual('9', module.PlaceSymbol('X'));
            Assert.AreEqual('3', module.PlaceSymbol('O'));

            module.currentRow = 2;

            Assert.AreEqual('5', module.PlaceSymbol('X'));
            Assert.AreEqual('6', module.PlaceSymbol('O'));

            module.currentRow = 3;

            Assert.AreEqual('7', module.PlaceSymbol('X'));
            Assert.AreEqual('8', module.PlaceSymbol('O'));

            module.currentRow = 4;

            Assert.AreEqual('4', module.PlaceSymbol('X'));
            Assert.AreEqual('5', module.PlaceSymbol('O'));

            module.currentRow = 5;

            Assert.AreEqual('1', module.PlaceSymbol('X'));
            Assert.AreEqual('4', module.PlaceSymbol('O'));

            module.currentRow = 6;

            Assert.AreEqual('8', module.PlaceSymbol('X'));
            Assert.AreEqual('7', module.PlaceSymbol('O'));

            module.currentRow = 7;

            Assert.AreEqual('6', module.PlaceSymbol('X'));
            Assert.AreEqual('1', module.PlaceSymbol('O'));

            module.currentRow = 8;

            Assert.AreEqual('2', module.PlaceSymbol('X'));
            Assert.AreEqual('2', module.PlaceSymbol('O'));

            module.currentRow = 9;

            Assert.AreEqual('3', module.PlaceSymbol('X'));
            Assert.AreEqual('9', module.PlaceSymbol('O'));

            #endregion

            #region More O
            grid = new char[,] { { 'O', '1', '1' }, { '1', '1', '1' }, { '1', '1', '1' } };

            module = new TicTacToe(null, streamWriter, grid);


            module.currentRow = 1;

            Assert.AreEqual('3', module.PlaceSymbol('X'));
            Assert.AreEqual('9', module.PlaceSymbol('O'));

            module.currentRow = 2;

            Assert.AreEqual('6', module.PlaceSymbol('X'));
            Assert.AreEqual('7', module.PlaceSymbol('O'));

            module.currentRow = 3;

            Assert.AreEqual('2', module.PlaceSymbol('X'));
            Assert.AreEqual('1', module.PlaceSymbol('O'));

            module.currentRow = 4;

            Assert.AreEqual('7', module.PlaceSymbol('X'));
            Assert.AreEqual('8', module.PlaceSymbol('O'));

            module.currentRow = 5;

            Assert.AreEqual('1', module.PlaceSymbol('X'));
            Assert.AreEqual('6', module.PlaceSymbol('O'));

            module.currentRow = 6;

            Assert.AreEqual('5', module.PlaceSymbol('X'));
            Assert.AreEqual('2', module.PlaceSymbol('O'));

            module.currentRow = 7;

            Assert.AreEqual('8', module.PlaceSymbol('X'));
            Assert.AreEqual('4', module.PlaceSymbol('O'));

            module.currentRow = 8;

            Assert.AreEqual('9', module.PlaceSymbol('X'));
            Assert.AreEqual('5', module.PlaceSymbol('O'));

            module.currentRow = 9;

            Assert.AreEqual('4', module.PlaceSymbol('X'));
            Assert.AreEqual('3', module.PlaceSymbol('O'));



            #endregion

            #region Even
            grid = new char[,] { { 'O', 'X', '1' }, { '1', '1', '1' }, { '1', '1', '1' } };
            module = new TicTacToe(null, streamWriter, grid);


            module.currentRow = 1;

            Assert.AreEqual('8', module.PlaceSymbol('X'));
            Assert.AreEqual('1', module.PlaceSymbol('O'));

            module.currentRow = 2;

            Assert.AreEqual('1', module.PlaceSymbol('X'));
            Assert.AreEqual('2', module.PlaceSymbol('O'));

            module.currentRow = 3;

            Assert.AreEqual('5', module.PlaceSymbol('X'));
            Assert.AreEqual('8', module.PlaceSymbol('O'));

            module.currentRow = 4;

            Assert.AreEqual('9', module.PlaceSymbol('X'));
            Assert.AreEqual('6', module.PlaceSymbol('O'));

            module.currentRow = 5;

            Assert.AreEqual('7', module.PlaceSymbol('X'));
            Assert.AreEqual('3', module.PlaceSymbol('O'));

            module.currentRow = 6;

            Assert.AreEqual('4', module.PlaceSymbol('X'));
            Assert.AreEqual('4', module.PlaceSymbol('O'));

            module.currentRow = 7;

            Assert.AreEqual('3', module.PlaceSymbol('X'));
            Assert.AreEqual('9', module.PlaceSymbol('O'));

            module.currentRow = 8;

            Assert.AreEqual('2', module.PlaceSymbol('X'));
            Assert.AreEqual('5', module.PlaceSymbol('O'));

            module.currentRow = 9;

            Assert.AreEqual('6', module.PlaceSymbol('X'));
            Assert.AreEqual('7', module.PlaceSymbol('O'));

            #endregion

            streamWriter.Close();
        }
    }
}
