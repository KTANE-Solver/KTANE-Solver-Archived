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
            //setting the statements
            topFirstStatement = SetStatement(topFirstLetter);

            topSecondStatement = SetStatement(topSecondLetter);

            topThirdStatement = SetStatement(topThirdLetter);

            bottomFirstStatement = SetStatement(bottomFirstLetter);

            bottomSecondStatement = SetStatement(bottomSecondLetter);

            bottomThirdStatement = SetStatement(bottomThirdLetter);

            PrintLetterInfo(new List<char> {topFirstLetter, topSecondLetter, topThirdLetter, bottomFirstLetter, bottomFirstLetter, bottomThirdLetter}.Distinct().ToList());

            //updating statements
            topFirstStatement = UpdateStatement(topFirstStatement, topFirstNotStatement);
            topSecondStatement = UpdateStatement(topSecondStatement, topSecondNotStatement);
            topThirdStatement = UpdateStatement(topThirdStatement, topThirdNotStatement);

            bottomFirstStatement = UpdateStatement(bottomFirstStatement, bottomFirstNotStatement);
            bottomSecondStatement = UpdateStatement(bottomSecondStatement, bottomSecondNotStatement);
            bottomThirdStatement = UpdateStatement(bottomThirdStatement, bottomThirdNotStatement);

            //evaluating the statements

            bool topEvaluation;
            if (topFirstTwoFirst)
            {
                topEvaluation = EvaluateStatement(topFirstStatement, topSecondStatement, topFirstOperation);
                topEvaluation = EvaluateStatement(topEvaluation, topThirdStatement, topSecondOperation);
            }

            else
            {
                topEvaluation = EvaluateStatement(topSecondStatement, topThirdStatement, topSecondOperation);
                topEvaluation = EvaluateStatement(topFirstStatement, topEvaluation, topFirstOperation);
            }

            bool bottomEvaluation;
            if (bottomFirstTwoFirst)
            {
                bottomEvaluation = EvaluateStatement(bottomFirstStatement, bottomSecondStatement, bottomFirstOperation);
                bottomEvaluation = EvaluateStatement(bottomEvaluation, bottomThirdStatement, bottomSecondOperation);
            }

            else
            {
                bottomEvaluation = EvaluateStatement(bottomSecondStatement, bottomThirdStatement, bottomSecondOperation);
                bottomEvaluation = EvaluateStatement(bottomFirstStatement, bottomEvaluation, bottomFirstOperation);
            }

            ShowAnswer($"Top: {topEvaluation} \nBottom: {bottomEvaluation}", "Logic Answer");
        }

        //=========METHODS=========

        /// <summary>
        /// Prints if each letter is true or not
        /// </summary>
        /// <param name="list">the list of letters</param>
        private void PrintLetterInfo(List<char> list)
        {
            PrintDebugLine("Letters:");
            foreach (char c in list)
            {
                PrintDebugLine($"{c}: ");
            }

        }

        /// <summary>
        /// Tells if a statement if true or false
        /// based on a character
        /// </summary>
        /// <param name="character">the charcter the statement will be based on</param>
        /// <returns>if the statement is true or false</returns>
        private bool SetStatement(char character)
        {
            bool statement = false;
            switch (character)
            {
                //A - Number of batteries = number of indicators
                case 'A':
                    

                    statement = Bomb.Battery == Bomb.IndicatorNum;
                    break;

                //B - Serial number has more letters than digits
                case 'B':

                    statement = Bomb.LetterNum > Bomb.DigitNum;
                    break;

                //C - Has IND indicator
                case 'C':

                    statement = Bomb.Ind.Visible;
                    break;

                //D - Has FRK indicator
                case 'D':

                    statement = Bomb.Frk.Visible;
                    break;

                //E - Exactly 1 unlit indicator
                case 'E':

                    statement = Bomb.IndicatorUnlitNum == 1;
                    break;

                //F - More than 1 port type
                case 'F':

                    statement = Bomb.UniquePortNum > 1;
                    break;

                //G - 2 batteries or more
                case 'G':

                    statement = Bomb.Battery >= 2;
                    break;

                //H - Less than 2 batteries
                case 'H':

                    statement = Bomb.Battery < 2;
                    break;

                //I - Last digit of serial number is odd
                case 'I':

                    statement = Bomb.LastDigit % 2 == 1;
                    break;

                //J - More than 4 batteries
                case 'J':

                    statement = Bomb.Battery > 4;
                    break;

                //K - Exactly 1 lit indicator
                case 'K':

                    statement = Bomb.IndicatorLitNum == 1;
                    break;

                //L - More than 2 indicators
                case 'L':

                    statement = Bomb.IndicatorNum > 2;
                    break;

                //M - No duplicate ports
                case 'M':

                    statement = Bomb.UniquePortNum == Bomb.PortNum;
                    break;

                //N - More than 2 battery holders
                case 'N':

                    statement = Bomb.BatteryHolder > 2;
                    break;

                //O - Has both lit and unlit indicators
                case 'O':

                    statement = Bomb.IndicatorLitNum > 0 && Bomb.IndicatorUnlitNum > 0;
                    break;

                //P - Has parallel port
                case 'P':

                    statement = Bomb.Parallel.Visible;
                    break;

                //Q - Exactly 2 ports
                case 'Q':

                    statement = Bomb.PortNum == 2;
                    break;

                //R - Has PS/2 port
                case 'R':

                    statement = Bomb.Ps.Visible;
                    break;

                //S - Sum of digits in serial number > 10
                case 'S':

                    statement = Bomb.DigitSum > 10;
                    break;

                //T - Has MSA indicator
                case 'T':

                    statement = Bomb.Msa.Visible;
                    break;

                //U - Exactly 1 battery holder
                case 'U':

                    statement = Bomb.BatteryHolder == 1;
                    break;

                //V - Serial number contains vowels
                case 'V':

                    statement = Bomb.HasVowel;
                    break;

                //W - No indicators
                case 'W':

                    statement = Bomb.IndicatorNum == 0;
                    break;

                //X - Exactly 1 indicator
                case 'X':

                    statement = Bomb.IndicatorNum == 1;
                    break;

                //Y - More than 5 ports
                case 'Y':

                    statement = Bomb.PortNum > 5;
                    break;
                    
                //Z - Less than 2 ports
                case 'Z':

                    statement = Bomb.PortNum < 2;
                    break;
            }
            return statement;
        }

        private bool UpdateStatement(bool statement, bool notStatement)
        {
            if (notStatement)
            {
                statement = !statement;
            }

            return statement;
        }

        /// <summary>
        /// Evauluatees a boolen operation
        /// </summary>
        /// <param name="bool1">the first boolean</param>
        /// <param name="bool2">the second boolean</param>
        /// <param name="operation">the operation used to evaulate the statement</param>
        /// <returns>the evauluated statement</returns>

        private bool EvaluateStatement(bool bool1, bool bool2, String operation)
        {
            switch (operation)
            {
                //AND
                case "∧":
                    return bool1 && bool2;

                //OR
                case "∨":
                    return bool1 || bool2;

                //XOR
                case "⊻":
                    return bool1 ^ bool2;

                //NAND
                case "|":
                    return !(bool1 && bool2);

                //NOR
                case "↓":
                    return !(bool1 || bool2);

                //XNOR
                case "↔":
                    return !(bool1 ^ bool2);

                //NOT 1 OR 2
                case "→":
                    return !bool1 || bool2;

                //NOT 2 OR 1
                default:
                    return bool1 || !bool2;
            }

        }
    }
}
