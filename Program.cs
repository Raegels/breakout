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
    Console.WriteLine("Choose a question by picking the corresponding number");

    string choice = Console.ReadLine();
    // implementation of all the cases of the puzzle maze
    switch (choice)
    {
        case "1":

            Console.WriteLine("Here is question number 1:");
            Console.WriteLine("Who is the Netherlands top-scorer of all time?");
            string answer = Console.ReadLine();
            if (answer == "Vivianne Miedema" || answer == "vivianne miedema")
            {
                arrBoard[0] = "\u2713";
                correctAnswer();
            }
            else
            {
                arrBoard[0] = "X";
                incorrectAnswer();
            }
            break;

        case "2":
            Console.WriteLine("Here is question number 2:");
            Console.WriteLine("Who won the Nation's league in 2024? Spain, Germany, the Netherlands or France?");
            answer = Console.ReadLine();
            if (answer == "Spain" || answer == "spain")
            {
                arrBoard[1] = "\u2713";
                correctAnswer();
            }
            else
            {
                arrBoard[1] = "X";
                incorrectAnswer();
            }
            break;

        case "3":
            Console.WriteLine("Here is question number 3:");
            Console.WriteLine("Who won the Champions League in 2024?");
            answer = Console.ReadLine();
            if (answer == "Barcelona" || answer == "barcelona")
            {
                arrBoard[2] = "\u2713";
                correctAnswer();
            }
            else
            {
                arrBoard[2] = "X";
                incorrectAnswer();
            }
            break;

        case "4":
            Console.WriteLine("Here is question number 4:");
            Console.WriteLine("Who is the current Head Coach of the English national team? Wiegman, Sampson or Neville?");
            answer = Console.ReadLine();
            if (answer == "Wiegman" || answer == "wiegman")
            {

                arrBoard[3] = "\u2713";
                correctAnswer();
            }
            else
            {
                arrBoard[3] = "X";
                incorrectAnswer();
            }
            break;

        case "5":
            Console.WriteLine("Here is question number 5:");
            Console.WriteLine("In what year was the first European Championship hosted?");
            answer = Console.ReadLine();
            if (answer == "1984")
            {
                arrBoard[4] = "\u2713";
                correctAnswer();
            }
            else
            {
                arrBoard[4] = "X";
                incorrectAnswer();
            }
            break;

        case "6":
            Console.WriteLine("Here is question number 6:");
            Console.WriteLine("How many times did the USA win the World Cup?");
            answer = Console.ReadLine();
            if (answer == "4")
            {

                arrBoard[5] = "\u2713";
                correctAnswer();
            }
            else
            {

                arrBoard[5] = "X";
                incorrectAnswer();
            }
            break;

        case "7":
            Console.WriteLine("Here is question number 7:");
            Console.WriteLine("What is the most common  high-burden injury in women's football?");
            answer = Console.ReadLine();
            if (answer == "ACL" || answer == "ACL tear" || answer == "acl" || answer == "acl tear")
            {

                arrBoard[6] = "\u2713";
                correctAnswer();
            }
            else
            {
                arrBoard[6] = "X";
                incorrectAnswer();
            }
            break;

        case "8":
            Console.WriteLine("Here is question number 8:");
            Console.WriteLine("Where will the World cup of 2025 be hosted? The Netherlands, Germany or Brasil?");
            answer = Console.ReadLine();
            if (answer == "Brasil" || answer == "brasil")
            {

                arrBoard[7] = "\u2713";
                correctAnswer();
            }
            else
            {

                arrBoard[7] = "X";
                incorrectAnswer();
            }
            break;

        case "9":
            Console.WriteLine("Here is question number 9:");
            Console.WriteLine("With which number does, best player of the world, Aitana Bonmati play?");
            answer = Console.ReadLine();
            if (answer == "14")
            {
                arrBoard[8] = "\u2713";
                correctAnswer();
            }
            else
            {
                arrBoard[8] = "X";
                incorrectAnswer();
            }
            break;

        default:
            break;
    }
} while (questionCount < 9);

double percentage = Math.Round((Convert.ToDouble(score) / 90) * 100);

Console.WriteLine("Congratulations on answering all the questions!");
Console.WriteLine("and thank you for taking the quiz :)");
Console.WriteLine();
Console.WriteLine($"Your score is {score}");
Console.WriteLine($"You answered {percentage}% correct");
Console.WriteLine();
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

//Method for correct answer

void correctAnswer()
{
    Console.WriteLine();
    Console.WriteLine("Correct!");
    Console.WriteLine("10 points!");
    Console.WriteLine();
    score += 10;
    questionCount++;

    DrawBoard();
    Console.WriteLine();
    Console.WriteLine($"Your score is: {score}");
    Console.WriteLine();


}


//Method for incorrect answer

void incorrectAnswer()
{

    Console.WriteLine("Unfortunately, that is incorrect!");
    questionCount++;
    DrawBoard();
    Console.WriteLine();
    Console.WriteLine($"Your score is: {score}");
    Console.WriteLine();
}