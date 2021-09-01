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

        private Piece piece1;
        private Piece piece2;
        private Piece piece3;
        private Piece piece4;
        private Piece piece5;
        private Piece piece6;

        //CONSTRUCTOR

        //will take 6 positions for the pieces, the bomb, and the streamwriter
        public Chess(String position1, String position2, String position3, String position4, String position5, String position6, Bomb bomb, StreamWriter logWriterFile) : base(bomb, logWriterFile)
        {
            board = new char[,]
                {
                    {'.','.','.','.','.','.'},
                    {'.','.','.','.','.','.'},
                    {'.','.','.','.','.','.'},
                    {'.','.','.','.','.','.'},
                    {'.','.','.','.','.','.'},
                    {'.','.','.','.','.','.'}
                };

            //determine all the piece locations
            piece1 = new Piece (ConvertLocation(position1));
            piece2 = new Piece (ConvertLocation(position2));
            piece3 = new Piece (ConvertLocation(position3));
            piece4 = new Piece (ConvertLocation(position4));
            piece5 = new Piece (ConvertLocation(position5));
            piece6 = new Piece (ConvertLocation(position6));


            //determine and place all the pieces
            piece4.PieceChar = DeterminePiece(piece4.PieceLocation, 4);
            PlacePiece(piece4);

            piece5.PieceChar = DeterminePiece(piece5.PieceLocation, 5);
            PlacePiece(piece5);

            piece1.PieceChar = DeterminePiece(piece1.PieceLocation, 1);
            PlacePiece(piece1);

            piece2.PieceChar = DeterminePiece(piece2.PieceLocation, 2);
            PlacePiece(piece2);

            piece3.PieceChar = DeterminePiece(piece3.PieceLocation, 3);
            PlacePiece(piece3);

            piece6.PieceChar = DeterminePiece(piece6.PieceLocation, 6);
            PlacePiece(piece6);

            //print information about all the pieces
            PrintPiece(1, piece1.PieceChar, position1);
            PrintPiece(2, piece2.PieceChar, position2);
            PrintPiece(3, piece3.PieceChar, position3);
            PrintPiece(4, piece4.PieceChar, position4);
            PrintPiece(5, piece5.PieceChar, position5);
            PrintPiece(6, piece6.PieceChar, position6);

            PrintDebugLine("");
        }

        //METHODS

        /// <summary>
        /// Solves the module
        /// </summary>
        public void Solve()
        {
            //sees which tiles are covered by the pieces
            ConverArea(piece1);
            ConverArea(piece2);
            ConverArea(piece3);
            ConverArea(piece4);
            ConverArea(piece5);
            ConverArea(piece6);

            //print the board
            PrintBoard();

            List<String> answerList = new List<string>();

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {

                    if (board[i, j] == '.')
                    {
                        answerList.Add("" + i + j);
                    }
                }
            }

            //convert the location back to the module

            String answer = "";

            if (answerList.Count > 1)
            {
                answer = "Unable to find answer. Mutiple possible answers found:\n\n";
                List<String> newAnwerList = new List<string>();

                foreach (String a in answerList)
                {
                    newAnwerList.Add($"{(char)(int.Parse("" + a[1]) + 97)}{Math.Abs(6 - int.Parse("" + a[0]))}");
                }

                answer += string.Join(", ", newAnwerList);
            }

            else if (answerList.Count == 0)
            {
                answer = "Couldn't find answer";
            }

            else
            {
                answer = $"{(char)(int.Parse("" + answerList[0][1]) + 97)}{Math.Abs(6 - int.Parse("" + answerList[0][0]))}";
            }

            PrintDebug($"Answer: {answer}\n");

            ShowAnswer(answer, "Chess Answer");

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
                    if (piece5.PieceChar == 'Q')
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
                    if (position[0] % 2 == position[1] % 2)
                        return 'Q';


                    //Otherwise, the field is occupied by a rook.
                    return 'R';

                case 6:
                    //Occupied by a queen if there are no other queens on the board.
                    if (piece5.PieceChar != 'Q' && piece3.PieceChar != 'Q')
                        return 'Q';

                    //Otherwise, occupied by a knight if there are no other knights on the board.
                    if (piece2.PieceChar != 'N')
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
            return new int[] { Math.Abs((int)location[1] - 54), (int)location[0] - 97 };
        }

        private string ConvertLocation(int[] pieceLication)
        {
            return $"{(char)(int.Parse("" + pieceLication[1]) + 97)}{Math.Abs(6 - int.Parse("" + pieceLication[0]))}";
        }

        //a method that places all the pieces on the board
        private void PlacePiece(Piece piece)
        {
            board[piece.PieceLocation[0], piece.PieceLocation[1]] = piece.PieceChar;
        }

        /// <summary>
        /// Tells if a tile is a piece
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        private bool isPiece(int row, int column)
        {
            char character = board[row, column];

            switch (character)
            {
                case 'K':
                case 'R':
                case 'Q':
                case 'B':
                case 'N':
                    return true;

                default:
                    return false;

            }
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

                    if (ValidCoordinate(newRow, newColumn))
                    {
                        CoverTile(newRow, newColumn);
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

            int newRow = 1;

            while (ValidCoordinate(position[0] - newRow, position[1]) && !isPiece(position[0] - newRow, position[1]))
            {
                board[position[0] - newRow, position[1]] = '*';
                newRow++;
            }

            //go down

            newRow = 1;

            while (ValidCoordinate(position[0] + newRow, position[1]) && !isPiece(position[0] + newRow, position[1]))
            {
                board[position[0] + newRow, position[1]] = '*';
                newRow++;
            }

            //go left

            int newColumn = 1;

            while (ValidCoordinate(position[0], position[1] - newColumn) && !isPiece(position[0], position[1] - newColumn))
            {
                board[position[0], position[1] - newColumn] = '*';
                newColumn++;
            }

            //go right

            newColumn = 1;

            while (ValidCoordinate(position[0], position[1] + newColumn) && !isPiece(position[0], position[1] + newColumn))
            {
                board[position[0], position[1] + newColumn] = '*';
                newColumn++;
            }
        }


        /// <summary>
        /// Tells where a knight will go
        /// </summary>
        /// <param name="position"></param>
        private void KnightArea(int[] position)
        {
            //left twice and up once
            if (ValidCoordinate(position[0] - 1, position[1] - 2))
                CoverTile(position[0] - 1, position[1] - 2);


            //left twice and down once
            if (ValidCoordinate(position[0] + 1, position[1] - 2))
                CoverTile(position[0] + 1, position[1] - 2);

            //right twice and up once
            if (ValidCoordinate(position[0] - 1, position[1] + 2))
                CoverTile(position[0] - 1, position[1] + 2);

            //right twice and down once
            if (ValidCoordinate(position[0] + 1, position[1] + 2))
                CoverTile(position[0] + 1, position[1] + 2);

            //up twice and left once
            if (ValidCoordinate(position[0] - 2, position[1] - 1))
                CoverTile(position[0] - 2, position[1] - 1);

            //up twice and right once
            if (ValidCoordinate(position[0] - 2, position[1] + 1))
                CoverTile(position[0] - 2, position[1] + 1);


            //down twice and left once
            if (ValidCoordinate(position[0] + 2, position[1] - 1))
                CoverTile(position[0] + 2, position[1] - 1);

            //down twice and right once
            if (ValidCoordinate(position[0] + 2, position[1] + 1))
                CoverTile(position[0] + 2, position[1] + 1);
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
                CoverTile(position[0] - newRow, position[1] - newColumn);
                newColumn++;
                newRow++;
            }

            //top right

            newRow = 1;
            newColumn = 1;

            while (ValidCoordinate(position[0] - newRow, position[1] + newColumn))
            {
                CoverTile(position[0] - newRow, position[1] + newColumn);
                newColumn++;
                newRow++;
            }

            //bottom left

            newRow = 1;
            newColumn = 1;

            while (ValidCoordinate(position[0] + newRow, position[1] - newColumn))
            {
                CoverTile(position[0] + newRow, position[1] - newColumn);
                newColumn++;
                newRow++;
            }


            //bottom right

            newRow = 1;
            newColumn = 1;

            while (ValidCoordinate(position[0] + newRow, position[1] + newColumn))
            {
                CoverTile(position[0] + newRow, position[1] + newColumn);
                newColumn++;
                newRow++;
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
        private void ConverArea(Piece piece)
        {
            switch (piece.PieceChar)
            {
                case 'K':
                    KingArea(piece.PieceLocation);
                    break;

                case 'N':
                    KnightArea(piece.PieceLocation);
                    break;

                case 'R':
                    RookArea(piece.PieceLocation);
                    break;

                case 'B':
                    BishopArea(piece.PieceLocation);
                    break;

                case 'Q':
                    QueenArea(piece.PieceLocation);
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
                    PrintDebug(board[i, j] + " ");
                }

                PrintDebugLine("");
            }

            PrintDebugLine("");
        }

        /// <summary>
        /// Prints information about the piece
        /// </summary>
        /// <param name="num"></param>
        /// <param name="piece"></param>
        private void PrintPiece(int num, char piece, String locattion)
        {
            PrintDebugLine($"{num}. Location {locattion}: {piece}");
        }

        /// <summary>
        /// Covers a tile if it's blank
        /// </summary>
        /// <param name="row"></param>
        /// <param name="column"></param>
        private void CoverTile(int row, int column)
        {
            if (board[row, column] == '.')
                board[row, column] = '*';
        }

        private class Piece
        {
            //tells what the piece is 
            public char PieceChar { get; set;  }

            //the location for piece 1
            public int[] PieceLocation { get; }

            public Piece(int [] pieceLocation)
            {
                PieceLocation = pieceLocation;
            }
        }

    }
}
