// Phase 8

// The program should be updated to...

//     Add a difficulty level of "Cheater" which will cause the program to continue prompting the user until they get the answer correct.


Random rnd = new Random();
string userGuess;
int userInt;
int secretNumber = rnd.Next(1, 100);
string highLowMessage;
int guessCount = 0;
string difficultyLevel;
int maxGuesses = 0;
string guessesRemaining;

Console.WriteLine("Choose your difficulty level:");
Console.WriteLine("Enter 1: Easy");
Console.WriteLine("Enter 2: Medium");
Console.WriteLine("Enter 3: Difficult");
Console.WriteLine("Enter 4: Cheater");

difficultyLevel = Console.ReadLine();

switch (difficultyLevel)
{
    case "1":
        maxGuesses = 8;
        break;
    case "2":
        maxGuesses = 6;
        break;
    case "3":
        maxGuesses = 4;
        break;
    case "4":
        maxGuesses = -1;
        break;

    default:
        Console.WriteLine("You didn't enter 1, 2, or 3");
        break;

}


while (guessCount != maxGuesses)
{
    try
    {

        guessesRemaining = maxGuesses == -1 ? "Please enter an integer. You have infinite guesses: " : $"Please enter an integer.  You have {maxGuesses - guessCount} guess(es) left.";

        Console.Write(guessesRemaining);

        userGuess = Console.ReadLine();

        userInt = int.Parse(userGuess);


        if (userInt == secretNumber)
        {
            Console.WriteLine("You guessed the secret number.  Good job!");
            break;
        }
        else
        {
            highLowMessage = userInt < secretNumber ? "Your guess was too low." : "Your guess was too high.";

            Console.WriteLine(highLowMessage);
        }


    }
    catch
    {
        Console.WriteLine("Hey loser, you need to input an integer!");

    }

    guessCount++;

}


