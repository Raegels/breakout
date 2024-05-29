// The premise: Welcome to the 2024 Women's football quiz!
// Answer all the questions and fill out the grid


// Layout: Tic Tac Toe board
// Player can decide which square question to answer. There are 9 questions.

using System;

string[] arrBoard = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
int score = 0;
int questionCount = 0;

Console.WriteLine("Welcome to the 2024 women's football quiz!");
Console.WriteLine("Answer the 9 questions and find out your score!");
Console.WriteLine("Press any key to start.");
Console.ReadKey();
DrawBoard();

do
{
    Console.WriteLine("Choose a question you would like to start with by picking the corresponding number");

    string choice = Console.ReadLine();
    // implementation of all the cases of the puzzle maze
    switch (choice)
    {
        case "1":

            Console.WriteLine("Here is question number 1:");
            Console.WriteLine("How can you use four 9's to make 20?");
            string answer = Console.ReadLine();
            if (answer == "99/9+9")
            {
                Console.WriteLine("Correct!");
                Console.WriteLine("10 points!");
                arrBoard[0] = "\u2713";
                score = score + 10;
                questionCount++;

                DrawBoard();

                Console.WriteLine($"Your score is: {score}");
            }
            else
            {
                Console.WriteLine("Unfortunately, that is incorrect!");
                arrBoard[0] = "X";
                questionCount++;
                DrawBoard();
                Console.WriteLine($"Your score is: {score}");


            }
            break;

        case "2":
            Console.WriteLine("Here is question number 2:");
            Console.WriteLine("How can you use four 9's to make 20?");
            answer = Console.ReadLine();
            if (answer == "99/9+9")
            {
                Console.WriteLine("Correct!");
                Console.WriteLine("10 points!");
                arrBoard[1] = "\u2713";
                score = score + 10;
                questionCount++;
                DrawBoard();
                Console.WriteLine($"Your score is: {score}");
            }
            else
            {
                Console.WriteLine("Unfortunately, that is incorrect!");
                arrBoard[1] = "X";
                questionCount++;
                DrawBoard();
                Console.WriteLine($"Your score is: {score}");
            }
            break;

        case "3":
            Console.WriteLine("Here is question number 3:");
            Console.WriteLine("How can you use four 9's to make 20?");
            answer = Console.ReadLine();
            if (answer == "99/9+9")
            {
                Console.WriteLine("Correct!");
                Console.WriteLine("10 points!");
                arrBoard[2] = "\u2713";
                score = score + 10;
                questionCount++;
                DrawBoard();
                Console.WriteLine($"Your score is: {score}");
            }
            else
            {
                Console.WriteLine("Unfortunately, that is incorrect!");
                arrBoard[2] = "X";
                questionCount++;
                DrawBoard();
                Console.WriteLine($"Your score is: {score}");
            }
            break;

        case "4":
            Console.WriteLine("Here is question number 4:");
            Console.WriteLine("How can you use four 9's to make 20?");
            answer = Console.ReadLine();
            if (answer == "99/9+9")
            {
                Console.WriteLine("Correct!");
                Console.WriteLine("10 points!");
                arrBoard[3] = "\u2713";
                score = score + 10;
                questionCount++;
                DrawBoard();
                Console.WriteLine($"Your score is: {score}");
            }
            else
            {
                Console.WriteLine("Unfortunately, that is incorrect!");
                arrBoard[3] = "X";
                questionCount++;
                DrawBoard();
                Console.WriteLine($"Your score is: {score}");
            }
            break;

        case "5":
            Console.WriteLine("Here is question number 5:");
            Console.WriteLine("How can you use four 9's to make 20?");
            answer = Console.ReadLine();
            if (answer == "99/9+9")
            {
                Console.WriteLine("Correct!");
                Console.WriteLine("10 points!");
                arrBoard[4] = "\u2713";
                score = score + 10;
                questionCount++;
                DrawBoard();
                Console.WriteLine($"Your score is: {score}");
            }
            else
            {
                Console.WriteLine("Unfortunately, that is incorrect!");
                arrBoard[4] = "X";
                questionCount++;
                DrawBoard();
                Console.WriteLine($"Your score is: {score}");
            }
            break;

        case "6":
            Console.WriteLine("Here is question number 6:");
            Console.WriteLine("How can you use four 9's to make 20?");
            answer = Console.ReadLine();
            if (answer == "99/9+9")
            {
                Console.WriteLine("Correct!");
                Console.WriteLine("10 points!");
                arrBoard[5] = "\u2713";
                score = score + 10;
                questionCount++;
                DrawBoard();
                Console.WriteLine($"Your score is: {score}");
            }
            else
            {
                Console.WriteLine("Unfortunately, that is incorrect!");
                arrBoard[5] = "X";
                questionCount++;
                DrawBoard();
                Console.WriteLine($"Your score is: {score}");
            }
            break;

        case "7":
            Console.WriteLine("Here is question number 7:");
            Console.WriteLine("How can you use four 9's to make 20?");
            answer = Console.ReadLine();
            if (answer == "99/9+9")
            {
                Console.WriteLine("Correct!");
                Console.WriteLine("10 points!");
                arrBoard[6] = "\u2713";
                score = score + 10;
                questionCount++;
                DrawBoard();
                Console.WriteLine($"Your score is: {score}");
            }
            else
            {
                Console.WriteLine("Unfortunately, that is incorrect!");
                arrBoard[6] = "X";
                questionCount++;
                DrawBoard();
                Console.WriteLine($"Your score is: {score}");
            }
            break;

        case "8":
            Console.WriteLine("Here is question number 8:");
            Console.WriteLine("How can you use four 9's to make 20?");
            answer = Console.ReadLine();
            if (answer == "99/9+9")
            {
                Console.WriteLine("Correct!");
                Console.WriteLine("10 points!");
                arrBoard[7] = "\u2713";
                score = score + 10;
                questionCount++;
                DrawBoard();
                Console.WriteLine($"Your score is: {score}");
            }
            else
            {
                Console.WriteLine("Unfortunately, that is incorrect!");
                arrBoard[7] = "X";
                questionCount++;
                DrawBoard();
                Console.WriteLine($"Your score is: {score}");
            }
            break;

        case "9":
            Console.WriteLine("Here is question number 9:");
            Console.WriteLine("How can you use four 9's to make 20?");
            answer = Console.ReadLine();
            if (answer == "99/9+9")
            {
                Console.WriteLine("Correct!");
                Console.WriteLine("10 points!");
                arrBoard[8] = "\u2713";
                score = score + 10;
                questionCount++;
                DrawBoard();
                Console.WriteLine($"Your score is: {score}");
            }
            else
            {
                Console.WriteLine("Unfortunately, that is incorrect!");
                arrBoard[8] = "X";
                questionCount++;
                DrawBoard();
                Console.WriteLine($"Your score is: {score}");
            }
            break;

        default:
            break;
    }
} while (questionCount < 9);

double percentage = Math.Round((Convert.ToDouble(score) / 90) * 100);
Console.WriteLine(percentage);

Console.WriteLine("Congratulations on answering all the questions!");
Console.WriteLine("and thank you for taking the quiz :)");
Console.WriteLine($"Your score is {score}");
Console.WriteLine($"You answered {percentage}% correct");
Console.WriteLine("Would you like to save your score? y/n");
string saveScore = Console.ReadLine();
if (saveScore == "y")
{
    Console.WriteLine("What is your name?");
    string name = Console.ReadLine();
    Console.WriteLine($"1 \t {name} \t {percentage}%");
    Console.WriteLine($"2 \t abc \t 0%");
    Console.WriteLine($"3 \t abc \t 0%");
    Console.WriteLine($"4 \t abc \t 0%");
    Console.WriteLine($"5 \t abc \t 0%");

}
else
{
    Console.WriteLine("Thank you for playing!");
}




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