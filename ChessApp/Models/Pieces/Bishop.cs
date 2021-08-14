using System;
using System.Collections.Generic;
using System.Text;
using ChessApp.BusinessLogic;

namespace ChessApp.Models.Pieces
{
    public class Bishop : Piece
    {
        public bool HasMoved { get; set; }

        public override string Icon { get => Colour == Colour.White ? "B" : "b"; }

        public Bishop(Colour colour) : base(colour)
        {

        }

        public static bool isValidMovePosition((int x, int y) start, (int x, int y) end)
        {
            return RuleService.isDiagonalMove(start,end) && end != start;
        }
    }
}
