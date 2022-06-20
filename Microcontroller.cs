using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;

namespace KTANE_Solver
{
    public class Microcontroller : Module
    {
        private string whiteDotCorner;
        private string moduleType; 
        private int pinNum; 
        private int secondDigit; 
        private int lastDigit;
        public List<Pin> pinList;
        public Microcontroller(Bomb bomb, StreamWriter logFileWriter, string whiteDotCorner, string moduleType, int pinNum, int secondDigit, int lastDigit) : base(bomb, logFileWriter, "Microcontroller")
        {
            this.whiteDotCorner = whiteDotCorner;
            this.moduleType = moduleType;
            this.pinNum = pinNum;
            this.secondDigit = secondDigit;
            this.lastDigit = lastDigit;
            pinList = new List<Pin>();
        }

        public void SetUpModule()
        {
            PrintDebugLine($"Controller Type: {moduleType}");
            PrintDebugLine($"White Dot Corner: {whiteDotCorner}");
            PrintDebugLine($"Second Controller Digit: {secondDigit}");
            PrintDebugLine($"Last Controller Digit: {lastDigit}\n");

            for (int i = 1; i <= pinNum; i++)
            {
                pinList.Add(new Pin(i, moduleType, pinNum, secondDigit, lastDigit, Bomb));
            }

            foreach (Pin p in pinList)
            {
                PrintDebugLine(p.PrintPin() + "\n");
            }
        }

        public List<Color> Solve()
        {
            SetUpModule();

            List<Color> answers = new List<Color>();
            int halfPinNum = pinNum / 2;
            switch (whiteDotCorner)
            {
                case "Top Left":
                    

                    for (int i = 0; i < halfPinNum; i++)
                    {
                        answers.Add(ConvertPin(pinList[i]));
                    }

                    for (int i = pinNum - 1; i >= halfPinNum; i--)
                    {
                        answers.Add(ConvertPin(pinList[i]));
                    }

                    return answers;

                case "Top Right":
                    for (int i = halfPinNum - 1; i >= 0; i--)
                    {
                        answers.Add(ConvertPin(pinList[i]));
                    }

                    for (int i = halfPinNum; i < pinNum; i++)
                    {
                        answers.Add(ConvertPin(pinList[i]));
                    }

                    return answers;

                case "Bottom Left":
                    for (int i = halfPinNum; i < pinNum; i++)
                    { 
                        answers.Add(ConvertPin(pinList[i]));
                    }

                    for (int i = halfPinNum - 1; i >= 0; i--)
                    {
                        answers.Add(ConvertPin(pinList[i]));
                    }

                    return answers;


                default:
                    for (int i = pinNum - 1; i >= halfPinNum; i--)
                    { 
                        answers.Add(ConvertPin(pinList[i]));
                    }

                    for (int i = 0 ; i < halfPinNum; i++)
                    { 
                        answers.Add(ConvertPin(pinList[i]));
                    }

                    return answers;
            }
        }

        private Color ConvertPin(Pin p)
        {
            switch (p.color)
            {
                case Pin.Color.Yellow:
                    return Color.Yellow;

                case Pin.Color.Magenta:
                    return Color.Magenta;

                case Pin.Color.Green:
                    return Color.Green;

                case Pin.Color.Blue:
                    return Color.Blue;

                case Pin.Color.Red:
                    return Color.Red;

                default:
                    return Color.White;
            }
        }


        public class Pin
        {
            private int index;
            public string name;
            public Color color { get { return c; } }
            private Color c;

            public enum Color
            { 
                Yellow,
                Magenta,
                Green,
                Blue,
                Red,
                White
            }

            public Pin(int index, string moduleType, int pinNum, int secondDigit, int lastDigit, Bomb bomb)
            {
                this.index = index;
                SetName(moduleType, pinNum);
                SetColor(secondDigit, lastDigit, bomb);
            }

            private void SetName(string moduleType, int pinNum)
            {
                if (pinNum == 6)
                {
                    switch (moduleType)
                    {
                        case "STRK":
                            if (index == 1)
                            {
                                name = "AIN";
                            }

                            else if (index == 2)
                            {
                                name = "VCC";
                            }

                            else if (index == 3)
                            {
                                name = "RST";
                            }

                            else if (index == 4)
                            {
                                name = "DIN";
                            }

                            else if (index == 5)
                            {
                                name = "PWM";
                            }

                            else
                            {
                                name = "GND";
                            }
                            break;

                        case "LEDS":
                            if (index == 1)
                            {
                                name = "PWM";
                            }

                            else if (index == 2)
                            {
                                name = "RST";
                            }

                            else if (index == 3)
                            {
                                name = "VCC";
                            }

                            else if (index == 4)
                            {
                                name = "DIN";
                            }

                            else if (index == 5)
                            {
                                name = "AIN";
                            }

                            else
                            {
                                name = "GND";
                            }
                            break;

                        case "CNTD":
                            if (index == 1)
                            {
                                name = "GND";
                            }

                            else if (index == 2)
                            {
                                name = "AIN";
                            }

                            else if (index == 3)
                            {
                                name = "PWM";
                            }

                            else if (index == 4)
                            {
                                name = "VCC";
                            }

                            else if (index == 5)
                            {
                                name = "DIN";
                            }

                            else
                            {
                                name = "RST";
                            }
                            break;

                        case "EXPL":
                            if (index == 1)
                            {
                                name = "PWM";
                            }

                            else if (index == 2)
                            {
                                name = "VCC";
                            }

                            else if (index == 3)
                            {
                                name = "RST";
                            }

                            else if (index == 4)
                            {
                                name = "GND";
                            }

                            else if (index == 5)
                            {
                                name = "DIN";
                            }

                            else
                            {
                                name = "AIN";
                            }
                            break;
                    }
                }

                else if (pinNum == 8)
                {
                    switch (moduleType)
                    {
                        case "STRK":
                            if (index == 1)
                            {
                                name = "AIN";
                            }

                            else if (index == 2)
                            {
                                name = "PWM";
                            }

                            else if (index == 3)
                            {
                                name = "GND";
                            }

                            else if (index == 4)
                            {
                                name = "DIN";
                            }

                            else if (index == 5)
                            {
                                name = "VCC";
                            }

                            else if (index == 6)
                            {
                                name = "GND";
                            }

                            else if (index == 7)
                            {
                                name = "RST";
                            }

                            else
                            {
                                name = "GND";
                            }
                            break;

                        case "LEDS":
                            if (index == 1)
                            {
                                name = "PWM";
                            }

                            else if (index == 2)
                            {
                                name = "DIN";
                            }

                            else if (index == 3)
                            {
                                name = "VCC";
                            }

                            else if (index == 4)
                            {
                                name = "GND";
                            }

                            else if (index == 5)
                            {
                                name = "AIN";
                            }

                            else if (index == 6)
                            {
                                name = "GND";
                            }

                            else if (index == 7)
                            {
                                name = "RST";
                            }

                            else
                            {
                                name = "GND";
                            }
                            break;

                        case "CNTD":
                            if (index == 1)
                            {
                                name = "PWM";
                            }

                            else if (index == 2)
                            {
                                name = "GND";
                            }

                            else if (index == 3)
                            {
                                name = "GND";
                            }

                            else if (index == 4)
                            {
                                name = "VCC";
                            }

                            else if (index == 5)
                            {
                                name = "AIN";
                            }

                            else if (index == 6)
                            {
                                name = "GND";
                            }

                            else if (index == 7)
                            {
                                name = "DIN";
                            }

                            else
                            {
                                name = "RST";
                            }
                            break;

                        case "EXPL":
                            if (index == 1)
                            {
                                name = "AIN";
                            }

                            else if (index == 2)
                            {
                                name = "GND";
                            }

                            else if (index == 3)
                            {
                                name = "RST";
                            }

                            else if (index == 4)
                            {
                                name = "GND";
                            }

                            else if (index == 5)
                            {
                                name = "PWM";
                            }

                            else if (index == 6)
                            {
                                name = "DIN";
                            }

                            else if (index == 7)
                            {
                                name = "GND";
                            }

                            else
                            {
                                name = "VCC";
                            }
                            break;
                    }
                }

                else if (pinNum == 10)
                {
                    switch (moduleType)
                    {
                        case "STRK":
                            if (index == 1)
                            {
                                name = "GND";
                            }

                            else if (index == 2)
                            {
                                name = "GND";
                            }

                            else if (index == 3)
                            {
                                name = "GND";
                            }

                            else if (index == 4)
                            {
                                name = "GND";
                            }

                            else if (index == 5)
                            {
                                name = "AIN";
                            }

                            else if (index == 6)
                            {
                                name = "DIN";
                            }

                            else if (index == 7)
                            {
                                name = "GND";
                            }

                            else if (index == 8)
                            {
                                name = "VCC";
                            }

                            else if (index == 9)
                            {
                                name = "RST";
                            }

                            else
                            {
                                name = "PWM";
                            }
                            break;

                        case "LEDS":
                            if (index == 1)
                            {
                                name = "PWM";
                            }

                            else if (index == 2)
                            {
                                name = "AIN";
                            }

                            else if (index == 3)
                            {
                                name = "DIN";
                            }

                            else if (index == 4)
                            {
                                name = "GND";
                            }

                            else if (index == 5)
                            {
                                name = "GND";
                            }

                            else if (index == 6)
                            {
                                name = "GND";
                            }

                            else if (index == 7)
                            {
                                name = "GND";
                            }

                            else if (index == 8)
                            {
                                name = "RST";
                            }

                            else if (index == 9)
                            {
                                name = "VCC";
                            }

                            else
                            {
                                name = "GND";
                            }
                            break;

                        case "CNTD":
                            if (index == 1)
                            {
                                name = "PWM";
                            }

                            else if (index == 2)
                            {
                                name = "DIN";
                            }

                            else if (index == 3)
                            {
                                name = "AIN";
                            }

                            else if (index == 4)
                            {
                                name = "GND";
                            }

                            else if (index == 5)
                            {
                                name = "GND";
                            }

                            else if (index == 6)
                            {
                                name = "VCC";
                            }

                            else if (index == 7)
                            {
                                name = "GND";
                            }

                            else if (index == 8)
                            {
                                name = "GND";
                            }

                            else if (index == 9)
                            {
                                name = "RST";
                            }

                            else
                            {
                                name = "GND";
                            }
                            break;

                        case "EXPL":
                            if (index == 1)
                            {
                                name = "RST";
                            }

                            else if (index == 2)
                            {
                                name = "DIN";
                            }

                            else if (index == 3)
                            {
                                name = "VCC";
                            }

                            else if (index == 4)
                            {
                                name = "GND";
                            }

                            else if (index == 5)
                            {
                                name = "GND";
                            }

                            else if (index == 6)
                            {
                                name = "GND";
                            }

                            else if (index == 7)
                            {
                                name = "AIN";
                            }

                            else if (index == 8)
                            {
                                name = "GND";
                            }

                            else if (index == 9)
                            {
                                name = "PWM";
                            }

                            else
                            {
                                name = "GND";
                            }
                            break;
                    }
                }
            }

            private void SetColor(int secondDigit, int lastDigit, Bomb bomb)
            {
                //GND is always white
                if (name == "GND")
                {
                    c = Color.White;
                }

                else
                {
                    //If the last digit of the controller's serial number is 1 or 4
                    if (lastDigit == 1 || lastDigit == 4)
                    {
                        switch (name)
                        {
                            case "VCC":
                                c = Color.Yellow;
                                break;

                            case "AIN":
                                c = Color.Magenta;
                                break;

                            case "DIN":
                                c = Color.Green;
                                break;

                            case "PWM":
                                c = Color.Blue;
                                break;

                            case "RST":
                                c = Color.Red;
                                break;
                        }
                    }

                    //Otherwise, if there is a lit indicator "SIG" or a RJ-45 port
                    else if (bomb.Sig.Lit || bomb.Rj.Visible)
                    {
                        switch (name)
                        {
                            case "VCC":
                                c = Color.Yellow;
                                break;

                            case "AIN":
                                c = Color.Red;
                                break;

                            case "DIN":
                                c = Color.Magenta;
                                break;

                            case "PWM":
                                c = Color.Green;
                                break;

                            case "RST":
                                c = Color.Blue;
                                break;
                        }
                    }

                    //Otherwise, if the bomb's serial number contains C, L, R, X, 1 or 8
                    else if (bomb.SerialNumber.Contains('C') ||
                            bomb.SerialNumber.Contains('L') ||
                            bomb.SerialNumber.Contains('R') ||
                            bomb.SerialNumber.Contains('X') ||
                            bomb.SerialNumber.Contains('1') ||
                            bomb.SerialNumber.Contains('8'))
                    {
                        switch (name)
                        {
                            case "VCC":
                                c = Color.Red;
                                break;

                            case "AIN":
                                c = Color.Magenta;
                                break;

                            case "DIN":
                                c = Color.Green;
                                break;

                            case "PWM":
                                c = Color.Blue;
                                break;

                            case "RST":
                                c = Color.Yellow;
                                break;
                        }
                    }

                    //Otherwise, if the second numerical digit of the controller's serial number matches the number of batteries on the bomb
                    else if (secondDigit == bomb.Battery)
                    {
                        switch (name)
                        {
                            case "VCC":
                                c = Color.Red;
                                break;

                            case "AIN":
                                c = Color.Blue;
                                break;

                            case "DIN":
                                c = Color.Yellow;
                                break;

                            case "PWM":
                                c = Color.Green;
                                break;

                            case "RST":
                                c = Color.Magenta;
                                break;
                        }
                    }

                    else
                    {
                        switch (name)
                        {
                            case "VCC":
                                c = Color.Green;
                                break;

                            case "AIN":
                                c = Color.Red;
                                break;

                            case "DIN":
                                c = Color.Yellow;
                                break;

                            case "PWM":
                                c = Color.Blue;
                                break;

                            case "RST":
                                c = Color.Magenta;
                                break;
                        }
                    }
                }

            }

            public string PrintPin()
            {
                return $"Index: {index}\nName: {name}\nColor: {color}";
            }
        }
    }
}
