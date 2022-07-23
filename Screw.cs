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

        List<Color> screwLocationAnswers;
        List<Color> colorLocations;

        public Screw(Bomb bomb, StreamWriter logFileWriter, Color topLeft, Color topMid, Color topRight, Color bottomLeft, Color bottomMid, Color bottomRight) : base(bomb, logFileWriter, "Screw")
        {
            this.topLeft = topLeft;
            this.topMid = topMid;
            this.topRight = topRight;
            this.bottomLeft = bottomLeft;
            this.bottomMid = bottomMid;
            this.bottomRight = bottomRight;
            colorLocations = new List<Color> { topLeft, topMid, topRight, bottomLeft, bottomMid, bottomRight };
            screwLocationAnswers = new List<Color>();
        }

        public string SolveDebug(int stage)
        {
            return $"{screwLocationAnswers[stage - 1]} and {FindLetterAnswers(stage - 1)}"; 
        }

        public void Solve(int stage)
        {
            ShowAnswer(SolveDebug(stage), true);
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
            Color color = screwLocationAnswers[stage];

            int colorIndex = colorLocations.IndexOf(color);

            if (color == Color.Red || color == Color.Yellow || color == Color.Green)
            {
                if (colorIndex < 3)
                {
                    if (colorIndex % 3 + 1 == Bomb.BatteryHolder)
                    {
                        return "4th position";
                    }

                    else if (MessageBox.Show("Is the letter A in the 1st or 3rd position?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        return "C";
                    }

                    else if (Bomb.Clr.Visible || Bomb.Frk.Visible || Bomb.Trn.Visible)
                    {
                        return "3rd position";
                    }

                    else if (colorLocations.IndexOf(Color.Blue) % 3 == colorIndex % 3)
                    {
                        return "1st position";
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
                        return "2nd position";
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
                        return "1st position";
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

                    else if (MessageBox.Show("Is the letter C in the 2nd or 4th position?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        return "B";
                    }

                    else if (Bomb.Car.Visible || Bomb.Frk.Visible || Bomb.Snd.Visible)
                    {
                        return "4th position";
                    }

                    else if (colorIndex / 3 == colorLocations.IndexOf(Color.Red) / 3)
                    {
                        return "2nd position";
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
                        return "2nd position";
                    }

                    else if (colorIndex % 3 + 1 == Bomb.IndicatorNum)
                    {
                        return "A";
                    }

                    else if ((colorIndex - 1 > 2 && colorLocations[colorIndex - 1] == Color.Yellow) || (colorIndex + 1 < 6 && colorLocations[colorIndex + 1] == Color.Yellow))
                    {
                        return "C";
                    }

                    else if (colorIndex % 3 != colorLocations.IndexOf(Color.Green) % 3)
                    {
                        return "D";
                    }

                    else
                    {
                        return "4th position";
                    }
                }
            }            
        }

        public Color OverrideScrewLocation(Color currentStageAnswer, Color previousStageAnswer)
        {
            if (currentStageAnswer == previousStageAnswer)
            {
                int index = colorLocations.IndexOf(currentStageAnswer) + 1;

                index %= 6;

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
            num %= 6;

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
