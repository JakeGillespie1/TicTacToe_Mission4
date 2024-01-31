using TicTacToe_Mission4;

/*Initialize variables*/
string playerX = "";
string playerO = "";
string[] boardArray = new string[9];
bool gameOver = false;

/*Welcome the users to the game*/
Console.WriteLine("Welcome to the game of Tic-Tac-Toe");

/*Prompt the user to enter the player names*/
Console.WriteLine("Please enter player Xs name: ");
playerX = Console.ReadLine().ToUpper();
Console.WriteLine("Please enter player Os name: ");
playerO = Console.ReadLine().ToUpper();

/*Create the game board*/
Console.WriteLine($"Welcome {playerX} and {playerO}");
Console.WriteLine("Generating game board");
for (int i = 0; i < boardArray.Length; i++)
{
    boardArray[i] = "_";
}

//This will cause the program to pause for a third of a second (1000) three times and write 3 dots after each third
Thread.Sleep(300);
Console.WriteLine("T I C - T A C - T O E");
Console.WriteLine($"  _{boardArray[0]}_  _{boardArray[1]}_  _{boardArray[2]}_  ");
Thread.Sleep(300);
Console.WriteLine($"  _{boardArray[3]}_  _{boardArray[4]}_  _{boardArray[5]}_  ");
Thread.Sleep(300);
Console.WriteLine($"  _{boardArray[6]}_  _{boardArray[7]}_  _{boardArray[8]}_  ");
Console.WriteLine();
Console.WriteLine("Done");

/*Start gameplay*/
do
{
    /*Ask for the 2 players moves and update the game board array*/
    bool validMove = false;
    /*Player X is True and Player O is False*/
    bool playerMove = true;

    do
    {
        /*Which player is going?*/
        if (playerMove == true)
        {
            Console.WriteLine($"{playerX} what quadrant would you like to place your move in (0-9)?");
        }
        if (playerMove == false)
        {
            Console.WriteLine($"{playerX} what quadrant would you like to place your move in (0-9)?");
        }

        /*Is the selected quadrant already full?*/
        for (int i = 0;i < boardArray.Length;i++)
        {
            if (boardArray[i] != "_")
            {
                Console.WriteLine("That spot has already been taken");
            }
            else
            {
                validMove = true;
                /*Print board...*/
            }
        }
    } while (!validMove);



} while (!gameOver);



/*Call the supporting class method to print board*/

/*Check for a winner by calling class method*/
