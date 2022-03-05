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
    /// <summary>
    /// Author: Nya Bentley
    /// Purpose: Gets information from the user that is needed to solve 3D Maze
    /// </summary>
    public partial class _3DMazeForm : ModuleForm
    {
        _3DMaze module;

        public _3DMazeForm(Bomb bomb, StreamWriter logFile, ModuleSelectionForm moduleSelectionForm)
        {
            InitializeComponent();
            UpdateEdgeWork(bomb, logFile, moduleSelectionForm);
            module = new _3DMaze(bomb, logFile);
            module.SetMaze("CDH");
        }

        public void UpdateForm(Bomb bomb, StreamWriter logFile, ModuleSelectionForm moduleSelectionForm)
        { 
            UpdateEdgeWork(bomb, logFile, moduleSelectionForm);
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            module.PrintGrid();

            PrintDebugLine("");

            VerifyNodes();

            //PrintDebugInfo();
        }

        private void VerifyNodes()
        {
            int counter = 0;

            foreach (_3DMaze.Node start in module.Maze)
            {
                //verify that start's north has south set to start
                if (start.North != null && start.North.South != start)
                {
                    PrintDebugLine($"Inconsistencies at {start.Row},{start.Colunm} and {start.North.Row},{start.North.Colunm}\n");
                    counter++;
                }

                //verify that start's south has north set to start
                if (start.South != null && start.South.North!= start)
                {
                    PrintDebugLine($"Inconsistencies at {start.Row},{start.Colunm} and {start.South.Row},{start.South.Colunm}\n");
                    counter++;
                }

                //verify that start's east has west set to start
                if (start.East != null && start.East.West != start)
                {
                    PrintDebugLine($"Inconsistencies at {start.Row},{start.Colunm} and {start.East.Row},{start.East.Colunm}\n");
                    counter++;
                }

                //verify that start's west has east set to start
                if (start.West != null && start.West.East != start)
                {
                    PrintDebugLine($"Inconsistencies at {start.Row},{start.Colunm} and {start.West.Row},{start.West.Colunm}\n");
                    counter++;
                }
            }

            if (counter == 0)
            {
                PrintDebugLine("No inconsistencies found\n");
            }

        }

        private void PrintDebugInfo()
        { 
            foreach(_3DMaze.Node start in module.Maze)
            {

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
