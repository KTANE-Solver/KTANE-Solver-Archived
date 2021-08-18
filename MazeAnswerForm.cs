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
using System.Linq;

namespace KTANE_Solver
{
    public partial class MazeAnswerForm : ModuleForm
    {
        List<Maze.Coordinate> grid;
        public MazeAnswerForm(List<Maze.Coordinate> grid, StreamWriter logFileWriter)
        {
            InitializeComponent();

            this.grid = grid;

            row1button1.BackColor = GetColor(0, 0);
            row1button2.BackColor = GetColor(0, 1);
            row1button3.BackColor = GetColor(0, 2);
            row1button4.BackColor = GetColor(0, 3);
            row1button5.BackColor = GetColor(0, 4);
            row1button6.BackColor = GetColor(0, 5);

            row2button1.BackColor = GetColor(1, 0);
            row2button2.BackColor = GetColor(1, 1);
            row2button3.BackColor = GetColor(1, 2);
            row2button4.BackColor = GetColor(1, 3);
            row2button5.BackColor = GetColor(1, 4);
            row2button6.BackColor = GetColor(1, 5);

            row3button1.BackColor = GetColor(2, 0);
            row3button2.BackColor = GetColor(2, 1);
            row3button3.BackColor = GetColor(2, 2);
            row3button4.BackColor = GetColor(2, 3);
            row3button5.BackColor = GetColor(2, 4);
            row3button6.BackColor = GetColor(2, 5);

            row4button1.BackColor = GetColor(3, 0);
            row4button2.BackColor = GetColor(3, 1);
            row4button3.BackColor = GetColor(3, 2);
            row4button4.BackColor = GetColor(3, 3);
            row4button5.BackColor = GetColor(3, 4);
            row4button6.BackColor = GetColor(3, 5);

            row5button1.BackColor = GetColor(4, 0);
            row5button2.BackColor = GetColor(4, 1);
            row5button3.BackColor = GetColor(4, 2);
            row5button4.BackColor = GetColor(4, 3);
            row5button5.BackColor = GetColor(4, 4);
            row5button6.BackColor = GetColor(4, 5);

            row6button1.BackColor = GetColor(5, 0);
            row6button2.BackColor = GetColor(5, 1);
            row6button3.BackColor = GetColor(5, 2);
            row6button4.BackColor = GetColor(5, 3);
            row6button4.BackColor = GetColor(5, 3);
            row6button5.BackColor = GetColor(5, 4);
            row6button6.BackColor = GetColor(5, 5);

            this.ControlBox = false;
            LogFileWriter = logFileWriter;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private Color GetColor(int row, int column)
        {
                if (AreEqual(grid[0], new Maze.Coordinate( row, column ) ))
                {
                    return Color.White;
                }

                if (AreEqual(grid[grid.Count - 1], new Maze.Coordinate(row, column)))
                {
                    return Color.Red;
                }

                foreach (Maze.Coordinate pair in grid)
                {
                    if (AreEqual(pair, new Maze.Coordinate(row, column)))
                    {
                        return Color.Purple;
                    }
                }

            return Color.Blue;
        }

        private bool AreEqual(Maze.Coordinate c1, Maze.Coordinate c2)
        {
            return c1.Row == c2.Row && c1.Column == c2.Column;
        }
    }
}
