while (true)
{
    Console.WriteLine("Type Rock, Paper or Scissors:");
    string input = Console.ReadLine();

    if (Enum.TryParse(input, out RPS enumValue))
    {
        Random random = new Random();
        RPS rps = (RPS)random.Next(0, 3);
        Console.WriteLine("Computer chose- " + rps.ToString());

        if (rps == enumValue)
        {
            Console.WriteLine("Draw");
        }
        else if (rps == enumValue + 1 || rps == enumValue - 2)
        {
            Console.WriteLine("Computer wins");

        }
        else
        {
            Console.WriteLine("You win");
        }

    }
    else
    {
        Console.WriteLine("Invalid Input!!");
    }

    Console.WriteLine("Do you want to play again?(Y/N)");
    string choice = Console.ReadLine();

    if (choice != "Y")
    {
        break;
    }
}


enum RPS
{
    Rock, Paper, Scissors
}
