using System;
using System.Collections.Generic;
using System.Text;

namespace ChessApp.Models.Pieces
{
    public class Bishop : Piece
    {
        public bool HasMoved { get; set; }

        public override string Icon { get => Colour == Colour.White ? "B" : "b"; }

        public Bishop(Colour colour) : base(colour)
        {

        }
    }
}
