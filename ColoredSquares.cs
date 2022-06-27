using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace KTANE_Solver
{
    public class ColoredSquares : Module
    {
        public enum Color
        {
            Red,
            Blue,
            Green,
            Yellow,
            Magenta,
            Row,
            Column,
            White,
        }

        public Color[,] grid { get; }

        public ColoredSquares(Color[,] grid, Bomb bomb, StreamWriter logFileWriter) : base(bomb, logFileWriter, "Colored Squares")
        {
            this.grid = grid;
        }

        public Color GetFirstColor()
        {
            //find the color that has appears the least on the module
            int blueColor = ColorNum(Color.Blue);
            int redColor = ColorNum(Color.Red);
            int yellowColor = ColorNum(Color.Yellow);
            int greenColor = ColorNum(Color.Green);
            int magentaColor = ColorNum(Color.Magenta);

            PrintDebugLine($"Blue Num: {blueColor}");
            PrintDebugLine($"Red Num: {redColor}");
            PrintDebugLine($"Yellow Num: {yellowColor}");
            PrintDebugLine($"Green Num: {greenColor}");
            PrintDebugLine($"Magenta Num: {magentaColor}\n");


            int smallest = blueColor;
            Color color = Color.Blue;

            if (smallest > redColor)
            {
                color = Color.Red;
                smallest = redColor;
            }

            if (smallest > yellowColor)
            {
                color = Color.Yellow;
                smallest = yellowColor;
            }

            if (smallest > greenColor)
            {
                color = Color.Green;
                smallest = greenColor;
            }

            if (smallest > magentaColor)
            {
                color = Color.Magenta;
            }

            ShowAnswer("" + color, true);

            FillWhiteSquares(color);

            PrintGrid();

            return color;
        }

        public Color Solve(Color color)
        {
            Color answer = FindButtonsToPress(color);
            
            FillWhiteSquares(answer);

            PrintGrid();

            ShowAnswer("" + answer, true);

            return answer;
        }

        private void FillWhiteSquares(Color color)
        {
            if (color == Color.Row)
            {
                bool foundWhite = true;
                int row = 0;

                while (!foundWhite)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        foundWhite = grid[row, i] == Color.White;

                        if (!foundWhite)
                        {
                            break;
                        }

                        row++;
                    }
                }

                for (int i = 0; i < 4; i++)
                {
                    grid[row, i] = Color.White;
                }
            }

            else if (color == Color.Column)
            {
                bool foundWhite = true;
                int column = 0;

                while (!foundWhite)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        foundWhite = grid[i, column] == Color.White;

                        if (!foundWhite)
                        {
                            break;
                        }

                        column++;
                    }
                }

                for (int i = 0; i < 4; i++)
                {
                    grid[i, column] = Color.White;
                }
            }

            else
            {
                for (int row = 0; row < 4; row++)
                {
                    for (int column = 0; column < 4; column++)
                    {
                        if (grid[row, column] == color)
                        {
                            grid[row, column] = Color.White;
                        }
                    }
                }
            }
        }

        private Color FindButtonsToPress(Color color)
        {
            int whiteNum = ColorNum(Color.White);

            PrintDebugLine($"White Num: {whiteNum}\n");

            switch (whiteNum)
            {
                case 1:
                    if (color == Color.Red)
                    { 
                        return Color.Blue;
                    }

                    if (color == Color.Blue)
                    {
                        return Color.Column;
                    }

                    if (color == Color.Green)
                    {
                        return Color.Red;
                    }

                    if (color == Color.Yellow)
                    {
                        return Color.Yellow;
                    }

                    if (color == Color.Magenta)
                    {
                        return Color.Row;
                    }

                    if (color == Color.Row)
                    {
                        return Color.Green;
                    }

                    return Color.Magenta;

                case 2:
                    if (color == Color.Red)
                    {
                        return Color.Row;
                    }

                    if (color == Color.Blue)
                    {
                        return Color.Green;
                    }

                    if (color == Color.Green)
                    {
                        return Color.Blue;
                    }

                    if (color == Color.Yellow)
                    {
                        return Color.Magenta;
                    }

                    if (color == Color.Magenta)
                    {
                        return Color.Column;
                    }

                    if (color == Color.Row)
                    {
                        return Color.Yellow;
                    }

                    return Color.Magenta;
                case 3:
                    if (color == Color.Red)
                    {
                        return Color.Yellow;
                    }

                    if (color == Color.Blue)
                    {
                        return Color.Magenta;
                    }

                    if (color == Color.Green)
                    {
                        return Color.Green;
                    }

                    if (color == Color.Yellow)
                    {
                        return Color.Row;
                    }

                    if (color == Color.Magenta)
                    {
                        return Color.Blue;
                    }

                    if (color == Color.Row)
                    {
                        return Color.Red;
                    }

                    return Color.Column;
                case 4:
                    if (color == Color.Red)
                    {
                        return Color.Blue;
                    }

                    if (color == Color.Blue)
                    {
                        return Color.Green;
                    }

                    if (color == Color.Green)
                    {
                        return Color.Yellow;
                    }

                    if (color == Color.Yellow)
                    {
                        return Color.Column;
                    }

                    if (color == Color.Magenta)
                    {
                        return Color.Red;
                    }

                    if (color == Color.Row)
                    {
                        return Color.Row;
                    }

                    return Color.Magenta;

                case 5:
                    if (color == Color.Red)
                    {
                        return Color.Yellow;
                    }

                    if (color == Color.Blue)
                    {
                        return Color.Row;
                    }

                    if (color == Color.Green)
                    {
                        return Color.Blue;
                    }

                    if (color == Color.Yellow)
                    {
                        return Color.Magenta;
                    }

                    if (color == Color.Magenta)
                    {
                        return Color.Column;
                    }

                    if (color == Color.Row)
                    {
                        return Color.Red;
                    }

                    return Color.Green;

                case 6:
                    if (color == Color.Red)
                    {
                        return Color.Magenta;
                    }

                    if (color == Color.Blue)
                    {
                        return Color.Red;
                    }

                    if (color == Color.Green)
                    {
                        return Color.Yellow;
                    }

                    if (color == Color.Yellow)
                    {
                        return Color.Green;
                    }

                    if (color == Color.Magenta)
                    {
                        return Color.Column;
                    }

                    if (color == Color.Row)
                    {
                        return Color.Blue;
                    }

                    return Color.Row;

                case 7:
                    if (color == Color.Red)
                    {
                        return Color.Green;
                    }

                    if (color == Color.Blue)
                    {
                        return Color.Row;
                    }

                    if (color == Color.Green)
                    {
                        return Color.Column;
                    }

                    if (color == Color.Yellow)
                    {
                        return Color.Blue;
                    }

                    if (color == Color.Magenta)
                    {
                        return Color.Magenta;
                    }

                    if (color == Color.Row)
                    {
                        return Color.Yellow;
                    }

                    return Color.Red;

                case 8:
                    if (color == Color.Red)
                    {
                        return Color.Magenta;
                    }

                    if (color == Color.Blue)
                    {
                        return Color.Red;
                    }

                    if (color == Color.Green)
                    {
                        return Color.Green;
                    }

                    if (color == Color.Yellow)
                    {
                        return Color.Blue;
                    }

                    if (color == Color.Magenta)
                    {
                        return Color.Yellow;
                    }

                    if (color == Color.Row)
                    {
                        return Color.Column;
                    }

                    return Color.Row;

                case 9:
                    if (color == Color.Red)
                    {
                        return Color.Column;
                    }

                    if (color == Color.Blue)
                    {
                        return Color.Yellow;
                    }

                    if (color == Color.Green)
                    {
                        return Color.Red;
                    }

                    if (color == Color.Yellow)
                    {
                        return Color.Green;
                    }

                    if (color == Color.Magenta)
                    {
                        return Color.Row;
                    }

                    if (color == Color.Row)
                    {
                        return Color.Magenta;
                    }

                    return Color.Blue;

                case 10:
                    if (color == Color.Red)
                    {
                        return Color.Green;
                    }

                    if (color == Color.Blue)
                    {
                        return Color.Column;
                    }

                    if (color == Color.Green)
                    {
                        return Color.Row;
                    }

                    if (color == Color.Yellow)
                    {
                        return Color.Red;
                    }

                    if (color == Color.Magenta)
                    {
                        return Color.Magenta;
                    }

                    if (color == Color.Row)
                    {
                        return Color.Blue;
                    }

                    return Color.Yellow;

                case 11:
                    if (color == Color.Red)
                    {
                        return Color.Red;
                    }

                    if (color == Color.Blue)
                    {
                        return Color.Yellow;
                    }

                    if (color == Color.Green)
                    {
                        return Color.Row;
                    }

                    if (color == Color.Yellow)
                    {
                        return Color.Column;
                    }

                    if (color == Color.Magenta)
                    {
                        return Color.Green;
                    }

                    if (color == Color.Row)
                    {
                        return Color.Magenta;
                    }

                    return Color.Blue;

                case 12:
                    if (color == Color.Red)
                    {
                        return Color.Column;
                    }

                    if (color == Color.Blue)
                    {
                        return Color.Blue;
                    }

                    if (color == Color.Green)
                    {
                        return Color.Magenta;
                    }

                    if (color == Color.Yellow)
                    {
                        return Color.Red;
                    }

                    if (color == Color.Magenta)
                    {
                        return Color.Yellow;
                    }

                    if (color == Color.Row)
                    {
                        return Color.Row;
                    }

                    return Color.Green;

                case 13:
                    if (color == Color.Red)
                    {
                        return Color.Row;
                    }

                    if (color == Color.Blue)
                    {
                        return Color.Magenta;
                    }

                    if (color == Color.Green)
                    {
                        return Color.Column;
                    }

                    if (color == Color.Yellow)
                    {
                        return Color.Yellow;
                    }

                    if (color == Color.Magenta)
                    {
                        return Color.Blue;
                    }

                    if (color == Color.Row)
                    {
                        return Color.Green;
                    }

                    return Color.Red;

                default:
                    if (color == Color.Red)
                    {
                        return Color.Red;
                    }

                    if (color == Color.Blue)
                    {
                        return Color.Blue;
                    }

                    if (color == Color.Green)
                    {
                        return Color.Magenta;
                    }

                    if (color == Color.Yellow)
                    {
                        return Color.Row;
                    }

                    if (color == Color.Magenta)
                    {
                        return Color.Green;
                    }

                    if (color == Color.Row)
                    {
                        return Color.Yellow;
                    }

                    return Color.Column;
            }
        }

        public int ColorNum(Color color)
        {
            int num = 0;

            foreach (Color c in grid)
            {
                if (c == color)
                {
                    num++;
                }
            }

            return num;
        }

        public void PrintGrid()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                     PrintDebug(grid[i, j].ToString()[0] + " ");
                }

                PrintDebugLine("");
            }

            PrintDebugLine("");
        }
    }
}
