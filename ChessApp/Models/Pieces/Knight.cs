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

    }
}