using System;
using System.Collections.Generic;
using System.Text;
using ChessApp.BusinessLogic;

namespace ChessApp.Models.Pieces
{
    public class Queen : Piece
    {
        public bool HasMoved { get; set; }

        public override string Icon { get => Colour == Colour.White ? "Q" : "q"; }

        public Queen(Colour colour) : base(colour)
        {

        }

        public static bool isValidMovePosition((int x, int y) start, (int x, int y) end)
        {
            return (RuleService.isDiagonalMove(start, end) || RuleService.isStraightMove(start,end)) && end != start;
        }
    }
}
