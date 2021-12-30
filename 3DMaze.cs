using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTANE_Solver
{
    class _3DMaze
    {
        //FIELDS
        /* a 2D Node array that will represent the maze
         */

        public Node[,] Maze { get; }

        public _3DMaze()
        {
            Maze = new Node[8, 8];
        }

        private enum Walls
        {
            //1 walls

            Up,
            Right,
            Down,
            Left,

            //2 walls
            Vertical,
            Horizontal,
            NorthWestWall,
            NorthEastWall,
            SouthEastWall,
            SouthWestWall,

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
        public void SetMaze(char char1, char char2, char char3)
        {
            string str = "" + char1 + char2 + char3;

            if (str.Contains('A') && str.Contains('B') && str.Contains('C'))
            {
                Maze[0, 0] = new Node(0, 0, '.');
                Maze[0, 1] = new Node(0, 1, '.');
                Maze[0, 2] = new Node(0, 2, '.');
                Maze[0, 3] = new Node(0, 3, '.');
                Maze[0, 4] = new Node(0, 4, '.');
                Maze[0, 5] = new Node(0, 5, 'A');
                Maze[0, 6] = new Node(0, 6, '.');
                Maze[0, 7] = new Node(0, 7, '.');

                Maze[1, 0] = new Node(1, 0, '.');
                Maze[1, 1] = new Node(1, 1, '*');
                Maze[1, 2] = new Node(1, 2, 'A');
                Maze[1, 3] = new Node(1, 3, '.');
                Maze[1, 4] = new Node(1, 4, '.');
                Maze[1, 5] = new Node(1, 5, '.');
                Maze[1, 6] = new Node(1, 6, '.');
                Maze[1, 7] = new Node(1, 7, 'B');

                Maze[2, 0] = new Node(2, 0, 'A');
                Maze[2, 1] = new Node(2, 1, '.');
                Maze[2, 2] = new Node(2, 2, '.');
                Maze[2, 3] = new Node(2, 3, 'B');
                Maze[2, 4] = new Node(2, 4, '.');
                Maze[2, 5] = new Node(2, 5, 'C');
                Maze[2, 6] = new Node(2, 6, '.');
                Maze[2, 7] = new Node(2, 7, '.');

                Maze[3, 0] = new Node(3, 0, '.');
                Maze[3, 1] = new Node(3, 1, 'C');
                Maze[3, 2] = new Node(3, 2, '.');
                Maze[3, 3] = new Node(3, 3, '.');
                Maze[3, 4] = new Node(3, 4, '*');
                Maze[3, 5] = new Node(3, 5, '.');
                Maze[3, 6] = new Node(3, 6, '.');
                Maze[3, 7] = new Node(3, 7, 'B');

                Maze[4, 0] = new Node(4, 0, '.');
                Maze[4, 1] = new Node(4, 1, '.');
                Maze[4, 2] = new Node(4, 2, '.');
                Maze[4, 3] = new Node(4, 3, '.');
                Maze[4, 4] = new Node(4, 4, '.');
                Maze[4, 5] = new Node(4, 5, 'A');
                Maze[4, 6] = new Node(4, 6, '.');
                Maze[4, 7] = new Node(4, 7, '.');

                Maze[5, 0] = new Node(5, 0, '.');
                Maze[5, 1] = new Node(5, 1, 'B');
                Maze[5, 2] = new Node(5, 2, '.');
                Maze[5, 3] = new Node(5, 3, 'C');
                Maze[5, 4] = new Node(5, 4, '.');
                Maze[5, 5] = new Node(5, 5, '.');
                Maze[5, 6] = new Node(5, 6, 'B');
                Maze[5, 7] = new Node(5, 7, '.');

                Maze[6, 0] = new Node(6, 0, '*');
                Maze[6, 1] = new Node(6, 1, '.');
                Maze[6, 2] = new Node(6, 2, 'C');
                Maze[6, 3] = new Node(6, 3, '.');
                Maze[6, 4] = new Node(6, 4, '.');
                Maze[6, 5] = new Node(6, 5, '.');
                Maze[6, 6] = new Node(6, 6, '.');
                Maze[6, 7] = new Node(6, 7, '.');

                Maze[7, 0] = new Node(7, 0, '.');
                Maze[7, 1] = new Node(7, 1, '.');
                Maze[7, 2] = new Node(7, 2, '.');
                Maze[7, 3] = new Node(7, 3, '.');
                Maze[7, 4] = new Node(7, 4, 'A');
                Maze[7, 5] = new Node(7, 5, '.');
                Maze[7, 6] = new Node(7, 6, 'C');
                Maze[7, 7] = new Node(7, 7, '.');

                SetMazeConnection(Maze[0, 0], Walls.NorthWestWall);
                SetMazeConnection(Maze[0, 1], Walls.NorthEastWall);
                SetMazeConnection(Maze[0, 2], Walls.Left);
                SetMazeConnection(Maze[0, 3], Walls.Right);
                SetMazeConnection(Maze[0, 4], Walls.SouthWestWall);
                SetMazeConnection(Maze[0, 5], Walls.Up);
                SetMazeConnection(Maze[0, 6], Walls.NorthEastWall);
                SetMazeConnection(Maze[0, 7], Walls.Vertical);

                SetMazeConnection(Maze[1, 0], Walls.Left);
                SetMazeConnection(Maze[1, 1], Walls.SouthEastWall);
                SetMazeConnection(Maze[1, 2], Walls.Left);
                SetMazeConnection(Maze[1, 3], Walls.Down);
                SetMazeConnection(Maze[1, 4], Walls.EastU);
                SetMazeConnection(Maze[1, 5], Walls.SouthWestWall);
                SetMazeConnection(Maze[1, 6], Walls.None);
                SetMazeConnection(Maze[1, 7], Walls.Right);

                SetMazeConnection(Maze[2, 0], Walls.None);
                SetMazeConnection(Maze[2, 1], Walls.Up);
                SetMazeConnection(Maze[2, 2], Walls.SouthEastWall);
                SetMazeConnection(Maze[2, 3], Walls.NorthWestWall);
                SetMazeConnection(Maze[2, 4], Walls.Up);
                SetMazeConnection(Maze[2, 5], Walls.Up);
                SetMazeConnection(Maze[2, 6], Walls.SouthEastWall);
                SetMazeConnection(Maze[2, 7], Walls.SouthWestWall);

                SetMazeConnection(Maze[3, 0], Walls.None);
                SetMazeConnection(Maze[3, 1], Walls.Right);
                SetMazeConnection(Maze[3, 2], Walls.Left);
                SetMazeConnection(Maze[3, 3], Walls.NorthEastWall);
                SetMazeConnection(Maze[3, 4], Walls.SouthWestWall);
                SetMazeConnection(Maze[3, 5], Walls.Vertical);
                SetMazeConnection(Maze[3, 6], Walls.NorthEastWall);
                SetMazeConnection(Maze[3, 7], Walls.Horizontal);

                SetMazeConnection(Maze[4, 0], Walls.NorthEastWall);
                SetMazeConnection(Maze[4, 1], Walls.Left);
                SetMazeConnection(Maze[4, 2], Walls.Right);
                SetMazeConnection(Maze[4, 3], Walls.NorthWestWall);
                SetMazeConnection(Maze[4, 4], Walls.Up);
                SetMazeConnection(Maze[4, 5], Walls.Down);
                SetMazeConnection(Maze[4, 6], Walls.Right);
                SetMazeConnection(Maze[4, 7], Walls.NorthWestWall);

                SetMazeConnection(Maze[5, 0], Walls.Right);
                SetMazeConnection(Maze[5, 2], Walls.Left);
                SetMazeConnection(Maze[5, 1], Walls.SouthWestWall);
                SetMazeConnection(Maze[5, 3], Walls.Down);
                SetMazeConnection(Maze[5, 4], Walls.Right);
                SetMazeConnection(Maze[5, 5], Walls.NorthWestWall);
                SetMazeConnection(Maze[5, 6], Walls.Down);
                SetMazeConnection(Maze[5, 7], Walls.None);

                SetMazeConnection(Maze[6, 0], Walls.SouthEastWall);
                SetMazeConnection(Maze[6, 1], Walls.SouthWestWall);
                SetMazeConnection(Maze[6, 2], Walls.NorthWestWall);
                SetMazeConnection(Maze[6, 3], Walls.NorthEastWall);
                SetMazeConnection(Maze[6, 4], Walls.Vertical);
                SetMazeConnection(Maze[6, 5], Walls.Left);
                SetMazeConnection(Maze[6, 6], Walls.NorthWestWall);
                SetMazeConnection(Maze[6, 7], Walls.SouthEastWall);

                SetMazeConnection(Maze[7, 0], Walls.Horizontal);
                SetMazeConnection(Maze[7, 1], Walls.Horizontal);
                SetMazeConnection(Maze[7, 2], Walls.EastU);
                SetMazeConnection(Maze[7, 3], Walls.Right);
                SetMazeConnection(Maze[7, 4], Walls.Vertical);
                SetMazeConnection(Maze[7, 5], Walls.Left);
                SetMazeConnection(Maze[7, 6], Walls.NorthEastWall);
                SetMazeConnection(Maze[7, 7], Walls.SouthWestWall);
            }

            else if (str.Contains('A') && str.Contains('B') && str.Contains('D'))
            {
                Maze[0, 0] = new Node(0, 0, 'A');
                Maze[0, 1] = new Node(0, 1, '.');
                Maze[0, 2] = new Node(0, 2, '.');
                Maze[0, 3] = new Node(0, 3, 'B');
                Maze[0, 4] = new Node(0, 4, '.');
                Maze[0, 5] = new Node(0, 5, '.');
                Maze[0, 6] = new Node(0, 6, 'A');
                Maze[0, 7] = new Node(0, 7, '*');

                Maze[1, 0] = new Node(1, 0, '.');
                Maze[1, 1] = new Node(1, 1, '.');
                Maze[1, 2] = new Node(1, 2, 'D');
                Maze[1, 3] = new Node(1, 3, '.');
                Maze[1, 4] = new Node(1, 4, '.');
                Maze[1, 5] = new Node(1, 5, '.');
                Maze[1, 6] = new Node(1, 6, '.');
                Maze[1, 7] = new Node(1, 7, '.');

                Maze[2, 0] = new Node(2, 0, '.');
                Maze[2, 1] = new Node(2, 1, '.');
                Maze[2, 2] = new Node(2, 2, '.');
                Maze[2, 3] = new Node(2, 3, '.');
                Maze[2, 4] = new Node(2, 4, '.');
                Maze[2, 5] = new Node(2, 5, 'D');
                Maze[2, 6] = new Node(2, 6, '.');
                Maze[2, 7] = new Node(2, 7, 'B');

                Maze[3, 0] = new Node(3, 0, '.');
                Maze[3, 1] = new Node(3, 1, 'A');
                Maze[3, 2] = new Node(3, 2, '.');
                Maze[3, 3] = new Node(3, 3, 'B');
                Maze[3, 4] = new Node(3, 4, '.');
                Maze[3, 5] = new Node(3, 5, '.');
                Maze[3, 6] = new Node(3, 6, '.');
                Maze[3, 7] = new Node(3, 7, '.');

                Maze[4, 0] = new Node(4, 0, '.');
                Maze[4, 1] = new Node(4, 1, '.');
                Maze[4, 2] = new Node(4, 2, '*');
                Maze[4, 3] = new Node(4, 3, '.');
                Maze[4, 4] = new Node(4, 4, '.');
                Maze[4, 5] = new Node(4, 5, '.');
                Maze[4, 6] = new Node(4, 6, 'A');
                Maze[4, 7] = new Node(4, 7, '.');

                Maze[5, 0] = new Node(5, 0, 'D');
                Maze[5, 1] = new Node(5, 1, '.');
                Maze[5, 2] = new Node(5, 2, '.');
                Maze[5, 3] = new Node(5, 3, '.');
                Maze[5, 4] = new Node(5, 4, 'A');
                Maze[5, 5] = new Node(5, 5, '.');
                Maze[5, 6] = new Node(5, 6, '.');
                Maze[5, 7] = new Node(5, 7, '.');

                Maze[6, 0] = new Node(6, 0, '.');
                Maze[6, 1] = new Node(6, 1, '.');
                Maze[6, 2] = new Node(6, 2, '.');
                Maze[6, 3] = new Node(6, 3, 'B');
                Maze[6, 4] = new Node(6, 4, '.');
                Maze[6, 5] = new Node(6, 5, 'D');
                Maze[6, 6] = new Node(6, 6, '.');
                Maze[6, 7] = new Node(6, 7, '.');

                Maze[7, 0] = new Node(7, 0, '.');
                Maze[7, 1] = new Node(7, 1, '.');
                Maze[7, 2] = new Node(7, 2, 'D');
                Maze[7, 3] = new Node(7, 3, '.');
                Maze[7, 4] = new Node(7, 4, '*');
                Maze[7, 5] = new Node(7, 5, '.');
                Maze[7, 6] = new Node(7, 6, '.');
                Maze[7, 7] = new Node(7, 7, 'B');

                SetMazeConnection(Maze[0, 0], Walls.NorthEastWall);
                SetMazeConnection(Maze[0, 1], Walls.Down);
                SetMazeConnection(Maze[0, 2], Walls.Vertical);
                SetMazeConnection(Maze[0, 3], Walls.None);
                SetMazeConnection(Maze[0, 4], Walls.None);
                SetMazeConnection(Maze[0, 5], Walls.SouthEastWall);
                SetMazeConnection(Maze[0, 6], Walls.NorthWestWall);
                SetMazeConnection(Maze[0, 7], Walls.NorthEastWall);

                SetMazeConnection(Maze[1, 0], Walls.Vertical);
                SetMazeConnection(Maze[1, 1], Walls.NorthEastWall);
                SetMazeConnection(Maze[1, 2], Walls.Up);
                SetMazeConnection(Maze[1, 3], Walls.Down);
                SetMazeConnection(Maze[1, 4], Walls.SouthEastWall);
                SetMazeConnection(Maze[1, 5], Walls.NorthWestWall);
                SetMazeConnection(Maze[1, 6], Walls.Down);
                SetMazeConnection(Maze[1, 7], Walls.Left);

                SetMazeConnection(Maze[2, 0], Walls.None);
                SetMazeConnection(Maze[2, 1], Walls.None);
                SetMazeConnection(Maze[2, 2], Walls.SouthEastWall);
                SetMazeConnection(Maze[2, 3], Walls.NorthWestWall);
                SetMazeConnection(Maze[2, 4], Walls.Up);
                SetMazeConnection(Maze[2, 5], Walls.None);
                SetMazeConnection(Maze[2, 6], Walls.NorthEastWall);
                SetMazeConnection(Maze[2, 7], Walls.Left);

                SetMazeConnection(Maze[3, 0], Walls.SouthEastWall);
                SetMazeConnection(Maze[3, 1], Walls.SouthWestWall);
                SetMazeConnection(Maze[3, 2], Walls.Horizontal);
                SetMazeConnection(Maze[3, 3], Walls.None);
                SetMazeConnection(Maze[3, 4], Walls.Right);
                SetMazeConnection(Maze[3, 5], Walls.SouthWestWall);
                SetMazeConnection(Maze[3, 6], Walls.Down);
                SetMazeConnection(Maze[3, 7], Walls.None);

                SetMazeConnection(Maze[4, 0], Walls.NorthEastWall);
                SetMazeConnection(Maze[4, 1], Walls.Up);
                SetMazeConnection(Maze[4, 2], Walls.NorthEastWall);
                SetMazeConnection(Maze[4, 3], Walls.SouthWestWall);
                SetMazeConnection(Maze[4, 4], Walls.None);
                SetMazeConnection(Maze[4, 5], Walls.Horizontal);
                SetMazeConnection(Maze[4, 6], Walls.NorthEastWall);
                SetMazeConnection(Maze[4, 7], Walls.Vertical);

                SetMazeConnection(Maze[5, 0], Walls.Down);
                SetMazeConnection(Maze[5, 1], Walls.None);
                SetMazeConnection(Maze[5, 2], Walls.SouthEastWall);
                SetMazeConnection(Maze[5, 3], Walls.NorthEastWall);
                SetMazeConnection(Maze[5, 4], Walls.Right);
                SetMazeConnection(Maze[5, 5], Walls.NorthWestWall);
                SetMazeConnection(Maze[5, 6], Walls.None);
                SetMazeConnection(Maze[5, 7], Walls.Down);
                SetMazeConnection(Maze[6, 0], Walls.NorthEastWall);
                SetMazeConnection(Maze[6, 1], Walls.Left);
                SetMazeConnection(Maze[6, 2], Walls.Up);
                SetMazeConnection(Maze[6, 3], Walls.Down);
                SetMazeConnection(Maze[6, 4], Walls.SouthEastWall);
                SetMazeConnection(Maze[6, 5], Walls.Left);
                SetMazeConnection(Maze[6, 6], Walls.Right);
                SetMazeConnection(Maze[6, 7], Walls.NorthEastWall);

                SetMazeConnection(Maze[7, 0], Walls.Down);
                SetMazeConnection(Maze[7, 1], Walls.None);
                SetMazeConnection(Maze[7, 2], Walls.SouthEastWall);
                SetMazeConnection(Maze[7, 3], Walls.NorthWestWall);
                SetMazeConnection(Maze[7, 4], Walls.NorthEastWall);
                SetMazeConnection(Maze[7, 5], Walls.Left);
                SetMazeConnection(Maze[7, 6], Walls.Down);
                SetMazeConnection(Maze[7, 7], Walls.Down);
            }

            else if (str.Contains('A') && str.Contains('C') && str.Contains('H'))
            {
                Maze[0, 0] = new Node(0, 0, 'B');
                Maze[0, 1] = new Node(0, 1, '.');
                Maze[0, 2] = new Node(0, 2, '.');
                Maze[0, 3] = new Node(0, 3, '.');
                Maze[0, 4] = new Node(0, 4, '.');
                Maze[0, 5] = new Node(0, 5, 'A');
                Maze[0, 6] = new Node(0, 6, '.');
                Maze[0, 7] = new Node(0, 7, 'H');

                Maze[1, 0] = new Node(1, 0, '*');
                Maze[1, 1] = new Node(1, 1, '.');
                Maze[1, 2] = new Node(1, 2, 'H');
                Maze[1, 3] = new Node(1, 3, '.');
                Maze[1, 4] = new Node(1, 4, '.');
                Maze[1, 5] = new Node(1, 5, '.');
                Maze[1, 6] = new Node(1, 6, '.');
                Maze[1, 7] = new Node(1, 7, '.');

                Maze[2, 0] = new Node(2, 0, 'B');
                Maze[2, 1] = new Node(2, 1, '.');
                Maze[2, 2] = new Node(2, 2, '.');
                Maze[2, 3] = new Node(2, 3, '.');
                Maze[2, 4] = new Node(2, 4, 'B');
                Maze[2, 5] = new Node(2, 5, '.');
                Maze[2, 6] = new Node(2, 6, '.');
                Maze[2, 7] = new Node(2, 7, '.');

                Maze[3, 0] = new Node(3, 0, '.');
                Maze[3, 1] = new Node(3, 1, '.');
                Maze[3, 2] = new Node(3, 2, '.');
                Maze[3, 3] = new Node(3, 3, '.');
                Maze[3, 4] = new Node(3, 4, '*');
                Maze[3, 5] = new Node(3, 5, '.');
                Maze[3, 6] = new Node(3, 6, 'H');
                Maze[3, 7] = new Node(3, 7, 'A');

                Maze[4, 0] = new Node(4, 0, '.');
                Maze[4, 1] = new Node(4, 1, 'A');
                Maze[4, 2] = new Node(4, 2, '.');
                Maze[4, 3] = new Node(4, 3, 'H');
                Maze[4, 4] = new Node(4, 4, '.');
                Maze[4, 5] = new Node(4, 5, '.');
                Maze[4, 6] = new Node(4, 6, '.');
                Maze[4, 7] = new Node(4, 7, '.');

                Maze[5, 0] = new Node(5, 0, '.');
                Maze[5, 1] = new Node(5, 1, '.');
                Maze[5, 2] = new Node(5, 2, '.');
                Maze[5, 3] = new Node(5, 3, '.');
                Maze[5, 4] = new Node(5, 4, 'A');
                Maze[5, 5] = new Node(5, 5, '.');
                Maze[5, 6] = new Node(5, 6, 'B');
                Maze[5, 7] = new Node(5, 7, '.');

                Maze[6, 0] = new Node(6, 0, '.');
                Maze[6, 1] = new Node(6, 1, 'B');
                Maze[6, 2] = new Node(6, 2, '.');
                Maze[6, 3] = new Node(6, 3, '.');
                Maze[6, 4] = new Node(6, 4, '.');
                Maze[6, 5] = new Node(6, 5, '*');
                Maze[6, 6] = new Node(6, 6, '.');
                Maze[6, 7] = new Node(6, 7, '.');

                Maze[7, 0] = new Node(7, 0, 'A');
                Maze[7, 1] = new Node(7, 1, '.');
                Maze[7, 2] = new Node(7, 2, '.');
                Maze[7, 3] = new Node(7, 3, 'H');
                Maze[7, 4] = new Node(7, 4, '.');
                Maze[7, 5] = new Node(7, 5, '.');
                Maze[7, 6] = new Node(7, 6, '.');
                Maze[7, 7] = new Node(7, 7, '.');

                SetMazeConnection(Maze[0, 0], Walls.NorthWestWall);
                SetMazeConnection(Maze[0, 1], Walls.Horizontal);
                SetMazeConnection(Maze[0, 2], Walls.NorthEastWall);
                SetMazeConnection(Maze[0, 3], Walls.SouthWestWall);
                SetMazeConnection(Maze[0, 4], Walls.Vertical);
                SetMazeConnection(Maze[0, 5], Walls.None);
                SetMazeConnection(Maze[0, 6], Walls.Up);
                SetMazeConnection(Maze[0, 7], Walls.NorthEastWall);

                SetMazeConnection(Maze[1, 0], Walls.SouthEastWall);
                SetMazeConnection(Maze[1, 1], Walls.NorthWestWall);
                SetMazeConnection(Maze[1, 2], Walls.None);
                SetMazeConnection(Maze[1, 3], Walls.Up);
                SetMazeConnection(Maze[1, 4], Walls.Horizontal);
                SetMazeConnection(Maze[1, 5], Walls.Down);
                SetMazeConnection(Maze[1, 6], Walls.Right);
                SetMazeConnection(Maze[1, 7], Walls.SouthWestWall);

                SetMazeConnection(Maze[2, 0], Walls.Up);
                SetMazeConnection(Maze[2, 1], Walls.NorthEastWall);
                SetMazeConnection(Maze[2, 2], Walls.Vertical);
                SetMazeConnection(Maze[2, 3], Walls.SouthWestWall);
                SetMazeConnection(Maze[2, 4], Walls.Up);
                SetMazeConnection(Maze[2, 5], Walls.NorthEastWall);
                SetMazeConnection(Maze[2, 6], Walls.Vertical);
                SetMazeConnection(Maze[2, 7], Walls.Left);

                SetMazeConnection(Maze[3, 0], Walls.Vertical);
                SetMazeConnection(Maze[3, 1], Walls.NorthEastWall);
                SetMazeConnection(Maze[3, 2], Walls.Right);
                SetMazeConnection(Maze[3, 3], Walls.NorthWestWall);
                SetMazeConnection(Maze[3, 4], Walls.SouthEastWall);
                SetMazeConnection(Maze[3, 5], Walls.Left);
                SetMazeConnection(Maze[3, 6], Walls.Right);
                SetMazeConnection(Maze[3, 7], Walls.Vertical);

                SetMazeConnection(Maze[4, 0], Walls.Vertical);
                SetMazeConnection(Maze[4, 1], Walls.Left);
                SetMazeConnection(Maze[4, 2], Walls.SouthEastWall);
                SetMazeConnection(Maze[4, 3], Walls.SouthWestWall);
                SetMazeConnection(Maze[4, 4], Walls.Up);
                SetMazeConnection(Maze[4, 5], Walls.SouthEastWall);
                SetMazeConnection(Maze[4, 6], Walls.Left);
                SetMazeConnection(Maze[4, 7], Walls.Right);

                SetMazeConnection(Maze[5, 0], Walls.Vertical);
                SetMazeConnection(Maze[5, 1], Walls.Vertical);
                SetMazeConnection(Maze[5, 2], Walls.WestU);
                SetMazeConnection(Maze[5, 3], Walls.Up);
                SetMazeConnection(Maze[5, 4], Walls.Down);
                SetMazeConnection(Maze[5, 5], Walls.Horizontal);
                SetMazeConnection(Maze[5, 6], Walls.Down);
                SetMazeConnection(Maze[5, 7], Walls.Right);

                SetMazeConnection(Maze[6, 0], Walls.None);
                SetMazeConnection(Maze[6, 1], Walls.Down);
                SetMazeConnection(Maze[6, 2], Walls.EastU);
                SetMazeConnection(Maze[6, 3], Walls.Left);
                SetMazeConnection(Maze[6, 4], Walls.NorthEastWall);
                SetMazeConnection(Maze[6, 5], Walls.NorthWestWall);
                SetMazeConnection(Maze[6, 6], Walls.NorthEastWall);
                SetMazeConnection(Maze[6, 7], Walls.Left);

                SetMazeConnection(Maze[7, 0], Walls.Down);
                SetMazeConnection(Maze[7, 1], Walls.Horizontal);
                SetMazeConnection(Maze[7, 2], Walls.Horizontal);
                SetMazeConnection(Maze[7, 3], Walls.None);
                SetMazeConnection(Maze[7, 4], Walls.Down);
                SetMazeConnection(Maze[7, 5], Walls.None);
                SetMazeConnection(Maze[7, 6], Walls.SouthWestWall);
                SetMazeConnection(Maze[7, 7], Walls.SouthEastWall);
            }

            else if (str.Contains('A') && str.Contains('B') && str.Contains('H'))
            {
                Maze[0, 0] = new Node(0, 0, 'D');
                Maze[0, 1] = new Node(0, 1, '.');
                Maze[0, 2] = new Node(0, 2, '.');
                Maze[0, 3] = new Node(0, 3, '.');
                Maze[0, 4] = new Node(0, 4, '.');
                Maze[0, 5] = new Node(0, 5, '.');
                Maze[0, 6] = new Node(0, 6, '.');
                Maze[0, 7] = new Node(0, 7, '.');

                Maze[1, 0] = new Node(1, 0, '.');
                Maze[1, 1] = new Node(1, 1, '.');
                Maze[1, 2] = new Node(1, 2, 'C');
                Maze[1, 3] = new Node(1, 3, '.');
                Maze[1, 4] = new Node(1, 4, 'D');
                Maze[1, 5] = new Node(1, 5, '*');
                Maze[1, 6] = new Node(1, 6, '.');
                Maze[1, 7] = new Node(1, 7, 'C');

                Maze[2, 0] = new Node(2, 0, '.');
                Maze[2, 1] = new Node(2, 1, '.');
                Maze[2, 2] = new Node(2, 2, '*');
                Maze[2, 3] = new Node(2, 3, '.');
                Maze[2, 4] = new Node(2, 4, '.');
                Maze[2, 5] = new Node(2, 5, 'C');
                Maze[2, 6] = new Node(2, 6, '.');
                Maze[2, 7] = new Node(2, 7, '.');

                Maze[3, 0] = new Node(3, 0, '.');
                Maze[3, 1] = new Node(3, 1, 'A');
                Maze[3, 2] = new Node(3, 2, '.');
                Maze[3, 3] = new Node(3, 3, '.');
                Maze[3, 4] = new Node(3, 4, '.');
                Maze[3, 5] = new Node(3, 5, '.');
                Maze[3, 6] = new Node(3, 6, '.');
                Maze[3, 7] = new Node(3, 7, '.');

                Maze[4, 0] = new Node(4, 0, 'D');
                Maze[4, 1] = new Node(4, 1, '.');
                Maze[4, 2] = new Node(4, 2, '.');
                Maze[4, 3] = new Node(4, 3, 'C');
                Maze[4, 4] = new Node(4, 4, '.');
                Maze[4, 5] = new Node(4, 5, 'D');
                Maze[4, 6] = new Node(4, 6, '.');
                Maze[4, 7] = new Node(4, 7, '.');

                Maze[5, 0] = new Node(5, 0, '.');
                Maze[5, 1] = new Node(5, 1, '.');
                Maze[5, 2] = new Node(5, 2, '.');
                Maze[5, 3] = new Node(5, 3, 'A');
                Maze[5, 4] = new Node(5, 4, '.');
                Maze[5, 5] = new Node(5, 5, '*');
                Maze[5, 6] = new Node(5, 6, '.');
                Maze[5, 7] = new Node(5, 7, 'A');

                Maze[6, 0] = new Node(6, 0, '.');
                Maze[6, 1] = new Node(6, 1, '.');
                Maze[6, 2] = new Node(6, 2, '.');
                Maze[6, 3] = new Node(6, 3, 'A');
                Maze[6, 4] = new Node(6, 4, '.');
                Maze[6, 5] = new Node(6, 5, '.');
                Maze[6, 6] = new Node(6, 6, 'D');
                Maze[6, 7] = new Node(6, 7, '.');

                Maze[7, 0] = new Node(7, 0, 'A');
                Maze[7, 1] = new Node(7, 1, '.');
                Maze[7, 2] = new Node(7, 2, '.');
                Maze[7, 3] = new Node(7, 3, '.');
                Maze[7, 4] = new Node(7, 4, '.');
                Maze[7, 5] = new Node(7, 5, 'C');
                Maze[7, 6] = new Node(7, 6, '.');
                Maze[7, 7] = new Node(7, 7, '.');

                SetMazeConnection(Maze[0, 0], Walls.Up);
                SetMazeConnection(Maze[0, 1], Walls.Down);
                SetMazeConnection(Maze[0, 2], Walls.Horizontal);
                SetMazeConnection(Maze[0, 3], Walls.NorthEastWall);
                SetMazeConnection(Maze[0, 4], Walls.NorthWestWall);
                SetMazeConnection(Maze[0, 5], Walls.Down);
                SetMazeConnection(Maze[0, 6], Walls.Horizontal);
                SetMazeConnection(Maze[0, 7], Walls.Up);

                SetMazeConnection(Maze[1, 0], Walls.Vertical);
                SetMazeConnection(Maze[1, 1], Walls.NorthEastWall);
                SetMazeConnection(Maze[1, 2], Walls.Up);
                SetMazeConnection(Maze[1, 3], Walls.Right);
                SetMazeConnection(Maze[1, 4], Walls.Vertical);
                SetMazeConnection(Maze[1, 5], Walls.WestU);
                SetMazeConnection(Maze[1, 6], Walls.Horizontal);
                SetMazeConnection(Maze[1, 7], Walls.SouthEastWall);

                SetMazeConnection(Maze[2, 0], Walls.Right);
                SetMazeConnection(Maze[2, 1], Walls.SouthU);
                SetMazeConnection(Maze[2, 2], Walls.Vertical);
                SetMazeConnection(Maze[2, 3], Walls.Left);
                SetMazeConnection(Maze[2, 4], Walls.None);
                SetMazeConnection(Maze[2, 5], Walls.NorthEastWall);
                SetMazeConnection(Maze[2, 6], Walls.NorthWestWall);
                SetMazeConnection(Maze[2, 7], Walls.Up);

                SetMazeConnection(Maze[3, 0], Walls.SouthWestWall);
                SetMazeConnection(Maze[3, 1], Walls.Horizontal);
                SetMazeConnection(Maze[3, 2], Walls.Horizontal);
                SetMazeConnection(Maze[3, 3], Walls.Right);
                SetMazeConnection(Maze[3, 4], Walls.NorthWestWall);
                SetMazeConnection(Maze[3, 5], Walls.Horizontal);
                SetMazeConnection(Maze[3, 6], Walls.NorthEastWall);
                SetMazeConnection(Maze[3, 7], Walls.Vertical);

                SetMazeConnection(Maze[4, 0], Walls.NorthEastWall);
                SetMazeConnection(Maze[4, 1], Walls.Horizontal);
                SetMazeConnection(Maze[4, 2], Walls.Right);
                SetMazeConnection(Maze[4, 3], Walls.Vertical);
                SetMazeConnection(Maze[4, 4], Walls.NorthEastWall);
                SetMazeConnection(Maze[4, 5], Walls.Horizontal);
                SetMazeConnection(Maze[4, 6], Walls.NorthEastWall);
                SetMazeConnection(Maze[4, 7], Walls.Vertical);

                SetMazeConnection(Maze[5, 0], Walls.Right);
                SetMazeConnection(Maze[5, 1], Walls.NorthU);
                SetMazeConnection(Maze[5, 2], Walls.NorthWestWall);
                SetMazeConnection(Maze[5, 3], Walls.Down);
                SetMazeConnection(Maze[5, 4], Walls.Right);
                SetMazeConnection(Maze[5, 5], Walls.WestU);
                SetMazeConnection(Maze[5, 6], Walls.SouthWestWall);
                SetMazeConnection(Maze[5, 7], Walls.Left);

                SetMazeConnection(Maze[6, 0], Walls.Right);
                SetMazeConnection(Maze[6, 1], Walls.SouthWestWall);
                SetMazeConnection(Maze[6, 2], Walls.SouthEastWall);
                SetMazeConnection(Maze[6, 3], Walls.NorthWestWall);
                SetMazeConnection(Maze[6, 4], Walls.Down);
                SetMazeConnection(Maze[6, 5], Walls.Vertical);
                SetMazeConnection(Maze[6, 6], Walls.Up);
                SetMazeConnection(Maze[6, 7], Walls.None);

                SetMazeConnection(Maze[7, 0], Walls.SouthWestWall);
                SetMazeConnection(Maze[7, 1], Walls.Up);
                SetMazeConnection(Maze[7, 2], Walls.Horizontal);
                SetMazeConnection(Maze[7, 3], Walls.Down);
                SetMazeConnection(Maze[7, 4], Walls.Horizontal);
                SetMazeConnection(Maze[7, 5], Walls.NorthEastWall);
                SetMazeConnection(Maze[7, 6], Walls.SouthWestWall);
                SetMazeConnection(Maze[7, 7], Walls.SouthEastWall);
            }

            else if (str.Contains('A') && str.Contains('C') && str.Contains('H'))
            {
                Maze[0, 0] = new Node(0, 0, 'H');
                Maze[0, 1] = new Node(0, 1, '.');
                Maze[0, 2] = new Node(0, 2, 'C');
                Maze[0, 3] = new Node(0, 3, '.');
                Maze[0, 4] = new Node(0, 4, '.');
                Maze[0, 5] = new Node(0, 5, '.');
                Maze[0, 6] = new Node(0, 6, 'A');
                Maze[0, 7] = new Node(0, 7, '.');

                Maze[1, 0] = new Node(1, 0, '*');
                Maze[1, 1] = new Node(1, 1, '.');
                Maze[1, 2] = new Node(1, 2, '.');
                Maze[1, 3] = new Node(1, 3, '.');
                Maze[1, 4] = new Node(1, 4, 'H');
                Maze[1, 5] = new Node(1, 5, '.');
                Maze[1, 6] = new Node(1, 6, '.');
                Maze[1, 7] = new Node(1, 7, '.');

                Maze[2, 0] = new Node(2, 0, '.');
                Maze[2, 1] = new Node(2, 1, '.');
                Maze[2, 2] = new Node(2, 2, '.');
                Maze[2, 3] = new Node(2, 3, '.');
                Maze[2, 4] = new Node(2, 4, '.');
                Maze[2, 5] = new Node(2, 5, '.');
                Maze[2, 6] = new Node(2, 6, '*');
                Maze[2, 7] = new Node(2, 7, 'C');

                Maze[3, 0] = new Node(3, 0, '.');
                Maze[3, 1] = new Node(3, 1, 'A');
                Maze[3, 2] = new Node(3, 2, '.');
                Maze[3, 3] = new Node(3, 3, '.');
                Maze[3, 4] = new Node(3, 4, '.');
                Maze[3, 5] = new Node(3, 5, 'H');
                Maze[3, 6] = new Node(3, 6, '.');
                Maze[3, 7] = new Node(3, 7, '.');

                Maze[4, 0] = new Node(4, 0, 'C');
                Maze[4, 1] = new Node(4, 1, '.');
                Maze[4, 2] = new Node(4, 2, 'H');
                Maze[4, 3] = new Node(4, 3, '.');
                Maze[4, 4] = new Node(4, 4, 'C');
                Maze[4, 5] = new Node(4, 5, '.');
                Maze[4, 6] = new Node(4, 6, 'A');
                Maze[4, 7] = new Node(4, 7, '.');

                Maze[5, 0] = new Node(5, 0, '.');
                Maze[5, 1] = new Node(5, 1, '*');
                Maze[5, 2] = new Node(5, 2, '.');
                Maze[5, 3] = new Node(5, 3, '.');
                Maze[5, 4] = new Node(5, 4, '.');
                Maze[5, 5] = new Node(5, 5, '.');
                Maze[5, 6] = new Node(5, 6, '.');
                Maze[5, 7] = new Node(5, 7, 'A');

                Maze[6, 0] = new Node(6, 0, '.');
                Maze[6, 1] = new Node(6, 1, '.');
                Maze[6, 2] = new Node(6, 2, '.');
                Maze[6, 3] = new Node(6, 3, 'C');
                Maze[6, 4] = new Node(6, 4, '.');
                Maze[6, 5] = new Node(6, 5, 'H');
                Maze[6, 6] = new Node(6, 6, '.');
                Maze[6, 7] = new Node(6, 7, '.');

                Maze[7, 0] = new Node(7, 0, '.');
                Maze[7, 1] = new Node(7, 1, '.');
                Maze[7, 2] = new Node(7, 2, 'A');
                Maze[7, 3] = new Node(7, 3, '.');
                Maze[7, 4] = new Node(7, 4, '.');
                Maze[7, 5] = new Node(7, 5, '.');
                Maze[7, 6] = new Node(7, 6, '.');
                Maze[7, 7] = new Node(7, 7, '.');

                SetMazeConnection(Maze[0, 0], Walls.NorthEastWall);
                SetMazeConnection(Maze[0, 1], Walls.Down);
                SetMazeConnection(Maze[0, 2], Walls.Up);
                SetMazeConnection(Maze[0, 3], Walls.Horizontal);
                SetMazeConnection(Maze[0, 4], Walls.NorthEastWall);
                SetMazeConnection(Maze[0, 5], Walls.NorthU);
                SetMazeConnection(Maze[0, 6], Walls.Left);
                SetMazeConnection(Maze[0, 7], Walls.Right);

                SetMazeConnection(Maze[1, 0], Walls.NorthEastWall);
                SetMazeConnection(Maze[1, 1], Walls.Vertical);
                SetMazeConnection(Maze[1, 2], Walls.SouthEastWall);
                SetMazeConnection(Maze[1, 3], Walls.NorthEastWall);
                SetMazeConnection(Maze[1, 4], Walls.None);
                SetMazeConnection(Maze[1, 5], Walls.Down);
                SetMazeConnection(Maze[1, 6], Walls.NorthWestWall);
                SetMazeConnection(Maze[1, 7], Walls.Vertical);

                SetMazeConnection(Maze[2, 0], Walls.Right);
                SetMazeConnection(Maze[2, 1], Walls.NorthWestWall);
                SetMazeConnection(Maze[2, 2], Walls.NorthEastWall);
                SetMazeConnection(Maze[2, 3], Walls.Left);
                SetMazeConnection(Maze[2, 4], Walls.Right);
                SetMazeConnection(Maze[2, 5], Walls.NorthEastWall);
                SetMazeConnection(Maze[2, 6], Walls.NorthWestWall);
                SetMazeConnection(Maze[2, 7], Walls.Left);

                SetMazeConnection(Maze[3, 0], Walls.Left);
                SetMazeConnection(Maze[3, 1], Walls.Down);
                SetMazeConnection(Maze[3, 2], Walls.None);
                SetMazeConnection(Maze[3, 3], Walls.None);
                SetMazeConnection(Maze[3, 4], Walls.None);
                SetMazeConnection(Maze[3, 5], Walls.Down);
                SetMazeConnection(Maze[3, 6], Walls.Right);
                SetMazeConnection(Maze[3, 7], Walls.Vertical);

                SetMazeConnection(Maze[4, 0], Walls.Vertical);
                SetMazeConnection(Maze[4, 1], Walls.NorthWestWall);
                SetMazeConnection(Maze[4, 2], Walls.None);
                SetMazeConnection(Maze[4, 3], Walls.None);
                SetMazeConnection(Maze[4, 4], Walls.None);
                SetMazeConnection(Maze[4, 5], Walls.Up);
                SetMazeConnection(Maze[4, 6], Walls.None);
                SetMazeConnection(Maze[4, 7], Walls.SouthEastWall);

                SetMazeConnection(Maze[5, 0], Walls.SouthEastWall);
                SetMazeConnection(Maze[5, 1], Walls.SouthWestWall);
                SetMazeConnection(Maze[5, 2], Walls.SouthWestWall);
                SetMazeConnection(Maze[5, 3], Walls.Left);
                SetMazeConnection(Maze[5, 4], Walls.Right);
                SetMazeConnection(Maze[5, 5], Walls.Left);
                SetMazeConnection(Maze[5, 6], Walls.SouthEastWall);
                SetMazeConnection(Maze[5, 7], Walls.NorthWestWall);

                SetMazeConnection(Maze[6, 0], Walls.NorthWestWall);
                SetMazeConnection(Maze[6, 1], Walls.Horizontal);
                SetMazeConnection(Maze[6, 2], Walls.NorthEastWall);
                SetMazeConnection(Maze[6, 3], Walls.SouthWestWall);
                SetMazeConnection(Maze[6, 4], Walls.Down);
                SetMazeConnection(Maze[6, 5], Walls.None);
                SetMazeConnection(Maze[6, 6], Walls.Horizontal);
                SetMazeConnection(Maze[6, 7], Walls.NorthEastWall);

                SetMazeConnection(Maze[7, 0], Walls.Right);
                SetMazeConnection(Maze[7, 1], Walls.NorthWestWall);
                SetMazeConnection(Maze[7, 2], Walls.Down);
                SetMazeConnection(Maze[7, 3], Walls.Horizontal);
                SetMazeConnection(Maze[7, 4], Walls.Horizontal);
                SetMazeConnection(Maze[7, 5], Walls.SouthEastWall);
                SetMazeConnection(Maze[7, 6], Walls.NorthWestWall);
                SetMazeConnection(Maze[7, 7], Walls.Up);
            }

            else if (str.Contains('A') && str.Contains('D') && str.Contains('H'))
            {
                Maze[0, 0] = new Node(0, 0, 'D');
                Maze[0, 1] = new Node(0, 1, '.');
                Maze[0, 2] = new Node(0, 2, 'D');
                Maze[0, 3] = new Node(0, 3, '.');
                Maze[0, 4] = new Node(0, 4, '.');
                Maze[0, 5] = new Node(0, 5, '*');
                Maze[0, 6] = new Node(0, 6, '.');
                Maze[0, 7] = new Node(0, 7, '.');

                Maze[1, 0] = new Node(1, 0, '.');
                Maze[1, 1] = new Node(1, 1, '.');
                Maze[1, 2] = new Node(1, 2, '.');
                Maze[1, 3] = new Node(1, 3, '.');
                Maze[1, 4] = new Node(1, 4, 'H');
                Maze[1, 5] = new Node(1, 5, '.');
                Maze[1, 6] = new Node(1, 6, '.');
                Maze[1, 7] = new Node(1, 7, 'A');

                Maze[2, 0] = new Node(2, 0, '.');
                Maze[2, 1] = new Node(2, 1, '*');
                Maze[2, 2] = new Node(2, 2, 'H');
                Maze[2, 3] = new Node(2, 3, '.');
                Maze[2, 4] = new Node(2, 4, '.');
                Maze[2, 5] = new Node(2, 5, '.');
                Maze[2, 6] = new Node(2, 6, 'A');
                Maze[2, 7] = new Node(2, 7, '.');

                Maze[3, 0] = new Node(3, 0, 'A');
                Maze[3, 1] = new Node(3, 1, '.');
                Maze[3, 2] = new Node(3, 2, '.');
                Maze[3, 3] = new Node(3, 3, 'D');
                Maze[3, 4] = new Node(3, 4, '.');
                Maze[3, 5] = new Node(3, 5, '.');
                Maze[3, 6] = new Node(3, 6, '.');
                Maze[3, 7] = new Node(3, 7, '.');

                Maze[4, 0] = new Node(4, 0, '.');
                Maze[4, 1] = new Node(4, 1, '.');
                Maze[4, 2] = new Node(4, 2, '.');
                Maze[4, 3] = new Node(4, 3, '.');
                Maze[4, 4] = new Node(4, 4, 'H');
                Maze[4, 5] = new Node(4, 5, 'D');
                Maze[4, 6] = new Node(4, 6, '.');
                Maze[4, 7] = new Node(4, 7, '.');

                Maze[5, 0] = new Node(5, 0, '*');
                Maze[5, 1] = new Node(5, 1, '.');
                Maze[5, 2] = new Node(5, 2, 'H');
                Maze[5, 3] = new Node(5, 3, '.');
                Maze[5, 4] = new Node(5, 4, '.');
                Maze[5, 5] = new Node(5, 5, '.');
                Maze[5, 6] = new Node(5, 6, '.');
                Maze[5, 7] = new Node(5, 7, 'A');

                Maze[6, 0] = new Node(6, 0, 'D');
                Maze[6, 1] = new Node(6, 1, '.');
                Maze[6, 2] = new Node(6, 2, '.');
                Maze[6, 3] = new Node(6, 3, '.');
                Maze[6, 4] = new Node(6, 4, '.');
                Maze[6, 5] = new Node(6, 5, '.');
                Maze[6, 6] = new Node(6, 6, '.');
                Maze[6, 7] = new Node(6, 7, '.');

                Maze[7, 0] = new Node(7, 0, '.');
                Maze[7, 1] = new Node(7, 1, '.');
                Maze[7, 2] = new Node(7, 2, '.');
                Maze[7, 3] = new Node(7, 3, 'A');
                Maze[7, 4] = new Node(7, 4, '.');
                Maze[7, 5] = new Node(7, 5, 'H');
                Maze[7, 6] = new Node(7, 6, '.');
                Maze[7, 7] = new Node(7, 7, '.');

                SetMazeConnection(Maze[0, 0], Walls.Left);
                SetMazeConnection(Maze[0, 1], Walls.NorthEastWall);
                SetMazeConnection(Maze[0, 2], Walls.NorthWestWall);
                SetMazeConnection(Maze[0, 3], Walls.Up);
                SetMazeConnection(Maze[0, 4], Walls.SouthEastWall);
                SetMazeConnection(Maze[0, 5], Walls.WestU);
                SetMazeConnection(Maze[0, 6], Walls.Down);
                SetMazeConnection(Maze[0, 7], Walls.NorthEastWall);

                SetMazeConnection(Maze[1, 0], Walls.Vertical);
                SetMazeConnection(Maze[1, 1], Walls.Vertical);
                SetMazeConnection(Maze[1, 2], Walls.Vertical);
                SetMazeConnection(Maze[1, 3], Walls.Left);
                SetMazeConnection(Maze[1, 4], Walls.Up);
                SetMazeConnection(Maze[1, 5], Walls.Horizontal);
                SetMazeConnection(Maze[1, 6], Walls.Horizontal);
                SetMazeConnection(Maze[1, 7], Walls.SouthEastWall);

                SetMazeConnection(Maze[2, 0], Walls.Vertical);
                SetMazeConnection(Maze[2, 1], Walls.SouthWestWall);
                SetMazeConnection(Maze[2, 2], Walls.Right);
                SetMazeConnection(Maze[2, 3], Walls.Vertical);
                SetMazeConnection(Maze[2, 4], Walls.SouthWestWall);
                SetMazeConnection(Maze[2, 5], Walls.Horizontal);
                SetMazeConnection(Maze[2, 6], Walls.Up);
                SetMazeConnection(Maze[2, 7], Walls.NorthEastWall);

                SetMazeConnection(Maze[3, 0], Walls.SouthWestWall);
                SetMazeConnection(Maze[3, 1], Walls.Down);
                SetMazeConnection(Maze[3, 2], Walls.Vertical);
                SetMazeConnection(Maze[3, 3], Walls.Up);
                SetMazeConnection(Maze[3, 4], Walls.Right);
                SetMazeConnection(Maze[3, 5], Walls.NorthEastWall);
                SetMazeConnection(Maze[3, 6], Walls.Right);
                SetMazeConnection(Maze[3, 7], Walls.NorthU);

                SetMazeConnection(Maze[4, 0], Walls.NorthWestWall);
                SetMazeConnection(Maze[4, 1], Walls.Horizontal);
                SetMazeConnection(Maze[4, 2], Walls.Horizontal);
                SetMazeConnection(Maze[4, 3], Walls.Right);
                SetMazeConnection(Maze[4, 4], Walls.Vertical);
                SetMazeConnection(Maze[4, 5], Walls.Vertical);
                SetMazeConnection(Maze[4, 6], Walls.Left);
                SetMazeConnection(Maze[4, 7], Walls.Right);

                SetMazeConnection(Maze[5, 0], Walls.NorthEastWall);
                SetMazeConnection(Maze[5, 1], Walls.Horizontal);
                SetMazeConnection(Maze[5, 2], Walls.Horizontal);
                SetMazeConnection(Maze[5, 3], Walls.Right);
                SetMazeConnection(Maze[5, 4], Walls.Vertical);
                SetMazeConnection(Maze[5, 5], Walls.Vertical);
                SetMazeConnection(Maze[5, 6], Walls.Left);
                SetMazeConnection(Maze[5, 7], Walls.Right);

                SetMazeConnection(Maze[6, 0], Walls.Down);
                SetMazeConnection(Maze[6, 1], Walls.Horizontal);
                SetMazeConnection(Maze[6, 2], Walls.NorthEastWall);
                SetMazeConnection(Maze[6, 3], Walls.Vertical);
                SetMazeConnection(Maze[6, 4], Walls.SouthU);
                SetMazeConnection(Maze[6, 5], Walls.Vertical);
                SetMazeConnection(Maze[6, 6], Walls.Vertical);
                SetMazeConnection(Maze[6, 7], Walls.Left);

                SetMazeConnection(Maze[7, 0], Walls.NorthEastWall);
                SetMazeConnection(Maze[7, 1], Walls.Horizontal);
                SetMazeConnection(Maze[7, 2], Walls.Down);
                SetMazeConnection(Maze[7, 3], Walls.Down);
                SetMazeConnection(Maze[7, 4], Walls.NorthEastWall);
                SetMazeConnection(Maze[7, 5], Walls.SouthWestWall);
                SetMazeConnection(Maze[7, 6], Walls.Right);
                SetMazeConnection(Maze[7, 7], Walls.SouthU);
            }

            else if (str.Contains('D') && str.Contains('C') && str.Contains('B'))
            {
                Maze[0, 0] = new Node(0, 0, '.');
                Maze[0, 1] = new Node(0, 1, '.');
                Maze[0, 2] = new Node(0, 2, '.');
                Maze[0, 3] = new Node(0, 3, '.');
                Maze[0, 4] = new Node(0, 4, '.');
                Maze[0, 5] = new Node(0, 5, 'B');
                Maze[0, 6] = new Node(0, 6, '.');
                Maze[0, 7] = new Node(0, 7, '.');

                Maze[1, 0] = new Node(1, 0, 'C');
                Maze[1, 1] = new Node(1, 1, '.');
                Maze[1, 2] = new Node(1, 2, 'D');
                Maze[1, 3] = new Node(1, 3, '.');
                Maze[1, 4] = new Node(1, 4, '.');
                Maze[1, 5] = new Node(1, 5, '.');
                Maze[1, 6] = new Node(1, 6, '*');
                Maze[1, 7] = new Node(1, 7, '.');

                Maze[2, 0] = new Node(2, 0, '.');
                Maze[2, 1] = new Node(2, 1, '*');
                Maze[2, 2] = new Node(2, 2, '.');
                Maze[2, 3] = new Node(2, 3, 'B');
                Maze[2, 4] = new Node(2, 4, '.');
                Maze[2, 5] = new Node(2, 5, '.');
                Maze[2, 6] = new Node(2, 6, 'C');
                Maze[2, 7] = new Node(2, 7, '.');

                Maze[3, 0] = new Node(3, 0, '.');
                Maze[3, 1] = new Node(3, 1, 'C');
                Maze[3, 2] = new Node(3, 2, '.');
                Maze[3, 3] = new Node(3, 3, '.');
                Maze[3, 4] = new Node(3, 4, '.');
                Maze[3, 5] = new Node(3, 5, '.');
                Maze[3, 6] = new Node(3, 6, 'B');
                Maze[3, 7] = new Node(3, 7, '.');

                Maze[4, 0] = new Node(4, 0, '.');
                Maze[4, 1] = new Node(4, 1, '.');
                Maze[4, 2] = new Node(4, 2, '.');
                Maze[4, 3] = new Node(4, 3, '.');
                Maze[4, 4] = new Node(4, 4, 'C');
                Maze[4, 5] = new Node(4, 5, '.');
                Maze[4, 6] = new Node(4, 6, '.');
                Maze[4, 7] = new Node(4, 7, 'D');

                Maze[5, 0] = new Node(5, 0, 'B');
                Maze[5, 1] = new Node(5, 1, '.');
                Maze[5, 2] = new Node(5, 2, '.');
                Maze[5, 3] = new Node(5, 3, '.');
                Maze[5, 4] = new Node(5, 4, '.');
                Maze[5, 5] = new Node(5, 5, '.');
                Maze[5, 6] = new Node(5, 6, 'D');
                Maze[5, 7] = new Node(5, 7, '.');

                Maze[6, 0] = new Node(6, 0, '.');
                Maze[6, 1] = new Node(6, 1, 'C');
                Maze[6, 2] = new Node(6, 2, '.');
                Maze[6, 3] = new Node(6, 3, '.');
                Maze[6, 4] = new Node(6, 4, '*');
                Maze[6, 5] = new Node(6, 5, '.');
                Maze[6, 6] = new Node(6, 6, 'D');
                Maze[6, 7] = new Node(6, 7, '.');

                Maze[7, 0] = new Node(7, 0, 'D');
                Maze[7, 1] = new Node(7, 1, '.');
                Maze[7, 2] = new Node(7, 2, '.');
                Maze[7, 3] = new Node(7, 3, 'B');
                Maze[7, 4] = new Node(7, 4, '.');
                Maze[7, 5] = new Node(7, 5, '.');
                Maze[7, 6] = new Node(7, 6, '.');
                Maze[7, 7] = new Node(7, 7, '.');

                SetMazeConnection(Maze[0, 0], Walls.Left);
                SetMazeConnection(Maze[0, 1], Walls.Vertical);
                SetMazeConnection(Maze[0, 2], Walls.SouthEastWall);
                SetMazeConnection(Maze[0, 3], Walls.NorthWestWall);
                SetMazeConnection(Maze[0, 4], Walls.Horizontal);
                SetMazeConnection(Maze[0, 5], Walls.Up);
                SetMazeConnection(Maze[0, 6], Walls.Horizontal);
                SetMazeConnection(Maze[0, 7], Walls.SouthEastWall);

                SetMazeConnection(Maze[1, 0], Walls.None);
                SetMazeConnection(Maze[1, 1], Walls.Horizontal);
                SetMazeConnection(Maze[1, 2], Walls.Horizontal);
                SetMazeConnection(Maze[1, 3], Walls.Right);
                SetMazeConnection(Maze[1, 4], Walls.NorthWestWall);
                SetMazeConnection(Maze[1, 5], Walls.SouthEastWall);
                SetMazeConnection(Maze[1, 6], Walls.NorthWestWall);
                SetMazeConnection(Maze[1, 7], Walls.Up);

                SetMazeConnection(Maze[2, 0], Walls.SouthU);
                SetMazeConnection(Maze[2, 1], Walls.NorthU);
                SetMazeConnection(Maze[2, 2], Walls.NorthWestWall);
                SetMazeConnection(Maze[2, 3], Walls.Right);
                SetMazeConnection(Maze[2, 4], Walls.Left);
                SetMazeConnection(Maze[2, 5], Walls.Horizontal);
                SetMazeConnection(Maze[2, 6], Walls.Down);
                SetMazeConnection(Maze[2, 7], Walls.SouthEastWall);

                SetMazeConnection(Maze[3, 0], Walls.Horizontal);
                SetMazeConnection(Maze[3, 1], Walls.None);
                SetMazeConnection(Maze[3, 2], Walls.Down);
                SetMazeConnection(Maze[3, 3], Walls.NorthWestWall);
                SetMazeConnection(Maze[3, 4], Walls.Left);
                SetMazeConnection(Maze[3, 5], Walls.Up);
                SetMazeConnection(Maze[3, 6], Walls.Horizontal);
                SetMazeConnection(Maze[3, 7], Walls.Horizontal);



                SetMazeConnection(Maze[4, 0], Walls.Horizontal);
                SetMazeConnection(Maze[4, 1], Walls.Right);
                SetMazeConnection(Maze[4, 2], Walls.NorthWestWall);
                SetMazeConnection(Maze[4, 3], Walls.Horizontal);
                SetMazeConnection(Maze[4, 4], Walls.Down);
                SetMazeConnection(Maze[4, 5], Walls.Right);
                SetMazeConnection(Maze[4, 6], Walls.NorthWestWall);
                SetMazeConnection(Maze[4, 7], Walls.Horizontal);

                SetMazeConnection(Maze[5, 0], Walls.Up);
                SetMazeConnection(Maze[5, 1], Walls.Down);
                SetMazeConnection(Maze[5, 2], Walls.SouthEastWall);
                SetMazeConnection(Maze[5, 3], Walls.NorthWestWall);
                SetMazeConnection(Maze[5, 4], Walls.Up);
                SetMazeConnection(Maze[5, 5], Walls.None);
                SetMazeConnection(Maze[5, 6], Walls.SouthEastWall);
                SetMazeConnection(Maze[5, 7], Walls.NorthWestWall);

                SetMazeConnection(Maze[6, 0], Walls.Down);
                SetMazeConnection(Maze[6, 1], Walls.Up);
                SetMazeConnection(Maze[6, 2], Walls.Horizontal);
                SetMazeConnection(Maze[6, 3], Walls.Down);
                SetMazeConnection(Maze[6, 4], Walls.SouthWestWall);
                SetMazeConnection(Maze[6, 5], Walls.Vertical);
                SetMazeConnection(Maze[6, 6], Walls.NorthWestWall);
                SetMazeConnection(Maze[6, 7], Walls.Down);

                SetMazeConnection(Maze[7, 0], Walls.Up);
                SetMazeConnection(Maze[7, 1], Walls.SouthEastWall);
                SetMazeConnection(Maze[7, 2], Walls.NorthWestWall);
                SetMazeConnection(Maze[7, 3], Walls.Horizontal);
                SetMazeConnection(Maze[7, 4], Walls.Horizontal);
                SetMazeConnection(Maze[7, 5], Walls.Down);
                SetMazeConnection(Maze[7, 6], Walls.SouthWestWall);
                SetMazeConnection(Maze[7, 7], Walls.NorthEastWall);
            }

            else if (str.Contains('B') && str.Contains('C') && str.Contains('H'))
            {
                Maze[0, 0] = new Node(0, 0, 'C');
                Maze[0, 1] = new Node(0, 1, '.');
                Maze[0, 2] = new Node(0, 2, '.');
                Maze[0, 3] = new Node(0, 3, '.');
                Maze[0, 4] = new Node(0, 4, 'H');
                Maze[0, 5] = new Node(0, 5, '.');
                Maze[0, 6] = new Node(0, 6, '.');
                Maze[0, 7] = new Node(0, 7, '.');

                Maze[1, 0] = new Node(1, 0, '.');
                Maze[1, 1] = new Node(1, 1, '.');
                Maze[1, 2] = new Node(1, 2, 'C');
                Maze[1, 3] = new Node(1, 3, '.');
                Maze[1, 4] = new Node(1, 4, '.');
                Maze[1, 5] = new Node(1, 5, '.');
                Maze[1, 6] = new Node(1, 6, '.');
                Maze[1, 7] = new Node(1, 7, 'H');

                Maze[2, 0] = new Node(2, 0, '.');
                Maze[2, 1] = new Node(2, 1, '.');
                Maze[2, 2] = new Node(2, 2, '*');
                Maze[2, 3] = new Node(2, 3, '.');
                Maze[2, 4] = new Node(2, 4, 'B');
                Maze[2, 5] = new Node(2, 5, '.');
                Maze[2, 6] = new Node(2, 6, '.');
                Maze[2, 7] = new Node(2, 7, '.');

                Maze[3, 0] = new Node(3, 0, 'B');
                Maze[3, 1] = new Node(3, 1, '.');
                Maze[3, 2] = new Node(3, 2, '.');
                Maze[3, 3] = new Node(3, 3, 'H');
                Maze[3, 4] = new Node(3, 4, '*');
                Maze[3, 5] = new Node(3, 5, '.');
                Maze[3, 6] = new Node(3, 6, '.');
                Maze[3, 7] = new Node(3, 7, '.');

                Maze[4, 0] = new Node(4, 0, '.');
                Maze[4, 1] = new Node(4, 1, 'H');
                Maze[4, 2] = new Node(4, 2, '.');
                Maze[4, 3] = new Node(4, 3, '.');
                Maze[4, 4] = new Node(4, 4, '.');
                Maze[4, 5] = new Node(4, 5, 'B');
                Maze[4, 6] = new Node(4, 6, '.');
                Maze[4, 7] = new Node(4, 7, 'C');

                Maze[5, 0] = new Node(5, 0, '.');
                Maze[5, 1] = new Node(5, 1, '.');
                Maze[5, 2] = new Node(5, 2, '.');
                Maze[5, 3] = new Node(5, 3, '*');
                Maze[5, 4] = new Node(5, 4, '.');
                Maze[5, 5] = new Node(5, 5, '.');
                Maze[5, 6] = new Node(5, 6, '.');
                Maze[5, 7] = new Node(5, 7, '.');

                Maze[6, 0] = new Node(6, 0, '.');
                Maze[6, 1] = new Node(6, 1, '.');
                Maze[6, 2] = new Node(6, 2, 'B');
                Maze[6, 3] = new Node(6, 3, '.');
                Maze[6, 4] = new Node(6, 4, 'C');
                Maze[6, 5] = new Node(6, 5, '.');
                Maze[6, 6] = new Node(6, 6, '.');
                Maze[6, 7] = new Node(6, 7, '.');

                Maze[7, 0] = new Node(7, 0, '.');
                Maze[7, 1] = new Node(7, 1, 'C');
                Maze[7, 2] = new Node(7, 2, '.');
                Maze[7, 3] = new Node(7, 3, '.');
                Maze[7, 4] = new Node(7, 4, '.');
                Maze[7, 5] = new Node(7, 5, 'H');
                Maze[7, 6] = new Node(7, 6, '.');
                Maze[7, 7] = new Node(7, 7, 'B');

                SetMazeConnection(Maze[0, 0], Walls.NorthEastWall);
                SetMazeConnection(Maze[0, 1], Walls.Down);
                SetMazeConnection(Maze[0, 2], Walls.Up);
                SetMazeConnection(Maze[0, 3], Walls.Horizontal);
                SetMazeConnection(Maze[0, 4], Walls.Right);
                SetMazeConnection(Maze[0, 5], Walls.SouthEastWall);
                SetMazeConnection(Maze[0, 6], Walls.Horizontal);
                SetMazeConnection(Maze[0, 7], Walls.EastU);

                SetMazeConnection(Maze[1, 0], Walls.SouthWestWall);
                SetMazeConnection(Maze[1, 1], Walls.NorthEastWall);
                SetMazeConnection(Maze[1, 2], Walls.Down);
                SetMazeConnection(Maze[1, 3], Walls.NorthEastWall);
                SetMazeConnection(Maze[1, 4], Walls.SouthWestWall);
                SetMazeConnection(Maze[1, 5], Walls.Horizontal);
                SetMazeConnection(Maze[1, 6], Walls.Up);
                SetMazeConnection(Maze[1, 7], Walls.Up);

                SetMazeConnection(Maze[2, 0], Walls.NorthEastWall);
                SetMazeConnection(Maze[2, 1], Walls.Vertical);
                SetMazeConnection(Maze[2, 2], Walls.NorthU);
                SetMazeConnection(Maze[2, 3], Walls.Vertical);
                SetMazeConnection(Maze[2, 4], Walls.NorthWestWall);
                SetMazeConnection(Maze[2, 5], Walls.Horizontal);
                SetMazeConnection(Maze[2, 6], Walls.SouthEastWall);
                SetMazeConnection(Maze[2, 7], Walls.Left);

                SetMazeConnection(Maze[3, 0], Walls.Left);
                SetMazeConnection(Maze[3, 1], Walls.Down);
                SetMazeConnection(Maze[3, 2], Walls.Down);
                SetMazeConnection(Maze[3, 3], Walls.SouthWestWall);
                SetMazeConnection(Maze[3, 4], Walls.SouthEastWall);
                SetMazeConnection(Maze[3, 5], Walls.Horizontal);
                SetMazeConnection(Maze[3, 6], Walls.Horizontal);
                SetMazeConnection(Maze[3, 7], Walls.Right);

                SetMazeConnection(Maze[4, 0], Walls.Left);
                SetMazeConnection(Maze[4, 1], Walls.Up);
                SetMazeConnection(Maze[4, 2], Walls.Horizontal);
                SetMazeConnection(Maze[4, 3], Walls.NorthEastWall);
                SetMazeConnection(Maze[4, 4], Walls.NorthWestWall);
                SetMazeConnection(Maze[4, 5], Walls.Up);
                SetMazeConnection(Maze[4, 6], Walls.Horizontal);
                SetMazeConnection(Maze[4, 7], Walls.Right);

                SetMazeConnection(Maze[5, 0], Walls.SouthEastWall);
                SetMazeConnection(Maze[5, 1], Walls.Vertical);
                SetMazeConnection(Maze[5, 2], Walls.NorthWestWall);
                SetMazeConnection(Maze[5, 3], Walls.SouthEastWall);
                SetMazeConnection(Maze[5, 4], Walls.Vertical);
                SetMazeConnection(Maze[5, 5], Walls.SouthEastWall);
                SetMazeConnection(Maze[5, 6], Walls.SouthWestWall);
                SetMazeConnection(Maze[5, 7], Walls.Left);

                SetMazeConnection(Maze[6, 0], Walls.NorthEastWall);
                SetMazeConnection(Maze[6, 1], Walls.Vertical);
                SetMazeConnection(Maze[6, 2], Walls.Left);
                SetMazeConnection(Maze[6, 3], Walls.NorthEastWall);
                SetMazeConnection(Maze[6, 4], Walls.Left);
                SetMazeConnection(Maze[6, 5], Walls.Horizontal);
                SetMazeConnection(Maze[6, 6], Walls.SouthEastWall);
                SetMazeConnection(Maze[6, 7], Walls.Left);

                SetMazeConnection(Maze[7, 0], Walls.Down);
                SetMazeConnection(Maze[7, 1], Walls.None);
                SetMazeConnection(Maze[7, 2], Walls.SouthWestWall);
                SetMazeConnection(Maze[7, 3], Walls.SouthEastWall);
                SetMazeConnection(Maze[7, 4], Walls.None);
                SetMazeConnection(Maze[7, 5], Walls.NorthEastWall);
                SetMazeConnection(Maze[7, 6], Walls.EastU);
                SetMazeConnection(Maze[7, 7], Walls.Down);
            }

            else if (str.Contains('B') && str.Contains('D') && str.Contains('H'))
            {
                Maze[0, 0] = new Node(0, 0, '.');
                Maze[0, 1] = new Node(0, 1, '.');
                Maze[0, 2] = new Node(0, 2, 'D');
                Maze[0, 3] = new Node(0, 3, '.');
                Maze[0, 4] = new Node(0, 4, 'B');
                Maze[0, 5] = new Node(0, 5, '.');
                Maze[0, 6] = new Node(0, 6, '.');
                Maze[0, 7] = new Node(0, 7, 'H');

                Maze[1, 0] = new Node(1, 0, '.');
                Maze[1, 1] = new Node(1, 1, '.');
                Maze[1, 2] = new Node(1, 2, '.');
                Maze[1, 3] = new Node(1, 3, '*');
                Maze[1, 4] = new Node(1, 4, '.');
                Maze[1, 5] = new Node(1, 5, 'D');
                Maze[1, 6] = new Node(1, 6, '.');
                Maze[1, 7] = new Node(1, 7, '.');

                Maze[2, 0] = new Node(2, 0, '.');
                Maze[2, 1] = new Node(2, 1, '.');
                Maze[2, 2] = new Node(2, 2, 'H');
                Maze[2, 3] = new Node(2, 3, '.');
                Maze[2, 4] = new Node(2, 4, '*');
                Maze[2, 5] = new Node(2, 5, '.');
                Maze[2, 6] = new Node(2, 6, 'B');
                Maze[2, 7] = new Node(2, 7, '.');

                Maze[3, 0] = new Node(3, 0, 'D');
                Maze[3, 1] = new Node(3, 1, '.');
                Maze[3, 2] = new Node(3, 2, '.');
                Maze[3, 3] = new Node(3, 3, '.');
                Maze[3, 4] = new Node(3, 4, '.');
                Maze[3, 5] = new Node(3, 5, 'B');
                Maze[3, 6] = new Node(3, 6, '.');
                Maze[3, 7] = new Node(3, 7, '.');

                Maze[4, 0] = new Node(4, 0, '.');
                Maze[4, 1] = new Node(4, 1, '.');
                Maze[4, 2] = new Node(4, 2, '.');
                Maze[4, 3] = new Node(4, 3, '.');
                Maze[4, 4] = new Node(4, 4, 'D');
                Maze[4, 5] = new Node(4, 5, '.');
                Maze[4, 6] = new Node(4, 6, '.');
                Maze[4, 7] = new Node(4, 7, 'H');

                Maze[5, 0] = new Node(5, 0, '.');
                Maze[5, 1] = new Node(5, 1, '.');
                Maze[5, 2] = new Node(5, 2, 'B');
                Maze[5, 3] = new Node(5, 3, '.');
                Maze[5, 4] = new Node(5, 4, '.');
                Maze[5, 5] = new Node(5, 5, '.');
                Maze[5, 6] = new Node(5, 6, '.');
                Maze[5, 7] = new Node(5, 7, '.');

                Maze[6, 0] = new Node(6, 0, '.');
                Maze[6, 1] = new Node(6, 1, '.');
                Maze[6, 2] = new Node(6, 2, '.');
                Maze[6, 3] = new Node(6, 3, 'H');
                Maze[6, 4] = new Node(6, 4, '.');
                Maze[6, 5] = new Node(6, 5, '.');
                Maze[6, 6] = new Node(6, 6, 'H');
                Maze[6, 7] = new Node(6, 7, '*');

                Maze[7, 0] = new Node(7, 0, 'D');
                Maze[7, 1] = new Node(7, 1, '.');
                Maze[7, 2] = new Node(7, 2, '.');
                Maze[7, 3] = new Node(7, 3, '.');
                Maze[7, 4] = new Node(7, 4, '.');
                Maze[7, 5] = new Node(7, 5, 'B');
                Maze[7, 6] = new Node(7, 6, '.');
                Maze[7, 7] = new Node(7, 7, '.');

                SetMazeConnection(Maze[0, 0], Walls.Right);
                SetMazeConnection(Maze[0, 1], Walls.Vertical);
                SetMazeConnection(Maze[0, 2], Walls.NorthWestWall);
                SetMazeConnection(Maze[0, 3], Walls.SouthEastWall);
                SetMazeConnection(Maze[0, 4], Walls.Left);
                SetMazeConnection(Maze[0, 5], Walls.None);
                SetMazeConnection(Maze[0, 6], Walls.None);
                SetMazeConnection(Maze[0, 7], Walls.Up);

                SetMazeConnection(Maze[1, 0], Walls.SouthU);
                SetMazeConnection(Maze[1, 1], Walls.SouthWestWall);
                SetMazeConnection(Maze[1, 2], Walls.Right);
                SetMazeConnection(Maze[1, 3], Walls.WestU);
                SetMazeConnection(Maze[1, 4], Walls.SouthEastWall);
                SetMazeConnection(Maze[1, 5], Walls.Vertical);
                SetMazeConnection(Maze[1, 6], Walls.Vertical);
                SetMazeConnection(Maze[1, 7], Walls.NorthU);

                SetMazeConnection(Maze[2, 0], Walls.Horizontal);
                SetMazeConnection(Maze[2, 1], Walls.Horizontal);
                SetMazeConnection(Maze[2, 2], Walls.None);
                SetMazeConnection(Maze[2, 3], Walls.Horizontal);
                SetMazeConnection(Maze[2, 4], Walls.EastU);
                SetMazeConnection(Maze[2, 5], Walls.Vertical);
                SetMazeConnection(Maze[2, 6], Walls.SouthEastWall);
                SetMazeConnection(Maze[2, 7], Walls.Down);

                SetMazeConnection(Maze[3, 0], Walls.Up);
                SetMazeConnection(Maze[3, 1], Walls.NorthEastWall);
                SetMazeConnection(Maze[3, 2], Walls.Left);
                SetMazeConnection(Maze[3, 3], Walls.Horizontal);
                SetMazeConnection(Maze[3, 4], Walls.Up);
                SetMazeConnection(Maze[3, 5], Walls.None);
                SetMazeConnection(Maze[3, 6], Walls.Horizontal);
                SetMazeConnection(Maze[3, 7], Walls.Horizontal);

                SetMazeConnection(Maze[4, 0], Walls.Down);
                SetMazeConnection(Maze[4, 1], Walls.Right);
                SetMazeConnection(Maze[4, 2], Walls.Vertical);
                SetMazeConnection(Maze[4, 3], Walls.NorthEastWall);
                SetMazeConnection(Maze[4, 4], Walls.Right);
                SetMazeConnection(Maze[4, 5], Walls.Left);
                SetMazeConnection(Maze[4, 6], Walls.Up);
                SetMazeConnection(Maze[4, 7], Walls.Up);

                SetMazeConnection(Maze[5, 0], Walls.NorthWestWall);
                SetMazeConnection(Maze[5, 1], Walls.Down);
                SetMazeConnection(Maze[5, 2], Walls.Down);
                SetMazeConnection(Maze[5, 3], Walls.Right);
                SetMazeConnection(Maze[5, 4], Walls.SouthU);
                SetMazeConnection(Maze[5, 5], Walls.SouthU);
                SetMazeConnection(Maze[5, 6], Walls.Left);
                SetMazeConnection(Maze[5, 7], Walls.Right);

                SetMazeConnection(Maze[6, 0], Walls.Vertical);
                SetMazeConnection(Maze[6, 1], Walls.EastU);
                SetMazeConnection(Maze[6, 2], Walls.Up);
                SetMazeConnection(Maze[6, 3], Walls.None);
                SetMazeConnection(Maze[6, 4], Walls.Horizontal);
                SetMazeConnection(Maze[6, 5], Walls.Horizontal);
                SetMazeConnection(Maze[6, 6], Walls.Down);
                SetMazeConnection(Maze[6, 7], Walls.SouthEastWall);

                SetMazeConnection(Maze[7, 0], Walls.None);
                SetMazeConnection(Maze[7, 1], Walls.Up);
                SetMazeConnection(Maze[7, 2], Walls.SouthEastWall);
                SetMazeConnection(Maze[7, 3], Walls.Vertical);
                SetMazeConnection(Maze[7, 4], Walls.NorthWestWall);
                SetMazeConnection(Maze[7, 5], Walls.NorthEastWall);
                SetMazeConnection(Maze[7, 6], Walls.NorthWestWall);
                SetMazeConnection(Maze[7, 7], Walls.Horizontal);
            }

            else
            {
                Maze[0, 0] = new Node(0, 0, '.');
                Maze[0, 1] = new Node(0, 1, '.');
                Maze[0, 2] = new Node(0, 2, 'H');
                Maze[0, 3] = new Node(0, 3, '.');
                Maze[0, 4] = new Node(0, 4, '.');
                Maze[0, 5] = new Node(0, 5, 'D');
                Maze[0, 6] = new Node(0, 6, '.');
                Maze[0, 7] = new Node(0, 7, '.');

                Maze[1, 0] = new Node(1, 0, '.');
                Maze[1, 1] = new Node(1, 1, '.');
                Maze[1, 2] = new Node(1, 2, '.');
                Maze[1, 3] = new Node(1, 3, '.');
                Maze[1, 4] = new Node(1, 4, 'C');
                Maze[1, 5] = new Node(1, 5, '*');
                Maze[1, 6] = new Node(1, 6, '.');
                Maze[1, 7] = new Node(1, 7, '.');

                Maze[2, 0] = new Node(2, 0, '.');
                Maze[2, 1] = new Node(2, 1, '.');
                Maze[2, 2] = new Node(2, 2, '.');
                Maze[2, 3] = new Node(2, 3, 'H');
                Maze[2, 4] = new Node(2, 4, '.');
                Maze[2, 5] = new Node(2, 5, '.');
                Maze[2, 6] = new Node(2, 6, '.');
                Maze[2, 7] = new Node(2, 7, 'D');

                Maze[3, 0] = new Node(3, 0, 'H');
                Maze[3, 1] = new Node(3, 1, '.');
                Maze[3, 2] = new Node(3, 2, '.');
                Maze[3, 3] = new Node(3, 3, '.');
                Maze[3, 4] = new Node(3, 4, '.');
                Maze[3, 5] = new Node(3, 5, 'D');
                Maze[3, 6] = new Node(3, 6, '.');
                Maze[3, 7] = new Node(3, 7, '.');

                Maze[4, 0] = new Node(4, 0, '.');
                Maze[4, 1] = new Node(4, 1, '.');
                Maze[4, 2] = new Node(4, 2, '.');
                Maze[4, 3] = new Node(4, 3, '.');
                Maze[4, 4] = new Node(4, 4, 'C');
                Maze[4, 5] = new Node(4, 5, '.');
                Maze[4, 6] = new Node(4, 6, '.');
                Maze[4, 7] = new Node(4, 7, '.');

                Maze[5, 0] = new Node(5, 0, 'C');
                Maze[5, 1] = new Node(5, 1, '.');
                Maze[5, 2] = new Node(5, 2, '.');
                Maze[5, 3] = new Node(5, 3, 'D');
                Maze[5, 4] = new Node(5, 4, '.');
                Maze[5, 5] = new Node(5, 5, 'C');
                Maze[5, 6] = new Node(5, 6, '.');
                Maze[5, 7] = new Node(5, 7, 'H');

                Maze[6, 0] = new Node(6, 0, '*');
                Maze[6, 1] = new Node(6, 1, 'D');
                Maze[6, 2] = new Node(6, 2, '.');
                Maze[6, 3] = new Node(6, 3, '.');
                Maze[6, 4] = new Node(6, 4, 'H');
                Maze[6, 5] = new Node(6, 5, '.');
                Maze[6, 6] = new Node(6, 6, '*');
                Maze[6, 7] = new Node(6, 7, '.');

                Maze[7, 0] = new Node(7, 0, '.');
                Maze[7, 1] = new Node(7, 1, '.');
                Maze[7, 2] = new Node(7, 2, '.');
                Maze[7, 3] = new Node(7, 3, '.');
                Maze[7, 4] = new Node(7, 4, '.');
                Maze[7, 5] = new Node(7, 5, '.');
                Maze[7, 6] = new Node(7, 6, '.');
                Maze[7, 7] = new Node(7, 7, 'C');

                SetMazeConnection(Maze[0, 0], Walls.Vertical);
                SetMazeConnection(Maze[0, 1], Walls.NorthWestWall);
                SetMazeConnection(Maze[0, 2], Walls.Down);
                SetMazeConnection(Maze[0, 3], Walls.NorthEastWall);
                SetMazeConnection(Maze[0, 4], Walls.NorthWestWall);
                SetMazeConnection(Maze[0, 5], Walls.Down);
                SetMazeConnection(Maze[0, 6], Walls.NorthEastWall);
                SetMazeConnection(Maze[0, 7], Walls.Vertical);

                SetMazeConnection(Maze[1, 0], Walls.Vertical);
                SetMazeConnection(Maze[1, 1], Walls.Vertical);
                SetMazeConnection(Maze[1, 2], Walls.NorthU);
                SetMazeConnection(Maze[1, 3], Walls.Left);
                SetMazeConnection(Maze[1, 4], Walls.Right);
                SetMazeConnection(Maze[1, 5], Walls.NorthU);
                SetMazeConnection(Maze[1, 6], Walls.Vertical);
                SetMazeConnection(Maze[1, 7], Walls.Vertical);

                SetMazeConnection(Maze[2, 0], Walls.None);
                SetMazeConnection(Maze[2, 1], Walls.SouthEastWall);
                SetMazeConnection(Maze[2, 2], Walls.Left);
                SetMazeConnection(Maze[2, 3], Walls.None);
                SetMazeConnection(Maze[2, 4], Walls.None);
                SetMazeConnection(Maze[2, 5], Walls.Right);
                SetMazeConnection(Maze[2, 6], Walls.SouthWestWall);
                SetMazeConnection(Maze[2, 7], Walls.None);

                SetMazeConnection(Maze[3, 0], Walls.Left);
                SetMazeConnection(Maze[3, 1], Walls.Horizontal);
                SetMazeConnection(Maze[3, 2], Walls.SouthEastWall);
                SetMazeConnection(Maze[3, 3], Walls.Vertical);
                SetMazeConnection(Maze[3, 4], Walls.Vertical);
                SetMazeConnection(Maze[3, 5], Walls.Left);
                SetMazeConnection(Maze[3, 6], Walls.Horizontal);
                SetMazeConnection(Maze[3, 7], Walls.None);

                SetMazeConnection(Maze[4, 0], Walls.Left);
                SetMazeConnection(Maze[4, 1], Walls.Horizontal);
                SetMazeConnection(Maze[4, 2], Walls.SouthEastWall);
                SetMazeConnection(Maze[4, 3], Walls.Vertical);
                SetMazeConnection(Maze[4, 4], Walls.Vertical);
                SetMazeConnection(Maze[4, 5], Walls.SouthWestWall);
                SetMazeConnection(Maze[4, 6], Walls.Horizontal);
                SetMazeConnection(Maze[4, 7], Walls.None);

                SetMazeConnection(Maze[5, 0], Walls.Left);
                SetMazeConnection(Maze[5, 1], Walls.Horizontal);
                SetMazeConnection(Maze[5, 2], Walls.Up);
                SetMazeConnection(Maze[5, 3], Walls.SouthEastWall);
                SetMazeConnection(Maze[5, 4], Walls.SouthWestWall);
                SetMazeConnection(Maze[5, 5], Walls.Up);
                SetMazeConnection(Maze[5, 6], Walls.Horizontal);
                SetMazeConnection(Maze[5, 7], Walls.Right);

                SetMazeConnection(Maze[6, 0], Walls.SouthU);
                SetMazeConnection(Maze[6, 1], Walls.NorthWestWall);
                SetMazeConnection(Maze[6, 2], Walls.Down);
                SetMazeConnection(Maze[6, 3], Walls.Up);
                SetMazeConnection(Maze[6, 4], Walls.Up);
                SetMazeConnection(Maze[6, 5], Walls.Down);
                SetMazeConnection(Maze[6, 6], Walls.SouthEastWall);
                SetMazeConnection(Maze[6, 7], Walls.SouthU);

                SetMazeConnection(Maze[7, 0], Walls.Up);
                SetMazeConnection(Maze[7, 1], Walls.SouthEastWall);
                SetMazeConnection(Maze[7, 2], Walls.NorthWestWall);
                SetMazeConnection(Maze[7, 3], Walls.SouthEastWall);
                SetMazeConnection(Maze[7, 4], Walls.SouthWestWall);
                SetMazeConnection(Maze[7, 5], Walls.SouthEastWall);
                SetMazeConnection(Maze[7, 6], Walls.SouthWestWall);
                SetMazeConnection(Maze[7, 7], Walls.Up);
            }

        }

        /// <summary>
        /// Method that tells what other nodes current node is connected to
        /// </summary>
        /// <param name="node">the node that may have connections</param>
        /// <param name="north">If there is a north node</param>
        /// <param name="east">If there is a east node</param>
        /// <param name="south">If there is a south node</param>
        /// <param name="west">If there is a west node</param>
        private void SetMazeConnection(Node node, Walls wall)
        {
            bool north, east, south, west;
            switch (wall)
            {
                case Walls.Up:
                    north = false;
                    east = true;
                    south = true;
                    west = true;
                    break;

                case Walls.Right:
                    north = true;
                    east = false;
                    south = true;
                    west = true;
                    break;

                case Walls.Down:
                    north = true;
                    east = true;
                    south = false;
                    west = true;
                    break;

                case Walls.Left:
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

                case Walls.NorthWestWall:
                    north = false;
                    south = true;
                    west = false;
                    east = true;
                    break;

                case Walls.NorthEastWall:
                    north = false;
                    south = true;
                    west = true;
                    east = false;
                    break;

                case Walls.SouthEastWall:
                    north = false;
                    south = false;
                    west = true;
                    east = true;
                    break;

                case Walls.SouthWestWall:
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
                if (node.Row == 0)
                {
                    node.North = Maze[7, node.Colunm];
                }

                else
                {
                    node.North = Maze[node.Row - 1, node.Colunm];
                }
            }

            if (east)
            {
                if (node.Colunm == 7)
                {
                    node.East = Maze[node.Row, 0];
                }

                else
                {
                    node.East = Maze[node.Row, node.Colunm + 1];
                }
            }

            if (south)
            {
                if (node.Row == 7)
                {
                    node.South = Maze[0, node.Colunm];
                }

                else
                {
                    node.South = Maze[node.Row + 1, node.Colunm];
                }
            }

            if (west)
            {
                if (node.Colunm == 0)
                {
                    node.West = Maze[node.Row, 7];
                }

                else
                {
                    node.West = Maze[node.Row, node.Colunm - 1];
                }
            }
        }

        public void PrintGrid()
        {
            for (int row = 0; row < 8; row++)
            {
                for (int column = 0; column < 8; column++)
                {
                    Console.Write(Maze[row, column].Character + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
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

            public Node(int row, int column, char character)
            {
                Row = row;
                Colunm = column;
                Character = character;

                North = null;
                East = null;
                South = null;
                West = null;
            }
        }
        //CLASSES
        /* Node class that contains the following fields:
        
        
         -Row (int)
         -Column (int)
         -Charater (char)
         -North neighbor (Node)
         -East neighbor (Node)
         -South neighbor (Node)
         -West neighbor (Node)
        */
    }
}
