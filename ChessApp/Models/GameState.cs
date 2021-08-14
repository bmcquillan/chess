using System;
using System.Collections.Generic;
using ChessApp.Models;

namespace ChessApp.Models
{
    public class GameState
    {
        public List<(Colour, Board)> History;
        public GameState()
        {
            this.History = new List<(Colour,Board)>();
            Board start = new Board();
            start.initializePieces();
            this.History.Add((Colour.White,start));
        }

        public (Colour, Board) getCurrentState()
        {
            return this.History[this.History.Count - 1];
        }

    }

    
}
