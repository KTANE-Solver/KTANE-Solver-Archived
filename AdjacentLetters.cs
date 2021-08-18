using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace KTANE_Solver
{
    class AdjacentLetters : Module
    {
        private char[,] grid;
        private bool [,] answer;
        public AdjacentLetters(char[,] grid, Bomb bomb, StreamWriter logFileWriter) : base (bomb, logFileWriter)
        {
            this.grid = grid;
            answer = new bool[3, 4];

            for (int row = 0; row < 3; row++)
            {
                for (int column = 0; column < 4; column++)
                {
                    answer[row, column] = Left(row, column) || Right(row, column) || Up(row, column) || Down(row, column);
                }
            }


                
        }

        private bool Left(int row, int column)
        {
            if (column == 0)
                return false;

            switch (grid[row,column])
            {
                case 'A':
                    return ContainsLetter(row, column - 1, "GJMOY");

                case 'B':
                    return ContainsLetter(row, column - 1, "IKLRT");

                case 'C':
                    return ContainsLetter(row, column - 1, "BHIJW");

                case 'D':
                    return ContainsLetter(row, column - 1, "IKOPQ");

                case 'E':
                    return ContainsLetter(row, column - 1, "ACGIJ");

                case 'F':
                    return ContainsLetter(row, column - 1, "CERVY");

                case 'G':
                    return ContainsLetter(row, column - 1, "ACFNS");

                case 'H':
                    return ContainsLetter(row, column - 1, "LRTUX");

                case 'I':
                    return ContainsLetter(row, column - 1, "DLOWZ");

                case 'J':
                    return ContainsLetter(row, column - 1, "BQTUW");

                case 'K':
                    return ContainsLetter(row, column - 1, "AFPXY");

                case 'L':
                    return ContainsLetter(row, column - 1, "GKPTZ");

                case 'M':
                    return ContainsLetter(row, column - 1, "EILQT");

                case 'N':
                    return ContainsLetter(row, column - 1, "PQRSV");

                case 'O':
                    return ContainsLetter(row, column - 1, "HJLUZ");

                case 'P':
                    return ContainsLetter(row, column - 1, "DMNOX");

                case 'Q':
                    return ContainsLetter(row, column - 1, "CEOPV");

                case 'R':
                    return ContainsLetter(row, column - 1, "AEGSU");

                case 'S':
                    return ContainsLetter(row, column - 1, "ABEKQ");

                case 'T':
                    return ContainsLetter(row, column - 1, "GVXYZ");

                case 'U':
                    return ContainsLetter(row, column - 1, "FMVXZ");

                case 'V':
                    return ContainsLetter(row, column - 1, "DHMNW");

                case 'W':
                    return ContainsLetter(row, column - 1, "DFHMN");

                case 'X':
                    return ContainsLetter(row, column - 1, "BDFKW");

                case 'Y':
                    return ContainsLetter(row, column - 1, "BCHSU");

                default:
                    return ContainsLetter(row, column - 1, "JNRSY");
            }
        }

        private bool Right(int row, int column)
        {
            if (column == 3)
                return false;

            switch (grid[row, column])
            {
                case 'A':
                    return ContainsLetter(row, column + 1, "GJMOY");

                case 'B':
                    return ContainsLetter(row, column + 1, "IKLRT");

                case 'C':
                    return ContainsLetter(row, column + 1, "BHIJW");

                case 'D':
                    return ContainsLetter(row, column + 1, "IKOPQ");

                case 'E':
                    return ContainsLetter(row, column + 1, "ACGIJ");

                case 'F':
                    return ContainsLetter(row, column + 1, "CERVY");

                case 'G':
                    return ContainsLetter(row, column + 1, "ACFNS");

                case 'H':
                    return ContainsLetter(row, column + 1, "LRTUX");

                case 'I':
                    return ContainsLetter(row, column + 1, "DLOWZ");

                case 'J':
                    return ContainsLetter(row, column + 1, "BQTUW");

                case 'K':
                    return ContainsLetter(row, column + 1, "AFPXY");

                case 'L':
                    return ContainsLetter(row, column + 1, "GKPTZ");

                case 'M':
                    return ContainsLetter(row, column + 1, "EILQT");

                case 'N':
                    return ContainsLetter(row, column + 1, "PQRSV");

                case 'O':
                    return ContainsLetter(row, column + 1, "HJLUZ");

                case 'P':
                    return ContainsLetter(row, column + 1, "DMNOX");

                case 'Q':
                    return ContainsLetter(row, column + 1, "CEOPV");

                case 'R':
                    return ContainsLetter(row, column + 1, "AEGSU");

                case 'S':
                    return ContainsLetter(row, column + 1, "ABEKQ");

                case 'T':
                    return ContainsLetter(row, column + 1, "GVXYZ");

                case 'U':
                    return ContainsLetter(row, column + 1, "FMVXZ");

                case 'V':
                    return ContainsLetter(row, column + 1, "DHMNW");

                case 'W':
                    return ContainsLetter(row, column + 1, "DFHMN");

                case 'X':
                    return ContainsLetter(row, column + 1, "BDFKW");

                case 'Y':
                    return ContainsLetter(row, column + 1, "BCHSU");

                default:
                    return ContainsLetter(row, column + 1, "JNRSY");
            }
        }

        private bool Down(int row, int column)
        {
            if (column == 3)
                return false;

            switch (grid[row,column])
            {
                case 'A':
                    return ContainsLetter(row, column + 1, "HKPRW");

                case 'B':
                    return ContainsLetter(row, column + 1, "CDFYZ");

                case 'C':
                    return ContainsLetter(row, column + 1, "DEMTU");

                case 'D':
                    return ContainsLetter(row, column + 1, "CJTUW");

                case 'E':
                    return ContainsLetter(row, column + 1, "KSUWZ");

                case 'F':
                    return ContainsLetter(row, column + 1, "AGJPQ");

                case 'G':
                    return ContainsLetter(row, column + 1, "HOQYZ");

                case 'H':
                    return ContainsLetter(row, column + 1, "DKMPS");

                case 'I':
                    return ContainsLetter(row, column + 1, "EFNUV");

                case 'J':
                    return ContainsLetter(row, column + 1, "EHIOS");

                case 'K':
                    return ContainsLetter(row, column + 1, "DIORZ");

                case 'L':
                    return ContainsLetter(row, column + 1, "ABRVX");

                case 'M':
                    return ContainsLetter(row, column + 1, "BFPWX");

                case 'N':
                    return ContainsLetter(row, column + 1, "AFGHL");

                case 'O':
                    return ContainsLetter(row, column + 1, "IQSTX");

                case 'P':
                    return ContainsLetter(row, column + 1, "CFHKR");

                case 'Q':
                    return ContainsLetter(row, column + 1, "BDIKN");

                case 'R':
                    return ContainsLetter(row, column + 1, "BNOXY");

                case 'S':
                    return ContainsLetter(row, column + 1, "GMVYZ");

                case 'T':
                    return ContainsLetter(row, column + 1, "GVXYZ");

                case 'U':
                    return ContainsLetter(row, column + 1, "BILNY");

                case 'V':
                    return ContainsLetter(row, column + 1, "AEJQX");

                case 'W':
                    return ContainsLetter(row, column + 1, "GLQRT");

                case 'X':
                    return ContainsLetter(row, column + 1, "AJNOV");

                case 'Y':
                    return ContainsLetter(row, column + 1, "EGMTW");

                default:
                    return ContainsLetter(row, column + 1, "CLMPV");
            }
        }

        private bool Up(int row, int column)
        {
            if (column == 0)
                return false;

            switch (grid[row,column])
            {
                case 'A':
                    return ContainsLetter(row, column - 1, "HKPRW");

                case 'B':
                    return ContainsLetter(row, column - 1, "CDFYZ");

                case 'C':
                    return ContainsLetter(row, column - 1, "DEMTU");

                case 'D':
                    return ContainsLetter(row, column - 1, "CJTUW");

                case 'E':
                    return ContainsLetter(row, column - 1, "KSUWZ");

                case 'F':
                    return ContainsLetter(row, column - 1, "AGJPQ");

                case 'G':
                    return ContainsLetter(row, column - 1, "HOQYZ");

                case 'H':
                    return ContainsLetter(row, column - 1, "DKMPS");

                case 'I':
                    return ContainsLetter(row, column - 1, "EFNUV");

                case 'J':
                    return ContainsLetter(row, column - 1, "EHIOS");

                case 'K':
                    return ContainsLetter(row, column - 1, "DIORZ");

                case 'L':
                    return ContainsLetter(row, column - 1, "ABRVX");

                case 'M':
                    return ContainsLetter(row, column - 1, "BFPWX");

                case 'N':
                    return ContainsLetter(row, column - 1, "AFGHL");

                case 'O':
                    return ContainsLetter(row, column - 1, "IQSTX");

                case 'P':
                    return ContainsLetter(row, column - 1, "CFHKR");

                case 'Q':
                    return ContainsLetter(row, column - 1, "BDIKN");

                case 'R':
                    return ContainsLetter(row, column - 1, "BNOXY");

                case 'S':
                    return ContainsLetter(row, column - 1, "GMVYZ");

                case 'T':
                    return ContainsLetter(row, column - 1, "GVXYZ");

                case 'U':
                    return ContainsLetter(row, column - 1, "BILNY");

                case 'V':
                    return ContainsLetter(row, column - 1, "AEJQX");

                case 'W':
                    return ContainsLetter(row, column - 1, "GLQRT");

                case 'X':
                    return ContainsLetter(row, column - 1, "AJNOV");

                case 'Y':
                    return ContainsLetter(row, column - 1, "EGMTW");

                default:
                    return ContainsLetter(row, column - 1, "CLMPV");
            }
        }



        private bool ContainsLetter(int row, int column, string str)
        {
            foreach (char c in str)
            {
                if (grid[row, column] == c)
                    return true;
            }

            return false;
        }

    }
}
