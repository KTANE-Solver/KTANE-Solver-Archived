using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
namespace KTANE_Solver
{
    public class Screw : Module
    {
        Color topLeft;
        Color topMid;
        Color topRight;
        Color bottomLeft;
        Color bottomMid;
        Color bottomRight;

        Color screwInitialLocation;

        List<Color> screwLocationAnswers;
        List<Color> colorLocations;

        List<string> letterAnswers;

        public Screw(Bomb bomb, StreamWriter logFileWriter, Color topLeft, Color topMid, Color topRight, Color bottomLeft, Color bottomMid, Color bottomRight, Color screwLocation) : base(bomb, logFileWriter, "Screw")
        {
            this.topLeft = topLeft;
            this.topMid = topMid;
            this.topRight = topRight;
            this.bottomLeft = bottomLeft;
            this.bottomMid = bottomMid;
            this.bottomRight = bottomRight;
            this.screwInitialLocation = screwLocation;
            colorLocations = new List<Color> { topLeft, topMid, topRight, bottomLeft, bottomMid, bottomRight };
            screwLocationAnswers = new List<Color>();
            letterAnswers = new List<string>();
        }

        public void Solve(int stage)
        {
            ShowAnswer($"{screwLocationAnswers[stage]} in {FindLetterAnswers(stage)}", true);
        }

        public void FindScrewLocations()
        {
            Color stage1 = ConvertNumToScrewLocation(Bomb.Battery + Bomb.UnlitIndicatorsList.Count);
            Color stage2 = ConvertNumToScrewLocation(Bomb.LastDigit + Bomb.LitIndicatorsList.Count);
            Color stage3 = ConvertNumToScrewLocation(Bomb.PortNum + Bomb.BatteryHolder);

            if (stage1 == colorLocations[0])
            {
                stage1 = colorLocations[1];
            }

            stage2 = OverrideScrewLocation(stage2, stage1);

            stage3 = OverrideScrewLocation(stage3, stage2);

            screwLocationAnswers.AddRange(new Color[]{stage1, stage2, stage3});
        }

        public string FindLetterAnswers(int stage)
        {
            bool letterAinFirstThirdPos = MessageBox.Show("Is the letter A in the first or third position?", "", MessageBoxButtons.YesNo) == DialogResult.Yes;
            bool letterCinSecondFourthPos = MessageBox.Show("Is the letter C in the second or fourth position?", "", MessageBoxButtons.YesNo) == DialogResult.Yes;

            Color color = colorLocations[stage];

            int colorIndex = colorLocations.IndexOf(color);

            if (color == Color.Red || color == Color.Yellow || color == Color.Green)
            {
                if (colorIndex < 3)
                {
                    if (colorIndex % 3 + 1 == Bomb.BatteryHolder)
                    {
                        return "Fourth Position";
                    }

                    else if (letterAinFirstThirdPos)
                    {
                        return "C";
                    }

                    else if (Bomb.Clr.Visible || Bomb.Frk.Visible || Bomb.Trn.Visible)
                    {
                        return "Third Position";
                    }

                    else if (colorLocations.IndexOf(Color.Blue) % 3 == colorIndex % 3)
                    {
                        return "First Position";
                    }

                    else
                    {
                        return "B";
                    }
                }

                else
                {
                    if (colorIndex % 3 + 1 == Bomb.UniquePortNum)
                    {
                        return "Second Position";
                    }

                    else if (colorIndex % 3 + 1 == Bomb.Battery)
                    {
                        return "D";
                    }

                    else if (colorIndex % 3 != colorLocations.IndexOf(Color.White) % 3)
                    {
                        return "A";
                    }

                    else if ((colorLocations[colorIndex - 1] == Color.Magenta && colorIndex - 1 > 2) || (colorIndex + 1 < 5 && colorLocations[colorIndex + 1] == Color.Magenta))
                    {
                        return "C";
                    }

                    else
                    {
                        return "First Position";
                    }
                }
            }

            else
            {
                if (colorIndex < 3)
                {
                    if (colorIndex % 3 + 1 == Bomb.UniquePortNum)
                    {
                        return "D";
                    }

                    else if (letterCinSecondFourthPos)
                    {
                        return "B";
                    }

                    else if (Bomb.Car.Visible || Bomb.Frk.Visible || Bomb.Snd.Visible)
                    {
                        return "Fourth Position";
                    }

                    else if (colorIndex % 3 == colorLocations.IndexOf(Color.Red) % 3)
                    {
                        return "Second Position";
                    }

                    else
                    {
                        return "A";
                    }
                }

                else
                {
                    if (colorIndex % 3 + 1 == Bomb.PortPlateNum)
                    {
                        return "Second Position";
                    }

                    else if (colorIndex % 3 + 1 == Bomb.IndicatorNum)
                    {
                        return "A";
                    }

                    else if ((colorLocations[colorIndex - 1] == Color.Yellow && colorIndex - 1 > 2) || (colorIndex + 1 < 5 && colorLocations[colorIndex + 1] == Color.Yellow))
                    {
                        return "C";
                    }

                    else if (colorIndex % 3 != colorLocations.IndexOf(Color.Green) % 3)
                    {
                        return "D";
                    }

                    else
                    {
                        return "Fourth Position";
                    }
                }
            }            
        }

        public Color OverrideScrewLocation(Color currentStageAnswer, Color previousStageAnswer)
        {
            if (currentStageAnswer == previousStageAnswer)
            {
                int index = colorLocations.IndexOf(currentStageAnswer) + 1;

                index %= 7;

                if (index == 0)
                {
                    index = 1;
                }

                return colorLocations[index];
            }

            return currentStageAnswer;
        }

        public Color ConvertNumToScrewLocation(int num)
        {
            num %= 7;

            if (num == 0)
            {
                num++;
            }

            switch (num)
            {
                case 1:
                    return topLeft;

                case 2:
                    return topMid;

                case 3:
                    return topRight;

                case 4:
                    return bottomLeft;

                case 5:
                    return bottomMid;

            }

            return bottomRight;
        }



        public enum Color
        { 
            White,
            Magenta,
            Green,
            Blue,
            Red,
            Yellow
        }
    }
}
