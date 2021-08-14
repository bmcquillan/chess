using System;
using System.Collections.Generic;
using ChessApp.Models;

namespace ChessApp.Models
{
    public class GameState
    {
        public List<(Colour, Board)> History { get; set; }

        public Colour ActivePlayer { get; set; }

        public Board CurrentBoard { get; set; }

        public GameState()
        {
            this.History = new List<(Colour,Board)>();
            Board start = new Board();
            start.initializePieces();
            CurrentBoard = start;
            ActivePlayer = Colour.White;
        }

        public (Colour, Board) getCurrentState()
        {
            return (ActivePlayer, CurrentBoard);
        }

        public void PrintState()
        {
            Console.WriteLine($"Active colour: {ActivePlayer}");
            CurrentBoard.PrintBoard();
        }

    }

    
}
