using ChessApp.Models.Pieces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChessApp.Models
{
    public class Board
    {
        private Square[,] squares = new Square[8, 8];

        public Board() { this.createBoard(); }

        public void initializePieces()
        {
            for (int i = 0; i < 8; i++)
            {
                squares[1, i].Piece = new Pawn(Colour.Black);
                squares[6, i].Piece = new Pawn(Colour.White);
                if (i == 0 | i == 7)
                {
                    squares[0, i].Piece = new Rook(Colour.Black);
                    squares[7, i].Piece = new Rook(Colour.White);
                } 
                if (i == 1 | i == 6)
                {
                    squares[0, i].Piece = new Knight(Colour.Black);
                    squares[7, i].Piece = new Knight(Colour.White);
                }
                if (i == 2 | i == 5)
                {
                    squares[0, i].Piece = new Bishop(Colour.Black);
                    squares[7, i].Piece = new Bishop(Colour.White);
                }
                if (i == 4)
                {
                    squares[0, i].Piece = new King(Colour.Black);
                    squares[7, i].Piece = new King(Colour.White);
                }
                if (i == 3)
                {
                    squares[0, i].Piece = new Queen(Colour.Black);
                    squares[7, i].Piece = new Queen(Colour.White);
                }
            }
        }

        public Colour? inCheckMate() {
            return null;
        }


        public void createBoard()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    this.squares[i, j] = new Square();
                    this.squares[i, j].Colour = i % 2 == j % 2 ? Colour.White : Colour.Black;
                }
            }
        }

        public void PrintBoard()
        {
            for (int row = 7; row >= 0; row--)
            {
                // print row specifier
                Console.Write("{0} ", row + 1);

                for (int col = 0; col < 8; col++)
                {

                    // print piece
                    Console.Write("|{0}", squares[row, col].Piece?.Icon ?? ".");
                }
                Console.WriteLine();
            }
            Console.WriteLine("   a b c d e f g h");
        }

        public Piece? GetPiece(string notation)
        {
            return GetSquare(notation).Piece;
        }

        private Square GetSquare(string notation)
        {
            string lowerCaseNotation = notation.ToLower();
            int column = lowerCaseNotation[0] - 97;
            int row = int.Parse(lowerCaseNotation.Substring(1, 1)) - 1;

            return squares[row, column];
        }

        private Square GetKingLocation(Colour kingColour)
        {
            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
                {

                    if(squares[row, col].Piece is King && squares[row, col].Piece.Colour == kingColour)
                    {
                        return squares[row, col];
                    }
                }
            }
            throw new ArgumentOutOfRangeException($"Could not find King of target colour {kingColour}");
        }

        private List<(int, int)> FindPieces(Colour colour, Type pieceType)
        {
            List<(int, int)> positions = new List<(int, int)>();

            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
                {

                    if (squares[row, col].Piece != null && pieceType == squares[row, col].Piece.GetType() && squares[row, col].Piece.Colour == colour)
                    {
                        positions.Add((row, col));
                    }
                }
            }
            return positions
        }
    }
}
