using System;
using System.Collections.Generic;
using System.Text;

namespace ChessApp.Models.Pieces
{
    public class Queen : Piece
    {
        public bool HasMoved { get; set; }

        public override string Icon { get => Colour == Colour.White ? "Q" : "q"; }

        public Queen(Colour colour) : base(colour)
        {

        }
    }
}
