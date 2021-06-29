using System;
using ChessApp.Models;

namespace ChessApp
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Board board = new Board();
            board.initializePieces();
            board.lazyPrint();
            board.lazyPrintPieces();
        }
    }
}
