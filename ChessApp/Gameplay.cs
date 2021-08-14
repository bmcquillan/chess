using System;
using ChessApp.Models;

namespace ChessApp
{
    public class Gameplay
    {
        private GameStates game;

        public Gameplay(GameStates game)
        {
            this.game = game;
        }

        public void takeTurns()
        {
            String moveInput;
            Colour currentTurn;
            while (true) // 
            {
                currentTurn = this.game.getCurrentState().Item1;
                if (currentTurn == Colour.Black)
                {
                    Console.WriteLine("Enter black's move: ");
                }
                else
                {
                    Console.WriteLine("Enter white's move: ");
                }
                moveInput = Console.ReadLine().ToLower();

                if (moveInput.Contains("end") || moveInput.Contains("resign"))
                {
                    break;
                }

                // check if move input is syntactically valid

                    //try move

                    //validate new state

                    //

            }
            Console.WriteLine("Game over");//print winner
           
        }
    }
}
