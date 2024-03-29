﻿using System;
using TicTacToe_Mission4;

class Program
{
    static void Main(string[] args)
    {
        bool playAgain = true;
        while (playAgain)
        {
            char[,] board = new char[3, 3]; // initialize board, making a 2d array 

            for (int row = 0; row < 3; row++) // for loop creating the spaces for the symbols
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
                bool validInput = false;
                int row = -1;
                int col = -1;

                while(!validInput)
                {
                    // splits the coordinates, and sets it back by 1 because arrays start with 0
                    Console.Write($"Player {currentPlayer}, enter your move (row and column separated by a space):");
                    string[] input = Console.ReadLine().Split();

                    // check to make sure that the user put numbers and not letters
                    try
                    {
                        row = int.Parse(input[0]) - 1;
                        col = int.Parse(input[1]) - 1;

                        validInput = true;
                        if (input.Length > 2)
                        {
                            validInput = false;
                            Console.WriteLine("Please enter just two numbers, separated by a space");
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Please enter row and column number separated by a space");
                    }
                }

                if (row >= 0 && row < 3 && col >= 0 && col < 3 && board[row, col] == ' ') 
                    // checks to make sure the user put in a valid coordinate, and ensures that there is an empty space
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
                        currentPlayer = (currentPlayer == 'X') ? 'O' : 'X'; // switches players using ternary operator
                    }
                }
                else
                {

                    Console.WriteLine("Invalid move. Try again. ");
                }
            }
            Console.WriteLine("Do you want to play again? (yes/no)"); // allows players to play again
            string playAgainInput = Console.ReadLine().ToLower();
            playAgain = (playAgainInput == "yes" || playAgainInput == "y");
        }
        Console.WriteLine("Thanks for playing");
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
