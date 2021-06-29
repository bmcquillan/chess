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
    }
}
