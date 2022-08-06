using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace KTANE_Solver
{


    /// <summary>
    /// Author: Nya Bentley
    /// Date: 3/5/21
    /// Purpose: Solves the Maze module
    /// </summary>
    public class Maze : Module
    {
        //==============FIELDS==============

        private List<Coordinate> visitedNodes;


        //the maze itself
        private Node[,] maze;

        //the player coordinates
        private int playerRow;
        private int playerColumn;
        private int startingPlayerRow;
        private int startingPlayerColumn;


        //the goal coordiantes
        private int goalRow;
        private int goalColumn;
        private int startingGoalRow;
        private int startingGoalColumn;
        
        //the marker coordiantes
        private int markerRow;
        private int markerColumn;

        private int mazeIndex;

        //a list to hold the directions the player
        //has to go
        private List<String> directionList;

        //tells if the player is at the goal
        private bool goal;

        //==============PROPERTIES==============

        //==============CONSTRUCTORS==============
        public Maze(int playerRow, int playerColumn, int goalRow, int goalColumn, int markerRow, int markerColumn, StreamWriter LogFileWriter) : base(null, LogFileWriter, "Maze")
        {
            visitedNodes = new List<Coordinate>();
            //sets up the coordiantes
            startingPlayerRow = playerRow;
            startingPlayerColumn = playerColumn;

            startingGoalRow = goalRow;
            startingGoalColumn = goalColumn;

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

            //sets up the rest of the maze

            maze = new Node[6,6];
            if ((markerRow == 2 && markerColumn == 1) || (markerRow == 3 && markerColumn == 6))
            {
                mazeIndex = 1;
                maze[0, 0] = new Node(Walls.NorthWest);
                maze[0, 1] = new Node(Walls.Vertical);
                maze[0, 2] = new Node(Walls.Vertical);
                maze[0, 3] = new Node(Walls.Vertical);
                maze[0, 4] = new Node(Walls.West);
                maze[0, 5] = new Node(Walls.SouthWest);

                maze[1, 0] = new Node(Walls.Horizontal);
                maze[1, 1] = new Node(Walls.NorthWest);
                maze[1, 2] = new Node(Walls.SouthWest);
                maze[1, 3] = new Node(Walls.WestU);
                maze[1, 4] = new Node(Walls.Horizontal);
                maze[1, 5] = new Node(Walls.EastU);

                maze[2, 0] = new Node(Walls.NorthEast);
                maze[2, 1] = new Node(Walls.SouthEast);
                maze[2, 2] = new Node(Walls.NorthEast);
                maze[2, 3] = new Node(Walls.South);
                maze[2, 4] = new Node(Walls.NorthEast);
                maze[2, 5] = new Node(Walls.SouthWest);

                maze[3, 0] = new Node(Walls.NorthWest);
                maze[3, 1] = new Node(Walls.SouthWest);
                maze[3, 2] = new Node(Walls.NorthWest);
                maze[3, 3] = new Node(Walls.SouthEast);
                maze[3, 4] = new Node(Walls.NorthWest);
                maze[3, 5] = new Node(Walls.SouthEast);

                maze[4, 0] = new Node(Walls.Horizontal);
                maze[4, 1] = new Node(Walls.Horizontal);
                maze[4, 2] = new Node(Walls.Horizontal);
                maze[4, 3] = new Node(Walls.WestU);
                maze[4, 4] = new Node(Walls.EastU);
                maze[4, 5] = new Node(Walls.WestU);

                maze[5, 0] = new Node(Walls.Horizontal);
                maze[5, 1] = new Node(Walls.NorthEast);
                maze[5, 2] = new Node(Walls.East);
                maze[5, 3] = new Node(Walls.East);
                maze[5, 4] = new Node(Walls.Vertical);
                maze[5, 5] = new Node(Walls.SouthEast);
            }

            else if ((markerRow == 2 && markerColumn == 5) || (markerRow == 4 && markerColumn == 2))
            {
                mazeIndex = 2;

                maze[0, 0] = new Node(Walls.WestU);
                maze[0, 1] = new Node(Walls.NorthWest);
                maze[0, 2] = new Node(Walls.Vertical);
                maze[0, 3] = new Node(Walls.West);
                maze[0, 4] = new Node(Walls.Vertical);
                maze[0, 5] = new Node(Walls.SouthU);

                maze[1, 0] = new Node(Walls.North);
                maze[1, 1] = new Node(Walls.SouthEast);
                maze[1, 2] = new Node(Walls.NorthWest);
                maze[1, 3] = new Node(Walls.SouthEast);
                maze[1, 4] = new Node(Walls.NorthU);
                maze[1, 5] = new Node(Walls.SouthWest);

                maze[2, 0] = new Node(Walls.EastU);
                maze[2, 1] = new Node(Walls.NorthWest);
                maze[2, 2] = new Node(Walls.SouthEast);
                maze[2, 3] = new Node(Walls.NorthWest);
                maze[2, 4] = new Node(Walls.Vertical);
                maze[2, 5] = new Node(Walls.SouthEast);

                maze[3, 0] = new Node(Walls.NorthWest);
                maze[3, 1] = new Node(Walls.SouthEast);
                maze[3, 2] = new Node(Walls.NorthWest);
                maze[3, 3] = new Node(Walls.SouthEast);
                maze[3, 4] = new Node(Walls.NorthWest);
                maze[3, 5] = new Node(Walls.SouthWest);

                maze[4, 0] = new Node(Walls.North);
                maze[4, 1] = new Node(Walls.SouthWest);
                maze[4, 2] = new Node(Walls.Horizontal);
                maze[4, 3] = new Node(Walls.NorthU);
                maze[4, 4] = new Node(Walls.SouthEast);
                maze[4, 5] = new Node(Walls.Horizontal);

                maze[5, 0] = new Node(Walls.EastU);
                maze[5, 1] = new Node(Walls.NorthEast);
                maze[5, 2] = new Node(Walls.East);
                maze[5, 3] = new Node(Walls.Vertical);
                maze[5, 4] = new Node(Walls.Vertical);
                maze[5, 5] = new Node(Walls.SouthEast);
            }

            else if ((markerRow == 4 && markerColumn == 4) || (markerRow == 4 && markerColumn == 6))
            {
                mazeIndex = 3;

                maze[0, 0] = new Node(Walls.NorthWest);
                maze[0, 1] = new Node(Walls.SouthU);
                maze[0, 2] = new Node(Walls.NorthWest);
                maze[0, 3] = new Node(Walls.Vertical);
                maze[0, 4] = new Node(Walls.Vertical);
                maze[0, 5] = new Node(Walls.SouthWest);

                maze[1, 0] = new Node(Walls.);
                maze[1, 1] = new Node(Walls.);
                maze[1, 2] = new Node(Walls.);
                maze[1, 3] = new Node(Walls.);
                maze[1, 4] = new Node(Walls.);
                maze[1, 5] = new Node(Walls.);

                maze[2, 0] = new Node(Walls.);
                maze[2, 1] = new Node(Walls.);
                maze[2, 2] = new Node(Walls.);
                maze[2, 3] = new Node(Walls.);
                maze[2, 4] = new Node(Walls.);
                maze[2, 5] = new Node(Walls.);

                maze[3, 0] = new Node(Walls.);
                maze[3, 1] = new Node(Walls.);
                maze[3, 2] = new Node(Walls.);
                maze[3, 3] = new Node(Walls.);
                maze[3, 4] = new Node(Walls.);
                maze[3, 5] = new Node(Walls.);

                maze[4, 0] = new Node(Walls.);
                maze[4, 1] = new Node(Walls.);
                maze[4, 2] = new Node(Walls.);
                maze[4, 3] = new Node(Walls.);
                maze[4, 4] = new Node(Walls.);
                maze[4, 5] = new Node(Walls.);

                maze[5, 0] = new Node(Walls.);
                maze[5, 1] = new Node(Walls.);
                maze[5, 2] = new Node(Walls.);
                maze[5, 3] = new Node(Walls.);
                maze[5, 4] = new Node(Walls.);
                maze[5, 5] = new Node(Walls.);
            }

            else if ((markerRow == 1 && markerColumn == 1) || (markerRow == 4 && markerColumn == 1))
            {
                mazeIndex = 4;

                maze[0, 0] = new Node(Walls.);
                maze[0, 1] = new Node(Walls.);
                maze[0, 2] = new Node(Walls.);
                maze[0, 3] = new Node(Walls.);
                maze[0, 4] = new Node(Walls.);
                maze[0, 5] = new Node(Walls.);

                maze[1, 0] = new Node(Walls.);
                maze[1, 1] = new Node(Walls.);
                maze[1, 2] = new Node(Walls.);
                maze[1, 3] = new Node(Walls.);
                maze[1, 4] = new Node(Walls.);
                maze[1, 5] = new Node(Walls.);

                maze[2, 0] = new Node(Walls.);
                maze[2, 1] = new Node(Walls.);
                maze[2, 2] = new Node(Walls.);
                maze[2, 3] = new Node(Walls.);
                maze[2, 4] = new Node(Walls.);
                maze[2, 5] = new Node(Walls.);

                maze[3, 0] = new Node(Walls.);
                maze[3, 1] = new Node(Walls.);
                maze[3, 2] = new Node(Walls.);
                maze[3, 3] = new Node(Walls.);
                maze[3, 4] = new Node(Walls.);
                maze[3, 5] = new Node(Walls.);

                maze[4, 0] = new Node(Walls.);
                maze[4, 1] = new Node(Walls.);
                maze[4, 2] = new Node(Walls.);
                maze[4, 3] = new Node(Walls.);
                maze[4, 4] = new Node(Walls.);
                maze[4, 5] = new Node(Walls.);

                maze[5, 0] = new Node(Walls.);
                maze[5, 1] = new Node(Walls.);
                maze[5, 2] = new Node(Walls.);
                maze[5, 3] = new Node(Walls.);
                maze[5, 4] = new Node(Walls.);
                maze[5, 5] = new Node(Walls.);
            }

            else if ((markerRow == 3 && markerColumn == 5) || (markerRow == 6 && markerColumn == 4))
            {
                mazeIndex = 5;

                maze[0, 0] = new Node(Walls.);
                maze[0, 1] = new Node(Walls.);
                maze[0, 2] = new Node(Walls.);
                maze[0, 3] = new Node(Walls.);
                maze[0, 4] = new Node(Walls.);
                maze[0, 5] = new Node(Walls.);

                maze[1, 0] = new Node(Walls.);
                maze[1, 1] = new Node(Walls.);
                maze[1, 2] = new Node(Walls.);
                maze[1, 3] = new Node(Walls.);
                maze[1, 4] = new Node(Walls.);
                maze[1, 5] = new Node(Walls.);

                maze[2, 0] = new Node(Walls.);
                maze[2, 1] = new Node(Walls.);
                maze[2, 2] = new Node(Walls.);
                maze[2, 3] = new Node(Walls.);
                maze[2, 4] = new Node(Walls.);
                maze[2, 5] = new Node(Walls.);

                maze[3, 0] = new Node(Walls.);
                maze[3, 1] = new Node(Walls.);
                maze[3, 2] = new Node(Walls.);
                maze[3, 3] = new Node(Walls.);
                maze[3, 4] = new Node(Walls.);
                maze[3, 5] = new Node(Walls.);

                maze[4, 0] = new Node(Walls.);
                maze[4, 1] = new Node(Walls.);
                maze[4, 2] = new Node(Walls.);
                maze[4, 3] = new Node(Walls.);
                maze[4, 4] = new Node(Walls.);
                maze[4, 5] = new Node(Walls.);

                maze[5, 0] = new Node(Walls.);
                maze[5, 1] = new Node(Walls.);
                maze[5, 2] = new Node(Walls.);
                maze[5, 3] = new Node(Walls.);
                maze[5, 4] = new Node(Walls.);
                maze[5, 5] = new Node(Walls.);
            }

            else if ((markerRow == 1 && markerColumn == 5) || (markerRow == 5 && markerColumn == 3))
            {
                mazeIndex = 6;

                maze[0, 0] = new Node(Walls.);
                maze[0, 1] = new Node(Walls.);
                maze[0, 2] = new Node(Walls.);
                maze[0, 3] = new Node(Walls.);
                maze[0, 4] = new Node(Walls.);
                maze[0, 5] = new Node(Walls.);

                maze[1, 0] = new Node(Walls.);
                maze[1, 1] = new Node(Walls.);
                maze[1, 2] = new Node(Walls.);
                maze[1, 3] = new Node(Walls.);
                maze[1, 4] = new Node(Walls.);
                maze[1, 5] = new Node(Walls.);

                maze[2, 0] = new Node(Walls.);
                maze[2, 1] = new Node(Walls.);
                maze[2, 2] = new Node(Walls.);
                maze[2, 3] = new Node(Walls.);
                maze[2, 4] = new Node(Walls.);
                maze[2, 5] = new Node(Walls.);

                maze[3, 0] = new Node(Walls.);
                maze[3, 1] = new Node(Walls.);
                maze[3, 2] = new Node(Walls.);
                maze[3, 3] = new Node(Walls.);
                maze[3, 4] = new Node(Walls.);
                maze[3, 5] = new Node(Walls.);

                maze[4, 0] = new Node(Walls.);
                maze[4, 1] = new Node(Walls.);
                maze[4, 2] = new Node(Walls.);
                maze[4, 3] = new Node(Walls.);
                maze[4, 4] = new Node(Walls.);
                maze[4, 5] = new Node(Walls.);

                maze[5, 0] = new Node(Walls.);
                maze[5, 1] = new Node(Walls.);
                maze[5, 2] = new Node(Walls.);
                maze[5, 3] = new Node(Walls.);
                maze[5, 4] = new Node(Walls.);
                maze[5, 5] = new Node(Walls.);
            }

            else if ((markerRow == 1 && markerColumn == 2) || (markerRow == 6 && markerColumn == 2))
            {
                mazeIndex = 7;

                maze[0, 0] = new Node(Walls.);
                maze[0, 1] = new Node(Walls.);
                maze[0, 2] = new Node(Walls.);
                maze[0, 3] = new Node(Walls.);
                maze[0, 4] = new Node(Walls.);
                maze[0, 5] = new Node(Walls.);

                maze[1, 0] = new Node(Walls.);
                maze[1, 1] = new Node(Walls.);
                maze[1, 2] = new Node(Walls.);
                maze[1, 3] = new Node(Walls.);
                maze[1, 4] = new Node(Walls.);
                maze[1, 5] = new Node(Walls.);

                maze[2, 0] = new Node(Walls.);
                maze[2, 1] = new Node(Walls.);
                maze[2, 2] = new Node(Walls.);
                maze[2, 3] = new Node(Walls.);
                maze[2, 4] = new Node(Walls.);
                maze[2, 5] = new Node(Walls.);

                maze[3, 0] = new Node(Walls.);
                maze[3, 1] = new Node(Walls.);
                maze[3, 2] = new Node(Walls.);
                maze[3, 3] = new Node(Walls.);
                maze[3, 4] = new Node(Walls.);
                maze[3, 5] = new Node(Walls.);

                maze[4, 0] = new Node(Walls.);
                maze[4, 1] = new Node(Walls.);
                maze[4, 2] = new Node(Walls.);
                maze[4, 3] = new Node(Walls.);
                maze[4, 4] = new Node(Walls.);
                maze[4, 5] = new Node(Walls.);

                maze[5, 0] = new Node(Walls.);
                maze[5, 1] = new Node(Walls.);
                maze[5, 2] = new Node(Walls.);
                maze[5, 3] = new Node(Walls.);
                maze[5, 4] = new Node(Walls.);
                maze[5, 5] = new Node(Walls.);
            }

            else if ((markerRow == 1 && markerColumn == 4) || (markerRow == 4 && markerColumn == 3))
            {
                mazeIndex = 8;

                maze[0, 0] = new Node(Walls.);
                maze[0, 1] = new Node(Walls.);
                maze[0, 2] = new Node(Walls.);
                maze[0, 3] = new Node(Walls.);
                maze[0, 4] = new Node(Walls.);
                maze[0, 5] = new Node(Walls.);

                maze[1, 0] = new Node(Walls.);
                maze[1, 1] = new Node(Walls.);
                maze[1, 2] = new Node(Walls.);
                maze[1, 3] = new Node(Walls.);
                maze[1, 4] = new Node(Walls.);
                maze[1, 5] = new Node(Walls.);

                maze[2, 0] = new Node(Walls.);
                maze[2, 1] = new Node(Walls.);
                maze[2, 2] = new Node(Walls.);
                maze[2, 3] = new Node(Walls.);
                maze[2, 4] = new Node(Walls.);
                maze[2, 5] = new Node(Walls.);

                maze[3, 0] = new Node(Walls.);
                maze[3, 1] = new Node(Walls.);
                maze[3, 2] = new Node(Walls.);
                maze[3, 3] = new Node(Walls.);
                maze[3, 4] = new Node(Walls.);
                maze[3, 5] = new Node(Walls.);

                maze[4, 0] = new Node(Walls.);
                maze[4, 1] = new Node(Walls.);
                maze[4, 2] = new Node(Walls.);
                maze[4, 3] = new Node(Walls.);
                maze[4, 4] = new Node(Walls.);
                maze[4, 5] = new Node(Walls.);

                maze[5, 0] = new Node(Walls.);
                maze[5, 1] = new Node(Walls.);
                maze[5, 2] = new Node(Walls.);
                maze[5, 3] = new Node(Walls.);
                maze[5, 4] = new Node(Walls.);
                maze[5, 5] = new Node(Walls.);
            }

            else
            {
                mazeIndex = 9;

                maze[0, 0] = new Node(Walls.);
                maze[0, 1] = new Node(Walls.);
                maze[0, 2] = new Node(Walls.);
                maze[0, 3] = new Node(Walls.);
                maze[0, 4] = new Node(Walls.);
                maze[0, 5] = new Node(Walls.);

                maze[1, 0] = new Node(Walls.);
                maze[1, 1] = new Node(Walls.);
                maze[1, 2] = new Node(Walls.);
                maze[1, 3] = new Node(Walls.);
                maze[1, 4] = new Node(Walls.);
                maze[1, 5] = new Node(Walls.);

                maze[2, 0] = new Node(Walls.);
                maze[2, 1] = new Node(Walls.);
                maze[2, 2] = new Node(Walls.);
                maze[2, 3] = new Node(Walls.);
                maze[2, 4] = new Node(Walls.);
                maze[2, 5] = new Node(Walls.);

                maze[3, 0] = new Node(Walls.);
                maze[3, 1] = new Node(Walls.);
                maze[3, 2] = new Node(Walls.);
                maze[3, 3] = new Node(Walls.);
                maze[3, 4] = new Node(Walls.);
                maze[3, 5] = new Node(Walls.);

                maze[4, 0] = new Node(Walls.);
                maze[4, 1] = new Node(Walls.);
                maze[4, 2] = new Node(Walls.);
                maze[4, 3] = new Node(Walls.);
                maze[4, 4] = new Node(Walls.);
                maze[4, 5] = new Node(Walls.);

                maze[5, 0] = new Node(Walls.);
                maze[5, 1] = new Node(Walls.);
                maze[5, 2] = new Node(Walls.);
                maze[5, 3] = new Node(Walls.);
                maze[5, 4] = new Node(Walls.);
                maze[5, 5] = new Node(Walls.);
            }

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    maze[i, j].Row = i;
                    maze[i, j].Col = j;

                }

            }

            //converts the player and goal coordinates
            //so it fits on the program's maze
            playerRow = ConvertCoordinate(startingPlayerRow);
            playerColumn = ConvertCoordinate(startingPlayerColumn);

            goalRow = ConvertCoordinate(startingGoalRow);
            goalColumn = ConvertCoordinate(startingGoalColumn);

            directionList = new List<string>();
        }


        /// <summary>
        /// Shows a list of directions
        /// in a message box
        /// </summary>
        public List<Coordinate> Solve()
        {
            PrintDebugLine($"Player: ({startingPlayerRow},{startingPlayerColumn})\n");
            PrintDebugLine($"Goal: ({startingGoalRow},{startingGoalColumn})\n");
            PrintDebugLine($"Marker: ({markerRow},{markerColumn})\n");
            PrintDebugLine($"Maze Index: {mazeIndex}\n");

            //if the player finds the goal

            visitedNodes.Add(new Coordinate(RevertCoordinate(playerRow), RevertCoordinate(playerColumn)));

            if (MoveNorth() || MoveEast() || MoveSouth() || MoveWest())
            {
                //simplifly the directions and show them
                directionList = SimplifyDirections();

                String answer = string.Join(", ", directionList);

                PrintDebugLine($"Answer: {answer}");

                return visitedNodes;
            }

            //otherwise tell them this module is unsolvable
            //and show the coordinates
            else
            {
                PrintDebugLine("Unable to find answer");
                ShowErrorMessage("Unable to find answer");
                return null;
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
            return coordinate + (coordinate - 2);
        }

        private int RevertCoordinate(int coordiante)
        {
            return coordiante /2;
        }

        /// <summary>
        /// Moves up if that's possible
        /// </summary>
        /// <returns>true if that's the right way to the goal</returns>
        private bool MoveNorth()
        {
            PrintDebugLine($"Attempting to move up. Starting at ({playerRow},{playerColumn})\n");
            //if there is a path and an available space going up, and the last direction went wasn't down, go up
            if (playerRow > 0 && maze[playerRow - 1, playerColumn] != '!' && maze[playerRow - 2, playerColumn] == '?'
                && (directionList.Count == 0 || directionList[directionList.Count - 1] != "DOWN"))
            {

                playerRow -= 2;
                visitedNodes.Add(new Coordinate (RevertCoordinate(playerRow), RevertCoordinate(playerColumn)));

                PrintDebugLine($"Moving up. Player is now at ({playerRow},{playerColumn})\n");
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
                                maze[playerRow, playerColumn] = 'X';
                                if (playerRow == 0 && playerColumn == 10)
                                {
                                    Console.WriteLine();
                                }
                                
                                RemoveCoordiante(new Coordinate(RevertCoordinate(playerRow), RevertCoordinate(playerColumn)));
                                playerRow += 2;
                                directionList.RemoveAt(directionList.Count - 1);

                                PrintDebugLine($"Not the right way to go. Backtracking to ({playerRow},{playerColumn})\n");
                            }
                        }

                    }

                }
            }

            //otherwise, set goal as false
            else
            {
                PrintDebugLine($"Unable to move up\n");
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
            PrintDebugLine($"Attempting to move right. Starting at ({playerRow},{playerColumn})\n");
            //if there is a path and an available space going right, and the last direction went wasn't left, go right
            if (playerColumn < 10 && maze[playerRow, playerColumn + 1] != '!' && maze[playerRow, playerColumn + 2] == '?'
                && (directionList.Count == 0 || directionList[directionList.Count - 1] != "LEFT"))
            {
                playerColumn += 2;
                visitedNodes.Add(new Coordinate(RevertCoordinate(playerRow), RevertCoordinate(playerColumn)));
                directionList.Add("RIGHT");
                PrintDebugLine($"Moving right. Player is now at ({playerRow},{playerColumn})\n");



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
                                    maze[playerRow, playerColumn] = 'X';
                                    RemoveCoordiante(new Coordinate(RevertCoordinate(playerRow), RevertCoordinate(playerColumn)));
                                    playerColumn -= 2;
                                    directionList.RemoveAt(directionList.Count - 1);
                                    PrintDebugLine($"Not the right way to go. Backtracking to ({playerRow},{playerColumn})\n");
                                }
                            }
                        }
                    }
                }
            }

            else
            {
                goal = false;
                PrintDebugLine($"Unable to move right\n");
            }

            return goal;

        }

        /// <summary>
        /// Moves down if that's possible
        /// </summary>
        /// <returns>true if that's the right way to the goal</returns>
        private bool MoveSouth()

        {
            PrintDebugLine($"Attempting to move down. Starting at ({playerRow},{playerColumn})\n");

            //if there is a path and an available space going down, and the last direction went wasn't up, go down
            if (playerRow < 10 && maze[playerRow + 1, playerColumn] != '!' && maze[playerRow + 2, playerColumn] == '?'
                && (directionList.Count == 0 || directionList[directionList.Count - 1] != "UP"))
            {
                directionList.Add("DOWN");

                playerRow += 2;
                visitedNodes.Add(new Coordinate(RevertCoordinate(playerRow), RevertCoordinate(playerColumn)));
                PrintDebugLine($"Moving down. Player is now at ({playerRow},{playerColumn})\n");


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
                                maze[playerRow, playerColumn] = 'X';
                                RemoveCoordiante(new Coordinate(RevertCoordinate(playerRow), RevertCoordinate(playerColumn)));
                                playerRow -= 2;
                                directionList.RemoveAt(directionList.Count - 1);
                                PrintDebugLine($"Not the right way to go. Backtracking to ({playerRow},{playerColumn})\n");
                            }
                        }

                    }

                }
            }

            //otherwise, set goal as false
            else
            {
                goal = false;
                PrintDebugLine($"Unable to move down\n");
            }

            return goal;
        }

        /// <summary>
        /// Moves left if that's possible
        /// </summary>
        /// <returns>true if that's the right way to the goal</returns>
        private bool MoveWest()
        {
            PrintDebugLine($"Attempting to move left. Starting at ({playerRow},{playerColumn})\n");

            //if there is a path and an available space going left, and the last direction went wasn't right, go left
            if (playerColumn > 0 && maze[playerRow, playerColumn - 1] != '!' && maze[playerRow, playerColumn - 2] == '?' && 
               (directionList.Count == 0 || directionList[directionList.Count - 1] != "RIGHT"))
            {
                playerColumn -= 2;
                visitedNodes.Add(new Coordinate(RevertCoordinate(playerRow), RevertCoordinate(playerColumn)));
                directionList.Add("LEFT");
                PrintDebugLine($"Moving left. Player is now at ({playerRow},{playerColumn})\n");



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
                                    maze[playerRow, playerColumn] = 'X';
                                    RemoveCoordiante(new Coordinate(RevertCoordinate(playerRow), RevertCoordinate(playerColumn)));
                                    playerColumn += 2;
                                    directionList.RemoveAt(directionList.Count - 1);
                                    PrintDebugLine($"Not the right way to go. Backtracking to ({playerRow},{playerColumn})\n");
                                }
                            }
                        }
                    }
                }
            }

            else
            {
                goal = false;
                PrintDebugLine($"Unable to move left\n");
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

        public class Coordinate
        {
            public int Row { get; set; }
            public int Column { get; set; }

            public Coordinate(int row, int column)
            {
                Row = row;
                Column = column;
            }

        }

        private void RemoveCoordiante(Coordinate coordianate)
        {
            for (int i = 0; i < visitedNodes.Count; i++)
            {
                if (visitedNodes[i].Row == coordianate.Row && visitedNodes[i].Column == coordianate.Column)
                {
                    visitedNodes.RemoveAt(i);
                    return;
                }
            }
        }

        private enum Walls
        {
            //1 walls

            North,
            East,
            South,
            West,

            //2 walls
            Vertical,
            Horizontal,
            NorthWest,
            NorthEast,
            SouthEast,
            SouthWest,

            //3 walls
            NorthU,
            EastU,
            SouthU,
            WestU,

            //0 walls
            None
        }



        private class Node
        {
            public int Row;
            public int Col;

            public Node North;
            public Node East;
            public Node South;
            public Node West;

            Walls wall;
            public Node(Walls wall)
            {
                this.wall = wall;
            }

            public void SetMazeConnection(Walls wall, Node[,] maze)
            {
                bool north, east, south, west;
                switch (wall)
                {
                    case Walls.North:
                        north = false;
                        east = true;
                        south = true;
                        west = true;
                        break;

                    case Walls.East:
                        north = true;
                        east = false;
                        south = true;
                        west = true;
                        break;

                    case Walls.South:
                        north = true;
                        east = true;
                        south = false;
                        west = true;
                        break;

                    case Walls.West:
                        north = true;
                        east = true;
                        south = true;
                        west = false;
                        break;

                    case Walls.Vertical:
                        north = true;
                        south = true;
                        west = false;
                        east = false;
                        break;

                    case Walls.Horizontal:
                        north = false;
                        south = false;
                        west = true;
                        east = true;
                        break;

                    case Walls.NorthWest:
                        north = false;
                        south = true;
                        west = false;
                        east = true;
                        break;

                    case Walls.NorthEast:
                        north = false;
                        south = true;
                        west = true;
                        east = false;
                        break;

                    case Walls.SouthEast:
                        north = true;
                        south = false;
                        west = true;
                        east = false;
                        break;

                    case Walls.SouthWest:
                        north = true;
                        south = false;
                        west = false;
                        east = true;
                        break;

                    case Walls.NorthU:
                        north = false;
                        south = true;
                        west = false;
                        east = false;
                        break;

                    case Walls.EastU:
                        north = false;
                        south = false;
                        west = true;
                        east = false;
                        break;

                    case Walls.SouthU:
                        north = true;
                        south = false;
                        west = false;
                        east = false;
                        break;

                    case Walls.WestU:
                        north = false;
                        south = false;
                        west = false;
                        east = true;
                        break;

                    default:
                        north = true;
                        south = true;
                        west = true;
                        east = true;
                        break;
                }

                if (north)
                {
                    North = maze[Row - 1, Col];
                }

                if (east)
                {
                    East = maze[Row, Col + 1];
                }

                if (south)
                {
                    South = maze[Row + 1, Col];
                }

                if (west)
                {
                    West = maze[Row, Col - 1];
                }
            }
        }
    }
}
