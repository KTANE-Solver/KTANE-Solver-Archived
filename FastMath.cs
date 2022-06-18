using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace KTANE_Solver
{
    public class FastMath : Module
    {
        int answer;

        public FastMath(Bomb bomb, StreamWriter logFileWriter) : base(bomb, logFileWriter, "Fast Math")
        {

        }

        private void Solve(char leftLetter, char rightLetter)
        {
            GetInitialNumber(leftLetter, rightLetter);
            ModifyNumber();
        }

        private void GetInitialNumber(char leftLetter, char rightLetter)
        {
            answer = -1;
            switch (leftLetter)
            {
                case 'A':
                    {
                        if (rightLetter == 'A')
                        {
                            answer = 25;
                        }

                        else if (rightLetter == 'B')
                        {
                            answer = 54;
                        }

                        else if (rightLetter == 'C')
                        {
                            answer = 86;
                        }

                        else if (rightLetter == 'D')
                        {
                            answer = 54;
                        }

                        else if (rightLetter == 'E')
                        {
                            answer = 99;
                        }

                        else if (rightLetter == 'G')
                        {
                            answer = 74;
                        }

                        else if (rightLetter == 'K')
                        {
                            answer = 88;
                        }

                        else if (rightLetter == 'N')
                        {
                            answer = 54;
                        }

                        else if (rightLetter == 'P')
                        {
                            answer = 7;
                        }

                        else if (rightLetter == 'S')
                        {
                            answer = 63;
                        }

                        else if (rightLetter == 'T')
                        {
                            answer = 35;
                        }

                        else if (rightLetter == 'X')
                        {
                            answer = 67;
                        }

                        else if (rightLetter == 'Z')
                        {
                            answer = 13;
                        }
                    }
                    break;

                case 'B':
                    {
                        if (rightLetter == 'A')
                        {
                            answer = 11;
                        }

                        else if (rightLetter == 'B')
                        {
                            answer = 7;
                        }

                        else if (rightLetter == 'C')
                        {
                            answer = 37;
                        }

                        else if (rightLetter == 'D')
                        {
                            answer = 28;
                        }

                        else if (rightLetter == 'E')
                        {
                            answer = 36;
                        }

                        else if (rightLetter == 'G')
                        {
                            answer = 95;
                        }

                        else if (rightLetter == 'K')
                        {
                            answer = 46;
                        }

                        else if (rightLetter == 'N')
                        {
                            answer = 43;
                        }

                        else if (rightLetter == 'P')
                        {
                            answer = 33;
                        }

                        else if (rightLetter == 'S')
                        {
                            answer = 64;
                        }

                        else if (rightLetter == 'T')
                        {
                            answer = 39;
                        }

                        else if (rightLetter == 'X')
                        {
                            answer = 30;
                        }

                        else if (rightLetter == 'Z')
                        {
                            answer = 23;
                        }
                    }
                    break;

                case 'C':
                    {
                        if (rightLetter == 'A')
                        {
                            answer = 53;
                        }

                        else if (rightLetter == 'B')
                        {
                            answer = 32;
                        }

                        else if (rightLetter == 'C')
                        {
                            answer = 44;
                        }

                        else if (rightLetter == 'D')
                        {
                            answer = 77;
                        }

                        else if (rightLetter == 'E')
                        {
                            answer = 23;
                        }

                        else if (rightLetter == 'G')
                        {
                            answer = 3;
                        }

                        else if (rightLetter == 'K')
                        {
                            answer = 37;
                        }

                        else if (rightLetter == 'N')
                        {
                            answer = 12;
                        }

                        else if (rightLetter == 'P')
                        {
                            answer = 26;
                        }

                        else if (rightLetter == 'S')
                        {
                            answer = 94;
                        }

                        else if (rightLetter == 'T')
                        {
                            answer = 3;
                        }

                        else if (rightLetter == 'X')
                        {
                            answer = 27;
                        }

                        else if (rightLetter == 'Z')
                        {
                            answer = 26;
                        }
                    }
                    break;
                case 'D':
                    {
                        if (rightLetter == 'A')
                        {
                            answer = 97;
                        }

                        else if (rightLetter == 'B')
                        {
                            answer = 19;
                        }

                        else if (rightLetter == 'C')
                        {
                            answer = 1;
                        }

                        else if (rightLetter == 'D')
                        {
                            answer = 93;
                        }

                        else if (rightLetter == 'E')
                        {
                            answer = 95;
                        }

                        else if (rightLetter == 'G')
                        {
                            answer = 4;
                        }

                        else if (rightLetter == 'K')
                        {
                            answer = 96;
                        }

                        else if (rightLetter == 'N')
                        {
                            answer = 65;
                        }

                        else if (rightLetter == 'P')
                        {
                            answer = 1;
                        }

                        else if (rightLetter == 'S')
                        {
                            answer = 27;
                        }

                        else if (rightLetter == 'T')
                        {
                            answer = 25;
                        }

                        else if (rightLetter == 'X')
                        {
                            answer = 71;
                        }

                        else if (rightLetter == 'Z')
                        {
                            answer = 85;
                        }
                    }
                    break;

                case 'E':
                    {
                        if (rightLetter == 'A')
                        {
                            answer = 2;
                        }

                        else if (rightLetter == 'B')
                        {
                            answer = 84;
                        }

                        else if (rightLetter == 'C')
                        {
                            answer = 5;
                        }

                        else if (rightLetter == 'D')
                        {
                            answer = 11;
                        }

                        else if (rightLetter == 'E')
                        {
                            answer = 67;
                        }

                        else if (rightLetter == 'G')
                        {
                            answer = 56;
                        }

                        else if (rightLetter == 'K')
                        {
                            answer = 2;
                        }

                        else if (rightLetter == 'N')
                        {
                            answer = 94;
                        }

                        else if (rightLetter == 'P')
                        {
                            answer = 67;
                        }

                        else if (rightLetter == 'S')
                        {
                            answer = 48;
                        }

                        else if (rightLetter == 'T')
                        {
                            answer = 47;
                        }

                        else if (rightLetter == 'X')
                        {
                            answer = 9;
                        }

                        else if (rightLetter == 'Z')
                        {
                            answer = 92;
                        }
                    }
                    break;

                case 'G':
                    {
                        if (rightLetter == 'A')
                        {
                            answer = 42;
                        }

                        else if (rightLetter == 'B')
                        {
                            answer = 33;
                        }

                        else if (rightLetter == 'C')
                        {
                            answer = 26;
                        }

                        else if (rightLetter == 'D')
                        {
                            answer = 0;
                        }

                        else if (rightLetter == 'E')
                        {
                            answer = 5;
                        }

                        else if (rightLetter == 'G')
                        {
                            answer = 23;
                        }

                        else if (rightLetter == 'K')
                        {
                            answer = 52;
                        }

                        else if (rightLetter == 'N')
                        {
                            answer = 3;
                        }

                        else if (rightLetter == 'P')
                        {
                            answer = 26;
                        }

                        else if (rightLetter == 'S')
                        {
                            answer = 84;
                        }

                        else if (rightLetter == 'T')
                        {
                            answer = 62;
                        }

                        else if (rightLetter == 'X')
                        {
                            answer = 11;
                        }

                        else if (rightLetter == 'Z')
                        {
                            answer = 12;
                        }
                    }
                    break;

                case 'K':
                    {
                        if (rightLetter == 'A')
                        {
                            answer = 51;
                        }

                        else if (rightLetter == 'B')
                        {
                            answer = 27;
                        }

                        else if (rightLetter == 'C')
                        {
                            answer = 93;
                        }

                        else if (rightLetter == 'D')
                        {
                            answer = 35;
                        }

                        else if (rightLetter == 'E')
                        {
                            answer = 26;
                        }

                        else if (rightLetter == 'G')
                        {
                            answer = 54;
                        }

                        else if (rightLetter == 'K')
                        {
                            answer = 81;
                        }

                        else if (rightLetter == 'N')
                        {
                            answer = 47;
                        }

                        else if (rightLetter == 'P')
                        {
                            answer = 27;
                        }

                        else if (rightLetter == 'S')
                        {
                            answer = 33;
                        }

                        else if (rightLetter == 'T')
                        {
                            answer = 38;
                        }

                        else if (rightLetter == 'X')
                        {
                            answer = 44;
                        }

                        else if (rightLetter == 'Z')
                        {
                            answer = 73;
                        }
                    }
                    break;

                case 'N':
                    {
                        if (rightLetter == 'A')
                        {
                            answer = 97;
                        }

                        else if (rightLetter == 'B')
                        {
                            answer = 78;
                        }

                        else if (rightLetter == 'C')
                        {
                            answer = 49;
                        }

                        else if (rightLetter == 'D')
                        {
                            answer = 61;
                        }

                        else if (rightLetter == 'E')
                        {
                            answer = 17;
                        }

                        else if (rightLetter == 'G')
                        {
                            answer = 29;
                        }

                        else if (rightLetter == 'K')
                        {
                            answer = 37;
                        }

                        else if (rightLetter == 'N')
                        {
                            answer = 23;
                        }

                        else if (rightLetter == 'P')
                        {
                            answer = 77;
                        }

                        else if (rightLetter == 'S')
                        {
                            answer = 10;
                        }

                        else if (rightLetter == 'T')
                        {
                            answer = 45;
                        }

                        else if (rightLetter == 'X')
                        {
                            answer = 37;
                        }

                        else if (rightLetter == 'Z')
                        {
                            answer = 56;
                        }
                    }
                    break;

                case 'P':
                    {
                        if (rightLetter == 'A')
                        {
                            answer = 12;
                        }

                        else if (rightLetter == 'B')
                        {
                            answer = 26;
                        }

                        else if (rightLetter == 'C')
                        {
                            answer = 18;
                        }

                        else if (rightLetter == 'D')
                        {
                            answer = 27;
                        }

                        else if (rightLetter == 'E')
                        {
                            answer = 44;
                        }

                        else if (rightLetter == 'G')
                        {
                            answer = 52;
                        }

                        else if (rightLetter == 'K')
                        {
                            answer = 12;
                        }

                        else if (rightLetter == 'N')
                        {
                            answer = 16;
                        }

                        else if (rightLetter == 'P')
                        {
                            answer = 83;
                        }

                        else if (rightLetter == 'S')
                        {
                            answer = 16;
                        }

                        else if (rightLetter == 'T')
                        {
                            answer = 88;
                        }

                        else if (rightLetter == 'X')
                        {
                            answer = 18;
                        }

                        else if (rightLetter == 'Z')
                        {
                            answer = 81;
                        }
                    }
                    break;

                case 'S':
                    {
                        if (rightLetter == 'A')
                        {
                            answer = 86;
                        }

                        else if (rightLetter == 'B')
                        {
                            answer = 46;
                        }

                        else if (rightLetter == 'C')
                        {
                            answer = 69;
                        }

                        else if (rightLetter == 'D')
                        {
                            answer = 48;
                        }

                        else if (rightLetter == 'E')
                        {
                            answer = 60;
                        }

                        else if (rightLetter == 'G')
                        {
                            answer = 38;
                        }

                        else if (rightLetter == 'K')
                        {
                            answer = 70;
                        }

                        else if (rightLetter == 'N')
                        {
                            answer = 62;
                        }

                        else if (rightLetter == 'P')
                        {
                            answer = 14;
                        }

                        else if (rightLetter == 'S')
                        {
                            answer = 74;
                        }

                        else if (rightLetter == 'T')
                        {
                            answer = 48;
                        }

                        else if (rightLetter == 'X')
                        {
                            answer = 40;
                        }

                        else if (rightLetter == 'Z')
                        {
                            answer = 7;
                        }
                    }
                    break;

                case 'T':
                    {
                        if (rightLetter == 'A')
                        {
                            answer = 55;
                        }

                        else if (rightLetter == 'B')
                        {
                            answer = 9;
                        }

                        else if (rightLetter == 'C')
                        {
                            answer = 23;
                        }

                        else if (rightLetter == 'D')
                        {
                            answer = 13;
                        }

                        else if (rightLetter == 'E')
                        {
                            answer = 26;
                        }

                        else if (rightLetter == 'G')
                        {
                            answer = 10;
                        }

                        else if (rightLetter == 'K')
                        {
                            answer = 14;
                        }

                        else if (rightLetter == 'N')
                        {
                            answer = 73;
                        }

                        else if (rightLetter == 'P')
                        {
                            answer = 27;
                        }

                        else if (rightLetter == 'S')
                        {
                            answer = 43;
                        }

                        else if (rightLetter == 'T')
                        {
                            answer = 34;
                        }

                        else if (rightLetter == 'X')
                        {
                            answer = 32;
                        }

                        else if (rightLetter == 'Z')
                        {
                            answer = 75;
                        }
                    }
                    break;

                case 'X':
                    {
                        if (rightLetter == 'A')
                        {
                            answer = 73;
                        }

                        else if (rightLetter == 'B')
                        {
                            answer = 13;
                        }

                        else if (rightLetter == 'C')
                        {
                            answer = 40;
                        }

                        else if (rightLetter == 'D')
                        {
                            answer = 72;
                        }

                        else if (rightLetter == 'E')
                        {
                            answer = 41;
                        }

                        else if (rightLetter == 'G')
                        {
                            answer = 76;
                        }

                        else if (rightLetter == 'K')
                        {
                            answer = 36;
                        }

                        else if (rightLetter == 'N')
                        {
                            answer = 46;
                        }

                        else if (rightLetter == 'P')
                        {
                            answer = 93;
                        }

                        else if (rightLetter == 'S')
                        {
                            answer = 99;
                        }

                        else if (rightLetter == 'T')
                        {
                            answer = 31;
                        }

                        else if (rightLetter == 'X')
                        {
                            answer = 15;
                        }

                        else if (rightLetter == 'Z')
                        {
                            answer = 47;
                        }
                    }
                    break;

                case 'Z':
                    {
                        if (rightLetter == 'A')
                        {
                            answer = 33;
                        }

                        else if (rightLetter == 'B')
                        {
                            answer = 58;
                        }

                        else if (rightLetter == 'C')
                        {
                            answer = 22;
                        }

                        else if (rightLetter == 'D')
                        {
                            answer = 80;
                        }

                        else if (rightLetter == 'E')
                        {
                            answer = 67;
                        }

                        else if (rightLetter == 'G')
                        {
                            answer = 98;
                        }

                        else if (rightLetter == 'K')
                        {
                            answer = 78;
                        }

                        else if (rightLetter == 'N')
                        {
                            answer = 21;
                        }

                        else if (rightLetter == 'P')
                        {
                            answer = 9;
                        }

                        else if (rightLetter == 'S')
                        {
                            answer = 4;
                        }

                        else if (rightLetter == 'T')
                        {
                            answer = 27;
                        }

                        else if (rightLetter == 'X')
                        {
                            answer = 78;
                        }

                        else if (rightLetter == 'Z')
                        {
                            answer = 99;
                        }
                    }
                    break;
            }

            PrintDebugLine("Initial Number: " + answer + "\n");
        }

        private void ModifyNumber()
        {
            if (Bomb.Msa.Lit)
            {
                answer += 20;
                PrintDebugLine("Bomb has a lit MSA: adding 20");
            }

            if (Bomb.Serial.Visible)
            {
                answer += 14;
                PrintDebugLine("Bomb has a serial port: adding 14");
            }

            if (Bomb.SerialNumber.Contains("F") || Bomb.SerialNumber.Contains("A") || Bomb.SerialNumber.Contains("S") || Bomb.SerialNumber.Contains("T"))
            {
                answer -= 5;
                PrintDebugLine("Bomb contains at least one of the following letters: F, A, S, T: subtracting 5");
            }

            if (Bomb.Rj.Visible)
            {
                answer += 27;
                PrintDebugLine("Bomb has a RJ-45 port: adding 27");
            }

            if (Bomb.Battery > 3)
            {
                answer -= 15;
                PrintDebugLine("Bomb has at least 4 batteries: subtracting 15");

            }

            if (answer < 0)
            {
                answer += 50;
            }

            answer %= 100;

            PrintDebugLine("Answer is now " + answer);
        }
    }
}
