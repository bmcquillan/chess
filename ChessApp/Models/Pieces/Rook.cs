using System;
using System.Collections.Generic;
using System.Text;

namespace ChessApp.Models.Pieces
{
    public class Rook : Piece
    {
        public bool HasMoved { get; private set; }
        public override string Icon { get => Colour == Colour.White ? "R" : "r"; }

        public Rook(Colour colour) : base(colour)
        {

        }
    }
}