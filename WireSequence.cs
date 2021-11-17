using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace KTANE_Solver
{
    public class WireSequence : Module
    {
        private int redColor;
        private int blueColor;
        private int blackColor;
        public WireSequence(Bomb bomb, StreamWriter logFileWriter) : base(bomb, logFileWriter)
        {
            redColor = 0;
            blueColor = 0;
            blackColor = 0;
        }

        public String Solve(int wireNum, String color, char letter)
        {
            string answer;
            int colorNum;

            PrintDebugLine($"{color} Wire: {wireNum} to {letter}\n");

            switch (color)
            {
                case "Red":
                    
                    redColor++;
                    
                    colorNum = redColor;

                    if (letter == 'A')
                    {
                        if (redColor == 3 || redColor == 4 || redColor == 6 || redColor == 7 || redColor == 8)
                        {
                            answer = "Cut";
                        }

                        else
                        { 
                            answer = "Don't Cut";
                        }
                    }

                    else if (letter == 'B')
                    {
                        if (redColor == 2 || redColor == 5 || redColor == 7 || redColor == 8 || redColor == 9)
                        {
                            answer = "Cut";
                        }

                        else
                        {
                            answer = "Don't Cut";
                        }
                    }

                    else
                    {
                        if (redColor == 1 || redColor == 4 || redColor == 6 || redColor == 7)
                        {
                            answer = "Cut";
                        }

                        else
                        {
                            answer = "Don't Cut";
                        }
                    }

                    break;

                case "Blue":

                    blueColor++;

                    colorNum = blueColor;

                    if (letter == 'A')
                    {
                        if (blueColor == 2 || blueColor == 4 || blueColor == 8 || blueColor == 9)
                        {
                            answer = "Cut";
                        }

                        else
                        {
                            answer = "Don't Cut";
                        }
                    }

                    else if (letter == 'B')
                    {
                        if (blueColor == 1 || blueColor == 3 || blueColor == 5 || blueColor == 6)
                        {
                            answer = "Cut";
                        }

                        else
                        {
                            answer = "Don't Cut";
                        }
                    }

                    else
                    {
                        if (blueColor == 2 || blueColor == 7 || blueColor == 8 || blueColor == 6)
                        {
                            answer = "Cut";
                        }

                        else
                        {
                            answer = "Don't Cut";;
                        }
                    }

                    break;

                default:

                    blackColor++;

                    colorNum = blackColor;

                    if (letter == 'A')
                    {
                        if (blackColor == 1 || blackColor == 2 || blackColor == 4 || blackColor == 7)
                        {
                            answer = "Cut";
                        }

                        else
                        {
                            answer = "Don't Cut";
                        }
                    }

                    else if (letter == 'B')
                    {
                        if (blackColor == 1 || blackColor == 3 || blackColor == 5 || blackColor == 6 || blackColor == 7)
                        {
                            answer = "Cut";
                        }

                        else
                        {
                            answer = "Don't Cut";
                        }
                    }

                    else
                    {
                        if (blackColor == 1 || blackColor == 2 || blackColor == 4 || blackColor == 6 || blackColor == 8 || blackColor == 9)
                        {
                            answer = "Cut";
                        }

                        else
                        {
                            answer = "Don't Cut";
                        }
                    }

                    break;
            }

            PrintDebugLine($"{GetPlace(colorNum)} instance of a {color} wire\n");

            if (answer == "Cut")
            {
                PrintDebugLine($"Cut wire {wireNum}\n");
            }

            else
            { 
                PrintDebugLine($"Don't cut wire {wireNum}\n");
            }

            return answer;
        }

        private string GetPlace(int num)
        {
            if (num == 1)
                return "1st";

            if (num == 2)
                return "2nd";

            if (num == 3)
                return "3rd";

            return $"{num}th";
        }
    }
}
