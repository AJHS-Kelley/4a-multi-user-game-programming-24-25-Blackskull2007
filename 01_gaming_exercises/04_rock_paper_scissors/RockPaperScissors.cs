using System;

class Template {

  static void Main() {
    //PLAYER VARIABLE
    string playerName = "Test Player";
    int playerScore = 0;
    string playerChoice = "";

    //CPU VARIABLES
    int cpuScore = 0;
    string cpuChoice = "";

    Console.WriteLine("Welcome to the rock, Paper, scissors Bot!\n");
    Console.WriteLine("Please type your name and press ENTER\n");
    playerName = Console.ReadLine();
    Console.WriteLine($"Hello {playerName}. Is that correct?\n");
    Console.WriteLine("Please type yes or no, then press enter.\n");
    String isCorrect = Console.ReadLine().ToLower();

    if (isCorrect == "yes")
    {
      Console.WriteLine ($"Great! I'll call you {playerName}.\n");
    }
    else if(isCorrect == "no")
    {
      Console.WriteLine("Please type our name and press ENTER.\n");
      playerName = Console.ReadLine();
    }
    else
    {
      Console.WriteLine("Unable to determine answer. Try again.\n");
    }

    Console.WriteLine("""
    +===========================================================+
    |                                                           |
    |      WELCOME TO THE rock, PAPER, scissors CHALLENGE!      |
    +===========================================================+
    You will select fromrock, Paper, scissors.
    The CPU will select one of those choices at random.
    Then a winner will be determined usinfg the following rules:
    --rock Beats scissors
    --Paper Beats rock
    --scissors Beats Paper

    The winner will receive a point.
    The first player to score 5 points will be declared the winner.
    """);


    Random rnd = new Random();
    while (playerScore < 5 && cpuScore <5)
    {
      //Print the scores
      Console.WriteLine($"Your score: {playerScore}\n Opponents: {cpuScore}");
      //Let the player selecty R, P, S
      Console.WriteLine("Please choose rock, paper, or scissors. Type your answer and press answer\n");
      playerChoice = Console.ReadLine().ToLower();
      if (playerChoice != "rock" && playerChoice != "paper" & playerChoice != "scissors")
      {
        Console.WriteLine("Please choose rock, paper, or scissors. Type your answer and press enter.\n");
        playerChoice = Console.ReadLine().ToLower();
      }
      //Allow CPU to select radomly
      int cpuRand = rnd.Next(1,3);
      if (cpuRand == 1)
      {
        cpuChoice = "rock";
      }
      else if (cpuRand == 2)
      {
        cpuChoice = "paper";
      }
      else if (cpuRand == 3)
      {
        cpuChoice = "scissors";
      }
      else
      {
        Console.WriteLine("Unable to determine CPU choice.\n");
      }
      Console.WriteLine("CPU Choice" + cpuChoice);

      //Compare the two choices and determine a winner
      if (playerChoice == "rock" && cpuChoice == "paper")
      {
        Console.WriteLine($"You chose {playerChoice} and the CPU chose {cpuChoice}.\n");
        Console.WriteLine("The CPU wins!\n");
        cpuScore++;
      }
      else if (playerChoice == "rock" && cpuChoice == "scissors")
      {
        Console.WriteLine($"You chose {playerChoice} and the CPU chose {cpuChoice}.\n");
        Console.WriteLine("You win!\n");
        playerScore++;
      }
      else if (playerChoice == "rock" && cpuChoice == "rock")
      {
        Console.WriteLine($"You chose {playerChoice} and the CPU chose {cpuChoice}.\n");
        Console.WriteLine("It's a draw!\n");
      }
      else if (playerChoice == "paper" && cpuChoice == "paper")
      {
        Console.WriteLine($"You chose {playerChoice} and the CPU chose {cpuChoice}.\n");
        Console.WriteLine("It's a draw!\n");
      }
      else if (playerChoice == "paper" && cpuChoice == "rock")
      {
        Console.WriteLine($"You chose {playerChoice} and the CPU chose {cpuChoice}.\n");
        Console.WriteLine("You win!\n");
        playerScore++;
      }
      else if (playerChoice == "paper" && cpuChoice == "scissors")
      {
        Console.WriteLine($"You chose {playerChoice} and the CPU chose {cpuChoice}.\n");
        Console.WriteLine("The CPU wins!\n");
        cpuScore++;
      }
      else if (playerChoice == "scissors" && cpuChoice == "rock")
      {
        Console.WriteLine($"You chose {playerChoice} and the CPU chose {cpuChoice}.\n");
        Console.WriteLine("The CPU wins!\n");
        cpuScore++;
      }
      else if (playerChoice == "scissors" && cpuChoice == "scissors")
      {
        Console.WriteLine($"You chose {playerChoice} and the CPU chose {cpuChoice}.\n");
        Console.WriteLine("It's a draw!\n");
      }
      else if (playerChoice == "scissors" && cpuChoice == "paper")
      {
        Console.WriteLine($"You chose {playerChoice} and the CPU chose {cpuChoice}.\n");
        Console.WriteLine("You win\n");
        playerScore++;
      }

      if (playerScore > cpuScore)
      {
        Console.WriteLine("Congratultions, you're the winner!\n");
      }
      else
      {
        Console.WriteLine("The CPU has defeated you.\n");
      }
    }
  }
}