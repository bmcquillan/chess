using System;
using System.Collections.Generic;
using System.Text;

namespace ChessApp.Models.Pieces
{
    public abstract class Piece
    {
        public readonly Colour Colour;
        public abstract string Icon { get; }
    }
}
