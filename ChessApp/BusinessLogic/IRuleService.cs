using ChessApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChessApp.BusinessLogic
{
    public interface IRuleService
    {
        public bool IsValid(Move move, Board board);

        public bool IsCheck();

        public bool IsCheckMate();
    }
}
