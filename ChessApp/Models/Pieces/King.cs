using System;
using System.Collections.Generic;
using System.Text;

namespace ChessApp.Models.Pieces
{
    public class King : Piece
    {
        public bool HasMoved { get; set; }

        public override string Icon { get => Colour == Colour.White ? "K" : "k"; }

        public King(Colour colour) : base(colour)
        {

        }

        public static bool isValidMovePosition((int x, int y) start, (int x, int y) end)
        {
            return (Math.Abs(start.x - end.x) <= 1 && Math.Abs(start.y - end.y) <= 1) && end != start;
        }
    }
}
