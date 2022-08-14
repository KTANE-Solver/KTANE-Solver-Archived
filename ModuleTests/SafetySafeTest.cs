using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using KTANE_Solver;
using System.IO;
using System.Windows.Forms;

namespace ModuleTests
{
    [TestClass]
    public class SafetySafeTest
    {

        StreamWriter streamWriter = new StreamWriter("dummy.txt");


        [TestMethod]
        public void Rule1()
        {
            Bomb bomb;

            for (int i = 0; i < 26; i++)
            {
                char letter = (char)(i + 65);

                string serialNumber = "" + letter + letter + letter + letter + letter + letter;
                bomb = new Bomb(Day.Sunday, serialNumber, 0, 0, new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), false, 0, new Port("", 0), new Port("", 0), new Port("", 0), new Port("", 0), new Port("", 0), new Port("", 0));

                SafetySafe module = new SafetySafe(bomb, streamWriter);

                module.Debug();


                switch (letter)
                {
                    case 'A':
                        Assert.AreEqual(8, module.firstTurn);
                        break;

                    case 'B':
                        Assert.AreEqual(10, module.firstTurn);
                        break;

                    case 'C':
                        Assert.AreEqual(2, module.firstTurn);
                        break;

                    case 'D':
                        Assert.AreEqual(11, module.firstTurn);
                        break;

                    case 'E':
                        Assert.AreEqual(0, module.firstTurn);
                        break;

                    case 'F':
                        Assert.AreEqual(4, module.firstTurn);
                        break;

                    case 'G':
                        Assert.AreEqual(7, module.firstTurn);
                        break;

                    case 'H':
                        Assert.AreEqual(8, module.firstTurn);
                        break;

                    case 'I':
                        Assert.AreEqual(0, module.firstTurn);
                        break;

                    case 'J':
                        Assert.AreEqual(2, module.firstTurn);
                        break;

                    case 'K':
                        Assert.AreEqual(5, module.firstTurn);
                        break;

                    case 'L':
                        Assert.AreEqual(1, module.firstTurn);
                        break;

                    case 'M':
                        Assert.AreEqual(1, module.firstTurn);
                        break;

                    case 'N':
                        Assert.AreEqual(9, module.firstTurn);
                        break;

                    case 'O':
                        Assert.AreEqual(5, module.firstTurn);
                        break;

                    case 'P':
                        Assert.AreEqual(3, module.firstTurn);
                        break;

                    case 'Q':
                        Assert.AreEqual(4, module.firstTurn);
                        break;

                    case 'R':
                        Assert.AreEqual(8, module.firstTurn);
                        break;

                    case 'S':
                        Assert.AreEqual(9, module.firstTurn);
                        break;

                    case 'T':
                        Assert.AreEqual(7, module.firstTurn);
                        break;

                    case 'U':
                        Assert.AreEqual(11, module.firstTurn);
                        break;

                    case 'V':
                        Assert.AreEqual(11, module.firstTurn);
                        break;

                    case 'W':
                        Assert.AreEqual(6, module.firstTurn);
                        break;

                    case 'X':
                        Assert.AreEqual(4, module.firstTurn);
                        break;

                    case 'Y':
                        Assert.AreEqual(10, module.firstTurn);
                        break;

                    case 'Z':
                        Assert.AreEqual(3, module.firstTurn);
                        break;

                    case '0':
                        Assert.AreEqual(7, module.firstTurn);
                        break;

                    case '1':
                        Assert.AreEqual(9, module.firstTurn);
                        break;

                    case '2':
                        Assert.AreEqual(2, module.firstTurn);
                        break;

                    case '3':
                        Assert.AreEqual(10, module.firstTurn);
                        break;

                    case '4':
                        Assert.AreEqual(6, module.firstTurn);
                        break;

                    case '5':
                        Assert.AreEqual(6, module.firstTurn);
                        break;

                    case '6':
                        Assert.AreEqual(1, module.firstTurn);
                        break;

                    case '7':
                        Assert.AreEqual(0, module.firstTurn);
                        break;

                    case '8':
                        Assert.AreEqual(5, module.firstTurn);
                        break;

                    case '9':
                        Assert.AreEqual(3, module.firstTurn);
                        break;
                }
            }

            streamWriter.Close();
        }

        [TestMethod]
        public void Rule2()
        {
            Bomb bomb;

            for (int i = 0; i < 26; i++)
            {
                char letter = (char)(i + 65);

                string serialNumber = "" + letter + letter + letter + letter + letter + letter;
                bomb = new Bomb(Day.Sunday, serialNumber, 0, 0, new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), false, 0, new Port("", 0), new Port("", 0), new Port("", 0), new Port("", 0), new Port("", 0), new Port("", 0));

                SafetySafe module = new SafetySafe(bomb, streamWriter);

                module.Debug();


                switch (letter)
                {
                    case 'A':
                        Assert.AreEqual(3, module.secondTurn);
                        break;

                    case 'B':
                        Assert.AreEqual(1, module.secondTurn);
                        break;

                    case 'C':
                        Assert.AreEqual(1, module.secondTurn);
                        break;

                    case 'D':
                        Assert.AreEqual(6, module.secondTurn);
                        break;

                    case 'E':
                        Assert.AreEqual(5, module.secondTurn);
                        break;

                    case 'F':
                        Assert.AreEqual(2, module.secondTurn);
                        break;

                    case 'G':
                        Assert.AreEqual(4, module.secondTurn);
                        break;

                    case 'H':
                        Assert.AreEqual(3, module.secondTurn);
                        break;

                    case 'I':
                        Assert.AreEqual(11, module.secondTurn);
                        break;

                    case 'J':
                        Assert.AreEqual(11, module.secondTurn);
                        break;

                    case 'K':
                        Assert.AreEqual(2, module.secondTurn);
                        break;

                    case 'L':
                        Assert.AreEqual(9, module.secondTurn);
                        break;

                    case 'M':
                        Assert.AreEqual(7, module.secondTurn);
                        break;

                    case 'N':
                        Assert.AreEqual(5, module.secondTurn);
                        break;

                    case 'O':
                        Assert.AreEqual(9, module.secondTurn);
                        break;

                    case 'P':
                        Assert.AreEqual(10, module.secondTurn);
                        break;

                    case 'Q':
                        Assert.AreEqual(10, module.secondTurn);
                        break;

                    case 'R':
                        Assert.AreEqual(0, module.secondTurn);
                        break;

                    case 'S':
                        Assert.AreEqual(4, module.secondTurn);
                        break;

                    case 'T':
                        Assert.AreEqual(6, module.secondTurn);
                        break;

                    case 'U':
                        Assert.AreEqual(9, module.secondTurn);
                        break;

                    case 'V':
                        Assert.AreEqual(11, module.secondTurn);
                        break;

                    case 'W':
                        Assert.AreEqual(0, module.secondTurn);
                        break;

                    case 'X':
                        Assert.AreEqual(2, module.secondTurn);
                        break;

                    case 'Y':
                        Assert.AreEqual(7, module.secondTurn);
                        break;

                    case 'Z':
                        Assert.AreEqual(7, module.secondTurn);
                        break;

                    case '0':
                        Assert.AreEqual(0, module.secondTurn);
                        break;

                    case '1':
                        Assert.AreEqual(10, module.secondTurn);
                        break;

                    case '2':
                        Assert.AreEqual(5, module.secondTurn);
                        break;

                    case '3':
                        Assert.AreEqual(8, module.secondTurn);
                        break;

                    case '4':
                        Assert.AreEqual(8, module.secondTurn);
                        break;

                    case '5':
                        Assert.AreEqual(3, module.secondTurn);
                        break;

                    case '6':
                        Assert.AreEqual(1, module.secondTurn);
                        break;

                    case '7':
                        Assert.AreEqual(6, module.secondTurn);
                        break;

                    case '8':
                        Assert.AreEqual(4, module.secondTurn);
                        break;

                    case '9':
                        Assert.AreEqual(8, module.secondTurn);
                        break;
                }
            }
            streamWriter.Close();

        }

        [TestMethod]
        public void Rule3()
        {
            Bomb bomb;

            for (int i = 0; i < 26; i++)
            {
                char letter = (char)(i + 65);

                string serialNumber = "" + letter + letter + letter + letter + letter + letter;
                bomb = new Bomb(Day.Sunday, serialNumber, 0, 0, new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), false, 0, new Port("", 0), new Port("", 0), new Port("", 0), new Port("", 0), new Port("", 0), new Port("", 0));

                SafetySafe module = new SafetySafe(bomb, streamWriter);

                module.Debug();


                switch (letter)
                {
                    case 'A':
                        Assert.AreEqual(4, module.thirdTurn);
                        break;

                    case 'B':
                        Assert.AreEqual(3, module.thirdTurn);
                        break;

                    case 'C':
                        Assert.AreEqual(1, module.thirdTurn);
                        break;

                    case 'D':
                        Assert.AreEqual(11, module.thirdTurn);
                        break;

                    case 'E':
                        Assert.AreEqual(5, module.thirdTurn);
                        break;

                    case 'F':
                        Assert.AreEqual(7, module.thirdTurn);
                        break;

                    case 'G':
                        Assert.AreEqual(4, module.thirdTurn);
                        break;

                    case 'H':
                        Assert.AreEqual(6, module.thirdTurn);
                        break;

                    case 'I':
                        Assert.AreEqual(0, module.thirdTurn);
                        break;

                    case 'J':
                        Assert.AreEqual(8, module.thirdTurn);
                        break;

                    case 'K':
                        Assert.AreEqual(5, module.thirdTurn);
                        break;

                    case 'L':
                        Assert.AreEqual(8, module.thirdTurn);
                        break;

                    case 'M':
                        Assert.AreEqual(9, module.thirdTurn);
                        break;

                    case 'N':
                        Assert.AreEqual(1, module.thirdTurn);
                        break;

                    case 'O':
                        Assert.AreEqual(8, module.thirdTurn);
                        break;

                    case 'P':
                        Assert.AreEqual(9, module.thirdTurn);
                        break;

                    case 'Q':
                        Assert.AreEqual(6, module.thirdTurn);
                        break;

                    case 'R':
                        Assert.AreEqual(4, module.thirdTurn);
                        break;

                    case 'S':
                        Assert.AreEqual(0, module.thirdTurn);
                        break;

                    case 'T':
                        Assert.AreEqual(7, module.thirdTurn);
                        break;

                    case 'U':
                        Assert.AreEqual(6, module.thirdTurn);
                        break;

                    case 'V':
                        Assert.AreEqual(2, module.thirdTurn);
                        break;

                    case 'W':
                        Assert.AreEqual(11, module.thirdTurn);
                        break;

                    case 'X':
                        Assert.AreEqual(7, module.thirdTurn);
                        break;

                    case 'Y':
                        Assert.AreEqual(10, module.thirdTurn);
                        break;

                    case 'Z':
                        Assert.AreEqual(1, module.thirdTurn);
                        break;

                    case '0':
                        Assert.AreEqual(3, module.thirdTurn);
                        break;

                    case '1':
                        Assert.AreEqual(10, module.thirdTurn);
                        break;

                    case '2':
                        Assert.AreEqual(11, module.thirdTurn);
                        break;

                    case '3':
                        Assert.AreEqual(10, module.thirdTurn);
                        break;

                    case '4':
                        Assert.AreEqual(0, module.thirdTurn);
                        break;

                    case '5':
                        Assert.AreEqual(3, module.thirdTurn);
                        break;

                    case '6':
                        Assert.AreEqual(5, module.thirdTurn);
                        break;

                    case '7':
                        Assert.AreEqual(2, module.thirdTurn);
                        break;

                    case '8':
                        Assert.AreEqual(9, module.thirdTurn);
                        break;

                    case '9':
                        Assert.AreEqual(2, module.thirdTurn);
                        break;
                }
            }

            streamWriter.Close();

        }


        [TestMethod]
        public void Rule4()

        {
            Bomb bomb;

            for (int i = 0; i < 26; i++)
            {
                char letter = (char)(i + 65);

                string serialNumber = "" + letter + letter + letter + letter + letter + letter;
                bomb = new Bomb(Day.Sunday, serialNumber, 0, 0, new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), false, 0, new Port("", 0), new Port("", 0), new Port("", 0), new Port("", 0), new Port("", 0), new Port("", 0));

                SafetySafe module = new SafetySafe(bomb, streamWriter);

                module.Debug();


                switch (letter)
                {
                    case 'A':
                        Assert.AreEqual(8, module.fourthTurn);
                        break;

                    case 'B':
                        Assert.AreEqual(7, module.fourthTurn);
                        break;

                    case 'C':
                        Assert.AreEqual(5, module.fourthTurn);
                        break;

                    case 'D':
                        Assert.AreEqual(11, module.fourthTurn);
                        break;

                    case 'E':
                        Assert.AreEqual(8, module.fourthTurn);
                        break;

                    case 'F':
                        Assert.AreEqual(7, module.fourthTurn);
                        break;

                    case 'G':
                        Assert.AreEqual(2, module.fourthTurn);
                        break;

                    case 'H':
                        Assert.AreEqual(6, module.fourthTurn);
                        break;

                    case 'I':
                        Assert.AreEqual(0, module.fourthTurn);
                        break;

                    case 'J':
                        Assert.AreEqual(0, module.fourthTurn);
                        break;

                    case 'K':
                        Assert.AreEqual(1, module.fourthTurn);
                        break;

                    case 'L':
                        Assert.AreEqual(11, module.fourthTurn);
                        break;

                    case 'M':
                        Assert.AreEqual(5, module.fourthTurn);
                        break;

                    case 'N':
                        Assert.AreEqual(4, module.fourthTurn);
                        break;

                    case 'O':
                        Assert.AreEqual(10, module.fourthTurn);
                        break;

                    case 'P':
                        Assert.AreEqual(1, module.fourthTurn);
                        break;

                    case 'Q':
                        Assert.AreEqual(1, module.fourthTurn);
                        break;

                    case 'R':
                        Assert.AreEqual(0, module.fourthTurn);
                        break;

                    case 'S':
                        Assert.AreEqual(6, module.fourthTurn);
                        break;

                    case 'T':
                        Assert.AreEqual(11, module.fourthTurn);
                        break;

                    case 'U':
                        Assert.AreEqual(3, module.fourthTurn);
                        break;

                    case 'V':
                        Assert.AreEqual(8, module.fourthTurn);
                        break;

                    case 'W':
                        Assert.AreEqual(6, module.fourthTurn);
                        break;

                    case 'X':
                        Assert.AreEqual(2, module.fourthTurn);
                        break;

                    case 'Y':
                        Assert.AreEqual(10, module.fourthTurn);
                        break;

                    case 'Z':
                        Assert.AreEqual(10, module.fourthTurn);
                        break;

                    case '0':
                        Assert.AreEqual(5, module.fourthTurn);
                        break;

                    case '1':
                        Assert.AreEqual(9, module.fourthTurn);
                        break;

                    case '2':
                        Assert.AreEqual(7, module.fourthTurn);
                        break;

                    case '3':
                        Assert.AreEqual(4, module.fourthTurn);
                        break;

                    case '4':
                        Assert.AreEqual(3, module.fourthTurn);
                        break;

                    case '5':
                        Assert.AreEqual(2, module.fourthTurn);
                        break;

                    case '6':
                        Assert.AreEqual(4, module.fourthTurn);
                        break;

                    case '7':
                        Assert.AreEqual(9, module.fourthTurn);
                        break;

                    case '8':
                        Assert.AreEqual(9, module.fourthTurn);
                        break;

                    case '9':
                        Assert.AreEqual(9, module.fourthTurn);
                        break;
                }
            }

            streamWriter.Close();

        }

        [TestMethod]
        public void Rule5()
        {
            Bomb bomb;

            for (int i = 0; i < 26; i++)
            {
                char letter = (char)(i + 65);

                string serialNumber = "" + letter + letter + letter + letter + letter + letter;
                bomb = new Bomb(Day.Sunday, serialNumber, 0, 0, new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), false, 0, new Port("", 0), new Port("", 0), new Port("", 0), new Port("", 0), new Port("", 0), new Port("", 0));

                SafetySafe module = new SafetySafe(bomb, streamWriter);

                module.Debug();


                switch (letter)
                {
                    case 'A':
                        Assert.AreEqual(9, module.fifthTurn);
                        break;

                    case 'B':
                        Assert.AreEqual(3, module.fifthTurn);
                        break;

                    case 'C':
                        Assert.AreEqual(3, module.fifthTurn);
                        break;

                    case 'D':
                        Assert.AreEqual(7, module.fifthTurn);
                        break;

                    case 'E':
                        Assert.AreEqual(2, module.fifthTurn);
                        break;

                    case 'F':
                        Assert.AreEqual(1, module.fifthTurn);
                        break;

                    case 'G':
                        Assert.AreEqual(10, module.fifthTurn);
                        break;

                    case 'H':
                        Assert.AreEqual(6, module.fifthTurn);
                        break;

                    case 'I':
                        Assert.AreEqual(9, module.fifthTurn);
                        break;

                    case 'J':
                        Assert.AreEqual(5, module.fifthTurn);
                        break;

                    case 'K':
                        Assert.AreEqual(0, module.fifthTurn);
                        break;

                    case 'L':
                        Assert.AreEqual(11, module.fifthTurn);
                        break;

                    case 'M':
                        Assert.AreEqual(6, module.fifthTurn);
                        break;

                    case 'N':
                        Assert.AreEqual(4, module.fifthTurn);
                        break;

                    case 'O':
                        Assert.AreEqual(2, module.fifthTurn);
                        break;

                    case 'P':
                        Assert.AreEqual(9, module.fifthTurn);
                        break;

                    case 'Q':
                        Assert.AreEqual(4, module.fifthTurn);
                        break;

                    case 'R':
                        Assert.AreEqual(6, module.fifthTurn);
                        break;

                    case 'S':
                        Assert.AreEqual(3, module.fifthTurn);
                        break;

                    case 'T':
                        Assert.AreEqual(5, module.fifthTurn);
                        break;

                    case 'U':
                        Assert.AreEqual(11, module.fifthTurn);
                        break;

                    case 'V':
                        Assert.AreEqual(1, module.fifthTurn);
                        break;

                    case 'W':
                        Assert.AreEqual(11, module.fifthTurn);
                        break;

                    case 'X':
                        Assert.AreEqual(8, module.fifthTurn);
                        break;

                    case 'Y':
                        Assert.AreEqual(8, module.fifthTurn);
                        break;

                    case 'Z':
                        Assert.AreEqual(0, module.fifthTurn);
                        break;

                    case '0':
                        Assert.AreEqual(8, module.fifthTurn);
                        break;

                    case '1':
                        Assert.AreEqual(1, module.fifthTurn);
                        break;

                    case '2':
                        Assert.AreEqual(7, module.fifthTurn);
                        break;

                    case '3':
                        Assert.AreEqual(10, module.fifthTurn);
                        break;

                    case '4':
                        Assert.AreEqual(5, module.fifthTurn);
                        break;

                    case '5':
                        Assert.AreEqual(0, module.fifthTurn);
                        break;

                    case '6':
                        Assert.AreEqual(7, module.fifthTurn);
                        break;

                    case '7':
                        Assert.AreEqual(2, module.fifthTurn);
                        break;

                    case '8':
                        Assert.AreEqual(10, module.fifthTurn);
                        break;

                    case '9':
                        Assert.AreEqual(4, module.fifthTurn);
                        break;
                }
            }

            streamWriter.Close();

        }

        [TestMethod]
        public void Rule6()
        {
            Bomb bomb;

            for (int i = 0; i < 26; i++)
            {
                char letter = (char)(i + 65);

                string serialNumber = "" + letter + letter + letter + letter + letter + letter;
                bomb = new Bomb(Day.Sunday, serialNumber, 0, 0, new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), new Indicator("", false, false), false, 0, new Port("", 0), new Port("", 0), new Port("", 0), new Port("", 0), new Port("", 0), new Port("", 0));

                SafetySafe module = new SafetySafe(bomb, streamWriter);

                module.Debug();


                switch (letter)
                {
                    case 'A':
                        Assert.AreEqual(0, module.sixthTurn / 6);
                        break;

                    case 'B':
                        Assert.AreEqual(8, module.sixthTurn / 6);
                        break;

                    case 'C':
                        Assert.AreEqual(6, module.sixthTurn / 6);
                        break;

                    case 'D':
                        Assert.AreEqual(7, module.sixthTurn / 6);
                        break;

                    case 'E':
                        Assert.AreEqual(1, module.sixthTurn / 6);
                        break;

                    case 'F':
                        Assert.AreEqual(5, module.sixthTurn / 6);
                        break;

                    case 'G':
                        Assert.AreEqual(5, module.sixthTurn / 6);
                        break;

                    case 'H':
                        Assert.AreEqual(5, module.sixthTurn / 6);
                        break;

                    case 'I':
                        Assert.AreEqual(10, module.sixthTurn / 6);
                        break;

                    case 'J':
                        Assert.AreEqual(6, module.sixthTurn / 6);
                        break;

                    case 'K':
                        Assert.AreEqual(4, module.sixthTurn / 6);
                        break;

                    case 'L':
                        Assert.AreEqual(11, module.sixthTurn / 6);
                        break;

                    case 'M':
                        Assert.AreEqual(2, module.sixthTurn / 6);
                        break;

                    case 'N':
                        Assert.AreEqual(9, module.sixthTurn / 6);
                        break;

                    case 'O':
                        Assert.AreEqual(8, module.sixthTurn / 6);
                        break;

                    case 'P':
                        Assert.AreEqual(7, module.sixthTurn / 6);
                        break;

                    case 'Q':
                        Assert.AreEqual(8, module.sixthTurn / 6);
                        break;

                    case 'R':
                        Assert.AreEqual(11, module.sixthTurn / 6);
                        break;

                    case 'S':
                        Assert.AreEqual(10, module.sixthTurn / 6);
                        break;

                    case 'T':
                        Assert.AreEqual(3, module.sixthTurn / 6);
                        break;

                    case 'U':
                        Assert.AreEqual(1, module.sixthTurn / 6);
                        break;

                    case 'V':
                        Assert.AreEqual(0, module.sixthTurn / 6);
                        break;

                    case 'W':
                        Assert.AreEqual(2, module.sixthTurn / 6);
                        break;

                    case 'X':
                        Assert.AreEqual(10, module.sixthTurn / 6);
                        break;

                    case 'Y':
                        Assert.AreEqual(9, module.sixthTurn / 6);
                        break;

                    case 'Z':
                        Assert.AreEqual(4, module.sixthTurn / 6);
                        break;

                    case '0':
                        Assert.AreEqual(6, module.sixthTurn / 6);
                        break;

                    case '1':
                        Assert.AreEqual(20, module.sixthTurn / 6);
                        break;

                    case '2':
                        Assert.AreEqual(3, module.sixthTurn / 6);
                        break;

                    case '3':
                        Assert.AreEqual(4, module.sixthTurn / 6);
                        break;

                    case '4':
                        Assert.AreEqual(0, module.sixthTurn / 6);
                        break;

                    case '5':
                        Assert.AreEqual(11, module.sixthTurn / 6);
                        break;

                    case '6':
                        Assert.AreEqual(3, module.sixthTurn / 6);
                        break;

                    case '7':
                        Assert.AreEqual(1, module.sixthTurn / 6);
                        break;

                    case '8':
                        Assert.AreEqual(7, module.sixthTurn / 6);
                        break;

                    case '9':
                        Assert.AreEqual(9, module.sixthTurn / 6);
                        break;
                }
            }

            streamWriter.Close();
        }
    }
}
