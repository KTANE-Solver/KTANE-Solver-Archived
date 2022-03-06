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
        }

        public void UpdateForm(Bomb bomb, StreamWriter logFile, ModuleSelectionForm moduleSelectionForm)
        { 
            UpdateEdgeWork(bomb, logFile, moduleSelectionForm);
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string mazeText = mazeTextBox.Text.ToUpper();


            //maze can only have 3 letters
            if (mazeText.Length != 3)
            {
                ShowErrorMessage("Maze can only have 3 letters");
                return;
            }

            //make sure maze given is valid
            if (!(mazeText.Contains('A') && mazeText.Contains('B') && mazeText.Contains('C')) &&
                !(mazeText.Contains('A') && mazeText.Contains('B') && mazeText.Contains('D')) &&
                !(mazeText.Contains('A') && mazeText.Contains('B') && mazeText.Contains('H')) &&
                !(mazeText.Contains('A') && mazeText.Contains('C') && mazeText.Contains('D')) &&
                !(mazeText.Contains('A') && mazeText.Contains('C') && mazeText.Contains('H')) &&
                !(mazeText.Contains('A') && mazeText.Contains('D') && mazeText.Contains('H')) &&
                !(mazeText.Contains('B') && mazeText.Contains('C') && mazeText.Contains('D')) &&
                !(mazeText.Contains('B') && mazeText.Contains('C') && mazeText.Contains('H')) &&
                !(mazeText.Contains('B') && mazeText.Contains('D') && mazeText.Contains('H')) &&
                !(mazeText.Contains('C') && mazeText.Contains('D') && mazeText.Contains('H')))
            {
                ShowErrorMessage("Unaable to find correct maze");
            }

            module = new _3DMaze(Bomb, LogFileWriter);

            module.SetMaze(mazeText);

            //make sure user puts in valid path input

            string pathText = pathTextBox.Text;

            char[] mazeLetters = module.mazeLetters;

            //find where the user is going
            int row = module.FindRow();

            int column = module.FindColumn();

            PrintDebugLine($"Goal: {row},{column}\n");

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

        /// <summary>
        /// Verifies is path is on current maze
        /// </summary>
        /// <param name="path">the path the user gave</param>
        /// <param name="mazeLetters">the letters on the maze</param>
        /// <param name="module">the module</param>
        /// <returns>if the program can find where the user is</returns>
        private bool ValidPathText(string path, char[] mazeLetters, _3DMaze module)
        {
            string newPath = "";

            //convert all N, E, S, W to *
            for (int i = 0; i < path.Length; i++)
            {
                char c = path[i];

                if (c == 'N' || c == 'E' || c == 'S' || c == 'W')
                {
                    newPath += "*";
                }

                else
                {
                    newPath += c;
                }
            }

            //find all possible places user ended up at

            //first digit: ending row (where the user is now)
            //second digit: ending column (where the user is now)
            //third digit: which direction the user is facing
                //0 - north
                //1 - east
                //2 - south
                //3 - west
            List<int []> possiblePaths = new List<int[]> ();

            //find where user can start
            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    if (CharacterMatch(module.Maze[row, col], newPath[0]))
                    {
                        //Pick a direction and continue to head in that direction for as many steps the user took
                        //and verify that all steps are corret

                        //North
                        if (NorthValid(newPath, row, col))
                        {
                            possiblePaths.Add(new int[3] { (row - (newPath.Length - 1)) % 8, col , 0 });
                        }

                        //East
                        if (EastValid(newPath, row, col))
                        { 
                            possiblePaths.Add(new int[3] {row, (col + (newPath.Length - 1)) % 8, 1 });
                        }

                        //South
                        if (SouthValid(newPath, row, col))
                        {
                            possiblePaths.Add(new int[3] { (row + (newPath.Length - 1)) % 8, col, 2 });
                        }

                        //West
                        if (WestValid(newPath, row, col))
                        {
                            possiblePaths.Add(new int[3] { row, (col - (newPath.Length - 1)) % 8, 1 });
                        }

                    }

                    else
                    {
                        continue;
                    }
                }
            }


            //print all possilbe locations
            PrintDebugLine("Possible locations:");

            foreach (int[] possibleLocation in possiblePaths)
            {
                string direction = "";

                switch (possibleLocation[2])
                {
                    case 0:
                        direction = "North";
                        break;
                    case 1:
                        direction = "East";
                        break;
                    case 2:
                        direction = "South";
                        break;
                    case 3:
                        direction = "West";
                        break;
                }

                PrintDebugLine($"Location [{possibleLocation[0]},{possibleLocation[1]}] Direction: {direction}");
            }


            //if one path can't be found, then path user gave was invalid
            return possiblePaths.Count == 1;
        }


        /// <summary>
        /// Tells if node has the targeted caracter 
        /// </summary>
        /// <param name="node"></param>
        /// <param name="target"></param>
        /// <returns>true if there is a match</returns>
        private bool CharacterMatch(_3DMaze.Node node, char target)
        {
            //if target is cardinal, return true if node is blank or has a cardinal
            if (target == '*' && node.Character == '.')
            {
                return true;
            }

            return node.Character == target;
        }

        /// <summary>
        /// Tells if the user possibly went north
        /// </summary>
        /// <param name="path">the path the user went on</param>
        /// <param name="startingRow">the possible row the user started in</param>
        /// <param name="col">the possible column the user started in</param>
        /// <returns>true if this is a valid position of where the user is</returns>
        private bool NorthValid(string path, int startingRow, int col)
        { 

            for (int i = 1; i < path.Length; i++)
            {
                //check if ther is a wall between the spaces
                if (module.Maze[startingRow - (i - 1), col].North == null)
                {
                    return false;
                }

                //check to see if next pair of characters match
                if(!CharacterMatch(module.Maze[startingRow - i, col], path[i]))
                {
                    return false;
                }
            }

            return true;
        }

        private bool SouthValid(string path, int startingRow, int col)
        {

            for (int i = 1; i < path.Length; i++)
            {
                //check if ther is a wall between the spaces
                if (module.Maze[startingRow + (i - 1), col].South == null)
                {
                    return false;
                }

                //check to see if next pair of characters match
                if (!CharacterMatch(module.Maze[startingRow + i, col], path[i]))
                {
                    return false;
                }
            }

            return true;
        }

        private bool EastValid(string path, int startingRow, int col)
        {
            for (int i = 1; i < path.Length; i++)
            {
                //check if ther is a wall between the spaces
                if (module.Maze[startingRow, col + (i - 1)].East == null)
                {
                    return false;
                }

                //check to see if next pair of characters match
                if (!CharacterMatch(module.Maze[startingRow, col + i], path[i]))
                {
                    return false;
                }
            }

            return true;
        }

        private bool WestValid(string path, int startingRow, int col)
        {
            for (int i = 1; i < path.Length; i++)
            {
                //check if ther is a wall between the spaces
                if (module.Maze[startingRow, col - (i - 1)].West == null)
                {
                    return false;
                }

                //check to see if next pair of characters match
                if (!CharacterMatch(module.Maze[startingRow, col - i], path[i]))
                {
                    return false;
                }
            }

            return true;
        }

    }
}
