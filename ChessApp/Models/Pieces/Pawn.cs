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
    }
}