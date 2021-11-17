using System;

namespace TickTackGameWorkshop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tick Tack Toe Game");
           //creating object of TicTacToeGame class
            TicTacToeGame game = new TicTacToeGame();
            Console.WriteLine();
            //calling display method
            game.DisplayBoard();        }
    }
}
