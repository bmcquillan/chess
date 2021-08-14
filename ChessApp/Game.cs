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
            Board start = new Board();
            start.initializePieces();
            this.history.Add(start);
        }

        public Board getCurrentState()
        {
            return history[history.Count - 1];
        }
    }
}
