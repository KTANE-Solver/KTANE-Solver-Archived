using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace KTANE_Solver
{
    //Author: Nya Bentley
    //Date: 3/6/21
    //Purpose: Solves the logic module
    public class Logic : Module
    {
        //=========FIELDS=========

        //the letters for the top evaluation
        private char topFirstLetter;
        private char topSecondLetter;
        private char topThirdLetter;

        //tells if the statement for each top letter is true or false
        private bool topFirstStatement;
        private bool topSecondStatement;
        private bool topThirdStatement;

        //tells if the top statments are the opposite
        private bool topFirstNotStatement;
        private bool topSecondNotStatement;
        private bool topThirdNotStatement;


        //the operations for the top evaluation
        private String topFirstOperation;
        private String topSecondOperation;

        //tells if the first two statemetnts should be
        //evalualted first
        private bool topFirstTwoFirst;

        //the letters for the bottom evaluation
        private char bottomFirstLetter;
        private char bottomSecondLetter;
        private char bottomThirdLetter;

        //tells if the statement for each bottom letter is true or false
        private bool bottomFirstStatement;
        private bool bottomSecondStatement;
        private bool bottomThirdStatement;

        //tells if the bottom statments are the opposite
        private bool bottomFirstNotStatement;
        private bool bottomSecondNotStatement;
        private bool bottomThirdNotStatement;

        //the operations for the top evaluation
        private String bottomFirstOperation;
        private String bottomSecondOperation;

        //tells if the first two statemetnts should be
        //evalualted first
        private bool bottomFirstTwoFirst;


        //=========PROPERTIES=========

        //=========CONSTRUCTORS=========

        /// <summary>
        /// Creates a object that will solve
        /// the logic module
        /// </summary>
        /// <param name="Bomb">used to get the edgework</param>
        /// <param name="topFirstNotStatement">if the top first statement is the opposite</param>
        /// <param name="topFirstLetter">top left letter</param>
        /// <param name="topSecondNotStatement">if the top second statement is the opposite</param>
        /// <param name="topSecondLetter">top middle letter</param>
        /// <param name="topThirdNotStatement">if the top third statement is the opposite</param>
        /// <param name="topThirdLetter">top right letter</param>
        /// <param name="topFirstOperation">top first operation</param>
        /// <param name="topSecondOperation">top second operation</param>
        /// <param name="topFirstTwoFirst">if the top two statments are evaluated first</param>
        /// <param name="bottomFirstLetter">bottom left letter</param>
        /// <param name="bottomSecondLetter">bottom middle letter</param>
        /// <param name="bottomThirdLetter">bottom right letter</param>
        /// <param name="bottomFirstOperation">bottom first operation</param>
        /// <param name="bottomSecondOperation">bottom second operation</param>
        /// <param name="bottomFirstTwoFirst">tells if the first two bottom statements are evaluated first</param>
        /// 
        public Logic(Bomb Bomb, 
                     bool topFirstNotStatement, char topFirstLetter, 
                     bool topSecondNotStatement, char topSecondLetter, 
                     bool topThirdNotStatement, char topThirdLetter, 
                     String topFirstOperation, String topSecondOperation, 
                     bool topFirstTwoFirst,
                     bool bottomFirstNotStatement, char bottomFirstLetter, 
                     bool bottomSecondNotStatement, char bottomSecondLetter,
                     bool bottomThirdNotStatement,  char bottomThirdLetter, 
                     String bottomFirstOperation, String bottomSecondOperation, 
                     bool bottomFirstTwoFirst, StreamWriter LogFileWriter) : base(Bomb, LogFileWriter)
        {

            this.topFirstNotStatement = topFirstNotStatement;
            this.topSecondNotStatement = topSecondNotStatement;
            this.topThirdNotStatement = topThirdNotStatement;

            this.topFirstLetter = topFirstLetter;
            this.topSecondLetter = topSecondLetter;
            this.topThirdLetter = topThirdLetter;

            this.topFirstOperation = topFirstOperation;
            this.topSecondOperation = topSecondOperation;

            this.topFirstTwoFirst = topFirstTwoFirst;

            this.bottomFirstNotStatement = bottomFirstNotStatement;
            this.bottomSecondNotStatement = bottomSecondNotStatement;
            this.bottomThirdNotStatement = bottomThirdNotStatement;

            this.bottomFirstLetter = bottomFirstLetter;
            this.bottomSecondLetter = bottomSecondLetter;
            this.bottomThirdLetter = bottomThirdLetter;

            this.bottomFirstOperation = bottomFirstOperation;
            this.bottomSecondOperation = bottomSecondOperation;

            this.bottomFirstTwoFirst = bottomFirstTwoFirst;
        }

        public void Solve()
        {
            LogFileWriter.WriteLine("======================LOGIC======================");

            //setting the statements
            topFirstStatement = SetStatement("Top", "First", topFirstLetter);

            topSecondStatement = SetStatement("Top", "Second", topSecondLetter);

            topThirdStatement = SetStatement("Top", "Third", topThirdLetter);

            bottomFirstStatement = SetStatement("Bottom", "First", bottomFirstLetter);

            bottomSecondStatement = SetStatement("Bottom", "Second", bottomSecondLetter);

            bottomThirdStatement = SetStatement("Bottom", "Third", bottomThirdLetter);

            //updating statements
            topFirstStatement = UpdateStatement("Top First", topFirstStatement, topFirstNotStatement);
            topSecondStatement = UpdateStatement("Top Second", topSecondStatement, topSecondNotStatement);
            topThirdStatement = UpdateStatement("Top Third", topThirdStatement, topThirdNotStatement);

            bottomFirstStatement = UpdateStatement("Bottom First", bottomFirstStatement, bottomFirstNotStatement);
            bottomSecondStatement = UpdateStatement("Bottom Second", bottomSecondStatement, bottomSecondNotStatement);
            bottomThirdStatement = UpdateStatement("Bottom Third", bottomThirdStatement, bottomThirdNotStatement);

            //evaluating the statements

            bool topEvaluation;
            if (topFirstTwoFirst)
            {
                topEvaluation = EvaluateStatement(topFirstStatement, topSecondStatement, topFirstOperation, "Top", "first");
                topEvaluation = EvaluateStatement(topEvaluation, topThirdStatement, topSecondOperation, "Top", "second");
            }

            else
            {
                topEvaluation = EvaluateStatement(topSecondStatement, topThirdStatement, topSecondOperation, "Top", "second");
                topEvaluation = EvaluateStatement(topFirstStatement, topEvaluation, topFirstOperation, "Top", "first");
            }

            bool bottomEvaluation;
            if (bottomFirstTwoFirst)
            {
                bottomEvaluation = EvaluateStatement(bottomFirstStatement, bottomSecondStatement, bottomFirstOperation, "Bottom", "first");
                bottomEvaluation = EvaluateStatement(bottomEvaluation, bottomThirdStatement, bottomSecondOperation, "Bottom", "second");
            }

            else
            {
                bottomEvaluation = EvaluateStatement(bottomSecondStatement, bottomThirdStatement, bottomSecondOperation, "Bottom", "second");
                bottomEvaluation = EvaluateStatement(bottomFirstStatement, bottomEvaluation, bottomFirstOperation, "Bottom", "first");
            }

            String text = $"Top: {topEvaluation} \nBottom: {bottomEvaluation}";

            MessageBox.Show(text, "Logic Answer", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //=========METHODS=========

        /// <summary>
        /// Tells if a statement if true or false
        /// based on a character
        /// </summary>
        /// <param name="top">the placement vertically of the letter</param>
        /// <param name="place">the placement horizontally of the letter</param>
        /// <param name="character">the charcter the statement will be based on</param>
        /// <returns>if the statement is true or false</returns>
        private bool SetStatement(String top, String place, char character)
        {
            bool statement = false;
            String statementString = "";

            switch (character)
            {
                //A - Number of batteries = number of indicators
                case 'A':
                    

                    statement = Bomb.Battery == Bomb.IndicatorNum;
                    statementString = "Number of batteries = number of indicators";
                    break;

                //B - Serial number has more letters than digits
                case 'B':

                    statement = Bomb.LetterNum > Bomb.DigitNum;
                    statementString = "Serial number has more letters than digits";
                    break;

                //C - Has IND indicator
                case 'C':

                    statement = Bomb.Ind.Visible;
                    statementString = "Has IND indicator";
                    break;

                //D - Has FRK indicator
                case 'D':

                    statement = Bomb.Frk.Visible;
                    statementString = "Has FRK indicator";
                    break;

                //E - Exactly 1 unlit indicator
                case 'E':

                    statement = Bomb.IndicatorUnlitNum == 1;
                    statementString = "Exactly 1 unlit indicator";
                    break;

                //F - More than 1 port type
                case 'F':

                    statement = Bomb.UniquePortNum > 1;
                    statementString = "More than 1 port type";
                    break;

                //G - 2 batteries or more
                case 'G':

                    statement = Bomb.Battery >= 2;
                    statementString = "2 batteries or more";
                    break;

                //H - Less than 2 batteries
                case 'H':

                    statement = Bomb.Battery < 2;
                    statementString = "Less than 2 batteries";
                    break;

                //I - Last digit of serial number is odd
                case 'I':

                    statement = Bomb.LastDigit % 2 == 1;
                    statementString = "Last digit of serial number is odd";
                    break;

                //J - More than 4 batteries
                case 'J':

                    statement = Bomb.Battery > 4;
                    statementString = "More than 4 batteries";
                    break;

                //K - Exactly 1 lit indicator
                case 'K':

                    statement = Bomb.IndicatorLitNum == 1;
                    statementString = "Exactly 1 lit indicator";
                    break;

                //L - More than 2 indicators
                case 'L':

                    statement = Bomb.IndicatorNum > 2;
                    statementString = "More than 2 indicators";
                    break;

                //M - No duplicate ports
                case 'M':

                    statement = Bomb.UniquePortNum == Bomb.PortNum;
                    statementString = "No duplicate ports";
                    break;

                //N - More than 2 battery holders
                case 'N':

                    statement = Bomb.BatteryHolder > 2;
                    statementString = "More than 2 battery holders";
                    break;

                //O - Has both lit and unlit indicators
                case 'O':

                    statement = Bomb.IndicatorLitNum > 0 && Bomb.IndicatorUnlitNum > 0;
                    statementString = "Has both lit and unlit indicators";
                    break;

                //P - Has parallel port
                case 'P':

                    statement = Bomb.Parallel.Visible;
                    statementString = "Has parallel port";
                    break;

                //Q - Exactly 2 ports
                case 'Q':

                    statement = Bomb.PortNum == 2;
                    statementString = "Exactly 2 ports";
                    break;

                //R - Has PS/2 port
                case 'R':

                    statement = Bomb.Ps.Visible;
                    statementString = "Has PS/2 port";
                    break;

                //S - Sum of digits in serial number > 10
                case 'S':

                    statement = Bomb.DigitSum > 10;
                    statementString = "2 batteries or more";
                    break;

                //T - Has MSA indicator
                case 'T':

                    statement = Bomb.Msa.Visible;
                    statementString = "Has MSA indicator";
                    break;

                //U - Exactly 1 battery holder
                case 'U':

                    statement = Bomb.BatteryHolder == 1;
                    statementString = "Exactly 1 battery holder";
                    break;

                //V - Serial number contains vowels
                case 'V':

                    statement = Bomb.HasVowel;
                    statementString = "Serial number contains vowels";
                    break;

                //W - No indicators
                case 'W':

                    statement = Bomb.IndicatorNum == 0;
                    statementString = "No indicators";
                    break;

                //X - Exactly 1 indicator
                case 'X':

                    statement = Bomb.IndicatorNum == 1;
                    statementString = "Exactly 1 indicator";
                    break;

                //Y - More than 5 ports
                case 'Y':

                    statement = Bomb.PortNum > 5;
                    statementString = "More than 5 ports";
                    break;
                    
                //Z - Less than 2 ports
                case 'Z':

                    statement = Bomb.PortNum < 2;
                    statementString = "Less than 2 ports";
                    break;
            }

            LogFileWriter.WriteLine($"{top} {place}: {character} - {statementString}: {statement} \n");

            return statement;
        }

        private bool UpdateStatement(String letterPosition, bool statement, bool notStatement)
        {
            if (notStatement)
            {
                statement = !statement;
                LogFileWriter.WriteLine($"Not statement detected. {letterPosition} Statement is now {statement}\n");
            }

            return statement;
        }

        /// <summary>
        /// Evauluatees a boolen operation
        /// </summary>
        /// <param name="bool1">the first boolean</param>
        /// <param name="bool2">the second boolean</param>
        /// <param name="operation">the operation used to evaulate the statement</param>
        /// <param name="topBottom">if the statement is on the top or bottom</param>
        /// <param name="firstSecond">if the statement is using the first or second operation</param>
        /// <returns>the evauluated statement</returns>

        private bool EvaluateStatement(bool bool1, bool bool2, String operation, String topBottom, String firstSecond)
        {
            bool statement = false;
            String opeartionString = "";

            switch (operation)
            {
                //AND
                case "∧":
                    statement = bool1 && bool2;
                    opeartionString = "AND";
                    break;

                //OR
                case "∨":
                    statement = bool1 || bool2;
                    opeartionString = "OR";
                    break;

                //XOR
                case "⊻":
                    statement = bool1 ^ bool2;
                    opeartionString = "XOR";

                    break;

                //NAND
                case "|":
                    statement = !(bool1 && bool2);
                    opeartionString = "NAND";
                    break;

                //NOR
                case "↓":
                    statement = !(bool1 || bool2);
                    opeartionString = "NOR";
                    break;

                //XNOR
                case "↔":
                    statement = !(bool1 ^ bool2);
                    opeartionString = "XNOR";
                    break;

                //NOT 1 OR 2
                case "→":
                    statement = !bool1 || bool2;
                    opeartionString = "IMPLIES LEFT";
                    break;

                //NOT 2 OR 1
                case "←":
                    statement = bool1 || !bool2;
                    opeartionString = "IMPLIES RIGHT";
                    break;

                default:
                    statement = false;
                    opeartionString = "INVALID";
                    break;
            }

            LogFileWriter.WriteLine($"{topBottom} {firstSecond} statement: {bool1} {opeartionString} {bool2} returns {statement}\n");
            return statement;
        }
    }
}
