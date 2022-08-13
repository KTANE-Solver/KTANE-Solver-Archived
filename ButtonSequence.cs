using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;

namespace KTANE_Solver
{
    public class ButtonSequence : Module
    {
        int redNum;
        int yellowNum;
        int blueNum;
        int whiteNum;

        Dictionary<Color, int> colorDict;

        public enum Shape
        {
            Square,
            Hexagon,
            Circle
        }

        public ButtonSequence(Bomb bomb, StreamWriter logFileWriter) : base(bomb, logFileWriter, "Button Sequence")
        {
            colorDict = new Dictionary<Color, int>
            {
                { Color.Red, 0 },
                { Color.Yellow, 0 },
                { Color.Blue, 0 },
                { Color.White, 0 }
            };
        }


        public string Solve(Button button)
        {
            string answer = AnswerButton(button);
            if (answer == "Hold")
            {
                return "Hold:\nBlue: 2\nWhite: 7\nYellow: 3\nMagenta: 4\nOther: 0";

            }

            return answer;
        }





        private string AnswerButton(Button button)
        {
            //increment value
            colorDict[button.color]++;

            if (button.color == Color.Red)
            {
                return RedButton(button);
            }

            if (button.color == Color.Blue)
            {
                return BlueButton(button);
            }

            if (button.color == Color.Yellow)
            {
                return YellowButton(button);
            }

            return WhiteButton(button);

        }

        private string RedButton(Button button)
        {
            switch (colorDict[button.color])
            {
                case 1:
                case 6:
                    return InteractButton("Abort", Shape.Square, button);

                case 2:
                case 7:
                    return InteractButton("Detonate", Shape.Hexagon, button);

                case 3:
                case 8:
                    return InteractButton("Hold", Shape.Circle, button);

                case 4:
                case 9:
                    return InteractButton("Abort", Shape.Circle, button);

                default:
                    return InteractButton("Press", Shape.Square, button);
            }
        }

        private string BlueButton(Button button)
        {
            switch (colorDict[button.color])
            {
                case 1:
                case 6:
                    return InteractButton("Hold", Shape.Circle, button);

                case 2:
                case 7:
                    return InteractButton("Abort", Shape.Square, button);

                case 3:
                case 8:
                    return InteractButton("Detonate", Shape.Hexagon, button);

                case 4:
                case 9:
                    return InteractButton("Press", Shape.Square, button);

                default:
                    return InteractButton("Press", Shape.Hexagon, button);
            }
        }

        private string YellowButton(Button button)
        {
            switch (colorDict[button.color])
            {
                case 1:
                case 6:
                    return InteractButton("Detonate", Shape.Circle, button);

                case 2:
                case 7:
                    return InteractButton("Hold", Shape.Hexagon, button);

                case 3:
                case 8:
                    return InteractButton("Abort", Shape.Square, button);

                case 4:
                case 9:
                    return InteractButton("Press", Shape.Circle, button);

                default:
                    return InteractButton("Hold", Shape.Hexagon, button);
            }
        }

        private string WhiteButton(Button button)
        {
            switch (colorDict[button.color])
            {
                case 1:
                case 6:
                    return InteractButton("Hold", Shape.Hexagon, button);

                case 2:
                case 7:
                    return InteractButton("Detonate", Shape.Square, button);

                case 3:
                case 8:
                    return InteractButton("Press", Shape.Hexagon, button);

                case 4:
                case 9:
                    return InteractButton("Abort", Shape.Circle, button);

                default:
                    return InteractButton("Detonate", Shape.Square, button);
            }
        }

        private string InteractButton(string correctName, Shape correctShape, Button button)
        {
            int num = 0;

            if (correctName == button.name)
            {
                num++;
            }

            if (correctShape == button.shape)
            {
                num++;
            }

            return num == 0 ? "Skip" : num == 1 ? "Tap" : "Hold";
        }

        public class Button
        {
            public string name;
            public Color color;
            public Shape shape;

            public Button(string name, Color color, Shape shape)
            {
                this.name = name;
                this.color = color;
                this.shape = shape;
            }

        }
    }
}
