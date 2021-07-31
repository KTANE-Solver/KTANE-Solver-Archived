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

        public String Solve(String color, char letter)
        {
            switch (color)
            {
                case "Red":
                    redColor++;

                    if (letter == 'A')
                    {
                        if (redColor == 3 || redColor == 4 || redColor == 6 || redColor == 7 || redColor == 8)
                        {
                            return "Cut";
                        }

                        else
                        { 
                            return "Don't Cut";
                        }
                    }

                    else if (letter == 'B')
                    {
                        if (redColor == 2 || redColor == 5 || redColor == 7 || redColor == 8 || redColor == 9)
                        {
                            return "Cut";
                        }

                        else
                        {
                            return "Don't Cut";
                        }
                    }

                    else
                    {
                        if (redColor == 1 || redColor == 4 || redColor == 6 || redColor == 7)
                        {
                            return "Cut";
                        }

                        else
                        {
                            return "Don't Cut";
                        }
                    }

                case "Blue":
                    blueColor++;
                    if (letter == 'A')
                    {
                        if (blueColor == 2 || blueColor == 4 || blueColor == 8 || blueColor == 9)
                        {
                            return "Cut";
                        }

                        else
                        {
                            return "Don't Cut";
                        }
                    }

                    else if (letter == 'B')
                    {
                        if (blueColor == 1 || blueColor == 3 || blueColor == 5 || blueColor == 6)
                        {
                            return "Cut";
                        }

                        else
                        {
                            return "Don't Cut";
                        }
                    }

                    else
                    {
                        if (blueColor == 2 || blueColor == 7 || blueColor == 8 || blueColor == 6)
                        {
                            return "Cut";
                        }

                        else
                        {
                            return "Don't Cut";;
                        }
                    }

                default:
                    blackColor++;
                    if (letter == 'A')
                    {
                        if (blackColor == 1 || blackColor == 2 || blackColor == 4 || blackColor == 7)
                        {
                            return "Cut";
                        }

                        else
                        {
                            return "Don't Cut";
                        }
                    }

                    else if (letter == 'B')
                    {
                        if (blackColor == 1 || blackColor == 3 || blackColor == 5 || blackColor == 6 || blackColor == 7)
                        {
                            return "Cut";
                        }

                        else
                        {
                            return "Don't Cut";
                        }
                    }

                    else
                    {
                        if (blackColor == 1 || blackColor == 2 || blackColor == 4 || blackColor == 6 || blackColor == 8 || blackColor == 9)
                        {
                            return "Cut";
                        }

                        else
                        {
                            return "Don't Cut";
                        }
                    }
            }
        }
    }
}
