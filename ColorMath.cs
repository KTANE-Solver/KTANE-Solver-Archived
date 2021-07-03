﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace KTANE_Solver
{
    class ColorMath: Module
    {
        Color leftColor1;
        Color leftColor2;
        Color leftColor3;
        Color leftColor4;

        Color rightColor1;
        Color rightColor2;
        Color rightColor3;
        Color rightColor4;

        char letter;

        public ColorMath(Color leftColor1, Color leftColor2, Color leftColor3, Color leftColor4, char letter, 
                         Bomb bomb, StreamWriter logfileWriter) : base(bomb, logfileWriter)
        {
            this.leftColor1 = leftColor1;
            this.leftColor2 = leftColor2;
            this.leftColor3 = leftColor3;
            this.leftColor4 = leftColor4;

            this.letter = letter;
        }

        public ColorMath(Color leftColor1, Color leftColor2, Color leftColor3, Color leftColor4,
                         Color rightColor1, Color rightColor2, Color rightColor3, Color rightColor4, char letter, 
                         Bomb bomb, StreamWriter logfileWriter) : base(bomb, logfileWriter)
        {
            this.leftColor1 = leftColor1;
            this.leftColor2 = leftColor2;
            this.leftColor3 = leftColor3;
            this.leftColor4 = leftColor4;

            this.rightColor1 = rightColor1;
            this.rightColor2 = rightColor2;
            this.rightColor3 = rightColor3;
            this.rightColor4 = rightColor4;

            this.letter = letter;
        }

        public void SolveGreen()
        {
            int thousandPlace = GetLeftSideNumber(1, leftColor1);
            int hundredPlace = GetLeftSideNumber(2, leftColor2);
            int tenPlace = GetLeftSideNumber(3, leftColor3);
            int onePlace = GetLeftSideNumber(4, leftColor4);

            int leftNumber = thousandPlace * 1000 + hundredPlace * 100 + tenPlace * 10 + onePlace;

            thousandPlace = GetRightSideNumber(1, rightColor1);
            hundredPlace = GetRightSideNumber(2, rightColor2);
            tenPlace = GetRightSideNumber(3, rightColor3);
            onePlace = GetRightSideNumber(4, rightColor4);

            int rightNumber = thousandPlace * 1000 + hundredPlace * 100 + tenPlace * 10 + onePlace;

            int answer = -1;

            switch (letter)
            {
                case 'A':
                    answer = leftNumber + rightNumber;
                    break;

                case 'M':
                    answer = leftNumber * rightNumber;
                    break;

                case 'D':
                    answer = leftNumber / rightNumber;
                    break;

                case 'S':
                    answer = leftNumber - rightNumber;
                    break;
            }

            if(answer < 0)
            {
                answer *= -1;
            }

            answer %= 10000;

            MessageBox.Show(ConvertAnswerToColor(answer), "Color Math Answer", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void SolveRed()
        {
            int thousandPlace = GetLeftSideNumber(1, leftColor1);
            int hundredPlace = GetLeftSideNumber(2, leftColor2);
            int tenPlace = GetLeftSideNumber(3, leftColor3);
            int onePlace = GetLeftSideNumber(4, leftColor4);

            int leftNumber = thousandPlace * 1000 + hundredPlace * 100 + tenPlace * 10 + onePlace;

            thousandPlace = GetRightSideNumber(1);
            hundredPlace = GetRightSideNumber(2);
            tenPlace = GetRightSideNumber(3);
            onePlace = GetRightSideNumber(4);

            int rightNumber = thousandPlace * 1000 + hundredPlace * 100 + tenPlace * 10 + onePlace;

            int number = -1;

            switch (letter)
            {
                case 'A':
                    number = leftNumber + rightNumber;
                    break;

                case 'M':
                    number = leftNumber * rightNumber;
                    break;

                case 'D':
                    number = leftNumber / rightNumber;
                    break;

                case 'S':
                    number = leftNumber - rightNumber;
                    break;
            }

            if (number < 0)
            {
                number *= -1;
            }

            number %= 10000;

            
            MessageBox.Show(ConvertAnswerToColor(number), "Color Math Answer", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public int GetLeftSideNumber(int place, Color color)
        {
            if (place == 1)
            {
                switch (color)
                {

                    case Color.Blue:
                        return 6;

                    case Color.Green:
                        return 1;

                    case Color.Purple:
                        return 2;

                    case Color.Yellow:
                        return 4;

                    case Color.White:
                        return 9;

                    case Color.Magenta:
                        return 0;

                    case Color.Red:
                        return 8;

                    case Color.Orange:
                        return 5;

                    case Color.Gray:
                        return 3;

                    case Color.Black:
                        return 7;
                }
            }

            else if (place == 2)
            {
                switch (color)
                {

                    case Color.Blue:
                        return 8;

                    case Color.Green:
                        return 1;

                    case Color.Purple:
                        return 9;

                    case Color.Yellow:
                        return 4;

                    case Color.White:
                        return 3;

                    case Color.Magenta:
                        return 6;

                    case Color.Red:
                        return 0;

                    case Color.Orange:
                        return 5;

                    case Color.Gray:
                        return 7;

                    case Color.Black:
                        return 2;
                }
            }

            else if (place == 3)
            {
                switch (color)
                {

                    case Color.Blue:
                        return 4;

                    case Color.Green:
                        return 1;

                    case Color.Purple:
                        return 9;

                    case Color.Yellow:
                        return 7;

                    case Color.White:
                        return 0;

                    case Color.Magenta:
                        return 2;

                    case Color.Red:
                        return 5;

                    case Color.Orange:
                        return 3;

                    case Color.Gray:
                        return 8;

                    case Color.Black:
                        return 6;
                }
            }

            else
            {
                switch (color)
                {

                    case Color.Blue:
                        return 6;

                    case Color.Green:
                        return 8;

                    case Color.Purple:
                        return 7;

                    case Color.Yellow:
                        return 5;

                    case Color.White:
                        return 4;

                    case Color.Magenta:
                        return 9;

                    case Color.Red:
                        return 1;

                    case Color.Orange:
                        return 3;

                    case Color.Gray:
                        return 0;

                    case Color.Black:
                        return 2;   
                }
            }

            return -1;
        }

        public int GetRightSideNumber(int place, Color color)

        {
            if (place == 1)
            {
                switch (color)
                {

                    case Color.Blue:
                        return 0;

                    case Color.Green:
                        return 6;

                    case Color.Purple:
                        return 5;

                    case Color.Yellow:
                        return 4;

                    case Color.White:
                        return 3;

                    case Color.Magenta:
                        return 7;

                    case Color.Red:
                        return 9;

                    case Color.Orange:
                        return 8;

                    case Color.Gray:
                        return 1;

                    case Color.Black:
                        return 2;
                }
            }

            else if (place == 2)
            {
                switch (color)
                {

                    case Color.Blue:
                        return 2;

                    case Color.Green:
                        return 9;

                    case Color.Purple:
                        return 8;

                    case Color.Yellow:
                        return 0;

                    case Color.White:
                        return 5;

                    case Color.Magenta:
                        return 3;

                    case Color.Red:
                        return 4;

                    case Color.Orange:
                        return 7;

                    case Color.Gray:
                        return 1;

                    case Color.Black:
                        return 6;
                }
            }

            else if (place == 3)
            {
                switch (color)
                {

                    case Color.Blue:
                        return 5;

                    case Color.Green:
                        return 0;

                    case Color.Purple:
                        return 6;

                    case Color.Yellow:
                        return 4;

                    case Color.White:
                        return 2;

                    case Color.Magenta:
                        return 7;

                    case Color.Red:
                        return 9;

                    case Color.Orange:
                        return 3;

                    case Color.Gray:
                        return 8;

                    case Color.Black:
                        return 1;
                }
            }

            else
            {
                switch (color)
                {

                    case Color.Blue:
                        return 5;

                    case Color.Green:
                        return 4;

                    case Color.Purple:
                        return 2;

                    case Color.Yellow:
                        return 9;

                    case Color.White:
                        return 8;

                    case Color.Magenta:
                        return 6;

                    case Color.Red:
                        return 7;

                    case Color.Orange:
                        return 1;

                    case Color.Gray:
                        return 3;

                    case Color.Black:
                        return 0;
                }
            }

            return -1;
        }

        public int GetRightSideNumber(int place)
        {
            switch (Bomb.Battery)
            {
                case 0:
                case 1:

                    if (place == 1)
                    {
                        return Bomb.FirstDigit;
                    }

                    else if (place == 2)
                    {
                        return Bomb.IndicatorUnlitNum;
                    }

                    else if (place == 3)
                    {
                        return 9;
                    }

                    return Bomb.Rj.Num;

                case 2:
                case 3:

                    if (place == 1)
                    {
                        return 0;
                    }

                    else if (place == 2)
                    {
                        return Bomb.Ps.Num;
                    }

                    else if (place == 3)
                    {
                        return Bomb.LetterNum;
                    }

                    return Bomb.LastDigit;


                case 4:
                case 5:

                    if (place == 1)
                    {
                        return Bomb.VowelNum;
                    }

                    else if (place == 2)
                    {
                        return Bomb.BatteryHolder;
                    }

                    else if (place == 3)
                    {
                        return Bomb.Serial.Num;
                    }

                    return 4;
           

                default:

                    if (place == 1)
                    {
                        return Bomb.Dvid.Num;
                    }

                    else if (place == 2)
                    {
                        return 5;
                    }

                    else if (place == 3)
                    {
                        return Bomb.SerialNumber.Length - (Bomb.VowelNum + Bomb.DigitNum);
                    }

                    return Bomb.IndicatorLitNum;
            }
        }

        private String ConvertAnswerToColor(int answer)
        {
            int thousandPlace = answer / 1000;
            int hundredPlace = (answer % 1000) / 100;
            int tenPlace = (answer % 100) / 10;
            int onePlace = answer % 10;

            List<Color> answerList = new List<Color>();

            switch (thousandPlace)
            {
                case 0:
                    answerList.Add(Color.Gray);
                    break;

                case 1:
                    answerList.Add(Color.Green);
                    break;

                case 2:
                    answerList.Add(Color.Orange);
                    break;

                case 3:
                    answerList.Add(Color.White);
                    break;

                case 4:
                    answerList.Add(Color.Purple);
                    break;

                case 5:
                    answerList.Add(Color.Blue);
                    break;

                case 6:
                    answerList.Add(Color.Magenta);
                    break;

                case 7:
                    answerList.Add(Color.Black);
                    break;

                case 8:
                    answerList.Add(Color.Yellow);
                    break;

                case 9:
                    answerList.Add(Color.Red);
                    break;
            }

            switch (hundredPlace)
            {
                case 0:
                    answerList.Add(Color.Blue);
                    break;

                case 1:
                    answerList.Add(Color.Green);
                    break;

                case 2:
                    answerList.Add(Color.Black);
                    break;

                case 3:
                    answerList.Add(Color.Purple);
                    break;

                case 4:
                    answerList.Add(Color.Magenta);
                    break;

                case 5:
                    answerList.Add(Color.Red);
                    break;

                case 6:
                    answerList.Add(Color.Gray);
                    break;

                case 7:
                    answerList.Add(Color.Yellow);
                    break;

                case 8:
                    answerList.Add(Color.Orange);
                    break;

                case 9:
                    answerList.Add(Color.White);
                    break;
            }

            switch (tenPlace)
            {
                case 0:
                    answerList.Add(Color.Magenta);
                    break;

                case 1:
                    answerList.Add(Color.Yellow);
                    break;

                case 2:
                    answerList.Add(Color.Blue);
                    break;

                case 3:
                    answerList.Add(Color.Gray);
                    break;

                case 4:
                    answerList.Add(Color.Red);
                    break;

                case 5:
                    answerList.Add(Color.Black);
                    break;

                case 6:
                    answerList.Add(Color.Green);
                    break;

                case 7:
                    answerList.Add(Color.Purple);
                    break;

                case 8:
                    answerList.Add(Color.Orange);
                    break;

                case 9:
                    answerList.Add(Color.White);
                    break;
            }

            switch (onePlace)
            {
                case 0:
                    answerList.Add(Color.Gray);
                    break;

                case 1:
                    answerList.Add(Color.Blue);
                    break;

                case 2:
                    answerList.Add(Color.Purple);
                    break;

                case 3:
                    answerList.Add(Color.Red);
                    break;

                case 4:
                    answerList.Add(Color.Yellow);
                    break;

                case 5:
                    answerList.Add(Color.Magenta);
                    break;

                case 6:
                    answerList.Add(Color.Black);
                    break;

                case 7:
                    answerList.Add(Color.Orange);
                    break;

                case 8:
                    answerList.Add(Color.Green);
                    break;

                case 9:
                    answerList.Add(Color.White);
                    break;
            }

            String answerString = "";

            foreach (Color color in answerList)
            {
                answerString += color.ToString() + "\n";
            }

            return answerString;
        }

        public enum Color
        { 
            Gray,
            Green,
            Orange,
            White,
            Purple,
            Blue,
            Black,
            Magenta,
            Yellow,
            Red
        }
    }
}