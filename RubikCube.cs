using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace KTANE_Solver
{
    class RubikCube : Module
    {
        //all the possible colors of each face
        public enum Face
        {
            YELLOW,
            BLUE,
            RED,
            GREEN,
            ORANGE,
            WHITE,
        }

        //all the six faces
        public Face upFace;
        public Face leftFace;
        public Face frontFace;
        public Face rightFace;
        public Face bottomFace;

        List<String> directions = new List<string>();

        public RubikCube(Face upFace, Face leftFace, Face frontFace, Face rightFace, Face bottomFace, Bomb bomb, StreamWriter logFileWriter) : base(bomb, logFileWriter)
        {
            this.upFace = upFace;
            this.leftFace = leftFace;
            this.frontFace = frontFace;
            this.rightFace = rightFace;
            this.bottomFace = bottomFace;

            directions = new List<string>();

        }

        /// <summary>
        /// Getting the moves required to solve the module
        /// </summary>
        public void Solve()
        {
            //figure out if we're getting both moves

            //If the R face is red, green or blue, take both moves for each serial number character in order.
            bool bothMoves = rightFace == Face.RED || rightFace == Face.GREEN || rightFace == Face.BLUE;

            //used just in case moves need to be sperated
            List<String> directions2 = new List<string>();

            for (int i = 0; i < Bomb.SerialNumber.Length; i++)
            {
                //skip bottom face's num
                if (i == (int)bottomFace)
                {
                    continue;
                }

                //get the starting character
                char startingChar = Bomb.SerialNumber[i];

                //find the starting row
                int startingRow = GetStartingRow(startingChar);

                //find which face belongs to the starting row
                Face startingFace = GetStartingFace(startingChar);

                //find the row to take the moves from

                int endingRow = (startingRow + (int)startingFace + 1) % 12;

                //take both moves, 
                if (bothMoves)
                {
                    switch (endingRow)
                    {
                        case 0:
                            directions.Add("L'");
                            directions.Add("F'");
                            break;
                        case 1:
                            directions.Add("D'");
                            directions.Add("U'");
                            break;
                        case 2:
                            directions.Add("U");
                            directions.Add("B'");
                            break;
                        case 3:
                            directions.Add("F");
                            directions.Add("B");
                            break;
                        case 4:
                            directions.Add("L");
                            directions.Add("D");
                            break;
                        case 5:
                            directions.Add("R'");
                            directions.Add("U");
                            break;
                        case 6:
                            directions.Add("U'");
                            directions.Add("F");
                            break;
                        case 7:
                            directions.Add("B'");
                            directions.Add("L'");
                            break;
                        case 8:
                            directions.Add("B");
                            directions.Add("R");
                            break;
                        case 9:
                            directions.Add("D");
                            directions.Add("L");
                            break;
                        case 10:
                            directions.Add("R");
                            directions.Add("D'");
                            break;
                        case 11:
                            directions.Add("F'");
                            directions.Add("R'");
                            break;

                    }
                }

                //or take seprate each moves into their own directions and combine later
                else
                {
                    switch (endingRow)
                    {
                        case 0:
                            directions.Add("L'");
                            directions2.Add("F'");
                            break;
                        case 1:
                            directions.Add("D'");
                            directions2.Add("U'");
                            break;
                        case 2:
                            directions.Add("U");
                            directions2.Add("B'");
                            break;
                        case 3:
                            directions.Add("F");
                            directions2.Add("B");
                            break;
                        case 4:
                            directions.Add("L");
                            directions2.Add("D");
                            break;
                        case 5:
                            directions.Add("R'");
                            directions2.Add("U");
                            break;
                        case 6:
                            directions.Add("U'");
                            directions2.Add("F");
                            break;
                        case 7:
                            directions.Add("B'");
                            directions2.Add("L'");
                            break;
                        case 8:
                            directions.Add("B");
                            directions2.Add("R");
                            break;
                        case 9:
                            directions.Add("D");
                            directions2.Add("L");
                            break;
                        case 10:
                            directions.Add("R");
                            directions2.Add("D'");
                            break;
                        case 11:
                            directions.Add("F'");
                            directions2.Add("R'");
                            break;

                    }
                }
            }

            //if moves were taken seperatly, then combine them now
            if (!bothMoves)
            {
                System.Diagnostics.Debug.Write("Direction 1 List: ");

                foreach(String str in directions)
                {
                    System.Diagnostics.Debug.Write(str + " ");
                }

                System.Diagnostics.Debug.Write("\nDirection 2 List: ");

                foreach (String str in directions2)
                {
                    System.Diagnostics.Debug.Write(str + " ");
                }

                directions.AddRange(directions2);
            }

            //If the R face is red or yellow, change the first five moves to their opposites.
            if (rightFace == Face.RED || rightFace == Face.YELLOW)
            {
                for (int i = 0; i < 5; i++)
                {
                    directions[i] = GetOppositeMove(directions[i]);
                }
            }

            //If the R face is green or white, reverse the order of all the moves.
            else if (rightFace == Face.GREEN || rightFace == Face.WHITE)
            {
                directions.Reverse();
            }

            //updating the directions so unnessary moves aren't made
            for (int i = directions.Count - 1; i > 0; i--)
            {
                if (MovesAreOpposite(directions[i], directions[i - 1]))
                {
                    directions.RemoveAt(i);
                    directions.RemoveAt(i - 1);
                    i--;
                }
            }

            String answer = "";

            foreach (String str in directions)
            {
                answer += str + ", ";
            }

            answer = answer.Substring(0, answer.Length - 2);

            MessageBox.Show(answer, "Rubik's Cube Answer", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Tells if two moves are the opposite of each other
        /// </summary>
        /// <returns></returns>
        private bool MovesAreOpposite(String move1, String move2)
        {
            if (move1.Length == move2.Length)
            {
                return false;
            }
            //return if move1 is the same as move2 with a '
            if (move1.Length == 2)
            {
                return move2 == "" + move1[0];
            }

            //return if move1 is the same as move2 without the '
            return move1 == "" + move2[0];

        }

        private String GetOppositeMove(String move)
        {
            if (move.Length == 2)
            {
                return "" + move[0];
            }

            return move + "'";
        }


        public int GetStartingRow(char character)
        {
            switch (character)
            {
                case '0':
                case '1':
                case '2':
                    return 0;

                case '3':
                case '4':
                case '5':
                    return 1;

                case '6':
                case '7':
                case '8':
                    return 2;

                case '9':
                case 'A':
                case 'B':
                    return 3;

                case 'C':
                case 'D':
                case 'E':
                    return 4;

                case 'F':
                case 'G':
                case 'H':
                    return 5;

                case 'I':
                case 'J':
                case 'K':
                    return 6;

                case 'L':
                case 'M':
                case 'N':
                    return 7;

                case 'O':
                case 'P':
                case 'Q':
                    return 8;

                case 'R':
                case 'S':
                case 'T':
                    return 9;

                case 'U':
                case 'V':
                case 'W':
                    return 10;

                default:
                    return 11;
            }
        }

        public Face GetStartingFace(char character)
        {
            switch (character)
            {
                case '0':
                case '3':
                case '6':
                case '9':
                case 'C':
                case 'F':
                case 'I':
                case 'L':
                case 'O':
                case 'R':
                case 'U':
                case 'X':
                    return upFace;

                case '1':
                case '4':
                case '7':
                case 'A':
                case 'D':
                case 'G':
                case 'J':
                case 'M':
                case 'P':
                case 'S':
                case 'V':
                case 'Y':
                    return leftFace;

                default:
                    return frontFace;
            }



        }
    }
}
