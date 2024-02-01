using System;
using TicTacToe_Mission4;

class Program
{
    static void Main(string[] args)
    {
        bool playAgain = true;

        while (playAgain)
        {
            char[,] board = new char[3, 3]; // initialize board

            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    board[row, col] = ' ';
                }
            }

            Console.WriteLine("Welcome to tic-tac-toe");

            char currentPlayer = 'X'; // start with player x
            bool gameEnded = false; // flag to track game end

            // game loop
            while (!gameEnded)
            {
                Support.PrintBoard(board);

                Console.Write($"Player {currentPlayer}, enter your move (row and column separated by a space:");
                string[] input = Console.ReadLine().Split();
                int row = int.Parse(input[0]) - 1;
                int col = int.Parse(input[1]) - 1;

                if (row >= 0 && row < 3 && col >= 0 && col < 3 && board[row, col] == ' ')
                {
                    board[row, col] = currentPlayer;


                    char winner = Support.CheckForWinner(board);
                    if (winner != ' ')
                    {
                        Support.PrintBoard(board);

                        Console.WriteLine($"Player {winner} wins!");
                        gameEnded = true;

                    }
                    else if (IsBoardFull(board))
                    {
                        Support.PrintBoard(board);

                        Console.WriteLine("Draw!");
                        gameEnded = true;
                    }
                    else
                    {
                        currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
                    }
                }
                else
                {

                    Console.WriteLine("Invalid move. Try again. ");
                }
            }
            Console.WriteLine("Do you want to play again? (yes/no)");
            string playAgainInput = Console.ReadLine().ToLower();
            playAgain = (playAgainInput == "yes" || playAgainInput == "y");
        }
        Console.WriteLine("Thanks for playin");
    } 
    static bool IsBoardFull(char[,] board)
    {
        for(int row = 0; row < 3; row++)
        {
            for(int col = 0; col < 3; col++)
            {
                if (board[row, col] == ' ')
                {
                    return false;
                }
            }
        }
        return true;
    }
}