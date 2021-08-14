using ChessApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChessApp.BusinessLogic
{
    public class RuleService : IRuleService
    {
        public bool IsCheck()
        {
            throw new NotImplementedException();
        }

        public bool IsCheckMate()
        {
            throw new NotImplementedException();
        }

        public bool IsValid(Move move, Board board)
        {
            throw new NotImplementedException();
        }


        internal static bool isDiagonalMove((int x, int y) start, (int x, int y) end)
        {
            return Math.Abs(start.x - end.x) == Math.Abs(start.y - end.y) && end != start;
        }

        internal static bool isStraightMove((int x, int y) start, (int x, int y) end)
        {
            return (Math.Abs(start.x - end.x) > 0 && Math.Abs(start.y - end.y) == 0) ||
                (Math.Abs(start.x - end.x) == 0 && Math.Abs(start.y - end.y) > 0);
        }
    }
}
