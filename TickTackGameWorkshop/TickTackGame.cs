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
        char player, computer;

        //displayiong the display board 
        public string DisplayBoard()
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
            return "true";
        }

        public void SelectLetter()
        {
            Console.WriteLine("Please choose which letter you want to take-- X or O");
            char letter = Convert.ToChar(Console.ReadLine());
            if (letter == 'X')
            {
                player = 'X';
                computer = 'O';
            }
            else if (letter == 'O') 
            {
                player = 'O';
                computer = 'X';
            }
            else
            {
                Console.WriteLine("Please Enter O or X letter only");

            }
            Console.WriteLine("Player has chosen {0} and computer {1}", player, computer);


        }
        public void Position()
        {
            while (true)
            {
                DisplayBoard();
                Console.WriteLine("Enter position from 1 to 9 ");
                Console.WriteLine("Enter position you want to mark : ");
                int choicePosition = Convert.ToInt32(Console.ReadLine());

                board[choicePosition] = 'X';
            }

        }

    }
}
