using System;

class RockPaperScissors
{
    static void Main()
    {
        Console.Write("Player 1, enter Rock, Paper or Scissors: ");
        string p1 = Console.ReadLine().ToLower();

        Console.Write("Player 2, enter Rock, Paper or Scissors: ");
        string p2 = Console.ReadLine().ToLower();

        if (p1 == p2)
        {
            Console.WriteLine("It's a Tie!");
        }
        else
        {
            if (p1 == "rock")
            {
                if (p2 == "scissors")
                    Console.WriteLine("Player 1 Wins!");
                else if (p2 == "paper")
                    Console.WriteLine("Player 2 Wins!");
            }
            else if (p1 == "paper")
            {
                if (p2 == "rock")
                    Console.WriteLine("Player 1 Wins!");
                else if (p2 == "scissors")
                    Console.WriteLine("Player 2 Wins!");
            }
            else if (p1 == "scissors")
            {
                if (p2 == "paper")
                    Console.WriteLine("Player 1 Wins!");
                else if (p2 == "rock")
                    Console.WriteLine("Player 2 Wins!");
            }
            else
            {
                Console.WriteLine("Invalid input from Player 1");
            }
        }
    }
}
