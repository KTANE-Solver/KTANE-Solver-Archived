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
    public partial class _3DMazeForm : ModuleForm
    {
        _3DMaze module;

        public _3DMazeForm(Bomb bomb, StreamWriter logFile, ModuleSelectionForm moduleSelectionForm)
        {
            InitializeComponent();
            UpdateEdgeWork(bomb, logFile, moduleSelectionForm);
            module = new _3DMaze(bomb, logFile);
            module.SetMaze("ABD");
        }

        public void UpdateForm(Bomb bomb, StreamWriter logFile, ModuleSelectionForm moduleSelectionForm)
        { 
            UpdateEdgeWork(bomb, logFile, moduleSelectionForm);
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            module.PrintGrid();

            PrintDebugLine("");

            PrintDebugInfo();
        }

        private void PrintDebugInfo()
        { 
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    _3DMaze.Node start = module.Maze[i, j];

                    PrintDebugLine("Start: " + GetNodeInformation(start));

                    if (start.North != null)
                    {
                        PrintDebugLine("North: " + GetNodeInformation(start.North));
                    }

                    if (start.East != null)
                    {
                        PrintDebugLine("East: " + GetNodeInformation(start.East));
                    }

                    if (start.South != null)
                    {
                        PrintDebugLine("South: " + GetNodeInformation(start.South));
                    }

                    if (start.West != null)
                    {
                        PrintDebugLine("West: " + GetNodeInformation(start.West));
                    }

                    PrintDebugLine("");
                }
            }

        }

        private string GetNodeInformation(_3DMaze.Node node)
        {
            if (node == null)
            {
                return "No information found\n";
            }

            return $"Row {node.Row}, Column {node.Colunm}, Char {node.Character}";
        }
    }
}
