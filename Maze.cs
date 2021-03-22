using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace KTANE_Solver
{
    //Author: Nya Bentley
    //Date: 3/5/21
    //Purpose: Solves the Maze module
    class Maze
    {
        //==============FIELDS==============

        //used to write to the log file
        private StreamWriter logFileWriter;

        //the maze itself
        private String[,] maze;

        //the player coordinates
        private int playerRow;
        private int playerColumn;

        //the goal coordiantes
        private int goalRow;
        private int goalColumn;

        //the marker coordiantes
        private int markerRow;
        private int markerColumn;

        //a list to hold the directions the player
        //has to go
        private List<String> directionList;

        //tells if the player is at the goal
        private bool goal;

        //==============PROPERTIES==============

        //==============CONSTRUCTORS==============
        public Maze(int playerRow, int playerColumn, int goalRow, int goalColumn, int markerRow, int markerColumn, StreamWriter logFileWriter)
        {
            this.logFileWriter = logFileWriter;

            //sets up the coordiantes
            this.playerRow = playerRow;
            this.playerColumn = playerColumn;


            this.goalRow = goalRow;
            this.goalColumn = goalColumn;


            this.markerRow = markerRow;
            this.markerColumn = markerColumn;

            //sets up the module
            SetUpModule();

            
        }
        //==============METHODS==============


        /// <summary>
        /// Sets up the module so the maze
        /// is set and the coordiantes are
        /// converted
        /// </summary>
        public void SetUpModule()
        {
            //sets up a base of the maze

            // ! - represents a wall
            // ? - represents an available space
            // . - represents a passage

            maze = new String[,]
                {
                        {"!","!","!","!","!","!","!","!","!","!","!","!","!"},
                        {"!","?",".","?",".","?",".","?",".","?",".","?","!"},
                        {"!",".",".",".",".",".",".",".",".",".",".",".","!"},
                        {"!","?",".","?",".","?",".","?",".","?",".","?","!"},
                        {"!",".",".",".",".",".",".",".",".",".",".",".","!"},
                        {"!","?",".","?",".","?",".","?",".","?",".","?","!"},
                        {"!",".",".",".",".",".",".",".",".",".",".",".","!"},
                        {"!","?",".","?",".","?",".","?",".","?",".","?","!"},
                        {"!",".",".",".",".",".",".",".",".",".",".",".","!"},
                        {"!","?",".","?",".","?",".","?",".","?",".","?","!"},
                        {"!",".",".",".",".",".",".",".",".",".",".",".","!"},
                        {"!","?",".","?",".","?",".","?",".","?",".","?","!"},
                        {"!","!","!","!","!","!","!","!","!","!","!","!","!"}
                };

            //sets up the rest of the maze
            if ((markerRow == 2 && markerColumn == 1) || (markerRow == 3 && markerColumn == 6))
            {
                maze[1, 6] = "!";

                maze[2, 2] = "!";
                maze[2, 3] = "!";
                maze[2, 4] = "!";
                maze[2, 6] = "!";
                maze[1, 6] = "!";
                maze[2, 8] = "!";
                maze[2, 9] = "!";
                maze[2, 10] = "!";
                maze[2, 11] = "!";

                maze[3, 2] = "!";
                maze[3, 6] = "!";

                maze[4, 2] = "!";
                maze[4, 4] = "!";
                maze[4, 5] = "!";
                maze[4, 6] = "!";
                maze[4, 7] = "!";
                maze[4, 8] = "!";
                maze[4, 9] = "!";
                maze[4, 10] = "!";

                maze[5, 2] = "!";
                maze[5, 6] = "!";

                maze[6, 2] = "!";
                maze[6, 3] = "!";
                maze[6, 4] = "!";
                maze[6, 6] = "!";
                maze[6, 8] = "!";
                maze[6, 9] = "!";
                maze[6, 10] = "!";

                maze[7, 2] = "!";
                maze[7, 8] = "!";

                maze[8, 2] = "!";
                maze[8, 3] = "!";
                maze[8, 4] = "!";
                maze[8, 5] = "!";
                maze[8, 6] = "!";
                maze[8, 7] = "!";
                maze[8, 8] = "!";
                maze[8, 9] = "!";
                maze[8, 10] = "!";
                maze[9, 6] = "!";
                maze[9, 10] = "!";

                maze[10, 2] = "!";
                maze[10, 3] = "!";
                maze[10, 4] = "!";
                maze[10, 6] = "!";
                maze[10, 8] = "!";
                maze[10, 9] = "!";
                maze[10, 10] = "!";

                maze[11, 4] = "!";
                maze[11, 8] = "!";
            }

            else if ((markerRow == 2 && markerColumn == 5) || (markerRow == 4 && markerColumn == 2))
            {
                maze[1, 6] = "!";

                maze[2, 1] = "!";
                maze[2, 2] = "!";
                maze[2, 4] = "!";
                maze[2, 5] = "!";
                maze[2, 6] = "!";
                maze[2, 8] = "!";
                maze[2, 10] = "!";
                maze[2, 11] = "!";

                maze[3, 4] = "!";
                maze[3, 8] = "!";

                maze[4, 2] = "!";
                maze[4, 3] = "!";
                maze[4, 4] = "!";
                maze[4, 6] = "!";
                maze[4, 7] = "!";
                maze[4, 8] = "!";
                maze[4, 9] = "!";
                maze[4, 10] = "!";

                maze[5, 2] = "!";
                maze[5, 6] = "!";

                maze[6, 2] = "!";
                maze[6, 4] = "!";
                maze[6, 5] = "!";
                maze[6, 6] = "!";
                maze[6, 8] = "!";
                maze[6, 9] = "!";
                maze[6, 10] = "!";

                maze[7, 4] = "!";
                maze[7, 8] = "!";
                maze[7, 10] = "!";

                maze[8, 2] = "!";
                maze[8, 3] = "!";
                maze[8, 4] = "!";
                maze[8, 6] = "!";
                maze[8, 7] = "!";
                maze[8, 8] = "!";
                maze[8, 10] = "!";

                maze[9, 2] = "!";
                maze[9, 4] = "!";
                maze[9, 6] = "!";
                maze[9, 10] = "!";

                maze[10, 2] = "!";
                maze[10, 4] = "!";
                maze[10, 6] = "!";
                maze[10, 8] = "!";
                maze[10, 9] = "!";
                maze[10, 10] = "!";

                maze[11, 2] = "!";
                maze[11, 6] = "!";

            }

            else if ((markerRow == 4 && markerColumn == 4) || (markerRow == 4 && markerColumn == 6))
            {
                maze[1, 6] = "!";
                maze[1, 8] = "!";

                maze[2, 2] = "!";
                maze[2, 3] = "!";
                maze[2, 4] = "!";
                maze[2, 6] = "!";
                maze[2, 10] = "!";

                maze[3, 2] = "!";
                maze[3, 4] = "!";
                maze[3, 6] = "!";
                maze[3, 10] = "!";

                maze[4, 1] = "!";
                maze[4, 2] = "!";
                maze[4, 4] = "!";
                maze[4, 6] = "!";
                maze[4, 7] = "!";
                maze[4, 8] = "!";
                maze[4, 9] = "!";
                maze[4, 10] = "!";

                maze[5, 4] = "!";
                maze[5, 6] = "!";
                maze[5, 10] = "!";

                maze[6, 2] = "!";
                maze[6, 4] = "!";
                maze[6, 6] = "!";
                maze[6, 8] = "!";
                maze[6, 10] = "!";

                maze[7, 2] = "!";
                maze[7, 4] = "!";
                maze[7, 6] = "!";
                maze[7, 8] = "!";
                maze[7, 10] = "!";

                maze[8, 2] = "!";
                maze[8, 4] = "!";
                maze[8, 6] = "!";
                maze[8, 8] = "!";
                maze[8, 10] = "!";

                maze[9, 2] = "!";
                maze[9, 6] = "!";
                maze[9, 8] = "!";
                maze[9, 10] = "!";

                maze[10, 2] = "!";
                maze[10, 3] = "!";
                maze[10, 4] = "!";
                maze[10, 5] = "!";
                maze[10, 6] = "!";
                maze[10, 8] = "!";
                maze[10, 10] = "!";

                maze[11, 8] = "!";
            }

            else if ((markerRow == 1 && markerColumn == 1) || (markerRow == 4 && markerColumn == 1))
            {
                maze[1, 4] = "!";

                maze[2, 2] = "!";
                maze[2, 4] = "!";
                maze[2, 5] = "!";
                maze[2, 6] = "!";
                maze[2, 7] = "!";
                maze[2, 8] = "!";
                maze[2, 9] = "!";
                maze[2, 10] = "!";

                maze[3, 2] = "!";
                maze[3, 4] = "!";

                maze[4, 2] = "!";
                maze[4, 4] = "!";
                maze[4, 7] = "!";
                maze[4, 8] = "!";
                maze[4, 9] = "!";
                maze[4, 10] = "!";

                maze[5, 2] = "!";
                maze[5, 6] = "!";
                maze[5, 10] = "!";

                maze[6, 2] = "!";
                maze[6, 3] = "!";
                maze[6, 4] = "!";
                maze[6, 5] = "!";
                maze[6, 6] = "!";
                maze[6, 8] = "!";
                maze[6, 9] = "!";
                maze[6, 10] = "!";

                maze[7, 2] = "!";

                maze[8, 2] = "!";
                maze[8, 3] = "!";
                maze[8, 4] = "!";
                maze[8, 5] = "!";
                maze[8, 6] = "!";
                maze[8, 7] = "!";
                maze[8, 8] = "!";
                maze[8, 9] = "!";
                maze[8, 10] = "!";

                maze[9, 10] = "!";

                maze[10, 2] = "!";
                maze[10, 3] = "!";
                maze[10, 4] = "!";
                maze[10, 5] = "!";
                maze[10, 6] = "!";
                maze[10, 7] = "!";
                maze[10, 8] = "!";
                maze[10, 10] = "!";

                maze[11, 6] = "!";
                maze[11, 10] = "!";
            }

            else if ((markerRow == 3 && markerColumn == 5) || (markerRow == 6 && markerColumn == 4))
            {
                maze[2, 1] = "!";
                maze[2, 2] = "!";
                maze[2, 3] = "!";
                maze[2, 4] = "!";
                maze[2, 5] = "!";
                maze[2, 6] = "!";
                maze[2, 7] = "!";
                maze[2, 8] = "!";
                maze[2, 10] = "!";
                maze[3, 10] = "!";
                maze[4, 2] = "!";
                maze[4, 3] = "!";
                maze[4, 4] = "!";
                maze[4, 5] = "!";
                maze[4, 6] = "!";
                maze[4, 8] = "!";
                maze[4, 9] = "!";
                maze[4, 10] = "!";
                maze[4, 11] = "!";

                maze[5, 4] = "!";
                maze[5, 8] = "!";

                maze[6, 2] = "!";
                maze[6, 4] = "!";
                maze[6, 5] = "!";
                maze[6, 6] = "!";
                maze[6, 7] = "!";
                maze[6, 8] = "!";
                maze[6, 10] = "!";

                maze[7, 2] = "!";
                maze[7, 8] = "!";
                maze[7, 10] = "!";

                maze[8, 2] = "!";
                maze[8, 3] = "!";
                maze[8, 4] = "!";
                maze[8, 5] = "!";
                maze[8, 6] = "!";
                maze[8, 8] = "!";
                maze[8, 9] = "!";
                maze[8, 10] = "!";

                maze[9, 2] = "!";
                maze[9, 10] = "!";

                maze[10, 2] = "!";
                maze[10, 4] = "!";
                maze[10, 5] = "!";
                maze[10, 6] = "!";
                maze[10, 7] = "!";
                maze[10, 8] = "!";
                maze[10, 9] = "!";
                maze[10, 10] = "!";

                maze[11, 2] = "!";
            }

            else if ((markerRow == 1 && markerColumn == 5) || (markerRow == 5 && markerColumn == 3))
            {
                maze[1, 2] = "!";
                maze[1, 6] = "!";

                maze[2, 2] = "!";
                maze[2, 4] = "!";
                maze[2, 6] = "!";
                maze[2, 7] = "!";
                maze[2, 8] = "!";
                maze[2, 10] = "!";

                maze[3, 2] = "!";
                maze[3, 4] = "!";
                maze[3, 6] = "!";
                maze[3, 10] = "!";

                maze[4, 2] = "!";
                maze[4, 4] = "!";
                maze[4, 6] = "!";
                maze[4, 8] = "!";
                maze[4, 9] = "!";
                maze[4, 10] = "!";

                maze[5, 4] = "!";
                maze[5, 6] = "!";
                maze[5, 8] = "!";

                maze[6, 2] = "!";
                maze[6, 3] = "!";
                maze[6, 4] = "!";
                maze[6, 5] = "!";
                maze[6, 6] = "!";
                maze[6, 8] = "!";
                maze[6, 10] = "!";
                maze[6, 11] = "!";

                maze[7, 4] = "!";
                maze[7, 8] = "!";
                maze[7, 10] = "!";

                maze[8, 1] = "!";
                maze[8, 2] = "!";
                maze[8, 4] = "!";
                maze[8, 6] = "!";
                maze[8, 8] = "!";
                maze[8, 10] = "!";

                maze[9, 4] = "!";
                maze[9, 6] = "!";
                maze[9, 8] = "!";


                maze[10, 2] = "!";
                maze[10, 3] = "!";
                maze[10, 4] = "!";
                maze[10, 5] = "!";
                maze[10, 6] = "!";
                maze[10, 8] = "!";
                maze[10, 9] = "!";
                maze[10, 10] = "!";

                maze[11, 8] = "!";
            }

            else if ((markerRow == 1 && markerColumn == 2) || (markerRow == 6 && markerColumn == 2))
            {
                maze[1, 8] = "!";

                maze[2, 2] = "!";
                maze[2, 3] = "!";
                maze[2, 4] = "!";
                maze[2, 5] = "!";
                maze[2, 6] = "!";
                maze[2, 8] = "!";
                maze[2, 10] = "!";

                maze[3, 2] = "!";
                maze[3, 6] = "!";
                maze[3, 10] = "!";

                maze[4, 2] = "!";
                maze[4, 4] = "!";
                maze[4, 5] = "!";
                maze[4, 7] = "!";
                maze[4, 8] = "!";
                maze[4, 9] = "!";
                maze[4, 10] = "!";

                maze[5, 4] = "!";
                maze[5, 8] = "!";

                maze[6, 1] = "!";
                maze[6, 2] = "!";
                maze[6, 3] = "!";
                maze[6, 4] = "!";
                maze[6, 6] = "!";
                maze[6, 7] = "!";
                maze[6, 8] = "!";
                maze[6, 10] = "!";
                maze[6, 11] = "!";

                maze[7, 4] = "!";
                maze[7, 10] = "!";

                maze[8, 2] = "!";
                maze[8, 4] = "!";
                maze[8, 6] = "!";
                maze[8, 7] = "!";
                maze[8, 8] = "!";
                maze[8, 9] = "!";
                maze[8, 10] = "!";

                maze[9, 2] = "!";
                maze[9, 4] = "!";
                maze[9, 10] = "!";

                maze[10, 2] = "!";
                maze[10, 3] = "!";
                maze[10, 4] = "!";
                maze[10, 5] = "!";
                maze[10, 6] = "!";
                maze[10, 7] = "!";
                maze[10, 8] = "!";
                maze[10, 10] = "!";
            }

            else if ((markerRow == 1 && markerColumn == 4) || (markerRow == 4 && markerColumn == 3))
            {
                maze[1, 2] = "!";
                maze[1, 8] = "!";

                maze[2, 2] = "!";
                maze[2, 4] = "!";
                maze[2, 5] = "!";
                maze[2, 6] = "!";
                maze[2, 8] = "!";
                maze[2, 10] = "!";

                maze[3, 6] = "!";
                maze[3, 10] = "!";

                maze[4, 2] = "!";
                maze[4, 3] = "!";
                maze[4, 4] = "!";
                maze[4, 5] = "!";
                maze[4, 6] = "!";
                maze[4, 7] = "!";
                maze[4, 8] = "!";
                maze[4, 9] = "!";
                maze[4, 10] = "!";

                maze[5, 2] = "!";
                maze[5, 10] = "!";

                maze[6, 2] = "!";
                maze[6, 4] = "!";
                maze[6, 5] = "!";
                maze[6, 6] = "!";
                maze[6, 7] = "!";
                maze[6, 8] = "!";
                maze[6, 10] = "!";

                maze[7, 2] = "!";
                maze[7, 6] = "!";

                maze[8, 2] = "!";
                maze[8, 3] = "!";
                maze[8, 4] = "!";
                maze[8, 6] = "!";
                maze[8, 7] = "!";
                maze[8, 8] = "!";
                maze[8, 9] = "!";
                maze[8, 10] = "!";
                maze[8, 11] = "!";

                maze[9, 2] = "!";
                maze[9, 4] = "!";

                maze[10, 2] = "!";
                maze[10, 4] = "!";
                maze[10, 5] = "!";
                maze[10, 6] = "!";
                maze[10, 7] = "!";
                maze[10, 8] = "!";
                maze[10, 9] = "!";
                maze[10, 10] = "!";
                maze[10, 11] = "!";
            }

            else if ((markerRow == 2 && markerColumn == 3) || (markerRow == 5 && markerColumn == 1))
            {
                maze[1, 2] = "!";

                maze[2, 2] = "!";
                maze[2, 4] = "!";
                maze[2, 5] = "!";
                maze[2, 6] = "!";
                maze[2, 2] = "!";
                maze[2, 7] = "!";
                maze[2, 8] = "!";
                maze[2, 10] = "!";

                maze[3, 2] = "!";
                maze[3, 4] = "!";
                maze[3, 8] = "!";
                maze[3, 10] = "!";

                maze[4, 2] = "!";
                maze[4, 4] = "!";
                maze[4, 6] = "!";
                maze[4, 7] = "!";
                maze[4, 8] = "!";
                maze[4, 10] = "!";

                maze[5, 6] = "!";
                maze[5, 10] = "!";

                maze[6, 2] = "!";
                maze[6, 3] = "!";
                maze[6, 4] = "!";
                maze[6, 5] = "!";
                maze[6, 6] = "!";
                maze[6, 8] = "!";
                maze[6, 9] = "!";
                maze[6, 10] = "!";

                maze[7, 2] = "!";
                maze[7, 4] = "!";
                maze[7, 8] = "!";

                maze[8, 2] = "!";
                maze[8, 4] = "!";
                maze[8, 6] = "!";
                maze[8, 7] = "!";
                maze[8, 8] = "!";
                maze[8, 9] = "!";
                maze[8, 10] = "!";

                maze[9, 2] = "!";
                maze[9, 4] = "!";
                maze[9, 6] = "!";
                maze[9, 10] = "!";

                maze[10, 2] = "!";
                maze[10, 4] = "!";
                maze[10, 6] = "!";
                maze[10, 8] = "!";
                maze[10, 10] = "!";
                maze[10, 11] = "!";

                maze[11, 4] = "!";
                maze[11, 8] = "!";
            }

            //converts the player and goal coordinates
            //so it fits on the program's maze
            playerRow = ConvertCoordinate(playerRow);
            playerColumn = ConvertCoordinate(playerColumn);

            goalRow = ConvertCoordinate(goalRow);
            goalColumn = ConvertCoordinate(goalColumn);

            directionList = new List<string>();
        }


        /// <summary>
        /// Shows a list of directions
        /// in a message box
        /// </summary>
        public void Solve()
        {
            logFileWriter.WriteLine("======================MAZE======================");

            logFileWriter.WriteLine($"Player: ({playerRow},{playerColumn})\n");
            logFileWriter.WriteLine($"Goal: ({goalRow},{goalColumn})\n");
            logFileWriter.WriteLine($"Marker: ({markerRow},{markerColumn})\n");

            //if the player finds the goal

            if (MoveNorth() || MoveEast() || MoveSouth() || MoveWest())
            {
                //simplifly the directions and show them
                directionList = SimplifyDirections();

                String caption = "Maze Answer";
                String text = "";

                for (int i = 0; i < directionList.Count; i++)
                {
                    if (i == directionList.Count() - 1)
                    {
                        text += directionList[i];
                    }
                    else
                    { 
                        text += directionList[i] + ", ";
                    }
                }

                MessageBox.Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            //otherwise tell them this module is unsolvable
            //and show the coordinates
            else
            {
                String caption = "Maze Answer Error";
                String text = "There was an error finding the answer. Show developer this message: \n" + 
                              $"Player (row, column): {playerRow},{playerColumn} \n" +
                              $"Goal (row, column): {goalRow},{goalColumn} \n" +
                              $"Marker (row, column): {markerRow},{markerColumn}";

                MessageBox.Show(caption, text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Simplfies the direction list so it's
        /// easier to read
        /// </summary>
        private List<String> SimplifyDirections()
        {
            List<String> finalDirections = new List<String>();

            while (directionList.Count != 0)
            {
                int counter = 0;
                String word = directionList[0];

                while (directionList.Count != 0 && word == directionList[0])
                {
                    counter++;
                    directionList.RemoveAt(0);
                }
                finalDirections.Add(word + " x" + counter);
            }
            return finalDirections;
        }

        /// <summary>
        /// Converts the cooridnate so they fit on the
        /// program's maze
        /// </summary>
        /// <param name="coordinate">the coodiante that will be converted</param>
        /// <returns>the new coordiante</returns>
        private int ConvertCoordinate(int coordinate)
        {
            switch (coordinate)
            {
                case 2:
                    coordinate = 3;
                    break;
                case 3:
                    coordinate = 5;
                    break;
                case 4:
                    coordinate = 7;
                    break;
                case 5:
                    coordinate = 9;
                    break;
                case 6:
                    coordinate = 11;
                    break;
            }

            return coordinate;
        }

        /// <summary>
        /// Moves up if that's possible
        /// </summary>
        /// <returns>true if that's the right way to the goal</returns>
        private bool MoveNorth()
        {
            //if there is a path and an available space going up, and the last direction went wasn't down, go up
            if (playerRow > 2 && maze[playerRow - 1, playerColumn] != "!" && maze[playerRow - 2, playerColumn] == "?"
                && (directionList.Count == 0 || directionList[directionList.Count - 1] != "DOWN"))
            {

                playerRow -= 2;
                logFileWriter.WriteLine($"Moving up. Player is now at ({playerRow},{playerColumn})\n");
                directionList.Add("UP");


                //if he player is at the goal,
                //set goal as true
                if (AtGoal())
                {
                    goal = true;
                }

                //otherwise, follow the direction hierarchy
                else
                {
                    goal = MoveNorth();

                    //if movig up doesn't work, move right
                    if (!goal)
                    {
                        goal = MoveEast();

                        //if moving right doesn't work, move down
                        if (!goal)
                        {
                            goal = MoveSouth();
                        }

                        //if moving down doesn't work, move left
                        if (!goal)
                        {
                            goal = MoveWest();

                            //if moving left doesn't work, mark this position as 
                            //unavailable and move back down
                            if (!goal)
                            {
                                maze[playerRow, playerColumn] = "X";
                                playerRow += 2;
                                directionList.RemoveAt(directionList.Count - 1);

                                logFileWriter.WriteLine($"Not the right way to go. Backtracking to ({playerRow},{playerColumn})\n");
                            }
                        }

                    }

                }
            }

            //otherwise, set goal as false
            else
            {
                goal = false;
            }

            return goal;
        }
        /// <summary>
        /// Moves right if that's possible
        /// </summary>
        /// <returns>true if that's the right way to the goal</returns>
        private bool MoveEast()
        {
            //if there is a path and an available space going right, and the last direction went wasn't left, go right
            if (playerColumn < 10 && maze[playerRow, playerColumn + 1] != "!" && maze[playerRow, playerColumn + 2] == "?" 
                && (directionList.Count == 0 || directionList[directionList.Count - 1] != "LEFT"))
            {
                playerColumn += 2;
                directionList.Add("RIGHT");
                logFileWriter.WriteLine($"Moving right. Player is now at ({playerRow},{playerColumn})\n");



                //if he player is at the goal,
                //set goal as true
                if (AtGoal())
                {
                    goal = true;
                }

                //otherwise, follow the direction hierarchy
                else
                {
                    goal = MoveEast();

                    //if movig right doesn't work, move down
                    if (!goal)
                    {
                        goal = MoveSouth();

                        //if movig down doesn't work, move left
                        if (!goal)
                        {
                            goal = MoveWest();

                            //if movig left doesn't work, move up
                            if (!goal)
                            {
                                goal = MoveNorth();

                                //if moving up doesn't work, mark this position as 
                                //unavailable and move back left
                                if (!goal)
                                {
                                    maze[playerRow, playerColumn] = "X";
                                    playerColumn -= 2;
                                    directionList.RemoveAt(directionList.Count - 1);
                                    logFileWriter.WriteLine($"Not the right way to go. Backtracking to ({playerRow},{playerColumn})\n");
                                }
                            }
                        }
                    }
                }
            }

            else
            {
                goal = false;
            }

            return goal;

        }

        /// <summary>
        /// Moves down if that's possible
        /// </summary>
        /// <returns>true if that's the right way to the goal</returns>
        private bool MoveSouth()

        {
            //if there is a path and an available space going down, and the last direction went wasn't up, go down
            if (playerRow < 10 && maze[playerRow + 1, playerColumn] != "!" && maze[playerRow + 2, playerColumn] == "?"
                && (directionList.Count == 0 || directionList[directionList.Count - 1] != "UP"))
            {
                directionList.Add("DOWN");

                playerRow += 2;
                logFileWriter.WriteLine($"Moving down. Player is now at ({playerRow},{playerColumn})\n");


                //if the player is at the goal,
                //set goal as true
                if (AtGoal())
                {
                    goal = true;
                }

                //otherwise, follow the direction hierarchy
                else
                {
                    goal = MoveSouth();

                    //if moving down doesn't work, move left
                    if (!goal)
                    {
                        goal = MoveWest();

                        //if moving left doesn't work, move up
                        if (!goal)
                        {
                            goal = MoveNorth();
                        }

                        //if moving up doesn't work, move right
                        if (!goal)
                        {
                            goal = MoveEast();

                            //if moving right doesn't work, mark this position as 
                            //unavailable and move back up
                            if (!goal)
                            {
                                maze[playerRow, playerColumn] = "X";
                                playerRow -= 2;
                                directionList.RemoveAt(directionList.Count - 1);
                                logFileWriter.WriteLine($"Not the right way to go. Backtracking to ({playerRow},{playerColumn})\n");
                            }
                        }

                    }

                }
            }

            //otherwise, set goal as false
            else
            {
                goal = false;
            }

            return goal;
        }

        /// <summary>
        /// Moves left if that's possible
        /// </summary>
        /// <returns>true if that's the right way to the goal</returns>
        private bool MoveWest()

        {
            //if there is a path and an available space going left, and the last direction went wasn't right, go left
            if (playerColumn > 2 && maze[playerRow, playerColumn - 1] != "!" && maze[playerRow, playerColumn - 2] == "?" && 
               (directionList.Count == 0 || directionList[directionList.Count - 1] != "RIGHT"))
            {
                playerColumn -= 2;
                directionList.Add("LEFT");
                logFileWriter.WriteLine($"Moving left. Player is now at ({playerRow},{playerColumn})\n");



                //if he player is at the goal,
                //set goal as true
                if (AtGoal())
                {
                    goal = true;
                }

                //otherwise, follow the direction hierarchy
                else
                {
                    goal = MoveWest();

                    //if movig left doesn't work, move up
                    if (!goal)
                    {
                        goal = MoveNorth();

                        //if moving up doesn't work, move right
                        if (!goal)
                        {
                            goal = MoveEast();

                            //if movig right doesn't work, move down
                            if (!goal)
                            {
                                goal = MoveSouth();

                                //if moving down doesn't work, mark this position as 
                                //unavailable and move back right
                                if (!goal)
                                {
                                    maze[playerRow, playerColumn] = "X";
                                    playerColumn += 2;
                                    directionList.RemoveAt(directionList.Count - 1);
                                    logFileWriter.WriteLine($"Not the right way to go. Backtracking to ({playerRow},{playerColumn})\n");
                                }
                            }
                        }
                    }
                }
            }

            else
            {
                goal = false;
            }

            return goal;
        }

        /// <summary>
        /// Tells if the player is
        /// at the goal
        /// </summary>
        /// <returns>true if the player and the goal
        ///           coordiantes are equal</returns>
        private bool AtGoal()
        {
            return playerRow == goalRow && playerColumn == goalColumn;
        }
    }
}
