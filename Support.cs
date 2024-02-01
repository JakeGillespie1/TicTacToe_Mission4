using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_Mission4
{
    public class Support
    {
        public static void PrintBoard(char[,] board)
        {
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Console.Write(board[row, col]); 
                    if (col <2)
                    {
                        Console.Write(" | ");
                    }
                }
                Console.WriteLine();
                if (row <2) 
                {
                    Console.WriteLine("-------------");
                }
            }
        }
        public static char CheckForWinner(char[,] board)
        {
            for (int i=0; i < 3; i++)
            {
                // check rows
                if (board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2] && board[i, 0] != ' ')
                {
                    return board[i, 0]; // return the winning symbol
                }
                // check columns
                if (board[0, i] == board[1, i] && board[1, i] == board[2, i] && board[0, i] != ' ')
                {
                    return board[0, i]; // return the winning symbol
                }
            }
            // check diagonals
            if ((board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2] && board[0, 0] != ' ') ||
                (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0] && board[0, 2] != ' '))
            {
                return board[1, 1];

            }

            return ' ';
        }
    }
}
