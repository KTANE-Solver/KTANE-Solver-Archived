using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace KTANE_Solver
{
    //Date: 4/30/21
    //Purpose: solves the "chess" module 
    class Chess : Module
    {
        //FIELDS

        //a 6x6 2d char array that represents the board
        private char[,] board;

        //the character for piece 1
        private char piece1;

        //the location for piece 1
        private int[] piece1Location;

        //the character for piece 2
        private char piece2;

        //the location for piece 2
        private int[] piece2Location;

        //the character for piece 3
        private char piece3;

        //the location for piece 3
        private int[] piece3Location;

        //the character for piece 4
        private char piece4;

        //the location for piece 4
        private int[] piece4Location;

        //the character for piece 5
        private char piece5;

        //the location for piece 5
        private int[] piece5Location;

        //the character for piece 6
        private char piece6;

        //the location for piece 6
        private int[] piece6Location;

        //CONSTRUCTOR

        //will take 6 positions for the pieces, the bomb, and the streamwriter
        public Chess(String position1, String position2, String position3, String position4, String position5, String position6, Bomb bomb, StreamWriter logWriterFile) : base (bomb, logWriterFile)
        {
            //determine all the piece locations
            piece1Location = ConvertLocation(position1);
            piece2Location = ConvertLocation(position2);
            piece3Location = ConvertLocation(position3);
            piece4Location = ConvertLocation(position4);
            piece5Location = ConvertLocation(position5);
            piece6Location = ConvertLocation(position6);

            //determine all the pieces
            piece4 = DeterminePiece(piece4Location, 4);
            piece5 = DeterminePiece(piece5Location, 5);
            piece1 = DeterminePiece(piece1Location, 1);
            piece2 = DeterminePiece(piece2Location, 2);
            piece3 = DeterminePiece(piece2Location, 3);
            piece6 = DeterminePiece(piece2Location, 6);

            //print information about all the pieces
            PrintPiece(1, piece1, position1);
            PrintPiece(2, piece2, position2);
            PrintPiece(3, piece3, position3);
            PrintPiece(4, piece4, position4);
            PrintPiece(5, piece5, position5);
            PrintPiece(6, piece6, position6);

            Console.WriteLine();
        }

        //METHODS

        /// <summary>
        /// Solves the module
        /// </summary>
        public void Solve()
        {
            //place all pieces on board
            PlacePiece(piece1, piece1Location);
            PlacePiece(piece2, piece2Location);
            PlacePiece(piece3, piece3Location);
            PlacePiece(piece4, piece4Location);
            PlacePiece(piece5, piece5Location);
            PlacePiece(piece6, piece6Location);

            //sees which tiles are covered by the pieces
            ConverArea(piece1, piece1Location);
            ConverArea(piece2, piece2Location);
            ConverArea(piece3, piece3Location);
            ConverArea(piece4, piece4Location);
            ConverArea(piece5, piece5Location);
            ConverArea(piece6, piece6Location);

            //print the board
            PrintBoard();

            //find the unchecked piece
            int row = -1;
            int column = -1;

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (board[i, j] == '.')
                    {
                        row = i;
                        column = j;
                        break;
                    }
                }

                if (row != 1)
                    break;
            }

            //convert the location back to the module

            String answer = $"{Math.Abs(6 - row)}{(char)(column + 97)}";

            MessageBox.Show(answer, "Chess Answer", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Will tell which piece is what
        /// </summary>
        /// <param name="position">the position of the piece on the board</param>
        /// <param name="pieceNum">the number order of the piece</param>
        private char DeterminePiece(int[] position, int pieceNum)
        {
            switch (pieceNum)
            {
                case 1:
                    //Occupied by a king if Position #5 is occupied by a queen.
                    if (piece5 == 'Q')
                        return 'K';

                    //Otherwise, the field is occupied by a bishop.
                    return 'B';

                case 2:
                    //Occupied by a rook if the last digit of the serial number is odd.
                    if (Bomb.LastDigit % 2 == 1)
                        return 'R';

                    //Otherwise, the field is occupied by a knight.
                    return 'N';

                case 3:
                    //Occupied by a queen if there are less than two rooks on the board.
                    if (PieceCount('R') < 2)
                        return 'Q';

                    //Otherwise, the field is occupied by a king.
                    return 'K';

                case 4:
                    //Always occupied by a rook.
                    return 'R';

                case 5:
                    //Occupied by a queen if the field is white.
                    if (position[0] % 2 == 0 && position[1] % 2 == 0)
                        return 'Q';


                    //Otherwise, the field is occupied by a rook.
                    return 'R';

                case 6:
                    //Occupied by a queen if there are no other queens on the board.
                    if (piece5 != 'Q' && piece3 != 'Q')
                        return 'Q';

                    //Otherwise, occupied by a knight if there are no other knights on the board.
                    if (piece2 != 'N')
                        return 'N';


                    //Otherwise, the field is occupied by a bishop.
                    return 'B';
            }

            //shouldn't happen
            return 'F';
        }

        /// <summary>
        /// tells how many of a certain peice is on the baord
        /// </summary>
        /// <param name="piece">the name of the peice</param>
        /// <returns>the number of peices</returns>
        private int PieceCount(char piece)
        {
            int num = 0;

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (board[i, j] == piece)
                        num++;
                }
            }

            return num;
        }

        /// <summary>
        /// Converts the location of the peice so it can be placed on the board
        /// </summary>
        /// <param name="location"></param>
        /// <returns></returns>
        private int[] ConvertLocation(String location)
        {
            return new int[] { (int)location[0] - 54, (int)location[1] - 65 };
        }

        //a method that places all the pieces on the board
        private void PlacePiece(char piece, int[] position)
        {
            board[position[0], position[1]] = piece;
        }



        //a method that will tell where a king will go

        /// <summary>
        /// Tells where the king can go
        /// </summary>
        /// <param name="position">the position of the king</param>
        private void KingArea(int[] position)
        {
            for (int row = -1; row < 2; row++)
            {
                for (int column = -1; column < 2; column++)
                {
                    int newRow = position[0] + row;
                    int newColumn = position[1] + column;

                    if (ValidCoordinate(newRow, newColumn) && (row != 0 && column != 0))
                    {
                        board[newRow, newColumn] = '*';
                    }
                }
            }
        }


        /// <summary>
        ///  Tells where the rook can go
        /// </summary>
        /// <param name="position">the position of the rook</param>
        private void RookArea(int[] position)
        {
            //go up

            int newRow = position[0] - 1;

            while (ValidCoordinate(newRow, position[1]))
            {
                board[newRow, position[1]] = '*';
            }

            //go down

            newRow = position[0] + 1;

            while (ValidCoordinate(newRow, position[1]))
            {
                board[newRow, position[1]] = '*';
            }

            //go left

            int newColumn = position[1] - 1;

            while (ValidCoordinate(position[0], newColumn))
            {
                board[position[0], newColumn] = '*';
            }

            //go right

            newColumn = position[1] + 1;

            while (ValidCoordinate(position[0], newColumn))
            {
                board[position[0], newColumn] = '*';
            }
        }


        /// <summary>
        /// Tells where a knight will go
        /// </summary>
        /// <param name="position"></param>
        private void KnightArea(int[] position)
        {
            //left twice
            if (ValidCoordinate(position[0], position[1] - 1))
            {
                board[position[0], position[1] - 1] = '*';

                if (ValidCoordinate(position[0], position[1] - 2))
                {
                    board[position[0], position[1] - 2] = '*';

                    //up once
                    if (ValidCoordinate(position[0] - 1, position[1] - 2))
                        board[position[0] - 1, position[1] - 2] = '*';


                    //down once
                    if (ValidCoordinate(position[0] + 1, position[1] - 2))
                        board[position[0] + 1, position[1] - 2] = '*';
                }


            }


            //right twice
            if (ValidCoordinate(position[0], position[1] + 1))
            {
                board[position[0], position[1] + 1] = '*';

                if (ValidCoordinate(position[0], position[1] + 2))
                {
                    board[position[0], position[1] + 2] = '*';

                    //up once
                    if (ValidCoordinate(position[0] - 1, position[1] + 2))
                        board[position[0] - 1, position[1] + 2] = '*';


                    //down once
                    if (ValidCoordinate(position[0] + 1, position[1] + 2))
                        board[position[0] + 1, position[1] + 2] = '*';
                }

            }

            //up once
            if (ValidCoordinate(position[0] - 1, position[1]))
            {
                board[position[0] - 1, position[1]] = '*';


                if (ValidCoordinate(position[0] - 2, position[1]))
                {
                    //left once
                    if (ValidCoordinate(position[0] - 2, position[1] - 1))
                        board[position[0] - 2, position[1] - 1] = '*';

                    //right once
                    if (ValidCoordinate(position[0] - 2, position[1] + 1))
                        board[position[0] - 2, position[1] + 1] = '*';
                }


            }

            //down once
            if (ValidCoordinate(position[0] + 1, position[1]))
            {
                board[position[0] + 1, position[1]] = '*';


                if (ValidCoordinate(position[0] + 2, position[1]))
                {
                    //left once
                    if (ValidCoordinate(position[0] + 2, position[1] - 1))
                        board[position[0] + 2, position[1] - 1] = '*';

                    //right once
                    if (ValidCoordinate(position[0] + 2, position[1] + 1))
                        board[position[0] + 2, position[1] + 1] = '*';
                }


            }


        }

        //a method that will 

        /// <summary>
        /// Tells where a bishop will go
        /// </summary>
        /// <param name="position"></param>
        private void BishopArea(int[] position)
        {
            int newRow = 1;
            int newColumn = 1;

            //top left
            while (ValidCoordinate(position[0] - newRow, position[1] - newColumn))
            {
                board[position[0] - newRow, position[1] - newColumn] = '*';
            }



            //top right

            newRow = 1;
            newColumn = 1;

            while (ValidCoordinate(position[0] - newRow, position[1] + newColumn))
            {
                board[position[0] - newRow, position[1] + newColumn] = '*';
            }

            //bottom left

            newRow = 1;
            newColumn = 1;

            while (ValidCoordinate(position[0] + newRow, position[1] - newColumn))
            {
                board[position[0] + newRow, position[1] - newColumn] = '*';
            }

            //bottom right

            newRow = 1;
            newColumn = 1;

            while (ValidCoordinate(position[0] + newRow, position[1] + newColumn))
            {
                board[position[0] + newRow, position[1] + newColumn] = '*';
            }
        }

        /// <summary>
        /// Tells where a queen will go
        /// </summary>
        /// <param name="position"></param>
        private void QueenArea(int[] position)
        {
            RookArea(position);
            BishopArea(position);
        }

        /// <summary>
        /// Covers the tiles depending on the piece
        /// </summary>
        /// <param name="piece">the piece itself</param>
        /// <param name="position">the position of the piece</param>
        private void ConverArea(char piece, int[] position)
        {
            switch (piece)
            {
                case 'K':
                    KingArea(position);
                    break;

                case 'N':
                    KnightArea(position);
                    break;

                case 'R':
                    RookArea(position);
                    break;

                case 'B':
                    BishopArea(position);
                    break;

                case 'Q':
                    QueenArea(position);
                    break;
            }
        }

        //a method that will tell if a position is considered valid
        private bool ValidCoordinate(int row, int column)
        {
            return row >= 0 && row <= 5 &&
                   column >= 0 && column <= 5;
        }

        /// <summary>
        /// Prints the board
        /// </summary>
        private void PrintBoard()
        {
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.Write(board[i, j] + " ");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }

        /// <summary>
        /// Prints information about the piece
        /// </summary>
        /// <param name="num"></param>
        /// <param name="piece"></param>
        private void PrintPiece(int num, char piece, String locattion)
        {
            Console.WriteLine($"{num}. Location {locattion}: {piece}");
        }

    }
}
