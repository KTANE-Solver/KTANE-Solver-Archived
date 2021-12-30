using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KTANE_Solver
{
    public partial class _3DMazeForm : Form
    {
        _3DMaze module;

        public _3DMazeForm()
        {
            InitializeComponent();
            module = new _3DMaze();
            module.SetMaze('A', 'B', 'C');
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            module.PrintGrid();

            bool progress = true;
            _3DMaze.Node start;

            for (int row = 0; row < 8; row++)
            {
                for (int column = 0; column < 8; column++)
                {
                    start = module.Maze[row, column];

                    string info =  "Start: " + GetNodeInformation(start);

                    if (start.North != null)
                    { 
                        info += "North: " + GetNodeInformation(start.North);
                    }

                    if (start.East != null)
                    { 
                        info += "East: " + GetNodeInformation(start.East);
                    }

                    if (start.South != null)
                    { 
                        info += "South: " + GetNodeInformation(start.South);
                    }

                    if (start.West != null)
                    { 
                        info += "West: " + GetNodeInformation(start.West);
                    }

                    info += "Is this correct?";  

                    if (MessageBox.Show(info, "3D Maze Debug", MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        MessageBox.Show($"Fix Row {row} and Column {column}");
                        progress = false;
                        break;
                    }
                }

                if (!progress)
                {
                    break;
                }
            }
        }

        private string GetNodeInformation(_3DMaze.Node node)
        {
            if (node == null)
            {
                return "No information found\n";
            }

            return $"Row {node.Row}, Column {node.Colunm}, Char {node.Character}\n";
        }
    }
}
