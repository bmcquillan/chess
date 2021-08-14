using System;
using System.Collections.Generic;
using System.Text;

namespace ChessApp.Models.Pieces
{
    public class Knight : Piece
    {
        public bool HasMoved { get; set; }
        public override string Icon { get => Colour == Colour.White ? "N" : "n"; }
        public Knight(Colour colour) : base(colour)
        {

        }

        public bool isValidMovePosition((int x, int y) start, (int x, int y) end)
        {
            return (Math.Abs(start.x - end.x) == 2 && Math.Abs(start.y - end.y) == 1) ||
                (Math.Abs(start.x - end.x) == 1 && Math.Abs(start.y - end.y) == 2);
        }
    }
}