using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace KTANE_Solver
{
    public class SafetySafe : Module
    {
        int offset;
        int firstTurn;
        int secondTurn;
        int thirdTurn;
        int fourthTurn;
        int fifthTurn;
        int sixthTurn;

        public SafetySafe(Bomb bomb, StreamWriter logFileWriter) : base(bomb, logFileWriter, "Saftey Safe")
        {
            offset = 0;
            firstTurn = 0;
            secondTurn = 0;
            thirdTurn = 0;
            fourthTurn = 0;
            firstTurn = 0;
            sixthTurn = 0;
        }

        public void Solve()
        {
            offset = FindOffset();

            firstTurn = (FindFirstTurn() + offset) % 12;
            secondTurn = (FindSecondTurn() + offset) % 12;
            thirdTurn = (FindThirdTurn() + offset) % 12;
            fourthTurn = (FindFourthTurn() + offset) % 12;
            fifthTurn = (FindFifthTurn() + offset) % 12;
            sixthTurn = (FindSixthTurn() + offset) % 12;

            ShowAnswer($"1. {firstTurn}\n2. {secondTurn}\n3. {thirdTurn}\n4. {fourthTurn}\n5. {fifthTurn}\n6. {sixthTurn}", true);
        }

        private int FindOffset()
        {
            int offset = Bomb.UniquePortNum * 7;

            int indicatorLitNum = 0;
            foreach (Indicator indicator in Bomb.LitIndicatorsList)
            {
                if (HasLetterInSerialNumber(indicator.Name))
                {
                    indicatorLitNum++;
                }
                
            }

            offset += indicatorLitNum * 5;

            int indicatorUnlitNum = 0;
            foreach (Indicator indicator in Bomb.UnlitIndicatorsList)
            {
                if (HasLetterInSerialNumber(indicator.Name))
                {
                    indicatorUnlitNum++;
                }

            }

            offset += indicatorUnlitNum;

            return offset;
        }

        private int FindFirstTurn()
        {
            switch (Bomb.SerialNumber[0])
            {
                case 'A':
                    return 8;
                    
                case 'B':
                    return 10;

                case 'C':
                    return 2;
                case 'D':
                    return 11;

                case 'E':
                    return 0;

                case 'F':
                    return 4;

                case 'G':
                    return 7;
                case 'H':
                    return 8;
                case 'I':
                    return 0;
                case 'J':
                    return 2;
                case 'K':
                    return 5;
                case 'L':
                    return 1;
                case 'M':
                    return 1;
                case 'N':
                    return 9;
                case 'O':
                    return 5;
                case 'P':
                    return 3;
                case 'Q':
                    return 4;
                case 'R':
                    return 8;
                case 'S':
                    return 9;
                case 'T':
                    return 7;
                case 'U':
                    return 11;
                case 'V':
                    return 11;
                case 'W':
                    return 6;
                case 'X':
                    return 4;
                case 'Y':
                    return 10;
                case 'Z':
                    return 3;
                case '0':
                    return 7;
                case '1':
                    return 9;
                case '2':
                    return 2;
                case '3':
                    return 10;
                case '4':
                    return 6;
                case '5':
                    return 6;
                case '6':
                    return 1;
                case '7':
                    return 0;
                case '8':
                    return 5;
                default:
                    return 3;
            }
        }

        private int FindSecondTurn()
        {
            switch (Bomb.SerialNumber[0])
            {
                case 'A':
                    return 3;
                case 'B':
                    return 1;
                case 'C':
                    return 1;
                case 'D':
                    return 6;
                case 'E':
                    return 5;
                case 'F':
                    return 2;
                case 'G':
                    return 4;
                case 'H':
                    return 3;
                case 'I':
                    return 11;
                case 'J':
                    return 11;
                case 'K':
                    return 2;
                case 'L':
                    return 9;
                case 'M':
                    return 7;
                case 'N':
                    return 5;
                case 'O':
                    return 9;
                case 'P':
                    return 10;
                case 'Q':
                    return 10;
                case 'R':
                    return 0;
                case 'S':
                    return 4;
                case 'T':
                    return 6;
                case 'U':
                    return 9;
                case 'V':
                    return 11;
                case 'W':
                    return 0;
                case 'X':
                    return 2;
                case 'Y':
                    return 7;
                case 'Z':
                    return 7;
                case '0':
                    return 0;
                case '1':
                    return 10;
                case '2':
                    return 5;
                case '3':
                    return 8;
                case '4':
                    return 8;
                case '5':
                    return 3;
                case '6':
                    return 1;
                case '7':
                    return 6;
                case '8':
                    return 4;
                default:
                    return 8;
            }
        }

        private int FindThirdTurn()
        {
            switch (Bomb.SerialNumber[0])
            {
                case 'A':
                    return 4;
                case 'B':
                    return 3;
                case 'C':
                    return 1;
                case 'D':
                    return 11;
                case 'E':
                    return 5;
                case 'F':
                    return 7;
                case 'G':
                    return 4;
                case 'H':
                    return 6;
                case 'I':
                    return 0;
                case 'J':
                    return 8;
                case 'K':
                    return 5;
                case 'L':
                    return 8;
                case 'M':
                    return 9;
                case 'N':
                    return 1;
                case 'O':
                    return 8;
                case 'P':
                    return 9;
                case 'Q':
                    return 6;
                case 'R':
                    return 4;
                case 'S':
                    return 0;
                case 'T':
                    return 7;
                case 'U':
                    return 6;
                case 'V':
                    return 2;
                case 'W':
                    return 11;
                case 'X':
                    return 7;
                case 'Y':
                    return 10;
                case 'Z':
                    return 1;
                case '0':
                    return 3;
                case '1':
                    return 10;
                case '2':
                    return 11;
                case '3':
                    return 10;
                case '4':
                    return 0;
                case '5':
                    return 3;
                case '6':
                    return 5;
                case '7':
                    return 2;
                case '8':
                    return 9;
                default:
                    return 2;
            }
        }

        private int FindFourthTurn()
        {
            switch (Bomb.SerialNumber[0])
            {
                case 'A':
                    return 8;
                case 'B':
                    return 7;
                case 'C':
                    return 5;
                case 'D':
                    return 11;
                case 'E':
                    return 8;
                case 'F':
                    return 7;
                case 'G':
                    return 2;
                case 'H':
                    return 6;
                case 'I':
                    return 0;
                case 'J':
                    return 0;
                case 'K':
                    return 1;
                case 'L':
                    return 11;
                case 'M':
                    return 5;
                case 'N':
                    return 4;
                case 'O':
                    return 10;
                case 'P':
                    return 1;
                case 'Q':
                    return 1;
                case 'R':
                    return 0;
                case 'S':
                    return 6;
                case 'T':
                    return 11;
                case 'U':
                    return 3;
                case 'V':
                    return 8;
                case 'W':
                    return 6;
                case 'X':
                    return 2;
                case 'Y':
                    return 10;
                case 'Z':
                    return 10;
                case '0':
                    return 5;
                case '1':
                    return 9;
                case '2':
                    return 7;
                case '3':
                    return 4;
                case '4':
                    return 3;
                case '5':
                    return 3;
                case '6':
                    return 2;
                case '7':
                    return 4;
                case '8':
                    return 9;
                default:
                    return 9;
            }
        }

        private int FindFifthTurn()
        {
            switch (Bomb.SerialNumber[0])
            {
                case 'A':
                    return 9;
                case 'B':
                    return 3;
                case 'C':
                    return 3;
                case 'D':
                    return 7;
                case 'E':
                    return 2;
                case 'F':
                    return 1;
                case 'G':
                    return 10;
                case 'H':
                    return 6;
                case 'I':
                    return 9;
                case 'J':
                    return 5;
                case 'K':
                    return 0;
                case 'L':
                    return 11;
                case 'M':
                    return 6;
                case 'N':
                    return 4;
                case 'O':
                    return 2;
                case 'P':
                    return 9;
                case 'Q':
                    return 4;
                case 'R':
                    return 6;
                case 'S':
                    return 3;
                case 'T':
                    return 5;
                case 'U':
                    return 11;
                case 'V':
                    return 1;
                case 'W':
                    return 11;
                case 'X':
                    return 8;
                case 'Y':
                    return 8;
                case 'Z':
                    return 0;
                case '0':
                    return 8;
                case '1':
                    return 1;
                case '2':
                    return 7;
                case '3':
                    return 10;
                case '4':
                    return 5;
                case '5':
                    return 0;
                case '6':
                    return 7;
                case '7':
                    return 2;
                case '8':
                    return 10;
                default:
                    return 4;
            }
        }

        private int FindSixthTurn()
        {
            int num = 0;
            foreach (char c in Bomb.SerialNumber)
            {
                switch (c)
                {
                    case 'A':
                        num += 0;
                        break;
                    case 'B':
                        num += 8;
                        break;

                    case 'C':
                        num += 6;
                        break;

                    case 'D':
                        num += 7;
                        break;

                    case 'E':
                        num += 1;
                        break;

                    case 'F':
                        num += 5;
                        break;

                    case 'G':
                        num += 5;
                        break;

                    case 'H':
                        num += 5;
                        break;

                    case 'I':
                        num += 10;
                        break;

                    case 'J':
                        num += 6;
                        break;

                    case 'K':
                        num += 4;
                        break;

                    case 'L':
                        num += 11;
                        break;

                    case 'M':
                        num += 2;
                        break;

                    case 'N':
                        num += 9;
                        break;

                    case 'O':
                        num += 8;
                        break;

                    case 'P':
                        num += 7;
                        break;

                    case 'Q':
                        num += 8;
                        break;

                    case 'R':
                        num += 11;
                        break;

                    case 'S':
                        num += 10;
                        break;

                    case 'T':
                        num += 3;
                        break;

                    case 'U':
                        num += 1;
                        break;

                    case 'V':
                        num += 0;
                        break;

                    case 'W':
                        num += 2;
                        break;

                    case 'X':
                        num += 10;
                        break;

                    case 'Y':
                        num += 9;
                        break;

                    case 'Z':
                        num += 4;
                        break;

                    case '0':
                        num += 6;
                        break;

                    case '1':
                        num += 2;
                        break;

                    case '2':
                        num += 3;
                        break;

                    case '3':
                        num += 4;
                        break;

                    case '4':
                        num += 0;
                        break;

                    case '5':
                        num += 11;
                        break;

                    case '6':
                        num += 3;
                        break;

                    case '7':
                        num += 1;
                        break;

                    case '8':
                        num += 7;
                        break;

                    default:
                        num += 9;
                        break;

                }
            }

            return num;
            
        }

        private bool HasLetterInSerialNumber(string str)
        {
            foreach (char c in Bomb.SerialNumber)
            {
                if (str.Contains(c))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
