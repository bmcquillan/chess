using System;
using System.Collections.Generic;
using System.Text;

namespace ChessApp.Models
{
    public class Move
    {
        public string oldPosition { get; set; }
        public string newPosition { get; set; }

        public Move(string notation, List<string> specialMoves)
        {
            if(specialMoves.Contains(notation))
            {
                oldPosition = newPosition = notation;
            }
            else
            {
                string[] squares = notation.Split('-');
                oldPosition = squares[0];
                newPosition = squares[1];
            }
        }

    }
}
