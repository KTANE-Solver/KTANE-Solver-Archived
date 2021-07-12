using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace KTANE_Solver
{
    public class TwoBits : Module
    {

        public int initalCode;

        public TwoBits(Bomb bomb, StreamWriter logFileWriter) : base(bomb, logFileWriter)
        {

        }

        public String GetInitalCode()
        {
            //get initial code and show the user

            //If the serial number contains a letter, use the leftmost letter's numeric
            //position in the alphabet as your base value (e.g. A=1, B=2). For no letters, use 0.

            //Add the last digit of the serial number multiplied by the number of batteries present.

            initalCode = (Bomb.FirstLetter - 64) + (Bomb.LastDigit * Bomb.Battery);

            //If there is a Stereo RCA port present, double the current value.*

            //*Note: Skip this step if there is also an RJ45 port present.

            if (!Bomb.Rj.Visible && Bomb.Stereo.Visible)
            {
                initalCode *= 2;
            }

            //** Note: Use the last two digits if the value is greater than 99. Prepend with a zero if less than 10.
            String answer = ConvertCode(initalCode);

            initalCode %= 100;

            return answer;
        }

        public void Solve(int stage, int response)
        {
            String answer = ConvertCode(response);

            if (stage == 4)
            {
                ShowAnswer($"Insert {answer} and press submit", "Two Bits Stage 4");
            }

            else
            { 
                ShowAnswer($"Insert {answer} and press query", $"Two Bits Stage {response}");
            }
        }

        public String ConvertCode(int code)
        {
            switch (code)
            {
                case 0:
                    return "KB";

                case 1:
                    return "DK";

                case 2:
                    return "GV";

                case 3:
                    return "TK";

                case 4:
                    return "PV";

                case 5:
                    return "KP";

                case 6:
                    return "BV";

                case 7:
                    return "VT";

                case 8:
                    return "PZ";

                case 9:
                    return "DT";

                case 10:
                    return "EE";

                case 11:
                    return "ZK";

                case 12:
                    return "KE";

                case 13:
                    return "CK";

                case 14:
                    return "ZP";

                case 15:
                    return "PP";

                case 16:
                    return "TP";

                case 17:
                    return "TG";

                case 18:
                    return "PD";

                case 19:
                    return "PT";

                case 20:
                    return "TZ";

                case 21:
                    return "EB";

                case 22:
                    return "EC";

                case 23:
                    return "CC";

                case 24:
                    return "CZ";

                case 25:
                    return "ZV";

                case 26:
                    return "CV";

                case 27:
                    return "GC";

                case 28:
                    return "BT";

                case 29:
                    return "GT";

                case 30:
                    return "BZ";

                case 31:
                    return "PK";

                case 32:
                    return "KZ";

                case 33:
                    return "KG";

                case 34:
                    return "VD";

                case 35:
                    return "CE";

                case 36:
                    return "VB";

                case 37:
                    return "KD";

                case 38:
                    return "GG";

                case 39:
                    return "DG";

                case 40:
                    return "PB";

                case 41:
                    return "VV";

                case 42:
                    return "GE";

                case 43:
                    return "KV";

                case 44:
                    return "DZ";

                case 45:
                    return "PE";

                case 46:
                    return "DB";

                case 47:
                    return "CD";

                case 48:
                    return "TD";

                case 49:
                    return "CB";

                case 50:
                    return "GB";

                case 51:
                    return "TV";

                case 52:
                    return "KK";

                case 53:
                    return "BG";

                case 54:
                    return "BP";

                case 55:
                    return "VP";

                case 56:
                    return "EP";

                case 57:
                    return "TT";

                case 58:
                    return "ED";

                case 59:
                    return "ZG";

                case 60:
                    return "DE";

                case 61:
                    return "DD";

                case 62:
                    return "EV";

                case 63:
                    return "TE";

                case 64:
                    return "ZD";

                case 65:
                    return "BB";

                case 66:
                    return "PC";

                case 67:
                    return "BD";

                case 68:
                    return "KC";

                case 69:
                    return "ZB";

                case 70:
                    return "DE";

                case 71:
                    return "BC";

                case 72:
                    return "TC";

                case 73:
                    return "ZE";

                case 74:
                    return "ZC";

                case 75:
                    return "GP";

                case 76:
                    return "ET";

                case 77:
                    return "VC";

                case 78:
                    return "TB";

                case 79:
                    return "VZ";

                case 80:
                    return "EZ";

                case 81:
                    return "EK";

                case 82:
                    return "DV";

                case 83:
                    return "CG";

                case 84:
                    return "VE";

                case 85:
                    return "DP";

                case 86:
                    return "BK";

                case 87:
                    return "PG";

                case 88:
                    return "GK";

                case 89:
                    return "GZ";

                case 90:
                    return "KT";

                case 91:
                    return "CT";

                case 92:
                    return "ZZ";

                case 93:
                    return "VG";

                case 94:
                    return "GD";

                case 95:
                    return "CP";

                case 96:
                    return "BE";

                case 97:
                    return "ZT";

                case 98:
                    return "VK";

                default:
                    return "GZ";


            }
        }
    }
}
