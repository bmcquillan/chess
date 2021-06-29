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
                squares[1, i].piece = new Pawn(Colour.Black);
                squares[6, i].piece = new Pawn(Colour.White);
                if (i == 0 | i == 7)
                {
                    squares[0, i].piece = new Rook(Colour.Black);
                    squares[7, i].piece = new Rook(Colour.White);
                } 
                if (i == 1 | i == 6)
                {
                    squares[0, i].piece = new Knight(Colour.Black);
                    squares[7, i].piece = new Knight(Colour.White);
                }
                if (i == 2 | i == 5)
                {
                    squares[0, i].piece = new Bishop(Colour.Black);
                    squares[7, i].piece = new Bishop(Colour.White);
                }
                if (i == 4)
                {
                    squares[0, i].piece = new King(Colour.Black);
                    squares[7, i].piece = new King(Colour.White);
                }
                if (i == 3)
                {
                    squares[0, i].piece = new Queen(Colour.Black);
                    squares[7, i].piece = new Queen(Colour.White);
                }
            }
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

        public void lazyPrint()
        {
            Console.Write(" ");
            for (int i = 0; i < 8; i++)
            {
                Console.Write(i.ToString());
            }
            Console.WriteLine();
            for (int i = 0; i < 8; i++)
            {
                Console.Write(i.ToString());
                for (int j = 0; j < 8; j++)
                {
                    Console.Write(this.squares[i, j].Colour == Colour.Black ? " " : "\u2588");
                }
                Console.WriteLine();
            }
        }

        public void lazyPrintPieces()
        {
            Console.Write(" ");
            for (int i = 0; i < 8; i++)
            {
                Console.Write(i.ToString());
            }
            Console.WriteLine();
            for (int i = 0; i < 8; i++)
            {
                Console.Write(i.ToString());
                for (int j = 0; j < 8; j++)
                {
                    if (this.squares[i,j].piece != null)
                    {
                        Console.Write(this.squares[i, j].piece.Icon);
                    }
                    else
                    {
                        Console.Write(this.squares[i, j].Colour == Colour.Black ? " " : "\u2588");
                    }

                    
                }
                Console.WriteLine();
            }
        }
    }
}
