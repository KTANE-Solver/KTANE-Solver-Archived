using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace KTANE_Solver
{
    class _3DMaze : Module
    {
        //FIELDS
        /* a 2D Node array that will represent the maze
         */

        public Node[,] Maze { get; }

        public _3DMaze(Bomb bomb, StreamWriter logFile) : base(bomb, logFile)
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
                Maze[0, 0] = new Node(0, 0, 'D', Walls.North);
                Maze[0, 1] = new Node(0, 1, '.', Walls.South);
                Maze[0, 2] = new Node(0, 2, '.', Walls.Horizontal);
                Maze[0, 3] = new Node(0, 3, '.', Walls.NorthEast);
                Maze[0, 4] = new Node(0, 4, '.', Walls.NorthWest);
                Maze[0, 5] = new Node(0, 5, '.', Walls.South);
                Maze[0, 6] = new Node(0, 6, '.', Walls.Horizontal);
                Maze[0, 7] = new Node(0, 7, '.', Walls.North);

                Maze[1, 0] = new Node(1, 0, '.', Walls.North);
                Maze[1, 1] = new Node(1, 1, '.', Walls.Vertical);
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
                Maze[3, 2] = new Node(3, 2, 'A', Walls.Horizontal);
                Maze[3, 3] = new Node(3, 3, '.', Walls.East);
                Maze[3, 4] = new Node(3, 4, '.', Walls.NorthWest);
                Maze[3, 5] = new Node(3, 5, '.', Walls.Horizontal);
                Maze[3, 6] = new Node(3, 6, '.', Walls.NorthEast);
                Maze[3, 7] = new Node(3, 7, '.', Walls.Vertical);

                Maze[4, 0] = new Node(4, 0, 'D', Walls.NorthEast);
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
                Maze[0, 0] = new Node(0, 0, 'H', Walls.East);
                Maze[0, 1] = new Node(0, 1, '.', Walls.South);
                Maze[0, 2] = new Node(0, 2, 'C', Walls.North);
                Maze[0, 3] = new Node(0, 3, '.', Walls.Horizontal);
                Maze[0, 4] = new Node(0, 4, '.', Walls.NorthEast);
                Maze[0, 5] = new Node(0, 5, '.', Walls.NorthU);
                Maze[0, 6] = new Node(0, 6, 'A', Walls.SouthWest);
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
                Maze[5, 1] = new Node(5, 1, '*', Walls.SouthWest);
                Maze[5, 2] = new Node(5, 2, '.', Walls.SouthEast);
                Maze[5, 3] = new Node(5, 3, '.', Walls.West);
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
                Maze[6, 7] = new Node(6, 7, '.', Walls.NorthEast);

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

                Maze[4, 0] = new Node(4, 0, '.', Walls.West);
                Maze[4, 1] = new Node(4, 1, '.', Walls.South);
                Maze[4, 2] = new Node(4, 2, '.', Walls.Horizontal);
                Maze[4, 3] = new Node(4, 3, '.', Walls.East);
                Maze[4, 4] = new Node(4, 4, 'H', Walls.Vertical);
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

            else if (str.Contains('D') && str.Contains('C') && str.Contains('B'))
            {
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
                Maze[0, 0] = new Node(0, 0, 'C', Walls.NorthWest);
                Maze[0, 1] = new Node(0, 1, '.', Walls.South);
                Maze[0, 2] = new Node(0, 2, '.', Walls.North);
                Maze[0, 3] = new Node(0, 3, '.', Walls.Horizontal);
                Maze[0, 4] = new Node(0, 4, 'H', Walls.West);
                Maze[0, 5] = new Node(0, 5, '.', Walls.SouthU);
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
                Maze[5, 2] = new Node(5, 2, '.', Walls.NorthEast);
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
                Maze[0, 0] = new Node(0, 0, '.', Walls.East);
                Maze[0, 1] = new Node(0, 1, '.', Walls.Vertical);
                Maze[0, 2] = new Node(0, 2, 'D', Walls.NorthWest);
                Maze[0, 3] = new Node(0, 3, '.', Walls.SouthEast);
                Maze[0, 4] = new Node(0, 4, 'B', Walls.West);
                Maze[0, 5] = new Node(0, 5, '.', Walls.None);
                Maze[0, 6] = new Node(0, 6, '.', Walls.None);
                Maze[0, 7] = new Node(0, 7, 'H', Walls.North);

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
                Maze[2, 6] = new Node(2, 6, 'B', Walls.SouthEast);
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
                Maze[4, 3] = new Node(4, 3, '.', Walls.NorthEast);
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
                Maze[6, 1] = new Node(6, 1, '.', Walls.EastU);
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

            else
            {
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

                Maze[3, 0] = new Node(3, 0, 'H', Walls.West);
                Maze[3, 1] = new Node(3, 1, '.', Walls.Horizontal);
                Maze[3, 2] = new Node(3, 2, '.', Walls.SouthEast);
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
                Maze[4, 7] = new Node(4, 7, '.', Walls.None);

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
                Maze[6, 6] = new Node(6, 6, '*', Walls.SouthEast);
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
                if(row % 2 == 0)
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
                            PrintWestWall(Maze[row / 2, (column + 1) / 2 ]);
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
