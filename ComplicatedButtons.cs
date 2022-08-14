using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
namespace KTANE_Solver
{
    public class ComplicatedButtons : Module
    {
        Button[] buttonArr;
        public ComplicatedButtons(Bomb bomb, StreamWriter logFileWriter, List<Button> buttonList) : base(bomb, logFileWriter, "Complicated Buttons")
        {
            for (int i = 0; i < 3; i++)
            {
                buttonArr[i] = buttonList[i];
            }
        }

        private void FindButtonResult(Button b)
        { 
                if (b.color == Color.Blue)
                {
                    if (Array.IndexOf(buttonArr, b) == 1 && b.name == "Press")
                    {
                        b.result = 'S';
                    }

                    else if (Array.IndexOf(buttonArr, b) == 1)
                    {
                        b.result = 'S';
                    }

                    else if (b.name == "Press")
                    {
                        b.result = 'D';
                    }

                    else
                    {
                        b.result = 'P';
                    }
                }

                else if (b.color == Color.Red)
                {
                    if (Array.IndexOf(buttonArr, b) == 1 && b.name == "Press")
                    {
                        b.result = 'B';
                    }

                    else if (Array.IndexOf(buttonArr, b) == 1)
                    {
                        b.result = 'B';
                    }

                    else if (b.name == "Press")
                    {
                        b.result = 'P';
                    }

                    else
                    {
                        b.result = 'R';
                    }
                }

                else
                {
                    if (Array.IndexOf(buttonArr, b) == 1 && b.name == "Press")
                    {
                        b.result = 'D';
                    }

                    else if (Array.IndexOf(buttonArr, b) == 1)
                    {
                        b.result = 'R';
                    }

                    else if (b.name == "Press")
                    {
                        b.result = 'S';
                    }

                    else
                    {
                        b.result = 'R';
                    }
                }
            
        }

        private int[] PressOrder()
        {
            switch (Bomb.Battery)
            {
                case 0:
                case 1:
                    if (buttonArr[0].name == "Press")
                    { 
                        return new int[] { 1, 2, 3};
                    }

                    if (buttonArr[0].name == "Hold")
                    {
                        return new int[] { 2, 1, 3 };
                    }

                    return new int[] { 3, 1, 2 };

                case 2:
                case 3:
                    if (buttonArr[0].name == "Press")
                    {
                        return new int[] { 2, 3, 1 };
                    }

                    if (buttonArr[0].name == "Hold")
                    {
                        return new int[] { 3, 2, 1 };
                    }

                    return new int[] { 1, 2, 3 };

                case 4:
                case 5:
                    if (buttonArr[0].name == "Press")
                    {
                        return new int[] { 3, 1, 2 };
                    }

                    if (buttonArr[0].name == "Hold")
                    {
                        return new int[] { 1, 3, 2 };
                    }

                    return new int[] { 2, 1, 3 };

                default:
                    if (buttonArr[0].name == "Press")
                    {
                        return new int[] { 1, 2, 3 };
                    }

                    if (buttonArr[0].name == "Hold")
                    {
                        return new int[] { 2, 3, 1 };
                    }

                    return new int[] { 3, 1, 2 };
            }
        }

        public void Solve()
        {
            foreach (Button b in buttonArr)
            {
                FindButtonResult(b);
                b.SetPressValue(Bomb);
            }

            int[] pressOrder = PressOrder();

            string answer = "";
            foreach (int order in pressOrder)
            {
                Button b = buttonArr[order - 1];

                if (b.press)
                {
                    answer += order;
                }
            }

            if (answer == "")
            {
                answer = "2";
            }

            ShowAnswer(answer, true);
        }

        public class Button
        {
            public Color color;
            public string name;
            public char result;
            public bool press;

            public Button(Color color, string name)
            {
                this.color = color;
                this.name = name;
            }

            public void SetPressValue(Bomb bomb)
            {
                switch (result)
                {
                    case 'P':
                        press = true;

                        break;

                    case 'D':
                        press = false;
                        break;

                    case 'R':
                        string distinctSerialNum = bomb.SerialNumber.Distinct().ToString();
                        press = distinctSerialNum.Length < bomb.SerialNumber.Length;
                        break;

                    case 'S':
                        press = bomb.Serial.Visible;
                        break;

                    default:
                        press = bomb.Battery >= 2;
                        break;

                }
            }
        }
    }
}
