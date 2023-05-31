using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to Rock, Paper, Scissors!");
        Console.WriteLine("Please choose: 1 for Rock, 2 for Paper, 3 for Scissors");

        int playerChoice = GetPlayerChoice();

        Random random = new Random();
        int computerChoice = random.Next(1,4);

        Console.WriteLine("Computer choice: " + GetChoiceName(computerChoice));
        Console.WriteLine("You choose: " + GetChoiceName(playerChoice));

        DetermineWinner(playerChoice, computerChoice);
        
        Console.ReadLine();
    }

    static int GetPlayerChoice()
    {
        int choice = 0;
        bool validChoice = false;

        while (!validChoice)
        {
            string input = Console.ReadLine();

            if(int.TryParse(input, out choice) && choice >= 1 && choice <= 3)
            {
                validChoice = true;
            } else
            {
                Console.WriteLine("Invalid choice. Please enter 1 for Rock, 2 for Paper or 3 for Scissors");
            }
        }
        return choice;

    }

    static string GetChoiceName(int choice)
    {
        switch (choice)
        {
            case 1:
                return "Rock";
            case 2:
                return "Paper";
            case 3:
                return "Scissors";
            default:
                return "Invalid";
        }
    }

    static void DetermineWinner(int playerChoice, int computerChoice)
    {
        if (playerChoice == computerChoice)
        {
            Console.WriteLine("It's a tie!");
        }
        else if ((playerChoice == 1 && computerChoice == 3) ||
                (playerChoice == 2 && computerChoice == 1) ||
                (playerChoice == 3 && computerChoice == 2))
        {
            Console.WriteLine("You win!");
        } else
        {
            Console.WriteLine("Computer wins!");
        }
    }
}