using System;
using System.Collections.Generic;
using System.Text;
using ChessApp.BusinessLogic;

namespace ChessApp.Models.Pieces
{
    public class Rook : Piece
    {
        public bool HasMoved { get; private set; }
        public override string Icon { get => Colour == Colour.White ? "R" : "r"; }

        public Rook(Colour colour) : base(colour)
        {

        }

        public static bool isValidMovePosition((int x, int y) start, (int x, int y) end)
        {
            return RuleService.isStraightMove(start, end) && end != start;
        }
    }
}