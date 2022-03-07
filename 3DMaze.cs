using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace KTANE_Solver
{
    /// <summary>
    /// Author: Nya Bentley
    /// Purpose: Solves the 3D maze module
    /// </summary>
    class _3DMaze : Module
    {
        //FIELDS
        /* a 2D Node array that will represent the maze
         */

        public Node[,] Maze { get; }

        //the letters that are used to differentiate the maze
        public char[] mazeLetters;

        public _3DMaze(Bomb bomb, StreamWriter logFile) : base(bomb, logFile, "3D Maze")
        {
            Maze = new Node[8, 8];
        }

        public enum Walls
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

        //METHODS
        /* Method that will fill in the 2d array
           -Parameters (the three letters in the maze)
        */
        public void SetMaze(string str)
        {
            if (str.Contains('A') && str.Contains('B') && str.Contains('C'))
            {
                mazeLetters = new char[3] { 'A', 'B', 'C' };

                Maze[0, 0] = new Node(0, 0, '.', Walls.NorthWest);
                Maze[0, 1] = new Node(0, 1, '.', Walls.NorthEast);
                Maze[0, 2] = new Node(0, 2, '.', Walls.West);
                Maze[0, 3] = new Node(0, 3, '.', Walls.East);
                Maze[0, 4] = new Node(0, 4, '.', Walls.SouthEast);
                Maze[0, 5] = new Node(0, 5, 'A', Walls.North);
                Maze[0, 6] = new Node(0, 6, '.', Walls.NorthEast);
                Maze[0, 7] = new Node(0, 7, '.', Walls.Vertical);

                Maze[1, 0] = new Node(1, 0, '.', Walls.West);
                Maze[1, 1] = new Node(1, 1, '*', Walls.SouthEast);
                Maze[1, 2] = new Node(1, 2, 'A', Walls.West);
                Maze[1, 3] = new Node(1, 3, '.', Walls.South);
                Maze[1, 4] = new Node(1, 4, '.', Walls.EastU);
                Maze[1, 5] = new Node(1, 5, '.', Walls.SouthWest);
                Maze[1, 6] = new Node(1, 6, '.', Walls.None);
                Maze[1, 7] = new Node(1, 7, 'B', Walls.East);

                Maze[2, 0] = new Node(2, 0, 'A', Walls.None);
                Maze[2, 1] = new Node(2, 1, '.', Walls.North);
                Maze[2, 2] = new Node(2, 2, '.', Walls.SouthEast);
                Maze[2, 3] = new Node(2, 3, 'B', Walls.NorthWest);
                Maze[2, 4] = new Node(2, 4, '.', Walls.North);
                Maze[2, 5] = new Node(2, 5, 'C', Walls.North);
                Maze[2, 6] = new Node(2, 6, '.', Walls.SouthEast);
                Maze[2, 7] = new Node(2, 7, '.', Walls.SouthWest);

                Maze[3, 0] = new Node(3, 0, '.', Walls.SouthEast);
                Maze[3, 1] = new Node(3, 1, 'C', Walls.West);
                Maze[3, 2] = new Node(3, 2, '.', Walls.NorthEast);
                Maze[3, 3] = new Node(3, 3, '.', Walls.SouthWest);
                Maze[3, 4] = new Node(3, 4, '*', Walls.SouthEast);
                Maze[3, 5] = new Node(3, 5, '.', Walls.Vertical);
                Maze[3, 6] = new Node(3, 6, '.', Walls.NorthWest);
                Maze[3, 7] = new Node(3, 7, 'B', Walls.Horizontal);

                Maze[4, 0] = new Node(4, 0, '.', Walls.NorthEast);
                Maze[4, 1] = new Node(4, 1, '.', Walls.West);
                Maze[4, 2] = new Node(4, 2, '.', Walls.East);
                Maze[4, 3] = new Node(4, 3, '.', Walls.NorthWest);
                Maze[4, 4] = new Node(4, 4, 'A', Walls.North);
                Maze[4, 5] = new Node(4, 5, '.', Walls.South);
                Maze[4, 6] = new Node(4, 6, '.', Walls.East);
                Maze[4, 7] = new Node(4, 7, '.', Walls.NorthWest);

                Maze[5, 0] = new Node(5, 0, '.', Walls.East);
                Maze[5, 1] = new Node(5, 1, 'B', Walls.Vertical);
                Maze[5, 2] = new Node(5, 2, '.', Walls.SouthWest);
                Maze[5, 3] = new Node(5, 3, 'C', Walls.South);
                Maze[5, 4] = new Node(5, 4, '.', Walls.East);
                Maze[5, 5] = new Node(5, 5, '.', Walls.NorthWest);
                Maze[5, 6] = new Node(5, 6, 'B', Walls.South);
                Maze[5, 7] = new Node(5, 7, '.', Walls.None);

                Maze[6, 0] = new Node(6, 0, '*', Walls.SouthEast);
                Maze[6, 1] = new Node(6, 1, '.', Walls.SouthWest);
                Maze[6, 2] = new Node(6, 2, 'C', Walls.North);
                Maze[6, 3] = new Node(6, 3, '.', Walls.NorthEast);
                Maze[6, 4] = new Node(6, 4, '.', Walls.Vertical);
                Maze[6, 5] = new Node(6, 5, '.', Walls.West);
                Maze[6, 6] = new Node(6, 6, '.', Walls.NorthEast);
                Maze[6, 7] = new Node(6, 7, '.', Walls.SouthWest);

                Maze[7, 0] = new Node(7, 0, '.', Walls.Horizontal);
                Maze[7, 1] = new Node(7, 1, '.', Walls.EastU);
                Maze[7, 2] = new Node(7, 2, '.', Walls.West);
                Maze[7, 3] = new Node(7, 3, '.', Walls.East);
                Maze[7, 4] = new Node(7, 4, 'A', Walls.Vertical);
                Maze[7, 5] = new Node(7, 5, '.', Walls.SouthWest);
                Maze[7, 6] = new Node(7, 6, 'C', Walls.South);
                Maze[7, 7] = new Node(7, 7, '.', Walls.North);
            }

            else if (str.Contains('A') && str.Contains('B') && str.Contains('D'))
            {
                mazeLetters = new char[3] { 'A', 'B', 'D' };

                Maze[0, 0] = new Node(0, 0, 'A', Walls.NorthWest);
                Maze[0, 1] = new Node(0, 1, '.', Walls.South);
                Maze[0, 2] = new Node(0, 2, '.', Walls.Horizontal);
                Maze[0, 3] = new Node(0, 3, 'B', Walls.None);
                Maze[0, 4] = new Node(0, 4, '.', Walls.None);
                Maze[0, 5] = new Node(0, 5, '.', Walls.SouthEast);
                Maze[0, 6] = new Node(0, 6, 'A', Walls.NorthWest);
                Maze[0, 7] = new Node(0, 7, '*', Walls.NorthEast);

                Maze[1, 0] = new Node(1, 0, '.', Walls.Vertical);
                Maze[1, 1] = new Node(1, 1, '.', Walls.NorthWest);
                Maze[1, 2] = new Node(1, 2, 'D', Walls.North);
                Maze[1, 3] = new Node(1, 3, '.', Walls.South);
                Maze[1, 4] = new Node(1, 4, '.', Walls.SouthEast);
                Maze[1, 5] = new Node(1, 5, '.', Walls.NorthWest);
                Maze[1, 6] = new Node(1, 6, '.', Walls.South);
                Maze[1, 7] = new Node(1, 7, '.', Walls.East);

                Maze[2, 0] = new Node(2, 0, '.', Walls.None);
                Maze[2, 1] = new Node(2, 1, '.', Walls.None);
                Maze[2, 2] = new Node(2, 2, '.', Walls.SouthEast);
                Maze[2, 3] = new Node(2, 3, '.', Walls.NorthWest);
                Maze[2, 4] = new Node(2, 4, '.', Walls.North);
                Maze[2, 5] = new Node(2, 5, 'D', Walls.None);
                Maze[2, 6] = new Node(2, 6, '.', Walls.NorthEast);
                Maze[2, 7] = new Node(2, 7, 'B', Walls.West);

                Maze[3, 0] = new Node(3, 0, '.', Walls.SouthEast);
                Maze[3, 1] = new Node(3, 1, 'A', Walls.SouthWest);
                Maze[3, 2] = new Node(3, 2, '.', Walls.Horizontal);
                Maze[3, 3] = new Node(3, 3, 'B', Walls.None);
                Maze[3, 4] = new Node(3, 4, '.', Walls.East);
                Maze[3, 5] = new Node(3, 5, '.', Walls.SouthWest);
                Maze[3, 6] = new Node(3, 6, '.', Walls.South);
                Maze[3, 7] = new Node(3, 7, '.', Walls.None);

                Maze[4, 0] = new Node(4, 0, '.', Walls.NorthWest);
                Maze[4, 1] = new Node(4, 1, '.', Walls.North);
                Maze[4, 2] = new Node(4, 2, '*', Walls.NorthEast);
                Maze[4, 3] = new Node(4, 3, '.', Walls.SouthWest);
                Maze[4, 4] = new Node(4, 4, '.', Walls.None);
                Maze[4, 5] = new Node(4, 5, '.', Walls.Horizontal);
                Maze[4, 6] = new Node(4, 6, 'A', Walls.NorthEast);
                Maze[4, 7] = new Node(4, 7, '.', Walls.Vertical);

                Maze[5, 0] = new Node(5, 0, 'D', Walls.South);
                Maze[5, 1] = new Node(5, 1, '.', Walls.None);
                Maze[5, 2] = new Node(5, 2, '.', Walls.SouthEast);
                Maze[5, 3] = new Node(5, 3, '.', Walls.NorthWest);
                Maze[5, 4] = new Node(5, 4, 'A', Walls.East);
                Maze[5, 5] = new Node(5, 5, '.', Walls.NorthWest);
                Maze[5, 6] = new Node(5, 6, '.', Walls.None);
                Maze[5, 7] = new Node(5, 7, '.', Walls.South);

                Maze[6, 0] = new Node(6, 0, '.', Walls.NorthEast);
                Maze[6, 1] = new Node(6, 1, '.', Walls.West);
                Maze[6, 2] = new Node(6, 2, 'B', Walls.North);
                Maze[6, 3] = new Node(6, 3, '.', Walls.South);
                Maze[6, 4] = new Node(6, 4, '.', Walls.SouthEast);
                Maze[6, 5] = new Node(6, 5, 'D', Walls.West);
                Maze[6, 6] = new Node(6, 6, '.', Walls.East);
                Maze[6, 7] = new Node(6, 7, '.', Walls.NorthWest);

                Maze[7, 0] = new Node(7, 0, '.', Walls.South);
                Maze[7, 1] = new Node(7, 1, 'D', Walls.None);
                Maze[7, 2] = new Node(7, 2, '.', Walls.SouthEast);
                Maze[7, 3] = new Node(7, 3, '.', Walls.NorthWest);
                Maze[7, 4] = new Node(7, 4, '*', Walls.NorthEast);
                Maze[7, 5] = new Node(7, 5, '.', Walls.West);
                Maze[7, 6] = new Node(7, 6, '.', Walls.South);
                Maze[7, 7] = new Node(7, 7, 'B', Walls.South);
            }

            else if (str.Contains('A') && str.Contains('B') && str.Contains('H'))
            {
                mazeLetters = new char[3] { 'A', 'B', 'H' };

                Maze[0, 0] = new Node(0, 0, 'B', Walls.NorthWest);
                Maze[0, 1] = new Node(0, 1, '.', Walls.Horizontal);
                Maze[0, 2] = new Node(0, 2, '.', Walls.NorthEast);
                Maze[0, 3] = new Node(0, 3, '.', Walls.SouthWest);
                Maze[0, 4] = new Node(0, 4, '.', Walls.Horizontal);
                Maze[0, 5] = new Node(0, 5, 'A', Walls.None);
                Maze[0, 6] = new Node(0, 6, '.', Walls.North);
                Maze[0, 7] = new Node(0, 7, 'H', Walls.NorthEast);

                Maze[1, 0] = new Node(1, 0, '*', Walls.SouthEast);
                Maze[1, 1] = new Node(1, 1, '.', Walls.NorthWest);
                Maze[1, 2] = new Node(1, 2, 'H', Walls.None);
                Maze[1, 3] = new Node(1, 3, '.', Walls.North);
                Maze[1, 4] = new Node(1, 4, '.', Walls.Horizontal);
                Maze[1, 5] = new Node(1, 5, '.', Walls.South);
                Maze[1, 6] = new Node(1, 6, '.', Walls.East);
                Maze[1, 7] = new Node(1, 7, '.', Walls.SouthWest);

                Maze[2, 0] = new Node(2, 0, 'B', Walls.North);
                Maze[2, 1] = new Node(2, 1, '.', Walls.SouthEast);
                Maze[2, 2] = new Node(2, 2, '.', Walls.Vertical);
                Maze[2, 3] = new Node(2, 3, '.', Walls.SouthWest);
                Maze[2, 4] = new Node(2, 4, 'B', Walls.North);
                Maze[2, 5] = new Node(2, 5, '.', Walls.NorthEast);
                Maze[2, 6] = new Node(2, 6, '.', Walls.Vertical);
                Maze[2, 7] = new Node(2, 7, '.', Walls.NorthWest);

                Maze[3, 0] = new Node(3, 0, '.', Walls.Vertical);
                Maze[3, 1] = new Node(3, 1, '.', Walls.NorthWest);
                Maze[3, 2] = new Node(3, 2, '.', Walls.East);
                Maze[3, 3] = new Node(3, 3, '.', Walls.NorthWest);
                Maze[3, 4] = new Node(3, 4, '*', Walls.SouthEast);
                Maze[3, 5] = new Node(3, 5, '.', Walls.West);
                Maze[3, 6] = new Node(3, 6, 'H', Walls.East);
                Maze[3, 7] = new Node(3, 7, 'A', Walls.Vertical);

                Maze[4, 0] = new Node(4, 0, '.', Walls.Vertical);
                Maze[4, 1] = new Node(4, 1, 'A', Walls.West);
                Maze[4, 2] = new Node(4, 2, '.', Walls.SouthEast);
                Maze[4, 3] = new Node(4, 3, 'H', Walls.SouthWest);
                Maze[4, 4] = new Node(4, 4, '.', Walls.North);
                Maze[4, 5] = new Node(4, 5, '.', Walls.SouthEast);
                Maze[4, 6] = new Node(4, 6, '.', Walls.West);
                Maze[4, 7] = new Node(4, 7, '.', Walls.East);

                Maze[5, 0] = new Node(5, 0, '.', Walls.Vertical);
                Maze[5, 1] = new Node(5, 1, '.', Walls.Vertical);
                Maze[5, 2] = new Node(5, 2, '.', Walls.WestU);
                Maze[5, 3] = new Node(5, 3, '.', Walls.North);
                Maze[5, 4] = new Node(5, 4, 'A', Walls.South);
                Maze[5, 5] = new Node(5, 5, '.', Walls.Horizontal);
                Maze[5, 6] = new Node(5, 6, 'B', Walls.South);
                Maze[5, 7] = new Node(5, 7, '.', Walls.East);

                Maze[6, 0] = new Node(6, 0, '.', Walls.None);
                Maze[6, 1] = new Node(6, 1, 'B', Walls.South);
                Maze[6, 2] = new Node(6, 2, '.', Walls.EastU);
                Maze[6, 3] = new Node(6, 3, '.', Walls.West);
                Maze[6, 4] = new Node(6, 4, '.', Walls.NorthEast);
                Maze[6, 5] = new Node(6, 5, '*', Walls.NorthWest);
                Maze[6, 6] = new Node(6, 6, '.', Walls.NorthEast);
                Maze[6, 7] = new Node(6, 7, '.', Walls.West);

                Maze[7, 0] = new Node(7, 0, 'A', Walls.South);
                Maze[7, 1] = new Node(7, 1, '.', Walls.Horizontal);
                Maze[7, 2] = new Node(7, 2, '.', Walls.Horizontal);
                Maze[7, 3] = new Node(7, 3, 'H', Walls.None);
                Maze[7, 4] = new Node(7, 4, '.', Walls.South);
                Maze[7, 5] = new Node(7, 5, '.', Walls.None);
                Maze[7, 6] = new Node(7, 6, '.', Walls.SouthEast);
                Maze[7, 7] = new Node(7, 7, '.', Walls.SouthWest);
            }

            else if (str.Contains('A') && str.Contains('C') && str.Contains('D'))
            {
                mazeLetters = new char[3] { 'A', 'C', 'D' };

                Maze[0, 0] = new Node(0, 0, 'D', Walls.North);
                Maze[0, 1] = new Node(0, 1, '.', Walls.South);
                Maze[0, 2] = new Node(0, 2, '.', Walls.Horizontal);
                Maze[0, 3] = new Node(0, 3, '.', Walls.NorthEast);
                Maze[0, 4] = new Node(0, 4, '.', Walls.NorthWest);
                Maze[0, 5] = new Node(0, 5, '.', Walls.South);
                Maze[0, 6] = new Node(0, 6, '.', Walls.Horizontal);
                Maze[0, 7] = new Node(0, 7, '.', Walls.North);

                Maze[1, 0] = new Node(1, 0, '.', Walls.Vertical);
                Maze[1, 1] = new Node(1, 1, '.', Walls.NorthWest);
                Maze[1, 2] = new Node(1, 2, 'C', Walls.North);
                Maze[1, 3] = new Node(1, 3, '.', Walls.East);
                Maze[1, 4] = new Node(1, 4, 'D', Walls.Vertical);
                Maze[1, 5] = new Node(1, 5, '*', Walls.WestU);
                Maze[1, 6] = new Node(1, 6, '.', Walls.Horizontal);
                Maze[1, 7] = new Node(1, 7, 'C', Walls.SouthEast);

                Maze[2, 0] = new Node(2, 0, '.', Walls.East);
                Maze[2, 1] = new Node(2, 1, '.', Walls.SouthU);
                Maze[2, 2] = new Node(2, 2, '*', Walls.Vertical);
                Maze[2, 3] = new Node(2, 3, '.', Walls.West);
                Maze[2, 4] = new Node(2, 4, '.', Walls.None);
                Maze[2, 5] = new Node(2, 5, 'C', Walls.NorthEast);
                Maze[2, 6] = new Node(2, 6, '.', Walls.NorthWest);
                Maze[2, 7] = new Node(2, 7, '.', Walls.North);

                Maze[3, 0] = new Node(3, 0, '.', Walls.SouthWest);
                Maze[3, 1] = new Node(3, 1, '.', Walls.Horizontal);
                Maze[3, 2] = new Node(3, 2, 'A', Walls.SouthEast);
                Maze[3, 3] = new Node(3, 3, '.', Walls.Vertical);
                Maze[3, 4] = new Node(3, 4, '.', Walls.SouthWest);
                Maze[3, 5] = new Node(3, 5, '.', Walls.South);
                Maze[3, 6] = new Node(3, 6, '.', Walls.SouthEast);
                Maze[3, 7] = new Node(3, 7, '.', Walls.Vertical);

                Maze[4, 0] = new Node(4, 0, 'D', Walls.NorthWest);
                Maze[4, 1] = new Node(4, 1, '.', Walls.Horizontal);
                Maze[4, 2] = new Node(4, 2, '.', Walls.Horizontal);
                Maze[4, 3] = new Node(4, 3, 'C', Walls.East);
                Maze[4, 4] = new Node(4, 4, '.', Walls.NorthWest);
                Maze[4, 5] = new Node(4, 5, 'D', Walls.Horizontal);
                Maze[4, 6] = new Node(4, 6, '.', Walls.NorthEast);
                Maze[4, 7] = new Node(4, 7, '.', Walls.Vertical);

                Maze[5, 0] = new Node(5, 0, '.', Walls.East);
                Maze[5, 1] = new Node(5, 1, '.', Walls.NorthU);
                Maze[5, 2] = new Node(5, 2, 'A', Walls.NorthWest);
                Maze[5, 3] = new Node(5, 3, '.', Walls.South);
                Maze[5, 4] = new Node(5, 4, '.', Walls.East);
                Maze[5, 5] = new Node(5, 5, '*', Walls.WestU);
                Maze[5, 6] = new Node(5, 6, '.', Walls.SouthEast);
                Maze[5, 7] = new Node(5, 7, 'A', Walls.West);

                Maze[6, 0] = new Node(6, 0, '.', Walls.East);
                Maze[6, 1] = new Node(6, 1, '.', Walls.SouthWest);
                Maze[6, 2] = new Node(6, 2, '.', Walls.SouthEast);
                Maze[6, 3] = new Node(6, 3, 'A', Walls.NorthWest);
                Maze[6, 4] = new Node(6, 4, '.', Walls.South);
                Maze[6, 5] = new Node(6, 5, '.', Walls.Horizontal);
                Maze[6, 6] = new Node(6, 6, 'D', Walls.North);
                Maze[6, 7] = new Node(6, 7, '.', Walls.None);

                Maze[7, 0] = new Node(7, 0, 'A', Walls.SouthWest);
                Maze[7, 1] = new Node(7, 1, '.', Walls.North);
                Maze[7, 2] = new Node(7, 2, '.', Walls.Horizontal);
                Maze[7, 3] = new Node(7, 3, '.', Walls.South);
                Maze[7, 4] = new Node(7, 4, '.', Walls.Horizontal);
                Maze[7, 5] = new Node(7, 5, 'C', Walls.NorthEast);
                Maze[7, 6] = new Node(7, 6, '.', Walls.SouthWest);
                Maze[7, 7] = new Node(7, 7, '.', Walls.SouthEast);
            }

            else if (str.Contains('A') && str.Contains('C') && str.Contains('H'))
            {
                mazeLetters = new char[3] { 'A', 'C', 'H' };

                Maze[0, 0] = new Node(0, 0, 'H', Walls.SouthWest);
                Maze[0, 1] = new Node(0, 1, '.', Walls.South);
                Maze[0, 2] = new Node(0, 2, 'C', Walls.North);
                Maze[0, 3] = new Node(0, 3, '.', Walls.Horizontal);
                Maze[0, 4] = new Node(0, 4, '.', Walls.East);
                Maze[0, 5] = new Node(0, 5, '.', Walls.SouthWest);
                Maze[0, 6] = new Node(0, 6, 'A', Walls.Horizontal);
                Maze[0, 7] = new Node(0, 7, '.', Walls.East);

                Maze[1, 0] = new Node(1, 0, '*', Walls.NorthWest);
                Maze[1, 1] = new Node(1, 1, '.', Walls.Horizontal);
                Maze[1, 2] = new Node(1, 2, '.', Walls.SouthEast);
                Maze[1, 3] = new Node(1, 3, '.', Walls.NorthWest);
                Maze[1, 4] = new Node(1, 4, 'H', Walls.None);
                Maze[1, 5] = new Node(1, 5, '.', Walls.South);
                Maze[1, 6] = new Node(1, 6, '.', Walls.SouthEast);
                Maze[1, 7] = new Node(1, 7, '.', Walls.Vertical);

                Maze[2, 0] = new Node(2, 0, '.', Walls.East);
                Maze[2, 1] = new Node(2, 1, '.', Walls.NorthWest);
                Maze[2, 2] = new Node(2, 2, '.', Walls.NorthEast);
                Maze[2, 3] = new Node(2, 3, '.', Walls.West);
                Maze[2, 4] = new Node(2, 4, '.', Walls.East);
                Maze[2, 5] = new Node(2, 5, '.', Walls.NorthWest);
                Maze[2, 6] = new Node(2, 6, '*', Walls.NorthEast);
                Maze[2, 7] = new Node(2, 7, 'C', Walls.West);

                Maze[3, 0] = new Node(3, 0, '.', Walls.West);
                Maze[3, 1] = new Node(3, 1, 'A', Walls.South);
                Maze[3, 2] = new Node(3, 2, '.', Walls.None);
                Maze[3, 3] = new Node(3, 3, '.', Walls.None);
                Maze[3, 4] = new Node(3, 4, '.', Walls.None);
                Maze[3, 5] = new Node(3, 5, 'H', Walls.South);
                Maze[3, 6] = new Node(3, 6, '.', Walls.East);
                Maze[3, 7] = new Node(3, 7, '.', Walls.Vertical);

                Maze[4, 0] = new Node(4, 0, 'C', Walls.Vertical);
                Maze[4, 1] = new Node(4, 1, '.', Walls.NorthWest);
                Maze[4, 2] = new Node(4, 2, 'H', Walls.None);
                Maze[4, 3] = new Node(4, 3, '.', Walls.None);
                Maze[4, 4] = new Node(4, 4, 'C', Walls.None);
                Maze[4, 5] = new Node(4, 5, '.', Walls.North);
                Maze[4, 6] = new Node(4, 6, 'A', Walls.None);
                Maze[4, 7] = new Node(4, 7, '.', Walls.SouthEast);

                Maze[5, 0] = new Node(5, 0, '.', Walls.SouthEast);
                Maze[5, 1] = new Node(5, 1, '*', Walls.Vertical);
                Maze[5, 2] = new Node(5, 2, '.', Walls.NorthWest);
                Maze[5, 3] = new Node(5, 3, '.', Walls.SouthEast);
                Maze[5, 4] = new Node(5, 4, '.', Walls.East);
                Maze[5, 5] = new Node(5, 5, '.', Walls.West);
                Maze[5, 6] = new Node(5, 6, '.', Walls.SouthEast);
                Maze[5, 7] = new Node(5, 7, 'A', Walls.NorthWest);

                Maze[6, 0] = new Node(6, 0, '.', Walls.NorthWest);
                Maze[6, 1] = new Node(6, 1, '.', Walls.Horizontal);
                Maze[6, 2] = new Node(6, 2, '.', Walls.NorthEast);
                Maze[6, 3] = new Node(6, 3, 'C', Walls.SouthWest);
                Maze[6, 4] = new Node(6, 4, '.', Walls.South);
                Maze[6, 5] = new Node(6, 5, 'H', Walls.None);
                Maze[6, 6] = new Node(6, 6, '.', Walls.Horizontal);
                Maze[6, 7] = new Node(6, 7, '.', Walls.SouthEast);

                Maze[7, 0] = new Node(7, 0, '.', Walls.East);
                Maze[7, 1] = new Node(7, 1, '.', Walls.NorthWest);
                Maze[7, 2] = new Node(7, 2, 'A', Walls.South);
                Maze[7, 3] = new Node(7, 3, '.', Walls.Horizontal);
                Maze[7, 4] = new Node(7, 4, '.', Walls.Horizontal);
                Maze[7, 5] = new Node(7, 5, '.', Walls.SouthEast);
                Maze[7, 6] = new Node(7, 6, '.', Walls.NorthWest);
                Maze[7, 7] = new Node(7, 7, '.', Walls.North);

            }

            else if (str.Contains('A') && str.Contains('D') && str.Contains('H'))
            {
                mazeLetters = new char[3] { 'A', 'D', 'H' };

                Maze[0, 0] = new Node(0, 0, 'D', Walls.West);
                Maze[0, 1] = new Node(0, 1, '.', Walls.NorthEast);
                Maze[0, 2] = new Node(0, 2, 'D', Walls.NorthWest);
                Maze[0, 3] = new Node(0, 3, '.', Walls.North);
                Maze[0, 4] = new Node(0, 4, '.', Walls.SouthEast);
                Maze[0, 5] = new Node(0, 5, '*', Walls.WestU);
                Maze[0, 6] = new Node(0, 6, '.', Walls.South);
                Maze[0, 7] = new Node(0, 7, '.', Walls.NorthEast);

                Maze[1, 0] = new Node(1, 0, '.', Walls.Vertical);
                Maze[1, 1] = new Node(1, 1, '.', Walls.Vertical);
                Maze[1, 2] = new Node(1, 2, '.', Walls.Vertical);
                Maze[1, 3] = new Node(1, 3, '.', Walls.West);
                Maze[1, 4] = new Node(1, 4, 'H', Walls.North);
                Maze[1, 5] = new Node(1, 5, '.', Walls.Horizontal);
                Maze[1, 6] = new Node(1, 6, '.', Walls.Horizontal);
                Maze[1, 7] = new Node(1, 7, 'A', Walls.SouthEast);

                Maze[2, 0] = new Node(2, 0, '.', Walls.Vertical);
                Maze[2, 1] = new Node(2, 1, '*', Walls.SouthWest);
                Maze[2, 2] = new Node(2, 2, 'H', Walls.East);
                Maze[2, 3] = new Node(2, 3, '.', Walls.Vertical);
                Maze[2, 4] = new Node(2, 4, '.', Walls.SouthWest);
                Maze[2, 5] = new Node(2, 5, '.', Walls.Horizontal);
                Maze[2, 6] = new Node(2, 6, 'A', Walls.North);
                Maze[2, 7] = new Node(2, 7, '.', Walls.NorthEast);

                Maze[3, 0] = new Node(3, 0, 'A', Walls.East);
                Maze[3, 1] = new Node(3, 1, '.', Walls.NorthU);
                Maze[3, 2] = new Node(3, 2, '.', Walls.SouthU);
                Maze[3, 3] = new Node(3, 3, 'D', Walls.SouthWest);
                Maze[3, 4] = new Node(3, 4, '.', Walls.North);
                Maze[3, 5] = new Node(3, 5, '.', Walls.Horizontal);
                Maze[3, 6] = new Node(3, 6, '.', Walls.None);
                Maze[3, 7] = new Node(3, 7, '.', Walls.South);

                Maze[4, 0] = new Node(4, 0, '.', Walls.SouthWest);
                Maze[4, 1] = new Node(4, 1, '.', Walls.South);
                Maze[4, 2] = new Node(4, 2, '.', Walls.Horizontal);
                Maze[4, 3] = new Node(4, 3, '.', Walls.North);
                Maze[4, 4] = new Node(4, 4, 'H', Walls.East);
                Maze[4, 5] = new Node(4, 5, 'D', Walls.NorthWest);
                Maze[4, 6] = new Node(4, 6, '.', Walls.East);
                Maze[4, 7] = new Node(4, 7, '.', Walls.NorthU);

                Maze[5, 0] = new Node(5, 0, '*', Walls.NorthWest);
                Maze[5, 1] = new Node(5, 1, '.', Walls.Horizontal);
                Maze[5, 2] = new Node(5, 2, 'H', Walls.Horizontal);
                Maze[5, 3] = new Node(5, 3, '.', Walls.East);
                Maze[5, 4] = new Node(5, 4, '.', Walls.Vertical);
                Maze[5, 5] = new Node(5, 5, '.', Walls.Vertical);
                Maze[5, 6] = new Node(5, 6, '.', Walls.West);
                Maze[5, 7] = new Node(5, 7, 'A', Walls.East);

                Maze[6, 0] = new Node(6, 0, 'D', Walls.South);
                Maze[6, 1] = new Node(6, 1, '.', Walls.Horizontal);
                Maze[6, 2] = new Node(6, 2, '.', Walls.NorthEast);
                Maze[6, 3] = new Node(6, 3, '.', Walls.Vertical);
                Maze[6, 4] = new Node(6, 4, '.', Walls.SouthU);
                Maze[6, 5] = new Node(6, 5, '.', Walls.Vertical);
                Maze[6, 6] = new Node(6, 6, '.', Walls.Vertical);
                Maze[6, 7] = new Node(6, 7, '.', Walls.West);

                Maze[7, 0] = new Node(7, 0, '.', Walls.NorthWest);
                Maze[7, 1] = new Node(7, 1, '.', Walls.Horizontal);
                Maze[7, 2] = new Node(7, 2, '.', Walls.South);
                Maze[7, 3] = new Node(7, 3, 'A', Walls.South);
                Maze[7, 4] = new Node(7, 4, '.', Walls.NorthEast);
                Maze[7, 5] = new Node(7, 5, 'H', Walls.SouthWest);
                Maze[7, 6] = new Node(7, 6, '.', Walls.East);
                Maze[7, 7] = new Node(7, 7, '.', Walls.SouthU);
            }

            else if (str.Contains('B') && str.Contains('C') && str.Contains('D'))
            {
                mazeLetters = new char[3] { 'B', 'C', 'D' };

                Maze[0, 0] = new Node(0, 0, '.', Walls.West);
                Maze[0, 1] = new Node(0, 1, '.', Walls.Horizontal);
                Maze[0, 2] = new Node(0, 2, '.', Walls.SouthEast);
                Maze[0, 3] = new Node(0, 3, '.', Walls.NorthWest);
                Maze[0, 4] = new Node(0, 4, '.', Walls.Horizontal);
                Maze[0, 5] = new Node(0, 5, 'B', Walls.North);
                Maze[0, 6] = new Node(0, 6, '.', Walls.Horizontal);
                Maze[0, 7] = new Node(0, 7, '.', Walls.SouthEast);

                Maze[1, 0] = new Node(1, 0, 'C', Walls.None);
                Maze[1, 1] = new Node(1, 1, '.', Walls.Horizontal);
                Maze[1, 2] = new Node(1, 2, 'D', Walls.Horizontal);
                Maze[1, 3] = new Node(1, 3, '.', Walls.East);
                Maze[1, 4] = new Node(1, 4, '.', Walls.NorthWest);
                Maze[1, 5] = new Node(1, 5, '.', Walls.SouthEast);
                Maze[1, 6] = new Node(1, 6, '*', Walls.NorthWest);
                Maze[1, 7] = new Node(1, 7, '.', Walls.North);

                Maze[2, 0] = new Node(2, 0, '.', Walls.SouthU);
                Maze[2, 1] = new Node(2, 1, '*', Walls.NorthU);
                Maze[2, 2] = new Node(2, 2, '.', Walls.NorthWest);
                Maze[2, 3] = new Node(2, 3, 'B', Walls.East);
                Maze[2, 4] = new Node(2, 4, '.', Walls.West);
                Maze[2, 5] = new Node(2, 5, '.', Walls.Horizontal);
                Maze[2, 6] = new Node(2, 6, 'C', Walls.South);
                Maze[2, 7] = new Node(2, 7, '.', Walls.SouthEast);

                Maze[3, 0] = new Node(3, 0, '.', Walls.Horizontal);
                Maze[3, 1] = new Node(3, 1, 'C', Walls.None);
                Maze[3, 2] = new Node(3, 2, '.', Walls.South);
                Maze[3, 3] = new Node(3, 3, '.', Walls.East);
                Maze[3, 4] = new Node(3, 4, '.', Walls.West);
                Maze[3, 5] = new Node(3, 5, '.', Walls.North);
                Maze[3, 6] = new Node(3, 6, 'B', Walls.Horizontal);
                Maze[3, 7] = new Node(3, 7, '.', Walls.Horizontal);

                Maze[4, 0] = new Node(4, 0, '.', Walls.Horizontal);
                Maze[4, 1] = new Node(4, 1, '.', Walls.East);
                Maze[4, 2] = new Node(4, 2, '.', Walls.NorthWest);
                Maze[4, 3] = new Node(4, 3, '.', Walls.South);
                Maze[4, 4] = new Node(4, 4, 'C', Walls.South);
                Maze[4, 5] = new Node(4, 5, '.', Walls.East);
                Maze[4, 6] = new Node(4, 6, '.', Walls.NorthWest);
                Maze[4, 7] = new Node(4, 7, 'D', Walls.Horizontal);

                Maze[5, 0] = new Node(5, 0, 'B', Walls.North);
                Maze[5, 1] = new Node(5, 1, '.', Walls.South);
                Maze[5, 2] = new Node(5, 2, '.', Walls.SouthEast);
                Maze[5, 3] = new Node(5, 3, '.', Walls.NorthWest);
                Maze[5, 4] = new Node(5, 4, '.', Walls.North);
                Maze[5, 5] = new Node(5, 5, 'D', Walls.None);
                Maze[5, 6] = new Node(5, 6, '.', Walls.SouthEast);
                Maze[5, 7] = new Node(5, 7, '.', Walls.NorthWest);

                Maze[6, 0] = new Node(6, 0, '.', Walls.South);
                Maze[6, 1] = new Node(6, 1, 'C', Walls.North);
                Maze[6, 2] = new Node(6, 2, '.', Walls.Horizontal);
                Maze[6, 3] = new Node(6, 3, '.', Walls.South);
                Maze[6, 4] = new Node(6, 4, '*', Walls.SouthEast);
                Maze[6, 5] = new Node(6, 5, '.', Walls.Vertical);
                Maze[6, 6] = new Node(6, 6, 'D', Walls.NorthWest);
                Maze[6, 7] = new Node(6, 7, '.', Walls.South);

                Maze[7, 0] = new Node(7, 0, 'D', Walls.North);
                Maze[7, 1] = new Node(7, 1, '.', Walls.SouthEast);
                Maze[7, 2] = new Node(7, 2, '.', Walls.NorthWest);
                Maze[7, 3] = new Node(7, 3, 'B', Walls.Horizontal);
                Maze[7, 4] = new Node(7, 4, '.', Walls.Horizontal);
                Maze[7, 5] = new Node(7, 5, '.', Walls.South);
                Maze[7, 6] = new Node(7, 6, '.', Walls.SouthEast);
                Maze[7, 7] = new Node(7, 7, '.', Walls.NorthWest);
            }

            else if (str.Contains('B') && str.Contains('C') && str.Contains('H'))
            {
                mazeLetters = new char[3] { 'B', 'C', 'H' };

                Maze[0, 0] = new Node(0, 0, 'C', Walls.NorthWest);
                Maze[0, 1] = new Node(0, 1, '.', Walls.South);
                Maze[0, 2] = new Node(0, 2, '.', Walls.North);
                Maze[0, 3] = new Node(0, 3, '.', Walls.Horizontal);
                Maze[0, 4] = new Node(0, 4, 'H', Walls.East);
                Maze[0, 5] = new Node(0, 5, '.', Walls.SouthWest);
                Maze[0, 6] = new Node(0, 6, '.', Walls.Horizontal);
                Maze[0, 7] = new Node(0, 7, '.', Walls.EastU);

                Maze[1, 0] = new Node(1, 0, '.', Walls.SouthEast);
                Maze[1, 1] = new Node(1, 1, '.', Walls.NorthWest);
                Maze[1, 2] = new Node(1, 2, 'C', Walls.South);
                Maze[1, 3] = new Node(1, 3, '.', Walls.NorthEast);
                Maze[1, 4] = new Node(1, 4, '.', Walls.SouthWest);
                Maze[1, 5] = new Node(1, 5, '.', Walls.Horizontal);
                Maze[1, 6] = new Node(1, 6, '.', Walls.North);
                Maze[1, 7] = new Node(1, 7, 'H', Walls.North);

                Maze[2, 0] = new Node(2, 0, '.', Walls.NorthEast);
                Maze[2, 1] = new Node(2, 1, '.', Walls.Vertical);
                Maze[2, 2] = new Node(2, 2, '*', Walls.NorthU);
                Maze[2, 3] = new Node(2, 3, '.', Walls.Vertical);
                Maze[2, 4] = new Node(2, 4, 'B', Walls.NorthWest);
                Maze[2, 5] = new Node(2, 5, '.', Walls.Horizontal);
                Maze[2, 6] = new Node(2, 6, '.', Walls.SouthEast);
                Maze[2, 7] = new Node(2, 7, '.', Walls.West);

                Maze[3, 0] = new Node(3, 0, 'B', Walls.West);
                Maze[3, 1] = new Node(3, 1, '.', Walls.South);
                Maze[3, 2] = new Node(3, 2, '.', Walls.South);
                Maze[3, 3] = new Node(3, 3, 'H', Walls.SouthEast);
                Maze[3, 4] = new Node(3, 4, '*', Walls.SouthWest);
                Maze[3, 5] = new Node(3, 5, '.', Walls.Horizontal);
                Maze[3, 6] = new Node(3, 6, '.', Walls.Horizontal);
                Maze[3, 7] = new Node(3, 7, '.', Walls.East);

                Maze[4, 0] = new Node(4, 0, '.', Walls.West);
                Maze[4, 1] = new Node(4, 1, 'H', Walls.North);
                Maze[4, 2] = new Node(4, 2, '.', Walls.Horizontal);
                Maze[4, 3] = new Node(4, 3, '.', Walls.NorthEast);
                Maze[4, 4] = new Node(4, 4, '.', Walls.NorthWest);
                Maze[4, 5] = new Node(4, 5, 'B', Walls.North);
                Maze[4, 6] = new Node(4, 6, '.', Walls.Horizontal);
                Maze[4, 7] = new Node(4, 7, 'C', Walls.East);

                Maze[5, 0] = new Node(5, 0, '.', Walls.SouthEast);
                Maze[5, 1] = new Node(5, 1, '.', Walls.Vertical);
                Maze[5, 2] = new Node(5, 2, '.', Walls.NorthWest);
                Maze[5, 3] = new Node(5, 3, '*', Walls.SouthEast);
                Maze[5, 4] = new Node(5, 4, '.', Walls.Vertical);
                Maze[5, 5] = new Node(5, 5, '.', Walls.SouthWest);
                Maze[5, 6] = new Node(5, 6, '.', Walls.NorthEast);
                Maze[5, 7] = new Node(5, 7, '.', Walls.West);

                Maze[6, 0] = new Node(6, 0, '.', Walls.NorthEast);
                Maze[6, 1] = new Node(6, 1, '.', Walls.Vertical);
                Maze[6, 2] = new Node(6, 2, 'B', Walls.West);
                Maze[6, 3] = new Node(6, 3, '.', Walls.NorthEast);
                Maze[6, 4] = new Node(6, 4, 'C', Walls.West);
                Maze[6, 5] = new Node(6, 5, '.', Walls.Horizontal);
                Maze[6, 6] = new Node(6, 6, '.', Walls.SouthEast);
                Maze[6, 7] = new Node(6, 7, '.', Walls.West);

                Maze[7, 0] = new Node(7, 0, '.', Walls.South);
                Maze[7, 1] = new Node(7, 1, 'C', Walls.None);
                Maze[7, 2] = new Node(7, 2, '.', Walls.SouthEast);
                Maze[7, 3] = new Node(7, 3, '.', Walls.SouthWest);
                Maze[7, 4] = new Node(7, 4, '.', Walls.None);
                Maze[7, 5] = new Node(7, 5, 'H', Walls.NorthEast);
                Maze[7, 6] = new Node(7, 6, '.', Walls.WestU);
                Maze[7, 7] = new Node(7, 7, 'B', Walls.South);
            }

            else if (str.Contains('B') && str.Contains('D') && str.Contains('H'))
            {
                mazeLetters = new char[3] { 'B', 'D', 'H' };

                Maze[0, 0] = new Node(0, 0, '.', Walls.East);
                Maze[0, 1] = new Node(0, 1, '.', Walls.Vertical);
                Maze[0, 2] = new Node(0, 2, 'D', Walls.NorthWest);
                Maze[0, 3] = new Node(0, 3, '.', Walls.SouthEast);
                Maze[0, 4] = new Node(0, 4, 'B', Walls.West);
                Maze[0, 5] = new Node(0, 5, '.', Walls.None);
                Maze[0, 6] = new Node(0, 6, '.', Walls.None);
                Maze[0, 7] = new Node(0, 7, 'H', Walls.Horizontal);

                Maze[1, 0] = new Node(1, 0, '.', Walls.SouthU);
                Maze[1, 1] = new Node(1, 1, '.', Walls.SouthWest);
                Maze[1, 2] = new Node(1, 2, '.', Walls.East);
                Maze[1, 3] = new Node(1, 3, '*', Walls.WestU);
                Maze[1, 4] = new Node(1, 4, '.', Walls.SouthEast);
                Maze[1, 5] = new Node(1, 5, 'D', Walls.Vertical);
                Maze[1, 6] = new Node(1, 6, '.', Walls.Vertical);
                Maze[1, 7] = new Node(1, 7, '.', Walls.NorthU);

                Maze[2, 0] = new Node(2, 0, '.', Walls.Horizontal);
                Maze[2, 1] = new Node(2, 1, '.', Walls.Horizontal);
                Maze[2, 2] = new Node(2, 2, 'H', Walls.None);
                Maze[2, 3] = new Node(2, 3, '.', Walls.Horizontal);
                Maze[2, 4] = new Node(2, 4, '*', Walls.EastU);
                Maze[2, 5] = new Node(2, 5, '.', Walls.Vertical);
                Maze[2, 6] = new Node(2, 6, 'B', Walls.SouthWest);
                Maze[2, 7] = new Node(2, 7, '.', Walls.South);

                Maze[3, 0] = new Node(3, 0, 'D', Walls.North);
                Maze[3, 1] = new Node(3, 1, '.', Walls.NorthEast);
                Maze[3, 2] = new Node(3, 2, '.', Walls.West);
                Maze[3, 3] = new Node(3, 3, '.', Walls.Horizontal);
                Maze[3, 4] = new Node(3, 4, '.', Walls.North);
                Maze[3, 5] = new Node(3, 5, 'B', Walls.None);
                Maze[3, 6] = new Node(3, 6, '.', Walls.Horizontal);
                Maze[3, 7] = new Node(3, 7, '.', Walls.Horizontal);

                Maze[4, 0] = new Node(4, 0, '.', Walls.South);
                Maze[4, 1] = new Node(4, 1, '.', Walls.East);
                Maze[4, 2] = new Node(4, 2, '.', Walls.Vertical);
                Maze[4, 3] = new Node(4, 3, '.', Walls.NorthWest);
                Maze[4, 4] = new Node(4, 4, 'D', Walls.East);
                Maze[4, 5] = new Node(4, 5, '.', Walls.West);
                Maze[4, 6] = new Node(4, 6, '.', Walls.North);
                Maze[4, 7] = new Node(4, 7, 'H', Walls.North);

                Maze[5, 0] = new Node(5, 0, '.', Walls.NorthWest);
                Maze[5, 1] = new Node(5, 1, '.', Walls.South);
                Maze[5, 2] = new Node(5, 2, 'B', Walls.South);
                Maze[5, 3] = new Node(5, 3, '.', Walls.East);
                Maze[5, 4] = new Node(5, 4, '.', Walls.SouthU);
                Maze[5, 5] = new Node(5, 5, '.', Walls.SouthU);
                Maze[5, 6] = new Node(5, 6, '.', Walls.West);
                Maze[5, 7] = new Node(5, 7, '.', Walls.East);

                Maze[6, 0] = new Node(6, 0, '.', Walls.Vertical);
                Maze[6, 1] = new Node(6, 1, '.', Walls.WestU);
                Maze[6, 2] = new Node(6, 2, '.', Walls.North);
                Maze[6, 3] = new Node(6, 3, 'H', Walls.None);
                Maze[6, 4] = new Node(6, 4, '.', Walls.Horizontal);
                Maze[6, 5] = new Node(6, 5, '.', Walls.Horizontal);
                Maze[6, 6] = new Node(6, 6, 'H', Walls.South);
                Maze[6, 7] = new Node(6, 7, '*', Walls.SouthEast);

                Maze[7, 0] = new Node(7, 0, 'D', Walls.None);
                Maze[7, 1] = new Node(7, 1, '.', Walls.North);
                Maze[7, 2] = new Node(7, 2, '.', Walls.SouthEast);
                Maze[7, 3] = new Node(7, 3, '.', Walls.Vertical);
                Maze[7, 4] = new Node(7, 4, '.', Walls.NorthWest);
                Maze[7, 5] = new Node(7, 5, 'B', Walls.NorthEast);
                Maze[7, 6] = new Node(7, 6, '.', Walls.NorthWest);
                Maze[7, 7] = new Node(7, 7, '.', Walls.Horizontal);
            }

            //CDH maze
            else
            {
                mazeLetters = new char[3] { 'C', 'D', 'H' };

                Maze[0, 0] = new Node(0, 0, '.', Walls.Vertical);
                Maze[0, 1] = new Node(0, 1, '.', Walls.NorthWest);
                Maze[0, 2] = new Node(0, 2, 'H', Walls.South);
                Maze[0, 3] = new Node(0, 3, '.', Walls.NorthEast);
                Maze[0, 4] = new Node(0, 4, '.', Walls.NorthWest);
                Maze[0, 5] = new Node(0, 5, 'D', Walls.South);
                Maze[0, 6] = new Node(0, 6, '.', Walls.NorthEast);
                Maze[0, 7] = new Node(0, 7, '.', Walls.Vertical);

                Maze[1, 0] = new Node(1, 0, '.', Walls.Vertical);
                Maze[1, 1] = new Node(1, 1, '.', Walls.Vertical);
                Maze[1, 2] = new Node(1, 2, '.', Walls.NorthU);
                Maze[1, 3] = new Node(1, 3, '.', Walls.West);
                Maze[1, 4] = new Node(1, 4, 'C', Walls.East);
                Maze[1, 5] = new Node(1, 5, '*', Walls.NorthU);
                Maze[1, 6] = new Node(1, 6, '.', Walls.Vertical);
                Maze[1, 7] = new Node(1, 7, '.', Walls.Vertical);

                Maze[2, 0] = new Node(2, 0, '.', Walls.None);
                Maze[2, 1] = new Node(2, 1, '.', Walls.SouthEast);
                Maze[2, 2] = new Node(2, 2, '.', Walls.West);
                Maze[2, 3] = new Node(2, 3, 'H', Walls.None);
                Maze[2, 4] = new Node(2, 4, '.', Walls.None);
                Maze[2, 5] = new Node(2, 5, '.', Walls.East);
                Maze[2, 6] = new Node(2, 6, '.', Walls.SouthWest);
                Maze[2, 7] = new Node(2, 7, 'D', Walls.None);

                Maze[3, 0] = new Node(3, 0, 'H', Walls.None);
                Maze[3, 1] = new Node(3, 1, '.', Walls.Horizontal);
                Maze[3, 2] = new Node(3, 2, '.', Walls.East);
                Maze[3, 3] = new Node(3, 3, '.', Walls.Vertical);
                Maze[3, 4] = new Node(3, 4, '.', Walls.Vertical);
                Maze[3, 5] = new Node(3, 5, 'D', Walls.West);
                Maze[3, 6] = new Node(3, 6, '.', Walls.Horizontal);
                Maze[3, 7] = new Node(3, 7, '.', Walls.None);

                Maze[4, 0] = new Node(4, 0, '.', Walls.West);
                Maze[4, 1] = new Node(4, 1, '.', Walls.Horizontal);
                Maze[4, 2] = new Node(4, 2, 'C', Walls.SouthEast);
                Maze[4, 3] = new Node(4, 3, '.', Walls.Vertical);
                Maze[4, 4] = new Node(4, 4, '.', Walls.Vertical);
                Maze[4, 5] = new Node(4, 5, '.', Walls.SouthWest);
                Maze[4, 6] = new Node(4, 6, '.', Walls.Horizontal);
                Maze[4, 7] = new Node(4, 7, '.', Walls.East);

                Maze[5, 0] = new Node(5, 0, 'C', Walls.West);
                Maze[5, 1] = new Node(5, 1, '.', Walls.Horizontal);
                Maze[5, 2] = new Node(5, 2, '.', Walls.North);
                Maze[5, 3] = new Node(5, 3, 'D', Walls.SouthEast);
                Maze[5, 4] = new Node(5, 4, '.', Walls.SouthWest);
                Maze[5, 5] = new Node(5, 5, 'C', Walls.North);
                Maze[5, 6] = new Node(5, 6, '.', Walls.Horizontal);
                Maze[5, 7] = new Node(5, 7, 'H', Walls.East);

                Maze[6, 0] = new Node(6, 0, '*', Walls.SouthU);
                Maze[6, 1] = new Node(6, 1, 'D', Walls.NorthWest);
                Maze[6, 2] = new Node(6, 2, '.', Walls.South);
                Maze[6, 3] = new Node(6, 3, '.', Walls.North);
                Maze[6, 4] = new Node(6, 4, 'H', Walls.North);
                Maze[6, 5] = new Node(6, 5, '.', Walls.South);
                Maze[6, 6] = new Node(6, 6, '*', Walls.NorthEast);
                Maze[6, 7] = new Node(6, 7, '.', Walls.SouthU);

                Maze[7, 0] = new Node(7, 0, '.', Walls.North);
                Maze[7, 1] = new Node(7, 1, '.', Walls.SouthEast);
                Maze[7, 2] = new Node(7, 2, '.', Walls.NorthWest);
                Maze[7, 3] = new Node(7, 3, '.', Walls.SouthEast);
                Maze[7, 4] = new Node(7, 4, '.', Walls.SouthWest);
                Maze[7, 5] = new Node(7, 5, '.', Walls.NorthEast);
                Maze[7, 6] = new Node(7, 6, '.', Walls.SouthWest);
                Maze[7, 7] = new Node(7, 7, 'C', Walls.North);
            }

            PrintDebugLine($"Using {mazeLetters[0]}{mazeLetters[1]}{mazeLetters[2]} Maze\n");


            foreach (Node node in Maze)
            {
                node.SetMazeConnection(node.Wall, Maze);
            }

        }

        public void PrintGrid()
        {
            PrintDebug(" ");

            for (int i = 0; i < 8; i++)
            {
                PrintDebug(" " + i);
            }

            PrintDebugLine("");

            for (int row = 0; row < 16; row++)
            {
                if (row % 2 == 0)
                {
                    PrintDebug(" ");
                }

                for (int column = 0; column < 16; column++)
                {
                    if (row == 5 && column == 0)
                    { }
                    //printing the north walls

                    if (row % 2 == 0)
                    {

                        if (column % 2 == 0)
                        {
                            PrintDebug(" ");
                        }

                        else
                        {
                            PrintNorthWall(Maze[row / 2, column / 2]);
                        }
                    }

                    //printing west walls or letters
                    else
                    {
                        if (column == 0)
                        {
                            PrintDebug("" + row / 2);
                        }

                        if (column % 2 == 0)
                        {
                            PrintWestWall(Maze[row / 2, (column + 1) / 2]);
                        }

                        else
                        {
                            PrintDebug("" + Maze[row / 2, column / 2].Character);
                        }
                    }
                }

                PrintDebugLine("");
            }
        }

        private void PrintNorthWall(Node node)
        {
            if (node.North == null)
            {
                PrintDebug("-");
            }

            else
            {
                PrintDebug(" ");
            }
        }

        private void PrintWestWall(Node node)
        {
            if (node.West == null)
            {
                PrintDebug("|");
            }

            else
            {
                PrintDebug(" ");
            }
        }

        /*
           Method that will find find where the user needs to go (Dijkstra)
           -Paramaters (starting position (and where user is facing), ending position)
           -Returns a list of directions
         */

        /// <summary>
        /// Finds the row the of the goal
        /// </summary>
        /// <returns>the row the goal is in</returns>
        public int FindRow()
        {
            int row = Bomb.FirstDigit;

            foreach (Indicator indicator in Bomb.UnlitIndicatorsList)
            {
                if (ValidIndicator(indicator, "MAZE GAMER"))
                {
                    row++;
                }
            }

            return row % 8;
        }

        /// <summary>
        /// Finds the column the of the goal
        /// </summary>
        /// <returns>the column the goal is in</returns>
        public int FindColumn()
        {
            int column = Bomb.LastDigit;

            foreach (Indicator indicator in Bomb.LitIndicatorsList)
            {
                if (ValidIndicator(indicator, "HELP IM LOST"))
                {
                    column++;
                }
            }

            return column % 8;
        }


        /// <summary>
        /// Tells in an indicator is going to be used to find the goal
        /// </summary>
        /// <param name="indicator">the indicator in question</param>
        /// <param name="phrase"></param>
        /// <returns>true if the indicator's name shares a letter with the phrase</returns>
        private bool ValidIndicator(Indicator indicator, string phrase)
        {
            foreach (char c in phrase)
            {
                if (c == ' ')
                {
                    continue;
                }

                if (indicator.Name.Contains(c))
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Find the closetest cardinal based on the player's current position and tell them how to get to that cardinal
        /// </summary>
        /// <param name="playerPosition">where the player currently is and their facing direction</param>
        /// <returns>where the player ends up and their facing direction</returns>
        public int[] FindCardinal(int[] playerPosition)
        {
            Node playerPositionNode = Maze[playerPosition[0], playerPosition[1]];

            //find all of the cardials
            Dictionary<Node, int> cardinalList = new Dictionary<Node, int>();

            foreach (Node node in Maze)
            {
                if (node.Character == '*')
                {
                    cardinalList.Add(node, 0);
                }
            }

            //find the distance of each cardinal based on the player's current position
            for (int i = 0; i < cardinalList.Keys.Count; i++)
            {
                var cardinalVar = cardinalList.ElementAt(i);

                Node cardinal = cardinalVar.Key;

                int rowDistanceSquared = (int)Math.Pow(playerPositionNode.Row - cardinal.Row, 2);
                int columnDistanceSquared = (int)Math.Pow(playerPositionNode.Colunm - cardinal.Colunm, 2);

                int distance = (int)Math.Sqrt(rowDistanceSquared + columnDistanceSquared);

                cardinalList[cardinal] = distance;
            }

            //find the cardianal with the lowest value
            var first = cardinalList.First();

            Node smallestDistanceCardianl = first.Key;

            foreach (Node cardinal in cardinalList.Keys)
            { 
                if(cardinalList[cardinal] < cardinalList[smallestDistanceCardianl])
                {
                    smallestDistanceCardianl = cardinal;
                }
            }

            //set up the maze to find smallest path from where the user started
            Dijkstra(playerPositionNode);

            string playerFacingDirection = ConvertPlayerDirection(playerPosition[2]);


            //find the path to find the cardinal
            ShowAnswer(FindPath(playerPositionNode, smallestDistanceCardianl, playerFacingDirection));

            int playerFacingDirectionInt = ConvertPlayerDirection(playerFacingDirection);

            return new int[3] {smallestDistanceCardianl.Row, smallestDistanceCardianl.Colunm, playerFacingDirectionInt };
        }

        /// <summary>
        /// Converts an int into the direction the player is facing
        /// </summary>
        private string ConvertPlayerDirection(int i)
        {
            switch (i)
            {
                case 0:
                    return "NORTH";

                case 1:
                    return "EAST";

                case 2:
                    return "SOUTH";
                
                default:
                    return "WEST";
            }
        }

        /// <summary>
        /// Converts the player facing direction into an int
        /// </summary>
        private int ConvertPlayerDirection(string direction)
        {
            switch (direction)
            {
                case "NORTH":
                    return 0;

                case "EAST":
                    return 1;

                case "SOUTH":
                    return 2;

                default:
                    return 3;
            }
        }

        /// <summary>
        /// Finds a path from the starting position to the ending position
        /// </summary>
        /// <param name="startingPostion"></param>
        /// <param name="endingPosition"></param>
        private string FindPath(Node startingPostion, Node endingPosition, string playerFacingDirection)
        {
            List<Node> directions = new List<Node>();

            Node currentNode = endingPosition;

            directions.Add(currentNode);

            while (currentNode != startingPostion)
            {
                currentNode = currentNode.PreviousNode;

                directions.Add(currentNode);
            }

            directions.Reverse();

            return ConvertDirections(directions, playerFacingDirection);
        }

        /// <summary>
        /// Converts the direction from a list in to directions the user can user to manuver through the maze
        /// </summary>
        /// <param name="directions">the directions in nodes</param>
        /// <param name="playerFacingDirection">which direction the user is currently facing</param>
        /// <returns></returns>
        private string ConvertDirections(List<Node> directions, string playerFacingDirection)
        {
            List<string> newDirections = new List<string>();

            Node currentNode = directions[0];

            while (currentNode != directions[directions.Count - 1])
            {
                int currentNodeIndex = directions.IndexOf(currentNode);

                //rotate the user to face the next node (if neccessary)
                //and go to the next node

                //North
                if (currentNode.North == directions[currentNodeIndex + 1])
                {
                    if (playerFacingDirection == "NORTH")
                    {
                        newDirections.Add("Foward");
                    }

                    else
                    {
                        while (playerFacingDirection != "NORTH")
                        {
                            playerFacingDirection = RotateClockWise(playerFacingDirection);
                            newDirections.Add("Right");
                        }

                        newDirections.Add("Foward");
                    }
                }

                //East
                else if (currentNode.East == directions[currentNodeIndex + 1])
                {
                    if (playerFacingDirection == "EAST")
                    {
                        newDirections.Add("Foward");
                    }

                    else
                    {
                        while (playerFacingDirection != "EAST")
                        {
                            playerFacingDirection = RotateClockWise(playerFacingDirection);
                            newDirections.Add("Right");
                        }

                        newDirections.Add("Foward");
                    }
                }

                //South
                else if (currentNode.South == directions[currentNodeIndex + 1])
                {
                    if (playerFacingDirection == "SOUTH")
                    {
                        newDirections.Add("Foward");
                    }

                    else
                    {
                        while (playerFacingDirection != "SOUTH")
                        {
                            playerFacingDirection = RotateClockWise(playerFacingDirection);
                            newDirections.Add("Right");
                        }

                        newDirections.Add("Foward");
                    }
                }

                //West
                else
                {
                    if (playerFacingDirection == "WEST")
                    {
                        newDirections.Add("Foward");
                    }

                    else
                    {
                        while (playerFacingDirection != "WEST")
                        {
                            playerFacingDirection = RotateClockWise(playerFacingDirection);
                            newDirections.Add("Right");
                        }

                        newDirections.Add("Foward");
                    }
                }


                currentNode = directions[currentNodeIndex + 1];
            }

            //if there are three rights in a row, replace them with one left

            for (int i = newDirections.Count - 4; i > -1 ; i--)
            {
                string str1 = newDirections[i];
                string str2 = newDirections[i + 1];
                string str3 = newDirections[i + 2];

                if (str1 == "Right" && str1 == str2 && str1 == str3)
                {
                    newDirections.RemoveAt(i + 2);
                    newDirections.RemoveAt(i + 1);
                    newDirections.RemoveAt(i);

                    newDirections.Insert(i, "Left");
                }
            }

            return string.Join(", ", newDirections);
        }

        /// <summary>
        /// Changes the user to face 90 degrees clockwise
        /// </summary>
        /// <param name="playerFacingDirection">what direction the user was facing before</param>
        /// <returns>what direction the user is currently facing</returns>
        private string RotateClockWise(string playerFacingDirection)
        {
            switch (playerFacingDirection)
            {
                case "NORTH":
                    return "EAST";
                case "EAST":
                    return "SOUTH";
                case "SOUTH":
                    return "WEST";
                default:
                    return "NORTH";
            }
        }


        /// <summary>
        /// Finds shortest distance of each Node from the starting Node
        /// </summary>
        /// <param name="startPosition">the starting position</param>
        private void Dijkstra(Node startPosition)
        {
            //set all nodes to unvisted
            //set the distance of those nodes to max value


            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Maze[i, j].Visted = false;
                    Maze[i, j].Distance = int.MaxValue;
                    Maze[i, j].PreviousNode = null;
                }
            }

            //set the start point distance to 0 and visted
            Maze[startPosition.Row, startPosition.Colunm].Distance = 0;
            Maze[startPosition.Row, startPosition.Colunm].Visted = true;

            Node currentNode = Maze[startPosition.Row, startPosition.Colunm];

            //find a list of all the unvistedRooms
            List<Node> unvistedNodes = FindAllUnvistedNodes();


            while (unvistedNodes.Count != 0)
            {
                List<Node> unvistedNeighbors = GetUnvistedNeighbors(currentNode);

                //set the distance of all the neighbors of currentNode
                foreach (Node node in unvistedNeighbors)
                {
                    //find the potential ditance of this neighbor
                    int potentialCost = Maze[currentNode.Row, currentNode.Colunm].Distance + 1;

                    //set the ditance to the potential one if it is less than the current one
                    if (potentialCost < Maze[node.Row, node.Colunm].Distance)
                    {
                        Maze[node.Row, node.Colunm].Distance = potentialCost;
                        node.PreviousNode = currentNode;
                    }
                }

                //find the node with the smallest distance and set that as fully visted
                Node smallestDistanceNode = unvistedNodes[0];

                for (int i = 1; i < unvistedNodes.Count; i++)
                {
                    if (smallestDistanceNode.Distance > unvistedNodes[i].Distance)
                    {
                        smallestDistanceNode = unvistedNodes[i];
                    }
                }

                currentNode = smallestDistanceNode;

                smallestDistanceNode.Visted = true;


                //remove the node with the smallest distance
                unvistedNodes.Remove(smallestDistanceNode);
            }






        }

        private List<Node> FindAllUnvistedNodes()
        {
            List<Node> unvistedNodes = new List<Node>();

                foreach(Node node in Maze)
                {
                    if (!node.Visted)
                    {
                        unvistedNodes.Add(node);
                    }
                }
            

            return unvistedNodes;
        }

        private List<Node> GetUnvistedNeighbors(Node currentNode)
        {
            List<Node> unvistedNeighbors = new List<Node>();

            Node northNode = currentNode.North;
            Node easthNode = currentNode.East;
            Node westhNode = currentNode.West;
            Node southhNode = currentNode.South;

            if (northNode != null && !Maze[northNode.Row, northNode.Colunm].Visted)
            {
                unvistedNeighbors.Add(northNode);
            }

            if (easthNode != null && !Maze[easthNode.Row, easthNode.Colunm].Visted)
            {
                unvistedNeighbors.Add(easthNode);
            }

            if (westhNode != null && !Maze[westhNode.Row, westhNode.Colunm].Visted)
            {
                unvistedNeighbors.Add(westhNode);
            }

            if (southhNode != null && !Maze[southhNode.Row, southhNode.Colunm].Visted)
            {
                unvistedNeighbors.Add(southhNode);
            }

            return unvistedNeighbors;
        }

        private bool AllNodeVisited(bool[,] vistedNodes)
        {
            foreach (bool b in vistedNodes)
            {
                if (!b)
                {
                    return false;
                }
            }

            return true;
        }

        public class Node
        {
            public int Row { get; }
            public int Colunm { get; }
            public char Character { get; }
            public Node North { get; set; }
            public Node East { get; set; }
            public Node South { get; set; }
            public Node West { get; set; }
            public Walls Wall { get; set; }

            public Node PreviousNode { get; set; }
            public int Distance { get; set; }
            public bool Visted { get; set; }

            public Node(int row, int column, char character, Walls wall)
            {
                Row = row;
                Colunm = column;
                Character = character;

                North = null;
                East = null;
                South = null;
                West = null;
                Wall = wall;

                PreviousNode = null;
                Distance = int.MaxValue;
                Visted = true;
            }

            /// <summary>
            /// Method that tells what other nodes current node is connected to
            /// </summary>
            /// <param name="wall">What type of wall is around the node</param>
            /// <param name="maze">The maze the user is in</param>
            /// 
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
                    if (Row == 0)
                    {
                        North = maze[7, Colunm];
                    }

                    else
                    {
                        North = maze[Row - 1, Colunm];
                    }
                }

                if (east)
                {
                    if (Colunm == 7)
                    {
                        East = maze[Row, 0];
                    }

                    else
                    {
                        East = maze[Row, Colunm + 1];
                    }
                }

                if (south)
                {
                    if (Row == 7)
                    {
                        South = maze[0, Colunm];
                    }

                    else
                    {
                        South = maze[Row + 1, Colunm];
                    }
                }

                if (west)
                {
                    if (Colunm == 0)
                    {
                        West = maze[Row, 7];
                    }

                    else
                    {
                        West = maze[Row, Colunm - 1];
                    }
                }
            }

        }
    }
}
