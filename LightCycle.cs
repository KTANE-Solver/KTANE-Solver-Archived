using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace KTANE_Solver
{
    class LightCycle : Module
    {
        String pair1, pair2, pair3, pair4, pair5, pair6;
        String sequence1, sequence2, sequence3, sequence4, sequence5, sequence6;
        public LightCycle(Bomb bomb, StreamWriter logFileWriter, String cycle) : base(bomb, logFileWriter)
        {
            pair1 = "" + bomb.SerialNumber[0] + bomb.SerialNumber[bomb.SerialNumber.Length - 1];
            pair2 = "" + bomb.SerialNumber[1] + bomb.SerialNumber[bomb.SerialNumber.Length - 2];
            pair3 = "" + bomb.SerialNumber[2] + bomb.SerialNumber[bomb.SerialNumber.Length - 3];
            pair4 = "" + bomb.SerialNumber[3] + bomb.SerialNumber[bomb.SerialNumber.Length - 4];
            pair5 = "" + bomb.SerialNumber[4] + bomb.SerialNumber[bomb.SerialNumber.Length - 5];
            pair6 = "" + bomb.SerialNumber[5] + bomb.SerialNumber[bomb.SerialNumber.Length - 6];

            sequence1 = GetSequence(pair1);
            sequence2 = GetSequence(pair2);
            sequence3 = GetSequence(pair3);
            sequence4 = GetSequence(pair4);
            sequence5 = GetSequence(pair5);
            sequence6 = GetSequence(pair6);

            cycle = SwapCycle(cycle, sequence1);
            cycle = SwapCycle(cycle, sequence2);
            cycle = SwapCycle(cycle, sequence3);
            cycle = SwapCycle(cycle, sequence4);
            cycle = SwapCycle(cycle, sequence5);
            cycle = SwapCycle(cycle, sequence6);

            ShowAnswer(GetAnswer(cycle), "Light Cycle Answer");

        }

        private String GetSequence(String pair)
        {
            switch (pair[1])
            {
                case 'A':
                case 'B':
                case 'C':

                    if (pair[1] == 'A')
                    {
                        return "5B";
                    }

                    if (pair[1] == 'B')
                    {
                        return "2R";
                    }

                    if (pair[1] == 'C')
                    {
                        return "MY";
                    }

                    if (pair[1] == 'D')
                    {
                        return "56";
                    }

                    if (pair[1] == 'E')
                    {
                        return "BR";
                    }

                    if (pair[1] == 'F')
                    {
                        return "RY";
                    }

                    if (pair[1] == 'G')
                    {
                        return "Y1";
                    }

                    if (pair[1] == 'H')
                    {
                        return "35";
                    }

                    if (pair[1] == 'I')
                    {
                        return "RM";
                    }

                    if (pair[1] == 'J')
                    {
                        return "WB";
                    }

                    if (pair[1] == 'K')
                    {
                        return "64";
                    }

                    if (pair[1] == 'L')
                    {
                        return "64";
                    }

                    if (pair[1] == 'M')
                    {
                        return "W3";
                    }

                    if (pair[1] == 'N')
                    {
                        return "1Y";
                    }

                    if (pair[1] == 'O')
                    {
                        return "R5";
                    }

                    if (pair[1] == 'P')
                    {
                        return "14";
                    }

                    if (pair[1] == 'Q')
                    {
                        return "5G";
                    }

                    if (pair[1] == 'R')
                    {
                        return "MG";
                    }

                    if (pair[1] == 'S')
                    {
                        return "RY";
                    }

                    if (pair[1] == 'T')
                    {
                        return "G3";
                    }

                    if (pair[1] == 'U')
                    {
                        return "51";
                    }

                    if (pair[1] == 'V')
                    {
                        return "M6";
                    }

                    if (pair[1] == 'W')
                    {
                        return "YM";
                    }

                    if (pair[1] == 'X')
                    {
                        return "42";
                    }

                    if (pair[1] == 'Y')
                    {
                        return "GY";
                    }

                    if (pair[1] == 'Z')
                    {
                        return "GB";
                    }

                    if (pair[1] == '0')
                    {
                        return "2R";
                    }

                    if (pair[1] == '1')
                    {
                        return "R4";
                    }

                    if (pair[1] == '2')
                    {
                        return "4B";
                    }

                    if (pair[1] == '3')
                    {
                        return "B6";
                    }

                    if (pair[1] == '4')
                    {
                        return "MR";
                    }

                    if (pair[1] == '5')
                    {
                        return "Y1";
                    }

                    if (pair[1] == '6')
                    {
                        return "34";
                    }

                    if (pair[1] == '7')
                    {
                        return "4G";
                    }

                    if (pair[1] == '8')
                    {
                        return "YB";
                    }

                    return "GY";

                case 'D':
                case 'E':
                case 'F':
                    if (pair[1] == 'A')
                    {
                        return "BR";
                    }

                    if (pair[1] == 'B')
                    {
                        return "6M";
                    }

                    if (pair[1] == 'C')
                    {
                        return "24";
                    }

                    if (pair[1] == 'D')
                    {
                        return "63";
                    }

                    if (pair[1] == 'E')
                    {
                        return "W2";
                    }

                    if (pair[1] == 'F')
                    {
                        return "2G";
                    }

                    if (pair[1] == 'G')
                    {
                        return "54";
                    }

                    if (pair[1] == 'H')
                    {
                        return "WY";
                    }

                    if (pair[1] == 'I')
                    {
                        return "45";
                    }

                    if (pair[1] == 'J')
                    {
                        return "R6";
                    }

                    if (pair[1] == 'K')
                    {
                        return "B2";
                    }

                    if (pair[1] == 'L')
                    {
                        return "B5";
                    }

                    if (pair[1] == 'M')
                    {
                        return "3G";
                    }

                    if (pair[1] == 'N')
                    {
                        return "6M";
                    }

                    if (pair[1] == 'O')
                    {
                        return "3G";
                    }

                    if (pair[1] == 'P')
                    {
                        return "4B";
                    }

                    if (pair[1] == 'Q')
                    {
                        return "MB";
                    }

                    if (pair[1] == 'R')
                    {
                        return "56";
                    }

                    if (pair[1] == 'S')
                    {
                        return "65";
                    }

                    if (pair[1] == 'T')
                    {
                        return "B2";
                    }

                    if (pair[1] == 'U')
                    {
                        return "W3";
                    }

                    if (pair[1] == 'V')
                    {
                        return "6B";
                    }

                    if (pair[1] == 'W')
                    {
                        return "B1";
                    }

                    if (pair[1] == 'X')
                    {
                        return "RB";
                    }

                    if (pair[1] == 'Y')
                    {
                        return "1R";
                    }

                    if (pair[1] == 'Z')
                    {
                        return "BG";
                    }

                    if (pair[1] == '0')
                    {
                        return "RB";
                    }

                    if (pair[1] == '1')
                    {
                        return "W6";
                    }

                    if (pair[1] == '2')
                    {
                        return "B3";
                    }

                    if (pair[1] == '3')
                    {
                        return "M3";
                    }

                    if (pair[1] == '4')
                    {
                        return "2B";
                    }

                    if (pair[1] == '5')
                    {
                        return "56";
                    }

                    if (pair[1] == '6')
                    {
                        return "WB";
                    }

                    if (pair[1] == '7')
                    {
                        return "65";
                    }

                    if (pair[1] == '8')
                    {
                        return "R2";
                    }

                    return "31";

                case 'G':
                case 'H':
                case 'I':
                    if (pair[1] == 'A')
                    {
                        return "MG";
                    }

                    if (pair[1] == 'B')
                    {
                        return "43";
                    }

                    if (pair[1] == 'C')
                    {
                        return "YR";
                    }

                    if (pair[1] == 'D')
                    {
                        return "14";
                    }

                    if (pair[1] == 'E')
                    {
                        return "23";
                    }

                    if (pair[1] == 'F')
                    {
                        return "1M";
                    }

                    if (pair[1] == 'G')
                    {
                        return "2W";
                    }

                    if (pair[1] == 'H')
                    {
                        return "G2";
                    }

                    if (pair[1] == 'I')
                    {
                        return "5W";
                    }

                    if (pair[1] == 'J')
                    {
                        return "5Y";
                    }

                    if (pair[1] == 'K')
                    {
                        return "WG";
                    }

                    if (pair[1] == 'L')
                    {
                        return "W6";
                    }

                    if (pair[1] == 'M')
                    {
                        return "24";
                    }

                    if (pair[1] == 'N')
                    {
                        return "21";
                    }

                    if (pair[1] == 'O')
                    {
                        return "23";
                    }

                    if (pair[1] == 'P')
                    {
                        return "62";
                    }

                    if (pair[1] == 'Q')
                    {
                        return "4W";
                    }

                    if (pair[1] == 'R')
                    {
                        return "GM";
                    }

                    if (pair[1] == 'S')
                    {
                        return "5G";
                    }

                    if (pair[1] == 'T')
                    {
                        return "6W";
                    }

                    if (pair[1] == 'U')
                    {
                        return "45";
                    }

                    if (pair[1] == 'V')
                    {
                        return "1G";
                    }

                    if (pair[1] == 'W')
                    {
                        return "53";
                    }

                    if (pair[1] == 'X')
                    {
                        return "W5";
                    }

                    if (pair[1] == 'Y')
                    {
                        return "54";
                    }

                    if (pair[1] == 'Z')
                    {
                        return "15";
                    }

                    if (pair[1] == '0')
                    {
                        return "5G";
                    }

                    if (pair[1] == '1')
                    {
                        return "32";
                    }

                    if (pair[1] == '2')
                    {
                        return "64";
                    }

                    if (pair[1] == '3')
                    {
                        return "4B";
                    }

                    if (pair[1] == '4')
                    {
                        return "W5";
                    }

                    if (pair[1] == '5')
                    {
                        return "1W";
                    }

                    if (pair[1] == '6')
                    {
                        return "YG";
                    }

                    if (pair[1] == '7')
                    {
                        return "Y4";
                    }

                    if (pair[1] == '8')
                    {
                        return "WR";
                    }

                    return "5M";

                case 'J':
                case 'K':
                case 'L':
                    if (pair[1] == 'A')
                    {
                        return "Y5";
                    }

                    if (pair[1] == 'B')
                    {
                        return "5B";
                    }

                    if (pair[1] == 'C')
                    {
                        return "35";
                    }

                    if (pair[1] == 'D')
                    {
                        return "M2";
                    }

                    if (pair[1] == 'E')
                    {
                        return "14";
                    }

                    if (pair[1] == 'F')
                    {
                        return "Y5";
                    }

                    if (pair[1] == 'G')
                    {
                        return "RY";
                    }

                    if (pair[1] == 'H')
                    {
                        return "2B";
                    }

                    if (pair[1] == 'I')
                    {
                        return "B1";
                    }

                    if (pair[1] == 'J')
                    {
                        return "41";
                    }

                    if (pair[1] == 'K')
                    {
                        return "R5";
                    }

                    if (pair[1] == 'L')
                    {
                        return "1G";
                    }

                    if (pair[1] == 'M')
                    {
                        return "YM";
                    }

                    if (pair[1] == 'N')
                    {
                        return "GR";
                    }

                    if (pair[1] == 'O')
                    {
                        return "W4";
                    }

                    if (pair[1] == 'P')
                    {
                        return "3W";
                    }

                    if (pair[1] == 'Q')
                    {
                        return "Y2";
                    }

                    if (pair[1] == 'R')
                    {
                        return "W5";
                    }

                    if (pair[1] == 'S')
                    {
                        return "GB";
                    }

                    if (pair[1] == 'T')
                    {
                        return "MB";
                    }

                    if (pair[1] == 'U')
                    {
                        return "34";
                    }

                    if (pair[1] == 'V')
                    {
                        return "35";
                    }

                    if (pair[1] == 'W')
                    {
                        return "2G";
                    }

                    if (pair[1] == 'X')
                    {
                        return "YM";
                    }

                    if (pair[1] == 'Y')
                    {
                        return "4G";
                    }

                    if (pair[1] == 'Z')
                    {
                        return "M1";
                    }

                    if (pair[1] == '0')
                    {
                        return "W2";
                    }

                    if (pair[1] == '1')
                    {
                        return "2W";
                    }

                    if (pair[1] == '2')
                    {
                        return "W1";
                    }

                    if (pair[1] == '3')
                    {
                        return "14";
                    }

                    if (pair[1] == '4')
                    {
                        return "6Y";
                    }

                    if (pair[1] == '5')
                    {
                        return "W4";
                    }

                    if (pair[1] == '6')
                    {
                        return "5M";
                    }

                    if (pair[1] == '7')
                    {
                        return "GB";
                    }

                    if (pair[1] == '8')
                    {
                        return "53";
                    }

                    return "R2";

                case 'M':
                case 'N':
                case 'O':
                    if (pair[1] == 'A')
                    {
                        return "41";
                    }

                    if (pair[1] == 'B')
                    {
                        return "R5";
                    }

                    if (pair[1] == 'C')
                    {
                        return "W2";
                    }

                    if (pair[1] == 'D')
                    {
                        return "RY";
                    }

                    if (pair[1] == 'E')
                    {
                        return "MB";
                    }

                    if (pair[1] == 'F')
                    {
                        return "5R";
                    }

                    if (pair[1] == 'G')
                    {
                        return "1R";
                    }

                    if (pair[1] == 'H')
                    {
                        return "5G";
                    }

                    if (pair[1] == 'I')
                    {
                        return "M6";
                    }

                    if (pair[1] == 'J')
                    {
                        return "25";
                    }

                    if (pair[1] == 'K')
                    {
                        return "G1";
                    }

                    if (pair[1] == 'L')
                    {
                        return "R2";
                    }

                    if (pair[1] == 'M')
                    {
                        return "M2";
                    }

                    if (pair[1] == 'N')
                    {
                        return "3G";
                    }

                    if (pair[1] == 'O')
                    {
                        return "B2";
                    }

                    if (pair[1] == 'P')
                    {
                        return "MR";
                    }

                    if (pair[1] == 'Q')
                    {
                        return "RM";
                    }

                    if (pair[1] == 'R')
                    {
                        return "Y2";
                    }

                    if (pair[1] == 'S')
                    {
                        return "WM";
                    }

                    if (pair[1] == 'T')
                    {
                        return "15";
                    }

                    if (pair[1] == 'U')
                    {
                        return "YM";
                    }

                    if (pair[1] == 'V')
                    {
                        return "WR";
                    }

                    if (pair[1] == 'W')
                    {
                        return "32";
                    }

                    if (pair[1] == 'X')
                    {
                        return "2Y";
                    }

                    if (pair[1] == 'Y')
                    {
                        return "3B";
                    }

                    if (pair[1] == 'Z')
                    {
                        return "3M";
                    }

                    if (pair[1] == '0')
                    {
                        return "Y1";
                    }

                    if (pair[1] == '1')
                    {
                        return "4Y";
                    }

                    if (pair[1] == '2')
                    {
                        return "MY";
                    }

                    if (pair[1] == '3')
                    {
                        return "25";
                    }

                    if (pair[1] == '4')
                    {
                        return "B3";
                    }

                    if (pair[1] == '5')
                    {
                        return "BG";
                    }

                    if (pair[1] == '6')
                    {
                        return "R1";
                    }

                    if (pair[1] == '7')
                    {
                        return "31";
                    }

                    if (pair[1] == '8')
                    {
                        return "1W";
                    }

                    return "GW";

                case 'P':
                case 'Q':
                case 'R':
                    if (pair[1] == 'A')
                    {
                        return "RW";
                    }

                    if (pair[1] == 'B')
                    {
                        return "Y2";
                    }

                    if (pair[1] == 'C')
                    {
                        return "GB";
                    }

                    if (pair[1] == 'D')
                    {
                        return "2M";
                    }

                    if (pair[1] == 'E')
                    {
                        return "56";
                    }

                    if (pair[1] == 'F')
                    {
                        return "WB";
                    }

                    if (pair[1] == 'G')
                    {
                        return "B3";
                    }

                    if (pair[1] == 'H')
                    {
                        return "MR";
                    }

                    if (pair[1] == 'I')
                    {
                        return "32";
                    }

                    if (pair[1] == 'J')
                    {
                        return "Y3";
                    }

                    if (pair[1] == 'K')
                    {
                        return "2Y";
                    }

                    if (pair[1] == 'L')
                    {
                        return "4R";
                    }

                    if (pair[1] == 'M')
                    {
                        return "R5";
                    }

                    if (pair[1] == 'N')
                    {
                        return "5B";
                    }

                    if (pair[1] == 'O')
                    {
                        return "1M";
                    }

                    if (pair[1] == 'P')
                    {
                        return "Y6";
                    }

                    if (pair[1] == 'Q')
                    {
                        return "W4";
                    }

                    if (pair[1] == 'R')
                    {
                        return "R4";
                    }

                    if (pair[1] == 'S')
                    {
                        return "43";
                    }

                    if (pair[1] == 'T')
                    {
                        return "Y4";
                    }

                    if (pair[1] == 'U')
                    {
                        return "1Y";
                    }

                    if (pair[1] == 'V')
                    {
                        return "B4";
                    }

                    if (pair[1] == 'W')
                    {
                        return "R5";
                    }

                    if (pair[1] == 'X')
                    {
                        return "51";
                    }

                    if (pair[1] == 'Y')
                    {
                        return "M6";
                    }

                    if (pair[1] == 'Z')
                    {
                        return "R3";
                    }

                    if (pair[1] == '0')
                    {
                        return "4Y";
                    }

                    if (pair[1] == '1')
                    {
                        return "65";
                    }

                    if (pair[1] == '2')
                    {
                        return "R6";
                    }

                    if (pair[1] == '3')
                    {
                        return "Y1";
                    }

                    if (pair[1] == '4')
                    {
                        return "42";
                    }

                    if (pair[1] == '5')
                    {
                        return "65";
                    }

                    if (pair[1] == '6')
                    {
                        return "GW";
                    }

                    if (pair[1] == '7')
                    {
                        return "MY";
                    }

                    if (pair[1] == '8')
                    {
                        return "35";
                    }

                    return "MB";

                case 'S':
                case 'T':
                case 'U':
                    if (pair[1] == 'A')
                    {
                        return "64";
                    }

                    if (pair[1] == 'B')
                    {
                        return "1G";
                    }

                    if (pair[1] == 'C')
                    {
                        return "1W";
                    }

                    if (pair[1] == 'D')
                    {
                        return "WR";
                    }

                    if (pair[1] == 'E')
                    {
                        return "YW";
                    }

                    if (pair[1] == 'F')
                    {
                        return "63";
                    }

                    if (pair[1] == 'G')
                    {
                        return "6G";
                    }

                    if (pair[1] == 'H')
                    {
                        return "B3";
                    }

                    if (pair[1] == 'I')
                    {
                        return "WB";
                    }

                    if (pair[1] == 'J')
                    {
                        return "MW";
                    }

                    if (pair[1] == 'K')
                    {
                        return "YR";
                    }

                    if (pair[1] == 'L')
                    {
                        return "GW";
                    }

                    if (pair[1] == 'M')
                    {
                        return "6R";
                    }

                    if (pair[1] == 'N')
                    {
                        return "R4";
                    }

                    if (pair[1] == 'O')
                    {
                        return "56";
                    }

                    if (pair[1] == 'P')
                    {
                        return "BY";
                    }

                    if (pair[1] == 'Q')
                    {
                        return "61";
                    }

                    if (pair[1] == 'R')
                    {
                        return "B1";
                    }

                    if (pair[1] == 'S')
                    {
                        return "1W";
                    }

                    if (pair[1] == 'T')
                    {
                        return "5M";
                    }

                    if (pair[1] == 'U')
                    {
                        return "BG";
                    }

                    if (pair[1] == 'V')
                    {
                        return "GM";
                    }

                    if (pair[1] == 'W')
                    {
                        return "14";
                    }

                    if (pair[1] == 'X')
                    {
                        return "BR";
                    }

                    if (pair[1] == 'Y')
                    {
                        return "25";
                    }

                    if (pair[1] == 'Z')
                    {
                        return "YW";
                    }

                    if (pair[1] == '0')
                    {
                        return "35";
                    }

                    if (pair[1] == '1')
                    {
                        return "BR";
                    }

                    if (pair[1] == '2')
                    {
                        return "G5";
                    }

                    if (pair[1] == '3')
                    {
                        return "GY";
                    }

                    if (pair[1] == '4')
                    {
                        return "G1";
                    }

                    if (pair[1] == '5')
                    {
                        return "4M";
                    }

                    if (pair[1] == '6')
                    {
                        return "12";
                    }

                    if (pair[1] == '7')
                    {
                        return "53";
                    }

                    if (pair[1] == '8')
                    {
                        return "BM";
                    }

                    return "Y6";

                case 'V':
                case 'W':
                case 'X':
                    if (pair[1] == 'A')
                    {
                        return "16";
                    }

                    if (pair[1] == 'B')
                    {
                        return "MY";
                    }

                    if (pair[1] == 'C')
                    {
                        return "R3";
                    }

                    if (pair[1] == 'D')
                    {
                        return "BG";
                    }

                    if (pair[1] == 'E')
                    {
                        return "RM";
                    }

                    if (pair[1] == 'F')
                    {
                        return "B1";
                    }

                    if (pair[1] == 'G')
                    {
                        return "G6";
                    }

                    if (pair[1] == 'H')
                    {
                        return "14";
                    }

                    if (pair[1] == 'I')
                    {
                        return "GY";
                    }

                    if (pair[1] == 'J')
                    {
                        return "32";
                    }

                    if (pair[1] == 'K')
                    {
                        return "MB";
                    }

                    if (pair[1] == 'L')
                    {
                        return "3M";
                    }

                    if (pair[1] == 'M')
                    {
                        return "B6";
                    }

                    if (pair[1] == 'N')
                    {
                        return "43";
                    }

                    if (pair[1] == 'O')
                    {
                        return "M1";
                    }

                    if (pair[1] == 'P')
                    {
                        return "2G";
                    }

                    if (pair[1] == 'Q')
                    {
                        return "36";
                    }

                    if (pair[1] == 'R')
                    {
                        return "1B";
                    }

                    if (pair[1] == 'S')
                    {
                        return "B1";
                    }

                    if (pair[1] == 'T')
                    {
                        return "WR";
                    }

                    if (pair[1] == 'U')
                    {
                        return "62";
                    }

                    if (pair[1] == 'V')
                    {
                        return "R1";
                    }

                    if (pair[1] == 'W')
                    {
                        return "W6";
                    }

                    if (pair[1] == 'X')
                    {
                        return "G3";
                    }

                    if (pair[1] == 'Y')
                    {
                        return "Y2";
                    }

                    if (pair[1] == 'Z')
                    {
                        return "GY";
                    }

                    if (pair[1] == '0')
                    {
                        return "1M";
                    }

                    if (pair[1] == '1')
                    {
                        return "5G";
                    }

                    if (pair[1] == '2')
                    {
                        return "YW";
                    }

                    if (pair[1] == '3')
                    {
                        return "RW";
                    }

                    if (pair[1] == '4')
                    {
                        return "Y6";
                    }

                    if (pair[1] == '5')
                    {
                        return "2B";
                    }

                    if (pair[1] == '6')
                    {
                        return "6Y";
                    }

                    if (pair[1] == '7')
                    {
                        return "1M";
                    }

                    if (pair[1] == '8')
                    {
                        return "G4";
                    }

                    return "24";

                case 'Y':
                case 'Z':
                case '0':
                    if (pair[1] == 'A')
                    {
                        return "23";
                    }

                    if (pair[1] == 'B')
                    {
                        return "W6";
                    }

                    if (pair[1] == 'C')
                    {
                        return "5G";
                    }

                    if (pair[1] == 'D')
                    {
                        return "YW";
                    }

                    if (pair[1] == 'E')
                    {
                        return "GY";
                    }

                    if (pair[1] == 'F')
                    {
                        return "M4";
                    }

                    if (pair[1] == 'G')
                    {
                        return "MB";
                    }

                    if (pair[1] == 'H')
                    {
                        return "46";
                    }

                    if (pair[1] == 'I')
                    {
                        return "YR";
                    }

                    if (pair[1] == 'J')
                    {
                        return "BG";
                    }

                    if (pair[1] == 'K')
                    {
                        return "16";
                    }

                    if (pair[1] == 'L')
                    {
                        return "2B";
                    }

                    if (pair[1] == 'M')
                    {
                        return "GY";
                    }

                    if (pair[1] == 'N')
                    {
                        return "W2";
                    }

                    if (pair[1] == 'O')
                    {
                        return "4Y";
                    }

                    if (pair[1] == 'P')
                    {
                        return "5M";
                    }

                    if (pair[1] == 'Q')
                    {
                        return "BY";
                    }

                    if (pair[1] == 'R')
                    {
                        return "2R";
                    }

                    if (pair[1] == 'S')
                    {
                        return "36";
                    }

                    if (pair[1] == 'T')
                    {
                        return "46";
                    }

                    if (pair[1] == 'U')
                    {
                        return "M6";
                    }

                    if (pair[1] == 'V')
                    {
                        return "2W";
                    }

                    if (pair[1] == 'W')
                    {
                        return "4W";
                    }

                    if (pair[1] == 'X')
                    {
                        return "MG";
                    }

                    if (pair[1] == 'Y')
                    {
                        return "R1";
                    }

                    if (pair[1] == 'Z')
                    {
                        return "52";
                    }

                    if (pair[1] == '0')
                    {
                        return "BW";
                    }

                    if (pair[1] == '1')
                    {
                        return "YB";
                    }

                    if (pair[1] == '2')
                    {
                        return "52";
                    }

                    if (pair[1] == '3')
                    {
                        return "WG";
                    }

                    if (pair[1] == '4')
                    {
                        return "5G";
                    }

                    if (pair[1] == '5')
                    {
                        return "3R";
                    }

                    if (pair[1] == '6')
                    {
                        return "BR";
                    }

                    if (pair[1] == '7')
                    {
                        return "2R";
                    }

                    if (pair[1] == '8')
                    {
                        return "6Y";
                    }

                    return "4G";

                case '1':
                case '2':
                case '3':
                    if (pair[1] == 'A')
                    {
                        return "3M";
                    }

                    if (pair[1] == 'B')
                    {
                        return "34";
                    }

                    if (pair[1] == 'C')
                    {
                        return "46";
                    }

                    if (pair[1] == 'D')
                    {
                        return "3B";
                    }

                    if (pair[1] == 'E')
                    {
                        return "6G";
                    }

                    if (pair[1] == 'F')
                    {
                        return "G6";
                    }

                    if (pair[1] == 'G')
                    {
                        return "W5";
                    }

                    if (pair[1] == 'H')
                    {
                        return "YM";
                    }

                    if (pair[1] == 'I')
                    {
                        return "14";
                    }

                    if (pair[1] == 'J')
                    {
                        return "GM";
                    }

                    if (pair[1] == 'K')
                    {
                        return "3W";
                    }

                    if (pair[1] == 'L')
                    {
                        return "Y3";
                    }

                    if (pair[1] == 'M')
                    {
                        return "5B";
                    }

                    if (pair[1] == 'N')
                    {
                        return "YW";
                    }

                    if (pair[1] == 'O')
                    {
                        return "GB";
                    }

                    if (pair[1] == 'P')
                    {
                        return "G5";
                    }

                    if (pair[1] == 'Q')
                    {
                        return "15";
                    }

                    if (pair[1] == 'R')
                    {
                        return "43";
                    }

                    if (pair[1] == 'S')
                    {
                        return "24";
                    }

                    if (pair[1] == 'T')
                    {
                        return "3Y";
                    }

                    if (pair[1] == 'U')
                    {
                        return "GR";
                    }

                    if (pair[1] == 'V')
                    {
                        return "52";
                    }

                    if (pair[1] == 'W')
                    {
                        return "GR";
                    }

                    if (pair[1] == 'X')
                    {
                        return "36";
                    }

                    if (pair[1] == 'Y')
                    {
                        return "W3";
                    }

                    if (pair[1] == 'Z')
                    {
                        return "46";
                    }

                    if (pair[1] == '0')
                    {
                        return "G6";
                    }

                    if (pair[1] == '1')
                    {
                        return "GM";
                    }

                    if (pair[1] == '2')
                    {
                        return "2R";
                    }

                    if (pair[1] == '3')
                    {
                        return "52";
                    }

                    if (pair[1] == '4')
                    {
                        return "3M";
                    }

                    if (pair[1] == '5')
                    {
                        return "63";
                    }

                    if (pair[1] == '6')
                    {
                        return "M6";
                    }

                    if (pair[1] == '7')
                    {
                        return "R2";
                    }

                    if (pair[1] == '8')
                    {
                        return "4G";
                    }

                    return "B5";

                case '4':
                case '5':
                case '6':
                    if (pair[1] == 'A')
                    {
                        return "GY";
                    }

                    if (pair[1] == 'B')
                    {
                        return "BW";
                    }

                    if (pair[1] == 'C')
                    {
                        return "BM";
                    }

                    if (pair[1] == 'D')
                    {
                        return "G1";
                    }

                    if (pair[1] == 'E')
                    {
                        return "35";
                    }

                    if (pair[1] == 'F')
                    {
                        return "32";
                    }

                    if (pair[1] == 'G')
                    {
                        return "42";
                    }

                    if (pair[1] == 'H')
                    {
                        return "6W";
                    }

                    if (pair[1] == 'I')
                    {
                        return "6G";
                    }

                    if (pair[1] == 'J')
                    {
                        return "1R";
                    }

                    if (pair[1] == 'K')
                    {
                        return "53";
                    }

                    if (pair[1] == 'L')
                    {
                        return "5Y";
                    }

                    if (pair[1] == 'M')
                    {
                        return "1W";
                    }

                    if (pair[1] == 'N')
                    {
                        return "B5";
                    }

                    if (pair[1] == 'O')
                    {
                        return "6R";
                    }

                    if (pair[1] == 'P')
                    {
                        return "R3";
                    }

                    if (pair[1] == 'Q')
                    {
                        return "GR";
                    }

                    if (pair[1] == 'R')
                    {
                        return "6W";
                    }

                    if (pair[1] == 'S')
                    {
                        return "Y2";
                    }

                    if (pair[1] == 'T')
                    {
                        return "2G";
                    }

                    if (pair[1] == 'U')
                    {
                        return "2M";
                    }

                    if (pair[1] == 'V')
                    {
                        return "4Y";
                    }

                    if (pair[1] == 'W')
                    {
                        return "MY";
                    }

                    if (pair[1] == 'X')
                    {
                        return "6W";
                    }

                    if (pair[1] == 'Y')
                    {
                        return "BW";
                    }

                    if (pair[1] == 'Z')
                    {
                        return "WR";
                    }

                    if (pair[1] == '0')
                    {
                        return "64";
                    }

                    if (pair[1] == '1')
                    {
                        return "M1";
                    }

                    if (pair[1] == '2')
                    {
                        return "3G";
                    }

                    if (pair[1] == '3')
                    {
                        return "6M";
                    }

                    if (pair[1] == '4')
                    {
                        return "RW";
                    }

                    if (pair[1] == '5')
                    {
                        return "M2";
                    }

                    if (pair[1] == '6')
                    {
                        return "43";
                    }

                    if (pair[1] == '7')
                    {
                        return "BW";
                    }

                    if (pair[1] == '8')
                    {
                        return "21";
                    }

                    return "1R";

                default:
                    if (pair[1] == 'A')
                    {
                        return "W2";
                    }

                    if (pair[1] == 'B')
                    {
                        return "G1";
                    }

                    if (pair[1] == 'C')
                    {
                        return "61";
                    }

                    if (pair[1] == 'D')
                    {
                        return "45";
                    }

                    if (pair[1] == 'E')
                    {
                        return "41";
                    }

                    if (pair[1] == 'F')
                    {
                        return "4W";
                    }

                    if (pair[1] == 'G')
                    {
                        return "3M";
                    }

                    if (pair[1] == 'H')
                    {
                        return "R1";
                    }

                    if (pair[1] == 'I')
                    {
                        return "23";
                    }

                    if (pair[1] == 'J')
                    {
                        return "64";
                    }

                    if (pair[1] == 'K')
                    {
                        return "4M";
                    }

                    if (pair[1] == 'L')
                    {
                        return "M1";
                    }

                    if (pair[1] == 'M')
                    {
                        return "41";
                    }

                    if (pair[1] == 'N')
                    {
                        return "M6";
                    }

                    if (pair[1] == 'O')
                    {
                        return "YW";
                    }

                    if (pair[1] == 'P')
                    {
                        return "W1";
                    }

                    if (pair[1] == 'Q')
                    {
                        return "23";
                    }

                    if (pair[1] == 'R')
                    {
                        return "3Y";
                    }

                    if (pair[1] == 'S')
                    {
                        return "MR";
                    }

                    if (pair[1] == 'T')
                    {
                        return "R1";
                    }

                    if (pair[1] == 'U')
                    {
                        return "RB";
                    }

                    if (pair[1] == 'V')
                    {
                        return "Y3";
                    }

                    if (pair[1] == 'W')
                    {
                        return "6B";
                    }

                    if (pair[1] == 'X')
                    {
                        return "14";
                    }

                    if (pair[1] == 'Y')
                    {
                        return "6M";
                    }

                    if (pair[1] == 'Z')
                    {
                        return "24";
                    }

                    if (pair[1] == '0')
                    {
                        return "M3";
                    }

                    if (pair[1] == '1')
                    {
                        return "13";
                    }

                    if (pair[1] == '2')
                    {
                        return "1M";
                    }

                    if (pair[1] == '3')
                    {
                        return "3R";
                    }

                    if (pair[1] == '4')
                    {
                        return "14";
                    }

                    if (pair[1] == '5')
                    {
                        return "RY";
                    }

                    if (pair[1] == '6')
                    {
                        return "25";
                    }

                    if (pair[1] == '7')
                    {
                        return "W6";
                    }

                    if (pair[1] == '8')
                    {
                        return "M6";
                    }

                    return "W3";
            }
        }

        private String SwapCycle(String cycle, String sequence)
        {
            char[] cycleArr = cycle.ToCharArray();
            int firstIndex;
            int secondIndex;
            //two numbers
            if (sequence[0] >= 49 && sequence[0] <= 57 && sequence[1] >= 49 && sequence[1] <= 57)
            {
                //get index of both colors

                firstIndex = cycle[sequence[0]];
                secondIndex = cycle[sequence[1]];
            }

            //two letters
            else if (sequence[0] >= 65 && sequence[0] <= 90 && sequence[1] >= 65 && sequence[1] <= 90)
            {
                firstIndex = cycle.IndexOf(sequence[0]);
                secondIndex = cycle.IndexOf(sequence[1]);
            }

            //letter than number
            else if (sequence[0] >= 65 && sequence[0] <= 90 && sequence[1] >= 49 && sequence[1] <= 57)
            {
                firstIndex = cycle.IndexOf(sequence[0]);
                secondIndex = cycle[sequence[1]];
            }


            //number then letter
            else
            {
                firstIndex = cycle[sequence[0]];
                secondIndex = cycle.IndexOf(sequence[1]);
            }

            char firstChar = cycle[firstIndex];

            cycleArr[firstIndex] = cycle[secondIndex];

            cycleArr[secondIndex] = firstChar;

            return string.Join("", cycleArr);
        }

        private String GetAnswer(String cycle)
        {
            List<string> list = new List<string>();

            foreach (char character in cycle)
            {
                switch (character)
                { 
                    case 'R':
                        list.Add("Red");
                        break;

                    case 'B':
                        list.Add("Red");
                        break;

                    case 'Y':
                        list.Add("Red");
                        break;

                    case 'G':
                        list.Add("Red");
                        break;

                    case 'W':
                        list.Add("Red");
                        break;

                    case 'M':
                        list.Add("Magenta");
                        break;
                }
            }

            return string.Join(", ", list);
        }
    }
}
