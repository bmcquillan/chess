using System;
using ChessApp.BusinessLogic;
using ChessApp.IoC;
using ChessApp.Models;
using Ninject;

namespace ChessApp
{
    class Program
    {
       
        static void Main(string[] args)
        {
            var _kernel = new StandardKernel();
            _kernel.Load(new ChessModule());

            var game = _kernel.Get<IGameplay>();
            Console.WriteLine("Hello World!");
            Board board = new Board();
            board.initializePieces();
            board.PrintBoard();

            game.takeTurns();

        }
    }
}
