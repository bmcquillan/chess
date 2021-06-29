using System;
using System.Collections.Generic;
using ChessApp.Models;

namespace ChessApp
{
    public class Game
    {
        public List<Board> history;
        public Game()
        {
            this.history = new List<Board>();
            this.history.Add(new Board());
        }

    }
}
