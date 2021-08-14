using System;
using System.Collections.Generic;
using System.Text;

namespace ChessApp.Models.Pieces
{
    public class Pawn : Piece
    {
        public bool HasMoved { get; private set; }
        public override string Icon { get => Colour == Colour.White ? "P" : "p"; }

        public Pawn(Colour colour) : base(colour)
        {

        }

        public bool isValidMovePosition((int x, int y) start, (int x, int y) end)
        {
            return (start.x - end.x == 0 && Math.Abs(end.y - start.y) <= 2) ||
                (Math.Abs(end.x - start.x) == 1 && Math.Abs(end.y - start.y) == 1);
        }
    }
}