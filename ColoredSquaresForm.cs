using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace KTANE_Solver
{
    public partial class ColoredSquaresForm : ModuleForm
    {
        private ColoredSquares.Color[,] moduleGrid;
        public ColoredSquaresForm(Bomb bomb, StreamWriter logFileWriter, ModuleSelectionForm moduleSelectionForm) : base(bomb, logFileWriter, moduleSelectionForm, "Colored Squares", false)
        {
            InitializeComponent();
        }

        public void UpdateForm(Bomb bomb, StreamWriter logFileWriter)
        {
            Bomb = bomb;
            LogFileWriter = logFileWriter;

            row1Button1.BackColor = Color.White;
            row1Button2.BackColor = Color.White;
            row1Button3.BackColor = Color.White;
            row1Button4.BackColor = Color.White;

            row2Button1.BackColor = Color.White;
            row2Button2.BackColor = Color.White;
            row2Button3.BackColor = Color.White;
            row2Button4.BackColor = Color.White;

            row3Button1.BackColor = Color.White;
            row3Button2.BackColor = Color.White;
            row3Button3.BackColor = Color.White;
            row3Button4.BackColor = Color.White;

            row4Button1.BackColor = Color.White;
            row4Button2.BackColor = Color.White;
            row4Button3.BackColor = Color.White;
            row4Button4.BackColor = Color.White;



            row1Button1.Click += (Tile_Click);
            row1Button2.Click += (Tile_Click);
            row1Button3.Click += (Tile_Click);
            row1Button4.Click += (Tile_Click);


            row2Button1.Click += (Tile_Click);
            row2Button2.Click += (Tile_Click);
            row2Button3.Click += (Tile_Click);
            row2Button4.Click += (Tile_Click);


            row3Button1.Click += (Tile_Click);
            row3Button2.Click += (Tile_Click);
            row3Button3.Click += (Tile_Click);
            row3Button4.Click += (Tile_Click);


            row4Button1.Click += (Tile_Click);
            row4Button2.Click += (Tile_Click);
            row4Button3.Click += (Tile_Click);
            row4Button4.Click += (Tile_Click);

            moduleGrid = null;
        }

        public void Tile_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button button = (System.Windows.Forms.Button)sender;

            if (ButtonGoodToClick(button))
            {
                if (button.BackColor == Color.White)
                {
                    button.BackColor = Color.Red;
                }

                else if (button.BackColor == Color.Red)
                {
                    button.BackColor = Color.Blue;
                }

                else if (button.BackColor == Color.Blue)
                {
                    button.BackColor = Color.Green;
                }

                else if (button.BackColor == Color.Green)
                {
                    button.BackColor = Color.Yellow;
                }

                else if (button.BackColor == Color.Yellow)
                {
                    button.BackColor = Color.Magenta;
                }

                else
                {
                    button.BackColor = Color.White;
                }
            }
        }

        private void SetButtonsWhite()
        {
            row1Button1.BackColor = Color.White;
            row1Button2.BackColor = Color.White;
            row1Button3.BackColor = Color.White;
            row1Button4.BackColor = Color.White;

            row2Button1.BackColor = Color.White;
            row2Button2.BackColor = Color.White;
            row2Button3.BackColor = Color.White;
            row2Button4.BackColor = Color.White;

            row3Button1.BackColor = Color.White;
            row3Button2.BackColor = Color.White;
            row3Button3.BackColor = Color.White;
            row3Button4.BackColor = Color.White;

            row4Button1.BackColor = Color.White;
            row4Button2.BackColor = Color.White;
            row4Button3.BackColor = Color.White;
            row4Button4.BackColor = Color.White;
        }

        private bool ButtonGoodToClick(System.Windows.Forms.Button b)
        {
            if (moduleGrid == null)
                return true;

            if (b == row1Button1)
            {
                return moduleGrid[0, 0] != ColoredSquares.Color.White;
            }

            else if (b == row1Button2)
            {
                return moduleGrid[0, 1] != ColoredSquares.Color.White;
            }

            else if (b == row1Button3)
            {
                return moduleGrid[0, 2] != ColoredSquares.Color.White;
            }

            else if (b == row1Button4)
            {
                return moduleGrid[0, 3] != ColoredSquares.Color.White;
            }

            else if (b == row2Button1)
            {
                return moduleGrid[1, 0] != ColoredSquares.Color.White;
            }

            else if (b == row2Button2)
            {
                return moduleGrid[1, 1] != ColoredSquares.Color.White;
            }

            else if (b == row2Button3)
            {
                return moduleGrid[1, 2] != ColoredSquares.Color.White;
            }

            else if (b == row2Button4)
            {
                return moduleGrid[1, 3] != ColoredSquares.Color.White;
            }

            else if (b == row3Button1)
            {
                return moduleGrid[2, 0] != ColoredSquares.Color.White;
            }

            else if (b == row3Button2)
            {
                return moduleGrid[2, 1] != ColoredSquares.Color.White;
            }

            else if (b == row3Button3)
            {
                return moduleGrid[2, 2] != ColoredSquares.Color.White;
            }

            else if (b == row3Button4)
            {
                return moduleGrid[2, 3] != ColoredSquares.Color.White;
            }

            else if (b == row4Button1)
            {
                return moduleGrid[3, 0] != ColoredSquares.Color.White;
            }

            else if (b == row4Button2)
            {
                return moduleGrid[3, 1] != ColoredSquares.Color.White;
            }

            else if (b == row4Button3)
            {
                return moduleGrid[3, 2] != ColoredSquares.Color.White;
            }


            return moduleGrid[3, 3] != ColoredSquares.Color.White;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            ColoredSquares module = null;
            ColoredSquares.Color color = ColoredSquares.Color.Red;

            if (moduleGrid == null)
            {
                moduleGrid = ConvertForm();

                module = new ColoredSquares(moduleGrid, Bomb, LogFileWriter);

                color = module.GetFirstColor();

                SetButtonsWhite();
            }

            else if(module.ColorNum(ColoredSquares.Color.White) < 15)
            {
                moduleGrid = ConvertForm();
                
                color = module.Solve(color);

                if (module.ColorNum(ColoredSquares.Color.White) >= 15)
                {
                    UpdateForm(Bomb, LogFileWriter);
                }
            }
        }

        private ColoredSquares.Color[,] ConvertForm()
        {
            ColoredSquares.Color[,] grid = new ColoredSquares.Color[4, 4];

            grid[0, 0] = ConvertFormColor(row1Button1.BackColor);
            grid[0, 1] = ConvertFormColor(row1Button2.BackColor);
            grid[0, 2] = ConvertFormColor(row1Button3.BackColor);
            grid[0, 3] = ConvertFormColor(row1Button4.BackColor);

            grid[1, 0] = ConvertFormColor(row2Button1.BackColor);
            grid[1, 1] = ConvertFormColor(row2Button2.BackColor);
            grid[1, 2] = ConvertFormColor(row2Button3.BackColor);
            grid[1, 3] = ConvertFormColor(row2Button4.BackColor);

            grid[2, 0] = ConvertFormColor(row3Button1.BackColor);
            grid[2, 1] = ConvertFormColor(row3Button2.BackColor);
            grid[2, 2] = ConvertFormColor(row3Button3.BackColor);
            grid[2, 3] = ConvertFormColor(row3Button4.BackColor);

            grid[3, 0] = ConvertFormColor(row4Button1.BackColor);
            grid[3, 1] = ConvertFormColor(row4Button2.BackColor);
            grid[3, 2] = ConvertFormColor(row4Button3.BackColor);
            grid[3, 3] = ConvertFormColor(row4Button4.BackColor);

            return grid;
        }

        private Color ConvertColoredSquareColor(ColoredSquares.Color c)
        {
            switch (c)
            {
                case ColoredSquares.Color.Red:
                    return Color.Red;

                case ColoredSquares.Color.Blue:
                    return Color.Blue;

                case ColoredSquares.Color.Green:
                    return Color.Green;

                case ColoredSquares.Color.Yellow:
                    return Color.Yellow;

                case ColoredSquares.Color.Magenta:
                    return Color.Magenta;

                default:
                    return Color.White;
            }
        }

        private ColoredSquares.Color ConvertFormColor(Color c)
        {
            if (c == Color.Red)
            { 
                return ColoredSquares.Color.Red;
            }

            if (c == Color.Blue)
            {
                return ColoredSquares.Color.Blue;
            }

            if (c == Color.Green)
            {
                return ColoredSquares.Color.Green;
            }

            if (c == Color.Yellow)
            {
                return ColoredSquares.Color.Yellow;
            }

            if (c == Color.White)
            { 
                return ColoredSquares.Color.White;
            }

            return ColoredSquares.Color.Magenta;
        }

        private void strikeButton_Click(object sender, EventArgs e)
        {
            IncrementStrike();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            GoToMoudleSelectionForm();
        }
    }
}
