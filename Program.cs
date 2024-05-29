// The premise: Welcome to Breakout!
// Find your way out of the maze through answering a series of puzzle questions.
// Fill the entire board with correct answers to breakout of the puzzle Maze!


// Layout: Tic Tac Toe board
// Player can decide which square question to answer. There are 9 questions, in varying difficulties.

using System;

string[] arrBoard = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };

Console.WriteLine("Welcome to Breakout!");
Console.WriteLine("Answer all 9 puzzle questions correctly to breakout of the puzzle maze!");
Console.WriteLine("Press any key to start.");
Console.ReadKey();
DrawBoard();
Console.WriteLine("Choose a puzzle you would like to start with by picking the corresponding number");


//Method will draw the puzzle maze board
void DrawBoard()
{
    Console.WriteLine("---------");
    for (int i = 0; i < 3; i++)
    {

        for (int j = 0; j < 3; j++)
        {
            Console.Write("|" + arrBoard[i * 3 + j] + "|");

        }
        Console.WriteLine();
        Console.WriteLine("---------");
    }
}