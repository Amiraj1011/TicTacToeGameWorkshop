using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TickTackGameWorkshop
{
    public class TicTacToeGame
    {
        //declaring a char data type array of size 10 to accomodate all the 9 places in the game these are set to be empty.
        char[] board = { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };

        //displayiong the display board 
        public void DisplayBoard()
        {
            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", board[1], board[2], board[3]);

            Console.WriteLine("_____|_____|_____ ");

            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", board[4], board[5], board[6]);

            Console.WriteLine("_____|_____|_____ ");

            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", board[7], board[8], board[9]);

            Console.WriteLine("     |     |      ");
        }
    }
}
