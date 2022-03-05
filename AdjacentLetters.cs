using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace KTANE_Solver
{
    /// <summary>
    /// Author: Nya Bentley
    /// Purpose: Solves the Adjacent Letters module
    /// </summary>
    class AdjacentLetters : Module
    {
        private char[,] Grid { get; }
        private bool[,] Answer { get; set; }
        public AdjacentLetters(char[,] grid, Bomb bomb, StreamWriter logFileWriter) 
        : base (bomb, logFileWriter, "Adjacent Letters")
        {
            Grid = grid;            
        }

        public void Solve()
        {
            Answer = new bool[3, 4];

            for (int row = 0; row < 3; row++)
            {
                for (int column = 0; column < 4; column++)
                {
                    PrintDebug(Grid[row, column] + " ");
                    Answer[row, column] = Left(row, column) || Right(row, column) || Up(row, column) || Down(row, column);
                }

                PrintDebugLine("");
            }

            PrintDebugLine("");

            AdjacentLettersAnswerForm answerForm = new AdjacentLettersAnswerForm(Answer, LogFileWriter);
            answerForm.Show();
        }

        private bool Left(int row, int column)
        {
            if (column == 0)
            { 
                return false;
            }

            switch (Grid[row,column])
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

            switch (Grid[row, column])
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

            if (row == 2)
                return false;

            switch (Grid[row,column])
            {
                case 'A':
                    return ContainsLetter(row + 1, column, "HKPRW");

                case 'B':
                    return ContainsLetter(row + 1, column, "CDFYZ");

                case 'C':
                    return ContainsLetter(row + 1, column, "DEMTU");

                case 'D':
                    return ContainsLetter(row + 1, column, "CJTUW");

                case 'E':
                    return ContainsLetter(row + 1, column, "KSUWZ");

                case 'F':
                    return ContainsLetter(row + 1, column, "AGJPQ");

                case 'G':
                    return ContainsLetter(row + 1, column, "HOQYZ");

                case 'H':
                    return ContainsLetter(row + 1, column, "DKMPS");

                case 'I':
                    return ContainsLetter(row + 1, column, "EFNUV");

                case 'J':
                    return ContainsLetter(row + 1, column, "EHIOS");

                case 'K':
                    return ContainsLetter(row + 1, column, "DIORZ");

                case 'L':
                    return ContainsLetter(row + 1, column, "ABRVX");

                case 'M':
                    return ContainsLetter(row + 1, column, "BFPWX");

                case 'N':
                    return ContainsLetter(row + 1, column, "AFGHL");

                case 'O':
                    return ContainsLetter(row + 1, column, "IQSTX");

                case 'P':
                    return ContainsLetter(row + 1, column, "CFHKR");

                case 'Q':
                    return ContainsLetter(row + 1, column, "BDIKN");

                case 'R':
                    return ContainsLetter(row + 1, column, "BNOXY");

                case 'S':
                    return ContainsLetter(row + 1, column, "GMVYZ");

                case 'T':
                    return ContainsLetter(row + 1, column, "CJLSU");

                case 'U':
                    return ContainsLetter(row + 1, column, "BILNY");

                case 'V':
                    return ContainsLetter(row + 1, column, "AEJQX");

                case 'W':
                    return ContainsLetter(row + 1, column, "GLQRT");

                case 'X':
                    return ContainsLetter(row + 1, column, "AJNOV");

                case 'Y':
                    return ContainsLetter(row + 1, column, "EGMTW");

                default:
                    return ContainsLetter(row + 1, column, "CLMPV");
            }
        }

        private bool Up(int row, int column)
        {
            if (row == 0)
                return false;

            switch (Grid[row,column])
            {
                case 'A':
                    return ContainsLetter(row - 1, column, "HKPRW");

                case 'B':
                    return ContainsLetter(row - 1, column, "CDFYZ");

                case 'C':
                    return ContainsLetter(row - 1, column, "DEMTU");

                case 'D':
                    return ContainsLetter(row - 1, column, "CJTUW");

                case 'E':
                    return ContainsLetter(row - 1, column, "KSUWZ");

                case 'F':
                    return ContainsLetter(row - 1, column, "AGJPQ");

                case 'G':
                    return ContainsLetter(row - 1, column, "HOQYZ");

                case 'H':
                    return ContainsLetter(row - 1, column, "DKMPS");

                case 'I':
                    return ContainsLetter(row - 1, column, "EFNUV");

                case 'J':
                    return ContainsLetter(row - 1, column, "EHIOS");

                case 'K':
                    return ContainsLetter(row - 1, column, "DIORZ");

                case 'L':
                    return ContainsLetter(row - 1, column, "ABRVX");

                case 'M':
                    return ContainsLetter(row - 1, column, "BFPWX");

                case 'N':
                    return ContainsLetter(row - 1, column, "AFGHL");

                case 'O':
                    return ContainsLetter(row - 1, column, "IQSTX");

                case 'P':
                    return ContainsLetter(row - 1, column, "CFHKR");

                case 'Q':
                    return ContainsLetter(row - 1, column, "BDIKN");

                case 'R':
                    return ContainsLetter(row - 1, column, "BNOXY");

                case 'S':
                    return ContainsLetter(row - 1, column, "GMVYZ");

                case 'T':
                    return ContainsLetter(row - 1, column, "CJLSU");

                case 'U':
                    return ContainsLetter(row - 1, column, "BILNY");

                case 'V':
                    return ContainsLetter(row - 1, column, "AEJQX");

                case 'W':
                    return ContainsLetter(row - 1, column, "GLQRT");

                case 'X':
                    return ContainsLetter(row - 1, column, "AJNOV");

                case 'Y':
                    return ContainsLetter(row - 1, column, "EGMTW");

                default:
                    return ContainsLetter(row - 1, column, "CLMPV");
            }
        }



        private bool ContainsLetter(int row, int column, string str)
        {
            foreach (char c in str)
            {
                if (Grid[row, column] == c)
                    return true;
            }

            return false;
        }

    }
}
