using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace KTANE_Solver
{
    class Button : Module
    {
        public Button(Bomb bomb, StreamWriter logFileWriter) : base(bomb, logFileWriter, "Button")
        { 
        }

        public void Solve(Color color, String word)
        {
            PrintDebugLine($"{color} {word}\n");

            switch (color)
            {
                case Color.Red:

                    if (word == "Detonate")
                    {
                        DentonateAnswer();
                    }

                    else if (word == "Hold")
                    {
                        PressAnswer();
                    }

                    else
                    {
                        CheckAnswer();
                    }
                    break;
                case Color.Blue:
                    if (word == "Abort")
                    {
                        HoldAnswer();
                    }

                    else if (word == "Detonate")
                    {
                        DentonateAnswer();
                    }

                    else
                    {
                        CheckAnswer();
                    }
                    break;
                case Color.White:

                    if (word == "Detonate")
                    {
                        DentonateAnswer();
                    }

                    else if (Bomb.Car.Lit)
                    {
                        HoldAnswer();
                    }

                    else
                    {
                        CheckAnswer();
                    }
                    break;


                default:

                    if (word == "Detonate")
                    {
                        DentonateAnswer();
                    }

                    else
                    {
                        CheckAnswer();
                    }
                    break;
            }
        }

        private void CheckAnswer()
        {
            if (Bomb.Battery >= 3 && Bomb.Frk.Lit)
            {
                PressAnswer();
            }

            else
            {
                HoldAnswer();
            }
        }

        private void DentonateAnswer()
        {
            if (Bomb.Battery >= 2)
            {
                PressAnswer();
            }

            else
            {
                HoldAnswer();
            }
        }

        private void PressAnswer()
        {
            PrintDebugLine("Answer: Press\n");
            ShowAnswer("Press");
        }

        private void HoldAnswer()
        {
            PrintDebugLine("Answer: Hold\n");
            ShowAnswer("Hold Button\nBlue: 4\nYellow: 5\nElse: 1");
        }

        public enum Color
        { 
            Red,
            Blue,
            White,
            Yellow
        }
    }
}
