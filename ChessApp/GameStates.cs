using System;
using System.Collections.Generic;
using ChessApp.Models;

namespace ChessApp
{
    public class GameStates
    {
        public List<(Colour, Board)> History;
        public GameStates()
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
