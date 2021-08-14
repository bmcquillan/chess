using System;
using System.Collections.Generic;
using ChessApp.BusinessLogic;
using ChessApp.Models;

namespace ChessApp.BusinessLogic
{
    public class Gameplay : IGameplay
    {
        private GameState game = new GameState();
        private readonly IRuleService _ruleService;
        private string resignNotation = "resign";
        private readonly List<string> specialMoveNotation = new List<string> { "o-o", "o-o-o" };
        public Gameplay(IRuleService ruleService)
        {
            _ruleService = ruleService;
            specialMoveNotation.Add(resignNotation);
        }

        public void takeTurns()
        {
            game.PrintState();
            while (true) // 
            {
                Colour activePlayer = game.ActivePlayer;
                Move? proposedMove = GetMove(activePlayer);

                if (proposedMove is null)
                {
                    break;
                }

                // check if move input is syntactically valid

                //try move

                //validate new state

                //
                game.PrintState();

            }
            Console.WriteLine("Game over");//print winner

        }

        private Move? GetMove(Colour playerColour)
        {
            if (playerColour == Colour.Black)
            {
                Console.WriteLine("Enter black's move: ");
            }
            else
            {
                Console.WriteLine("Enter white's move: ");
            }

            Move newMove;
            do
            {
                string moveString;
                do
                {
                    moveString = Console.ReadLine().ToLower();
                } while (!IsValidMoveString(moveString));
                
                newMove = new Move(moveString, specialMoveNotation);
            } while (!IsValidMove(newMove));

            if (newMove.newPosition == resignNotation)
            {
                return null;
            }
            else
            {
                return newMove;
            }
        }

        private bool IsValidMoveString(string move)
        {
            move = move.ToLower();
            if (specialMoveNotation.Contains(move))
                return true;
            if (move.Length == 5)
            {
                if (move[2] == '-')
                {
                    string[] squares = move.Split('-');
                    foreach (string square in squares)
                    {
                        if (!ValidSquare(square))
                        {
                            return false;
                        }
                    }
                    return true;
                }
            }
            return false;
        }

        private bool IsValidMove(Move move)
        {
            return specialMoveNotation.Contains(move.newPosition) ||(ValidSquare(move.oldPosition) && ValidSquare(move.newPosition));
        }

        private bool ValidSquare(string square)
        {
            if (square[0] >= 'a' && square[0] <= 'h')
            {
                if (int.Parse(square[1].ToString()) >= 1 && int.Parse(square[1].ToString()) <= 8)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
