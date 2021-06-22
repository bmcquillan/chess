using System;
using System.Collections.Generic;
using System.Text;

namespace ChessApp.Models
{
    public class Board
    {
        private Square[,] squares = new Square[8, 8];

        public void createBoard()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    this.squares[i, j] = new Square();
                    this.squares[i, j].Colour = (i % 2 == 0 & j % 2 == 0) | (i % 2 != 0 & j % 2 != 0) ? Colour.White : Colour.Black;
                }
            }
        }

        public void lazyPrint()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.Write(this.squares[i, j].Colour == Colour.Black ? " " : "\u2588");
                }
                Console.WriteLine();
            }
        }
    }
}
