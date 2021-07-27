using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace KTANE_Solver
{
    class WireSequence : Module
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

        public void Solve(String color, char letter)
        {
            switch (color)
            {
                case "Red":
                    redColor++;

                    if (letter == 'A')
                    {
                        if (redColor == 3 || redColor == 4 || redColor == 6 || redColor == 7 || redColor == 8)
                        {
                            ShowAnswer("Cut", "Wire Sequence Answer");
                        }

                        else
                        { 
                            ShowAnswer("Don't Cut", "Wire Sequence Answer");
                        }
                    }

                    else if (letter == 'B')
                    {
                        if (redColor == 2 || redColor == 5 || redColor == 7 || redColor == 8 || redColor == 9)
                        {
                            ShowAnswer("Cut", "Wire Sequence Answer");
                        }

                        else
                        {
                            ShowAnswer("Don't Cut", "Wire Sequence Answer");
                        }
                    }

                    else
                    {
                        if (redColor == 1 || redColor == 4 || redColor == 6 || redColor == 7)
                        {
                            ShowAnswer("Cut", "Wire Sequence Answer");
                        }

                        else
                        {
                            ShowAnswer("Don't Cut", "Wire Sequence Answer");
                        }
                    }

                    break;

                case "Blue":
                    blueColor++;
                    if (letter == 'A')
                    {
                        if (blueColor == 2 || blueColor == 4 || blueColor == 8 || blueColor == 9)
                        {
                            ShowAnswer("Cut", "Wire Sequence Answer");
                        }

                        else
                        {
                            ShowAnswer("Don't Cut", "Wire Sequence Answer");
                        }
                    }

                    else if (letter == 'B')
                    {
                        if (blueColor == 1 || blueColor == 3 || blueColor == 5 || blueColor == 6)
                        {
                            ShowAnswer("Cut", "Wire Sequence Answer");
                        }

                        else
                        {
                            ShowAnswer("Don't Cut", "Wire Sequence Answer");
                        }
                    }

                    else
                    {
                        if (blueColor == 2 || blueColor == 7 || blueColor == 8 || blueColor == 6)
                        {
                            ShowAnswer("Cut", "Wire Sequence Answer");
                        }

                        else
                        {
                            ShowAnswer("Don't Cut", "Wire Sequence Answer");
                        }
                    }

                    break;

                default:
                    blackColor++;
                    if (letter == 'A')
                    {
                        if (blackColor == 1 || blackColor == 2 || blackColor == 4 || blackColor == 7)
                        {
                            ShowAnswer("Cut", "Wire Sequence Answer");
                        }

                        else
                        {
                            ShowAnswer("Don't Cut", "Wire Sequence Answer");
                        }
                    }

                    else if (letter == 'B')
                    {
                        if (blackColor == 1 || blackColor == 3 || blackColor == 5 || blackColor == 6 || blackColor == 7)
                        {
                            ShowAnswer("Cut", "Wire Sequence Answer");
                        }

                        else
                        {
                            ShowAnswer("Don't Cut", "Wire Sequence Answer");
                        }
                    }

                    else
                    {
                        if (blackColor == 1 || blackColor == 2 || blackColor == 4 || blackColor == 6 || blackColor == 8 || blackColor == 9)
                        {
                            ShowAnswer("Cut", "Wire Sequence Answer");
                        }

                        else
                        {
                            ShowAnswer("Don't Cut", "Wire Sequence Answer");
                        }
                    }

                    break;
            }
        }
    }
}
